using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip;

[Token(Token = "0x2003C06")]
public class ZipEntry : _Attribute
{
	[Token(Token = "0x2003C07")]
	private enum Known : byte
	{
		[Token(Token = "0x40199D8")]
		None = 0,
		[Token(Token = "0x40199D9")]
		Size = 1,
		[Token(Token = "0x40199DA")]
		CompressedSize = 2,
		[Token(Token = "0x40199DB")]
		Crc = 4,
		[Token(Token = "0x40199DC")]
		Time = 8,
		[Token(Token = "0x40199DD")]
		ExternalAttributes = 0x10
	}

	[Token(Token = "0x40199C4")]
	[FieldOffset(Offset = "0x8")]
	private Known known;

	[Token(Token = "0x40199C5")]
	[FieldOffset(Offset = "0xC")]
	private int externalFileAttributes;

	[Token(Token = "0x40199C6")]
	[FieldOffset(Offset = "0x10")]
	private ushort versionMadeBy;

	[Token(Token = "0x40199C7")]
	[FieldOffset(Offset = "0x14")]
	private string name;

	[Token(Token = "0x40199C8")]
	[FieldOffset(Offset = "0x18")]
	private ulong size;

	[Token(Token = "0x40199C9")]
	[FieldOffset(Offset = "0x20")]
	private ulong compressedSize;

	[Token(Token = "0x40199CA")]
	[FieldOffset(Offset = "0x28")]
	private ushort versionToExtract;

	[Token(Token = "0x40199CB")]
	[FieldOffset(Offset = "0x2C")]
	private uint crc;

	[Token(Token = "0x40199CC")]
	[FieldOffset(Offset = "0x30")]
	private uint dosTime;

	[Token(Token = "0x40199CD")]
	[FieldOffset(Offset = "0x34")]
	private CompressionMethod method;

	[Token(Token = "0x40199CE")]
	[FieldOffset(Offset = "0x38")]
	private byte[] extra;

	[Token(Token = "0x40199CF")]
	[FieldOffset(Offset = "0x3C")]
	private string comment;

	[Token(Token = "0x40199D0")]
	[FieldOffset(Offset = "0x40")]
	private int flags;

	[Token(Token = "0x40199D1")]
	[FieldOffset(Offset = "0x48")]
	private long zipFileIndex;

	[Token(Token = "0x40199D2")]
	[FieldOffset(Offset = "0x50")]
	private long offset;

	[Token(Token = "0x40199D3")]
	[FieldOffset(Offset = "0x58")]
	private bool forceZip64_;

	[Token(Token = "0x40199D4")]
	[FieldOffset(Offset = "0x59")]
	private byte cryptoCheckValue_;

	[Token(Token = "0x40199D5")]
	[FieldOffset(Offset = "0x5C")]
	private int _aesVer;

	[Token(Token = "0x40199D6")]
	[FieldOffset(Offset = "0x60")]
	private int _aesEncryptionStrength;

