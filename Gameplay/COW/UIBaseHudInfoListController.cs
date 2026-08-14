using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x20024F5")]
internal class UIBaseHudInfoListController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x400E55B")]
	protected const uint SINGLE_PLAYER_CELL_HEIGHT = 80u;

	[Token(Token = "0x400E55C")]
	protected const uint DUO_PLAYER_CELL_HEIGHT = 150u;

	[Token(Token = "0x400E55D")]
	protected const uint TRIPLE_PLAYER_CELL_HEIGHT = 210u;

	[Token(Token = "0x400E55E")]
	protected const uint QUAD_PLAYER_CELL_HEIGHT = 270u;

	[Token(Token = "0x400E55F")]
	protected const uint PENTA_PLAYER_CELL_HEIGHT = 330u;

	[Token(Token = "0x400E560")]
	protected const uint SIX_PLAYER_CELL_HEIGHT = 405u;

	[Token(Token = "0x400E561")]
	protected const int SINGLE_PLAYER_ITEM_HEIGHT = 78;

	[Token(Token = "0x400E562")]
	protected const int MULTI_PLAYER_ITEM_HEIGHT = 58;

	[Token(Token = "0x400E563")]
	[FieldOffset(Offset = "0x28")]
	protected UIBaseHudInfoListView m_BaseView;

	[Token(Token = "0x400E564")]
	[FieldOffset(Offset = "0x2C")]
	protected UIModelSpectator m_Model;

	[Token(Token = "0x400E565")]
	[FieldOffset(Offset = "0x30")]
	protected List<UISPHudAirdropItemController> m_AirdropList;

	[Token(Token = "0x400E566")]
	[FieldOffset(Offset = "0x34")]
	protected HHDIPHFOBFO m_CurrentGroupMode;

	[Token(Token = "0x400E567")]
	[FieldOffset(Offset = "0x38")]
	protected Vector3 m_PlayerGridTransform;

	[Token(Token = "0x400E568")]
	[FieldOffset(Offset = "0x44")]
	protected float CELL_WIDTH;

	[Token(Token = "0x400E569")]
	[FieldOffset(Offset = "0x48")]
	protected float m_CellHeight;

	[Token(Token = "0x400E56A")]
	[FieldOffset(Offset = "0x4C")]
	protected float m_PlayerPanelHeight;

	[Token(Token = "0x400E56B")]
	[FieldOffset(Offset = "0x50")]
	protected Vector3 m_MoveRelative;

	[Token(Token = "0x400E56C")]
	[FieldOffset(Offset = "0x5C")]
	protected UIScrollView m_PlayerScrollView;

	[Token(Token = "0x400E56D")]
	[FieldOffset(Offset = "0x60")]
	private bool m_ShowInfoList;

	[Token(Token = "0x600D56A")]
	[Address(RVA = "0x1409800", Offset = "0x1409800", VA = "0x1409800")]
	public UIBaseHudInfoListController()
	{
	}

	[Token(Token = "0x600D56B")]
	[Address(RVA = "0x1409900", Offset = "0x1409900", VA = "0x1409900", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D56C")]
	[Address(RVA = "0x140A548", Offset = "0x140A548", VA = "0x140A548")]
	protected void OnHotkeyInfoTabChanged(object[] data)
	{
	}

	[Token(Token = "0x600D56D")]
	[Address(RVA = "0x140A980", Offset = "0x140A980", VA = "0x140A980")]
	protected void AutoscrollToSelectedPlayer(object[] data)
	{
	}

	[Token(Token = "0x600D56E")]
	[Address(RVA = "0x140ACF4", Offset = "0x140ACF4", VA = "0x140ACF4")]
	protected void RefreshAirdropSelected(object[] data)
	{
	}

	[Token(Token = "0x600D56F")]
	[Address(RVA = "0x140AE78", Offset = "0x140AE78", VA = "0x140AE78", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D570")]
	[Address(RVA = "0x140B0A0", Offset = "0x140B0A0", VA = "0x140B0A0")]
	protected void OnCloseClick()
	{
	}

	[Token(Token = "0x600D571")]
	[Address(RVA = "0x140A758", Offset = "0x140A758", VA = "0x140A758")]
	protected void OnPlayerTabClick()
	{
	}

	[Token(Token = "0x600D572")]
	[Address(RVA = "0x140A88C", Offset = "0x140A88C", VA = "0x140A88C")]
	protected void OnAirdropTabClick()
	{
	}

	[Token(Token = "0x600D573")]
	[Address(RVA = "0x140A098", Offset = "0x140A098", VA = "0x140A098")]
	protected void SetPlayerGridParam()
	{
	}

	[Token(Token = "0x600D574")]
	[Address(RVA = "0x140B26C", Offset = "0x140B26C", VA = "0x140B26C")]
	protected void RefreshPlayerList()
	{
	}

	[Token(Token = "0x600D575")]
	[Address(RVA = "0x140B3A4", Offset = "0x140B3A4", VA = "0x140B3A4")]
	protected void RefreshAirdropList()
	{
	}

	[Token(Token = "0x600D576")]
	[Address(RVA = "0x140B8B0", Offset = "0x140B8B0", VA = "0x140B8B0", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D577")]
	[Address(RVA = "0x140B9B0", Offset = "0x140B9B0", VA = "0x140B9B0", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D578")]
	[Address(RVA = "0x140BA44", Offset = "0x140BA44", VA = "0x140BA44", Slot = "33")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D579")]
	[Address(RVA = "0x140BB58", Offset = "0x140BB58", VA = "0x140BB58", Slot = "34")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D57A")]
	[Address(RVA = "0x140A358", Offset = "0x140A358", VA = "0x140A358")]
	protected void ShowHudInfoList(bool value)
	{
	}

	[Token(Token = "0x600D57B")]
	[Address(RVA = "0x140BBD4", Offset = "0x140BBD4", VA = "0x140BBD4")]
	private void OnShowFinished()
	{
	}

	[Token(Token = "0x600D57C")]
	[Address(RVA = "0x140BD7C", Offset = "0x140BD7C", VA = "0x140BD7C")]
	private void OnGlobalEventOpen(object[] data)
	{
	}

	[Token(Token = "0x600D57D")]
	[Address(RVA = "0x140BE84", Offset = "0x140BE84", VA = "0x140BE84")]
	private void OnPollEntryOpen(object[] data)
	{
	}

	[Token(Token = "0x600D57E")]
	[Address(RVA = "0x140BEF8", Offset = "0x140BEF8", VA = "0x140BEF8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D57F")]
	[Address(RVA = "0x140BF00", Offset = "0x140BF00", VA = "0x140BF00")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
