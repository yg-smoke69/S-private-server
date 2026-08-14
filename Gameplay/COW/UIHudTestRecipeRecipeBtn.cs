using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002877")]
public class UIHudTestRecipeRecipeBtn : UIEasyListItemController
{
	[Token(Token = "0x400F96A")]
	[FieldOffset(Offset = "0x38")]
	public AvatarWardrobeData WData;

	[Token(Token = "0x400F96B")]
	[FieldOffset(Offset = "0x3C")]
	public UIHudTestRecipeController Owner;

	[Token(Token = "0x400F96C")]
	[FieldOffset(Offset = "0x40")]
	public bool IsSearch;

	[Token(Token = "0x400F96D")]
	[FieldOffset(Offset = "0x44")]
	public UISprite IconSprite;

	[Token(Token = "0x400F96E")]
	[FieldOffset(Offset = "0x48")]
	public GameObject BG;

	[Token(Token = "0x600FDBC")]
	[Address(RVA = "0x1579164", Offset = "0x1579164", VA = "0x1579164")]
	public UIHudTestRecipeRecipeBtn()
	{
	}

	[Token(Token = "0x600FDBD")]
	[Address(RVA = "0x157916C", Offset = "0x157916C", VA = "0x157916C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FDBE")]
	[Address(RVA = "0x1579068", Offset = "0x1579068", VA = "0x1579068")]
	public void SetOwnerData(UIHudTestRecipeController owner, bool isSearch)
	{
	}

	[Token(Token = "0x600FDBF")]
	[Address(RVA = "0x15792B0", Offset = "0x15792B0", VA = "0x15792B0", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600FDC0")]
	[Address(RVA = "0x15795E4", Offset = "0x15795E4", VA = "0x15795E4", Slot = "32")]
	public override void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600FDC1")]
	[Address(RVA = "0x1579694", Offset = "0x1579694", VA = "0x1579694", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600FDC2")]
	[Address(RVA = "0x1579800", Offset = "0x1579800", VA = "0x1579800", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600FDC3")]
	[Address(RVA = "0x15796F8", Offset = "0x15796F8", VA = "0x15796F8")]
	public void ShowBg(bool b)
	{
	}

	[Token(Token = "0x600FDC4")]
	[Address(RVA = "0x1579864", Offset = "0x1579864", VA = "0x1579864")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FDC5")]
	[Address(RVA = "0x157986C", Offset = "0x157986C", VA = "0x157986C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}

	[Token(Token = "0x600FDC6")]
	[Address(RVA = "0x1579874", Offset = "0x1579874", VA = "0x1579874")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600FDC7")]
	[Address(RVA = "0x157987C", Offset = "0x157987C", VA = "0x157987C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
