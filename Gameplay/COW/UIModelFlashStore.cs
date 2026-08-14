using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200302C")]
public class UIModelFlashStore : UIBaseModel
{
	[Token(Token = "0x200302D")]
	public enum FlashStoreState
	{
		[Token(Token = "0x40125BB")]
		Unknown,
		[Token(Token = "0x40125BC")]
		Pre,
		[Token(Token = "0x40125BD")]
		Open,
		[Token(Token = "0x40125BE")]
		Closed
	}

	[Token(Token = "0x200302E")]
	public enum EFlashStoreItemPriceState
	{
		[Token(Token = "0x40125C0")]
		FLASH_GEMS_ONLY,
		[Token(Token = "0x40125C1")]
		FLASH_GEMS_AND_GEMS,
		[Token(Token = "0x40125C2")]
		GEMS_ONLY
	}

	[Token(Token = "0x200302F")]
	public enum ECurrentSelectItemAvailableState
	{
		[Token(Token = "0x40125C4")]
		NO_FLASHGEMS_NO_GEMS,
		[Token(Token = "0x40125C5")]
		NO_FLASHGEMS_HAS_GEMS,
		[Token(Token = "0x40125C6")]
		HAS_FLASHGEMS_NO_GEMS,
		[Token(Token = "0x40125C7")]
		HAS_FLASHGEMS_HAS_GEMS
	}

	[Token(Token = "0x2003030")]
	public enum UILimitedStoreTabType
	{
		[Token(Token = "0x40125C9")]
		MallTabTypeRecommend,
		[Token(Token = "0x40125CA")]
		MallTabTypeCharacter,
		[Token(Token = "0x40125CB")]
		MallTabTypeFashion,
		[Token(Token = "0x40125CC")]
		MallTabTypeWeapon,
		[Token(Token = "0x40125CD")]
		MallTabTypeCollection,
		[Token(Token = "0x40125CE")]
		MallTabTypePet,
		[Token(Token = "0x40125CF")]
		MallTabTypeOther
	}

	[Token(Token = "0x2003031")]
	private sealed class _003CRequestFlashStoreDesc_003Ec__AnonStorey0
	{
		[Token(Token = "0x40125D0")]
		[FieldOffset(Offset = "0x8")]
		internal bool requestInfoAfter;

