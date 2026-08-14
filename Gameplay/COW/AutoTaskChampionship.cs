using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E4D")]
internal class AutoTaskChampionship : AutoPopupTask
{
	[Token(Token = "0x400BF29")]
	[FieldOffset(Offset = "0x8")]
	private UIChampionshipAnimController m_ChampionshipAnimCtrl;

	[Token(Token = "0x600919C")]
	[Address(RVA = "0x10ED278", Offset = "0x10ED278", VA = "0x10ED278")]
	public AutoTaskChampionship()
	{
	}

	[Token(Token = "0x600919D")]
	[Address(RVA = "0x10ED280", Offset = "0x10ED280", VA = "0x10ED280", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x600919E")]
	[Address(RVA = "0x10ED368", Offset = "0x10ED368", VA = "0x10ED368", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x600919F")]
	[Address(RVA = "0x10EDDC4", Offset = "0x10EDDC4", VA = "0x10EDDC4", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
