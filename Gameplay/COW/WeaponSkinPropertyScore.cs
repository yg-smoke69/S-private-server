using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000E9")]
public class WeaponSkinPropertyScore : CSVBaseData
{
	[Token(Token = "0x40005C9")]
	[FieldOffset(Offset = "0x8")]
	public int[] Property;

	[Token(Token = "0x40005CA")]
	[FieldOffset(Offset = "0xC")]
	public string Region;

	[Token(Token = "0x40005CB")]
	[FieldOffset(Offset = "0x10")]
	public uint SkinID;

	[Token(Token = "0x6000601")]
	[Address(RVA = "0x21AA9B0", Offset = "0x21AA9B0", VA = "0x21AA9B0")]
	public WeaponSkinPropertyScore()
	{
	}

	[Token(Token = "0x6000602")]
	[Address(RVA = "0x21AAA34", Offset = "0x21AAA34", VA = "0x21AAA34", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000603")]
	[Address(RVA = "0x21AAA98", Offset = "0x21AAA98", VA = "0x21AAA98", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
