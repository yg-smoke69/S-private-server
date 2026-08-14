using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034A7")]
public class UICupMatchTeamJoinView : UIBaseView
{
	[Token(Token = "0x40148D7")]
	[FieldOffset(Offset = "0x14")]
	public UIInput SearchInput;

	[Token(Token = "0x40148D8")]
	[FieldOffset(Offset = "0x18")]
	public UIButton SearchButton;

	[Token(Token = "0x40148D9")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ResetButton;

	[Token(Token = "0x40148DA")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList TeamList;

	[Token(Token = "0x40148DB")]
	[FieldOffset(Offset = "0x24")]
	public GameObject EmptyTips;

	[Token(Token = "0x40148DC")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Refresh;

	[Token(Token = "0x40148DD")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject RefreshIcon;

	[Token(Token = "0x40148DE")]
	[FieldOffset(Offset = "0x30")]
	public UICountDownLabel CountDownLabel;

	[Token(Token = "0x60161A9")]
	[Address(RVA = "0x11DBD40", Offset = "0x11DBD40", VA = "0x11DBD40")]
	public UICupMatchTeamJoinView()
	{
	}

	[Token(Token = "0x60161AA")]
	[Address(RVA = "0x11DBD48", Offset = "0x11DBD48", VA = "0x11DBD48", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161AB")]
	[Address(RVA = "0x11DC178", Offset = "0x11DC178", VA = "0x11DC178")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
