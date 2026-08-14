using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016C0")]
public class CSScrollMarqueeReq
{
	[Token(Token = "0x40096E1")]
	[FieldOffset(Offset = "0x8")]
	public string lang_name;

	[Token(Token = "0x40096E2")]
	[FieldOffset(Offset = "0xC")]
	public EAnnouncement.Os os;

	[Token(Token = "0x40096E3")]
	[FieldOffset(Offset = "0x10")]
	public EAnnouncement.AndroidChannel android_channel;

	[Token(Token = "0x6007D21")]
	[Address(RVA = "0x3099570", Offset = "0x3099570", VA = "0x3099570")]
	public CSScrollMarqueeReq()
	{
	}
}
