using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200016E")]
public class LevelExpData : CSVBaseData
{
	[Token(Token = "0x400093C")]
	[FieldOffset(Offset = "0x8")]
	public uint Level;

	[Token(Token = "0x400093D")]
	[FieldOffset(Offset = "0xC")]
	public uint MinExp;

	[Token(Token = "0x600086F")]
	[Address(RVA = "0xEBD2F8", Offset = "0xEBD2F8", VA = "0xEBD2F8")]
	public LevelExpData()
	{
	}

	[Token(Token = "0x6000870")]
	[Address(RVA = "0xEBD37C", Offset = "0xEBD37C", VA = "0xEBD37C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000871")]
	[Address(RVA = "0xEBD3E0", Offset = "0xEBD3E0", VA = "0xEBD3E0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
