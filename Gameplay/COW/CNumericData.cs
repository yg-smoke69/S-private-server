using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E6B")]
public class CNumericData : _Attribute
{
	[Token(Token = "0x4011B96")]
	[FieldOffset(Offset = "0x8")]
	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	[Token(Token = "0x4011B97")]
	[FieldOffset(Offset = "0xC")]
	public ModeVariableBinding maxValue;

	[Token(Token = "0x4011B98")]
	[FieldOffset(Offset = "0x10")]
	public ModeVariableBinding minValue;

	[Token(Token = "0x4011B99")]
	[FieldOffset(Offset = "0x14")]
	public ModeVariableBinding step;

	[Token(Token = "0x4011B9A")]
	[FieldOffset(Offset = "0x18")]
	public ModeVariableBinding value;

	[Token(Token = "0x17001420")]
	public GeneralComponentData GeneralData
	{
		[Token(Token = "0x601366F")]
		[Address(RVA = "0x1815B58", Offset = "0x1815B58", VA = "0x1815B58", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013670")]
		[Address(RVA = "0x1815B60", Offset = "0x1815B60", VA = "0x1815B60", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x601366E")]
	[Address(RVA = "0x1815B50", Offset = "0x1815B50", VA = "0x1815B50")]
	public CNumericData()
	{
	}

	[Token(Token = "0x6013671")]
	[Address(RVA = "0x1815B68", Offset = "0x1815B68", VA = "0x1815B68", Slot = "6")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
