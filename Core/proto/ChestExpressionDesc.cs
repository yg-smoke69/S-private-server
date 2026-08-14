using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A9F")]
public class ChestExpressionDesc
{
	[Token(Token = "0x400A711")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x400A712")]
	[FieldOffset(Offset = "0xC")]
	public uint chest_sub_id;

	[Token(Token = "0x400A713")]
	[FieldOffset(Offset = "0x10")]
	public uint color_id;

	[Token(Token = "0x400A714")]
	[FieldOffset(Offset = "0x14")]
	public uint chest_model_id;

	[Token(Token = "0x400A715")]
	[FieldOffset(Offset = "0x18")]
	public uint show_model_male;

	[Token(Token = "0x400A716")]
	[FieldOffset(Offset = "0x1C")]
	public uint show_model_female;

	[Token(Token = "0x400A717")]
	[FieldOffset(Offset = "0x20")]
	public uint chest_model_id2;

	[Token(Token = "0x400A718")]
	[FieldOffset(Offset = "0x24")]
	public uint chest_activity;

	[Token(Token = "0x400A719")]
	[FieldOffset(Offset = "0x28")]
	public uint extra_reward_icon;

	[Token(Token = "0x400A71A")]
	[FieldOffset(Offset = "0x2C")]
	public uint chest_hint_color;

	[Token(Token = "0x400A71B")]
	[FieldOffset(Offset = "0x30")]
	public uint[] show_type;

	[Token(Token = "0x400A71C")]
	[FieldOffset(Offset = "0x34")]
	public uint show_ui_color;

	[Token(Token = "0x400A71D")]
	[FieldOffset(Offset = "0x38")]
	public string bag_icon;

	[Token(Token = "0x400A71E")]
	[FieldOffset(Offset = "0x3C")]
	public bool is_tab_vfx;

	[Token(Token = "0x60080FC")]
	[Address(RVA = "0x309B4E0", Offset = "0x309B4E0", VA = "0x309B4E0")]
	public ChestExpressionDesc()
	{
	}
}
