using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002059")]
internal class UIHudCSSOLeaderboardItemController : UIBaseController
{
	[Token(Token = "0x400CABA")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCSSOLeaderboardItemView m_View;

	[Token(Token = "0x400CABB")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400CABC")]
	[FieldOffset(Offset = "0x30")]
	private byte m_TeamID;

	[Token(Token = "0x400CABD")]
	[FieldOffset(Offset = "0x31")]
	private byte m_LastRoundTeamID;

	[Token(Token = "0x400CABE")]
	[FieldOffset(Offset = "0x34")]
	private List<UILabel> m_NameList;

	[Token(Token = "0x400CABF")]
	[FieldOffset(Offset = "0x38")]
	private List<UILabel> m_KillNumList;

	[Token(Token = "0x400CAC0")]
	[FieldOffset(Offset = "0x3C")]
	private int m_Index;

	[Token(Token = "0x400CAC1")]
	[FieldOffset(Offset = "0x40")]
	private uint m_DelayCallID;

	[Token(Token = "0x400CAC2")]
	[FieldOffset(Offset = "0x44")]
	private uint m_AnimDelayCallID;

	[Token(Token = "0x400CAC3")]
	[FieldOffset(Offset = "0x48")]
	private bool m_ShowNormalMatch;

	[Token(Token = "0x400CAC4")]
	[FieldOffset(Offset = "0x49")]
	private bool m_ShowSpecialMatch;

	[Token(Token = "0x400CAC5")]
	[FieldOffset(Offset = "0x4C")]
	private Color m_BGBaseColor;

	[Token(Token = "0x600A538")]
	[Address(RVA = "0x212B5E8", Offset = "0x212B5E8", VA = "0x212B5E8")]
	public UIHudCSSOLeaderboardItemController()
	{
	}

	[Token(Token = "0x600A539")]
	[Address(RVA = "0x212B66C", Offset = "0x212B66C", VA = "0x212B66C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A53A")]
	[Address(RVA = "0x212B714", Offset = "0x212B714", VA = "0x212B714", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A53B")]
	[Address(RVA = "0x212BBC0", Offset = "0x212BBC0", VA = "0x212BBC0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A53C")]
	[Address(RVA = "0x212BD48", Offset = "0x212BD48", VA = "0x212BD48")]
	public void SetDataInfo(byte lastRoundTeamID, byte teamID, int index)
	{
	}

	[Token(Token = "0x600A53D")]
	[Address(RVA = "0x212D268", Offset = "0x212D268", VA = "0x212D268")]
	public void SetDataInfo(byte teamID, int index)
	{
	}

	[Token(Token = "0x600A53E")]
	[Address(RVA = "0x212D32C", Offset = "0x212D32C", VA = "0x212D32C")]
	public void SetMatchInfo(bool showNormalMatch, bool showSpecialMatch, bool showImmediately = false)
	{
	}

	[Token(Token = "0x600A53F")]
	[Address(RVA = "0x212C12C", Offset = "0x212C12C", VA = "0x212C12C")]
	private void RefreshPlayersInfo(byte teamID)
	{
	}

	[Token(Token = "0x600A540")]
	[Address(RVA = "0x212D4D4", Offset = "0x212D4D4", VA = "0x212D4D4")]
	private string PlayerKDAString(AFDILJDJCCJ killInfo)
	{
		return null;
	}

	[Token(Token = "0x600A541")]
	[Address(RVA = "0x212D174", Offset = "0x212D174", VA = "0x212D174")]
	private void RefreshBattleResult()
	{
	}

	[Token(Token = "0x600A542")]
	[Address(RVA = "0x212D634", Offset = "0x212D634", VA = "0x212D634")]
	private void HideBattleResult()
	{
	}

	[Token(Token = "0x600A543")]
	[Address(RVA = "0x212D6FC", Offset = "0x212D6FC", VA = "0x212D6FC")]
	private void PlayAnim()
	{
	}

	[Token(Token = "0x600A544")]
	[Address(RVA = "0x212D918", Offset = "0x212D918", VA = "0x212D918")]
	private void OnAnimFinish()
	{
	}

	[Token(Token = "0x600A545")]
	[Address(RVA = "0x212D980", Offset = "0x212D980", VA = "0x212D980")]
	private void RefreshRankChange()
	{
	}

	[Token(Token = "0x600A546")]
	[Address(RVA = "0x212D0B4", Offset = "0x212D0B4", VA = "0x212D0B4")]
	private void RefreshEliminateState(byte teamID)
	{
	}

	[Token(Token = "0x600A547")]
	[Address(RVA = "0x212CF04", Offset = "0x212CF04", VA = "0x212CF04")]
	private bool IsLastRoundEliminate(byte teamID)
	{
		return default(bool);
	}

	[Token(Token = "0x600A548")]
	[Address(RVA = "0x212C834", Offset = "0x212C834", VA = "0x212C834")]
	private void RefreshTeamInfoView(byte teamID)
	{
	}

	[Token(Token = "0x600A549")]
	[Address(RVA = "0x212C974", Offset = "0x212C974", VA = "0x212C974")]
	private void RefreshIndex()
	{
	}

	[Token(Token = "0x600A54A")]
	[Address(RVA = "0x212D3C4", Offset = "0x212D3C4", VA = "0x212D3C4")]
	private void RefreshMatchInfo()
	{
	}

	[Token(Token = "0x600A54B")]
	[Address(RVA = "0x212CC80", Offset = "0x212CC80", VA = "0x212CC80")]
	private void RefreshBGColor(byte teamID)
	{
	}

	[Token(Token = "0x600A54C")]
	[Address(RVA = "0x212BF70", Offset = "0x212BF70", VA = "0x212BF70")]
	private void RefreshTeamName(byte teamID)
	{
	}

	[Token(Token = "0x600A54D")]
	[Address(RVA = "0x212E2F4", Offset = "0x212E2F4", VA = "0x212E2F4")]
	private void _003CSetDataInfo_003Em__0()
	{
	}

	[Token(Token = "0x600A54E")]
	[Address(RVA = "0x212E2F8", Offset = "0x212E2F8", VA = "0x212E2F8")]
	private void _003CPlayAnim_003Em__1()
	{
	}

	[Token(Token = "0x600A54F")]
	[Address(RVA = "0x212E348", Offset = "0x212E348", VA = "0x212E348")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A550")]
	[Address(RVA = "0x212E350", Offset = "0x212E350", VA = "0x212E350")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
