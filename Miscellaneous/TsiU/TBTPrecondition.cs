using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C26")]
public abstract class TBTPrecondition : TBTTreeNode
{
	[Token(Token = "0x601803A")]
	[Address(RVA = "0x2641198", Offset = "0x2641198", VA = "0x2641198")]
	public TBTPrecondition(int maxChildCount)
	{
	}

	[Token(Token = "0x601803B")]
	public abstract bool IsTrue(TBTWorkingData wData);
}
