using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003911")]
public class UIPopMenuBigView : UIBaseView
{
	[Token(Token = "0x4017BDD")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIPopMenuBig;

	[Token(Token = "0x4017BDE")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel Container;

	[Token(Token = "0x4017BDF")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject MainPart;

	[Token(Token = "0x4017BE0")]
	[FieldOffset(Offset = "0x20")]
	public UIButton UIButtonOpenBtn;

	[Token(Token = "0x4017BE1")]
	[FieldOffset(Offset = "0x24")]
	public UISprite UISpriteOpenBtn;

	[Token(Token = "0x4017BE2")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ArrUp;

	[Token(Token = "0x4017BE3")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ArrDown;

	[Token(Token = "0x4017BE4")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Title;

	[Token(Token = "0x4017BE5")]
	[FieldOffset(Offset = "0x34")]
	public UISprite Icon;

	[Token(Token = "0x4017BE6")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ScrollViewUpContainer;

	[Token(Token = "0x4017BE7")]
	[FieldOffset(Offset = "0x3C")]
	public UIScrollView UIScrollViewScrollViewUp;

	[Token(Token = "0x4017BE8")]
	[FieldOffset(Offset = "0x40")]
	public UIPanel UIPanelScrollViewUp;

	[Token(Token = "0x4017BE9")]
	[FieldOffset(Offset = "0x44")]
	public UIGrid Table;

	[Token(Token = "0x4017BEA")]
	[FieldOffset(Offset = "0x48")]
	public UISprite BGUp;

	[Token(Token = "0x4017BEB")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject ScrollViewDownContainer;

	[Token(Token = "0x4017BEC")]
	[FieldOffset(Offset = "0x50")]
	public UIScrollView UIScrollViewScrollViewDown;

	[Token(Token = "0x4017BED")]
	[FieldOffset(Offset = "0x54")]
	public UIPanel UIPanelScrollViewDown;

	[Token(Token = "0x4017BEE")]
	[FieldOffset(Offset = "0x58")]
	public UIGrid Grid;

	[Token(Token = "0x4017BEF")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite BGDown;

	[Token(Token = "0x6016EDC")]
	[Address(RVA = "0x2C5B84C", Offset = "0x2C5B84C", VA = "0x2C5B84C")]
	public UIPopMenuBigView()
	{
	}

	[Token(Token = "0x6016EDD")]
	[Address(RVA = "0x2C5B854", Offset = "0x2C5B854", VA = "0x2C5B854", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EDE")]
	[Address(RVA = "0x2C5C098", Offset = "0x2C5C098", VA = "0x2C5C098")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
