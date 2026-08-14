using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001824")]
public class CSSuperFighterAttackRes
{
	[Token(Token = "0x4009C23")]
	[FieldOffset(Offset = "0x8")]
	public uint player_damage;

	[Token(Token = "0x4009C24")]
	[FieldOffset(Offset = "0xC")]
	public ELimitedEvent.SuperFighterManner enemy_manner;

	[Token(Token = "0x4009C25")]
	[FieldOffset(Offset = "0x10")]
	public uint enemy_damage;

	[Token(Token = "0x4009C26")]
	[FieldOffset(Offset = "0x14")]
	public ELimitedEvent.SuperFighterResult result;

	[Token(Token = "0x4009C27")]
	[FieldOffset(Offset = "0x18")]
	public bool is_big_reward;

	[Token(Token = "0x4009C28")]
	[FieldOffset(Offset = "0x1C")]
	public AwardDesc reward;

	[Token(Token = "0x6007E7E")]
	[Address(RVA = "0x309A00C", Offset = "0x309A00C", VA = "0x309A00C")]
	public CSSuperFighterAttackRes()
	{
	}
}
