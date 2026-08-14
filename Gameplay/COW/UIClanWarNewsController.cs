using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002560")]
public class UIClanWarNewsController : UIBaseController
{
	[Token(Token = "0x400E76B")]
	[FieldOffset(Offset = "0x28")]
	private UIClanWarNewsView m_View;

	[Token(Token = "0x400E76C")]
	[FieldOffset(Offset = "0x2C")]
	private UICenterOnChild m_MapCenter;

	[Token(Token = "0x400E76D")]
	private const string RewardTipKey = "T_29_AG_CLANWAR_AWARDTIPS";

	[Token(Token = "0x400E76E")]
	private const string UnavailableKey = "T_29_AG_CLANWAR_UNAVAILABLE";

	[Token(Token = "0x400E76F")]
	private const string MapDescKey = "T_29_AG_CLANWAR_MAP_DESC";

	[Token(Token = "0x400E770")]
	[FieldOffset(Offset = "0x30")]
	private int m_CurMapIndex;

	[Token(Token = "0x400E771")]
	[FieldOffset(Offset = "0x34")]
	private uint m_AutoScrollDelayCallID;

	[Token(Token = "0x400E772")]
	[FieldOffset(Offset = "0x38")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400E773")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIClanWarNewsMapItemController> m_MapItemList;

	[Token(Token = "0x600DA30")]
	[Address(RVA = "0x29002B8", Offset = "0x29002B8", VA = "0x29002B8")]
	public UIClanWarNewsController()
	{
	}

	[Token(Token = "0x600DA31")]
	[Address(RVA = "0x2900370", Offset = "0x2900370", VA = "0x2900370")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DA32")]
	[Address(RVA = "0x2900418", Offset = "0x2900418", VA = "0x2900418", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DA33")]
	[Address(RVA = "0x2900F78", Offset = "0x2900F78", VA = "0x2900F78", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600DA34")]
	[Address(RVA = "0x2900538", Offset = "0x2900538", VA = "0x2900538")]
	private void InitView()
	{
	}

	[Token(Token = "0x600DA35")]
	[Address(RVA = "0x29008D0", Offset = "0x29008D0", VA = "0x29008D0")]
	private void ShowViewInfo()
	{
	}

	[Token(Token = "0x600DA36")]
	[Address(RVA = "0x2901A5C", Offset = "0x2901A5C", VA = "0x2901A5C")]
	public void RefreshStage()
	{
	}

	[Token(Token = "0x600DA37")]
	[Address(RVA = "0x2901F6C", Offset = "0x2901F6C", VA = "0x2901F6C")]
	private void HideAllSage()
	{
	}

	[Token(Token = "0x600DA38")]
	[Address(RVA = "0x290108C", Offset = "0x290108C", VA = "0x290108C")]
	private void InitMapTexs(string[] cdns)
	{
	}

	[Token(Token = "0x600DA39")]
	[Address(RVA = "0x2901640", Offset = "0x2901640", VA = "0x2901640")]
	private void InitRewardItems(List<AwardDesc> list, Transform parent)
	{
	}

	[Token(Token = "0x600DA3A")]
	[Address(RVA = "0x290183C", Offset = "0x290183C", VA = "0x290183C")]
	private void InitRewardItems(List<ClanWarAwardDesc> list, Transform parent)
	{
	}

	[Token(Token = "0x600DA3B")]
	[Address(RVA = "0x290224C", Offset = "0x290224C", VA = "0x290224C")]
	private void OnClickRewardTip()
	{
	}

	[Token(Token = "0x600DA3C")]
	[Address(RVA = "0x29024A8", Offset = "0x29024A8", VA = "0x29024A8")]
	private void OnClickToRewardBtn()
	{
	}

	[Token(Token = "0x600DA3D")]
	[Address(RVA = "0x29025B4", Offset = "0x29025B4", VA = "0x29025B4")]
	private void OnClickToMatchBtn()
	{
	}

	[Token(Token = "0x600DA3E")]
	[Address(RVA = "0x29026C0", Offset = "0x29026C0", VA = "0x29026C0")]
	private void OnClickRuleBtn()
	{
	}

	[Token(Token = "0x600DA3F")]
	[Address(RVA = "0x290285C", Offset = "0x290285C", VA = "0x290285C")]
	private void OnFinishCountDown()
	{
	}

	[Token(Token = "0x600DA40")]
	[Address(RVA = "0x29028BC", Offset = "0x29028BC", VA = "0x29028BC")]
	private void GetCenterItem(GameObject item)
	{
	}

	[Token(Token = "0x600DA41")]
	[Address(RVA = "0x2902960", Offset = "0x2902960", VA = "0x2902960")]
	private void OnAutoScrollAdItem()
	{
	}

	[Token(Token = "0x600DA42")]
	[Address(RVA = "0x2902AB4", Offset = "0x2902AB4", VA = "0x2902AB4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DA43")]
	[Address(RVA = "0x2902ABC", Offset = "0x2902ABC", VA = "0x2902ABC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
