using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C2B")]
public class TBTPreconditionFALSE : TBTPreconditionLeaf
{
	[Token(Token = "0x6018041")]
	[Address(RVA = "0x26413B8", Offset = "0x26413B8", VA = "0x26413B8")]
	public TBTPreconditionFALSE()
	{
	}

	[Token(Token = "0x6018042")]
	[Address(RVA = "0x26413C8", Offset = "0x26413C8", VA = "0x26413C8", Slot = "4")]
	public override bool IsTrue(TBTWorkingData wData)
	{
		return default(bool);
	}
}
