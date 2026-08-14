using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20008E7")]
public class AutoPickUpHelper
{
	[Token(Token = "0x20008E8")]
	private sealed class _003CFreezeAutoPickup_003Ec__AnonStorey0
	{
		[Token(Token = "0x40054BC")]
		[FieldOffset(Offset = "0x8")]
		internal int type;

		[Token(Token = "0x6003E85")]
		[Address(RVA = "0x10E5230", Offset = "0x10E5230", VA = "0x10E5230")]
		public _003CFreezeAutoPickup_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6003E86")]
		[Address(RVA = "0x10E5238", Offset = "0x10E5238", VA = "0x10E5238")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x40054AA")]
	[FieldOffset(Offset = "0x8")]
	private Queue<MNGBAPBBJDC> m_AutoPickupQueue;

	[Token(Token = "0x40054AB")]
	[FieldOffset(Offset = "0xC")]
	private List<MNGBAPBBJDC> m_PickupInContainer;

	[Token(Token = "0x40054AC")]
	[FieldOffset(Offset = "0x10")]
	private uint m_AutoPickupDelayCall;

	[Token(Token = "0x40054AD")]
	[FieldOffset(Offset = "0x0")]
	private static bool pauseAutoPickup;

	[Token(Token = "0x40054AE")]
	[FieldOffset(Offset = "0x1")]
	private static bool m_AutoPickupSwitch;

	[Token(Token = "0x40054AF")]
	[FieldOffset(Offset = "0x14")]
	private Player m_LocalPlayer;

	[Token(Token = "0x40054B0")]
	[FieldOffset(Offset = "0x18")]
	public BountyPickupStatus m_BountyStatus;

	[Token(Token = "0x40054B1")]
	[FieldOffset(Offset = "0x4")]
	private static List<AutoPickupConfigData> m_AutoPickConfigList;

	[Token(Token = "0x40054B2")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<int, Dictionary<uint, AutoPickupConfigData>> m_ItemIDToDataDict;

	[Token(Token = "0x40054B3")]
	[FieldOffset(Offset = "0xC")]
	private static Dictionary<int, int> m_ChildTypeToParentTypeID;

	[Token(Token = "0x40054B4")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<uint, int> m_GameModeToTypeDic;

	[Token(Token = "0x40054B5")]
	[FieldOffset(Offset = "0x14")]
	private static bool hasInit;

	[Token(Token = "0x40054B6")]
	[FieldOffset(Offset = "0x18")]
	private static Dictionary<uint, int> m_TemporaryCloseIDToTypeDict;

	[Token(Token = "0x40054B7")]
	[FieldOffset(Offset = "0x1C")]
	private static Dictionary<int, bool> m_TemporaryCloseTypeOpenStateDict;

	[Token(Token = "0x40054B8")]
	[FieldOffset(Offset = "0x20")]
	private static Dictionary<int, uint> m_TemporaryCloseTypeDelayCallDict;

	[Token(Token = "0x40054B9")]
	[FieldOffset(Offset = "0x24")]
	private static readonly Dictionary<int, AutoPickupConfigData> m_AutoPickupDataDict;

	[Token(Token = "0x40054BA")]
	[FieldOffset(Offset = "0x28")]
	private static readonly Dictionary<int, int> m_AutoPickupIDToType;

	[Token(Token = "0x40054BB")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly Dictionary<int, List<AutoPickupConfigData>> m_TypeToPrioritySortedList;

	[Token(Token = "0x1700042F")]
	private NPCNMJAGIKI m_InventoryManager
	{
		[Token(Token = "0x6003E61")]
		[Address(RVA = "0x14D2660", Offset = "0x14D2660", VA = "0x14D2660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000430")]
	public Dictionary<int, Dictionary<uint, AutoPickupConfigData>> ItemIDToDataDict
	{
		[Token(Token = "0x6003E63")]
		[Address(RVA = "0x14D340C", Offset = "0x14D340C", VA = "0x14D340C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E60")]
	[Address(RVA = "0x14D2518", Offset = "0x14D2518", VA = "0x14D2518")]
	public AutoPickUpHelper()
	{
	}

	[Token(Token = "0x6003E62")]
	[Address(RVA = "0x14D27E8", Offset = "0x14D27E8", VA = "0x14D27E8")]
	public void StartAutoPickup()
	{
	}

	[Token(Token = "0x6003E64")]
	[Address(RVA = "0x14D34E4", Offset = "0x14D34E4", VA = "0x14D34E4")]
	public static void SetAutoPickupSwitch(bool isOn)
	{
	}

	[Token(Token = "0x6003E65")]
	[Address(RVA = "0x14D35BC", Offset = "0x14D35BC", VA = "0x14D35BC")]
	public void StopAutoPickup(bool changedBySetting = false)
	{
	}

	[Token(Token = "0x6003E66")]
	[Address(RVA = "0x14D3F9C", Offset = "0x14D3F9C", VA = "0x14D3F9C")]
	public static void ResetAutoPickUpTemporaryTypeOpenState()
	{
	}

	[Token(Token = "0x6003E67")]
	[Address(RVA = "0x14D437C", Offset = "0x14D437C", VA = "0x14D437C")]
	private void DoAutoPickUp()
	{
	}

	[Token(Token = "0x6003E68")]
	[Address(RVA = "0x14D46F8", Offset = "0x14D46F8", VA = "0x14D46F8")]
	private void SortAutoPickQueue()
	{
	}

	[Token(Token = "0x6003E69")]
	[Address(RVA = "0x14D4908", Offset = "0x14D4908", VA = "0x14D4908")]
	public void SetPickUpList(List<MNGBAPBBJDC> pickupList)
	{
	}

	[Token(Token = "0x6003E6A")]
	[Address(RVA = "0x14D37F8", Offset = "0x14D37F8", VA = "0x14D37F8")]
	public void RefreshAutoPickUpList()
	{
	}

	[Token(Token = "0x6003E6B")]
	[Address(RVA = "0x14D4B04", Offset = "0x14D4B04", VA = "0x14D4B04")]
	public void FreezeAutoPickup(uint itemID)
	{
	}

	[Token(Token = "0x6003E6C")]
	[Address(RVA = "0x14D2AE0", Offset = "0x14D2AE0", VA = "0x14D2AE0")]
	public static bool EnableAutoPickupFunction()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E6D")]
	[Address(RVA = "0x14D49E8", Offset = "0x14D49E8", VA = "0x14D49E8")]
	public void SortPickupList(List<MNGBAPBBJDC> pickUps)
	{
	}

	[Token(Token = "0x6003E6E")]
	[Address(RVA = "0x14D54D4", Offset = "0x14D54D4", VA = "0x14D54D4")]
	public int AutoPickupSort(MNGBAPBBJDC x, MNGBAPBBJDC y)
	{
		return default(int);
	}

	[Token(Token = "0x6003E6F")]
	[Address(RVA = "0x14D5B48", Offset = "0x14D5B48", VA = "0x14D5B48")]
	public void SortNotAutoPickupList(List<MNGBAPBBJDC> pickUps)
	{
	}

	[Token(Token = "0x6003E70")]
	[Address(RVA = "0x14D5C7C", Offset = "0x14D5C7C", VA = "0x14D5C7C")]
	public int AutoNotAutoPickupSort(MNGBAPBBJDC x, MNGBAPBBJDC y)
	{
		return default(int);
	}

	[Token(Token = "0x6003E71")]
	[Address(RVA = "0x14D5E5C", Offset = "0x14D5E5C", VA = "0x14D5E5C")]
	public static List<AutoPickupConfigData> GetAutoPickUpConfigDataList()
	{
		return null;
	}

	[Token(Token = "0x6003E72")]
	[Address(RVA = "0x14D61E0", Offset = "0x14D61E0", VA = "0x14D61E0")]
	public static List<AutoPickupConfigData> GetSettingTypeAutoPickupItemList(int type, bool filter = false, bool available = true)
	{
		return null;
	}

	[Token(Token = "0x6003E73")]
	[Address(RVA = "0x14D6610", Offset = "0x14D6610", VA = "0x14D6610")]
	public static List<AutoPickupConfigData> GetPrioritySortedItemListWithSettingType(int type)
	{
		return null;
	}

	[Token(Token = "0x6003E74")]
	[Address(RVA = "0x14D69B8", Offset = "0x14D69B8", VA = "0x14D69B8")]
	public static AutoPickupConfigData GetAutoPickupItemWithID(int id)
	{
		return null;
	}

	[Token(Token = "0x6003E75")]
	[Address(RVA = "0x14D6B90", Offset = "0x14D6B90", VA = "0x14D6B90")]
	public static void ResetAllAutoPickupItemPreferenceWithType(int type)
	{
	}

	[Token(Token = "0x6003E76")]
	[Address(RVA = "0x14D70D0", Offset = "0x14D70D0", VA = "0x14D70D0")]
	public static void CreateAutoPickupItemDictAndOrderList()
	{
	}

	[Token(Token = "0x6003E77")]
	[Address(RVA = "0x14D7E88", Offset = "0x14D7E88", VA = "0x14D7E88")]
	public static void CreateAutoPickupTypeMapping()
	{
	}

	[Token(Token = "0x6003E78")]
	[Address(RVA = "0x14D83A4", Offset = "0x14D83A4", VA = "0x14D83A4")]
	public static void SetAutoPickupItemActive(AutoPickupConfigData configData, bool active)
	{
	}

	[Token(Token = "0x6003E79")]
	[Address(RVA = "0x14D898C", Offset = "0x14D898C", VA = "0x14D898C")]
	private static void SetParentAutoPickupItemPriority(AutoPickupConfigData configData, bool up)
	{
	}

	[Token(Token = "0x6003E7A")]
	[Address(RVA = "0x14D8F70", Offset = "0x14D8F70", VA = "0x14D8F70")]
	private static void SetChildAutoPickupItemPriority(AutoPickupConfigData configData, bool up)
	{
	}

	[Token(Token = "0x6003E7B")]
	[Address(RVA = "0x14D9450", Offset = "0x14D9450", VA = "0x14D9450")]
	public static void SetActiveAutoPickupItemPriority(int itemID, bool up)
	{
	}

	[Token(Token = "0x6003E7C")]
	[Address(RVA = "0x14D9780", Offset = "0x14D9780", VA = "0x14D9780")]
	public static int GetAutoPickupSettingTypeWithGameMode(uint gameMode)
	{
		return default(int);
	}

	[Token(Token = "0x6003E7D")]
	[Address(RVA = "0x14D2EB8", Offset = "0x14D2EB8", VA = "0x14D2EB8")]
	public static AutoPickupConfigData GetAutoPickupSettingByType(int itemType, int itemSubType, uint itemID = 0u)
	{
		return null;
	}

	[Token(Token = "0x6003E7E")]
	[Address(RVA = "0x14D98A8", Offset = "0x14D98A8", VA = "0x14D98A8")]
	public static bool InitAutoPickUpKeyMap(bool forceRefresh = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E7F")]
	[Address(RVA = "0x14D9B90", Offset = "0x14D9B90", VA = "0x14D9B90")]
	public static void UploadUserSetting(SettingDetail request)
	{
	}

	[Token(Token = "0x6003E80")]
	[Address(RVA = "0x14D9EDC", Offset = "0x14D9EDC", VA = "0x14D9EDC")]
	private static void DownloadUserSettingV0(SettingDetail result)
	{
	}

	[Token(Token = "0x6003E81")]
	[Address(RVA = "0x14DA42C", Offset = "0x14DA42C", VA = "0x14DA42C")]
	private static void DownloadUserSettingV1(SettingDetail result)
	{
	}

	[Token(Token = "0x6003E82")]
	[Address(RVA = "0x14DAB8C", Offset = "0x14DAB8C", VA = "0x14DAB8C")]
	public static void DownloadUserSetting(SettingDetail result)
	{
	}

	[Token(Token = "0x6003E84")]
	[Address(RVA = "0x14DAF68", Offset = "0x14DAF68", VA = "0x14DAF68")]
	private int _003CSortAutoPickQueue_003Em__0(MNGBAPBBJDC a, MNGBAPBBJDC b)
	{
		return default(int);
	}
}
