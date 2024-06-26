﻿using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using static Vanara.PInvoke.DbgHelp;
using static Vanara.PInvoke.ImageHlp;
using static Vanara.PInvoke.Kernel32;

namespace Vanara.PInvoke.Tests;

[TestFixture, SingleThreaded]
public class DbgHelpTests
{
	const string imgName = "imagehlp.dll";
	const string testAppName = "TestDbgApp";
	static readonly string testAppPath = TestCaseSources.TempDirWhack + testAppName + ".exe";
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
	//private Process testApp;
	private ProcessSymbolHandler hProc;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

	[OneTimeSetUp]
	public void _Setup()
	{
		//testApp = Process.Start(new ProcessStartInfo(testAppPath) { WindowStyle = ProcessWindowStyle.Minimized })!;
		//hProc = new ProcessSymbolHandler(testApp.Handle, SYMOPT.SYMOPT_UNDNAME | SYMOPT.SYMOPT_DEFERRED_LOADS);
		hProc = new ProcessSymbolHandler(testAppPath);
	}

	[OneTimeTearDown]
	public void _TearDown()
	{
		hProc.Dispose();
		//testApp.Kill();
	}

	[Test]
	public void EnumDirTreeTest()
	{
		var output = EnumDirTree(HPROCESS.NULL, Environment.GetFolderPath(Environment.SpecialFolder.Windows), imgName);
		Assert.That(output, Is.Not.Empty);
		TestContext.WriteLine($"Count: {output.Count}");
		output.WriteValues();
	}

	[Test]
	public void EnumerateLoadedModulesTest()
	{
		var output = EnumerateLoadedModules(Process.GetCurrentProcess().Handle);
		Assert.That(output, Is.Not.Empty);
		TestContext.WriteLine($"Count: {output.Count}");
		output.WriteValues();
	}

	[Test]
	public void EnumerateLoadedModulesExTest()
	{
		var output = EnumerateLoadedModulesEx(Process.GetCurrentProcess().Handle);
		Assert.That(output, Is.Not.Empty);
		TestContext.WriteLine($"Count: {output.Count}");
		output.WriteValues();
	}

	[Test]
	public void FindExecutableImageExTest()
	{
		Assert.That(FindExecutableImageEx(imgName, new[] { Environment.GetFolderPath(Environment.SpecialFolder.System), TestCaseSources.TempDir }), ResultIs.Not.Value(null));
	}

	[Test]
	public void ImagehlpApiVersionTest()
	{
		Assert.That(ImagehlpApiVersion().MajorVersion, Is.GreaterThan((ushort)0));
	}

	[Test]
	public unsafe void GetImageConfigInformationTest()
	{
		LOADED_IMAGE_UNSAFE LoadedImage = default;
		Assert.That(MapAndLoad(imgName, null, &LoadedImage, true, true), ResultIs.Successful);
		try
		{
			var data = ImageDirectoryEntryToData(LoadedImage.MappedAddress, false, IMAGE_DIRECTORY_ENTRY.IMAGE_DIRECTORY_ENTRY_EXPORT, out var cDirSize); // (_IMAGE_EXPORT_DIRECTORY*)
			Assert.That(data, ResultIs.ValidHandle);
			var ImageExportDirectory = data.ToStructure<IMAGE_EXPORT_DIRECTORY>(cDirSize);
			ImageExportDirectory.WriteValues();
			var addr = ImageRvaToVa(LoadedImage.FileHeader, LoadedImage.MappedAddress, ImageExportDirectory.AddressOfNames, out _); // (uint*)
			Assert.That(addr, ResultIs.ValidHandle);
			foreach (var rva in addr.ToArray<uint>((int)ImageExportDirectory.NumberOfNames)!)
			{
				var sName = ImageRvaToVa(LoadedImage.FileHeader, LoadedImage.MappedAddress, rva, out _);
				TestContext.WriteLine(Marshal.PtrToStringAnsi(sName) ?? "(null)");
			}
		}
		finally
		{
			UnMapAndLoad(&LoadedImage);
		}
	}

	[Test]
	public void SymEnumerateModulesTest()
	{
		Thread.Sleep(500);
		var output = SymEnumerateModules(hProc);
		TestContext.WriteLine($"Count: {output.Count}");
		output.WriteValues();
	}

