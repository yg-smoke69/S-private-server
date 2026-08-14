using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037C3")]
public class UIHudVehicleJumpView : UIBaseView
{
	[Token(Token = "0x4016970")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Btn;

	[Token(Token = "0x4016971")]
	[FieldOffset(Offset = "0x18")]
	public UISprite CDProgress;

	[Token(Token = "0x4016972")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject CDMask;

	[Token(Token = "0x6016AF4")]
	[Address(RVA = "0x1A6F3CC", Offset = "0x1A6F3CC", VA = "0x1A6F3CC")]
	public UIHudVehicleJumpView()
	{
	}

	[Token(Token = "0x6016AF5")]
	[Address(RVA = "0x1A6F3D4", Offset = "0x1A6F3D4", VA = "0x1A6F3D4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AF6")]
	[Address(RVA = "0x1A6F630", Offset = "0x1A6F630", VA = "0x1A6F630")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
