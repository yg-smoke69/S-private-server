using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B70")]
public class BooyahChessSettingDesc
{
	[Token(Token = "0x400AC91")]
	[FieldOffset(Offset = "0x8")]
	public uint ticket_id;

	[Token(Token = "0x400AC92")]
	[FieldOffset(Offset = "0xC")]
	public uint ticket;

	[Token(Token = "0x400AC93")]
	[FieldOffset(Offset = "0x10")]
	public uint max_step;

	[Token(Token = "0x400AC94")]
	[FieldOffset(Offset = "0x14")]
	public uint reward_id;

	[Token(Token = "0x400AC95")]
	[FieldOffset(Offset = "0x18")]
	public uint enemy_reward_lower;

	[Token(Token = "0x400AC96")]
	[FieldOffset(Offset = "0x1C")]
	public uint enemy_reward_upper;

	[Token(Token = "0x400AC97")]
	[FieldOffset(Offset = "0x20")]
	public uint enemy_cnt;

	[Token(Token = "0x400AC98")]
	[FieldOffset(Offset = "0x24")]
	public uint chest_reward;

	[Token(Token = "0x400AC99")]
	[FieldOffset(Offset = "0x28")]
	public uint chest_cnt;

	[Token(Token = "0x400AC9A")]
	[FieldOffset(Offset = "0x2C")]
	public uint booyah_reward;

	[Token(Token = "0x400AC9B")]
	[FieldOffset(Offset = "0x30")]
	public uint ticket_increment;

	[Token(Token = "0x400AC9C")]
	[FieldOffset(Offset = "0x34")]
	public uint ticket_max;

	[Token(Token = "0x60081CB")]
	[Address(RVA = "0x317C8B4", Offset = "0x317C8B4", VA = "0x317C8B4")]
	public BooyahChessSettingDesc()
	{
	}
}
