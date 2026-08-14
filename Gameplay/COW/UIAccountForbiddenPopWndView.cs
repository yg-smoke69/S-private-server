using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200339C")]
public class UIAccountForbiddenPopWndView : UIBaseView
{
	[Token(Token = "0x4013B10")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ForbiddenReasonTxt;

	[Token(Token = "0x4013B11")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4013B12")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton HelpBtn;

	[Token(Token = "0x4013B13")]
	[FieldOffset(Offset = "0x20")]
	public Transform CountDownContainer;

	[Token(Token = "0x6015E8A")]
	[Address(RVA = "0x29FE5DC", Offset = "0x29FE5DC", VA = "0x29FE5DC")]
	public UIAccountForbiddenPopWndView()
	{
	}

	[Token(Token = "0x6015E8B")]
	[Address(RVA = "0x29FE5E4", Offset = "0x29FE5E4", VA = "0x29FE5E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E8C")]
	[Address(RVA = "0x29FE884", Offset = "0x29FE884", VA = "0x29FE884")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
