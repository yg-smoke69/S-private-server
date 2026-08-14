using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037AE")]
public class UIHUDUGC_TwoTeam_ShowTimeView : UIBaseView
{
	[Token(Token = "0x40168C0")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ScoreContainer;

	[Token(Token = "0x40168C1")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LeftTeamScore;

	[Token(Token = "0x40168C2")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LeftTeamIconOB;

	[Token(Token = "0x40168C3")]
	[FieldOffset(Offset = "0x20")]
	public UISprite LeftTeamIcon;

	[Token(Token = "0x40168C4")]
	[FieldOffset(Offset = "0x24")]
	public GameObject LeftTeamDefaultIconBG;

	[Token(Token = "0x40168C5")]
	[FieldOffset(Offset = "0x28")]
	public UILabel RightTeamScore;

	[Token(Token = "0x40168C6")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject RightTeamIconOB;

	[Token(Token = "0x40168C7")]
	[FieldOffset(Offset = "0x30")]
	public UISprite RightTeamIcon;

	[Token(Token = "0x40168C8")]
	[FieldOffset(Offset = "0x34")]
	public GameObject RightTeamDefaultIconBG;

	[Token(Token = "0x40168C9")]
	[FieldOffset(Offset = "0x38")]
	public GameObject BooyahContainer;

	[Token(Token = "0x40168CA")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject DefeatedContainer;

	[Token(Token = "0x40168CB")]
	[FieldOffset(Offset = "0x40")]
	public GameObject DrawContainer;

	[Token(Token = "0x40168CC")]
	[FieldOffset(Offset = "0x44")]
	public GameObject VictoryContainer;

	[Token(Token = "0x40168CD")]
	[FieldOffset(Offset = "0x48")]
	public UIButton ReturnBtn;

	[Token(Token = "0x40168CE")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel ReturnBtnContent;

	[Token(Token = "0x6016AB5")]
	[Address(RVA = "0x292FD74", Offset = "0x292FD74", VA = "0x292FD74")]
	public UIHUDUGC_TwoTeam_ShowTimeView()
	{
	}

	[Token(Token = "0x6016AB6")]
	[Address(RVA = "0x292FD7C", Offset = "0x292FD7C", VA = "0x292FD7C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AB7")]
	[Address(RVA = "0x29303F8", Offset = "0x29303F8", VA = "0x29303F8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
