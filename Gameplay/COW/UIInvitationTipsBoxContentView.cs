using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003801")]
public class UIInvitationTipsBoxContentView : UIBaseView
{
	[Token(Token = "0x4016C02")]
	[FieldOffset(Offset = "0x14")]
	public Animation AnimationUIInvitationTipsBoxContent;

	[Token(Token = "0x4016C03")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel UIPanelUIInvitationTipsBoxContent;

	[Token(Token = "0x4016C04")]
	[FieldOffset(Offset = "0x1C")]
	public AnimEvtForwarderIncludeParam AnimEvtForwarderIncludeParamUIInvitationTipsBoxContent;

	[Token(Token = "0x4016C05")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ChangeImage;

	[Token(Token = "0x4016C06")]
	[FieldOffset(Offset = "0x24")]
	public UIToggle IgnoreToggle;

	[Token(Token = "0x4016C07")]
	[FieldOffset(Offset = "0x28")]
	public UILabel IgnoreLabel;

	[Token(Token = "0x4016C08")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject InviteRoot;

	[Token(Token = "0x4016C09")]
	[FieldOffset(Offset = "0x30")]
	public UISprite InviteFromBG;

	[Token(Token = "0x4016C0A")]
	[FieldOffset(Offset = "0x34")]
	public UILabel InviteFrom;

	[Token(Token = "0x4016C0B")]
	[FieldOffset(Offset = "0x38")]
	public UISprite TimeCircle;

	[Token(Token = "0x4016C0C")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel TimeLabel;

	[Token(Token = "0x4016C0D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel TipsTypeLabel;

	[Token(Token = "0x4016C0E")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnClose;

	[Token(Token = "0x4016C0F")]
	[FieldOffset(Offset = "0x48")]
	public UISprite Sprite;

	[Token(Token = "0x4016C10")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel MessageLabel;

	[Token(Token = "0x4016C11")]
	[FieldOffset(Offset = "0x50")]
	public UIButton NameButton;

	[Token(Token = "0x4016C12")]
	[FieldOffset(Offset = "0x54")]
	public UILabel MessageLabel2;

	[Token(Token = "0x4016C13")]
	[FieldOffset(Offset = "0x58")]
	public UIButton AcceptBtn;

	[Token(Token = "0x4016C14")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton RejectBtn;

	[Token(Token = "0x4016C15")]
	[FieldOffset(Offset = "0x60")]
	public UILabel TeamInfoLabel;

	[Token(Token = "0x4016C16")]
	[FieldOffset(Offset = "0x64")]
	public GameObject Mask;

	[Token(Token = "0x4016C17")]
	[FieldOffset(Offset = "0x68")]
	public GameObject CupRankIcon;

	[Token(Token = "0x4016C18")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel CupRankTierLabel;

	[Token(Token = "0x6016BAE")]
	[Address(RVA = "0x1296818", Offset = "0x1296818", VA = "0x1296818")]
	public UIInvitationTipsBoxContentView()
	{
	}

	[Token(Token = "0x6016BAF")]
	[Address(RVA = "0x1296820", Offset = "0x1296820", VA = "0x1296820", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BB0")]
	[Address(RVA = "0x12971E4", Offset = "0x12971E4", VA = "0x12971E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
