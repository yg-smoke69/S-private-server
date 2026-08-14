using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001883")]
public class CSStartFFWSGuessingReq
{
	[Token(Token = "0x4009D22")]
	[FieldOffset(Offset = "0x8")]
	public uint session;

	[Token(Token = "0x4009D23")]
	[FieldOffset(Offset = "0xC")]
	public uint team_id;

	[Token(Token = "0x6007EDC")]
	[Address(RVA = "0x3099EA4", Offset = "0x3099EA4", VA = "0x3099EA4")]
	public CSStartFFWSGuessingReq()
	{
	}
}
