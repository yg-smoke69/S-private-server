using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A97")]
public class PatchOptionalResManagerUpdateDesc
{
	[Token(Token = "0x400A680")]
	[FieldOffset(Offset = "0x8")]
	public uint optional_re_def_id;

	[Token(Token = "0x400A681")]
	[FieldOffset(Offset = "0xC")]
	public bool is_download;

	[Token(Token = "0x400A682")]
	[FieldOffset(Offset = "0xD")]
	public bool is_show;

	[Token(Token = "0x400A683")]
	[FieldOffset(Offset = "0x10")]
	public long show_time;

	[Token(Token = "0x400A684")]
	[FieldOffset(Offset = "0x18")]
	public long end_time;

	[Token(Token = "0x400A685")]
	[FieldOffset(Offset = "0x20")]
	public bool hide_after_download;

	[Token(Token = "0x400A686")]
	[FieldOffset(Offset = "0x21")]
	public bool is_delete;

	[Token(Token = "0x400A687")]
	[FieldOffset(Offset = "0x22")]
	public bool hide_in_login;

	[Token(Token = "0x400A688")]
	[FieldOffset(Offset = "0x24")]
	public uint download_hardware;

	[Token(Token = "0x400A689")]
	[FieldOffset(Offset = "0x28")]
	public uint auto_download_hardware;

	[Token(Token = "0x400A68A")]
	[FieldOffset(Offset = "0x2C")]
	public uint download_sort_id;

	[Token(Token = "0x400A68B")]
	[FieldOffset(Offset = "0x30")]
	public uint gopos;

	[Token(Token = "0x400A68C")]
	[FieldOffset(Offset = "0x34")]
	public string sub_gopos;

	[Token(Token = "0x400A68D")]
	[FieldOffset(Offset = "0x38")]
	public bool force_download;

	[Token(Token = "0x60080F4")]
	[Address(RVA = "0x33DF01C", Offset = "0x33DF01C", VA = "0x33DF01C")]
	public PatchOptionalResManagerUpdateDesc()
	{
	}
}
