using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002044")]
internal class UIHudCSLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHudCSLeaderboardItemController>
{
	[Token(Token = "0x400CA49")]
	[FieldOffset(Offset = "0x41")]
	private bool m_IsSetSelfTeamInfo;

	[Token(Token = "0x400CA4A")]
	[FieldOffset(Offset = "0x42")]
	private bool m_IsSetOppoTeamInfo;

	[Token(Token = "0x400CA4B")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<Transform> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600A3FC")]
	[Address(RVA = "0x1F103F0", Offset = "0x1F103F0", VA = "0x1F103F0")]
	public UIHudCSLeaderboardController()
	{
	}

	[Token(Token = "0x600A3FD")]
	[Address(RVA = "0x1F10454", Offset = "0x1F10454", VA = "0x1F10454")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A3FE")]
	[Address(RVA = "0x1F104FC", Offset = "0x1F104FC", VA = "0x1F104FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A3FF")]
	[Address(RVA = "0x1F10A78", Offset = "0x1F10A78", VA = "0x1F10A78", Slot = "31")]
	protected override void SetInfoType()
	{
	}

	[Token(Token = "0x600A400")]
	[Address(RVA = "0x1F10C28", Offset = "0x1F10C28", VA = "0x1F10C28", Slot = "33")]
	public override void RegisterUIEvent()
	{
	}

	[Token(Token = "0x600A401")]
	[Address(RVA = "0x1F1100C", Offset = "0x1F1100C", VA = "0x1F1100C", Slot = "34")]
	public override void UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600A402")]
	[Address(RVA = "0x1F113F0", Offset = "0x1F113F0", VA = "0x1F113F0")]
	private void OnPlayerJoin(object[] param)
	{
	}

	[Token(Token = "0x600A403")]
	[Address(RVA = "0x1F11848", Offset = "0x1F11848", VA = "0x1F11848", Slot = "38")]
	protected override bool IsTeamOnLeft(IHAAMHPPLMG pId)
	{
		return default(bool);
	}

	[Token(Token = "0x600A404")]
	[Address(RVA = "0x1F11C40", Offset = "0x1F11C40", VA = "0x1F11C40")]
	private void Sort(IHAAMHPPLMG pId)
	{
	}

	[Token(Token = "0x600A405")]
	[Address(RVA = "0x1F11E24", Offset = "0x1F11E24", VA = "0x1F11E24", Slot = "41")]
	protected override void OnKillCountChanged(object[] param)
	{
	}

	[Token(Token = "0x600A406")]
	[Address(RVA = "0x1F11F4C", Offset = "0x1F11F4C", VA = "0x1F11F4C", Slot = "42")]
	protected override void OnDeadCountChanged(object[] param)
	{
	}

	[Token(Token = "0x600A407")]
	[Address(RVA = "0x1F12074", Offset = "0x1F12074", VA = "0x1F12074", Slot = "43")]
	protected override void OnTotalDamageChanged(object[] param)
	{
	}

	[Token(Token = "0x600A408")]
	[Address(RVA = "0x1F1219C", Offset = "0x1F1219C", VA = "0x1F1219C")]
	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	[Token(Token = "0x600A409")]
	[Address(RVA = "0x1F12290", Offset = "0x1F12290", VA = "0x1F12290")]
	private void OnToggleRoundInfo(object[] parap)
	{
	}

	[Token(Token = "0x600A40A")]
	[Address(RVA = "0x1F12344", Offset = "0x1F12344", VA = "0x1F12344", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A40B")]
	[Address(RVA = "0x1F1243C", Offset = "0x1F1243C", VA = "0x1F1243C")]
	private void OnTeamScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600A40C")]
	[Address(RVA = "0x1F1270C", Offset = "0x1F1270C", VA = "0x1F1270C")]
	private static int _003CSort_003Em__0(Transform item2, Transform item1)
	{
		return default(int);
	}

	[Token(Token = "0x600A40D")]
	[Address(RVA = "0x1F129A8", Offset = "0x1F129A8", VA = "0x1F129A8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A40E")]
	[Address(RVA = "0x1F129AC", Offset = "0x1F129AC", VA = "0x1F129AC")]
	public void _003C_003EiFixBaseProxy_SetInfoType()
	{
	}

	[Token(Token = "0x600A40F")]
	[Address(RVA = "0x1F129B0", Offset = "0x1F129B0", VA = "0x1F129B0")]
	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	[Token(Token = "0x600A410")]
	[Address(RVA = "0x1F129B4", Offset = "0x1F129B4", VA = "0x1F129B4")]
	public void _003C_003EiFixBaseProxy_UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600A411")]
	[Address(RVA = "0x1F129B8", Offset = "0x1F129B8", VA = "0x1F129B8")]
	public bool _003C_003EiFixBaseProxy_IsTeamOnLeft(IHAAMHPPLMG P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600A412")]
	[Address(RVA = "0x1F129E4", Offset = "0x1F129E4", VA = "0x1F129E4")]
	public void _003C_003EiFixBaseProxy_OnKillCountChanged(object[] P0)
	{
	}

	[Token(Token = "0x600A413")]
	[Address(RVA = "0x1F129E8", Offset = "0x1F129E8", VA = "0x1F129E8")]
	public void _003C_003EiFixBaseProxy_OnDeadCountChanged(object[] P0)
	{
	}

	[Token(Token = "0x600A414")]
	[Address(RVA = "0x1F129EC", Offset = "0x1F129EC", VA = "0x1F129EC")]
	public void _003C_003EiFixBaseProxy_OnTotalDamageChanged(object[] P0)
	{
	}

	[Token(Token = "0x600A415")]
	[Address(RVA = "0x1F129F0", Offset = "0x1F129F0", VA = "0x1F129F0")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
