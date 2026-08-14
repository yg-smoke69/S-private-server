using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200287B")]
public class UIHudTestSkateboardBtn : UIEasyListItemController
{
	[Token(Token = "0x400F976")]
	[FieldOffset(Offset = "0x38")]
	public SkyboardData AData;

	[Token(Token = "0x400F977")]
	[FieldOffset(Offset = "0x3C")]
	public UIHudTestSkateboardController Owner;

	[Token(Token = "0x400F978")]
	[FieldOffset(Offset = "0x40")]
	public UILabel LabelName;

	[Token(Token = "0x400F979")]
	[FieldOffset(Offset = "0x44")]
	public UILabel LabelId;

	[Token(Token = "0x400F97A")]
	[FieldOffset(Offset = "0x48")]
	public UISprite Icon;

	[Token(Token = "0x400F97B")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite BG;

	[Token(Token = "0x400F97C")]
	[FieldOffset(Offset = "0x50")]
	public bool IsSearch;

	[Token(Token = "0x600FDCF")]
	[Address(RVA = "0x157A3D8", Offset = "0x157A3D8", VA = "0x157A3D8")]
	public UIHudTestSkateboardBtn()
	{
	}

	[Token(Token = "0x600FDD0")]
	[Address(RVA = "0x157A3E0", Offset = "0x157A3E0", VA = "0x157A3E0")]
	public void SetOwner(UIHudTestSkateboardController owner, bool isSearch)
	{
	}

	[Token(Token = "0x600FDD1")]
	[Address(RVA = "0x157A460", Offset = "0x157A460", VA = "0x157A460")]
	public void SetData(SkyboardData data)
	{
	}

	[Token(Token = "0x600FDD2")]
	[Address(RVA = "0x157A718", Offset = "0x157A718", VA = "0x157A718", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FDD3")]
	[Address(RVA = "0x157A85C", Offset = "0x157A85C", VA = "0x157A85C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600FDD4")]
	[Address(RVA = "0x157A960", Offset = "0x157A960", VA = "0x157A960", Slot = "32")]
	public override void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600FDD5")]
	[Address(RVA = "0x157ADA8", Offset = "0x157ADA8", VA = "0x157ADA8", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600FDD6")]
	[Address(RVA = "0x157AE0C", Offset = "0x157AE0C", VA = "0x157AE0C", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600FDD7")]
	[Address(RVA = "0x157A64C", Offset = "0x157A64C", VA = "0x157A64C")]
	public void SetSelection(bool selected)
	{
	}

	[Token(Token = "0x600FDD8")]
	[Address(RVA = "0x157AE70", Offset = "0x157AE70", VA = "0x157AE70")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FDD9")]
	[Address(RVA = "0x157AE78", Offset = "0x157AE78", VA = "0x157AE78")]
	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}

	[Token(Token = "0x600FDDA")]
	[Address(RVA = "0x157AE80", Offset = "0x157AE80", VA = "0x157AE80")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600FDDB")]
	[Address(RVA = "0x157AE88", Offset = "0x157AE88", VA = "0x157AE88")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
