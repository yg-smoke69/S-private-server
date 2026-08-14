using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035E9")]
public class UIHudBigHintView : UIBaseView
{
	[Token(Token = "0x4015949")]
	[FieldOffset(Offset = "0x14")]
	public TweenAlpha TA;

	[Token(Token = "0x401594A")]
	[FieldOffset(Offset = "0x18")]
	public TweenScale TS;

	[Token(Token = "0x401594B")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget Anchor;

	[Token(Token = "0x401594C")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Content;

	[Token(Token = "0x6016569")]
	[Address(RVA = "0x1DFFE54", Offset = "0x1DFFE54", VA = "0x1DFFE54")]
	public UIHudBigHintView()
	{
	}

	[Token(Token = "0x601656A")]
	[Address(RVA = "0x1DFFE5C", Offset = "0x1DFFE5C", VA = "0x1DFFE5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601656B")]
	[Address(RVA = "0x1E00124", Offset = "0x1E00124", VA = "0x1E00124")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
