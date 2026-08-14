using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026E4")]
internal class UIHudBanknoteShopItemController : UIBaseController
{
	[Token(Token = "0x400F03D")]
	[FieldOffset(Offset = "0x28")]
	private UIHudInGameShopItemViewExt m_View;

	[Token(Token = "0x400F03E")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_Selected;

	[Token(Token = "0x400F03F")]
	[FieldOffset(Offset = "0x30")]
	public int m_Index;

	[Token(Token = "0x400F040")]
	[FieldOffset(Offset = "0x34")]
	private Action<int> m_CallBack;

	[Token(Token = "0x600EBAF")]
	[Address(RVA = "0x171E480", Offset = "0x171E480", VA = "0x171E480")]
	public UIHudBanknoteShopItemController()
	{
	}

	[Token(Token = "0x600EBB0")]
	[Address(RVA = "0x171E504", Offset = "0x171E504", VA = "0x171E504")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EBB1")]
	[Address(RVA = "0x171E5AC", Offset = "0x171E5AC", VA = "0x171E5AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EBB2")]
	[Address(RVA = "0x171E728", Offset = "0x171E728", VA = "0x171E728", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EBB3")]
	[Address(RVA = "0x171E78C", Offset = "0x171E78C", VA = "0x171E78C")]
	private void Update()
	{
	}

	[Token(Token = "0x600EBB4")]
	[Address(RVA = "0x171E7F8", Offset = "0x171E7F8", VA = "0x171E7F8")]
	public void SetUIData(uint itemID, int index, Action<int> callBack)
	{
	}

	[Token(Token = "0x600EBB5")]
	[Address(RVA = "0x171EA3C", Offset = "0x171EA3C", VA = "0x171EA3C")]
	private void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600EBB6")]
	[Address(RVA = "0x171EB1C", Offset = "0x171EB1C", VA = "0x171EB1C")]
	public void SetSelected(bool v)
	{
	}

	[Token(Token = "0x600EBB7")]
	[Address(RVA = "0x171EBE0", Offset = "0x171EBE0", VA = "0x171EBE0")]
	public void UpdateUnLockState(bool isUnLock)
	{
	}

	[Token(Token = "0x600EBB8")]
	[Address(RVA = "0x171ED28", Offset = "0x171ED28", VA = "0x171ED28")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EBB9")]
	[Address(RVA = "0x171ED30", Offset = "0x171ED30", VA = "0x171ED30")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
