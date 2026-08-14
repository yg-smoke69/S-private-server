using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002C50")]
public class CSSharedItemDataManager : SingletonModule<CSSharedItemDataManager>
{
	[Token(Token = "0x2002C51")]
	public enum ItemType
	{
		[Token(Token = "0x4010E58")]
		ITEMTYPENONE = 0,
		[Token(Token = "0x4010E59")]
		Avatar = 1,
		[Token(Token = "0x4010E5A")]
		Clothes = 2,
		[Token(Token = "0x4010E5B")]
		LimitedCard = 3,
		[Token(Token = "0x4010E5C")]
		TreasureBox = 4,
		[Token(Token = "0x4010E5D")]
		Props = 5,
		[Token(Token = "0x4010E5E")]
		RoomCard = 6,
		[Token(Token = "0x4010E5F")]
		Bundle = 7,
		[Token(Token = "0x4010E60")]
		Debris = 8,
		[Token(Token = "0x4010E61")]
		Collection = 9,
		[Token(Token = "0x4010E62")]
		VirtualGoods = 10,
		[Token(Token = "0x4010E63")]
		BonusCard = 11,
		[Token(Token = "0x4010E64")]
		WeaponSkin = 12,
		[Token(Token = "0x4010E65")]
		Pet = 13,
		[Token(Token = "0x4010E66")]
		BattleFlag = 14,
		[Token(Token = "0x4010E67")]
		ElitePassDebris = 15,
		[Token(Token = "0x4010E68")]
		RelationItem = 16,
		[Token(Token = "0x4010E69")]
		OptionalBundle = 17,
		[Token(Token = "0x4010E6A")]
		HyperBook = 18,
		[Token(Token = "0x4010E6B")]
		ItemHide = 99
	}

	[Token(Token = "0x2002C52")]
	public enum CollectionSubType
	{
		[Token(Token = "0x4010E6D")]
		NOTCOLLECTION,
		[Token(Token = "0x4010E6E")]
		Banner,
		[Token(Token = "0x4010E6F")]
		HeadPic,
		[Token(Token = "0x4010E70")]
		LootBox,
		[Token(Token = "0x4010E71")]
		BackPack,
		[Token(Token = "0x4010E72")]
		Parachute,
		[Token(Token = "0x4010E73")]
		Skyboard,
		[Token(Token = "0x4010E74")]
		Weapon,
		[Token(Token = "0x4010E75")]
		VehicleSkin,
		[Token(Token = "0x4010E76")]
		Emote,
		[Token(Token = "0x4010E77")]
		Pin,
		[Token(Token = "0x4010E78")]
		Flight,
		[Token(Token = "0x4010E79")]
		GroupAnim,
		[Token(Token = "0x4010E7A")]
		Music,
		[Token(Token = "0x4010E7B")]
		Transformer,
		[Token(Token = "0x4010E7C")]
		HyperBook,
		[Token(Token = "0x4010E7D")]
		Max
	}

	[Token(Token = "0x2002C53")]
	public enum CharacterSubType
	{
		[Token(Token = "0x4010E7F")]
		NONE,
		[Token(Token = "0x4010E80")]
		Avatar,
		[Token(Token = "0x4010E81")]
		AvatarBundle,
		[Token(Token = "0x4010E82")]
		AvatarDebirs,
		[Token(Token = "0x4010E83")]
		AvatarUpgradeCard,
		[Token(Token = "0x4010E84")]
		AvatarBox
	}

	[Token(Token = "0x2002C54")]
	public enum LoadoutSubType
	{
		[Token(Token = "0x4010E86")]
		LoadoutType_NONE,
		[Token(Token = "0x4010E87")]
		LoadoutType_OLD,
		[Token(Token = "0x4010E88")]
		LoadoutType_NEW
	}

