using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20021A6")]
internal class UIHudLWSOMatchInfoController : UIBaseController
{
	[Token(Token = "0x20021A7")]
	private sealed class _003CRefreshTeamHPBGWidth_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D2CE")]
		[FieldOffset(Offset = "0x8")]
		internal Bounds _003CmyTeamHPGridBouns_003E__0;

		[Token(Token = "0x400D2CF")]
		[FieldOffset(Offset = "0x20")]
		internal Bounds _003CoppoTeamHPGridBouns_003E__0;

		[Token(Token = "0x400D2D0")]
		[FieldOffset(Offset = "0x38")]
		internal float _003CmyTeamPosX_003E__0;

		[Token(Token = "0x400D2D1")]
		[FieldOffset(Offset = "0x3C")]
		internal float _003CoppoTeamPosX_003E__0;

		[Token(Token = "0x400D2D2")]
		[FieldOffset(Offset = "0x40")]
		internal Vector3 _003CmyTeamPos_003E__0;

		[Token(Token = "0x400D2D3")]
		[FieldOffset(Offset = "0x4C")]
		internal Vector3 _003CoppoTeamPos_003E__0;

		[Token(Token = "0x400D2D4")]
		[FieldOffset(Offset = "0x58")]
		internal UIHudLWSOMatchInfoController _0024this;

		[Token(Token = "0x400D2D5")]
		[FieldOffset(Offset = "0x5C")]
		internal object _0024current;

		[Token(Token = "0x400D2D6")]
		[FieldOffset(Offset = "0x60")]
		internal bool _0024disposing;

		[Token(Token = "0x400D2D7")]
		[FieldOffset(Offset = "0x64")]
		internal int _0024PC;

