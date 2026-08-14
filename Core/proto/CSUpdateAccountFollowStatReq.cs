using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200176D")]
public class CSUpdateAccountFollowStatReq
{
	[Token(Token = "0x4009A3B")]
	[FieldOffset(Offset = "0x8")]
	public ulong streamer_id;

	[Token(Token = "0x4009A3C")]
	[FieldOffset(Offset = "0x10")]
	public ELive.FollowerType follower_type;

	[Token(Token = "0x6007DC7")]
	[Address(RVA = "0x309A618", Offset = "0x309A618", VA = "0x309A618")]
	public CSUpdateAccountFollowStatReq()
	{
	}
}
