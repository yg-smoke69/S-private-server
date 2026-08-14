using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200369A")]
public class UIHudLudoGameCountDownTipView : UIBaseView
{
	[Token(Token = "0x4015F88")]
	[FieldOffset(Offset = "0x14")]
	public UILabel CountDownLabel;

	[Token(Token = "0x4015F89")]
	[FieldOffset(Offset = "0x18")]
	public GameObject GoVFX;

	[Token(Token = "0x601677B")]
	[Address(RVA = "0xFF45AC", Offset = "0xFF45AC", VA = "0xFF45AC")]
	public UIHudLudoGameCountDownTipView()
	{
	}

	[Token(Token = "0x601677C")]
	[Address(RVA = "0xFF45B4", Offset = "0xFF45B4", VA = "0xFF45B4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601677D")]
	[Address(RVA = "0xFF47B0", Offset = "0xFF47B0", VA = "0xFF47B0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
