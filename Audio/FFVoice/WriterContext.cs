using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B58")]
internal class WriterContext
{
	[Token(Token = "0x4019453")]
	[FieldOffset(Offset = "0x8")]
	public int Count;

	[Token(Token = "0x4019454")]
	[FieldOffset(Offset = "0xC")]
	public bool InArray;

	[Token(Token = "0x4019455")]
	[FieldOffset(Offset = "0xD")]
	public bool InObject;

	[Token(Token = "0x4019456")]
	[FieldOffset(Offset = "0xE")]
	public bool ExpectingValue;

	[Token(Token = "0x4019457")]
	[FieldOffset(Offset = "0x10")]
	public int Padding;

	[Token(Token = "0x60179E6")]
	[Address(RVA = "0x26A52A8", Offset = "0x26A52A8", VA = "0x26A52A8")]
	public WriterContext()
	{
	}
}
