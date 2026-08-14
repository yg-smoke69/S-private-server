using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001775")]
public class CSGetSingleFollowTypeRes
{
	[Token(Token = "0x4009A53")]
	[FieldOffset(Offset = "0x8")]
	public bool is_streamer;

	[Token(Token = "0x4009A54")]
	[FieldOffset(Offset = "0xC")]
	public ELive.FollowerType follower_type;

	[Token(Token = "0x6007DCF")]
	[Address(RVA = "0x309546C", Offset = "0x309546C", VA = "0x309546C")]
	public CSGetSingleFollowTypeRes()
	{
	}
}
