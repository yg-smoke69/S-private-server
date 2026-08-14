using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A90")]
public class RebateCardDesc
{
	[Token(Token = "0x400A65A")]
	[FieldOffset(Offset = "0x8")]
	public uint rebate_id;

	[Token(Token = "0x400A65B")]
	[FieldOffset(Offset = "0xC")]
	public uint subscription_bonus;

	[Token(Token = "0x60080ED")]
	[Address(RVA = "0x33E0F58", Offset = "0x33E0F58", VA = "0x33E0F58")]
	public RebateCardDesc()
	{
	}
}
