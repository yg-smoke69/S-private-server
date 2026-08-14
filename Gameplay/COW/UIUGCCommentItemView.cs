using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A1E")]
public class UIUGCCommentItemView : UIBaseView
{
	[Token(Token = "0x40188A3")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIUGCCommentItem;

	[Token(Token = "0x40188A4")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Text;

	[Token(Token = "0x40188A5")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Bg;

	[Token(Token = "0x40188A6")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SelectedBg;

	[Token(Token = "0x40188A7")]
	[FieldOffset(Offset = "0x24")]
	public UIButton DeleteBtn;

	[Token(Token = "0x6017200")]
	[Address(RVA = "0x2B85CD4", Offset = "0x2B85CD4", VA = "0x2B85CD4")]
	public UIUGCCommentItemView()
	{
	}

	[Token(Token = "0x6017201")]
	[Address(RVA = "0x2B85CDC", Offset = "0x2B85CDC", VA = "0x2B85CDC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017202")]
	[Address(RVA = "0x2B86004", Offset = "0x2B86004", VA = "0x2B86004")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
