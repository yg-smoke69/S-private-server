using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003486")]
public class UICommonTipsView : UIBaseView
{
	[Token(Token = "0x4014721")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Mask;

	[Token(Token = "0x4014722")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TipTxt;

	[Token(Token = "0x4014723")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Bg;

	[Token(Token = "0x6016146")]
	[Address(RVA = "0x1EBC120", Offset = "0x1EBC120", VA = "0x1EBC120")]
	public UICommonTipsView()
	{
	}

	[Token(Token = "0x6016147")]
	[Address(RVA = "0x1EBC128", Offset = "0x1EBC128", VA = "0x1EBC128", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016148")]
	[Address(RVA = "0x1EBC390", Offset = "0x1EBC390", VA = "0x1EBC390")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
