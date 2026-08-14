using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E16")]
internal class ReportConfigDataManager : SingletonModule<ReportConfigDataManager>
{
	[Token(Token = "0x4011A49")]
	[FieldOffset(Offset = "0xC")]
	private List<GameModeReportConfigData> m_GameModeReportList;

	[Token(Token = "0x4011A4A")]
	[FieldOffset(Offset = "0x10")]
	private List<ReportMainTypeConfigData> m_ReportMainTypeList;

	[Token(Token = "0x60134BE")]
	[Address(RVA = "0x2405170", Offset = "0x2405170", VA = "0x2405170")]
	public ReportConfigDataManager()
	{
	}

	[Token(Token = "0x60134BF")]
	[Address(RVA = "0x2405268", Offset = "0x2405268", VA = "0x2405268", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60134C0")]
	[Address(RVA = "0x24053F0", Offset = "0x24053F0", VA = "0x24053F0", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60134C1")]
	[Address(RVA = "0x24054DC", Offset = "0x24054DC", VA = "0x24054DC")]
	public List<uint> GetReportMainTypes(uint gameMode, uint matchMode, uint groupMode)
	{
		return null;
	}

	[Token(Token = "0x60134C2")]
	[Address(RVA = "0x240595C", Offset = "0x240595C", VA = "0x240595C")]
	public List<uint> GetReportTypeByMainType(uint type)
	{
		return null;
	}

	[Token(Token = "0x60134C3")]
	[Address(RVA = "0x2405DC4", Offset = "0x2405DC4", VA = "0x2405DC4")]
	public uint GetReportMainTypeByReportType(uint reportType)
	{
		return default(uint);
	}
}
