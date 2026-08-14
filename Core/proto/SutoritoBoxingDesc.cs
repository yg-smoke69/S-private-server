using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B59")]
public class SutoritoBoxingDesc
{
	[Token(Token = "0x400AC0E")]
	[FieldOffset(Offset = "0x8")]
	public ELimitedEvent.SutoritoManner manner_id;

	[Token(Token = "0x400AC0F")]
	[FieldOffset(Offset = "0xC")]
	public uint consume_token_id;

	[Token(Token = "0x400AC10")]
	[FieldOffset(Offset = "0x10")]
	public uint consume_token_num;

	[Token(Token = "0x400AC11")]
	[FieldOffset(Offset = "0x14")]
	public uint damage_lower;

	[Token(Token = "0x400AC12")]
	[FieldOffset(Offset = "0x18")]
	public uint damage_upper;

	[Token(Token = "0x400AC13")]
	[FieldOffset(Offset = "0x1C")]
	public ELimitedEvent.SutoritoCharacter character;

	[Token(Token = "0x400AC14")]
	[FieldOffset(Offset = "0x20")]
	public bool is_enemy;

	[Token(Token = "0x60081B4")]
	[Address(RVA = "0x33E30A0", Offset = "0x33E30A0", VA = "0x33E30A0")]
	public SutoritoBoxingDesc()
	{
	}
}
