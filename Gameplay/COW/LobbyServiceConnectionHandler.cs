using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2000D5C")]
internal class LobbyServiceConnectionHandler : ServiceConnectionHandler
{
	[Token(Token = "0x2000D5D")]
	private struct FreatureCache
	{
		[Token(Token = "0x4006B9B")]
		[FieldOffset(Offset = "0x0")]
		public string feature_name;

		[Token(Token = "0x4006B9C")]
		[FieldOffset(Offset = "0x4")]
		public byte[] feature_data;

		[Token(Token = "0x4006B9D")]
		[FieldOffset(Offset = "0x8")]
		public uint data_len;

		[Token(Token = "0x4006B9E")]
		[FieldOffset(Offset = "0xC")]
		public uint data_crc;
	}

	[Token(Token = "0x2000D5E")]
	private sealed class _003COnMsgCustomRoom_003Ec__AnonStorey0
	{
		[Token(Token = "0x4006B9F")]
		[FieldOffset(Offset = "0x8")]
		internal MatchmakingSussNtf resData;

		[Token(Token = "0x4006BA0")]
		[FieldOffset(Offset = "0xC")]
		internal string outAddr;

		[Token(Token = "0x4006BA1")]
		[FieldOffset(Offset = "0x10")]
		internal int outPort;

		[Token(Token = "0x4006BA2")]
		[FieldOffset(Offset = "0x14")]
		internal LobbyServiceConnectionHandler _0024this;

