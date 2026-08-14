using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x200286A")]
internal class UIHudTeammatesInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x400F932")]
	[FieldOffset(Offset = "0x28")]
	private UIHudTeammatesInfoView m_View;

	[Token(Token = "0x400F933")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<IHAAMHPPLMG, UIHudTeammateItem> m_Teammates;

	[Token(Token = "0x400F934")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<ulong, IHAAMHPPLMG> m_UserIdToPlayerId;

	[Token(Token = "0x400F935")]
	[FieldOffset(Offset = "0x34")]
	private UIModelMatch m_MatchModel;

	[Token(Token = "0x400F936")]
	[FieldOffset(Offset = "0x38")]
	private List<UIHudTeammateItem> m_ListTeammateItem;

	[Token(Token = "0x400F937")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<int, Transform> m_DicPageGrid;

	[Token(Token = "0x400F938")]
	[FieldOffset(Offset = "0x40")]
	private UICenterOnChild m_wrapCenter;

	[Token(Token = "0x400F939")]
	[FieldOffset(Offset = "0x44")]
	private bool m_RemoveOnQuit;

	[Token(Token = "0x400F93A")]
	[FieldOffset(Offset = "0x48")]
	private int m_totalTeammatePage;

	[Token(Token = "0x400F93B")]
	[FieldOffset(Offset = "0x4C")]
	private Dictionary<IHAAMHPPLMG, MNJIFKDNEKI> m_TeammateSycInfo;

	[Token(Token = "0x400F93C")]
	[FieldOffset(Offset = "0x50")]
	private int ITEM_PER_PAGE;

	[Token(Token = "0x400F93D")]
	private const float _TEAMMATE_ITEM_GAP = -35f;

	[Token(Token = "0x400F93E")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<UIHudTeammateItem> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600FD40")]
	[Address(RVA = "0x17A4300", Offset = "0x17A4300", VA = "0x17A4300")]
	public UIHudTeammatesInfoController()
	{
	}

	[Token(Token = "0x600FD41")]
	[Address(RVA = "0x17A4430", Offset = "0x17A4430", VA = "0x17A4430")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FD42")]
	[Address(RVA = "0x17A44D4", Offset = "0x17A44D4", VA = "0x17A44D4")]
	private bool NeedWrapPages()
	{
		return default(bool);
	}

	[Token(Token = "0x600FD43")]
	[Address(RVA = "0x17A46DC", Offset = "0x17A46DC", VA = "0x17A46DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FD44")]
	[Address(RVA = "0x17A5F04", Offset = "0x17A5F04", VA = "0x17A5F04", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FD45")]
	[Address(RVA = "0x17A6E2C", Offset = "0x17A6E2C", VA = "0x17A6E2C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FD46")]
	[Address(RVA = "0x17A7D2C", Offset = "0x17A7D2C", VA = "0x17A7D2C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600FD47")]
	[Address(RVA = "0x17AA250", Offset = "0x17AA250", VA = "0x17AA250")]
	private void GetCenterItem(GameObject centerGo)
	{
	}

	[Token(Token = "0x600FD48")]
	[Address(RVA = "0x17AA55C", Offset = "0x17AA55C", VA = "0x17AA55C")]
	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	[Token(Token = "0x600FD49")]
	[Address(RVA = "0x17AA62C", Offset = "0x17AA62C", VA = "0x17AA62C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600FD4A")]
	[Address(RVA = "0x17AA6C4", Offset = "0x17AA6C4", VA = "0x17AA6C4")]
	private void OnPlayerHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600FD4B")]
	[Address(RVA = "0x17AA9B8", Offset = "0x17AA9B8", VA = "0x17AA9B8")]
	private void OnLevelChanged(object[] data)
	{
	}

	[Token(Token = "0x600FD4C")]
	[Address(RVA = "0x17AABD4", Offset = "0x17AABD4", VA = "0x17AABD4")]
	private void OnRescueByTeammate(object[] data)
	{
	}

	[Token(Token = "0x600FD4D")]
	[Address(RVA = "0x17AADE0", Offset = "0x17AADE0", VA = "0x17AADE0")]
	private void OnPlayerKnockDownStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600FD4E")]
	[Address(RVA = "0x17AB57C", Offset = "0x17AB57C", VA = "0x17AB57C")]
	private void OnPlayerMaxHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600FD4F")]
	[Address(RVA = "0x17AB76C", Offset = "0x17AB76C", VA = "0x17AB76C")]
	private void OnRemoveMapMark(object[] data)
	{
	}

	[Token(Token = "0x600FD50")]
	[Address(RVA = "0x17AB8CC", Offset = "0x17AB8CC", VA = "0x17AB8CC")]
	private void OnUpdateMapMark(object[] data)
	{
	}

	[Token(Token = "0x600FD51")]
	[Address(RVA = "0x17ABA2C", Offset = "0x17ABA2C", VA = "0x17ABA2C")]
	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	[Token(Token = "0x600FD52")]
	[Address(RVA = "0x17ABC3C", Offset = "0x17ABC3C", VA = "0x17ABC3C")]
	private void OnPlayerGetOffVehicle(object[] data)
	{
	}

	[Token(Token = "0x600FD53")]
	[Address(RVA = "0x17ABE4C", Offset = "0x17ABE4C", VA = "0x17ABE4C")]
	private void OnTeammateKnockDown(object[] data)
	{
	}

	[Token(Token = "0x600FD54")]
	[Address(RVA = "0x17AC098", Offset = "0x17AC098", VA = "0x17AC098")]
	private void OnTeammateRevive(object[] data)
	{
	}

	[Token(Token = "0x600FD55")]
	[Address(RVA = "0x17AC2E4", Offset = "0x17AC2E4", VA = "0x17AC2E4")]
	private void OnTeammatePhyxStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600FD56")]
	[Address(RVA = "0x17AC5CC", Offset = "0x17AC5CC", VA = "0x17AC5CC")]
	private void OnTeammateQuit(object[] data)
	{
	}

	[Token(Token = "0x600FD57")]
	[Address(RVA = "0x17AC97C", Offset = "0x17AC97C", VA = "0x17AC97C")]
	private void OnRefreshQuitTeamMateUI(object[] data)
	{
	}

	[Token(Token = "0x600FD58")]
	[Address(RVA = "0x17ACB38", Offset = "0x17ACB38", VA = "0x17ACB38")]
	private void OnTeamateVadStateChange(object[] data)
	{
	}

	[Token(Token = "0x600FD59")]
	[Address(RVA = "0x17ACE34", Offset = "0x17ACE34", VA = "0x17ACE34")]
	private void OnMicrophoneChanged(object[] data)
	{
	}

	[Token(Token = "0x600FD5A")]
	[Address(RVA = "0x17AD0A8", Offset = "0x17AD0A8", VA = "0x17AD0A8")]
	private void OnOwnPlayerChange(object[] data)
	{
	}

	[Token(Token = "0x600FD5B")]
	[Address(RVA = "0x17AD2AC", Offset = "0x17AD2AC", VA = "0x17AD2AC")]
	private void OnTeammateMuteChange(object[] data)
	{
	}

	[Token(Token = "0x600FD5C")]
	[Address(RVA = "0x17AD5A8", Offset = "0x17AD5A8", VA = "0x17AD5A8")]
	private void OnTeamateStateChange(object[] data)
	{
	}

	[Token(Token = "0x600FD5D")]
	[Address(RVA = "0x17AD7B8", Offset = "0x17AD7B8", VA = "0x17AD7B8")]
	private void OnTeamInfoGet(object[] data)
	{
	}

	[Token(Token = "0x600FD5E")]
	[Address(RVA = "0x17A5020", Offset = "0x17A5020", VA = "0x17A5020")]
	private void Repositon()
	{
	}

	[Token(Token = "0x600FD5F")]
	[Address(RVA = "0x17ADFFC", Offset = "0x17ADFFC", VA = "0x17ADFFC")]
	private void OnTeamParachuteModeChange(object[] param)
	{
	}

	[Token(Token = "0x600FD60")]
	[Address(RVA = "0x17AE3C4", Offset = "0x17AE3C4", VA = "0x17AE3C4")]
	private void OnTrainingZoneChanged(object[] param)
	{
	}

	[Token(Token = "0x600FD61")]
	[Address(RVA = "0x17AE4C0", Offset = "0x17AE4C0", VA = "0x17AE4C0")]
	private void OnPlayerTrainingZoneChange(object[] param)
	{
	}

	[Token(Token = "0x600FD62")]
	[Address(RVA = "0x17AE660", Offset = "0x17AE660", VA = "0x17AE660")]
	private void OnPlayerTokenChanged(object[] param)
	{
	}

	[Token(Token = "0x600FD63")]
	[Address(RVA = "0x17AE844", Offset = "0x17AE844", VA = "0x17AE844")]
	private void OnPlayerGuildWarPropChanged(object[] param)
	{
	}

	[Token(Token = "0x600FD64")]
	[Address(RVA = "0x17AE9E8", Offset = "0x17AE9E8", VA = "0x17AE9E8")]
	private void OnPlayerPickupOrDropBomb(object[] param)
	{
	}

	[Token(Token = "0x600FD65")]
	[Address(RVA = "0x17AB388", Offset = "0x17AB388", VA = "0x17AB388")]
	private bool IsHadKnockDownTeammate()
	{
		return default(bool);
	}

	[Token(Token = "0x600FD66")]
	[Address(RVA = "0x17A9E88", Offset = "0x17A9E88", VA = "0x17A9E88")]
	private void OnNewPhaseStarted(object[] data)
	{
	}

	[Token(Token = "0x600FD67")]
	[Address(RVA = "0x17AEC24", Offset = "0x17AEC24", VA = "0x17AEC24")]
	private void OnADS1v1Countdown(object[] data)
	{
	}

	[Token(Token = "0x600FD68")]
	[Address(RVA = "0x17AF4E4", Offset = "0x17AF4E4", VA = "0x17AF4E4")]
	private void OnADS1v1Selected(object[] data)
	{
	}

	[Token(Token = "0x600FD69")]
	[Address(RVA = "0x17AF8C0", Offset = "0x17AF8C0", VA = "0x17AF8C0")]
	private void OnADSPlayerWin(object[] param)
	{
	}

	[Token(Token = "0x600FD6A")]
	[Address(RVA = "0x17B0060", Offset = "0x17B0060", VA = "0x17B0060")]
	private void OnLocalPlayerOnHandWeaponChange(object[] data)
	{
	}

	[Token(Token = "0x600FD6B")]
	[Address(RVA = "0x17B0350", Offset = "0x17B0350", VA = "0x17B0350")]
	private static int _003CRepositon_003Em__0(UIHudTeammateItem a, UIHudTeammateItem b)
	{
		return default(int);
	}

	[Token(Token = "0x600FD6C")]
	[Address(RVA = "0x17B03AC", Offset = "0x17B03AC", VA = "0x17B03AC")]
	private void _003COnADSPlayerWin_003Em__1()
	{
	}

	[Token(Token = "0x600FD6D")]
	[Address(RVA = "0x17B0560", Offset = "0x17B0560", VA = "0x17B0560")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FD6E")]
	[Address(RVA = "0x17B0568", Offset = "0x17B0568", VA = "0x17B0568")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600FD6F")]
	[Address(RVA = "0x17B0570", Offset = "0x17B0570", VA = "0x17B0570")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
