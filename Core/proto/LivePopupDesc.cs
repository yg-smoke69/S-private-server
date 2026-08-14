using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B80")]
public class LivePopupDesc
{
	[Token(Token = "0x400ACFC")]
	[FieldOffset(Offset = "0x8")]
	public string tips;

	[Token(Token = "0x400ACFD")]
	[FieldOffset(Offset = "0xC")]
	public uint tips_start_time;

	[Token(Token = "0x400ACFE")]
	[FieldOffset(Offset = "0x10")]
	public uint tips_end_time;

	[Token(Token = "0x400ACFF")]
	[FieldOffset(Offset = "0x14")]
	public ECDN.LivePopupTipsType tips_type;

	[Token(Token = "0x400AD00")]
	[FieldOffset(Offset = "0x18")]
	public string tips_cdn;

	[Token(Token = "0x60081DB")]
	[Address(RVA = "0x30A65B0", Offset = "0x30A65B0", VA = "0x30A65B0")]
	public LivePopupDesc()
	{
	}
}
