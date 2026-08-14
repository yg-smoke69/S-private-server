using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003719")]
public class UIHUDRushingPetsCountDownTipView : UIBaseView
{
	[Token(Token = "0x4016433")]
	[FieldOffset(Offset = "0x14")]
	public UILabel CountDownLabel;

	[Token(Token = "0x4016434")]
	[FieldOffset(Offset = "0x18")]
	public GameObject GoVFX;

	[Token(Token = "0x4016435")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GameBeginPrepareRoot;

	[Token(Token = "0x4016436")]
	[FieldOffset(Offset = "0x20")]
	public UILabel GameBeginLeftTimeLabel;

	[Token(Token = "0x60168F6")]
	[Address(RVA = "0x1688398", Offset = "0x1688398", VA = "0x1688398")]
	public UIHUDRushingPetsCountDownTipView()
	{
	}

	[Token(Token = "0x60168F7")]
	[Address(RVA = "0x16883A0", Offset = "0x16883A0", VA = "0x16883A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168F8")]
	[Address(RVA = "0x1688650", Offset = "0x1688650", VA = "0x1688650")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
