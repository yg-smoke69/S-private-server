using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001594")]
public class CSToggleCupTicketReq
{
	[Token(Token = "0x4009394")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x4009395")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x6007BDC")]
	[Address(RVA = "0x309A464", Offset = "0x309A464", VA = "0x309A464")]
	public CSToggleCupTicketReq()
	{
	}
}