	[Test]
	public void SymEnumLinesTest()
	{
		var (_, BaseOfDll) = SymEnumerateModules(hProc).First();
		var output = SymEnumLines(hProc, unchecked((ulong)BaseOfDll.ToInt64()));
		TestContext.WriteLine($"Count: {output.Count}");
		output.WriteValues();
	}

	[Test]
	public void SymEnumProcessesTest()
	{
		Assert.That(SymEnumProcesses(), Is.Not.Empty);
	}

	[Test]
	public void SymEnumSymbolsExTest()
	{
		using var fakeProc = new ProcessSymbolHandler(new IntPtr(1), null, false);
		var pdbBase = SymLoadModuleEx(fakeProc, default, @"C:\Windows\System32\ntdll.dll");
		var list = SymEnumSymbolsEx(fakeProc, pdbBase);
		Assert.That(list, Is.Not.Empty);
		foreach (var i in list.OrderBy(i => i.Index))
			TestContext.WriteLine($"{i.Index,3}) {i.Name}");
	}

	[Test]
	public void SymFromIndexTest()
	{
		using var fakeProc = new ProcessSymbolHandler(new IntPtr(1), null, false);
		var pdbBase = SymLoadModuleEx(fakeProc, default, @"C:\Windows\System32\ntdll.dll");
		var si = SYMBOL_INFO.Default;
		Assert.That(SymFromIndex(fakeProc, pdbBase, 1, ref si), ResultIs.Successful);
		si.WriteValues();
	}

	[Test]
	public void SymFromNameTest()
	{
		SYMBOL_INFO si = SYMBOL_INFO.Default;
		Assert.That(SymFromName(hProc, "strcat", ref si), ResultIs.Successful);
		si.WriteValues();
	}

	[Test]
	public unsafe void SymGetOmapsTest()
	{
		var (_, BaseOfDll) = SymEnumerateModules(hProc, true).First();
		SymGetOmaps(hProc, unchecked((ulong)BaseOfDll.ToInt64()), out _, out var t, out _, out var f);
		Assert.That((uint)Win32Error.GetLastError(), Is.EqualTo(Win32Error.ERROR_NOT_FOUND).Or.EqualTo(Win32Error.ERROR_SUCCESS));
	}

	[Test]
	public void SymGetSymFromNameTest()
	{
		using var sym = new SafeIMAGEHLP_SYMBOL();
		Assert.That(SymGetSymFromName(hProc, "strcat", sym), ResultIs.Successful);
		sym.Value.WriteValues();
	}

	[Test]
	public void SymGetSymFromName64Test()
	{
		ulong addr = 0;
		using (var sym = new SafeIMAGEHLP_SYMBOL64())
		{
			Assert.That(SymGetSymFromName64(hProc, "strcat", sym), ResultIs.Successful);
			sym.Value.WriteValues();
			Assert.That(sym.Value.Name, Is.EqualTo("strcat"));
			addr = sym.Value.Address;
		}

		using (var sym = new SafeIMAGEHLP_SYMBOL64())
		{
			Assert.That(SymGetSymFromAddr64(hProc, addr, out var displ, sym), ResultIs.Successful);
			sym.Value.WriteValues();
			Assert.That(sym.Value.Name, Is.EqualTo("strcat"));
		}
	}

