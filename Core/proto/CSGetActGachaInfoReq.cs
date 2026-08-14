using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016DC")]
public class CSGetActGachaInfoReq
{
	[Token(Token = "0x4009783")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x4009784")]
	[FieldOffset(Offset = "0xC")]
	public uint chest_sub_id;

	[Token(Token = "0x6007D36")]
	[Address(RVA = "0x3180F30", Offset = "0x3180F30", VA = "0x3180F30")]
	public CSGetActGachaInfoReq()
	{
	}
}
