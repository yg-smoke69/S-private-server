using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018FF")]
public class CSGetUploadWorkshopURLRes
{
	[Token(Token = "0x4009E81")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x4009E82")]
	[FieldOffset(Offset = "0x10")]
	public long update_time;

	[Token(Token = "0x4009E83")]
	[FieldOffset(Offset = "0x18")]
	public string project_settings_url;

	[Token(Token = "0x4009E84")]
	[FieldOffset(Offset = "0x1C")]
	public string export_settings_url;

	[Token(Token = "0x4009E85")]
	[FieldOffset(Offset = "0x20")]
	public List<WorkshopWordFilter> filter_contents;

	[Token(Token = "0x6007F58")]
	[Address(RVA = "0x3095FA8", Offset = "0x3095FA8", VA = "0x3095FA8")]
	public CSGetUploadWorkshopURLRes()
	{
	}
}
