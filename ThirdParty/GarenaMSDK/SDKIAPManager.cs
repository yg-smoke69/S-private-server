using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x200005A")]
public static class SDKIAPManager
{
	[Token(Token = "0x200005B")]
	public class SDKIAPManagerConfiguration
	{
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x8")]
		public bool LocalizePrice;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0xC")]
		public int ServerID;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x10")]
		public int RoleID;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x14")]
		public string Region;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x18")]
		public string ProductPrefix_iOS;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x34646CC", Offset = "0x34646CC", VA = "0x34646CC")]
		public SDKIAPManagerConfiguration()
		{
		}
	}

	[Token(Token = "0x200005C")]
	public class RebateOptionPurchaseResult
	{
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x8")]
		public string ProductIdentifier;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x10")]
		public long RebateID;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x18")]
		public int RemainingDays;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x1C")]
		public int Quantity;

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x34587EC", Offset = "0x34587EC", VA = "0x34587EC")]
		public RebateOptionPurchaseResult()
		{
		}
	}

	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<int, int> _TaskTypes;

	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x4")]
	private static List<SDKIAPTaskInstance> _Tasks;

	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x8")]
	private static SDKIAPTaskInstance _PendingTask;

	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0xC")]
	private static SDKIAPManagerConfiguration _003CConfiguration_003Ek__BackingField;

	[Token(Token = "0x17000059")]
	public static bool Pending
	{
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x3461C34", Offset = "0x3461C34", VA = "0x3461C34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700005A")]
	public static SDKIAPManagerConfiguration Configuration
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x34531B4", Offset = "0x34531B4", VA = "0x34531B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x3461DB4", Offset = "0x3461DB4", VA = "0x3461DB4")]
		set
		{
		}
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x3461E44", Offset = "0x3461E44", VA = "0x3461E44")]
	private static void DestroyTask(SDKIAPTaskInstance taskInstance)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x3462010", Offset = "0x3462010", VA = "0x3462010")]
	private static bool ExecuteTask(SDKIAPTaskInstance taskInstance)
	{
		return default(bool);
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x3462470", Offset = "0x3462470", VA = "0x3462470")]
	private static bool ProcessTask(SDKIAPTaskInstance taskInstance)
	{
		return default(bool);
	}

	[Token(Token = "0x60001FE")]
	private static bool CanFinishWith<T>(T t, SDKIAPTaskInstance i) where T : SDKIAPTaskInstance
	{
		return default(bool);
	}

	[Token(Token = "0x60001FF")]
	internal static void Finish<T>(T t, Action<T> callback) where T : SDKIAPTaskInstance
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x3462DB0", Offset = "0x3462DB0", VA = "0x3462DB0")]
	internal static void TaskInstanceStateChanged(SDKIAPTaskInstance task, SDKIAPTaskState prev, SDKIAPTaskState next)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x3462FF8", Offset = "0x3462FF8", VA = "0x3462FF8")]
	public static bool ScanIAPInventory(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAP.ScanIAPInventoryResult[]> scanned)
	{
		return default(bool);
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x3463190", Offset = "0x3463190", VA = "0x3463190")]
	public static bool LoadIAPItems(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.IAPItem[]> done, int rebateID = 0, bool allItems = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x3463394", Offset = "0x3463394", VA = "0x3463394")]
	public static bool LoadRebateOptions(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateOption[]> done, bool force = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x3463528", Offset = "0x3463528", VA = "0x3463528")]
	public static bool LoadSomeIAPItems(SDKIAPTaskInfo info, int[] productIds, long[] rebateIds, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.IAPItem[]> done)
	{
		return default(bool);
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x3463700", Offset = "0x3463700", VA = "0x3463700")]
	public static bool LoadSomeRebateOptions(SDKIAPTaskInfo info, long[] rebateIds, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateOption[]> done)
	{
		return default(bool);
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x34638B0", Offset = "0x34638B0", VA = "0x34638B0")]
	public static bool PurchaseNormalProduct(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, string, int> success, Action<SDKIAPTaskInfo, SDKIAPTaskResult, string> failure, [Optional] string productIdentifier, int quantity = 1)
	{
		return default(bool);
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x3463A90", Offset = "0x3463A90", VA = "0x3463A90")]
	public static bool PurchaseRebateOption(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, RebateOptionPurchaseResult> success, Action<SDKIAPTaskInfo, SDKIAPTaskResult, RebateOptionPurchaseResult> failure, int rebateID, string productIdentifier)
	{
		return default(bool);
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x3463C84", Offset = "0x3463C84", VA = "0x3463C84")]
	public static bool RedeemRebateOption(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateRedeemResult[]> redeemed, int rebateID)
	{
		return default(bool);
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x3463E34", Offset = "0x3463E34", VA = "0x3463E34")]
	public static bool LoadEventConfigs(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.LoadEventConfigsResult> done, bool activeOnly)
	{
		return default(bool);
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x3463FE4", Offset = "0x3463FE4", VA = "0x3463FE4")]
	public static bool LoadEventIAPItems(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.LoadEventIAPResult> done)
	{
		return default(bool);
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x34641AC", Offset = "0x34641AC", VA = "0x34641AC")]
	public static bool PurchaseEventProduct(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, string, int> success, Action<SDKIAPTaskInfo, SDKIAPTaskResult, string> failure, long eventId, string productIdentifier, int quantity = 1)
	{
		return default(bool);
	}
}
