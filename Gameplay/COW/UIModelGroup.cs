using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using tcp;

namespace COW;

[Token(Token = "0x200309B")]
internal class UIModelGroup : UIBaseModel
{
	[Token(Token = "0x200309C")]
	public enum IntentToDo
	{
		[Token(Token = "0x40127DB")]
		None,
		[Token(Token = "0x40127DC")]
		Invite,
		[Token(Token = "0x40127DD")]
		Recruit
	}

	[Token(Token = "0x200309D")]
	public class IntentInviteInfo
	{
		[Token(Token = "0x40127DE")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_AccountID;

		[Token(Token = "0x40127DF")]
		[FieldOffset(Offset = "0x10")]
		public string m_Region;

		[Token(Token = "0x40127E0")]
		[FieldOffset(Offset = "0x14")]
		public EGroup.InviteChannelType m_Channel;

		[Token(Token = "0x40127E1")]
		[FieldOffset(Offset = "0x18")]
		public EGroup.InviteeType m_InviteeType;

		[Token(Token = "0x6014589")]
		[Address(RVA = "0x12AF644", Offset = "0x12AF644", VA = "0x12AF644")]
		public IntentInviteInfo(ulong account_id, string region, EGroup.InviteChannelType channel, EGroup.InviteeType inviteeType = EGroup.InviteeType.InviteeType_NONE)
		{
		}
	}

	[Token(Token = "0x200309E")]
	private sealed class _003CRequestCreateGroup_003Ec__AnonStorey0
	{
		[Token(Token = "0x40127E2")]
		[FieldOffset(Offset = "0x8")]
		internal List<uint> map_ids;

		[Token(Token = "0x40127E3")]
		[FieldOffset(Offset = "0xC")]
		internal bool isRanking;

		[Token(Token = "0x40127E4")]
		[FieldOffset(Offset = "0x10")]
		internal uint game_mode;

		[Token(Token = "0x40127E5")]
		[FieldOffset(Offset = "0x14")]
		internal HHDIPHFOBFO group_mode;

		[Token(Token = "0x40127E6")]
		[FieldOffset(Offset = "0x18")]
		internal uint difficulty;

		[Token(Token = "0x40127E7")]
		[FieldOffset(Offset = "0x1C")]
		internal uint match_mode;

		[Token(Token = "0x40127E8")]
		[FieldOffset(Offset = "0x20")]
		internal EGroup.CreateFromType fromType;

		[Token(Token = "0x40127E9")]
		[FieldOffset(Offset = "0x24")]
		internal bool isRandomMap;

		[Token(Token = "0x40127EA")]
		[FieldOffset(Offset = "0x28")]
		internal uint requireRank;

		[Token(Token = "0x40127EB")]
		[FieldOffset(Offset = "0x2C")]
		internal string groupTag;

		[Token(Token = "0x40127EC")]
		[FieldOffset(Offset = "0x30")]
		internal UIModelGroup _0024this;

		[Token(Token = "0x601458A")]
		[Address(RVA = "0x12A6724", Offset = "0x12A6724", VA = "0x12A6724")]
		public _003CRequestCreateGroup_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601458B")]
		[Address(RVA = "0x12B56B4", Offset = "0x12B56B4", VA = "0x12B56B4")]
		internal void _003C_003Em__0(ResErrorCode error, ResDownloadType download_type)
		{
		}
	}

	[Token(Token = "0x200309F")]
	private sealed class _003CRequestJoinGroup_003Ec__AnonStorey1
	{
		[Token(Token = "0x40127ED")]
		[FieldOffset(Offset = "0x8")]
		internal ulong account_id;

		[Token(Token = "0x40127EE")]
		[FieldOffset(Offset = "0x10")]
		internal ulong groupId;

		[Token(Token = "0x40127EF")]
		[FieldOffset(Offset = "0x18")]
		internal EGroup.InviteeType inviteType;

		[Token(Token = "0x40127F0")]
		[FieldOffset(Offset = "0x1C")]
		internal UIModelGroup _0024this;

		[Token(Token = "0x601458C")]
		[Address(RVA = "0x12A809C", Offset = "0x12A809C", VA = "0x12A809C")]
		public _003CRequestJoinGroup_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601458D")]
		[Address(RVA = "0x12B583C", Offset = "0x12B583C", VA = "0x12B583C")]
		internal void _003C_003Em__0(ResErrorCode error, ResDownloadType download_type)
		{
		}
	}

