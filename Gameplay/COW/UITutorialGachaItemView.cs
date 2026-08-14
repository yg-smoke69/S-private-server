using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A15")]
public class UITutorialGachaItemView : UIBaseView
{
	[Token(Token = "0x4018869")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x401886A")]
	[FieldOffset(Offset = "0x18")]
	public UIButton close;

	[Token(Token = "0x401886B")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x60171E5")]
	[Address(RVA = "0x1C3BB34", Offset = "0x1C3BB34", VA = "0x1C3BB34")]
	public UITutorialGachaItemView()
	{
	}

	[Token(Token = "0x60171E6")]
	[Address(RVA = "0x1C3BB3C", Offset = "0x1C3BB3C", VA = "0x1C3BB3C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171E7")]
	[Address(RVA = "0x1C3BDA4", Offset = "0x1C3BDA4", VA = "0x1C3BDA4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
