using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001773")]
public class CSGetFollowStreamerListRes
{
	[Token(Token = "0x4009A50")]
	[FieldOffset(Offset = "0x8")]
	public List<StreamerBaseInfo> streamer_list;

	[Token(Token = "0x4009A51")]
	[FieldOffset(Offset = "0xC")]
	public List<StreamerBaseInfo> recommended_streamer_list;

	[Token(Token = "0x6007DCD")]
	[Address(RVA = "0x3184F4C", Offset = "0x3184F4C", VA = "0x3184F4C")]
	public CSGetFollowStreamerListRes()
	{
	}
}
