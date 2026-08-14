using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039DC")]
public class UISPHudTeamMatchResultView : UIBaseView
{
	[Token(Token = "0x401858A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BG;

	[Token(Token = "0x401858B")]
	[FieldOffset(Offset = "0x18")]
	public UITexture LocalBG;

	[Token(Token = "0x401858C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel MatchModeTxt;

	[Token(Token = "0x401858D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel MatchMapTxt;

	[Token(Token = "0x401858E")]
	[FieldOffset(Offset = "0x24")]
	public UIEasyList ResultListGrid;

	[Token(Token = "0x401858F")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Result;

	[Token(Token = "0x4018590")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton NextBtn;

	[Token(Token = "0x4018591")]
	[FieldOffset(Offset = "0x30")]
	public UIButton DetailsBtn;

	[Token(Token = "0x4018592")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Top1;

	[Token(Token = "0x4018593")]
	[FieldOffset(Offset = "0x38")]
	public UISprite Top1FakeIcon;

	[Token(Token = "0x4018594")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite Top1TeamIcon;

	[Token(Token = "0x4018595")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Top1ScoreLabel;

	[Token(Token = "0x4018596")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Top1KillCountLabel;

	[Token(Token = "0x4018597")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Top1TeamName;

	[Token(Token = "0x4018598")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Top2;

	[Token(Token = "0x4018599")]
	[FieldOffset(Offset = "0x50")]
	public UISprite Top2TeamIcon;

	[Token(Token = "0x401859A")]
	[FieldOffset(Offset = "0x54")]
	public UISprite Top2FakeIcon;

	[Token(Token = "0x401859B")]
	[FieldOffset(Offset = "0x58")]
	public UILabel Top2ScoreLabel;

	[Token(Token = "0x401859C")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel Top2KillCountLabel;

	[Token(Token = "0x401859D")]
	[FieldOffset(Offset = "0x60")]
	public UILabel Top2TeamName;

	[Token(Token = "0x401859E")]
	[FieldOffset(Offset = "0x64")]
	public GameObject Top3;

	[Token(Token = "0x401859F")]
	[FieldOffset(Offset = "0x68")]
	public UISprite Top3FakeIcon;

	[Token(Token = "0x40185A0")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite Top3TeamIcon;

	[Token(Token = "0x40185A1")]
	[FieldOffset(Offset = "0x70")]
	public UILabel Top3ScoreLabel;

	[Token(Token = "0x40185A2")]
	[FieldOffset(Offset = "0x74")]
	public UILabel Top3KillCountLabel;

	[Token(Token = "0x40185A3")]
	[FieldOffset(Offset = "0x78")]
	public UILabel Top3TeamName;

	[Token(Token = "0x601713A")]
	[Address(RVA = "0x1497DE0", Offset = "0x1497DE0", VA = "0x1497DE0")]
	public UISPHudTeamMatchResultView()
	{
	}

	[Token(Token = "0x601713B")]
	[Address(RVA = "0x1497DE8", Offset = "0x1497DE8", VA = "0x1497DE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601713C")]
	[Address(RVA = "0x14986D0", Offset = "0x14986D0", VA = "0x14986D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
