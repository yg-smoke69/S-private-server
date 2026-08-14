using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000142")]
internal class GameModeReportConfigData : CSVBaseData
{
	[Token(Token = "0x400082B")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x400082C")]
	[FieldOffset(Offset = "0xC")]
	public uint GameMode;

	[Token(Token = "0x400082D")]
	[FieldOffset(Offset = "0x10")]
	public uint[] MatchMode;

	[Token(Token = "0x400082E")]
	[FieldOffset(Offset = "0x14")]
	public uint[] GroupMode;

	[Token(Token = "0x400082F")]
	[FieldOffset(Offset = "0x18")]
	public uint[] ReportMainType;

	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x1DD6464", Offset = "0x1DD6464", VA = "0x1DD6464")]
	public GameModeReportConfigData()
	{
	}

	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x1DD64E8", Offset = "0x1DD64E8", VA = "0x1DD64E8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x1DD66B8", Offset = "0x1DD66B8", VA = "0x1DD66B8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
