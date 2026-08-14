using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20030B4")]
public class InventoryClothShowingInfo : _Attribute
{
	[Token(Token = "0x20030B5")]
	private sealed class _003CGetClothInfoById_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012865")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x601463D")]
		[Address(RVA = "0x1EE0B5C", Offset = "0x1EE0B5C", VA = "0x1EE0B5C")]
		public _003CGetClothInfoById_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601463E")]
		[Address(RVA = "0x1EE179C", Offset = "0x1EE179C", VA = "0x1EE179C")]
		internal bool _003C_003Em__0(InventoryClothInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012861")]
	[FieldOffset(Offset = "0x8")]
	private bool _003CIsLegend_003Ek__BackingField;

	[Token(Token = "0x4012862")]
	[FieldOffset(Offset = "0xC")]
	private uint _003CLegendType_003Ek__BackingField;

	[Token(Token = "0x4012863")]
	[FieldOffset(Offset = "0x10")]
	private List<InventoryClothInfo> _003CClothes_003Ek__BackingField;

	[Token(Token = "0x4012864")]
	[FieldOffset(Offset = "0x14")]
	public int CurrentLevel;

	[Token(Token = "0x1700152F")]
	public bool IsLegend
	{
		[Token(Token = "0x601462B")]
		[Address(RVA = "0x1EE0990", Offset = "0x1EE0990", VA = "0x1EE0990")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601462C")]
		[Address(RVA = "0x1EE0970", Offset = "0x1EE0970", VA = "0x1EE0970")]
		private set
		{
		}
	}

	[Token(Token = "0x17001530")]
	public uint LegendType
	{
		[Token(Token = "0x601462D")]
		[Address(RVA = "0x1EE0998", Offset = "0x1EE0998", VA = "0x1EE0998")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601462E")]
		[Address(RVA = "0x1EE0988", Offset = "0x1EE0988", VA = "0x1EE0988")]
		private set
		{
		}
	}

	[Token(Token = "0x17001531")]
	public List<InventoryClothInfo> Clothes
	{
		[Token(Token = "0x601462F")]
		[Address(RVA = "0x1EE0980", Offset = "0x1EE0980", VA = "0x1EE0980")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014630")]
		[Address(RVA = "0x1EE0978", Offset = "0x1EE0978", VA = "0x1EE0978")]
		private set
		{
		}
	}

	[Token(Token = "0x601462A")]
	[Address(RVA = "0x1EE0830", Offset = "0x1EE0830", VA = "0x1EE0830")]
	public InventoryClothShowingInfo(bool isLegend, [Optional] InventoryClothInfo info)
	{
	}

	[Token(Token = "0x6014631")]
	[Address(RVA = "0x1EE09A0", Offset = "0x1EE09A0", VA = "0x1EE09A0")]
	public bool HaveId(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014632")]
	[Address(RVA = "0x1EE0A14", Offset = "0x1EE0A14", VA = "0x1EE0A14")]
	private InventoryClothInfo GetClothInfoById(uint id)
	{
		return null;
	}

	[Token(Token = "0x6014633")]
	[Address(RVA = "0x1EE0B64", Offset = "0x1EE0B64", VA = "0x1EE0B64")]
	public void PickId(uint legendType, uint id)
	{
	}

	[Token(Token = "0x6014634")]
	[Address(RVA = "0x1EE0ECC", Offset = "0x1EE0ECC", VA = "0x1EE0ECC")]
	public void SetType(uint type)
	{
	}

	[Token(Token = "0x6014635")]
	[Address(RVA = "0x1EE0F2C", Offset = "0x1EE0F2C", VA = "0x1EE0F2C")]
	public void Add(InventoryClothInfo cloth)
	{
	}

	[Token(Token = "0x6014636")]
	[Address(RVA = "0x1EE0D0C", Offset = "0x1EE0D0C", VA = "0x1EE0D0C")]
	public void PickLevel(int legendType, int level)
	{
	}

	[Token(Token = "0x6014637")]
	[Address(RVA = "0x1EE14AC", Offset = "0x1EE14AC", VA = "0x1EE14AC")]
	public int GetCurrentClothLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6014638")]
	[Address(RVA = "0x1EE1504", Offset = "0x1EE1504", VA = "0x1EE1504")]
	public InventoryClothInfo GetCurrentClothData()
	{
		return null;
	}

	[Token(Token = "0x6014639")]
	[Address(RVA = "0x1EE13A4", Offset = "0x1EE13A4", VA = "0x1EE13A4")]
	public InventoryClothInfo GetClothDataByLevel(int level)
	{
		return null;
	}

	[Token(Token = "0x601463A")]
	[Address(RVA = "0x1EE1578", Offset = "0x1EE1578", VA = "0x1EE1578", Slot = "4")]
	public int CompareTo(InventoryClothShowingInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x601463B")]
	[Address(RVA = "0x1EE129C", Offset = "0x1EE129C", VA = "0x1EE129C")]
	private void SortByLevel()
	{
	}

	[Token(Token = "0x601463C")]
	[Address(RVA = "0x1EE1620", Offset = "0x1EE1620", VA = "0x1EE1620")]
	private int CompareLevel(InventoryClothInfo left, InventoryClothInfo right)
	{
		return default(int);
	}
}
