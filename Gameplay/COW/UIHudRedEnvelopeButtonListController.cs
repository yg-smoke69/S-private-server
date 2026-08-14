using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002823")]
public class UIHudRedEnvelopeButtonListController : UIBaseController
{
	[Token(Token = "0x400F7B7")]
	[FieldOffset(Offset = "0x28")]
	private UIHudRedEnvelopeButtonListView m_View;

	[Token(Token = "0x400F7B8")]
	[FieldOffset(Offset = "0x2C")]
	private List<RedEnvelopeItemView> m_ItemViewList;

	[Token(Token = "0x400F7B9")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<LGACFNABBDC> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600FA1C")]
	[Address(RVA = "0x13DB0F4", Offset = "0x13DB0F4", VA = "0x13DB0F4")]
	public UIHudRedEnvelopeButtonListController()
	{
	}

	[Token(Token = "0x600FA1D")]
	[Address(RVA = "0x13DB1AC", Offset = "0x13DB1AC", VA = "0x13DB1AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FA1E")]
	[Address(RVA = "0x13DB254", Offset = "0x13DB254", VA = "0x13DB254", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FA1F")]
	[Address(RVA = "0x13DB4D0", Offset = "0x13DB4D0", VA = "0x13DB4D0")]
	public void SetRedEnvelopeData(object[] param)
	{
	}

	[Token(Token = "0x600FA20")]
	[Address(RVA = "0x13DBC64", Offset = "0x13DBC64", VA = "0x13DBC64", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FA21")]
	[Address(RVA = "0x13DBE68", Offset = "0x13DBE68", VA = "0x13DBE68")]
	private void OnRedEnvelopeBtnClick(object[] param)
	{
	}

	[Token(Token = "0x600FA22")]
	[Address(RVA = "0x13DC154", Offset = "0x13DC154", VA = "0x13DC154")]
	private void OnTrainingZoneChanged(object[] param)
	{
	}

	[Token(Token = "0x600FA23")]
	[Address(RVA = "0x13DC254", Offset = "0x13DC254", VA = "0x13DC254")]
	private static int _003CSetRedEnvelopeData_003Em__0(LGACFNABBDC a, LGACFNABBDC b)
	{
		return default(int);
	}

	[Token(Token = "0x600FA24")]
	[Address(RVA = "0x13DC2C4", Offset = "0x13DC2C4", VA = "0x13DC2C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FA25")]
	[Address(RVA = "0x13DC2CC", Offset = "0x13DC2CC", VA = "0x13DC2CC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
