using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x20030B8")]
internal class UIModelInventory : UIBaseModel
{
	[Token(Token = "0x20030B9")]
	public class NotifyInstallmentArgs
	{
		[Token(Token = "0x40128B3")]
		[FieldOffset(Offset = "0x8")]
		public bool requestProfile;

		[Token(Token = "0x60146DD")]
		[Address(RVA = "0x326BB24", Offset = "0x326BB24", VA = "0x326BB24")]
		public NotifyInstallmentArgs()
		{
		}
	}

	[Token(Token = "0x20030BA")]
	private sealed class _003CRequestLegendClothDesc_003Ec__AnonStorey0
	{
		[Token(Token = "0x40128B4")]
		[FieldOffset(Offset = "0x8")]
		internal bool refreshAll;

		[Token(Token = "0x40128B5")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelInventory _0024this;

		[Token(Token = "0x60146DE")]
		[Address(RVA = "0x326B81C", Offset = "0x326B81C", VA = "0x326B81C")]
		public _003CRequestLegendClothDesc_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60146DF")]
		[Address(RVA = "0x326B824", Offset = "0x326B824", VA = "0x326B824")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20030BB")]
	private sealed class _003CUpdateInstallmentsInfo_003Ec__AnonStorey1
	{
		[Token(Token = "0x40128B6")]
		[FieldOffset(Offset = "0x8")]
		internal Item it;

		[Token(Token = "0x60146E0")]
		[Address(RVA = "0x326BA48", Offset = "0x326BA48", VA = "0x326BA48")]
		public _003CUpdateInstallmentsInfo_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60146E1")]
		[Address(RVA = "0x326BA50", Offset = "0x326BA50", VA = "0x326BA50")]
		internal bool _003C_003Em__0(Item a)
		{
			return default(bool);
		}

		[Token(Token = "0x60146E2")]
		[Address(RVA = "0x326BA90", Offset = "0x326BA90", VA = "0x326BA90")]
		internal bool _003C_003Em__1(Item a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030BC")]
	private sealed class _003CUpdateInstallmentsInfo_003Ec__AnonStorey2
	{
		[Token(Token = "0x40128B7")]
		[FieldOffset(Offset = "0x8")]
		internal Item it;

		[Token(Token = "0x60146E3")]
		[Address(RVA = "0x326BAD0", Offset = "0x326BAD0", VA = "0x326BAD0")]
		public _003CUpdateInstallmentsInfo_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60146E4")]
		[Address(RVA = "0x326BAD8", Offset = "0x326BAD8", VA = "0x326BAD8")]
		internal bool _003C_003Em__0(Item a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030BD")]
	private sealed class _003CUpdateBackPackInfo_003Ec__AnonStorey3
	{
		[Token(Token = "0x40128B8")]
		[FieldOffset(Offset = "0x8")]
		internal Item it;

		[Token(Token = "0x60146E5")]
		[Address(RVA = "0x326B9A0", Offset = "0x326B9A0", VA = "0x326B9A0")]
		public _003CUpdateBackPackInfo_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60146E6")]
		[Address(RVA = "0x326B9A8", Offset = "0x326B9A8", VA = "0x326B9A8")]
		internal bool _003C_003Em__0(Item a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030BE")]
	private sealed class _003CGetItemById_003Ec__AnonStorey4
	{
		[Token(Token = "0x40128B9")]
		[FieldOffset(Offset = "0x8")]
		internal uint iid;

		[Token(Token = "0x60146E7")]
		[Address(RVA = "0x326B724", Offset = "0x326B724", VA = "0x326B724")]
		public _003CGetItemById_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60146E8")]
		[Address(RVA = "0x326B72C", Offset = "0x326B72C", VA = "0x326B72C")]
		internal bool _003C_003Em__0(Item item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030BF")]
	private sealed class _003CGetInstallmentItemById_003Ec__AnonStorey5
	{
		[Token(Token = "0x40128BA")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x60146E9")]
		[Address(RVA = "0x326B6E4", Offset = "0x326B6E4", VA = "0x326B6E4")]
		public _003CGetInstallmentItemById_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60146EA")]
		[Address(RVA = "0x326B6EC", Offset = "0x326B6EC", VA = "0x326B6EC")]
		internal bool _003C_003Em__0(Item item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030C0")]
	private sealed class _003CFindReminderItemByID_003Ec__AnonStorey6
	{
		[Token(Token = "0x40128BB")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x60146EB")]
		[Address(RVA = "0x326B6A8", Offset = "0x326B6A8", VA = "0x326B6A8")]
		public _003CFindReminderItemByID_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x60146EC")]
		[Address(RVA = "0x326B6B0", Offset = "0x326B6B0", VA = "0x326B6B0")]
		internal bool _003C_003Em__0(Item item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030C1")]
	private sealed class _003CUpdateClothNewOwnedState_003Ec__AnonStorey7
	{
		[Token(Token = "0x40128BC")]
		[FieldOffset(Offset = "0x8")]
		internal AvatarWardrobeData cloth;

		[Token(Token = "0x60146ED")]
		[Address(RVA = "0x326B9F4", Offset = "0x326B9F4", VA = "0x326B9F4")]
		public _003CUpdateClothNewOwnedState_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x60146EE")]
		[Address(RVA = "0x326B9FC", Offset = "0x326B9FC", VA = "0x326B9FC")]
		internal bool _003C_003Em__0(InventoryClothInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030C2")]
	private sealed class _003CGetValidRankTimesRPCardData_003Ec__AnonStorey8
	{
		[Token(Token = "0x40128BD")]
		[FieldOffset(Offset = "0x8")]
		internal Item item;

		[Token(Token = "0x60146EF")]
		[Address(RVA = "0x326B7C0", Offset = "0x326B7C0", VA = "0x326B7C0")]
		public _003CGetValidRankTimesRPCardData_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x60146F0")]
		[Address(RVA = "0x326B7C8", Offset = "0x326B7C8", VA = "0x326B7C8")]
		internal bool _003C_003Em__0(RankCardData t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030C3")]
	private sealed class _003CGetValidRankNoDeductCardData_003Ec__AnonStorey9
	{
		[Token(Token = "0x40128BE")]
		[FieldOffset(Offset = "0x8")]
		internal Item item;

		[Token(Token = "0x60146F1")]
		[Address(RVA = "0x326B764", Offset = "0x326B764", VA = "0x326B764")]
		public _003CGetValidRankNoDeductCardData_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x60146F2")]
		[Address(RVA = "0x326B76C", Offset = "0x326B76C", VA = "0x326B76C")]
		internal bool _003C_003Em__0(RankCardData t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012871")]
	public const uint PropID_InventoryBagpack = 2u;

	[Token(Token = "0x4012872")]
	public const uint PropID_InventoryNew = 4u;

	[Token(Token = "0x4012873")]
	public const uint PropID_InventoryBagpackChanged = 8u;

	[Token(Token = "0x4012874")]
	public const uint PropID_InventoryTopupNotification = 16u;

	[Token(Token = "0x4012875")]
	public const uint PropID_InventoryInstallmentItems = 32u;

	[Token(Token = "0x4012876")]
	public const uint PropID_InventoryInstallmentItemsChanged = 64u;

	[Token(Token = "0x4012877")]
	public const uint PropID_InventoryFetchLegendClothDesc = 128u;

	[Token(Token = "0x4012878")]
	[FieldOffset(Offset = "0xC")]
	private bool m_isLogin;

	[Token(Token = "0x4012879")]
	[FieldOffset(Offset = "0xD")]
	private bool purchase_flag;

	[Token(Token = "0x401287A")]
	private const string INVENTORY_LOADOUT_KEY = "inventory_loadout";

	[Token(Token = "0x401287B")]
	public const string NORMAL_LOADOUT_GUIDE_KEY = "normal_loadout_guide";

	[Token(Token = "0x401287C")]
	public const string ADVANCE_LOADOUT_GUIDE_KEY = "advance_loadout_guide";

	[Token(Token = "0x401287D")]
	[FieldOffset(Offset = "0xE")]
	private bool m_IsIPMusicValid;

	[Token(Token = "0x401287E")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, ETipsType> InvTypeToTipsMap;

	[Token(Token = "0x401287F")]
	[FieldOffset(Offset = "0x14")]
	public Dictionary<int, ETipsType> clothTypeToTipsMap;

	[Token(Token = "0x4012880")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<uint, SkinTimelineDesc> SkinTimelineDescMap;

	[Token(Token = "0x4012881")]
	[FieldOffset(Offset = "0x1C")]
	public List<uint> PlayedAnimItem;

	[Token(Token = "0x4012882")]
	[FieldOffset(Offset = "0x20")]
	private CSGetBackpackRes _003CBackpackData_003Ek__BackingField;

	[Token(Token = "0x4012883")]
	[FieldOffset(Offset = "0x24")]
	private Item[] _003CNewInventories_003Ek__BackingField;

	[Token(Token = "0x4012884")]
	[FieldOffset(Offset = "0x28")]
	public Dictionary<int, ResourceID> DictBGMPath;

	[Token(Token = "0x4012885")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, InventoryItemInfo> m_dicCacheNewInventories;

	[Token(Token = "0x4012886")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<uint, Dictionary<uint, LegendClothUnlockDesc>> DictLegendClothLevelConfigs;

	[Token(Token = "0x4012887")]
	[FieldOffset(Offset = "0x34")]
	private List<uint> m_SelectedLoadouts;

	[Token(Token = "0x4012888")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<int, List<CSSharedAvatarData>> m_DictBackpackAvatar;

	[Token(Token = "0x4012889")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<int, List<InventoryClothInfo>> m_DictBackpackCloth;

	[Token(Token = "0x401288A")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<uint, Item> m_DictFaceInfo;

	[Token(Token = "0x401288B")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<uint, Item> m_DictClothInfo;

	[Token(Token = "0x401288C")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<uint, Item> m_DictLoadoutInfo;

	[Token(Token = "0x401288D")]
	[FieldOffset(Offset = "0x4C")]
	private Dictionary<uint, Item> m_DictTreasureBoxInfo;

	[Token(Token = "0x401288E")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<uint, Item> m_DictDebrisInfo;

	[Token(Token = "0x401288F")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<uint, Item> m_DictBundleInfo;

	[Token(Token = "0x4012890")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<uint, Item> m_DictExchangeCurrency;

	[Token(Token = "0x4012891")]
	[FieldOffset(Offset = "0x5C")]
	private Dictionary<uint, Item> m_DictGrowthCardInfo;

	[Token(Token = "0x4012892")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<uint, Item> m_DictRoomCardInfo;

	[Token(Token = "0x4012893")]
	[FieldOffset(Offset = "0x64")]
	private readonly List<Item> m_RankTimesRPCardList;

	[Token(Token = "0x4012894")]
	[FieldOffset(Offset = "0x68")]
	private readonly List<Item> m_RankNoDeductCardList;

	[Token(Token = "0x4012895")]
	[FieldOffset(Offset = "0x6C")]
	private Dictionary<uint, Item> m_dicAllBackPackIter;

	[Token(Token = "0x4012896")]
	[FieldOffset(Offset = "0x70")]
	private HashSet<uint> m_BackpackItemIDCache;

	[Token(Token = "0x4012897")]
	[FieldOffset(Offset = "0x74")]
	private List<Item> m_SortedLoadoutList;

	[Token(Token = "0x4012898")]
	[FieldOffset(Offset = "0x78")]
	private List<Item> m_SortedOldLoadoutList;

	[Token(Token = "0x4012899")]
	[FieldOffset(Offset = "0x7C")]
	private List<Item> m_SortedNewLoadoutList;

	[Token(Token = "0x401289A")]
	[FieldOffset(Offset = "0x80")]
	private List<Item> m_SortedGrowthCardList;

	[Token(Token = "0x401289B")]
	[FieldOffset(Offset = "0x84")]
	private List<Item> m_PlayCardList;

	[Token(Token = "0x401289C")]
	[FieldOffset(Offset = "0x88")]
	private List<Item> m_ShowInInventoryPropList;

	[Token(Token = "0x401289D")]
	[FieldOffset(Offset = "0x8C")]
	private List<InventoryTopupNtf> _TopupNotifications;

	[Token(Token = "0x401289E")]
	[FieldOffset(Offset = "0x90")]
	private List<int> m_PendingRequest;

	[Token(Token = "0x401289F")]
	[FieldOffset(Offset = "0x94")]
	private List<Item> m_InstallmentItemsList;

	[Token(Token = "0x40128A0")]
	[FieldOffset(Offset = "0x98")]
	private List<Item> m_ReminderItemsList;

	[Token(Token = "0x40128A1")]
	[FieldOffset(Offset = "0x9C")]
	private List<Item> m_GachaCouponList;

	[Token(Token = "0x40128A2")]
	[FieldOffset(Offset = "0xA0")]
	private List<uint> m_CacheLimitAvatar;

	[Token(Token = "0x40128A3")]
	[FieldOffset(Offset = "0xA4")]
	private uint _003CChipCount_003Ek__BackingField;

	[Token(Token = "0x40128A4")]
	[FieldOffset(Offset = "0xA8")]
	public bool NeedShowLegendVaultColorTip;

	[Token(Token = "0x40128A5")]
	[FieldOffset(Offset = "0xAC")]
	private Dictionary<uint, RandomSlotInfo> m_dicRandSlotInfos;

	[Token(Token = "0x40128A6")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_bRandomSkinSwitch;

	[Token(Token = "0x40128A7")]
	public const uint LegendCloth_UnlockDesc_ConfigLevel = 1u;

	[Token(Token = "0x40128A8")]
	[FieldOffset(Offset = "0x0")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40128A9")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<Item> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x40128AA")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<Item> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x40128AB")]
	[FieldOffset(Offset = "0xC")]
	private static Comparison<Item> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x40128AC")]
	[FieldOffset(Offset = "0x10")]
	private static Comparison<Item> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x40128AD")]
	[FieldOffset(Offset = "0x14")]
	private static Func<uint, string> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x40128AE")]
	[FieldOffset(Offset = "0x18")]
	private static Converter<BundleShowData, uint> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x40128AF")]
	[FieldOffset(Offset = "0x1C")]
	private static Predicate<Item> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x40128B0")]
	[FieldOffset(Offset = "0x20")]
	private static Predicate<Item> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x40128B1")]
	[FieldOffset(Offset = "0x24")]
	private static Predicate<Item> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x40128B2")]
	[FieldOffset(Offset = "0x28")]
	private static Predicate<Item> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x17001532")]
	public CSGetBackpackRes BackpackData
	{
		[Token(Token = "0x6014644")]
		[Address(RVA = "0x12C67A0", Offset = "0x12C67A0", VA = "0x12C67A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014645")]
		[Address(RVA = "0x12C67A8", Offset = "0x12C67A8", VA = "0x12C67A8")]
		private set
		{
		}
	}

	[Token(Token = "0x17001533")]
	public Item[] NewInventories
	{
		[Token(Token = "0x6014646")]
		[Address(RVA = "0x12C67B0", Offset = "0x12C67B0", VA = "0x12C67B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014647")]
		[Address(RVA = "0x12C67B8", Offset = "0x12C67B8", VA = "0x12C67B8")]
		private set
		{
		}
	}

	[Token(Token = "0x17001534")]
	public List<InventoryTopupNtf> TopupNotifications
	{
		[Token(Token = "0x6014649")]
		[Address(RVA = "0x12C6818", Offset = "0x12C6818", VA = "0x12C6818")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001535")]
	public List<Item> GachaCouponList
	{
		[Token(Token = "0x601464A")]
		[Address(RVA = "0x12C6870", Offset = "0x12C6870", VA = "0x12C6870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001536")]
	public List<uint> CacheLimitAvatar
	{
		[Token(Token = "0x601464B")]
		[Address(RVA = "0x12C68C8", Offset = "0x12C68C8", VA = "0x12C68C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001537")]
	public uint ChipCount
	{
		[Token(Token = "0x6014651")]
		[Address(RVA = "0x12C7068", Offset = "0x12C7068", VA = "0x12C7068")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014652")]
		[Address(RVA = "0x12C7070", Offset = "0x12C7070", VA = "0x12C7070")]
		private set
		{
		}
	}

	[Token(Token = "0x6014642")]
	[Address(RVA = "0x12C5A54", Offset = "0x12C5A54", VA = "0x12C5A54")]
	public UIModelInventory()
	{
	}

	[Token(Token = "0x6014643")]
	[Address(RVA = "0x12C6748", Offset = "0x12C6748", VA = "0x12C6748", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014648")]
	[Address(RVA = "0x12C67C0", Offset = "0x12C67C0", VA = "0x12C67C0")]
	public List<uint> SelectedLoadouts()
	{
		return null;
	}

	[Token(Token = "0x601464C")]
	[Address(RVA = "0x12C6920", Offset = "0x12C6920", VA = "0x12C6920")]
	public SkinTimelineDesc GetIPMusicDesc()
	{
		return null;
	}

	[Token(Token = "0x601464D")]
	[Address(RVA = "0x12C6A24", Offset = "0x12C6A24", VA = "0x12C6A24")]
	public string GetSkinTimeLineResConf1Name(InventorySkinTimelineType type)
	{
		return null;
	}

	[Token(Token = "0x601464E")]
	[Address(RVA = "0x12C6B70", Offset = "0x12C6B70", VA = "0x12C6B70")]
	public void UpdateIsIPMusicValid()
	{
	}

	[Token(Token = "0x601464F")]
	[Address(RVA = "0x12C7010", Offset = "0x12C7010", VA = "0x12C7010")]
	public bool IfIPMusicConfigValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6014650")]
	[Address(RVA = "0x12C6D70", Offset = "0x12C6D70", VA = "0x12C6D70")]
	public ResourceID GetIPMusicResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6014653")]
	[Address(RVA = "0x12C7078", Offset = "0x12C7078", VA = "0x12C7078", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6014654")]
	[Address(RVA = "0x12C73A4", Offset = "0x12C73A4", VA = "0x12C73A4", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014655")]
	[Address(RVA = "0x12C7604", Offset = "0x12C7604", VA = "0x12C7604")]
	public void OnTopupNtf(List<InventoryTopupNtf> topupNtfs)
	{
	}

	[Token(Token = "0x6014656")]
	[Address(RVA = "0x12C77F4", Offset = "0x12C77F4", VA = "0x12C77F4")]
	public void RequestWallet(bool isRebateCard)
	{
	}

	[Token(Token = "0x6014657")]
	[Address(RVA = "0x12C7B28", Offset = "0x12C7B28", VA = "0x12C7B28")]
	public void RequestBackpack(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014658")]
	[Address(RVA = "0x12C7E64", Offset = "0x12C7E64", VA = "0x12C7E64")]
	public void RequestLegendClothDesc(uint legendClothId = 0u, bool forceReq = false, uint httpOp = 0u)
	{
	}

	[Token(Token = "0x6014659")]
	[Address(RVA = "0x12C828C", Offset = "0x12C828C", VA = "0x12C828C")]
	private void RefreshLegendClothDesc(CSGetLegendClothesDescRes res, bool refreshAll)
	{
	}

	[Token(Token = "0x601465A")]
	[Address(RVA = "0x12C85B0", Offset = "0x12C85B0", VA = "0x12C85B0")]
	public List<uint> GetLegendClothSetList()
	{
		return null;
	}

	[Token(Token = "0x601465B")]
	[Address(RVA = "0x12C81AC", Offset = "0x12C81AC", VA = "0x12C81AC")]
	public Dictionary<uint, LegendClothUnlockDesc> GetLegendClothConfigSetDict(uint legendId)
	{
		return null;
	}

	[Token(Token = "0x601465C")]
	[Address(RVA = "0x12C8850", Offset = "0x12C8850", VA = "0x12C8850")]
	public LegendClothUnlockDesc GetLegendClothUnlockDesc(uint legendId, uint level)
	{
		return null;
	}

	[Token(Token = "0x601465D")]
	[Address(RVA = "0x12C894C", Offset = "0x12C894C", VA = "0x12C894C")]
	public void RequestInstallmentItems(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x601465E")]
	[Address(RVA = "0x12C8BE8", Offset = "0x12C8BE8", VA = "0x12C8BE8")]
	private void LockOverDueAvatar()
	{
	}

	[Token(Token = "0x601465F")]
	[Address(RVA = "0x12C8F84", Offset = "0x12C8F84", VA = "0x12C8F84")]
	public bool CheckLimitIsOwned(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014660")]
	[Address(RVA = "0x12C9268", Offset = "0x12C9268", VA = "0x12C9268")]
	public bool CheckRealIsOwend(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014661")]
	[Address(RVA = "0x12C94B4", Offset = "0x12C94B4", VA = "0x12C94B4")]
	public bool IsItemUnique(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014662")]
	[Address(RVA = "0x12C92F0", Offset = "0x12C92F0", VA = "0x12C92F0")]
	public bool CheckIsOwned(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014663")]
	[Address(RVA = "0x12C969C", Offset = "0x12C969C", VA = "0x12C969C")]
	public bool CheckIsUniqueAndOwned(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014664")]
	[Address(RVA = "0x12C9870", Offset = "0x12C9870", VA = "0x12C9870")]
	private bool CheckHasUsingLockItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6014665")]
	[Address(RVA = "0x12C9D78", Offset = "0x12C9D78", VA = "0x12C9D78")]
	public Dictionary<uint, Item> GetLoadOutDictInfo()
	{
		return null;
	}

	[Token(Token = "0x6014666")]
	[Address(RVA = "0x12C9DD0", Offset = "0x12C9DD0", VA = "0x12C9DD0")]
	public Dictionary<uint, Item> GetTreasureboxDictInfo()
	{
		return null;
	}

	[Token(Token = "0x6014667")]
	[Address(RVA = "0x12C9E28", Offset = "0x12C9E28", VA = "0x12C9E28")]
	public Dictionary<uint, Item> GetFaceDictInfo()
	{
		return null;
	}

	[Token(Token = "0x6014668")]
	[Address(RVA = "0x12C9E80", Offset = "0x12C9E80", VA = "0x12C9E80")]
	public Dictionary<uint, Item> GetClothDictInfo()
	{
		return null;
	}

	[Token(Token = "0x6014669")]
	[Address(RVA = "0x12C9ED8", Offset = "0x12C9ED8", VA = "0x12C9ED8")]
	public Item GetClothinfoByItemID(uint id)
	{
		return null;
	}

	[Token(Token = "0x601466A")]
	[Address(RVA = "0x12C9FC0", Offset = "0x12C9FC0", VA = "0x12C9FC0")]
	public Dictionary<uint, Item> GetBundleDictInfo()
	{
		return null;
	}

	[Token(Token = "0x601466B")]
	[Address(RVA = "0x12CA018", Offset = "0x12CA018", VA = "0x12CA018")]
	public Dictionary<uint, Item> GetRoomCardDictInfo()
	{
		return null;
	}

	[Token(Token = "0x601466C")]
	[Address(RVA = "0x12CA070", Offset = "0x12CA070", VA = "0x12CA070")]
	public Dictionary<uint, Item> GetExchangeCurrencyInfo()
	{
		return null;
	}

	[Token(Token = "0x601466D")]
	[Address(RVA = "0x12CA0C8", Offset = "0x12CA0C8", VA = "0x12CA0C8")]
	public Dictionary<uint, Item> GetDebrisDictInfo()
	{
		return null;
	}

	[Token(Token = "0x601466E")]
	[Address(RVA = "0x12CA120", Offset = "0x12CA120", VA = "0x12CA120")]
	public Dictionary<uint, Item> GetGrowthCardDictInfo()
	{
		return null;
	}

	[Token(Token = "0x601466F")]
	[Address(RVA = "0x12CA178", Offset = "0x12CA178", VA = "0x12CA178")]
	public void UpdateReminderItems(InventoryChangeMessage res)
	{
	}

	[Token(Token = "0x6014670")]
	[Address(RVA = "0x12CA398", Offset = "0x12CA398", VA = "0x12CA398")]
	public void UpdateInstallmentsInfo(InventoryChangeMessage res, tcp.EInventory.Proto type)
	{
	}

	[Token(Token = "0x6014671")]
	[Address(RVA = "0x12CAFA4", Offset = "0x12CAFA4", VA = "0x12CAFA4")]
	public void UpdateBackPackInfo(InventoryChangeMessage res)
	{
	}

	[Token(Token = "0x6014672")]
	[Address(RVA = "0x12CDDB4", Offset = "0x12CDDB4", VA = "0x12CDDB4")]
	public bool IsNewGetByItemID(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014673")]
	[Address(RVA = "0x12CDE80", Offset = "0x12CDE80", VA = "0x12CDE80")]
	public InventoryItemInfo FindItemInCacheNewInventory(uint itemID)
	{
		return null;
	}

	[Token(Token = "0x6014674")]
	[Address(RVA = "0x12CB8E0", Offset = "0x12CB8E0", VA = "0x12CB8E0")]
	private void UpdateCachedNewInventory(Item it, [Optional] Item origItem)
	{
	}

	[Token(Token = "0x6014675")]
	[Address(RVA = "0x12CBFF0", Offset = "0x12CBFF0", VA = "0x12CBFF0")]
	public void UpdateBackPackInfo(CSGetBackpackRes res, bool isTcpNtf = false)
	{
	}

	[Token(Token = "0x6014676")]
	[Address(RVA = "0x12CEB9C", Offset = "0x12CEB9C", VA = "0x12CEB9C")]
	public bool IsOpenMutliSelectFunction()
	{
		return default(bool);
	}

	[Token(Token = "0x6014677")]
	[Address(RVA = "0x12CEC30", Offset = "0x12CEC30", VA = "0x12CEC30")]
	public void ProcessCSGetRandomSkinSwitchDescRes(RandomSkinSwitchDesc resRandomSkinSwitch)
	{
	}

	[Token(Token = "0x6014678")]
	[Address(RVA = "0x12CEC9C", Offset = "0x12CEC9C", VA = "0x12CEC9C")]
	public Dictionary<uint, RandomSlotInfo> GetRandomSlotInfos()
	{
		return null;
	}

	[Token(Token = "0x6014679")]
	[Address(RVA = "0x12CE970", Offset = "0x12CE970", VA = "0x12CE970")]
	public void RefreshRandomSlots()
	{
	}

	[Token(Token = "0x601467A")]
	[Address(RVA = "0x12CED6C", Offset = "0x12CED6C", VA = "0x12CED6C")]
	public RandomSlotInfo GetRandomSlotInfoBySlotIndex(uint slotIndex)
	{
		return null;
	}

	[Token(Token = "0x601467B")]
	[Address(RVA = "0x12CEE54", Offset = "0x12CEE54", VA = "0x12CEE54")]
	public proto.EInventory.SlotChooseType GetMutliSelectChooseType(uint slotIndex)
	{
		return default(proto.EInventory.SlotChooseType);
	}

	[Token(Token = "0x601467C")]
	[Address(RVA = "0x12CEECC", Offset = "0x12CEECC", VA = "0x12CEECC")]
	public bool IsMutliSelectEquipedBySkinID(int skinID, int slotIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x601467D")]
	[Address(RVA = "0x12CF028", Offset = "0x12CF028", VA = "0x12CF028")]
	public bool IsValidLoadout(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x601467E")]
	[Address(RVA = "0x12CF2F4", Offset = "0x12CF2F4", VA = "0x12CF2F4")]
	public bool CanUsePlayCard(Item PlayCardData)
	{
		return default(bool);
	}

	[Token(Token = "0x601467F")]
	[Address(RVA = "0x12CF408", Offset = "0x12CF408", VA = "0x12CF408")]
	public void ChooseLoadOut(uint itemIdold, uint itemIdnew, bool v = false)
	{
	}

	[Token(Token = "0x6014680")]
	[Address(RVA = "0x12CE668", Offset = "0x12CE668", VA = "0x12CE668")]
	private void UpdateSelectedLoadouts(List<proto.LoadoutInfo> selectedinfo)
	{
	}

	[Token(Token = "0x6014681")]
	[Address(RVA = "0x12CBBBC", Offset = "0x12CBBBC", VA = "0x12CBBBC")]
	public void UpdateNewInventories()
	{
	}

	[Token(Token = "0x6014682")]
	[Address(RVA = "0x12CFB60", Offset = "0x12CFB60", VA = "0x12CFB60")]
	public Item FindItemByID(uint id)
	{
		return null;
	}

	[Token(Token = "0x6014683")]
	[Address(RVA = "0x12C9118", Offset = "0x12C9118", VA = "0x12C9118")]
	public Item GetItemById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x6014684")]
	[Address(RVA = "0x12CFC48", Offset = "0x12CFC48", VA = "0x12CFC48")]
	public Item GetInstallmentItemById(uint id)
	{
		return null;
	}

	[Token(Token = "0x6014685")]
	[Address(RVA = "0x12BAF0C", Offset = "0x12BAF0C", VA = "0x12BAF0C")]
	public int GetItemCount(uint iid)
	{
		return default(int);
	}

	[Token(Token = "0x6014686")]
	[Address(RVA = "0x12CFD90", Offset = "0x12CFD90", VA = "0x12CFD90")]
	public int GetTotalItemCount(IEnumerable<uint> idList)
	{
		return default(int);
	}

	[Token(Token = "0x6014687")]
	[Address(RVA = "0x12CF0D0", Offset = "0x12CF0D0", VA = "0x12CF0D0")]
	public Item GetPlayCardById(uint id)
	{
		return null;
	}

	[Token(Token = "0x6014688")]
	[Address(RVA = "0x12CFF70", Offset = "0x12CFF70", VA = "0x12CFF70")]
	public bool IsInstallmentItem(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014689")]
	[Address(RVA = "0x12CFFE8", Offset = "0x12CFFE8", VA = "0x12CFFE8")]
	public bool IsInstallmentItem(Item item)
	{
		return default(bool);
	}

	[Token(Token = "0x601468A")]
	[Address(RVA = "0x12D0064", Offset = "0x12D0064", VA = "0x12D0064")]
	public bool IsReminderItem(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x601468B")]
	[Address(RVA = "0x12D00F0", Offset = "0x12D00F0", VA = "0x12D00F0")]
	public Item FindReminderItemByID(uint id)
	{
		return null;
	}

	[Token(Token = "0x601468C")]
	[Address(RVA = "0x12CB7AC", Offset = "0x12CB7AC", VA = "0x12CB7AC")]
	public void RemoveReminderItem(Item item)
	{
	}

	[Token(Token = "0x601468D")]
	[Address(RVA = "0x12C95D0", Offset = "0x12C95D0", VA = "0x12C95D0")]
	public bool ContainsItemIDInBackpack(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x601468E")]
	[Address(RVA = "0x12D0238", Offset = "0x12D0238", VA = "0x12D0238")]
	public bool IsLockItem(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x601468F")]
	[Address(RVA = "0x12C8F04", Offset = "0x12C8F04", VA = "0x12C8F04")]
	public bool IsLockItem(Item item)
	{
		return default(bool);
	}

	[Token(Token = "0x6014690")]
	[Address(RVA = "0x12D02B0", Offset = "0x12D02B0", VA = "0x12D02B0")]
	public List<Item> GetSortedLoadoutsList()
	{
		return null;
	}

	[Token(Token = "0x6014691")]
	[Address(RVA = "0x12D0308", Offset = "0x12D0308", VA = "0x12D0308")]
	public List<Item> GetSortedLoadoutsListByType(CSSharedItemDataManager.LoadoutSubType type)
	{
		return null;
	}

	[Token(Token = "0x6014692")]
	[Address(RVA = "0x12D0388", Offset = "0x12D0388", VA = "0x12D0388")]
	public List<Item> GetSortedGrowthCardList()
	{
		return null;
	}

	[Token(Token = "0x6014693")]
	[Address(RVA = "0x12D03E0", Offset = "0x12D03E0", VA = "0x12D03E0")]
	public List<InventoryItemInfo> GetInventoryItemList(List<Item> itemList)
	{
		return null;
	}

	[Token(Token = "0x6014694")]
	[Address(RVA = "0x12D05DC", Offset = "0x12D05DC", VA = "0x12D05DC")]
	public List<Item> GetShowInInventoryPropList()
	{
		return null;
	}

	[Token(Token = "0x6014695")]
	[Address(RVA = "0x12D0634", Offset = "0x12D0634", VA = "0x12D0634")]
	public List<Item> GetInstallmentItemList()
	{
		return null;
	}

	[Token(Token = "0x6014696")]
	[Address(RVA = "0x12D068C", Offset = "0x12D068C", VA = "0x12D068C")]
	public void UpdatePreviewClothItem(InventoryClothInfo cInfo)
	{
	}

	[Token(Token = "0x6014697")]
	[Address(RVA = "0x12D0708", Offset = "0x12D0708", VA = "0x12D0708")]
	public void UpdateClothNewOwnedState(AvatarWardrobeData cloth)
	{
	}

	[Token(Token = "0x6014698")]
	[Address(RVA = "0x12D08FC", Offset = "0x12D08FC", VA = "0x12D08FC")]
	public void ClearClothNewOwnedState(IEnumerable<InventoryClothShowingInfo> infos)
	{
	}

	[Token(Token = "0x6014699")]
	[Address(RVA = "0x12D0EA4", Offset = "0x12D0EA4", VA = "0x12D0EA4")]
	public void RemoveItemsInNewItemCache(IEnumerable<uint> itemIDs, bool updateTipsNum = true)
	{
	}

	[Token(Token = "0x601469A")]
	[Address(RVA = "0x12D0E24", Offset = "0x12D0E24", VA = "0x12D0E24")]
	public void RemoveItemInNewItemCache(uint itemID)
	{
	}

	[Token(Token = "0x601469B")]
	[Address(RVA = "0x12CE220", Offset = "0x12CE220", VA = "0x12CE220")]
	public void RemoveItemInNewItemCache(InventoryItemInfo info)
	{
	}

	[Token(Token = "0x601469C")]
	[Address(RVA = "0x12D121C", Offset = "0x12D121C", VA = "0x12D121C")]
	public void UpdateAllTipsNum()
	{
	}

	[Token(Token = "0x601469D")]
	[Address(RVA = "0x12D1364", Offset = "0x12D1364", VA = "0x12D1364")]
	public void UpdateTreasureBoxTipsNum()
	{
	}

	[Token(Token = "0x601469E")]
	[Address(RVA = "0x12D13C8", Offset = "0x12D13C8", VA = "0x12D13C8")]
	public void UpdateBundleTipsNum()
	{
	}

	[Token(Token = "0x601469F")]
	[Address(RVA = "0x12D142C", Offset = "0x12D142C", VA = "0x12D142C")]
	public void UpdateGrowthCardTipsNum()
	{
	}

	[Token(Token = "0x60146A0")]
	[Address(RVA = "0x12CDF68", Offset = "0x12CDF68", VA = "0x12CDF68")]
	private void UpdateTipsNum(InventoryItemInfo infoInNewCache, int num)
	{
	}

	[Token(Token = "0x60146A1")]
	[Address(RVA = "0x12D18FC", Offset = "0x12D18FC", VA = "0x12D18FC")]
	public void UpdateTipsNum(uint itemID)
	{
	}

	[Token(Token = "0x60146A2")]
	[Address(RVA = "0x12D1984", Offset = "0x12D1984", VA = "0x12D1984")]
	public bool IsItemOwn(uint item_id)
	{
		return default(bool);
	}

	[Token(Token = "0x60146A3")]
	[Address(RVA = "0x12D1ABC", Offset = "0x12D1ABC", VA = "0x12D1ABC")]
	public bool CheckBundleOwned(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x60146A4")]
	[Address(RVA = "0x12D1C00", Offset = "0x12D1C00", VA = "0x12D1C00")]
	public bool BundleContainsItemAllOwned(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x60146A5")]
	[Address(RVA = "0x12CA260", Offset = "0x12CA260", VA = "0x12CA260")]
	public void UpdateReminderTipsNum()
	{
	}

	[Token(Token = "0x60146A6")]
	[Address(RVA = "0x12D1858", Offset = "0x12D1858", VA = "0x12D1858")]
	public bool CheckIsAvaliableItem(InventoryItemInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x60146A7")]
	[Address(RVA = "0x12D232C", Offset = "0x12D232C", VA = "0x12D232C")]
	public bool CheckIsAvaliableCloth(InventoryItemInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x60146A8")]
	[Address(RVA = "0x12CE38C", Offset = "0x12CE38C", VA = "0x12CE38C")]
	public bool IsShowInInventoryPropItem(InventoryItemInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x60146A9")]
	[Address(RVA = "0x12D1748", Offset = "0x12D1748", VA = "0x12D1748")]
	public ETipsType GetTipsType(InventoryItemInfo info)
	{
		return default(ETipsType);
	}

	[Token(Token = "0x60146AA")]
	[Address(RVA = "0x12D2578", Offset = "0x12D2578", VA = "0x12D2578")]
	public ETipsType GetTipsType(UIModelAvatarBase.EWardrobeType wType)
	{
		return default(ETipsType);
	}

	[Token(Token = "0x60146AB")]
	[Address(RVA = "0x12D26A0", Offset = "0x12D26A0", VA = "0x12D26A0")]
	public ETipsType GetTipsType(CSSharedItemDataManager.ItemType itemType)
	{
		return default(ETipsType);
	}

	[Token(Token = "0x60146AC")]
	[Address(RVA = "0x12D1294", Offset = "0x12D1294", VA = "0x12D1294")]
	public void UpdateAllClothTipsNum()
	{
	}

	[Token(Token = "0x60146AD")]
	[Address(RVA = "0x12D1490", Offset = "0x12D1490", VA = "0x12D1490")]
	public void UpdateTipsNum(CSSharedItemDataManager.ItemType itType)
	{
	}

	[Token(Token = "0x60146AE")]
	[Address(RVA = "0x12D27C8", Offset = "0x12D27C8", VA = "0x12D27C8")]
	public void UpdateTipsNum(UIModelAvatarBase.EWardrobeType wType)
	{
	}

	[Token(Token = "0x60146AF")]
	[Address(RVA = "0x12D2860", Offset = "0x12D2860", VA = "0x12D2860")]
	public int GetTipNum(UIModelAvatarBase.EWardrobeType wType, bool legendOnly = false)
	{
		return default(int);
	}

	[Token(Token = "0x60146B0")]
	[Address(RVA = "0x12CB684", Offset = "0x12CB684", VA = "0x12CB684")]
	private void SetTipsNum(ETipsType tipsType, int number = 0)
	{
	}

	[Token(Token = "0x60146B1")]
	[Address(RVA = "0x12D2130", Offset = "0x12D2130", VA = "0x12D2130")]
	public bool HaveOwnedPermanetUniqueItem(uint id, bool checkInstallment = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60146B2")]
	[Address(RVA = "0x12D2BD8", Offset = "0x12D2BD8", VA = "0x12D2BD8")]
	public bool HasRoomCard(proto.EInventory.ItemSubType type)
	{
		return default(bool);
	}

	[Token(Token = "0x60146B3")]
	[Address(RVA = "0x12D2EC0", Offset = "0x12D2EC0", VA = "0x12D2EC0")]
	public uint GetRoomCardCount(proto.EInventory.ItemSubType type)
	{
		return default(uint);
	}

	[Token(Token = "0x60146B4")]
	[Address(RVA = "0x12D30BC", Offset = "0x12D30BC", VA = "0x12D30BC")]
	public uint GetRoomCardExpiredTime(proto.EInventory.ItemSubType type)
	{
		return default(uint);
	}

	[Token(Token = "0x60146B5")]
	[Address(RVA = "0x12D32B8", Offset = "0x12D32B8", VA = "0x12D32B8")]
	public bool HasLimitedRoomCard(proto.EInventory.ItemSubType type)
	{
		return default(bool);
	}

	[Token(Token = "0x60146B6")]
	[Address(RVA = "0x12D33AC", Offset = "0x12D33AC", VA = "0x12D33AC")]
	public int SortRankCardItemByExpireTime(Item a, Item b)
	{
		return default(int);
	}

	[Token(Token = "0x60146B7")]
	[Address(RVA = "0x12D348C", Offset = "0x12D348C", VA = "0x12D348C")]
	public RankCardData GetValidRankTimesRPCardData()
	{
		return null;
	}

	[Token(Token = "0x60146B8")]
	[Address(RVA = "0x12D3914", Offset = "0x12D3914", VA = "0x12D3914")]
	public RankCardData GetValidRankNoDeductCardData()
	{
		return null;
	}

	[Token(Token = "0x60146B9")]
	[Address(RVA = "0x12D3680", Offset = "0x12D3680", VA = "0x12D3680")]
	public Item GetValidRankTimesRPCardItem()
	{
		return null;
	}

	[Token(Token = "0x60146BA")]
	[Address(RVA = "0x12D3B08", Offset = "0x12D3B08", VA = "0x12D3B08")]
	public Item GetValidRankNoDeductCardItem()
	{
		return null;
	}

	[Token(Token = "0x60146BB")]
	[Address(RVA = "0x12D3D9C", Offset = "0x12D3D9C", VA = "0x12D3D9C")]
	public List<Item> GetValidRankNoDeductCardItemList()
	{
		return null;
	}

	[Token(Token = "0x60146BC")]
	[Address(RVA = "0x12D4030", Offset = "0x12D4030", VA = "0x12D4030")]
	public List<Item> GetValidRankTiemsRPCardItemList()
	{
		return null;
	}

	[Token(Token = "0x60146BD")]
	[Address(RVA = "0x12D42C4", Offset = "0x12D42C4", VA = "0x12D42C4")]
	public int GetValidRankNoDeductCardItemListCnt()
	{
		return default(int);
	}

	[Token(Token = "0x60146BE")]
	[Address(RVA = "0x12D44A0", Offset = "0x12D44A0", VA = "0x12D44A0")]
	public int GetValidRankTiemsRPCardItemListCnt()
	{
		return default(int);
	}

	[Token(Token = "0x60146BF")]
	[Address(RVA = "0x12D467C", Offset = "0x12D467C", VA = "0x12D467C")]
	public void SetPurchaseFlag(bool state)
	{
	}

	[Token(Token = "0x60146C0")]
	[Address(RVA = "0x12D46DC", Offset = "0x12D46DC", VA = "0x12D46DC")]
	public bool GetPurchaseFlag()
	{
		return default(bool);
	}

	[Token(Token = "0x60146C1")]
	[Address(RVA = "0x12D4734", Offset = "0x12D4734", VA = "0x12D4734")]
	public void ProcessSkinTimelineDescRes(CSSkinTimelineDescRes data)
	{
	}

	[Token(Token = "0x60146C2")]
	[Address(RVA = "0x12D4BA0", Offset = "0x12D4BA0", VA = "0x12D4BA0")]
	public List<ChoosedEmote> GetCurEquipEmote()
	{
		return null;
	}

	[Token(Token = "0x60146C3")]
	[Address(RVA = "0x12D4C20", Offset = "0x12D4C20", VA = "0x12D4C20")]
	public uint GetEmoteIndex(uint emoteID)
	{
		return default(uint);
	}

	[Token(Token = "0x60146C4")]
	[Address(RVA = "0x12D4E24", Offset = "0x12D4E24", VA = "0x12D4E24")]
	public uint GetCurEmoteByIndex(uint slotIndex)
	{
		return default(uint);
	}

	[Token(Token = "0x60146C5")]
	[Address(RVA = "0x12D5028", Offset = "0x12D5028", VA = "0x12D5028")]
	public uint[] GetCurSlot()
	{
		return null;
	}

	[Token(Token = "0x60146C6")]
	[Address(RVA = "0x12CECF4", Offset = "0x12CECF4", VA = "0x12CECF4")]
	public List<RandomSlotInfo> GetCurRandomSlot()
	{
		return null;
	}

	[Token(Token = "0x60146C7")]
	[Address(RVA = "0x12D50A0", Offset = "0x12D50A0", VA = "0x12D50A0")]
	public bool NeedDownloadLegendClothResByLegendId(uint legendId)
	{
		return default(bool);
	}

	[Token(Token = "0x60146C8")]
	[Address(RVA = "0x12D517C", Offset = "0x12D517C", VA = "0x12D517C")]
	public List<ResourceID> GetLegendClothNeedDownloadResListByLegendId(uint legendId)
	{
		return null;
	}

	[Token(Token = "0x60146C9")]
	[Address(RVA = "0x12D5D2C", Offset = "0x12D5D2C", VA = "0x12D5D2C")]
	private static void _003CRequestWallet_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60146CA")]
	[Address(RVA = "0x12D5F9C", Offset = "0x12D5F9C", VA = "0x12D5F9C")]
	private void _003CRequestBackpack_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60146CB")]
	[Address(RVA = "0x12D6404", Offset = "0x12D6404", VA = "0x12D6404")]
	private void _003CRequestInstallmentItems_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60146CC")]
	[Address(RVA = "0x12D67A8", Offset = "0x12D67A8", VA = "0x12D67A8")]
	private static int _003CUpdateBackPackInfo_003Em__3(Item a, Item b)
	{
		return default(int);
	}

	[Token(Token = "0x60146CD")]
	[Address(RVA = "0x12D67F0", Offset = "0x12D67F0", VA = "0x12D67F0")]
	private static int _003CUpdateBackPackInfo_003Em__4(Item a, Item b)
	{
		return default(int);
	}

	[Token(Token = "0x60146CE")]
	[Address(RVA = "0x12D6838", Offset = "0x12D6838", VA = "0x12D6838")]
	private static int _003CUpdateBackPackInfo_003Em__5(Item a, Item b)
	{
		return default(int);
	}

	[Token(Token = "0x60146CF")]
	[Address(RVA = "0x12D6880", Offset = "0x12D6880", VA = "0x12D6880")]
	private static int _003CUpdateBackPackInfo_003Em__6(Item a, Item b)
	{
		return default(int);
	}

	[Token(Token = "0x60146D0")]
	[Address(RVA = "0x12D68DC", Offset = "0x12D68DC", VA = "0x12D68DC")]
	private bool _003CChooseLoadOut_003Em__7(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x60146D1")]
	[Address(RVA = "0x12D68E0", Offset = "0x12D68E0", VA = "0x12D68E0")]
	private void _003CChooseLoadOut_003Em__8(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60146D2")]
	[Address(RVA = "0x12D6A04", Offset = "0x12D6A04", VA = "0x12D6A04")]
	private static string _003CUpdateSelectedLoadouts_003Em__9(uint iid)
	{
		return null;
	}

	[Token(Token = "0x60146D3")]
	[Address(RVA = "0x12D6A28", Offset = "0x12D6A28", VA = "0x12D6A28")]
	private bool _003CUpdateNewInventories_003Em__A(Item it)
	{
		return default(bool);
	}

	[Token(Token = "0x60146D4")]
	[Address(RVA = "0x12D6ACC", Offset = "0x12D6ACC", VA = "0x12D6ACC")]
	private bool _003CUpdateNewInventories_003Em__B(Item it)
	{
		return default(bool);
	}

	[Token(Token = "0x60146D5")]
	[Address(RVA = "0x12D6B70", Offset = "0x12D6B70", VA = "0x12D6B70")]
	private bool _003CUpdateNewInventories_003Em__C(Item it)
	{
		return default(bool);
	}

	[Token(Token = "0x60146D6")]
	[Address(RVA = "0x12D6C14", Offset = "0x12D6C14", VA = "0x12D6C14")]
	private static uint _003CBundleContainsItemAllOwned_003Em__D(BundleShowData item)
	{
		return default(uint);
	}

	[Token(Token = "0x60146D7")]
	[Address(RVA = "0x12D6C38", Offset = "0x12D6C38", VA = "0x12D6C38")]
	private static bool _003CGetValidRankTimesRPCardItem_003Em__E(Item t)
	{
		return default(bool);
	}

	[Token(Token = "0x60146D8")]
	[Address(RVA = "0x12D6D7C", Offset = "0x12D6D7C", VA = "0x12D6D7C")]
	private static bool _003CGetValidRankNoDeductCardItem_003Em__F(Item t)
	{
		return default(bool);
	}

	[Token(Token = "0x60146D9")]
	[Address(RVA = "0x12D6EC0", Offset = "0x12D6EC0", VA = "0x12D6EC0")]
	private static bool _003CGetValidRankNoDeductCardItemList_003Em__10(Item t)
	{
		return default(bool);
	}

	[Token(Token = "0x60146DA")]
	[Address(RVA = "0x12D6FF4", Offset = "0x12D6FF4", VA = "0x12D6FF4")]
	private static bool _003CGetValidRankTiemsRPCardItemList_003Em__11(Item t)
	{
		return default(bool);
	}

	[Token(Token = "0x60146DB")]
	[Address(RVA = "0x12D7128", Offset = "0x12D7128", VA = "0x12D7128")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x60146DC")]
	[Address(RVA = "0x12D7130", Offset = "0x12D7130", VA = "0x12D7130")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
