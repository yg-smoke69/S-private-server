using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002018")]
public class UIChampionshipReviewRewardItemController : UIEasyListItemController
{
	[Token(Token = "0x400C98D")]
	[FieldOffset(Offset = "0x38")]
	private UIChampionshipReviewRewardItemView m_View;

	[Token(Token = "0x400C98E")]
	[FieldOffset(Offset = "0x3C")]
	private ChampionshipScoreRewardDesc m_AwardData;

	[Token(Token = "0x400C98F")]
	[FieldOffset(Offset = "0x40")]
	private List<UIStandardItemMiniController> m_RewardCtrlCache;

	[Token(Token = "0x400C990")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<uint, string> m_CupIconDict;

	[Token(Token = "0x400C991")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<uint, GameObject> m_BGDict;

	[Token(Token = "0x400C992")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C993")]
	[FieldOffset(Offset = "0x50")]
	private bool m_NeedHighLight;

	[Token(Token = "0x400C994")]
	[FieldOffset(Offset = "0x54")]
	private uint m_ChampionshipType;

	[Token(Token = "0x400C995")]
	[FieldOffset(Offset = "0x58")]
	private ChampionshipSettingDesc m_ChampionshipSetting;

	[Token(Token = "0x400C996")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_LocalSize;

	[Token(Token = "0x600A265")]
	[Address(RVA = "0x28366C0", Offset = "0x28366C0", VA = "0x28366C0")]
	public UIChampionshipReviewRewardItemController()
	{
	}

	[Token(Token = "0x600A266")]
	[Address(RVA = "0x2836864", Offset = "0x2836864", VA = "0x2836864")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A267")]
	[Address(RVA = "0x283690C", Offset = "0x283690C", VA = "0x283690C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A268")]
	[Address(RVA = "0x2836BD0", Offset = "0x2836BD0", VA = "0x2836BD0", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A269")]
	[Address(RVA = "0x2836DA0", Offset = "0x2836DA0", VA = "0x2836DA0")]
	public void NeedHighLight(bool needHighLight)
	{
	}

	[Token(Token = "0x600A26A")]
	[Address(RVA = "0x2836D28", Offset = "0x2836D28", VA = "0x2836D28")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600A26B")]
	[Address(RVA = "0x2837020", Offset = "0x2837020", VA = "0x2837020")]
	private void RefreshRewardList()
	{
	}

	[Token(Token = "0x600A26C")]
	[Address(RVA = "0x283750C", Offset = "0x283750C", VA = "0x283750C")]
	private void RefreshLevel()
	{
	}

	[Token(Token = "0x600A26D")]
	[Address(RVA = "0x2837C64", Offset = "0x2837C64", VA = "0x2837C64")]
	private void HighLightBg()
	{
	}

	[Token(Token = "0x600A26E")]
	[Address(RVA = "0x2836E00", Offset = "0x2836E00", VA = "0x2836E00")]
	private void HideUI()
	{
	}

	[Token(Token = "0x600A26F")]
	[Address(RVA = "0x2837DDC", Offset = "0x2837DDC", VA = "0x2837DDC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
