using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x20026B5")]
internal class UIGroupInviteItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x20026B6")]
	public enum GroupInviteUI
	{
		[Token(Token = "0x400EEDD")]
		Group,
		[Token(Token = "0x400EEDE")]
		Room
	}

	[Token(Token = "0x400EECD")]
	[FieldOffset(Offset = "0x38")]
	private UIGroupInviteItemView m_View;

	[Token(Token = "0x400EECE")]
	[FieldOffset(Offset = "0x3C")]
	public GroupInviteMemberType InviteType;

	[Token(Token = "0x400EECF")]
	[FieldOffset(Offset = "0x40")]
	public int ItemIdex;

	[Token(Token = "0x400EED0")]
	[FieldOffset(Offset = "0x44")]
	private object m_Data;

	[Token(Token = "0x400EED1")]
	[FieldOffset(Offset = "0x48")]
	private GroupInviteUI m_InviteUI;

	[Token(Token = "0x400EED2")]
	[FieldOffset(Offset = "0x4C")]
	private ClanMember clanMemberInfo;

	[Token(Token = "0x400EED3")]
	[FieldOffset(Offset = "0x50")]
	private FriendAccountInfo friendInfo;

	[Token(Token = "0x400EED4")]
	[FieldOffset(Offset = "0x54")]
	private TeamMemberWithAccountInfo teamMemberInfo;

	[Token(Token = "0x400EED5")]
	[FieldOffset(Offset = "0x58")]
	private UIModelCupMatch.AccountInfoBasicWithCupInfo cupMatchTeamMemberInfo;

	[Token(Token = "0x400EED6")]
	[FieldOffset(Offset = "0x60")]
	private ulong m_AccountId;

	[Token(Token = "0x400EED7")]
	[FieldOffset(Offset = "0x68")]
	private UIModelTeamReserve m_ModelTeamReserve;

	[Token(Token = "0x400EED8")]
	[FieldOffset(Offset = "0x6C")]
	private float m_StartTime;

	[Token(Token = "0x400EED9")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IsCoolingDown;

	[Token(Token = "0x400EEDA")]
	[FieldOffset(Offset = "0x74")]
	private UIBaseProfileInfoController m_BaseProfile;

	[Token(Token = "0x400EEDB")]
	[FieldOffset(Offset = "0x78")]
	private bool m_SentInvite;

	[Token(Token = "0x1700119C")]
	public bool HasGroup
	{
		[Token(Token = "0x600E96A")]
		[Address(RVA = "0x1CFAF1C", Offset = "0x1CFAF1C", VA = "0x1CFAF1C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700119D")]
	public bool InGame
	{
		[Token(Token = "0x600E96B")]
		[Address(RVA = "0x1CFB2EC", Offset = "0x1CFB2EC", VA = "0x1CFB2EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600E969")]
	[Address(RVA = "0x1CFAF14", Offset = "0x1CFAF14", VA = "0x1CFAF14")]
	public UIGroupInviteItemController()
	{
	}

	[Token(Token = "0x600E96C")]
	[Address(RVA = "0x1CFB35C", Offset = "0x1CFB35C", VA = "0x1CFB35C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E96D")]
	[Address(RVA = "0x1CFB400", Offset = "0x1CFB400", VA = "0x1CFB400", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E96E")]
	[Address(RVA = "0x1CFB9C0", Offset = "0x1CFB9C0", VA = "0x1CFB9C0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E96F")]
	[Address(RVA = "0x1CFBC54", Offset = "0x1CFBC54", VA = "0x1CFBC54")]
	public void SetDefaultBtnStatus()
	{
	}

	[Token(Token = "0x600E970")]
	[Address(RVA = "0x1CFAF8C", Offset = "0x1CFAF8C", VA = "0x1CFAF8C")]
	public proto.EPresence.AccountPresence GetPresence()
	{
		return default(proto.EPresence.AccountPresence);
	}

	[Token(Token = "0x600E971")]
	[Address(RVA = "0x1CFBE9C", Offset = "0x1CFBE9C", VA = "0x1CFBE9C")]
	private void OnBgBtnClick()
	{
	}

	[Token(Token = "0x600E972")]
	[Address(RVA = "0x1CFC370", Offset = "0x1CFC370", VA = "0x1CFC370")]
	public void SetSelected(bool v)
	{
	}

	[Token(Token = "0x600E973")]
	[Address(RVA = "0x1CFC3CC", Offset = "0x1CFC3CC", VA = "0x1CFC3CC")]
	private void OnGroupCreateSuccess(object[] param)
	{
	}

	[Token(Token = "0x600E974")]
	[Address(RVA = "0x1CFC448", Offset = "0x1CFC448", VA = "0x1CFC448")]
	private void InviteFriend()
	{
	}

	[Token(Token = "0x600E975")]
	[Address(RVA = "0x1CFD624", Offset = "0x1CFD624", VA = "0x1CFD624")]
	private void onBtnReserveClick()
	{
	}

	[Token(Token = "0x600E976")]
	[Address(RVA = "0x1CFDA7C", Offset = "0x1CFDA7C", VA = "0x1CFDA7C")]
	private void onBtnInviteClick()
	{
	}

	[Token(Token = "0x600E977")]
	[Address(RVA = "0x1CFED6C", Offset = "0x1CFED6C", VA = "0x1CFED6C")]
	private ulong GetAccountID()
	{
		return default(ulong);
	}

	[Token(Token = "0x600E978")]
	[Address(RVA = "0x1CFEE74", Offset = "0x1CFEE74", VA = "0x1CFEE74")]
	private ulong GetGroupID()
	{
		return default(ulong);
	}

	[Token(Token = "0x600E979")]
	[Address(RVA = "0x1CFD39C", Offset = "0x1CFD39C", VA = "0x1CFD39C")]
	private tcp.EGroup.InviteeType GetInviteeType(GroupInviteMemberType type)
	{
		return default(tcp.EGroup.InviteeType);
	}

	[Token(Token = "0x600E97A")]
	[Address(RVA = "0x1CFF170", Offset = "0x1CFF170", VA = "0x1CFF170")]
	public void ClearUIData()
	{
	}

	[Token(Token = "0x600E97B")]
	[Address(RVA = "0x1CFF4A4", Offset = "0x1CFF4A4", VA = "0x1CFF4A4")]
	private void RefreshInviteBtnState()
	{
	}

	[Token(Token = "0x600E97C")]
	[Address(RVA = "0x1CFF6F4", Offset = "0x1CFF6F4", VA = "0x1CFF6F4")]
	private void SetReserveStatus()
	{
	}

	[Token(Token = "0x600E97D")]
	[Address(RVA = "0x1CFF8E8", Offset = "0x1CFF8E8", VA = "0x1CFF8E8", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600E97E")]
	[Address(RVA = "0x1D00F74", Offset = "0x1D00F74", VA = "0x1D00F74")]
	private void UpdateCsRankState(uint rank, uint rankpoint, uint peakRankPos)
	{
	}

	[Token(Token = "0x600E97F")]
	[Address(RVA = "0x1D00DAC", Offset = "0x1D00DAC", VA = "0x1D00DAC")]
	private void UpdateBrRankState(uint rank, uint rankpoint, uint peakRankPos)
	{
	}

	[Token(Token = "0x600E980")]
	[Address(RVA = "0x1D00BEC", Offset = "0x1D00BEC", VA = "0x1D00BEC")]
	private bool ShowInviteOrJoinBtn(proto.EPresence.AccountPresence presence)
	{
		return default(bool);
	}

	[Token(Token = "0x600E981")]
	[Address(RVA = "0x1D00D30", Offset = "0x1D00D30", VA = "0x1D00D30")]
	private bool ShowReserveBtn(proto.EPresence.AccountPresence presence)
	{
		return default(bool);
	}

	[Token(Token = "0x600E982")]
	[Address(RVA = "0x1D01140", Offset = "0x1D01140", VA = "0x1D01140")]
	private void OnGroupChangeNtf(object[] data)
	{
	}

	[Token(Token = "0x600E983")]
	[Address(RVA = "0x1D011BC", Offset = "0x1D011BC", VA = "0x1D011BC")]
	private void OnJoinNtf(object[] data)
	{
	}

	[Token(Token = "0x600E984")]
	[Address(RVA = "0x1D00A38", Offset = "0x1D00A38", VA = "0x1D00A38")]
	private bool IsRankingMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x600E985")]
	[Address(RVA = "0x1CFA40C", Offset = "0x1CFA40C", VA = "0x1CFA40C")]
	public void SetInviteUIType(GroupInviteUI ui)
	{
	}

	[Token(Token = "0x600E986")]
	[Address(RVA = "0x1D0141C", Offset = "0x1D0141C", VA = "0x1D0141C")]
	public void SetInviteMemberType(GroupInviteMemberType ui)
	{
	}

	[Token(Token = "0x600E987")]
	[Address(RVA = "0x1D0147C", Offset = "0x1D0147C", VA = "0x1D0147C", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E988")]
	[Address(RVA = "0x1D01510", Offset = "0x1D01510", VA = "0x1D01510", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E989")]
	[Address(RVA = "0x1D015DC", Offset = "0x1D015DC", VA = "0x1D015DC")]
	private bool _003CGetInviteeType_003Em__0(RecentPlayerInfo temp)
	{
		return default(bool);
	}

	[Token(Token = "0x600E98A")]
	[Address(RVA = "0x1D01644", Offset = "0x1D01644", VA = "0x1D01644")]
	private bool _003COnJoinNtf_003Em__1(GroupMemberInfo a)
	{
		return default(bool);
	}

	[Token(Token = "0x600E98B")]
	[Address(RVA = "0x1D01684", Offset = "0x1D01684", VA = "0x1D01684")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E98C")]
	[Address(RVA = "0x1D0168C", Offset = "0x1D0168C", VA = "0x1D0168C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
