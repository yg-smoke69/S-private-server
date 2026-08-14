using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C2E")]
public class TBTPreconditionOR : TBTPreconditionBinary
{
	[Token(Token = "0x6018047")]
	[Address(RVA = "0x26414BC", Offset = "0x26414BC", VA = "0x26414BC")]
	public TBTPreconditionOR(TBTPrecondition lhs, TBTPrecondition rhs)
	{
	}

	[Token(Token = "0x6018048")]
	[Address(RVA = "0x26414C0", Offset = "0x26414C0", VA = "0x26414C0", Slot = "4")]
	public override bool IsTrue(TBTWorkingData wData)
	{
		return default(bool);
	}
}
