using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020C9")]
public class UIActivitySignInPopUpController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400CD44")]
	[FieldOffset(Offset = "0x48")]
	private UIActivitySignInPopUpView m_View;

	[Token(Token = "0x400CD45")]
	private const int MaxItemPerLine = 6;

	[Token(Token = "0x400CD46")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIAnnouncementRewardItemController> m_ItemList;

	[Token(Token = "0x400CD47")]
	[FieldOffset(Offset = "0x50")]
	private int m_lastSignedIndex;

	[Token(Token = "0x400CD48")]
	[FieldOffset(Offset = "0x54")]
	private Transform[] m_ItemContainerList;

	[Token(Token = "0x600A964")]
	[Address(RVA = "0x1F1FD98", Offset = "0x1F1FD98", VA = "0x1F1FD98")]
	public UIActivitySignInPopUpController()
	{
	}

	[Token(Token = "0x600A965")]
	[Address(RVA = "0x1F1FE2C", Offset = "0x1F1FE2C", VA = "0x1F1FE2C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A966")]
	[Address(RVA = "0x1F1FED0", Offset = "0x1F1FED0", VA = "0x1F1FED0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A967")]
	[Address(RVA = "0x1F205D0", Offset = "0x1F205D0", VA = "0x1F205D0", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A968")]
	[Address(RVA = "0x1F20734", Offset = "0x1F20734", VA = "0x1F20734", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A969")]
	[Address(RVA = "0x1F20864", Offset = "0x1F20864", VA = "0x1F20864")]
	private void ClearItem()
	{
	}

	[Token(Token = "0x600A96A")]
	[Address(RVA = "0x1F20A34", Offset = "0x1F20A34", VA = "0x1F20A34")]
	private void RefreshList()
	{
	}

	[Token(Token = "0x600A96B")]
	[Address(RVA = "0x1F20DC0", Offset = "0x1F20DC0", VA = "0x1F20DC0")]
	private void RepositionItem()
	{
	}

	[Token(Token = "0x600A96C")]
	[Address(RVA = "0x1F21028", Offset = "0x1F21028", VA = "0x1F21028")]
	private void ScrollToLastSignedLine()
	{
	}

	[Token(Token = "0x600A96D")]
	[Address(RVA = "0x1F214A4", Offset = "0x1F214A4", VA = "0x1F214A4")]
	private void RefreshSignDesc()
	{
	}

	[Token(Token = "0x600A96E")]
	[Address(RVA = "0x1F218FC", Offset = "0x1F218FC", VA = "0x1F218FC", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A96F")]
	[Address(RVA = "0x1F219C4", Offset = "0x1F219C4", VA = "0x1F219C4")]
	private void AutoSignIn()
	{
	}

	[Token(Token = "0x600A970")]
	[Address(RVA = "0x1F21D00", Offset = "0x1F21D00", VA = "0x1F21D00", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A971")]
	[Address(RVA = "0x1F21D94", Offset = "0x1F21D94", VA = "0x1F21D94")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A972")]
	[Address(RVA = "0x1F21D9C", Offset = "0x1F21D9C", VA = "0x1F21D9C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A973")]
	[Address(RVA = "0x1F21DA4", Offset = "0x1F21DA4", VA = "0x1F21DA4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
