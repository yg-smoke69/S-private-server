using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200241A")]
public class UIUGCHudWidgetAttributeSpriteItemController : UIEasyListItemController
{
	[Token(Token = "0x400E0CE")]
	[FieldOffset(Offset = "0x38")]
	public Action<int> onSelected;

	[Token(Token = "0x400E0CF")]
	[FieldOffset(Offset = "0x3C")]
	private UIUGCHudWidgetAttributeSpriteItemView m_View;

	[Token(Token = "0x600CC09")]
	[Address(RVA = "0x2FF897C", Offset = "0x2FF897C", VA = "0x2FF897C")]
	public UIUGCHudWidgetAttributeSpriteItemController()
	{
	}

	[Token(Token = "0x600CC0A")]
	[Address(RVA = "0x2FF8984", Offset = "0x2FF8984", VA = "0x2FF8984")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CC0B")]
	[Address(RVA = "0x2FF8A28", Offset = "0x2FF8A28", VA = "0x2FF8A28", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CC0C")]
	[Address(RVA = "0x2FF8B84", Offset = "0x2FF8B84", VA = "0x2FF8B84", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600CC0D")]
	[Address(RVA = "0x2FF8D30", Offset = "0x2FF8D30", VA = "0x2FF8D30", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600CC0E")]
	[Address(RVA = "0x2FF8E3C", Offset = "0x2FF8E3C", VA = "0x2FF8E3C", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600CC0F")]
	[Address(RVA = "0x2FF8ED8", Offset = "0x2FF8ED8", VA = "0x2FF8ED8")]
	private void OnItemClick()
	{
	}

	[Token(Token = "0x600CC10")]
	[Address(RVA = "0x2FF8F3C", Offset = "0x2FF8F3C", VA = "0x2FF8F3C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CC11")]
	[Address(RVA = "0x2FF8F44", Offset = "0x2FF8F44", VA = "0x2FF8F44")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600CC12")]
	[Address(RVA = "0x2FF8F4C", Offset = "0x2FF8F4C", VA = "0x2FF8F4C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
