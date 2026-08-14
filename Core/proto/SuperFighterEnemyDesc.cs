using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B54")]
public class SuperFighterEnemyDesc
{
	[Token(Token = "0x400ABE2")]
	[FieldOffset(Offset = "0x8")]
	public uint stage;

	[Token(Token = "0x400ABE3")]
	[FieldOffset(Offset = "0xC")]
	public uint light_punch;

	[Token(Token = "0x400ABE4")]
	[FieldOffset(Offset = "0x10")]
	public uint heavy_punch;

	[Token(Token = "0x400ABE5")]
	[FieldOffset(Offset = "0x14")]
	public uint unique_punch;

	[Token(Token = "0x400ABE6")]
	[FieldOffset(Offset = "0x18")]
	public uint enemy_health;

	[Token(Token = "0x400ABE7")]
	[FieldOffset(Offset = "0x1C")]
	public uint player_health;

	[Token(Token = "0x400ABE8")]
	[FieldOffset(Offset = "0x20")]
	public AwardDesc reward;

	[Token(Token = "0x60081AF")]
	[Address(RVA = "0x33E2D70", Offset = "0x33E2D70", VA = "0x33E2D70")]
	public SuperFighterEnemyDesc()
	{
	}
}
