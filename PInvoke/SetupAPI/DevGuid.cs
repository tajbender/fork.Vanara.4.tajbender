namespace Vanara.PInvoke;

/// <summary>Items from the SetupAPI.dll</summary>
public static partial class SetupAPI
{
	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_1394 = new(0x6bdd1fc1, 0x810f, 0x11d0, 0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_1394DEBUG = new(0x66f250d6, 0x7801, 0x4a64, 0xb1, 0x39, 0xee, 0xa8, 0x0a, 0x45, 0x0b, 0x24);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_61883 = new(0x7ebefbc0, 0x3200, 0x11d2, 0xb4, 0xc2, 0x00, 0xa0, 0xc9, 0x69, 0x7d, 0x07);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_ADAPTER = new(0x4d36e964, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_APMSUPPORT = new(0xd45b1c18, 0xc8fa, 0x11d1, 0x9f, 0x77, 0x00, 0x00, 0xf8, 0x05, 0xf5, 0x30);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_AVC = new(0xc06ff265, 0xae09, 0x48f0, 0x81, 0x2c, 0x16, 0x75, 0x3d, 0x7c, 0xba, 0x83);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_BATTERY = new(0x72631e54, 0x78a4, 0x11d0, 0xbc, 0xf7, 0x00, 0xaa, 0x00, 0xb7, 0xb3, 0x2a);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_BIOMETRIC = new(0x53d29ef7, 0x377c, 0x4d14, 0x86, 0x4b, 0xeb, 0x3a, 0x85, 0x76, 0x93, 0x59);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_BLUETOOTH = new(0xe0cbf06c, 0xcd8b, 0x4647, 0xbb, 0x8a, 0x26, 0x3b, 0x43, 0xf0, 0xf9, 0x74);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_CAMERA = new(0xca3e7ab9, 0xb4c3, 0x4ae6, 0x82, 0x51, 0x57, 0x9e, 0xf9, 0x33, 0x89, 0x0f);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_CDROM = new(0x4d36e965, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_COMPUTEACCELERATOR = new(0xf01a9d53, 0x3ff6, 0x48d2, 0x9f, 0x97, 0xc8, 0xa7, 0x00, 0x4b, 0xe1, 0x0c);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_COMPUTER = new(0x4d36e966, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_DECODER = new(0x6bdd1fc2, 0x810f, 0x11d0, 0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_DISKDRIVE = new(0x4d36e967, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_DISPLAY = new(0x4d36e968, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_DOT4 = new(0x48721b56, 0x6795, 0x11d2, 0xb1, 0xa8, 0x00, 0x80, 0xc7, 0x2e, 0x74, 0xa2);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_DOT4PRINT = new(0x49ce6ac8, 0x6f86, 0x11d2, 0xb1, 0xe5, 0x00, 0x80, 0xc7, 0x2e, 0x74, 0xa2);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_EHSTORAGESILO = new(0x9da2b80f, 0xf89f, 0x4a49, 0xa5, 0xc2, 0x51, 0x1b, 0x08, 0x5b, 0x9e, 0x8a);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_ENUM1394 = new(0xc459df55, 0xdb08, 0x11d1, 0xb0, 0x09, 0x00, 0xa0, 0xc9, 0x08, 0x1f, 0xf6);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_EXTENSION = new(0xe2f84ce7, 0x8efa, 0x411c, 0xaa, 0x69, 0x97, 0x45, 0x4c, 0xa4, 0xcb, 0x57);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FDC = new(0x4d36e969, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FIRMWARE = new(0xf2e7dd72, 0x6468, 0x4e36, 0xb6, 0xf1, 0x64, 0x88, 0xf4, 0x2c, 0x1b, 0x52);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FLOPPYDISK = new(0x4d36e980, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_ACTIVITYMONITOR = new(0xb86dff51, 0xa31e, 0x4bac, 0xb3, 0xcf, 0xe8, 0xcf, 0xe7, 0x5c, 0x9f, 0xc2);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_ANTIVIRUS = new(0xb1d1a169, 0xc54f, 0x4379, 0x81, 0xdb, 0xbe, 0xe7, 0xd8, 0x8d, 0x74, 0x54);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_BOTTOM = new(0x37765ea0, 0x5958, 0x4fc9, 0xb0, 0x4b, 0x2f, 0xdf, 0xef, 0x97, 0xe5, 0x9e);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_CFSMETADATASERVER = new(0xcdcf0939, 0xb75b, 0x4630, 0xbf, 0x76, 0x80, 0xf7, 0xba, 0x65, 0x58, 0x84);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_COMPRESSION = new(0xf3586baf, 0xb5aa, 0x49b5, 0x8d, 0x6c, 0x05, 0x69, 0x28, 0x4c, 0x63, 0x9f);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_CONTENTSCREENER = new(0x3e3f0674, 0xc83c, 0x4558, 0xbb, 0x26, 0x98, 0x20, 0xe1, 0xeb, 0xa5, 0xc5);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_CONTINUOUSBACKUP = new(0x71aa14f8, 0x6fad, 0x4622, 0xad, 0x77, 0x92, 0xbb, 0x9d, 0x7e, 0x69, 0x47);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_COPYPROTECTION = new(0x89786ff1, 0x9c12, 0x402f, 0x9c, 0x9e, 0x17, 0x75, 0x3c, 0x7f, 0x43, 0x75);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_ENCRYPTION = new(0xa0a701c0, 0xa511, 0x42ff, 0xaa, 0x6c, 0x06, 0xdc, 0x03, 0x95, 0x57, 0x6f);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_HSM = new(0xd546500a, 0x2aeb, 0x45f6, 0x94, 0x82, 0xf4, 0xb1, 0x79, 0x9c, 0x31, 0x77);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_INFRASTRUCTURE = new(0xe55fa6f9, 0x128c, 0x4d04, 0xab, 0xab, 0x63, 0x0c, 0x74, 0xb1, 0x45, 0x3a);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_OPENFILEBACKUP = new(0xf8ecafa6, 0x66d1, 0x41a5, 0x89, 0x9b, 0x66, 0x58, 0x5d, 0x72, 0x16, 0xb7);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_PHYSICALQUOTAMANAGEMENT = new(0x6a0a8e78, 0xbba6, 0x4fc4, 0xa7, 0x09, 0x1e, 0x33, 0xcd, 0x09, 0xd6, 0x7e);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_QUOTAMANAGEMENT = new(0x8503c911, 0xa6c7, 0x4919, 0x8f, 0x79, 0x50, 0x28, 0xf5, 0x86, 0x6b, 0x0c);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_REPLICATION = new(0x48d3ebc4, 0x4cf8, 0x48ff, 0xb8, 0x69, 0x9c, 0x68, 0xad, 0x42, 0xeb, 0x9f);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_SECURITYENHANCER = new(0xd02bc3da, 0x0c8e, 0x4945, 0x9b, 0xd5, 0xf1, 0x88, 0x3c, 0x22, 0x6c, 0x8c);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_SYSTEM = new(0x5d1b9aaa, 0x01e2, 0x46af, 0x84, 0x9f, 0x27, 0x2b, 0x3f, 0x32, 0x4c, 0x46);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_SYSTEMRECOVERY = new(0x2db15374, 0x706e, 0x4131, 0xa0, 0xc7, 0xd7, 0xc7, 0x8e, 0xb0, 0x28, 0x9a);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_TOP = new(0xb369baf4, 0x5568, 0x4e82, 0xa8, 0x7e, 0xa9, 0x3e, 0xb1, 0x6b, 0xca, 0x87);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_UNDELETE = new(0xfe8f1572, 0xc67a, 0x48c0, 0xbb, 0xac, 0x0b, 0x5c, 0x6d, 0x66, 0xca, 0xfb);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_FSFILTER_VIRTUALIZATION = new(0xf75a86c0, 0x10d8, 0x4c3a, 0xb2, 0x33, 0xed, 0x60, 0xe4, 0xcd, 0xfa, 0xac);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_GPS = new(0x6bdd1fc3, 0x810f, 0x11d0, 0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_HDC = new(0x4d36e96a, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_HIDCLASS = new(0x745a17a0, 0x74d3, 0x11d0, 0xb6, 0xfe, 0x00, 0xa0, 0xc9, 0x0f, 0x57, 0xda);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_HOLOGRAPHIC = new(0xd612553d, 0x06b1, 0x49ca, 0x89, 0x38, 0xe3, 0x9e, 0xf8, 0x0e, 0xb1, 0x6f);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_IMAGE = new(0x6bdd1fc6, 0x810f, 0x11d0, 0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_INFINIBAND = new(0x30ef7132, 0xd858, 0x4a0c, 0xac, 0x24, 0xb9, 0x02, 0x8a, 0x5c, 0xca, 0x3f);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_INFRARED = new(0x6bdd1fc5, 0x810f, 0x11d0, 0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_KEYBOARD = new(0x4d36e96b, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_LEGACYDRIVER = new(0x8ecc055d, 0x047f, 0x11d1, 0xa5, 0x37, 0x00, 0x00, 0xf8, 0x75, 0x3e, 0xd1);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_MEDIA = new(0x4d36e96c, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_MEDIUM_CHANGER = new(0xce5939ae, 0xebde, 0x11d0, 0xb1, 0x81, 0x00, 0x00, 0xf8, 0x75, 0x3e, 0xc4);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_MEMORY = new(0x5099944a, 0xf6b9, 0x4057, 0xa0, 0x56, 0x8c, 0x55, 0x02, 0x28, 0x54, 0x4c);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_MODEM = new(0x4d36e96d, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_MONITOR = new(0x4d36e96e, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_MOUSE = new(0x4d36e96f, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_MTD = new(0x4d36e970, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_MULTIFUNCTION = new(0x4d36e971, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_MULTIPORTSERIAL = new(0x50906cb8, 0xba12, 0x11d1, 0xbf, 0x5d, 0x00, 0x00, 0xf8, 0x05, 0xf5, 0x30);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_NET = new(0x4d36e972, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_NETCLIENT = new(0x4d36e973, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_NETDRIVER = new(0x87ef9ad1, 0x8f70, 0x49ee, 0xb2, 0x15, 0xab, 0x1f, 0xca, 0xdc, 0xbe, 0x3c);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_NETSERVICE = new(0x4d36e974, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_NETTRANS = new(0x4d36e975, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_NODRIVER = new(0x4d36e976, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_PCMCIA = new(0x4d36e977, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_PNPPRINTERS = new(0x4658ee7e, 0xf050, 0x11d1, 0xb6, 0xbd, 0x00, 0xc0, 0x4f, 0xa3, 0x72, 0xa7);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_PORTS = new(0x4d36e978, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_PRINTER = new(0x4d36e979, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_PRINTERUPGRADE = new(0x4d36e97a, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_PRINTQUEUE = new(0x1ed2bbf9, 0x11f0, 0x4084, 0xb2, 0x1f, 0xad, 0x83, 0xa8, 0xe6, 0xdc, 0xdc);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_PROCESSOR = new(0x50127dc3, 0x0f36, 0x415e, 0xa6, 0xcc, 0x4c, 0xb3, 0xbe, 0x91, 0x0B, 0x65);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_SBP2 = new(0xd48179be, 0xec20, 0x11d1, 0xb6, 0xb8, 0x00, 0xc0, 0x4f, 0xa3, 0x72, 0xa7);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_SCMDISK = new(0x53966cb1, 0x4d46, 0x4166, 0xbf, 0x23, 0xc5, 0x22, 0x40, 0x3c, 0xd4, 0x95);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_SCMVOLUME = new(0x53ccb149, 0xe543, 0x4c84, 0xb6, 0xe0, 0xbc, 0xe4, 0xf6, 0xb7, 0xe8, 0x06);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_SCSIADAPTER = new(0x4d36e97b, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_SECURITYACCELERATOR = new(0x268c95a1, 0xedfe, 0x11d3, 0x95, 0xc3, 0x00, 0x10, 0xdc, 0x40, 0x50, 0xa5);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_SENSOR = new(0x5175d334, 0xc371, 0x4806, 0xb3, 0xba, 0x71, 0xfd, 0x53, 0xc9, 0x25, 0x8d);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_SIDESHOW = new(0x997b5d8d, 0xc442, 0x4f2e, 0xba, 0xf3, 0x9c, 0x8e, 0x67, 0x1e, 0x9e, 0x21);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_SMARTCARDREADER = new(0x50dd5230, 0xba8a, 0x11d1, 0xbf, 0x5d, 0x00, 0x00, 0xf8, 0x05, 0xf5, 0x30);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_SMRDISK = new(0x53487c23, 0x680f, 0x4585, 0xac, 0xc3, 0x1f, 0x10, 0xd6, 0x77, 0x7e, 0x82);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_SMRVOLUME = new(0x53b3cf03, 0x8f5a, 0x4788, 0x91, 0xb6, 0xd1, 0x9e, 0xd9, 0xfc, 0xcc, 0xbf);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_SOFTWARECOMPONENT = new(0x5c4c3332, 0x344d, 0x483c, 0x87, 0x39, 0x25, 0x9e, 0x93, 0x4c, 0x9c, 0xc8);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_SOUND = new(0x4d36e97c, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_SYSTEM = new(0x4d36e97d, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_TAPEDRIVE = new(0x6d807884, 0x7d21, 0x11cf, 0x80, 0x1c, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_UCM = new(0xe6f1aa1c, 0x7f3b, 0x4473, 0xb2, 0xe8, 0xc9, 0x7d, 0x8a, 0xc7, 0x1d, 0x53);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_UNKNOWN = new(0x4d36e97e, 0xe325, 0x11ce, 0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_USB = new(0x36fc9e60, 0xc465, 0x11cf, 0x80, 0x56, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_VOLUME = new(0x71a27cdd, 0x812a, 0x11d0, 0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_VOLUMESNAPSHOT = new(0x533c5b84, 0xec70, 0x11d2, 0x95, 0x05, 0x00, 0xc0, 0x4f, 0x79, 0xde, 0xaf);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_WCEUSBS = new(0x25dbce51, 0x6c8f, 0x4a72, 0x8a, 0x6d, 0xb5, 0x4c, 0x2b, 0x4f, 0xc8, 0x35);

	/// <summary></summary>
	public static readonly Guid GUID_DEVCLASS_WPD = new(0xeec5ad98, 0x8080, 0x425f, 0x92, 0x2a, 0xda, 0xbf, 0x3d, 0xe3, 0xf6, 0x9a);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_CDCHANGER = new(0x53f56312, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_CDROM = new(0x53f56308, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_COMPORT = new(0X86E0D1E0, 0X8089, 0X11D0, 0X9C, 0XE4, 0X08, 0X00, 0X3E, 0X30, 0X1F, 0X73);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_DISK = new(0x53f56307, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_DISPLAY_ADAPTER = new(0x5b45201d, 0xf2f2, 0x4f3b, 0x85, 0xbb, 0x30, 0xff, 0x1f, 0x95, 0x35, 0x99);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_FLOPPY = new(0x53f56311, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_GNSS = new(0x3336e5e4, 0x18a, 0x4669, 0x84, 0xc5, 0xbd, 0x5, 0xf3, 0xbd, 0x36, 0x8b);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_GRAPHICSPOWER = new(0xea5c6870, 0xe93c, 0x4588, 0xbe, 0xf1, 0xfe, 0xc4, 0x2f, 0xc9, 0x42, 0x9a);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_HIDDEN_VOLUME = new(0x7f108a28, 0x9833, 0x4b3b, 0xb7, 0x80, 0x2c, 0x6b, 0x5f, 0xa5, 0xc0, 0x62);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_IMAGE = new(0x6bdd1fc6, 0x810f, 0x11d0, 0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_IPPUSB_PRINT = new(0xf2f40381, 0xf46d, 0x4e51, 0xbc, 0xe7, 0x62, 0xde, 0x6c, 0xf2, 0xd0, 0x98);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_LAMP = new(0x6c11e9e3, 0x8238, 0x4f0a, 0x0a, 0x19, 0xaa, 0xec, 0x26, 0xca, 0x5e, 0x98);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_MEDIUMCHANGER = new(0x53f56310, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_MODEM = new(0x2c7089aa, 0x2e0e, 0x11d1, 0xb1, 0x14, 0x00, 0xc0, 0x4f, 0xc2, 0xaa, 0xe4);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_MONITOR = new(0xe6f07b5f, 0xee97, 0x4a90, 0xb0, 0x76, 0x33, 0xf5, 0x7b, 0xf4, 0xea, 0xa7);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_NET = new(0xcac88484, 0x7515, 0x4c03, 0x82, 0xe6, 0x71, 0xa8, 0x7a, 0xba, 0xc3, 0x61);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_NFCDTA = new(0x7fd3f30b, 0x5e49, 0x4be1, 0xb3, 0xaa, 0xaf, 0x06, 0x26, 0x0d, 0x23, 0x6a);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_NFCSE = new(0x8dc7c854, 0xf5e5, 0x4bed, 0x81, 0x5d, 0xc, 0x85, 0xad, 0x4, 0x77, 0x25);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_NFP = new(0xFB3842CD, 0x9E2A, 0x4F83, 0x8F, 0xCC, 0x4B, 0x07, 0x61, 0x13, 0x9A, 0xE9);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_PARALLEL = new(0x97F76EF0, 0xF883, 0x11D0, 0xAF, 0x1F, 0x00, 0x00, 0xF8, 0x00, 0x84, 0x5C);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_PARCLASS = new(0x811FC6A5, 0xF728, 0x11D0, 0xA5, 0x37, 0x00, 0x00, 0xF8, 0x75, 0x3E, 0xD1);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_PARTITION = new(0x53f5630a, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_PWM_CONTROLLER = new(0x60824b4c, 0xeed1, 0x4c9c, 0xb4, 0x9c, 0x1b, 0x96, 0x14, 0x61, 0xa8, 0x19);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_SCM_PHYSICAL_DEVICE = new(0x4283609d, 0x4dc2, 0x43be, 0xbb, 0xb4, 0x4f, 0x15, 0xdf, 0xce, 0x2c, 0x61);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_SENSOR = new(0XBA1BB692, 0X9B7A, 0X4833, 0X9A, 0X1E, 0X52, 0X5E, 0XD1, 0X34, 0XE7, 0XE2);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_SERENUM_BUS_ENUMERATOR = new(0x4D36E978, 0xE325, 0x11CE, 0xBF, 0xC1, 0x08, 0x00, 0x2B, 0xE1, 0x03, 0x18);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_SERVICE_VOLUME = new(0x6ead3d82, 0x25ec, 0x46bc, 0xb7, 0xfd, 0xc1, 0xf0, 0xdf, 0x8f, 0x50, 0x37);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_SES = new(0x1790c9ec, 0x47d5, 0x4df3, 0xb5, 0xaf, 0x9a, 0xdf, 0x3c, 0xf2, 0x3e, 0x48);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_SIDESHOW = new(0x152e5811, 0xfeb9, 0x4b00, 0x90, 0xf4, 0xd3, 0x29, 0x47, 0xae, 0x16, 0x81);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_SMARTCARD_READER = new(0x50DD5230, 0xBA8A, 0x11D1, 0xBF, 0x5D, 0x00, 0x00, 0xF8, 0x05, 0xF5, 0x30);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_STORAGEPORT = new(0x2accfe60, 0xc130, 0x11d2, 0xb0, 0x82, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_TAPE = new(0x53f5630b, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_THERMAL_COOLING = new(0xdbe4373d, 0x3c81, 0x40cb, 0xac, 0xe4, 0xe0, 0xe5, 0xd0, 0x5f, 0xc, 0x9f);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_UNIFIED_ACCESS_RPMB = new(0x27447c21, 0xbcc3, 0x4d07, 0xa0, 0x5b, 0xa3, 0x39, 0x5b, 0xb4, 0xee, 0xe7);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_USB_BILLBOARD = new(0x5e9adaef, 0xf879, 0x473f, 0xb8, 0x07, 0x4e, 0x5e, 0xa7, 0x7d, 0x1b, 0x1c);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_USB_DEVICE = new(0xA5DCBF10, 0x6530, 0x11D2, 0x90, 0x1F, 0x00, 0xC0, 0x4F, 0xB9, 0x51, 0xED);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_USB_HOST_CONTROLLER = new(0x3abf6f2d, 0x71c4, 0x462a, 0x8a, 0x92, 0x1e, 0x68, 0x61, 0xe6, 0xaf, 0x27);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_USB_HUB = new(0xf18a0e88, 0xc30c, 0x11d0, 0x88, 0x15, 0x00, 0xa0, 0xc9, 0x06, 0xbe, 0xd8);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_USBPRINT = new(0x28d78fad, 0x5a12, 0x11d1, 0xae, 0x5b, 0x0, 0x0, 0xf8, 0x3, 0xa8, 0xc2);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_VIDEO_OUTPUT_ARRIVAL = new(0x1AD9E4F0, 0xF88D, 0x4360, 0xBA, 0xB9, 0x4C, 0x2D, 0x55, 0xE5, 0x64, 0xCD);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_VM_GENCOUNTER = new(0x3ff2c92b, 0x6598, 0x4e60, 0x8e, 0x1c, 0x0c, 0xcf, 0x49, 0x27, 0xe3, 0x19);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_VMLUN = new(0x6f416619, 0x9f29, 0x42a5, 0xb2, 0x0b, 0x37, 0xe2, 0x19, 0xca, 0x02, 0xb0);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_VOLUME = new(0x53f5630d, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_WPD = new(0x6AC27878, 0xA6FA, 0x4155, 0xBA, 0x85, 0xF9, 0x8F, 0x49, 0x1D, 0x4F, 0x33);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_WPD_PRIVATE = new(0xBA0C718F, 0x4DED, 0x49B7, 0xBD, 0xD3, 0xFA, 0xBE, 0x28, 0x66, 0x12, 0x11);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_WPD_SERVICE = new(0x9EF44F80, 0x3D64, 0x4246, 0xA6, 0xAA, 0x20, 0x6F, 0x32, 0x8D, 0x1E, 0xDC);

	/// <summary></summary>
	public static readonly Guid GUID_DEVINTERFACE_WRITEONCEDISK = new(0x53f5630c, 0xb6bf, 0x11d0, 0x94, 0xf2, 0x00, 0xa0, 0xc9, 0x1e, 0xfb, 0x8b);
}