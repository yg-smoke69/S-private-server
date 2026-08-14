using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003423")]
public class UIChampionshipTeamProfileView : UIBaseView
{
	[Token(Token = "0x4014232")]
	[FieldOffset(Offset = "0x14")]
	public GameObject TeamOverview;

	[Token(Token = "0x4014233")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid NewTeam;

	[Token(Token = "0x4014234")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton CreateTeam;

	[Token(Token = "0x4014235")]
	[FieldOffset(Offset = "0x20")]
	public UILabel CreateTeamLabel;

	[Token(Token = "0x4014236")]
	[FieldOffset(Offset = "0x24")]
	public UIButton JoinTeam;

	[Token(Token = "0x4014237")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Left;

	[Token(Token = "0x4014238")]
	[FieldOffset(Offset = "0x2C")]
	public UIMenu Menu;

	[Token(Token = "0x4014239")]
	[FieldOffset(Offset = "0x30")]
	public UILabel MenuLabelSelect;

	[Token(Token = "0x401423A")]
	[FieldOffset(Offset = "0x34")]
	public UILabel MenuLabelUnSelect;

	[Token(Token = "0x401423B")]
	[FieldOffset(Offset = "0x38")]
	public UITipsButton RedPoint;

	[Token(Token = "0x401423C")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Info;

	[Token(Token = "0x401423D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel TeammateCntText;

	[Token(Token = "0x401423E")]
	[FieldOffset(Offset = "0x44")]
	public UIButton TeamInfoRefresh;

	[Token(Token = "0x401423F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject TeamInfoRefreshIcon;

	[Token(Token = "0x4014240")]
	[FieldOffset(Offset = "0x4C")]
	public UICountDownLabel TeamInfoRefreshCD;

	[Token(Token = "0x4014241")]
	[FieldOffset(Offset = "0x50")]
	public UIEasyList InfoEasyList;

	[Token(Token = "0x4014242")]
	[FieldOffset(Offset = "0x54")]
	public UIButton Recruit;

	[Token(Token = "0x4014243")]
	[FieldOffset(Offset = "0x58")]
	public UIButton BtnApplyAndInvite;

	[Token(Token = "0x4014244")]
	[FieldOffset(Offset = "0x5C")]
	public UITipsButton ApplyAndInviteRedPoint;

	[Token(Token = "0x4014245")]
	[FieldOffset(Offset = "0x60")]
	public UIButton BtnInvite;

	[Token(Token = "0x4014246")]
	[FieldOffset(Offset = "0x64")]
	public UITipsButton InviteRedPoint;

	[Token(Token = "0x4014247")]
	[FieldOffset(Offset = "0x68")]
	public UIButton BtnInviteNoTeam;

	[Token(Token = "0x4014248")]
	[FieldOffset(Offset = "0x6C")]
	public UITipsButton InviteNoTeamRedPoint;

	[Token(Token = "0x4014249")]
	[FieldOffset(Offset = "0x70")]
	public GameObject NoTeamTips;

	[Token(Token = "0x401424A")]
	[FieldOffset(Offset = "0x74")]
	public GameObject Record;

	[Token(Token = "0x401424B")]
	[FieldOffset(Offset = "0x78")]
	public UIEasyList RecoardEasyList;

	[Token(Token = "0x401424C")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton RecordDetail;

	[Token(Token = "0x401424D")]
	[FieldOffset(Offset = "0x80")]
	public GameObject RecordNoData;

	[Token(Token = "0x401424E")]
	[FieldOffset(Offset = "0x84")]
	public GameObject RecordNoTeam;

	[Token(Token = "0x401424F")]
	[FieldOffset(Offset = "0x88")]
	public UILabel RecordTips;

	[Token(Token = "0x4014250")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton Exit;

	[Token(Token = "0x4014251")]
	[FieldOffset(Offset = "0x90")]
	public UIButton ChampionshipRecruitBtn;

	[Token(Token = "0x601601D")]
	[Address(RVA = "0x2621248", Offset = "0x2621248", VA = "0x2621248")]
	public UIChampionshipTeamProfileView()
	{
	}

	[Token(Token = "0x601601E")]
	[Address(RVA = "0x2621250", Offset = "0x2621250", VA = "0x2621250", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601601F")]
	[Address(RVA = "0x2621F38", Offset = "0x2621F38", VA = "0x2621F38")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
