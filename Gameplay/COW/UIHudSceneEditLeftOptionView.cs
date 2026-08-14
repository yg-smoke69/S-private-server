using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003732")]
public class UIHudSceneEditLeftOptionView : UIBaseView
{
	[Token(Token = "0x40164F5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton MoreSettingBtn;

	[Token(Token = "0x40164F6")]
	[FieldOffset(Offset = "0x18")]
	public UIButton RevertBtn;

	[Token(Token = "0x40164F7")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite RevertBtnIcon;

	[Token(Token = "0x40164F8")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ExtendBtn;

	[Token(Token = "0x40164F9")]
	[FieldOffset(Offset = "0x24")]
	public UISprite ExtendBtnIcon;

	[Token(Token = "0x40164FA")]
	[FieldOffset(Offset = "0x28")]
	public UIButton SwitchSigh;

	[Token(Token = "0x40164FB")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SwitchSighIcon;

	[Token(Token = "0x40164FC")]
	[FieldOffset(Offset = "0x30")]
	public UIButton OpenHudEditorBtn;

	[Token(Token = "0x6016941")]
	[Address(RVA = "0x24DEC50", Offset = "0x24DEC50", VA = "0x24DEC50")]
	public UIHudSceneEditLeftOptionView()
	{
	}

	[Token(Token = "0x6016942")]
	[Address(RVA = "0x24DEC58", Offset = "0x24DEC58", VA = "0x24DEC58", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016943")]
	[Address(RVA = "0x24DF0A0", Offset = "0x24DF0A0", VA = "0x24DF0A0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
