using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E68")]
public class CToggleData : _Attribute
{
	[Token(Token = "0x4011B8E")]
	[FieldOffset(Offset = "0x8")]
	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	[Token(Token = "0x4011B8F")]
	[FieldOffset(Offset = "0xC")]
	public ModeVariableBinding value;

	[Token(Token = "0x1700141E")]
	public GeneralComponentData GeneralData
	{
		[Token(Token = "0x6013666")]
		[Address(RVA = "0x17209C0", Offset = "0x17209C0", VA = "0x17209C0", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013667")]
		[Address(RVA = "0x17209C8", Offset = "0x17209C8", VA = "0x17209C8", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6013665")]
	[Address(RVA = "0x17209B8", Offset = "0x17209B8", VA = "0x17209B8")]
	public CToggleData()
	{
	}

	[Token(Token = "0x6013668")]
	[Address(RVA = "0x17209D0", Offset = "0x17209D0", VA = "0x17209D0", Slot = "6")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