	[Token(Token = "0x2002C55")]
	public enum StoreQuality
	{
		[Token(Token = "0x4010E8A")]
		StoreQuality_NONE = 0,
		[Token(Token = "0x4010E8B")]
		StoreQuality_WHITE = 1,
		[Token(Token = "0x4010E8C")]
		StoreQuality_GREEN = 2,
		[Token(Token = "0x4010E8D")]
		StoreQuality_BLUE = 3,
		[Token(Token = "0x4010E8E")]
		StoreQuality_PURPLE = 4,
		[Token(Token = "0x4010E8F")]
		StoreQuality_ORANGE = 5,
		[Token(Token = "0x4010E90")]
		StoreQuality_Red = 7,
		[Token(Token = "0x4010E91")]
		StoreQuality_PURPLE_PLUS = 8,
		[Token(Token = "0x4010E92")]
		StoreQuality_ORANGE_PLUS = 9,
		[Token(Token = "0x4010E93")]
		StoreQuality_BLACK = 10
	}

	[Token(Token = "0x2002C56")]
	public enum PetSubType
	{
		[Token(Token = "0x4010E95")]
		PetSubType_NONE,
		[Token(Token = "0x4010E96")]
		PetSubType_PET_AND_FOOD,
		[Token(Token = "0x4010E97")]
		PetSubType_PET_ANIM,
		[Token(Token = "0x4010E98")]
		PetSubType_PET_SKIN,
		[Token(Token = "0x4010E99")]
		PetSubType_PET_CHEST,
		[Token(Token = "0x4010E9A")]
		PetSubType_PET_BOX
	}

	[Token(Token = "0x2002C57")]
	public enum ItemSubType
	{
		[Token(Token = "0x4010E9C")]
		ItemSubType_NONE = 0,
		[Token(Token = "0x4010E9D")]
		ItemSubType_GACHACOUPON = 2,
		[Token(Token = "0x4010E9E")]
		ItemSubType_ELITEPASS = 3,
		[Token(Token = "0x4010E9F")]
		ItemSubType_VOUCHER = 4,
		[Token(Token = "0x4010EA0")]
		ItemSubType_RENAMECARD = 5,
		[Token(Token = "0x4010EA1")]
		ItemSubType_REDENVELOPE = 6,
		[Token(Token = "0x4010EA2")]
		ItemSubType_PETFOOD = 7,
		[Token(Token = "0x4010EA3")]
		ItemSubType_FORGECURRENCY = 8,
		[Token(Token = "0x4010EA4")]
		ItemSubType_PETANIM = 9,
		[Token(Token = "0x4010EA5")]
		ItemSubType_PETSKIN = 10,
		[Token(Token = "0x4010EA6")]
		ItemSubType_REVIVETOKEN = 11,
		[Token(Token = "0x4010EA7")]
		ItemSubType_CHARACTER_PROFILE_UPGRADE_CARD = 12,
		[Token(Token = "0x4010EA8")]
		ItemSubType_CHIP = 13,
		[Token(Token = "0x4010EA9")]
		ItemSubType_PetSkill = 15,
		[Token(Token = "0x4010EAA")]
		ItemSubType_CrateBox = 16,
		[Token(Token = "0x4010EAB")]
		ItemSubType_UNIVERSALDEBRIS = 17,
		[Token(Token = "0x4010EAC")]
		ItemSubType_GACHACOUPON_LIMIT = 19,
		[Token(Token = "0x4010EAD")]
		ItemSubType_EVENTITEMFORHISTORY = 20,
		[Token(Token = "0x4010EAE")]
		ItemSubType_FLASH_GEM = 29,
		[Token(Token = "0x4010EAF")]
		ItemSubType_RANK_NO_DEDUCT_CARD = 30,
		[Token(Token = "0x4010EB0")]
		ItemSubType_RANK_TIMES_RP_CARD = 31
	}

	[Token(Token = "0x2002C58")]
	private sealed class _003CFindIpTagDescByID_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010EB1")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemID;

