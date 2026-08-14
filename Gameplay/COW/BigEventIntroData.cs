using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DAE")]
public class BigEventIntroData : CSVBaseData
{
	[Token(Token = "0x401188D")]
	[FieldOffset(Offset = "0x8")]
	public int eventID;

	[Token(Token = "0x401188E")]
	[FieldOffset(Offset = "0xC")]
	public int timing;

	[Token(Token = "0x401188F")]
	[FieldOffset(Offset = "0x10")]
	public string introDesc;

	[Token(Token = "0x60131F8")]
	[Address(RVA = "0x2E67BAC", Offset = "0x2E67BAC", VA = "0x2E67BAC")]
	public BigEventIntroData()
	{
	}

	[Token(Token = "0x60131F9")]
	[Address(RVA = "0x2E67C30", Offset = "0x2E67C30", VA = "0x2E67C30", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60131FA")]
	[Address(RVA = "0x2E67D30", Offset = "0x2E67D30", VA = "0x2E67D30", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
