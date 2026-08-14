using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003720")]
public class UIHudSceneEditActionAttributeView : UIBaseView
{
	[Token(Token = "0x4016471")]
	[FieldOffset(Offset = "0x14")]
	public UITable TabTable;

	[Token(Token = "0x4016472")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TipTabRoot;

	[Token(Token = "0x4016473")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite TipTabIcon;

	[Token(Token = "0x4016474")]
	[FieldOffset(Offset = "0x20")]
	public UISprite TipTabBg;

	[Token(Token = "0x4016475")]
	[FieldOffset(Offset = "0x24")]
	public UIButton TipTabBtn;

	[Token(Token = "0x4016476")]
	[FieldOffset(Offset = "0x28")]
	public GameObject AttributeTabRoot;

	[Token(Token = "0x4016477")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite AttributeTabIcon;

	[Token(Token = "0x4016478")]
	[FieldOffset(Offset = "0x30")]
	public UISprite AttributeTabBg;

	[Token(Token = "0x4016479")]
	[FieldOffset(Offset = "0x34")]
	public UIButton AttributeTabBtn;

	[Token(Token = "0x401647A")]
	[FieldOffset(Offset = "0x38")]
	public UIButton CloseBtn;

	[Token(Token = "0x401647B")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject AttributeRoot;

	[Token(Token = "0x401647C")]
	[FieldOffset(Offset = "0x40")]
	public GameObject AttributeDragSroll;

	[Token(Token = "0x401647D")]
	[FieldOffset(Offset = "0x44")]
	public UIScrollView ScollContentPanel;

	[Token(Token = "0x401647E")]
	[FieldOffset(Offset = "0x48")]
	public UITable AttributeItemTable;

	[Token(Token = "0x401647F")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject TipRoot;

	[Token(Token = "0x4016480")]
	[FieldOffset(Offset = "0x50")]
	public UILabel TipLabel;

	[Token(Token = "0x4016481")]
	[FieldOffset(Offset = "0x54")]
	public Transform CloseLeftAnchor;

	[Token(Token = "0x4016482")]
	[FieldOffset(Offset = "0x58")]
	public Transform CloseRightAnchor;

	[Token(Token = "0x4016483")]
	[FieldOffset(Offset = "0x5C")]
	public UIInput NameLabel;

	[Token(Token = "0x4016484")]
	[FieldOffset(Offset = "0x60")]
	public UIButton EditNameButton;

	[Token(Token = "0x4016485")]
	[FieldOffset(Offset = "0x64")]
	public GameObject CoordinateRoot;

	[Token(Token = "0x4016486")]
	[FieldOffset(Offset = "0x68")]
	public UILabel CoordinateLabel;

	[Token(Token = "0x4016487")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject DetailSettingRoot;

	[Token(Token = "0x4016488")]
	[FieldOffset(Offset = "0x70")]
	public UIButton SettingButton;

	[Token(Token = "0x4016489")]
	[FieldOffset(Offset = "0x74")]
	public UIButton OpenGraphButton;

	[Token(Token = "0x401648A")]
	[FieldOffset(Offset = "0x78")]
	public UITable AttributesContainer;

	[Token(Token = "0x401648B")]
	[FieldOffset(Offset = "0x7C")]
	public UISprite AttributesBG;

	[Token(Token = "0x401648C")]
	[FieldOffset(Offset = "0x80")]
	public GameObject Container;

	[Token(Token = "0x401648D")]
	[FieldOffset(Offset = "0x84")]
	public GameObject CloseBtnArrow;

	[Token(Token = "0x401648E")]
	[FieldOffset(Offset = "0x88")]
	public GameObject ColorRoot;

	[Token(Token = "0x401648F")]
	[FieldOffset(Offset = "0x8C")]
	public UIGrid ColorGrid;

	[Token(Token = "0x4016490")]
	[FieldOffset(Offset = "0x90")]
	public UISprite SurfaceColor;

	[Token(Token = "0x4016491")]
	[FieldOffset(Offset = "0x94")]
	public UISprite BorderColor;

	[Token(Token = "0x4016492")]
	[FieldOffset(Offset = "0x98")]
	public UIButton ColorButton;

	[Token(Token = "0x601690B")]
	[Address(RVA = "0x1C51408", Offset = "0x1C51408", VA = "0x1C51408")]
	public UIHudSceneEditActionAttributeView()
	{
	}

	[Token(Token = "0x601690C")]
	[Address(RVA = "0x1C51410", Offset = "0x1C51410", VA = "0x1C51410", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601690D")]
	[Address(RVA = "0x1C52150", Offset = "0x1C52150", VA = "0x1C52150")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
