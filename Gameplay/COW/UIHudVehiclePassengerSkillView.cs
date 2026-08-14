using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037C5")]
public class UIHudVehiclePassengerSkillView : UIBaseView
{
	[Token(Token = "0x4016975")]
	[FieldOffset(Offset = "0x14")]
	public UIButton btn;

	[Token(Token = "0x4016976")]
	[FieldOffset(Offset = "0x18")]
	public UISprite normal;

	[Token(Token = "0x4016977")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite icon;

	[Token(Token = "0x4016978")]
	[FieldOffset(Offset = "0x20")]
	public TweenFill cooldown;

	[Token(Token = "0x6016AFA")]
	[Address(RVA = "0x1A6F638", Offset = "0x1A6F638", VA = "0x1A6F638")]
	public UIHudVehiclePassengerSkillView()
	{
	}

	[Token(Token = "0x6016AFB")]
	[Address(RVA = "0x1A6F640", Offset = "0x1A6F640", VA = "0x1A6F640", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AFC")]
	[Address(RVA = "0x1A6F908", Offset = "0x1A6F908", VA = "0x1A6F908")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
