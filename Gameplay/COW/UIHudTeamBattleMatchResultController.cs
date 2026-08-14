using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002253")]
internal class UIHudTeamBattleMatchResultController : UIHudMatchResultBaseController
{
	[Token(Token = "0x400D6E3")]
	private const int SCORE_TO_DIVIDING_LINE_WIDTH = 10;

	[Token(Token = "0x400D6E4")]
	[FieldOffset(Offset = "0x18C")]
	protected UIHudTeamBattleMatchResultView m_View;

	[Token(Token = "0x400D6E5")]
	[FieldOffset(Offset = "0x190")]
	protected bool HideGradeInfo;

	[Token(Token = "0x400D6E6")]
	[FieldOffset(Offset = "0x198")]
	private ulong m_WinMVPPlayerAccountID;

	[Token(Token = "0x400D6E7")]
	[FieldOffset(Offset = "0x1A0")]
	private ulong m_FailMVPPlayerAccountID;

	[Token(Token = "0x17001084")]
	protected ulong WinMVPPlayerAccountID
	{
		[Token(Token = "0x600BB22")]
		[Address(RVA = "0x1792734", Offset = "0x1792734", VA = "0x1792734")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600BB23")]
		[Address(RVA = "0x1792794", Offset = "0x1792794", VA = "0x1792794")]
		set
		{
		}
	}

	[Token(Token = "0x17001085")]
	protected ulong FailMVPPlayerAccountID
	{
		[Token(Token = "0x600BB24")]
		[Address(RVA = "0x1792814", Offset = "0x1792814", VA = "0x1792814")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600BB25")]
		[Address(RVA = "0x1792874", Offset = "0x1792874", VA = "0x1792874")]
		set
		{
		}
	}

	[Token(Token = "0x600BB20")]
	[Address(RVA = "0x1792684", Offset = "0x1792684", VA = "0x1792684")]
	public UIHudTeamBattleMatchResultController()
	{
	}

	[Token(Token = "0x600BB21")]
	[Address(RVA = "0x179268C", Offset = "0x179268C", VA = "0x179268C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BB26")]
	[Address(RVA = "0x17928F4", Offset = "0x17928F4", VA = "0x17928F4")]
	protected void UpdateLeftTeamScoreBG(ResourceID spriteID, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	[Token(Token = "0x600BB27")]
	[Address(RVA = "0x1792A64", Offset = "0x1792A64", VA = "0x1792A64")]
	protected void UpdateRightTeamScoreBG(ResourceID spriteID, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	[Token(Token = "0x600BB28")]
	[Address(RVA = "0x1792BD4", Offset = "0x1792BD4", VA = "0x1792BD4")]
	protected void UpdateLeftTeamCustomIcon(ResourceID spriteID, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	[Token(Token = "0x600BB29")]
	[Address(RVA = "0x1792D44", Offset = "0x1792D44", VA = "0x1792D44")]
	protected void UpdateRightTeamCustomIcon(ResourceID spriteID, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	[Token(Token = "0x600BB2A")]
	[Address(RVA = "0x1792EB4", Offset = "0x1792EB4", VA = "0x1792EB4")]
	protected void RepositionScoreWidth()
	{
	}

	[Token(Token = "0x600BB2B")]
	[Address(RVA = "0x17935A0", Offset = "0x17935A0", VA = "0x17935A0", Slot = "57")]
	protected virtual bool UseLongTeamList()
	{
		return default(bool);
	}

	[Token(Token = "0x600BB2C")]
	[Address(RVA = "0x1793718", Offset = "0x1793718", VA = "0x1793718", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BB2D")]
	[Address(RVA = "0x1794158", Offset = "0x1794158", VA = "0x1794158", Slot = "50")]
	protected override void OnShowAvatarInfoUI()
	{
	}

	[Token(Token = "0x600BB2E")]
	[Address(RVA = "0x17942BC", Offset = "0x17942BC", VA = "0x17942BC", Slot = "47")]
	protected override void OnChangePageType()
	{
	}

	[Token(Token = "0x600BB2F")]
	[Address(RVA = "0x17950CC", Offset = "0x17950CC", VA = "0x17950CC")]
	private void UpdateFakeLikes(uint rank, uint kills)
	{
	}

	[Token(Token = "0x600BB30")]
	[Address(RVA = "0x17946A0", Offset = "0x17946A0", VA = "0x17946A0")]
	private void UpdateInfoTitles()
	{
	}

	[Token(Token = "0x600BB31")]
	[Address(RVA = "0x1795188", Offset = "0x1795188", VA = "0x1795188")]
	private new bool GetDataBtnVisibility()
	{
		return default(bool);
	}

	[Token(Token = "0x600BB32")]
	[Address(RVA = "0x179520C", Offset = "0x179520C", VA = "0x179520C", Slot = "48")]
	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	[Token(Token = "0x600BB33")]
	[Address(RVA = "0x17954F0", Offset = "0x17954F0", VA = "0x17954F0")]
	private bool NeedSetMVPPlayer()
	{
		return default(bool);
	}

	[Token(Token = "0x600BB34")]
	[Address(RVA = "0x179774C", Offset = "0x179774C", VA = "0x179774C", Slot = "49")]
	protected override void OnShowDetailUI(bool show)
	{
	}

	[Token(Token = "0x600BB35")]
	[Address(RVA = "0x1797B68", Offset = "0x1797B68", VA = "0x1797B68", Slot = "45")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600BB36")]
	[Address(RVA = "0x1797D50", Offset = "0x1797D50", VA = "0x1797D50", Slot = "46")]
	protected override int[] GetInfoTypesData()
	{
		return null;
	}

	[Token(Token = "0x600BB37")]
	[Address(RVA = "0x179704C", Offset = "0x179704C", VA = "0x179704C")]
	protected void UpdateMVPInfo(List<TeammateStats> players, bool win, bool needSetMVPPlayer, bool show = false)
	{
	}

	[Token(Token = "0x600BB38")]
	[Address(RVA = "0x1797E20", Offset = "0x1797E20", VA = "0x1797E20", Slot = "55")]
	protected override void OnFixMatchInfoForLanguage()
	{
	}

	[Token(Token = "0x600BB39")]
	[Address(RVA = "0x1797FD0", Offset = "0x1797FD0", VA = "0x1797FD0", Slot = "58")]
	protected virtual Transform GetItemTransform(bool localTeam, int index)
	{
		return null;
	}

	[Token(Token = "0x600BB3A")]
	[Address(RVA = "0x179853C", Offset = "0x179853C", VA = "0x179853C", Slot = "54")]
	protected override bool CheckIsWinTeamPlayerForSpectator(IHAAMHPPLMG playerID)
	{
		return default(bool);
	}

	[Token(Token = "0x600BB3B")]
	[Address(RVA = "0x17955BC", Offset = "0x17955BC", VA = "0x17955BC")]
	private void UpdateTeamInfo(MatchStats stats)
	{
	}

	[Token(Token = "0x600BB3C")]
	[Address(RVA = "0x1797264", Offset = "0x1797264", VA = "0x1797264")]
	private void UpdateTeammateInfo(bool localTeam, List<TeammateStats> players)
	{
	}

	[Token(Token = "0x600BB3D")]
	[Address(RVA = "0x179889C", Offset = "0x179889C", VA = "0x179889C")]
	private void OnClickReportBtn()
	{
	}

	[Token(Token = "0x600BB3E")]
	[Address(RVA = "0x1798B4C", Offset = "0x1798B4C", VA = "0x1798B4C")]
	private void OnClickAddFriendBtn()
	{
	}

	[Token(Token = "0x600BB3F")]
	[Address(RVA = "0x17978E8", Offset = "0x17978E8", VA = "0x17978E8")]
	private void OnClickLikeBtn()
	{
	}

	[Token(Token = "0x600BB40")]
	[Address(RVA = "0x1798DCC", Offset = "0x1798DCC", VA = "0x1798DCC")]
	public void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	[Token(Token = "0x600BB41")]
	[Address(RVA = "0x1798DD4", Offset = "0x1798DD4", VA = "0x1798DD4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BB42")]
	[Address(RVA = "0x1798DDC", Offset = "0x1798DDC", VA = "0x1798DDC")]
	public void _003C_003EiFixBaseProxy_OnShowAvatarInfoUI()
	{
	}

	[Token(Token = "0x600BB43")]
	[Address(RVA = "0x1798DE4", Offset = "0x1798DE4", VA = "0x1798DE4")]
	public void _003C_003EiFixBaseProxy_OnChangePageType()
	{
	}

	[Token(Token = "0x600BB44")]
	[Address(RVA = "0x1798DEC", Offset = "0x1798DEC", VA = "0x1798DEC")]
	public void _003C_003EiFixBaseProxy_OnShowDetailUI(bool P0)
	{
	}

	[Token(Token = "0x600BB45")]
	[Address(RVA = "0x1798DF4", Offset = "0x1798DF4", VA = "0x1798DF4")]
	public int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600BB46")]
	[Address(RVA = "0x1798DFC", Offset = "0x1798DFC", VA = "0x1798DFC")]
	public int[] _003C_003EiFixBaseProxy_GetInfoTypesData()
	{
		return null;
	}

	[Token(Token = "0x600BB47")]
	[Address(RVA = "0x1798E04", Offset = "0x1798E04", VA = "0x1798E04")]
	public void _003C_003EiFixBaseProxy_OnFixMatchInfoForLanguage()
	{
	}

	[Token(Token = "0x600BB48")]
	[Address(RVA = "0x1798E0C", Offset = "0x1798E0C", VA = "0x1798E0C")]
	public bool _003C_003EiFixBaseProxy_CheckIsWinTeamPlayerForSpectator(IHAAMHPPLMG P0)
	{
		return default(bool);
	}
}
