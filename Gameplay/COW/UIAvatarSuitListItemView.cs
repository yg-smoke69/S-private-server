using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033DB")]
public class UIAvatarSuitListItemView : UIBaseView
{
	[Token(Token = "0x4013EBF")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Download;

	[Token(Token = "0x4013EC0")]
	[FieldOffset(Offset = "0x18")]
	public UIButton SuitBtn;

	[Token(Token = "0x4013EC1")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SuitSprite;

	[Token(Token = "0x4013EC2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HL;

	[Token(Token = "0x4013EC3")]
	[FieldOffset(Offset = "0x24")]
	public UILabel SuitNameLabel;

	[Token(Token = "0x4013EC4")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ownStateLabel;

	[Token(Token = "0x4013EC5")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton equipBtn;

	[Token(Token = "0x4013EC6")]
	[FieldOffset(Offset = "0x30")]
	public UIButton obtainBtn;

	[Token(Token = "0x6015F47")]
	[Address(RVA = "0x2FA46EC", Offset = "0x2FA46EC", VA = "0x2FA46EC")]
	public UIAvatarSuitListItemView()
	{
	}

	[Token(Token = "0x6015F48")]
	[Address(RVA = "0x2FA46F4", Offset = "0x2FA46F4", VA = "0x2FA46F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F49")]
	[Address(RVA = "0x2FA4B30", Offset = "0x2FA4B30", VA = "0x2FA4B30")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
