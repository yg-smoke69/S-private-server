using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x2000070")]
public class LoginRsp
{
	[Token(Token = "0x400026C")]
	[FieldOffset(Offset = "0x8")]
	public ErrorCode errCode;

	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0xC")]
	public string openID;

	[Token(Token = "0x400026E")]
	[FieldOffset(Offset = "0x10")]
	public string accessToken;

	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0x14")]
	public int platform;

	[Token(Token = "0x4000270")]
	[FieldOffset(Offset = "0x18")]
	public int mainPlatform;

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x344CE88", Offset = "0x344CE88", VA = "0x344CE88")]
	public LoginRsp()
	{
	}
}
