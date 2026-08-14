using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001605")]
public class CSGetActivityDescReq
{
	[Token(Token = "0x40094D1")]
	[FieldOffset(Offset = "0x8")]
	public string language;

	[Token(Token = "0x40094D2")]
	[FieldOffset(Offset = "0xC")]
	public uint platform;

	[Token(Token = "0x40094D3")]
	[FieldOffset(Offset = "0x10")]
	public uint client_type;

	[Token(Token = "0x6007C4F")]
	[Address(RVA = "0x3180FC4", Offset = "0x3180FC4", VA = "0x3180FC4")]
	public CSGetActivityDescReq()
	{
	}
}
