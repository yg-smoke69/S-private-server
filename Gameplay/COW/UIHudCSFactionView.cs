using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200361F")]
public class UIHudCSFactionView : UIBaseView
{
	[Token(Token = "0x4015AAB")]
	[FieldOffset(Offset = "0x14")]
	public UILabel taskDesc;

	[Token(Token = "0x4015AAC")]
	[FieldOffset(Offset = "0x18")]
	public UILabel myTeamName;

	[Token(Token = "0x4015AAD")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel myTeamDesc;

	[Token(Token = "0x4015AAE")]
	[FieldOffset(Offset = "0x20")]
	public UISprite myTeamIcon;

	[Token(Token = "0x4015AAF")]
	[FieldOffset(Offset = "0x24")]
	public UISprite myDefaultTeamIcon;

	[Token(Token = "0x4015AB0")]
	[FieldOffset(Offset = "0x28")]
	public UILabel oppoTeamName;

	[Token(Token = "0x4015AB1")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel oppoTeamDesc;

	[Token(Token = "0x4015AB2")]
	[FieldOffset(Offset = "0x30")]
	public UISprite oppoTeamIcon;

	[Token(Token = "0x4015AB3")]
	[FieldOffset(Offset = "0x34")]
	public UISprite oppoDefaultTeamIcon;

	[Token(Token = "0x4015AB4")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Icon_B;

	[Token(Token = "0x4015AB5")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Icon_O;

	[Token(Token = "0x4015AB6")]
	[FieldOffset(Offset = "0x40")]
	public UISprite Icon_attack;

	[Token(Token = "0x4015AB7")]
	[FieldOffset(Offset = "0x44")]
	public UISprite Icon_def;

	[Token(Token = "0x4015AB8")]
	[FieldOffset(Offset = "0x48")]
	public GameObject blackBg;

	[Token(Token = "0x4015AB9")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite taskIcon;

	[Token(Token = "0x4015ABA")]
	[FieldOffset(Offset = "0x50")]
	public GameObject taskDescbg;

	[Token(Token = "0x4015ABB")]
	[FieldOffset(Offset = "0x54")]
	public Animator UIHudCSFaction;

	[Token(Token = "0x601660C")]
	[Address(RVA = "0x1F08650", Offset = "0x1F08650", VA = "0x1F08650")]
	public UIHudCSFactionView()
	{
	}

	[Token(Token = "0x601660D")]
	[Address(RVA = "0x1F08658", Offset = "0x1F08658", VA = "0x1F08658", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601660E")]
	[Address(RVA = "0x1F08DD0", Offset = "0x1F08DD0", VA = "0x1F08DD0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
