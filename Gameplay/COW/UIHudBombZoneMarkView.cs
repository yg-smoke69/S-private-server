using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035F4")]
public class UIHudBombZoneMarkView : UIBaseView
{
	[Token(Token = "0x40159A6")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BombFg;

	[Token(Token = "0x40159A7")]
	[FieldOffset(Offset = "0x18")]
	public UISprite RemoveBombFg;

	[Token(Token = "0x40159A8")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject BombBg;

	[Token(Token = "0x40159A9")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ZoneIDLabel;

	[Token(Token = "0x40159AA")]
	[FieldOffset(Offset = "0x24")]
	public UISprite ArrowLeft;

	[Token(Token = "0x40159AB")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ArrowUp;

	[Token(Token = "0x40159AC")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ArrowDown;

	[Token(Token = "0x40159AD")]
	[FieldOffset(Offset = "0x30")]
	public UISprite ArrowRight;

	[Token(Token = "0x40159AE")]
	[FieldOffset(Offset = "0x34")]
	public UILabel DistanceLabel;

	[Token(Token = "0x40159AF")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget boundWidget;

	[Token(Token = "0x601658A")]
	[Address(RVA = "0x1E15118", Offset = "0x1E15118", VA = "0x1E15118")]
	public UIHudBombZoneMarkView()
	{
	}

	[Token(Token = "0x601658B")]
	[Address(RVA = "0x1E15120", Offset = "0x1E15120", VA = "0x1E15120", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601658C")]
	[Address(RVA = "0x1E1561C", Offset = "0x1E1561C", VA = "0x1E1561C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
