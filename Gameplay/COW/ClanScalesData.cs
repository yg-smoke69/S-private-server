using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000D5")]
public class ClanScalesData : CSVBaseData
{
	[Token(Token = "0x4000516")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0xC")]
	public uint MaxMember;

	[Token(Token = "0x4000518")]
	[FieldOffset(Offset = "0x10")]
	public uint GoldCost;

	[Token(Token = "0x4000519")]
	[FieldOffset(Offset = "0x14")]
	public uint DiamondCost;

	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x172C170", Offset = "0x172C170", VA = "0x172C170")]
	public ClanScalesData()
	{
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x172C1F4", Offset = "0x172C1F4", VA = "0x172C1F4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x172C258", Offset = "0x172C258", VA = "0x172C258", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
