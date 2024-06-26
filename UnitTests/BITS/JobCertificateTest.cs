﻿using System.Security.Cryptography.X509Certificates;

namespace Vanara.PInvoke.Tests;

internal partial class BackgroundCopyTests
{
	[Test]
	public void JobCertificateTest()
	{
		using var job = BackgroundCopyManager.Jobs.Add(GetCurrentMethodName() ?? Guid.NewGuid().ToString());
		Assert.That(job, Is.Not.Null);
		Assert.That(job?.Certificate, Is.Null);

		using var store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
		store.Open(OpenFlags.ReadOnly);
		var c = store.Certificates.Cast<X509Certificate2>().FirstOrDefault();
		Assert.That(c, Is.Not.Null);

		job!.SetCertificate(store, c!);
		Assert.That(job.Certificate, Is.EqualTo(c));
	}
}