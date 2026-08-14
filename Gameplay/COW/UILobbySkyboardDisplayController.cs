using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200213A")]
public class UILobbySkyboardDisplayController : UINavigationController, _Attribute
{
	[Token(Token = "0x400D053")]
	[FieldOffset(Offset = "0x68")]
	private UILobbySkyboardDisplayView m_View;

	[Token(Token = "0x400D054")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelSkyboardDisplay m_Model;

	[Token(Token = "0x400D055")]
	[FieldOffset(Offset = "0x70")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x400D056")]
	[FieldOffset(Offset = "0x74")]
	private uint m_CurrentSkateboardId;

	[Token(Token = "0x400D057")]
	[FieldOffset(Offset = "0x78")]
	private bool isTipsFollowGrid;

	[Token(Token = "0x400D058")]
	[FieldOffset(Offset = "0x0")]
	private static int SKATEBOARDITEMCOUNT;

	[Token(Token = "0x400D059")]
	[FieldOffset(Offset = "0x7C")]
	private float m_SkateboardDisplayItemHeight;

	[Token(Token = "0x400D05A")]
	[FieldOffset(Offset = "0x80")]
	private float m_CellSpacing;

	[Token(Token = "0x400D05B")]
	[FieldOffset(Offset = "0x84")]
	private List<SkyboardDisplayItemData> m_skyboardDisplayList;

	[Token(Token = "0x400D05C")]
	[FieldOffset(Offset = "0x88")]
	private UICommonGuideController m_GuideController;

	[Token(Token = "0x400D05D")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<SkyboardDisplayItemData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600AE6B")]
	[Address(RVA = "0x1CB50AC", Offset = "0x1CB50AC", VA = "0x1CB50AC")]
	public UILobbySkyboardDisplayController()
	{
	}

	[Token(Token = "0x600AE6C")]
	[Address(RVA = "0x1CB5164", Offset = "0x1CB5164", VA = "0x1CB5164")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AE6D")]
	[Address(RVA = "0x1CB5208", Offset = "0x1CB5208", VA = "0x1CB5208", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AE6E")]
	[Address(RVA = "0x1CB591C", Offset = "0x1CB591C", VA = "0x1CB591C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AE6F")]
	[Address(RVA = "0x1CB5B14", Offset = "0x1CB5B14", VA = "0x1CB5B14")]
	private void OnAutoRotateClicked()
	{
	}

	[Token(Token = "0x600AE70")]
	[Address(RVA = "0x1CB6008", Offset = "0x1CB6008", VA = "0x1CB6008", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600AE71")]
	[Address(RVA = "0x1CB6894", Offset = "0x1CB6894", VA = "0x1CB6894", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600AE72")]
	[Address(RVA = "0x1CB6A74", Offset = "0x1CB6A74", VA = "0x1CB6A74")]
	private void OnGotoShopButtonClick()
	{
	}

	[Token(Token = "0x600AE73")]
	[Address(RVA = "0x1CB6C7C", Offset = "0x1CB6C7C", VA = "0x1CB6C7C")]
	private void OnRemoveButtonClicked()
	{
	}

	[Token(Token = "0x600AE74")]
	[Address(RVA = "0x1CB63F0", Offset = "0x1CB63F0", VA = "0x1CB63F0")]
	private void SetSkateboardShow()
	{
	}

	[Token(Token = "0x600AE75")]
	[Address(RVA = "0x1CB6F08", Offset = "0x1CB6F08", VA = "0x1CB6F08")]
	private void OnClickCloseButton()
	{
	}

	[Token(Token = "0x600AE76")]
	[Address(RVA = "0x1CB7014", Offset = "0x1CB7014", VA = "0x1CB7014")]
	private void OnClickHelpButton()
	{
	}

	[Token(Token = "0x600AE77")]
	[Address(RVA = "0x1CB725C", Offset = "0x1CB725C", VA = "0x1CB725C")]
	private void ChangeSkyboard(object[] data)
	{
	}

	[Token(Token = "0x600AE78")]
	[Address(RVA = "0x1CB77C8", Offset = "0x1CB77C8", VA = "0x1CB77C8")]
	private void OnCameraMoveEnd(object[] data)
	{
	}

	[Token(Token = "0x600AE79")]
	[Address(RVA = "0x1CB7B6C", Offset = "0x1CB7B6C", VA = "0x1CB7B6C", Slot = "42")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600AE7A")]
	[Address(RVA = "0x1CB7C9C", Offset = "0x1CB7C9C", VA = "0x1CB7C9C", Slot = "43")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600AE7C")]
	[Address(RVA = "0x1CB7D80", Offset = "0x1CB7D80", VA = "0x1CB7D80")]
	private static int _003CSetSkateboardShow_003Em__0(SkyboardDisplayItemData a, SkyboardDisplayItemData b)
	{
		return default(int);
	}

	[Token(Token = "0x600AE7D")]
	[Address(RVA = "0x1CB7DB4", Offset = "0x1CB7DB4", VA = "0x1CB7DB4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AE7E")]
	[Address(RVA = "0x1CB7DBC", Offset = "0x1CB7DBC", VA = "0x1CB7DBC")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600AE7F")]
	[Address(RVA = "0x1CB7DC4", Offset = "0x1CB7DC4", VA = "0x1CB7DC4")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600AE80")]
	[Address(RVA = "0x1CB7DCC", Offset = "0x1CB7DCC", VA = "0x1CB7DCC")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
