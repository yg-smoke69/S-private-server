using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003915")]
public class UIPopMenuSmallView : UIBaseView
{
	[Token(Token = "0x4017C06")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIPopMenuSmall;

	[Token(Token = "0x4017C07")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel Container;

	[Token(Token = "0x4017C08")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject MainPart;

	[Token(Token = "0x4017C09")]
	[FieldOffset(Offset = "0x20")]
	public UIButton UIButtonOpenBtn;

	[Token(Token = "0x4017C0A")]
	[FieldOffset(Offset = "0x24")]
	public UISprite UISpriteOpenBtn;

	[Token(Token = "0x4017C0B")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ArrUp;

	[Token(Token = "0x4017C0C")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ArrDown;

	[Token(Token = "0x4017C0D")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Title;

	[Token(Token = "0x4017C0E")]
	[FieldOffset(Offset = "0x34")]
	public UISprite Icon;

	[Token(Token = "0x4017C0F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ScrollViewUpContainer;

	[Token(Token = "0x4017C10")]
	[FieldOffset(Offset = "0x3C")]
	public UIScrollView UIScrollViewScrollViewUp;

	[Token(Token = "0x4017C11")]
	[FieldOffset(Offset = "0x40")]
	public UIPanel UIPanelScrollViewUp;

	[Token(Token = "0x4017C12")]
	[FieldOffset(Offset = "0x44")]
	public UIGrid Table;

	[Token(Token = "0x4017C13")]
	[FieldOffset(Offset = "0x48")]
	public UISprite BGUp;

	[Token(Token = "0x4017C14")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject ScrollViewDownContainer;

	[Token(Token = "0x4017C15")]
	[FieldOffset(Offset = "0x50")]
	public UIScrollView UIScrollViewScrollViewDown;

	[Token(Token = "0x4017C16")]
	[FieldOffset(Offset = "0x54")]
	public UIPanel UIPanelScrollViewDown;

	[Token(Token = "0x4017C17")]
	[FieldOffset(Offset = "0x58")]
	public UIGrid Grid;

	[Token(Token = "0x4017C18")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite BGDown;

	[Token(Token = "0x6016EE8")]
	[Address(RVA = "0x2C6333C", Offset = "0x2C6333C", VA = "0x2C6333C")]
	public UIPopMenuSmallView()
	{
	}

	[Token(Token = "0x6016EE9")]
	[Address(RVA = "0x2C63344", Offset = "0x2C63344", VA = "0x2C63344", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EEA")]
	[Address(RVA = "0x2C63B88", Offset = "0x2C63B88", VA = "0x2C63B88")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
