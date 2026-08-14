using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038FD")]
public class UIPayResultPopupWindowView : UIBaseView
{
	[Token(Token = "0x4017AFC")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel MainWidget;

	[Token(Token = "0x4017AFD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BtnCloseGO;

	[Token(Token = "0x4017AFE")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnClose;

	[Token(Token = "0x4017AFF")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Title;

	[Token(Token = "0x4017B00")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BtnCancelGO;

	[Token(Token = "0x4017B01")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnCancel;

	[Token(Token = "0x4017B02")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite BtnCancelSprite;

	[Token(Token = "0x4017B03")]
	[FieldOffset(Offset = "0x30")]
	public UILabel BtnCancelLabel;

	[Token(Token = "0x4017B04")]
	[FieldOffset(Offset = "0x34")]
	public GameObject BtnOKGO;

	[Token(Token = "0x4017B05")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnOK;

	[Token(Token = "0x4017B06")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite BtnOKSprite;

	[Token(Token = "0x4017B07")]
	[FieldOffset(Offset = "0x40")]
	public UILabel BtnOKLabel;

	[Token(Token = "0x4017B08")]
	[FieldOffset(Offset = "0x44")]
	public UISprite TextArea;

	[Token(Token = "0x4017B09")]
	[FieldOffset(Offset = "0x48")]
	public UITextList Info;

	[Token(Token = "0x4017B0A")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel Note;

	[Token(Token = "0x6016EA0")]
	[Address(RVA = "0x15B7978", Offset = "0x15B7978", VA = "0x15B7978")]
	public UIPayResultPopupWindowView()
	{
	}

	[Token(Token = "0x6016EA1")]
	[Address(RVA = "0x15B7980", Offset = "0x15B7980", VA = "0x15B7980", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EA2")]
	[Address(RVA = "0x15B8044", Offset = "0x15B8044", VA = "0x15B8044")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