	[Test]
	public unsafe void MimicDllExp()
	{
		LOADED_IMAGE_UNSAFE LoadedImage = default;
		Assert.That(MapAndLoad(imgName, null, &LoadedImage, true, true), ResultIs.Successful);
		try
		{
			var data = ImageDirectoryEntryToData(LoadedImage.MappedAddress, false, IMAGE_DIRECTORY_ENTRY.IMAGE_DIRECTORY_ENTRY_EXPORT, out var cDirSize); // (_IMAGE_EXPORT_DIRECTORY*)
			Assert.That(data, ResultIs.ValidHandle);
			var ImageExportDirectory = data.ToStructure<IMAGE_EXPORT_DIRECTORY>(cDirSize);
			ImageExportDirectory.WriteValues();

			var addr = ImageRvaToVa(LoadedImage.FileHeader, LoadedImage.MappedAddress, ImageExportDirectory.AddressOfNames, out _); // (uint*)
			Assert.That(addr, ResultIs.ValidHandle);
			uint[] rnameaddrs = addr.ToArray<uint>((int)ImageExportDirectory.NumberOfNames)!;

			addr = ImageRvaToVa(LoadedImage.FileHeader, LoadedImage.MappedAddress, ImageExportDirectory.AddressOfNameOrdinals, out _); // (uint*)
			Assert.That(addr, ResultIs.ValidHandle);
			uint[] rordaddrs = addr.ToArray<uint>((int)ImageExportDirectory.NumberOfNames)!;

			for (int i = 0; i < rnameaddrs.Length; i++)
			{
				var sName = Marshal.PtrToStringAnsi(ImageRvaToVa(LoadedImage.FileHeader, LoadedImage.MappedAddress, rnameaddrs[i], out _));
				var ord = ImageRvaToVa(LoadedImage.FileHeader, LoadedImage.MappedAddress, rordaddrs[i], out _).ToNullableStructure<uint>();
				TestContext.WriteLine($"{sName ?? (null)}\t0x{ord ?? 0}");
			}
		}
		finally
		{
			UnMapAndLoad(&LoadedImage);
		}
	}

	[Test]
	public void MiniDumpCallbackOrderTest()
	{
		try
		{
			// Load an exception into the system tables
			throw new InvalidOperationException();
		}
		catch
		{
			// Test for debug exception info
			var memCallbackCalled = false;
			using var hFile = CreateFile("CallbackOrder.dmp", Kernel32.FileAccess.GENERIC_READ | Kernel32.FileAccess.GENERIC_WRITE, 0, default, FileMode.Create, FileFlagsAndAttributes.FILE_ATTRIBUTE_NORMAL);
			if (!hFile.IsInvalid)
			{
				var mdei = new MINIDUMP_EXCEPTION_INFORMATION
				{
					ThreadId = GetCurrentThreadId(),
					ExceptionPointers = Marshal.GetExceptionPointers()
				};

				var mci = new MINIDUMP_CALLBACK_INFORMATION { CallbackRoutine = MyMiniDumpCallback };

				Assert.That(MiniDumpWriteDump(GetCurrentProcess(), GetCurrentProcessId(), hFile, MINIDUMP_TYPE.MiniDumpNormal, mdei, default, mci), ResultIs.Successful);
			}

			bool MyMiniDumpCallback([In, Out] IntPtr CallbackParam, in MINIDUMP_CALLBACK_INPUT CallbackInput, ref MINIDUMP_CALLBACK_OUTPUT CallbackOutput)
			{
				TestContext.Write($"{CallbackInput.CallbackType} ");
				switch (CallbackInput.CallbackType)
				{
					case MINIDUMP_CALLBACK_TYPE.ModuleCallback:
						TestContext.WriteLine($"(module: {CallbackInput.Module.FullPath})");
						return true;
					case MINIDUMP_CALLBACK_TYPE.ThreadCallback:
						TestContext.WriteLine($"(thread: {CallbackInput.Thread.ThreadId:X})");
						return true;
					case MINIDUMP_CALLBACK_TYPE.ThreadExCallback:
						TestContext.WriteLine($"(thread: {CallbackInput.ThreadEx.ThreadId:X})");
						return true;
					case MINIDUMP_CALLBACK_TYPE.IncludeThreadCallback:
						TestContext.WriteLine($"(thread: {CallbackInput.IncludeThread.ThreadId:X})");
						return true;
					case MINIDUMP_CALLBACK_TYPE.IncludeModuleCallback:
						TestContext.WriteLine($"(module: {CallbackInput.IncludeModule.BaseOfImage:X})");
						return true;
					case MINIDUMP_CALLBACK_TYPE.MemoryCallback:
						memCallbackCalled = true;
						TestContext.WriteLine("");
						return false;
					case MINIDUMP_CALLBACK_TYPE.CancelCallback:
						CallbackOutput.Cancel = false;
						CallbackOutput.CheckCancel = !memCallbackCalled;
						TestContext.WriteLine("");
						return true;
					default:
						TestContext.WriteLine("");
						return false;
				}
			}
		}
	}
}