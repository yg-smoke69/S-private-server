using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003443")]
public class UIClanAvatarItemView : UIBaseView
{
	[Token(Token = "0x40143F3")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Item;

	[Token(Token = "0x40143F4")]
	[FieldOffset(Offset = "0x18")]
	public UIEffectSprite HeadSprite;

	[Token(Token = "0x601607D")]
	[Address(RVA = "0x2F229C4", Offset = "0x2F229C4", VA = "0x2F229C4")]
	public UIClanAvatarItemView()
	{
	}

	[Token(Token = "0x601607E")]
	[Address(RVA = "0x2F229CC", Offset = "0x2F229CC", VA = "0x2F229CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601607F")]
	[Address(RVA = "0x2F22BD4", Offset = "0x2F22BD4", VA = "0x2F22BD4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
