using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200182F")]
public class CSAccountSutoritoInfo
{
	[Token(Token = "0x4009C42")]
	[FieldOffset(Offset = "0x8")]
	public uint win_round;

	[Token(Token = "0x4009C43")]
	[FieldOffset(Offset = "0xC")]
	public uint enemy_stage;

	[Token(Token = "0x4009C44")]
	[FieldOffset(Offset = "0x10")]
	public uint player_health;

	[Token(Token = "0x4009C45")]
	[FieldOffset(Offset = "0x14")]
	public uint enemy_health;

	[Token(Token = "0x4009C46")]
	[FieldOffset(Offset = "0x18")]
	public ELimitedEvent.SutoritoCharacter character;

	[Token(Token = "0x6007E89")]
	[Address(RVA = "0x317D870", Offset = "0x317D870", VA = "0x317D870")]
	public CSAccountSutoritoInfo()
	{
	}
}
