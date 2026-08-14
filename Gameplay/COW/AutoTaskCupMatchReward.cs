using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E5A")]
public class AutoTaskCupMatchReward : AutoPopupTask
{
	[Token(Token = "0x400BF46")]
	[FieldOffset(Offset = "0x8")]
	private UICupMatchRewardWndController m_Ctrl;

	[Token(Token = "0x400BF47")]
	[FieldOffset(Offset = "0xC")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x60091D7")]
	[Address(RVA = "0x10F2438", Offset = "0x10F2438", VA = "0x10F2438")]
	public AutoTaskCupMatchReward()
	{
	}

	[Token(Token = "0x60091D8")]
	[Address(RVA = "0x10F2440", Offset = "0x10F2440", VA = "0x10F2440", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091D9")]
	[Address(RVA = "0x10F2528", Offset = "0x10F2528", VA = "0x10F2528", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091DA")]
	[Address(RVA = "0x10F271C", Offset = "0x10F271C", VA = "0x10F271C", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
