using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037C7")]
public class UIHudVehicleResetView : UIBaseView
{
	[Token(Token = "0x4016980")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Btn;

	[Token(Token = "0x4016981")]
	[FieldOffset(Offset = "0x18")]
	public UISprite icon;

	[Token(Token = "0x4016982")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject CDMask;

	[Token(Token = "0x4016983")]
	[FieldOffset(Offset = "0x20")]
	public UISprite CDProgress;

	[Token(Token = "0x6016B00")]
	[Address(RVA = "0x1A70DD0", Offset = "0x1A70DD0", VA = "0x1A70DD0")]
	public UIHudVehicleResetView()
	{
	}

	[Token(Token = "0x6016B01")]
	[Address(RVA = "0x1A70DD8", Offset = "0x1A70DD8", VA = "0x1A70DD8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B02")]
	[Address(RVA = "0x1A71094", Offset = "0x1A71094", VA = "0x1A71094")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
