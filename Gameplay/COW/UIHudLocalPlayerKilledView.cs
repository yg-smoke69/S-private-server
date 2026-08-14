using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003694")]
public class UIHudLocalPlayerKilledView : UIBaseView
{
	[Token(Token = "0x4015F61")]
	[FieldOffset(Offset = "0x14")]
	public UISprite MaskBG;

	[Token(Token = "0x4015F62")]
	[FieldOffset(Offset = "0x18")]
	public UILabel KillMsg;

	[Token(Token = "0x4015F63")]
	[FieldOffset(Offset = "0x1C")]
	public Animation KillInfoContainer;

	[Token(Token = "0x4015F64")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ProfileContainer;

	[Token(Token = "0x4015F65")]
	[FieldOffset(Offset = "0x24")]
	public UILabel killerMsg;

	[Token(Token = "0x4015F66")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NormalContainer;

	[Token(Token = "0x4015F67")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel NormalName;

	[Token(Token = "0x6016769")]
	[Address(RVA = "0xFEDC38", Offset = "0xFEDC38", VA = "0xFEDC38")]
	public UIHudLocalPlayerKilledView()
	{
	}

	[Token(Token = "0x601676A")]
	[Address(RVA = "0xFEDC40", Offset = "0xFEDC40", VA = "0xFEDC40", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601676B")]
	[Address(RVA = "0xFEE010", Offset = "0xFEE010", VA = "0xFEE010")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
