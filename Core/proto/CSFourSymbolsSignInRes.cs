using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018BE")]
public class CSFourSymbolsSignInRes
{
	[Token(Token = "0x4009DBA")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4009DBB")]
	[FieldOffset(Offset = "0xC")]
	public bool signed;

	[Token(Token = "0x4009DBC")]
	[FieldOffset(Offset = "0x10")]
	public ELimitedEvent.FourSymbolsID symbol;

	[Token(Token = "0x4009DBD")]
	[FieldOffset(Offset = "0x14")]
	public uint accumulated_days;

	[Token(Token = "0x6007F17")]
	[Address(RVA = "0x31808AC", Offset = "0x31808AC", VA = "0x31808AC")]
	public CSFourSymbolsSignInRes()
	{
	}
}
