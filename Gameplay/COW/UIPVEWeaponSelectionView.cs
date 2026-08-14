using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200393A")]
public class UIPVEWeaponSelectionView : UIBaseView
{
	[Token(Token = "0x4017F1C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Close;

	[Token(Token = "0x4017F1D")]
	[FieldOffset(Offset = "0x18")]
	public UISprite primaryWPSprite;

	[Token(Token = "0x4017F1E")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite validSprite;

	[Token(Token = "0x4017F1F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel valid;

	[Token(Token = "0x4017F20")]
	[FieldOffset(Offset = "0x24")]
	public UILabel skillDesc;

	[Token(Token = "0x4017F21")]
	[FieldOffset(Offset = "0x28")]
	public GameObject skillicon;

	[Token(Token = "0x4017F22")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel description;

	[Token(Token = "0x4017F23")]
	[FieldOffset(Offset = "0x30")]
	public Transform weaponProperty;

	[Token(Token = "0x4017F24")]
	[FieldOffset(Offset = "0x34")]
	public UIScrollView ScrollTab;

	[Token(Token = "0x4017F25")]
	[FieldOffset(Offset = "0x38")]
	public UIGrid tabGrid;

	[Token(Token = "0x4017F26")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggleButtonGroup tabToggleGroup;

	[Token(Token = "0x4017F27")]
	[FieldOffset(Offset = "0x40")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4017F28")]
	[FieldOffset(Offset = "0x44")]
	public UIEasyList weaponGrid;

	[Token(Token = "0x6016F55")]
	[Address(RVA = "0x15AF728", Offset = "0x15AF728", VA = "0x15AF728")]
	public UIPVEWeaponSelectionView()
	{
	}

	[Token(Token = "0x6016F56")]
	[Address(RVA = "0x15AF730", Offset = "0x15AF730", VA = "0x15AF730", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F57")]
	[Address(RVA = "0x15AFD24", Offset = "0x15AFD24", VA = "0x15AFD24")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