		[Token(Token = "0x17001026")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B2DB")]
			[Address(RVA = "0x1BCB154", Offset = "0x1BCB154", VA = "0x1BCB154", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001027")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B2DC")]
			[Address(RVA = "0x1BCB15C", Offset = "0x1BCB15C", VA = "0x1BCB15C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B2D9")]
		[Address(RVA = "0x1BCAA8C", Offset = "0x1BCAA8C", VA = "0x1BCAA8C")]
		public _003CRefreshTeamHPBGWidth_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600B2DA")]
		[Address(RVA = "0x1BCAAAC", Offset = "0x1BCAAAC", VA = "0x1BCAAAC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B2DD")]
		[Address(RVA = "0x1BCB164", Offset = "0x1BCB164", VA = "0x1BCB164", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B2DE")]
		[Address(RVA = "0x1BCB178", Offset = "0x1BCB178", VA = "0x1BCB178", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D2C1")]
	[FieldOffset(Offset = "0x28")]
	private UIHudLWSOMatchInfoView m_View;

	[Token(Token = "0x400D2C2")]
	[FieldOffset(Offset = "0x2C")]
	private int mSeconds;

	[Token(Token = "0x400D2C3")]
	[FieldOffset(Offset = "0x30")]
	private StringBuilder m_Timer;

	[Token(Token = "0x400D2C4")]
	[FieldOffset(Offset = "0x34")]
	private uint min;

	[Token(Token = "0x400D2C5")]
	[FieldOffset(Offset = "0x38")]
	private uint sec;

	[Token(Token = "0x400D2C6")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIHudCSPlayerStateInfoView> m_MyTeamViews;

	[Token(Token = "0x400D2C7")]
	[FieldOffset(Offset = "0x40")]
	private List<UIHudCSPlayerStateInfoView> m_OppoTeamViews;

	[Token(Token = "0x400D2C8")]
	[FieldOffset(Offset = "0x44")]
	private List<UISprite> m_MyTeamHP;

	[Token(Token = "0x400D2C9")]
	[FieldOffset(Offset = "0x48")]
	private List<UISprite> m_OppoTeamHP;

	[Token(Token = "0x400D2CA")]
	[FieldOffset(Offset = "0x4C")]
	private ANBHLMNFJMP mGame;

	[Token(Token = "0x400D2CB")]
	[FieldOffset(Offset = "0x50")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400D2CC")]
	[FieldOffset(Offset = "0x54")]
	private int m_TeamCount;

	[Token(Token = "0x400D2CD")]
	[FieldOffset(Offset = "0x58")]
	private bool InitedHP;

	[Token(Token = "0x600B2C1")]
	[Address(RVA = "0x1BC73E0", Offset = "0x1BC73E0", VA = "0x1BC73E0")]
	public UIHudLWSOMatchInfoController()
	{
	}

	[Token(Token = "0x600B2C2")]
	[Address(RVA = "0x1BC7504", Offset = "0x1BC7504", VA = "0x1BC7504")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B2C3")]
	[Address(RVA = "0x1BC75AC", Offset = "0x1BC75AC", VA = "0x1BC75AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B2C4")]
	[Address(RVA = "0x1BC7E30", Offset = "0x1BC7E30", VA = "0x1BC7E30", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B2C5")]
	[Address(RVA = "0x1BC82A4", Offset = "0x1BC82A4", VA = "0x1BC82A4", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600B2C6")]
	[Address(RVA = "0x1BC8404", Offset = "0x1BC8404", VA = "0x1BC8404")]
	private void OnBtnLeaderboardClick()
	{
	}

	[Token(Token = "0x600B2C7")]
	[Address(RVA = "0x1BC8320", Offset = "0x1BC8320", VA = "0x1BC8320")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x600B2C8")]
	[Address(RVA = "0x1BC8FFC", Offset = "0x1BC8FFC", VA = "0x1BC8FFC")]
	private void RefreshTeamStatesUI(IHAAMHPPLMG pId)
	{
	}

	[Token(Token = "0x600B2C9")]
	[Address(RVA = "0x1BC8584", Offset = "0x1BC8584", VA = "0x1BC8584")]
	private void SetTeamStatesUI(List<IHAAMHPPLMG> pids, List<UIHudCSPlayerStateInfoView> views, bool ascending = true)
	{
	}

	[Token(Token = "0x600B2CA")]
	[Address(RVA = "0x1BC8CC0", Offset = "0x1BC8CC0", VA = "0x1BC8CC0")]
	private void SetHP()
	{
	}

	[Token(Token = "0x600B2CB")]
	[Address(RVA = "0x1BC9190", Offset = "0x1BC9190", VA = "0x1BC9190")]
	private void Update()
	{
	}

	[Token(Token = "0x600B2CC")]
	[Address(RVA = "0x1BC961C", Offset = "0x1BC961C", VA = "0x1BC961C")]
	private void OnPlayerHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600B2CD")]
	[Address(RVA = "0x1BC9774", Offset = "0x1BC9774", VA = "0x1BC9774")]
	private void OnPlayerStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600B2CE")]
	[Address(RVA = "0x1BC9888", Offset = "0x1BC9888", VA = "0x1BC9888")]
	private void OnPlayerQuit(object[] data)
	{
	}

	[Token(Token = "0x600B2CF")]
	[Address(RVA = "0x1BC99D8", Offset = "0x1BC99D8", VA = "0x1BC99D8")]
	private void OnNewPhaseEnter(object[] data)
	{
	}

	[Token(Token = "0x600B2D0")]
	[Address(RVA = "0x1BCA4C0", Offset = "0x1BCA4C0", VA = "0x1BCA4C0")]
	private void OnNewMiniPhaseEnter(object[] data)
	{
	}

	[Token(Token = "0x600B2D1")]
	[Address(RVA = "0x1BCA954", Offset = "0x1BCA954", VA = "0x1BCA954")]
	private void OnStartMatchEndShow(object[] data)
	{
	}

	[Token(Token = "0x600B2D2")]
	[Address(RVA = "0x1BC9ED4", Offset = "0x1BC9ED4", VA = "0x1BC9ED4")]
	private void SetRoundInfoUI()
	{
	}

	[Token(Token = "0x600B2D3")]
	[Address(RVA = "0x1BC7D38", Offset = "0x1BC7D38", VA = "0x1BC7D38")]
	private int CalTeamCount()
	{
		return default(int);
	}

	[Token(Token = "0x600B2D4")]
	[Address(RVA = "0x1BCA0E4", Offset = "0x1BCA0E4", VA = "0x1BCA0E4")]
	private void InstantiateHP(object[] param)
	{
	}

	[Token(Token = "0x600B2D5")]
	[Address(RVA = "0x1BCA9C0", Offset = "0x1BCA9C0", VA = "0x1BCA9C0")]
	private IEnumerator RefreshTeamHPBGWidth()
	{
		return null;
	}

	[Token(Token = "0x600B2D6")]
	[Address(RVA = "0x1BCAA94", Offset = "0x1BCAA94", VA = "0x1BCAA94")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B2D7")]
	[Address(RVA = "0x1BCAA9C", Offset = "0x1BCAA9C", VA = "0x1BCAA9C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600B2D8")]
	[Address(RVA = "0x1BCAAA4", Offset = "0x1BCAAA4", VA = "0x1BCAAA4")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
