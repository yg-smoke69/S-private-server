using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E5E")]
public class AutoTaskEPDebrisReward : AutoPopupTask
{
	[Token(Token = "0x400BF4B")]
	[FieldOffset(Offset = "0x8")]
	private UIEPDebrisRewardController m_EPDebrisRewardUI;

	[Token(Token = "0x60091E7")]
	[Address(RVA = "0x10F3570", Offset = "0x10F3570", VA = "0x10F3570")]
	public AutoTaskEPDebrisReward()
	{
	}

	[Token(Token = "0x60091E8")]
	[Address(RVA = "0x10F3578", Offset = "0x10F3578", VA = "0x10F3578", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091E9")]
	[Address(RVA = "0x10F3660", Offset = "0x10F3660", VA = "0x10F3660", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091EA")]
	[Address(RVA = "0x10F390C", Offset = "0x10F390C", VA = "0x10F390C", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
