using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20021E0")]
public class SlotClothInfo
{
	[Token(Token = "0x400D3DE")]
	[FieldOffset(Offset = "0x8")]
	public uint clothID;

	[Token(Token = "0x400D3DF")]
	[FieldOffset(Offset = "0xC")]
	public uint tabType;

	[Token(Token = "0x600B5B2")]
	[Address(RVA = "0x20F28D4", Offset = "0x20F28D4", VA = "0x20F28D4")]
	public SlotClothInfo(uint clothID, uint tabType)
	{
	}
}
