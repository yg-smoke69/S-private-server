using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B4C")]
public class BermudaSettingsDesc
{
	[Token(Token = "0x400ABB8")]
	[FieldOffset(Offset = "0x8")]
	public string movie;

	[Token(Token = "0x400ABB9")]
	[FieldOffset(Offset = "0xC")]
	public uint mode_jump_go_pos;

	[Token(Token = "0x400ABBA")]
	[FieldOffset(Offset = "0x10")]
	public uint mode_jump_sub_go_pos;

	[Token(Token = "0x400ABBB")]
	[FieldOffset(Offset = "0x14")]
	public uint item_id;

	[Token(Token = "0x60081A7")]
	[Address(RVA = "0x317BB50", Offset = "0x317BB50", VA = "0x317BB50")]
	public BermudaSettingsDesc()
	{
	}
}
