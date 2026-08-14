using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20026C7")]
public class UIHistoryRecordItemController : UIEasyListItemController
{
	[Token(Token = "0x400EF4C")]
	[FieldOffset(Offset = "0x38")]
	private UIHistoryRecordItemView m_View;

	[Token(Token = "0x400EF4D")]
	[FieldOffset(Offset = "0x3C")]
	private MatchRecordPersonal m_RecordData;

	[Token(Token = "0x400EF4E")]
	[FieldOffset(Offset = "0x40")]
	private MobileReplayInfo m_ReplayData;

	[Token(Token = "0x400EF4F")]
	private const string FIRST_STRING = "TXT_OB5_HISTORY_NO1";

	[Token(Token = "0x400EF50")]
	private const string TOP3_STRING = "TXT_OB5_HISTORY_TOP3";

	[Token(Token = "0x400EF51")]
	private const string TOP5_STRING = "TXT_OB5_HISTORY_TOP5";

	[Token(Token = "0x400EF52")]
	private const string TOP10_STRING = "TXT_OB5_HISTORY_TOP10";

	[Token(Token = "0x400EF53")]
	private const string Win_String = "T_26_YP_HISTORY_WIN";

	[Token(Token = "0x400EF54")]
	private const string Lose_string = "T_26_YP_HISTORY_LOSE";

	[Token(Token = "0x400EF55")]
	private const string Draw_String = "T_32_M_WS_PEACE";

	[Token(Token = "0x400EF56")]
	private const uint FIRST_COLOR = 4294949376u;

	[Token(Token = "0x400EF57")]
	private const uint HIGHRANK_COLOR = uint.MaxValue;

	[Token(Token = "0x400EF58")]
	public const string POSITIVE_DELTA_COLOR = "[62ffe3]";

	[Token(Token = "0x400EF59")]
	public const string NEGATIVE_DELTA_COLOR = "[ff2a00]";

	[Token(Token = "0x400EF5A")]
	public const string LABLE_COLOR_1 = "[F2801A]";

	[Token(Token = "0x400EF5B")]
	public const string LABLE_COLOR_2 = "[3D3D4C]";

	[Token(Token = "0x400EF5C")]
	[FieldOffset(Offset = "0x44")]
	private Color colorbg1;

	[Token(Token = "0x400EF5D")]
	[FieldOffset(Offset = "0x54")]
	private Color colorbg2;

	[Token(Token = "0x400EF5E")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<TeammateStats> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400EF5F")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<TeammateStats> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600EA54")]
	[Address(RVA = "0x162D704", Offset = "0x162D704", VA = "0x162D704")]
	public UIHistoryRecordItemController()
	{
	}

	[Token(Token = "0x600EA55")]
	[Address(RVA = "0x162D7AC", Offset = "0x162D7AC", VA = "0x162D7AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EA56")]
	[Address(RVA = "0x162D908", Offset = "0x162D908", VA = "0x162D908")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EA57")]
	[Address(RVA = "0x162D9AC", Offset = "0x162D9AC", VA = "0x162D9AC")]
	private bool IsMatchInfo4v4(MatchRecordPersonal data)
	{
		return default(bool);
	}

	[Token(Token = "0x600EA58")]
	[Address(RVA = "0x162DA2C", Offset = "0x162DA2C", VA = "0x162DA2C")]
	private ulong GetMvpPlayerAccount(List<TeammateStats> players, uint mode)
	{
		return default(ulong);
	}

	[Token(Token = "0x600EA59")]
	[Address(RVA = "0x162DDB0", Offset = "0x162DDB0", VA = "0x162DDB0")]
	private void ShowMvp(bool isGiveUp)
	{
	}

	[Token(Token = "0x600EA5A")]
	[Address(RVA = "0x162E1FC", Offset = "0x162E1FC", VA = "0x162E1FC")]
	private void UpdateDelta(MatchRecordPersonal data)
	{
	}

	[Token(Token = "0x600EA5B")]
	[Address(RVA = "0x162EBD8", Offset = "0x162EBD8", VA = "0x162EBD8", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600EA5C")]
	[Address(RVA = "0x1631B90", Offset = "0x1631B90", VA = "0x1631B90")]
	private void SetGroupHeadCount(uint groupMode)
	{
	}

	[Token(Token = "0x600EA5D")]
	[Address(RVA = "0x1631D60", Offset = "0x1631D60", VA = "0x1631D60")]
	private void RefreshReplayBtn()
	{
	}

	[Token(Token = "0x600EA5E")]
	[Address(RVA = "0x1631E68", Offset = "0x1631E68", VA = "0x1631E68")]
	private void OnPlayClick()
	{
	}

	[Token(Token = "0x600EA5F")]
	[Address(RVA = "0x16320D8", Offset = "0x16320D8", VA = "0x16320D8")]
	private void OnSaveClick()
	{
	}

	[Token(Token = "0x600EA60")]
	[Address(RVA = "0x163232C", Offset = "0x163232C", VA = "0x163232C", Slot = "32")]
	public override void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600EA61")]
	[Address(RVA = "0x16324A8", Offset = "0x16324A8", VA = "0x16324A8", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600EA62")]
	[Address(RVA = "0x1632544", Offset = "0x1632544", VA = "0x1632544", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600EA63")]
	[Address(RVA = "0x16325E0", Offset = "0x16325E0", VA = "0x16325E0")]
	private static int _003CGetMvpPlayerAccount_003Em__0(TeammateStats player1, TeammateStats player2)
	{
		return default(int);
	}

	[Token(Token = "0x600EA64")]
	[Address(RVA = "0x1632654", Offset = "0x1632654", VA = "0x1632654")]
	private static int _003CGetMvpPlayerAccount_003Em__1(TeammateStats player1, TeammateStats player2)
	{
		return default(int);
	}

	[Token(Token = "0x600EA65")]
	[Address(RVA = "0x16326AC", Offset = "0x16326AC", VA = "0x16326AC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EA66")]
	[Address(RVA = "0x16326B4", Offset = "0x16326B4", VA = "0x16326B4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}

	[Token(Token = "0x600EA67")]
	[Address(RVA = "0x16326BC", Offset = "0x16326BC", VA = "0x16326BC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600EA68")]
	[Address(RVA = "0x16326C4", Offset = "0x16326C4", VA = "0x16326C4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
