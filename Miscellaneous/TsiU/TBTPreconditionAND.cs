using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C2D")]
public class TBTPreconditionAND : TBTPreconditionBinary
{
	[Token(Token = "0x6018045")]
	[Address(RVA = "0x264119C", Offset = "0x264119C", VA = "0x264119C")]
	public TBTPreconditionAND(TBTPrecondition lhs, TBTPrecondition rhs)
	{
	}

	[Token(Token = "0x6018046")]
	[Address(RVA = "0x26411E8", Offset = "0x26411E8", VA = "0x26411E8", Slot = "4")]
	public override bool IsTrue(TBTWorkingData wData)
	{
		return default(bool);
	}
}
