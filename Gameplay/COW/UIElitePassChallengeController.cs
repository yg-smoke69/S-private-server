using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20025E4")]
internal class UIElitePassChallengeController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x20025E5")]
	private sealed class _003CCreateTab_003Ec__AnonStorey1
	{
		[Token(Token = "0x400EA4A")]
		[FieldOffset(Offset = "0x8")]
		internal StandardTabItemViewData mainTabData;

		[Token(Token = "0x400EA4B")]
		[FieldOffset(Offset = "0xC")]
		internal UIElitePassChallengeController _0024this;

		[Token(Token = "0x600DF64")]
		[Address(RVA = "0x2A48CDC", Offset = "0x2A48CDC", VA = "0x2A48CDC")]
		public _003CCreateTab_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600DF65")]
		[Address(RVA = "0x2A4E264", Offset = "0x2A4E264", VA = "0x2A4E264")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20025E6")]
	private sealed class _003CCreateTab_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EA4C")]
		[FieldOffset(Offset = "0x8")]
		internal StandardSubTabItemViewData subTabData;

		[Token(Token = "0x400EA4D")]
		[FieldOffset(Offset = "0xC")]
		internal _003CCreateTab_003Ec__AnonStorey1 _003C_003Ef__ref_00241;

		[Token(Token = "0x600DF66")]
		[Address(RVA = "0x2A48CE4", Offset = "0x2A48CE4", VA = "0x2A48CE4")]
		public _003CCreateTab_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600DF67")]
		[Address(RVA = "0x2A4E1B4", Offset = "0x2A4E1B4", VA = "0x2A4E1B4")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400EA2F")]
	[FieldOffset(Offset = "0x28")]
	private UIElitePassChallengeView m_View;

	[Token(Token = "0x400EA30")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelElitePass m_EPModel;

	[Token(Token = "0x400EA31")]
	[FieldOffset(Offset = "0x30")]
	private UIGuideTipsController m_GuideTipsCtrl;

	[Token(Token = "0x400EA32")]
	[FieldOffset(Offset = "0x34")]
	private UICountDownController m_CDController;

	[Token(Token = "0x400EA33")]
	[FieldOffset(Offset = "0x38")]
	private bool m_HasCreateTab;

	[Token(Token = "0x400EA34")]
	[FieldOffset(Offset = "0x39")]
	private bool m_NeedForceUpdateTab;

	[Token(Token = "0x400EA35")]
	[FieldOffset(Offset = "0x3C")]
	private List<EPTaskTabData> m_EPTaskTabDatas;

	[Token(Token = "0x400EA36")]
	[FieldOffset(Offset = "0x40")]
	private UIStandardDrawerTabRemakeController m_TabCtrl;

	[Token(Token = "0x400EA37")]
	[FieldOffset(Offset = "0x44")]
	private List<StandardTabItemViewData> m_MainTabDataList;

	[Token(Token = "0x400EA38")]
	[FieldOffset(Offset = "0x48")]
	private List<StandardSubTabItemViewData> m_SubTabDataList;

	[Token(Token = "0x400EA39")]
	[FieldOffset(Offset = "0x4C")]
	private EEPTaskTab m_CurrentTab;

	[Token(Token = "0x400EA3A")]
	[FieldOffset(Offset = "0x50")]
	private UICommonGuideController m_EPWeeklyTabUnlockGuideCtrl;

	[Token(Token = "0x400EA3B")]
	[FieldOffset(Offset = "0x54")]
	private uint m_EPWeeklyGuideDelayID;

	[Token(Token = "0x400EA3C")]
	[FieldOffset(Offset = "0x58")]
	private bool m_PlayAnim;

	[Token(Token = "0x400EA3D")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_DailyProcessInvalidStatus;

	[Token(Token = "0x400EA3E")]
	[FieldOffset(Offset = "0x60")]
	private uint m_DailyProcessNodeId;

	[Token(Token = "0x400EA3F")]
	[FieldOffset(Offset = "0x64")]
	private List<BaseItemInfo> m_DailyProcessReward;

	[Token(Token = "0x400EA40")]
	[FieldOffset(Offset = "0x68")]
	private UITaskController m_ParentCtrl;

	[Token(Token = "0x400EA41")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_NotSetMaxRewardPreview;

	[Token(Token = "0x400EA42")]
	[FieldOffset(Offset = "0x70")]
	private EPTarget_Status m_MaxRewardStatus;

	[Token(Token = "0x400EA43")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 m_MaxRewardPos;

	[Token(Token = "0x400EA44")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 m_MaxRewardPosOnLevel;

	[Token(Token = "0x400EA45")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_DailyProcessNeedChallengeNum;

	[Token(Token = "0x400EA46")]
	[FieldOffset(Offset = "0x90")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x400EA47")]
	[FieldOffset(Offset = "0x94")]
	private uint m_DailyProcessExchangeItemId;

	[Token(Token = "0x400EA48")]
	[FieldOffset(Offset = "0x98")]
	private string m_DailyProessExchangeItemDescString;

	[Token(Token = "0x400EA49")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_GoExchangeViewHasSet;

	[Token(Token = "0x17001154")]
	public bool PlayAnim
	{
		[Token(Token = "0x600DF30")]
		[Address(RVA = "0x2A440D8", Offset = "0x2A440D8", VA = "0x2A440D8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600DF2F")]
	[Address(RVA = "0x2A43F24", Offset = "0x2A43F24", VA = "0x2A43F24")]
	public UIElitePassChallengeController()
	{
	}

	[Token(Token = "0x600DF31")]
	[Address(RVA = "0x2A44130", Offset = "0x2A44130", VA = "0x2A44130")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DF32")]
	[Address(RVA = "0x2A441D8", Offset = "0x2A441D8", VA = "0x2A441D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DF33")]
	[Address(RVA = "0x2A45C20", Offset = "0x2A45C20", VA = "0x2A45C20", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600DF34")]
	[Address(RVA = "0x2A44E80", Offset = "0x2A44E80", VA = "0x2A44E80")]
	private void GetMaxRewardProgressPos()
	{
	}

	[Token(Token = "0x600DF35")]
	[Address(RVA = "0x2A4518C", Offset = "0x2A4518C", VA = "0x2A4518C")]
	private void InitLabel()
	{
	}

	[Token(Token = "0x600DF36")]
	[Address(RVA = "0x2A45A00", Offset = "0x2A45A00", VA = "0x2A45A00")]
	private void SetBadgeIconView()
	{
	}

	[Token(Token = "0x600DF37")]
	[Address(RVA = "0x2A464F0", Offset = "0x2A464F0", VA = "0x2A464F0")]
	private void SetTreasureBoxView()
	{
	}

	[Token(Token = "0x600DF38")]
	[Address(RVA = "0x2A475D8", Offset = "0x2A475D8", VA = "0x2A475D8")]
	private uint GetDailyProcessDescStatusByNodeID(uint nodeID)
	{
		return default(uint);
	}

	[Token(Token = "0x600DF39")]
	[Address(RVA = "0x2A47700", Offset = "0x2A47700", VA = "0x2A47700")]
	private void SetGoExchangeView()
	{
	}

	[Token(Token = "0x600DF3A")]
	[Address(RVA = "0x2A47C7C", Offset = "0x2A47C7C", VA = "0x2A47C7C")]
	private void SetDailyProcessRewardView()
	{
	}

	[Token(Token = "0x600DF3B")]
	[Address(RVA = "0x2A47CE4", Offset = "0x2A47CE4", VA = "0x2A47CE4")]
	private void SetMaxRewardView()
	{
	}

	[Token(Token = "0x600DF3C")]
	[Address(RVA = "0x2A48664", Offset = "0x2A48664", VA = "0x2A48664")]
	private void SetMaxRewardProgressPos(uint id)
	{
	}

	[Token(Token = "0x600DF3D")]
	[Address(RVA = "0x2A48298", Offset = "0x2A48298", VA = "0x2A48298")]
	private void SetMaxRewardView(uint curProgress, int requireBadgeNum)
	{
	}

	[Token(Token = "0x600DF3E")]
	[Address(RVA = "0x2A4592C", Offset = "0x2A4592C", VA = "0x2A4592C")]
	private void SetBadgeCountView()
	{
	}

	[Token(Token = "0x600DF3F")]
	[Address(RVA = "0x2A48868", Offset = "0x2A48868", VA = "0x2A48868")]
	private void InitTab()
	{
	}

	[Token(Token = "0x600DF40")]
	[Address(RVA = "0x2A4898C", Offset = "0x2A4898C", VA = "0x2A4898C")]
	private void CreateTab()
	{
	}

	[Token(Token = "0x600DF41")]
	[Address(RVA = "0x2A48CEC", Offset = "0x2A48CEC", VA = "0x2A48CEC")]
	private void OnSelectTab(EEPTaskTab tab)
	{
	}

	[Token(Token = "0x600DF42")]
	[Address(RVA = "0x2A49E34", Offset = "0x2A49E34", VA = "0x2A49E34")]
	private EPChallengeInfo GetChallengeInfoByWeekQuest(EPWeeklyQuestInfo weekInfo)
	{
		return null;
	}

	[Token(Token = "0x600DF43")]
	[Address(RVA = "0x2A49F64", Offset = "0x2A49F64", VA = "0x2A49F64")]
	private int EPChallengeSortFunc(EPChallengeInfo x, EPChallengeInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x600DF44")]
	[Address(RVA = "0x2A4A154", Offset = "0x2A4A154", VA = "0x2A4A154")]
	private void UpdateTabRedDot()
	{
	}

	[Token(Token = "0x600DF45")]
	[Address(RVA = "0x2A4A340", Offset = "0x2A4A340", VA = "0x2A4A340")]
	private void UpdateWeeklySubTabLockState()
	{
	}

	[Token(Token = "0x600DF46")]
	[Address(RVA = "0x2A4A658", Offset = "0x2A4A658", VA = "0x2A4A658")]
	private void OnGotoEPBtnClick()
	{
	}

	[Token(Token = "0x600DF47")]
	[Address(RVA = "0x2A4A740", Offset = "0x2A4A740", VA = "0x2A4A740")]
	private void OnDailyHelpBtnClick()
	{
	}

	[Token(Token = "0x600DF48")]
	[Address(RVA = "0x2A4AC94", Offset = "0x2A4AC94", VA = "0x2A4AC94")]
	private void OnWeeklyHelpBtnClick()
	{
	}

	[Token(Token = "0x600DF49")]
	[Address(RVA = "0x2A4B1B0", Offset = "0x2A4B1B0", VA = "0x2A4B1B0")]
	private void OnTreasureBoxPreviewBtnClick()
	{
	}

	[Token(Token = "0x600DF4A")]
	[Address(RVA = "0x2A4B6EC", Offset = "0x2A4B6EC", VA = "0x2A4B6EC")]
	private List<BaseItemInfo> GetPreviewReward(BaseItemInfo reward, bool showBox = true)
	{
		return null;
	}

	[Token(Token = "0x600DF4B")]
	[Address(RVA = "0x2A4BD74", Offset = "0x2A4BD74", VA = "0x2A4BD74")]
	private void OnTreasureBoxClaimBtnClick()
	{
	}

	[Token(Token = "0x600DF4C")]
	[Address(RVA = "0x2A4BFFC", Offset = "0x2A4BFFC", VA = "0x2A4BFFC")]
	private void OnClaimAllBtnClick()
	{
	}

	[Token(Token = "0x600DF4D")]
	[Address(RVA = "0x2A4C5C4", Offset = "0x2A4C5C4", VA = "0x2A4C5C4")]
	private void OnMaxRewardClaimBtnClick()
	{
	}

	[Token(Token = "0x600DF4E")]
	[Address(RVA = "0x2A4C984", Offset = "0x2A4C984", VA = "0x2A4C984")]
	private void OnMaxRewardCheckBtnClick()
	{
	}

	[Token(Token = "0x600DF4F")]
	[Address(RVA = "0x2A4CCBC", Offset = "0x2A4CCBC", VA = "0x2A4CCBC")]
	private void OnGoExchangeBtnClick()
	{
	}

	[Token(Token = "0x600DF50")]
	[Address(RVA = "0x2A4CE50", Offset = "0x2A4CE50", VA = "0x2A4CE50")]
	private void OnEPChallengeUpdate(object[] param)
	{
	}

	[Token(Token = "0x600DF51")]
	[Address(RVA = "0x2A4CECC", Offset = "0x2A4CECC", VA = "0x2A4CECC")]
	private void StopNewbieGuide(object[] args)
	{
	}

	[Token(Token = "0x600DF52")]
	[Address(RVA = "0x2A4CFD8", Offset = "0x2A4CFD8", VA = "0x2A4CFD8")]
	private void OnEPUnlocked(object[] param)
	{
	}

	[Token(Token = "0x600DF53")]
	[Address(RVA = "0x2A4D04C", Offset = "0x2A4D04C", VA = "0x2A4D04C")]
	private void OnUpdateTabRedDot(object[] param)
	{
	}

	[Token(Token = "0x600DF54")]
	[Address(RVA = "0x2A4D0B4", Offset = "0x2A4D0B4", VA = "0x2A4D0B4")]
	private void OnEPBadgeChange(object[] param)
	{
	}

	[Token(Token = "0x600DF55")]
	[Address(RVA = "0x2A4D12C", Offset = "0x2A4D12C", VA = "0x2A4D12C")]
	private void OnEPDataReady(object[] param)
	{
	}

	[Token(Token = "0x600DF56")]
	[Address(RVA = "0x2A4D2FC", Offset = "0x2A4D2FC", VA = "0x2A4D2FC")]
	private EEPTaskTab SelectTab2Open(ref bool needShowGuide)
	{
		return default(EEPTaskTab);
	}

	[Token(Token = "0x600DF57")]
	[Address(RVA = "0x2A4D360", Offset = "0x2A4D360", VA = "0x2A4D360")]
	private void SetWeeklyTabUnlockGuide(EEPTaskTab tab)
	{
	}

	[Token(Token = "0x600DF58")]
	[Address(RVA = "0x2A4D808", Offset = "0x2A4D808", VA = "0x2A4D808")]
	private void OnEPChallengeClaimPlayUIFX(object[] param)
	{
	}

	[Token(Token = "0x600DF59")]
	[Address(RVA = "0x2A45D28", Offset = "0x2A45D28", VA = "0x2A45D28")]
	private void GotoTab(EEPTaskTab tab)
	{
	}

	[Token(Token = "0x600DF5A")]
	[Address(RVA = "0x2A462B8", Offset = "0x2A462B8", VA = "0x2A462B8")]
	private void SetMaxRewardPreviewView()
	{
	}

	[Token(Token = "0x600DF5B")]
	[Address(RVA = "0x2A45DE8", Offset = "0x2A45DE8", VA = "0x2A45DE8")]
	public void SetClaimAllBtnClick()
	{
	}

	[Token(Token = "0x600DF5C")]
	[Address(RVA = "0x2A4DB6C", Offset = "0x2A4DB6C", VA = "0x2A4DB6C", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600DF5D")]
	[Address(RVA = "0x2A4DC64", Offset = "0x2A4DC64", VA = "0x2A4DC64", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600DF5E")]
	[Address(RVA = "0x2A4DCE0", Offset = "0x2A4DCE0", VA = "0x2A4DCE0", Slot = "33")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600DF5F")]
	[Address(RVA = "0x2A4DE4C", Offset = "0x2A4DE4C", VA = "0x2A4DE4C", Slot = "34")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600DF60")]
	[Address(RVA = "0x2A4DF04", Offset = "0x2A4DF04", VA = "0x2A4DF04")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600DF61")]
	[Address(RVA = "0x2A4E0F0", Offset = "0x2A4E0F0", VA = "0x2A4E0F0")]
	private void _003CSetWeeklyTabUnlockGuide_003Em__1()
	{
	}

	[Token(Token = "0x600DF62")]
	[Address(RVA = "0x2A4E1A4", Offset = "0x2A4E1A4", VA = "0x2A4E1A4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DF63")]
	[Address(RVA = "0x2A4E1AC", Offset = "0x2A4E1AC", VA = "0x2A4E1AC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
