using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200377F")]
public class UIHudTrainingVehicleSpeedActionView : UIBaseView
{
	[Token(Token = "0x40167E1")]
	[FieldOffset(Offset = "0x14")]
	public UIButton btn;

	[Token(Token = "0x40167E2")]
	[FieldOffset(Offset = "0x18")]
	public UISprite icon;

	[Token(Token = "0x40167E3")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite normal;

	[Token(Token = "0x40167E4")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ActionNameTxt;

	[Token(Token = "0x6016A28")]
	[Address(RVA = "0x1586420", Offset = "0x1586420", VA = "0x1586420")]
	public UIHudTrainingVehicleSpeedActionView()
	{
	}

	[Token(Token = "0x6016A29")]
	[Address(RVA = "0x1586428", Offset = "0x1586428", VA = "0x1586428", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A2A")]
	[Address(RVA = "0x15866F0", Offset = "0x15866F0", VA = "0x15866F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
