using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003467")]
public class UIClanWarRankItemView : UIBaseView
{
	[Token(Token = "0x40145BF")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Bg;

	[Token(Token = "0x40145C0")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Bg01;

	[Token(Token = "0x40145C1")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject PersonRobbed;

	[Token(Token = "0x40145C2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BaseProfile;

	[Token(Token = "0x40145C3")]
	[FieldOffset(Offset = "0x24")]
	public UILabel PersonKill;

	[Token(Token = "0x40145C4")]
	[FieldOffset(Offset = "0x28")]
	public UILabel PersonScore;

	[Token(Token = "0x40145C5")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject TeamRobbed;

	[Token(Token = "0x40145C6")]
	[FieldOffset(Offset = "0x30")]
	public UISprite TeamLogo;

	[Token(Token = "0x40145C7")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TeamName;

	[Token(Token = "0x40145C8")]
	[FieldOffset(Offset = "0x38")]
	public UILabel TeamScore;

	[Token(Token = "0x40145C9")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Rank;

	[Token(Token = "0x40145CA")]
	[FieldOffset(Offset = "0x40")]
	public UILabel RankLabel;

	[Token(Token = "0x40145CB")]
	[FieldOffset(Offset = "0x44")]
	public UISprite CupIcon;

	[Token(Token = "0x40145CC")]
	[FieldOffset(Offset = "0x48")]
	public UISprite CupIconTop;

	[Token(Token = "0x40145CD")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite HighLight;

	[Token(Token = "0x60160E9")]
	[Address(RVA = "0x2907B74", Offset = "0x2907B74", VA = "0x2907B74")]
	public UIClanWarRankItemView()
	{
	}

	[Token(Token = "0x60160EA")]
	[Address(RVA = "0x2907B7C", Offset = "0x2907B7C", VA = "0x2907B7C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160EB")]
	[Address(RVA = "0x2908234", Offset = "0x2908234", VA = "0x2908234")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
