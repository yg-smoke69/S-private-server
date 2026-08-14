using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002859")]
internal class UIHudSpeedRoyaleTeammatesInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x400F8DD")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSpeedRoyaleTeammatesInfoView m_View;

	[Token(Token = "0x400F8DE")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, UIHudSpeedRoyaleTeammateGroup> m_VehicleGroups;

	[Token(Token = "0x400F8DF")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<ulong, UIHudSpeedRoyaleTeammateItem> m_TeammatesWithAccountID;

	[Token(Token = "0x400F8E0")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<uint, uint> m_PlayerIDToVehicleID;

	[Token(Token = "0x400F8E1")]
	[FieldOffset(Offset = "0x38")]
	private UIModelMatch m_MatchModel;

	[Token(Token = "0x600FC56")]
	[Address(RVA = "0x1FE0784", Offset = "0x1FE0784", VA = "0x1FE0784")]
	public UIHudSpeedRoyaleTeammatesInfoController()
	{
	}

	[Token(Token = "0x600FC57")]
	[Address(RVA = "0x1FE0808", Offset = "0x1FE0808", VA = "0x1FE0808")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FC58")]
	[Address(RVA = "0x1FE08AC", Offset = "0x1FE08AC", VA = "0x1FE08AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FC59")]
	[Address(RVA = "0x1FE0B84", Offset = "0x1FE0B84", VA = "0x1FE0B84", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FC5A")]
	[Address(RVA = "0x1FE10C8", Offset = "0x1FE10C8", VA = "0x1FE10C8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FC5B")]
	[Address(RVA = "0x1FE1630", Offset = "0x1FE1630", VA = "0x1FE1630")]
	private UIHudSpeedRoyaleTeammateItem AddTeammateItem(IHAAMHPPLMG playerID)
	{
		return null;
	}

	[Token(Token = "0x600FC5C")]
	[Address(RVA = "0x1FE1CCC", Offset = "0x1FE1CCC", VA = "0x1FE1CCC", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600FC5D")]
	[Address(RVA = "0x1FE239C", Offset = "0x1FE239C", VA = "0x1FE239C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600FC5E")]
	[Address(RVA = "0x1FE2430", Offset = "0x1FE2430", VA = "0x1FE2430")]
	private UIHudSpeedRoyaleTeammateItem GetTeammateItem(IHAAMHPPLMG pId)
	{
		return null;
	}

	[Token(Token = "0x600FC5F")]
	[Address(RVA = "0x1FE26C0", Offset = "0x1FE26C0", VA = "0x1FE26C0")]
	private void OnPlayerHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600FC60")]
	[Address(RVA = "0x1FE2914", Offset = "0x1FE2914", VA = "0x1FE2914")]
	private void OnVehicleHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600FC61")]
	[Address(RVA = "0x1FE2AFC", Offset = "0x1FE2AFC", VA = "0x1FE2AFC")]
	private void OnVehicleDead(object[] data)
	{
	}

	[Token(Token = "0x600FC62")]
	[Address(RVA = "0x1FE2D30", Offset = "0x1FE2D30", VA = "0x1FE2D30")]
	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	[Token(Token = "0x600FC63")]
	[Address(RVA = "0x1FE3028", Offset = "0x1FE3028", VA = "0x1FE3028")]
	private void OnPlayerGetOffVehicle(object[] data)
	{
	}

	[Token(Token = "0x600FC64")]
	[Address(RVA = "0x1FE3230", Offset = "0x1FE3230", VA = "0x1FE3230")]
	private void OnRemoveMapMark(object[] data)
	{
	}

	[Token(Token = "0x600FC65")]
	[Address(RVA = "0x1FE33A0", Offset = "0x1FE33A0", VA = "0x1FE33A0")]
	private void OnUpdateMapMark(object[] data)
	{
	}

	[Token(Token = "0x600FC66")]
	[Address(RVA = "0x1FE3510", Offset = "0x1FE3510", VA = "0x1FE3510")]
	private void OnTeammateQuit(object[] data)
	{
	}

	[Token(Token = "0x600FC67")]
	[Address(RVA = "0x1FE36C4", Offset = "0x1FE36C4", VA = "0x1FE36C4")]
	private void OnTeamateVadStateChange(object[] data)
	{
	}

	[Token(Token = "0x600FC68")]
	[Address(RVA = "0x1FE38F8", Offset = "0x1FE38F8", VA = "0x1FE38F8")]
	private void OnTeamateStateChange(object[] data)
	{
	}

	[Token(Token = "0x600FC69")]
	[Address(RVA = "0x1FE3B18", Offset = "0x1FE3B18", VA = "0x1FE3B18")]
	private void OnTeamInfoGet(object[] data)
	{
	}

	[Token(Token = "0x600FC6A")]
	[Address(RVA = "0x1FE1E5C", Offset = "0x1FE1E5C", VA = "0x1FE1E5C")]
	private bool CheckToShow(IHAAMHPPLMG pId)
	{
		return default(bool);
	}

	[Token(Token = "0x600FC6B")]
	[Address(RVA = "0x1FE3F74", Offset = "0x1FE3F74", VA = "0x1FE3F74")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FC6C")]
	[Address(RVA = "0x1FE3F7C", Offset = "0x1FE3F7C", VA = "0x1FE3F7C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600FC6D")]
	[Address(RVA = "0x1FE3F84", Offset = "0x1FE3F84", VA = "0x1FE3F84")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
