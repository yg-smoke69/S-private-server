using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016E9")]
public class GachaShowItem
{
	[Token(Token = "0x40097E1")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x40097E2")]
	[FieldOffset(Offset = "0xC")]
	public bool is_show;

	[Token(Token = "0x40097E3")]
	[FieldOffset(Offset = "0x10")]
	public uint repeated_item_id;

	[Token(Token = "0x40097E4")]
	[FieldOffset(Offset = "0x14")]
	public uint repeated_item_num;

	[Token(Token = "0x40097E5")]
	[FieldOffset(Offset = "0x18")]
	public EInventory.AwardType item_type;

	[Token(Token = "0x40097E6")]
	[FieldOffset(Offset = "0x1C")]
	public uint item_num;

	[Token(Token = "0x40097E7")]
	[FieldOffset(Offset = "0x20")]
	public uint reward_level;

	[Token(Token = "0x40097E8")]
	[FieldOffset(Offset = "0x24")]
	public uint turntable_props_type;

	[Token(Token = "0x40097E9")]
	[FieldOffset(Offset = "0x28")]
	public float drop_up_ratio;

	[Token(Token = "0x40097EA")]
	[FieldOffset(Offset = "0x2C")]
	public bool is_drop_up_buffed;

	[Token(Token = "0x40097EB")]
	[FieldOffset(Offset = "0x30")]
	public uint id;

	[Token(Token = "0x40097EC")]
	[FieldOffset(Offset = "0x34")]
	public uint item_duration;

	[Token(Token = "0x40097ED")]
	[FieldOffset(Offset = "0x38")]
	public bool token_flag;

	[Token(Token = "0x40097EE")]
	[FieldOffset(Offset = "0x39")]
	public bool un_quick_selection;

	[Token(Token = "0x40097EF")]
	[FieldOffset(Offset = "0x3C")]
	public ELottery.RareType rare_item;

	[Token(Token = "0x6007D43")]
	[Address(RVA = "0x30A1778", Offset = "0x30A1778", VA = "0x30A1778")]
	public GachaShowItem()
	{
	}
}
