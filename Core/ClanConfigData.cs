using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x20000CF")]
public class ClanConfigData : CSVBaseData
{
	[Token(Token = "0x40004EA")]
	public const string PRIMARYKEY = "KEY";

	[Token(Token = "0x40004EB")]
	[FieldOffset(Offset = "0x8")]
	public int ClanMaxPendingApplications;

	[Token(Token = "0x40004EC")]
	[FieldOffset(Offset = "0xC")]
	public int PlayerMaxRequestsPerDay;

	[Token(Token = "0x40004ED")]
	[FieldOffset(Offset = "0x10")]
	public int MaxInviteNum;

	[Token(Token = "0x40004EE")]
	[FieldOffset(Offset = "0x14")]
	public int JoinDaysBeforeSignIn;

	[Token(Token = "0x40004EF")]
	[FieldOffset(Offset = "0x18")]
	public int ClanLogTimeMax;

	[Token(Token = "0x40004F0")]
	[FieldOffset(Offset = "0x1C")]
	public int ClanLogCntMax;

	[Token(Token = "0x40004F1")]
	[FieldOffset(Offset = "0x20")]
	public uint[] ClanPresetLevels;

	[Token(Token = "0x40004F2")]
	[FieldOffset(Offset = "0x24")]
	public uint[] ClanPresetRanks;

	[Token(Token = "0x40004F3")]
	[FieldOffset(Offset = "0x28")]
	public uint[] ClanPresetCSRanks;

	[Token(Token = "0x40004F4")]
	[FieldOffset(Offset = "0x2C")]
	public int CaptainOfflineDays;

	[Token(Token = "0x40004F5")]
	[FieldOffset(Offset = "0x30")]
	public int JoinDaysBeforeApplyForDeputy;

	[Token(Token = "0x40004F6")]
	[FieldOffset(Offset = "0x34")]
	public int DeputyOfflineDays;

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x230DEDC", Offset = "0x230DEDC", VA = "0x230DEDC")]
	public ClanConfigData()
	{
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x230DF60", Offset = "0x230DF60", VA = "0x230DF60", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x230DFBC", Offset = "0x230DFBC", VA = "0x230DFBC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
