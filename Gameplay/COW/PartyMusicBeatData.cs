using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001C9")]
public class PartyMusicBeatData : CSVBaseData
{
	[Token(Token = "0x4000AF5")]
	[FieldOffset(Offset = "0x8")]
	public float BeatTime;

	[Token(Token = "0x6000996")]
	[Address(RVA = "0x28D0A30", Offset = "0x28D0A30", VA = "0x28D0A30")]
	public PartyMusicBeatData()
	{
	}

	[Token(Token = "0x6000997")]
	[Address(RVA = "0x28D0AB4", Offset = "0x28D0AB4", VA = "0x28D0AB4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000998")]
	[Address(RVA = "0x28D0B18", Offset = "0x28D0B18", VA = "0x28D0B18", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