		[Token(Token = "0x6012816")]
		[Address(RVA = "0x182B7BC", Offset = "0x182B7BC", VA = "0x182B7BC")]
		public _003CFindIpTagDescByID_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6012817")]
		[Address(RVA = "0x182B7C4", Offset = "0x182B7C4", VA = "0x182B7C4")]
		internal bool _003C_003Em__0(IPTagConfigDesc d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4010E4F")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, CSSharedItemData> m_dictIdToCSItemData;

	[Token(Token = "0x4010E50")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, string> m_dictIdToCSItemDataEndtime;

	[Token(Token = "0x4010E51")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<uint, byte> m_dictIdToCSItemDataSubType;

	[Token(Token = "0x4010E52")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, CSSharedLoadoutData> m_dictIdtoCSLoadoutData;

	[Token(Token = "0x4010E53")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<uint, BattleFlagConfigData> m_dictIdToBattleFlagConfigData;

	[Token(Token = "0x4010E54")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<uint, BattleFlagConfigData> m_dictLinkIdToBattleFlagConfigData;

	[Token(Token = "0x4010E55")]
	[FieldOffset(Offset = "0x24")]
	private List<CSSharedItemData> m_DefaultPVEWeapons;

	[Token(Token = "0x4010E56")]
	[FieldOffset(Offset = "0x28")]
	private List<IPTagConfigDesc> m_IPTagConfigDesc;

	[Token(Token = "0x60127FA")]
	[Address(RVA = "0x182874C", Offset = "0x182874C", VA = "0x182874C")]
	public CSSharedItemDataManager()
	{
	}

	[Token(Token = "0x60127FB")]
	[Address(RVA = "0x1828960", Offset = "0x1828960", VA = "0x1828960", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60127FC")]
	[Address(RVA = "0x1828B3C", Offset = "0x1828B3C", VA = "0x1828B3C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60127FD")]
	[Address(RVA = "0x1828654", Offset = "0x1828654", VA = "0x1828654")]
	public void SetCSItemDataEndtime(uint id, string endTime)
	{
	}

	[Token(Token = "0x60127FE")]
	[Address(RVA = "0x1827294", Offset = "0x1827294", VA = "0x1827294")]
	public string GetCSItemDataEndtime(uint id)
	{
		return null;
	}

	[Token(Token = "0x60127FF")]
	[Address(RVA = "0x182856C", Offset = "0x182856C", VA = "0x182856C")]
	public void SetCSItemDataSubType(uint id, byte subtype)
	{
	}

	[Token(Token = "0x6012800")]
	[Address(RVA = "0x18270B8", Offset = "0x18270B8", VA = "0x18270B8")]
	public byte GetCSItemDataSubType(uint id)
	{
		return default(byte);
	}

	[Token(Token = "0x6012801")]
	[Address(RVA = "0x18295D4", Offset = "0x18295D4", VA = "0x18295D4")]
	public bool IsLoadoutPlayCard(uint InId)
	{
		return default(bool);
	}

	[Token(Token = "0x6012802")]
	[Address(RVA = "0x18297D4", Offset = "0x18297D4", VA = "0x18297D4")]
	public uint GetCSLoadoutPlayCardIdById(uint InId)
	{
		return default(uint);
	}

	[Token(Token = "0x6012803")]
	[Address(RVA = "0x18298DC", Offset = "0x18298DC", VA = "0x18298DC")]
	public LoadoutSubType GetCSLoadoutSubTypeById(uint InId)
	{
		return default(LoadoutSubType);
	}

	[Token(Token = "0x6012804")]
	[Address(RVA = "0x18299E4", Offset = "0x18299E4", VA = "0x18299E4")]
	public List<Item> GetLoadoutListByType(LoadoutSubType subType)
	{
		return null;
	}

	[Token(Token = "0x6012805")]
	[Address(RVA = "0x1829DD0", Offset = "0x1829DD0", VA = "0x1829DD0")]
	public int GetCSLoadoutPageID(uint InId)
	{
		return default(int);
	}

	[Token(Token = "0x6012806")]
	[Address(RVA = "0x1829ED8", Offset = "0x1829ED8", VA = "0x1829ED8")]
	public string GetLoadoutSpriteNameById(uint InId)
	{
		return null;
	}

	[Token(Token = "0x6012807")]
	[Address(RVA = "0x182A020", Offset = "0x182A020", VA = "0x182A020")]
	public bool IsCSLoadoutSold(uint InId)
	{
		return default(bool);
	}

	[Token(Token = "0x6012808")]
	[Address(RVA = "0x182A130", Offset = "0x182A130", VA = "0x182A130")]
	public Dictionary<uint, CSSharedItemData> GetItemDict()
	{
		return null;
	}

	[Token(Token = "0x6012809")]
	[Address(RVA = "0x181FB9C", Offset = "0x181FB9C", VA = "0x181FB9C")]
	public CSSharedItemData FindCSSharedItemDataById(uint InId)
	{
		return null;
	}

	[Token(Token = "0x601280A")]
	[Address(RVA = "0x182A188", Offset = "0x182A188", VA = "0x182A188")]
	public CSSharedItemData FindFirstTicket(IEnumerable<uint> idList)
	{
		return null;
	}

	[Token(Token = "0x601280B")]
	[Address(RVA = "0x182A6B0", Offset = "0x182A6B0", VA = "0x182A6B0")]
	public string FindCSSharedItemTypeSpriteNameById(uint InId)
	{
		return null;
	}

	[Token(Token = "0x601280C")]
	[Address(RVA = "0x182AB78", Offset = "0x182AB78", VA = "0x182AB78")]
	public CSSharedItemData FindCSSharedItemDataCoverLimitcard(uint id)
	{
		return null;
	}

	[Token(Token = "0x601280D")]
	[Address(RVA = "0x182AD28", Offset = "0x182AD28", VA = "0x182AD28")]
	public BattleFlagConfigData FindBattleFlagConfigDataByID(uint id)
	{
		return null;
	}

	[Token(Token = "0x601280E")]
	[Address(RVA = "0x182AE1C", Offset = "0x182AE1C", VA = "0x182AE1C")]
	public BattleFlagConfigData FindBattleFlagConfigDataByLinkID(uint id)
	{
		return null;
	}

	[Token(Token = "0x601280F")]
	[Address(RVA = "0x182AF10", Offset = "0x182AF10", VA = "0x182AF10")]
	public static Color GetRareColor(uint rare)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6012810")]
	[Address(RVA = "0x182B0C0", Offset = "0x182B0C0", VA = "0x182B0C0")]
	public static string GetRareColorBBCode(uint rare, string name)
	{
		return null;
	}

	[Token(Token = "0x6012811")]
	[Address(RVA = "0x182B3A4", Offset = "0x182B3A4", VA = "0x182B3A4")]
	public static CollectionSubType GetCollectionSubTypeByID(uint iid)
	{
		return default(CollectionSubType);
	}

	[Token(Token = "0x6012812")]
	[Address(RVA = "0x182B4B4", Offset = "0x182B4B4", VA = "0x182B4B4")]
	public static ItemType GetItemTypeByID(uint id)
	{
		return default(ItemType);
	}

	[Token(Token = "0x6012813")]
	[Address(RVA = "0x182B5B4", Offset = "0x182B5B4", VA = "0x182B5B4")]
	public List<CSSharedItemData> DefaultPVEWeapons()
	{
		return null;
	}

	[Token(Token = "0x6012814")]
	[Address(RVA = "0x182B60C", Offset = "0x182B60C", VA = "0x182B60C")]
	public void ProcessIpTagConfig(CSGetIPTagConfigRes res)
	{
	}

	[Token(Token = "0x6012815")]
	[Address(RVA = "0x182B678", Offset = "0x182B678", VA = "0x182B678")]
	public IPTagConfigDesc FindIpTagDescByID(uint itemID)
	{
		return null;
	}
}
