using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200369B")]
public class UIHUDLudoGameInfoView : UIBaseView
{
	[Token(Token = "0x4015F8A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Random;

	[Token(Token = "0x4015F8B")]
	[FieldOffset(Offset = "0x18")]
	public UIButton RandomBtn;

	[Token(Token = "0x4015F8C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject HideRandom;

	[Token(Token = "0x4015F8D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject TrustRandom;

	[Token(Token = "0x4015F8E")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Trust;

	[Token(Token = "0x4015F8F")]
	[FieldOffset(Offset = "0x28")]
	public UIButton TrustBtn;

	[Token(Token = "0x4015F90")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton ManualBtn;

	[Token(Token = "0x4015F91")]
	[FieldOffset(Offset = "0x30")]
	public Transform PlayerItemInfo1;

	[Token(Token = "0x4015F92")]
	[FieldOffset(Offset = "0x34")]
	public Transform PlayerItemInfo2;

	[Token(Token = "0x4015F93")]
	[FieldOffset(Offset = "0x38")]
	public Transform PlayerItemInfo3;

	[Token(Token = "0x4015F94")]
	[FieldOffset(Offset = "0x3C")]
	public Transform PlayerItemInfo4;

	[Token(Token = "0x601677E")]
	[Address(RVA = "0x167DF78", Offset = "0x167DF78", VA = "0x167DF78")]
	public UIHUDLudoGameInfoView()
	{
	}

	[Token(Token = "0x601677F")]
	[Address(RVA = "0x167DF80", Offset = "0x167DF80", VA = "0x167DF80", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016780")]
	[Address(RVA = "0x167E418", Offset = "0x167E418", VA = "0x167E418")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
