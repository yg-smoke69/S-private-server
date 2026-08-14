using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200281D")]
public class UIHudRangeShopCatagoryItemController : UIEasyListItemController
{
	[Token(Token = "0x400F7A0")]
	[FieldOffset(Offset = "0x38")]
	private UIHudRangeShopCatagoryItemView m_View;

	[Token(Token = "0x400F7A1")]
	[FieldOffset(Offset = "0x3C")]
	private MJCAOACICGE catagory;

	[Token(Token = "0x400F7A2")]
	[FieldOffset(Offset = "0x40")]
	private Color normalIconCol;

	[Token(Token = "0x400F7A3")]
	[FieldOffset(Offset = "0x50")]
	private Color hlIconCol;

	[Token(Token = "0x600F9F0")]
	[Address(RVA = "0x1FD7E5C", Offset = "0x1FD7E5C", VA = "0x1FD7E5C")]
	public UIHudRangeShopCatagoryItemController()
	{
	}

	[Token(Token = "0x600F9F1")]
	[Address(RVA = "0x1FD7EC4", Offset = "0x1FD7EC4", VA = "0x1FD7EC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F9F2")]
	[Address(RVA = "0x1FD7F68", Offset = "0x1FD7F68", VA = "0x1FD7F68", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F9F3")]
	[Address(RVA = "0x1FD80C4", Offset = "0x1FD80C4", VA = "0x1FD80C4", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600F9F4")]
	[Address(RVA = "0x1FD8310", Offset = "0x1FD8310", VA = "0x1FD8310", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600F9F5")]
	[Address(RVA = "0x1FD8410", Offset = "0x1FD8410", VA = "0x1FD8410", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600F9F6")]
	[Address(RVA = "0x1FD87D4", Offset = "0x1FD87D4", VA = "0x1FD87D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F9F7")]
	[Address(RVA = "0x1FD87DC", Offset = "0x1FD87DC", VA = "0x1FD87DC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600F9F8")]
	[Address(RVA = "0x1FD87E4", Offset = "0x1FD87E4", VA = "0x1FD87E4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
