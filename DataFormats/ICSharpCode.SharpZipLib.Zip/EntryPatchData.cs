using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip;

[Token(Token = "0x2003C11")]
internal class EntryPatchData
{
	[Token(Token = "0x40199F3")]
	[FieldOffset(Offset = "0x8")]
	private long sizePatchOffset_;

	[Token(Token = "0x40199F4")]
	[FieldOffset(Offset = "0x10")]
	private long crcPatchOffset_;

	[Token(Token = "0x1700196C")]
	public long SizePatchOffset
	{
		[Token(Token = "0x6017FDA")]
		[Address(RVA = "0xA26A88", Offset = "0xA26A88", VA = "0xA26A88")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6017FDB")]
		[Address(RVA = "0xA26A90", Offset = "0xA26A90", VA = "0xA26A90")]
		set
		{
		}
	}

	[Token(Token = "0x1700196D")]
	public long CrcPatchOffset
	{
		[Token(Token = "0x6017FDC")]
		[Address(RVA = "0xA26AA0", Offset = "0xA26AA0", VA = "0xA26AA0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6017FDD")]
		[Address(RVA = "0xA26AA8", Offset = "0xA26AA8", VA = "0xA26AA8")]
		set
		{
		}
	}

	[Token(Token = "0x6017FD9")]
	[Address(RVA = "0xA26A80", Offset = "0xA26A80", VA = "0xA26A80")]
	public EntryPatchData()
	{
	}
}
