using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002052")]
internal class UIHudLeaderboardController : UIBaseController
{
	[Token(Token = "0x400CA9C")]
	[FieldOffset(Offset = "0x28")]
	private UIHudLeaderboardView m_View;

	[Token(Token = "0x400CA9D")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<IHAAMHPPLMG, LeaderboardData> m_ItemsBe4LocalPlayer;

	[Token(Token = "0x400CA9E")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<IHAAMHPPLMG, UIHudLeaderboardItemController> m_ItemControllers;

	[Token(Token = "0x400CA9F")]
	[FieldOffset(Offset = "0x34")]
	private bool m_LocalPlayerAdded;

	[Token(Token = "0x400CAA0")]
	[FieldOffset(Offset = "0x38")]
	private int m_LocalPlayerTeamId;

	[Token(Token = "0x400CAA1")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_IsSPFactionUpdated;

	[Token(Token = "0x400CAA2")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<Transform> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600A4D8")]
	[Address(RVA = "0xFE8808", Offset = "0xFE8808", VA = "0xFE8808")]
	public UIHudLeaderboardController()
	{
	}

	[Token(Token = "0x600A4D9")]
	[Address(RVA = "0xFE88F4", Offset = "0xFE88F4", VA = "0xFE88F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A4DA")]
	[Address(RVA = "0xFE8998", Offset = "0xFE8998", VA = "0xFE8998", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A4DB")]
	[Address(RVA = "0xFE8E74", Offset = "0xFE8E74", VA = "0xFE8E74", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A4DC")]
	[Address(RVA = "0xFE9280", Offset = "0xFE9280", VA = "0xFE9280")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x600A4DD")]
	[Address(RVA = "0xFE92EC", Offset = "0xFE92EC", VA = "0xFE92EC")]
	private void OnAddPlayer(object[] param)
	{
	}

	[Token(Token = "0x600A4DE")]
	[Address(RVA = "0xFEA0E4", Offset = "0xFEA0E4", VA = "0xFEA0E4")]
	private bool IsTeamOnLeft(IHAAMHPPLMG pId)
	{
		return default(bool);
	}

	[Token(Token = "0x600A4DF")]
	[Address(RVA = "0xFE9C04", Offset = "0xFE9C04", VA = "0xFE9C04")]
	private void AddItemController(IHAAMHPPLMG pId, LeaderboardData dataInfo)
	{
	}

	[Token(Token = "0x600A4E0")]
	[Address(RVA = "0xFEAB60", Offset = "0xFEAB60", VA = "0xFEAB60")]
	private void Sort(IHAAMHPPLMG pId)
	{
	}

	[Token(Token = "0x600A4E1")]
	[Address(RVA = "0xFEAD40", Offset = "0xFEAD40", VA = "0xFEAD40")]
	private void OnKillCountChanged(object[] param)
	{
	}

	[Token(Token = "0x600A4E2")]
	[Address(RVA = "0xFEAFC0", Offset = "0xFEAFC0", VA = "0xFEAFC0")]
	private void OnDeadCountChanged(object[] param)
	{
	}

	[Token(Token = "0x600A4E3")]
	[Address(RVA = "0xFEB240", Offset = "0xFEB240", VA = "0xFEB240")]
	private void OnAssistCountChanged(object[] param)
	{
	}

	[Token(Token = "0x600A4E4")]
	[Address(RVA = "0xFEB4C0", Offset = "0xFEB4C0", VA = "0xFEB4C0")]
	private void OnTotalDamageChanged(object[] param)
	{
	}

	[Token(Token = "0x600A4E5")]
	[Address(RVA = "0xFEB740", Offset = "0xFEB740", VA = "0xFEB740")]
	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	[Token(Token = "0x600A4E6")]
	[Address(RVA = "0xFEB834", Offset = "0xFEB834", VA = "0xFEB834")]
	private void OnFactionIDChanged(object[] param)
	{
	}

	[Token(Token = "0x600A4E7")]
	[Address(RVA = "0xFEA58C", Offset = "0xFEA58C", VA = "0xFEA58C")]
	private void UpdateFactionInfo()
	{
	}

	[Token(Token = "0x600A4E8")]
	[Address(RVA = "0xFEA2E0", Offset = "0xFEA2E0", VA = "0xFEA2E0")]
	private void UpdateFactionInfo(int localFactionID)
	{
	}

	[Token(Token = "0x600A4E9")]
	[Address(RVA = "0xFEB910", Offset = "0xFEB910", VA = "0xFEB910")]
	private void OnToggleRoundInfo(object[] parap)
	{
	}

	[Token(Token = "0x600A4EA")]
	[Address(RVA = "0xFEB9C4", Offset = "0xFEB9C4", VA = "0xFEB9C4", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A4EB")]
	[Address(RVA = "0xFEBABC", Offset = "0xFEBABC", VA = "0xFEBABC")]
	private static int _003CSort_003Em__0(Transform item2, Transform item1)
	{
		return default(int);
	}

	[Token(Token = "0x600A4EC")]
	[Address(RVA = "0xFEBD00", Offset = "0xFEBD00", VA = "0xFEBD00")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A4ED")]
	[Address(RVA = "0xFEBD08", Offset = "0xFEBD08", VA = "0xFEBD08")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A4EE")]
	[Address(RVA = "0xFEBD10", Offset = "0xFEBD10", VA = "0xFEBD10")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
