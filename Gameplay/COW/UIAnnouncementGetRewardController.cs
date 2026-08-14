using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200249D")]
public class UIAnnouncementGetRewardController : UIPopupWindowController
{
	[Token(Token = "0x400E2EC")]
	[FieldOffset(Offset = "0x48")]
	private UIAnnouncementGetRewardViewExt m_View;

	[Token(Token = "0x400E2ED")]
	[FieldOffset(Offset = "0x4C")]
	private RewardBtn m_BtnData;

	[Token(Token = "0x400E2EE")]
	[FieldOffset(Offset = "0x50")]
	public Dictionary<int, UIAwardItemController> m_SelectedDict;

	[Token(Token = "0x400E2EF")]
	[FieldOffset(Offset = "0x54")]
	private int m_EquippedSuccessNum;

	[Token(Token = "0x400E2F0")]
	[FieldOffset(Offset = "0x58")]
	private bool m_HaveShowFailTip;

	[Token(Token = "0x400E2F1")]
	private const float m_AutoCloseSecond = 1f;

	[Token(Token = "0x400E2F2")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_AutoCloseDC;

	[Token(Token = "0x400E2F3")]
	[FieldOffset(Offset = "0x60")]
	private bool m_EnableOKBtn;

	[Token(Token = "0x400E2F4")]
	[FieldOffset(Offset = "0x64")]
	private uint previewItemID;

	[Token(Token = "0x400E2F5")]
	[FieldOffset(Offset = "0x68")]
	private int quality;

	[Token(Token = "0x600D157")]
	[Address(RVA = "0x1E6B148", Offset = "0x1E6B148", VA = "0x1E6B148")]
	public UIAnnouncementGetRewardController()
	{
	}

	[Token(Token = "0x600D158")]
	[Address(RVA = "0x1E6B1DC", Offset = "0x1E6B1DC", VA = "0x1E6B1DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D159")]
	[Address(RVA = "0x1E6B280", Offset = "0x1E6B280", VA = "0x1E6B280", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D15A")]
	[Address(RVA = "0x1E6B7B8", Offset = "0x1E6B7B8", VA = "0x1E6B7B8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600D15B")]
	[Address(RVA = "0x1E6B8E8", Offset = "0x1E6B8E8", VA = "0x1E6B8E8")]
	public void ShowAwardList(List<BaseItemInfo> infoList, [Optional] string reward_title, [Optional] RewardBtn btn_data, [Optional] string transfer_hint)
	{
	}

	[Token(Token = "0x600D15C")]
	[Address(RVA = "0x1E6CBB0", Offset = "0x1E6CBB0", VA = "0x1E6CBB0")]
	private bool IsCanEquip(uint itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x600D15D")]
	[Address(RVA = "0x1E6C75C", Offset = "0x1E6C75C", VA = "0x1E6C75C")]
	private void SetEquipBtnStats(List<UIAwardItemController> awardList)
	{
	}

	[Token(Token = "0x600D15E")]
	[Address(RVA = "0x1E6C200", Offset = "0x1E6C200", VA = "0x1E6C200")]
	private void SetEquipToggleStats(List<UIAwardItemController> awardList)
	{
	}

	[Token(Token = "0x600D15F")]
	[Address(RVA = "0x1E6CD70", Offset = "0x1E6CD70", VA = "0x1E6CD70")]
	private void OnFastEquipClick()
	{
	}

	[Token(Token = "0x600D160")]
	[Address(RVA = "0x1E6DC08", Offset = "0x1E6DC08", VA = "0x1E6DC08")]
	private void OnOKBtnClick()
	{
	}

	[Token(Token = "0x600D161")]
	[Address(RVA = "0x1E6DC94", Offset = "0x1E6DC94", VA = "0x1E6DC94")]
	private void OnBannerEquipResult(object[] data)
	{
	}

	[Token(Token = "0x600D162")]
	[Address(RVA = "0x1E6E2B0", Offset = "0x1E6E2B0", VA = "0x1E6E2B0")]
	private void OnHeadPicEquipResult(object[] data)
	{
	}

	[Token(Token = "0x600D163")]
	[Address(RVA = "0x1E6E31C", Offset = "0x1E6E31C", VA = "0x1E6E31C")]
	private void OnCommonEquipResult(object[] data)
	{
	}

	[Token(Token = "0x600D164")]
	[Address(RVA = "0x1E6E6B0", Offset = "0x1E6E6B0", VA = "0x1E6E6B0")]
	private void OnClothEquipResult(object[] data)
	{
	}

	[Token(Token = "0x600D165")]
	[Address(RVA = "0x1E6DF00", Offset = "0x1E6DF00", VA = "0x1E6DF00")]
	private void OnEquipSuccess()
	{
	}

	[Token(Token = "0x600D166")]
	[Address(RVA = "0x1E6E104", Offset = "0x1E6E104", VA = "0x1E6E104")]
	private void OnEquipFail()
	{
	}

	[Token(Token = "0x600D167")]
	[Address(RVA = "0x1E6E71C", Offset = "0x1E6E71C", VA = "0x1E6E71C")]
	private void AutoClose()
	{
	}

	[Token(Token = "0x600D168")]
	[Address(RVA = "0x1E6E868", Offset = "0x1E6E868", VA = "0x1E6E868")]
	private void OnGoToSharePreviewClick()
	{
	}

	[Token(Token = "0x600D169")]
	[Address(RVA = "0x1E6EAC0", Offset = "0x1E6EAC0", VA = "0x1E6EAC0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600D16A")]
	[Address(RVA = "0x1E6EBD8", Offset = "0x1E6EBD8", VA = "0x1E6EBD8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D16B")]
	[Address(RVA = "0x1E6EEB8", Offset = "0x1E6EEB8", VA = "0x1E6EEB8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D16C")]
	[Address(RVA = "0x1E6EEC0", Offset = "0x1E6EEC0", VA = "0x1E6EEC0")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600D16D")]
	[Address(RVA = "0x1E6EEC8", Offset = "0x1E6EEC8", VA = "0x1E6EEC8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600D16E")]
	[Address(RVA = "0x1E6EED0", Offset = "0x1E6EED0", VA = "0x1E6EED0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
