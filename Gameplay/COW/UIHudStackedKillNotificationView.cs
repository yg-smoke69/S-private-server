using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200375C")]
public class UIHudStackedKillNotificationView : UIBaseView
{
	[Token(Token = "0x4016671")]
	[FieldOffset(Offset = "0x14")]
	public Animator StackKillAnimator;

	[Token(Token = "0x4016672")]
	[FieldOffset(Offset = "0x18")]
	public GameObject StackKill;

	[Token(Token = "0x4016673")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ChangableBG;

	[Token(Token = "0x4016674")]
	[FieldOffset(Offset = "0x20")]
	public GameObject FirstBlood;

	[Token(Token = "0x4016675")]
	[FieldOffset(Offset = "0x24")]
	public GameObject DoubleKill;

	[Token(Token = "0x4016676")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TripleKill;

	[Token(Token = "0x4016677")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject QuadraKill;

	[Token(Token = "0x4016678")]
	[FieldOffset(Offset = "0x30")]
	public UILabel KillCountLabel_1;

	[Token(Token = "0x4016679")]
	[FieldOffset(Offset = "0x34")]
	public UILabel KillCountLabel_2;

	[Token(Token = "0x401667A")]
	[FieldOffset(Offset = "0x38")]
	public UISprite KillHead;

	[Token(Token = "0x401667B")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel content;

	[Token(Token = "0x401667C")]
	[FieldOffset(Offset = "0x40")]
	public UISprite KillerNameBG;

	[Token(Token = "0x401667D")]
	[FieldOffset(Offset = "0x44")]
	public UISprite KillTypeIcon;

	[Token(Token = "0x401667E")]
	[FieldOffset(Offset = "0x48")]
	public UISprite KillerNameBGWithIcon;

	[Token(Token = "0x401667F")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject styleBlue;

	[Token(Token = "0x4016680")]
	[FieldOffset(Offset = "0x50")]
	public UISprite StyleBlueBg;

	[Token(Token = "0x4016681")]
	[FieldOffset(Offset = "0x54")]
	public GameObject styleRed;

	[Token(Token = "0x4016682")]
	[FieldOffset(Offset = "0x58")]
	public UISprite StyleRedBg;

	[Token(Token = "0x4016683")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject AceEffect;

	[Token(Token = "0x4016684")]
	[FieldOffset(Offset = "0x60")]
	public Transform TrStyleMulKill;

	[Token(Token = "0x4016685")]
	[FieldOffset(Offset = "0x64")]
	public GameObject UIHudStackedKillNotification;

	[Token(Token = "0x4016686")]
	[FieldOffset(Offset = "0x68")]
	public UILabel KillCount;

	[Token(Token = "0x4016687")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite NoChangeBG;

	[Token(Token = "0x60169BF")]
	[Address(RVA = "0x1FEDCEC", Offset = "0x1FEDCEC", VA = "0x1FEDCEC")]
	public UIHudStackedKillNotificationView()
	{
	}

	[Token(Token = "0x60169C0")]
	[Address(RVA = "0x1FEDCF4", Offset = "0x1FEDCF4", VA = "0x1FEDCF4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169C1")]
	[Address(RVA = "0x1FEE648", Offset = "0x1FEE648", VA = "0x1FEE648")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
