using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002248")]
public class UIHudMatchResultBaseRewardController : UIBaseController
{
	[Token(Token = "0x2002249")]
	private sealed class _003CScrollCoinCount_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D69D")]
		[FieldOffset(Offset = "0x8")]
		internal int _003CcurCount_003E__0;

		[Token(Token = "0x400D69E")]
		[FieldOffset(Offset = "0xC")]
		internal uint coinCount;

		[Token(Token = "0x400D69F")]
		[FieldOffset(Offset = "0x10")]
		internal int _003CFinalCount_003E__0;

		[Token(Token = "0x400D6A0")]
		[FieldOffset(Offset = "0x14")]
		internal float _003CChangeTime_003E__0;

		[Token(Token = "0x400D6A1")]
		[FieldOffset(Offset = "0x18")]
		internal float _003CdeltaCount_003E__0;

		[Token(Token = "0x400D6A2")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003CNowCount_003E__1;

		[Token(Token = "0x400D6A3")]
		[FieldOffset(Offset = "0x20")]
		internal UIHudMatchResultBaseRewardController _0024this;

		[Token(Token = "0x400D6A4")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x400D6A5")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0024disposing;

		[Token(Token = "0x400D6A6")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x1700106D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600BA72")]
			[Address(RVA = "0x19AEB10", Offset = "0x19AEB10", VA = "0x19AEB10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700106E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BA73")]
			[Address(RVA = "0x19AEB18", Offset = "0x19AEB18", VA = "0x19AEB18", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BA70")]
		[Address(RVA = "0x19AE004", Offset = "0x19AE004", VA = "0x19AE004")]
		public _003CScrollCoinCount_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600BA71")]
		[Address(RVA = "0x19AE824", Offset = "0x19AE824", VA = "0x19AE824", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BA74")]
		[Address(RVA = "0x19AEB20", Offset = "0x19AEB20", VA = "0x19AEB20", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600BA75")]
		[Address(RVA = "0x19AEB34", Offset = "0x19AEB34", VA = "0x19AEB34", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D69A")]
	[FieldOffset(Offset = "0x28")]
	private UIHudMatchResultBaseRewardView m_View;

	[Token(Token = "0x400D69B")]
	[FieldOffset(Offset = "0x2C")]
	private MatchResultDetailInfo m_DetailInfo;

	[Token(Token = "0x400D69C")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_CoinCount;

	[Token(Token = "0x600BA61")]
	[Address(RVA = "0x19AD738", Offset = "0x19AD738", VA = "0x19AD738")]
	public UIHudMatchResultBaseRewardController()
	{
	}

	[Token(Token = "0x600BA62")]
	[Address(RVA = "0x19AD7BC", Offset = "0x19AD7BC", VA = "0x19AD7BC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BA63")]
	[Address(RVA = "0x19AD864", Offset = "0x19AD864", VA = "0x19AD864")]
	public void ShowRewardData(MatchIncome income)
	{
	}

	[Token(Token = "0x600BA64")]
	[Address(RVA = "0x19ADF18", Offset = "0x19ADF18", VA = "0x19ADF18")]
	private IEnumerator ScrollCoinCount(uint coinCount)
	{
		return null;
	}

	[Token(Token = "0x600BA65")]
	[Address(RVA = "0x19AE00C", Offset = "0x19AE00C", VA = "0x19AE00C")]
	public void ExecScrollCoin()
	{
	}

	[Token(Token = "0x600BA66")]
	[Address(RVA = "0x19AE09C", Offset = "0x19AE09C", VA = "0x19AE09C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BA67")]
	[Address(RVA = "0x19AE2F8", Offset = "0x19AE2F8", VA = "0x19AE2F8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BA68")]
	[Address(RVA = "0x19AE378", Offset = "0x19AE378", VA = "0x19AE378", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600BA69")]
	[Address(RVA = "0x19AE434", Offset = "0x19AE434", VA = "0x19AE434", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600BA6A")]
	[Address(RVA = "0x19AE4F0", Offset = "0x19AE4F0", VA = "0x19AE4F0")]
	private void OnClickDetailBtn()
	{
	}

	[Token(Token = "0x600BA6B")]
	[Address(RVA = "0x19AE720", Offset = "0x19AE720", VA = "0x19AE720")]
	private void OnClickDetailMaskBtn()
	{
	}

	[Token(Token = "0x600BA6C")]
	[Address(RVA = "0x19AE804", Offset = "0x19AE804", VA = "0x19AE804")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BA6D")]
	[Address(RVA = "0x19AE80C", Offset = "0x19AE80C", VA = "0x19AE80C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600BA6E")]
	[Address(RVA = "0x19AE814", Offset = "0x19AE814", VA = "0x19AE814")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600BA6F")]
	[Address(RVA = "0x19AE81C", Offset = "0x19AE81C", VA = "0x19AE81C")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
