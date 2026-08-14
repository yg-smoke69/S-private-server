using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002139")]
public class SkyboardDisplayItemData
{
	[Token(Token = "0x400D051")]
	[FieldOffset(Offset = "0x8")]
	public SkyboardBaseInfo Info;

	[Token(Token = "0x400D052")]
	[FieldOffset(Offset = "0xC")]
	public bool IsEquipped;

	[Token(Token = "0x600AE69")]
	[Address(RVA = "0x20F2550", Offset = "0x20F2550", VA = "0x20F2550")]
	public SkyboardDisplayItemData()
	{
	}

	[Token(Token = "0x600AE6A")]
	[Address(RVA = "0x20F2558", Offset = "0x20F2558", VA = "0x20F2558")]
	public int CompareTo(SkyboardDisplayItemData other)
	{
		return default(int);
	}
}
