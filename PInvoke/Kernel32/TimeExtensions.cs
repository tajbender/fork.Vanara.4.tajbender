﻿namespace Vanara.PInvoke;

public static partial class Kernel32
{
	/// <summary>Convert a <see cref="SYSTEMTIME"/> value to a <see cref="FILETIME"/> value.</summary>
	/// <param name="st">The <see cref="SYSTEMTIME"/> value.</param>
	/// <returns>The converted <see cref="FILETIME"/> value.</returns>
	public static FILETIME ToFILETIME(this SYSTEMTIME st)
	{
		Win32Error.ThrowLastErrorIfFalse(SystemTimeToFileTime(st, out var ft));
		return ft;
	}

	/// <summary>Convert a <see cref="FILETIME"/> value to a <see cref="SYSTEMTIME"/> value.</summary>
	/// <param name="ft">The <see cref="FILETIME"/> value.</param>
	/// <returns>The converted <see cref="SYSTEMTIME"/> value.</returns>
	public static SYSTEMTIME ToSYSTEMTIME(this FILETIME ft)
	{
		Win32Error.ThrowLastErrorIfFalse(FileTimeToSystemTime(ft, out var st));
		return st;
	}
}