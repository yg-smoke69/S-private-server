using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E67")]
public class CSubTableContainerData : _Attribute
{
	[Token(Token = "0x4011B8D")]
	[FieldOffset(Offset = "0x8")]
	public CTableContainerData TableContainerData;

	[Token(Token = "0x1700141D")]
	public GeneralComponentData GeneralData
	{
		[Token(Token = "0x6013662")]
		[Address(RVA = "0x182C330", Offset = "0x182C330", VA = "0x182C330", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013663")]
		[Address(RVA = "0x182C3A8", Offset = "0x182C3A8", VA = "0x182C3A8", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6013661")]
	[Address(RVA = "0x182C2AC", Offset = "0x182C2AC", VA = "0x182C2AC")]
	public CSubTableContainerData()
	{
	}

	[Token(Token = "0x6013664")]
	[Address(RVA = "0x182C428", Offset = "0x182C428", VA = "0x182C428", Slot = "6")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
