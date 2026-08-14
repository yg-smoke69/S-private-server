using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003562")]
public class UIFrontEndPreviewZoomInWithCameraView : UIBaseView
{
	[Token(Token = "0x4015254")]
	[FieldOffset(Offset = "0x14")]
	public UIButton btnClose;

	[Token(Token = "0x4015255")]
	[FieldOffset(Offset = "0x18")]
	public UITexture PetBgPanel;

	[Token(Token = "0x60163D6")]
	[Address(RVA = "0xE984F8", Offset = "0xE984F8", VA = "0xE984F8")]
	public UIFrontEndPreviewZoomInWithCameraView()
	{
	}

	[Token(Token = "0x60163D7")]
	[Address(RVA = "0xE98500", Offset = "0xE98500", VA = "0xE98500", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163D8")]
	[Address(RVA = "0xE98708", Offset = "0xE98708", VA = "0xE98708")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
