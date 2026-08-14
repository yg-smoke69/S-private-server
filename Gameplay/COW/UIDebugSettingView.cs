using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034BC")]
public class UIDebugSettingView : UIBaseView
{
	[Token(Token = "0x40149F9")]
	[FieldOffset(Offset = "0x14")]
	public UIToggle DebugUIOn;

	[Token(Token = "0x40149FA")]
	[FieldOffset(Offset = "0x18")]
	public UIToggle DebugUIOff;

	[Token(Token = "0x40149FB")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggle DebugInfoOn;

	[Token(Token = "0x40149FC")]
	[FieldOffset(Offset = "0x20")]
	public UIToggle DebugInfoOff;

	[Token(Token = "0x40149FD")]
	[FieldOffset(Offset = "0x24")]
	public GameObject LogLevel;

	[Token(Token = "0x40149FE")]
	[FieldOffset(Offset = "0x28")]
	public UIToggle LogLevelAll;

	[Token(Token = "0x40149FF")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggle LogLevelError;

	[Token(Token = "0x4014A00")]
	[FieldOffset(Offset = "0x30")]
	public UIToggle LogLevelNone;

	[Token(Token = "0x4014A01")]
	[FieldOffset(Offset = "0x34")]
	public GameObject PCHideContainer;

	[Token(Token = "0x4014A02")]
	[FieldOffset(Offset = "0x38")]
	public UICheckboxButton TestChangeClothCheckBox;

	[Token(Token = "0x4014A03")]
	[FieldOffset(Offset = "0x3C")]
	public UICheckboxButton TestAutoChangeClothCheckBox;

	[Token(Token = "0x4014A04")]
	[FieldOffset(Offset = "0x40")]
	public UIToggle RemoteConsoleOn;

	[Token(Token = "0x4014A05")]
	[FieldOffset(Offset = "0x44")]
	public GameObject RemoteConsoleInputContainer;

	[Token(Token = "0x4014A06")]
	[FieldOffset(Offset = "0x48")]
	public UIInput RemoteConsoleInput;

	[Token(Token = "0x4014A07")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton RemoteConsoleBtn;

	[Token(Token = "0x4014A08")]
	[FieldOffset(Offset = "0x50")]
	public UILabel RemoteConsoleBtnLabel;

	[Token(Token = "0x60161E8")]
	[Address(RVA = "0x2D81FF8", Offset = "0x2D81FF8", VA = "0x2D81FF8")]
	public UIDebugSettingView()
	{
	}

	[Token(Token = "0x60161E9")]
	[Address(RVA = "0x2D82000", Offset = "0x2D82000", VA = "0x2D82000", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161EA")]
	[Address(RVA = "0x2D82724", Offset = "0x2D82724", VA = "0x2D82724")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
