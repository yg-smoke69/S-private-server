using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002778")]
internal class UIHudHyakkiTeammatesInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x400F3A4")]
	[FieldOffset(Offset = "0x28")]
	private UIHudHyakkiTeammatesInfoView m_View;

	[Token(Token = "0x400F3A5")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<IHAAMHPPLMG, UIHudHyakkiTeammateItem> m_Teammates;

	[Token(Token = "0x400F3A6")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<ulong, UIHudHyakkiTeammateItem> m_TeammatesWithAccountID;

	[Token(Token = "0x400F3A7")]
	[FieldOffset(Offset = "0x34")]
	private UIModelMatch m_MatchModel;

	[Token(Token = "0x400F3A8")]
	[FieldOffset(Offset = "0x38")]
	private List<UIHudHyakkiTeammateItem> m_ListTeammateItem;

	[Token(Token = "0x400F3A9")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_EnoughMoneyToBuyback;

	[Token(Token = "0x400F3AA")]
	[FieldOffset(Offset = "0x3D")]
	private bool m_LocalPlayerDead;

	[Token(Token = "0x400F3AB")]
	[FieldOffset(Offset = "0x40")]
	private int m_PVEReviveGemCost;

	[Token(Token = "0x400F3AC")]
	[FieldOffset(Offset = "0x44")]
	private bool isCurShowDamageInfo;

	[Token(Token = "0x400F3AD")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<Transform> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600F1B5")]
	[Address(RVA = "0x1348878", Offset = "0x1348878", VA = "0x1348878")]
	public UIHudHyakkiTeammatesInfoController()
	{
	}

	[Token(Token = "0x600F1B6")]
	[Address(RVA = "0x1348938", Offset = "0x1348938", VA = "0x1348938")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F1B7")]
	[Address(RVA = "0x13489DC", Offset = "0x13489DC", VA = "0x13489DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F1B8")]
	[Address(RVA = "0x1348F68", Offset = "0x1348F68", VA = "0x1348F68", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F1B9")]
	[Address(RVA = "0x1349514", Offset = "0x1349514", VA = "0x1349514", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F1BA")]
	[Address(RVA = "0x1349AE4", Offset = "0x1349AE4", VA = "0x1349AE4", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600F1BB")]
	[Address(RVA = "0x1349F94", Offset = "0x1349F94", VA = "0x1349F94", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600F1BC")]
	[Address(RVA = "0x134A028", Offset = "0x134A028", VA = "0x134A028")]
	private void OnPlayerHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600F1BD")]
	[Address(RVA = "0x134A530", Offset = "0x134A530", VA = "0x134A530")]
	private void OnRemoveMapMark(object[] data)
	{
	}

	[Token(Token = "0x600F1BE")]
	[Address(RVA = "0x134A690", Offset = "0x134A690", VA = "0x134A690")]
	private void OnUpdateMapMark(object[] data)
	{
	}

	[Token(Token = "0x600F1BF")]
	[Address(RVA = "0x134A7F0", Offset = "0x134A7F0", VA = "0x134A7F0")]
	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	[Token(Token = "0x600F1C0")]
	[Address(RVA = "0x134AA00", Offset = "0x134AA00", VA = "0x134AA00")]
	private void OnPlayerGetOffVehicle(object[] data)
	{
	}

	[Token(Token = "0x600F1C1")]
	[Address(RVA = "0x134AC10", Offset = "0x134AC10", VA = "0x134AC10")]
	private void OnTeammateQuit(object[] data)
	{
	}

	[Token(Token = "0x600F1C2")]
	[Address(RVA = "0x134AF84", Offset = "0x134AF84", VA = "0x134AF84")]
	private void OnTeamateVadStateChange(object[] data)
	{
	}

	[Token(Token = "0x600F1C3")]
	[Address(RVA = "0x134B1B8", Offset = "0x134B1B8", VA = "0x134B1B8")]
	private void OnTeamateStateChange(object[] data)
	{
	}

	[Token(Token = "0x600F1C4")]
	[Address(RVA = "0x134B3C8", Offset = "0x134B3C8", VA = "0x134B3C8")]
	private void OnTeamInfoGet(object[] data)
	{
	}

	[Token(Token = "0x600F1C5")]
	[Address(RVA = "0x134BA98", Offset = "0x134BA98", VA = "0x134BA98")]
	private void OnPlayerReviveWalletChange(object[] data)
	{
	}

	[Token(Token = "0x600F1C6")]
	[Address(RVA = "0x134BAF4", Offset = "0x134BAF4", VA = "0x134BAF4")]
	private void OnPlayerRevive(object[] data)
	{
	}

	[Token(Token = "0x600F1C7")]
	[Address(RVA = "0x134A310", Offset = "0x134A310", VA = "0x134A310")]
	private void UpdateBuybackBtns()
	{
	}

	[Token(Token = "0x600F1C8")]
	[Address(RVA = "0x134BDCC", Offset = "0x134BDCC", VA = "0x134BDCC")]
	private void OnUpdateDamage(object[] data)
	{
	}

	[Token(Token = "0x600F1C9")]
	[Address(RVA = "0x134BFAC", Offset = "0x134BFAC", VA = "0x134BFAC")]
	private void OnTeamClick()
	{
	}

	[Token(Token = "0x600F1CA")]
	[Address(RVA = "0x134C164", Offset = "0x134C164", VA = "0x134C164")]
	private void OnDamageClick()
	{
	}

	[Token(Token = "0x600F1CB")]
	[Address(RVA = "0x134C324", Offset = "0x134C324", VA = "0x134C324")]
	private static int _003COnUIInit_003Em__0(Transform transform1, Transform transform2)
	{
		return default(int);
	}

	[Token(Token = "0x600F1CC")]
	[Address(RVA = "0x134C414", Offset = "0x134C414", VA = "0x134C414")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F1CD")]
	[Address(RVA = "0x134C41C", Offset = "0x134C41C", VA = "0x134C41C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F1CE")]
	[Address(RVA = "0x134C424", Offset = "0x134C424", VA = "0x134C424")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
