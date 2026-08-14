using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E8E")]
public class ActivenessInfo
{
	[Token(Token = "0x4011C61")]
	[FieldOffset(Offset = "0x8")]
	public uint group_id;

	[Token(Token = "0x4011C62")]
	[FieldOffset(Offset = "0xC")]
	public uint obtain_daily_activeness;

	[Token(Token = "0x4011C63")]
	[FieldOffset(Offset = "0x10")]
	public uint obtain_weekly_activeness;

	[Token(Token = "0x4011C64")]
	[FieldOffset(Offset = "0x14")]
	public uint last_daily_reward_need_activeness;

	[Token(Token = "0x4011C65")]
	[FieldOffset(Offset = "0x18")]
	public uint weekly_reward_need_activeness;

	[Token(Token = "0x60136C8")]
	[Address(RVA = "0x14B93B4", Offset = "0x14B93B4", VA = "0x14B93B4")]
	public ActivenessInfo()
	{
	}
}
