using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038DB")]
public class UIOBSettingView : UIBaseView
{
	[Token(Token = "0x4017958")]
	[FieldOffset(Offset = "0x14")]
	public UIToggleButtonGroup DelayOBEnabled;

	[Token(Token = "0x4017959")]
	[FieldOffset(Offset = "0x18")]
	public UIToggleButton DelayOBOn;

	[Token(Token = "0x401795A")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton DelayOBOff;

	[Token(Token = "0x401795B")]
	[FieldOffset(Offset = "0x20")]
	public UIToggleButtonGroup ReplayEnabled;

	[Token(Token = "0x401795C")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton ReplayOn;

	[Token(Token = "0x401795D")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButton ReplayOff;

	[Token(Token = "0x401795E")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButtonGroup PlayerSightEnabled;

	[Token(Token = "0x401795F")]
	[FieldOffset(Offset = "0x30")]
	public UIToggleButton PlayerSightOn;

	[Token(Token = "0x4017960")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButton PlayerSightOff;

	[Token(Token = "0x4017961")]
	[FieldOffset(Offset = "0x38")]
	public UIToggleButtonGroup PerspectiveColoring;

	[Token(Token = "0x4017962")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggleButton StuffedColor;

	[Token(Token = "0x4017963")]
	[FieldOffset(Offset = "0x40")]
	public UIToggleButton HollowColor;

	[Token(Token = "0x4017964")]
	[FieldOffset(Offset = "0x44")]
	public UIToggleButtonGroup FrameLimit;

	[Token(Token = "0x4017965")]
	[FieldOffset(Offset = "0x48")]
	public UIToggleButton UnlimitFrame;

	[Token(Token = "0x4017966")]
	[FieldOffset(Offset = "0x4C")]
	public UIToggleButton LimitedFrame;

	[Token(Token = "0x4017967")]
	[FieldOffset(Offset = "0x50")]
	public UIToggleButtonGroup ErrorTipsEnabled;

	[Token(Token = "0x4017968")]
	[FieldOffset(Offset = "0x54")]
	public UIToggleButton ErrorTipsOn;

	[Token(Token = "0x4017969")]
	[FieldOffset(Offset = "0x58")]
	public UIToggleButton ErrorTipsOff;

	[Token(Token = "0x401796A")]
	[FieldOffset(Offset = "0x5C")]
	public UIToggleButtonGroup PerspectiveType;

	[Token(Token = "0x401796B")]
	[FieldOffset(Offset = "0x60")]
	public UIToggleButton NormalMode;

	[Token(Token = "0x401796C")]
	[FieldOffset(Offset = "0x64")]
	public UIToggleButton TeamMode;

	[Token(Token = "0x401796D")]
	[FieldOffset(Offset = "0x68")]
	public UIToggleButtonGroup OpeningCamEnabled;

	[Token(Token = "0x401796E")]
	[FieldOffset(Offset = "0x6C")]
	public UIToggleButton OpeningCamOn;

	[Token(Token = "0x401796F")]
	[FieldOffset(Offset = "0x70")]
	public UIToggleButton OpeningCamOff;

	[Token(Token = "0x4017970")]
	[FieldOffset(Offset = "0x74")]
	public UIToggleButtonGroup TeamBillboard;

	[Token(Token = "0x4017971")]
	[FieldOffset(Offset = "0x78")]
	public UIToggleButton TeamBillboardOn;

	[Token(Token = "0x4017972")]
	[FieldOffset(Offset = "0x7C")]
	public UIToggleButton TeamBillboardOff;

	[Token(Token = "0x4017973")]
	[FieldOffset(Offset = "0x80")]
	public UIToggleButtonGroup SpHudCsPlayerInfoEnabled;

	[Token(Token = "0x4017974")]
	[FieldOffset(Offset = "0x84")]
	public UIToggleButton SpHudCsPlayerInfoOn;

	[Token(Token = "0x4017975")]
	[FieldOffset(Offset = "0x88")]
	public UIToggleButton SpHudCsPlayerInfoOff;

	[Token(Token = "0x4017976")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel MatchIDTxt;

	[Token(Token = "0x4017977")]
	[FieldOffset(Offset = "0x90")]
	public UILabel cameraSpeedText;

	[Token(Token = "0x4017978")]
	[FieldOffset(Offset = "0x94")]
	public UILabel cameraRotateSpeedText;

	[Token(Token = "0x6016E3A")]
	[Address(RVA = "0x159CD78", Offset = "0x159CD78", VA = "0x159CD78")]
	public UIOBSettingView()
	{
	}

	[Token(Token = "0x6016E3B")]
	[Address(RVA = "0x159CD80", Offset = "0x159CD80", VA = "0x159CD80", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E3C")]
	[Address(RVA = "0x159DB28", Offset = "0x159DB28", VA = "0x159DB28")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
