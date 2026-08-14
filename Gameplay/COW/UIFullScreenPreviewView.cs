using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003563")]
public class UIFullScreenPreviewView : UIBaseView
{
	[Token(Token = "0x4015256")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture BG;

	[Token(Token = "0x4015257")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel PanelMaxDepth;

	[Token(Token = "0x4015258")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x60163D9")]
	[Address(RVA = "0x265A500", Offset = "0x265A500", VA = "0x265A500")]
	public UIFullScreenPreviewView()
	{
	}

	[Token(Token = "0x60163DA")]
	[Address(RVA = "0x265A508", Offset = "0x265A508", VA = "0x265A508", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163DB")]
	[Address(RVA = "0x265A770", Offset = "0x265A770", VA = "0x265A770")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
