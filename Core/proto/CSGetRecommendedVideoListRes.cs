using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001769")]
public class CSGetRecommendedVideoListRes
{
	[Token(Token = "0x4009A35")]
	[FieldOffset(Offset = "0x8")]
	public List<VideoDetail> video_list;

	[Token(Token = "0x6007DC3")]
	[Address(RVA = "0x3095214", Offset = "0x3095214", VA = "0x3095214")]
	public CSGetRecommendedVideoListRes()
	{
	}
}
