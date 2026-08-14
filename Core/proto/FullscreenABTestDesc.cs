using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A99")]
public class FullscreenABTestDesc
{
	[Token(Token = "0x400A6A9")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A6AA")]
	[FieldOffset(Offset = "0xC")]
	public uint account_id;

	[Token(Token = "0x400A6AB")]
	[FieldOffset(Offset = "0x10")]
	public uint anim_id;

	[Token(Token = "0x400A6AC")]
	[FieldOffset(Offset = "0x14")]
	public uint anim_type;

	[Token(Token = "0x400A6AD")]
	[FieldOffset(Offset = "0x18")]
	public uint system_pos;

	[Token(Token = "0x400A6AE")]
	[FieldOffset(Offset = "0x1C")]
	public uint go_pos;

	[Token(Token = "0x400A6AF")]
	[FieldOffset(Offset = "0x20")]
	public string fullscreen_resource_id_a;

	[Token(Token = "0x400A6B0")]
	[FieldOffset(Offset = "0x24")]
	public string fullscreen_resource_id_b;

	[Token(Token = "0x400A6B1")]
	[FieldOffset(Offset = "0x28")]
	public string skin_resource_list_a;

	[Token(Token = "0x400A6B2")]
	[FieldOffset(Offset = "0x2C")]
	public string skin_resource_list_b;

	[Token(Token = "0x60080F6")]
	[Address(RVA = "0x30A14A4", Offset = "0x30A14A4", VA = "0x30A14A4")]
	public FullscreenABTestDesc()
	{
	}
}
