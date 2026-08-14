using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034AA")]
public class UICupMatchTeamProfileView : UIBaseView
{
	[Token(Token = "0x40148F5")]
	[FieldOffset(Offset = "0x14")]
	public GameObject TeamOverview;

	[Token(Token = "0x40148F6")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid NewTeam;

	[Token(Token = "0x40148F7")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton CreateTeam;

	[Token(Token = "0x40148F8")]
	[FieldOffset(Offset = "0x20")]
	public UILabel CreateTeamLabel;

	[Token(Token = "0x40148F9")]
	[FieldOffset(Offset = "0x24")]
	public UIButton JoinTeam;

	[Token(Token = "0x40148FA")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Left;

	[Token(Token = "0x40148FB")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Info;

	[Token(Token = "0x40148FC")]
	[FieldOffset(Offset = "0x30")]
	public UILabel TeammateCntText;

	[Token(Token = "0x40148FD")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TeamId;

	[Token(Token = "0x40148FE")]
	[FieldOffset(Offset = "0x38")]
	public GameObject TeamIdTag;

	[Token(Token = "0x40148FF")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton TeamInfoRefresh;

	[Token(Token = "0x4014900")]
	[FieldOffset(Offset = "0x40")]
	public GameObject TeamInfoRefreshIcon;

	[Token(Token = "0x4014901")]
	[FieldOffset(Offset = "0x44")]
	public UICountDownLabel TeamInfoRefreshCD;

	[Token(Token = "0x4014902")]
	[FieldOffset(Offset = "0x48")]
	public UIEasyList InfoEasyList;

	[Token(Token = "0x4014903")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton Recruit;

	[Token(Token = "0x4014904")]
	[FieldOffset(Offset = "0x50")]
	public UIButton BtnApplyAndInvite;

	[Token(Token = "0x4014905")]
	[FieldOffset(Offset = "0x54")]
	public GameObject ApplyAndInviteRedPoint;

	[Token(Token = "0x4014906")]
	[FieldOffset(Offset = "0x58")]
	public UIButton BtnInvite;

	[Token(Token = "0x4014907")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject InviteRedPoint;

	[Token(Token = "0x4014908")]
	[FieldOffset(Offset = "0x60")]
	public UIButton BtnInviteNoTeam;

	[Token(Token = "0x4014909")]
	[FieldOffset(Offset = "0x64")]
	public GameObject InviteNoTeamRedPoint;

	[Token(Token = "0x401490A")]
	[FieldOffset(Offset = "0x68")]
	public GameObject NoTeamTips;

	[Token(Token = "0x401490B")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton Exit;

	[Token(Token = "0x401490C")]
	[FieldOffset(Offset = "0x70")]
	public GameObject TicketTips;

	[Token(Token = "0x401490D")]
	[FieldOffset(Offset = "0x74")]
	public UIButton RecruitBtn;

	[Token(Token = "0x401490E")]
	[FieldOffset(Offset = "0x78")]
	public UIWidget RecruitBtnWidget;

	[Token(Token = "0x60161B2")]
	[Address(RVA = "0x11E5E68", Offset = "0x11E5E68", VA = "0x11E5E68")]
	public UICupMatchTeamProfileView()
	{
	}

	[Token(Token = "0x60161B3")]
	[Address(RVA = "0x11E5E70", Offset = "0x11E5E70", VA = "0x11E5E70", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161B4")]
	[Address(RVA = "0x11E6900", Offset = "0x11E6900", VA = "0x11E6900")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
