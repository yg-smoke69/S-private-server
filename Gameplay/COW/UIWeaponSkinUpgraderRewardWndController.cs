using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C19")]
public class UIWeaponSkinUpgraderRewardWndController : UIPopupWindowController
{
	[Token(Token = "0x2002C1A")]
	private sealed class _003CAutoClose_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010D69")]
		[FieldOffset(Offset = "0x8")]
		internal uint skinId;

		[Token(Token = "0x601258A")]
		[Address(RVA = "0x1B78700", Offset = "0x1B78700", VA = "0x1B78700")]
		public _003CAutoClose_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601258B")]
		[Address(RVA = "0x1B7887C", Offset = "0x1B7887C", VA = "0x1B7887C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4010D62")]
	[FieldOffset(Offset = "0x48")]
	private UIWeaponSkinUpgraderRewardWndView m_View;

	[Token(Token = "0x4010D63")]
	[FieldOffset(Offset = "0x4C")]
	private WeaponSkinData m_WeaponSkinData;

	[Token(Token = "0x4010D64")]
	[FieldOffset(Offset = "0x50")]
	private List<int> m_Features;

	[Token(Token = "0x4010D65")]
	[FieldOffset(Offset = "0x54")]
	private List<uint> m_RewardItemIds;

	[Token(Token = "0x4010D66")]
	[FieldOffset(Offset = "0x58")]
	private int m_CurRewardIdx;

	[Token(Token = "0x4010D67")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_AutoCloseDC;

	[Token(Token = "0x4010D68")]
	[FieldOffset(Offset = "0x60")]
	private bool m_HasABNotReadyItem;

	[Token(Token = "0x6012577")]
	[Address(RVA = "0x1B76ACC", Offset = "0x1B76ACC", VA = "0x1B76ACC")]
	public UIWeaponSkinUpgraderRewardWndController()
	{
	}

	[Token(Token = "0x6012578")]
	[Address(RVA = "0x1B76B8C", Offset = "0x1B76B8C", VA = "0x1B76B8C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012579")]
	[Address(RVA = "0x1B76C30", Offset = "0x1B76C30", VA = "0x1B76C30", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601257A")]
	[Address(RVA = "0x1B76D80", Offset = "0x1B76D80", VA = "0x1B76D80", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601257B")]
	[Address(RVA = "0x1B76EF0", Offset = "0x1B76EF0", VA = "0x1B76EF0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x601257C")]
	[Address(RVA = "0x1B77020", Offset = "0x1B77020", VA = "0x1B77020")]
	public void SetRewardsData(WeaponSkinData data, List<int> features, List<uint> itemIds)
	{
	}

	[Token(Token = "0x601257D")]
	[Address(RVA = "0x1B77158", Offset = "0x1B77158", VA = "0x1B77158")]
	private void ShowRewardsView()
	{
	}

	[Token(Token = "0x601257E")]
	[Address(RVA = "0x1B7788C", Offset = "0x1B7788C", VA = "0x1B7788C")]
	private void ShowRewardFeatureView(WeaponSkinFeature feature)
	{
	}

	[Token(Token = "0x601257F")]
	[Address(RVA = "0x1B772EC", Offset = "0x1B772EC", VA = "0x1B772EC")]
	private void SetUIVisible(bool flag)
	{
	}

	[Token(Token = "0x6012580")]
	[Address(RVA = "0x1B77A30", Offset = "0x1B77A30", VA = "0x1B77A30")]
	private void OnCommonEquipResult(object[] data)
	{
	}

	[Token(Token = "0x6012581")]
	[Address(RVA = "0x1B77CD4", Offset = "0x1B77CD4", VA = "0x1B77CD4")]
	private void OnEquipSuccess(bool isTipShow = true)
	{
	}

	[Token(Token = "0x6012582")]
	[Address(RVA = "0x1B77D44", Offset = "0x1B77D44", VA = "0x1B77D44")]
	private void OnEquipFail()
	{
	}

	[Token(Token = "0x6012583")]
	[Address(RVA = "0x1B77DAC", Offset = "0x1B77DAC", VA = "0x1B77DAC")]
	private void AutoClose(bool showTip = false, bool equipSuccess = true)
	{
	}

	[Token(Token = "0x6012584")]
	[Address(RVA = "0x1B77348", Offset = "0x1B77348", VA = "0x1B77348")]
	private void CheckFastEquip()
	{
	}

	[Token(Token = "0x6012585")]
	[Address(RVA = "0x1B78708", Offset = "0x1B78708", VA = "0x1B78708")]
	private bool CheckItemABReady(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x6012586")]
	[Address(RVA = "0x1B78854", Offset = "0x1B78854", VA = "0x1B78854")]
	private void _003CShowRewardFeatureView_003Em__0()
	{
	}

	[Token(Token = "0x6012587")]
	[Address(RVA = "0x1B78864", Offset = "0x1B78864", VA = "0x1B78864")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012588")]
	[Address(RVA = "0x1B7886C", Offset = "0x1B7886C", VA = "0x1B7886C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6012589")]
	[Address(RVA = "0x1B78874", Offset = "0x1B78874", VA = "0x1B78874")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
