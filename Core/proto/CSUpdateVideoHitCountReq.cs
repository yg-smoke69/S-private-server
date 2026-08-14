using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200176C")]
public class CSUpdateVideoHitCountReq
{
	[Token(Token = "0x4009A39")]
	[FieldOffset(Offset = "0x8")]
	public ulong streamer_id;

	[Token(Token = "0x4009A3A")]
	[FieldOffset(Offset = "0x10")]
	public uint video_id;

	[Token(Token = "0x6007DC6")]
	[Address(RVA = "0x309A7D8", Offset = "0x309A7D8", VA = "0x309A7D8")]
	public CSUpdateVideoHitCountReq()
	{
	}
}
