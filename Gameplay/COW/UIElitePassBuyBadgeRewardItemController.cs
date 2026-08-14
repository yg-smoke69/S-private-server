using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025E0")]
public class UIElitePassBuyBadgeRewardItemController : UIEasyListItemController
{
	[Token(Token = "0x400EA1A")]
	[FieldOffset(Offset = "0x38")]
	private EPAwardInfo m_RewardData;

	[Token(Token = "0x400EA1B")]
	[FieldOffset(Offset = "0x3C")]
	private UIElitePassBuyBadgeRewardItemView m_View;

	[Token(Token = "0x400EA1C")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsClickEpAward;

	[Token(Token = "0x400EA1D")]
	[FieldOffset(Offset = "0x44")]
	private int badgeAfter;

	[Token(Token = "0x600DF0A")]
	[Address(RVA = "0x2A3FA40", Offset = "0x2A3FA40", VA = "0x2A3FA40")]
	public UIElitePassBuyBadgeRewardItemController()
	{
	}

	[Token(Token = "0x600DF0B")]
	[Address(RVA = "0x2A3FA50", Offset = "0x2A3FA50", VA = "0x2A3FA50")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DF0C")]
	[Address(RVA = "0x2A3FAF8", Offset = "0x2A3FAF8", VA = "0x2A3FAF8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DF0D")]
	[Address(RVA = "0x2A3FF28", Offset = "0x2A3FF28", VA = "0x2A3FF28", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DF0E")]
	[Address(RVA = "0x2A4005C", Offset = "0x2A4005C", VA = "0x2A4005C")]
	private void OnChangeSelectedBadgeCount(object[] param)
	{
	}

	[Token(Token = "0x600DF0F")]
	[Address(RVA = "0x2A4094C", Offset = "0x2A4094C", VA = "0x2A4094C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600DF10")]
	[Address(RVA = "0x2A3D660", Offset = "0x2A3D660", VA = "0x2A3D660")]
	public void SelectItem(bool isEP)
	{
	}

	[Token(Token = "0x600DF11")]
	[Address(RVA = "0x2A41498", Offset = "0x2A41498", VA = "0x2A41498", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600DF12")]
	[Address(RVA = "0x2A41584", Offset = "0x2A41584", VA = "0x2A41584", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600DF13")]
	[Address(RVA = "0x2A41658", Offset = "0x2A41658", VA = "0x2A41658")]
	private void OnFpAwardClick()
	{
	}

	[Token(Token = "0x600DF14")]
	[Address(RVA = "0x2A416BC", Offset = "0x2A416BC", VA = "0x2A416BC")]
	private void OnEpAwardClick()
	{
	}

	[Token(Token = "0x600DF15")]
	[Address(RVA = "0x2A40324", Offset = "0x2A40324", VA = "0x2A40324")]
	private void ShowLockState(int badgeCount)
	{
	}

	[Token(Token = "0x600DF16")]
	[Address(RVA = "0x2A41720", Offset = "0x2A41720", VA = "0x2A41720")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DF17")]
	[Address(RVA = "0x2A41728", Offset = "0x2A41728", VA = "0x2A41728")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600DF18")]
	[Address(RVA = "0x2A41730", Offset = "0x2A41730", VA = "0x2A41730")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600DF19")]
	[Address(RVA = "0x2A41738", Offset = "0x2A41738", VA = "0x2A41738")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
