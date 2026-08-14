using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200012E")]
public class FateRandomSubModeData : CSVBaseData
{
	[Token(Token = "0x40007BE")]
	[FieldOffset(Offset = "0x8")]
	public uint Id;

	[Token(Token = "0x40007BF")]
	[FieldOffset(Offset = "0xC")]
	public string IconName;

	[Token(Token = "0x40007C0")]
	[FieldOffset(Offset = "0x10")]
	public string ModeName;

	[Token(Token = "0x40007C1")]
	[FieldOffset(Offset = "0x14")]
	public string[] DescStrings;

	[Token(Token = "0x40007C2")]
	[FieldOffset(Offset = "0x18")]
	private string m_desc;

	[Token(Token = "0x6000753")]
	[Address(RVA = "0xDE4D58", Offset = "0xDE4D58", VA = "0xDE4D58")]
	public FateRandomSubModeData()
	{
	}

	[Token(Token = "0x6000754")]
	[Address(RVA = "0xDE4DDC", Offset = "0xDE4DDC", VA = "0xDE4DDC")]
	public string GetDesc()
	{
		return null;
	}

	[Token(Token = "0x6000755")]
	[Address(RVA = "0xDE5108", Offset = "0xDE5108", VA = "0xDE5108", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000756")]
	[Address(RVA = "0xDE516C", Offset = "0xDE516C", VA = "0xDE516C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
