using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip;

[Token(Token = "0x2003C10")]
public class DescriptorData
{
	[Token(Token = "0x40199F0")]
	[FieldOffset(Offset = "0x8")]
	private long size;

	[Token(Token = "0x40199F1")]
	[FieldOffset(Offset = "0x10")]
	private long compressedSize;

	[Token(Token = "0x40199F2")]
	[FieldOffset(Offset = "0x18")]
	private long crc;

	[Token(Token = "0x17001969")]
	public long CompressedSize
	{
		[Token(Token = "0x6017FD3")]
		[Address(RVA = "0xA26A3C", Offset = "0xA26A3C", VA = "0xA26A3C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6017FD4")]
		[Address(RVA = "0xA26A44", Offset = "0xA26A44", VA = "0xA26A44")]
		set
		{
		}
	}

	[Token(Token = "0x1700196A")]
	public long Size
	{
		[Token(Token = "0x6017FD5")]
		[Address(RVA = "0xA26A54", Offset = "0xA26A54", VA = "0xA26A54")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6017FD6")]
		[Address(RVA = "0xA26A5C", Offset = "0xA26A5C", VA = "0xA26A5C")]
		set
		{
		}
	}

	[Token(Token = "0x1700196B")]
	public long Crc
	{
		[Token(Token = "0x6017FD7")]
		[Address(RVA = "0xA26A6C", Offset = "0xA26A6C", VA = "0xA26A6C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6017FD8")]
		[Address(RVA = "0xA26A74", Offset = "0xA26A74", VA = "0xA26A74")]
		set
		{
		}
	}

	[Token(Token = "0x6017FD2")]
	[Address(RVA = "0xA26A34", Offset = "0xA26A34", VA = "0xA26A34")]
	public DescriptorData()
	{
	}
}
