using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035B8")]
public class UIGuideTipsView : UIBaseView
{
	[Token(Token = "0x4015802")]
	[FieldOffset(Offset = "0x14")]
	public GameObject TextHintObject;

	[Token(Token = "0x4015803")]
	[FieldOffset(Offset = "0x18")]
	public UILabel HintLabel;

	[Token(Token = "0x4015804")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite TipsBGWidget;

	[Token(Token = "0x60164D6")]
	[Address(RVA = "0x2028064", Offset = "0x2028064", VA = "0x2028064")]
	public UIGuideTipsView()
	{
	}

	[Token(Token = "0x60164D7")]
	[Address(RVA = "0x202806C", Offset = "0x202806C", VA = "0x202806C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164D8")]
	[Address(RVA = "0x20282C8", Offset = "0x20282C8", VA = "0x20282C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
