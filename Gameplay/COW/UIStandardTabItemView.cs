using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039F1")]
public class UIStandardTabItemView : UIBaseView
{
	[Token(Token = "0x401869C")]
	[FieldOffset(Offset = "0x14")]
	public Animation Anim;

	[Token(Token = "0x401869D")]
	[FieldOffset(Offset = "0x18")]
	public UISprite DownArrow;

	[Token(Token = "0x401869E")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite UpArrow;

	[Token(Token = "0x401869F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Select;

	[Token(Token = "0x40186A0")]
	[FieldOffset(Offset = "0x24")]
	public UILabel SelectLabel;

	[Token(Token = "0x40186A1")]
	[FieldOffset(Offset = "0x28")]
	public GameObject UnFolded;

	[Token(Token = "0x40186A2")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel UnFoldedLabel;

	[Token(Token = "0x40186A3")]
	[FieldOffset(Offset = "0x30")]
	public GameObject UnSelect;

	[Token(Token = "0x40186A4")]
	[FieldOffset(Offset = "0x34")]
	public UISprite UnSelectWidget;

	[Token(Token = "0x40186A5")]
	[FieldOffset(Offset = "0x38")]
	public UILabel UnSelectLabel;

	[Token(Token = "0x40186A6")]
	[FieldOffset(Offset = "0x3C")]
	public UITipsButton RedPoint;

	[Token(Token = "0x40186A7")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Tag;

	[Token(Token = "0x40186A8")]
	[FieldOffset(Offset = "0x44")]
	public UILabel TagLabel;

	[Token(Token = "0x40186A9")]
	[FieldOffset(Offset = "0x48")]
	public UISprite TagIconBg;

	[Token(Token = "0x40186AA")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite TagIcon;

	[Token(Token = "0x40186AB")]
	[FieldOffset(Offset = "0x50")]
	public UIButton Button;

	[Token(Token = "0x40186AC")]
	[FieldOffset(Offset = "0x54")]
	public GameObject DrawerFixRect;

	[Token(Token = "0x6017179")]
	[Address(RVA = "0x2003F54", Offset = "0x2003F54", VA = "0x2003F54")]
	public UIStandardTabItemView()
	{
	}

	[Token(Token = "0x601717A")]
	[Address(RVA = "0x2003F5C", Offset = "0x2003F5C", VA = "0x2003F5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601717B")]
	[Address(RVA = "0x20046C8", Offset = "0x20046C8", VA = "0x20046C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
