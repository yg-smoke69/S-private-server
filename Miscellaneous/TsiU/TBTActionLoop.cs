using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C1B")]
public class TBTActionLoop : TBTAction
{
	[Token(Token = "0x2003C1C")]
	protected class TBTActionLoopContext : TBTActionContext
	{
		[Token(Token = "0x4019A02")]
		[FieldOffset(Offset = "0x8")]
		internal int currentCount;

		[Token(Token = "0x601801F")]
		[Address(RVA = "0x26400A8", Offset = "0x26400A8", VA = "0x26400A8")]
		public TBTActionLoopContext()
		{
		}
	}

	[Token(Token = "0x4019A00")]
	public const int INFINITY = -1;

	[Token(Token = "0x4019A01")]
	[FieldOffset(Offset = "0x18")]
	private int _loopCount;

	[Token(Token = "0x601801A")]
	[Address(RVA = "0x263FC28", Offset = "0x263FC28", VA = "0x263FC28")]
	public TBTActionLoop()
	{
	}

	[Token(Token = "0x601801B")]
	[Address(RVA = "0x263FCB4", Offset = "0x263FCB4", VA = "0x263FCB4")]
	public TBTActionLoop SetLoopCount(int count)
	{
		return null;
	}

	[Token(Token = "0x601801C")]
	[Address(RVA = "0x263FCBC", Offset = "0x263FCBC", VA = "0x263FCBC", Slot = "4")]
	protected override bool onEvaluate(TBTWorkingData wData)
	{
		return default(bool);
	}

	[Token(Token = "0x601801D")]
	[Address(RVA = "0x263FE80", Offset = "0x263FE80", VA = "0x263FE80", Slot = "5")]
	protected override int onUpdate(TBTWorkingData wData)
	{
		return default(int);
	}

	[Token(Token = "0x601801E")]
	[Address(RVA = "0x263FFC4", Offset = "0x263FFC4", VA = "0x263FFC4", Slot = "6")]
	protected override void onTransition(TBTWorkingData wData)
	{
	}
}
