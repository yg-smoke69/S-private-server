using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002785")]
internal class UIItem
{
	[Token(Token = "0x400F3F9")]
	[FieldOffset(Offset = "0x8")]
	public AAHMJHHPECM ParentItem;

	[Token(Token = "0x400F3FA")]
	[FieldOffset(Offset = "0xC")]
	public int Count;

	[Token(Token = "0x400F3FB")]
	[FieldOffset(Offset = "0x10")]
	public int Value;

	[Token(Token = "0x400F3FC")]
	[FieldOffset(Offset = "0x14")]
	public bool ChangeHighlight;

	[Token(Token = "0x600F2C5")]
	[Address(RVA = "0x1ADE918", Offset = "0x1ADE918", VA = "0x1ADE918")]
	public UIItem()
	{
	}
}
