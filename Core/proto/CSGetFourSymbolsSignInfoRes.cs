using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018BC")]
public class CSGetFourSymbolsSignInfoRes
{
	[Token(Token = "0x4009DB4")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4009DB5")]
	[FieldOffset(Offset = "0xC")]
	public bool signed;

	[Token(Token = "0x4009DB6")]
	[FieldOffset(Offset = "0x10")]
	public ELimitedEvent.FourSymbolsID symbol;

	[Token(Token = "0x4009DB7")]
	[FieldOffset(Offset = "0x14")]
	public uint accumulated_days;

	[Token(Token = "0x4009DB8")]
	[FieldOffset(Offset = "0x18")]
	public bool accumulated_award_rewarded;

	[Token(Token = "0x6007F15")]
	[Address(RVA = "0x31850B8", Offset = "0x31850B8", VA = "0x31850B8")]
	public CSGetFourSymbolsSignInfoRes()
	{
	}
}
