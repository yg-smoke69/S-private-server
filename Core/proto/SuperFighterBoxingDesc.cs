using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B53")]
public class SuperFighterBoxingDesc
{
	[Token(Token = "0x400ABDD")]
	[FieldOffset(Offset = "0x8")]
	public ELimitedEvent.SuperFighterManner manner_id;

	[Token(Token = "0x400ABDE")]
	[FieldOffset(Offset = "0xC")]
	public uint consume_token_id;

	[Token(Token = "0x400ABDF")]
	[FieldOffset(Offset = "0x10")]
	public uint consume_token_num;

	[Token(Token = "0x400ABE0")]
	[FieldOffset(Offset = "0x14")]
	public uint damage_lower;

	[Token(Token = "0x400ABE1")]
	[FieldOffset(Offset = "0x18")]
	public uint damage_upper;

	[Token(Token = "0x60081AE")]
	[Address(RVA = "0x33E2D68", Offset = "0x33E2D68", VA = "0x33E2D68")]
	public SuperFighterBoxingDesc()
	{
	}
}
