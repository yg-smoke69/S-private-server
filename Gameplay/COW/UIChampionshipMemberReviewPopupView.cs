using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003413")]
public class UIChampionshipMemberReviewPopupView : UIBaseView
{
	[Token(Token = "0x40141BB")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Tabs;

	[Token(Token = "0x40141BC")]
	[FieldOffset(Offset = "0x18")]
	public UITable Btns;

	[Token(Token = "0x40141BD")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton BtnApply;

	[Token(Token = "0x40141BE")]
	[FieldOffset(Offset = "0x20")]
	public UITipsButton ApplyTipsBtn;

	[Token(Token = "0x40141BF")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton BtnInvite;

	[Token(Token = "0x40141C0")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelUnSelect;

	[Token(Token = "0x40141C1")]
	[FieldOffset(Offset = "0x2C")]
	public UITipsButton InviteTipsBtn;

	[Token(Token = "0x40141C2")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Apply;

	[Token(Token = "0x40141C3")]
	[FieldOffset(Offset = "0x34")]
	public UIEasyList ApplyEasyList;

	[Token(Token = "0x40141C4")]
	[FieldOffset(Offset = "0x38")]
	public UIButton RejectAll;

	[Token(Token = "0x40141C5")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ApplyNoData;

	[Token(Token = "0x40141C6")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Invite;

	[Token(Token = "0x40141C7")]
	[FieldOffset(Offset = "0x44")]
	public UIEasyList InviteEasyList;

	[Token(Token = "0x40141C8")]
	[FieldOffset(Offset = "0x48")]
	public UIButton RejectAllInvite;

	[Token(Token = "0x40141C9")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject InviteNoData;

	[Token(Token = "0x6015FED")]
	[Address(RVA = "0x2832DD0", Offset = "0x2832DD0", VA = "0x2832DD0")]
	public UIChampionshipMemberReviewPopupView()
	{
	}

	[Token(Token = "0x6015FEE")]
	[Address(RVA = "0x2832DD8", Offset = "0x2832DD8", VA = "0x2832DD8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FEF")]
	[Address(RVA = "0x2833484", Offset = "0x2833484", VA = "0x2833484")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
