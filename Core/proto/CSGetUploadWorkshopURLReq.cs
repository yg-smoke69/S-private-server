using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018FE")]
public class CSGetUploadWorkshopURLReq
{
	[Token(Token = "0x4009E71")]
	[FieldOffset(Offset = "0x8")]
	public string workshop_name;

	[Token(Token = "0x4009E72")]
	[FieldOffset(Offset = "0x10")]
	public ulong performance_cost;

	[Token(Token = "0x4009E73")]
	[FieldOffset(Offset = "0x18")]
	public uint slot_id;

	[Token(Token = "0x4009E74")]
	[FieldOffset(Offset = "0x20")]
	public ulong resource_statistics;

	[Token(Token = "0x4009E75")]
	[FieldOffset(Offset = "0x28")]
	public string workshop_desc;

	[Token(Token = "0x4009E76")]
	[FieldOffset(Offset = "0x2C")]
	public uint game_mode;

	[Token(Token = "0x4009E77")]
	[FieldOffset(Offset = "0x30")]
	public byte[] mode_settings;

	[Token(Token = "0x4009E78")]
	[FieldOffset(Offset = "0x34")]
	public uint group_mode;

	[Token(Token = "0x4009E79")]
	[FieldOffset(Offset = "0x38")]
	public uint[] tags;

	[Token(Token = "0x4009E7A")]
	[FieldOffset(Offset = "0x3C")]
	public uint team_count;

	[Token(Token = "0x4009E7B")]
	[FieldOffset(Offset = "0x40")]
	public byte[] mini_map_settings;

	[Token(Token = "0x4009E7C")]
	[FieldOffset(Offset = "0x44")]
	public byte[] mini_map_object_settings;

	[Token(Token = "0x4009E7D")]
	[FieldOffset(Offset = "0x48")]
	public ulong project_settings_size;

	[Token(Token = "0x4009E7E")]
	[FieldOffset(Offset = "0x50")]
	public ulong export_settings_size;

	[Token(Token = "0x4009E7F")]
	[FieldOffset(Offset = "0x58")]
	public uint map_id;

	[Token(Token = "0x4009E80")]
	[FieldOffset(Offset = "0x5C")]
	public List<WorkshopWordFilter> filter_contents;

	[Token(Token = "0x6007F57")]
	[Address(RVA = "0x3095EC8", Offset = "0x3095EC8", VA = "0x3095EC8")]
	public CSGetUploadWorkshopURLReq()
	{
	}
}
