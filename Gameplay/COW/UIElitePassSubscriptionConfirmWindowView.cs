using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200350C")]
public class UIElitePassSubscriptionConfirmWindowView : UIBaseView
{
	[Token(Token = "0x4014ED5")]
	[FieldOffset(Offset = "0x14")]
	public GameObject line;

	[Token(Token = "0x4014ED6")]
	[FieldOffset(Offset = "0x18")]
	public BaseItemView BaseItemView;

	[Token(Token = "0x4014ED7")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel MainTextLabel;

	[Token(Token = "0x4014ED8")]
	[FieldOffset(Offset = "0x20")]
	public UILabel AutoRenewalLabel;

	[Token(Token = "0x4014ED9")]
	[FieldOffset(Offset = "0x24")]
	public UILabel QuitSubscriptionLabel;

	[Token(Token = "0x4014EDA")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CancelBtn;

	[Token(Token = "0x4014EDB")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x60162D4")]
	[Address(RVA = "0x3067748", Offset = "0x3067748", VA = "0x3067748")]
	public UIElitePassSubscriptionConfirmWindowView()
	{
	}

	[Token(Token = "0x60162D5")]
	[Address(RVA = "0x3067750", Offset = "0x3067750", VA = "0x3067750", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162D6")]
	[Address(RVA = "0x3067B2C", Offset = "0x3067B2C", VA = "0x3067B2C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
