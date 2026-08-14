using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018F6")]
public class CSSendWorkshopLikeReq
{
	[Token(Token = "0x4009E47")]
	[FieldOffset(Offset = "0x8")]
	public string workshop_code;

	[Token(Token = "0x4009E48")]
	[FieldOffset(Offset = "0x10")]
	public ulong match_id;

	[Token(Token = "0x4009E49")]
	[FieldOffset(Offset = "0x18")]
	public EWorkshop.LikeType like_type;

	[Token(Token = "0x4009E4A")]
	[FieldOffset(Offset = "0x1C")]
	public uint match_mode;

	[Token(Token = "0x4009E4B")]
	[FieldOffset(Offset = "0x20")]
	public uint game_mode;

	[Token(Token = "0x6007F4F")]
	[Address(RVA = "0x3099958", Offset = "0x3099958", VA = "0x3099958")]
	public CSSendWorkshopLikeReq()
	{
	}
}
