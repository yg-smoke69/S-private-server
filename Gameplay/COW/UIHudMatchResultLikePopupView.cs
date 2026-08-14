using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036B0")]
public class UIHudMatchResultLikePopupView : UIBaseView
{
	[Token(Token = "0x4016074")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel MainPanel;

	[Token(Token = "0x4016075")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Bg;

	[Token(Token = "0x4016076")]
	[FieldOffset(Offset = "0x1C")]
	public UIPanel LabelPanel;

	[Token(Token = "0x4016077")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Like;

	[Token(Token = "0x4016078")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Messageshow;

	[Token(Token = "0x60167BD")]
	[Address(RVA = "0x19BB06C", Offset = "0x19BB06C", VA = "0x19BB06C")]
	public UIHudMatchResultLikePopupView()
	{
	}

	[Token(Token = "0x60167BE")]
	[Address(RVA = "0x19BB074", Offset = "0x19BB074", VA = "0x19BB074", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167BF")]
	[Address(RVA = "0x19BB39C", Offset = "0x19BB39C", VA = "0x19BB39C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
