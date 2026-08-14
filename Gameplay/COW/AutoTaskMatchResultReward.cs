using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E65")]
public class AutoTaskMatchResultReward : AutoPopupTask
{
	[Token(Token = "0x400BF57")]
	[FieldOffset(Offset = "0x8")]
	private UIMatchResultRewardWndController m_UIMatchResultRewardWndController;

	[Token(Token = "0x400BF58")]
	[FieldOffset(Offset = "0xC")]
	private UIMatchResultRewardSingersBWndController m_UIMatchResultRewardSingersBWndController;

	[Token(Token = "0x400BF59")]
	[FieldOffset(Offset = "0x10")]
	private bool m_IsSingersB;

	[Token(Token = "0x6009207")]
	[Address(RVA = "0x10F6C3C", Offset = "0x10F6C3C", VA = "0x10F6C3C")]
	public AutoTaskMatchResultReward()
	{
	}

	[Token(Token = "0x6009208")]
	[Address(RVA = "0x10F6C44", Offset = "0x10F6C44", VA = "0x10F6C44", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x6009209")]
	[Address(RVA = "0x10F6C9C", Offset = "0x10F6C9C", VA = "0x10F6C9C", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x600920A")]
	[Address(RVA = "0x10F7138", Offset = "0x10F7138", VA = "0x10F7138", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
