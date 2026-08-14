using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200202C")]
public class UIChampionshipTeamProfileOtherController : UIChampionshipTeamProfileController, _Attribute
{
	[Token(Token = "0x400C9F8")]
	[FieldOffset(Offset = "0x44")]
	private UIChampionshipTeamProfileView m_View;

	[Token(Token = "0x400C9F9")]
	[FieldOffset(Offset = "0x48")]
	private ulong m_TeamID;

	[Token(Token = "0x400C9FA")]
	[FieldOffset(Offset = "0x50")]
	private TeamInfo m_TeamInfo;

	[Token(Token = "0x400C9FB")]
	[FieldOffset(Offset = "0x54")]
	private TeamMemberListWithAccountInfo m_TeamMemberInfo;

	[Token(Token = "0x400C9FC")]
	[FieldOffset(Offset = "0x58")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C9FD")]
	[FieldOffset(Offset = "0x5C")]
	private CSTeamMatchStatsHistoryRes m_TeamMatchStatsHisotryRes;

	[Token(Token = "0x600A322")]
	[Address(RVA = "0x261C214", Offset = "0x261C214", VA = "0x261C214")]
	public UIChampionshipTeamProfileOtherController()
	{
	}

	[Token(Token = "0x600A323")]
	[Address(RVA = "0x261C218", Offset = "0x261C218", VA = "0x261C218")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A324")]
	[Address(RVA = "0x261C26C", Offset = "0x261C26C", VA = "0x261C26C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A325")]
	[Address(RVA = "0x261C518", Offset = "0x261C518", VA = "0x261C518", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A326")]
	[Address(RVA = "0x261C5A0", Offset = "0x261C5A0", VA = "0x261C5A0")]
	public void SetViewData(uint championshipType, uint teamID)
	{
	}

	[Token(Token = "0x600A327")]
	[Address(RVA = "0x261C704", Offset = "0x261C704", VA = "0x261C704")]
	private void UpdateTeamInfoView()
	{
	}

	[Token(Token = "0x600A328")]
	[Address(RVA = "0x261C798", Offset = "0x261C798", VA = "0x261C798")]
	private void UpdateTeamMemberView()
	{
	}

	[Token(Token = "0x600A329")]
	[Address(RVA = "0x261CB2C", Offset = "0x261CB2C", VA = "0x261CB2C")]
	public void SetBtnStatus()
	{
	}

	[Token(Token = "0x600A32A")]
	[Address(RVA = "0x261CC8C", Offset = "0x261CC8C", VA = "0x261CC8C")]
	public void ShowMembers()
	{
	}

	[Token(Token = "0x600A32B")]
	[Address(RVA = "0x261CD1C", Offset = "0x261CD1C", VA = "0x261CD1C")]
	public void ShowRecord()
	{
	}

	[Token(Token = "0x600A32C")]
	[Address(RVA = "0x261CE7C", Offset = "0x261CE7C", VA = "0x261CE7C")]
	private void RecordDetail()
	{
	}

	[Token(Token = "0x600A32D")]
	[Address(RVA = "0x261C62C", Offset = "0x261C62C", VA = "0x261C62C")]
	private void RequestData()
	{
	}

	[Token(Token = "0x600A32E")]
	[Address(RVA = "0x261D018", Offset = "0x261D018", VA = "0x261D018", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A32F")]
	[Address(RVA = "0x261D334", Offset = "0x261D334", VA = "0x261D334", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A330")]
	[Address(RVA = "0x261D3CC", Offset = "0x261D3CC", VA = "0x261D3CC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A331")]
	[Address(RVA = "0x261D3D0", Offset = "0x261D3D0", VA = "0x261D3D0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
