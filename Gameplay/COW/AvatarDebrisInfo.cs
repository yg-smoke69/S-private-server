using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003140")]
public class AvatarDebrisInfo
{
	[Token(Token = "0x4012B4E")]
	[FieldOffset(Offset = "0x8")]
	public uint PurchaseCount;

	[Token(Token = "0x4012B4F")]
	[FieldOffset(Offset = "0xC")]
	public uint GoldPrice;

	[Token(Token = "0x4012B50")]
	[FieldOffset(Offset = "0x10")]
	public uint GemPrice;

	[Token(Token = "0x6014A61")]
	[Address(RVA = "0x10FCB24", Offset = "0x10FCB24", VA = "0x10FCB24")]
	public AvatarDebrisInfo()
	{
	}
}
