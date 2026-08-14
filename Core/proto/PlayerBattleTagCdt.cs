using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B88")]
public class PlayerBattleTagCdt
{
	[Token(Token = "0x400AD25")]
	[FieldOffset(Offset = "0x8")]
	public ESocial.PlayerBattleTagCdtType condition_type;

	[Token(Token = "0x400AD26")]
	[FieldOffset(Offset = "0xC")]
	public float condition_param;

	[Token(Token = "0x60081E3")]
	[Address(RVA = "0x33DFF54", Offset = "0x33DFF54", VA = "0x33DFF54")]
	public PlayerBattleTagCdt()
	{
	}
}
