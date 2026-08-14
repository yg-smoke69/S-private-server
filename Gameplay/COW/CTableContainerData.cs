using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E66")]
public class CTableContainerData : _Attribute
{
	[Token(Token = "0x4011B88")]
	[FieldOffset(Offset = "0x8")]
	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	[Token(Token = "0x4011B89")]
	[FieldOffset(Offset = "0xC")]
	public string subLabelKey;

	[Token(Token = "0x4011B8A")]
	[FieldOffset(Offset = "0x10")]
	public ModeVariableBinding autoBgExtension;

	[Token(Token = "0x4011B8B")]
	[FieldOffset(Offset = "0x14")]
	public ModeVariableBinding bgExtension;

	[Token(Token = "0x4011B8C")]
	[FieldOffset(Offset = "0x18")]
	public List<IModeEditComponentData> items;

	[Token(Token = "0x1700141C")]
	public GeneralComponentData GeneralData
	{
		[Token(Token = "0x601365E")]
		[Address(RVA = "0x182C3A0", Offset = "0x182C3A0", VA = "0x182C3A0", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x601365F")]
		[Address(RVA = "0x182C420", Offset = "0x182C420", VA = "0x182C420", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x601365D")]
	[Address(RVA = "0x182C328", Offset = "0x182C328", VA = "0x182C328")]
	public CTableContainerData()
	{
	}

	[Token(Token = "0x6013660")]
	[Address(RVA = "0x182C4C4", Offset = "0x182C4C4", VA = "0x182C4C4", Slot = "6")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
