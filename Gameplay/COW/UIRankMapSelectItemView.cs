using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003944")]
public class UIRankMapSelectItemView : UIBaseView
{
	[Token(Token = "0x4017F6B")]
	[FieldOffset(Offset = "0x14")]
	public UIButton DragItem;

	[Token(Token = "0x4017F6C")]
	[FieldOffset(Offset = "0x18")]
	public UISprite bg;

	[Token(Token = "0x4017F6D")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ModeSprite;

	[Token(Token = "0x4017F6E")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x4017F6F")]
	[FieldOffset(Offset = "0x24")]
	public GameObject DownloadRoot;

	[Token(Token = "0x4017F70")]
	[FieldOffset(Offset = "0x28")]
	public UICheckboxButton SelectButton;

	[Token(Token = "0x4017F71")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Empty;

	[Token(Token = "0x4017F72")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Selected;

	[Token(Token = "0x4017F73")]
	[FieldOffset(Offset = "0x34")]
	public UILabel MapName;

	[Token(Token = "0x6016F73")]
	[Address(RVA = "0x1ACF158", Offset = "0x1ACF158", VA = "0x1ACF158")]
	public UIRankMapSelectItemView()
	{
	}

	[Token(Token = "0x6016F74")]
	[Address(RVA = "0x1ACF160", Offset = "0x1ACF160", VA = "0x1ACF160", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F75")]
	[Address(RVA = "0x1ACF5E4", Offset = "0x1ACF5E4", VA = "0x1ACF5E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
