using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200339D")]
public class UIAccountIDNickNameLoginWindowView : UIBaseView
{
	[Token(Token = "0x4013B14")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4013B15")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelTitle;

	[Token(Token = "0x4013B16")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelNewNameTitle;

	[Token(Token = "0x4013B17")]
	[FieldOffset(Offset = "0x20")]
	public UIInput InputNewName;

	[Token(Token = "0x4013B18")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelPrice;

	[Token(Token = "0x4013B19")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnConfirm;

	[Token(Token = "0x4013B1A")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ConfirmBtnBg;

	[Token(Token = "0x4013B1B")]
	[FieldOffset(Offset = "0x30")]
	public Transform ServerListNode;

	[Token(Token = "0x6015E8D")]
	[Address(RVA = "0x29FE88C", Offset = "0x29FE88C", VA = "0x29FE88C")]
	public UIAccountIDNickNameLoginWindowView()
	{
	}

	[Token(Token = "0x6015E8E")]
	[Address(RVA = "0x29FE894", Offset = "0x29FE894", VA = "0x29FE894", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E8F")]
	[Address(RVA = "0x29FECB4", Offset = "0x29FECB4", VA = "0x29FECB4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
