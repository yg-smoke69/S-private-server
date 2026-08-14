using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E70")]
public class CSafeZoneData : _Attribute
{
	[Token(Token = "0x4011BB2")]
	[FieldOffset(Offset = "0x8")]
	public CRangeData RangeData;

	[Token(Token = "0x4011BB3")]
	[FieldOffset(Offset = "0xC")]
	public ModeVariableBinding maxCircleSize;

	[Token(Token = "0x4011BB4")]
	[FieldOffset(Offset = "0x10")]
	public ModeVariableBinding minCircleSize;

	[Token(Token = "0x17001423")]
	public GeneralComponentData GeneralData
	{
		[Token(Token = "0x601367F")]
		[Address(RVA = "0x182C048", Offset = "0x182C048", VA = "0x182C048", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013680")]
		[Address(RVA = "0x182C0B8", Offset = "0x182C0B8", VA = "0x182C0B8", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x601367E")]
	[Address(RVA = "0x182BFCC", Offset = "0x182BFCC", VA = "0x182BFCC")]
	public CSafeZoneData()
	{
	}

	[Token(Token = "0x6013681")]
	[Address(RVA = "0x182C130", Offset = "0x182C130", VA = "0x182C130", Slot = "6")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
