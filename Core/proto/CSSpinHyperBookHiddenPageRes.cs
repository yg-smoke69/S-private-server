using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200198F")]
public class CSSpinHyperBookHiddenPageRes
{
	[Token(Token = "0x400A015")]
	[FieldOffset(Offset = "0x8")]
	public uint book_id;

	[Token(Token = "0x400A016")]
	[FieldOffset(Offset = "0xC")]
	public bool hidden_unlocked;

	[Token(Token = "0x400A017")]
	[FieldOffset(Offset = "0x10")]
	public uint spin_num;

	[Token(Token = "0x400A018")]
	[FieldOffset(Offset = "0x14")]
	public ExchangeChangeData award;

	[Token(Token = "0x6007FEA")]
	[Address(RVA = "0x3099D58", Offset = "0x3099D58", VA = "0x3099D58")]
	public CSSpinHyperBookHiddenPageRes()
	{
	}
}
