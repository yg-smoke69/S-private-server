using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033AA")]
public class UIActivityFriendReunionTitleView : UIBaseView
{
	[Token(Token = "0x4013BAA")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIActivityFriendReunionTitle;

	[Token(Token = "0x4013BAB")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4013BAC")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton DetailButton;

	[Token(Token = "0x4013BAD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SelfLink;

	[Token(Token = "0x4013BAE")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Label;

	[Token(Token = "0x4013BAF")]
	[FieldOffset(Offset = "0x28")]
	public UIButton LinkButton;

	[Token(Token = "0x4013BB0")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton CallbackButton;

	[Token(Token = "0x4013BB1")]
	[FieldOffset(Offset = "0x30")]
	public UILabel BtnOperateLabelWhite;

	[Token(Token = "0x4013BB2")]
	[FieldOffset(Offset = "0x34")]
	public UISprite ReunionInviterItemBg;

	[Token(Token = "0x6015EB4")]
	[Address(RVA = "0x2FB56A4", Offset = "0x2FB56A4", VA = "0x2FB56A4")]
	public UIActivityFriendReunionTitleView()
	{
	}

	[Token(Token = "0x6015EB5")]
	[Address(RVA = "0x2FB56AC", Offset = "0x2FB56AC", VA = "0x2FB56AC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EB6")]
	[Address(RVA = "0x2FB5B48", Offset = "0x2FB5B48", VA = "0x2FB5B48")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
