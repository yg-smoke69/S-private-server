using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003992")]
public class UISceneEditItemAttributePopMenuView : UIBaseView
{
	[Token(Token = "0x40181F5")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UISceneEditItemAttributePopMenu;

	[Token(Token = "0x40181F6")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ParamNameLabel;

	[Token(Token = "0x40181F7")]
	[FieldOffset(Offset = "0x1C")]
	public UIPanel Container;

	[Token(Token = "0x40181F8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MainPart;

	[Token(Token = "0x40181F9")]
	[FieldOffset(Offset = "0x24")]
	public UIButton OpenBtn;

	[Token(Token = "0x40181FA")]
	[FieldOffset(Offset = "0x28")]
	public UISprite OpenBtnSprite;

	[Token(Token = "0x40181FB")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ArrUp;

	[Token(Token = "0x40181FC")]
	[FieldOffset(Offset = "0x30")]
	public UISprite ArrDown;

	[Token(Token = "0x40181FD")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Title;

	[Token(Token = "0x40181FE")]
	[FieldOffset(Offset = "0x38")]
	public UISprite Icon;

	[Token(Token = "0x40181FF")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ScrollViewUpContainer;

	[Token(Token = "0x4018200")]
	[FieldOffset(Offset = "0x40")]
	public UIScrollView ScrollViewUp;

	[Token(Token = "0x4018201")]
	[FieldOffset(Offset = "0x44")]
	public UIPanel ScrollViewUpPanel;

	[Token(Token = "0x4018202")]
	[FieldOffset(Offset = "0x48")]
	public UIGrid UpGrid;

	[Token(Token = "0x4018203")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite BGUp;

	[Token(Token = "0x4018204")]
	[FieldOffset(Offset = "0x50")]
	public GameObject ScrollViewDownContainer;

	[Token(Token = "0x4018205")]
	[FieldOffset(Offset = "0x54")]
	public UIScrollView ScrollViewDown;

	[Token(Token = "0x4018206")]
	[FieldOffset(Offset = "0x58")]
	public UIPanel ScrollViewDownPanel;

	[Token(Token = "0x4018207")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite BGDown;

	[Token(Token = "0x4018208")]
	[FieldOffset(Offset = "0x60")]
	public UIGrid DownGrid;

	[Token(Token = "0x4018209")]
	[FieldOffset(Offset = "0x64")]
	public Transform PopMenuUpContainer;

	[Token(Token = "0x401820A")]
	[FieldOffset(Offset = "0x68")]
	public Transform PopMenuDownContainer;

	[Token(Token = "0x601705D")]
	[Address(RVA = "0x2DA25D4", Offset = "0x2DA25D4", VA = "0x2DA25D4")]
	public UISceneEditItemAttributePopMenuView()
	{
	}

	[Token(Token = "0x601705E")]
	[Address(RVA = "0x2DA25DC", Offset = "0x2DA25DC", VA = "0x2DA25DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601705F")]
	[Address(RVA = "0x2DA2EF0", Offset = "0x2DA2EF0", VA = "0x2DA2EF0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
