using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001EB")]
public class PeriodicRankingDataDisplayDataManager : SingletonModule<PeriodicRankingDataDisplayDataManager>
{
	[Token(Token = "0x20001EC")]
	private sealed class _003CGetData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4000B79")]
		[FieldOffset(Offset = "0x8")]
		internal uint gameMode;

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x2DE02A8", Offset = "0x2DE02A8", VA = "0x2DE02A8")]
		public _003CGetData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x2DE02B0", Offset = "0x2DE02B0", VA = "0x2DE02B0")]
		internal bool _003C_003Em__0(PeriodicRankingDataDisplayData value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000B78")]
	[FieldOffset(Offset = "0xC")]
	private List<PeriodicRankingDataDisplayData> m_DataList;

	[Token(Token = "0x6000A15")]
	[Address(RVA = "0x2DDFEBC", Offset = "0x2DDFEBC", VA = "0x2DDFEBC")]
	public PeriodicRankingDataDisplayDataManager()
	{
	}

	[Token(Token = "0x6000A16")]
	[Address(RVA = "0x2DDFF4C", Offset = "0x2DDFF4C", VA = "0x2DDFF4C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000A17")]
	[Address(RVA = "0x2DE000C", Offset = "0x2DE000C", VA = "0x2DE000C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000A18")]
	[Address(RVA = "0x2DE0130", Offset = "0x2DE0130", VA = "0x2DE0130")]
	public PeriodicRankingDataDisplayData GetData(uint gameMode)
	{
		return null;
	}
}
