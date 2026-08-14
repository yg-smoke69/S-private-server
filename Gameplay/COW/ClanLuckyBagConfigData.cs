using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000D3")]
public class ClanLuckyBagConfigData : CSVBaseData
{
	[Token(Token = "0x400050E")]
	public const string PRIMARYKEY = "key";

	[Token(Token = "0x400050F")]
	[FieldOffset(Offset = "0x8")]
	public uint EffectiveHours;

	[Token(Token = "0x4000510")]
	[FieldOffset(Offset = "0xC")]
	public uint MaxDrawNumPerDay;

	[Token(Token = "0x4000511")]
	[FieldOffset(Offset = "0x10")]
	public uint MaxBagsPerClan;

	[Token(Token = "0x4000512")]
	[FieldOffset(Offset = "0x14")]
	public uint GuildTokenItemID;

	[Token(Token = "0x4000513")]
	[FieldOffset(Offset = "0x18")]
	public uint FreezeHours;

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x172B060", Offset = "0x172B060", VA = "0x172B060")]
	public ClanLuckyBagConfigData()
	{
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x172B0E4", Offset = "0x172B0E4", VA = "0x172B0E4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x172B188", Offset = "0x172B188", VA = "0x172B188", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
