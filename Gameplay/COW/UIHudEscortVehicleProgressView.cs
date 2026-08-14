using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200364D")]
public class UIHudEscortVehicleProgressView : UIBaseView
{
	[Token(Token = "0x4015C81")]
	[FieldOffset(Offset = "0x14")]
	public Transform PlayerStatus;

	[Token(Token = "0x4015C82")]
	[FieldOffset(Offset = "0x18")]
	public UILabel DefenderLabel;

	[Token(Token = "0x4015C83")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel AttackerLabel;

	[Token(Token = "0x4015C84")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ProgBar1;

	[Token(Token = "0x4015C85")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Flag1;

	[Token(Token = "0x4015C86")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ProgBar2;

	[Token(Token = "0x4015C87")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Flag2;

	[Token(Token = "0x4015C88")]
	[FieldOffset(Offset = "0x30")]
	public UISprite ProgBar3;

	[Token(Token = "0x4015C89")]
	[FieldOffset(Offset = "0x34")]
	public UISprite Flag3;

	[Token(Token = "0x4015C8A")]
	[FieldOffset(Offset = "0x38")]
	public UISprite ProgBar4;

	[Token(Token = "0x4015C8B")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite Flag4;

	[Token(Token = "0x4015C8C")]
	[FieldOffset(Offset = "0x40")]
	public Transform VehicleIcon;

	[Token(Token = "0x4015C8D")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Hint;

	[Token(Token = "0x4015C8E")]
	[FieldOffset(Offset = "0x48")]
	public UILabel HintText;

	[Token(Token = "0x4015C8F")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite DescriptionBG;

	[Token(Token = "0x6016694")]
	[Address(RVA = "0x1B98FD8", Offset = "0x1B98FD8", VA = "0x1B98FD8")]
	public UIHudEscortVehicleProgressView()
	{
	}

	[Token(Token = "0x6016695")]
	[Address(RVA = "0x1B98FE0", Offset = "0x1B98FE0", VA = "0x1B98FE0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016696")]
	[Address(RVA = "0x1B9966C", Offset = "0x1B9966C", VA = "0x1B9966C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
