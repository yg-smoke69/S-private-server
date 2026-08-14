using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002297")]
internal class UISPHudTeammatesInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x400D8A9")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudTeammatesInfoView m_View;

	[Token(Token = "0x400D8AA")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<IHAAMHPPLMG, UISPHudTeammateItem> m_Teammates;

	[Token(Token = "0x400D8AB")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<ulong, UISPHudTeammateItem> m_TeammatesWithAccountID;

	[Token(Token = "0x400D8AC")]
	[FieldOffset(Offset = "0x34")]
	private UIModelMatch m_MatchModel;

	[Token(Token = "0x400D8AD")]
	[FieldOffset(Offset = "0x38")]
	private List<UISPHudTeammateItem> m_ListTeammateItem;

	[Token(Token = "0x400D8AE")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelSpectator m_SpModel;

	[Token(Token = "0x400D8AF")]
	[FieldOffset(Offset = "0x40")]
	private List<UISPHudTeammateMissionItem> m_MissionItemList;

	[Token(Token = "0x400D8B0")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<MatchTeam.MNJIFKDNEKI> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600BDD2")]
	[Address(RVA = "0x14A00F4", Offset = "0x14A00F4", VA = "0x14A00F4")]
	public UISPHudTeammatesInfoController()
	{
	}

	[Token(Token = "0x600BDD3")]
	[Address(RVA = "0x14A01E0", Offset = "0x14A01E0", VA = "0x14A01E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BDD4")]
	[Address(RVA = "0x14A0288", Offset = "0x14A0288", VA = "0x14A0288", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BDD5")]
	[Address(RVA = "0x14A07EC", Offset = "0x14A07EC", VA = "0x14A07EC", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600BDD6")]
	[Address(RVA = "0x14A1008", Offset = "0x14A1008", VA = "0x14A1008", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BDD7")]
	[Address(RVA = "0x14A186C", Offset = "0x14A186C", VA = "0x14A186C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600BDD8")]
	[Address(RVA = "0x14A3644", Offset = "0x14A3644", VA = "0x14A3644", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600BDD9")]
	[Address(RVA = "0x14A3700", Offset = "0x14A3700", VA = "0x14A3700")]
	private void OnPlayerHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600BDDA")]
	[Address(RVA = "0x14A3978", Offset = "0x14A3978", VA = "0x14A3978")]
	private void OnPlayerMaxHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600BDDB")]
	[Address(RVA = "0x14A3B64", Offset = "0x14A3B64", VA = "0x14A3B64")]
	private void OnRemoveMapMark(object[] data)
	{
	}

	[Token(Token = "0x600BDDC")]
	[Address(RVA = "0x14A3CC8", Offset = "0x14A3CC8", VA = "0x14A3CC8")]
	private void OnUpdateMapMark(object[] data)
	{
	}

	[Token(Token = "0x600BDDD")]
	[Address(RVA = "0x14A3E2C", Offset = "0x14A3E2C", VA = "0x14A3E2C")]
	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	[Token(Token = "0x600BDDE")]
	[Address(RVA = "0x14A4040", Offset = "0x14A4040", VA = "0x14A4040")]
	private void OnPlayerGetOffVehicle(object[] data)
	{
	}

	[Token(Token = "0x600BDDF")]
	[Address(RVA = "0x14A4254", Offset = "0x14A4254", VA = "0x14A4254")]
	private void OnTeammateKnockDown(object[] data)
	{
	}

	[Token(Token = "0x600BDE0")]
	[Address(RVA = "0x14A4464", Offset = "0x14A4464", VA = "0x14A4464")]
	private void OnTeammateRevive(object[] data)
	{
	}

	[Token(Token = "0x600BDE1")]
	[Address(RVA = "0x14A4690", Offset = "0x14A4690", VA = "0x14A4690")]
	private void OnPlayerKnockDownStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600BDE2")]
	[Address(RVA = "0x14A4848", Offset = "0x14A4848", VA = "0x14A4848")]
	private void OnTeammateQuit(object[] data)
	{
	}

	[Token(Token = "0x600BDE3")]
	[Address(RVA = "0x14A4A08", Offset = "0x14A4A08", VA = "0x14A4A08")]
	private void OnTeamateVadStateChange(object[] data)
	{
	}

	[Token(Token = "0x600BDE4")]
	[Address(RVA = "0x14A4C40", Offset = "0x14A4C40", VA = "0x14A4C40")]
	private void OnTeamateStateChange(object[] data)
	{
	}

	[Token(Token = "0x600BDE5")]
	[Address(RVA = "0x14A4E50", Offset = "0x14A4E50", VA = "0x14A4E50")]
	private void OnTeamInfoGet(object[] data)
	{
	}

	[Token(Token = "0x600BDE6")]
	[Address(RVA = "0x14A34AC", Offset = "0x14A34AC", VA = "0x14A34AC")]
	private void UpdatePlayerKillCount(PlayerData pData)
	{
	}

	[Token(Token = "0x600BDE7")]
	[Address(RVA = "0x14A23E4", Offset = "0x14A23E4", VA = "0x14A23E4")]
	private void UpdateTeamKillCount(IHAAMHPPLMG pId)
	{
	}

	[Token(Token = "0x600BDE8")]
	[Address(RVA = "0x14A25B4", Offset = "0x14A25B4", VA = "0x14A25B4")]
	private void UpdateTeamName(IHAAMHPPLMG pId)
	{
	}

	[Token(Token = "0x600BDE9")]
	[Address(RVA = "0x14A27C8", Offset = "0x14A27C8", VA = "0x14A27C8")]
	private void UpdateTeamRegion(IHAAMHPPLMG pId)
	{
	}

	[Token(Token = "0x600BDEA")]
	[Address(RVA = "0x14A5538", Offset = "0x14A5538", VA = "0x14A5538")]
	private void UpdateTeamColor(UILabel Text, int TeamID)
	{
	}

	[Token(Token = "0x600BDEB")]
	[Address(RVA = "0x14A569C", Offset = "0x14A569C", VA = "0x14A569C")]
	private void OnLocalPlayerNewItemOnHand(object[] param)
	{
	}

	[Token(Token = "0x600BDEC")]
	[Address(RVA = "0x14A5960", Offset = "0x14A5960", VA = "0x14A5960")]
	private void OnLocalPlayerNewReviveInfo(object[] param)
	{
	}

	[Token(Token = "0x600BDED")]
	[Address(RVA = "0x14A5B18", Offset = "0x14A5B18", VA = "0x14A5B18")]
	private void OnTeammateNewItemOnHand(object[] param)
	{
	}

	[Token(Token = "0x600BDEE")]
	[Address(RVA = "0x14A5DDC", Offset = "0x14A5DDC", VA = "0x14A5DDC")]
	private void OnPlayerFire(object[] param)
	{
	}

	[Token(Token = "0x600BDEF")]
	[Address(RVA = "0x14A6134", Offset = "0x14A6134", VA = "0x14A6134")]
	private void OnKingOfKillerChange(object[] data)
	{
	}

	[Token(Token = "0x600BDF0")]
	[Address(RVA = "0x14A320C", Offset = "0x14A320C", VA = "0x14A320C")]
	private void RefreshKingOfKillerTeam()
	{
	}

	[Token(Token = "0x600BDF1")]
	[Address(RVA = "0x14A619C", Offset = "0x14A619C", VA = "0x14A619C")]
	private void OnTeamParachuteModeChange(object[] param)
	{
	}

	[Token(Token = "0x600BDF2")]
	[Address(RVA = "0x14A2B84", Offset = "0x14A2B84", VA = "0x14A2B84")]
	private void UpdateTeamIcon()
	{
	}

	[Token(Token = "0x600BDF3")]
	[Address(RVA = "0x14A6598", Offset = "0x14A6598", VA = "0x14A6598")]
	private void Update()
	{
	}

	[Token(Token = "0x600BDF4")]
	[Address(RVA = "0x14A65EC", Offset = "0x14A65EC", VA = "0x14A65EC")]
	private static int _003COnDataChanged_003Em__0(MatchTeam.MNJIFKDNEKI a, MatchTeam.MNJIFKDNEKI b)
	{
		return default(int);
	}

	[Token(Token = "0x600BDF5")]
	[Address(RVA = "0x14A6634", Offset = "0x14A6634", VA = "0x14A6634")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BDF6")]
	[Address(RVA = "0x14A663C", Offset = "0x14A663C", VA = "0x14A663C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600BDF7")]
	[Address(RVA = "0x14A6644", Offset = "0x14A6644", VA = "0x14A6644")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
