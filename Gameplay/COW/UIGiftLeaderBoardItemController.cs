using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20021BD")]
public class UIGiftLeaderBoardItemController : UIEasyListItemController
{
	[Token(Token = "0x20021BE")]
	private enum ERewardState
	{
		[Token(Token = "0x400D329")]
		None,
		[Token(Token = "0x400D32A")]
		UnClaimed,
		[Token(Token = "0x400D32B")]
		Claimed,
		[Token(Token = "0x400D32C")]
		Cant
	}

	[Token(Token = "0x20021BF")]
	public enum RankFormat
	{
		[Token(Token = "0x400D32E")]
		Normal,
		[Token(Token = "0x400D32F")]
		TopPercent
	}

	[Token(Token = "0x400D321")]
	[FieldOffset(Offset = "0x38")]
	private RankFormat m_RankFormat;

	[Token(Token = "0x400D322")]
	[FieldOffset(Offset = "0x3C")]
	private UIGiftLeaderBoardItemView m_View;

	[Token(Token = "0x400D323")]
	[FieldOffset(Offset = "0x40")]
	private CSSharedItemData m_ItemData;

	[Token(Token = "0x400D324")]
	[FieldOffset(Offset = "0x44")]
	private LeaderBoardInfo m_Info;

	[Token(Token = "0x400D325")]
	[FieldOffset(Offset = "0x48")]
	private UIBaseProfileInfoController m_BaseProfileUI;

	[Token(Token = "0x400D326")]
	[FieldOffset(Offset = "0x4C")]
	private Dictionary<uint, string> m_RankCupIcon;

	[Token(Token = "0x400D327")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<uint, float> m_BgAlpha;

	[Token(Token = "0x600B43C")]
	[Address(RVA = "0x1CE8B78", Offset = "0x1CE8B78", VA = "0x1CE8B78")]
	public UIGiftLeaderBoardItemController()
	{
	}

	[Token(Token = "0x600B43D")]
	[Address(RVA = "0x1CE8DD4", Offset = "0x1CE8DD4", VA = "0x1CE8DD4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B43E")]
	[Address(RVA = "0x1CE8E7C", Offset = "0x1CE8E7C", VA = "0x1CE8E7C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B43F")]
	[Address(RVA = "0x1CE8F38", Offset = "0x1CE8F38", VA = "0x1CE8F38", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B440")]
	[Address(RVA = "0x1CE8F9C", Offset = "0x1CE8F9C", VA = "0x1CE8F9C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B441")]
	[Address(RVA = "0x1CE90F4", Offset = "0x1CE90F4", VA = "0x1CE90F4")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600B442")]
	[Address(RVA = "0x1CEA094", Offset = "0x1CEA094", VA = "0x1CEA094")]
	public void SetWidgetColor(Color color)
	{
	}

	[Token(Token = "0x600B443")]
	[Address(RVA = "0x1CEA1EC", Offset = "0x1CEA1EC", VA = "0x1CEA1EC")]
	public void SetBgState(bool state)
	{
	}

	[Token(Token = "0x600B444")]
	[Address(RVA = "0x1CEA334", Offset = "0x1CEA334", VA = "0x1CEA334")]
	public void SetRankFormat(RankFormat format)
	{
	}

	[Token(Token = "0x600B445")]
	[Address(RVA = "0x1CEA394", Offset = "0x1CEA394", VA = "0x1CEA394")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B446")]
	[Address(RVA = "0x1CEA39C", Offset = "0x1CEA39C", VA = "0x1CEA39C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
