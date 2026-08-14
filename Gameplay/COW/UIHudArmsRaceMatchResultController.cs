using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001FA3")]
internal class UIHudArmsRaceMatchResultController : UIHudMatchResultBaseShareController, _Attribute
{
	[Token(Token = "0x400C676")]
	[FieldOffset(Offset = "0x4C")]
	private UIHudArmsRaceMatchResultView m_View;

	[Token(Token = "0x400C677")]
	[FieldOffset(Offset = "0x50")]
	private bool m_UIInited;

	[Token(Token = "0x6009DAC")]
	[Address(RVA = "0x1705480", Offset = "0x1705480", VA = "0x1705480")]
	public UIHudArmsRaceMatchResultController()
	{
	}

	[Token(Token = "0x6009DAD")]
	[Address(RVA = "0x1705488", Offset = "0x1705488", VA = "0x1705488")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009DAE")]
	[Address(RVA = "0x1705530", Offset = "0x1705530", VA = "0x1705530", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009DAF")]
	[Address(RVA = "0x1705838", Offset = "0x1705838", VA = "0x1705838", Slot = "33")]
	protected override void OnMatchStatsChange(MatchStats stats, MatchIncome income)
	{
	}

	[Token(Token = "0x6009DB0")]
	[Address(RVA = "0x1705698", Offset = "0x1705698", VA = "0x1705698")]
	private void ShowUI(MatchStats statsData, MatchIncome income)
	{
	}

	[Token(Token = "0x6009DB1")]
	[Address(RVA = "0x17058C0", Offset = "0x17058C0", VA = "0x17058C0", Slot = "38")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6009DB2")]
	[Address(RVA = "0x1705AA4", Offset = "0x1705AA4", VA = "0x1705AA4", Slot = "39")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6009DB3")]
	[Address(RVA = "0x1705B20", Offset = "0x1705B20", VA = "0x1705B20")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009DB4")]
	[Address(RVA = "0x1705B28", Offset = "0x1705B28", VA = "0x1705B28")]
	public void _003C_003EiFixBaseProxy_OnMatchStatsChange(MatchStats P0, MatchIncome P1)
	{
	}
}
