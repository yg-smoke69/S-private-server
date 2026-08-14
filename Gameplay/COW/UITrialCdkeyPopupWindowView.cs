using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A10")]
public class UITrialCdkeyPopupWindowView : UIBaseView
{
	[Token(Token = "0x401883F")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelTip;

	[Token(Token = "0x4018840")]
	[FieldOffset(Offset = "0x18")]
	public UIInput InputCode;

	[Token(Token = "0x4018841")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnConfirm;

	[Token(Token = "0x60171D6")]
	[Address(RVA = "0x1C2F908", Offset = "0x1C2F908", VA = "0x1C2F908")]
	public UITrialCdkeyPopupWindowView()
	{
	}

	[Token(Token = "0x60171D7")]
	[Address(RVA = "0x1C2F910", Offset = "0x1C2F910", VA = "0x1C2F910", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171D8")]
	[Address(RVA = "0x1C2FB78", Offset = "0x1C2FB78", VA = "0x1C2FB78")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
