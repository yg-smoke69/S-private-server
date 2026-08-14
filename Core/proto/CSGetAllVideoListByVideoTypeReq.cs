using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200176A")]
public class CSGetAllVideoListByVideoTypeReq
{
	[Token(Token = "0x4009A36")]
	[FieldOffset(Offset = "0x8")]
	public ELive.VideoType video_type;

	[Token(Token = "0x4009A37")]
	[FieldOffset(Offset = "0xC")]
	public uint page_id;

	[Token(Token = "0x6007DC4")]
	[Address(RVA = "0x31818CC", Offset = "0x31818CC", VA = "0x31818CC")]
	public CSGetAllVideoListByVideoTypeReq()
	{
	}
}
