using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001766")]
public class CSGetPersonalVideoZoneReq
{
	[Token(Token = "0x4009A2B")]
	[FieldOffset(Offset = "0x8")]
	public ulong other_account_id;

	[Token(Token = "0x4009A2C")]
	[FieldOffset(Offset = "0x10")]
	public ELive.VideoType video_type;

	[Token(Token = "0x4009A2D")]
	[FieldOffset(Offset = "0x14")]
	public uint page_id;

	[Token(Token = "0x6007DC0")]
	[Address(RVA = "0x3188560", Offset = "0x3188560", VA = "0x3188560")]
	public CSGetPersonalVideoZoneReq()
	{
	}
}
