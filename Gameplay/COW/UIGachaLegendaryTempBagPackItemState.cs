using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002649")]
public class UIGachaLegendaryTempBagPackItemState
{
	[Token(Token = "0x400EC76")]
	[FieldOffset(Offset = "0x8")]
	public uint UniquePrizeID;

	[Token(Token = "0x400EC77")]
	[FieldOffset(Offset = "0xC")]
	public int RealIndex;

	[Token(Token = "0x400EC78")]
	[FieldOffset(Offset = "0x10")]
	public GachaShowItem Item;

	[Token(Token = "0x400EC79")]
	[FieldOffset(Offset = "0x14")]
	public bool IsSelected;

	[Token(Token = "0x400EC7A")]
	[FieldOffset(Offset = "0x15")]
	public bool QuickSelect;

	[Token(Token = "0x600E469")]
	[Address(RVA = "0x2E6AA34", Offset = "0x2E6AA34", VA = "0x2E6AA34")]
	public UIGachaLegendaryTempBagPackItemState(GachaShowItem item, int realIndex)
	{
	}
}
