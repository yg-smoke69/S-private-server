using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000111")]
public class DiamondSpendEventPriceDataManager : SingletonModule<DiamondSpendEventPriceDataManager>
{
	[Token(Token = "0x2000112")]
	private sealed class _003CGetDiamondSpendEventPriceDataByRegion_003Ec__AnonStorey0
	{
		[Token(Token = "0x40006EA")]
		[FieldOffset(Offset = "0x8")]
		internal string region;

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1C92FB8", Offset = "0x1C92FB8", VA = "0x1C92FB8")]
		public _003CGetDiamondSpendEventPriceDataByRegion_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1C9306C", Offset = "0x1C9306C", VA = "0x1C9306C")]
		internal bool _003C_003Em__0(DiamondSpendEventPriceData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40006E8")]
	[FieldOffset(Offset = "0xC")]
	private List<DiamondSpendEventPriceData> m_DataList;

	[Token(Token = "0x40006E9")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<DiamondSpendEventPriceData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x1C92B0C", Offset = "0x1C92B0C", VA = "0x1C92B0C")]
	public DiamondSpendEventPriceDataManager()
	{
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x1C92BD0", Offset = "0x1C92BD0", VA = "0x1C92BD0", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0x1C92CF4", Offset = "0x1C92CF4", VA = "0x1C92CF4", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0x1C92DB4", Offset = "0x1C92DB4", VA = "0x1C92DB4")]
	public DiamondSpendEventPriceData GetDiamondSpendEventPriceDataByRegion(string region)
	{
		return null;
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0x1C92FC0", Offset = "0x1C92FC0", VA = "0x1C92FC0")]
	private static bool _003CGetDiamondSpendEventPriceDataByRegion_003Em__0(DiamondSpendEventPriceData x)
	{
		return default(bool);
	}
}
