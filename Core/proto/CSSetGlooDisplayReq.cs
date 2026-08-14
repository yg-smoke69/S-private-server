using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015CA")]
public class CSSetGlooDisplayReq
{
	[Token(Token = "0x4009449")]
	[FieldOffset(Offset = "0x8")]
	public uint gloo_display_id;

	[Token(Token = "0x400944A")]
	[FieldOffset(Offset = "0xC")]
	public uint auto_rotate;

	[Token(Token = "0x6007C14")]
	[Address(RVA = "0x3099B38", Offset = "0x3099B38", VA = "0x3099B38")]
	public CSSetGlooDisplayReq()
	{
	}
}
