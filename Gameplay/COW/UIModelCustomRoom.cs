using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2003010")]
public class UIModelCustomRoom : UIBaseModel
{
	[Token(Token = "0x2003011")]
	public enum ECustomRoomGameSetting
	{
		[Token(Token = "0x40124F2")]
		Revive = 1,
		[Token(Token = "0x40124F3")]
		HP,
		[Token(Token = "0x40124F4")]
		EP,
		[Token(Token = "0x40124F5")]
		MoveSpeed,
		[Token(Token = "0x40124F6")]
		JumpHeight,
		[Token(Token = "0x40124F7")]
		Weather,
		[Token(Token = "0x40124F8")]
		UnLimitedAmmo,
		[Token(Token = "0x40124F9")]
		NoFallDamage,
		[Token(Token = "0x40124FA")]
		NoLoadOut,
		[Token(Token = "0x40124FB")]
		NoAirDrop,
		[Token(Token = "0x40124FC")]
		NoSkill,
		[Token(Token = "0x40124FD")]
		NoVehicles,
		[Token(Token = "0x40124FE")]
		NoPowerGun,
		[Token(Token = "0x40124FF")]
		NoUAV,
		[Token(Token = "0x4012500")]
		NoBomb,
		[Token(Token = "0x4012501")]
		NoZeppelin,
		[Token(Token = "0x4012502")]
		HideEnemyCloth,
		[Token(Token = "0x4012503")]
		NoHud,
		[Token(Token = "0x4012504")]
		FriendDmg,
		[Token(Token = "0x4012505")]
		CSRound,
		[Token(Token = "0x4012506")]
		CSInitCoin,
		[Token(Token = "0x4012507")]
		FightClubRound,
		[Token(Token = "0x4012508")]
		ShopFlow,
		[Token(Token = "0x4012509")]
		UseRandomMap,
		[Token(Token = "0x401250A")]
		NoAuxAim,
		[Token(Token = "0x401250B")]
		InGameChat,
		[Token(Token = "0x401250C")]
		AutoRevival,
		[Token(Token = "0x401250D")]
		SaveZoneSpeed,
		[Token(Token = "0x401250E")]
		SaveZoneDamage,
		[Token(Token = "0x401250F")]
		GameMission,
		[Token(Token = "0x4012510")]
		RandomBuff
	}

