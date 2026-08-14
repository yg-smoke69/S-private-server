using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001436")]
public class RoomBasicInfo
{
	[Token(Token = "0x4008CC6")]
	[FieldOffset(Offset = "0x8")]
	public ulong id;

	[Token(Token = "0x4008CC7")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4008CC8")]
	[FieldOffset(Offset = "0x14")]
	public uint map_id;

	[Token(Token = "0x4008CC9")]
	[FieldOffset(Offset = "0x18")]
	public uint game_mode;

	[Token(Token = "0x4008CCA")]
	[FieldOffset(Offset = "0x1C")]
	public uint group_mode;

	[Token(Token = "0x4008CCB")]
	[FieldOffset(Offset = "0x20")]
	public uint cur_member_num;

	[Token(Token = "0x4008CCC")]
	[FieldOffset(Offset = "0x24")]
	public uint max_member_num;

	[Token(Token = "0x4008CCD")]
	[FieldOffset(Offset = "0x28")]
	public uint cur_spectator_num;

	[Token(Token = "0x4008CCE")]
	[FieldOffset(Offset = "0x2C")]
	public uint max_spectator_num;

	[Token(Token = "0x4008CCF")]
	[FieldOffset(Offset = "0x30")]
	public uint state;

	[Token(Token = "0x4008CD0")]
	[FieldOffset(Offset = "0x34")]
	public bool need_code;

	[Token(Token = "0x4008CD1")]
	[FieldOffset(Offset = "0x38")]
	public uint banner;

	[Token(Token = "0x4008CD2")]
	[FieldOffset(Offset = "0x3C")]
	public uint color;

	[Token(Token = "0x4008CD3")]
	[FieldOffset(Offset = "0x40")]
	public uint icon;

	[Token(Token = "0x4008CD4")]
	[FieldOffset(Offset = "0x44")]
	public uint room_type;

	[Token(Token = "0x4008CD5")]
	[FieldOffset(Offset = "0x48")]
	public uint level_visual_style;

	[Token(Token = "0x4008CD6")]
	[FieldOffset(Offset = "0x4C")]
	public string code;

	[Token(Token = "0x4008CD7")]
	[FieldOffset(Offset = "0x50")]
	public bool enable_emulator_check;

	[Token(Token = "0x4008CD8")]
	[FieldOffset(Offset = "0x54")]
	public uint room_setting;

	[Token(Token = "0x4008CD9")]
	[FieldOffset(Offset = "0x58")]
	public bool enough_room_card;

	[Token(Token = "0x4008CDA")]
	[FieldOffset(Offset = "0x59")]
	public bool owner_online;

	[Token(Token = "0x4008CDB")]
	[FieldOffset(Offset = "0x5C")]
	public uint owner_role;

	[Token(Token = "0x4008CDC")]
	[FieldOffset(Offset = "0x60")]
	public bool is_cs_advanced;

	[Token(Token = "0x4008CDD")]
	[FieldOffset(Offset = "0x64")]
	public uint language;

	[Token(Token = "0x4008CDE")]
	[FieldOffset(Offset = "0x68")]
	public bool contestant_role_check;

	[Token(Token = "0x4008CDF")]
	[FieldOffset(Offset = "0x6C")]
	public uint priority;

	[Token(Token = "0x4008CE0")]
	[FieldOffset(Offset = "0x70")]
	public uint create_time;

	[Token(Token = "0x4008CE1")]
	[FieldOffset(Offset = "0x74")]
	public uint[] workshop_tags;

	[Token(Token = "0x6007AE8")]
	[Address(RVA = "0x33E1B54", Offset = "0x33E1B54", VA = "0x33E1B54")]
	public RoomBasicInfo()
	{
	}
}
