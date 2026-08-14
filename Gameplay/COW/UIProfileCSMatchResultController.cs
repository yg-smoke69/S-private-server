using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002A94")]
public class UIProfileCSMatchResultController : UIProfileBaseMatchResultController
{
	[Token(Token = "0x40105B3")]
	[FieldOffset(Offset = "0x54")]
	private UIProfileCSMatchResultView m_View;

	[Token(Token = "0x40105B4")]
	[FieldOffset(Offset = "0x58")]
	private List<UIProfileTeamBattleMatchResultItemController> m_ItemCtrlList;

	[Token(Token = "0x40105B5")]
	[FieldOffset(Offset = "0x5C")]
	private Dictionary<ulong, ExtraPlayerDataForMatchResult> m_PlayerMatchResultDataMap;

	[Token(Token = "0x40105B6")]
	[FieldOffset(Offset = "0x60")]
	private MatchStats m_MatchStats;

	[Token(Token = "0x40105B7")]
	[FieldOffset(Offset = "0x68")]
	private ulong m_MatchID;

	[Token(Token = "0x40105B8")]
	[FieldOffset(Offset = "0x70")]
	private bool m_SHowFastGift;

	[Token(Token = "0x40105B9")]
	[FieldOffset(Offset = "0x78")]
	private ulong m_WinMVPPlayerAccountID;

	[Token(Token = "0x40105BA")]
	[FieldOffset(Offset = "0x80")]
	private ulong m_FailMVPPlayerAccountID;

	[Token(Token = "0x40105BB")]
	[FieldOffset(Offset = "0x88")]
	private ulong m_ShowMVPPlayerAccountID;

