using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x20020EF")]
internal class UIHudTakeTurnsShopItemController : UIHudCSEquipItemController
{
	[Token(Token = "0x400CDF1")]
	[FieldOffset(Offset = "0x44")]
	private bool m_IsInCD;

	[Token(Token = "0x600AAA5")]
	[Address(RVA = "0x1FFEEB4", Offset = "0x1FFEEB4", VA = "0x1FFEEB4")]
	public UIHudTakeTurnsShopItemController()
	{
	}

	[Token(Token = "0x600AAA6")]
	[Address(RVA = "0x1FFEEBC", Offset = "0x1FFEEBC", VA = "0x1FFEEBC")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AAA7")]
	[Address(RVA = "0x1FFEF64", Offset = "0x1FFEF64", VA = "0x1FFEF64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AAA8")]
	[Address(RVA = "0x1FFF1B0", Offset = "0x1FFF1B0", VA = "0x1FFF1B0")]
	private void RecordCD(object[] data)
	{
	}

	[Token(Token = "0x600AAA9")]
	[Address(RVA = "0x1FFF3FC", Offset = "0x1FFF3FC", VA = "0x1FFF3FC")]
	private void SetTakeTurnsItemView(object[] data)
	{
	}

	[Token(Token = "0x600AAAA")]
	[Address(RVA = "0x1FFF508", Offset = "0x1FFF508", VA = "0x1FFF508")]
	private void CheckTakeTurnsLimit(NLGKDGCHAIB state)
	{
	}

	[Token(Token = "0x600AAAB")]
	[Address(RVA = "0x1FFFBE8", Offset = "0x1FFFBE8", VA = "0x1FFFBE8")]
	private void OnItemMultiSelected(object[] data)
	{
	}

	[Token(Token = "0x600AAAC")]
	[Address(RVA = "0x1FFFE28", Offset = "0x1FFFE28", VA = "0x1FFFE28")]
	private void OnItemMultiSelectedMark(object[] data)
	{
	}

	[Token(Token = "0x600AAAD")]
	[Address(RVA = "0x1FFFFCC", Offset = "0x1FFFFCC", VA = "0x1FFFFCC")]
	private void OnOthersChoosingMaskClick()
	{
	}

	[Token(Token = "0x600AAAE")]
	[Address(RVA = "0x20000D8", Offset = "0x20000D8", VA = "0x20000D8")]
	private void _003CCheckTakeTurnsLimit_003Em__0()
	{
	}

	[Token(Token = "0x600AAAF")]
	[Address(RVA = "0x2000158", Offset = "0x2000158", VA = "0x2000158")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
