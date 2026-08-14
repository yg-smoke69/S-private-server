using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200202D")]
public class UIChampionshipTeamProfileSelfController : UIChampionshipTeamProfileController, _Attribute
{
	[Token(Token = "0x400C9FE")]
	private const string TabApply = "TabApply";

	[Token(Token = "0x400C9FF")]
	private const string TabInvite = "TabInvite";

	[Token(Token = "0x400CA00")]
	[FieldOffset(Offset = "0x44")]
	private UIChampionshipTeamProfileView m_View;

	[Token(Token = "0x400CA01")]
	[FieldOffset(Offset = "0x48")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400CA02")]
	[FieldOffset(Offset = "0x4C")]
	private StandardTabItemViewData m_SelectedTab;

	[Token(Token = "0x400CA03")]
	[FieldOffset(Offset = "0x50")]
	private UIChampionshipMemberReviewPopupController m_MemberReviewPopupCtrl;

	[Token(Token = "0x400CA04")]
	[FieldOffset(Offset = "0x54")]
	public Action SignUpPopupWndCancelAction;

	[Token(Token = "0x600A332")]
	[Address(RVA = "0x261D3D8", Offset = "0x261D3D8", VA = "0x261D3D8")]
	public UIChampionshipTeamProfileSelfController()
	{
	}

	[Token(Token = "0x600A333")]
	[Address(RVA = "0x261D3DC", Offset = "0x261D3DC", VA = "0x261D3DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A334")]
	[Address(RVA = "0x261D430", Offset = "0x261D430", VA = "0x261D430", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A335")]
	[Address(RVA = "0x261DD00", Offset = "0x261DD00", VA = "0x261DD00", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A336")]
	[Address(RVA = "0x261DD88", Offset = "0x261DD88", VA = "0x261DD88")]
	public void SetViewData(uint championshipType)
	{
	}

	[Token(Token = "0x600A337")]
	[Address(RVA = "0x261DDF4", Offset = "0x261DDF4", VA = "0x261DDF4")]
	public void UpdateTeamInfoView()
	{
	}

	[Token(Token = "0x600A338")]
	[Address(RVA = "0x261E99C", Offset = "0x261E99C", VA = "0x261E99C")]
	public void UpdateTeamMemberView()
	{
	}

	[Token(Token = "0x600A339")]
	[Address(RVA = "0x261ED70", Offset = "0x261ED70", VA = "0x261ED70")]
	private void OnExitTeam()
	{
	}

	[Token(Token = "0x600A33A")]
	[Address(RVA = "0x261F184", Offset = "0x261F184", VA = "0x261F184")]
	private void OnCreateTeamClick()
	{
	}

	[Token(Token = "0x600A33B")]
	[Address(RVA = "0x261F544", Offset = "0x261F544", VA = "0x261F544")]
	private void OnBtnChatRecruitClick()
	{
	}

	[Token(Token = "0x600A33C")]
	[Address(RVA = "0x261F650", Offset = "0x261F650", VA = "0x261F650")]
	private void OnJoinTeamOnlick()
	{
	}

	[Token(Token = "0x600A33D")]
	[Address(RVA = "0x261F8E4", Offset = "0x261F8E4", VA = "0x261F8E4")]
	private void OnRecruit()
	{
	}

	[Token(Token = "0x600A33E")]
	[Address(RVA = "0x261F9F4", Offset = "0x261F9F4", VA = "0x261F9F4")]
	private void OnRecourdDetail()
	{
	}

	[Token(Token = "0x600A33F")]
	[Address(RVA = "0x261FB98", Offset = "0x261FB98", VA = "0x261FB98")]
	private void OnTeamInfoRefresh()
	{
	}

	[Token(Token = "0x600A340")]
	[Address(RVA = "0x261DA8C", Offset = "0x261DA8C", VA = "0x261DA8C")]
	private void RequestData()
	{
	}

	[Token(Token = "0x600A341")]
	[Address(RVA = "0x261FFA8", Offset = "0x261FFA8", VA = "0x261FFA8", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A342")]
	[Address(RVA = "0x2620B00", Offset = "0x2620B00", VA = "0x2620B00", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A343")]
	[Address(RVA = "0x2620B98", Offset = "0x2620B98", VA = "0x2620B98")]
	public void ShowMembers()
	{
	}

	[Token(Token = "0x600A344")]
	[Address(RVA = "0x2620C04", Offset = "0x2620C04", VA = "0x2620C04")]
	public void ShowRecord()
	{
	}

	[Token(Token = "0x600A345")]
	[Address(RVA = "0x2620CD4", Offset = "0x2620CD4", VA = "0x2620CD4")]
	private void ShowInvite()
	{
	}

	[Token(Token = "0x600A346")]
	[Address(RVA = "0x2620E10", Offset = "0x2620E10", VA = "0x2620E10")]
	private void ShowApplyAndInvite()
	{
	}

	[Token(Token = "0x600A347")]
	[Address(RVA = "0x2620F6C", Offset = "0x2620F6C", VA = "0x2620F6C")]
	public void ShowCreateTeamWnd()
	{
	}

	[Token(Token = "0x600A348")]
	[Address(RVA = "0x26210B8", Offset = "0x26210B8", VA = "0x26210B8")]
	private void _003COnExitTeam_003Em__0()
	{
	}

	[Token(Token = "0x600A349")]
	[Address(RVA = "0x2621164", Offset = "0x2621164", VA = "0x2621164")]
	private void _003COnTeamInfoRefresh_003Em__1()
	{
	}

	[Token(Token = "0x600A34A")]
	[Address(RVA = "0x262123C", Offset = "0x262123C", VA = "0x262123C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A34B")]
	[Address(RVA = "0x2621240", Offset = "0x2621240", VA = "0x2621240")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