	[Token(Token = "0x20030A0")]
	private sealed class _003CRequestAccept_003Ec__AnonStorey2
	{
		[Token(Token = "0x40127F1")]
		[FieldOffset(Offset = "0x8")]
		internal ulong group_id;

		[Token(Token = "0x40127F2")]
		[FieldOffset(Offset = "0x10")]
		internal string region;

		[Token(Token = "0x40127F3")]
		[FieldOffset(Offset = "0x18")]
		internal ulong inviterid;

		[Token(Token = "0x40127F4")]
		[FieldOffset(Offset = "0x20")]
		internal string group_code;

		[Token(Token = "0x40127F5")]
		[FieldOffset(Offset = "0x24")]
		internal EGroup.InviteChannelType channel;

		[Token(Token = "0x40127F6")]
		[FieldOffset(Offset = "0x28")]
		internal string secretCode;

		[Token(Token = "0x40127F7")]
		[FieldOffset(Offset = "0x2C")]
		internal bool autoAccept;

		[Token(Token = "0x40127F8")]
		[FieldOffset(Offset = "0x30")]
		internal UIModelGroup _0024this;

		[Token(Token = "0x601458E")]
		[Address(RVA = "0x12A9868", Offset = "0x12A9868", VA = "0x12A9868")]
		public _003CRequestAccept_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x601458F")]
		[Address(RVA = "0x12B563C", Offset = "0x12B563C", VA = "0x12B563C")]
		internal void _003C_003Em__0(ResErrorCode error, ResDownloadType type)
		{
		}
	}

	[Token(Token = "0x20030A1")]
	private sealed class _003CRequestKickout_003Ec__AnonStorey3
	{
		[Token(Token = "0x40127F9")]
		[FieldOffset(Offset = "0x8")]
		internal ulong kickout_id;

