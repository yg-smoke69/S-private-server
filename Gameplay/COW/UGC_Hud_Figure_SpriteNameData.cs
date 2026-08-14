using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000253")]
public class UGC_Hud_Figure_SpriteNameData : CSVBaseData
{
	[Token(Token = "0x4000E1D")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000E1E")]
	[FieldOffset(Offset = "0xC")]
	public string SpriteName;

	[Token(Token = "0x4000E1F")]
	[FieldOffset(Offset = "0x10")]
	public int SpriteType;

	[Token(Token = "0x6000B9A")]
	[Address(RVA = "0x29F5D94", Offset = "0x29F5D94", VA = "0x29F5D94")]
	public UGC_Hud_Figure_SpriteNameData()
	{
	}

	[Token(Token = "0x6000B9B")]
	[Address(RVA = "0x29F5E18", Offset = "0x29F5E18", VA = "0x29F5E18", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000B9C")]
	[Address(RVA = "0x29F5FD0", Offset = "0x29F5FD0", VA = "0x29F5FD0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B9D")]
	[Address(RVA = "0x29F6034", Offset = "0x29F6034", VA = "0x29F6034")]
	public static List<UGC_Hud_Figure_SpriteNameData> GetAllSpriteNameDataList()
	{
		return null;
	}

	[Token(Token = "0x6000B9E")]
	[Address(RVA = "0x29F6324", Offset = "0x29F6324", VA = "0x29F6324")]
	public static List<string> GetAllSpriteNames()
	{
		return null;
	}
}
