using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038B4")]
public class UIModifyClanNameView : UIBaseView
{
	[Token(Token = "0x4017741")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4017742")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelCurrentName;

	[Token(Token = "0x4017743")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput InputNewName;

	[Token(Token = "0x4017744")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelPrice;

	[Token(Token = "0x4017745")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnConfirm;

	[Token(Token = "0x4017746")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ConfirmBtnBg;

	[Token(Token = "0x6016DC7")]
	[Address(RVA = "0x194C390", Offset = "0x194C390", VA = "0x194C390")]
	public UIModifyClanNameView()
	{
	}

	[Token(Token = "0x6016DC8")]
	[Address(RVA = "0x194C398", Offset = "0x194C398", VA = "0x194C398", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DC9")]
	[Address(RVA = "0x194C720", Offset = "0x194C720", VA = "0x194C720")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
