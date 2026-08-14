using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2003201")]
public class UIModelRelationShip : UIBaseModel
{
	[Token(Token = "0x2003202")]
	private sealed class _003CRequestAuthInspect_003Ec__AnonStorey0
	{
		[Token(Token = "0x40130A0")]
		[FieldOffset(Offset = "0x8")]
		internal bool visible;

		[Token(Token = "0x40130A1")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelRelationShip _0024this;

		[Token(Token = "0x60151CB")]
		[Address(RVA = "0x314BA38", Offset = "0x314BA38", VA = "0x314BA38")]
		public _003CRequestAuthInspect_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60151CC")]
		[Address(RVA = "0x314FA34", Offset = "0x314FA34", VA = "0x314FA34")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	[Token(Token = "0x2003203")]
	private sealed class _003CRequestClaimIntimacyAward_003Ec__AnonStorey1
	{
		[Token(Token = "0x40130A2")]
		[FieldOffset(Offset = "0x8")]
		internal ulong friendID;

		[Token(Token = "0x40130A3")]
		[FieldOffset(Offset = "0x10")]
		internal uint rankLevel;

		[Token(Token = "0x40130A4")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelRelationShip _0024this;

		[Token(Token = "0x60151CD")]
		[Address(RVA = "0x314BD80", Offset = "0x314BD80", VA = "0x314BD80")]
		public _003CRequestClaimIntimacyAward_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60151CE")]
		[Address(RVA = "0x314FD68", Offset = "0x314FD68", VA = "0x314FD68")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003204")]
	private sealed class _003CRequestCreateSpecialRelation_003Ec__AnonStorey2
	{
		[Token(Token = "0x40130A5")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountID;

		[Token(Token = "0x40130A6")]
		[FieldOffset(Offset = "0x10")]
		internal proto.EFriend.RelationType relationType;

		[Token(Token = "0x40130A7")]
		[FieldOffset(Offset = "0x14")]
		internal RelationshipInfo currentRelationshipInfo;

		[Token(Token = "0x40130A8")]
		[FieldOffset(Offset = "0x18")]
		internal List<RelationshipInfo> accountInfoList;

		[Token(Token = "0x40130A9")]
		[FieldOffset(Offset = "0x1C")]
		internal UIModelRelationShip _0024this;

		[Token(Token = "0x60151CF")]
		[Address(RVA = "0x2CFCA44", Offset = "0x2CFCA44", VA = "0x2CFCA44")]
		public _003CRequestCreateSpecialRelation_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60151D0")]
		[Address(RVA = "0x2CFCA4C", Offset = "0x2CFCA4C", VA = "0x2CFCA4C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003205")]
	private sealed class _003CRequestConfirmCreateSpecialRelation_003Ec__AnonStorey3
	{
		[Token(Token = "0x40130AA")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EFriend.RelationType relationType;

		[Token(Token = "0x40130AB")]
		[FieldOffset(Offset = "0x10")]
		internal ulong accountID;

		[Token(Token = "0x40130AC")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelRelationShip _0024this;

		[Token(Token = "0x60151D1")]
		[Address(RVA = "0x2CFBFB8", Offset = "0x2CFBFB8", VA = "0x2CFBFB8")]
		public _003CRequestConfirmCreateSpecialRelation_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60151D2")]
		[Address(RVA = "0x2CFBFC0", Offset = "0x2CFBFC0", VA = "0x2CFBFC0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003206")]
	private sealed class _003CRequestConfirmDismissSpecialRelation_003Ec__AnonStorey4
	{
		[Token(Token = "0x40130AD")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EFriend.RelationType relationType;

		[Token(Token = "0x40130AE")]
		[FieldOffset(Offset = "0x10")]
		internal ulong accountID;

		[Token(Token = "0x40130AF")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelRelationShip _0024this;

		[Token(Token = "0x60151D3")]
		[Address(RVA = "0x2CFC5C4", Offset = "0x2CFC5C4", VA = "0x2CFC5C4")]
		public _003CRequestConfirmDismissSpecialRelation_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60151D4")]
		[Address(RVA = "0x2CFC5CC", Offset = "0x2CFC5CC", VA = "0x2CFC5CC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003207")]
	private sealed class _003CRequestDeclineCreateSpecialFriend_003Ec__AnonStorey5
	{
		[Token(Token = "0x40130B0")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EFriend.RelationType relationType;

		[Token(Token = "0x40130B1")]
		[FieldOffset(Offset = "0x10")]
		internal ulong accountID;

		[Token(Token = "0x40130B2")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelRelationShip _0024this;

		[Token(Token = "0x60151D5")]
		[Address(RVA = "0x2CFCD20", Offset = "0x2CFCD20", VA = "0x2CFCD20")]
		public _003CRequestDeclineCreateSpecialFriend_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60151D6")]
		[Address(RVA = "0x2CFCD28", Offset = "0x2CFCD28", VA = "0x2CFCD28")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003208")]
	private sealed class _003CRequestDeclineDissmissSpecialFriend_003Ec__AnonStorey6
	{
		[Token(Token = "0x40130B3")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EFriend.RelationType relationType;

		[Token(Token = "0x40130B4")]
		[FieldOffset(Offset = "0x10")]
		internal ulong accountID;

		[Token(Token = "0x40130B5")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelRelationShip _0024this;

		[Token(Token = "0x60151D7")]
		[Address(RVA = "0x2CFCED4", Offset = "0x2CFCED4", VA = "0x2CFCED4")]
		public _003CRequestDeclineDissmissSpecialFriend_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x60151D8")]
		[Address(RVA = "0x2CFCEDC", Offset = "0x2CFCEDC", VA = "0x2CFCEDC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003209")]
	private sealed class _003CRequestCallbackDismissSpecialFriend_003Ec__AnonStorey7
	{
		[Token(Token = "0x40130B6")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EFriend.RelationType relationType;

		[Token(Token = "0x40130B7")]
		[FieldOffset(Offset = "0x10")]
		internal ulong accountID;

		[Token(Token = "0x40130B8")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelRelationShip _0024this;

		[Token(Token = "0x60151D9")]
		[Address(RVA = "0x314DD1C", Offset = "0x314DD1C", VA = "0x314DD1C")]
		public _003CRequestCallbackDismissSpecialFriend_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x60151DA")]
		[Address(RVA = "0x314FC0C", Offset = "0x314FC0C", VA = "0x314FC0C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x401308D")]
	public const uint PropID_RelationshipInfoReady = 1u;

	[Token(Token = "0x401308E")]
	public const uint PropID_UpdateRelationshipInviteState = 2u;

	[Token(Token = "0x401308F")]
	public const uint PropID_UpdateRelationshipApplications = 4u;

	[Token(Token = "0x4013090")]
	public const uint PropID_UpdateApplicationMsgInfoState = 8u;

	[Token(Token = "0x4013091")]
	public const uint PropID_ClaimRelationshipRewards = 16u;

	[Token(Token = "0x4013092")]
	public const uint PropID_UpdateIntimacyChange = 32u;

	[Token(Token = "0x4013093")]
	public const uint PropID_UpdateRelationshipVisible = 64u;

	[Token(Token = "0x4013094")]
	public const uint PropID_RelationshipIntimacyInfoReady = 128u;

	[Token(Token = "0x4013095")]
	private const string SHOW_CELEBERATE_CONNECT_WITH_FRIEND = "Congratulation_{0}";

	[Token(Token = "0x4013096")]
	[FieldOffset(Offset = "0xC")]
	private bool m_RelationshipDicReady;

	[Token(Token = "0x4013097")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, List<RelationshipInfo>> m_RelationshipDic;

	[Token(Token = "0x4013098")]
	[FieldOffset(Offset = "0x14")]
	private bool m_IntimacyAwardInfoDicReady;

	[Token(Token = "0x4013099")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<ulong, SpecificIntimacyRankAwardInfo> m_IntimacyAwardInfoDic;

	[Token(Token = "0x401309A")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<uint, Dictionary<uint, IntimacyAwardDesc>> m_IntimacyAwardDescDic;

	[Token(Token = "0x401309B")]
	[FieldOffset(Offset = "0x20")]
	private bool m_ApplicationsListReady;

	[Token(Token = "0x401309C")]
	[FieldOffset(Offset = "0x24")]
	private List<RelationshipMessageInfo> m_ApplicationsList;

	[Token(Token = "0x401309D")]
	private const string RecordLastPlayGameFriendString = "LastPlayGameFriend";

	[Token(Token = "0x401309E")]
	private const int RecordLastPlayGameFriendCount = 3;

	[Token(Token = "0x401309F")]
	[FieldOffset(Offset = "0x28")]
	private List<ulong> m_LastPlayGameFriends;

	[Token(Token = "0x17001640")]
	public List<ulong> LastPlayGameFriends
	{
		[Token(Token = "0x60151C4")]
		[Address(RVA = "0x314ED50", Offset = "0x314ED50", VA = "0x314ED50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6015196")]
	[Address(RVA = "0x3146F28", Offset = "0x3146F28", VA = "0x3146F28")]
	public UIModelRelationShip()
	{
	}

	[Token(Token = "0x6015197")]
	[Address(RVA = "0x314707C", Offset = "0x314707C", VA = "0x314707C")]
	public RelationshipInfo GetRelationshipInfoAlreadyBe(proto.EFriend.RelationType relationType, ulong accountID)
	{
		return null;
	}

	[Token(Token = "0x6015198")]
	[Address(RVA = "0x3147340", Offset = "0x3147340", VA = "0x3147340")]
	public RelationshipInfo GetRelationshipInfo(proto.EFriend.RelationType relationType, ulong accountID)
	{
		return null;
	}

	[Token(Token = "0x6015199")]
	[Address(RVA = "0x31475AC", Offset = "0x31475AC", VA = "0x31475AC")]
	public void SetCurrentAllNotifyMsgRead()
	{
	}

	[Token(Token = "0x601519A")]
	[Address(RVA = "0x3147998", Offset = "0x3147998", VA = "0x3147998")]
	public void DeclineAndReadCurrentAllMsg()
	{
	}

	[Token(Token = "0x601519B")]
	[Address(RVA = "0x3147770", Offset = "0x3147770", VA = "0x3147770")]
	public void CheckNewRelationshipMsg()
	{
	}

	[Token(Token = "0x601519C")]
	[Address(RVA = "0x3147B50", Offset = "0x3147B50", VA = "0x3147B50")]
	public bool RelationshipInfoVisible(proto.EFriend.RelationType relationType)
	{
		return default(bool);
	}

	[Token(Token = "0x601519D")]
	[Address(RVA = "0x3147D4C", Offset = "0x3147D4C", VA = "0x3147D4C")]
	public List<RelationshipMessageInfo> GetRelationshipApplications()
	{
		return null;
	}

	[Token(Token = "0x601519E")]
	[Address(RVA = "0x3147F90", Offset = "0x3147F90", VA = "0x3147F90")]
	public bool HasRelationshipDismissApplication(proto.EFriend.RelationType relationType)
	{
		return default(bool);
	}

	[Token(Token = "0x601519F")]
	[Address(RVA = "0x3148158", Offset = "0x3148158", VA = "0x3148158")]
	public ulong GetRelationshipDismissApplicationReqTime(proto.EFriend.RelationType relationType)
	{
		return default(ulong);
	}

	[Token(Token = "0x60151A0")]
	[Address(RVA = "0x3148330", Offset = "0x3148330", VA = "0x3148330")]
	public SpecificIntimacyRankAwardInfo GetIntimacyRewardInfo(ulong relationshipID)
	{
		return null;
	}

	[Token(Token = "0x60151A1")]
	[Address(RVA = "0x314842C", Offset = "0x314842C", VA = "0x314842C")]
	public List<RelationshipInfo> GetCurrentRelationInfoAlreadyBe(proto.EFriend.RelationType relationType)
	{
		return null;
	}

	[Token(Token = "0x60151A2")]
	[Address(RVA = "0x3147C68", Offset = "0x3147C68", VA = "0x3147C68")]
	public List<RelationshipInfo> GetCurrentRelationInfo(proto.EFriend.RelationType relationType)
	{
		return null;
	}

	[Token(Token = "0x60151A3")]
	[Address(RVA = "0x31486B4", Offset = "0x31486B4", VA = "0x31486B4")]
	public List<FriendAccountInfo> GetRelationshipCandidateList(proto.EFriend.RelationType relationType)
	{
		return null;
	}

	[Token(Token = "0x60151A4")]
	[Address(RVA = "0x3148E04", Offset = "0x3148E04", VA = "0x3148E04")]
	public Dictionary<uint, IntimacyAwardDesc> GetIntimacyAwardsDesc(proto.EFriend.RelationType relationType)
	{
		return null;
	}

	[Token(Token = "0x60151A5")]
	[Address(RVA = "0x3148EF4", Offset = "0x3148EF4", VA = "0x3148EF4")]
	public IntimacyRankAwardInfo GetIntimacyAwardsInfo(ulong friendID, uint rank)
	{
		return null;
	}

	[Token(Token = "0x60151A6")]
	[Address(RVA = "0x3149110", Offset = "0x3149110", VA = "0x3149110")]
	public int GetIntimacyMax(proto.EFriend.RelationType relationType)
	{
		return default(int);
	}

	[Token(Token = "0x60151A7")]
	[Address(RVA = "0x31493EC", Offset = "0x31493EC", VA = "0x31493EC")]
	public int GetNewIntimacyMax(proto.EFriend.RelationType relationType)
	{
		return default(int);
	}

	[Token(Token = "0x60151A8")]
	[Address(RVA = "0x31496C8", Offset = "0x31496C8", VA = "0x31496C8")]
	public IntimacyRankInfoData GetIntimacyRankInfoByIntimacy(proto.EFriend.RelationType relationType, uint intimacy)
	{
		return null;
	}

	[Token(Token = "0x60151A9")]
	[Address(RVA = "0x3149BA0", Offset = "0x3149BA0", VA = "0x3149BA0")]
	public proto.EFriend.RelationType GetRelationship(ulong FriendID)
	{
		return default(proto.EFriend.RelationType);
	}

	[Token(Token = "0x60151AA")]
	[Address(RVA = "0x314A064", Offset = "0x314A064", VA = "0x314A064")]
	public List<RelationshipInfo> GetRelationshipsByFriendID(ulong FriendID)
	{
		return null;
	}

	[Token(Token = "0x60151AB")]
	[Address(RVA = "0x314A4C8", Offset = "0x314A4C8", VA = "0x314A4C8")]
	public List<ulong> GetRelationshipFriendIDsInLocationData(proto.EFriend.RelationType relationType)
	{
		return null;
	}

	[Token(Token = "0x60151AC")]
	[Address(RVA = "0x314A7DC", Offset = "0x314A7DC", VA = "0x314A7DC")]
	public void SetRelationshipFriendIDsInLocationData(proto.EFriend.RelationType relationType)
	{
	}

	[Token(Token = "0x60151AD")]
	[Address(RVA = "0x314AB9C", Offset = "0x314AB9C", VA = "0x314AB9C")]
	public uint GetRelationshipRank(ulong FriendID, proto.EFriend.RelationType relationType)
	{
		return default(uint);
	}

	[Token(Token = "0x60151AE")]
	[Address(RVA = "0x3148B48", Offset = "0x3148B48", VA = "0x3148B48")]
	private bool CheckRelationshipStateIsConnect(proto.EFriend.RelationType relationType, ulong accountID)
	{
		return default(bool);
	}

	[Token(Token = "0x60151AF")]
	[Address(RVA = "0x314AC94", Offset = "0x314AC94", VA = "0x314AC94")]
	private RelationshipMessageInfo GetSepcialFriendApplication(proto.EFriend.RelationType relationType, ulong accountID)
	{
		return null;
	}

	[Token(Token = "0x60151B0")]
	[Address(RVA = "0x314AEF0", Offset = "0x314AEF0", VA = "0x314AEF0")]
	public void ProcessServerData(CSGetAllFriendDescRes desc)
	{
	}

	[Token(Token = "0x60151B1")]
	[Address(RVA = "0x314B0DC", Offset = "0x314B0DC", VA = "0x314B0DC")]
	private IntimacyAwardDesc GetAwardDesc(proto.EFriend.RelationType relationType, uint rank)
	{
		return null;
	}

	[Token(Token = "0x60151B2")]
	[Address(RVA = "0x314B228", Offset = "0x314B228", VA = "0x314B228", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60151B3")]
	[Address(RVA = "0x314B280", Offset = "0x314B280", VA = "0x314B280", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x60151B4")]
	[Address(RVA = "0x314B590", Offset = "0x314B590", VA = "0x314B590", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60151B5")]
	[Address(RVA = "0x314B700", Offset = "0x314B700", VA = "0x314B700")]
	public void RequestAuthInspect(bool visible)
	{
	}

	[Token(Token = "0x60151B6")]
	[Address(RVA = "0x314BA40", Offset = "0x314BA40", VA = "0x314BA40")]
	public void RequestClaimIntimacyAward(ulong friendID, uint rankLevel, proto.EFriend.RelationType relationType)
	{
	}

	[Token(Token = "0x60151B7")]
	[Address(RVA = "0x314BD88", Offset = "0x314BD88", VA = "0x314BD88")]
	public void RequestIntimacyRankAwardsInfo(bool force = false)
	{
	}

	[Token(Token = "0x60151B8")]
	[Address(RVA = "0x314C068", Offset = "0x314C068", VA = "0x314C068")]
	public void RequestCreateSpecialRelation(proto.EFriend.RelationType relationType, ulong accountID)
	{
	}

	[Token(Token = "0x60151B9")]
	[Address(RVA = "0x314C4B8", Offset = "0x314C4B8", VA = "0x314C4B8")]
	public void RequestDismissSpecialRelation(proto.EFriend.RelationType relationType, ulong accountID)
	{
	}

	[Token(Token = "0x60151BA")]
	[Address(RVA = "0x314C92C", Offset = "0x314C92C", VA = "0x314C92C")]
	public void RequestRelationShipInvitationInfos(bool force = false)
	{
	}

	[Token(Token = "0x60151BB")]
	[Address(RVA = "0x314CA08", Offset = "0x314CA08", VA = "0x314CA08")]
	public void RequestAllRelationshipStateInfo(bool isFirstLogin, bool force = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60151BC")]
	[Address(RVA = "0x314CB04", Offset = "0x314CB04", VA = "0x314CB04")]
	public void RequestConfirmCreateSpecialRelation(proto.EFriend.RelationType relationType, ulong accountID)
	{
	}

	[Token(Token = "0x60151BD")]
	[Address(RVA = "0x314CE3C", Offset = "0x314CE3C", VA = "0x314CE3C")]
	public void RequestConfirmDismissSpecialRelation(proto.EFriend.RelationType relationType, ulong accountID)
	{
	}

	[Token(Token = "0x60151BE")]
	[Address(RVA = "0x314D174", Offset = "0x314D174", VA = "0x314D174")]
	public void DeleteMessageInfo(RelationshipMessageInfo msg)
	{
	}

	[Token(Token = "0x60151BF")]
	[Address(RVA = "0x314D378", Offset = "0x314D378", VA = "0x314D378")]
	public void RequestDeclineCreateSpecialFriend(proto.EFriend.RelationType relationType, ulong accountID)
	{
	}

	[Token(Token = "0x60151C0")]
	[Address(RVA = "0x314D6B0", Offset = "0x314D6B0", VA = "0x314D6B0")]
	public void RequestDeclineDissmissSpecialFriend(proto.EFriend.RelationType relationType, ulong accountID)
	{
	}

	[Token(Token = "0x60151C1")]
	[Address(RVA = "0x314D9E8", Offset = "0x314D9E8", VA = "0x314D9E8")]
	public void RequestCallbackDismissSpecialFriend(proto.EFriend.RelationType relationType, ulong accountID)
	{
	}

	[Token(Token = "0x60151C2")]
	[Address(RVA = "0x314DD24", Offset = "0x314DD24", VA = "0x314DD24")]
	public void OnReceiveRelationshipMsgInfo(RelatedFriendRequestNtf receiveMsg, UIRelationshipMsgType msgType)
	{
	}

	[Token(Token = "0x60151C3")]
	[Address(RVA = "0x314E720", Offset = "0x314E720", VA = "0x314E720")]
	public void OnReceiveIntimacyChange(ulong friendID, proto.EFriend.RelationType relationType, uint changeValue)
	{
	}

	[Token(Token = "0x60151C5")]
	[Address(RVA = "0x314EE28", Offset = "0x314EE28", VA = "0x314EE28")]
	public void AddLastPlayGameFriend(MatchStats stats)
	{
	}

	[Token(Token = "0x60151C6")]
	[Address(RVA = "0x314B2E8", Offset = "0x314B2E8", VA = "0x314B2E8")]
	public void InitLastPlayGameFriend()
	{
	}

	[Token(Token = "0x60151C7")]
	[Address(RVA = "0x314F528", Offset = "0x314F528", VA = "0x314F528")]
	private void _003CRequestIntimacyRankAwardsInfo_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60151C8")]
	[Address(RVA = "0x314F9E0", Offset = "0x314F9E0", VA = "0x314F9E0")]
	private void _003CRequestDismissSpecialRelation_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60151C9")]
	[Address(RVA = "0x314FA24", Offset = "0x314FA24", VA = "0x314FA24")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x60151CA")]
	[Address(RVA = "0x314FA2C", Offset = "0x314FA2C", VA = "0x314FA2C")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