		[Token(Token = "0x6014590")]
		[Address(RVA = "0x12AB7A8", Offset = "0x12AB7A8", VA = "0x12AB7A8")]
		public _003CRequestKickout_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6014591")]
		[Address(RVA = "0x12B5980", Offset = "0x12B5980", VA = "0x12B5980")]
		internal bool _003C_003Em__0(GroupMemberInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030A2")]
	private sealed class _003CUpdateGroupInfo_003Ec__AnonStorey4
	{
		[Token(Token = "0x40127FA")]
		[FieldOffset(Offset = "0x8")]
		internal ulong myId;

		[Token(Token = "0x6014592")]
		[Address(RVA = "0x12AEF6C", Offset = "0x12AEF6C", VA = "0x12AEF6C")]
		public _003CUpdateGroupInfo_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6014593")]
		[Address(RVA = "0x12B59DC", Offset = "0x12B59DC", VA = "0x12B59DC")]
		internal bool _003C_003Em__0(GroupMemberInfo m)
		{
			return default(bool);
		}

		[Token(Token = "0x6014594")]
		[Address(RVA = "0x12B5A28", Offset = "0x12B5A28", VA = "0x12B5A28")]
		internal bool _003C_003Em__1(GroupMemberInfo mem)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030A3")]
	private sealed class _003CCheckMemberLackOfMaps_003Ec__AnonStorey5
	{
		[Token(Token = "0x40127FB")]
		[FieldOffset(Offset = "0x8")]
		internal uint mapId;

		[Token(Token = "0x6014595")]
		[Address(RVA = "0x12B2CA8", Offset = "0x12B2CA8", VA = "0x12B2CA8")]
		public _003CCheckMemberLackOfMaps_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6014596")]
		[Address(RVA = "0x12B55E8", Offset = "0x12B55E8", VA = "0x12B55E8")]
		internal bool _003C_003Em__0(uint a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030A4")]
	private sealed class _003CCheckAndShowEmulatorWarningTip_003Ec__AnonStorey6
	{
		[Token(Token = "0x40127FC")]
		[FieldOffset(Offset = "0x8")]
		internal ulong memberAccountId;

		[Token(Token = "0x6014597")]
		[Address(RVA = "0x12B3C1C", Offset = "0x12B3C1C", VA = "0x12B3C1C")]
		public _003CCheckAndShowEmulatorWarningTip_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6014598")]
		[Address(RVA = "0x12B5598", Offset = "0x12B5598", VA = "0x12B5598")]
		internal bool _003C_003Em__0(GroupMemberInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030A5")]
	private sealed class _003CCheckNewMemberCreditScorePunishTip_003Ec__AnonStorey7
	{
		[Token(Token = "0x40127FD")]
		[FieldOffset(Offset = "0x8")]
		internal ulong memberAccountId;

		[Token(Token = "0x6014599")]
		[Address(RVA = "0x12B3C24", Offset = "0x12B3C24", VA = "0x12B3C24")]
		public _003CCheckNewMemberCreditScorePunishTip_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x601459A")]
		[Address(RVA = "0x12B55FC", Offset = "0x12B55FC", VA = "0x12B55FC")]
		internal bool _003C_003Em__0(GroupMemberInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40127B9")]
	[FieldOffset(Offset = "0xC")]
	public GroupInfo GroupInfo;

	[Token(Token = "0x40127BA")]
	[FieldOffset(Offset = "0x10")]
	public GroupMemberInfo MyInfo;

	[Token(Token = "0x40127BB")]
	[FieldOffset(Offset = "0x14")]
	public GroupInviteNtf InviterGroupInfo;

	[Token(Token = "0x40127BC")]
	[FieldOffset(Offset = "0x18")]
	private List<ulong> m_GroupMemberIds;

	[Token(Token = "0x40127BD")]
	[FieldOffset(Offset = "0x1C")]
	public HHDIPHFOBFO GroupMode;

	[Token(Token = "0x40127BE")]
	[FieldOffset(Offset = "0x20")]
	public bool IsAutoMatch;

	[Token(Token = "0x40127BF")]
	[FieldOffset(Offset = "0x21")]
	public bool AllReady;

	[Token(Token = "0x40127C0")]
	[FieldOffset(Offset = "0x24")]
	private int m_SpecialReason;

	[Token(Token = "0x40127C1")]
	[FieldOffset(Offset = "0x0")]
	public static int GROUP_DUO_MEMBER_COUNT;

	[Token(Token = "0x40127C2")]
	[FieldOffset(Offset = "0x4")]
	public static int GROUP_QUARD_MEMBER_COUNT;

	[Token(Token = "0x40127C3")]
	public const uint PropID_GroupInfo_Update = 2u;

	[Token(Token = "0x40127C4")]
	public const uint PropID_GroupInfo_Clear = 4u;

	[Token(Token = "0x40127C5")]
	[FieldOffset(Offset = "0x28")]
	private IntentToDo m_IntentAfterCreate;

	[Token(Token = "0x40127C6")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_CacheInvite;

	[Token(Token = "0x40127C7")]
	[FieldOffset(Offset = "0x30")]
	private ulong InviteId;

	[Token(Token = "0x40127C8")]
	[FieldOffset(Offset = "0x38")]
	private string InviteRegion;

	[Token(Token = "0x40127C9")]
	[FieldOffset(Offset = "0x3C")]
	public bool HDEnterTeam;

	[Token(Token = "0x40127CA")]
	[FieldOffset(Offset = "0x3D")]
	private bool m_IsInGroup;

	[Token(Token = "0x40127CB")]
	[FieldOffset(Offset = "0x3E")]
	public bool RepairIdleReturnInGroup;

	[Token(Token = "0x40127CC")]
	[FieldOffset(Offset = "0x40")]
	private string m_GroupCaptainNickName;

	[Token(Token = "0x40127CD")]
	[FieldOffset(Offset = "0x44")]
	private bool _003CIsGroupLeader_003Ek__BackingField;

	[Token(Token = "0x40127CE")]
	[FieldOffset(Offset = "0x45")]
	private bool m_IsGroupPublic;

	[Token(Token = "0x40127CF")]
	[FieldOffset(Offset = "0x46")]
	public bool IsGroupMatchMaking;

	[Token(Token = "0x40127D0")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<ulong, ulong> m_IgnorePlayerDict;

	[Token(Token = "0x40127D1")]
	[FieldOffset(Offset = "0x4C")]
	public EGroup.InviteeType LastInviteeType;

	[Token(Token = "0x40127D2")]
	[FieldOffset(Offset = "0x50")]
	public ulong LastParticipantId;

	[Token(Token = "0x40127D3")]
	[FieldOffset(Offset = "0x58")]
	private List<IntentInviteInfo> m_IntentInviteInfoList;

	[Token(Token = "0x40127D4")]
	[FieldOffset(Offset = "0x5C")]
	public bool EnableEmulatorWarning;

	[Token(Token = "0x40127D5")]
	[FieldOffset(Offset = "0x5D")]
	private bool m_HasPopedEmulatorWarningTip;

	[Token(Token = "0x40127D6")]
	[FieldOffset(Offset = "0x8")]
	private static Func<uint, string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40127D7")]
	[FieldOffset(Offset = "0xC")]
	private static Func<string, string, string> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x40127D8")]
	[FieldOffset(Offset = "0x10")]
	private static Converter<MapModeData, uint> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x40127D9")]
	[FieldOffset(Offset = "0x14")]
	private static Converter<MapModeData, uint> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x17001520")]
	public bool IsInGroup
	{
		[Token(Token = "0x6014533")]
		[Address(RVA = "0x12A50F0", Offset = "0x12A50F0", VA = "0x12A50F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014534")]
		[Address(RVA = "0x12A5148", Offset = "0x12A5148", VA = "0x12A5148")]
		set
		{
		}
	}

	[Token(Token = "0x17001521")]
	public string GroupCapatainNickName
	{
		[Token(Token = "0x6014535")]
		[Address(RVA = "0x12A51A8", Offset = "0x12A51A8", VA = "0x12A51A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014536")]
		[Address(RVA = "0x12A5200", Offset = "0x12A5200", VA = "0x12A5200")]
		private set
		{
		}
	}

	[Token(Token = "0x17001522")]
	public bool IsGroupLeader
	{
		[Token(Token = "0x6014537")]
		[Address(RVA = "0x12A5260", Offset = "0x12A5260", VA = "0x12A5260")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014538")]
		[Address(RVA = "0x12A5268", Offset = "0x12A5268", VA = "0x12A5268")]
		private set
		{
		}
	}

	[Token(Token = "0x17001523")]
	public bool IsGroupPublic
	{
		[Token(Token = "0x6014539")]
		[Address(RVA = "0x12A5270", Offset = "0x12A5270", VA = "0x12A5270")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601453A")]
		[Address(RVA = "0x12A52C8", Offset = "0x12A52C8", VA = "0x12A52C8")]
		set
		{
		}
	}

	[Token(Token = "0x17001524")]
	public bool IsRankingMatch
	{
		[Token(Token = "0x601453B")]
		[Address(RVA = "0x12A5328", Offset = "0x12A5328", VA = "0x12A5328")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001525")]
	public bool IsCSRankingMatch
	{
		[Token(Token = "0x601453C")]
		[Address(RVA = "0x12A542C", Offset = "0x12A542C", VA = "0x12A542C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001526")]
	public uint GameMode
	{
		[Token(Token = "0x601453D")]
		[Address(RVA = "0x12A5530", Offset = "0x12A5530", VA = "0x12A5530")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x601452E")]
	[Address(RVA = "0x12A45CC", Offset = "0x12A45CC", VA = "0x12A45CC")]
	public UIModelGroup()
	{
	}

	[Token(Token = "0x601452F")]
	[Address(RVA = "0x12A4748", Offset = "0x12A4748", VA = "0x12A4748", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014530")]
	[Address(RVA = "0x12A47A0", Offset = "0x12A47A0", VA = "0x12A47A0")]
	public void CacheInviteData(ulong id, string region)
	{
	}

	[Token(Token = "0x6014531")]
	[Address(RVA = "0x12A4830", Offset = "0x12A4830", VA = "0x12A4830")]
	public void ClearCacheInviteData()
	{
	}

	[Token(Token = "0x6014532")]
	[Address(RVA = "0x12A491C", Offset = "0x12A491C", VA = "0x12A491C")]
	public void SendCacheData()
	{
	}

	[Token(Token = "0x601453E")]
	[Address(RVA = "0x12A5624", Offset = "0x12A5624", VA = "0x12A5624")]
	public void AddIgnorePlayer(ulong accountId)
	{
	}

	[Token(Token = "0x601453F")]
	[Address(RVA = "0x12A57F8", Offset = "0x12A57F8", VA = "0x12A57F8")]
	public void RemoveIgnorePlayer(ulong accountId)
	{
	}

	[Token(Token = "0x6014540")]
	[Address(RVA = "0x12A5920", Offset = "0x12A5920", VA = "0x12A5920")]
	public bool HasRelationshipPlayerInGroup(ulong friendID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014541")]
	[Address(RVA = "0x12A5B40", Offset = "0x12A5B40", VA = "0x12A5B40")]
	public bool CheckIsInIgnoreList(ulong accountId)
	{
		return default(bool);
	}

	[Token(Token = "0x6014542")]
	[Address(RVA = "0x12A5CD8", Offset = "0x12A5CD8", VA = "0x12A5CD8")]
	public bool ReachMaxGroupCount()
	{
		return default(bool);
	}

	[Token(Token = "0x6014543")]
	[Address(RVA = "0x12A5DE8", Offset = "0x12A5DE8", VA = "0x12A5DE8")]
	public bool CheckIsMatchMaking(bool showTips = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6014544")]
	[Address(RVA = "0x12A6088", Offset = "0x12A6088", VA = "0x12A6088")]
	public void RequestCreateGroup(List<uint> map_ids, bool isRanking = false, uint game_mode = 1u, HHDIPHFOBFO group_mode = HHDIPHFOBFO.EGROUPMODE_DUAL, uint difficulty = 0u, uint match_mode = 1u, EGroup.CreateFromType fromType = EGroup.CreateFromType.CreateFromType_OWNSELF, bool isRandomMap = false, uint requireRank = 0u, string groupTag = "")
	{
	}

	[Token(Token = "0x6014545")]
	[Address(RVA = "0x12A672C", Offset = "0x12A672C", VA = "0x12A672C")]
	private void RequestCreateGroupInternal(List<uint> map_ids, bool isRanking = false, uint game_mode = 1u, HHDIPHFOBFO group_mode = HHDIPHFOBFO.EGROUPMODE_DUAL, uint difficulty = 0u, uint match_mode = 1u, EGroup.CreateFromType fromType = EGroup.CreateFromType.CreateFromType_OWNSELF, bool isRandomMap = false, uint requireRank = 0u, string groupTag = "")
	{
	}

	[Token(Token = "0x6014546")]
	[Address(RVA = "0x12A7B98", Offset = "0x12A7B98", VA = "0x12A7B98")]
	public void RequestJoinGroup(ulong account_id, ulong groupId, EGroup.InviteeType inviteType)
	{
	}

	[Token(Token = "0x6014547")]
	[Address(RVA = "0x12A80A4", Offset = "0x12A80A4", VA = "0x12A80A4")]
	private void RequestJoinGroupInternal(ulong account_id, ulong groupId, EGroup.InviteeType inviteType)
	{
	}

	[Token(Token = "0x6014548")]
	[Address(RVA = "0x12A4A78", Offset = "0x12A4A78", VA = "0x12A4A78")]
	public void RequestInvite(ulong account_id, string region, EGroup.InviteChannelType channel, EGroup.InviteeType inviteeType = EGroup.InviteeType.InviteeType_NONE)
	{
	}

	[Token(Token = "0x6014549")]
	[Address(RVA = "0x12A9258", Offset = "0x12A9258", VA = "0x12A9258")]
	public void RequestAccept(ulong group_id, string region, ulong inviterid = 0uL, string group_code = "", EGroup.InviteChannelType channel = EGroup.InviteChannelType.InviteChannelType_PLAYER, string secretCode = "", bool autoAccept = false)
	{
	}

	[Token(Token = "0x601454A")]
	[Address(RVA = "0x12A9870", Offset = "0x12A9870", VA = "0x12A9870")]
	private void RequestAcceptInternal(ulong group_id, string region, ulong inviterid = 0uL, string group_code = "", EGroup.InviteChannelType channel = EGroup.InviteChannelType.InviteChannelType_PLAYER, string secretCode = "", bool autoAccept = false)
	{
	}

	[Token(Token = "0x601454B")]
	[Address(RVA = "0x12AA730", Offset = "0x12AA730", VA = "0x12AA730")]
	public void RequestRefuse(ulong group_id, string region, GroupInviteNtf inviteNtfData)
	{
	}

	[Token(Token = "0x601454C")]
	[Address(RVA = "0x12AA9B8", Offset = "0x12AA9B8", VA = "0x12AA9B8")]
	public void RequestAcceptGroupJoinRequest(ulong group_id, GroupJoinRequestNtf ntf)
	{
	}

	[Token(Token = "0x601454D")]
	[Address(RVA = "0x12AABC8", Offset = "0x12AABC8", VA = "0x12AABC8")]
	public void RequestRefuseGroupJoinRequest(ulong group_id, GroupJoinRequestNtf inviteNtfData)
	{
	}

	[Token(Token = "0x601454E")]
	[Address(RVA = "0x12AAEE8", Offset = "0x12AAEE8", VA = "0x12AAEE8")]
	public void RequestLeave()
	{
	}

	[Token(Token = "0x601454F")]
	[Address(RVA = "0x12AB540", Offset = "0x12AB540", VA = "0x12AB540")]
	public void RequestKickout(ulong kickout_id)
	{
	}

	[Token(Token = "0x6014550")]
	[Address(RVA = "0x12AB7B0", Offset = "0x12AB7B0", VA = "0x12AB7B0")]
	public void RequestChangePubPvt(bool isPublic)
	{
	}

	[Token(Token = "0x6014551")]
	[Address(RVA = "0x12AB918", Offset = "0x12AB918", VA = "0x12AB918")]
	public void RequestSyncOptionalMapResStatus(EGroup.PlayerPatchOptionalResStatus status)
	{
	}

	[Token(Token = "0x6014552")]
	[Address(RVA = "0x12ABD0C", Offset = "0x12ABD0C", VA = "0x12ABD0C")]
	public void RefreshOptionalMapResStatus(SyncPatchOptionalResStatusNtf resData)
	{
	}

	[Token(Token = "0x6014553")]
	[Address(RVA = "0x12AC0E0", Offset = "0x12AC0E0", VA = "0x12AC0E0")]
	public void RequestShowEmote(uint _eid, [Optional] List<AccountEmoteRandomID> randomLst)
	{
	}

	[Token(Token = "0x6014554")]
	[Address(RVA = "0x12AC340", Offset = "0x12AC340", VA = "0x12AC340")]
	public List<ulong> GetFriendsInGroup()
	{
		return null;
	}

	[Token(Token = "0x6014555")]
	[Address(RVA = "0x12AC6AC", Offset = "0x12AC6AC", VA = "0x12AC6AC")]
	public ulong GetMentorInGroup()
	{
		return default(ulong);
	}

	[Token(Token = "0x6014556")]
	[Address(RVA = "0x12ACA00", Offset = "0x12ACA00", VA = "0x12ACA00")]
	public void RequestStart()
	{
	}

	[Token(Token = "0x6014557")]
	[Address(RVA = "0x12ACEAC", Offset = "0x12ACEAC", VA = "0x12ACEAC")]
	public void RequestStop()
	{
	}

	[Token(Token = "0x6014558")]
	[Address(RVA = "0x12AD16C", Offset = "0x12AD16C", VA = "0x12AD16C")]
	public void RequestGroupInfo()
	{
	}

	[Token(Token = "0x6014559")]
	[Address(RVA = "0x12AD2FC", Offset = "0x12AD2FC", VA = "0x12AD2FC")]
	public void RequestUpdateMaps(List<uint> maps)
	{
	}

	[Token(Token = "0x601455A")]
	[Address(RVA = "0x12AD524", Offset = "0x12AD524", VA = "0x12AD524")]
	public void UpdatePlayerAvailableMaps(GroupChangeAvailableMapsNtf info)
	{
	}

	[Token(Token = "0x601455B")]
	[Address(RVA = "0x12AD77C", Offset = "0x12AD77C", VA = "0x12AD77C")]
	public static bool IsForceAutoMatchGameMode(uint gamemode)
	{
		return default(bool);
	}

	[Token(Token = "0x601455C")]
	[Address(RVA = "0x12AD8C4", Offset = "0x12AD8C4", VA = "0x12AD8C4")]
	public bool IsCantSoloMatchMakingGame(uint gamemode)
	{
		return default(bool);
	}

	[Token(Token = "0x601455D")]
	[Address(RVA = "0x12AD934", Offset = "0x12AD934", VA = "0x12AD934")]
	public bool CheckCrashMap(uint[] mapMode, uint matchMode)
	{
		return default(bool);
	}

	[Token(Token = "0x601455E")]
	[Address(RVA = "0x12ADD84", Offset = "0x12ADD84", VA = "0x12ADD84")]
	public void UpdateGroupInfo(GroupInfo resData, bool isNew = false, bool forcerefreshavatar = true)
	{
	}

	[Token(Token = "0x601455F")]
	[Address(RVA = "0x12AEF74", Offset = "0x12AEF74", VA = "0x12AEF74")]
	public void SetAfterCreateIntent(IntentToDo todo)
	{
	}

	[Token(Token = "0x6014560")]
	[Address(RVA = "0x12AF180", Offset = "0x12AF180", VA = "0x12AF180")]
	public void DoAfterCreateGroup()
	{
	}

	[Token(Token = "0x6014561")]
	[Address(RVA = "0x12AF524", Offset = "0x12AF524", VA = "0x12AF524")]
	public void SetIntentInviteInfo(ulong account_id, string region, EGroup.InviteChannelType channel, EGroup.InviteeType inviteeType = EGroup.InviteeType.InviteeType_NONE)
	{
	}

	[Token(Token = "0x6014562")]
	[Address(RVA = "0x12AF2C8", Offset = "0x12AF2C8", VA = "0x12AF2C8")]
	public void DoIntentInvite()
	{
	}

	[Token(Token = "0x6014563")]
	[Address(RVA = "0x12AF0C0", Offset = "0x12AF0C0", VA = "0x12AF0C0")]
	public void ClearIntentInviteInfo()
	{
	}

	[Token(Token = "0x6014564")]
	[Address(RVA = "0x12AF684", Offset = "0x12AF684", VA = "0x12AF684")]
	public void UpdateInviterGroupInfo(GroupInviteNtf resData)
	{
	}

	[Token(Token = "0x6014565")]
	[Address(RVA = "0x12AF6E4", Offset = "0x12AF6E4", VA = "0x12AF6E4")]
	public List<ulong> GetMemberIds()
	{
		return null;
	}

	[Token(Token = "0x6014566")]
	[Address(RVA = "0x12AB314", Offset = "0x12AB314", VA = "0x12AB314")]
	public void ClearData()
	{
	}

	[Token(Token = "0x6014567")]
	[Address(RVA = "0x12AF9A8", Offset = "0x12AF9A8", VA = "0x12AF9A8")]
	public int GetGroupMembersCount()
	{
		return default(int);
	}

	[Token(Token = "0x6014568")]
	[Address(RVA = "0x12AFA84", Offset = "0x12AFA84", VA = "0x12AFA84", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6014569")]
	[Address(RVA = "0x12AFE74", Offset = "0x12AFE74", VA = "0x12AFE74", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x601456A")]
	[Address(RVA = "0x12B0038", Offset = "0x12B0038", VA = "0x12B0038")]
	public void SetGroupMode(HHDIPHFOBFO mode, bool request = true)
	{
	}

	[Token(Token = "0x601456B")]
	[Address(RVA = "0x12B19E0", Offset = "0x12B19E0", VA = "0x12B19E0")]
	public void SetAutoMatch(bool v)
	{
	}

	[Token(Token = "0x601456C")]
	[Address(RVA = "0x12B18B0", Offset = "0x12B18B0", VA = "0x12B18B0")]
	public void RequestGroupChange(MapModeData mapData, uint difficutly = 0u, uint rankLimit = 0u, string groupTags = "")
	{
	}

	[Token(Token = "0x601456D")]
	[Address(RVA = "0x12B030C", Offset = "0x12B030C", VA = "0x12B030C")]
	public void RequestGroupChange(List<MapModeData> mapsData, uint difficutly = 0u, uint rankLimit = 0u, string groupTags = "")
	{
	}

	[Token(Token = "0x601456E")]
	[Address(RVA = "0x12B1CA4", Offset = "0x12B1CA4", VA = "0x12B1CA4")]
	public void RequestReady()
	{
	}

	[Token(Token = "0x601456F")]
	[Address(RVA = "0x12B1E80", Offset = "0x12B1E80", VA = "0x12B1E80")]
	public void RequestGroupCode()
	{
	}

	[Token(Token = "0x6014570")]
	[Address(RVA = "0x12B2000", Offset = "0x12B2000", VA = "0x12B2000")]
	public void SetEndReason(int reason)
	{
	}

	[Token(Token = "0x6014571")]
	[Address(RVA = "0x12B2060", Offset = "0x12B2060", VA = "0x12B2060")]
	public void SetGroupReady()
	{
	}

	[Token(Token = "0x6014572")]
	[Address(RVA = "0x12B20F0", Offset = "0x12B20F0", VA = "0x12B20F0")]
	public uint GetPlayersLimitsByMode(HHDIPHFOBFO mode)
	{
		return default(uint);
	}

	[Token(Token = "0x6014573")]
	[Address(RVA = "0x12B2174", Offset = "0x12B2174", VA = "0x12B2174")]
	public HHDIPHFOBFO GetGroupModeByMaxPlayerCount(uint playerCount)
	{
		return default(HHDIPHFOBFO);
	}

	[Token(Token = "0x6014574")]
	[Address(RVA = "0x12B2214", Offset = "0x12B2214", VA = "0x12B2214")]
	public void CheckAvailableMaps(uint[] maps, uint gameMode)
	{
	}

	[Token(Token = "0x6014575")]
	[Address(RVA = "0x12B25AC", Offset = "0x12B25AC", VA = "0x12B25AC")]
	public bool CheckMemberLackOfMaps(uint mapId, bool showTips = true, bool isNewTips = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6014576")]
	[Address(RVA = "0x12B2CB0", Offset = "0x12B2CB0", VA = "0x12B2CB0")]
	public void UpdateGroupCode(string groupCode)
	{
	}

	[Token(Token = "0x6014577")]
	[Address(RVA = "0x12B2D28", Offset = "0x12B2D28", VA = "0x12B2D28")]
	public bool IsLeftMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6014578")]
	[Address(RVA = "0x12B2E3C", Offset = "0x12B2E3C", VA = "0x12B2E3C")]
	public void OnGroupJoin(List<ulong> newJoinMemberAccountIds)
	{
	}

	[Token(Token = "0x6014579")]
	[Address(RVA = "0x12AFAF8", Offset = "0x12AFAF8", VA = "0x12AFAF8")]
	private bool CheckEmulatorWarningEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x601457A")]
	[Address(RVA = "0x12B2EBC", Offset = "0x12B2EBC", VA = "0x12B2EBC")]
	private void CheckAndShowEmulatorWarningTip(List<ulong> newJoinMemberAccountIds)
	{
	}

	[Token(Token = "0x601457B")]
	[Address(RVA = "0x12B36B4", Offset = "0x12B36B4", VA = "0x12B36B4")]
	private void CheckNewMemberCreditScorePunishTip(List<ulong> newJoinMemberAccountIds)
	{
	}

	[Token(Token = "0x601457C")]
	[Address(RVA = "0x12B3C2C", Offset = "0x12B3C2C", VA = "0x12B3C2C")]
	private bool CheckFriendIsClosedFriend(ulong friendid)
	{
		return default(bool);
	}

	[Token(Token = "0x601457D")]
	[Address(RVA = "0x12B3D84", Offset = "0x12B3D84", VA = "0x12B3D84")]
	public List<CDDNCLJFLCF> GetRelationshipInGroup()
	{
		return null;
	}

	[Token(Token = "0x601457E")]
	[Address(RVA = "0x12AB10C", Offset = "0x12AB10C", VA = "0x12AB10C")]
	public void GroupHDLeaveCaptainLobby()
	{
	}

	[Token(Token = "0x601457F")]
	[Address(RVA = "0x12B47CC", Offset = "0x12B47CC", VA = "0x12B47CC")]
	public void GroupHDEnterCaptainLobby()
	{
	}

	[Token(Token = "0x6014581")]
	[Address(RVA = "0x12B4BB4", Offset = "0x12B4BB4", VA = "0x12B4BB4")]
	private static string _003CRequestAcceptInternal_003Em__0(uint i)
	{
		return null;
	}

	[Token(Token = "0x6014582")]
	[Address(RVA = "0x12B4C4C", Offset = "0x12B4C4C", VA = "0x12B4C4C")]
	private static string _003CRequestAcceptInternal_003Em__1(string s1, string s2)
	{
		return null;
	}

	[Token(Token = "0x6014583")]
	[Address(RVA = "0x12B4CE8", Offset = "0x12B4CE8", VA = "0x12B4CE8")]
	private void _003CRequestStart_003Em__2()
	{
	}

	[Token(Token = "0x6014584")]
	[Address(RVA = "0x12B54D0", Offset = "0x12B54D0", VA = "0x12B54D0")]
	private static uint _003CRequestGroupChange_003Em__3(MapModeData x)
	{
		return default(uint);
	}

	[Token(Token = "0x6014585")]
	[Address(RVA = "0x12B54F4", Offset = "0x12B54F4", VA = "0x12B54F4")]
	private static uint _003CRequestGroupChange_003Em__4(MapModeData x)
	{
		return default(uint);
	}

	[Token(Token = "0x6014586")]
	[Address(RVA = "0x12B5518", Offset = "0x12B5518", VA = "0x12B5518")]
	private bool _003CGroupHDEnterCaptainLobby_003Em__5(GroupMemberInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x6014587")]
	[Address(RVA = "0x12B5588", Offset = "0x12B5588", VA = "0x12B5588")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6014588")]
	[Address(RVA = "0x12B5590", Offset = "0x12B5590", VA = "0x12B5590")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
