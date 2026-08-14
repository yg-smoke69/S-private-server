using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;
using proto;

namespace COW;

[Token(Token = "0x20022E7")]
internal class UIHUDRushingPetsLevelEndShowController : UIBaseController, _Attribute
{
	[Token(Token = "0x20022E8")]
	private sealed class _003CDelayShowCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D9F2")]
		[FieldOffset(Offset = "0x8")]
		internal UIHUDRushingPetsLevelEndShowController _0024this;

		[Token(Token = "0x400D9F3")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400D9F4")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400D9F5")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010A4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C04C")]
			[Address(RVA = "0x220D0BC", Offset = "0x220D0BC", VA = "0x220D0BC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010A5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C04D")]
			[Address(RVA = "0x220D0C4", Offset = "0x220D0C4", VA = "0x220D0C4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C04A")]
		[Address(RVA = "0x220CC64", Offset = "0x220CC64", VA = "0x220CC64")]
		public _003CDelayShowCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C04B")]
		[Address(RVA = "0x220CC6C", Offset = "0x220CC6C", VA = "0x220CC6C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C04E")]
		[Address(RVA = "0x220D0CC", Offset = "0x220D0CC", VA = "0x220D0CC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C04F")]
		[Address(RVA = "0x220D0E0", Offset = "0x220D0E0", VA = "0x220D0E0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D9E4")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDRushingPetsLevelEndShowView m_View;

	[Token(Token = "0x400D9E5")]
	private const float WinShowTimeSec = 2.5f;

	[Token(Token = "0x400D9E6")]
	private const float RoundEndTipShowTimeSec = 3f;

	[Token(Token = "0x400D9E7")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsShowWin;

	[Token(Token = "0x400D9E8")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_IsLevelEnd;

	[Token(Token = "0x400D9E9")]
	[FieldOffset(Offset = "0x2E")]
	private bool m_IsLastRound;

	[Token(Token = "0x400D9EA")]
	[FieldOffset(Offset = "0x30")]
	protected UIModelMatch m_ModelMatch;

	[Token(Token = "0x400D9EB")]
	[FieldOffset(Offset = "0x34")]
	private float m_EndTime;

	[Token(Token = "0x400D9EC")]
	[FieldOffset(Offset = "0x38")]
	private List<int> m_PlayerInfoType;

	[Token(Token = "0x400D9ED")]
	[FieldOffset(Offset = "0x3C")]
	private UIHUDRushingPetsPlayerInfoItemController m_SelfUIItem;

	[Token(Token = "0x400D9EE")]
	[FieldOffset(Offset = "0x40")]
	private int m_LocalPlayerItemIndex;

	[Token(Token = "0x400D9EF")]
	private const int ShowSelfItemRank = 4;

	[Token(Token = "0x400D9F0")]
	[FieldOffset(Offset = "0x44")]
	private int m_LastLeftTimeCeil;

	[Token(Token = "0x400D9F1")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<TeammateStats> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600C03A")]
	[Address(RVA = "0x1688B54", Offset = "0x1688B54", VA = "0x1688B54")]
	public UIHUDRushingPetsLevelEndShowController()
	{
	}

	[Token(Token = "0x600C03B")]
	[Address(RVA = "0x1688C14", Offset = "0x1688C14", VA = "0x1688C14")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C03C")]
	[Address(RVA = "0x1688CF8", Offset = "0x1688CF8", VA = "0x1688CF8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C03D")]
	[Address(RVA = "0x1688FCC", Offset = "0x1688FCC", VA = "0x1688FCC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C03E")]
	[Address(RVA = "0x1689100", Offset = "0x1689100", VA = "0x1689100")]
	public void InitData(LLAHOLGIFFE msg)
	{
	}

	[Token(Token = "0x600C03F")]
	[Address(RVA = "0x1689CCC", Offset = "0x1689CCC", VA = "0x1689CCC")]
	private IEnumerator DelayShowCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600C040")]
	[Address(RVA = "0x1689D98", Offset = "0x1689D98", VA = "0x1689D98", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C041")]
	[Address(RVA = "0x1689F64", Offset = "0x1689F64", VA = "0x1689F64", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600C042")]
	[Address(RVA = "0x1689384", Offset = "0x1689384", VA = "0x1689384")]
	public void InitLeaderBoardInfo(List<NMHNKFCFNOD> playerList)
	{
	}

	[Token(Token = "0x600C043")]
	[Address(RVA = "0x1689FE0", Offset = "0x1689FE0", VA = "0x1689FE0")]
	private void OnPhaseEndTimeCome(object[] data)
	{
	}

	[Token(Token = "0x600C044")]
	[Address(RVA = "0x168A0B8", Offset = "0x168A0B8", VA = "0x168A0B8")]
	protected void UpdateCheckLocalPlayerInfo()
	{
	}

	[Token(Token = "0x600C045")]
	[Address(RVA = "0x168A338", Offset = "0x168A338", VA = "0x168A338")]
	private void Update()
	{
	}

	[Token(Token = "0x600C046")]
	[Address(RVA = "0x168A3A0", Offset = "0x168A3A0", VA = "0x168A3A0")]
	private void UpdateLeftTime()
	{
	}

	[Token(Token = "0x600C047")]
	[Address(RVA = "0x168A64C", Offset = "0x168A64C", VA = "0x168A64C")]
	private static int _003CInitLeaderBoardInfo_003Em__0(TeammateStats x, TeammateStats y)
	{
		return default(int);
	}

	[Token(Token = "0x600C048")]
	[Address(RVA = "0x168A694", Offset = "0x168A694", VA = "0x168A694")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C049")]
	[Address(RVA = "0x168A69C", Offset = "0x168A69C", VA = "0x168A69C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
