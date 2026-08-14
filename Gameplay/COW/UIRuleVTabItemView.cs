using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200398C")]
public class UIRuleVTabItemView : UIBaseView
{
	[Token(Token = "0x401819C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIRuleVTabItem;

	[Token(Token = "0x401819D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelUniversal;

	[Token(Token = "0x401819E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelUniversalUnSelected;

	[Token(Token = "0x401819F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SpriteUniversalSelected;

	[Token(Token = "0x601704B")]
	[Address(RVA = "0x142A238", Offset = "0x142A238", VA = "0x142A238")]
	public UIRuleVTabItemView()
	{
	}

	[Token(Token = "0x601704C")]
	[Address(RVA = "0x142A240", Offset = "0x142A240", VA = "0x142A240", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601704D")]
	[Address(RVA = "0x142A4FC", Offset = "0x142A4FC", VA = "0x142A4FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
