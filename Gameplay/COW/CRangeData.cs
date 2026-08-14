using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E6C")]
public class CRangeData : _Attribute
{
	[Token(Token = "0x4011B9B")]
	[FieldOffset(Offset = "0x8")]
	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	[Token(Token = "0x4011B9C")]
	[FieldOffset(Offset = "0xC")]
	public ModeVariableBinding floatPrecision;

	[Token(Token = "0x4011B9D")]
	[FieldOffset(Offset = "0x10")]
	public ModeVariableBinding maxValue;

	[Token(Token = "0x4011B9E")]
	[FieldOffset(Offset = "0x14")]
	public ModeVariableBinding minValue;

	[Token(Token = "0x4011B9F")]
	[FieldOffset(Offset = "0x18")]
	public ModeVariableBinding step;

	[Token(Token = "0x4011BA0")]
	[FieldOffset(Offset = "0x1C")]
	public ModeVariableBinding value;

	[Token(Token = "0x4011BA1")]
	[FieldOffset(Offset = "0x20")]
	public string unitKey;

	[Token(Token = "0x4011BA2")]
	[FieldOffset(Offset = "0x24")]
	public bool IsFloat;

	[Token(Token = "0x17001421")]
	public GeneralComponentData GeneralData
	{
		[Token(Token = "0x6013673")]
		[Address(RVA = "0x1814F60", Offset = "0x1814F60", VA = "0x1814F60", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013674")]
		[Address(RVA = "0x1814FE0", Offset = "0x1814FE0", VA = "0x1814FE0", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6013672")]
	[Address(RVA = "0x1814EE8", Offset = "0x1814EE8", VA = "0x1814EE8")]
	public CRangeData()
	{
	}

	[Token(Token = "0x6013675")]
	[Address(RVA = "0x1820814", Offset = "0x1820814", VA = "0x1820814", Slot = "6")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
