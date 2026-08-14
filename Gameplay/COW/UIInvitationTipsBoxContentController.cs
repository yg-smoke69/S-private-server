using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2003354")]
internal class UIInvitationTipsBoxContentController : UIBaseController
{
	[Token(Token = "0x2003355")]
	private enum NotifyIDType
	{
		[Token(Token = "0x40138F6")]
		GroupInvite = 1,
		[Token(Token = "0x40138F7")]
		GroupJoin,
		[Token(Token = "0x40138F8")]
		FriendRequese,
		[Token(Token = "0x40138F9")]
		FriendRecommed,
		[Token(Token = "0x40138FA")]
		TeamReservation,
		[Token(Token = "0x40138FB")]
		RoomInvite,
		[Token(Token = "0x40138FC")]
		ClanWarInvite,
		[Token(Token = "0x40138FD")]
		CupInvite,
		[Token(Token = "0x40138FE")]
		JoinTeamReq,
		[Token(Token = "0x40138FF")]
		TeammateRecommend,
		[Token(Token = "0x4013900")]
		TeamReservationJoin,
		[Token(Token = "0x4013901")]
		TeamReservationJoinAccept
	}

	[Token(Token = "0x2003356")]
	private sealed class _003CSetUIData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4013902")]
		[FieldOffset(Offset = "0x8")]
		internal InviteToClanWarReq inviteNtfData;

		[Token(Token = "0x6015D68")]
		[Address(RVA = "0x128F278", Offset = "0x128F278", VA = "0x128F278")]
		public _003CSetUIData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6015D69")]
		[Address(RVA = "0x129441C", Offset = "0x129441C", VA = "0x129441C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2003357")]
	private sealed class _003CSetUIData_003Ec__AnonStorey1
	{
		[Token(Token = "0x4013903")]
		[FieldOffset(Offset = "0x8")]
		internal GroupInviteNtf inviteNtfData;

		[Token(Token = "0x4013904")]
		[FieldOffset(Offset = "0xC")]
		internal UIInvitationTipsBoxContentController _0024this;

