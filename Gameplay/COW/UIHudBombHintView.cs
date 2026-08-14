using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035F1")]
public class UIHudBombHintView : UIBaseView
{
	[Token(Token = "0x4015987")]
	[FieldOffset(Offset = "0x14")]
	public TweenAlpha tweenA;

	[Token(Token = "0x4015988")]
	[FieldOffset(Offset = "0x18")]
	public TweenScale tweenS;

	[Token(Token = "0x4015989")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel InfoLabel;

	[Token(Token = "0x401598A")]
	[FieldOffset(Offset = "0x20")]
	public UISprite WarningIcon;

	[Token(Token = "0x6016581")]
	[Address(RVA = "0x1E0CC84", Offset = "0x1E0CC84", VA = "0x1E0CC84")]
	public UIHudBombHintView()
	{
	}

	[Token(Token = "0x6016582")]
	[Address(RVA = "0x1E0CC8C", Offset = "0x1E0CC8C", VA = "0x1E0CC8C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016583")]
	[Address(RVA = "0x1E0CF54", Offset = "0x1E0CF54", VA = "0x1E0CF54")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
