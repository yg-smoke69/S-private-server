using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002F2F")]
public class UIModelChat : UIBaseModel
{
	[Token(Token = "0x2002F30")]
	public class FastTutorInvite : FastMessage
	{
		[Token(Token = "0x4012067")]
		[FieldOffset(Offset = "0x10")]
		public ulong accountId;

		[Token(Token = "0x4012068")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		[Token(Token = "0x4012069")]
		[FieldOffset(Offset = "0x1C")]
		public string declaration;

		[Token(Token = "0x401206A")]
		[FieldOffset(Offset = "0x20")]
		public string nickName;

		[Token(Token = "0x401206B")]
		[FieldOffset(Offset = "0x24")]
		public string region;

		[Token(Token = "0x401206C")]
		[FieldOffset(Offset = "0x28")]
		public bool isIdentifyTutor;

		[Token(Token = "0x6013C1A")]
		[Address(RVA = "0x27D19A0", Offset = "0x27D19A0", VA = "0x27D19A0")]
		public FastTutorInvite()
		{
		}
	}

	[Token(Token = "0x2002F31")]
	public class TutorRecruitInfo
	{
		[Token(Token = "0x401206D")]
		[FieldOffset(Offset = "0x8")]
		public ulong accountID;

		[Token(Token = "0x401206E")]
		[FieldOffset(Offset = "0x10")]
		public bool toWorld;

		[Token(Token = "0x401206F")]
		[FieldOffset(Offset = "0x11")]
		public bool toClan;

		[Token(Token = "0x4012070")]
		[FieldOffset(Offset = "0x12")]
		public bool toTutor;

		[Token(Token = "0x4012071")]
		[FieldOffset(Offset = "0x14")]
		public string title;

		[Token(Token = "0x4012072")]
		[FieldOffset(Offset = "0x18")]
		public string declaration;

		[Token(Token = "0x4012073")]
		[FieldOffset(Offset = "0x1C")]
		public string nickName;

		[Token(Token = "0x4012074")]
		[FieldOffset(Offset = "0x20")]
		public string region;

		[Token(Token = "0x4012075")]
		[FieldOffset(Offset = "0x24")]
		public bool isIdentifyTutor;

		[Token(Token = "0x6013C1B")]
		[Address(RVA = "0x27D159C", Offset = "0x27D159C", VA = "0x27D159C")]
		public TutorRecruitInfo(bool world, bool clan, bool tutor, string title, string declaration, ulong accountID, string nickName, string region, bool isIdentifyTutor)
		{
		}
	}

	[Token(Token = "0x2002F32")]
	public class IntentRecruitInfo
	{
		[Token(Token = "0x4012076")]
		[FieldOffset(Offset = "0x8")]
		public bool m_ToWorld;

		[Token(Token = "0x4012077")]
		[FieldOffset(Offset = "0x9")]
		public bool m_ToClan;

		[Token(Token = "0x4012078")]
		[FieldOffset(Offset = "0xC")]
		public uint m_RankLimit;

		[Token(Token = "0x4012079")]
		[FieldOffset(Offset = "0x10")]
		public string m_GroupTag;

		[Token(Token = "0x6013C1C")]
		[Address(RVA = "0x27D1B58", Offset = "0x27D1B58", VA = "0x27D1B58")]
		public IntentRecruitInfo(bool world, bool clan, uint rankLimit, string groupTag)
		{
		}
	}

	[Token(Token = "0x2002F33")]
	private sealed class _003CGetChannelInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x401207A")]
		[FieldOffset(Offset = "0x8")]
		internal EChannel.ChannelType type;

		[Token(Token = "0x401207B")]
		[FieldOffset(Offset = "0x10")]
		internal ulong id;

		[Token(Token = "0x6013C1D")]
		[Address(RVA = "0x27C2D24", Offset = "0x27C2D24", VA = "0x27C2D24")]
		public _003CGetChannelInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013C1E")]
		[Address(RVA = "0x27D3364", Offset = "0x27D3364", VA = "0x27D3364")]
		internal bool _003C_003Em__0(ChatChannelInfo x)
		{
			return default(bool);
		}

