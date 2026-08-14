using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003772")]
public class UIHudTimerView : UIBaseView
{
	[Token(Token = "0x4016762")]
	[FieldOffset(Offset = "0x14")]
	public Animator FX_UI_time;

	[Token(Token = "0x4016763")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Time;

	[Token(Token = "0x4016764")]
	[FieldOffset(Offset = "0x1C")]
	public Animator UIHudTimer_Ani;

	[Token(Token = "0x4016765")]
	[FieldOffset(Offset = "0x20")]
	public AudioSource UIHudTimerAudio;

	[Token(Token = "0x6016A01")]
	[Address(RVA = "0x157E910", Offset = "0x157E910", VA = "0x157E910")]
	public UIHudTimerView()
	{
	}

	[Token(Token = "0x6016A02")]
	[Address(RVA = "0x157E918", Offset = "0x157E918", VA = "0x157E918", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A03")]
	[Address(RVA = "0x157EBE0", Offset = "0x157EBE0", VA = "0x157EBE0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
