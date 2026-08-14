using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037C1")]
public class UIHudVehicleDriverFireView : UIBaseView
{
	[Token(Token = "0x4016966")]
	[FieldOffset(Offset = "0x14")]
	public UISprite fire_BG;

	[Token(Token = "0x4016967")]
	[FieldOffset(Offset = "0x18")]
	public UIButton btn;

	[Token(Token = "0x4016968")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite CDProgress;

	[Token(Token = "0x4016969")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CDMask;

	[Token(Token = "0x401696A")]
	[FieldOffset(Offset = "0x24")]
	public Transform InteractionTran;

	[Token(Token = "0x401696B")]
	[FieldOffset(Offset = "0x28")]
	public UISprite icon;

	[Token(Token = "0x401696C")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite normal;

	[Token(Token = "0x6016AEE")]
	[Address(RVA = "0x1A6D968", Offset = "0x1A6D968", VA = "0x1A6D968")]
	public UIHudVehicleDriverFireView()
	{
	}

	[Token(Token = "0x6016AEF")]
	[Address(RVA = "0x1A6D970", Offset = "0x1A6D970", VA = "0x1A6D970", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AF0")]
	[Address(RVA = "0x1A6DD24", Offset = "0x1A6DD24", VA = "0x1A6DD24")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
