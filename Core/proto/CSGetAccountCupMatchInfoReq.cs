using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200157A")]
public class CSGetAccountCupMatchInfoReq
{
	[Token(Token = "0x400934A")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x400934B")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x6007BC2")]
	[Address(RVA = "0x3180AC8", Offset = "0x3180AC8", VA = "0x3180AC8")]
	public CSGetAccountCupMatchInfoReq()
	{
	}
}
