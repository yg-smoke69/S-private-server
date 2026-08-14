using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20031A2")]
public class UIModelNewVault : UIBaseModel
{
	[Token(Token = "0x20031A3")]
	public enum eNewVault_VehicleType
	{
		[Token(Token = "0x4012DF9")]
		PickupVehicle = 112,
		[Token(Token = "0x4012DFA")]
		JeepVehicle,
		[Token(Token = "0x4012DFB")]
		TukTukVehicle,
		[Token(Token = "0x4012DFC")]
		AmphibiousVehicle,
		[Token(Token = "0x4012DFD")]
		MonsterVehicle,
		[Token(Token = "0x4012DFE")]
		MotorVehicle,
		[Token(Token = "0x4012DFF")]
		SportVehicle
	}

	[Token(Token = "0x20031A4")]
	public enum eFirstTab
	{
		[Token(Token = "0x4012E01")]
		None,
		[Token(Token = "0x4012E02")]
		Fashion,
		[Token(Token = "0x4012E03")]
		Accessory,
		[Token(Token = "0x4012E04")]
		Vehicle,
		[Token(Token = "0x4012E05")]
		CallSign,
		[Token(Token = "0x4012E06")]
		Emote,
		[Token(Token = "0x4012E07")]
		Music,
		[Token(Token = "0x4012E08")]
		Others
	}

	[Token(Token = "0x20031A5")]
	public enum eSecondTab
	{
		[Token(Token = "0x4012E0A")]
		None = 0,
		[Token(Token = "0x4012E0B")]
		Chest = 10203,
		[Token(Token = "0x4012E0C")]
		Legs = 10204,
		[Token(Token = "0x4012E0D")]
		Feet = 10205,
		[Token(Token = "0x4012E0E")]
		Face = 10208,
		[Token(Token = "0x4012E0F")]
		Hair = 10211,
		[Token(Token = "0x4012E10")]
		Set = 10212,
		[Token(Token = "0x4012E11")]
		HeadAdditive = 10214,
		[Token(Token = "0x4012E12")]
		LootBox = 20903,
		[Token(Token = "0x4012E13")]
		BackPack = 20904,
		[Token(Token = "0x4012E14")]
		Parachute = 20905,
		[Token(Token = "0x4012E15")]
		Skyboard = 20906,
		[Token(Token = "0x4012E16")]
		Flight = 20911,
		[Token(Token = "0x4012E17")]
		PickupVehicle = 30112,
		[Token(Token = "0x4012E18")]
		JeepVehicle = 30113,
		[Token(Token = "0x4012E19")]
		TukTukVehicle = 30114,
		[Token(Token = "0x4012E1A")]
		AmphibiousVehicle = 30115,
		[Token(Token = "0x4012E1B")]
		MonsterVehicle = 30116,
		[Token(Token = "0x4012E1C")]
		MotorVehicle = 30117,
		[Token(Token = "0x4012E1D")]
		SportVehicle = 30118,
		[Token(Token = "0x4012E1E")]
		Banner = 40901,
		[Token(Token = "0x4012E1F")]
		HeadPic = 40902,
		[Token(Token = "0x4012E20")]
		Pin = 40910,
		[Token(Token = "0x4012E21")]
		Emote = 50909,
		[Token(Token = "0x4012E22")]
		GroupAnim = 50912,
		[Token(Token = "0x4012E23")]
		Music = 60913,
		[Token(Token = "0x4012E24")]
		Transformer = 50914,
		[Token(Token = "0x4012E25")]
		Mortgage = 70000,
		[Token(Token = "0x4012E26")]
		TreasureBox = 70004,
		[Token(Token = "0x4012E27")]
		Bundle = 70007,
		[Token(Token = "0x4012E28")]
		Debris = 70008,
		[Token(Token = "0x4012E29")]
		BonusCard = 70011
	}

	[Token(Token = "0x20031A6")]
	public enum eNewVaultTag
	{
		[Token(Token = "0x4012E2B")]
		None,
		[Token(Token = "0x4012E2C")]
		Discount,
		[Token(Token = "0x4012E2D")]
		BestSell,
		[Token(Token = "0x4012E2E")]
		Latest,
		[Token(Token = "0x4012E2F")]
		CountLimit,
		[Token(Token = "0x4012E30")]
		TimeLimit
	}

