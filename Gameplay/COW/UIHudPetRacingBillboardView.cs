using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036D9")]
public class UIHudPetRacingBillboardView : UIBaseView
{
	[Token(Token = "0x4016266")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BeforeRacing;

	[Token(Token = "0x4016267")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CountdownLabel;

	[Token(Token = "0x4016268")]
	[FieldOffset(Offset = "0x1C")]
	public UIHudPetRacerView Pet1;

	[Token(Token = "0x4016269")]
	[FieldOffset(Offset = "0x20")]
	public UIHudPetRacerView Pet2;

	[Token(Token = "0x401626A")]
	[FieldOffset(Offset = "0x24")]
	public UIHudPetRacerView Pet3;

	[Token(Token = "0x401626B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject HighlightEffect;

	[Token(Token = "0x401626C")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject AfterRacing;

	[Token(Token = "0x401626D")]
	[FieldOffset(Offset = "0x30")]
	public UISprite Winner;

	[Token(Token = "0x401626E")]
	[FieldOffset(Offset = "0x34")]
	public UILabel NextCountDownLabel;

	[Token(Token = "0x6016838")]
	[Address(RVA = "0x1851788", Offset = "0x1851788", VA = "0x1851788")]
	public UIHudPetRacingBillboardView()
	{
	}

	[Token(Token = "0x6016839")]
	[Address(RVA = "0x1851790", Offset = "0x1851790", VA = "0x1851790", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601683A")]
	[Address(RVA = "0x1851B14", Offset = "0x1851B14", VA = "0x1851B14")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
