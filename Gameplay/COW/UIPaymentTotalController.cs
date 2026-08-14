using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A43")]
public class UIPaymentTotalController : UIPaymentController.PaymentTabContentController
{
	[Token(Token = "0x40103D2")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentTotalView m_View;

	[Token(Token = "0x40103D3")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelActivity m_Activity;

	[Token(Token = "0x40103D4")]
	[FieldOffset(Offset = "0x30")]
	private List<UIPaymentTotalItemController> m_Items;

	[Token(Token = "0x40103D5")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6011262")]
	[Address(RVA = "0x23DC544", Offset = "0x23DC544", VA = "0x23DC544")]
	public UIPaymentTotalController()
	{
	}

	[Token(Token = "0x6011263")]
	[Address(RVA = "0x23DC5D0", Offset = "0x23DC5D0", VA = "0x23DC5D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011264")]
	[Address(RVA = "0x23DC678", Offset = "0x23DC678", VA = "0x23DC678", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011265")]
	[Address(RVA = "0x23DC890", Offset = "0x23DC890", VA = "0x23DC890", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011266")]
	[Address(RVA = "0x23DC8F4", Offset = "0x23DC8F4", VA = "0x23DC8F4", Slot = "32")]
	public override void RefreshContent()
	{
	}

	[Token(Token = "0x6011267")]
	[Address(RVA = "0x23DD5E4", Offset = "0x23DD5E4", VA = "0x23DD5E4")]
	private void UpdateProgressBar(uint currentProgress, uint[] progressValues)
	{
	}

	[Token(Token = "0x6011268")]
	[Address(RVA = "0x23DE14C", Offset = "0x23DE14C", VA = "0x23DE14C")]
	private void OnGotoButtonClick()
	{
	}

	[Token(Token = "0x6011269")]
	[Address(RVA = "0x23DE234", Offset = "0x23DE234", VA = "0x23DE234")]
	private void _003CRefreshContent_003Em__0()
	{
	}

	[Token(Token = "0x601126A")]
	[Address(RVA = "0x23DE278", Offset = "0x23DE278", VA = "0x23DE278")]
	private static int _003CUpdateProgressBar_003Em__1(uint p1, uint p2)
	{
		return default(int);
	}

	[Token(Token = "0x601126B")]
	[Address(RVA = "0x23DE280", Offset = "0x23DE280", VA = "0x23DE280")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601126C")]
	[Address(RVA = "0x23DE288", Offset = "0x23DE288", VA = "0x23DE288")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x601126D")]
	[Address(RVA = "0x23DE290", Offset = "0x23DE290", VA = "0x23DE290")]
	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}
}
