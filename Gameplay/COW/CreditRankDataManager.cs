using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000FC")]
public class CreditRankDataManager : SingletonModule<CreditRankDataManager>
{
	[Token(Token = "0x20000FD")]
	private sealed class _003CGetData_003Ec__AnonStorey0
	{
		[Token(Token = "0x400065F")]
		[FieldOffset(Offset = "0x8")]
		internal uint score;

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1C8658C", Offset = "0x1C8658C", VA = "0x1C8658C")]
		public _003CGetData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1C86594", Offset = "0x1C86594", VA = "0x1C86594")]
		internal bool _003C_003Em__0(CreditRankData value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400065E")]
	[FieldOffset(Offset = "0xC")]
	private List<CreditRankData> m_DataList;

	[Token(Token = "0x600065A")]
	[Address(RVA = "0x1C86318", Offset = "0x1C86318", VA = "0x1C86318")]
	public CreditRankDataManager()
	{
	}

	[Token(Token = "0x600065B")]
	[Address(RVA = "0x1C863A8", Offset = "0x1C863A8", VA = "0x1C863A8", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x600065C")]
	[Address(RVA = "0x1C86468", Offset = "0x1C86468", VA = "0x1C86468", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600065D")]
	[Address(RVA = "0x1C8407C", Offset = "0x1C8407C", VA = "0x1C8407C")]
	public CreditRankData GetData(uint score)
	{
		return null;
	}
}
