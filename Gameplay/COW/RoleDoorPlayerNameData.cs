using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F1F")]
public class RoleDoorPlayerNameData : CSVBaseData
{
	[Token(Token = "0x400C3DB")]
	[FieldOffset(Offset = "0x8")]
	public uint PlayerID;

	[Token(Token = "0x400C3DC")]
	[FieldOffset(Offset = "0xC")]
	public string PlayerName;

	[Token(Token = "0x6009933")]
	[Address(RVA = "0x240A60C", Offset = "0x240A60C", VA = "0x240A60C")]
	public RoleDoorPlayerNameData()
	{
	}

	[Token(Token = "0x6009934")]
	[Address(RVA = "0x240A690", Offset = "0x240A690", VA = "0x240A690", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6009935")]
	[Address(RVA = "0x240A768", Offset = "0x240A768", VA = "0x240A768", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
