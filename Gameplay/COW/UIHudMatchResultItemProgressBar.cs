using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200224B")]
public class UIHudMatchResultItemProgressBar : MonoBehaviour
{
	[Token(Token = "0x200224C")]
	private sealed class _003CCoProcessBar_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D6C8")]
		[FieldOffset(Offset = "0x8")]
		internal float from;

		[Token(Token = "0x400D6C9")]
		[FieldOffset(Offset = "0xC")]
		internal float to;

		[Token(Token = "0x400D6CA")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudMatchResultItemProgressBar _0024this;

		[Token(Token = "0x400D6CB")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400D6CC")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400D6CD")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17001080")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600BAB3")]
			[Address(RVA = "0x19B9150", Offset = "0x19B9150", VA = "0x19B9150", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001081")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BAB4")]
			[Address(RVA = "0x19B9158", Offset = "0x19B9158", VA = "0x19B9158", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BAB1")]
		[Address(RVA = "0x19B904C", Offset = "0x19B904C", VA = "0x19B904C")]
		public _003CCoProcessBar_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600BAB2")]
		[Address(RVA = "0x19B9054", Offset = "0x19B9054", VA = "0x19B9054", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BAB5")]
		[Address(RVA = "0x19B9160", Offset = "0x19B9160", VA = "0x19B9160", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600BAB6")]
		[Address(RVA = "0x19B9174", Offset = "0x19B9174", VA = "0x19B9174", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D6C4")]
	[FieldOffset(Offset = "0xC")]
	public UIProgressBar m_Bar;

	[Token(Token = "0x400D6C5")]
	[FieldOffset(Offset = "0x10")]
	public UISprite m_ImgBar;

	[Token(Token = "0x400D6C6")]
	[FieldOffset(Offset = "0x14")]
	public UILabel m_LabelValue;

	[Token(Token = "0x400D6C7")]
	[FieldOffset(Offset = "0x18")]
	public UILabel m_LabelPercent;

	[Token(Token = "0x600BAAD")]
	[Address(RVA = "0x19B8E6C", Offset = "0x19B8E6C", VA = "0x19B8E6C")]
	public UIHudMatchResultItemProgressBar()
	{
	}

	[Token(Token = "0x600BAAE")]
	[Address(RVA = "0x19B8E74", Offset = "0x19B8E74", VA = "0x19B8E74")]
	public void SetBarColor(Color color)
	{
	}

	[Token(Token = "0x600BAAF")]
	[Address(RVA = "0x19B8F28", Offset = "0x19B8F28", VA = "0x19B8F28")]
	private IEnumerator CoProcessBar(float from, float to)
	{
		return null;
	}

	[Token(Token = "0x600BAB0")]
	[Address(RVA = "0x19B8B3C", Offset = "0x19B8B3C", VA = "0x19B8B3C")]
	public void UpdateInfo(int myValue, int totalValue)
	{
	}
}
