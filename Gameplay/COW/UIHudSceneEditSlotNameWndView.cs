using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200373E")]
public class UIHudSceneEditSlotNameWndView : UIBaseView
{
	[Token(Token = "0x401657D")]
	[FieldOffset(Offset = "0x14")]
	public UILabel CurrentNameTxt;

	[Token(Token = "0x401657E")]
	[FieldOffset(Offset = "0x18")]
	public UIInput NewNameInputTxt;

	[Token(Token = "0x401657F")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnCancel;

	[Token(Token = "0x4016580")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnApply;

	[Token(Token = "0x6016965")]
	[Address(RVA = "0x16B75C4", Offset = "0x16B75C4", VA = "0x16B75C4")]
	public UIHudSceneEditSlotNameWndView()
	{
	}

	[Token(Token = "0x6016966")]
	[Address(RVA = "0x16B75CC", Offset = "0x16B75CC", VA = "0x16B75CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016967")]
	[Address(RVA = "0x16B7894", Offset = "0x16B7894", VA = "0x16B7894")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
