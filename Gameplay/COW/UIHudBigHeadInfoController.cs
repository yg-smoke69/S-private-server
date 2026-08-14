using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026EB")]
public class UIHudBigHeadInfoController : UIBaseController
{
	[Token(Token = "0x20026EC")]
	private sealed class _003CWaitAndShowTutorial_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F067")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudBigHeadInfoController _0024this;

		[Token(Token = "0x400F068")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400F069")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400F06A")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170011AE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600EC06")]
			[Address(RVA = "0x1DFEF34", Offset = "0x1DFEF34", VA = "0x1DFEF34", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011AF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600EC07")]
			[Address(RVA = "0x1DFEF3C", Offset = "0x1DFEF3C", VA = "0x1DFEF3C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600EC04")]
		[Address(RVA = "0x1DFE714", Offset = "0x1DFE714", VA = "0x1DFE714")]
		public _003CWaitAndShowTutorial_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600EC05")]
		[Address(RVA = "0x1DFEDB8", Offset = "0x1DFEDB8", VA = "0x1DFEDB8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600EC08")]
		[Address(RVA = "0x1DFEF44", Offset = "0x1DFEF44", VA = "0x1DFEF44", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600EC09")]
		[Address(RVA = "0x1DFEF58", Offset = "0x1DFEF58", VA = "0x1DFEF58", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F061")]
	[FieldOffset(Offset = "0x28")]
	private UIHudBigHeadInfoView m_View;

	[Token(Token = "0x400F062")]
	[FieldOffset(Offset = "0x2C")]
	private StringBuilder m_TimeString;

	[Token(Token = "0x400F063")]
	[FieldOffset(Offset = "0x30")]
	private StringBuilder m_ScoreString;

	[Token(Token = "0x400F064")]
	[FieldOffset(Offset = "0x34")]
	private int m_TotalScore;

	[Token(Token = "0x400F065")]
	[FieldOffset(Offset = "0x38")]
	private int m_TotalTime;

	[Token(Token = "0x400F066")]
	[FieldOffset(Offset = "0x3C")]
	private int m_Secs;

	[Token(Token = "0x170011AD")]
	private int CurrentScore
	{
		[Token(Token = "0x600EC00")]
		[Address(RVA = "0x1DFE350", Offset = "0x1DFE350", VA = "0x1DFE350")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600EBF5")]
	[Address(RVA = "0x1DFDD24", Offset = "0x1DFDD24", VA = "0x1DFDD24")]
	public UIHudBigHeadInfoController()
	{
	}

	[Token(Token = "0x600EBF6")]
	[Address(RVA = "0x1DFDDA8", Offset = "0x1DFDDA8", VA = "0x1DFDDA8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EBF7")]
	[Address(RVA = "0x1DFDE4C", Offset = "0x1DFDE4C", VA = "0x1DFDE4C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EBF8")]
	[Address(RVA = "0x1DFE5D8", Offset = "0x1DFE5D8", VA = "0x1DFE5D8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600EBF9")]
	[Address(RVA = "0x1DFE648", Offset = "0x1DFE648", VA = "0x1DFE648")]
	private IEnumerator WaitAndShowTutorial()
	{
		return null;
	}

	[Token(Token = "0x600EBFA")]
	[Address(RVA = "0x1DFE71C", Offset = "0x1DFE71C", VA = "0x1DFE71C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EBFB")]
	[Address(RVA = "0x1DFE8B8", Offset = "0x1DFE8B8", VA = "0x1DFE8B8")]
	private void OnScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600EBFC")]
	[Address(RVA = "0x1DFEB28", Offset = "0x1DFEB28", VA = "0x1DFEB28")]
	private void OnLeadingScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600EBFD")]
	[Address(RVA = "0x1DFEC68", Offset = "0x1DFEC68", VA = "0x1DFEC68")]
	private void Update()
	{
	}

	[Token(Token = "0x600EBFE")]
	[Address(RVA = "0x1DFE0B4", Offset = "0x1DFE0B4", VA = "0x1DFE0B4")]
	private void UpdateTime()
	{
	}

	[Token(Token = "0x600EBFF")]
	[Address(RVA = "0x1DFE480", Offset = "0x1DFE480", VA = "0x1DFE480")]
	private void UpdateScore(int score)
	{
	}

	[Token(Token = "0x600EC01")]
	[Address(RVA = "0x1DFEDA0", Offset = "0x1DFEDA0", VA = "0x1DFEDA0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EC02")]
	[Address(RVA = "0x1DFEDA8", Offset = "0x1DFEDA8", VA = "0x1DFEDA8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600EC03")]
	[Address(RVA = "0x1DFEDB0", Offset = "0x1DFEDB0", VA = "0x1DFEDB0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
