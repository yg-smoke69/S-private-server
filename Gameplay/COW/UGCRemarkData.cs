using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000257")]
public class UGCRemarkData : CSVBaseData
{
	[Token(Token = "0x4000E37")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000E38")]
	[FieldOffset(Offset = "0xC")]
	public string key;

	[Token(Token = "0x6000BA5")]
	[Address(RVA = "0x29F5024", Offset = "0x29F5024", VA = "0x29F5024")]
	public UGCRemarkData()
	{
	}

	[Token(Token = "0x6000BA6")]
	[Address(RVA = "0x29F50A8", Offset = "0x29F50A8", VA = "0x29F50A8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BA7")]
	[Address(RVA = "0x29F510C", Offset = "0x29F510C", VA = "0x29F510C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
