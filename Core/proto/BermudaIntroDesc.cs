using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B4E")]
public class BermudaIntroDesc
{
	[Token(Token = "0x400ABC0")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400ABC1")]
	[FieldOffset(Offset = "0xC")]
	public uint position_id;

	[Token(Token = "0x400ABC2")]
	[FieldOffset(Offset = "0x10")]
	public string cdn_link;

	[Token(Token = "0x400ABC3")]
	[FieldOffset(Offset = "0x14")]
	public string title;

	[Token(Token = "0x400ABC4")]
	[FieldOffset(Offset = "0x18")]
	public string desc;

	[Token(Token = "0x400ABC5")]
	[FieldOffset(Offset = "0x1C")]
	public bool if_show;

	[Token(Token = "0x60081A9")]
	[Address(RVA = "0x317BA90", Offset = "0x317BA90", VA = "0x317BA90")]
	public BermudaIntroDesc()
	{
	}
}
