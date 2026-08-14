using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003561")]
public class UIFrontEndPreviewWeaponZoomInView : UIBaseView
{
	[Token(Token = "0x4015251")]
	[FieldOffset(Offset = "0x14")]
	public UIButton btnClose;

	[Token(Token = "0x4015252")]
	[FieldOffset(Offset = "0x18")]
	public GameObject arrow;

	[Token(Token = "0x4015253")]
	[FieldOffset(Offset = "0x1C")]
	public UITexture PetBgPanel;

	[Token(Token = "0x60163D3")]
	[Address(RVA = "0xE972E4", Offset = "0xE972E4", VA = "0xE972E4")]
	public UIFrontEndPreviewWeaponZoomInView()
	{
	}

	[Token(Token = "0x60163D4")]
	[Address(RVA = "0xE972EC", Offset = "0xE972EC", VA = "0xE972EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163D5")]
	[Address(RVA = "0xE97548", Offset = "0xE97548", VA = "0xE97548")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