	[Token(Token = "0x20031A7")]
	public enum eNewVaultGoPosType
	{
		[Token(Token = "0x4012E32")]
		Normal,
		[Token(Token = "0x4012E33")]
		NotHave
	}

	[Token(Token = "0x20031A8")]
	public class NewVaultItemSortInfo
	{
		[Token(Token = "0x4012E34")]
		[FieldOffset(Offset = "0x8")]
		public uint ID;

		[Token(Token = "0x4012E35")]
		[FieldOffset(Offset = "0xC")]
		public bool IsOwned;

		[Token(Token = "0x4012E36")]
		[FieldOffset(Offset = "0xD")]
		public bool IsEquiped;

		[Token(Token = "0x4012E37")]
		[FieldOffset(Offset = "0xE")]
		public bool IsNewGet;

		[Token(Token = "0x4012E38")]
		[FieldOffset(Offset = "0xF")]
		public bool IsCanEquip;

		[Token(Token = "0x4012E39")]
		[FieldOffset(Offset = "0x10")]
		public int Quality;

		[Token(Token = "0x4012E3A")]
		[FieldOffset(Offset = "0x14")]
		public bool IsTimeLimit;

		[Token(Token = "0x4012E3B")]
		[FieldOffset(Offset = "0x15")]
		public bool IsDefault;

		[Token(Token = "0x4012E3C")]
		[FieldOffset(Offset = "0x18")]
		public uint SortID;

		[Token(Token = "0x6014E12")]
		[Address(RVA = "0x2B0B2B4", Offset = "0x2B0B2B4", VA = "0x2B0B2B4")]
		public NewVaultItemSortInfo()
		{
		}

		[Token(Token = "0x6014E13")]
		[Address(RVA = "0x2B0B2BC", Offset = "0x2B0B2BC", VA = "0x2B0B2BC")]
		public NewVaultItemSortInfo(uint id)
		{
		}

		[Token(Token = "0x6014E14")]
		[Address(RVA = "0x2B0B81C", Offset = "0x2B0B81C", VA = "0x2B0B81C")]
		public NewVaultItemSortInfo Clone()
		{
			return null;
		}

		[Token(Token = "0x6014E15")]
		[Address(RVA = "0x2B0B2E4", Offset = "0x2B0B2E4", VA = "0x2B0B2E4")]
		public void RefreshInfo()
		{
		}
	}

	[Token(Token = "0x4012DE1")]
	public const uint PropID_GetNewVault_Success = 2u;

	[Token(Token = "0x4012DE2")]
	public const uint PropID_ShowItemChanged = 4u;

	[Token(Token = "0x4012DE3")]
	[FieldOffset(Offset = "0xC")]
	public bool m_AutoEquipDefaultMusic;