		[Token(Token = "0x6015D6A")]
		[Address(RVA = "0x128F7F0", Offset = "0x128F7F0", VA = "0x128F7F0")]
		public _003CSetUIData_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6015D6B")]
		[Address(RVA = "0x1294538", Offset = "0x1294538", VA = "0x1294538")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6015D6C")]
		[Address(RVA = "0x129476C", Offset = "0x129476C", VA = "0x129476C")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2003358")]
	private sealed class _003CSetUIData_003Ec__AnonStorey2
	{
		[Token(Token = "0x4013905")]
		[FieldOffset(Offset = "0x8")]
		internal RoomInviteNtf inviteNtfData;

		[Token(Token = "0x4013906")]
		[FieldOffset(Offset = "0xC")]
		internal UIInvitationTipsBoxContentController _0024this;

		[Token(Token = "0x6015D6D")]
		[Address(RVA = "0x128F7F8", Offset = "0x128F7F8", VA = "0x128F7F8")]
		public _003CSetUIData_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6015D6E")]
		[Address(RVA = "0x1294AC8", Offset = "0x1294AC8", VA = "0x1294AC8")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6015D6F")]
		[Address(RVA = "0x1294D0C", Offset = "0x1294D0C", VA = "0x1294D0C")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2003359")]
	private sealed class _003CSetUIData_003Ec__AnonStorey3
	{
		[Token(Token = "0x4013907")]
		[FieldOffset(Offset = "0x8")]
		internal int cupKey;

		[Token(Token = "0x4013908")]
		[FieldOffset(Offset = "0xC")]
		internal UIInvitationTipsBoxContentController _0024this;

		[Token(Token = "0x6015D70")]
		[Address(RVA = "0x128F800", Offset = "0x128F800", VA = "0x128F800")]
		public _003CSetUIData_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6015D71")]
		[Address(RVA = "0x1294F3C", Offset = "0x1294F3C", VA = "0x1294F3C")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6015D72")]
		[Address(RVA = "0x1295138", Offset = "0x1295138", VA = "0x1295138")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x200335A")]
	private sealed class _003CSetUIData_003Ec__AnonStorey4
	{
		[Token(Token = "0x4013909")]
		[FieldOffset(Offset = "0x8")]
		internal int cupKey;

		[Token(Token = "0x401390A")]
		[FieldOffset(Offset = "0x10")]
		internal ulong teamID;

		[Token(Token = "0x401390B")]
		[FieldOffset(Offset = "0x18")]
		internal UIInvitationTipsBoxContentController _0024this;

		[Token(Token = "0x6015D73")]
		[Address(RVA = "0x128F808", Offset = "0x128F808", VA = "0x128F808")]
		public _003CSetUIData_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6015D74")]
		[Address(RVA = "0x1295368", Offset = "0x1295368", VA = "0x1295368")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6015D75")]
		[Address(RVA = "0x1295870", Offset = "0x1295870", VA = "0x1295870")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x6015D76")]
		[Address(RVA = "0x1295AA0", Offset = "0x1295AA0", VA = "0x1295AA0")]
		internal void _003C_003Em__2()
		{
		}
	}

	[Token(Token = "0x200335B")]
	private sealed class _003CSetUIData_003Ec__AnonStorey5
	{
		[Token(Token = "0x401390C")]
		[FieldOffset(Offset = "0x8")]
		internal RecommendFriendInfo recommendFriend;

		[Token(Token = "0x401390D")]
		[FieldOffset(Offset = "0xC")]
		internal UIInvitationTipsBoxContentController _0024this;

		[Token(Token = "0x6015D77")]
		[Address(RVA = "0x128F810", Offset = "0x128F810", VA = "0x128F810")]
		public _003CSetUIData_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6015D78")]
		[Address(RVA = "0x1295DA4", Offset = "0x1295DA4", VA = "0x1295DA4")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6015D79")]
		[Address(RVA = "0x12960FC", Offset = "0x12960FC", VA = "0x12960FC")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x6015D7A")]
		[Address(RVA = "0x1296188", Offset = "0x1296188", VA = "0x1296188")]
		internal void _003C_003Em__2()
		{
		}

		[Token(Token = "0x6015D7B")]
		[Address(RVA = "0x1296360", Offset = "0x1296360", VA = "0x1296360")]
		internal void _003C_003Em__3()
		{
		}
	}

	[Token(Token = "0x200335C")]
	private sealed class _003CSetUIData_003Ec__AnonStorey6
	{
		[Token(Token = "0x401390E")]
		[FieldOffset(Offset = "0x8")]
		internal GroupInfo groupInfo;

		[Token(Token = "0x401390F")]
		[FieldOffset(Offset = "0xC")]
		internal GroupJoinRequestNtf inviteNtfData;

		[Token(Token = "0x4013910")]
		[FieldOffset(Offset = "0x10")]
		internal UIInvitationTipsBoxContentController _0024this;

		[Token(Token = "0x6015D7C")]
		[Address(RVA = "0x128F818", Offset = "0x128F818", VA = "0x128F818")]
		public _003CSetUIData_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6015D7D")]
		[Address(RVA = "0x12963EC", Offset = "0x12963EC", VA = "0x12963EC")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6015D7E")]
		[Address(RVA = "0x1296510", Offset = "0x1296510", VA = "0x1296510")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x200335D")]
	private sealed class _003CSetReservationUIData_003Ec__AnonStorey7
	{
		[Token(Token = "0x4013911")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EPresence.AccountPresence presence;

		[Token(Token = "0x4013912")]
		[FieldOffset(Offset = "0xC")]
		internal UIInvitationTipsBoxContentController _0024this;

		[Token(Token = "0x6015D7F")]
		[Address(RVA = "0x128F904", Offset = "0x128F904", VA = "0x128F904")]
		public _003CSetReservationUIData_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6015D80")]
		[Address(RVA = "0x1292A18", Offset = "0x1292A18", VA = "0x1292A18")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6015D81")]
		[Address(RVA = "0x1293B7C", Offset = "0x1293B7C", VA = "0x1293B7C")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x200335E")]
	private sealed class _003CSetReservationJoinUIData_003Ec__AnonStorey8
	{
		[Token(Token = "0x4013913")]
		[FieldOffset(Offset = "0x8")]
		internal FriendAccountInfo inviteInfo;

		[Token(Token = "0x4013914")]
		[FieldOffset(Offset = "0xC")]
		internal UIInvitationTipsBoxContentController _0024this;

		[Token(Token = "0x6015D82")]
		[Address(RVA = "0x128F90C", Offset = "0x128F90C", VA = "0x128F90C")]
		public _003CSetReservationJoinUIData_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x6015D83")]
		[Address(RVA = "0x1291CF8", Offset = "0x1291CF8", VA = "0x1291CF8")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6015D84")]
		[Address(RVA = "0x1291FE0", Offset = "0x1291FE0", VA = "0x1291FE0")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x200335F")]
	private sealed class _003CSetReservationJoinUIData_003Ec__AnonStorey9
	{
		[Token(Token = "0x4013915")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelGroup modelGroup;

		[Token(Token = "0x4013916")]
		[FieldOffset(Offset = "0xC")]
		internal GroupJoinRequestNtf inviteNtfData;

		[Token(Token = "0x4013917")]
		[FieldOffset(Offset = "0x10")]
		internal UIInvitationTipsBoxContentController _0024this;

		[Token(Token = "0x6015D85")]
		[Address(RVA = "0x128F914", Offset = "0x128F914", VA = "0x128F914")]
		public _003CSetReservationJoinUIData_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x6015D86")]
		[Address(RVA = "0x129222C", Offset = "0x129222C", VA = "0x129222C")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6015D87")]
		[Address(RVA = "0x12926C4", Offset = "0x12926C4", VA = "0x12926C4")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2003360")]
	private sealed class _003CSetTeammateRecommendData_003Ec__AnonStoreyA
	{
		[Token(Token = "0x4013918")]
		[FieldOffset(Offset = "0x8")]
		internal TeammateStats stats;

		[Token(Token = "0x4013919")]
		[FieldOffset(Offset = "0xC")]
		internal UIInvitationTipsBoxContentController _0024this;

		[Token(Token = "0x6015D88")]
		[Address(RVA = "0x128F91C", Offset = "0x128F91C", VA = "0x128F91C")]
		public _003CSetTeammateRecommendData_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x6015D89")]
		[Address(RVA = "0x1293DC8", Offset = "0x1293DC8", VA = "0x1293DC8")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6015D8A")]
		[Address(RVA = "0x12942D4", Offset = "0x12942D4", VA = "0x12942D4")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x6015D8B")]
		[Address(RVA = "0x1294378", Offset = "0x1294378", VA = "0x1294378")]
		internal void _003C_003Em__2()
		{
		}
	}

	[Token(Token = "0x40138D8")]
	[FieldOffset(Offset = "0x28")]
	private UIInvitationTipsBoxContentView m_View;

	[Token(Token = "0x40138D9")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x40138DA")]
	[FieldOffset(Offset = "0x30")]
	private UIModelCustomRoom m_ModelCustomRoom;

	[Token(Token = "0x40138DB")]
	[FieldOffset(Offset = "0x34")]
	private UIModelInvitation m_ModelInvitation;

	[Token(Token = "0x40138DC")]
	[FieldOffset(Offset = "0x38")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x40138DD")]
	[FieldOffset(Offset = "0x3C")]
	private Action m_OnOK;

	[Token(Token = "0x40138DE")]
	[FieldOffset(Offset = "0x40")]
	private Action m_OnCancel;

	[Token(Token = "0x40138DF")]
	[FieldOffset(Offset = "0x44")]
	private Action m_OnToggle;

	[Token(Token = "0x40138E0")]
	[FieldOffset(Offset = "0x48")]
	private Action m_OnExpired;

	[Token(Token = "0x40138E1")]
	[FieldOffset(Offset = "0x50")]
	private ulong m_InviterAccountID;

	[Token(Token = "0x40138E2")]
	[FieldOffset(Offset = "0x58")]
	private object m_Data;

	[Token(Token = "0x40138E3")]
	[FieldOffset(Offset = "0x60")]
	private ulong m_InvitationExpiredCallID;

	[Token(Token = "0x40138E4")]
	[FieldOffset(Offset = "0x68")]
	private ulong m_CurrentExpireTimeStamp;

	[Token(Token = "0x40138E5")]
	[FieldOffset(Offset = "0x70")]
	public bool ShouldOut;

	[Token(Token = "0x40138E6")]
	[FieldOffset(Offset = "0x71")]
	public bool IsInAni;

	[Token(Token = "0x40138E7")]
	[FieldOffset(Offset = "0x72")]
	public bool ShouldUp;

	[Token(Token = "0x40138E8")]
	[FieldOffset(Offset = "0x78")]
	public ulong InvitationID;

	[Token(Token = "0x40138E9")]
	[FieldOffset(Offset = "0x80")]
	private float m_TimeStart;

	[Token(Token = "0x40138EA")]
	[FieldOffset(Offset = "0x88")]
	private ulong m_AccountID;

	[Token(Token = "0x40138EB")]
	[FieldOffset(Offset = "0x90")]
	private string m_NickName;

	[Token(Token = "0x40138EC")]
	[FieldOffset(Offset = "0x94")]
	private int m_Rank;

	[Token(Token = "0x40138ED")]
	[FieldOffset(Offset = "0x98")]
	private float m_RankPoints;

	[Token(Token = "0x40138EE")]
	[FieldOffset(Offset = "0x9C")]
	private uint m_PeakRankPos;

	[Token(Token = "0x40138EF")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_HasExpired;

	[Token(Token = "0x40138F0")]
	[FieldOffset(Offset = "0xA4")]
	private NotifyData m_NotifyData;

	[Token(Token = "0x40138F1")]
	[FieldOffset(Offset = "0xA8")]
	private bool NeedQuitSceneEdit;

	[Token(Token = "0x40138F2")]
	[FieldOffset(Offset = "0xAC")]
	private FriendAccountInfo m_FriendInfo;

	[Token(Token = "0x40138F3")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40138F4")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6015D3A")]
	[Address(RVA = "0x12879C8", Offset = "0x12879C8", VA = "0x12879C8")]
	public UIInvitationTipsBoxContentController()
	{
	}

	[Token(Token = "0x6015D3B")]
	[Address(RVA = "0x1287A78", Offset = "0x1287A78", VA = "0x1287A78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015D3C")]
	[Address(RVA = "0x1287B20", Offset = "0x1287B20", VA = "0x1287B20", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015D3D")]
	[Address(RVA = "0x1288658", Offset = "0x1288658", VA = "0x1288658", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6015D3E")]
	[Address(RVA = "0x1288804", Offset = "0x1288804", VA = "0x1288804")]
	private void Update()
	{
	}

	[Token(Token = "0x6015D3F")]
	[Address(RVA = "0x1288BCC", Offset = "0x1288BCC", VA = "0x1288BCC")]
	public object GetData()
	{
		return null;
	}

	[Token(Token = "0x6015D40")]
	[Address(RVA = "0x1288C24", Offset = "0x1288C24", VA = "0x1288C24")]
	public void UpdateClanWarInfo()
	{
	}

	[Token(Token = "0x6015D41")]
	[Address(RVA = "0x1288E80", Offset = "0x1288E80", VA = "0x1288E80")]
	public void UpdateRank(int rank, uint peakRankPos, bool enableLabel2 = false, bool is_BRRank = true)
	{
	}

	[Token(Token = "0x6015D42")]
	[Address(RVA = "0x128988C", Offset = "0x128988C", VA = "0x128988C")]
	private void OnChangeBlockPlayer()
	{
	}

	[Token(Token = "0x6015D43")]
	[Address(RVA = "0x1289E98", Offset = "0x1289E98", VA = "0x1289E98")]
	private void BeforeSetData()
	{
	}

	[Token(Token = "0x6015D44")]
	[Address(RVA = "0x1289FA0", Offset = "0x1289FA0", VA = "0x1289FA0")]
	public void SetData(object[] args, ulong time, bool isFirst, ulong invitationID)
	{
	}

	[Token(Token = "0x6015D45")]
	[Address(RVA = "0x128DF88", Offset = "0x128DF88", VA = "0x128DF88")]
	public void SetUIData(InviteToClanWarReq inviteNtfData)
	{
	}

	[Token(Token = "0x6015D46")]
	[Address(RVA = "0x128F5A8", Offset = "0x128F5A8", VA = "0x128F5A8")]
	private void UpdataNickName()
	{
	}

	[Token(Token = "0x6015D47")]
	[Address(RVA = "0x128B508", Offset = "0x128B508", VA = "0x128B508")]
	public void SetUIData(GroupInviteNtf inviteNtfData, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6015D48")]
	[Address(RVA = "0x128C03C", Offset = "0x128C03C", VA = "0x128C03C")]
	public void SetUIData(RoomInviteNtf inviteNtfData, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6015D49")]
	[Address(RVA = "0x128E6C4", Offset = "0x128E6C4", VA = "0x128E6C4")]
	public void SetUIData(RequestJoinCupTeamReq requestJoinCupTeamReq)
	{
	}

	[Token(Token = "0x6015D4A")]
	[Address(RVA = "0x128E1AC", Offset = "0x128E1AC", VA = "0x128E1AC")]
	public void SetUIData(InviteToCupTeamReq inviteToCupTeamReq)
	{
	}

	[Token(Token = "0x6015D4B")]
	[Address(RVA = "0x128CE84", Offset = "0x128CE84", VA = "0x128CE84")]
	public void SetUIData(FriendAccountInfo inviteNtfData)
	{
	}

	[Token(Token = "0x6015D4C")]
	[Address(RVA = "0x128DAC8", Offset = "0x128DAC8", VA = "0x128DAC8")]
	public void SetUIData(RecommendFriendInfo recommendFriend)
	{
	}

	[Token(Token = "0x6015D4D")]
	[Address(RVA = "0x128C43C", Offset = "0x128C43C", VA = "0x128C43C")]
	public void SetUIData(GroupJoinRequestNtf inviteNtfData, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6015D4E")]
	[Address(RVA = "0x128F820", Offset = "0x128F820", VA = "0x128F820")]
	public proto.EPresence.AccountPresence GetPresence()
	{
		return default(proto.EPresence.AccountPresence);
	}

	[Token(Token = "0x6015D4F")]
	[Address(RVA = "0x128D74C", Offset = "0x128D74C", VA = "0x128D74C")]
	public void SetReservationUIData(FriendAccountInfo inviteInfo)
	{
	}

	[Token(Token = "0x6015D50")]
	[Address(RVA = "0x128D3C0", Offset = "0x128D3C0", VA = "0x128D3C0")]
	public void SetReservationJoinUIData(FriendAccountInfo inviteInfo)
	{
	}

	[Token(Token = "0x6015D51")]
	[Address(RVA = "0x128C958", Offset = "0x128C958", VA = "0x128C958")]
	public void SetReservationJoinUIData(GroupJoinRequestNtf inviteNtfData)
	{
	}

	[Token(Token = "0x6015D52")]
	[Address(RVA = "0x128EB74", Offset = "0x128EB74", VA = "0x128EB74")]
	public void SetTeammateRecommendData(TeammateStats stats, bool isBR)
	{
	}

	[Token(Token = "0x6015D53")]
	[Address(RVA = "0x128F924", Offset = "0x128F924", VA = "0x128F924")]
	private void RefuseInvite()
	{
	}

	[Token(Token = "0x6015D54")]
	[Address(RVA = "0x128FB3C", Offset = "0x128FB3C", VA = "0x128FB3C")]
	private void RefuseInviteWithoutLog()
	{
	}

	[Token(Token = "0x6015D55")]
	[Address(RVA = "0x128F280", Offset = "0x128F280", VA = "0x128F280")]
	private void AfterSetData()
	{
	}

	[Token(Token = "0x6015D56")]
	[Address(RVA = "0x128FE08", Offset = "0x128FE08", VA = "0x128FE08")]
	private string GetTimeString()
	{
		return null;
	}

	[Token(Token = "0x6015D57")]
	[Address(RVA = "0x128FFE8", Offset = "0x128FFE8", VA = "0x128FFE8")]
	private void OnClickName()
	{
	}

	[Token(Token = "0x6015D58")]
	[Address(RVA = "0x12901FC", Offset = "0x12901FC", VA = "0x12901FC")]
	private void OnClickOK()
	{
	}

	[Token(Token = "0x6015D59")]
	[Address(RVA = "0x12905A4", Offset = "0x12905A4", VA = "0x12905A4")]
	private void OnClickCancel()
	{
	}

	[Token(Token = "0x6015D5A")]
	[Address(RVA = "0x12889F8", Offset = "0x12889F8", VA = "0x12889F8")]
	public void OnTipsBoxClose()
	{
	}

	[Token(Token = "0x6015D5B")]
	[Address(RVA = "0x1290618", Offset = "0x1290618", VA = "0x1290618")]
	private void OnClickToggle()
	{
	}

	[Token(Token = "0x6015D5C")]
	[Address(RVA = "0x1290684", Offset = "0x1290684", VA = "0x1290684")]
	private void AnimEvtHandler(object[] data)
	{
	}

	[Token(Token = "0x6015D5D")]
	[Address(RVA = "0x1290CAC", Offset = "0x1290CAC", VA = "0x1290CAC")]
	public void SetContentDepth(int depth)
	{
	}

	[Token(Token = "0x6015D5E")]
	[Address(RVA = "0x128FF08", Offset = "0x128FF08", VA = "0x128FF08")]
	private int GetCurrentExpireLeftSeconds()
	{
		return default(int);
	}

	[Token(Token = "0x6015D5F")]
	[Address(RVA = "0x1290D44", Offset = "0x1290D44", VA = "0x1290D44")]
	public void PlayUpAni()
	{
	}

	[Token(Token = "0x6015D60")]
	[Address(RVA = "0x1290E1C", Offset = "0x1290E1C", VA = "0x1290E1C")]
	private static void _003CSetUIData_003Em__0()
	{
	}

	[Token(Token = "0x6015D61")]
	[Address(RVA = "0x12910C0", Offset = "0x12910C0", VA = "0x12910C0")]
	private void _003CSetUIData_003Em__1()
	{
	}

	[Token(Token = "0x6015D62")]
	[Address(RVA = "0x1291484", Offset = "0x1291484", VA = "0x1291484")]
	private void _003CSetUIData_003Em__2()
	{
	}

	[Token(Token = "0x6015D63")]
	[Address(RVA = "0x1291848", Offset = "0x1291848", VA = "0x1291848")]
	private void _003CSetUIData_003Em__3()
	{
	}

	[Token(Token = "0x6015D64")]
	[Address(RVA = "0x1291B78", Offset = "0x1291B78", VA = "0x1291B78")]
	private static void _003CSetUIData_003Em__4()
	{
	}

	[Token(Token = "0x6015D65")]
	[Address(RVA = "0x1291C94", Offset = "0x1291C94", VA = "0x1291C94")]
	private void _003CAfterSetData_003Em__5()
	{
	}

	[Token(Token = "0x6015D66")]
	[Address(RVA = "0x1291CE8", Offset = "0x1291CE8", VA = "0x1291CE8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015D67")]
	[Address(RVA = "0x1291CF0", Offset = "0x1291CF0", VA = "0x1291CF0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
