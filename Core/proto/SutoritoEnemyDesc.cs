using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B5A")]
public class SutoritoEnemyDesc
{
	[Token(Token = "0x400AC15")]
	[FieldOffset(Offset = "0x8")]
	public uint stage;

	[Token(Token = "0x400AC16")]
	[FieldOffset(Offset = "0xC")]
	public uint light_punch;

	[Token(Token = "0x400AC17")]
	[FieldOffset(Offset = "0x10")]
	public uint heavy_punch;

	[Token(Token = "0x400AC18")]
	[FieldOffset(Offset = "0x14")]
	public uint unique_punch;

	[Token(Token = "0x400AC19")]
	[FieldOffset(Offset = "0x18")]
	public uint enemy_health;

	[Token(Token = "0x400AC1A")]
	[FieldOffset(Offset = "0x1C")]
	public uint player_health;

	[Token(Token = "0x400AC1B")]
	[FieldOffset(Offset = "0x20")]
	public AwardDesc reward;

	[Token(Token = "0x400AC1C")]
	[FieldOffset(Offset = "0x24")]
	public ELimitedEvent.SutoritoCharacter character;

	[Token(Token = "0x400AC1D")]
	[FieldOffset(Offset = "0x28")]
	public string stage_name;

	[Token(Token = "0x400AC1E")]
	[FieldOffset(Offset = "0x2C")]
	public uint next_stage;

	[Token(Token = "0x60081B5")]
	[Address(RVA = "0x33E30A8", Offset = "0x33E30A8", VA = "0x33E30A8")]
	public SutoritoEnemyDesc()
	{
	}
}
