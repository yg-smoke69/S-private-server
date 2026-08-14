using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037F3")]
public class UIIAPBundlePreviewWindowView : UIBaseView
{
	[Token(Token = "0x4016B34")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ItemsContainer;

	[Token(Token = "0x4016B35")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ItemsScrollview;

	[Token(Token = "0x4016B36")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid ItemsGrid;

	[Token(Token = "0x6016B84")]
	[Address(RVA = "0xD4215C", Offset = "0xD4215C", VA = "0xD4215C")]
	public UIIAPBundlePreviewWindowView()
	{
	}

	[Token(Token = "0x6016B85")]
	[Address(RVA = "0xD42164", Offset = "0xD42164", VA = "0xD42164", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B86")]
	[Address(RVA = "0xD423C0", Offset = "0xD423C0", VA = "0xD423C0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
