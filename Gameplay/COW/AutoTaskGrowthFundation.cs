using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E61")]
public class AutoTaskGrowthFundation : AutoPopupTask
{
	[Token(Token = "0x400BF4E")]
	[FieldOffset(Offset = "0x8")]
	private UIGrowthFundAdController m_GrowthFundationUI;

	[Token(Token = "0x60091F3")]
	[Address(RVA = "0x10F42AC", Offset = "0x10F42AC", VA = "0x10F42AC")]
	public AutoTaskGrowthFundation()
	{
	}

	[Token(Token = "0x60091F4")]
	[Address(RVA = "0x10F42B4", Offset = "0x10F42B4", VA = "0x10F42B4", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091F5")]
	[Address(RVA = "0x10F430C", Offset = "0x10F430C", VA = "0x10F430C", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091F6")]
	[Address(RVA = "0x10F4F78", Offset = "0x10F4F78", VA = "0x10F4F78", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
