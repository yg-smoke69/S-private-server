using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039A1")]
public class UISceneEditUserAgreementView : UIBaseView
{
	[Token(Token = "0x40182B4")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnCancel;

	[Token(Token = "0x40182B5")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnApply;

	[Token(Token = "0x40182B6")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton JumpUrlLabel;

	[Token(Token = "0x601708A")]
	[Address(RVA = "0x1A42068", Offset = "0x1A42068", VA = "0x1A42068")]
	public UISceneEditUserAgreementView()
	{
	}

	[Token(Token = "0x601708B")]
	[Address(RVA = "0x1A42070", Offset = "0x1A42070", VA = "0x1A42070", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601708C")]
	[Address(RVA = "0x1A422D8", Offset = "0x1A422D8", VA = "0x1A422D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
