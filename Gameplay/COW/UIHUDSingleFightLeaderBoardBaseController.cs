using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002848")]
internal class UIHUDSingleFightLeaderBoardBaseController<T> : UIBaseController where T : UIHUDSingleFightLeaderBoardItemBaseController
{
	[Token(Token = "0x400F887")]
	[FieldOffset(Offset = "0x0")]
	protected UIHudSingleFightLeaderBoardView m_View;

	[Token(Token = "0x400F888")]
	[FieldOffset(Offset = "0x0")]
	protected List<int> m_InfoTypeList;

	[Token(Token = "0x400F889")]
	[FieldOffset(Offset = "0x0")]
	protected Dictionary<IHAAMHPPLMG, T> m_ItemCtrlDic;

	[Token(Token = "0x400F88A")]
	[FieldOffset(Offset = "0x0")]
	private T m_LocalPlayerItemCtrl;

	[Token(Token = "0x400F88B")]
	[FieldOffset(Offset = "0x0")]
	private T m_LocalPlayerItemCtrlInGrid;

	[Token(Token = "0x400F88C")]
	[FieldOffset(Offset = "0x0")]
	protected List<LeaderBoardSortingData> m_SortingDatas;

	[Token(Token = "0x400F88D")]
	[FieldOffset(Offset = "0x0")]
	private bool m_ReportOn;

	[Token(Token = "0x600FB92")]
	public UIHUDSingleFightLeaderBoardBaseController()
	{
	}

	[Token(Token = "0x600FB93")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FB94")]
	private T CreateItem(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600FB95")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FB96")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600FB97")]
	public virtual void RegisterUIEvent()
	{
	}

	[Token(Token = "0x600FB98")]
	public virtual void UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600FB99")]
	protected virtual void SetInfoTypeList()
	{
	}

	[Token(Token = "0x600FB9A")]
	public virtual void SetInfoTitlesByInfoType()
	{
	}

	[Token(Token = "0x600FB9B")]
	protected virtual void SetSortingTypes()
	{
	}

	[Token(Token = "0x600FB9C")]
	public virtual void Sort()
	{
	}

	[Token(Token = "0x600FB9D")]
	private int ItemCompareWithPlayerID(Transform item2, Transform item1)
	{
		return default(int);
	}

	[Token(Token = "0x600FB9E")]
	private int ItemCompare(Transform item2, Transform item1)
	{
		return default(int);
	}

	[Token(Token = "0x600FB9F")]
	private bool OnEscapeClick()
	{
		return default(bool);
	}

	[Token(Token = "0x600FBA0")]
	public virtual void OnAddPlayer(object[] param)
	{
	}

	[Token(Token = "0x600FBA1")]
	public void OnPlayerQuit(object[] param)
	{
	}

	[Token(Token = "0x600FBA2")]
	protected virtual void OnCommonPlayerStatsChanged(object[] param)
	{
	}

	[Token(Token = "0x600FBA3")]
	protected void SetSortingData(EMatchResultPlayerInfoType type, ELeaderBoardSortingOrder order)
	{
	}

	[Token(Token = "0x600FBA4")]
	protected void SetInfoTitle(UILabel infoTxt, int index)
	{
	}

	[Token(Token = "0x600FBA5")]
	private void SetRank()
	{
	}

	[Token(Token = "0x600FBA6")]
	public virtual void RefreshGrid()
	{
	}

	[Token(Token = "0x600FBA7")]
	private void ClosePage()
	{
	}

	[Token(Token = "0x600FBA8")]
	private void OnReportBtnClick()
	{
	}

	[Token(Token = "0x600FBA9")]
	private void Update()
	{
	}

	[Token(Token = "0x600FBAA")]
	protected void RefreshItemDataByPlayerID(IHAAMHPPLMG playerId)
	{
	}
}
