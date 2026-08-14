using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019ED")]
public class HackerPoolCdt
{
	[Token(Token = "0x400A2CF")]
	[FieldOffset(Offset = "0x8")]
	public EHacker.HackerPoolCdt cdt_type;

	[Token(Token = "0x400A2D0")]
	[FieldOffset(Offset = "0xC")]
	public EHacker.HackerCdtManner cdt_manner;

	[Token(Token = "0x400A2D1")]
	[FieldOffset(Offset = "0x10")]
	public string cdt_value;

	[Token(Token = "0x6008045")]
	[Address(RVA = "0x30A2E6C", Offset = "0x30A2E6C", VA = "0x30A2E6C")]
	public HackerPoolCdt()
	{
	}
}
