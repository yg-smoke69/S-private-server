using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x2000061")]
public class SDKIAPTaskResult
{
	[Token(Token = "0x400023A")]
	[FieldOffset(Offset = "0x8")]
	public ErrorCode Code;

	[Token(Token = "0x400023B")]
	[FieldOffset(Offset = "0xC")]
	public string Msg;

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x3464A8C", Offset = "0x3464A8C", VA = "0x3464A8C")]
	public SDKIAPTaskResult()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x3464F24", Offset = "0x3464F24", VA = "0x3464F24")]
	public string IdentifySelf()
	{
		return null;
	}
}
