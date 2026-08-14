using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E65")]
public class CVScrollTableContainerData : _Attribute
{
	[Token(Token = "0x4011B83")]
	[FieldOffset(Offset = "0x8")]
	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	[Token(Token = "0x4011B84")]
	[FieldOffset(Offset = "0xC")]
	public ModeVariableBinding height;

	[Token(Token = "0x4011B85")]
	[FieldOffset(Offset = "0x10")]
	public ModeVariableBinding visibleHeight;

	[Token(Token = "0x4011B86")]
	[FieldOffset(Offset = "0x14")]
	public ModeVariableBinding enableDragging;

	[Token(Token = "0x4011B87")]
	[FieldOffset(Offset = "0x18")]
	public List<IModeEditComponentData> items;

	[Token(Token = "0x1700141B")]
	public GeneralComponentData GeneralData
	{
		[Token(Token = "0x601365A")]
		[Address(RVA = "0x1721020", Offset = "0x1721020", VA = "0x1721020", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x601365B")]
		[Address(RVA = "0x1721028", Offset = "0x1721028", VA = "0x1721028", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6013659")]
	[Address(RVA = "0x1721018", Offset = "0x1721018", VA = "0x1721018")]
	public CVScrollTableContainerData()
	{
	}

	[Token(Token = "0x601365C")]
	[Address(RVA = "0x1721030", Offset = "0x1721030", VA = "0x1721030", Slot = "6")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
