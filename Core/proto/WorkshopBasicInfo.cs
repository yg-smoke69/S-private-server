using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014B1")]
public class WorkshopBasicInfo
{
	[Token(Token = "0x4008F68")]
	[FieldOffset(Offset = "0x8")]
	public string workshop_name;

	[Token(Token = "0x4008F69")]
	[FieldOffset(Offset = "0x10")]
	public ulong author_id;

	[Token(Token = "0x4008F6A")]
	[FieldOffset(Offset = "0x18")]
	public ulong perf_cost;

	[Token(Token = "0x4008F6B")]
	[FieldOffset(Offset = "0x20")]
	public long update_time;

	[Token(Token = "0x4008F6C")]
	[FieldOffset(Offset = "0x28")]
	public ulong resource_statistics;

	[Token(Token = "0x4008F6D")]
	[FieldOffset(Offset = "0x30")]
	public string author_name;

	[Token(Token = "0x4008F6E")]
	[FieldOffset(Offset = "0x38")]
	public ulong like_count;

	[Token(Token = "0x4008F6F")]
	[FieldOffset(Offset = "0x40")]
	public ulong subscribe_count;

	[Token(Token = "0x4008F70")]
	[FieldOffset(Offset = "0x48")]
	public string workshop_desc;

	[Token(Token = "0x4008F71")]
	[FieldOffset(Offset = "0x4C")]
	public uint game_mode;

	[Token(Token = "0x4008F72")]
	[FieldOffset(Offset = "0x50")]
	public uint group_mode;

	[Token(Token = "0x4008F73")]
	[FieldOffset(Offset = "0x54")]
	public uint[] tags;

	[Token(Token = "0x4008F74")]
	[FieldOffset(Offset = "0x58")]
	public byte[] mode_settings;

	[Token(Token = "0x4008F75")]
	[FieldOffset(Offset = "0x5C")]
	public uint team_count;

	[Token(Token = "0x4008F76")]
	[FieldOffset(Offset = "0x60")]
	public byte[] mini_map_settings;

	[Token(Token = "0x4008F77")]
	[FieldOffset(Offset = "0x64")]
	public byte[] mini_map_object_settings;

	[Token(Token = "0x4008F78")]
	[FieldOffset(Offset = "0x68")]
	public uint map_id;

	[Token(Token = "0x4008F79")]
	[FieldOffset(Offset = "0x6C")]
	public EWorkshop.EditorType editor_type;

	[Token(Token = "0x4008F7A")]
	[FieldOffset(Offset = "0x70")]
	public WorkshopCommentInfo comment_info;

	[Token(Token = "0x6007B12")]
	[Address(RVA = "0x33E6028", Offset = "0x33E6028", VA = "0x33E6028")]
	public WorkshopBasicInfo()
	{
	}
}
