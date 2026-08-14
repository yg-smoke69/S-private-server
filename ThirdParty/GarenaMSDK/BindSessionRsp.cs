using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x200002A")]
public class BindSessionRsp : LoginRsp
{
	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x1C")]
	public string exception;

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x344CE80", Offset = "0x344CE80", VA = "0x344CE80")]
	public BindSessionRsp()
	{
	}
}
