using System;
using System.Collections;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200279E")]
internal class UIHudKilledController : UIBaseController, _Attribute
{
	[Token(Token = "0x200279F")]
	private sealed class _003CRemoveKillHint_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F49D")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x400F49E")]
		[FieldOffset(Offset = "0xC")]
		internal GameObject hint_object;

		[Token(Token = "0x400F49F")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudKilledController _0024this;

		[Token(Token = "0x400F4A0")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400F4A1")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400F4A2")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x170011D3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600F443")]
			[Address(RVA = "0x1BBD7B0", Offset = "0x1BBD7B0", VA = "0x1BBD7B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011D4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600F444")]
			[Address(RVA = "0x1BBD7B8", Offset = "0x1BBD7B8", VA = "0x1BBD7B8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600F441")]
		[Address(RVA = "0x1BBBD2C", Offset = "0x1BBBD2C", VA = "0x1BBBD2C")]
		public _003CRemoveKillHint_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600F442")]
		[Address(RVA = "0x1BBD658", Offset = "0x1BBD658", VA = "0x1BBD658", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600F445")]
		[Address(RVA = "0x1BBD7C0", Offset = "0x1BBD7C0", VA = "0x1BBD7C0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600F446")]
		[Address(RVA = "0x1BBD7D4", Offset = "0x1BBD7D4", VA = "0x1BBD7D4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F497")]
	[FieldOffset(Offset = "0x28")]
	private UIHudKilledView m_View;

	[Token(Token = "0x400F498")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_MatchModel;

	[Token(Token = "0x400F499")]
	[FieldOffset(Offset = "0x30")]
	private bool isCoroutineRunning;

	[Token(Token = "0x400F49A")]
	[FieldOffset(Offset = "0x34")]
	private Player m_CurKiller;

	[Token(Token = "0x400F49B")]
	[FieldOffset(Offset = "0x38")]
	private Player m_CurBeKill;

	[Token(Token = "0x400F49C")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_TryKillAdditionalShow;

	[Token(Token = "0x600F431")]
	[Address(RVA = "0x1BBB590", Offset = "0x1BBB590", VA = "0x1BBB590")]
	public UIHudKilledController()
	{
	}

	[Token(Token = "0x600F432")]
	[Address(RVA = "0x1BBB614", Offset = "0x1BBB614", VA = "0x1BBB614")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F433")]
	[Address(RVA = "0x1BBB6B8", Offset = "0x1BBB6B8", VA = "0x1BBB6B8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F434")]
	[Address(RVA = "0x1BBBAA8", Offset = "0x1BBBAA8", VA = "0x1BBBAA8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F435")]
	[Address(RVA = "0x1BBBC0C", Offset = "0x1BBBC0C", VA = "0x1BBBC0C")]
	private IEnumerator RemoveKillHint(float delayTime, GameObject hint_object)
	{
		return null;
	}

	[Token(Token = "0x600F436")]
	[Address(RVA = "0x1BBBD34", Offset = "0x1BBBD34", VA = "0x1BBBD34")]
	private void OnHeadShot(object[] data)
	{
	}

	[Token(Token = "0x600F437")]
	[Address(RVA = "0x1BBBF80", Offset = "0x1BBBF80", VA = "0x1BBBF80")]
	private void OnAssistKonckDown(object[] data)
	{
	}

	[Token(Token = "0x600F438")]
	[Address(RVA = "0x1BBC474", Offset = "0x1BBC474", VA = "0x1BBC474", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600F439")]
	[Address(RVA = "0x1BBCE4C", Offset = "0x1BBCE4C", VA = "0x1BBCE4C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600F43A")]
	[Address(RVA = "0x1BBBE84", Offset = "0x1BBBE84", VA = "0x1BBBE84")]
	private void TargetPlayerKilledIcon(bool isHeadShot)
	{
	}

	[Token(Token = "0x600F43B")]
	[Address(RVA = "0x1BBCEE4", Offset = "0x1BBCEE4", VA = "0x1BBCEE4")]
	private void KilledIcon(bool isHeadShot)
	{
	}

	[Token(Token = "0x600F43C")]
	[Address(RVA = "0x1BBD334", Offset = "0x1BBD334", VA = "0x1BBD334")]
	private void KilledIconInSimple(bool isHeadShot)
	{
	}

	[Token(Token = "0x600F43D")]
	[Address(RVA = "0x1BBCA54", Offset = "0x1BBCA54", VA = "0x1BBCA54")]
	private void TargetPlayerKnockdownIcon()
	{
	}

	[Token(Token = "0x600F43E")]
	[Address(RVA = "0x1BBBFE8", Offset = "0x1BBBFE8", VA = "0x1BBBFE8")]
	private void TargetPlayerAssistKnockdownIcon()
	{
	}

	[Token(Token = "0x600F43F")]
	[Address(RVA = "0x1BBD648", Offset = "0x1BBD648", VA = "0x1BBD648")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F440")]
	[Address(RVA = "0x1BBD650", Offset = "0x1BBD650", VA = "0x1BBD650")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
