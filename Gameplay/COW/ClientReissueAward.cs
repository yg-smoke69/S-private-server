using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200317E")]
public class ClientReissueAward
{
	[Token(Token = "0x4012D0E")]
	[FieldOffset(Offset = "0x8")]
	public AwardDesc Award;

	[Token(Token = "0x4012D0F")]
	[FieldOffset(Offset = "0xC")]
	public EVipCard.VipCardType VipCardType;

	[Token(Token = "0x6014CB1")]
	[Address(RVA = "0x172C8E0", Offset = "0x172C8E0", VA = "0x172C8E0")]
	public ClientReissueAward()
	{
	}
}
