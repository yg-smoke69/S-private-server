using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036AB")]
public class UIHudMatchResult2TeamsGridItemBombView : UIBaseView
{
	[Token(Token = "0x4016037")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Self;

	[Token(Token = "0x4016038")]
	[FieldOffset(Offset = "0x18")]
	public UIButton SimpleProfileInfo;

	[Token(Token = "0x4016039")]
	[FieldOffset(Offset = "0x1C")]
	public UIEffectSprite bannerBg;

	[Token(Token = "0x401603A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject fakeBg;

	[Token(Token = "0x401603B")]
	[FieldOffset(Offset = "0x24")]
	public UIEffectSprite HeadIcon;

	[Token(Token = "0x401603C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject infoContainer;

	[Token(Token = "0x401603D")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel nickname;

	[Token(Token = "0x401603E")]
	[FieldOffset(Offset = "0x30")]
	public UILabel clanName;

	[Token(Token = "0x401603F")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Kill;

	[Token(Token = "0x4016040")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Death;

	[Token(Token = "0x4016041")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Assist;

	[Token(Token = "0x4016042")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Damage;

	[Token(Token = "0x4016043")]
	[FieldOffset(Offset = "0x44")]
	public UILabel BD;

	[Token(Token = "0x4016044")]
	[FieldOffset(Offset = "0x48")]
	public UILabel BP;

	[Token(Token = "0x4016045")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel Evaluation;

	[Token(Token = "0x4016046")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Mvp;

	[Token(Token = "0x4016047")]
	[FieldOffset(Offset = "0x54")]
	public UIButton AddFriendBtn;

	[Token(Token = "0x60167AE")]
	[Address(RVA = "0x1001E98", Offset = "0x1001E98", VA = "0x1001E98")]
	public UIHudMatchResult2TeamsGridItemBombView()
	{
	}

	[Token(Token = "0x60167AF")]
	[Address(RVA = "0x1001EA0", Offset = "0x1001EA0", VA = "0x1001EA0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167B0")]
	[Address(RVA = "0x1002618", Offset = "0x1002618", VA = "0x1002618")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
