using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026C5")]
public class UIHeroicMarkDetailWndController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x400EF3E")]
	[FieldOffset(Offset = "0x48")]
	private UIHeroicMarkDetailWndView m_View;

	[Token(Token = "0x400EF3F")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelProfile m_Model;

	[Token(Token = "0x400EF40")]
	[FieldOffset(Offset = "0x50")]
	private string m_Tab;

	[Token(Token = "0x400EF41")]
	[FieldOffset(Offset = "0x58")]
	private ulong m_CacheAccountID;

	[Token(Token = "0x400EF42")]
	[FieldOffset(Offset = "0x60")]
	private bool isDataReady;

	[Token(Token = "0x400EF43")]
	[FieldOffset(Offset = "0x61")]
	private bool hasInitInfo;

	[Token(Token = "0x400EF44")]
	[FieldOffset(Offset = "0x62")]
	private bool m_IsUserSelf;

	[Token(Token = "0x400EF45")]
	[FieldOffset(Offset = "0x64")]
	private List<UIHeroicMarkItemCtrl> m_MarkItems;

	[Token(Token = "0x400EF46")]
	[FieldOffset(Offset = "0x68")]
	private uint cellCntPerLine;

	[Token(Token = "0x600EA3B")]
	[Address(RVA = "0x162A17C", Offset = "0x162A17C", VA = "0x162A17C")]
	public UIHeroicMarkDetailWndController()
	{
	}

	[Token(Token = "0x600EA3C")]
	[Address(RVA = "0x162A22C", Offset = "0x162A22C", VA = "0x162A22C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EA3D")]
	[Address(RVA = "0x162A854", Offset = "0x162A854", VA = "0x162A854", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EA3E")]
	[Address(RVA = "0x162A9AC", Offset = "0x162A9AC", VA = "0x162A9AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EA3F")]
	[Address(RVA = "0x162AA50", Offset = "0x162AA50", VA = "0x162AA50")]
	private void OnMoreDetailClick()
	{
	}

	[Token(Token = "0x600EA40")]
	[Address(RVA = "0x162AAA4", Offset = "0x162AAA4", VA = "0x162AAA4")]
	private void OnShareBtnClick()
	{
	}

	[Token(Token = "0x600EA41")]
	[Address(RVA = "0x162ACD0", Offset = "0x162ACD0", VA = "0x162ACD0", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600EA42")]
	[Address(RVA = "0x162AD8C", Offset = "0x162AD8C", VA = "0x162AD8C", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600EA43")]
	[Address(RVA = "0x162AECC", Offset = "0x162AECC", VA = "0x162AECC")]
	private void OnSelectRule(object[] data)
	{
	}

	[Token(Token = "0x600EA44")]
	[Address(RVA = "0x162B984", Offset = "0x162B984", VA = "0x162B984")]
	private void GotoTab()
	{
	}

	[Token(Token = "0x600EA45")]
	[Address(RVA = "0x162B07C", Offset = "0x162B07C", VA = "0x162B07C")]
	private void RefreshInfo()
	{
	}

	[Token(Token = "0x600EA46")]
	[Address(RVA = "0x162A634", Offset = "0x162A634", VA = "0x162A634")]
	private void CreateTab()
	{
	}

	[Token(Token = "0x600EA47")]
	[Address(RVA = "0x162C158", Offset = "0x162C158", VA = "0x162C158")]
	public void Init(ulong account_id, string tab)
	{
	}

	[Token(Token = "0x600EA48")]
	[Address(RVA = "0x162BF78", Offset = "0x162BF78", VA = "0x162BF78")]
	private void UpdateDesc(bool isBR)
	{
	}

	[Token(Token = "0x600EA49")]
	[Address(RVA = "0x162C390", Offset = "0x162C390", VA = "0x162C390", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600EA4A")]
	[Address(RVA = "0x162C488", Offset = "0x162C488", VA = "0x162C488", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600EA4B")]
	[Address(RVA = "0x162C504", Offset = "0x162C504", VA = "0x162C504", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600EA4C")]
	[Address(RVA = "0x162C5C4", Offset = "0x162C5C4", VA = "0x162C5C4", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600EA4D")]
	[Address(RVA = "0x162C658", Offset = "0x162C658", VA = "0x162C658")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EA4E")]
	[Address(RVA = "0x162C660", Offset = "0x162C660", VA = "0x162C660")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600EA4F")]
	[Address(RVA = "0x162C668", Offset = "0x162C668", VA = "0x162C668")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600EA50")]
	[Address(RVA = "0x162C670", Offset = "0x162C670", VA = "0x162C670")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
