using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002E24")]
public class RoomCreateRuleDataManager : SingletonModule<RoomCreateRuleDataManager>
{
	[Token(Token = "0x2002E25")]
	private enum EConfigType
	{
		[Token(Token = "0x4011A97")]
		EConfigType_HP,
		[Token(Token = "0x4011A98")]
		EConfigType_EP,
		[Token(Token = "0x4011A99")]
		EConfigType_Speed,
		[Token(Token = "0x4011A9A")]
		EConfigType_JumpHeight,
		[Token(Token = "0x4011A9B")]
		EConfigType_RoundNum,
		[Token(Token = "0x4011A9C")]
		EConfigType_InitCoin,
		[Token(Token = "0x4011A9D")]
		EConfigType_FightClubRoundNum,
		[Token(Token = "0x4011A9E")]
		EConfigType_Revive,
		[Token(Token = "0x4011A9F")]
		EConfigType_MatchStartBuff
	}

	[Token(Token = "0x2002E26")]
	private class MapConfigInfo
	{
		[Token(Token = "0x4011AA0")]
		[FieldOffset(Offset = "0x8")]
		public uint[] members;

		[Token(Token = "0x4011AA1")]
		[FieldOffset(Offset = "0xC")]
		public uint[] spectators;

		[Token(Token = "0x4011AA2")]
		[FieldOffset(Offset = "0x10")]
		public uint minMemberCnt;

		[Token(Token = "0x4011AA3")]
		[FieldOffset(Offset = "0x14")]
		public bool enableVoiceChat;

		[Token(Token = "0x6013512")]
		[Address(RVA = "0x24151E0", Offset = "0x24151E0", VA = "0x24151E0")]
		public MapConfigInfo()
		{
		}
	}

	[Token(Token = "0x2002E27")]
	private sealed class _003CGetHPTxtByKey_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011AA4")]
		[FieldOffset(Offset = "0x8")]
		internal uint key;

