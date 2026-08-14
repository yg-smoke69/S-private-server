using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026D7")]
public class UIHudAskPurchaseItemController : UIEasyListItemController
{
	[Token(Token = "0x400EFF5")]
	[FieldOffset(Offset = "0x38")]
	private UIHudAskPurchaseItemView m_View;

	[Token(Token = "0x400EFF6")]
	[FieldOffset(Offset = "0x3C")]
	private AskCSPurchaseInfo m_Info;

	[Token(Token = "0x400EFF7")]
	[FieldOffset(Offset = "0x0")]
	private static Color ENABLE_COLOR;

	[Token(Token = "0x400EFF8")]
	[FieldOffset(Offset = "0x10")]
	private static Color DISABLE_COLOR;

	[Token(Token = "0x600EB0B")]
	[Address(RVA = "0x17080C0", Offset = "0x17080C0", VA = "0x17080C0")]
	public UIHudAskPurchaseItemController()
	{
	}

	[Token(Token = "0x600EB0C")]
	[Address(RVA = "0x17080C8", Offset = "0x17080C8", VA = "0x17080C8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EB0D")]
	[Address(RVA = "0x17082B8", Offset = "0x17082B8", VA = "0x17082B8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600EB0E")]
	[Address(RVA = "0x17083F4", Offset = "0x17083F4", VA = "0x17083F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EB0F")]
	[Address(RVA = "0x170849C", Offset = "0x170849C", VA = "0x170849C")]
	public void SetUIData(AskCSPurchaseInfo info)
	{
	}

	[Token(Token = "0x600EB10")]
	[Address(RVA = "0x1708B50", Offset = "0x1708B50", VA = "0x1708B50")]
	private void RefreshPayBtnStatus()
	{
	}

	[Token(Token = "0x600EB11")]
	[Address(RVA = "0x170944C", Offset = "0x170944C", VA = "0x170944C")]
	public void ClearData()
	{
	}

	[Token(Token = "0x600EB12")]
	[Address(RVA = "0x17094C0", Offset = "0x17094C0", VA = "0x17094C0")]
	private void OnClickPurchaseBtn()
	{
	}

	[Token(Token = "0x600EB13")]
	[Address(RVA = "0x1709668", Offset = "0x1709668", VA = "0x1709668")]
	private void OnCoinChange(object[] data)
	{
	}

	[Token(Token = "0x600EB14")]
	[Address(RVA = "0x170976C", Offset = "0x170976C", VA = "0x170976C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600EB16")]
	[Address(RVA = "0x1709924", Offset = "0x1709924", VA = "0x1709924")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EB17")]
	[Address(RVA = "0x170992C", Offset = "0x170992C", VA = "0x170992C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
