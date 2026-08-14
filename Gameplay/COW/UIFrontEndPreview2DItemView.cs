using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200354B")]
public class UIFrontEndPreview2DItemView : UIBaseView
{
	[Token(Token = "0x40151EF")]
	[FieldOffset(Offset = "0x14")]
	public GameObject GameObjectUIFrontEndPreview2DItem;

	[Token(Token = "0x40151F0")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel UIPanelUIFrontEndPreview2DItem;

	[Token(Token = "0x40151F1")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget UIWidgetItemViewContainer;

	[Token(Token = "0x40151F2")]
	[FieldOffset(Offset = "0x20")]
	public BaseItemView BaseItemViewItemViewContainer;

	[Token(Token = "0x40151F3")]
	[FieldOffset(Offset = "0x24")]
	public UISprite ItemViewIcon;

	[Token(Token = "0x40151F4")]
	[FieldOffset(Offset = "0x28")]
	public Transform BannerItemView;

	[Token(Token = "0x40151F5")]
	[FieldOffset(Offset = "0x2C")]
	public Transform HeadPicItemView;

	[Token(Token = "0x40151F6")]
	[FieldOffset(Offset = "0x30")]
	public Transform MusicItemView;

	[Token(Token = "0x40151F7")]
	[FieldOffset(Offset = "0x34")]
	public Transform ItemViewIconContainer;

	[Token(Token = "0x6016391")]
	[Address(RVA = "0x2517638", Offset = "0x2517638", VA = "0x2517638")]
	public UIFrontEndPreview2DItemView()
	{
	}

	[Token(Token = "0x6016392")]
	[Address(RVA = "0x2517640", Offset = "0x2517640", VA = "0x2517640", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016393")]
	[Address(RVA = "0x2517A3C", Offset = "0x2517A3C", VA = "0x2517A3C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
