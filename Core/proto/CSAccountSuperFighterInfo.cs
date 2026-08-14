using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001822")]
public class CSAccountSuperFighterInfo
{
	[Token(Token = "0x4009C1E")]
	[FieldOffset(Offset = "0x8")]
	public uint win_round;

	[Token(Token = "0x4009C1F")]
	[FieldOffset(Offset = "0xC")]
	public uint enemy_stage;

	[Token(Token = "0x4009C20")]
	[FieldOffset(Offset = "0x10")]
	public uint player_health;

	[Token(Token = "0x4009C21")]
	[FieldOffset(Offset = "0x14")]
	public uint enemy_health;

	[Token(Token = "0x6007E7C")]
	[Address(RVA = "0x317D868", Offset = "0x317D868", VA = "0x317D868")]
	public CSAccountSuperFighterInfo()
	{
	}
}