		[Token(Token = "0x6013513")]
		[Address(RVA = "0x2413088", Offset = "0x2413088", VA = "0x2413088")]
		public _003CGetHPTxtByKey_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013514")]
		[Address(RVA = "0x24154C4", Offset = "0x24154C4", VA = "0x24154C4")]
		internal bool _003C_003Em__0(HPConfigInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E28")]
	private sealed class _003CGetEPTxtByKey_003Ec__AnonStorey1
	{
		[Token(Token = "0x4011AA5")]
		[FieldOffset(Offset = "0x8")]
		internal uint key;

		[Token(Token = "0x6013515")]
		[Address(RVA = "0x241327C", Offset = "0x241327C", VA = "0x241327C")]
		public _003CGetEPTxtByKey_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6013516")]
		[Address(RVA = "0x2415454", Offset = "0x2415454", VA = "0x2415454")]
		internal bool _003C_003Em__0(EPConfigInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E29")]
	private sealed class _003CGetSpeedTxtByKey_003Ec__AnonStorey2
	{
		[Token(Token = "0x4011AA6")]
		[FieldOffset(Offset = "0x8")]
		internal uint key;

		[Token(Token = "0x6013517")]
		[Address(RVA = "0x2413470", Offset = "0x2413470", VA = "0x2413470")]
		public _003CGetSpeedTxtByKey_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6013518")]
		[Address(RVA = "0x2415614", Offset = "0x2415614", VA = "0x2415614")]
		internal bool _003C_003Em__0(SpeedConfigInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E2A")]
	private sealed class _003CGetJumpHeightTxtByKey_003Ec__AnonStorey3
	{
		[Token(Token = "0x4011AA7")]
		[FieldOffset(Offset = "0x8")]
		internal uint key;

		[Token(Token = "0x6013519")]
		[Address(RVA = "0x2413664", Offset = "0x2413664", VA = "0x2413664")]
		public _003CGetJumpHeightTxtByKey_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x601351A")]
		[Address(RVA = "0x2415534", Offset = "0x2415534", VA = "0x2415534")]
		internal bool _003C_003Em__0(JumpHeightConfigInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E2B")]
	private sealed class _003CGetFightClubRoundNumTxtByKey_003Ec__AnonStorey4
	{
		[Token(Token = "0x4011AA8")]
		[FieldOffset(Offset = "0x8")]
		internal uint key;

		[Token(Token = "0x601351B")]
		[Address(RVA = "0x2413858", Offset = "0x2413858", VA = "0x2413858")]
		public _003CGetFightClubRoundNumTxtByKey_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x601351C")]
		[Address(RVA = "0x241548C", Offset = "0x241548C", VA = "0x241548C")]
		internal bool _003C_003Em__0(RoundNumConfigInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E2C")]
	private sealed class _003CGetRoundNumTxtByKey_003Ec__AnonStorey5
	{
		[Token(Token = "0x4011AA9")]
		[FieldOffset(Offset = "0x8")]
		internal uint key;

		[Token(Token = "0x601351D")]
		[Address(RVA = "0x2413A4C", Offset = "0x2413A4C", VA = "0x2413A4C")]
		public _003CGetRoundNumTxtByKey_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x601351E")]
		[Address(RVA = "0x24155DC", Offset = "0x24155DC", VA = "0x24155DC")]
		internal bool _003C_003Em__0(RoundNumConfigInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E2D")]
	private sealed class _003CGetInitCoinTxtByKey_003Ec__AnonStorey6
	{
		[Token(Token = "0x4011AAA")]
		[FieldOffset(Offset = "0x8")]
		internal uint key;

		[Token(Token = "0x601351F")]
		[Address(RVA = "0x2413C40", Offset = "0x2413C40", VA = "0x2413C40")]
		public _003CGetInitCoinTxtByKey_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6013520")]
		[Address(RVA = "0x24154FC", Offset = "0x24154FC", VA = "0x24154FC")]
		internal bool _003C_003Em__0(InitCoinConfigInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E2E")]
	private sealed class _003CGetDropListTxtById_003Ec__AnonStorey7
	{
		[Token(Token = "0x4011AAB")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6013521")]
		[Address(RVA = "0x24140FC", Offset = "0x24140FC", VA = "0x24140FC")]
		public _003CGetDropListTxtById_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6013522")]
		[Address(RVA = "0x241541C", Offset = "0x241541C", VA = "0x241541C")]
		internal bool _003C_003Em__0(DropListConfigInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E2F")]
	private sealed class _003CGetReviveSwitchTxtByKey_003Ec__AnonStorey8
	{
		[Token(Token = "0x4011AAC")]
		[FieldOffset(Offset = "0x8")]
		internal uint key;

		[Token(Token = "0x6013523")]
		[Address(RVA = "0x24142F0", Offset = "0x24142F0", VA = "0x24142F0")]
		public _003CGetReviveSwitchTxtByKey_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x6013524")]
		[Address(RVA = "0x24155A4", Offset = "0x24155A4", VA = "0x24155A4")]
		internal bool _003C_003Em__0(ReviveConfigInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E30")]
	private sealed class _003CGetMatchStartBuffTxtByKey_003Ec__AnonStorey9
	{
		[Token(Token = "0x4011AAD")]
		[FieldOffset(Offset = "0x8")]
		internal uint key;

		[Token(Token = "0x6013525")]
		[Address(RVA = "0x24144E4", Offset = "0x24144E4", VA = "0x24144E4")]
		public _003CGetMatchStartBuffTxtByKey_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x6013526")]
		[Address(RVA = "0x241556C", Offset = "0x241556C", VA = "0x241556C")]
		internal bool _003C_003Em__0(MatchStartBuffConfig a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4011A77")]
	[FieldOffset(Offset = "0x0")]
	public static uint INVALIAD_MAPCONFIGID;

	[Token(Token = "0x4011A78")]
	[FieldOffset(Offset = "0x4")]
	public static uint CSSHOP_WEAPON_TYPETAB;

	[Token(Token = "0x4011A79")]
	[FieldOffset(Offset = "0x8")]
	public static uint CSSHOP_ITEM_TYPETAB;

	[Token(Token = "0x4011A7A")]
	[FieldOffset(Offset = "0xA")]
	private bool m_IsRoomCreateRuleDropInited;

	[Token(Token = "0x4011A7B")]
	[FieldOffset(Offset = "0xB")]
	private bool m_IsRoomCreateRulesInited;

	[Token(Token = "0x4011A7C")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<string, MapConfigInfo> m_MapConfigGroupDic;

	[Token(Token = "0x4011A7D")]
	[FieldOffset(Offset = "0x10")]
	private List<HPConfigInfo> m_HPConfigList;

	[Token(Token = "0x4011A7E")]
	[FieldOffset(Offset = "0x14")]
	private List<EPConfigInfo> m_EPConfigList;

	[Token(Token = "0x4011A7F")]
	[FieldOffset(Offset = "0x18")]
	private List<SpeedConfigInfo> m_SpeedConfigList;

	[Token(Token = "0x4011A80")]
	[FieldOffset(Offset = "0x1C")]
	private List<JumpHeightConfigInfo> m_JumpHeightConfigList;

	[Token(Token = "0x4011A81")]
	[FieldOffset(Offset = "0x20")]
	private List<DropListConfigInfo> m_DropListConfigList;

	[Token(Token = "0x4011A82")]
	[FieldOffset(Offset = "0x24")]
	private List<DropListConfigInfo> m_DropListConfigListCS;

	[Token(Token = "0x4011A83")]
	[FieldOffset(Offset = "0x28")]
	private List<DropListConfigInfo> m_DropListConfigListBomb;

	[Token(Token = "0x4011A84")]
	[FieldOffset(Offset = "0x2C")]
	private List<RoundNumConfigInfo> m_RoundNumConfigList;

	[Token(Token = "0x4011A85")]
	[FieldOffset(Offset = "0x30")]
	private List<InitCoinConfigInfo> m_InitCoinConfigList;

	[Token(Token = "0x4011A86")]
	[FieldOffset(Offset = "0x34")]
	private List<RoundNumConfigInfo> m_FightClubRoundNumConfigList;

	[Token(Token = "0x4011A87")]
	[FieldOffset(Offset = "0x38")]
	private List<ReviveConfigInfo> m_ReviveConfigList;

	[Token(Token = "0x4011A88")]
	[FieldOffset(Offset = "0x3C")]
	private List<MatchStartBuffConfig> m_MatchStartBuffList;

	[Token(Token = "0x4011A89")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<uint, List<RoomCreateCSShopData>> m_CreateRoomCSShopWeaponDic;

	[Token(Token = "0x4011A8A")]
	[FieldOffset(Offset = "0x44")]
	private List<RoomCreateCSShopData> m_CreateRoomCSShopWeaponList;

	[Token(Token = "0x4011A8B")]
	[FieldOffset(Offset = "0x48")]
	private List<RoomCreateCSShopData> m_CreateRoomCSShopItemList;

	[Token(Token = "0x4011A8C")]
	[FieldOffset(Offset = "0x4C")]
	private List<uint> m_CSShopTypeTabList;

	[Token(Token = "0x4011A8D")]
	[FieldOffset(Offset = "0x50")]
	private List<RoomCreateCSEcoData> m_CreateRoomCSEcoList;

	[Token(Token = "0x4011A8E")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<uint, RoomCrateSettingData> m_RoomCrateSettingDict;

	[Token(Token = "0x4011A8F")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<uint, List<uint>> m_MapConfigIdDic;

	[Token(Token = "0x4011A90")]
	[FieldOffset(Offset = "0x5C")]
	private Dictionary<uint, Dictionary<uint, List<uint>>> m_ModeMapIdDic;

	[Token(Token = "0x4011A91")]
	[FieldOffset(Offset = "0x60")]
	private List<uint> m_GameModeIdList;

	[Token(Token = "0x4011A92")]
	[FieldOffset(Offset = "0x64")]
	private List<uint> m_CreateRoomModeSort;

	[Token(Token = "0x4011A93")]
	[FieldOffset(Offset = "0xC")]
	private static Comparison<DropListConfigInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4011A94")]
	[FieldOffset(Offset = "0x10")]
	private static Comparison<DropListConfigInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4011A95")]
	[FieldOffset(Offset = "0x14")]
	private static Comparison<DropListConfigInfo> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x170013FC")]
	public List<uint> GameModeIdList
	{
		[Token(Token = "0x60134DA")]
		[Address(RVA = "0x240F9BC", Offset = "0x240F9BC", VA = "0x240F9BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013FD")]
	public List<uint> CreateRoomModeSort
	{
		[Token(Token = "0x60134DB")]
		[Address(RVA = "0x240FA94", Offset = "0x240FA94", VA = "0x240FA94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60134D9")]
	[Address(RVA = "0x240F558", Offset = "0x240F558", VA = "0x240F558")]
	public RoomCreateRuleDataManager()
	{
	}

	[Token(Token = "0x60134DC")]
	[Address(RVA = "0x240FCB8", Offset = "0x240FCB8", VA = "0x240FCB8", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60134DD")]
	[Address(RVA = "0x240FD30", Offset = "0x240FD30", VA = "0x240FD30")]
	private void LoadRoomCreateRuleHPEPData()
	{
	}

	[Token(Token = "0x60134DE")]
	[Address(RVA = "0x24105D4", Offset = "0x24105D4", VA = "0x24105D4")]
	private void LoadRoomCreateCSShop()
	{
	}

	[Token(Token = "0x60134DF")]
	[Address(RVA = "0x2410AAC", Offset = "0x2410AAC", VA = "0x2410AAC")]
	private void LoadRoomCreateCSEco()
	{
	}

	[Token(Token = "0x60134E0")]
	[Address(RVA = "0x2410D90", Offset = "0x2410D90", VA = "0x2410D90")]
	private void LoadRoomCrateSetting()
	{
	}

	[Token(Token = "0x60134E1")]
	[Address(RVA = "0x241102C", Offset = "0x241102C", VA = "0x241102C")]
	public List<RoomCreateCSShopData> GetCSShopWeaponList(uint type)
	{
		return null;
	}

	[Token(Token = "0x60134E2")]
	[Address(RVA = "0x2411190", Offset = "0x2411190", VA = "0x2411190")]
	public List<RoomCreateCSEcoData> GetCSEcoList()
	{
		return null;
	}

	[Token(Token = "0x60134E3")]
	[Address(RVA = "0x24111E8", Offset = "0x24111E8", VA = "0x24111E8")]
	public List<uint> GetCSShopTypeTabList()
	{
		return null;
	}

	[Token(Token = "0x60134E4")]
	[Address(RVA = "0x2411240", Offset = "0x2411240", VA = "0x2411240")]
	public RoomCrateSettingData GetRoomCrateSettingData(uint gameMode)
	{
		return null;
	}

	[Token(Token = "0x60134E5")]
	[Address(RVA = "0x241134C", Offset = "0x241134C", VA = "0x241134C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60134E6")]
	[Address(RVA = "0x2411758", Offset = "0x2411758", VA = "0x2411758")]
	public bool IsRoomCreateRuleDropInited()
	{
		return default(bool);
	}

	[Token(Token = "0x60134E7")]
	[Address(RVA = "0x24117B0", Offset = "0x24117B0", VA = "0x24117B0")]
	public void ClearRoomCreateRuleDrop()
	{
	}

	[Token(Token = "0x60134E8")]
	[Address(RVA = "0x241180C", Offset = "0x241180C", VA = "0x241180C")]
	public void UpdateRoomCreateRuleDrop(List<RoomCreateRuleDropDesc> list)
	{
	}

	[Token(Token = "0x60134E9")]
	[Address(RVA = "0x2411FDC", Offset = "0x2411FDC", VA = "0x2411FDC")]
	public List<uint> GetModeIDListByRoomType(uint roomType)
	{
		return null;
	}

	[Token(Token = "0x60134EA")]
	[Address(RVA = "0x24121E4", Offset = "0x24121E4", VA = "0x24121E4")]
	public List<uint> GetMapIDListByGameModeAndRoomType(uint roomType, uint gameMode)
	{
		return null;
	}

	[Token(Token = "0x60134EB")]
	[Address(RVA = "0x24122F8", Offset = "0x24122F8", VA = "0x24122F8")]
	public List<uint> GetMapConfigIDListByRoomType(uint roomType)
	{
		return null;
	}

	[Token(Token = "0x60134EC")]
	[Address(RVA = "0x24123C4", Offset = "0x24123C4", VA = "0x24123C4")]
	public uint[] GetMembers(string key)
	{
		return null;
	}

	[Token(Token = "0x60134ED")]
	[Address(RVA = "0x2412538", Offset = "0x2412538", VA = "0x2412538")]
	public uint[] GetSpectators(string key)
	{
		return null;
	}

	[Token(Token = "0x60134EE")]
	[Address(RVA = "0x24126AC", Offset = "0x24126AC", VA = "0x24126AC")]
	public uint GetMinMembersCount(string key)
	{
		return default(uint);
	}

	[Token(Token = "0x60134EF")]
	[Address(RVA = "0x2412878", Offset = "0x2412878", VA = "0x2412878")]
	public bool EnableRoomVoiceChat(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60134F0")]
	[Address(RVA = "0x24127AC", Offset = "0x24127AC", VA = "0x24127AC")]
	public bool IsKeyValid(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60134F1")]
	[Address(RVA = "0x2412980", Offset = "0x2412980", VA = "0x2412980")]
	public string PrintDic()
	{
		return null;
	}

	[Token(Token = "0x60134F2")]
	[Address(RVA = "0x2412BA8", Offset = "0x2412BA8", VA = "0x2412BA8")]
	public uint GetFirstMapConfig(uint roomType)
	{
		return default(uint);
	}

	[Token(Token = "0x60134F3")]
	[Address(RVA = "0x2412E9C", Offset = "0x2412E9C", VA = "0x2412E9C")]
	public List<HPConfigInfo> GetHPConfigList()
	{
		return null;
	}

	[Token(Token = "0x60134F4")]
	[Address(RVA = "0x2412EF4", Offset = "0x2412EF4", VA = "0x2412EF4")]
	public string GetHPTxtByKey(uint key)
	{
		return null;
	}

	[Token(Token = "0x60134F5")]
	[Address(RVA = "0x2413090", Offset = "0x2413090", VA = "0x2413090")]
	public List<EPConfigInfo> GetEPConfigList()
	{
		return null;
	}

	[Token(Token = "0x60134F6")]
	[Address(RVA = "0x24130E8", Offset = "0x24130E8", VA = "0x24130E8")]
	public string GetEPTxtByKey(uint key)
	{
		return null;
	}

	[Token(Token = "0x60134F7")]
	[Address(RVA = "0x2413284", Offset = "0x2413284", VA = "0x2413284")]
	public List<SpeedConfigInfo> GetSpeedConfigList()
	{
		return null;
	}

	[Token(Token = "0x60134F8")]
	[Address(RVA = "0x24132DC", Offset = "0x24132DC", VA = "0x24132DC")]
	public string GetSpeedTxtByKey(uint key)
	{
		return null;
	}

	[Token(Token = "0x60134F9")]
	[Address(RVA = "0x2413478", Offset = "0x2413478", VA = "0x2413478")]
	public List<JumpHeightConfigInfo> GetJumpHeightConfigList()
	{
		return null;
	}

	[Token(Token = "0x60134FA")]
	[Address(RVA = "0x24134D0", Offset = "0x24134D0", VA = "0x24134D0")]
	public string GetJumpHeightTxtByKey(uint key)
	{
		return null;
	}

	[Token(Token = "0x60134FB")]
	[Address(RVA = "0x241366C", Offset = "0x241366C", VA = "0x241366C")]
	public List<RoundNumConfigInfo> GetFightClubRoundNumConfigList()
	{
		return null;
	}

	[Token(Token = "0x60134FC")]
	[Address(RVA = "0x24136C4", Offset = "0x24136C4", VA = "0x24136C4")]
	public string GetFightClubRoundNumTxtByKey(uint key)
	{
		return null;
	}

	[Token(Token = "0x60134FD")]
	[Address(RVA = "0x2413860", Offset = "0x2413860", VA = "0x2413860")]
	public List<RoundNumConfigInfo> GetRoundNumConfigList()
	{
		return null;
	}

	[Token(Token = "0x60134FE")]
	[Address(RVA = "0x24138B8", Offset = "0x24138B8", VA = "0x24138B8")]
	public string GetRoundNumTxtByKey(uint key)
	{
		return null;
	}

	[Token(Token = "0x60134FF")]
	[Address(RVA = "0x2413A54", Offset = "0x2413A54", VA = "0x2413A54")]
	public List<InitCoinConfigInfo> GetInitCoinConfigList()
	{
		return null;
	}

	[Token(Token = "0x6013500")]
	[Address(RVA = "0x2413AAC", Offset = "0x2413AAC", VA = "0x2413AAC")]
	public string GetInitCoinTxtByKey(uint key)
	{
		return null;
	}

	[Token(Token = "0x6013501")]
	[Address(RVA = "0x2413C48", Offset = "0x2413C48", VA = "0x2413C48")]
	public List<DropListConfigInfo> GetDropListConfigList(uint configID)
	{
		return null;
	}

	[Token(Token = "0x6013502")]
	[Address(RVA = "0x2413EA0", Offset = "0x2413EA0", VA = "0x2413EA0")]
	public string GetDropListTxtById(uint id, uint configID)
	{
		return null;
	}

	[Token(Token = "0x6013503")]
	[Address(RVA = "0x2414104", Offset = "0x2414104", VA = "0x2414104")]
	public List<ReviveConfigInfo> GetReviveConfigList()
	{
		return null;
	}

	[Token(Token = "0x6013504")]
	[Address(RVA = "0x241415C", Offset = "0x241415C", VA = "0x241415C")]
	public string GetReviveSwitchTxtByKey(uint key)
	{
		return null;
	}

	[Token(Token = "0x6013505")]
	[Address(RVA = "0x24142F8", Offset = "0x24142F8", VA = "0x24142F8")]
	public List<MatchStartBuffConfig> GetMatchStartBuffList()
	{
		return null;
	}

	[Token(Token = "0x6013506")]
	[Address(RVA = "0x2414350", Offset = "0x2414350", VA = "0x2414350")]
	public string GetMatchStartBuffTxtByKey(uint key)
	{
		return null;
	}

	[Token(Token = "0x6013507")]
	[Address(RVA = "0x24144EC", Offset = "0x24144EC", VA = "0x24144EC")]
	public bool IsRoomCreateRulesInited()
	{
		return default(bool);
	}

	[Token(Token = "0x6013508")]
	[Address(RVA = "0x2414544", Offset = "0x2414544", VA = "0x2414544")]
	public void ClearRoomCreateRules()
	{
	}

	[Token(Token = "0x6013509")]
	[Address(RVA = "0x24145A0", Offset = "0x24145A0", VA = "0x24145A0")]
	private bool IsSigmaRoomType(uint roomType)
	{
		return default(bool);
	}

	[Token(Token = "0x601350A")]
	[Address(RVA = "0x2414614", Offset = "0x2414614", VA = "0x2414614")]
	private bool IsSigmaMode(uint gameMode)
	{
		return default(bool);
	}

	[Token(Token = "0x601350B")]
	[Address(RVA = "0x241468C", Offset = "0x241468C", VA = "0x241468C")]
	private bool IsSigmaMap(uint map)
	{
		return default(bool);
	}

	[Token(Token = "0x601350C")]
	[Address(RVA = "0x24146F8", Offset = "0x24146F8", VA = "0x24146F8")]
	public void UpdateRoomCreateRules(List<RoomCreateRuleDesc> list)
	{
	}

	[Token(Token = "0x601350E")]
	[Address(RVA = "0x2415250", Offset = "0x2415250", VA = "0x2415250")]
	private static int _003CUpdateRoomCreateRuleDrop_003Em__0(DropListConfigInfo a, DropListConfigInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x601350F")]
	[Address(RVA = "0x2415298", Offset = "0x2415298", VA = "0x2415298")]
	private static int _003CUpdateRoomCreateRuleDrop_003Em__1(DropListConfigInfo a, DropListConfigInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6013510")]
	[Address(RVA = "0x24152E0", Offset = "0x24152E0", VA = "0x24152E0")]
	private static int _003CUpdateRoomCreateRuleDrop_003Em__2(DropListConfigInfo a, DropListConfigInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6013511")]
	[Address(RVA = "0x2415328", Offset = "0x2415328", VA = "0x2415328")]
	private int _003CGetModeIDListByRoomType_003Em__3(uint a, uint b)
	{
		return default(int);
	}
}
