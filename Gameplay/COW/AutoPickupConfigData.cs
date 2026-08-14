using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000A2")]
public class AutoPickupConfigData : CSVBaseData, _Attribute
{
	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0x8")]
	public int Id;

	[Token(Token = "0x400038D")]
	[FieldOffset(Offset = "0xC")]
	public uint[] ItemTypes;

	[Token(Token = "0x400038E")]
	[FieldOffset(Offset = "0x10")]
	public uint[] SubTypes;

	[Token(Token = "0x400038F")]
	[FieldOffset(Offset = "0x14")]
	public int[] MenuType;

	[Token(Token = "0x4000390")]
	[FieldOffset(Offset = "0x18")]
	public uint ItemId;

	[Token(Token = "0x4000391")]
	[FieldOffset(Offset = "0x1C")]
	public string LocKey;

	[Token(Token = "0x4000392")]
	[FieldOffset(Offset = "0x20")]
	public bool IsDefaultOpen;

	[Token(Token = "0x4000393")]
	[FieldOffset(Offset = "0x24")]
	public int InitialOrder;

	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0x28")]
	public int InitialNum;

	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0x2C")]
	public int PickupMin;

	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0x30")]
	public int PickupMax;

	[Token(Token = "0x4000397")]
	[FieldOffset(Offset = "0x34")]
	public int PickupUnit;

	[Token(Token = "0x4000398")]
	[FieldOffset(Offset = "0x38")]
	private int _003CParentID_003Ek__BackingField;

	[Token(Token = "0x4000399")]
	[FieldOffset(Offset = "0x3C")]
	private int _003CParentOrder_003Ek__BackingField;

	[Token(Token = "0x400039A")]
	[FieldOffset(Offset = "0x40")]
	private string primaryKey;

	[Token(Token = "0x400039B")]
	[FieldOffset(Offset = "0x44")]
	private string m_NewKey;

	[Token(Token = "0x400039C")]
	[FieldOffset(Offset = "0x48")]
	private string m_PlayerPrefOrderKey;

	[Token(Token = "0x400039D")]
	[FieldOffset(Offset = "0x4C")]
	private string m_PlayerPrefPickupNumKey;

	[Token(Token = "0x400039E")]
	[FieldOffset(Offset = "0x50")]
	private int _003CStateValue_003Ek__BackingField;

	[Token(Token = "0x400039F")]
	[FieldOffset(Offset = "0x54")]
	private int _003COrder_003Ek__BackingField;

	[Token(Token = "0x40003A0")]
	[FieldOffset(Offset = "0x58")]
	private int _003CPickupNum_003Ek__BackingField;

	[Token(Token = "0x170000A7")]
	public int ParentID
	{
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x10E53CC", Offset = "0x10E53CC", VA = "0x10E53CC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x10E53D4", Offset = "0x10E53D4", VA = "0x10E53D4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000A8")]
	public int ParentOrder
	{
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x10E53DC", Offset = "0x10E53DC", VA = "0x10E53DC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x10E53E4", Offset = "0x10E53E4", VA = "0x10E53E4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000A9")]
	public int StateValue
	{
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x10E53EC", Offset = "0x10E53EC", VA = "0x10E53EC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x10E53F4", Offset = "0x10E53F4", VA = "0x10E53F4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000AA")]
	public int Order
	{
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x10E53FC", Offset = "0x10E53FC", VA = "0x10E53FC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x10E5404", Offset = "0x10E5404", VA = "0x10E5404")]
		private set
		{
		}
	}

	[Token(Token = "0x170000AB")]
	public int PickupNum
	{
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x10E540C", Offset = "0x10E540C", VA = "0x10E540C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x10E5414", Offset = "0x10E5414", VA = "0x10E5414")]
		private set
		{
		}
	}

	[Token(Token = "0x170000AC")]
	public bool HasNoParent
	{
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x10E541C", Offset = "0x10E541C", VA = "0x10E541C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x10E5348", Offset = "0x10E5348", VA = "0x10E5348")]
	public AutoPickupConfigData()
	{
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x10E5488", Offset = "0x10E5488", VA = "0x10E5488", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x10E5C5C", Offset = "0x10E5C5C", VA = "0x10E5C5C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x10E5D34", Offset = "0x10E5D34", VA = "0x10E5D34")]
	public string GetNewKey()
	{
		return null;
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x10E5AC4", Offset = "0x10E5AC4", VA = "0x10E5AC4")]
	public void RefreshKeyState()
	{
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x10E5D8C", Offset = "0x10E5D8C", VA = "0x10E5D8C")]
	public void SetParent(AutoPickupConfigData parent)
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x10E5E24", Offset = "0x10E5E24", VA = "0x10E5E24")]
	public void SetPickupItemState(EAutoPickup open)
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x10E6094", Offset = "0x10E6094", VA = "0x10E6094")]
	public void SetPickupSpeedState(EAutoPickupSpeed speed)
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x10E6174", Offset = "0x10E6174", VA = "0x10E6174")]
	public void SetPickupStateValue(int value)
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x10E6254", Offset = "0x10E6254", VA = "0x10E6254")]
	public void SetPickupItemPriority(int priority)
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x10E651C", Offset = "0x10E651C", VA = "0x10E651C")]
	public void SetPickupItemNum(int pickupNum)
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x10E66D4", Offset = "0x10E66D4", VA = "0x10E66D4")]
	public void ResetPickupItemPreference()
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x10E6764", Offset = "0x10E6764", VA = "0x10E6764")]
	public int GetPickupNumberOfSteps()
	{
		return default(int);
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x10E67D4", Offset = "0x10E67D4", VA = "0x10E67D4")]
	public float PickupNumToFloat(int value)
	{
		return default(float);
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x10E686C", Offset = "0x10E686C", VA = "0x10E686C")]
	public bool CanAutoPickUp()
	{
		return default(bool);
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x10E63FC", Offset = "0x10E63FC", VA = "0x10E63FC")]
	public bool IsPickupSpeedConfig()
	{
		return default(bool);
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x10E6010", Offset = "0x10E6010", VA = "0x10E6010")]
	public bool ContainMenuItems()
	{
		return default(bool);
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x10E6670", Offset = "0x10E6670", VA = "0x10E6670")]
	public bool IsPickupNumAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x10E68D8", Offset = "0x10E68D8", VA = "0x10E68D8", Slot = "9")]
	public int CompareTo(object obj)
	{
		return default(int);
	}
}
