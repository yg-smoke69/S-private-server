using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028E8")]
public class UIInvUseUpgradeCardController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400FB8F")]
	[FieldOffset(Offset = "0x48")]
	private UIInvUseUpgradeCardWindowView m_View;

	[Token(Token = "0x400FB90")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelAvatarProfile m_ProfileModel;

	[Token(Token = "0x400FB91")]
	[FieldOffset(Offset = "0x50")]
	private int careAvatarId;

	[Token(Token = "0x400FB92")]
	[FieldOffset(Offset = "0x54")]
	private int levelCardId;

	[Token(Token = "0x400FB93")]
	private const float ITEM_WIDTH = 140f;

	[Token(Token = "0x400FB94")]
	private const float ITEM_HEIGHT = 140f;

	[Token(Token = "0x400FB95")]
	[FieldOffset(Offset = "0x58")]
	private BaseItemView[] levelUpRewardList;

	[Token(Token = "0x400FB96")]
	[FieldOffset(Offset = "0x5C")]
	private List<UIAvatarLevelCardItemController> m_LevelCards;

	[Token(Token = "0x400FB97")]
	[FieldOffset(Offset = "0x60")]
	private Color NORMAL_COLOR;

	[Token(Token = "0x400FB98")]
	[FieldOffset(Offset = "0x70")]
	private Color DISABLE_COLOR;

	[Token(Token = "0x400FB99")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 NO_REWARD_DESC_OFFSET_POS;

	[Token(Token = "0x400FB9A")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 REWARD_DESC_OFFSET_POS;

	[Token(Token = "0x400FB9B")]
	[FieldOffset(Offset = "0x98")]
	private List<AvatarProfile> m_ShowAvatarList;

	[Token(Token = "0x400FB9C")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<AvatarProfile> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6010286")]
	[Address(RVA = "0x1281FC8", Offset = "0x1281FC8", VA = "0x1281FC8")]
	public UIInvUseUpgradeCardController()
	{
	}

	[Token(Token = "0x6010287")]
	[Address(RVA = "0x128213C", Offset = "0x128213C", VA = "0x128213C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010288")]
	[Address(RVA = "0x12821E4", Offset = "0x12821E4", VA = "0x12821E4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010289")]
	[Address(RVA = "0x1282804", Offset = "0x1282804", VA = "0x1282804", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601028A")]
	[Address(RVA = "0x1282AD4", Offset = "0x1282AD4", VA = "0x1282AD4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x601028B")]
	[Address(RVA = "0x1282B90", Offset = "0x1282B90", VA = "0x1282B90")]
	public void InitInventoryView(List<AvatarProfile> avatarList, int _cardId)
	{
	}

	[Token(Token = "0x601028C")]
	[Address(RVA = "0x1283D10", Offset = "0x1283D10", VA = "0x1283D10")]
	private void OnSelectAvatarheadItem(object[] data)
	{
	}

	[Token(Token = "0x601028D")]
	[Address(RVA = "0x1283FB0", Offset = "0x1283FB0", VA = "0x1283FB0")]
	private void OnSelectAvatarLevelCardItem(object[] data)
	{
	}

	[Token(Token = "0x601028E")]
	[Address(RVA = "0x1282E34", Offset = "0x1282E34", VA = "0x1282E34")]
	private void RefreshDesc()
	{
	}

	[Token(Token = "0x601028F")]
	[Address(RVA = "0x12837B0", Offset = "0x12837B0", VA = "0x12837B0")]
	private void RefreshAward()
	{
	}

	[Token(Token = "0x6010290")]
	[Address(RVA = "0x12841E4", Offset = "0x12841E4", VA = "0x12841E4")]
	private void RefreshUseState(bool _useable, bool _hasCard)
	{
	}

	[Token(Token = "0x6010291")]
	[Address(RVA = "0x128443C", Offset = "0x128443C", VA = "0x128443C")]
	private void OnUseCardClick()
	{
	}

	[Token(Token = "0x6010292")]
	[Address(RVA = "0x12847A4", Offset = "0x12847A4", VA = "0x12847A4")]
	private void OnAvatarListNextBtnClick()
	{
	}

	[Token(Token = "0x6010293")]
	[Address(RVA = "0x128499C", Offset = "0x128499C", VA = "0x128499C")]
	private void OnAvatarListPreBtnClick()
	{
	}

	[Token(Token = "0x6010294")]
	[Address(RVA = "0x1284B38", Offset = "0x1284B38", VA = "0x1284B38", Slot = "46")]
	private UIEasyListItemController GCommon_002EIEasyList_002EOpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010295")]
	[Address(RVA = "0x1284C30", Offset = "0x1284C30", VA = "0x1284C30", Slot = "47")]
	private void GCommon_002EIEasyList_002ECloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010296")]
	[Address(RVA = "0x1284CAC", Offset = "0x1284CAC", VA = "0x1284CAC")]
	private static int _003CInitInventoryView_003Em__0(AvatarProfile ap1, AvatarProfile ap2)
	{
		return default(int);
	}

	[Token(Token = "0x6010297")]
	[Address(RVA = "0x1284D3C", Offset = "0x1284D3C", VA = "0x1284D3C")]
	private void _003COnUseCardClick_003Em__1()
	{
	}

	[Token(Token = "0x6010298")]
	[Address(RVA = "0x1284D98", Offset = "0x1284D98", VA = "0x1284D98")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010299")]
	[Address(RVA = "0x1284DA0", Offset = "0x1284DA0", VA = "0x1284DA0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x601029A")]
	[Address(RVA = "0x1284DA8", Offset = "0x1284DA8", VA = "0x1284DA8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
