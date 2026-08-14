using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003453")]
public class UIClanMatchResultPopupView : UIBaseView
{
	[Token(Token = "0x40144CD")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BGTexture;

	[Token(Token = "0x40144CE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject OtherBGTexture;

	[Token(Token = "0x40144CF")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnConfirm;

	[Token(Token = "0x40144D0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Content;

	[Token(Token = "0x40144D1")]
	[FieldOffset(Offset = "0x24")]
	public UILabel OtherClanName;

	[Token(Token = "0x40144D2")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ClanAvatar;

	[Token(Token = "0x40144D3")]
	[FieldOffset(Offset = "0x2C")]
	public UICenterTargetHelper CenterHelper;

	[Token(Token = "0x40144D4")]
	[FieldOffset(Offset = "0x30")]
	public UISprite NationIcon;

	[Token(Token = "0x40144D5")]
	[FieldOffset(Offset = "0x34")]
	public UILabel ClanName;

	[Token(Token = "0x40144D6")]
	[FieldOffset(Offset = "0x38")]
	public UILabel TotalScAdd;

	[Token(Token = "0x40144D7")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel KillNumAdd;

	[Token(Token = "0x40144D8")]
	[FieldOffset(Offset = "0x40")]
	public UILabel DamageNumAdd;

	[Token(Token = "0x40144D9")]
	[FieldOffset(Offset = "0x44")]
	public UILabel RankScAdd;

	[Token(Token = "0x40144DA")]
	[FieldOffset(Offset = "0x48")]
	public UILabel BattleScAdd;

	[Token(Token = "0x40144DB")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel ServivedLabel;

	[Token(Token = "0x40144DC")]
	[FieldOffset(Offset = "0x50")]
	public UILabel SurviveTimeAdd;

	[Token(Token = "0x40144DD")]
	[FieldOffset(Offset = "0x54")]
	public GameObject SeasonIcon;

	[Token(Token = "0x40144DE")]
	[FieldOffset(Offset = "0x58")]
	public GameObject OtherIcons;

	[Token(Token = "0x40144DF")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject ThirdPartyIcon;

	[Token(Token = "0x40144E0")]
	[FieldOffset(Offset = "0x60")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x40144E1")]
	[FieldOffset(Offset = "0x64")]
	public UILabel ModeName;

	[Token(Token = "0x60160AD")]
	[Address(RVA = "0x2B3C274", Offset = "0x2B3C274", VA = "0x2B3C274")]
	public UIClanMatchResultPopupView()
	{
	}

	[Token(Token = "0x60160AE")]
	[Address(RVA = "0x2B3C27C", Offset = "0x2B3C27C", VA = "0x2B3C27C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160AF")]
	[Address(RVA = "0x2B3CB5C", Offset = "0x2B3CB5C", VA = "0x2B3CB5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
