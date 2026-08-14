using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002136")]
public class UILobbyIceWallDisplayController : UINavigationController, _Attribute
{
	[Token(Token = "0x400D03E")]
	[FieldOffset(Offset = "0x68")]
	private UILobbyIceWallDisplayView m_View;

	[Token(Token = "0x400D03F")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelIceWallDisplay m_Model;

	[Token(Token = "0x400D040")]
	[FieldOffset(Offset = "0x70")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x400D041")]
	[FieldOffset(Offset = "0x74")]
	private uint m_CurrentIceWallID;

	[Token(Token = "0x400D042")]
	[FieldOffset(Offset = "0x78")]
	private List<WeaponItemData> m_IceWallList;

	[Token(Token = "0x400D043")]
	[FieldOffset(Offset = "0x7C")]
	private UICommonGuideController m_guideController;

	[Token(Token = "0x400D044")]
	private const uint icewalltype = 1201u;

	[Token(Token = "0x400D045")]
	[FieldOffset(Offset = "0x80")]
	public bool CanRefresh;

	[Token(Token = "0x400D046")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<WeaponItemData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600AE3D")]
	[Address(RVA = "0xDB4654", Offset = "0xDB4654", VA = "0xDB4654")]
	public UILobbyIceWallDisplayController()
	{
	}

	[Token(Token = "0x600AE3E")]
	[Address(RVA = "0xDB470C", Offset = "0xDB470C", VA = "0xDB470C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AE3F")]
	[Address(RVA = "0xDB47B0", Offset = "0xDB47B0", VA = "0xDB47B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AE40")]
	[Address(RVA = "0xDB4EC4", Offset = "0xDB4EC4", VA = "0xDB4EC4")]
	private void OnAutoRotateClicked()
	{
	}

	[Token(Token = "0x600AE41")]
	[Address(RVA = "0xDB53B8", Offset = "0xDB53B8", VA = "0xDB53B8", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600AE42")]
	[Address(RVA = "0xDB6384", Offset = "0xDB6384", VA = "0xDB6384", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600AE43")]
	[Address(RVA = "0xDB65D4", Offset = "0xDB65D4", VA = "0xDB65D4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AE44")]
	[Address(RVA = "0xDB67CC", Offset = "0xDB67CC", VA = "0xDB67CC", Slot = "42")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600AE45")]
	[Address(RVA = "0xDB68FC", Offset = "0xDB68FC", VA = "0xDB68FC", Slot = "43")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600AE46")]
	[Address(RVA = "0xDB6978", Offset = "0xDB6978", VA = "0xDB6978")]
	private void OnGotoShopButtonClick()
	{
	}

	[Token(Token = "0x600AE47")]
	[Address(RVA = "0xDB6B54", Offset = "0xDB6B54", VA = "0xDB6B54")]
	private void OnRemoveButtonClicked()
	{
	}

	[Token(Token = "0x600AE48")]
	[Address(RVA = "0xDB58AC", Offset = "0xDB58AC", VA = "0xDB58AC")]
	private void SetIceWallShow(uint id)
	{
	}

	[Token(Token = "0x600AE49")]
	[Address(RVA = "0xDB6DDC", Offset = "0xDB6DDC", VA = "0xDB6DDC")]
	private void OnClickCloseButton()
	{
	}

	[Token(Token = "0x600AE4A")]
	[Address(RVA = "0xDB6EE8", Offset = "0xDB6EE8", VA = "0xDB6EE8")]
	private void OnClickHelpButton()
	{
	}

	[Token(Token = "0x600AE4B")]
	[Address(RVA = "0xDB7130", Offset = "0xDB7130", VA = "0xDB7130")]
	private void ChangIceWall(object[] data)
	{
	}

	[Token(Token = "0x600AE4C")]
	[Address(RVA = "0xDB769C", Offset = "0xDB769C", VA = "0xDB769C")]
	private void OnCameraMoveEnd(object[] data)
	{
	}

	[Token(Token = "0x600AE4D")]
	[Address(RVA = "0xDB77E0", Offset = "0xDB77E0", VA = "0xDB77E0")]
	private static int _003CSetIceWallShow_003Em__0(WeaponItemData a, WeaponItemData b)
	{
		return default(int);
	}

	[Token(Token = "0x600AE4E")]
	[Address(RVA = "0xDB7814", Offset = "0xDB7814", VA = "0xDB7814")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AE4F")]
	[Address(RVA = "0xDB781C", Offset = "0xDB781C", VA = "0xDB781C")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600AE50")]
	[Address(RVA = "0xDB7824", Offset = "0xDB7824", VA = "0xDB7824")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600AE51")]
	[Address(RVA = "0xDB782C", Offset = "0xDB782C", VA = "0xDB782C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
