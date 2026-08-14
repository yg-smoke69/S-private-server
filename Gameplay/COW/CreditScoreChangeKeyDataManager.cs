using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000102")]
public class CreditScoreChangeKeyDataManager : SingletonModule<CreditScoreChangeKeyDataManager>
{
	[Token(Token = "0x2000103")]
	private sealed class _003CGetData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x8")]
		internal uint reasonId;

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1C86BEC", Offset = "0x1C86BEC", VA = "0x1C86BEC")]
		public _003CGetData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1C86BF4", Offset = "0x1C86BF4", VA = "0x1C86BF4")]
		internal bool _003C_003Em__0(CreditScoreChangeKeyData value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000670")]
	[FieldOffset(Offset = "0xC")]
	private List<CreditScoreChangeKeyData> m_DataList;

	[Token(Token = "0x6000686")]
	[Address(RVA = "0x1C86800", Offset = "0x1C86800", VA = "0x1C86800")]
	public CreditScoreChangeKeyDataManager()
	{
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0x1C86890", Offset = "0x1C86890", VA = "0x1C86890", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000688")]
	[Address(RVA = "0x1C86950", Offset = "0x1C86950", VA = "0x1C86950", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000689")]
	[Address(RVA = "0x1C86A74", Offset = "0x1C86A74", VA = "0x1C86A74")]
	public CreditScoreChangeKeyData GetData(uint reasonId)
	{
		return null;
	}
}