	[Token(Token = "0x1700193A")]
	public bool HasCrc
	{
		[Token(Token = "0x6017F52")]
		[Address(RVA = "0xA29CF4", Offset = "0xA29CF4", VA = "0xA29CF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700193B")]
	public bool IsCrypted
	{
		[Token(Token = "0x6017F53")]
		[Address(RVA = "0xA29D00", Offset = "0xA29D00", VA = "0xA29D00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017F54")]
		[Address(RVA = "0xA29D0C", Offset = "0xA29D0C", VA = "0xA29D0C")]
		set
		{
		}
	}

	[Token(Token = "0x1700193C")]
	public bool IsUnicodeText
	{
		[Token(Token = "0x6017F55")]
		[Address(RVA = "0xA29D24", Offset = "0xA29D24", VA = "0xA29D24")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017F56")]
		[Address(RVA = "0xA29D30", Offset = "0xA29D30", VA = "0xA29D30")]
		set
		{
		}
	}

	[Token(Token = "0x1700193D")]
	internal byte CryptoCheckValue
	{
		[Token(Token = "0x6017F57")]
		[Address(RVA = "0xA29D48", Offset = "0xA29D48", VA = "0xA29D48")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6017F58")]
		[Address(RVA = "0xA29D50", Offset = "0xA29D50", VA = "0xA29D50")]
		set
		{
		}
	}

	[Token(Token = "0x1700193E")]
	public int Flags
	{
		[Token(Token = "0x6017F59")]
		[Address(RVA = "0xA29D58", Offset = "0xA29D58", VA = "0xA29D58")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6017F5A")]
		[Address(RVA = "0xA29D60", Offset = "0xA29D60", VA = "0xA29D60")]
		set
		{
		}
	}

	[Token(Token = "0x1700193F")]
	public long ZipFileIndex
	{
		[Token(Token = "0x6017F5B")]
		[Address(RVA = "0xA29D68", Offset = "0xA29D68", VA = "0xA29D68")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6017F5C")]
		[Address(RVA = "0xA29D70", Offset = "0xA29D70", VA = "0xA29D70")]
		set
		{
		}
	}

	[Token(Token = "0x17001940")]
	public long Offset
	{
		[Token(Token = "0x6017F5D")]
		[Address(RVA = "0xA29D80", Offset = "0xA29D80", VA = "0xA29D80")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6017F5E")]
		[Address(RVA = "0xA29D88", Offset = "0xA29D88", VA = "0xA29D88")]
		set
		{
		}
	}

	[Token(Token = "0x17001941")]
	public int ExternalFileAttributes
	{
		[Token(Token = "0x6017F5F")]
		[Address(RVA = "0xA29D98", Offset = "0xA29D98", VA = "0xA29D98")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6017F60")]
		[Address(RVA = "0xA29DB0", Offset = "0xA29DB0", VA = "0xA29DB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001942")]
	public int VersionMadeBy
	{
		[Token(Token = "0x6017F61")]
		[Address(RVA = "0xA29DC4", Offset = "0xA29DC4", VA = "0xA29DC4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001943")]
	public bool IsDOSEntry
	{
		[Token(Token = "0x6017F62")]
		[Address(RVA = "0xA29DCC", Offset = "0xA29DCC", VA = "0xA29DCC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001944")]
	public int HostSystem
	{
		[Token(Token = "0x6017F64")]
		[Address(RVA = "0xA29DF4", Offset = "0xA29DF4", VA = "0xA29DF4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6017F65")]
		[Address(RVA = "0xA29E44", Offset = "0xA29E44", VA = "0xA29E44")]
		set
		{
		}
	}

	[Token(Token = "0x17001945")]
	public int Version
	{
		[Token(Token = "0x6017F66")]
		[Address(RVA = "0xA29E54", Offset = "0xA29E54", VA = "0xA29E54")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001946")]
	public bool CanDecompress
	{
		[Token(Token = "0x6017F67")]
		[Address(RVA = "0xA2A02C", Offset = "0xA2A02C", VA = "0xA2A02C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001947")]
	public bool LocalHeaderRequiresZip64
	{
		[Token(Token = "0x6017F6A")]
		[Address(RVA = "0xA2A0E0", Offset = "0xA2A0E0", VA = "0xA2A0E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001948")]
	public bool CentralHeaderRequiresZip64
	{
		[Token(Token = "0x6017F6B")]
		[Address(RVA = "0xA29F14", Offset = "0xA29F14", VA = "0xA29F14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001949")]
	public long DosTime
	{
		[Token(Token = "0x6017F6C")]
		[Address(RVA = "0xA2A178", Offset = "0xA2A178", VA = "0xA2A178")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6017F6D")]
		[Address(RVA = "0xA2A190", Offset = "0xA2A190", VA = "0xA2A190")]
		set
		{
		}
	}

	[Token(Token = "0x1700194A")]
	public DateTime DateTime
	{
		[Token(Token = "0x6017F6E")]
		[Address(RVA = "0xA2A1A4", Offset = "0xA2A1A4", VA = "0xA2A1A4")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6017F6F")]
		[Address(RVA = "0xA29A00", Offset = "0xA29A00", VA = "0xA29A00")]
		set
		{
		}
	}

	[Token(Token = "0x1700194B")]
	public string Name
	{
		[Token(Token = "0x6017F70")]
		[Address(RVA = "0xA2A304", Offset = "0xA2A304", VA = "0xA2A304")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700194C")]
	public long Size
	{
		[Token(Token = "0x6017F71")]
		[Address(RVA = "0xA2A30C", Offset = "0xA2A30C", VA = "0xA2A30C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6017F72")]
		[Address(RVA = "0xA2A32C", Offset = "0xA2A32C", VA = "0xA2A32C")]
		set
		{
		}
	}

	[Token(Token = "0x1700194D")]
	public long CompressedSize
	{
		[Token(Token = "0x6017F73")]
		[Address(RVA = "0xA2A348", Offset = "0xA2A348", VA = "0xA2A348")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6017F74")]
		[Address(RVA = "0xA2A368", Offset = "0xA2A368", VA = "0xA2A368")]
		set
		{
		}
	}

	[Token(Token = "0x1700194E")]
	public long Crc
	{
		[Token(Token = "0x6017F75")]
		[Address(RVA = "0xA2A384", Offset = "0xA2A384", VA = "0xA2A384")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6017F76")]
		[Address(RVA = "0xA2A3A4", Offset = "0xA2A3A4", VA = "0xA2A3A4")]
		set
		{
		}
	}

	[Token(Token = "0x1700194F")]
	public CompressionMethod CompressionMethod
	{
		[Token(Token = "0x6017F77")]
		[Address(RVA = "0xA2A404", Offset = "0xA2A404", VA = "0xA2A404")]
		get
		{
			return default(CompressionMethod);
		}
		[Token(Token = "0x6017F78")]
		[Address(RVA = "0xA2A40C", Offset = "0xA2A40C", VA = "0xA2A40C")]
		set
		{
		}
	}

	[Token(Token = "0x17001950")]
	internal CompressionMethod CompressionMethodForHeader
	{
		[Token(Token = "0x6017F79")]
		[Address(RVA = "0xA2A4D4", Offset = "0xA2A4D4", VA = "0xA2A4D4")]
		get
		{
			return default(CompressionMethod);
		}
	}

	[Token(Token = "0x17001951")]
	public byte[] ExtraData
	{
		[Token(Token = "0x6017F7A")]
		[Address(RVA = "0xA2A4F8", Offset = "0xA2A4F8", VA = "0xA2A4F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017F7B")]
		[Address(RVA = "0xA2A500", Offset = "0xA2A500", VA = "0xA2A500")]
		set
		{
		}
	}

	[Token(Token = "0x17001952")]
	public int AESKeySize
	{
		[Token(Token = "0x6017F7C")]
		[Address(RVA = "0xA24270", Offset = "0xA24270", VA = "0xA24270")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6017F7D")]
		[Address(RVA = "0xA2A60C", Offset = "0xA2A60C", VA = "0xA2A60C")]
		set
		{
		}
	}

	[Token(Token = "0x17001953")]
	internal byte AESEncryptionStrength
	{
		[Token(Token = "0x6017F7E")]
		[Address(RVA = "0xA2A748", Offset = "0xA2A748", VA = "0xA2A748")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17001954")]
	internal int AESSaltLen
	{
		[Token(Token = "0x6017F7F")]
		[Address(RVA = "0xA24254", Offset = "0xA24254", VA = "0xA24254")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001955")]
	internal int AESOverheadSize
	{
		[Token(Token = "0x6017F80")]
		[Address(RVA = "0xA2A750", Offset = "0xA2A750", VA = "0xA2A750")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001956")]
	public string Comment
	{
		[Token(Token = "0x6017F83")]
		[Address(RVA = "0xA2B3C0", Offset = "0xA2B3C0", VA = "0xA2B3C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017F84")]
		[Address(RVA = "0xA2B3C8", Offset = "0xA2B3C8", VA = "0xA2B3C8")]
		set
		{
		}
	}

	[Token(Token = "0x17001957")]
	public bool IsDirectory
	{
		[Token(Token = "0x6017F85")]
		[Address(RVA = "0xA29F50", Offset = "0xA29F50", VA = "0xA29F50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001958")]
	public bool IsFile
	{
		[Token(Token = "0x6017F86")]
		[Address(RVA = "0xA2B4A0", Offset = "0xA2B4A0", VA = "0xA2B4A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6017F4E")]
	[Address(RVA = "0xA297AC", Offset = "0xA297AC", VA = "0xA297AC")]
	public ZipEntry(string name)
	{
	}

	[Token(Token = "0x6017F4F")]
	[Address(RVA = "0xA299DC", Offset = "0xA299DC", VA = "0xA299DC")]
	internal ZipEntry(string name, int versionRequiredToExtract)
	{
	}

	[Token(Token = "0x6017F50")]
	[Address(RVA = "0xA297D4", Offset = "0xA297D4", VA = "0xA297D4")]
	internal ZipEntry(string name, int versionRequiredToExtract, int madeByInfo, CompressionMethod method)
	{
	}

	[Token(Token = "0x6017F51")]
	[Address(RVA = "0xA29B24", Offset = "0xA29B24", VA = "0xA29B24")]
	public ZipEntry(ZipEntry entry)
	{
	}

	[Token(Token = "0x6017F63")]
	[Address(RVA = "0xA29E00", Offset = "0xA29E00", VA = "0xA29E00")]
	private bool HasDosAttributes(int attributes)
	{
		return default(bool);
	}

	[Token(Token = "0x6017F68")]
	[Address(RVA = "0xA2A0CC", Offset = "0xA2A0CC", VA = "0xA2A0CC")]
	public void ForceZip64()
	{
	}

	[Token(Token = "0x6017F69")]
	[Address(RVA = "0xA2A0D8", Offset = "0xA2A0D8", VA = "0xA2A0D8")]
	public bool IsZip64Forced()
	{
		return default(bool);
	}

	[Token(Token = "0x6017F81")]
	[Address(RVA = "0xA2A770", Offset = "0xA2A770", VA = "0xA2A770")]
	internal void ProcessExtraData(bool localHeader)
	{
	}

	[Token(Token = "0x6017F82")]
	[Address(RVA = "0xA2B1D0", Offset = "0xA2B1D0", VA = "0xA2B1D0")]
	private void ProcessAESExtraData(ZipExtraData extraData)
	{
	}

	[Token(Token = "0x6017F87")]
	[Address(RVA = "0xA2A0B4", Offset = "0xA2A0B4", VA = "0xA2A0B4")]
	public bool IsCompressionMethodSupported()
	{
		return default(bool);
	}

	[Token(Token = "0x6017F88")]
	[Address(RVA = "0xA2B4FC", Offset = "0xA2B4FC", VA = "0xA2B4FC", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Token(Token = "0x6017F89")]
	[Address(RVA = "0xA2B690", Offset = "0xA2B690", VA = "0xA2B690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6017F8A")]
	[Address(RVA = "0xA2A4C0", Offset = "0xA2A4C0", VA = "0xA2A4C0")]
	public static bool IsCompressionMethodSupported(CompressionMethod method)
	{
		return default(bool);
	}

	[Token(Token = "0x6017F8B")]
	[Address(RVA = "0xA2B698", Offset = "0xA2B698", VA = "0xA2B698")]
	public static string CleanName(string name)
	{
		return null;
	}
}
