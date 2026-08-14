using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C2F")]
public class TBTPreconditionXOR : TBTPreconditionBinary
{
	[Token(Token = "0x6018049")]
	[Address(RVA = "0x26415C0", Offset = "0x26415C0", VA = "0x26415C0")]
	public TBTPreconditionXOR(TBTPrecondition lhs, TBTPrecondition rhs)
	{
	}

	[Token(Token = "0x601804A")]
	[Address(RVA = "0x26415C4", Offset = "0x26415C4", VA = "0x26415C4", Slot = "4")]
	public override bool IsTrue(TBTWorkingData wData)
	{
		return default(bool);
	}
}
