using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200236C")]
internal class UIHUDTeamBattleScoreBoardController<T> : UIBaseController where T : UIHUDTeamBattleScoreBoardItemController
{
	[Token(Token = "0x400DC85")]
	[FieldOffset(Offset = "0x0")]
	protected TeamScoreBoardView m_View;

	[Token(Token = "0x400DC86")]
	[FieldOffset(Offset = "0x0")]
	private List<int> m_InfoTypeList;

	[Token(Token = "0x400DC87")]
	[FieldOffset(Offset = "0x0")]
	protected Dictionary<IHAAMHPPLMG, T> m_ItemCtrlDic;

	[Token(Token = "0x400DC88")]
	[FieldOffset(Offset = "0x0")]
	private List<T> m_LeftItemList;

	[Token(Token = "0x400DC89")]
	[FieldOffset(Offset = "0x0")]
	private List<T> m_RightItemList;

	[Token(Token = "0x400DC8A")]
	[FieldOffset(Offset = "0x0")]
	protected int m_LocalPlayerTeamId;

	[Token(Token = "0x400DC8B")]
	[FieldOffset(Offset = "0x0")]
	private bool m_EnableReport;

	[Token(Token = "0x170010D2")]
	protected List<int> InfoTypeList
	{
		[Token(Token = "0x600C5D1")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010D3")]
	protected Dictionary<IHAAMHPPLMG, T> ItemCtrlList
	{
		[Token(Token = "0x600C5D2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600C5CF")]
	public UIHUDTeamBattleScoreBoardController()
	{
	}

	[Token(Token = "0x600C5D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C5D3")]
	protected virtual void SetInfoType()
	{
	}

	[Token(Token = "0x600C5D4")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C5D5")]
	private bool OnEscapeClick()
	{
		return default(bool);
	}

	[Token(Token = "0x600C5D6")]
	protected virtual ResourceID GetTitileResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C5D7")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600C5D8")]
	public virtual void RegisterUIEvent()
	{
	}

	[Token(Token = "0x600C5D9")]
	public virtual void UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600C5DA")]
	private void ClosePage()
	{
	}

	[Token(Token = "0x600C5DB")]
	private void OnClickReportBtn()
	{
	}

	[Token(Token = "0x600C5DC")]
	public virtual T InitOneItem(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C5DD")]
	private ItemType CreateItem<ItemType>(Transform parent) where ItemType : UIHUDTeamBattleScoreBoardItemController
	{
		return null;
	}

	[Token(Token = "0x600C5DE")]
	public virtual int ItemCustomSort(Transform transform1, Transform transform2)
	{
		return default(int);
	}

	[Token(Token = "0x600C5DF")]
	public virtual void OnAddPlayer(object[] param)
	{
	}

	[Token(Token = "0x600C5E0")]
	private void OnReplaceSamoInfo(object[] param)
	{
	}

	[Token(Token = "0x600C5E1")]
	protected virtual bool IsTeamOnLeft(IHAAMHPPLMG pId)
	{
		return default(bool);
	}

	[Token(Token = "0x600C5E2")]
	public void OnPlayerQuit(object[] param)
	{
	}

	[Token(Token = "0x600C5E3")]
	public virtual void RefreshGrid()
	{
	}

	[Token(Token = "0x600C5E4")]
	protected int SortPlayerData(Transform tr1, Transform tr2)
	{
		return default(int);
	}

	[Token(Token = "0x600C5E5")]
	public void UpdateLeftScore(int leftScore)
	{
	}

	[Token(Token = "0x600C5E6")]
	public void UpdateRightScore(int rightScore)
	{
	}

	[Token(Token = "0x600C5E7")]
	public void UpdateLeftCustomIcon(ResourceID spriteName, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	[Token(Token = "0x600C5E8")]
	public void UpdateRightCustomIcon(ResourceID spriteName, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	[Token(Token = "0x600C5E9")]
	public virtual void UpdateAllTitle()
	{
	}

	[Token(Token = "0x600C5EA")]
	protected void UpdateInfoTitle(UILabel infoTxt, int index)
	{
	}

	[Token(Token = "0x600C5EB")]
	public void UpdateTeamInfo(Player player, bool isUpdateLeft)
	{
	}

	[Token(Token = "0x600C5EC")]
	private void OnFactionIDChanged(object[] data)
	{
	}

	[Token(Token = "0x600C5ED")]
	protected virtual void OnKillCountChanged(object[] param)
	{
	}

	[Token(Token = "0x600C5EE")]
	protected virtual void OnDeadCountChanged(object[] param)
	{
	}

	[Token(Token = "0x600C5EF")]
	protected void OnAssistCountChanged(object[] param)
	{
	}

	[Token(Token = "0x600C5F0")]
	protected virtual void OnTotalDamageChanged(object[] param)
	{
	}

	[Token(Token = "0x600C5F1")]
	protected void RefreshItemDataByPlayerID(IHAAMHPPLMG playerId)
	{
	}

	[Token(Token = "0x600C5F2")]
	protected void RefreshItemData(IHAAMHPPLMG playerId, int index, string msg)
	{
	}
}