	[Token(Token = "0x4012DE4")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cm_CurrentMusicDefaultId_003Ek__BackingField;

	[Token(Token = "0x4012DE5")]
	[FieldOffset(Offset = "0x14")]
	private bool m_GetNewDefaultMusicVault;

	[Token(Token = "0x4012DE6")]
	private const string LastDefaultMusicIdKey = "LastDefaultMusicIdKey";

	[Token(Token = "0x4012DE7")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, NewVaultTabData> m_dicTabCfg;

	[Token(Token = "0x4012DE8")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<uint, NewVaultSecondTabData> m_dicSecondTabCfg;

	[Token(Token = "0x4012DE9")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<uint, NewVaultDefaultID> m_dicNewVaultDefaultCfg;

	[Token(Token = "0x4012DEA")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<int, uint> m_dicNewVaultDefaultItems;

	[Token(Token = "0x4012DEB")]
	[FieldOffset(Offset = "0x28")]
	private HashSet<uint> m_setLegendClothIds;

	[Token(Token = "0x4012DEC")]
	[FieldOffset(Offset = "0x2C")]
	private HashSet<uint> m_hsForceHideFirstTab;

	[Token(Token = "0x4012DED")]
	[FieldOffset(Offset = "0x30")]
	private HashSet<uint> m_hsForceHideSecondTab;

	[Token(Token = "0x4012DEE")]
	[FieldOffset(Offset = "0x34")]
	private List<NewVaultItemDesc> m_NewVaultItemExtraInfo;

	[Token(Token = "0x4012DEF")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<uint, NewVaultItemDesc> m_dicNewVaultItemExtraInfo;

	[Token(Token = "0x4012DF0")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<uint, HashSet<uint>> m_dicShowItemInfos;

	[Token(Token = "0x4012DF1")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<uint, HashSet<uint>> m_dicShowOnlyOwnedItemInfos;

	[Token(Token = "0x4012DF2")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<uint, NewVaultItemSortInfo> m_dicNewVaultItemSortInfo;

	[Token(Token = "0x4012DF3")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<int, List<int>> m_dicShowTab;

	[Token(Token = "0x4012DF4")]
	[FieldOffset(Offset = "0x4C")]
	private List<int> m_sortShowFirstTab;

	[Token(Token = "0x4012DF5")]
	[FieldOffset(Offset = "0x50")]
	private UIModelInventory m_Inventory;

	[Token(Token = "0x4012DF6")]
	[FieldOffset(Offset = "0x54")]
	private bool m_bSortInfoIsDirty;

	[Token(Token = "0x4012DF7")]
	[FieldOffset(Offset = "0x58")]
	public uint m_CurrentPlayLobbyId;

	[Token(Token = "0x170015FA")]
	public uint m_CurrentMusicDefaultId
	{
		[Token(Token = "0x6014DCA")]
		[Address(RVA = "0x1786268", Offset = "0x1786268", VA = "0x1786268")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014DC9")]
		[Address(RVA = "0x1786260", Offset = "0x1786260", VA = "0x1786260")]
		private set
		{
		}
	}

	[Token(Token = "0x6014DC8")]
	[Address(RVA = "0x1785F68", Offset = "0x1785F68", VA = "0x1785F68")]
	public UIModelNewVault()
	{
	}

	[Token(Token = "0x6014DCB")]
	[Address(RVA = "0x1786270", Offset = "0x1786270", VA = "0x1786270", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014DCC")]
	[Address(RVA = "0x17862C8", Offset = "0x17862C8", VA = "0x17862C8")]
	private void SetSortInfo(uint id, [Optional] bool? isOwned, [Optional] bool? isEquipped, [Optional] bool? isNewGet, [Optional] bool? isCanEquip, [Optional] bool? isTimeLimit)
	{
	}

	[Token(Token = "0x6014DCD")]
	[Address(RVA = "0x1786608", Offset = "0x1786608", VA = "0x1786608")]
	private int NormalSort(uint curItemID, uint nextItemID)
	{
		return default(int);
	}

	[Token(Token = "0x6014DCE")]
	[Address(RVA = "0x17868B0", Offset = "0x17868B0", VA = "0x17868B0")]
	public bool IsOwned(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014DCF")]
	[Address(RVA = "0x1786938", Offset = "0x1786938", VA = "0x1786938")]
	public bool IsDefault(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014DD0")]
	[Address(RVA = "0x17869C0", Offset = "0x17869C0", VA = "0x17869C0")]
	public bool IsTimeLimit(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014DD1")]
	[Address(RVA = "0x1786A48", Offset = "0x1786A48", VA = "0x1786A48")]
	public bool IsEquiped(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014DD2")]
	[Address(RVA = "0x1786AD0", Offset = "0x1786AD0", VA = "0x1786AD0")]
	public bool IsNewGet(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014DD3")]
	[Address(RVA = "0x17867BC", Offset = "0x17867BC", VA = "0x17867BC")]
	private NewVaultItemSortInfo GetSortInfo(uint id)
	{
		return null;
	}

	[Token(Token = "0x6014DD4")]
	[Address(RVA = "0x1786B58", Offset = "0x1786B58", VA = "0x1786B58")]
	public NewVaultItemDesc GetItemExtraInfoById(uint id)
	{
		return null;
	}

	[Token(Token = "0x6014DD5")]
	[Address(RVA = "0x1786C4C", Offset = "0x1786C4C", VA = "0x1786C4C")]
	public List<int> GetShowFirstTab()
	{
		return null;
	}

	[Token(Token = "0x6014DD6")]
	[Address(RVA = "0x1786F0C", Offset = "0x1786F0C", VA = "0x1786F0C")]
	public List<uint> GetSortedShowItemIdsBySecondTabID(eSecondTab tab)
	{
		return null;
	}

	[Token(Token = "0x6014DD7")]
	[Address(RVA = "0x1787590", Offset = "0x1787590", VA = "0x1787590")]
	public List<uint> GetSortedOnlyOwnedShowItemIdsBySecondTabID(eSecondTab tab)
	{
		return null;
	}

	[Token(Token = "0x6014DD8")]
	[Address(RVA = "0x1787714", Offset = "0x1787714", VA = "0x1787714")]
	public Dictionary<int, List<int>> GetShowTab()
	{
		return null;
	}

	[Token(Token = "0x6014DD9")]
	[Address(RVA = "0x1787CE4", Offset = "0x1787CE4", VA = "0x1787CE4", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6014DDA")]
	[Address(RVA = "0x1788814", Offset = "0x1788814", VA = "0x1788814")]
	private void InitLegendConfig()
	{
	}

	[Token(Token = "0x6014DDB")]
	[Address(RVA = "0x1788D1C", Offset = "0x1788D1C", VA = "0x1788D1C")]
	private bool IsHiddenLegendItem(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014DDC")]
	[Address(RVA = "0x1788E00", Offset = "0x1788E00", VA = "0x1788E00")]
	public bool IsNewVaultDefault(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014DDD")]
	[Address(RVA = "0x1788ECC", Offset = "0x1788ECC", VA = "0x1788ECC")]
	public int NewVaultDefaultID2RealItemID(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6014DDE")]
	[Address(RVA = "0x1788F44", Offset = "0x1788F44", VA = "0x1788F44")]
	private uint GetCurEquipCloth(UIModelAvatarBase.EWardrobeType wardrobeType)
	{
		return default(uint);
	}

	[Token(Token = "0x6014DDF")]
	[Address(RVA = "0x178917C", Offset = "0x178917C", VA = "0x178917C")]
	private uint GetCurEquipVehicle(eNewVault_VehicleType vehicleType)
	{
		return default(uint);
	}

	[Token(Token = "0x6014DE0")]
	[Address(RVA = "0x178930C", Offset = "0x178930C", VA = "0x178930C")]
	public uint GetCurEquipItemID(int tabID)
	{
		return default(uint);
	}

	[Token(Token = "0x6014DE1")]
	[Address(RVA = "0x17898E0", Offset = "0x17898E0", VA = "0x17898E0")]
	public bool GetCollectCfgIsWithEffect(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014DE2")]
	[Address(RVA = "0x178A064", Offset = "0x178A064", VA = "0x178A064")]
	public List<NewVaultItemDesc> GetAllItemExtraInfo()
	{
		return null;
	}

	[Token(Token = "0x6014DE3")]
	[Address(RVA = "0x178A0BC", Offset = "0x178A0BC", VA = "0x178A0BC")]
	public void OnInstallItemChanged()
	{
	}

	[Token(Token = "0x6014DE4")]
	[Address(RVA = "0x178BB9C", Offset = "0x178BB9C", VA = "0x178BB9C")]
	public void OnBagpackChanged()
	{
	}

	[Token(Token = "0x6014DE5")]
	[Address(RVA = "0x178BF80", Offset = "0x178BF80", VA = "0x178BF80")]
	private void OnDescChanged()
	{
	}

	[Token(Token = "0x6014DE6")]
	[Address(RVA = "0x178BFE8", Offset = "0x178BFE8", VA = "0x178BFE8")]
	private bool IsForceHideByNewVaultCfg(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014DE7")]
	[Address(RVA = "0x178C100", Offset = "0x178C100", VA = "0x178C100")]
	private bool IsShowableDebrisInNewVault(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014DE8")]
	[Address(RVA = "0x1789CB8", Offset = "0x1789CB8", VA = "0x1789CB8")]
	private eSecondTab GetSecondTabByItemID(uint id)
	{
		return default(eSecondTab);
	}

	[Token(Token = "0x6014DE9")]
	[Address(RVA = "0x178C2AC", Offset = "0x178C2AC", VA = "0x178C2AC")]
	public string GetFirstTabName(uint tabID)
	{
		return null;
	}

	[Token(Token = "0x6014DEA")]
	[Address(RVA = "0x178C3F8", Offset = "0x178C3F8", VA = "0x178C3F8")]
	public bool IsCanEquipBySecondTab(eSecondTab secondTab)
	{
		return default(bool);
	}

	[Token(Token = "0x6014DEB")]
	[Address(RVA = "0x178C4A0", Offset = "0x178C4A0", VA = "0x178C4A0")]
	public uint GetDefaultItemIDByNewVaultSecondTab(eSecondTab secondTab)
	{
		return default(uint);
	}

	[Token(Token = "0x6014DEC")]
	[Address(RVA = "0x1787E04", Offset = "0x1787E04", VA = "0x1787E04")]
	private void InitTabCfg()
	{
	}

	[Token(Token = "0x6014DED")]
	[Address(RVA = "0x1786E40", Offset = "0x1786E40", VA = "0x1786E40")]
	private bool CheckForceHideFirstTabByTabID(uint tabID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014DEE")]
	[Address(RVA = "0x1787C18", Offset = "0x1787C18", VA = "0x1787C18")]
	public bool CheckForceHideSecondTabByTabID(uint tabID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014DEF")]
	[Address(RVA = "0x178C588", Offset = "0x178C588", VA = "0x178C588")]
	public void ProcessNewVaultDefaultMusicCfg(SkinTimelineDesc data)
	{
	}

	[Token(Token = "0x6014DF0")]
	[Address(RVA = "0x178CA64", Offset = "0x178CA64", VA = "0x178CA64")]
	public void UpdateIPLobbyMusic(ResourceID IPMusicResID)
	{
	}

	[Token(Token = "0x6014DF1")]
	[Address(RVA = "0x178CF98", Offset = "0x178CF98", VA = "0x178CF98")]
	public void UpdateLobbyMusic()
	{
	}

	[Token(Token = "0x6014DF2")]
	[Address(RVA = "0x178D574", Offset = "0x178D574", VA = "0x178D574")]
	public void UpdateLobyBGMAfterGetMusicSlotData()
	{
	}

	[Token(Token = "0x6014DF3")]
	[Address(RVA = "0x178D8C8", Offset = "0x178D8C8", VA = "0x178D8C8")]
	private bool IsCheckSendAutoEquipDefault()
	{
		return default(bool);
	}

	[Token(Token = "0x6014DF4")]
	[Address(RVA = "0x178DA14", Offset = "0x178DA14", VA = "0x178DA14")]
	private void RequesetEquipDefaultMusic()
	{
	}

	[Token(Token = "0x6014DF5")]
	[Address(RVA = "0x178DB80", Offset = "0x178DB80", VA = "0x178DB80")]
	public void SetAutoEquipMusic(bool value)
	{
	}

	[Token(Token = "0x6014DF6")]
	[Address(RVA = "0x178B318", Offset = "0x178B318", VA = "0x178B318")]
	private void RefreshShowTabList()
	{
	}

	[Token(Token = "0x6014DF7")]
	[Address(RVA = "0x178A124", Offset = "0x178A124", VA = "0x178A124")]
	private void UpdateShowItemInventoryAndCfg()
	{
	}

	[Token(Token = "0x6014DF8")]
	[Address(RVA = "0x178DE80", Offset = "0x178DE80", VA = "0x178DE80")]
	private bool IsOwnedShowByNewVaultCfg(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014DF9")]
	[Address(RVA = "0x178BC0C", Offset = "0x178BC0C", VA = "0x178BC0C")]
	public void RefreshAllSortInfo()
	{
	}

	[Token(Token = "0x6014DFA")]
	[Address(RVA = "0x178DF98", Offset = "0x178DF98", VA = "0x178DF98")]
	public void RefreshSortInfoBySecondTab(eSecondTab secondTab)
	{
	}

	[Token(Token = "0x6014DFB")]
	[Address(RVA = "0x178E284", Offset = "0x178E284", VA = "0x178E284")]
	public int GetTabPriority(uint tabID)
	{
		return default(int);
	}

	[Token(Token = "0x6014DFC")]
	[Address(RVA = "0x178E390", Offset = "0x178E390", VA = "0x178E390")]
	public int GetSecondTabPriority(uint tabID)
	{
		return default(int);
	}

	[Token(Token = "0x6014DFD")]
	[Address(RVA = "0x178E49C", Offset = "0x178E49C", VA = "0x178E49C")]
	public eNewVaultTag GetTagByID(uint id)
	{
		return default(eNewVaultTag);
	}

	[Token(Token = "0x6014DFE")]
	[Address(RVA = "0x178E5A8", Offset = "0x178E5A8", VA = "0x178E5A8")]
	public List<int> GetSecondTabsIDByFirstTabID(int firstTabID)
	{
		return null;
	}

	[Token(Token = "0x6014DFF")]
	[Address(RVA = "0x178E690", Offset = "0x178E690", VA = "0x178E690")]
	public ResourceID GetSecondTabDefaultIconID(uint SecondTabID)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6014E00")]
	[Address(RVA = "0x178E898", Offset = "0x178E898", VA = "0x178E898")]
	public int GetSecondTabCount(uint secondTabId)
	{
		return default(int);
	}

	[Token(Token = "0x6014E01")]
	[Address(RVA = "0x178EBC0", Offset = "0x178EBC0", VA = "0x178EBC0")]
	public bool IsShowTipBySecondtTabID(uint secondTabID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014E02")]
	[Address(RVA = "0x178EDA8", Offset = "0x178EDA8", VA = "0x178EDA8")]
	public void UpdateNewGetByInventory(uint id)
	{
	}

	[Token(Token = "0x6014E03")]
	[Address(RVA = "0x178EF0C", Offset = "0x178EF0C", VA = "0x178EF0C")]
	public void CloseTipBySecondTab(int secondTabID)
	{
	}

	[Token(Token = "0x6014E04")]
	[Address(RVA = "0x178F170", Offset = "0x178F170", VA = "0x178F170", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014E05")]
	[Address(RVA = "0x178F1F4", Offset = "0x178F1F4", VA = "0x178F1F4")]
	public void RequestAllNewVault(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014E06")]
	[Address(RVA = "0x178F420", Offset = "0x178F420", VA = "0x178F420")]
	public void OnClothesChanged()
	{
	}

	[Token(Token = "0x6014E07")]
	[Address(RVA = "0x178F4C0", Offset = "0x178F4C0", VA = "0x178F4C0")]
	public List<uint> GetAllOwnedClothesItemId()
	{
		return null;
	}

	[Token(Token = "0x6014E08")]
	[Address(RVA = "0x178FCE0", Offset = "0x178FCE0", VA = "0x178FCE0")]
	public List<ResourceID> GetAllOwnedMusicResourceIds()
	{
		return null;
	}

	[Token(Token = "0x6014E09")]
	[Address(RVA = "0x1790024", Offset = "0x1790024", VA = "0x1790024")]
	private List<uint> Test_GetAvatarWardrobeData(uint wType)
	{
		return null;
	}

	[Token(Token = "0x6014E0A")]
	[Address(RVA = "0x17903E0", Offset = "0x17903E0", VA = "0x17903E0")]
	private List<uint> Test_GetSortedItemIdsBySecondTabID(eSecondTab tab)
	{
		return null;
	}

	[Token(Token = "0x6014E0B")]
	[Address(RVA = "0x178DC58", Offset = "0x178DC58", VA = "0x178DC58")]
	private void Test_AddSampleSet()
	{
	}

	[Token(Token = "0x6014E0C")]
	[Address(RVA = "0x1787120", Offset = "0x1787120", VA = "0x1787120")]
	public List<uint> Test_GetSortedShowItemIdsBySecondTabID(eSecondTab tab)
	{
		return null;
	}

	[Token(Token = "0x6014E0D")]
	[Address(RVA = "0x17904EC", Offset = "0x17904EC", VA = "0x17904EC")]
	private int _003CRefreshShowTabList_003Em__0(int cur, int next)
	{
		return default(int);
	}

	[Token(Token = "0x6014E0E")]
	[Address(RVA = "0x179052C", Offset = "0x179052C", VA = "0x179052C")]
	private int _003CRefreshShowTabList_003Em__1(int cur, int next)
	{
		return default(int);
	}

	[Token(Token = "0x6014E0F")]
	[Address(RVA = "0x179056C", Offset = "0x179056C", VA = "0x179056C")]
	private void _003CRequestAllNewVault_003Em__2(HttpErrorCode err, object res)
	{
	}

	[Token(Token = "0x6014E10")]
	[Address(RVA = "0x17908E8", Offset = "0x17908E8", VA = "0x17908E8")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6014E11")]
	[Address(RVA = "0x17908F0", Offset = "0x17908F0", VA = "0x17908F0")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
