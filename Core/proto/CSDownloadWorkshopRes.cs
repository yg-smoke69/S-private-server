using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018E1")]
public class CSDownloadWorkshopRes
{
	[Token(Token = "0x4009E13")]
	[FieldOffset(Offset = "0x8")]
	public byte[] workshop_settings;

	[Token(Token = "0x4009E14")]
	[FieldOffset(Offset = "0xC")]
	public EWorkshop.SlotType slot_type;

	[Token(Token = "0x4009E15")]
	[FieldOffset(Offset = "0x10")]
	public uint slot_id;

	[Token(Token = "0x4009E16")]
	[FieldOffset(Offset = "0x14")]
	public byte[] mode_settings;

	[Token(Token = "0x4009E17")]
	[FieldOffset(Offset = "0x18")]
	public byte[] object_attribute_settings;

	[Token(Token = "0x4009E18")]
	[FieldOffset(Offset = "0x1C")]
	public string project_settings_url;

	[Token(Token = "0x4009E19")]
	[FieldOffset(Offset = "0x20")]
	public string export_settings_url;

	[Token(Token = "0x6007F3A")]
	[Address(RVA = "0x317FABC", Offset = "0x317FABC", VA = "0x317FABC")]
	public CSDownloadWorkshopRes()
	{
	}
}
