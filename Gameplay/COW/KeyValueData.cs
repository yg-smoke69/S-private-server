using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000164")]
public class KeyValueData : CSVBaseData
{
	[Token(Token = "0x40008F7")]
	[FieldOffset(Offset = "0x8")]
	public string Name;

	[Token(Token = "0x40008F8")]
	[FieldOffset(Offset = "0xC")]
	public object Value;

	[Token(Token = "0x6000856")]
	[Address(RVA = "0x1EE7DC8", Offset = "0x1EE7DC8", VA = "0x1EE7DC8")]
	public KeyValueData()
	{
	}

	[Token(Token = "0x6000857")]
	[Address(RVA = "0x1EE7E4C", Offset = "0x1EE7E4C", VA = "0x1EE7E4C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000858")]
	[Address(RVA = "0x1EE7ECC", Offset = "0x1EE7ECC", VA = "0x1EE7ECC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
