using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E69")]
public class CToggleGroupData : _Attribute
{
	[Token(Token = "0x2002E6A")]
	public class ToggleItem
	{
		[Token(Token = "0x4011B93")]
		[FieldOffset(Offset = "0x8")]
		public string labelKey;

		[Token(Token = "0x4011B94")]
		[FieldOffset(Offset = "0xC")]
		public ModeVariableBinding value;

		[Token(Token = "0x4011B95")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x601366D")]
		[Address(RVA = "0x1721010", Offset = "0x1721010", VA = "0x1721010")]
		public ToggleItem()
		{
		}
	}

	[Token(Token = "0x4011B90")]
	[FieldOffset(Offset = "0x8")]
	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	[Token(Token = "0x4011B91")]
	[FieldOffset(Offset = "0xC")]
	public ModeVariableBinding value;

	[Token(Token = "0x4011B92")]
	[FieldOffset(Offset = "0x10")]
	public List<ToggleItem> items;

	[Token(Token = "0x1700141F")]
	public GeneralComponentData GeneralData
	{
		[Token(Token = "0x601366A")]
		[Address(RVA = "0x1720C34", Offset = "0x1720C34", VA = "0x1720C34", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x601366B")]
		[Address(RVA = "0x1720C3C", Offset = "0x1720C3C", VA = "0x1720C3C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6013669")]
	[Address(RVA = "0x1720C2C", Offset = "0x1720C2C", VA = "0x1720C2C")]
	public CToggleGroupData()
	{
	}

	[Token(Token = "0x601366C")]
	[Address(RVA = "0x1720C44", Offset = "0x1720C44", VA = "0x1720C44", Slot = "6")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
