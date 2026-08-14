using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002BC8")]
public class UIUseUpgradeCardController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x4010B8E")]
	[FieldOffset(Offset = "0x48")]
	private UIUseUpgradeCardWindowView m_View;

	[Token(Token = "0x4010B8F")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelAvatarProfile m_ProfileModel;

	[Token(Token = "0x4010B90")]
	[FieldOffset(Offset = "0x50")]
	private int careAvatarId;

	[Token(Token = "0x4010B91")]
	[FieldOffset(Offset = "0x54")]
	private int levelCardId;

	[Token(Token = "0x4010B92")]
	[FieldOffset(Offset = "0x58")]
	private int selectedIndex;

	[Token(Token = "0x4010B93")]
	private const float ITEM_WIDTH = 140f;

	[Token(Token = "0x4010B94")]
	private const float ITEM_HEIGHT = 140f;

	[Token(Token = "0x4010B95")]
	[FieldOffset(Offset = "0x5C")]
	private BaseItemView[] levelUpRewardList;

	[Token(Token = "0x4010B96")]
	[FieldOffset(Offset = "0x60")]
	private List<UIAvatarLevelCardItemController> m_LevelCards;

	[Token(Token = "0x4010B97")]
	[FieldOffset(Offset = "0x64")]
	private Color NORMAL_COLOR;

	[Token(Token = "0x4010B98")]
	[FieldOffset(Offset = "0x74")]
	private Color DISABLE_COLOR;

	[Token(Token = "0x4010B99")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 DESC_OFFSET_POS;

	[Token(Token = "0x4010B9A")]
	[FieldOffset(Offset = "0x90")]
	private List<AvatarProfile> m_ShowAvatarList;

	[Token(Token = "0x4010B9B")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<AvatarProfile> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60121B8")]
	[Address(RVA = "0xF571C8", Offset = "0xF571C8", VA = "0xF571C8")]
	public UIUseUpgradeCardController()
	{
	}

	[Token(Token = "0x60121B9")]
	[Address(RVA = "0xF5730C", Offset = "0xF5730C", VA = "0xF5730C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60121BA")]
	[Address(RVA = "0xF573B4", Offset = "0xF573B4", VA = "0xF573B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60121BB")]
	[Address(RVA = "0xF57960", Offset = "0xF57960", VA = "0xF57960", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60121BC")]
	[Address(RVA = "0xF57C30", Offset = "0xF57C30", VA = "0xF57C30", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x60121BD")]
	[Address(RVA = "0xF57C9C", Offset = "0xF57C9C", VA = "0xF57C9C")]
	private void Refresh()
	{
	}

	[Token(Token = "0x60121BE")]
	[Address(RVA = "0xF57FA4", Offset = "0xF57FA4", VA = "0xF57FA4")]
	public void InitInventoryView(int _cardId)
	{
	}

	[Token(Token = "0x60121BF")]
	[Address(RVA = "0xF59238", Offset = "0xF59238", VA = "0xF59238")]
	public void InitAvatarNavigationView(int _avatarId, int selected)
	{
	}

	[Token(Token = "0x60121C0")]
	[Address(RVA = "0xF59B24", Offset = "0xF59B24", VA = "0xF59B24")]
	private void OnSelectAvatarheadItem(object[] data)
	{
	}

	[Token(Token = "0x60121C1")]
	[Address(RVA = "0xF59DC4", Offset = "0xF59DC4", VA = "0xF59DC4")]
	private void OnSelectAvatarLevelCardItem(object[] data)
	{
	}

	[Token(Token = "0x60121C2")]
	[Address(RVA = "0xF58338", Offset = "0xF58338", VA = "0xF58338")]
	private void RefreshDesc()
	{
	}

	[Token(Token = "0x60121C3")]
	[Address(RVA = "0xF58CB4", Offset = "0xF58CB4", VA = "0xF58CB4")]
	private void RefreshAward()
	{
	}

	[Token(Token = "0x60121C4")]
	[Address(RVA = "0xF59F9C", Offset = "0xF59F9C", VA = "0xF59F9C")]
	private void RefreshUseState(bool _useable, bool _hasCard)
	{
	}

	[Token(Token = "0x60121C5")]
	[Address(RVA = "0xF5A1F4", Offset = "0xF5A1F4", VA = "0xF5A1F4")]
	private void OnUseCardClick()
	{
	}

	[Token(Token = "0x60121C6")]
	[Address(RVA = "0xF5A550", Offset = "0xF5A550", VA = "0xF5A550")]
	private void OnGotoClick()
	{
	}

	[Token(Token = "0x60121C7")]
	[Address(RVA = "0xF5A844", Offset = "0xF5A844", VA = "0xF5A844", Slot = "46")]
	private UIEasyListItemController GCommon_002EIEasyList_002EOpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60121C8")]
	[Address(RVA = "0xF5A93C", Offset = "0xF5A93C", VA = "0xF5A93C", Slot = "47")]
	private void GCommon_002EIEasyList_002ECloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60121C9")]
	[Address(RVA = "0xF5A9B8", Offset = "0xF5A9B8", VA = "0xF5A9B8")]
	private bool _003CInitInventoryView_003Em__0(AvatarProfile a)
	{
		return default(bool);
	}

	[Token(Token = "0x60121CA")]
	[Address(RVA = "0xF5AA4C", Offset = "0xF5AA4C", VA = "0xF5AA4C")]
	private static int _003CInitInventoryView_003Em__1(AvatarProfile ap1, AvatarProfile ap2)
	{
		return default(int);
	}

	[Token(Token = "0x60121CB")]
	[Address(RVA = "0xF5AADC", Offset = "0xF5AADC", VA = "0xF5AADC")]
	private void _003COnUseCardClick_003Em__2()
	{
	}

	[Token(Token = "0x60121CC")]
	[Address(RVA = "0xF5AB38", Offset = "0xF5AB38", VA = "0xF5AB38")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60121CD")]
	[Address(RVA = "0xF5AB40", Offset = "0xF5AB40", VA = "0xF5AB40")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60121CE")]
	[Address(RVA = "0xF5AB48", Offset = "0xF5AB48", VA = "0xF5AB48")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
