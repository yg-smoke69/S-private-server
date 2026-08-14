using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002090")]
public class UICupMatchTeamProfileSelfController : UICupMatchTeamProfileController, _Attribute
{
	[Token(Token = "0x400CC1C")]
	[FieldOffset(Offset = "0x44")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CC1D")]
	[FieldOffset(Offset = "0x48")]
	private UICupMatchMemberReviewPopupController m_MemberReviewPopupCtrl;

	[Token(Token = "0x400CC1E")]
	[FieldOffset(Offset = "0x4C")]
	public Action SignUpPopupWndCancelAction;

	[Token(Token = "0x600A7A2")]
	[Address(RVA = "0x11E1CD0", Offset = "0x11E1CD0", VA = "0x11E1CD0")]
	public UICupMatchTeamProfileSelfController()
	{
	}

	[Token(Token = "0x600A7A3")]
	[Address(RVA = "0x11E1CD4", Offset = "0x11E1CD4", VA = "0x11E1CD4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A7A4")]
	[Address(RVA = "0x11E1D28", Offset = "0x11E1D28", VA = "0x11E1D28", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A7A5")]
	[Address(RVA = "0x11E22B4", Offset = "0x11E22B4", VA = "0x11E22B4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A7A6")]
	[Address(RVA = "0x11E233C", Offset = "0x11E233C", VA = "0x11E233C")]
	public void SetViewData(int cupMatchKey)
	{
	}

	[Token(Token = "0x600A7A7")]
	[Address(RVA = "0x11E25C4", Offset = "0x11E25C4", VA = "0x11E25C4")]
	public void UpdateTeamInfoView()
	{
	}

	[Token(Token = "0x600A7A8")]
	[Address(RVA = "0x11E31F8", Offset = "0x11E31F8", VA = "0x11E31F8")]
	public void UpdateTeamMemberView()
	{
	}

	[Token(Token = "0x600A7A9")]
	[Address(RVA = "0x11E313C", Offset = "0x11E313C", VA = "0x11E313C")]
	private void UpdateTicketInfo()
	{
	}

	[Token(Token = "0x600A7AA")]
	[Address(RVA = "0x11E37AC", Offset = "0x11E37AC", VA = "0x11E37AC")]
	private void ShowCreateTeamGuide()
	{
	}

	[Token(Token = "0x600A7AB")]
	[Address(RVA = "0x11E367C", Offset = "0x11E367C", VA = "0x11E367C")]
	private void UpdateInvitationRedTips()
	{
	}

	[Token(Token = "0x600A7AC")]
	[Address(RVA = "0x11E35B8", Offset = "0x11E35B8", VA = "0x11E35B8")]
	private void UpdateApplicationRedTips()
	{
	}

	[Token(Token = "0x600A7AD")]
	[Address(RVA = "0x11E3A14", Offset = "0x11E3A14", VA = "0x11E3A14")]
	private void OnExitTeam()
	{
	}

	[Token(Token = "0x600A7AE")]
	[Address(RVA = "0x11E4228", Offset = "0x11E4228", VA = "0x11E4228")]
	private void OnCreateTeamClick()
	{
	}

	[Token(Token = "0x600A7AF")]
	[Address(RVA = "0x11E451C", Offset = "0x11E451C", VA = "0x11E451C")]
	private void OnBtnChatRecruitClick()
	{
	}

	[Token(Token = "0x600A7B0")]
	[Address(RVA = "0x11E4628", Offset = "0x11E4628", VA = "0x11E4628")]
	private void OnJoinTeamClick()
	{
	}

	[Token(Token = "0x600A7B1")]
	[Address(RVA = "0x11E48C0", Offset = "0x11E48C0", VA = "0x11E48C0")]
	private void OnRecruit()
	{
	}

	[Token(Token = "0x600A7B2")]
	[Address(RVA = "0x11E49F8", Offset = "0x11E49F8", VA = "0x11E49F8")]
	private void OnTeamInfoRefresh()
	{
	}

	[Token(Token = "0x600A7B3")]
	[Address(RVA = "0x11E23D0", Offset = "0x11E23D0", VA = "0x11E23D0")]
	private void RequestData()
	{
	}

	[Token(Token = "0x600A7B4")]
	[Address(RVA = "0x11E4E18", Offset = "0x11E4E18", VA = "0x11E4E18", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A7B5")]
	[Address(RVA = "0x11E590C", Offset = "0x11E590C", VA = "0x11E590C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A7B6")]
	[Address(RVA = "0x11E59A4", Offset = "0x11E59A4", VA = "0x11E59A4")]
	public void ShowMembers()
	{
	}

	[Token(Token = "0x600A7B7")]
	[Address(RVA = "0x11E5A04", Offset = "0x11E5A04", VA = "0x11E5A04")]
	private void ShowInvite()
	{
	}

	[Token(Token = "0x600A7B8")]
	[Address(RVA = "0x11E5B68", Offset = "0x11E5B68", VA = "0x11E5B68")]
	private void ShowApplyAndInvite()
	{
	}

	[Token(Token = "0x600A7B9")]
	[Address(RVA = "0x11E5CC4", Offset = "0x11E5CC4", VA = "0x11E5CC4")]
	private void _003COnExitTeam_003Em__0()
	{
	}

	[Token(Token = "0x600A7BA")]
	[Address(RVA = "0x11E5D84", Offset = "0x11E5D84", VA = "0x11E5D84")]
	private void _003COnTeamInfoRefresh_003Em__1()
	{
	}

	[Token(Token = "0x600A7BB")]
	[Address(RVA = "0x11E5E5C", Offset = "0x11E5E5C", VA = "0x11E5E5C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A7BC")]
	[Address(RVA = "0x11E5E60", Offset = "0x11E5E60", VA = "0x11E5E60")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
