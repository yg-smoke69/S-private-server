using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000155")]
public class IAPBundleStoreData : CSVBaseData
{
	[Token(Token = "0x4000891")]
	[FieldOffset(Offset = "0x8")]
	private int _003CStoreID_003Ek__BackingField;

	[Token(Token = "0x4000892")]
	[FieldOffset(Offset = "0xC")]
	private int _003CBundleID_003Ek__BackingField;

	[Token(Token = "0x4000893")]
	[FieldOffset(Offset = "0x10")]
	private int _003CProductID_OriginalPrice_003Ek__BackingField;

	[Token(Token = "0x4000894")]
	[FieldOffset(Offset = "0x14")]
	private float _003COriginalPrice_003Ek__BackingField;

	[Token(Token = "0x4000895")]
	[FieldOffset(Offset = "0x18")]
	private int _003CRebateID_ActualPrice_003Ek__BackingField;

	[Token(Token = "0x4000896")]
	[FieldOffset(Offset = "0x1C")]
	private int _003CProductID_ActualPrice_003Ek__BackingField;

	[Token(Token = "0x4000897")]
	[FieldOffset(Offset = "0x20")]
	private float _003CActualPrice_003Ek__BackingField;

	[Token(Token = "0x4000898")]
	[FieldOffset(Offset = "0x24")]
	private int _003CDiscountPercentage_003Ek__BackingField;

	[Token(Token = "0x4000899")]
	[FieldOffset(Offset = "0x28")]
	private string _003CSlogan_003Ek__BackingField;

	[Token(Token = "0x400089A")]
	[FieldOffset(Offset = "0x2C")]
	private int _003CDiamondPrice_003Ek__BackingField;

	[Token(Token = "0x400089B")]
	[FieldOffset(Offset = "0x30")]
	private int _003CDiscountDiamondPrice_003Ek__BackingField;

	[Token(Token = "0x400089C")]
	[FieldOffset(Offset = "0x34")]
	private int _003CDiamondBonus_003Ek__BackingField;

	[Token(Token = "0x400089D")]
	[FieldOffset(Offset = "0x38")]
	private EStoreType _003CStoreType_003Ek__BackingField;

	[Token(Token = "0x400089E")]
	[FieldOffset(Offset = "0x3C")]
	private string _003CWebLink_003Ek__BackingField;

	[Token(Token = "0x400089F")]
	[FieldOffset(Offset = "0x40")]
	private int _003CActivityId_003Ek__BackingField;

	[Token(Token = "0x1700012D")]
	public int StoreID
	{
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x2C6F4EC", Offset = "0x2C6F4EC", VA = "0x2C6F4EC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x2C6F4F4", Offset = "0x2C6F4F4", VA = "0x2C6F4F4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700012E")]
	public int BundleID
	{
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x2C6F4FC", Offset = "0x2C6F4FC", VA = "0x2C6F4FC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x2C6F504", Offset = "0x2C6F504", VA = "0x2C6F504")]
		private set
		{
		}
	}

	[Token(Token = "0x1700012F")]
	public int ProductID_OriginalPrice
	{
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x2C6F50C", Offset = "0x2C6F50C", VA = "0x2C6F50C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x2C6F514", Offset = "0x2C6F514", VA = "0x2C6F514")]
		private set
		{
		}
	}

	[Token(Token = "0x17000130")]
	public float OriginalPrice
	{
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x2C6F51C", Offset = "0x2C6F51C", VA = "0x2C6F51C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x2C6F524", Offset = "0x2C6F524", VA = "0x2C6F524")]
		private set
		{
		}
	}

	[Token(Token = "0x17000131")]
	public int RebateID_ActualPrice
	{
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x2C6F52C", Offset = "0x2C6F52C", VA = "0x2C6F52C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x2C6F534", Offset = "0x2C6F534", VA = "0x2C6F534")]
		private set
		{
		}
	}

	[Token(Token = "0x17000132")]
	public int ProductID_ActualPrice
	{
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x2C6F53C", Offset = "0x2C6F53C", VA = "0x2C6F53C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x2C6F544", Offset = "0x2C6F544", VA = "0x2C6F544")]
		private set
		{
		}
	}

	[Token(Token = "0x17000133")]
	public float ActualPrice
	{
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x2C6F54C", Offset = "0x2C6F54C", VA = "0x2C6F54C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x2C6F554", Offset = "0x2C6F554", VA = "0x2C6F554")]
		private set
		{
		}
	}

	[Token(Token = "0x17000134")]
	public int DiscountPercentage
	{
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x2C6F55C", Offset = "0x2C6F55C", VA = "0x2C6F55C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x2C6F564", Offset = "0x2C6F564", VA = "0x2C6F564")]
		private set
		{
		}
	}

	[Token(Token = "0x17000135")]
	public string Slogan
	{
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x2C6F56C", Offset = "0x2C6F56C", VA = "0x2C6F56C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x2C6F574", Offset = "0x2C6F574", VA = "0x2C6F574")]
		private set
		{
		}
	}

	[Token(Token = "0x17000136")]
	public int DiamondPrice
	{
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x2C6F57C", Offset = "0x2C6F57C", VA = "0x2C6F57C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x2C6F584", Offset = "0x2C6F584", VA = "0x2C6F584")]
		private set
		{
		}
	}

	[Token(Token = "0x17000137")]
	public int DiscountDiamondPrice
	{
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x2C6F58C", Offset = "0x2C6F58C", VA = "0x2C6F58C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x2C6F594", Offset = "0x2C6F594", VA = "0x2C6F594")]
		private set
		{
		}
	}

	[Token(Token = "0x17000138")]
	public int DiamondBonus
	{
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x2C6F59C", Offset = "0x2C6F59C", VA = "0x2C6F59C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x2C6F5A4", Offset = "0x2C6F5A4", VA = "0x2C6F5A4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000139")]
	public EStoreType StoreType
	{
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x2C6F5AC", Offset = "0x2C6F5AC", VA = "0x2C6F5AC")]
		get
		{
			return default(EStoreType);
		}
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x2C6F5B4", Offset = "0x2C6F5B4", VA = "0x2C6F5B4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700013A")]
	public string WebLink
	{
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x2C6F5BC", Offset = "0x2C6F5BC", VA = "0x2C6F5BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x2C6F5C4", Offset = "0x2C6F5C4", VA = "0x2C6F5C4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700013B")]
	public int ActivityId
	{
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x2C6F5CC", Offset = "0x2C6F5CC", VA = "0x2C6F5CC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x2C6F5D4", Offset = "0x2C6F5D4", VA = "0x2C6F5D4")]
		private set
		{
		}
	}

	[Token(Token = "0x60007ED")]
	[Address(RVA = "0x2C6F468", Offset = "0x2C6F468", VA = "0x2C6F468")]
	public IAPBundleStoreData()
	{
	}

	[Token(Token = "0x600080C")]
	[Address(RVA = "0x2C6F5DC", Offset = "0x2C6F5DC", VA = "0x2C6F5DC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600080D")]
	[Address(RVA = "0x2C6F658", Offset = "0x2C6F658", VA = "0x2C6F658", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