	[Token(Token = "0x40105BC")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<TeammateStats, FriendInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x170012CB")]
	protected List<UIProfileTeamBattleMatchResultItemController> ItemCtrlList
	{
		[Token(Token = "0x6011616")]
		[Address(RVA = "0xF0BC80", Offset = "0xF0BC80", VA = "0xF0BC80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012CC")]
	protected Dictionary<ulong, ExtraPlayerDataForMatchResult> PlayerMatchResultDataMap
	{
		[Token(Token = "0x6011617")]
		[Address(RVA = "0xF0BD58", Offset = "0xF0BD58", VA = "0xF0BD58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012CD")]
	protected ulong WinMVPPlayerAccountID
	{
		[Token(Token = "0x6011618")]
		[Address(RVA = "0xF0BE30", Offset = "0xF0BE30", VA = "0xF0BE30")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6011619")]
		[Address(RVA = "0xF0BE88", Offset = "0xF0BE88", VA = "0xF0BE88")]
		set
		{
		}
	}

	[Token(Token = "0x170012CE")]
	protected ulong FailMVPPlayerAccountID
	{
		[Token(Token = "0x601161A")]
		[Address(RVA = "0xF0BF04", Offset = "0xF0BF04", VA = "0xF0BF04")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x601161B")]
		[Address(RVA = "0xF0BF5C", Offset = "0xF0BF5C", VA = "0xF0BF5C")]
		set
		{
		}
	}

	[Token(Token = "0x170012CF")]
	protected ulong ShowMVPPlayerAccountID
	{
		[Token(Token = "0x601161C")]
		[Address(RVA = "0xF0BFD8", Offset = "0xF0BFD8", VA = "0xF0BFD8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x601161D")]
		[Address(RVA = "0xF0C030", Offset = "0xF0C030", VA = "0xF0C030")]
		set
		{
		}
	}

	[Token(Token = "0x6011615")]
	[Address(RVA = "0xF0BC70", Offset = "0xF0BC70", VA = "0xF0BC70")]
	public UIProfileCSMatchResultController()
	{
	}

	[Token(Token = "0x601161E")]
	[Address(RVA = "0xF0C0AC", Offset = "0xF0C0AC", VA = "0xF0C0AC", Slot = "46")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x601161F")]
	[Address(RVA = "0xF0C17C", Offset = "0xF0C17C", VA = "0xF0C17C", Slot = "47")]
	protected override int[] GetInfoTypesData()
	{
		return null;
	}

	[Token(Token = "0x6011620")]
	[Address(RVA = "0xF0C24C", Offset = "0xF0C24C", VA = "0xF0C24C", Slot = "50")]
	protected virtual void UpdateMVPInfo(List<TeammateStats> players, bool win, bool show = false, bool showMVP = true)
	{
	}

	[Token(Token = "0x6011621")]
	[Address(RVA = "0xF0C4A8", Offset = "0xF0C4A8", VA = "0xF0C4A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011622")]
	[Address(RVA = "0xF0C54C", Offset = "0xF0C54C", VA = "0xF0C54C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011623")]
	[Address(RVA = "0xF0CAB8", Offset = "0xF0CAB8", VA = "0xF0CAB8", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x6011624")]
	[Address(RVA = "0xF0CF1C", Offset = "0xF0CF1C", VA = "0xF0CF1C", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x6011625")]
	[Address(RVA = "0xF0D3CC", Offset = "0xF0D3CC", VA = "0xF0D3CC")]
	private void OnShareBtnClick()
	{
	}

	[Token(Token = "0x6011626")]
	[Address(RVA = "0xF0D734", Offset = "0xF0D734", VA = "0xF0D734")]
	private void OnNextBtnClick()
	{
	}

	[Token(Token = "0x6011627")]
	[Address(RVA = "0xF0D798", Offset = "0xF0D798", VA = "0xF0D798")]
	private void OnFastGiftClick()
	{
	}

	[Token(Token = "0x6011628")]
	[Address(RVA = "0xF0D340", Offset = "0xF0D340", VA = "0xF0D340")]
	private bool GetDataBtnVisibility()
	{
		return default(bool);
	}

	[Token(Token = "0x6011629")]
	[Address(RVA = "0xF0DAA8", Offset = "0xF0DAA8", VA = "0xF0DAA8")]
	public void ShowMatchResultUIData(MatchStats stats, ulong matchID)
	{
	}

	[Token(Token = "0x601162A")]
	[Address(RVA = "0xF0ED10", Offset = "0xF0ED10", VA = "0xF0ED10")]
	private void ShowBiaoqianWindow(MatchStats stats)
	{
	}

	[Token(Token = "0x601162B")]
	[Address(RVA = "0xF0E6FC", Offset = "0xF0E6FC", VA = "0xF0E6FC")]
	private void SetResultDescTextByRank(uint rank)
	{
	}

	[Token(Token = "0x601162C")]
	[Address(RVA = "0xF0EAB4", Offset = "0xF0EAB4", VA = "0xF0EAB4")]
	private void CheckNeedShowRewardBtn(MatchStats stats)
	{
	}

	[Token(Token = "0x601162D")]
	[Address(RVA = "0xF0F2B0", Offset = "0xF0F2B0", VA = "0xF0F2B0", Slot = "48")]
	protected override void OnChangePageType()
	{
	}

	[Token(Token = "0x601162E")]
	[Address(RVA = "0xF0E294", Offset = "0xF0E294", VA = "0xF0E294")]
	protected void UpdateDataBtnStatus()
	{
	}

	[Token(Token = "0x601162F")]
	[Address(RVA = "0xF0F4BC", Offset = "0xF0F4BC", VA = "0xF0F4BC", Slot = "49")]
	protected override void UpdateInfoTitles()
	{
	}

	[Token(Token = "0x6011630")]
	[Address(RVA = "0xF0E4F8", Offset = "0xF0E4F8", VA = "0xF0E4F8")]
	protected void OnSetMatchResultInfo(MatchStats stats)
	{
	}

	[Token(Token = "0x6011631")]
	[Address(RVA = "0xF1120C", Offset = "0xF1120C", VA = "0xF1120C")]
	private void OnClickDataBtn()
	{
	}

	[Token(Token = "0x6011632")]
	[Address(RVA = "0xF11388", Offset = "0xF11388", VA = "0xF11388")]
	private void OnClickReportBtn()
	{
	}

	[Token(Token = "0x6011633")]
	[Address(RVA = "0xF115A8", Offset = "0xF115A8", VA = "0xF115A8")]
	private Transform GetItemTransform(bool localTeam)
	{
		return null;
	}

	[Token(Token = "0x6011634")]
	[Address(RVA = "0xF0FE98", Offset = "0xF0FE98", VA = "0xF0FE98")]
	private void UpdateTeamInfo(MatchStats stats, bool win)
	{
	}

	[Token(Token = "0x6011635")]
	[Address(RVA = "0xF0D52C", Offset = "0xF0D52C", VA = "0xF0D52C")]
	private void SendShareBtnClickLog()
	{
	}

	[Token(Token = "0x6011636")]
	[Address(RVA = "0xF10BA4", Offset = "0xF10BA4", VA = "0xF10BA4")]
	private void UpdateTeammateInfo(bool localTeam, List<TeammateStats> players)
	{
	}

	[Token(Token = "0x6011637")]
	[Address(RVA = "0xF11788", Offset = "0xF11788", VA = "0xF11788")]
	private ExtraPlayerDataForMatchResult GetPlayerMatchResultData(ulong accountID)
	{
		return null;
	}

	[Token(Token = "0x6011638")]
	[Address(RVA = "0xF1189C", Offset = "0xF1189C", VA = "0xF1189C")]
	private void CreatePlayerMatchResultData(ulong accountID, ulong localPlayerID, bool isFriend = false, uint likedCount = 0u)
	{
	}

	[Token(Token = "0x6011639")]
	[Address(RVA = "0xF0DD68", Offset = "0xF0DD68", VA = "0xF0DD68")]
	private void ConstructPlayerMatchResultInfo(MatchStats stats)
	{
	}

	[Token(Token = "0x601163A")]
	[Address(RVA = "0xF11BA4", Offset = "0xF11BA4", VA = "0xF11BA4")]
	private static FriendInfo _003COnFastGiftClick_003Em__0(TeammateStats teamMate)
	{
		return null;
	}

	[Token(Token = "0x601163B")]
	[Address(RVA = "0xF11BAC", Offset = "0xF11BAC", VA = "0xF11BAC")]
	public int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x601163C")]
	[Address(RVA = "0xF11BB0", Offset = "0xF11BB0", VA = "0xF11BB0")]
	public int[] _003C_003EiFixBaseProxy_GetInfoTypesData()
	{
		return null;
	}

	[Token(Token = "0x601163D")]
	[Address(RVA = "0xF11BB4", Offset = "0xF11BB4", VA = "0xF11BB4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601163E")]
	[Address(RVA = "0xF11BB8", Offset = "0xF11BB8", VA = "0xF11BB8")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x601163F")]
	[Address(RVA = "0xF11BC0", Offset = "0xF11BC0", VA = "0xF11BC0")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	[Token(Token = "0x6011640")]
	[Address(RVA = "0xF11BC8", Offset = "0xF11BC8", VA = "0xF11BC8")]
	public void _003C_003EiFixBaseProxy_OnChangePageType()
	{
	}

	[Token(Token = "0x6011641")]
	[Address(RVA = "0xF11BCC", Offset = "0xF11BCC", VA = "0xF11BCC")]
	public void _003C_003EiFixBaseProxy_UpdateInfoTitles()
	{
	}
}
