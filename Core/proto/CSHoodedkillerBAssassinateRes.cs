using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001837")]
public class CSHoodedkillerBAssassinateRes
{
	[Token(Token = "0x4009C5A")]
	[FieldOffset(Offset = "0x8")]
	public uint sword_times;

	[Token(Token = "0x4009C5B")]
	[FieldOffset(Offset = "0xC")]
	public uint sleeve_arrow_times;

	[Token(Token = "0x4009C5C")]
	[FieldOffset(Offset = "0x10")]
	public long escaped_time;

	[Token(Token = "0x4009C5D")]
	[FieldOffset(Offset = "0x18")]
	public bool is_dead;

	[Token(Token = "0x4009C5E")]
	[FieldOffset(Offset = "0x1C")]
	public ExchangeChangeData exchange_change_data;

	[Token(Token = "0x6007E91")]
	[Address(RVA = "0x30971A8", Offset = "0x30971A8", VA = "0x30971A8")]
	public CSHoodedkillerBAssassinateRes()
	{
	}
}
