using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003916")]
public class UIPopMenuView : UIBaseView
{
	[Token(Token = "0x4017C19")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel WindowPanel;

	[Token(Token = "0x4017C1A")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Mask;

	[Token(Token = "0x4017C1B")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Bg;

	[Token(Token = "0x4017C1C")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView MenuScrollView;

	[Token(Token = "0x4017C1D")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid ItemGrid;

	[Token(Token = "0x6016EEB")]
	[Address(RVA = "0x2C63B90", Offset = "0x2C63B90", VA = "0x2C63B90")]
	public UIPopMenuView()
	{
	}

	[Token(Token = "0x6016EEC")]
	[Address(RVA = "0x2C63B98", Offset = "0x2C63B98", VA = "0x2C63B98", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EED")]
	[Address(RVA = "0x2C63EC0", Offset = "0x2C63EC0", VA = "0x2C63EC0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
