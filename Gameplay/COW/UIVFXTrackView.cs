using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A68")]
public class UIVFXTrackView : UIBaseView
{
	[Token(Token = "0x4018C2E")]
	[FieldOffset(Offset = "0x14")]
	public TweenPositionArc VFXTrial;

	[Token(Token = "0x4018C2F")]
	[FieldOffset(Offset = "0x18")]
	public Transform VFXEnd;

	[Token(Token = "0x60172DE")]
	[Address(RVA = "0x2844918", Offset = "0x2844918", VA = "0x2844918")]
	public UIVFXTrackView()
	{
	}

	[Token(Token = "0x60172DF")]
	[Address(RVA = "0x2844920", Offset = "0x2844920", VA = "0x2844920", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172E0")]
	[Address(RVA = "0x2844B00", Offset = "0x2844B00", VA = "0x2844B00")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
