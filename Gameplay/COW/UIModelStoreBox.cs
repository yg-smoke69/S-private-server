using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2003271")]
internal class UIModelStoreBox : UIBaseModel
{
	[Token(Token = "0x2003272")]
	private class StoreBundleData
	{
		[Token(Token = "0x401332A")]
		[FieldOffset(Offset = "0x8")]
		private List<BundleShowData> m_UniqueBundleShowData;

		[Token(Token = "0x401332B")]
		[FieldOffset(Offset = "0xC")]
		private SortedDictionary<uint, List<BundleShowData>> m_StoreBundleDic;

		[Token(Token = "0x401332C")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<uint, List<BundleShowData>> m_ServerBundleDic;

		[Token(Token = "0x6015478")]
		[Address(RVA = "0x168C46C", Offset = "0x168C46C", VA = "0x168C46C")]
		public StoreBundleData()
		{
		}

		[Token(Token = "0x6015479")]
		[Address(RVA = "0x168F8E8", Offset = "0x168F8E8", VA = "0x168F8E8")]
		public void LoadFromServerData()
		{
		}

		[Token(Token = "0x601547A")]
		[Address(RVA = "0x168E7E8", Offset = "0x168E7E8", VA = "0x168E7E8")]
		public void UnloadData()
		{
		}

		[Token(Token = "0x601547B")]
		[Address(RVA = "0x16900B8", Offset = "0x16900B8", VA = "0x16900B8")]
		private BundleShowData FindData(BundleShowData data)
		{
			return null;
		}

		[Token(Token = "0x601547C")]
		[Address(RVA = "0x168E8A8", Offset = "0x168E8A8", VA = "0x168E8A8")]
		public void AddLocalBundle(uint dataID, BundleData data)
		{
		}

		[Token(Token = "0x601547D")]
		[Address(RVA = "0x168E08C", Offset = "0x168E08C", VA = "0x168E08C")]
		public void AddServerBundle(BundleShow bundle_show)
		{
		}

		[Token(Token = "0x601547E")]
		[Address(RVA = "0x168C694", Offset = "0x168C694", VA = "0x168C694")]
		public SortedDictionary<uint, List<BundleShowData>> GetStoreBundleDic()
		{
			return null;
		}
	}

	[Token(Token = "0x2003273")]
	private class StoreOptionalBundleData
	{
		[Token(Token = "0x401332D")]
		[FieldOffset(Offset = "0x8")]
		private SortedDictionary<uint, List<OptionalBundleShowData>> m_StoreOptionalBundleDic;

		[Token(Token = "0x401332E")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<uint, List<OptionalBundleShowData>> m_ServerOptionalBundleDic;

		[Token(Token = "0x601547F")]
		[Address(RVA = "0x168C560", Offset = "0x168C560", VA = "0x168C560")]
		public StoreOptionalBundleData()
		{
		}

		[Token(Token = "0x6015480")]
		[Address(RVA = "0x168FB64", Offset = "0x168FB64", VA = "0x168FB64")]
		public void LoadFromServerData()
		{
		}

		[Token(Token = "0x6015481")]
		[Address(RVA = "0x168FDE0", Offset = "0x168FDE0", VA = "0x168FDE0")]
		public void UnloadData()
		{
		}

		[Token(Token = "0x6015482")]
		[Address(RVA = "0x168EFAC", Offset = "0x168EFAC", VA = "0x168EFAC")]
		public void AddLocalOptionalBundle(uint dataID, OptionalBundleShowData data)
		{
		}

		[Token(Token = "0x6015483")]
		[Address(RVA = "0x168E4BC", Offset = "0x168E4BC", VA = "0x168E4BC")]
		public void AddServerOptionalBundle(OptionalBundleShow bundle_show)
		{
		}

		[Token(Token = "0x6015484")]
		[Address(RVA = "0x168C760", Offset = "0x168C760", VA = "0x168C760")]
		public SortedDictionary<uint, List<OptionalBundleShowData>> GetStoreOptionalBundleDic()
		{
			return null;
		}
	}

	[Token(Token = "0x4013324")]
	public const uint PropID_GotTreasureBoxRes = 2u;

	[Token(Token = "0x4013325")]
	public const uint PropID_GotBundleRes = 4u;

	[Token(Token = "0x4013326")]
	[FieldOffset(Offset = "0xC")]
	private StoreBundleData m_StoreBundleData;

	[Token(Token = "0x4013327")]
	[FieldOffset(Offset = "0x10")]
	private StoreOptionalBundleData m_StoreOptionalBundleData;

	[Token(Token = "0x4013328")]
	[FieldOffset(Offset = "0x14")]
	private List<TreasureBoxShowData> m_UniqueTreasureBoxData;

	[Token(Token = "0x4013329")]
	[FieldOffset(Offset = "0x18")]
	private SortedDictionary<uint, List<TreasureBoxShowData>> m_StoreTreasureBoxDict;

