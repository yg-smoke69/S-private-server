using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002749")]
public class UIHudFateRandomModeShowViewController : UIPopupWindowController
{
	[Token(Token = "0x200274A")]
	private sealed class _003CDelayClose_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F261")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudFateRandomModeShowViewController _0024this;

		[Token(Token = "0x400F262")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400F263")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400F264")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170011BE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600EFBA")]
			[Address(RVA = "0x1B9AEC4", Offset = "0x1B9AEC4", VA = "0x1B9AEC4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011BF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600EFBB")]
			[Address(RVA = "0x1B9AECC", Offset = "0x1B9AECC", VA = "0x1B9AECC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600EFB8")]
		[Address(RVA = "0x1B9AD7C", Offset = "0x1B9AD7C", VA = "0x1B9AD7C")]
		public _003CDelayClose_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600EFB9")]
		[Address(RVA = "0x1B9AD8C", Offset = "0x1B9AD8C", VA = "0x1B9AD8C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600EFBC")]
		[Address(RVA = "0x1B9AED4", Offset = "0x1B9AED4", VA = "0x1B9AED4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600EFBD")]
		[Address(RVA = "0x1B9AEE8", Offset = "0x1B9AEE8", VA = "0x1B9AEE8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F260")]
	[FieldOffset(Offset = "0x48")]
	private UIHudFateRandomModeShowView m_View;

	[Token(Token = "0x600EFB1")]
	[Address(RVA = "0x1B9A7E8", Offset = "0x1B9A7E8", VA = "0x1B9A7E8")]
	public UIHudFateRandomModeShowViewController()
	{
	}

	[Token(Token = "0x600EFB2")]
	[Address(RVA = "0x1B9A7F0", Offset = "0x1B9A7F0", VA = "0x1B9A7F0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EFB3")]
	[Address(RVA = "0x1B9A898", Offset = "0x1B9A898", VA = "0x1B9A898", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EFB4")]
	[Address(RVA = "0x1B9A9A0", Offset = "0x1B9A9A0", VA = "0x1B9A9A0")]
	private void ShowFateRandomTeamZone(object[] data)
	{
	}

	[Token(Token = "0x600EFB5")]
	[Address(RVA = "0x1B9AA0C", Offset = "0x1B9AA0C", VA = "0x1B9AA0C")]
	public void ShowModeInfo(DIEOGHJDNMJ msgModeId)
	{
	}

	[Token(Token = "0x600EFB6")]
	[Address(RVA = "0x1B9ACB0", Offset = "0x1B9ACB0", VA = "0x1B9ACB0")]
	private IEnumerator DelayClose()
	{
		return null;
	}

	[Token(Token = "0x600EFB7")]
	[Address(RVA = "0x1B9AD84", Offset = "0x1B9AD84", VA = "0x1B9AD84")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
