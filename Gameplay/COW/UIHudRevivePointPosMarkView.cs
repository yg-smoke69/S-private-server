using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003713")]
public class UIHudRevivePointPosMarkView : UIBaseView
{
	[Token(Token = "0x40163DE")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x40163DF")]
	[FieldOffset(Offset = "0x18")]
	public UISprite ProgressBg;

	[Token(Token = "0x40163E0")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel PointStatusLabel;

	[Token(Token = "0x40163E1")]
	[FieldOffset(Offset = "0x20")]
	public UISprite StateIcon;

	[Token(Token = "0x40163E2")]
	[FieldOffset(Offset = "0x24")]
	public UISprite StateBg;

	[Token(Token = "0x40163E3")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Timer;

	[Token(Token = "0x40163E4")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel DistanceLabel;

	[Token(Token = "0x60168E4")]
	[Address(RVA = "0x13FA2E0", Offset = "0x13FA2E0", VA = "0x13FA2E0")]
	public UIHudRevivePointPosMarkView()
	{
	}

	[Token(Token = "0x60168E5")]
	[Address(RVA = "0x13FA2E8", Offset = "0x13FA2E8", VA = "0x13FA2E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168E6")]
	[Address(RVA = "0x13FA6C4", Offset = "0x13FA6C4", VA = "0x13FA6C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
