using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C23")]
public class TBTActionSequence : TBTAction
{
	[Token(Token = "0x2003C24")]
	protected class TBTActionSequenceContext : TBTActionContext
	{
		[Token(Token = "0x4019A0D")]
		[FieldOffset(Offset = "0x8")]
		internal int currentSelectedIndex;

		[Token(Token = "0x6018034")]
		[Address(RVA = "0x2641178", Offset = "0x2641178", VA = "0x2641178")]
		public TBTActionSequenceContext()
		{
		}
	}

	[Token(Token = "0x4019A0C")]
	[FieldOffset(Offset = "0x18")]
	private bool _continueIfErrorOccors;

	[Token(Token = "0x601802F")]
	[Address(RVA = "0x2640DC8", Offset = "0x2640DC8", VA = "0x2640DC8")]
	public TBTActionSequence()
	{
	}

	[Token(Token = "0x6018030")]
	[Address(RVA = "0x2640E54", Offset = "0x2640E54", VA = "0x2640E54")]
	public TBTActionSequence SetContinueIfErrorOccors(bool v)
	{
		return null;
	}

	[Token(Token = "0x6018031")]
	[Address(RVA = "0x2640E5C", Offset = "0x2640E5C", VA = "0x2640E5C", Slot = "4")]
	protected override bool onEvaluate(TBTWorkingData wData)
	{
		return default(bool);
	}

	[Token(Token = "0x6018032")]
	[Address(RVA = "0x2640F8C", Offset = "0x2640F8C", VA = "0x2640F8C", Slot = "5")]
	protected override int onUpdate(TBTWorkingData wData)
	{
		return default(int);
	}

	[Token(Token = "0x6018033")]
	[Address(RVA = "0x26410B8", Offset = "0x26410B8", VA = "0x26410B8", Slot = "6")]
	protected override void onTransition(TBTWorkingData wData)
	{
	}
}
