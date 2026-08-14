using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001831")]
public class CSSutoritoAttackRes
{
	[Token(Token = "0x4009C48")]
	[FieldOffset(Offset = "0x8")]
	public uint player_damage;

	[Token(Token = "0x4009C49")]
	[FieldOffset(Offset = "0xC")]
	public ELimitedEvent.SutoritoManner enemy_manner;

	[Token(Token = "0x4009C4A")]
	[FieldOffset(Offset = "0x10")]
	public uint enemy_damage;

	[Token(Token = "0x4009C4B")]
	[FieldOffset(Offset = "0x14")]
	public ELimitedEvent.SutoritoResult result;

	[Token(Token = "0x4009C4C")]
	[FieldOffset(Offset = "0x18")]
	public bool is_big_reward;

	[Token(Token = "0x4009C4D")]
	[FieldOffset(Offset = "0x1C")]
	public AwardDesc reward;

	[Token(Token = "0x6007E8B")]
	[Address(RVA = "0x309A02C", Offset = "0x309A02C", VA = "0x309A02C")]
	public CSSutoritoAttackRes()
	{
	}
}
