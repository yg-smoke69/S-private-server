using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033E1")]
public class UIAwakenRefreshTaskConfirmWndView : UIBaseView
{
	[Token(Token = "0x4013EDE")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CancelBtn;

	[Token(Token = "0x4013EDF")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4013EE0")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Label;

	[Token(Token = "0x6015F59")]
	[Address(RVA = "0x13FF52C", Offset = "0x13FF52C", VA = "0x13FF52C")]
	public UIAwakenRefreshTaskConfirmWndView()
	{
	}

	[Token(Token = "0x6015F5A")]
	[Address(RVA = "0x13FF534", Offset = "0x13FF534", VA = "0x13FF534", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F5B")]
	[Address(RVA = "0x13FF79C", Offset = "0x13FF79C", VA = "0x13FF79C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
