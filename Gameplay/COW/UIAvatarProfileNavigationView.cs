using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033D5")]
public class UIAvatarProfileNavigationView : UIBaseView
{
	[Token(Token = "0x4013DAD")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel UIAvatarProfileNavigation;

	[Token(Token = "0x4013DAE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject tweenNodeBtn;

	[Token(Token = "0x4013DAF")]
	[FieldOffset(Offset = "0x1C")]
	public UITable AvatarTableGroup;

	[Token(Token = "0x4013DB0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GainAvatar;

	[Token(Token = "0x4013DB1")]
	[FieldOffset(Offset = "0x24")]
	public UIButton GainAvatarBtn;

	[Token(Token = "0x4013DB2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ExpireInfo;

	[Token(Token = "0x4013DB3")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel ExpireTime;

	[Token(Token = "0x4013DB4")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ExpireState1;

	[Token(Token = "0x4013DB5")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ExpireState2;

	[Token(Token = "0x4013DB6")]
	[FieldOffset(Offset = "0x38")]
	public UIButton InUseSelectBtn1;

	[Token(Token = "0x4013DB7")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Inuse;

	[Token(Token = "0x4013DB8")]
	[FieldOffset(Offset = "0x40")]
	public GameObject InuseState1;

	[Token(Token = "0x4013DB9")]
	[FieldOffset(Offset = "0x44")]
	public GameObject InuseState2;

	[Token(Token = "0x4013DBA")]
	[FieldOffset(Offset = "0x48")]
	public UIButton InUseSelectBtn;

	[Token(Token = "0x4013DBB")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject TopContainer;

	[Token(Token = "0x4013DBC")]
	[FieldOffset(Offset = "0x50")]
	public UIButton VaultBtn;

	[Token(Token = "0x4013DBD")]
	[FieldOffset(Offset = "0x54")]
	public Transform RecommendTr;

	[Token(Token = "0x4013DBE")]
	[FieldOffset(Offset = "0x58")]
	public Transform LeftContainer;

	[Token(Token = "0x4013DBF")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject LinkNoSelected;

	[Token(Token = "0x4013DC0")]
	[FieldOffset(Offset = "0x60")]
	public GameObject LinkSelected;

	[Token(Token = "0x4013DC1")]
	[FieldOffset(Offset = "0x64")]
	public UICountDownLabel LabelDate;

	[Token(Token = "0x4013DC2")]
	[FieldOffset(Offset = "0x68")]
	public GameObject CountDown;

	[Token(Token = "0x4013DC3")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite CharacterSprite;

	[Token(Token = "0x4013DC4")]
	[FieldOffset(Offset = "0x70")]
	public UILabel Progress;

	[Token(Token = "0x4013DC5")]
	[FieldOffset(Offset = "0x74")]
	public UIButton LinkBtn;

	[Token(Token = "0x4013DC6")]
	[FieldOffset(Offset = "0x78")]
	public GameObject LinkEntrance;

	[Token(Token = "0x4013DC7")]
	[FieldOffset(Offset = "0x7C")]
	public UISprite bar;

	[Token(Token = "0x4013DC8")]
	[FieldOffset(Offset = "0x80")]
	public GameObject AvatarLinkObtain;

	[Token(Token = "0x4013DC9")]
	[FieldOffset(Offset = "0x84")]
	public UIButton GotoLinkBtn;

	[Token(Token = "0x4013DCA")]
	[FieldOffset(Offset = "0x88")]
	public GameObject GainLabel;

	[Token(Token = "0x4013DCB")]
	[FieldOffset(Offset = "0x8C")]
	public UISprite LinkBtnSprite;

	[Token(Token = "0x6015F35")]
	[Address(RVA = "0x2F8E654", Offset = "0x2F8E654", VA = "0x2F8E654")]
	public UIAvatarProfileNavigationView()
	{
	}

	[Token(Token = "0x6015F36")]
	[Address(RVA = "0x2F8E65C", Offset = "0x2F8E65C", VA = "0x2F8E65C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F37")]
	[Address(RVA = "0x2F8F240", Offset = "0x2F8F240", VA = "0x2F8F240")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
