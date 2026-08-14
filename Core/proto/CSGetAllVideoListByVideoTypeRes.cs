using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200176B")]
public class CSGetAllVideoListByVideoTypeRes
{
	[Token(Token = "0x4009A38")]
	[FieldOffset(Offset = "0x8")]
	public List<VideoDetail> video_list;

	[Token(Token = "0x6007DC5")]
	[Address(RVA = "0x31818D4", Offset = "0x31818D4", VA = "0x31818D4")]
	public CSGetAllVideoListByVideoTypeRes()
	{
	}
}
