using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018E5")]
public class CSPreviewWorkshopCodeRes
{
	[Token(Token = "0x4009E21")]
	[FieldOffset(Offset = "0x8")]
	public byte[] workshop_settings;

	[Token(Token = "0x4009E22")]
	[FieldOffset(Offset = "0xC")]
	public byte[] mode_settings;

	[Token(Token = "0x4009E23")]
	[FieldOffset(Offset = "0x10")]
	public byte[] object_attribute_settings;

	[Token(Token = "0x4009E24")]
	[FieldOffset(Offset = "0x14")]
	public string project_settings_url;

	[Token(Token = "0x4009E25")]
	[FieldOffset(Offset = "0x18")]
	public string export_settings_url;

	[Token(Token = "0x6007F3E")]
	[Address(RVA = "0x30987C0", Offset = "0x30987C0", VA = "0x30987C0")]
	public CSPreviewWorkshopCodeRes()
	{
	}
}
