using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016F1")]
public class CSFlipCardReq
{
	[Token(Token = "0x4009800")]
	[FieldOffset(Offset = "0x8")]
	public bool is_pve;

	[Token(Token = "0x4009801")]
	[FieldOffset(Offset = "0x9")]
	public bool is_all;

	[Token(Token = "0x4009802")]
	[FieldOffset(Offset = "0xC")]
	public uint flip_order;

	[Token(Token = "0x6007D4B")]
	[Address(RVA = "0x318088C", Offset = "0x318088C", VA = "0x318088C")]
	public CSFlipCardReq()
	{
	}
}
