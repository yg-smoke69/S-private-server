using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018DC")]
public class CSUploadWorkshopReq
{
	[Token(Token = "0x4009DF9")]
	[FieldOffset(Offset = "0x8")]
	public string workshop_name;

	[Token(Token = "0x4009DFA")]
	[FieldOffset(Offset = "0x10")]
	public ulong performance_cost;

	[Token(Token = "0x4009DFB")]
	[FieldOffset(Offset = "0x18")]
	public byte[] workshop_settings;

	[Token(Token = "0x4009DFC")]
	[FieldOffset(Offset = "0x1C")]
	public uint slot_id;

	[Token(Token = "0x4009DFD")]
	[FieldOffset(Offset = "0x20")]
	public ulong resource_statistics;

	[Token(Token = "0x4009DFE")]
	[FieldOffset(Offset = "0x28")]
	public string workshop_desc;

	[Token(Token = "0x4009DFF")]
	[FieldOffset(Offset = "0x2C")]
	public uint game_mode;

	[Token(Token = "0x4009E00")]
	[FieldOffset(Offset = "0x30")]
	public byte[] mode_settings;

	[Token(Token = "0x4009E01")]
	[FieldOffset(Offset = "0x34")]
	public uint group_mode;

	[Token(Token = "0x4009E02")]
	[FieldOffset(Offset = "0x38")]
	public uint[] tags;

	[Token(Token = "0x4009E03")]
	[FieldOffset(Offset = "0x3C")]
	public byte[] object_attribute_settings;

	[Token(Token = "0x4009E04")]
	[FieldOffset(Offset = "0x40")]
	public uint team_count;

	[Token(Token = "0x4009E05")]
	[FieldOffset(Offset = "0x44")]
	public byte[] mini_map_settings;

	[Token(Token = "0x4009E06")]
	[FieldOffset(Offset = "0x48")]
	public byte[] mini_map_object_settings;

	[Token(Token = "0x6007F35")]
	[Address(RVA = "0x309A800", Offset = "0x309A800", VA = "0x309A800")]
	public CSUploadWorkshopReq()
	{
	}
}
