using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200396A")]
public class UIRoomPasswordConfirmView : UIBaseView
{
	[Token(Token = "0x40180A2")]
	[FieldOffset(Offset = "0x14")]
	public GameObject GroupNameGo;

	[Token(Token = "0x40180A3")]
	[FieldOffset(Offset = "0x18")]
	public UIInput GroupNameInput;

	[Token(Token = "0x40180A4")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput GroupNameAbbrInput;

	[Token(Token = "0x40180A5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PasswordGo;

	[Token(Token = "0x40180A6")]
	[FieldOffset(Offset = "0x24")]
	public UIInput PasswordInput;

	[Token(Token = "0x40180A7")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CancelBtn;

	[Token(Token = "0x40180A8")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x40180A9")]
	[FieldOffset(Offset = "0x30")]
	public UISprite BtnSprite;

	[Token(Token = "0x6016FE5")]
	[Address(RVA = "0x23D8FBC", Offset = "0x23D8FBC", VA = "0x23D8FBC")]
	public UIRoomPasswordConfirmView()
	{
	}

	[Token(Token = "0x6016FE6")]
	[Address(RVA = "0x23D8FC4", Offset = "0x23D8FC4", VA = "0x23D8FC4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FE7")]
	[Address(RVA = "0x23D93F4", Offset = "0x23D93F4", VA = "0x23D93F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
