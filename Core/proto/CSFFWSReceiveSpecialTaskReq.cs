using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001887")]
public class CSFFWSReceiveSpecialTaskReq
{
	[Token(Token = "0x4009D26")]
	[FieldOffset(Offset = "0x8")]
	public uint index_id;

	[Token(Token = "0x4009D27")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x6007EE0")]
	[Address(RVA = "0x31803C4", Offset = "0x31803C4", VA = "0x31803C4")]
	public CSFFWSReceiveSpecialTaskReq()
	{
	}
}
