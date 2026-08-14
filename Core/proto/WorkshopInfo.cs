using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014B2")]
public class WorkshopInfo
{
	[Token(Token = "0x4008F7B")]
	[FieldOffset(Offset = "0x8")]
	public byte[] workshop_settings;

	[Token(Token = "0x4008F7C")]
	[FieldOffset(Offset = "0xC")]
	public string workshop_code;

	[Token(Token = "0x4008F7D")]
	[FieldOffset(Offset = "0x10")]
	public WorkshopBasicInfo workshop_basic_info;

	[Token(Token = "0x4008F7E")]
	[FieldOffset(Offset = "0x14")]
	public byte[] object_attribute_settings;

	[Token(Token = "0x4008F7F")]
	[FieldOffset(Offset = "0x18")]
	public string project_settings_url;

	[Token(Token = "0x4008F80")]
	[FieldOffset(Offset = "0x1C")]
	public string export_settings_url;

	[Token(Token = "0x4008F81")]
	[FieldOffset(Offset = "0x20")]
	public WorkshopRoomFreeInfo workshop_room_free_info;

	[Token(Token = "0x6007B13")]
	[Address(RVA = "0x33E6528", Offset = "0x33E6528", VA = "0x33E6528")]
	public WorkshopInfo()
	{
	}
}
