using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000182")]
public class LobbyBgSwitchData : CSVBaseData
{
	[Token(Token = "0x400098B")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400098C")]
	[FieldOffset(Offset = "0xC")]
	public uint iID;

	[Token(Token = "0x400098D")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID resource;

	[Token(Token = "0x60008B1")]
	[Address(RVA = "0xECF4C4", Offset = "0xECF4C4", VA = "0xECF4C4")]
	public LobbyBgSwitchData()
	{
	}

	[Token(Token = "0x60008B2")]
	[Address(RVA = "0xECF548", Offset = "0xECF548", VA = "0xECF548", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008B3")]
	[Address(RVA = "0xECF5AC", Offset = "0xECF5AC", VA = "0xECF5AC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
