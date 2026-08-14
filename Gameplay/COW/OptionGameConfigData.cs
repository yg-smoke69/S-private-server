using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001C3")]
public class OptionGameConfigData : CSVBaseData
{
	[Token(Token = "0x4000AE3")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000AE4")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID SfxID;

	[Token(Token = "0x4000AE5")]
	[FieldOffset(Offset = "0x10")]
	public float time;

	[Token(Token = "0x600097D")]
	[Address(RVA = "0x28C7160", Offset = "0x28C7160", VA = "0x28C7160")]
	public OptionGameConfigData()
	{
	}

	[Token(Token = "0x600097E")]
	[Address(RVA = "0x28C722C", Offset = "0x28C722C", VA = "0x28C722C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600097F")]
	[Address(RVA = "0x28C7290", Offset = "0x28C7290", VA = "0x28C7290", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
