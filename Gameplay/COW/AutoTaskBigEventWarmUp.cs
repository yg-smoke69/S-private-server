using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E4B")]
internal class AutoTaskBigEventWarmUp : AutoPopupTask
{
	[Token(Token = "0x400BF27")]
	[FieldOffset(Offset = "0x8")]
	private UIBigEventNaviPopBaseController m_WarmUpWnd;

	[Token(Token = "0x6009192")]
	[Address(RVA = "0x10EA0D8", Offset = "0x10EA0D8", VA = "0x10EA0D8")]
	public AutoTaskBigEventWarmUp()
	{
	}

	[Token(Token = "0x6009193")]
	[Address(RVA = "0x10EA0E0", Offset = "0x10EA0E0", VA = "0x10EA0E0", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x6009194")]
	[Address(RVA = "0x10EA1C8", Offset = "0x10EA1C8", VA = "0x10EA1C8", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x6009195")]
	[Address(RVA = "0x10EA54C", Offset = "0x10EA54C", VA = "0x10EA54C")]
	private bool CheckFirstEnter(int eventId)
	{
		return default(bool);
	}

	[Token(Token = "0x6009196")]
	[Address(RVA = "0x10EA908", Offset = "0x10EA908", VA = "0x10EA908", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
