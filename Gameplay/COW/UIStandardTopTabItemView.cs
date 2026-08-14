using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039F3")]
public class UIStandardTopTabItemView : UIBaseView
{
	[Token(Token = "0x40186B2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Button;

	[Token(Token = "0x40186B3")]
	[FieldOffset(Offset = "0x18")]
	public BoxCollider Collider;

	[Token(Token = "0x40186B4")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Select;

	[Token(Token = "0x40186B5")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SelectBg;

	[Token(Token = "0x40186B6")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SelectLine;

	[Token(Token = "0x40186B7")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SelectLabel;

	[Token(Token = "0x40186B8")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite NewTabIcon;

	[Token(Token = "0x40186B9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject UnSelect;

	[Token(Token = "0x40186BA")]
	[FieldOffset(Offset = "0x34")]
	public UISprite UnSelectBg;

	[Token(Token = "0x40186BB")]
	[FieldOffset(Offset = "0x38")]
	public UILabel UnSelectLabel;

	[Token(Token = "0x40186BC")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite TabIcon;

	[Token(Token = "0x40186BD")]
	[FieldOffset(Offset = "0x40")]
	public UITipsButton RedPoint;

	[Token(Token = "0x601717F")]
	[Address(RVA = "0x200703C", Offset = "0x200703C", VA = "0x200703C")]
	public UIStandardTopTabItemView()
	{
	}

	[Token(Token = "0x6017180")]
	[Address(RVA = "0x2007044", Offset = "0x2007044", VA = "0x2007044", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017181")]
	[Address(RVA = "0x20075F4", Offset = "0x20075F4", VA = "0x20075F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
