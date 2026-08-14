using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A97")]
public class UIProfileDocumentRulePopWndController : UIPopupWindowController
{
	[Token(Token = "0x40105C3")]
	[FieldOffset(Offset = "0x48")]
	private List<UILobbyDotController> m_DotCtrls;

	[Token(Token = "0x40105C4")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIProfileDocumentRuleItemController> m_Items;

	[Token(Token = "0x40105C5")]
	[FieldOffset(Offset = "0x50")]
	private UIProfileDocumentRulePopWndView m_View;

	[Token(Token = "0x40105C6")]
	[FieldOffset(Offset = "0x54")]
	private UICenterOnChild m_wrapCenter;

	[Token(Token = "0x40105C7")]
	[FieldOffset(Offset = "0x58")]
	private UIDragScrollView m_Drag;

	[Token(Token = "0x40105C8")]
	[FieldOffset(Offset = "0x5C")]
	private int m_LastSelectedMapIndex;

	[Token(Token = "0x6011647")]
	[Address(RVA = "0x16D42F8", Offset = "0x16D42F8", VA = "0x16D42F8")]
	public UIProfileDocumentRulePopWndController()
	{
	}

	[Token(Token = "0x6011648")]
	[Address(RVA = "0x16D43C0", Offset = "0x16D43C0", VA = "0x16D43C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011649")]
	[Address(RVA = "0x16D4464", Offset = "0x16D4464", VA = "0x16D4464", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601164A")]
	[Address(RVA = "0x16D4D74", Offset = "0x16D4D74", VA = "0x16D4D74")]
	private void InitDots()
	{
	}

	[Token(Token = "0x601164B")]
	[Address(RVA = "0x16D4768", Offset = "0x16D4768", VA = "0x16D4768")]
	private void InitTutorial()
	{
	}

	[Token(Token = "0x601164C")]
	[Address(RVA = "0x16D5318", Offset = "0x16D5318", VA = "0x16D5318")]
	private void OnAutoScrollAdItem()
	{
	}

	[Token(Token = "0x601164D")]
	[Address(RVA = "0x16D5490", Offset = "0x16D5490", VA = "0x16D5490")]
	public void ForceScrollToItem(int index)
	{
	}

	[Token(Token = "0x601164E")]
	[Address(RVA = "0x16D55FC", Offset = "0x16D55FC", VA = "0x16D55FC")]
	private void GetCenterItem(GameObject centerGo)
	{
	}

	[Token(Token = "0x601164F")]
	[Address(RVA = "0x16D588C", Offset = "0x16D588C", VA = "0x16D588C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