		[Token(Token = "0x60066B3")]
		[Address(RVA = "0x1523430", Offset = "0x1523430", VA = "0x1523430")]
		public _003COnMsgCustomRoom_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60066B4")]
		[Address(RVA = "0x1523438", Offset = "0x1523438", VA = "0x1523438")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2000D5F")]
	private sealed class _003COnMsgCustomRoom_003Ec__AnonStorey1
	{
		[Token(Token = "0x4006BA3")]
		[FieldOffset(Offset = "0x8")]
		internal CreditScoreCheckNtf resData;

		[Token(Token = "0x60066B5")]
		[Address(RVA = "0x1523480", Offset = "0x1523480", VA = "0x1523480")]
		public _003COnMsgCustomRoom_003Ec__AnonStorey1()
		{
		}
	}

	[Token(Token = "0x2000D60")]
	private sealed class _003COnMsgCustomRoom_003Ec__AnonStorey2
	{
		[Token(Token = "0x4006BA4")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x4006BA5")]
		[FieldOffset(Offset = "0xC")]
		internal _003COnMsgCustomRoom_003Ec__AnonStorey1 _003C_003Ef__ref_00241;

		[Token(Token = "0x60066B6")]
		[Address(RVA = "0x1523488", Offset = "0x1523488", VA = "0x1523488")]
		public _003COnMsgCustomRoom_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60066B7")]
		[Address(RVA = "0x1523490", Offset = "0x1523490", VA = "0x1523490")]
		internal bool _003C_003Em__0(GroupMemberInfo value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000D61")]
	private sealed class _003COnMsgFriend_ConfidantOnline_003Ec__AnonStorey3
	{
		[Token(Token = "0x4006BA6")]
		[FieldOffset(Offset = "0x8")]
		internal RelatedFriendOnlineNtf resData;

		[Token(Token = "0x60066B8")]
		[Address(RVA = "0x152354C", Offset = "0x152354C", VA = "0x152354C")]
		public _003COnMsgFriend_ConfidantOnline_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60066B9")]
		[Address(RVA = "0x1523554", Offset = "0x1523554", VA = "0x1523554")]
		internal bool _003C_003Em__0(LeaderBoardInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000D62")]
	private sealed class _003COnMsgGroup_JoinNtf_003Ec__AnonStorey4
	{
		[Token(Token = "0x4006BA7")]
		[FieldOffset(Offset = "0x8")]
		internal GroupMemberInfo memberNew;

		[Token(Token = "0x60066BA")]
		[Address(RVA = "0x15235B4", Offset = "0x15235B4", VA = "0x15235B4")]
		public _003COnMsgGroup_JoinNtf_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60066BB")]
		[Address(RVA = "0x15235BC", Offset = "0x15235BC", VA = "0x15235BC")]
		internal bool _003C_003Em__0(GroupMemberInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000D63")]
	private sealed class _003COnMsgMatchMaking_003Ec__AnonStorey5
	{
		[Token(Token = "0x4006BA8")]
		[FieldOffset(Offset = "0x8")]
		internal MessageNotify res;

		[Token(Token = "0x4006BA9")]
		[FieldOffset(Offset = "0xC")]
		internal LobbyServiceConnectionHandler _0024this;

		[Token(Token = "0x60066BC")]
		[Address(RVA = "0x152362C", Offset = "0x152362C", VA = "0x152362C")]
		public _003COnMsgMatchMaking_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60066BD")]
		[Address(RVA = "0x1523634", Offset = "0x1523634", VA = "0x1523634")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4006B91")]
	[FieldOffset(Offset = "0x0")]
	private static FreatureCache lite_datas;

	[Token(Token = "0x4006B92")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Dictionary<uint, string> MATCHMAKING_ERR_MESSAGE_DICT;

	[Token(Token = "0x4006B93")]
	[FieldOffset(Offset = "0x14")]
	private static readonly Dictionary<uint, string> GROUP_ERR_MESSAGE_DICT;

	[Token(Token = "0x4006B94")]
	[FieldOffset(Offset = "0x18")]
	private static readonly Dictionary<uint, string> CUSTOMROOM_ERR_MESSAGE_DICT;

	[Token(Token = "0x4006B95")]
	[FieldOffset(Offset = "0x1C")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4006B96")]
	[FieldOffset(Offset = "0x20")]
	private static Predicate<RoomPlayerInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4006B97")]
	[FieldOffset(Offset = "0x24")]
	private static Converter<ulong, string> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4006B98")]
	[FieldOffset(Offset = "0x28")]
	private static Converter<ulong, string> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4006B99")]
	[FieldOffset(Offset = "0x2C")]
	private static Predicate<GroupMemberInfo> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4006B9A")]
	[FieldOffset(Offset = "0x30")]
	private static Action _003C_003Ef__am_0024cache5;

	[Token(Token = "0x6006655")]
	[Address(RVA = "0xECFF18", Offset = "0xECFF18", VA = "0xECFF18")]
	public LobbyServiceConnectionHandler(string token)
	{
	}

	[Token(Token = "0x6006656")]
	[Address(RVA = "0xED0C98", Offset = "0xED0C98", VA = "0xED0C98", Slot = "11")]
	public override EServiceHandler GetServiceHandlerName()
	{
		return default(EServiceHandler);
	}

	[Token(Token = "0x6006657")]
	[Address(RVA = "0xED0CF0", Offset = "0xED0CF0", VA = "0xED0CF0", Slot = "9")]
	public override void OnDisconnected(DisconnectedReason reason)
	{
	}

	[Token(Token = "0x6006658")]
	[Address(RVA = "0xED1230", Offset = "0xED1230", VA = "0xED1230")]
	private void OnMsgActivity(MessageNotify res)
	{
	}

	[Token(Token = "0x6006659")]
	[Address(RVA = "0xED1628", Offset = "0xED1628", VA = "0xED1628")]
	private void OnMsgAno(MessageNotify res)
	{
	}

	[Token(Token = "0x600665A")]
	[Address(RVA = "0xED1BE8", Offset = "0xED1BE8", VA = "0xED1BE8")]
	private void OnLightFeatureNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x600665B")]
	[Address(RVA = "0xED2110", Offset = "0xED2110", VA = "0xED2110")]
	private void OnSendDataToClientNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x600665C")]
	[Address(RVA = "0xED2238", Offset = "0xED2238", VA = "0xED2238")]
	private void OnMsgAttendance(MessageNotify res)
	{
	}

	[Token(Token = "0x600665D")]
	[Address(RVA = "0xED2630", Offset = "0xED2630", VA = "0xED2630")]
	private void OnMsgAvatarProfile(MessageNotify res)
	{
	}

	[Token(Token = "0x600665E")]
	[Address(RVA = "0xED2DAC", Offset = "0xED2DAC", VA = "0xED2DAC")]
	private void OnMsgChampionship(MessageNotify res)
	{
	}

	[Token(Token = "0x600665F")]
	[Address(RVA = "0xED35F0", Offset = "0xED35F0", VA = "0xED35F0")]
	private void OnMsgChummy(MessageNotify res)
	{
	}

	[Token(Token = "0x6006660")]
	[Address(RVA = "0xED3A0C", Offset = "0xED3A0C", VA = "0xED3A0C")]
	private void OnMsgClan(MessageNotify res)
	{
	}

	[Token(Token = "0x6006661")]
	[Address(RVA = "0xED4D74", Offset = "0xED4D74", VA = "0xED4D74")]
	private void OnMsgCupMatch(MessageNotify res)
	{
	}

	[Token(Token = "0x6006662")]
	[Address(RVA = "0xED58E4", Offset = "0xED58E4", VA = "0xED58E4")]
	private void OnMsgCustomRoom(MessageNotify res)
	{
	}

	[Token(Token = "0x6006663")]
	[Address(RVA = "0xEDCB00", Offset = "0xEDCB00", VA = "0xEDCB00")]
	private void MatchSuccessLoading(MatchmakingSussNtf resData, string outAddr, int outPort)
	{
	}

	[Token(Token = "0x6006664")]
	[Address(RVA = "0xEDC930", Offset = "0xEDC930", VA = "0xEDC930")]
	private bool CheckIsInBatchRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6006665")]
	[Address(RVA = "0xEDC988", Offset = "0xEDC988", VA = "0xEDC988")]
	private bool CheckIsInRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6006666")]
	[Address(RVA = "0xED10A8", Offset = "0xED10A8", VA = "0xED10A8")]
	private void OnDisconnected_CustomRoom()
	{
	}

	[Token(Token = "0x6006667")]
	[Address(RVA = "0xEDD754", Offset = "0xEDD754", VA = "0xEDD754")]
	private void OnMsgElitePass(MessageNotify res)
	{
	}

	[Token(Token = "0x6006668")]
	[Address(RVA = "0xEDB538", Offset = "0xEDB538", VA = "0xEDB538")]
	private void PopupErrWindow(Dictionary<uint, string> errMsgDict, uint errCode, bool cleanAllPopups = true)
	{
	}

	[Token(Token = "0x6006669")]
	[Address(RVA = "0xEDDC34", Offset = "0xEDDC34", VA = "0xEDDC34")]
	private void OnMsgFresh(MessageNotify res)
	{
	}

	[Token(Token = "0x600666A")]
	[Address(RVA = "0xEDE02C", Offset = "0xEDE02C", VA = "0xEDE02C")]
	private void OnMsgFriend(MessageNotify res)
	{
	}

	[Token(Token = "0x600666B")]
	[Address(RVA = "0xEDE4EC", Offset = "0xEDE4EC", VA = "0xEDE4EC")]
	private void OnMsgFriend_Remove(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x600666C")]
	[Address(RVA = "0xEDF8E8", Offset = "0xEDF8E8", VA = "0xEDF8E8")]
	private void OnReceiveIntimacyChange(byte[] data)
	{
	}

	[Token(Token = "0x600666D")]
	[Address(RVA = "0xEDF6A8", Offset = "0xEDF6A8", VA = "0xEDF6A8")]
	private void OnReceiveRelationshipMsgInfo(byte[] data, tcp.EFriend.Proto cmdType)
	{
	}

	[Token(Token = "0x600666E")]
	[Address(RVA = "0xEDE6E8", Offset = "0xEDE6E8", VA = "0xEDE6E8")]
	private void OnMsgFriend_ConfirmAdd(uint res, byte[] data)
	{
	}

	[Token(Token = "0x600666F")]
	[Address(RVA = "0xEDEC10", Offset = "0xEDEC10", VA = "0xEDEC10")]
	private void OnMsgFriend_ConfidantOnline(uint res, byte[] data)
	{
	}

	[Token(Token = "0x6006670")]
	[Address(RVA = "0xEDFAC4", Offset = "0xEDFAC4", VA = "0xEDFAC4")]
	private void OnMsgGroup(MessageNotify res)
	{
	}

	[Token(Token = "0x6006671")]
	[Address(RVA = "0xEE0A0C", Offset = "0xEE0A0C", VA = "0xEE0A0C")]
	private void OnMsgGroup_Create(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006672")]
	[Address(RVA = "0xEE22D0", Offset = "0xEE22D0", VA = "0xEE22D0")]
	private void OnMsgGroup_LeaveNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006673")]
	[Address(RVA = "0xEE0E40", Offset = "0xEE0E40", VA = "0xEE0E40")]
	private void OnMsgGroup_InviteNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006674")]
	[Address(RVA = "0xEE1188", Offset = "0xEE1188", VA = "0xEE1188")]
	private void OnMsgGroup_AcceptJoinNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006675")]
	[Address(RVA = "0xEE57F0", Offset = "0xEE57F0", VA = "0xEE57F0")]
	private void OnMsgGroup_JoinRequestNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006676")]
	[Address(RVA = "0xEE5B04", Offset = "0xEE5B04", VA = "0xEE5B04")]
	private void OnMsgGroup_ChangePublic(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006677")]
	[Address(RVA = "0xEE5CEC", Offset = "0xEE5CEC", VA = "0xEE5CEC")]
	private void OnMsgGroup_CSRANKINGBAN(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006678")]
	[Address(RVA = "0xEE5F38", Offset = "0xEE5F38", VA = "0xEE5F38")]
	private void OnMsgGroup_ChangeOptionalMapRes(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006679")]
	[Address(RVA = "0xEE6098", Offset = "0xEE6098", VA = "0xEE6098")]
	private void OnMsgGroup_GroupBanNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x600667A")]
	[Address(RVA = "0xEE63EC", Offset = "0xEE63EC", VA = "0xEE63EC")]
	private void OnMsgGroup_RankingBanNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x600667B")]
	[Address(RVA = "0xEE1330", Offset = "0xEE1330", VA = "0xEE1330")]
	private void OnMsgGroup_JoinNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x600667C")]
	[Address(RVA = "0xEE373C", Offset = "0xEE373C", VA = "0xEE373C")]
	private void OnMsgGroup_Info(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x600667D")]
	[Address(RVA = "0xEE28B4", Offset = "0xEE28B4", VA = "0xEE28B4")]
	private void OnMsgGroup_StartNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x600667E")]
	[Address(RVA = "0xEE2CC4", Offset = "0xEE2CC4", VA = "0xEE2CC4")]
	private void OnMsgGroup_StopNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x600667F")]
	[Address(RVA = "0xEE3234", Offset = "0xEE3234", VA = "0xEE3234")]
	private void OnMsgGroup_DismissNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006680")]
	[Address(RVA = "0xEE4688", Offset = "0xEE4688", VA = "0xEE4688")]
	private void OnMsgGroup_ShowEmoteNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006681")]
	[Address(RVA = "0xEE49E8", Offset = "0xEE49E8", VA = "0xEE49E8")]
	private void OnMsgGroup_ShowPetActionNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006682")]
	[Address(RVA = "0xEE4B90", Offset = "0xEE4B90", VA = "0xEE4B90")]
	private void OnMsgGroup_ShowAntiAddiction(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006683")]
	[Address(RVA = "0xEE5270", Offset = "0xEE5270", VA = "0xEE5270")]
	private void OnMsgGroup_ShowTeamMateCheating(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006684")]
	[Address(RVA = "0xED0E64", Offset = "0xED0E64", VA = "0xED0E64")]
	private void OnDisconnected_Group()
	{
	}

	[Token(Token = "0x6006685")]
	[Address(RVA = "0xEE6860", Offset = "0xEE6860", VA = "0xEE6860")]
	private void OnMsgGroup_Ready(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006686")]
	[Address(RVA = "0xEE3A84", Offset = "0xEE3A84", VA = "0xEE3A84")]
	private void OnMsgGroup_ReadyNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006687")]
	[Address(RVA = "0xEE3E58", Offset = "0xEE3E58", VA = "0xEE3E58")]
	private void OnMsgGroup_ChangeNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006688")]
	[Address(RVA = "0xEE44D8", Offset = "0xEE44D8", VA = "0xEE44D8")]
	private void OnMsgGroup_ChangeMapNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006689")]
	[Address(RVA = "0xEE08B8", Offset = "0xEE08B8", VA = "0xEE08B8")]
	private void UpdateGroupInfo(GroupInfo resData, bool isNew = false, bool force = true)
	{
	}

	[Token(Token = "0x600668A")]
	[Address(RVA = "0xEE6740", Offset = "0xEE6740", VA = "0xEE6740")]
	private void UpdateGroupMatchMakingStatus(bool v)
	{
	}

	[Token(Token = "0x600668B")]
	[Address(RVA = "0xEE558C", Offset = "0xEE558C", VA = "0xEE558C")]
	private void OnMsgGroup_GetGroupCodeNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x600668C")]
	[Address(RVA = "0xEE5998", Offset = "0xEE5998", VA = "0xEE5998")]
	private void OnChangeAvailableMapsNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x600668D")]
	[Address(RVA = "0xEE6B28", Offset = "0xEE6B28", VA = "0xEE6B28")]
	private void OnMsgInventory(MessageNotify res)
	{
	}

	[Token(Token = "0x600668E")]
	[Address(RVA = "0xEE7CC0", Offset = "0xEE7CC0", VA = "0xEE7CC0")]
	private void OnMsgBackpack(MessageNotify res)
	{
	}

	[Token(Token = "0x600668F")]
	[Address(RVA = "0xEE7E1C", Offset = "0xEE7E1C", VA = "0xEE7E1C")]
	private void OnMsgLimitedEvent(MessageNotify res)
	{
	}

	[Token(Token = "0x6006690")]
	[Address(RVA = "0xEE83E8", Offset = "0xEE83E8", VA = "0xEE83E8")]
	private void OnMsgMail(MessageNotify res)
	{
	}

	[Token(Token = "0x6006691")]
	[Address(RVA = "0xEE8D44", Offset = "0xEE8D44", VA = "0xEE8D44")]
	private void OnMsgMatchMaking(MessageNotify res)
	{
	}

	[Token(Token = "0x6006692")]
	[Address(RVA = "0xEECBCC", Offset = "0xEECBCC", VA = "0xEECBCC")]
	private void OnMsgMatchMakingRankingBannedNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006693")]
	[Address(RVA = "0xEED018", Offset = "0xEED018", VA = "0xEED018")]
	private void OnMsgMatchMakingTeammateRankingBannedNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006694")]
	[Address(RVA = "0xEEC994", Offset = "0xEEC994", VA = "0xEEC994")]
	private void OnMsgMatchMakingStopNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006695")]
	[Address(RVA = "0xEEC240", Offset = "0xEEC240", VA = "0xEEC240")]
	private void OnMsgMatchMakingStartNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006696")]
	[Address(RVA = "0xEEADAC", Offset = "0xEEADAC", VA = "0xEEADAC")]
	private void OnMsgMatchMakingSussNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006697")]
	[Address(RVA = "0xEEC474", Offset = "0xEEC474", VA = "0xEEC474")]
	private void OnMsgGameOpeningInfoNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006698")]
	[Address(RVA = "0xEEC5E0", Offset = "0xEEC5E0", VA = "0xEEC5E0")]
	private void OnMsgGameAntiAddicTionNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x6006699")]
	[Address(RVA = "0xED0F84", Offset = "0xED0F84", VA = "0xED0F84")]
	private void OnDisconnected_MatchMaking()
	{
	}

	[Token(Token = "0x600669A")]
	[Address(RVA = "0xEED3E8", Offset = "0xEED3E8", VA = "0xEED3E8")]
	private void OnMsgGameServerManager(MessageNotify res)
	{
	}

	[Token(Token = "0x600669B")]
	[Address(RVA = "0xEED474", Offset = "0xEED474", VA = "0xEED474")]
	private void OnMsgGSMDebugSussNtf(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x600669C")]
	[Address(RVA = "0xEEDC84", Offset = "0xEEDC84", VA = "0xEEDC84")]
	private void OnMsgMatchStats(MessageNotify res)
	{
	}

	[Token(Token = "0x600669D")]
	[Address(RVA = "0xEEE05C", Offset = "0xEEE05C", VA = "0xEEE05C")]
	private proto.EAntiAddiction.TotalTimeBanMode IntConvertToEnum(int i)
	{
		return default(proto.EAntiAddiction.TotalTimeBanMode);
	}

	[Token(Token = "0x600669E")]
	[Address(RVA = "0xEEE25C", Offset = "0xEEE25C", VA = "0xEEE25C")]
	private void OnMsgAntiaddiction(MessageNotify res)
	{
	}

	[Token(Token = "0x600669F")]
	[Address(RVA = "0xEEF8E0", Offset = "0xEEF8E0", VA = "0xEEF8E0")]
	private void OnMsgPetExpChange(MessageNotify res)
	{
	}

	[Token(Token = "0x60066A0")]
	[Address(RVA = "0xEEFA44", Offset = "0xEEFA44", VA = "0xEEFA44")]
	private void OnMsgPresence(MessageNotify res)
	{
	}

	[Token(Token = "0x60066A1")]
	[Address(RVA = "0xEEFD7C", Offset = "0xEEFD7C", VA = "0xEEFD7C")]
	private void OnTCPPresnceListNtf(byte[] data)
	{
	}

	[Token(Token = "0x60066A2")]
	[Address(RVA = "0xEEFED0", Offset = "0xEEFED0", VA = "0xEEFED0")]
	private void OnMsgCredit(MessageNotify res)
	{
	}

	[Token(Token = "0x60066A3")]
	[Address(RVA = "0xEF0920", Offset = "0xEF0920", VA = "0xEF0920")]
	private void OnMsgReconnection(MessageNotify res)
	{
	}

	[Token(Token = "0x60066A4")]
	[Address(RVA = "0xEF113C", Offset = "0xEF113C", VA = "0xEF113C")]
	private void OnMsgHasLatestGameInfo(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x60066A5")]
	[Address(RVA = "0xEF1AA4", Offset = "0xEF1AA4", VA = "0xEF1AA4")]
	private void OnMsgHasLatestRoomInfo(uint ret, byte[] data)
	{
	}

	[Token(Token = "0x60066A6")]
	[Address(RVA = "0xEF210C", Offset = "0xEF210C", VA = "0xEF210C")]
	private void OnMsgStore(MessageNotify res)
	{
	}

	[Token(Token = "0x60066A7")]
	[Address(RVA = "0xEF2630", Offset = "0xEF2630", VA = "0xEF2630")]
	private void OnMsgUpdateUser(MessageNotify res)
	{
	}

	[Token(Token = "0x60066A8")]
	[Address(RVA = "0xEF2AC8", Offset = "0xEF2AC8", VA = "0xEF2AC8")]
	private void OnMsgVIPCard(MessageNotify res)
	{
	}

	[Token(Token = "0x60066A9")]
	[Address(RVA = "0xEF2EC4", Offset = "0xEF2EC4", VA = "0xEF2EC4")]
	private void OnMsgWorkShop(MessageNotify res)
	{
	}

	[Token(Token = "0x60066AB")]
	[Address(RVA = "0xEF56C4", Offset = "0xEF56C4", VA = "0xEF56C4")]
	private static void _003COnLightFeatureNtf_003Em__0()
	{
	}

	[Token(Token = "0x60066AC")]
	[Address(RVA = "0xEF5860", Offset = "0xEF5860", VA = "0xEF5860")]
	private static bool _003COnMsgCustomRoom_003Em__1(RoomPlayerInfo a)
	{
		return default(bool);
	}

	[Token(Token = "0x60066AD")]
	[Address(RVA = "0xEF5974", Offset = "0xEF5974", VA = "0xEF5974")]
	private static string _003COnMsgCustomRoom_003Em__2(ulong e)
	{
		return null;
	}

	[Token(Token = "0x60066AE")]
	[Address(RVA = "0xEF5994", Offset = "0xEF5994", VA = "0xEF5994")]
	private static string _003COnMsgCustomRoom_003Em__3(ulong i)
	{
		return null;
	}

	[Token(Token = "0x60066AF")]
	[Address(RVA = "0xEF59B4", Offset = "0xEF59B4", VA = "0xEF59B4")]
	private static bool _003COnMsgGroup_JoinNtf_003Em__4(GroupMemberInfo m)
	{
		return default(bool);
	}

	[Token(Token = "0x60066B0")]
	[Address(RVA = "0xEF5A80", Offset = "0xEF5A80", VA = "0xEF5A80")]
	private static void _003COnMsgHasLatestRoomInfo_003Em__5()
	{
	}

	[Token(Token = "0x60066B1")]
	[Address(RVA = "0xEF5CF8", Offset = "0xEF5CF8", VA = "0xEF5CF8")]
	public EServiceHandler _003C_003EiFixBaseProxy_GetServiceHandlerName()
	{
		return default(EServiceHandler);
	}

	[Token(Token = "0x60066B2")]
	[Address(RVA = "0xEF5D00", Offset = "0xEF5D00", VA = "0xEF5D00")]
	public void _003C_003EiFixBaseProxy_OnDisconnected(DisconnectedReason P0)
	{
	}
}
