using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FEA")]
public class BountyBossHPController : UIBaseController
{
	[Token(Token = "0x2001FEB")]
	private sealed class _003CHPFullAnim_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C8C1")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CbeginTime_003E__0;

		[Token(Token = "0x400C8C2")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CpassTime_003E__0;

		[Token(Token = "0x400C8C3")]
		[FieldOffset(Offset = "0x10")]
		internal BountyBossHPController _0024this;

		[Token(Token = "0x400C8C4")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400C8C5")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400C8C6")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17000FCD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600A10B")]
			[Address(RVA = "0x180E764", Offset = "0x180E764", VA = "0x180E764", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FCE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A10C")]
			[Address(RVA = "0x180E76C", Offset = "0x180E76C", VA = "0x180E76C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A109")]
		[Address(RVA = "0x180DE94", Offset = "0x180DE94", VA = "0x180DE94")]
		public _003CHPFullAnim_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600A10A")]
		[Address(RVA = "0x180E5BC", Offset = "0x180E5BC", VA = "0x180E5BC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A10D")]
		[Address(RVA = "0x180E774", Offset = "0x180E774", VA = "0x180E774", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600A10E")]
		[Address(RVA = "0x180E788", Offset = "0x180E788", VA = "0x180E788", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001FEC")]
	private sealed class _003CDelayHideObject_003Ec__AnonStorey1
	{
		[Token(Token = "0x400C8C7")]
		[FieldOffset(Offset = "0x8")]
		internal GameObject obj;

		[Token(Token = "0x400C8C8")]
		[FieldOffset(Offset = "0xC")]
		internal bool isHide;

		[Token(Token = "0x600A10F")]
		[Address(RVA = "0x180E568", Offset = "0x180E568", VA = "0x180E568")]
		public _003CDelayHideObject_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600A110")]
		[Address(RVA = "0x180E580", Offset = "0x180E580", VA = "0x180E580")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400C8BF")]
	[FieldOffset(Offset = "0x28")]
	private UIHudBountyWaitingBossHPView m_View;

	[Token(Token = "0x400C8C0")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsPlayingAnim;

	[Token(Token = "0x600A0FE")]
	[Address(RVA = "0x180D750", Offset = "0x180D750", VA = "0x180D750")]
	public BountyBossHPController()
	{
	}

	[Token(Token = "0x600A0FF")]
	[Address(RVA = "0x180D7D4", Offset = "0x180D7D4", VA = "0x180D7D4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A100")]
	[Address(RVA = "0x180D87C", Offset = "0x180D87C", VA = "0x180D87C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A101")]
	[Address(RVA = "0x180DC90", Offset = "0x180DC90", VA = "0x180DC90", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A102")]
	[Address(RVA = "0x180DBC4", Offset = "0x180DBC4", VA = "0x180DBC4")]
	private IEnumerator HPFullAnim()
	{
		return null;
	}

	[Token(Token = "0x600A103")]
	[Address(RVA = "0x180DEA0", Offset = "0x180DEA0", VA = "0x180DEA0")]
	private void OnBossHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600A104")]
	[Address(RVA = "0x180E0D4", Offset = "0x180E0D4", VA = "0x180E0D4")]
	private void OnBossEnhance(object[] param)
	{
	}

	[Token(Token = "0x600A105")]
	[Address(RVA = "0x180E350", Offset = "0x180E350", VA = "0x180E350")]
	private void OnBossGod(object[] param)
	{
	}

	[Token(Token = "0x600A106")]
	[Address(RVA = "0x180E1A4", Offset = "0x180E1A4", VA = "0x180E1A4")]
	private void DelayHideObject(GameObject obj, float t, bool isHide = true)
	{
	}

	[Token(Token = "0x600A107")]
	[Address(RVA = "0x180E570", Offset = "0x180E570", VA = "0x180E570")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A108")]
	[Address(RVA = "0x180E578", Offset = "0x180E578", VA = "0x180E578")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
