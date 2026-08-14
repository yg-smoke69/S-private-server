using System;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20020B6")]
public class UIHudCommonlTipsController : UIPopupWindowController
{
	[Token(Token = "0x400CCE4")]
	[FieldOffset(Offset = "0x48")]
	private UIHudCommonlTipsView m_View;

	[Token(Token = "0x400CCE5")]
	[FieldOffset(Offset = "0x4C")]
	public Action<UIDetailTipsController> _onClose;

	[Token(Token = "0x600A8CA")]
	[Address(RVA = "0x1485C40", Offset = "0x1485C40", VA = "0x1485C40")]
	public UIHudCommonlTipsController()
	{
	}

	[Token(Token = "0x600A8CB")]
	[Address(RVA = "0x1485C48", Offset = "0x1485C48", VA = "0x1485C48")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A8CC")]
	[Address(RVA = "0x1485CB0", Offset = "0x1485CB0", VA = "0x1485CB0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A8CD")]
	[Address(RVA = "0x1485E20", Offset = "0x1485E20", VA = "0x1485E20", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A8CE")]
	[Address(RVA = "0x1485F74", Offset = "0x1485F74", VA = "0x1485F74", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600A8CF")]
	[Address(RVA = "0x1485F7C", Offset = "0x1485F7C", VA = "0x1485F7C", Slot = "35")]
	public override int MinGroupDepth()
	{
		return default(int);
	}

	[Token(Token = "0x600A8D0")]
	[Address(RVA = "0x1485F94", Offset = "0x1485F94", VA = "0x1485F94")]
	public void SetData(Vector3 itemPos, string descrip, Vector3 offset, EArrowFixedType arrowFixedType = EArrowFixedType.None)
	{
	}

	[Token(Token = "0x600A8D1")]
	[Address(RVA = "0x14861F0", Offset = "0x14861F0", VA = "0x14861F0")]
	private void _OnClose(object[] args)
	{
	}

	[Token(Token = "0x600A8D2")]
	[Address(RVA = "0x14861F8", Offset = "0x14861F8", VA = "0x14861F8")]
	private void OnNavigationPused(object[] args)
	{
	}
}
