using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033B2")]
public class UIActivityScrollViewItemView : UIBaseView
{
	[Token(Token = "0x4013BD7")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture AD;

	[Token(Token = "0x4013BD8")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ADBtn;

	[Token(Token = "0x4013BD9")]
	[FieldOffset(Offset = "0x1C")]
	public UIDragScrollView DragScroll;

	[Token(Token = "0x4013BDA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Line;

	[Token(Token = "0x6015ECC")]
	[Address(RVA = "0x2FC061C", Offset = "0x2FC061C", VA = "0x2FC061C")]
	public UIActivityScrollViewItemView()
	{
	}

	[Token(Token = "0x6015ECD")]
	[Address(RVA = "0x2FC0624", Offset = "0x2FC0624", VA = "0x2FC0624", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015ECE")]
	[Address(RVA = "0x2FC08E0", Offset = "0x2FC08E0", VA = "0x2FC08E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
