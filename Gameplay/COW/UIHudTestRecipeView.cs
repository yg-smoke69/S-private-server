using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200376F")]
public class UIHudTestRecipeView : UIBaseView
{
	[Token(Token = "0x4016747")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ToggleRecipeDebug;

	[Token(Token = "0x4016748")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Test;

	[Token(Token = "0x4016749")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject wardrobeBtnTemplate;

	[Token(Token = "0x401674A")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid wardrobeTypeGrid;

	[Token(Token = "0x401674B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject recipeBtnTemplate;

	[Token(Token = "0x401674C")]
	[FieldOffset(Offset = "0x28")]
	public UIEasyList recipeEasyList;

	[Token(Token = "0x401674D")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject avatarBtnTemplate;

	[Token(Token = "0x401674E")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid avatarGrid;

	[Token(Token = "0x401674F")]
	[FieldOffset(Offset = "0x34")]
	public UIGrid UtilGrid;

	[Token(Token = "0x4016750")]
	[FieldOffset(Offset = "0x38")]
	public UIButton ClearAllRecipeBtn;

	[Token(Token = "0x4016751")]
	[FieldOffset(Offset = "0x3C")]
	public UICheckboxButton UseDefaultQualityCheckBox;

	[Token(Token = "0x4016752")]
	[FieldOffset(Offset = "0x40")]
	public UICheckboxButton UseHighQualityCheckBox;

	[Token(Token = "0x4016753")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BroadcastToOthers;

	[Token(Token = "0x4016754")]
	[FieldOffset(Offset = "0x48")]
	public UIInput searchInput;

	[Token(Token = "0x4016755")]
	[FieldOffset(Offset = "0x4C")]
	public UIEasyList searchEasyList;

	[Token(Token = "0x60169F8")]
	[Address(RVA = "0x1579884", Offset = "0x1579884", VA = "0x1579884")]
	public UIHudTestRecipeView()
	{
	}

	[Token(Token = "0x60169F9")]
	[Address(RVA = "0x157988C", Offset = "0x157988C", VA = "0x157988C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169FA")]
	[Address(RVA = "0x1579DF0", Offset = "0x1579DF0", VA = "0x1579DF0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
