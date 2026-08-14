using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C1D")]
public class TBTActionNonPrioritizedSelector : TBTActionPrioritizedSelector
{
	[Token(Token = "0x6018020")]
	[Address(RVA = "0x26400C8", Offset = "0x26400C8", VA = "0x26400C8")]
	public TBTActionNonPrioritizedSelector()
	{
	}

	[Token(Token = "0x6018021")]
	[Address(RVA = "0x2640150", Offset = "0x2640150", VA = "0x2640150", Slot = "4")]
	protected override bool onEvaluate(TBTWorkingData wData)
	{
		return default(bool);
	}
}
