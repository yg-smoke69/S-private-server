using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200372D")]
public class UIHudSceneEditGroupModifyView : UIBaseView
{
	[Token(Token = "0x40164D3")]
	[FieldOffset(Offset = "0x14")]
	public UIButton AddGroup;

	[Token(Token = "0x40164D4")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnDelete;

	[Token(Token = "0x40164D5")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton GroupConfirmBtn;

	[Token(Token = "0x40164D6")]
	[FieldOffset(Offset = "0x20")]
	public UISprite AddGroupIcon;

	[Token(Token = "0x40164D7")]
	[FieldOffset(Offset = "0x24")]
	public UISprite GroupConfirmIcon;

	[Token(Token = "0x6016932")]
	[Address(RVA = "0x24D4234", Offset = "0x24D4234", VA = "0x24D4234")]
	public UIHudSceneEditGroupModifyView()
	{
	}

	[Token(Token = "0x6016933")]
	[Address(RVA = "0x24D423C", Offset = "0x24D423C", VA = "0x24D423C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016934")]
	[Address(RVA = "0x24D4564", Offset = "0x24D4564", VA = "0x24D4564")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
