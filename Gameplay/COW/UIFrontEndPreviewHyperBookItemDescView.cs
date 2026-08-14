using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003559")]
public class UIFrontEndPreviewHyperBookItemDescView : UIBaseView
{
	[Token(Token = "0x401520A")]
	[FieldOffset(Offset = "0x14")]
	public UIFrontEndPreviewItemDescBaseView BaseView;

	[Token(Token = "0x401520B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject NormalPageDecoLine;

	[Token(Token = "0x401520C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject HiddenPageDecoLine;

	[Token(Token = "0x60163BB")]
	[Address(RVA = "0x27FCCFC", Offset = "0x27FCCFC", VA = "0x27FCCFC")]
	public UIFrontEndPreviewHyperBookItemDescView()
	{
	}

	[Token(Token = "0x60163BC")]
	[Address(RVA = "0x27FCD04", Offset = "0x27FCD04", VA = "0x27FCD04", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163BD")]
	[Address(RVA = "0x27FCF54", Offset = "0x27FCF54", VA = "0x27FCF54")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
