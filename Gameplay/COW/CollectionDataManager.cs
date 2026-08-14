using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DC5")]
public class CollectionDataManager : SingletonModule<CollectionDataManager>, _Attribute
{
	[Token(Token = "0x2002DC6")]
	public enum ECallSignSourceType
	{
		[Token(Token = "0x4011940")]
		All,
		[Token(Token = "0x4011941")]
		Avatar,
		[Token(Token = "0x4011942")]
		Events,
		[Token(Token = "0x4011943")]
		LadderMatch,
		[Token(Token = "0x4011944")]
		Mall,
		[Token(Token = "0x4011945")]
		ElitePass
	}

	[Token(Token = "0x2002DC7")]
	public enum ECollectionWeaponType
	{
		[Token(Token = "0x4011947")]
		fist = 0,
		[Token(Token = "0x4011948")]
		rifle = 1,
		[Token(Token = "0x4011949")]
		sniper = 2,
		[Token(Token = "0x401194A")]
		handGun = 3,
		[Token(Token = "0x401194B")]
		subMachineGun = 4,
		[Token(Token = "0x401194C")]
		shotGun = 5,
		[Token(Token = "0x401194D")]
		melee = 6,
		[Token(Token = "0x401194E")]
		grenade = 7,
		[Token(Token = "0x401194F")]
		others = 8,
		[Token(Token = "0x4011950")]
		designatedmarksmanrifle = 9,
		[Token(Token = "0x4011951")]
		lightmachinegun = 10,
		[Token(Token = "0x4011952")]
		all = 99
	}

