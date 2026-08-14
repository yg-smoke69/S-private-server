using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003739")]
public class UIHudSceneEditOptionView : UIBaseView
{
	[Token(Token = "0x401651A")]
	[FieldOffset(Offset = "0x14")]
	public UITable BtnTable;

	[Token(Token = "0x401651B")]
	[FieldOffset(Offset = "0x18")]
	public UIButton GMVerifyBtn;

	[Token(Token = "0x401651C")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BackBtn;

	[Token(Token = "0x401651D")]
	[FieldOffset(Offset = "0x20")]
	public UIButton SaveSceneBtn;

	[Token(Token = "0x401651E")]
	[FieldOffset(Offset = "0x24")]
	public UIButton ChangeLookBtn;

	[Token(Token = "0x401651F")]
	[FieldOffset(Offset = "0x28")]
	public UIButton ChangeEditBtn;

	[Token(Token = "0x4016520")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton QuitPreviwtBtn;

	[Token(Token = "0x4016521")]
	[FieldOffset(Offset = "0x30")]
	public UIButton GoToMatchBtn;

	[Token(Token = "0x4016522")]
	[FieldOffset(Offset = "0x34")]
	public UIButton CollapseBtn;

	[Token(Token = "0x4016523")]
	[FieldOffset(Offset = "0x38")]
	public UIButton OpenConsoleBtn;

	[Token(Token = "0x4016524")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton ResMgrBtn;

	[Token(Token = "0x4016525")]
	[FieldOffset(Offset = "0x40")]
	public UISprite ResMgrIcon;

	[Token(Token = "0x4016526")]
	[FieldOffset(Offset = "0x44")]
	public UIButton ExpandBtn;

	[Token(Token = "0x4016527")]
	[FieldOffset(Offset = "0x48")]
	public UIButton PreviewModeBtn;

	[Token(Token = "0x6016956")]
	[Address(RVA = "0x24EC0DC", Offset = "0x24EC0DC", VA = "0x24EC0DC")]
	public UIHudSceneEditOptionView()
	{
	}

	[Token(Token = "0x6016957")]
	[Address(RVA = "0x24EC0E4", Offset = "0x24EC0E4", VA = "0x24EC0E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016958")]
	[Address(RVA = "0x24EC76C", Offset = "0x24EC76C", VA = "0x24EC76C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
