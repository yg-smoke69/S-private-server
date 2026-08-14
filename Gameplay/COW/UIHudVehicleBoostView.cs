using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037BF")]
public class UIHudVehicleBoostView : UIBaseView
{
	[Token(Token = "0x401695D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton btnBoost;

	[Token(Token = "0x401695E")]
	[FieldOffset(Offset = "0x18")]
	public UISprite icon;

	[Token(Token = "0x401695F")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject CDMask;

	[Token(Token = "0x4016960")]
	[FieldOffset(Offset = "0x20")]
	public UISprite CDProgress;

	[Token(Token = "0x6016AE8")]
	[Address(RVA = "0x1A6CD70", Offset = "0x1A6CD70", VA = "0x1A6CD70")]
	public UIHudVehicleBoostView()
	{
	}

	[Token(Token = "0x6016AE9")]
	[Address(RVA = "0x1A6CD78", Offset = "0x1A6CD78", VA = "0x1A6CD78", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AEA")]
	[Address(RVA = "0x1A6D034", Offset = "0x1A6D034", VA = "0x1A6D034")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
