using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002AAB")]
public class UIProfileTeamBattleMatchResultItemController : UIHudMatchResultItemBaseController
{
	[Token(Token = "0x4010666")]
	[FieldOffset(Offset = "0xDC")]
	private UIProfileTeamBattleMatchResultItemView m_View;

	[Token(Token = "0x4010667")]
	[FieldOffset(Offset = "0xE0")]
	private ulong m_PlayerId;

	[Token(Token = "0x4010668")]
	[FieldOffset(Offset = "0xE8")]
	private MatchStats m_MatchStats;

	[Token(Token = "0x4010669")]
	[FieldOffset(Offset = "0xF0")]
	private ulong m_MatchID;

	[Token(Token = "0x401066A")]
	[FieldOffset(Offset = "0xF8")]
	private Color Bar2Color;

	[Token(Token = "0x401066B")]
	[FieldOffset(Offset = "0x108")]
	private Color Bar3Color;

	[Token(Token = "0x401066C")]
	[FieldOffset(Offset = "0x118")]
	private Color BarlColor;

	[Token(Token = "0x6011750")]
	[Address(RVA = "0x1AB8D40", Offset = "0x1AB8D40", VA = "0x1AB8D40")]
	public UIProfileTeamBattleMatchResultItemController()
	{
	}

	[Token(Token = "0x6011751")]
	[Address(RVA = "0x1AB8E20", Offset = "0x1AB8E20", VA = "0x1AB8E20")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011752")]
	[Address(RVA = "0x1AB8EC4", Offset = "0x1AB8EC4", VA = "0x1AB8EC4", Slot = "45")]
	protected override void OnClickAddFriendBtn()
	{
	}

	[Token(Token = "0x6011753")]
	[Address(RVA = "0x1AB9038", Offset = "0x1AB9038", VA = "0x1AB9038")]
	public void SetMatchInfo(MatchStats mMatchStats, ulong matchID)
	{
	}

	[Token(Token = "0x6011754")]
	[Address(RVA = "0x1AB931C", Offset = "0x1AB931C", VA = "0x1AB931C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011755")]
	[Address(RVA = "0x1AB98B0", Offset = "0x1AB98B0", VA = "0x1AB98B0", Slot = "41")]
	public override void OnChangePageType(EMatchResultPageType pageType)
	{
	}

	[Token(Token = "0x6011756")]
	[Address(RVA = "0x1AB9C4C", Offset = "0x1AB9C4C", VA = "0x1AB9C4C", Slot = "46")]
	protected override void OnClickReportBtn()
	{
	}

	[Token(Token = "0x6011757")]
	[Address(RVA = "0x1ABA05C", Offset = "0x1ABA05C", VA = "0x1ABA05C", Slot = "39")]
	public override void ShowReportButton(bool show)
	{
	}

	[Token(Token = "0x6011758")]
	[Address(RVA = "0x1ABA334", Offset = "0x1ABA334", VA = "0x1ABA334", Slot = "48")]
	protected override void OnReportCheatSent(object[] param)
	{
	}

	[Token(Token = "0x6011759")]
	[Address(RVA = "0x1ABA568", Offset = "0x1ABA568", VA = "0x1ABA568", Slot = "40")]
	protected override void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	[Token(Token = "0x601175A")]
	[Address(RVA = "0x1ABA72C", Offset = "0x1ABA72C", VA = "0x1ABA72C")]
	private void UpdatePlayerData(TeammateStats player)
	{
	}

	[Token(Token = "0x601175B")]
	[Address(RVA = "0x1ABAD6C", Offset = "0x1ABAD6C", VA = "0x1ABAD6C")]
	private void OnBtnHeadClick()
	{
	}

	[Token(Token = "0x601175C")]
	[Address(RVA = "0x1ABB014", Offset = "0x1ABB014", VA = "0x1ABB014")]
	public void _003C_003EiFixBaseProxy_OnClickAddFriendBtn()
	{
	}

	[Token(Token = "0x601175D")]
	[Address(RVA = "0x1ABB01C", Offset = "0x1ABB01C", VA = "0x1ABB01C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601175E")]
	[Address(RVA = "0x1ABB024", Offset = "0x1ABB024", VA = "0x1ABB024")]
	public void _003C_003EiFixBaseProxy_OnChangePageType(EMatchResultPageType P0)
	{
	}

	[Token(Token = "0x601175F")]
	[Address(RVA = "0x1ABB02C", Offset = "0x1ABB02C", VA = "0x1ABB02C")]
	public void _003C_003EiFixBaseProxy_OnClickReportBtn()
	{
	}

	[Token(Token = "0x6011760")]
	[Address(RVA = "0x1ABB034", Offset = "0x1ABB034", VA = "0x1ABB034")]
	public void _003C_003EiFixBaseProxy_ShowReportButton(bool P0)
	{
	}

	[Token(Token = "0x6011761")]
	[Address(RVA = "0x1ABB03C", Offset = "0x1ABB03C", VA = "0x1ABB03C")]
	public void _003C_003EiFixBaseProxy_OnReportCheatSent(object[] P0)
	{
	}

	[Token(Token = "0x6011762")]
	[Address(RVA = "0x1ABB044", Offset = "0x1ABB044", VA = "0x1ABB044")]
	public void _003C_003EiFixBaseProxy_OnSetPlayerData(TeammateStats P0, bool P1)
	{
	}
}
