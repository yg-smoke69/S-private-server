using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001901")]
public class CSSendWorkshopCommentTagReq
{
	[Token(Token = "0x4009E87")]
	[FieldOffset(Offset = "0x8")]
	public string workshop_code;

	[Token(Token = "0x4009E88")]
	[FieldOffset(Offset = "0xC")]
	public uint[] comment_tags;

	[Token(Token = "0x4009E89")]
	[FieldOffset(Offset = "0x10")]
	public uint comment_scene;

	[Token(Token = "0x6007F5A")]
	[Address(RVA = "0x30998B8", Offset = "0x30998B8", VA = "0x30998B8")]
	public CSSendWorkshopCommentTagReq()
	{
	}
}