	[Token(Token = "0x2003012")]
	private sealed class _003CBatchJoinRoom_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012511")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x60141E0")]
		[Address(RVA = "0x15D4014", Offset = "0x15D4014", VA = "0x15D4014")]
		public _003CBatchJoinRoom_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60141E1")]
		[Address(RVA = "0x15DF894", Offset = "0x15DF894", VA = "0x15DF894")]
		internal bool _003C_003Em__0(tcp.RoomInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003013")]
	private sealed class _003CUpdateCurrentOptionalMapResState_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012512")]
		[FieldOffset(Offset = "0x8")]
		internal RoomSyncPatchOptionalResStatusNtf resData;

		[Token(Token = "0x60141E2")]
		[Address(RVA = "0x15D4CB8", Offset = "0x15D4CB8", VA = "0x15D4CB8")]
		public _003CUpdateCurrentOptionalMapResState_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60141E3")]
		[Address(RVA = "0x15DFB14", Offset = "0x15DFB14", VA = "0x15DFB14")]
		internal bool _003C_003Em__0(RoomPlayerInfo value)
		{
			return default(bool);
		}

		[Token(Token = "0x60141E4")]
		[Address(RVA = "0x15DFB84", Offset = "0x15DFB84", VA = "0x15DFB84")]
		internal bool _003C_003Em__1(RoomPlayerInfo value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003014")]
	private sealed class _003CUpdateCurrentReadyState_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012513")]
		[FieldOffset(Offset = "0x8")]
		internal RoomPlayerInfo player;

		[Token(Token = "0x60141E5")]
		[Address(RVA = "0x15D5294", Offset = "0x15D5294", VA = "0x15D5294")]
		public _003CUpdateCurrentReadyState_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60141E6")]
		[Address(RVA = "0x15DFBF4", Offset = "0x15DFBF4", VA = "0x15DFBF4")]
		internal bool _003C_003Em__0(RoomPlayerInfo p)
		{
			return default(bool);
		}

		[Token(Token = "0x60141E7")]
		[Address(RVA = "0x15DFC64", Offset = "0x15DFC64", VA = "0x15DFC64")]
		internal bool _003C_003Em__1(RoomGroupInfo g)
		{
			return default(bool);
		}

		[Token(Token = "0x60141E8")]
		[Address(RVA = "0x15DFCD4", Offset = "0x15DFCD4", VA = "0x15DFCD4")]
		internal bool _003C_003Em__2(RoomPlayerInfo p)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003015")]
	private sealed class _003CIsMyBatchRoom_003Ec__AnonStorey3
	{
		[Token(Token = "0x4012514")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x60141E9")]
		[Address(RVA = "0x15DB34C", Offset = "0x15DB34C", VA = "0x15DB34C")]
		public _003CIsMyBatchRoom_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60141EA")]
		[Address(RVA = "0x15DF92C", Offset = "0x15DF92C", VA = "0x15DF92C")]
		internal bool _003C_003Em__0(tcp.RoomInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003016")]
	private sealed class _003CClearBatchData_003Ec__AnonStorey4
	{
		[Token(Token = "0x4012515")]
		[FieldOffset(Offset = "0x8")]
		internal ulong roomid;

		[Token(Token = "0x60141EB")]
		[Address(RVA = "0x15DB354", Offset = "0x15DB354", VA = "0x15DB354")]
		public _003CClearBatchData_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60141EC")]
		[Address(RVA = "0x15DF8E0", Offset = "0x15DF8E0", VA = "0x15DF8E0")]
		internal bool _003C_003Em__0(tcp.RoomInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003017")]
	private sealed class _003CUpdateBatchRoomInfo_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012516")]
		[FieldOffset(Offset = "0x8")]
		internal tcp.RoomInfo roomInfo;

		[Token(Token = "0x60141ED")]
		[Address(RVA = "0x15DB684", Offset = "0x15DB684", VA = "0x15DB684")]
		public _003CUpdateBatchRoomInfo_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60141EE")]
		[Address(RVA = "0x15DF978", Offset = "0x15DF978", VA = "0x15DF978")]
		internal bool _003C_003Em__0(tcp.RoomInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003018")]
	private sealed class _003CUpdateBatchRoomState_003Ec__AnonStorey6
	{
		[Token(Token = "0x4012517")]
		[FieldOffset(Offset = "0x8")]
		internal RoomStateNtf state;

		[Token(Token = "0x60141EF")]
		[Address(RVA = "0x15DB970", Offset = "0x15DB970", VA = "0x15DB970")]
		public _003CUpdateBatchRoomState_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x60141F0")]
		[Address(RVA = "0x15DFAA4", Offset = "0x15DFAA4", VA = "0x15DFAA4")]
		internal bool _003C_003Em__0(tcp.RoomInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003019")]
	private sealed class _003CUpdateBatchRoomReadyState_003Ec__AnonStorey7
	{
		[Token(Token = "0x4012518")]
		[FieldOffset(Offset = "0x8")]
		internal ulong roomid;

		[Token(Token = "0x60141F1")]
		[Address(RVA = "0x15DBC3C", Offset = "0x15DBC3C", VA = "0x15DBC3C")]
		public _003CUpdateBatchRoomReadyState_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x60141F2")]
		[Address(RVA = "0x15DFA58", Offset = "0x15DFA58", VA = "0x15DFA58")]
		internal bool _003C_003Em__0(tcp.RoomInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200301A")]
	private sealed class _003CUpdateBatchRoomPlayerAvailableMaps_003Ec__AnonStorey8
	{
		[Token(Token = "0x4012519")]
		[FieldOffset(Offset = "0x8")]
		internal RoomChangeAvailableMapsNtf info;

		[Token(Token = "0x60141F3")]
		[Address(RVA = "0x15DBFE8", Offset = "0x15DBFE8", VA = "0x15DBFE8")]
		public _003CUpdateBatchRoomPlayerAvailableMaps_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x60141F4")]
		[Address(RVA = "0x15DF9E8", Offset = "0x15DF9E8", VA = "0x15DF9E8")]
		internal bool _003C_003Em__0(tcp.RoomInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40124BF")]
	public const string LEAGEROOMGROUPACCOUNTLIST = "LEAGEROOMGROUPACCOUNTLIST";

	[Token(Token = "0x40124C0")]
	public const string LEAGEROOMGROUPNAMECACHE = "LEAGEROOMGROUPNAMECACHE";

	[Token(Token = "0x40124C1")]
	public const string LEAGEROOMGROUPNICKNAMECACHE = "LEAGEROOMGROUPNICKNAMECACHE";

	[Token(Token = "0x40124C2")]
	[FieldOffset(Offset = "0xC")]
	private ECustomRoomRole _003CMyRoomRole_003Ek__BackingField;

	[Token(Token = "0x40124C3")]
	[FieldOffset(Offset = "0x10")]
	private bool _003CAmIAtPlayerSeat_003Ek__BackingField;

	[Token(Token = "0x40124C4")]
	[FieldOffset(Offset = "0x14")]
	private tcp.RoomInfo m_CurrentRoomInfo;

	[Token(Token = "0x40124C5")]
	[FieldOffset(Offset = "0x18")]
	private RoomPlayerInfo m_MyPlayerInfo;

	[Token(Token = "0x40124C6")]
	[FieldOffset(Offset = "0x1C")]
	private RoomGroupInfo m_MyGroupInfo;

	[Token(Token = "0x40124C7")]
	[FieldOffset(Offset = "0x20")]
	public int UIRootWidth;

	[Token(Token = "0x40124C8")]
	[FieldOffset(Offset = "0x24")]
	private int m_ModeFilter;

	[Token(Token = "0x40124C9")]
	[FieldOffset(Offset = "0x28")]
	private int m_GroupFilter;

	[Token(Token = "0x40124CA")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_ShowNickName;

	[Token(Token = "0x40124CB")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<uint, uint> CardTypeItemIdDic;

	[Token(Token = "0x40124CC")]
	[FieldOffset(Offset = "0x34")]
	public Dictionary<uint, uint> LimitedCardTypeItemIdDic;

	[Token(Token = "0x40124CD")]
	[FieldOffset(Offset = "0x38")]
	public Dictionary<uint, string> RoomModeNameDict;

	[Token(Token = "0x40124CE")]
	public const string OB35_FREE_ROOM_CARD_GUIDE = "OB35_FREE_ROOM_CARD_GUIDE";

	[Token(Token = "0x40124CF")]
	[FieldOffset(Offset = "0x3C")]
	public Dictionary<uint, string> CustomRoomGameSettingTitle;

	[Token(Token = "0x40124D0")]
	public const uint PropID_RoomListUpdated = 2u;

	[Token(Token = "0x40124D1")]
	public const uint PropID_RoomInfoUpdated = 4u;

	[Token(Token = "0x40124D2")]
	[FieldOffset(Offset = "0x40")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x40124D3")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<uint, List<tcp.RoomBasicInfo>> m_RoomListDict;

	[Token(Token = "0x40124D4")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<uint, List<ulong>> m_FailRoomListDict;

	[Token(Token = "0x40124D5")]
	[FieldOffset(Offset = "0x4C")]
	private MemoryStream m_MemStream;

	[Token(Token = "0x40124D6")]
	[FieldOffset(Offset = "0x50")]
	private BinaryWriter m_Writer;

	[Token(Token = "0x40124D7")]
	[FieldOffset(Offset = "0x54")]
	private BinaryReader m_Reader;

	[Token(Token = "0x40124D8")]
	[FieldOffset(Offset = "0x58")]
	private bool m_HasSendTimeoutPack;

	[Token(Token = "0x40124D9")]
	[FieldOffset(Offset = "0x5C")]
	private Action m_MatchNotifySucAction;

	[Token(Token = "0x40124DA")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<uint, ulong> m_CreateRoomCDFinish;

	[Token(Token = "0x40124DB")]
	[FieldOffset(Offset = "0x64")]
	private Dictionary<uint, int> m_CreateRoomCD;

	[Token(Token = "0x40124DC")]
	[FieldOffset(Offset = "0x68")]
	private ulong m_LatestTryConnectMatchId;

	[Token(Token = "0x40124DD")]
	[FieldOffset(Offset = "0x70")]
	public bool LatestWorkshopRoom;

	[Token(Token = "0x40124DE")]
	public const uint RoomSettingDropType_CheatCode = 13u;

	[Token(Token = "0x40124DF")]
	[FieldOffset(Offset = "0x74")]
	private uint _003CDropIndex_003Ek__BackingField;

	[Token(Token = "0x40124E0")]
	[FieldOffset(Offset = "0x78")]
	private ulong m_ReopenId;

	[Token(Token = "0x40124E1")]
	[FieldOffset(Offset = "0x80")]
	private int m_SelectedPos;

	[Token(Token = "0x40124E2")]
	[FieldOffset(Offset = "0x84")]
	private List<tcp.RoomInfo> m_BatchRoomInfoList;

	[Token(Token = "0x40124E3")]
	private const int ADCS_MIN_ROUND = 7;

	[Token(Token = "0x40124E4")]
	[FieldOffset(Offset = "0x88")]
	private Dictionary<uint, int> m_AdCSShopSettingValueDic;

	[Token(Token = "0x40124E5")]
	[FieldOffset(Offset = "0x8C")]
	private Dictionary<uint, bool> m_AdCSShopSettingCheckDic;

	[Token(Token = "0x40124E6")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<int, int> m_AdCSEcoRoundValueDic;

	[Token(Token = "0x40124E7")]
	[FieldOffset(Offset = "0x94")]
	private bool _003CADCSEnabled_003Ek__BackingField;

	[Token(Token = "0x40124E8")]
	[FieldOffset(Offset = "0x98")]
	private int _003CAdCSEcoRound_003Ek__BackingField;

	[Token(Token = "0x40124E9")]
	[FieldOffset(Offset = "0x0")]
	public static readonly uint WereWolvesMapConfigID;

	[Token(Token = "0x40124EA")]
	private const int WereWolvesParamBitStep = 8;

	[Token(Token = "0x40124EB")]
	[FieldOffset(Offset = "0x4")]
	public static readonly uint RushingPetsMapConfigID;

	[Token(Token = "0x40124EC")]
	private const int RushingPetsParamBitStep = 8;

	[Token(Token = "0x40124ED")]
	[FieldOffset(Offset = "0x9C")]
	private int _003CScoreVisible_003Ek__BackingField;

	[Token(Token = "0x40124EE")]
	[FieldOffset(Offset = "0x8")]
	private static Converter<string, int> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x40124EF")]
	[FieldOffset(Offset = "0xC")]
	private static Converter<string, int> _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x40124F0")]
	[FieldOffset(Offset = "0x10")]
	private static Func<KeyValuePair<uint, bool>, bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x170014C2")]
	public ECustomRoomRole MyRoomRole
	{
		[Token(Token = "0x601412F")]
		[Address(RVA = "0x15C87C4", Offset = "0x15C87C4", VA = "0x15C87C4")]
		get
		{
			return default(ECustomRoomRole);
		}
		[Token(Token = "0x6014130")]
		[Address(RVA = "0x15C87CC", Offset = "0x15C87CC", VA = "0x15C87CC")]
		set
		{
		}
	}

	[Token(Token = "0x170014C3")]
	public bool AmIAtPlayerSeat
	{
		[Token(Token = "0x6014131")]
		[Address(RVA = "0x15C87D4", Offset = "0x15C87D4", VA = "0x15C87D4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014132")]
		[Address(RVA = "0x15C87DC", Offset = "0x15C87DC", VA = "0x15C87DC")]
		private set
		{
		}
	}

	[Token(Token = "0x170014C4")]
	public int ModeFilter
	{
		[Token(Token = "0x6014133")]
		[Address(RVA = "0x15C87E4", Offset = "0x15C87E4", VA = "0x15C87E4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6014134")]
		[Address(RVA = "0x15C883C", Offset = "0x15C883C", VA = "0x15C883C")]
		set
		{
		}
	}

	[Token(Token = "0x170014C5")]
	public int GroupFilter
	{
		[Token(Token = "0x6014135")]
		[Address(RVA = "0x15C889C", Offset = "0x15C889C", VA = "0x15C889C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6014136")]
		[Address(RVA = "0x15C88F4", Offset = "0x15C88F4", VA = "0x15C88F4")]
		set
		{
		}
	}

	[Token(Token = "0x170014C6")]
	public bool ShowNickName
	{
		[Token(Token = "0x6014137")]
		[Address(RVA = "0x15C8954", Offset = "0x15C8954", VA = "0x15C8954")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014138")]
		[Address(RVA = "0x15C89AC", Offset = "0x15C89AC", VA = "0x15C89AC")]
		set
		{
		}
	}

	[Token(Token = "0x170014C7")]
	public ulong LatestTryConnectMatchId
	{
		[Token(Token = "0x601413D")]
		[Address(RVA = "0x15C8FE0", Offset = "0x15C8FE0", VA = "0x15C8FE0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x601413E")]
		[Address(RVA = "0x15C9038", Offset = "0x15C9038", VA = "0x15C9038")]
		set
		{
		}
	}

	[Token(Token = "0x170014C8")]
	public uint DropIndex
	{
		[Token(Token = "0x601413F")]
		[Address(RVA = "0x15C90B4", Offset = "0x15C90B4", VA = "0x15C90B4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014140")]
		[Address(RVA = "0x15C90BC", Offset = "0x15C90BC", VA = "0x15C90BC")]
		set
		{
		}
	}

	[Token(Token = "0x170014C9")]
	public bool DisableAuthority
	{
		[Token(Token = "0x6014144")]
		[Address(RVA = "0x15C9E38", Offset = "0x15C9E38", VA = "0x15C9E38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170014CA")]
	public tcp.RoomInfo CurrentRoomInfo
	{
		[Token(Token = "0x6014148")]
		[Address(RVA = "0x15CABF4", Offset = "0x15CABF4", VA = "0x15CABF4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014CB")]
	public RoomPlayerInfo MyPlayerInfo
	{
		[Token(Token = "0x6014149")]
		[Address(RVA = "0x15CAC4C", Offset = "0x15CAC4C", VA = "0x15CAC4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014CC")]
	public uint CurrentGroupMode
	{
		[Token(Token = "0x601414A")]
		[Address(RVA = "0x15CACA4", Offset = "0x15CACA4", VA = "0x15CACA4")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x170014CD")]
	public List<RoomPlayerInfo> CurrentSpectators
	{
		[Token(Token = "0x601414B")]
		[Address(RVA = "0x15CAD1C", Offset = "0x15CAD1C", VA = "0x15CAD1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014CE")]
	public List<RoomGroupInfo> CurrentGroups
	{
		[Token(Token = "0x601414C")]
		[Address(RVA = "0x15CAE10", Offset = "0x15CAE10", VA = "0x15CAE10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014CF")]
	public int CurrentRealGroupCount
	{
		[Token(Token = "0x601414F")]
		[Address(RVA = "0x15CB0A8", Offset = "0x15CB0A8", VA = "0x15CB0A8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170014D0")]
	public int CurrentPlayerCount
	{
		[Token(Token = "0x6014150")]
		[Address(RVA = "0x15CB280", Offset = "0x15CB280", VA = "0x15CB280")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170014D1")]
	public int CurrentSpectatorCount
	{
		[Token(Token = "0x6014152")]
		[Address(RVA = "0x15CB648", Offset = "0x15CB648", VA = "0x15CB648")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170014D2")]
	public int CurrentGroupCount
	{
		[Token(Token = "0x6014153")]
		[Address(RVA = "0x15CB728", Offset = "0x15CB728", VA = "0x15CB728")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170014D3")]
	public int PlayerPrefCheatCode
	{
		[Token(Token = "0x60141B5")]
		[Address(RVA = "0x15DAC98", Offset = "0x15DAC98", VA = "0x15DAC98")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60141B6")]
		[Address(RVA = "0x15DAE74", Offset = "0x15DAE74", VA = "0x15DAE74")]
		set
		{
		}
	}

	[Token(Token = "0x170014D4")]
	public bool ADCSEnabled
	{
		[Token(Token = "0x60141C0")]
		[Address(RVA = "0x15CCAE0", Offset = "0x15CCAE0", VA = "0x15CCAE0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60141C1")]
		[Address(RVA = "0x15D2504", Offset = "0x15D2504", VA = "0x15D2504")]
		set
		{
		}
	}

	[Token(Token = "0x170014D5")]
	public int AdCSEcoRound
	{
		[Token(Token = "0x60141C2")]
		[Address(RVA = "0x15DBFF0", Offset = "0x15DBFF0", VA = "0x15DBFF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60141C3")]
		[Address(RVA = "0x15DBFF8", Offset = "0x15DBFF8", VA = "0x15DBFF8")]
		set
		{
		}
	}

	[Token(Token = "0x170014D6")]
	public ESocial.Language WereWolvesRoomLanguage
	{
		[Token(Token = "0x60141D3")]
		[Address(RVA = "0x15DCD10", Offset = "0x15DCD10", VA = "0x15DCD10")]
		get
		{
			return default(ESocial.Language);
		}
	}

	[Token(Token = "0x170014D7")]
	public int ScoreVisible
	{
		[Token(Token = "0x60141D9")]
		[Address(RVA = "0x15DCD84", Offset = "0x15DCD84", VA = "0x15DCD84")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60141DA")]
		[Address(RVA = "0x15DC05C", Offset = "0x15DC05C", VA = "0x15DC05C")]
		set
		{
		}
	}

	[Token(Token = "0x601412D")]
	[Address(RVA = "0x15C7F60", Offset = "0x15C7F60", VA = "0x15C7F60")]
	public UIModelCustomRoom()
	{
	}

	[Token(Token = "0x601412E")]
	[Address(RVA = "0x15C876C", Offset = "0x15C876C", VA = "0x15C876C", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014139")]
	[Address(RVA = "0x15C8A0C", Offset = "0x15C8A0C", VA = "0x15C8A0C")]
	public bool InitCreateRoomCD()
	{
		return default(bool);
	}

	[Token(Token = "0x601413A")]
	[Address(RVA = "0x15C8CA8", Offset = "0x15C8CA8", VA = "0x15C8CA8")]
	public void SetCreateRoomCoolDown(proto.EInventory.ItemSubType subType)
	{
	}

	[Token(Token = "0x601413B")]
	[Address(RVA = "0x15C8DF8", Offset = "0x15C8DF8", VA = "0x15C8DF8")]
	public bool CheckCreateRoomCoolDown(proto.EInventory.ItemSubType subType)
	{
		return default(bool);
	}

	[Token(Token = "0x601413C")]
	[Address(RVA = "0x15C8F14", Offset = "0x15C8F14", VA = "0x15C8F14")]
	public ulong GetCoolDown(proto.EInventory.ItemSubType subType)
	{
		return default(ulong);
	}

	[Token(Token = "0x6014141")]
	[Address(RVA = "0x15C90C4", Offset = "0x15C90C4", VA = "0x15C90C4", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6014142")]
	[Address(RVA = "0x15C9BE8", Offset = "0x15C9BE8", VA = "0x15C9BE8", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6014143")]
	[Address(RVA = "0x15C9DC8", Offset = "0x15C9DC8", VA = "0x15C9DC8", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014145")]
	[Address(RVA = "0x15C9F1C", Offset = "0x15C9F1C", VA = "0x15C9F1C")]
	public List<tcp.RoomBasicInfo> GetRoomListByType(tcp.ERoom.TabType roomType)
	{
		return null;
	}

	[Token(Token = "0x6014146")]
	[Address(RVA = "0x15CA708", Offset = "0x15CA708", VA = "0x15CA708")]
	public List<ulong> GetFaillRoomListByType(tcp.ERoom.TabType roomType)
	{
		return null;
	}

	[Token(Token = "0x6014147")]
	[Address(RVA = "0x15CA05C", Offset = "0x15CA05C", VA = "0x15CA05C")]
	public List<tcp.RoomBasicInfo> GenerateRoomBasicInfoFromBatchRoom()
	{
		return null;
	}

	[Token(Token = "0x601414D")]
	[Address(RVA = "0x15CAF30", Offset = "0x15CAF30", VA = "0x15CAF30")]
	public uint GetGroupIcon()
	{
		return default(uint);
	}

	[Token(Token = "0x601414E")]
	[Address(RVA = "0x15CB030", Offset = "0x15CB030", VA = "0x15CB030")]
	public ulong GetMyGroupID()
	{
		return default(ulong);
	}

	[Token(Token = "0x6014151")]
	[Address(RVA = "0x15CA830", Offset = "0x15CA830", VA = "0x15CA830")]
	public uint CalPlayerCount(tcp.RoomInfo info)
	{
		return default(uint);
	}

	[Token(Token = "0x6014154")]
	[Address(RVA = "0x15CB838", Offset = "0x15CB838", VA = "0x15CB838")]
	public void RequestSyncOptionalMapResStatus(tcp.ERoom.PlayerPatchOptionalResStatus status)
	{
	}

	[Token(Token = "0x6014155")]
	[Address(RVA = "0x15CBAB8", Offset = "0x15CBAB8", VA = "0x15CBAB8")]
	public void RequestRoomList(tcp.ERoom.TabType tabType, ulong id = 0uL, [Optional] List<EMatch.GameMode> gameModes)
	{
	}

	[Token(Token = "0x6014156")]
	[Address(RVA = "0x15CBE60", Offset = "0x15CBE60", VA = "0x15CBE60")]
	public void RequestCreateRoom(RoomParams param)
	{
	}

	[Token(Token = "0x6014157")]
	[Address(RVA = "0x15CD7C8", Offset = "0x15CD7C8", VA = "0x15CD7C8")]
	public void RequestChangeRoom(RoomParams param)
	{
	}

	[Token(Token = "0x6014158")]
	[Address(RVA = "0x15CDC50", Offset = "0x15CDC50", VA = "0x15CDC50")]
	public void RequestJoinRoom(ulong id, string code = "", string name = "", string nameAbbr = "", bool solo = false, bool skipTickCheck = false, ulong inviterid = 0uL, uint roomType = 0u, ECustomRoomJoinType joinType = ECustomRoomJoinType.ECustomRoomJoinType_Normal, ECustomRoomJoinScene joinScene = ECustomRoomJoinScene.ECustomRoomJoinScene_Normal)
	{
	}

	[Token(Token = "0x6014159")]
	[Address(RVA = "0x15CE6DC", Offset = "0x15CE6DC", VA = "0x15CE6DC")]
	public void InvitationRequestJoinRoom(ulong id, bool skipTickCheck, ulong inviterid, uint map, uint mode, uint roomtype)
	{
	}

	[Token(Token = "0x601415A")]
	[Address(RVA = "0x15CE84C", Offset = "0x15CE84C", VA = "0x15CE84C")]
	public void RequestSpectateRoom(ulong id, string code = "", bool solo = false, uint roomType = 0u)
	{
	}

	[Token(Token = "0x601415B")]
	[Address(RVA = "0x15CF0CC", Offset = "0x15CF0CC", VA = "0x15CF0CC")]
	public void RequestRoomInfo(ulong id, tcp.ERoom.Type roomType)
	{
	}

	[Token(Token = "0x601415C")]
	[Address(RVA = "0x15CF2B4", Offset = "0x15CF2B4", VA = "0x15CF2B4")]
	public void RequestWorkshopTimeoutOrMatchSuccess(bool request)
	{
	}

	[Token(Token = "0x601415D")]
	[Address(RVA = "0x15CF41C", Offset = "0x15CF41C", VA = "0x15CF41C")]
	public void RequestWorkshopTimeout()
	{
	}

	[Token(Token = "0x601415E")]
	[Address(RVA = "0x15CF5F8", Offset = "0x15CF5F8", VA = "0x15CF5F8")]
	public void RequestLeaveRoom()
	{
	}

	[Token(Token = "0x601415F")]
	[Address(RVA = "0x15CF9BC", Offset = "0x15CF9BC", VA = "0x15CF9BC")]
	public void RequestBatchLeaveRoom(ulong id)
	{
	}

	[Token(Token = "0x6014160")]
	[Address(RVA = "0x15CFE8C", Offset = "0x15CFE8C", VA = "0x15CFE8C")]
	public void RequestStartGame(ulong id)
	{
	}

	[Token(Token = "0x6014161")]
	[Address(RVA = "0x15D0040", Offset = "0x15D0040", VA = "0x15D0040")]
	public void ClearMatchSucNotify()
	{
	}

	[Token(Token = "0x6014162")]
	[Address(RVA = "0x15D009C", Offset = "0x15D009C", VA = "0x15D009C")]
	public void RequsetCountDown(ulong id, uint time)
	{
	}

	[Token(Token = "0x6014163")]
	[Address(RVA = "0x15D0294", Offset = "0x15D0294", VA = "0x15D0294")]
	public void SetWaitMatchAction(Action match)
	{
	}

	[Token(Token = "0x6014164")]
	[Address(RVA = "0x15D02F4", Offset = "0x15D02F4", VA = "0x15D02F4")]
	public bool NeewWaitLoadingGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6014165")]
	[Address(RVA = "0x15D050C", Offset = "0x15D050C", VA = "0x15D050C")]
	public void RequestDropMatch()
	{
	}

	[Token(Token = "0x6014166")]
	[Address(RVA = "0x15D0664", Offset = "0x15D0664", VA = "0x15D0664")]
	public void RequestSetReady(bool ready)
	{
	}

	[Token(Token = "0x6014167")]
	[Address(RVA = "0x15D0830", Offset = "0x15D0830", VA = "0x15D0830")]
	public void RequestSwitchSeat(ulong account_id, tcp.ERoom.PlayerRole role = tcp.ERoom.PlayerRole.PlayerRole_MEMBER, uint teamIndex = 0u, uint memberIndex = 0u)
	{
	}

	[Token(Token = "0x6014168")]
	[Address(RVA = "0x15D0B24", Offset = "0x15D0B24", VA = "0x15D0B24")]
	public void RequestSwitchGroup(int from, int to)
	{
	}

	[Token(Token = "0x6014169")]
	[Address(RVA = "0x15D0EE0", Offset = "0x15D0EE0", VA = "0x15D0EE0")]
	public void RequestInvite(ulong account_id)
	{
	}

	[Token(Token = "0x601416A")]
	[Address(RVA = "0x15D1094", Offset = "0x15D1094", VA = "0x15D1094")]
	public void RequestUpdateMaps(List<uint> maps)
	{
	}

	[Token(Token = "0x601416B")]
	[Address(RVA = "0x15D12F4", Offset = "0x15D12F4", VA = "0x15D12F4")]
	public void RequestRoomCreateRules()
	{
	}

	[Token(Token = "0x601416C")]
	[Address(RVA = "0x15D151C", Offset = "0x15D151C", VA = "0x15D151C")]
	public void RequestKickPlayer(ulong id)
	{
	}

	[Token(Token = "0x601416D")]
	[Address(RVA = "0x15CF7EC", Offset = "0x15CF7EC", VA = "0x15CF7EC")]
	public void ClearData(string ctx)
	{
	}

	[Token(Token = "0x601416E")]
	[Address(RVA = "0x15D16F4", Offset = "0x15D16F4", VA = "0x15D16F4")]
	public void UpdateRoomList(RoomListRes infos)
	{
	}

	[Token(Token = "0x601416F")]
	[Address(RVA = "0x15D1B3C", Offset = "0x15D1B3C", VA = "0x15D1B3C")]
	public void ClearRoomList()
	{
	}

	[Token(Token = "0x6014170")]
	[Address(RVA = "0x15D1BFC", Offset = "0x15D1BFC", VA = "0x15D1BFC")]
	public void RecordFailJoinRoom(tcp.ERoom.Type type, ulong roomID)
	{
	}

	[Token(Token = "0x6014171")]
	[Address(RVA = "0x15D1D90", Offset = "0x15D1D90", VA = "0x15D1D90")]
	private void UpdateRoomInfo(tcp.RoomInfo info)
	{
	}

	[Token(Token = "0x6014172")]
	[Address(RVA = "0x15D35D0", Offset = "0x15D35D0", VA = "0x15D35D0")]
	public bool EnableRoomVoiceChat()
	{
		return default(bool);
	}

	[Token(Token = "0x6014173")]
	[Address(RVA = "0x15D39A8", Offset = "0x15D39A8", VA = "0x15D39A8")]
	public void UpdateCreateRoomInfo(tcp.RoomInfo info)
	{
	}

	[Token(Token = "0x6014174")]
	[Address(RVA = "0x15D3B58", Offset = "0x15D3B58", VA = "0x15D3B58")]
	public void UpdateBatchCreateRoomInfo(tcp.RoomInfo info)
	{
	}

	[Token(Token = "0x6014175")]
	[Address(RVA = "0x15D3C9C", Offset = "0x15D3C9C", VA = "0x15D3C9C")]
	public void BatchJoinRoom(ulong id)
	{
	}

	[Token(Token = "0x6014176")]
	[Address(RVA = "0x15D401C", Offset = "0x15D401C", VA = "0x15D401C")]
	public void UpdateCurrentRoomInfo(tcp.RoomInfo info, bool checkSeat = false)
	{
	}

	[Token(Token = "0x6014177")]
	[Address(RVA = "0x15D4410", Offset = "0x15D4410", VA = "0x15D4410")]
	public void CacheGroupNameAndAbbrName()
	{
	}

	[Token(Token = "0x6014178")]
	[Address(RVA = "0x15D4824", Offset = "0x15D4824", VA = "0x15D4824")]
	public void UpdateCurrentOptionalMapResState(RoomSyncPatchOptionalResStatusNtf resData)
	{
	}

	[Token(Token = "0x6014179")]
	[Address(RVA = "0x15D4CC0", Offset = "0x15D4CC0", VA = "0x15D4CC0")]
	public void UpdateCurrentReadyState(tcp.RoomInfo roomInfo, List<RoomPlayerInfo> players, bool needNotify)
	{
	}

	[Token(Token = "0x601417A")]
	[Address(RVA = "0x15D529C", Offset = "0x15D529C", VA = "0x15D529C")]
	public void UpdateRoomState(tcp.RoomInfo roomInfo, RoomStateNtf state, bool needNotify)
	{
	}

	[Token(Token = "0x601417B")]
	[Address(RVA = "0x15D54AC", Offset = "0x15D54AC", VA = "0x15D54AC")]
	public void UpdateRoomPlayerAvailableMaps(tcp.RoomInfo roomInfo, RoomChangeAvailableMapsNtf info, bool needNotify)
	{
	}

	[Token(Token = "0x601417C")]
	[Address(RVA = "0x15D5AB4", Offset = "0x15D5AB4", VA = "0x15D5AB4")]
	public void UpdateRoom()
	{
	}

	[Token(Token = "0x601417D")]
	[Address(RVA = "0x15D1F20", Offset = "0x15D1F20", VA = "0x15D1F20")]
	private RoomPlayerInfo FindMyPlayerInfoFromRoomInfo()
	{
		return null;
	}

	[Token(Token = "0x601417E")]
	[Address(RVA = "0x15D5C10", Offset = "0x15D5C10", VA = "0x15D5C10")]
	public bool IsValidSpectator()
	{
		return default(bool);
	}

	[Token(Token = "0x601417F")]
	[Address(RVA = "0x15D5DD4", Offset = "0x15D5DD4", VA = "0x15D5DD4")]
	public bool IsValidLeaguePlayer(uint groupMode)
	{
		return default(bool);
	}

	[Token(Token = "0x6014180")]
	[Address(RVA = "0x15D63E0", Offset = "0x15D63E0", VA = "0x15D63E0")]
	public bool IsValidCasualPlayer()
	{
		return default(bool);
	}

	[Token(Token = "0x6014181")]
	[Address(RVA = "0x15D6490", Offset = "0x15D6490", VA = "0x15D6490")]
	public bool CheckIsValidUser()
	{
		return default(bool);
	}

	[Token(Token = "0x6014182")]
	[Address(RVA = "0x15D6B74", Offset = "0x15D6B74", VA = "0x15D6B74")]
	public bool IsRoomMaster()
	{
		return default(bool);
	}

	[Token(Token = "0x6014183")]
	[Address(RVA = "0x15D6C98", Offset = "0x15D6C98", VA = "0x15D6C98")]
	public bool IsRoomPartner()
	{
		return default(bool);
	}

	[Token(Token = "0x6014184")]
	[Address(RVA = "0x15D6DBC", Offset = "0x15D6DBC", VA = "0x15D6DBC")]
	public bool IsValidPCUser()
	{
		return default(bool);
	}

	[Token(Token = "0x6014185")]
	[Address(RVA = "0x15D6E30", Offset = "0x15D6E30", VA = "0x15D6E30")]
	public bool CheckEmptySeat(out uint teamIndex, out uint memberIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6014186")]
	[Address(RVA = "0x15D70AC", Offset = "0x15D70AC", VA = "0x15D70AC")]
	public bool IsNeedLeave(RoomPlayerInfo player, tcp.RoomInfo room)
	{
		return default(bool);
	}

	[Token(Token = "0x6014187")]
	[Address(RVA = "0x15D725C", Offset = "0x15D725C", VA = "0x15D725C")]
	public bool IsSelf(ulong id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014188")]
	[Address(RVA = "0x15D73B4", Offset = "0x15D73B4", VA = "0x15D73B4")]
	public bool IsCreater()
	{
		return default(bool);
	}

	[Token(Token = "0x6014189")]
	[Address(RVA = "0x15D7418", Offset = "0x15D7418", VA = "0x15D7418")]
	public bool IsPlayer()
	{
		return default(bool);
	}

	[Token(Token = "0x601418A")]
	[Address(RVA = "0x15D7484", Offset = "0x15D7484", VA = "0x15D7484")]
	public bool IsSpectator()
	{
		return default(bool);
	}

	[Token(Token = "0x601418B")]
	[Address(RVA = "0x15D74F0", Offset = "0x15D74F0", VA = "0x15D74F0")]
	public bool IsGroupLeader()
	{
		return default(bool);
	}

	[Token(Token = "0x601418C")]
	[Address(RVA = "0x15D7650", Offset = "0x15D7650", VA = "0x15D7650")]
	public bool NeedShowReadyBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x601418D")]
	[Address(RVA = "0x15D778C", Offset = "0x15D778C", VA = "0x15D778C")]
	public bool IsReadyBtnEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x601418E")]
	[Address(RVA = "0x15D7800", Offset = "0x15D7800", VA = "0x15D7800")]
	public bool CurrentReadyState()
	{
		return default(bool);
	}

	[Token(Token = "0x601418F")]
	[Address(RVA = "0x15D7874", Offset = "0x15D7874", VA = "0x15D7874")]
	public void OnCustomRoomDismissed(tcp.ERoom.DismissReason reason)
	{
	}

	[Token(Token = "0x6014190")]
	[Address(RVA = "0x15D8064", Offset = "0x15D8064", VA = "0x15D8064")]
	public bool IsInRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6014191")]
	[Address(RVA = "0x15D76C4", Offset = "0x15D76C4", VA = "0x15D76C4")]
	public bool IsInLeagueRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6014192")]
	[Address(RVA = "0x15D80DC", Offset = "0x15D80DC", VA = "0x15D80DC")]
	public bool IsCasualLikeRoom(tcp.ERoom.Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6014193")]
	[Address(RVA = "0x15D8158", Offset = "0x15D8158", VA = "0x15D8158")]
	public bool IsCasualRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6014194")]
	[Address(RVA = "0x15D3938", Offset = "0x15D3938", VA = "0x15D3938")]
	public bool IsWorkshopRoom(tcp.ERoom.Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6014195")]
	[Address(RVA = "0x15D0470", Offset = "0x15D0470", VA = "0x15D0470")]
	public bool IsInWorkshopRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6014196")]
	[Address(RVA = "0x15D81F4", Offset = "0x15D81F4", VA = "0x15D81F4")]
	public bool IsInRushingPetsRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6014197")]
	[Address(RVA = "0x15D8290", Offset = "0x15D8290", VA = "0x15D8290")]
	public bool IsCheatcodeRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6014198")]
	[Address(RVA = "0x15D38C4", Offset = "0x15D38C4", VA = "0x15D38C4")]
	public bool IsLeagueRoom(tcp.ERoom.Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6014199")]
	[Address(RVA = "0x15D82FC", Offset = "0x15D82FC", VA = "0x15D82FC")]
	public bool IsWereWolvesRoom(tcp.ERoom.Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x601419A")]
	[Address(RVA = "0x15D836C", Offset = "0x15D836C", VA = "0x15D836C")]
	public bool IsInSpectatorSeat()
	{
		return default(bool);
	}

	[Token(Token = "0x601419B")]
	[Address(RVA = "0x15D85FC", Offset = "0x15D85FC", VA = "0x15D85FC")]
	public bool CheckIsValidSpectatorNumSetting(uint num)
	{
		return default(bool);
	}

	[Token(Token = "0x601419C")]
	[Address(RVA = "0x15D8678", Offset = "0x15D8678", VA = "0x15D8678")]
	public ulong GetNotReadyMemberId()
	{
		return default(ulong);
	}

	[Token(Token = "0x601419D")]
	[Address(RVA = "0x15D8CA4", Offset = "0x15D8CA4", VA = "0x15D8CA4")]
	public string GetNameById(ulong id)
	{
		return null;
	}

	[Token(Token = "0x601419E")]
	[Address(RVA = "0x15D92E4", Offset = "0x15D92E4", VA = "0x15D92E4")]
	public RoomPlayerInfo GetCurRoomPlayerInfoById(ulong id)
	{
		return null;
	}

	[Token(Token = "0x601419F")]
	[Address(RVA = "0x15D9854", Offset = "0x15D9854", VA = "0x15D9854")]
	public bool CheckIsValidPlayerNumSetting(uint num)
	{
		return default(bool);
	}

	[Token(Token = "0x60141A0")]
	[Address(RVA = "0x15D99D0", Offset = "0x15D99D0", VA = "0x15D99D0")]
	public bool IsPlayerNumValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60141A1")]
	[Address(RVA = "0x15D9AE0", Offset = "0x15D9AE0", VA = "0x15D9AE0")]
	public uint GetValidPlayerNum()
	{
		return default(uint);
	}

	[Token(Token = "0x60141A2")]
	[Address(RVA = "0x15D9DB0", Offset = "0x15D9DB0", VA = "0x15D9DB0")]
	public bool IsPlayerMapsAllAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x60141A3")]
	[Address(RVA = "0x15DA0AC", Offset = "0x15DA0AC", VA = "0x15DA0AC")]
	public bool IsObserverMapsAllAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x60141A4")]
	[Address(RVA = "0x15DA2DC", Offset = "0x15DA2DC", VA = "0x15DA2DC")]
	public void SetReopenId(ulong id)
	{
	}

	[Token(Token = "0x60141A5")]
	[Address(RVA = "0x15DA358", Offset = "0x15DA358", VA = "0x15DA358")]
	public ulong GetReopenId()
	{
		return default(ulong);
	}

	[Token(Token = "0x60141A6")]
	[Address(RVA = "0x15DA3B0", Offset = "0x15DA3B0", VA = "0x15DA3B0")]
	public void ResetReopenId()
	{
	}

	[Token(Token = "0x60141A7")]
	[Address(RVA = "0x15DA410", Offset = "0x15DA410", VA = "0x15DA410")]
	public void SaveOpenRoomId(ulong id)
	{
	}

	[Token(Token = "0x60141A8")]
	[Address(RVA = "0x15DA480", Offset = "0x15DA480", VA = "0x15DA480")]
	public void LogRoomId(ulong id)
	{
	}

	[Token(Token = "0x60141A9")]
	[Address(RVA = "0x15DA4F0", Offset = "0x15DA4F0", VA = "0x15DA4F0")]
	public void LogBatchMatchId(ulong id)
	{
	}

	[Token(Token = "0x60141AA")]
	[Address(RVA = "0x15DA560", Offset = "0x15DA560", VA = "0x15DA560")]
	public void SetSelected(int index)
	{
	}

	[Token(Token = "0x60141AB")]
	[Address(RVA = "0x15DA5C0", Offset = "0x15DA5C0", VA = "0x15DA5C0")]
	public int GetSelected()
	{
		return default(int);
	}

	[Token(Token = "0x60141AC")]
	[Address(RVA = "0x15DA618", Offset = "0x15DA618", VA = "0x15DA618")]
	public void ClearSelected()
	{
	}

	[Token(Token = "0x60141AD")]
	[Address(RVA = "0x15DA674", Offset = "0x15DA674", VA = "0x15DA674")]
	public bool HasSelected()
	{
		return default(bool);
	}

	[Token(Token = "0x60141AE")]
	[Address(RVA = "0x15DA6E0", Offset = "0x15DA6E0", VA = "0x15DA6E0")]
	public string GetGroupName(int index)
	{
		return null;
	}

	[Token(Token = "0x60141AF")]
	[Address(RVA = "0x15DA828", Offset = "0x15DA828", VA = "0x15DA828")]
	public bool IsEnableVoice()
	{
		return default(bool);
	}

	[Token(Token = "0x60141B0")]
	[Address(RVA = "0x15DA8BC", Offset = "0x15DA8BC", VA = "0x15DA8BC")]
	private bool IsRoomSettingsTrue(uint roomSetting, uint setting)
	{
		return default(bool);
	}

	[Token(Token = "0x60141B1")]
	[Address(RVA = "0x15D3520", Offset = "0x15D3520", VA = "0x15D3520")]
	public uint GetRoomSettingValue(uint roomSetting, uint start, uint end)
	{
		return default(uint);
	}

	[Token(Token = "0x60141B2")]
	[Address(RVA = "0x15DA944", Offset = "0x15DA944", VA = "0x15DA944")]
	public uint SetRoomSetting(uint roomSetting, uint setting, bool value)
	{
		return default(uint);
	}

	[Token(Token = "0x60141B3")]
	[Address(RVA = "0x15DA9E0", Offset = "0x15DA9E0", VA = "0x15DA9E0")]
	public uint SetRoomSetting(uint roomSetting, uint start, uint end, uint value)
	{
		return default(uint);
	}

	[Token(Token = "0x60141B4")]
	[Address(RVA = "0x15DAA90", Offset = "0x15DAA90", VA = "0x15DAA90")]
	public proto.EInventory.ItemSubType GetRoomCardTypeByRoomType()
	{
		return default(proto.EInventory.ItemSubType);
	}

	[Token(Token = "0x60141B7")]
	[Address(RVA = "0x15DB058", Offset = "0x15DB058", VA = "0x15DB058")]
	public bool IsInBatchRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x60141B8")]
	[Address(RVA = "0x15DB120", Offset = "0x15DB120", VA = "0x15DB120")]
	public bool IsInCurrentBatchRoom(ulong id)
	{
		return default(bool);
	}

	[Token(Token = "0x60141B9")]
	[Address(RVA = "0x15DB1E4", Offset = "0x15DB1E4", VA = "0x15DB1E4")]
	public bool IsMyBatchRoom(ulong id)
	{
		return default(bool);
	}

	[Token(Token = "0x60141BA")]
	[Address(RVA = "0x15CFB84", Offset = "0x15CFB84", VA = "0x15CFB84")]
	public void ClearBatchData(ulong roomid, tcp.ERoom.DismissReason reason)
	{
	}

	[Token(Token = "0x60141BB")]
	[Address(RVA = "0x15DB35C", Offset = "0x15DB35C", VA = "0x15DB35C")]
	public void UpdateBatchRoomInfo(tcp.RoomInfo roomInfo)
	{
	}

	[Token(Token = "0x60141BC")]
	[Address(RVA = "0x15DB68C", Offset = "0x15DB68C", VA = "0x15DB68C")]
	public void UpdateBatchRoomState(RoomStateNtf state)
	{
	}

	[Token(Token = "0x60141BD")]
	[Address(RVA = "0x15DB978", Offset = "0x15DB978", VA = "0x15DB978")]
	public void UpdateBatchRoomReadyState(ulong roomid, List<RoomPlayerInfo> players)
	{
	}

	[Token(Token = "0x60141BE")]
	[Address(RVA = "0x15DBC44", Offset = "0x15DBC44", VA = "0x15DBC44")]
	public int GetBatchRoomCount()
	{
		return default(int);
	}

	[Token(Token = "0x60141BF")]
	[Address(RVA = "0x15DBD04", Offset = "0x15DBD04", VA = "0x15DBD04")]
	public void UpdateBatchRoomPlayerAvailableMaps(RoomChangeAvailableMapsNtf info)
	{
	}

	[Token(Token = "0x60141C4")]
	[Address(RVA = "0x15DC000", Offset = "0x15DC000", VA = "0x15DC000")]
	public void ResetAdCSEcoRound()
	{
	}

	[Token(Token = "0x60141C5")]
	[Address(RVA = "0x15C91EC", Offset = "0x15C91EC", VA = "0x15C91EC")]
	public void InitDefaultCSSettingFromConfig()
	{
	}

	[Token(Token = "0x60141C6")]
	[Address(RVA = "0x15D250C", Offset = "0x15D250C", VA = "0x15D250C")]
	public void InitCSShopSettingFromBytes()
	{
	}

	[Token(Token = "0x60141C7")]
	[Address(RVA = "0x15D321C", Offset = "0x15D321C", VA = "0x15D321C")]
	public void InitSpectatorSettingFromBytes()
	{
	}

	[Token(Token = "0x60141C8")]
	[Address(RVA = "0x15DC064", Offset = "0x15DC064", VA = "0x15DC064")]
	public int GetCSShopSettingValueByIndex(uint index)
	{
		return default(int);
	}

	[Token(Token = "0x60141C9")]
	[Address(RVA = "0x15DC130", Offset = "0x15DC130", VA = "0x15DC130")]
	public void SetCSShopSettingValueByIndex(uint index, int val)
	{
	}

	[Token(Token = "0x60141CA")]
	[Address(RVA = "0x15DC218", Offset = "0x15DC218", VA = "0x15DC218")]
	public bool GetCSShopSettingCheckByIndex(uint index)
	{
		return default(bool);
	}

	[Token(Token = "0x60141CB")]
	[Address(RVA = "0x15DC2E4", Offset = "0x15DC2E4", VA = "0x15DC2E4")]
	public void SetCSShopSettingCheckByIndex(uint index, bool check)
	{
	}

	[Token(Token = "0x60141CC")]
	[Address(RVA = "0x15DC3CC", Offset = "0x15DC3CC", VA = "0x15DC3CC")]
	public int GetCSRoundValueByIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60141CD")]
	[Address(RVA = "0x15DC498", Offset = "0x15DC498", VA = "0x15DC498")]
	public void SetCSRoundValueByIndex(int index, int val)
	{
	}

	[Token(Token = "0x60141CE")]
	[Address(RVA = "0x15DC580", Offset = "0x15DC580", VA = "0x15DC580")]
	public int GetSelectedShopItemCnt()
	{
		return default(int);
	}

	[Token(Token = "0x60141CF")]
	[Address(RVA = "0x15DC738", Offset = "0x15DC738", VA = "0x15DC738")]
	public static uint GenerateWereWolvesSettingBitFromMap(int settingNum, int paramCount, Dictionary<uint, uint> paramMap)
	{
		return default(uint);
	}

	[Token(Token = "0x60141D0")]
	[Address(RVA = "0x15DC864", Offset = "0x15DC864", VA = "0x15DC864")]
	public Dictionary<uint, uint> GenerateWereWolvesSettingMapFromBit()
	{
		return null;
	}

	[Token(Token = "0x60141D1")]
	[Address(RVA = "0x15DCA24", Offset = "0x15DCA24", VA = "0x15DCA24")]
	public static uint GenerateRushingPetsSettingBitFromMap(int settingNum, int paramCount, Dictionary<uint, uint> paramMap)
	{
		return default(uint);
	}

	[Token(Token = "0x60141D2")]
	[Address(RVA = "0x15DCB50", Offset = "0x15DCB50", VA = "0x15DCB50")]
	public Dictionary<uint, uint> GenerateRushingPetsSettingMapFromBit()
	{
		return null;
	}

	[Token(Token = "0x60141D4")]
	[Address(RVA = "0x15CCAE8", Offset = "0x15CCAE8", VA = "0x15CCAE8")]
	private byte[] GenerateADCSSettingBytes()
	{
		return null;
	}

	[Token(Token = "0x60141D5")]
	[Address(RVA = "0x15CD6D0", Offset = "0x15CD6D0", VA = "0x15CD6D0")]
	private byte[] GenerateSpectatorSettingBytes()
	{
		return null;
	}

	[Token(Token = "0x60141D6")]
	[Address(RVA = "0x15DCD8C", Offset = "0x15DCD8C", VA = "0x15DCD8C")]
	public void InitCustomRoomSettingTitle()
	{
	}

	[Token(Token = "0x60141D7")]
	[Address(RVA = "0x15DE198", Offset = "0x15DE198", VA = "0x15DE198")]
	public Dictionary<uint, string> GenerateCustomRoomGameSettingDict()
	{
		return null;
	}

	[Token(Token = "0x60141D8")]
	[Address(RVA = "0x15DF624", Offset = "0x15DF624", VA = "0x15DF624")]
	public string GetSettingString(uint roomSetting, uint setting, bool reverse = true)
	{
		return null;
	}

	[Token(Token = "0x60141DC")]
	[Address(RVA = "0x15DF80C", Offset = "0x15DF80C", VA = "0x15DF80C")]
	private static bool _003CGetSelectedShopItemCnt_003Em__0(KeyValuePair<uint, bool> e)
	{
		return default(bool);
	}

	[Token(Token = "0x60141DD")]
	[Address(RVA = "0x15DF87C", Offset = "0x15DF87C", VA = "0x15DF87C")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x60141DE")]
	[Address(RVA = "0x15DF884", Offset = "0x15DF884", VA = "0x15DF884")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x60141DF")]
	[Address(RVA = "0x15DF88C", Offset = "0x15DF88C", VA = "0x15DF88C")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