	[Token(Token = "0x4011918")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, BannerData> m_dictIdToBannerData;

	[Token(Token = "0x4011919")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, HeadPicData> m_dictIdToHeadPicData;

	[Token(Token = "0x401191A")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<uint, LootBoxData> m_dictIdToLootBoxData;

	[Token(Token = "0x401191B")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, BackPackData> m_dictIdToBackPackData;

	[Token(Token = "0x401191C")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<uint, ParachuteData> m_dictIdToParachuteData;

	[Token(Token = "0x401191D")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<uint, FlightData> m_dictIdToFlightData;

	[Token(Token = "0x401191E")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<uint, SkyboardData> m_dictIdToSkyboardData;

	[Token(Token = "0x401191F")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<uint, WeaponSkinData> m_dictIdToWeaponSkinData;

	[Token(Token = "0x4011920")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, List<uint>> m_dictIdToCanUpgradeWeaponSkinSeriesData;

	[Token(Token = "0x4011921")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<uint, VehicleSkinData> m_dictIdToVehicleSkinData;

	[Token(Token = "0x4011922")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<uint, EmoteData> m_dictIdToEmoteData;

	[Token(Token = "0x4011923")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<uint, TransformData> m_dictIdToTransformData;

	[Token(Token = "0x4011924")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<uint, GroupAnimData> m_dictIDToGroupAnimData;

	[Token(Token = "0x4011925")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<uint, WeaponEffectConfigData> m_dictIdToWeaponEffectData;

	[Token(Token = "0x4011926")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<uint, MusicData> m_dictIdToMusicData;

	[Token(Token = "0x4011927")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<uint, PinData> m_PinDataDict;

	[Token(Token = "0x4011928")]
	[FieldOffset(Offset = "0x4C")]
	private Dictionary<int, int> m_DictTabPriority;

	[Token(Token = "0x4011929")]
	[FieldOffset(Offset = "0x50")]
	private List<EmoteData> m_ListSourceEmoteData;

	[Token(Token = "0x401192A")]
	[FieldOffset(Offset = "0x54")]
	private List<TransformData> m_ListSourceTransformData;

	[Token(Token = "0x401192B")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<uint, Dictionary<uint, List<WeaponSkinData>>> m_DictWeaponDataSortedByType;

	[Token(Token = "0x401192C")]
	[FieldOffset(Offset = "0x5C")]
	private List<uint> m_WeaponTypeList;

	[Token(Token = "0x401192D")]
	[FieldOffset(Offset = "0x60")]
	private List<uint> m_WeaponIdList;

	[Token(Token = "0x401192E")]
	[FieldOffset(Offset = "0x64")]
	private List<WeaponScoreName> m_WeaponScoreNameList;

	[Token(Token = "0x401192F")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<uint, WeaponPropertyScore> m_dictIdToWeaponScore;

	[Token(Token = "0x4011930")]
	[FieldOffset(Offset = "0x6C")]
	private Dictionary<uint, WeaponSkinPropertyScore> m_dictIdToWeaponSkinScore;

	[Token(Token = "0x4011931")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<uint, VehicleSkinPropertyScoreData> m_dictIdToVehicleSkinScore;

	[Token(Token = "0x4011932")]
	[FieldOffset(Offset = "0x74")]
	private Dictionary<uint, PVEWeaponPropertyScore> m_dictIdToPVEWeaponSkinScore;

	[Token(Token = "0x4011933")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<string, uint> m_WeaponScoreConfig;

	[Token(Token = "0x4011934")]
	[FieldOffset(Offset = "0x7C")]
	private List<uint> m_VehicleIdList;

	[Token(Token = "0x4011935")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<uint, List<VehicleSkinData>> m_DictSortedVehicleSkinDataByVehicleID;

	[Token(Token = "0x4011936")]
	[FieldOffset(Offset = "0x84")]
	private UIModelLogin m_ModelLogin;

	[Token(Token = "0x4011937")]
	[FieldOffset(Offset = "0x88")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x4011938")]
	[FieldOffset(Offset = "0x8C")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x4011939")]
	[FieldOffset(Offset = "0x90")]
	private UIModelLadderMatch m_ModelLadderMatch;

	[Token(Token = "0x401193A")]
	[FieldOffset(Offset = "0x94")]
	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	[Token(Token = "0x401193B")]
	[FieldOffset(Offset = "0x98")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x401193C")]
	[FieldOffset(Offset = "0x9C")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x401193D")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<EmoteData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x401193E")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<TransformData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x601330A")]
	[Address(RVA = "0x1730110", Offset = "0x1730110", VA = "0x1730110")]
	public CollectionDataManager()
	{
	}

	[Token(Token = "0x601330B")]
	[Address(RVA = "0x1730780", Offset = "0x1730780", VA = "0x1730780")]
	public List<WeaponScoreName> WeaponScoreNameList()
	{
		return null;
	}

	[Token(Token = "0x601330C")]
	[Address(RVA = "0x17307D8", Offset = "0x17307D8", VA = "0x17307D8")]
	public Dictionary<string, uint> GetWeaponScoreConfigDict()
	{
		return null;
	}

	[Token(Token = "0x601330D")]
	[Address(RVA = "0x1730830", Offset = "0x1730830", VA = "0x1730830")]
	public List<EmoteData> GetSourceEmoteData()
	{
		return null;
	}

	[Token(Token = "0x601330E")]
	[Address(RVA = "0x1730888", Offset = "0x1730888", VA = "0x1730888")]
	public List<TransformData> GetSourceTransformData()
	{
		return null;
	}

	[Token(Token = "0x601330F")]
	[Address(RVA = "0x17308E0", Offset = "0x17308E0", VA = "0x17308E0")]
	public List<uint> GetAllWeaponIds()
	{
		return null;
	}

	[Token(Token = "0x6013310")]
	[Address(RVA = "0x1730938", Offset = "0x1730938", VA = "0x1730938")]
	public List<WeaponSkinData> GetWeaponSkinDataListByWeaponId(uint wpId)
	{
		return null;
	}

	[Token(Token = "0x6013311")]
	[Address(RVA = "0x1730B68", Offset = "0x1730B68", VA = "0x1730B68")]
	public ResourceID GetWeaponTypeSpriteRes(ECollectionWeaponType wType)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6013312")]
	[Address(RVA = "0x1730DC0", Offset = "0x1730DC0", VA = "0x1730DC0")]
	public List<uint> GetAllVehicleIds()
	{
		return null;
	}

	[Token(Token = "0x6013313")]
	[Address(RVA = "0x1730E18", Offset = "0x1730E18", VA = "0x1730E18")]
	public List<VehicleSkinData> GetVehicleSkinDataListByVehicleId(uint wpId)
	{
		return null;
	}

	[Token(Token = "0x6013314")]
	[Address(RVA = "0x1730F00", Offset = "0x1730F00", VA = "0x1730F00", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013315")]
	[Address(RVA = "0x17312A0", Offset = "0x17312A0", VA = "0x17312A0")]
	public void LoadCSVData()
	{
	}

	[Token(Token = "0x6013316")]
	[Address(RVA = "0x17328C8", Offset = "0x17328C8", VA = "0x17328C8", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6013317")]
	[Address(RVA = "0x1732B40", Offset = "0x1732B40", VA = "0x1732B40")]
	public void LoadWithRegion()
	{
	}

	[Token(Token = "0x6013318")]
	[Address(RVA = "0x1733DBC", Offset = "0x1733DBC", VA = "0x1733DBC", Slot = "8")]
	protected override void OnUnloadMemeory()
	{
	}

	[Token(Token = "0x6013319")]
	[Address(RVA = "0x1733E94", Offset = "0x1733E94", VA = "0x1733E94", Slot = "9")]
	protected override void OnReloadMemory()
	{
	}

	[Token(Token = "0x601331A")]
	[Address(RVA = "0x17342A8", Offset = "0x17342A8", VA = "0x17342A8")]
	public Dictionary<uint, BannerData> GetAllBannerData()
	{
		return null;
	}

	[Token(Token = "0x601331B")]
	[Address(RVA = "0x1734300", Offset = "0x1734300", VA = "0x1734300")]
	public Dictionary<uint, HeadPicData> GetAllHeadPicData()
	{
		return null;
	}

	[Token(Token = "0x601331C")]
	[Address(RVA = "0x1734358", Offset = "0x1734358", VA = "0x1734358")]
	public Dictionary<uint, LootBoxData> GetAllLootBoxData()
	{
		return null;
	}

	[Token(Token = "0x601331D")]
	[Address(RVA = "0x17343B0", Offset = "0x17343B0", VA = "0x17343B0")]
	public BannerData FindBannerDataById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x601331E")]
	[Address(RVA = "0x17344A0", Offset = "0x17344A0", VA = "0x17344A0")]
	public HeadPicData FindHeadPicDataById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x601331F")]
	[Address(RVA = "0x1734590", Offset = "0x1734590", VA = "0x1734590")]
	public HeadPicData FindHeadPicDataByAvatarId(uint avatarid)
	{
		return null;
	}

	[Token(Token = "0x6013320")]
	[Address(RVA = "0x17347B4", Offset = "0x17347B4", VA = "0x17347B4")]
	public LootBoxData FindLootBoxDataById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x6013321")]
	[Address(RVA = "0x17348A4", Offset = "0x17348A4", VA = "0x17348A4")]
	public BackPackData FindBackPackDataById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x6013322")]
	[Address(RVA = "0x1734994", Offset = "0x1734994", VA = "0x1734994")]
	public ParachuteData FindParachuteDataById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x6013323")]
	[Address(RVA = "0x1734A84", Offset = "0x1734A84", VA = "0x1734A84")]
	public FlightData FindFlightDataById(uint id)
	{
		return null;
	}

	[Token(Token = "0x6013324")]
	[Address(RVA = "0x1734B74", Offset = "0x1734B74", VA = "0x1734B74")]
	public Dictionary<uint, SkyboardData> GetAllSkyboardData()
	{
		return null;
	}

	[Token(Token = "0x6013325")]
	[Address(RVA = "0x1734BCC", Offset = "0x1734BCC", VA = "0x1734BCC")]
	public List<uint> GetCollectionResIdsByType(CSSharedItemDataManager.CollectionSubType subType)
	{
		return null;
	}

	[Token(Token = "0x6013326")]
	[Address(RVA = "0x1734FA4", Offset = "0x1734FA4", VA = "0x1734FA4")]
	public SkyboardData FindSkyboardDataById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x6013327")]
	[Address(RVA = "0x1735094", Offset = "0x1735094", VA = "0x1735094")]
	public WeaponSkinData FindWeaponSkinDataById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x6013328")]
	[Address(RVA = "0x1735184", Offset = "0x1735184", VA = "0x1735184")]
	public VehicleSkinPropertyScoreData FindVehicleSkinPropertyScoreDataById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x6013329")]
	[Address(RVA = "0x1735274", Offset = "0x1735274", VA = "0x1735274")]
	public List<uint> FindWeaponSkinSuitByItemId(uint iid)
	{
		return null;
	}

	[Token(Token = "0x601332A")]
	[Address(RVA = "0x17352FC", Offset = "0x17352FC", VA = "0x17352FC")]
	public List<uint> FindWeaponSkinSuitBySuitId(uint suitId)
	{
		return null;
	}

	[Token(Token = "0x601332B")]
	[Address(RVA = "0x17353EC", Offset = "0x17353EC", VA = "0x17353EC")]
	public List<uint> GetWeaponSkinsCanUpgrade()
	{
		return null;
	}

	[Token(Token = "0x601332C")]
	[Address(RVA = "0x173565C", Offset = "0x173565C", VA = "0x173565C")]
	public WeaponPropertyScore FindWeaponScoreById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x601332D")]
	[Address(RVA = "0x173574C", Offset = "0x173574C", VA = "0x173574C")]
	public PVEWeaponPropertyScore FindPVEWeaponScoreById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x601332E")]
	[Address(RVA = "0x173583C", Offset = "0x173583C", VA = "0x173583C")]
	public int PVEWeaponPropertyScoreCount()
	{
		return default(int);
	}

	[Token(Token = "0x601332F")]
	[Address(RVA = "0x1735A38", Offset = "0x1735A38", VA = "0x1735A38")]
	public WeaponSkinPropertyScore FindWeaponSkinScoreById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x6013330")]
	[Address(RVA = "0x1735B28", Offset = "0x1735B28", VA = "0x1735B28")]
	public VehicleSkinData FindVehicleSkinDataById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x6013331")]
	[Address(RVA = "0x1735C18", Offset = "0x1735C18", VA = "0x1735C18")]
	public PinData FindPinDataById(uint pinId)
	{
		return null;
	}

	[Token(Token = "0x6013332")]
	[Address(RVA = "0x1735D00", Offset = "0x1735D00", VA = "0x1735D00")]
	public MusicData FindMusicDataById(uint pinId)
	{
		return null;
	}

	[Token(Token = "0x6013333")]
	[Address(RVA = "0x1735DE8", Offset = "0x1735DE8", VA = "0x1735DE8")]
	public Dictionary<uint, MusicData> FindAllMusicData()
	{
		return null;
	}

	[Token(Token = "0x6013334")]
	[Address(RVA = "0x1735E40", Offset = "0x1735E40", VA = "0x1735E40")]
	public EmoteData FindEmoteDataById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x6013335")]
	[Address(RVA = "0x1735F30", Offset = "0x1735F30", VA = "0x1735F30")]
	public TransformData FindTransformDataById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x6013336")]
	[Address(RVA = "0x1736020", Offset = "0x1736020", VA = "0x1736020")]
	public GroupAnimData FindGroupAnimDataById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x6013337")]
	[Address(RVA = "0x1736110", Offset = "0x1736110", VA = "0x1736110")]
	public Dictionary<uint, GroupAnimData> GetAllGroupAnimData()
	{
		return null;
	}

	[Token(Token = "0x6013338")]
	[Address(RVA = "0x1736168", Offset = "0x1736168", VA = "0x1736168")]
	public WeaponEffectConfigData FindWeaponEffectConfigDataById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x6013339")]
	[Address(RVA = "0x1736258", Offset = "0x1736258", VA = "0x1736258", Slot = "10")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601333A")]
	[Address(RVA = "0x1736760", Offset = "0x1736760", VA = "0x1736760", Slot = "11")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601333B")]
	[Address(RVA = "0x1733A90", Offset = "0x1733A90", VA = "0x1733A90")]
	private ECollectionType ToCollectionType(CSSharedItemDataManager.CollectionSubType subType)
	{
		return default(ECollectionType);
	}

	[Token(Token = "0x601333C")]
	[Address(RVA = "0x1736884", Offset = "0x1736884", VA = "0x1736884")]
	public int GetTabPriority(ECollectionType tab)
	{
		return default(int);
	}

	[Token(Token = "0x601333D")]
	[Address(RVA = "0x1736990", Offset = "0x1736990", VA = "0x1736990")]
	public int GetWeaponTypeSort(ECollectionWeaponType type)
	{
		return default(int);
	}

	[Token(Token = "0x601333E")]
	[Address(RVA = "0x1733B5C", Offset = "0x1733B5C", VA = "0x1733B5C")]
	public bool IsCurrentRegion(string regionString)
	{
		return default(bool);
	}

	[Token(Token = "0x601333F")]
	[Address(RVA = "0x1736A50", Offset = "0x1736A50", VA = "0x1736A50")]
	private int _003CLoadCSVData_003Em__0(uint x, uint y)
	{
		return default(int);
	}

	[Token(Token = "0x6013340")]
	[Address(RVA = "0x1736B6C", Offset = "0x1736B6C", VA = "0x1736B6C")]
	private static int _003CLoadCSVData_003Em__1(EmoteData a, EmoteData b)
	{
		return default(int);
	}

	[Token(Token = "0x6013341")]
	[Address(RVA = "0x1736BB4", Offset = "0x1736BB4", VA = "0x1736BB4")]
	private static int _003CLoadCSVData_003Em__2(TransformData a, TransformData b)
	{
		return default(int);
	}

	[Token(Token = "0x6013342")]
	[Address(RVA = "0x1736BFC", Offset = "0x1736BFC", VA = "0x1736BFC")]
	public void _003C_003EiFixBaseProxy_OnUnloadMemeory()
	{
	}

	[Token(Token = "0x6013343")]
	[Address(RVA = "0x1736C00", Offset = "0x1736C00", VA = "0x1736C00")]
	public void _003C_003EiFixBaseProxy_OnReloadMemory()
	{
	}
}
