using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003746")]
public class UIHudSimpleCountdownView : UIBaseView
{
	[Token(Token = "0x40165A5")]
	[FieldOffset(Offset = "0x14")]
	public UILabel CountdownLabel;

	[Token(Token = "0x40165A6")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget WidgetTutorialCountdown;

	[Token(Token = "0x601697D")]
	[Address(RVA = "0x16BB420", Offset = "0x16BB420", VA = "0x16BB420")]
	public UIHudSimpleCountdownView()
	{
	}

	[Token(Token = "0x601697E")]
	[Address(RVA = "0x16BB428", Offset = "0x16BB428", VA = "0x16BB428", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601697F")]
	[Address(RVA = "0x16BB630", Offset = "0x16BB630", VA = "0x16BB630")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
