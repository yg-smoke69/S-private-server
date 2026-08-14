using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A88")]
public class UIWorkShopMapDetailPopupWindowView : UIBaseView
{
	[Token(Token = "0x4018E5C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BlackBG;

	[Token(Token = "0x4018E5D")]
	[FieldOffset(Offset = "0x18")]
	public Transform WindowContainer;

	[Token(Token = "0x4018E5E")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnClose;

	[Token(Token = "0x4018E5F")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnLeft;

	[Token(Token = "0x4018E60")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnRight;

	[Token(Token = "0x4018E61")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DotNode;

	[Token(Token = "0x4018E62")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid DotGrid;

	[Token(Token = "0x4018E63")]
	[FieldOffset(Offset = "0x30")]
	public UISprite DotNodeItem;

	[Token(Token = "0x4018E64")]
	[FieldOffset(Offset = "0x34")]
	public UIScrollView MapScrollView;

	[Token(Token = "0x4018E65")]
	[FieldOffset(Offset = "0x38")]
	public UICenterOnChild CenterOnChildComponent;

	[Token(Token = "0x4018E66")]
	[FieldOffset(Offset = "0x3C")]
	public UIGrid ContentGrid;

	[Token(Token = "0x601733E")]
	[Address(RVA = "0x1A1849C", Offset = "0x1A1849C", VA = "0x1A1849C")]
	public UIWorkShopMapDetailPopupWindowView()
	{
	}

	[Token(Token = "0x601733F")]
	[Address(RVA = "0x1A184A4", Offset = "0x1A184A4", VA = "0x1A184A4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017340")]
	[Address(RVA = "0x1A189D8", Offset = "0x1A189D8", VA = "0x1A189D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
