using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003823")]
public class UILegendGachaAdsView : UIBaseView
{
	[Token(Token = "0x4016E12")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Content;

	[Token(Token = "0x4016E13")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid Grid;

	[Token(Token = "0x4016E14")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView scrollview;

	[Token(Token = "0x4016E15")]
	[FieldOffset(Offset = "0x20")]
	public UIWrapContent WrapContent;

	[Token(Token = "0x4016E16")]
	[FieldOffset(Offset = "0x24")]
	public Animation VFXAnimation;

	[Token(Token = "0x4016E17")]
	[FieldOffset(Offset = "0x28")]
	public UIPanel VFXPanel;

	[Token(Token = "0x6016C14")]
	[Address(RVA = "0x25483D4", Offset = "0x25483D4", VA = "0x25483D4")]
	public UILegendGachaAdsView()
	{
	}

	[Token(Token = "0x6016C15")]
	[Address(RVA = "0x25483DC", Offset = "0x25483DC", VA = "0x25483DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C16")]
	[Address(RVA = "0x2548764", Offset = "0x2548764", VA = "0x2548764")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
