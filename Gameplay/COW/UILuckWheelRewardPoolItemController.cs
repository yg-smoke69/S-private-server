using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002955")]
public class UILuckWheelRewardPoolItemController : UIBaseController
{
	[Token(Token = "0x400FEC3")]
	[FieldOffset(Offset = "0x28")]
	private UILuckWheelRewardPoolItemView m_View;

	[Token(Token = "0x400FEC4")]
	[FieldOffset(Offset = "0x2C")]
	private CSLuckyWheelShopItemDesc m_RewardItem;

	[Token(Token = "0x400FEC5")]
	[FieldOffset(Offset = "0x30")]
	private UIModelLuckyWheel m_Model;

	[Token(Token = "0x400FEC6")]
	[FieldOffset(Offset = "0x34")]
	private UIModelGacha m_ModelGacha;

	[Token(Token = "0x400FEC7")]
	[FieldOffset(Offset = "0x38")]
	private UILuckyWheelPreviewRewardPoolItemController m_ItemCtrl;

	[Token(Token = "0x400FEC8")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_Price;

	[Token(Token = "0x400FEC9")]
	[FieldOffset(Offset = "0x40")]
	private bool m_CanBuyItem;

	[Token(Token = "0x400FECA")]
	[FieldOffset(Offset = "0x41")]
	public bool ForceFullScreenPreview;

	[Token(Token = "0x400FECB")]
	[FieldOffset(Offset = "0x44")]
	private uint m_DelayCall;

	[Token(Token = "0x400FECC")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 m_OriginalPos;

	[Token(Token = "0x6010894")]
	[Address(RVA = "0x21F9C34", Offset = "0x21F9C34", VA = "0x21F9C34")]
	public UILuckWheelRewardPoolItemController()
	{
	}

	[Token(Token = "0x6010895")]
	[Address(RVA = "0x21F9CB8", Offset = "0x21F9CB8", VA = "0x21F9CB8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010896")]
	[Address(RVA = "0x21F9D60", Offset = "0x21F9D60", VA = "0x21F9D60", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010897")]
	[Address(RVA = "0x21FA124", Offset = "0x21FA124", VA = "0x21FA124", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010898")]
	[Address(RVA = "0x21FA22C", Offset = "0x21FA22C", VA = "0x21FA22C")]
	public void SetViewData(CSLuckyWheelShopItemDesc rewardItem, bool needRefreshAnim = false)
	{
	}

	[Token(Token = "0x6010899")]
	[Address(RVA = "0x21FA2D8", Offset = "0x21FA2D8", VA = "0x21FA2D8")]
	private void SetStandItemMiniData(CSLuckyWheelShopItemDesc rewardItem)
	{
	}

	[Token(Token = "0x601089A")]
	[Address(RVA = "0x21F9FF0", Offset = "0x21F9FF0", VA = "0x21F9FF0")]
	private void AddEventDelegate()
	{
	}

	[Token(Token = "0x601089B")]
	[Address(RVA = "0x21FA3D4", Offset = "0x21FA3D4", VA = "0x21FA3D4")]
	private void RefreshBuyBtnState()
	{
	}

	[Token(Token = "0x601089C")]
	[Address(RVA = "0x21FAAF8", Offset = "0x21FAAF8", VA = "0x21FAAF8")]
	private void RefreshCoinIcon()
	{
	}

	[Token(Token = "0x601089D")]
	[Address(RVA = "0x21FA70C", Offset = "0x21FA70C", VA = "0x21FA70C")]
	private void RefreshPrice()
	{
	}

	[Token(Token = "0x601089E")]
	[Address(RVA = "0x21FAA00", Offset = "0x21FAA00", VA = "0x21FAA00")]
	private void RefreshTag()
	{
	}

	[Token(Token = "0x601089F")]
	[Address(RVA = "0x21FAC94", Offset = "0x21FAC94", VA = "0x21FAC94")]
	private void OnBuyBtnClick()
	{
	}

	[Token(Token = "0x60108A0")]
	[Address(RVA = "0x21FB0C8", Offset = "0x21FB0C8", VA = "0x21FB0C8")]
	public void PlayUnLockVfx()
	{
	}

	[Token(Token = "0x60108A1")]
	[Address(RVA = "0x21FB1D0", Offset = "0x21FB1D0", VA = "0x21FB1D0")]
	public void HideUnLockVfx()
	{
	}

	[Token(Token = "0x60108A2")]
	[Address(RVA = "0x21FB260", Offset = "0x21FB260", VA = "0x21FB260")]
	public void PlayAnimation(CSLuckyWheelShopItemDesc desc)
	{
	}

	[Token(Token = "0x60108A3")]
	[Address(RVA = "0x21FB4E4", Offset = "0x21FB4E4", VA = "0x21FB4E4")]
	public void SkipAnimation()
	{
	}

	[Token(Token = "0x60108A4")]
	[Address(RVA = "0x21FB55C", Offset = "0x21FB55C", VA = "0x21FB55C")]
	public void ResetAnimation()
	{
	}

	[Token(Token = "0x60108A5")]
	[Address(RVA = "0x21FB708", Offset = "0x21FB708", VA = "0x21FB708")]
	public void SetBuyBtnState(bool flag)
	{
	}

	[Token(Token = "0x60108A6")]
	[Address(RVA = "0x21FB7A0", Offset = "0x21FB7A0", VA = "0x21FB7A0")]
	private void _003CPlayAnimation_003Em__0()
	{
	}

	[Token(Token = "0x60108A7")]
	[Address(RVA = "0x21FB7C8", Offset = "0x21FB7C8", VA = "0x21FB7C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60108A8")]
	[Address(RVA = "0x21FB7D0", Offset = "0x21FB7D0", VA = "0x21FB7D0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
