using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018C7")]
public class CSMusicFestSendPuzzleTokenReq
{
	[Token(Token = "0x4009DD5")]
	[FieldOffset(Offset = "0x8")]
	public ulong receiver_id;

	[Token(Token = "0x4009DD6")]
	[FieldOffset(Offset = "0x10")]
	public uint token_id;

	[Token(Token = "0x4009DD7")]
	[FieldOffset(Offset = "0x14")]
	public uint source_type;

	[Token(Token = "0x6007F20")]
	[Address(RVA = "0x3098080", Offset = "0x3098080", VA = "0x3098080")]
	public CSMusicFestSendPuzzleTokenReq()
	{
	}
}
