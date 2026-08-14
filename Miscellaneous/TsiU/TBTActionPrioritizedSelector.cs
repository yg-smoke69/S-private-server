using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C21")]
public class TBTActionPrioritizedSelector : TBTAction
{
	[Token(Token = "0x2003C22")]
	protected class TBTActionPrioritizedSelectorContext : TBTActionContext
	{
		[Token(Token = "0x4019A0A")]
		[FieldOffset(Offset = "0x8")]
		internal int currentSelectedIndex;

		[Token(Token = "0x4019A0B")]
		[FieldOffset(Offset = "0xC")]
		internal int lastSelectedIndex;

		[Token(Token = "0x601802E")]
		[Address(RVA = "0x2640DA4", Offset = "0x2640DA4", VA = "0x2640DA4")]
		public TBTActionPrioritizedSelectorContext()
		{
		}
	}

	[Token(Token = "0x601802A")]
	[Address(RVA = "0x26400CC", Offset = "0x26400CC", VA = "0x26400CC")]
	public TBTActionPrioritizedSelector()
	{
	}

	[Token(Token = "0x601802B")]
	[Address(RVA = "0x2640270", Offset = "0x2640270", VA = "0x2640270", Slot = "4")]
	protected override bool onEvaluate(TBTWorkingData wData)
	{
		return default(bool);
	}

	[Token(Token = "0x601802C")]
	[Address(RVA = "0x2640B5C", Offset = "0x2640B5C", VA = "0x2640B5C", Slot = "5")]
	protected override int onUpdate(TBTWorkingData wData)
	{
		return default(int);
	}

	[Token(Token = "0x601802D")]
	[Address(RVA = "0x2640CE4", Offset = "0x2640CE4", VA = "0x2640CE4", Slot = "6")]
	protected override void onTransition(TBTWorkingData wData)
	{
	}
}
