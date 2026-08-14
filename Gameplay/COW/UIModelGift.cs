using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2003096")]
public class UIModelGift : UIBaseModel
{
	[Token(Token = "0x2003097")]
	private sealed class _003CGetGiftStoreDetails_003Ec__AnonStorey0
	{
		[Token(Token = "0x40127B2")]
		[FieldOffset(Offset = "0x8")]
		internal bool force;

		[Token(Token = "0x40127B3")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelGift _0024this;

		[Token(Token = "0x6014526")]
		[Address(RVA = "0x12A35B0", Offset = "0x12A35B0", VA = "0x12A35B0")]
		public _003CGetGiftStoreDetails_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6014527")]
		[Address(RVA = "0x12A35B8", Offset = "0x12A35B8", VA = "0x12A35B8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003098")]
	private sealed class _003CAddOverrideItem_003Ec__AnonStorey1
	{
		[Token(Token = "0x40127B4")]
		[FieldOffset(Offset = "0x8")]
		internal GiftItem item;

		[Token(Token = "0x6014528")]
		[Address(RVA = "0x12A355C", Offset = "0x12A355C", VA = "0x12A355C")]
		public _003CAddOverrideItem_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6014529")]
		[Address(RVA = "0x12A3564", Offset = "0x12A3564", VA = "0x12A3564")]
		internal bool _003C_003Em__0(GiftItem i)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003099")]
	private sealed class _003CSendGift_003Ec__AnonStorey2
	{
		[Token(Token = "0x40127B5")]
		[FieldOffset(Offset = "0x8")]
		internal ulong[] receiverIds;

		[Token(Token = "0x40127B6")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelGift _0024this;

		[Token(Token = "0x601452A")]
		[Address(RVA = "0x12A40B4", Offset = "0x12A40B4", VA = "0x12A40B4")]
		public _003CSendGift_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x601452B")]
		[Address(RVA = "0x12A40BC", Offset = "0x12A40BC", VA = "0x12A40BC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x200309A")]
	private sealed class _003CRequestGetGiftRankReward_003Ec__AnonStorey3
	{
		[Token(Token = "0x40127B7")]
		[FieldOffset(Offset = "0x8")]
		internal EStore.GiftRankType giftRankType;

		[Token(Token = "0x40127B8")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelGift _0024this;

		[Token(Token = "0x601452C")]
		[Address(RVA = "0x12A3C44", Offset = "0x12A3C44", VA = "0x12A3C44")]
		public _003CRequestGetGiftRankReward_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x601452D")]
		[Address(RVA = "0x12A3C4C", Offset = "0x12A3C4C", VA = "0x12A3C4C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x401279A")]
	public const uint PropID_UpdateGiftStore = 2u;

	[Token(Token = "0x401279B")]
	public const uint PropID_UpdateGiftStoreDetails = 4u;

	[Token(Token = "0x401279C")]
	public const uint PropID_SendGift = 8u;

	[Token(Token = "0x401279D")]
	public const uint PropID_GetGiftRankDesc = 16u;

	[Token(Token = "0x401279E")]
	public const uint PropID_GetGiftRankRewardInfo = 32u;

	[Token(Token = "0x401279F")]
	public const uint PropID_GetGiftRankRewardSuccess = 64u;

	[Token(Token = "0x40127A0")]
	[FieldOffset(Offset = "0xC")]
	private uint m_SendGiftTimeToday;

	[Token(Token = "0x40127A1")]
	[FieldOffset(Offset = "0x10")]
	private List<FriendInfo> m_AllSelectedList;

	[Token(Token = "0x40127A2")]
	[FieldOffset(Offset = "0x14")]
	private GiftStoreInfo _003CGiftStore_003Ek__BackingField;

	[Token(Token = "0x40127A3")]
	[FieldOffset(Offset = "0x18")]
	private CSGetGiftStoreDetailsRes _003CGiftStoreDetails_003Ek__BackingField;

	[Token(Token = "0x40127A4")]
	[FieldOffset(Offset = "0x1C")]
	private List<GiftItem> m_GiftItemsList;

	[Token(Token = "0x40127A5")]
	[FieldOffset(Offset = "0x20")]
	private SortedDictionary<UINavigationUtil.UINavigationMallTabType, List<GiftItem>> m_GiftItemsDict;

	[Token(Token = "0x40127A6")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<uint, List<GiftItem>> m_GiftPetDict;

	[Token(Token = "0x40127A7")]
	[FieldOffset(Offset = "0x28")]
	private SortedDictionary<UIModelAvatarBase.EWardrobeType, List<GiftItem>> m_GiftClothDict;

	[Token(Token = "0x40127A8")]
	[FieldOffset(Offset = "0x2C")]
	private SortedDictionary<CSSharedItemDataManager.CollectionSubType, List<GiftItem>> m_GiftCollectionDict;

	[Token(Token = "0x40127A9")]
	[FieldOffset(Offset = "0x30")]
	private SortedDictionary<CSSharedItemDataManager.CharacterSubType, List<GiftItem>> m_GiftCharacterDict;

	[Token(Token = "0x40127AA")]
	[FieldOffset(Offset = "0x34")]
	private List<GiftItem> m_GiftExclusiveItemList;

	[Token(Token = "0x40127AB")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<uint, List<GiftRewardDesc>> m_GiftRewardsList;

	[Token(Token = "0x40127AC")]
	[FieldOffset(Offset = "0x3C")]
	private ClientGiftRankDesc m_GiftRankDesc;

	[Token(Token = "0x40127AD")]
	[FieldOffset(Offset = "0x40")]
	private CSGetGiftRankRewardInfoRes m_GiftRankRewardInfoRes;

	[Token(Token = "0x40127AE")]
	[FieldOffset(Offset = "0x44")]
	private float m_LastUpdateGiftStoreResTime;

	[Token(Token = "0x40127AF")]
	[FieldOffset(Offset = "0x48")]
	private float m_LastUpdateGiftStoreDetailResTime;

	[Token(Token = "0x40127B0")]
	[FieldOffset(Offset = "0x4C")]
	private float m_LastUpdateGiftRankResTime;

	[Token(Token = "0x40127B1")]
	[FieldOffset(Offset = "0x50")]
	private float m_GetGiftStoreResCoolDown;

	[Token(Token = "0x17001512")]
	public uint SendGiftTimeToday
	{
		[Token(Token = "0x60144FB")]
		[Address(RVA = "0x31A8964", Offset = "0x31A8964", VA = "0x31A8964")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001513")]
	public List<FriendInfo> AllSelectedList
	{
		[Token(Token = "0x60144FC")]
		[Address(RVA = "0x31A89BC", Offset = "0x31A89BC", VA = "0x31A89BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60144FD")]
		[Address(RVA = "0x31A8A14", Offset = "0x31A8A14", VA = "0x31A8A14")]
		set
		{
		}
	}

	[Token(Token = "0x17001514")]
	public GiftStoreInfo GiftStore
	{
		[Token(Token = "0x6014500")]
		[Address(RVA = "0x31A8AD0", Offset = "0x31A8AD0", VA = "0x31A8AD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60144FF")]
		[Address(RVA = "0x31A8AC8", Offset = "0x31A8AC8", VA = "0x31A8AC8")]
		private set
		{
		}
	}

	[Token(Token = "0x17001515")]
	public CSGetGiftStoreDetailsRes GiftStoreDetails
	{
		[Token(Token = "0x6014502")]
		[Address(RVA = "0x31A8AE0", Offset = "0x31A8AE0", VA = "0x31A8AE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014501")]
		[Address(RVA = "0x31A8AD8", Offset = "0x31A8AD8", VA = "0x31A8AD8")]
		private set
		{
		}
	}

	[Token(Token = "0x17001516")]
	public List<GiftItem> GiftItemsList
	{
		[Token(Token = "0x6014503")]
		[Address(RVA = "0x31A8AE8", Offset = "0x31A8AE8", VA = "0x31A8AE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001517")]
	public SortedDictionary<UINavigationUtil.UINavigationMallTabType, List<GiftItem>> GiftItemsDict
	{
		[Token(Token = "0x6014504")]
		[Address(RVA = "0x31A8B40", Offset = "0x31A8B40", VA = "0x31A8B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001518")]
	public Dictionary<uint, List<GiftItem>> GiftPetDict
	{
		[Token(Token = "0x6014505")]
		[Address(RVA = "0x31A8B98", Offset = "0x31A8B98", VA = "0x31A8B98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001519")]
	public SortedDictionary<UIModelAvatarBase.EWardrobeType, List<GiftItem>> GiftClothDict
	{
		[Token(Token = "0x6014506")]
		[Address(RVA = "0x31A8BF0", Offset = "0x31A8BF0", VA = "0x31A8BF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700151A")]
	public SortedDictionary<CSSharedItemDataManager.CollectionSubType, List<GiftItem>> GiftCollectionDict
	{
		[Token(Token = "0x6014507")]
		[Address(RVA = "0x31A8C48", Offset = "0x31A8C48", VA = "0x31A8C48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700151B")]
	public SortedDictionary<CSSharedItemDataManager.CharacterSubType, List<GiftItem>> GiftCharacterDict
	{
		[Token(Token = "0x6014508")]
		[Address(RVA = "0x31A8CA0", Offset = "0x31A8CA0", VA = "0x31A8CA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700151C")]
	public List<GiftItem> GiftExclusiveItemList
	{
		[Token(Token = "0x6014509")]
		[Address(RVA = "0x31A8CF8", Offset = "0x31A8CF8", VA = "0x31A8CF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700151D")]
	public Dictionary<uint, List<GiftRewardDesc>> GiftRewardsList
	{
		[Token(Token = "0x601450A")]
		[Address(RVA = "0x31A8D50", Offset = "0x31A8D50", VA = "0x31A8D50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700151E")]
	public ClientGiftRankDesc GiftRankDesc
	{
		[Token(Token = "0x601450B")]
		[Address(RVA = "0x31A8DA8", Offset = "0x31A8DA8", VA = "0x31A8DA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700151F")]
	public CSGetGiftRankRewardInfoRes GiftRankRewardInfoRes
	{
		[Token(Token = "0x601450C")]
		[Address(RVA = "0x31A8E00", Offset = "0x31A8E00", VA = "0x31A8E00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60144FA")]
	[Address(RVA = "0x31A871C", Offset = "0x31A871C", VA = "0x31A871C")]
	public UIModelGift()
	{
	}

	[Token(Token = "0x60144FE")]
	[Address(RVA = "0x31A8A70", Offset = "0x31A8A70", VA = "0x31A8A70", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x601450D")]
	[Address(RVA = "0x31A8E58", Offset = "0x31A8E58", VA = "0x31A8E58")]
	public void GetGiftStore(bool force = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x601450E")]
	[Address(RVA = "0x31A9200", Offset = "0x31A9200", VA = "0x31A9200")]
	public void ProcessGiftStore(CSGetGiftStoreRes giftStoreRes)
	{
	}

	[Token(Token = "0x601450F")]
	[Address(RVA = "0x31A93D4", Offset = "0x31A93D4", VA = "0x31A93D4")]
	public void GetGiftStoreDetails(bool force = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014510")]
	[Address(RVA = "0x31A97DC", Offset = "0x31A97DC", VA = "0x31A97DC")]
	private void UpdateItemsDict(GiftItem item)
	{
	}

	[Token(Token = "0x6014511")]
	[Address(RVA = "0x31A9F2C", Offset = "0x31A9F2C", VA = "0x31A9F2C")]
	public bool IsGiftStoreShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6014512")]
	[Address(RVA = "0x31A9AB0", Offset = "0x31A9AB0", VA = "0x31A9AB0")]
	private uint GetTabType(uint itemOverrideMallType)
	{
		return default(uint);
	}

	[Token(Token = "0x6014513")]
	[Address(RVA = "0x31A9B28", Offset = "0x31A9B28", VA = "0x31A9B28")]
	private uint GetSubType(uint itemOverrideMallType)
	{
		return default(uint);
	}

	[Token(Token = "0x6014514")]
	[Address(RVA = "0x31AA020", Offset = "0x31AA020", VA = "0x31AA020")]
	private void AddOverrideItem(Dictionary<uint, List<GiftItem>> dict, uint tabType, GiftItem item)
	{
	}

	[Token(Token = "0x6014515")]
	[Address(RVA = "0x31A9BAC", Offset = "0x31A9BAC", VA = "0x31A9BAC")]
	private void AddItemToDict(GiftItem item, UINavigationUtil.UINavigationMallTabType mallType, uint mallSubType)
	{
	}

	[Token(Token = "0x6014516")]
	[Address(RVA = "0x31AA2D0", Offset = "0x31AA2D0", VA = "0x31AA2D0")]
	private void UpdateClothDict(GiftItem item)
	{
	}

	[Token(Token = "0x6014517")]
	[Address(RVA = "0x31AA6E0", Offset = "0x31AA6E0", VA = "0x31AA6E0")]
	private void UpdateCollectionDict(GiftItem item)
	{
	}

	[Token(Token = "0x6014518")]
	[Address(RVA = "0x31AAAD4", Offset = "0x31AAAD4", VA = "0x31AAAD4")]
	public void SendGift(ulong[] receiverIds, EGiftStore_BuddyType buddyType, string message, uint commodityID, EInventory.CurrencyType currencyType = EInventory.CurrencyType.CurrencyType_COINS, uint count = 1u, uint voucherID = 0u)
	{
	}

	[Token(Token = "0x6014519")]
	[Address(RVA = "0x31AB6C8", Offset = "0x31AB6C8", VA = "0x31AB6C8")]
	private void RefreshGiftRes()
	{
	}

	[Token(Token = "0x601451A")]
	[Address(RVA = "0x31AB148", Offset = "0x31AB148", VA = "0x31AB148")]
	public bool CheckCurrencyStock(GiftItem item, uint itemCount, EInventory.CurrencyType currencyType, uint voucherID)
	{
		return default(bool);
	}

	[Token(Token = "0x601451B")]
	[Address(RVA = "0x31AB740", Offset = "0x31AB740", VA = "0x31AB740", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x601451C")]
	[Address(RVA = "0x31AB7C4", Offset = "0x31AB7C4", VA = "0x31AB7C4")]
	public GiftItem FindGiftItemById(uint itemID)
	{
		return null;
	}

	[Token(Token = "0x601451D")]
	[Address(RVA = "0x31AAFE4", Offset = "0x31AAFE4", VA = "0x31AAFE4")]
	public GiftItem FindGiftItemByCommodityID(uint commodityID)
	{
		return null;
	}

	[Token(Token = "0x601451E")]
	[Address(RVA = "0x31AB928", Offset = "0x31AB928", VA = "0x31AB928")]
	public int SortGiftItem(GiftItem a, GiftItem b)
	{
		return default(int);
	}

	[Token(Token = "0x601451F")]
	[Address(RVA = "0x31ABBB0", Offset = "0x31ABBB0", VA = "0x31ABBB0")]
	public void RequestGiftRankDesc(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014520")]
	[Address(RVA = "0x31ABF44", Offset = "0x31ABF44", VA = "0x31ABF44")]
	public void RequestGiftRankRewardInfo(uint rankID)
	{
	}

	[Token(Token = "0x6014521")]
	[Address(RVA = "0x31AC180", Offset = "0x31AC180", VA = "0x31AC180")]
	public void RequestGetGiftRankReward(uint rankID, EStore.GiftRankType giftRankType, uint giftItemNum)
	{
	}

	[Token(Token = "0x6014522")]
	[Address(RVA = "0x31AC454", Offset = "0x31AC454", VA = "0x31AC454")]
	private void _003CGetGiftStore_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014523")]
	[Address(RVA = "0x31AC55C", Offset = "0x31AC55C", VA = "0x31AC55C")]
	private void _003CRequestGiftRankDesc_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014524")]
	[Address(RVA = "0x31AC880", Offset = "0x31AC880", VA = "0x31AC880")]
	private void _003CRequestGiftRankRewardInfo_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014525")]
	[Address(RVA = "0x31AC9AC", Offset = "0x31AC9AC", VA = "0x31AC9AC")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