	[Token(Token = "0x1700166E")]
	public SortedDictionary<uint, List<BundleShowData>> StoreBundleDict
	{
		[Token(Token = "0x6015462")]
		[Address(RVA = "0x168C620", Offset = "0x168C620", VA = "0x168C620")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700166F")]
	public SortedDictionary<uint, List<OptionalBundleShowData>> StoreOptionalBundleDict
	{
		[Token(Token = "0x6015463")]
		[Address(RVA = "0x168C6EC", Offset = "0x168C6EC", VA = "0x168C6EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001670")]
	public SortedDictionary<uint, List<TreasureBoxShowData>> StoreTreasureBoxDict
	{
		[Token(Token = "0x6015464")]
		[Address(RVA = "0x168C7B8", Offset = "0x168C7B8", VA = "0x168C7B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6015465")]
		[Address(RVA = "0x168C810", Offset = "0x168C810", VA = "0x168C810")]
		set
		{
		}
	}

	[Token(Token = "0x6015461")]
	[Address(RVA = "0x168C340", Offset = "0x168C340", VA = "0x168C340")]
	public UIModelStoreBox()
	{
	}

	[Token(Token = "0x6015466")]
	[Address(RVA = "0x168C870", Offset = "0x168C870", VA = "0x168C870", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6015467")]
	[Address(RVA = "0x168C8C8", Offset = "0x168C8C8", VA = "0x168C8C8")]
	public void CSGetTreasureBoxRes(uint httpOp = 0u)
	{
	}

	[Token(Token = "0x6015468")]
	[Address(RVA = "0x168CAF0", Offset = "0x168CAF0", VA = "0x168CAF0")]
	private TreasureBoxShowData FindData(TreasureBoxData data)
	{
		return null;
	}

	[Token(Token = "0x6015469")]
	[Address(RVA = "0x168CD60", Offset = "0x168CD60", VA = "0x168CD60")]
	private TreasureBoxShowData FindData(TreasureBoxShowData data)
	{
		return null;
	}

	[Token(Token = "0x601546A")]
	[Address(RVA = "0x168CFBC", Offset = "0x168CFBC", VA = "0x168CFBC")]
	private TreasureBoxShowData FindData(CrateTreasureGroupDesc data)
	{
		return null;
	}

	[Token(Token = "0x601546B")]
	[Address(RVA = "0x168D1C4", Offset = "0x168D1C4", VA = "0x168D1C4")]
	public void AddLocalTreasureBoxData(TreasureBoxData data)
	{
	}

	[Token(Token = "0x601546C")]
	[Address(RVA = "0x168D518", Offset = "0x168D518", VA = "0x168D518")]
	public void ProcessTreasureBox(CSGetTreasureBoxRes treasureBoxRes)
	{
	}

	[Token(Token = "0x601546D")]
	[Address(RVA = "0x168DC34", Offset = "0x168DC34", VA = "0x168DC34")]
	public void GetBundleRes(uint httpOp = 0u)
	{
	}

	[Token(Token = "0x601546E")]
	[Address(RVA = "0x168DE5C", Offset = "0x168DE5C", VA = "0x168DE5C")]
	public void ProcessBundle(CSGetBundleRes bundleRes)
	{
	}

	[Token(Token = "0x601546F")]
	[Address(RVA = "0x168E2C0", Offset = "0x168E2C0", VA = "0x168E2C0")]
	public void ProcessOptionalBundle(CSGetOptionalBundleRes optionalBundleRes)
	{
	}

	[Token(Token = "0x6015470")]
	[Address(RVA = "0x168E604", Offset = "0x168E604", VA = "0x168E604")]
	public void ProcessLocalBundle(List<BundleData> bundleData)
	{
	}

	[Token(Token = "0x6015471")]
	[Address(RVA = "0x168EC08", Offset = "0x168EC08", VA = "0x168EC08")]
	public void ProcessLocalOptionalBundle(List<OptionalBundleData> optionalbundleData)
	{
	}

	[Token(Token = "0x6015472")]
	[Address(RVA = "0x168F1A8", Offset = "0x168F1A8", VA = "0x168F1A8")]
	public bool CheckHasInstallmentItemInBundle(uint bundleID)
	{
		return default(bool);
	}

	[Token(Token = "0x6015473")]
	[Address(RVA = "0x168F45C", Offset = "0x168F45C", VA = "0x168F45C")]
	public List<TreasureBoxShowData> GetTreasureBoxShowDataByID(uint boxID)
	{
		return null;
	}

	[Token(Token = "0x6015474")]
	[Address(RVA = "0x168F54C", Offset = "0x168F54C", VA = "0x168F54C", Slot = "12")]
	protected override void OnSceneChange(object[] data)
	{
	}

	[Token(Token = "0x6015475")]
	[Address(RVA = "0x168FEA0", Offset = "0x168FEA0", VA = "0x168FEA0")]
	private void _003CCSGetTreasureBoxRes_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6015476")]
	[Address(RVA = "0x168FFA8", Offset = "0x168FFA8", VA = "0x168FFA8")]
	private void _003CGetBundleRes_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6015477")]
	[Address(RVA = "0x16900B0", Offset = "0x16900B0", VA = "0x16900B0")]
	public void _003C_003EiFixBaseProxy_OnSceneChange(object[] P0)
	{
	}
}