		[Token(Token = "0x6013C1F")]
		[Address(RVA = "0x27D339C", Offset = "0x27D339C", VA = "0x27D339C")]
		internal bool _003C_003Em__1(ChatChannelInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F34")]
	private sealed class _003CJoinRecruit_003Ec__AnonStorey2
	{
		[Token(Token = "0x401207C")]
		[FieldOffset(Offset = "0x8")]
		internal MessageInfo recruitData;

		[Token(Token = "0x401207D")]
		[FieldOffset(Offset = "0xC")]
		internal bool fromWorldChannel;

		[Token(Token = "0x6013C20")]
		[Address(RVA = "0x27CF2EC", Offset = "0x27CF2EC", VA = "0x27CF2EC")]
		public _003CJoinRecruit_003Ec__AnonStorey2()
		{
		}
	}

	[Token(Token = "0x2002F35")]
	private sealed class _003CJoinRecruit_003Ec__AnonStorey3
	{
		[Token(Token = "0x401207E")]
		[FieldOffset(Offset = "0x8")]
		internal FastClanGroupInvite clanGroupInfo;

		[Token(Token = "0x6013C21")]
		[Address(RVA = "0x27CF9B4", Offset = "0x27CF9B4", VA = "0x27CF9B4")]
		public _003CJoinRecruit_003Ec__AnonStorey3()
		{
		}
	}

	[Token(Token = "0x2002F36")]
	private sealed class _003CJoinRecruit_003Ec__AnonStorey1
	{
		[Token(Token = "0x401207F")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelClan m_ModelClan;

		[Token(Token = "0x4012080")]
		[FieldOffset(Offset = "0xC")]
		internal string from;

		[Token(Token = "0x4012081")]
		[FieldOffset(Offset = "0x10")]
		internal _003CJoinRecruit_003Ec__AnonStorey2 _003C_003Ef__ref_00242;

		[Token(Token = "0x4012082")]
		[FieldOffset(Offset = "0x14")]
		internal _003CJoinRecruit_003Ec__AnonStorey3 _003C_003Ef__ref_00243;

		[Token(Token = "0x6013C22")]
		[Address(RVA = "0x27CF9BC", Offset = "0x27CF9BC", VA = "0x27CF9BC")]
		public _003CJoinRecruit_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6013C23")]
		[Address(RVA = "0x27D33F0", Offset = "0x27D33F0", VA = "0x27D33F0")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6013C24")]
		[Address(RVA = "0x27D3C10", Offset = "0x27D3C10", VA = "0x27D3C10")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x6013C25")]
		[Address(RVA = "0x27D3CBC", Offset = "0x27D3CBC", VA = "0x27D3CBC")]
		internal void _003C_003Em__2()
		{
		}

		[Token(Token = "0x6013C26")]
		[Address(RVA = "0x27D3D90", Offset = "0x27D3D90", VA = "0x27D3D90")]
		internal void _003C_003Em__3()
		{
		}
	}

	[Token(Token = "0x2002F37")]
	private sealed class _003CRemoveQuickAddFriendMessageInfo_003Ec__AnonStorey4
	{
		[Token(Token = "0x4012083")]
		[FieldOffset(Offset = "0x8")]
		internal ulong senderId;

		[Token(Token = "0x4012084")]
		[FieldOffset(Offset = "0x10")]
		internal ulong id;

		[Token(Token = "0x4012085")]
		[FieldOffset(Offset = "0x18")]
		internal EChannel.ChannelType type;

		[Token(Token = "0x6013C27")]
		[Address(RVA = "0x27CFDA4", Offset = "0x27CFDA4", VA = "0x27CFDA4")]
		public _003CRemoveQuickAddFriendMessageInfo_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6013C28")]
		[Address(RVA = "0x27D3E64", Offset = "0x27D3E64", VA = "0x27D3E64")]
		internal bool _003C_003Em__0(MessageInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F38")]
	private sealed class _003CBuySticker_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012086")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemID;

		[Token(Token = "0x4012087")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelChat _0024this;

		[Token(Token = "0x6013C29")]
		[Address(RVA = "0x27D0F54", Offset = "0x27D0F54", VA = "0x27D0F54")]
		public _003CBuySticker_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6013C2A")]
		[Address(RVA = "0x27D3234", Offset = "0x27D3234", VA = "0x27D3234")]
		internal void _003C_003Em__0(HttpErrorCode errorcode, object obj)
		{
		}
	}

	[Token(Token = "0x4012023")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<ChatChannelInfo, List<MessageInfo>> m_ChatDictionary;

	[Token(Token = "0x4012024")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<ChatChannelInfo, uint> m_RecvMessageNumCache;

	[Token(Token = "0x4012025")]
	[FieldOffset(Offset = "0x14")]
	public List<ChatChannelInfo> m_ChannelInfoList;

	[Token(Token = "0x4012026")]
	[FieldOffset(Offset = "0x18")]
	private List<MessageInfo> m_SendingMessages;

	[Token(Token = "0x4012027")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<ulong, MessageInfo> m_GroupRecruitMessagesDic;

	[Token(Token = "0x4012028")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<ulong, int> m_UnreadWhisperID;

	[Token(Token = "0x4012029")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<ulong, int> m_UnreadSquadID;

	[Token(Token = "0x401202A")]
	[FieldOffset(Offset = "0x28")]
	private EventLogger.EventChat m_ChatEvent;

	[Token(Token = "0x401202B")]
	[FieldOffset(Offset = "0x2C")]
	private MessageInfo m_LatestMessage;

	[Token(Token = "0x401202C")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, MessageInfo> m_LastMessage;

	[Token(Token = "0x401202D")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<string, float> m_NextShowProfileTime;

	[Token(Token = "0x401202E")]
	private const float SHOW_MESSAGE_UI_CD = 60f;

	[Token(Token = "0x401202F")]
	[FieldOffset(Offset = "0x38")]
	private ulong m_LastSendTimestamp;

	[Token(Token = "0x4012030")]
	[FieldOffset(Offset = "0x40")]
	private ulong m_LastWorldSendTs;

	[Token(Token = "0x4012031")]
	[FieldOffset(Offset = "0x48")]
	private string m_ReturnVeteranNickName;

	[Token(Token = "0x4012032")]
	[FieldOffset(Offset = "0x4C")]
	private LikeWorldChannelInfo m_MenToringInfo;

	[Token(Token = "0x4012033")]
	[FieldOffset(Offset = "0x50")]
	private LikeWorldChannelInfo m_WorldInfo;

	[Token(Token = "0x4012034")]
	[FieldOffset(Offset = "0x58")]
	private ulong _003CMutedTimeStamp_003Ek__BackingField;

	[Token(Token = "0x4012035")]
	private const string ChatReportTimesKey = "ChatReportTimesKey";

	[Token(Token = "0x4012036")]
	[FieldOffset(Offset = "0x60")]
	public bool m_HasRequestClanMemberList;

	[Token(Token = "0x4012037")]
	[FieldOffset(Offset = "0x64")]
	private List<int> m_GroupInviteTimeOutMessages;

	[Token(Token = "0x4012038")]
	[FieldOffset(Offset = "0x68")]
	private List<uint> m_GroupInviteCallIDs;

	[Token(Token = "0x4012039")]
	[FieldOffset(Offset = "0x6C")]
	public string QuickAddFriendNickName;

	[Token(Token = "0x401203A")]
	[FieldOffset(Offset = "0x70")]
	public ulong QuickAddFriendId;

	[Token(Token = "0x401203B")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<uint, uint> m_NumberOfContinuousChats;

	[Token(Token = "0x401203C")]
	[FieldOffset(Offset = "0x7C")]
	private Dictionary<uint, ulong> m_IdOfContinuousChats;

	[Token(Token = "0x401203D")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<uint, bool> m_HasLocalPlayerTalked;

	[Token(Token = "0x401203E")]
	[FieldOffset(Offset = "0x84")]
	private List<ulong> m_QuickAddFriendTipId;

	[Token(Token = "0x401203F")]
	[FieldOffset(Offset = "0x88")]
	private List<ChatBlockUserInfo> m_ChatBlockList;

	[Token(Token = "0x4012040")]
	[FieldOffset(Offset = "0x8C")]
	private Dictionary<uint, int> m_ChannelSortOrder;

	[Token(Token = "0x4012041")]
	private const int MAX_HISTORY_MESSAGE_LENGTH = 200;

	[Token(Token = "0x4012042")]
	private const int MAX_HISTORY_RECRUIT_MESSAGE_LENGTH = 50;

	[Token(Token = "0x4012043")]
	private const int MAX_WHISPER_COUNT = 10;

	[Token(Token = "0x4012044")]
	private const int STABLE_CHANNEL_COUNT = 3;

	[Token(Token = "0x4012045")]
	public const int SEND_MESSAGE_CDTIME = 2;

	[Token(Token = "0x4012046")]
	public const uint PropID_UpdateMessageList = 1u;

	[Token(Token = "0x4012047")]
	public const uint PropID_UpdateProfileInfo = 2u;

	[Token(Token = "0x4012048")]
	public const uint PropID_JoinOrLeaveRoom = 4u;

	[Token(Token = "0x4012049")]
	public const uint PropID_RefreshWhisperList = 8u;

	[Token(Token = "0x401204A")]
	public const uint PropID_UpdateStickerList = 16u;

	[Token(Token = "0x401204B")]
	public const uint PropID_CheckMuteState = 32u;

	[Token(Token = "0x401204C")]
	public const uint SPEAKER_ITEM_ID = 800000401u;

	[Token(Token = "0x401204D")]
	public const string FAST_MSG_CLAN_TYPENAME = "clan";

	[Token(Token = "0x401204E")]
	public const string FAST_MSG_CLANGROUP_TYPENAME = "clanGroup";

	[Token(Token = "0x401204F")]
	public const string FAST_MSG_GROUP_TYPENAME = "group";

	[Token(Token = "0x4012050")]
	public const string FAST_MSG_BIGEVENT_TYPENAME = "BigEventMsg";

	[Token(Token = "0x4012051")]
	public const string FAST_MSG_CHAMPIONSHIPTEAM_TYPENAME = "championshipTeam";

	[Token(Token = "0x4012052")]
	public const string FAST_MSG_CUPMATCHTEAM_TYPENAEM = "CupMatchTeam";

	[Token(Token = "0x4012053")]
	public const string FAST_MSG_TUTOR_TYPENAEM = "Tutor";

	[Token(Token = "0x4012054")]
	private const string LOBBY_MESSAGE_PREFIX_CLAN = "TXT_LOBBY_MESSAGE_PREFIX_CLAN";

	[Token(Token = "0x4012055")]
	private const string LOBBY_MESSAGE_PREFIX_GROUP = "TXT_LOBBY_MESSAGE_PREFIX_GROUP";

	[Token(Token = "0x4012056")]
	private const string LOBBY_MESSAGE_PREFIX_WHISPER = "TXT_OB10_ZC_CHANNEL_WHISPER";

	[Token(Token = "0x4012057")]
	private const string LOBBY_MESSAGE_PREFIX_ROOM = "T_12_Z_MESSAGE_PREFIX_ROOM";

	[Token(Token = "0x4012058")]
	private const string LOBBY_MESSAGE_PREFIX_WORLD = "T_20_P_CHANNEL_W_E";

	[Token(Token = "0x4012059")]
	private const string LOBBY_MESSAGE_PREFIX_MENTORING = "T_34_AG_MENTOR_CHANNEL";

	[Token(Token = "0x401205A")]
	private const string LOBBY_EMOJI_MESSAGE = "T_12_A_CHAT_LOBBY_EMOJI";

	[Token(Token = "0x401205B")]
	private const string LOBBY_FAST_GROUP = "T_20_P_CHANNEL_ENTRANCE_I";

	[Token(Token = "0x401205C")]
	private const string LOBBY_FAST_CLAN = "T_20_P_CHANNEL_ENTRANCE_R";

	[Token(Token = "0x401205D")]
	private const string LOBBY_FAST_CLAN_GROUP = "T_20_P_PARTNER_REC";

	[Token(Token = "0x401205E")]
	private const string LATEST_MESSAGE_FORMAT = "{0} {1}: {2}";

	[Token(Token = "0x401205F")]
	private const string STICKY_MESSAGE_COLOR_FORMAT = "[ffd451]{0}[-]";

	[Token(Token = "0x4012060")]
	private const string LATEST_MESSAGE_FORMAT_NOTITLE = "{0}{1}";

	[Token(Token = "0x4012061")]
	public const string SENDERNAME_WITHCOLOR = "[41a5ee]{0}:[-]";

	[Token(Token = "0x4012062")]
	[FieldOffset(Offset = "0x90")]
	private ulong AccountID;

	[Token(Token = "0x4012063")]
	[FieldOffset(Offset = "0x98")]
	private TutorRecruitInfo m_TutorRecruitInfo;

	[Token(Token = "0x4012064")]
	[FieldOffset(Offset = "0x9C")]
	private IntentRecruitInfo intentRecruitInfo;

	[Token(Token = "0x4012065")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<ChatChannelInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012066")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<MessageInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x17001470")]
	public ulong LastWorldSendTs
	{
		[Token(Token = "0x6013BC3")]
		[Address(RVA = "0x27C01A4", Offset = "0x27C01A4", VA = "0x27C01A4")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17001471")]
	public string ReturnVeteranNickName
	{
		[Token(Token = "0x6013BC4")]
		[Address(RVA = "0x27C01FC", Offset = "0x27C01FC", VA = "0x27C01FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013BC5")]
		[Address(RVA = "0x27C0254", Offset = "0x27C0254", VA = "0x27C0254")]
		set
		{
		}
	}

	[Token(Token = "0x17001472")]
	public LikeWorldChannelInfo MenToringInfo
	{
		[Token(Token = "0x6013BC6")]
		[Address(RVA = "0x27C02B4", Offset = "0x27C02B4", VA = "0x27C02B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013BC7")]
		[Address(RVA = "0x27C030C", Offset = "0x27C030C", VA = "0x27C030C")]
		set
		{
		}
	}

	[Token(Token = "0x17001473")]
	public LikeWorldChannelInfo WorldInfo
	{
		[Token(Token = "0x6013BC8")]
		[Address(RVA = "0x27C036C", Offset = "0x27C036C", VA = "0x27C036C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013BC9")]
		[Address(RVA = "0x27C03C4", Offset = "0x27C03C4", VA = "0x27C03C4")]
		set
		{
		}
	}

	[Token(Token = "0x17001474")]
	public ulong MutedTimeStamp
	{
		[Token(Token = "0x6013BCA")]
		[Address(RVA = "0x27C0424", Offset = "0x27C0424", VA = "0x27C0424")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6013BCB")]
		[Address(RVA = "0x27C042C", Offset = "0x27C042C", VA = "0x27C042C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001475")]
	public uint ChatReportTimes
	{
		[Token(Token = "0x6013BCC")]
		[Address(RVA = "0x27C043C", Offset = "0x27C043C", VA = "0x27C043C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6013BCD")]
		[Address(RVA = "0x27C0864", Offset = "0x27C0864", VA = "0x27C0864")]
		private set
		{
		}
	}

	[Token(Token = "0x17001476")]
	public List<ChatBlockUserInfo> ChatBlockList
	{
		[Token(Token = "0x6013BCE")]
		[Address(RVA = "0x27C0A24", Offset = "0x27C0A24", VA = "0x27C0A24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001477")]
	public MessageInfo LatestMessage
	{
		[Token(Token = "0x6013BCF")]
		[Address(RVA = "0x27C0A7C", Offset = "0x27C0A7C", VA = "0x27C0A7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001478")]
	public List<ChatChannelInfo> ChannelInfoList
	{
		[Token(Token = "0x6013BD0")]
		[Address(RVA = "0x27C0AD4", Offset = "0x27C0AD4", VA = "0x27C0AD4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6013BC2")]
	[Address(RVA = "0x27BFAA8", Offset = "0x27BFAA8", VA = "0x27BFAA8")]
	public UIModelChat()
	{
	}

	[Token(Token = "0x6013BD1")]
	[Address(RVA = "0x27C0BE0", Offset = "0x27C0BE0", VA = "0x27C0BE0", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013BD2")]
	[Address(RVA = "0x27C0C38", Offset = "0x27C0C38", VA = "0x27C0C38", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6013BD3")]
	[Address(RVA = "0x27C1820", Offset = "0x27C1820", VA = "0x27C1820", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6013BD4")]
	[Address(RVA = "0x27C19D8", Offset = "0x27C19D8", VA = "0x27C19D8", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6013BD5")]
	[Address(RVA = "0x27C0ED0", Offset = "0x27C0ED0", VA = "0x27C0ED0")]
	private void ResetContinousChats()
	{
	}

	[Token(Token = "0x6013BD6")]
	[Address(RVA = "0x27C120C", Offset = "0x27C120C", VA = "0x27C120C")]
	private void ReadBlockList()
	{
	}

	[Token(Token = "0x6013BD7")]
	[Address(RVA = "0x27C1F20", Offset = "0x27C1F20", VA = "0x27C1F20")]
	public void JoinRoom(EChannel.ChannelType type, ulong roomid)
	{
	}

	[Token(Token = "0x6013BD8")]
	[Address(RVA = "0x27C28F4", Offset = "0x27C28F4", VA = "0x27C28F4")]
	public void AddWhisper(ulong id)
	{
	}

	[Token(Token = "0x6013BD9")]
	[Address(RVA = "0x27C26D0", Offset = "0x27C26D0", VA = "0x27C26D0")]
	public ChatChannelInfo GetChannelInfo(EChannel.ChannelType type, ulong id = 0uL)
	{
		return null;
	}

	[Token(Token = "0x6013BDA")]
	[Address(RVA = "0x27C2D2C", Offset = "0x27C2D2C", VA = "0x27C2D2C")]
	private int SortChannelList(ChatChannelInfo x, ChatChannelInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x6013BDB")]
	[Address(RVA = "0x27C3348", Offset = "0x27C3348", VA = "0x27C3348")]
	public void LeaveRoom(EChannel.ChannelType type, ulong roomid)
	{
	}

	[Token(Token = "0x6013BDC")]
	[Address(RVA = "0x27C3D08", Offset = "0x27C3D08", VA = "0x27C3D08")]
	public ulong GetLikeWorldChannelID(EChannel.ChannelType type)
	{
		return default(ulong);
	}

	[Token(Token = "0x6013BDD")]
	[Address(RVA = "0x27C3DA0", Offset = "0x27C3DA0", VA = "0x27C3DA0")]
	public bool IsLikeWorldChannelOpen(EChannel.ChannelType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6013BDE")]
	[Address(RVA = "0x27C3E14", Offset = "0x27C3E14", VA = "0x27C3E14")]
	public void SetLikeWorldChannelID(ulong id, EChannel.ChannelType type)
	{
	}

	[Token(Token = "0x6013BDF")]
	[Address(RVA = "0x27C4024", Offset = "0x27C4024", VA = "0x27C4024")]
	public ulong GetWorldChannelID()
	{
		return default(ulong);
	}

	[Token(Token = "0x6013BE0")]
	[Address(RVA = "0x27C40B4", Offset = "0x27C40B4", VA = "0x27C40B4")]
	public bool IsWorldChannelOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6013BE1")]
	[Address(RVA = "0x27C411C", Offset = "0x27C411C", VA = "0x27C411C")]
	public void ProcessJoinWorldChannel()
	{
	}

	[Token(Token = "0x6013BE2")]
	[Address(RVA = "0x27C4244", Offset = "0x27C4244", VA = "0x27C4244")]
	public bool CorrectMessageContent(string msg, out string result)
	{
		return default(bool);
	}

	[Token(Token = "0x6013BE3")]
	[Address(RVA = "0x27C4468", Offset = "0x27C4468", VA = "0x27C4468")]
	public bool SendMessage(EChannel.ChannelType type, string content, EChannel.MsgType msgType = EChannel.MsgType.MsgType_DEFAULT, ulong accountID = 0uL)
	{
		return default(bool);
	}

	[Token(Token = "0x6013BE4")]
	[Address(RVA = "0x27C6188", Offset = "0x27C6188", VA = "0x27C6188")]
	public bool SendFastGroupInvite(EChannel.ChannelType channel)
	{
		return default(bool);
	}

	[Token(Token = "0x6013BE5")]
	[Address(RVA = "0x27C6768", Offset = "0x27C6768", VA = "0x27C6768")]
	public bool SendFastClanGroupInvite(ClanInfo clanInfo, string memberNum, uint BRRankLimit, uint CSRankLimit, string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x6013BE6")]
	[Address(RVA = "0x27C698C", Offset = "0x27C698C", VA = "0x27C698C")]
	public bool SendFastClanInvite(ClanInfo clanInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6013BE7")]
	[Address(RVA = "0x27C70DC", Offset = "0x27C70DC", VA = "0x27C70DC")]
	public bool SendFastChampionshipTeamInvite(EChannel.ChannelType channel, uint championshipType, uint championshipID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013BE8")]
	[Address(RVA = "0x27C7314", Offset = "0x27C7314", VA = "0x27C7314")]
	public bool SendFastCupMatchTeamInvite(EChannel.ChannelType channel, uint type, uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6013BE9")]
	[Address(RVA = "0x27C7580", Offset = "0x27C7580", VA = "0x27C7580")]
	public bool SendBigEventMsg(string msg, EChannel.ChannelType channel, ulong accountID = 0uL)
	{
		return default(bool);
	}

	[Token(Token = "0x6013BEA")]
	[Address(RVA = "0x27C7688", Offset = "0x27C7688", VA = "0x27C7688")]
	public bool SendTutorInviteMessage(EChannel.ChannelType type, string content, string customContent, EChannel.MsgType msgType = EChannel.MsgType.MsgType_FAST)
	{
		return default(bool);
	}

	[Token(Token = "0x6013BEB")]
	[Address(RVA = "0x27C6694", Offset = "0x27C6694", VA = "0x27C6694")]
	public bool SendMessage(EChannel.ChannelType type, string content, EChannel.MsgType msgType = EChannel.MsgType.MsgType_DEFAULT)
	{
		return default(bool);
	}

	[Token(Token = "0x6013BEC")]
	[Address(RVA = "0x27C4554", Offset = "0x27C4554", VA = "0x27C4554")]
	public bool SendMessage(EChannel.ChannelType type, ulong channelID, string content, EChannel.MsgType msgType = EChannel.MsgType.MsgType_DEFAULT, bool checkFriend = true, float deltaCD = 0f, bool showWhisperFailTips = true, bool isFastMessageWithCustuomContent = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6013BED")]
	[Address(RVA = "0x27C31BC", Offset = "0x27C31BC", VA = "0x27C31BC")]
	public List<MessageInfo> GetChannelMessageList(EChannel.ChannelType type, ulong id)
	{
		return null;
	}

	[Token(Token = "0x6013BEE")]
	[Address(RVA = "0x27C7898", Offset = "0x27C7898", VA = "0x27C7898")]
	public MessageInfo GetLatestMessage(EChannel.ChannelType type, ulong id)
	{
		return null;
	}

	[Token(Token = "0x6013BEF")]
	[Address(RVA = "0x27C7A1C", Offset = "0x27C7A1C", VA = "0x27C7A1C")]
	public void RecvNewMessageList(TextMsgReq info)
	{
	}

	[Token(Token = "0x6013BF0")]
	[Address(RVA = "0x27C93D8", Offset = "0x27C93D8", VA = "0x27C93D8")]
	public void SetWhisperUnread(ulong whisperID, bool hasUnreadTip)
	{
	}

	[Token(Token = "0x6013BF1")]
	[Address(RVA = "0x27CA7D0", Offset = "0x27CA7D0", VA = "0x27CA7D0")]
	public int GetWhisperUnread(ulong whisperID)
	{
		return default(int);
	}

	[Token(Token = "0x6013BF2")]
	[Address(RVA = "0x27C911C", Offset = "0x27C911C", VA = "0x27C911C")]
	public void SetSquadUnread(ulong channelID, EChannel.ChannelType channelType, bool hasUnreadTip)
	{
	}

	[Token(Token = "0x6013BF3")]
	[Address(RVA = "0x27CA910", Offset = "0x27CA910", VA = "0x27CA910")]
	public int GetSquadUnRead(ulong channelID, EChannel.ChannelType channelType)
	{
		return default(int);
	}

	[Token(Token = "0x6013BF4")]
	[Address(RVA = "0x27CAA68", Offset = "0x27CAA68", VA = "0x27CAA68")]
	public void ResendMessage(MessageInfo resendInfo)
	{
	}

	[Token(Token = "0x6013BF5")]
	[Address(RVA = "0x27CAB68", Offset = "0x27CAB68", VA = "0x27CAB68")]
	private void SetMessageProfileState(ref MessageInfo info, ChatChannelInfo channelInfo)
	{
	}

	[Token(Token = "0x6013BF6")]
	[Address(RVA = "0x27CB0A8", Offset = "0x27CB0A8", VA = "0x27CB0A8")]
	public void RemoveLastMessage(ulong channelID)
	{
	}

	[Token(Token = "0x6013BF7")]
	[Address(RVA = "0x27C966C", Offset = "0x27C966C", VA = "0x27C966C")]
	public void AddNewMessageToList(EChannel.ChannelType type, ulong id, MessageInfo info)
	{
	}

	[Token(Token = "0x6013BF8")]
	[Address(RVA = "0x27CB224", Offset = "0x27CB224", VA = "0x27CB224")]
	public void AddNewGroupRecuitMessage(MessageInfo info)
	{
	}

	[Token(Token = "0x6013BF9")]
	[Address(RVA = "0x27CBBF4", Offset = "0x27CBBF4", VA = "0x27CBBF4")]
	public void RemoveGroupRecruitMessage(ulong senderid)
	{
	}

	[Token(Token = "0x6013BFA")]
	[Address(RVA = "0x27CB914", Offset = "0x27CB914", VA = "0x27CB914")]
	public List<MessageInfo> GetSortedGroupRecruitMessageList()
	{
		return null;
	}

	[Token(Token = "0x6013BFB")]
	[Address(RVA = "0x27CBD1C", Offset = "0x27CBD1C", VA = "0x27CBD1C")]
	public void JoinRecruit(MessageInfo recruitData, bool fromWorldChannel)
	{
	}

	[Token(Token = "0x6013BFC")]
	[Address(RVA = "0x27CF2F4", Offset = "0x27CF2F4", VA = "0x27CF2F4")]
	private EGroup.InviteChannelType GetInviteChannel(EChannel.ChannelType type)
	{
		return default(EGroup.InviteChannelType);
	}

	[Token(Token = "0x6013BFD")]
	[Address(RVA = "0x27CF9C4", Offset = "0x27CF9C4", VA = "0x27CF9C4")]
	public void RemoveQuickAddFriendMessageInfo(EChannel.ChannelType type, ulong id, ulong senderId)
	{
	}

	[Token(Token = "0x6013BFE")]
	[Address(RVA = "0x27CFDAC", Offset = "0x27CFDAC", VA = "0x27CFDAC")]
	public void SendEventLog()
	{
	}

	[Token(Token = "0x6013BFF")]
	[Address(RVA = "0x27CFFD4", Offset = "0x27CFFD4", VA = "0x27CFFD4")]
	public string RemoveColorAttribute(string content)
	{
		return null;
	}

	[Token(Token = "0x6013C00")]
	[Address(RVA = "0x27D02F0", Offset = "0x27D02F0", VA = "0x27D02F0")]
	public void AddToBlockList(ulong userid, string name)
	{
	}

	[Token(Token = "0x6013C01")]
	[Address(RVA = "0x27D0B2C", Offset = "0x27D0B2C", VA = "0x27D0B2C")]
	public void DeleteFromBlockList(ulong userid)
	{
	}

	[Token(Token = "0x6013C02")]
	[Address(RVA = "0x27D07EC", Offset = "0x27D07EC", VA = "0x27D07EC")]
	private void SaveBlockList()
	{
	}

	[Token(Token = "0x6013C03")]
	[Address(RVA = "0x27C8FCC", Offset = "0x27C8FCC", VA = "0x27C8FCC")]
	public bool IsBlocked(ulong userid)
	{
		return default(bool);
	}

	[Token(Token = "0x6013C04")]
	[Address(RVA = "0x27D0CB4", Offset = "0x27D0CB4", VA = "0x27D0CB4")]
	public void BuySticker(uint itemID)
	{
	}

	[Token(Token = "0x6013C05")]
	[Address(RVA = "0x27CB6EC", Offset = "0x27CB6EC", VA = "0x27CB6EC")]
	public bool IsRecruitOverSelfRank(uint gameMode, uint reqRank)
	{
		return default(bool);
	}

	[Token(Token = "0x6013C06")]
	[Address(RVA = "0x27D0F5C", Offset = "0x27D0F5C", VA = "0x27D0F5C")]
	public bool EnableReportChat()
	{
		return default(bool);
	}

	[Token(Token = "0x6013C07")]
	[Address(RVA = "0x27C775C", Offset = "0x27C775C", VA = "0x27C775C")]
	public bool IsMuted()
	{
		return default(bool);
	}

	[Token(Token = "0x6013C08")]
	[Address(RVA = "0x27D1070", Offset = "0x27D1070", VA = "0x27D1070")]
	public void SetMutedTime(long timeToLive)
	{
	}

	[Token(Token = "0x6013C09")]
	[Address(RVA = "0x27D11A4", Offset = "0x27D11A4", VA = "0x27D11A4")]
	public void ReportChat(MessageInfo reportedMsg, uint reason)
	{
	}

	[Token(Token = "0x6013C0A")]
	[Address(RVA = "0x27C3C78", Offset = "0x27C3C78", VA = "0x27C3C78")]
	public static ETipsType ChannelType2TipsType(EChannel.ChannelType cType)
	{
		return default(ETipsType);
	}

	[Token(Token = "0x6013C0B")]
	[Address(RVA = "0x27D13B0", Offset = "0x27D13B0", VA = "0x27D13B0")]
	public static EChannel.ChannelType TipsType2ChannelType(ETipsType eType)
	{
		return default(EChannel.ChannelType);
	}

	[Token(Token = "0x6013C0C")]
	[Address(RVA = "0x27D1444", Offset = "0x27D1444", VA = "0x27D1444")]
	public void SetTutorRecruitInfo(bool world, bool clan, bool tutor, string title, string declaration, ulong accountID, string nickName, string region, bool isIdentifyTutor)
	{
	}

	[Token(Token = "0x6013C0D")]
	[Address(RVA = "0x27D15F0", Offset = "0x27D15F0", VA = "0x27D15F0")]
	public bool SendTutorRecruitInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x6013C0E")]
	[Address(RVA = "0x27D17CC", Offset = "0x27D17CC", VA = "0x27D17CC")]
	public bool SendFastTutorInvite(EChannel.ChannelType channel, TutorRecruitInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6013C0F")]
	[Address(RVA = "0x27D1A0C", Offset = "0x27D1A0C", VA = "0x27D1A0C")]
	public void ClearTutorRecruitInfo()
	{
	}

	[Token(Token = "0x6013C10")]
	[Address(RVA = "0x27D1A68", Offset = "0x27D1A68", VA = "0x27D1A68")]
	public void SetIntenRecruitInfo(bool world, bool clan, uint rankLimit, string groupTag)
	{
	}

	[Token(Token = "0x6013C11")]
	[Address(RVA = "0x27C1EC4", Offset = "0x27C1EC4", VA = "0x27C1EC4")]
	public void ClearIntenRecruitInfo()
	{
	}

	[Token(Token = "0x6013C12")]
	[Address(RVA = "0x27D1B90", Offset = "0x27D1B90", VA = "0x27D1B90")]
	public bool SendIntentRecruit()
	{
		return default(bool);
	}

	[Token(Token = "0x6013C13")]
	[Address(RVA = "0x27C264C", Offset = "0x27C264C", VA = "0x27C264C")]
	public bool IsSquadChannel(EChannel.ChannelType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6013C14")]
	[Address(RVA = "0x27D25E4", Offset = "0x27D25E4", VA = "0x27D25E4")]
	public string GetMessageText(MessageInfo showInfo, bool noTitle = false)
	{
		return null;
	}

	[Token(Token = "0x6013C15")]
	[Address(RVA = "0x27D316C", Offset = "0x27D316C", VA = "0x27D316C")]
	private static bool _003CAddWhisper_003Em__0(ChatChannelInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x6013C16")]
	[Address(RVA = "0x27D31A8", Offset = "0x27D31A8", VA = "0x27D31A8")]
	private static int _003CGetSortedGroupRecruitMessageList_003Em__1(MessageInfo x, MessageInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x6013C17")]
	[Address(RVA = "0x27D321C", Offset = "0x27D321C", VA = "0x27D321C")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6013C18")]
	[Address(RVA = "0x27D3224", Offset = "0x27D3224", VA = "0x27D3224")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6013C19")]
	[Address(RVA = "0x27D322C", Offset = "0x27D322C", VA = "0x27D322C")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
