using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003162")]
public class AskCSPurchaseInfo
{
	[Token(Token = "0x4012C0C")]
	[FieldOffset(Offset = "0x8")]
	public IHAAMHPPLMG SenderID;

	[Token(Token = "0x4012C0D")]
	[FieldOffset(Offset = "0x20")]
	public List<uint> AskItemIDs;

	[Token(Token = "0x4012C0E")]
	[FieldOffset(Offset = "0x28")]
	public IHAAMHPPLMG PayerID;

	[Token(Token = "0x6014B73")]
	[Address(RVA = "0x14CE3BC", Offset = "0x14CE3BC", VA = "0x14CE3BC")]
	public AskCSPurchaseInfo()
	{
	}
}
