using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000E7")]
public class WeaponScoreName : CSVBaseData
{
	[Token(Token = "0x40005C5")]
	[FieldOffset(Offset = "0x8")]
	public string scoreName;

	[Token(Token = "0x40005C6")]
	[FieldOffset(Offset = "0xC")]
	public uint scoreId;

	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x21A5F68", Offset = "0x21A5F68", VA = "0x21A5F68")]
	public WeaponScoreName()
	{
	}

	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x21A5FEC", Offset = "0x21A5FEC", VA = "0x21A5FEC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x21A6050", Offset = "0x21A6050", VA = "0x21A6050", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
