using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C2A")]
public class TBTPreconditionTRUE : TBTPreconditionLeaf
{
	[Token(Token = "0x601803F")]
	[Address(RVA = "0x26415B0", Offset = "0x26415B0", VA = "0x26415B0")]
	public TBTPreconditionTRUE()
	{
	}

	[Token(Token = "0x6018040")]
	[Address(RVA = "0x26415B8", Offset = "0x26415B8", VA = "0x26415B8", Slot = "4")]
	public override bool IsTrue(TBTWorkingData wData)
	{
		return default(bool);
	}
}
