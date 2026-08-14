using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C2C")]
public class TBTPreconditionNOT : TBTPreconditionUnary
{
	[Token(Token = "0x6018043")]
	[Address(RVA = "0x26413D0", Offset = "0x26413D0", VA = "0x26413D0")]
	public TBTPreconditionNOT(TBTPrecondition lhs)
	{
	}

	[Token(Token = "0x6018044")]
	[Address(RVA = "0x2641420", Offset = "0x2641420", VA = "0x2641420", Slot = "4")]
	public override bool IsTrue(TBTWorkingData wData)
	{
		return default(bool);
	}
}
