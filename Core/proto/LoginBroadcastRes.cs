using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001763")]
public class LoginBroadcastRes
{
	[Token(Token = "0x4009A22")]
	[FieldOffset(Offset = "0x8")]
	public CSScrollMarqueeRes scroll_res;

	[Token(Token = "0x4009A23")]
	[FieldOffset(Offset = "0xC")]
	public CSGetBroadcastListRes broadcast_res;

	[Token(Token = "0x6007DBD")]
	[Address(RVA = "0x30A6848", Offset = "0x30A6848", VA = "0x30A6848")]
	public LoginBroadcastRes()
	{
	}
}
