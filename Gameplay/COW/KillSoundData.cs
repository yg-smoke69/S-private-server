using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000165")]
public class KillSoundData : CSVBaseData
{
	[Token(Token = "0x40008F9")]
	[FieldOffset(Offset = "0x8")]
	public ResourceID SoundID;

	[Token(Token = "0x6000859")]
	[Address(RVA = "0x1EE8EF4", Offset = "0x1EE8EF4", VA = "0x1EE8EF4")]
	public KillSoundData()
	{
	}

	[Token(Token = "0x600085A")]
	[Address(RVA = "0x1EE8F78", Offset = "0x1EE8F78", VA = "0x1EE8F78", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600085B")]
	[Address(RVA = "0x1EE8FDC", Offset = "0x1EE8FDC", VA = "0x1EE8FDC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
