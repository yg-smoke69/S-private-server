using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F69")]
public class UIActivityOverviewController : UIActivityContentController
{
	[Token(Token = "0x400C54B")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityOverviewView m_View;

	[Token(Token = "0x400C54C")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C54D")]
	[FieldOffset(Offset = "0x30")]
	private List<UIActivityOverviewItemController> m_Items;

	[Token(Token = "0x400C54E")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<AdvertDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6009BA9")]
	[Address(RVA = "0x2FB95A4", Offset = "0x2FB95A4", VA = "0x2FB95A4")]
	public UIActivityOverviewController()
	{
	}

	[Token(Token = "0x6009BAA")]
	[Address(RVA = "0x2FB9630", Offset = "0x2FB9630", VA = "0x2FB9630")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009BAB")]
	[Address(RVA = "0x2FB96D4", Offset = "0x2FB96D4", VA = "0x2FB96D4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009BAC")]
	[Address(RVA = "0x2FB9790", Offset = "0x2FB9790", VA = "0x2FB9790", Slot = "31")]
	public override void SetData(object data)
	{
	}

	[Token(Token = "0x6009BAD")]
	[Address(RVA = "0x2FBA398", Offset = "0x2FBA398", VA = "0x2FBA398", Slot = "32")]
	public override void Reload()
	{
	}

	[Token(Token = "0x6009BAE")]
	[Address(RVA = "0x2FBA5A4", Offset = "0x2FBA5A4", VA = "0x2FBA5A4")]
	private static int _003CSetData_003Em__0(AdvertDesc x, AdvertDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x6009BAF")]
	[Address(RVA = "0x2FBA5E4", Offset = "0x2FBA5E4", VA = "0x2FBA5E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009BB0")]
	[Address(RVA = "0x2FBA5EC", Offset = "0x2FBA5EC", VA = "0x2FBA5EC")]
	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	[Token(Token = "0x6009BB1")]
	[Address(RVA = "0x2FBA5F4", Offset = "0x2FBA5F4", VA = "0x2FBA5F4")]
	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
