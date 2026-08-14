using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001918")]
public class CSPurchaseLimitedChestReq
{
	[Token(Token = "0x4009EBD")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x4009EBE")]
	[FieldOffset(Offset = "0xC")]
	public uint chest_sub_id;

	[Token(Token = "0x4009EBF")]
	[FieldOffset(Offset = "0x10")]
	public uint show_type;

	[Token(Token = "0x6007F71")]
	[Address(RVA = "0x309892C", Offset = "0x309892C", VA = "0x309892C")]
	public CSPurchaseLimitedChestReq()
	{
	}
}
