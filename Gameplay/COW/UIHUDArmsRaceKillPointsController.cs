using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FA0")]
public class UIHUDArmsRaceKillPointsController : UIBaseController
{
	[Token(Token = "0x2001FA1")]
	private sealed class _003CIEPointsUpAnim_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C667")]
		[FieldOffset(Offset = "0x8")]
		internal int _003CreadyShowArmLevel_003E__1;

		[Token(Token = "0x400C668")]
		[FieldOffset(Offset = "0xC")]
		internal uint _003ClastLevelPoints_003E__1;

		[Token(Token = "0x400C669")]
		[FieldOffset(Offset = "0x10")]
		internal int _003CshowPointIndex_003E__1;

		[Token(Token = "0x400C66A")]
		[FieldOffset(Offset = "0x14")]
		internal int _003CrealPointLevel_003E__1;

		[Token(Token = "0x400C66B")]
		[FieldOffset(Offset = "0x18")]
		internal UIHUDArmsRaceKillPointsController _0024this;

		[Token(Token = "0x400C66C")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x400C66D")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x400C66E")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x17000F9E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009D97")]
			[Address(RVA = "0x166E554", Offset = "0x166E554", VA = "0x166E554", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F9F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009D98")]
			[Address(RVA = "0x166E55C", Offset = "0x166E55C", VA = "0x166E55C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009D95")]
		[Address(RVA = "0x166DA98", Offset = "0x166DA98", VA = "0x166DA98")]
		public _003CIEPointsUpAnim_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009D96")]
		[Address(RVA = "0x166E124", Offset = "0x166E124", VA = "0x166E124", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009D99")]
		[Address(RVA = "0x166E564", Offset = "0x166E564", VA = "0x166E564", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009D9A")]
		[Address(RVA = "0x166E578", Offset = "0x166E578", VA = "0x166E578", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C65F")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDArmsRaceKillPointsView m_View;

	[Token(Token = "0x400C660")]
	[FieldOffset(Offset = "0x2C")]
	private int m_KillPoints;

	[Token(Token = "0x400C661")]
	[FieldOffset(Offset = "0x30")]
	private int m_CurShowArmLevel;

	[Token(Token = "0x400C662")]
	[FieldOffset(Offset = "0x34")]
	private int m_CurShowAnimPoint;

	[Token(Token = "0x400C663")]
	[FieldOffset(Offset = "0x38")]
	private Coroutine m_AnimHandle;

	[Token(Token = "0x400C664")]
	[FieldOffset(Offset = "0x3C")]
	private List<IJKEMPEMMDN> m_CachArmsList;

	[Token(Token = "0x400C665")]
	[FieldOffset(Offset = "0x40")]
	private List<UIHUDArmsRacePointItem> m_PointItems;

	[Token(Token = "0x400C666")]
	[FieldOffset(Offset = "0x44")]
	private bool m_IsPlayingPointUpAnim;

	[Token(Token = "0x6009D86")]
	[Address(RVA = "0x166CD34", Offset = "0x166CD34", VA = "0x166CD34")]
	public UIHUDArmsRaceKillPointsController()
	{
	}

	[Token(Token = "0x6009D87")]
	[Address(RVA = "0x166CDEC", Offset = "0x166CDEC", VA = "0x166CDEC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009D88")]
	[Address(RVA = "0x166CE94", Offset = "0x166CE94", VA = "0x166CE94", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009D89")]
	[Address(RVA = "0x166D1B0", Offset = "0x166D1B0", VA = "0x166D1B0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009D8A")]
	[Address(RVA = "0x166D3B4", Offset = "0x166D3B4", VA = "0x166D3B4")]
	private void OnGameArmsListCome(object[] param)
	{
	}

	[Token(Token = "0x6009D8B")]
	[Address(RVA = "0x166D7E0", Offset = "0x166D7E0", VA = "0x166D7E0")]
	private void OnArmKillPointsCome(object[] param)
	{
	}

	[Token(Token = "0x6009D8C")]
	[Address(RVA = "0x166D8D0", Offset = "0x166D8D0", VA = "0x166D8D0")]
	private void PlayPointsUpAnim()
	{
	}

	[Token(Token = "0x6009D8D")]
	[Address(RVA = "0x166D9CC", Offset = "0x166D9CC", VA = "0x166D9CC")]
	private IEnumerator IEPointsUpAnim()
	{
		return null;
	}

	[Token(Token = "0x6009D8E")]
	[Address(RVA = "0x166DAA0", Offset = "0x166DAA0", VA = "0x166DAA0")]
	private int GetShowLevelByPoint(int point)
	{
		return default(int);
	}

	[Token(Token = "0x6009D8F")]
	[Address(RVA = "0x166DBE8", Offset = "0x166DBE8", VA = "0x166DBE8")]
	private int GetRealLevelByPoint(int point)
	{
		return default(int);
	}

	[Token(Token = "0x6009D90")]
	[Address(RVA = "0x166D494", Offset = "0x166D494", VA = "0x166D494")]
	private void PrepareShowLevelEmptyPoint(int showLevel)
	{
	}

	[Token(Token = "0x6009D91")]
	[Address(RVA = "0x166DD68", Offset = "0x166DD68", VA = "0x166DD68")]
	private void LightingKillPoint(int index)
	{
	}

	[Token(Token = "0x6009D92")]
	[Address(RVA = "0x166DE54", Offset = "0x166DE54", VA = "0x166DE54")]
	private void OnKillLeader(object[] param)
	{
	}

	[Token(Token = "0x6009D93")]
	[Address(RVA = "0x166E114", Offset = "0x166E114", VA = "0x166E114")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009D94")]
	[Address(RVA = "0x166E11C", Offset = "0x166E11C", VA = "0x166E11C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
