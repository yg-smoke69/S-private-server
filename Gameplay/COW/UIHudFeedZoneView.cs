using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003650")]
public class UIHudFeedZoneView : UIBaseView
{
	[Token(Token = "0x4015C97")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnFeedZone;

	[Token(Token = "0x4015C98")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem FlashEffect;

	[Token(Token = "0x601669D")]
	[Address(RVA = "0x1B9B910", Offset = "0x1B9B910", VA = "0x1B9B910")]
	public UIHudFeedZoneView()
	{
	}

	[Token(Token = "0x601669E")]
	[Address(RVA = "0x1B9B918", Offset = "0x1B9B918", VA = "0x1B9B918", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601669F")]
	[Address(RVA = "0x1B9BB20", Offset = "0x1B9BB20", VA = "0x1B9BB20")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
