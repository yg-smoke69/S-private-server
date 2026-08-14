using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003422")]
public class UIChampionshipTeamOverviewView : UIBaseView
{
	[Token(Token = "0x401421D")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;

	[Token(Token = "0x401421E")]
	[FieldOffset(Offset = "0x18")]
	public UISprite TeamIcon;

	[Token(Token = "0x401421F")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton TeamIconBtn;

	[Token(Token = "0x4014220")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TeamName;

	[Token(Token = "0x4014221")]
	[FieldOffset(Offset = "0x24")]
	public GameObject FlagBg;

	[Token(Token = "0x4014222")]
	[FieldOffset(Offset = "0x28")]
	public UISprite NationFlag;

	[Token(Token = "0x4014223")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton InfoEdit;

	[Token(Token = "0x4014224")]
	[FieldOffset(Offset = "0x30")]
	public UIButton InfoEdit_bg;

	[Token(Token = "0x4014225")]
	[FieldOffset(Offset = "0x34")]
	public GameObject RankNomal;

	[Token(Token = "0x4014226")]
	[FieldOffset(Offset = "0x38")]
	public UILabel RankValue;

	[Token(Token = "0x4014227")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite RankTop3;

	[Token(Token = "0x4014228")]
	[FieldOffset(Offset = "0x40")]
	public UITable TeamInfoTable;

	[Token(Token = "0x4014229")]
	[FieldOffset(Offset = "0x44")]
	public UILabel TeamID;

	[Token(Token = "0x401422A")]
	[FieldOffset(Offset = "0x48")]
	public GameObject MemberCount;

	[Token(Token = "0x401422B")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel TeamMemberCount;

	[Token(Token = "0x401422C")]
	[FieldOffset(Offset = "0x50")]
	public GameObject TopCup;

	[Token(Token = "0x401422D")]
	[FieldOffset(Offset = "0x54")]
	public GameObject NoTeamIcon;

	[Token(Token = "0x401422E")]
	[FieldOffset(Offset = "0x58")]
	public GameObject Solo;

	[Token(Token = "0x401422F")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject Double;

	[Token(Token = "0x4014230")]
	[FieldOffset(Offset = "0x60")]
	public GameObject Four;

	[Token(Token = "0x4014231")]
	[FieldOffset(Offset = "0x64")]
	public GameObject TopThreeEffect;

	[Token(Token = "0x601601A")]
	[Address(RVA = "0x261A20C", Offset = "0x261A20C", VA = "0x261A20C")]
	public UIChampionshipTeamOverviewView()
	{
	}

	[Token(Token = "0x601601B")]
	[Address(RVA = "0x261A214", Offset = "0x261A214", VA = "0x261A214", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601601C")]
	[Address(RVA = "0x261AAC4", Offset = "0x261AAC4", VA = "0x261AAC4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
