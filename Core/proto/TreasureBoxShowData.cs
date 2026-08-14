using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015E6")]
public class TreasureBoxShowData
{
	[Token(Token = "0x4009481")]
	[FieldOffset(Offset = "0x8")]
	public uint award_id;

	[Token(Token = "0x4009482")]
	[FieldOffset(Offset = "0xC")]
	public bool is_preview;

	[Token(Token = "0x4009483")]
	[FieldOffset(Offset = "0x10")]
	public uint preview_avatar;

	[Token(Token = "0x4009484")]
	[FieldOffset(Offset = "0x14")]
	public bool is_big_reward;

	[Token(Token = "0x4009485")]
	[FieldOffset(Offset = "0x18")]
	public uint award_num;

	[Token(Token = "0x4009486")]
	[FieldOffset(Offset = "0x1C")]
	public EInventory.AwardType award_type;

	[Token(Token = "0x4009487")]
	[FieldOffset(Offset = "0x20")]
	public string icon;

	[Token(Token = "0x4009488")]
	[FieldOffset(Offset = "0x24")]
	public uint reward_level;

	[Token(Token = "0x4009489")]
	[FieldOffset(Offset = "0x28")]
	public bool compose_icon;

	[Token(Token = "0x400948A")]
	[FieldOffset(Offset = "0x2C")]
	public uint award_time;

	[Token(Token = "0x400948B")]
	[FieldOffset(Offset = "0x30")]
	public bool is_preview_probability;

	[Token(Token = "0x6007C30")]
	[Address(RVA = "0x33E3A10", Offset = "0x33E3A10", VA = "0x33E3A10")]
	public TreasureBoxShowData()
	{
	}
}
