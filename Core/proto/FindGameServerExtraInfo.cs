using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001314")]
public class FindGameServerExtraInfo
{
	[Token(Token = "0x4008704")]
	[FieldOffset(Offset = "0x8")]
	public uint ai_cnt_per_game;

	[Token(Token = "0x6007A4C")]
	[Address(RVA = "0x30A0D64", Offset = "0x30A0D64", VA = "0x30A0D64")]
	public FindGameServerExtraInfo()
	{
	}
}
