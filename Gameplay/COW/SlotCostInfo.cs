using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DA4")]
public class SlotCostInfo
{
	[Token(Token = "0x4011851")]
	[FieldOffset(Offset = "0x8")]
	public int slot_id;

	[Token(Token = "0x4011852")]
	[FieldOffset(Offset = "0xC")]
	public int coins;

	[Token(Token = "0x4011853")]
	[FieldOffset(Offset = "0x10")]
	public int gems;

	[Token(Token = "0x60131D1")]
	[Address(RVA = "0x20F28FC", Offset = "0x20F28FC", VA = "0x20F28FC")]
	public SlotCostInfo(int _slot, int _coin, int _gem)
	{
	}
}
