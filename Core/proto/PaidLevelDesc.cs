using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AE9")]
public class PaidLevelDesc
{
	[Token(Token = "0x400A930")]
	[FieldOffset(Offset = "0x8")]
	public uint paid_level;

	[Token(Token = "0x400A931")]
	[FieldOffset(Offset = "0xC")]
	public uint min_paid;

	[Token(Token = "0x400A932")]
	[FieldOffset(Offset = "0x10")]
	public uint max_paid;

	[Token(Token = "0x400A933")]
	[FieldOffset(Offset = "0x14")]
	public uint no_topup_days;

	[Token(Token = "0x6008144")]
	[Address(RVA = "0x33DF00C", Offset = "0x33DF00C", VA = "0x33DF00C")]
	public PaidLevelDesc()
	{
	}
}
