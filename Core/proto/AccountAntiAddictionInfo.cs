using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001442")]
public class AccountAntiAddictionInfo
{
	[Token(Token = "0x4008D0A")]
	[FieldOffset(Offset = "0x8")]
	public EAntiAddiction.TotalTimeBanMode ban_mode;

	[Token(Token = "0x4008D0B")]
	[FieldOffset(Offset = "0xC")]
	public uint unban_time;

	[Token(Token = "0x6007AF1")]
	[Address(RVA = "0x3179420", Offset = "0x3179420", VA = "0x3179420")]
	public AccountAntiAddictionInfo()
	{
	}
}
