using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019D2")]
public class ActivityLocalizationDesc
{
	[Token(Token = "0x400A1E6")]
	[FieldOffset(Offset = "0x8")]
	public uint activity_id;

	[Token(Token = "0x400A1E7")]
	[FieldOffset(Offset = "0xC")]
	public string act_title;

	[Token(Token = "0x400A1E8")]
	[FieldOffset(Offset = "0x10")]
	public string act_text;

	[Token(Token = "0x400A1E9")]
	[FieldOffset(Offset = "0x14")]
	public string image_url;

	[Token(Token = "0x400A1EA")]
	[FieldOffset(Offset = "0x18")]
	public string image_url_for_lobby;

	[Token(Token = "0x400A1EB")]
	[FieldOffset(Offset = "0x1C")]
	public string award_context;

	[Token(Token = "0x400A1EC")]
	[FieldOffset(Offset = "0x20")]
	public string language;

	[Token(Token = "0x400A1ED")]
	[FieldOffset(Offset = "0x24")]
	public string image_url_for_top_up;

	[Token(Token = "0x600802A")]
	[Address(RVA = "0x317A4C0", Offset = "0x317A4C0", VA = "0x317A4C0")]
	public ActivityLocalizationDesc()
	{
	}
}
