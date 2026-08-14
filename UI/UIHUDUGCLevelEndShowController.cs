using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

[Token(Token = "0x2002489")]
internal class UIHUDUGCLevelEndShowController : UIBaseController, _Attribute
{
	[Token(Token = "0x200248A")]
	public class UGCLevelEndShowData
	{
		[Token(Token = "0x400E295")]
		[FieldOffset(Offset = "0x8")]
		public float WinShowTime;

		[Token(Token = "0x400E296")]
		[FieldOffset(Offset = "0xC")]
		public float RoundEndShowTime;

		[Token(Token = "0x400E297")]
		[FieldOffset(Offset = "0x10")]
		public bool IsShowWin;

		[Token(Token = "0x400E298")]
		[FieldOffset(Offset = "0x11")]
		public bool IsShowLevelEnd;

		[Token(Token = "0x400E299")]
		[FieldOffset(Offset = "0x14")]
		public int Rank;

		[Token(Token = "0x400E29A")]
		[FieldOffset(Offset = "0x18")]
		public int RankMax;

		[Token(Token = "0x400E29B")]
		[FieldOffset(Offset = "0x1C")]
		public int Score;

		[Token(Token = "0x600D0B8")]
		[Address(RVA = "0x14827F8", Offset = "0x14827F8", VA = "0x14827F8")]
		public UGCLevelEndShowData()
		{
		}
	}

	[Token(Token = "0x200248B")]
	private sealed class _003CDelayShowCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E29C")]
		[FieldOffset(Offset = "0x8")]
		internal UIHUDUGCLevelEndShowController _0024this;

		[Token(Token = "0x400E29D")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400E29E")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400E29F")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x1700111C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600D0BB")]
			[Address(RVA = "0x14832AC", Offset = "0x14832AC", VA = "0x14832AC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700111D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600D0BC")]
			[Address(RVA = "0x14832B4", Offset = "0x14832B4", VA = "0x14832B4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600D0B9")]
		[Address(RVA = "0x1482D68", Offset = "0x1482D68", VA = "0x1482D68")]
		public _003CDelayShowCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600D0BA")]
		[Address(RVA = "0x1482E80", Offset = "0x1482E80", VA = "0x1482E80", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600D0BD")]
		[Address(RVA = "0x14832BC", Offset = "0x14832BC", VA = "0x14832BC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600D0BE")]
		[Address(RVA = "0x14832D0", Offset = "0x14832D0", VA = "0x14832D0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400E292")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDRushingPetsLevelEndShowView _view;

	[Token(Token = "0x400E293")]
	[FieldOffset(Offset = "0x2C")]
	private UGCLevelEndShowData _viewData;

	[Token(Token = "0x400E294")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine _delayCorHandler;

	[Token(Token = "0x600D0AF")]
	[Address(RVA = "0x1482634", Offset = "0x1482634", VA = "0x1482634")]
	public UIHUDUGCLevelEndShowController()
	{
	}

	[Token(Token = "0x600D0B0")]
	[Address(RVA = "0x14826B8", Offset = "0x14826B8", VA = "0x14826B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D0B1")]
	[Address(RVA = "0x1482720", Offset = "0x1482720", VA = "0x1482720", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D0B2")]
	[Address(RVA = "0x1482AD8", Offset = "0x1482AD8", VA = "0x1482AD8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D0B3")]
	[Address(RVA = "0x1482AE0", Offset = "0x1482AE0", VA = "0x1482AE0")]
	public void SetStateByParams(bool isShow, List<FIMGICJHBNI> args)
	{
	}

	[Token(Token = "0x600D0B4")]
	[Address(RVA = "0x1482800", Offset = "0x1482800", VA = "0x1482800")]
	private void _ApplyViewData()
	{
	}

	[Token(Token = "0x600D0B5")]
	[Address(RVA = "0x1482CE4", Offset = "0x1482CE4", VA = "0x1482CE4")]
	private IEnumerator DelayShowCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600D0B6")]
	[Address(RVA = "0x1482D70", Offset = "0x1482D70", VA = "0x1482D70", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600D0B7")]
	[Address(RVA = "0x1482DF8", Offset = "0x1482DF8", VA = "0x1482DF8", Slot = "32")]
	public void DestroyEntity()
	{
	}
}
