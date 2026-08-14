using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038FF")]
public class UIPeriodicRankMapSelectItemView : UIBaseView
{
	[Token(Token = "0x4017B1A")]
	[FieldOffset(Offset = "0x14")]
	public UIButton DragItem;

	[Token(Token = "0x4017B1B")]
	[FieldOffset(Offset = "0x18")]
	public UISprite bg;

	[Token(Token = "0x4017B1C")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ModeSprite;

	[Token(Token = "0x4017B1D")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x4017B1E")]
	[FieldOffset(Offset = "0x24")]
	public GameObject DownloadRoot;

	[Token(Token = "0x4017B1F")]
	[FieldOffset(Offset = "0x28")]
	public UICheckboxButton SelectButton;

	[Token(Token = "0x4017B20")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Empty;

	[Token(Token = "0x4017B21")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Selected;

	[Token(Token = "0x4017B22")]
	[FieldOffset(Offset = "0x34")]
	public UILabel MapName;

	[Token(Token = "0x6016EA6")]
	[Address(RVA = "0x23E4AC0", Offset = "0x23E4AC0", VA = "0x23E4AC0")]
	public UIPeriodicRankMapSelectItemView()
	{
	}

	[Token(Token = "0x6016EA7")]
	[Address(RVA = "0x23E4AC8", Offset = "0x23E4AC8", VA = "0x23E4AC8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EA8")]
	[Address(RVA = "0x23E4F4C", Offset = "0x23E4F4C", VA = "0x23E4F4C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
