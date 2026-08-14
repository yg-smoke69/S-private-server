using System;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20020B9")]
public class UISmallDetailTipsController : UIPopupWindowController
{
	[Token(Token = "0x400CCF2")]
	[FieldOffset(Offset = "0x48")]
	private UISmallDetailTipsView m_View;

	[Token(Token = "0x400CCF3")]
	[FieldOffset(Offset = "0x4C")]
	public Action<UIDetailTipsController> _onClose;

	[Token(Token = "0x400CCF4")]
	[FieldOffset(Offset = "0x50")]
	private Action m_ConfirmCallBack;

	[Token(Token = "0x400CCF5")]
	[FieldOffset(Offset = "0x54")]
	private Action m_CancelCallBack;

	[Token(Token = "0x400CCF6")]
	[FieldOffset(Offset = "0x58")]
	private bool m_CloseWithCollider;

	[Token(Token = "0x600A8E2")]
	[Address(RVA = "0x2248EFC", Offset = "0x2248EFC", VA = "0x2248EFC")]
	public UISmallDetailTipsController()
	{
	}

	[Token(Token = "0x600A8E3")]
	[Address(RVA = "0x2248F04", Offset = "0x2248F04", VA = "0x2248F04")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A8E4")]
	[Address(RVA = "0x2248F68", Offset = "0x2248F68", VA = "0x2248F68", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A8E5")]
	[Address(RVA = "0x2249268", Offset = "0x2249268", VA = "0x2249268", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A8E6")]
	[Address(RVA = "0x22493BC", Offset = "0x22493BC", VA = "0x22493BC", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600A8E7")]
	[Address(RVA = "0x22493C4", Offset = "0x22493C4", VA = "0x22493C4", Slot = "35")]
	public override int MinGroupDepth()
	{
		return default(int);
	}

	[Token(Token = "0x600A8E8")]
	[Address(RVA = "0x22493DC", Offset = "0x22493DC", VA = "0x22493DC")]
	public void SetData(Vector3 itemPos, BaseItemInfo info)
	{
	}

	[Token(Token = "0x600A8E9")]
	[Address(RVA = "0x22494F4", Offset = "0x22494F4", VA = "0x22494F4")]
	public void SetData(Vector3 itemPos, BaseItemInfo info, string name, string descrip, Vector3 offset, TipsBtnInfo[] btn_info_list, bool use_collider, EArrowFixedType arrowFixedType)
	{
	}

	[Token(Token = "0x600A8EA")]
	[Address(RVA = "0x224A8A0", Offset = "0x224A8A0", VA = "0x224A8A0")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x600A8EB")]
	[Address(RVA = "0x224A8F8", Offset = "0x224A8F8", VA = "0x224A8F8")]
	private void OnCancleClick()
	{
	}

	[Token(Token = "0x600A8EC")]
	[Address(RVA = "0x224A8E4", Offset = "0x224A8E4", VA = "0x224A8E4")]
	private void CloseWithCollider()
	{
	}

	[Token(Token = "0x600A8ED")]
	[Address(RVA = "0x224A93C", Offset = "0x224A93C", VA = "0x224A93C")]
	private void _OnClose(object[] args)
	{
	}

	[Token(Token = "0x600A8EE")]
	[Address(RVA = "0x224AA64", Offset = "0x224AA64", VA = "0x224AA64")]
	private void OnNavigationPused(object[] args)
	{
	}
}
