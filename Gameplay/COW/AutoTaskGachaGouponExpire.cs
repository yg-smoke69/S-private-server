using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E60")]
internal class AutoTaskGachaGouponExpire : AutoPopupTask
{
	[Token(Token = "0x400BF4D")]
	[FieldOffset(Offset = "0x8")]
	private UIGachaCouponExpireInfoController m_PopupWnd;

	[Token(Token = "0x60091EF")]
	[Address(RVA = "0x10F3CF4", Offset = "0x10F3CF4", VA = "0x10F3CF4")]
	public AutoTaskGachaGouponExpire()
	{
	}

	[Token(Token = "0x60091F0")]
	[Address(RVA = "0x10F3CFC", Offset = "0x10F3CFC", VA = "0x10F3CFC", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091F1")]
	[Address(RVA = "0x10F3DE4", Offset = "0x10F3DE4", VA = "0x10F3DE4", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091F2")]
	[Address(RVA = "0x10F41AC", Offset = "0x10F41AC", VA = "0x10F41AC", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
