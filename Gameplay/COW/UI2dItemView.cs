using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200339A")]
public class UI2dItemView : UIBaseView
{
	[Token(Token = "0x4013AFC")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ui2dparent;

	[Token(Token = "0x4013AFD")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel ui2dparentpanel;

	[Token(Token = "0x4013AFE")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget ItemViewContainer;

	[Token(Token = "0x4013AFF")]
	[FieldOffset(Offset = "0x20")]
	public BaseItemView BaseItemInfo;

	[Token(Token = "0x4013B00")]
	[FieldOffset(Offset = "0x24")]
	public Transform stone;

	[Token(Token = "0x4013B01")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ItemViewIcon;

	[Token(Token = "0x4013B02")]
	[FieldOffset(Offset = "0x2C")]
	public Transform BannerItemView;

	[Token(Token = "0x4013B03")]
	[FieldOffset(Offset = "0x30")]
	public Transform HeadPicItemView;

	[Token(Token = "0x4013B04")]
	[FieldOffset(Offset = "0x34")]
	public Transform MusicItemView;

	[Token(Token = "0x6015E84")]
	[Address(RVA = "0x29F9CFC", Offset = "0x29F9CFC", VA = "0x29F9CFC")]
	public UI2dItemView()
	{
	}

	[Token(Token = "0x6015E85")]
	[Address(RVA = "0x29F9D04", Offset = "0x29F9D04", VA = "0x29F9D04", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E86")]
	[Address(RVA = "0x29FA100", Offset = "0x29FA100", VA = "0x29FA100")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
