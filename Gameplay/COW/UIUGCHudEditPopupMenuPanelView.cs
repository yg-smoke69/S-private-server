using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A2E")]
public class UIUGCHudEditPopupMenuPanelView : UIBaseView
{
	[Token(Token = "0x4018926")]
	[FieldOffset(Offset = "0x14")]
	public Transform Root;

	[Token(Token = "0x4018927")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BG;

	[Token(Token = "0x4018928")]
	[FieldOffset(Offset = "0x1C")]
	public UITable MenuTable;

	[Token(Token = "0x4018929")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Item;

	[Token(Token = "0x401892A")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Empty;

	[Token(Token = "0x6017230")]
	[Address(RVA = "0x2FEDC70", Offset = "0x2FEDC70", VA = "0x2FEDC70")]
	public UIUGCHudEditPopupMenuPanelView()
	{
	}

	[Token(Token = "0x6017231")]
	[Address(RVA = "0x2FEDC78", Offset = "0x2FEDC78", VA = "0x2FEDC78", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017232")]
	[Address(RVA = "0x2FEDF6C", Offset = "0x2FEDF6C", VA = "0x2FEDF6C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
