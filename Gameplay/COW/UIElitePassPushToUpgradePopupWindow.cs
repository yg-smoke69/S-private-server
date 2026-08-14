using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20025F4")]
public class UIElitePassPushToUpgradePopupWindow : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400EA9B")]
	[FieldOffset(Offset = "0x48")]
	private UIElitePassPushToUpgradePopupView m_View;

	[Token(Token = "0x600E025")]
	[Address(RVA = "0x3060414", Offset = "0x3060414", VA = "0x3060414")]
	public UIElitePassPushToUpgradePopupWindow()
	{
	}

	[Token(Token = "0x600E026")]
	[Address(RVA = "0x306041C", Offset = "0x306041C", VA = "0x306041C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E027")]
	[Address(RVA = "0x30604C4", Offset = "0x30604C4", VA = "0x30604C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E028")]
	[Address(RVA = "0x30606D0", Offset = "0x30606D0", VA = "0x30606D0")]
	public void OnOKButtonClick()
	{
	}

	[Token(Token = "0x600E029")]
	[Address(RVA = "0x3060734", Offset = "0x3060734", VA = "0x3060734")]
	public void OnUpgradeBtnClick()
	{
	}

	[Token(Token = "0x600E02A")]
	[Address(RVA = "0x3060868", Offset = "0x3060868", VA = "0x3060868")]
	public void SetRewardsData(List<CommonRewardItemInfo> infoList)
	{
	}

	[Token(Token = "0x600E02B")]
	[Address(RVA = "0x306099C", Offset = "0x306099C", VA = "0x306099C", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E02C")]
	[Address(RVA = "0x3060A94", Offset = "0x3060A94", VA = "0x3060A94", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600E02D")]
	[Address(RVA = "0x3060B10", Offset = "0x3060B10", VA = "0x3060B10")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