		[Token(Token = "0x40125D1")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelFlashStore _0024this;

		[Token(Token = "0x6014304")]
		[Address(RVA = "0xFC61A4", Offset = "0xFC61A4", VA = "0xFC61A4")]
		public _003CRequestFlashStoreDesc_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6014305")]
		[Address(RVA = "0xFCC8B8", Offset = "0xFCC8B8", VA = "0xFCC8B8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object result)
		{
		}
	}

	[Token(Token = "0x2003032")]
	private sealed class _003CRequestFlashStorePurchase_003Ec__AnonStorey1
	{
		[Token(Token = "0x40125D2")]
		[FieldOffset(Offset = "0x8")]
		internal FlashStoreGoodsDesc flashStoreItem;

		[Token(Token = "0x40125D3")]
		[FieldOffset(Offset = "0xC")]
		internal uint count;

		[Token(Token = "0x40125D4")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelFlashStore _0024this;

		[Token(Token = "0x6014306")]
		[Address(RVA = "0xFC7B8C", Offset = "0xFC7B8C", VA = "0xFC7B8C")]
		public _003CRequestFlashStorePurchase_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6014307")]
		[Address(RVA = "0xFCC908", Offset = "0xFCC908", VA = "0xFCC908")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6014308")]
		[Address(RVA = "0xFCD0F8", Offset = "0xFCD0F8", VA = "0xFCD0F8")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x40125AD")]
	public const uint PropID_FlashStoreReady = 1u;

	[Token(Token = "0x40125AE")]
	public const uint PropID_FlashStoreDescUpdate = 2u;

	[Token(Token = "0x40125AF")]
	public const uint PropID_FlashStorePurchaseInfoUpdate = 4u;

	[Token(Token = "0x40125B0")]
	public const uint PropID_FlashStoreItemPurchaseSuccess = 8u;

	[Token(Token = "0x40125B1")]
	private const byte STEP1_READY = 1;

	[Token(Token = "0x40125B2")]
	private const byte STEP2_READY = 2;

	[Token(Token = "0x40125B3")]
	private const byte ALL_STEP_READY = 3;

	[Token(Token = "0x40125B4")]
	[FieldOffset(Offset = "0xC")]
	private byte m_ReadyFlag;

	[Token(Token = "0x40125B5")]
	[FieldOffset(Offset = "0x10")]
	private float m_FlashStoreDescRequestGameTime;

	[Token(Token = "0x40125B6")]
	[FieldOffset(Offset = "0x14")]
	private FlashStoreDesc m_FlashStoreDesc;

	[Token(Token = "0x40125B7")]
	[FieldOffset(Offset = "0x18")]
	private readonly List<FlashStoreGoodsDesc> m_FlashStoreGoodsDescList;

	[Token(Token = "0x40125B8")]
	[FieldOffset(Offset = "0x1C")]
	private readonly Dictionary<uint, List<FlashStoreGoodsDesc>> m_FlashStoreItemsDict;

	[Token(Token = "0x40125B9")]
	[FieldOffset(Offset = "0x20")]
	private readonly Dictionary<uint, AccountFlashStorePurchase> m_FlashStorePurchaseInfoDict;

	[Token(Token = "0x170014FC")]
	private bool IsReady
	{
		[Token(Token = "0x60142C2")]
		[Address(RVA = "0xFC57A0", Offset = "0xFC57A0", VA = "0xFC57A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170014FD")]
	private byte ReadyFlag
	{
		[Token(Token = "0x60142C3")]
		[Address(RVA = "0xFC580C", Offset = "0xFC580C", VA = "0xFC580C")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x60142C4")]
		[Address(RVA = "0xFC5864", Offset = "0xFC5864", VA = "0xFC5864")]
		set
		{
		}
	}

	[Token(Token = "0x60142C1")]
	[Address(RVA = "0xFC5680", Offset = "0xFC5680", VA = "0xFC5680")]
	public UIModelFlashStore()
	{
	}

	[Token(Token = "0x60142C5")]
	[Address(RVA = "0xFC5A94", Offset = "0xFC5A94", VA = "0xFC5A94", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60142C6")]
	[Address(RVA = "0xFC5AEC", Offset = "0xFC5AEC", VA = "0xFC5AEC", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x60142C7")]
	[Address(RVA = "0xFC5B50", Offset = "0xFC5B50", VA = "0xFC5B50", Slot = "11")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60142C8")]
	[Address(RVA = "0xFC5BB4", Offset = "0xFC5BB4", VA = "0xFC5BB4", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60142C9")]
	[Address(RVA = "0xFC5CFC", Offset = "0xFC5CFC", VA = "0xFC5CFC")]
	private void RequestFlashStoreDesc(bool silence = true, bool requestInfoAfter = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60142CA")]
	[Address(RVA = "0xFC61AC", Offset = "0xFC61AC", VA = "0xFC61AC")]
	public void RequestFlashStoreDescAfterCertainTime(bool silence = true, bool forceReq = false, float cooldown = 0f)
	{
	}

	[Token(Token = "0x60142CB")]
	[Address(RVA = "0xFC6334", Offset = "0xFC6334", VA = "0xFC6334")]
	private void OnRequestFlashStoreDescFinished(HttpErrorCode errorCode, object result, bool requestInfoAfter)
	{
	}

	[Token(Token = "0x60142CC")]
	[Address(RVA = "0xFC6C0C", Offset = "0xFC6C0C", VA = "0xFC6C0C")]
	private void RequestFlashStoreInfo(bool silence = true)
	{
	}

	[Token(Token = "0x60142CD")]
	[Address(RVA = "0xFC6F40", Offset = "0xFC6F40", VA = "0xFC6F40")]
	private void OnRequestFlashStoreInfoFinished(HttpErrorCode errorCode, object result)
	{
	}

	[Token(Token = "0x60142CE")]
	[Address(RVA = "0xFC77E4", Offset = "0xFC77E4", VA = "0xFC77E4")]
	public void RequestFlashStorePurchase(uint flashStoreActivityID, FlashStoreGoodsDesc flashStoreItem, uint count = 1u, bool silence = true)
	{
	}

	[Token(Token = "0x60142CF")]
	[Address(RVA = "0xFC7C44", Offset = "0xFC7C44", VA = "0xFC7C44")]
	public bool ResendRequestIfPreviousFailed()
	{
		return default(bool);
	}

	[Token(Token = "0x60142D0")]
	[Address(RVA = "0xFC7E88", Offset = "0xFC7E88", VA = "0xFC7E88")]
	public void RequestLobbyMessage(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60142D1")]
	[Address(RVA = "0xFC69B4", Offset = "0xFC69B4", VA = "0xFC69B4")]
	private void SortFlashStoreGoodsList()
	{
	}

	[Token(Token = "0x60142D2")]
	[Address(RVA = "0xFC7F08", Offset = "0xFC7F08", VA = "0xFC7F08")]
	private bool IsFlashStoreActivityMatched(uint flashActivityID)
	{
		return default(bool);
	}

	[Token(Token = "0x60142D3")]
	[Address(RVA = "0xFC7F8C", Offset = "0xFC7F8C", VA = "0xFC7F8C")]
	private bool IsGroupInFlashStoreActivityInternal(uint flashStoreActivityID, uint activityGroupID)
	{
		return default(bool);
	}

	[Token(Token = "0x60142D4")]
	[Address(RVA = "0xFC8228", Offset = "0xFC8228", VA = "0xFC8228")]
	private bool IsActivityGroupOpenInternal(uint flashStoreActivityID, uint activityGroupID)
	{
		return default(bool);
	}

	[Token(Token = "0x60142D5")]
	[Address(RVA = "0xFC8524", Offset = "0xFC8524", VA = "0xFC8524")]
	private FlashStoreState GetFlashStoreStateInternal(uint flashStoreActivityID)
	{
		return default(FlashStoreState);
	}

	[Token(Token = "0x60142D6")]
	[Address(RVA = "0xFC86B8", Offset = "0xFC86B8", VA = "0xFC86B8")]
	private uint GetCurrentFlashStoreActivityIDInternal()
	{
		return default(uint);
	}

	[Token(Token = "0x60142D7")]
	[Address(RVA = "0xFC8724", Offset = "0xFC8724", VA = "0xFC8724")]
	private uint GetFlashStoreIDInternal(uint flashStoreActivityID)
	{
		return default(uint);
	}

	[Token(Token = "0x60142D8")]
	[Address(RVA = "0xFC87B8", Offset = "0xFC87B8", VA = "0xFC87B8")]
	private uint GetFlashGemIDInternal(uint flashStoreActivityID)
	{
		return default(uint);
	}

	[Token(Token = "0x60142D9")]
	[Address(RVA = "0xFC884C", Offset = "0xFC884C", VA = "0xFC884C")]
	private uint[] GetActivityGroupIDArrayInternal(uint flashStoreActivityID)
	{
		return null;
	}

	[Token(Token = "0x60142DA")]
	[Address(RVA = "0xFC8A08", Offset = "0xFC8A08", VA = "0xFC8A08")]
	private FlashStorePeriodInfo GetFlashStorePeriodInfoInternal(uint flashStoreActivityID, uint activityGroupID)
	{
		return null;
	}

	[Token(Token = "0x60142DB")]
	[Address(RVA = "0xFC8BF0", Offset = "0xFC8BF0", VA = "0xFC8BF0")]
	private uint GetGroupTotalFlashGemAmountInternal(uint flashStoreActivityID, uint activityGroupID)
	{
		return default(uint);
	}

	[Token(Token = "0x60142DC")]
	[Address(RVA = "0xFC8DDC", Offset = "0xFC8DDC", VA = "0xFC8DDC")]
	public bool IsSystemAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x60142DD")]
	[Address(RVA = "0xFC8E3C", Offset = "0xFC8E3C", VA = "0xFC8E3C")]
	public bool IsAnyActivityGroupOpen(uint flashStoreActivityID)
	{
		return default(bool);
	}

	[Token(Token = "0x60142DE")]
	[Address(RVA = "0xFC9120", Offset = "0xFC9120", VA = "0xFC9120")]
	public bool IsActivityGroupOpen(uint flashStoreActivityID, uint activityGroupID)
	{
		return default(bool);
	}

	[Token(Token = "0x60142DF")]
	[Address(RVA = "0xFC91A8", Offset = "0xFC91A8", VA = "0xFC91A8")]
	public ulong GetFlashStoreStartTime(uint flashStoreActivityID)
	{
		return default(ulong);
	}

	[Token(Token = "0x60142E0")]
	[Address(RVA = "0xFC9244", Offset = "0xFC9244", VA = "0xFC9244")]
	public ulong GetFlashStoreEndTime(uint flashStoreActivityID)
	{
		return default(ulong);
	}

	[Token(Token = "0x60142E1")]
	[Address(RVA = "0xFC92E0", Offset = "0xFC92E0", VA = "0xFC92E0")]
	public static List<BaseItemInfo> AssembleAwardList(List<Item> add_list, List<Item> del_list)
	{
		return null;
	}

	[Token(Token = "0x60142E2")]
	[Address(RVA = "0xFC95D4", Offset = "0xFC95D4", VA = "0xFC95D4")]
	public uint GetCurrentFlashGemsCnt(uint flashStoreActivityID)
	{
		return default(uint);
	}

	[Token(Token = "0x60142E3")]
	[Address(RVA = "0xFC9720", Offset = "0xFC9720", VA = "0xFC9720")]
	public uint GetCurrentFlashStoreActivityID()
	{
		return default(uint);
	}

	[Token(Token = "0x60142E4")]
	[Address(RVA = "0xFC9780", Offset = "0xFC9780", VA = "0xFC9780")]
	public FlashStoreState GetFlashStoreState(uint flashStoreActivityID)
	{
		return default(FlashStoreState);
	}

	[Token(Token = "0x60142E5")]
	[Address(RVA = "0xFC97EC", Offset = "0xFC97EC", VA = "0xFC97EC")]
	public uint GetFlashStoreID(uint flashStoreActivityID)
	{
		return default(uint);
	}

	[Token(Token = "0x60142E6")]
	[Address(RVA = "0xFC9858", Offset = "0xFC9858", VA = "0xFC9858")]
	public uint GetFlashGemID(uint flashStoreActivityID)
	{
		return default(uint);
	}

	[Token(Token = "0x60142E7")]
	[Address(RVA = "0xFC98C4", Offset = "0xFC98C4", VA = "0xFC98C4")]
	public string GetActivityTitleTextureURL(uint flashStoreActivityID)
	{
		return null;
	}

	[Token(Token = "0x60142E8")]
	[Address(RVA = "0xFC9A58", Offset = "0xFC9A58", VA = "0xFC9A58")]
	public string GetStoreTitleTextureURL(uint flashStoreActivityID)
	{
		return null;
	}

	[Token(Token = "0x60142E9")]
	[Address(RVA = "0xFC9BEC", Offset = "0xFC9BEC", VA = "0xFC9BEC")]
	public uint GetTotalFlashGemAmount(uint flashStoreActivityID)
	{
		return default(uint);
	}

	[Token(Token = "0x60142EA")]
	[Address(RVA = "0xFC9E70", Offset = "0xFC9E70", VA = "0xFC9E70")]
	public uint GetFlashStoreCurrentActivityGroup(uint flashStoreActivityID)
	{
		return default(uint);
	}

	[Token(Token = "0x60142EB")]
	[Address(RVA = "0xFC7B94", Offset = "0xFC7B94", VA = "0xFC7B94")]
	public uint GetGemsReplenishNeedCnt(uint flashStoreActivityID, FlashStoreGoodsDesc flashStoreItem, uint count = 1u)
	{
		return default(uint);
	}

	[Token(Token = "0x60142EC")]
	[Address(RVA = "0xFCA20C", Offset = "0xFCA20C", VA = "0xFCA20C")]
	public uint GetGemsShortageCnt(uint flashStoreActivityid, FlashStoreGoodsDesc flashStoreItem, bool includeReplenishCnt = false, uint count = 1u)
	{
		return default(uint);
	}

	[Token(Token = "0x60142ED")]
	[Address(RVA = "0xFCA450", Offset = "0xFCA450", VA = "0xFCA450")]
	public uint[] GetActivityGroupIDArray(uint flashStoreActivityID)
	{
		return null;
	}

	[Token(Token = "0x60142EE")]
	[Address(RVA = "0xFCA5BC", Offset = "0xFCA5BC", VA = "0xFCA5BC")]
	public uint[] GetAllFinishedActivities(uint flashStoreActivityID)
	{
		return null;
	}

	[Token(Token = "0x60142EF")]
	[Address(RVA = "0xFCAB40", Offset = "0xFCAB40", VA = "0xFCAB40")]
	public uint GetGroupFlashGemAmount(uint flashStoreActivityID, uint activityGroupID)
	{
		return default(uint);
	}

	[Token(Token = "0x60142F0")]
	[Address(RVA = "0xFCACE4", Offset = "0xFCACE4", VA = "0xFCACE4")]
	public ulong GetGroupStartTimestamp(uint flashStoreActivityID, uint activityGroupID)
	{
		return default(ulong);
	}

	[Token(Token = "0x60142F1")]
	[Address(RVA = "0xFCAF90", Offset = "0xFCAF90", VA = "0xFCAF90")]
	public ulong GetGroupEndTimestamp(uint flashStoreActivityID, uint activityGroupID)
	{
		return default(ulong);
	}

	[Token(Token = "0x60142F2")]
	[Address(RVA = "0xFCB23C", Offset = "0xFCB23C", VA = "0xFCB23C")]
	public uint[] GetAllFinishedActivitiesInGroup(uint flashStoreActivityID, uint activityGroupID)
	{
		return null;
	}

	[Token(Token = "0x60142F3")]
	[Address(RVA = "0xFCB6A4", Offset = "0xFCB6A4", VA = "0xFCB6A4")]
	public List<FlashStoreGoodsDesc> GetFlashStoreItemListByTabType(UILimitedStoreTabType tabType)
	{
		return null;
	}

	[Token(Token = "0x60142F4")]
	[Address(RVA = "0xFCB840", Offset = "0xFCB840", VA = "0xFCB840")]
	public List<FlashStoreGoodsDesc> GetFlashStoreItemListByTabType(uint mallTabType)
	{
		return null;
	}

	[Token(Token = "0x60142F5")]
	[Address(RVA = "0xFCB9DC", Offset = "0xFCB9DC", VA = "0xFCB9DC")]
	public FlashStoreGoodsDesc GetFlashStoreItemByItemID(uint flashStoreActivityID, uint itemID)
	{
		return null;
	}

	[Token(Token = "0x60142F6")]
	[Address(RVA = "0xFCBCFC", Offset = "0xFCBCFC", VA = "0xFCBCFC")]
	public bool IsFlashStoreItemsDictKeyValid(uint key)
	{
		return default(bool);
	}

	[Token(Token = "0x60142F7")]
	[Address(RVA = "0xFCBE14", Offset = "0xFCBE14", VA = "0xFCBE14")]
	public static UILimitedStoreTabType GetItemtype2MallType(uint itemType, uint subType = 0u)
	{
		return default(UILimitedStoreTabType);
	}

	[Token(Token = "0x60142F8")]
	[Address(RVA = "0xFCBE80", Offset = "0xFCBE80", VA = "0xFCBE80")]
	public static UILimitedStoreTabType GetItemtype2MallType(CSSharedItemDataManager.ItemType itemType, CSSharedItemDataManager.CollectionSubType subType = CSSharedItemDataManager.CollectionSubType.NOTCOLLECTION)
	{
		return default(UILimitedStoreTabType);
	}

	[Token(Token = "0x60142F9")]
	[Address(RVA = "0xFC6710", Offset = "0xFC6710", VA = "0xFC6710")]
	public void ProcessTypeOverrideItemAndAddToDict(FlashStoreGoodsDesc item)
	{
	}

	[Token(Token = "0x60142FA")]
	[Address(RVA = "0xFCC120", Offset = "0xFCC120", VA = "0xFCC120")]
	public uint GetItemCurrentPurchaseTime(FlashStoreGoodsDesc itemData)
	{
		return default(uint);
	}

	[Token(Token = "0x60142FB")]
	[Address(RVA = "0xFCC234", Offset = "0xFCC234", VA = "0xFCC234")]
	public bool IsHavePurchaseTime(FlashStoreGoodsDesc itemData)
	{
		return default(bool);
	}

	[Token(Token = "0x60142FC")]
	[Address(RVA = "0xFCC37C", Offset = "0xFCC37C", VA = "0xFCC37C")]
	public ECurrentSelectItemAvailableState GetItemAvailableState(FlashStoreGoodsDesc desc, EFlashStoreItemPriceState priceState, int purchaseCnt = 1)
	{
		return default(ECurrentSelectItemAvailableState);
	}

	[Token(Token = "0x60142FD")]
	[Address(RVA = "0xFCC598", Offset = "0xFCC598", VA = "0xFCC598")]
	public static EFlashStoreItemPriceState GetItemPriceState(FlashStoreGoodsDesc item)
	{
		return default(EFlashStoreItemPriceState);
	}

	[Token(Token = "0x60142FE")]
	[Address(RVA = "0xFCC614", Offset = "0xFCC614", VA = "0xFCC614")]
	public int SortLimitedStoreItem(FlashStoreGoodsDesc x, FlashStoreGoodsDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x60142FF")]
	[Address(RVA = "0xFCBF24", Offset = "0xFCBF24", VA = "0xFCBF24")]
	public void AddItemToDict(FlashStoreGoodsDesc item, UILimitedStoreTabType tabType)
	{
	}

	[Token(Token = "0x6014300")]
	[Address(RVA = "0xFCC87C", Offset = "0xFCC87C", VA = "0xFCC87C")]
	private void _003COnRequestFlashStoreInfoFinished_003Em__0()
	{
	}

	[Token(Token = "0x6014301")]
	[Address(RVA = "0xFCC8A0", Offset = "0xFCC8A0", VA = "0xFCC8A0")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6014302")]
	[Address(RVA = "0xFCC8A8", Offset = "0xFCC8A8", VA = "0xFCC8A8")]
	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	[Token(Token = "0x6014303")]
	[Address(RVA = "0xFCC8B0", Offset = "0xFCC8B0", VA = "0xFCC8B0")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
