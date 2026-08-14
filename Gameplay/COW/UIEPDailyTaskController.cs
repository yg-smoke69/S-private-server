using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20020CF")]
public class UIEPDailyTaskController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x400CD5F")]
	[FieldOffset(Offset = "0x28")]
	private UIEPDailyTaskView m_View;

	[Token(Token = "0x400CD60")]
	[FieldOffset(Offset = "0x2C")]
	private UIEPDebrisProcessController m_EpDebrisCtrl;

	[Token(Token = "0x400CD61")]
	[FieldOffset(Offset = "0x30")]
	private List<UIEPDailyTaskRewardItemController> m_RewardList;

	[Token(Token = "0x400CD62")]
	private const string EPDAILYTASKFIRSTTIP = "EPDAILYTASKFIRSTTIP";

	[Token(Token = "0x400CD63")]
	private const string ANIMPREFIX = "VFX_UITaskReward_Path_";

	[Token(Token = "0x400CD64")]
	[FieldOffset(Offset = "0x34")]
	private UIModelElitePass m_ModelEP;

	[Token(Token = "0x400CD65")]
	[FieldOffset(Offset = "0x38")]
	private List<string> NeedPlayAnimClipLst;

	[Token(Token = "0x400CD66")]
	[FieldOffset(Offset = "0x3C")]
	private List<Transform> m_RewardsPosLst;

	[Token(Token = "0x400CD67")]
	[FieldOffset(Offset = "0x40")]
	private bool needPlayAnim;

	[Token(Token = "0x400CD68")]
	[FieldOffset(Offset = "0x44")]
	private string curPlayClipName;

	[Token(Token = "0x400CD69")]
	[FieldOffset(Offset = "0x48")]
	private uint curProcessID;

	[Token(Token = "0x400CD6A")]
	[FieldOffset(Offset = "0x4C")]
	private int hadPlayCnt;

	[Token(Token = "0x400CD6B")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<EPDailyRewardInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400CD6C")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<EPDailyRewardInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400CD6D")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x600A997")]
	[Address(RVA = "0x2BA2B64", Offset = "0x2BA2B64", VA = "0x2BA2B64")]
	public UIEPDailyTaskController()
	{
	}

	[Token(Token = "0x600A998")]
	[Address(RVA = "0x2BA2C98", Offset = "0x2BA2C98", VA = "0x2BA2C98")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A999")]
	[Address(RVA = "0x2BA2D3C", Offset = "0x2BA2D3C", VA = "0x2BA2D3C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A99A")]
	[Address(RVA = "0x2BA3544", Offset = "0x2BA3544", VA = "0x2BA3544")]
	public void OnDailySignBtn()
	{
	}

	[Token(Token = "0x600A99B")]
	[Address(RVA = "0x2BA3654", Offset = "0x2BA3654", VA = "0x2BA3654", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600A99C")]
	[Address(RVA = "0x2BA38E4", Offset = "0x2BA38E4", VA = "0x2BA38E4")]
	private void OnEpDataReady(object[] data)
	{
	}

	[Token(Token = "0x600A99D")]
	[Address(RVA = "0x2BA49EC", Offset = "0x2BA49EC", VA = "0x2BA49EC")]
	private void OnEpDailyRewardClaim(object[] data)
	{
	}

	[Token(Token = "0x600A99E")]
	[Address(RVA = "0x2BA4A5C", Offset = "0x2BA4A5C", VA = "0x2BA4A5C")]
	private void OnEpDailyRewardStateUpdate(object[] data)
	{
	}

	[Token(Token = "0x600A99F")]
	[Address(RVA = "0x2BA4DB4", Offset = "0x2BA4DB4", VA = "0x2BA4DB4")]
	private void OnUpgradeEPBtn()
	{
	}

	[Token(Token = "0x600A9A0")]
	[Address(RVA = "0x2BA345C", Offset = "0x2BA345C", VA = "0x2BA345C")]
	private void InitData()
	{
	}

	[Token(Token = "0x600A9A1")]
	[Address(RVA = "0x2BA5598", Offset = "0x2BA5598", VA = "0x2BA5598")]
	private void Update()
	{
	}

	[Token(Token = "0x600A9A2")]
	[Address(RVA = "0x2BA564C", Offset = "0x2BA564C", VA = "0x2BA564C")]
	private void _OnAnimPlayDone()
	{
	}

	[Token(Token = "0x600A9A3")]
	[Address(RVA = "0x2BA4B84", Offset = "0x2BA4B84", VA = "0x2BA4B84")]
	private void SetPlayAnim(uint process, uint lastProcess)
	{
	}

	[Token(Token = "0x600A9A4")]
	[Address(RVA = "0x2BA5B4C", Offset = "0x2BA5B4C", VA = "0x2BA5B4C")]
	private void InitAnim(uint doneCnt, bool forceToEnd = false)
	{
	}

	[Token(Token = "0x600A9A5")]
	[Address(RVA = "0x2BA47D4", Offset = "0x2BA47D4", VA = "0x2BA47D4")]
	private void RefreshTaskList()
	{
	}

	[Token(Token = "0x600A9A6")]
	[Address(RVA = "0x2BA5E84", Offset = "0x2BA5E84", VA = "0x2BA5E84")]
	private int SortTaskList(EPDailyQuestInfo q1, EPDailyQuestInfo q2)
	{
		return default(int);
	}

	[Token(Token = "0x600A9A7")]
	[Address(RVA = "0x2BA3964", Offset = "0x2BA3964", VA = "0x2BA3964")]
	private void RefreshRewardList()
	{
	}

	[Token(Token = "0x600A9A8")]
	[Address(RVA = "0x2BA4EDC", Offset = "0x2BA4EDC", VA = "0x2BA4EDC")]
	private void RefreshSignBtn()
	{
	}

	[Token(Token = "0x600A9A9")]
	[Address(RVA = "0x2BA4684", Offset = "0x2BA4684", VA = "0x2BA4684")]
	private void RefreshDesc()
	{
	}

	[Token(Token = "0x600A9AA")]
	[Address(RVA = "0x2BA40A0", Offset = "0x2BA40A0", VA = "0x2BA40A0")]
	private void RefreshTaskProcess()
	{
	}

	[Token(Token = "0x600A9AB")]
	[Address(RVA = "0x2BA5444", Offset = "0x2BA5444", VA = "0x2BA5444")]
	private void RefreshDebrisInfo()
	{
	}

	[Token(Token = "0x600A9AC")]
	[Address(RVA = "0x2BA61CC", Offset = "0x2BA61CC", VA = "0x2BA61CC", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A9AD")]
	[Address(RVA = "0x2BA62E8", Offset = "0x2BA62E8", VA = "0x2BA62E8", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A9AE")]
	[Address(RVA = "0x2BA5188", Offset = "0x2BA5188", VA = "0x2BA5188")]
	private void SetCDN(object[] data)
	{
	}

	[Token(Token = "0x600A9AF")]
	[Address(RVA = "0x2BA637C", Offset = "0x2BA637C", VA = "0x2BA637C", Slot = "33")]
	private UIEasyListItemController GCommon_002EIEasyList_002EOpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600A9B0")]
	[Address(RVA = "0x2BA64AC", Offset = "0x2BA64AC", VA = "0x2BA64AC", Slot = "34")]
	private void GCommon_002EIEasyList_002ECloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600A9B1")]
	[Address(RVA = "0x2BA6528", Offset = "0x2BA6528", VA = "0x2BA6528")]
	private static int _003CRefreshRewardList_003Em__0(EPDailyRewardInfo a, EPDailyRewardInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x600A9B2")]
	[Address(RVA = "0x2BA6598", Offset = "0x2BA6598", VA = "0x2BA6598")]
	private static bool _003CRefreshTaskProcess_003Em__1(EPDailyRewardInfo e)
	{
		return default(bool);
	}

	[Token(Token = "0x600A9B3")]
	[Address(RVA = "0x2BA65C4", Offset = "0x2BA65C4", VA = "0x2BA65C4")]
	private static bool _003CSetCDN_003Em__2(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600A9B4")]
	[Address(RVA = "0x2BA65F4", Offset = "0x2BA65F4", VA = "0x2BA65F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A9B5")]
	[Address(RVA = "0x2BA65FC", Offset = "0x2BA65FC", VA = "0x2BA65FC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
