using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E09")]
public class EnemyCollectionInLeagueData : CSVBaseData
{
	[Token(Token = "0x4011A26")]
	[FieldOffset(Offset = "0x8")]
	public uint CollectionType;

	[Token(Token = "0x4011A27")]
	[FieldOffset(Offset = "0xC")]
	public uint[] CollectionID;

	[Token(Token = "0x6013488")]
	[Address(RVA = "0x2536994", Offset = "0x2536994", VA = "0x2536994")]
	public EnemyCollectionInLeagueData()
	{
	}

	[Token(Token = "0x6013489")]
	[Address(RVA = "0x2536A18", Offset = "0x2536A18", VA = "0x2536A18", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x601348A")]
	[Address(RVA = "0x2536A7C", Offset = "0x2536A7C", VA = "0x2536A7C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
