using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B87")]
internal class WriterContext
{
	[Token(Token = "0x40195BD")]
	[FieldOffset(Offset = "0x8")]
	public int Count;

	[Token(Token = "0x40195BE")]
	[FieldOffset(Offset = "0xC")]
	public bool InArray;

	[Token(Token = "0x40195BF")]
	[FieldOffset(Offset = "0xD")]
	public bool InObject;

	[Token(Token = "0x40195C0")]
	[FieldOffset(Offset = "0xE")]
	public bool ExpectingValue;

	[Token(Token = "0x40195C1")]
	[FieldOffset(Offset = "0x10")]
	public int Padding;

	[Token(Token = "0x6017BD8")]
	[Address(RVA = "0x1C629E0", Offset = "0x1C629E0", VA = "0x1C629E0")]
	public WriterContext()
	{
	}
}
