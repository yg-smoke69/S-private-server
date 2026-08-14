using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A29")]
public class UIPaymentDiamondItemController : UIBaseController
{
	[Token(Token = "0x4010356")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentDiamondItemView m_View;

	[Token(Token = "0x4010357")]
	[FieldOffset(Offset = "0x2C")]
	private Color selectedColor;

	[Token(Token = "0x4010358")]
	[FieldOffset(Offset = "0x3C")]
	private Color lockedColor;

	[Token(Token = "0x4010359")]
	[FieldOffset(Offset = "0x4C")]
	private PaymentDiamondItemData m_Info;

	[Token(Token = "0x401035A")]
	[FieldOffset(Offset = "0x50")]
	private UIModelPayment m_Model;

	[Token(Token = "0x401035B")]
	[FieldOffset(Offset = "0x54")]
	private int m_Index;

	[Token(Token = "0x60110D2")]
	[Address(RVA = "0x288590C", Offset = "0x288590C", VA = "0x288590C")]
	public UIPaymentDiamondItemController()
	{
	}

	[Token(Token = "0x60110D3")]
	[Address(RVA = "0x28859E4", Offset = "0x28859E4", VA = "0x28859E4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60110D4")]
	[Address(RVA = "0x2885A8C", Offset = "0x2885A8C", VA = "0x2885A8C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60110D5")]
	[Address(RVA = "0x2881EA0", Offset = "0x2881EA0", VA = "0x2881EA0")]
	public void ResetState()
	{
	}

	[Token(Token = "0x60110D6")]
	[Address(RVA = "0x2885D54", Offset = "0x2885D54", VA = "0x2885D54", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60110D7")]
	[Address(RVA = "0x2883A60", Offset = "0x2883A60", VA = "0x2883A60")]
	public void SetViewData(object data, int index)
	{
	}

	[Token(Token = "0x60110D8")]
	[Address(RVA = "0x2885EF0", Offset = "0x2885EF0", VA = "0x2885EF0")]
	private void PlayEffectAndSound(object[] data)
	{
	}

	[Token(Token = "0x60110D9")]
	[Address(RVA = "0x2886690", Offset = "0x2886690", VA = "0x2886690")]
	private void AfterAnimPlayed(object[] data)
	{
	}

	[Token(Token = "0x60110DA")]
	[Address(RVA = "0x2886728", Offset = "0x2886728", VA = "0x2886728")]
	private void OnButtonClicked()
	{
	}

	[Token(Token = "0x60110DB")]
	[Address(RVA = "0x2886F68", Offset = "0x2886F68", VA = "0x2886F68")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60110DC")]
	[Address(RVA = "0x2886F70", Offset = "0x2886F70", VA = "0x2886F70")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
