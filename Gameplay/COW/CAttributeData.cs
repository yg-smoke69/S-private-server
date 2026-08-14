using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E71")]
public class CAttributeData : _Attribute
{
	[Token(Token = "0x4011BB5")]
	[FieldOffset(Offset = "0x8")]
	public CRangeData RangeData;

	[Token(Token = "0x17001424")]
	public GeneralComponentData GeneralData
	{
		[Token(Token = "0x6013683")]
		[Address(RVA = "0x1814EF0", Offset = "0x1814EF0", VA = "0x1814EF0", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013684")]
		[Address(RVA = "0x1814F68", Offset = "0x1814F68", VA = "0x1814F68", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6013682")]
	[Address(RVA = "0x1814E6C", Offset = "0x1814E6C", VA = "0x1814E6C")]
	public CAttributeData()
	{
	}

	[Token(Token = "0x6013685")]
	[Address(RVA = "0x1814FE8", Offset = "0x1814FE8", VA = "0x1814FE8", Slot = "6")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
