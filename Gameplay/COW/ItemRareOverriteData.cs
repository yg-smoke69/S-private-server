using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000161")]
public class ItemRareOverriteData : CSVBaseData, _Attribute
{
	[Token(Token = "0x40008F0")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40008F1")]
	[FieldOffset(Offset = "0xC")]
	public uint Quality;

	[Token(Token = "0x600084E")]
	[Address(RVA = "0x1EE2934", Offset = "0x1EE2934", VA = "0x1EE2934")]
	public ItemRareOverriteData()
	{
	}

	[Token(Token = "0x600084F")]
	[Address(RVA = "0x1EE29B8", Offset = "0x1EE29B8", VA = "0x1EE29B8", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000850")]
	[Address(RVA = "0x1EE2A10", Offset = "0x1EE2A10", VA = "0x1EE2A10", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000851")]
	[Address(RVA = "0x1EE2A74", Offset = "0x1EE2A74", VA = "0x1EE2A74", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
