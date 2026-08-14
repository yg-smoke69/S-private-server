using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016BE")]
public class CSAnnouncementReq
{
	[Token(Token = "0x40096DD")]
	[FieldOffset(Offset = "0x8")]
	public string language;

	[Token(Token = "0x40096DE")]
	[FieldOffset(Offset = "0xC")]
	public EAnnouncement.Os os;

	[Token(Token = "0x40096DF")]
	[FieldOffset(Offset = "0x10")]
	public EAnnouncement.AndroidChannel android_channel;

	[Token(Token = "0x6007D1F")]
	[Address(RVA = "0x317DB48", Offset = "0x317DB48", VA = "0x317DB48")]
	public CSAnnouncementReq()
	{
	}
}
