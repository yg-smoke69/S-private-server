using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200265B")]
internal class UIGachaLimitContent : UIGachaContentBase, _Attribute
{
	[Token(Token = "0x200265C")]
	private enum CircleStage
	{
		[Token(Token = "0x400ECFC")]
		NORMAL_RUNNING,
		[Token(Token = "0x400ECFD")]
		GET_REWARD,
		[Token(Token = "0x400ECFE")]
		END
	}

	[Token(Token = "0x200265D")]
	private class RewardIdx
	{
		[Token(Token = "0x400ECFF")]
		[FieldOffset(Offset = "0x8")]
		public int idx;

		[Token(Token = "0x400ED00")]
		[FieldOffset(Offset = "0xC")]
		public int iterationIdx;

		[Token(Token = "0x600E577")]
		[Address(RVA = "0x2A102F4", Offset = "0x2A102F4", VA = "0x2A102F4")]
		public RewardIdx()
		{
		}
	}

	[Token(Token = "0x200265E")]
	private class RateCurve
	{
		[Token(Token = "0x400ED01")]
		[FieldOffset(Offset = "0x8")]
		public float a;

		[Token(Token = "0x400ED02")]
		[FieldOffset(Offset = "0xC")]
		public int powers;

		[Token(Token = "0x400ED03")]
		[FieldOffset(Offset = "0x10")]
		public float endY;

		[Token(Token = "0x600E578")]
		[Address(RVA = "0x2A102DC", Offset = "0x2A102DC", VA = "0x2A102DC")]
		public RateCurve()
		{
		}
	}

	[Token(Token = "0x400ECE7")]
	[FieldOffset(Offset = "0x44")]
	private bool isInPreview;

	[Token(Token = "0x400ECE8")]
	[FieldOffset(Offset = "0x48")]
	private UIGachaLimitContentView m_View;

	[Token(Token = "0x400ECE9")]
	[FieldOffset(Offset = "0x4C")]
	private List<GameObject> m_ItemPosList;

	[Token(Token = "0x400ECEA")]
	[FieldOffset(Offset = "0x50")]
	private List<UIGachaLimitItemController> m_ItemCtrlList;

	[Token(Token = "0x400ECEB")]
	[FieldOffset(Offset = "0x54")]
	private List<UIGachaExtraListItemController> m_ExtraList;

	[Token(Token = "0x400ECEC")]
	[FieldOffset(Offset = "0x58")]
	private UIModelGacha m_ModelGacha;

	[Token(Token = "0x400ECED")]
	[FieldOffset(Offset = "0x5C")]
	private GachaLimitInfoData m_GachaInfo;

	[Token(Token = "0x400ECEE")]
	[FieldOffset(Offset = "0x60")]
	private RateCurve m_Curve;

	[Token(Token = "0x400ECEF")]
	[FieldOffset(Offset = "0x64")]
	private List<RewardIdx> m_RewardIdxList;

	[Token(Token = "0x400ECF0")]
	[FieldOffset(Offset = "0x68")]
	private int m_CurRewardIdx;

	[Token(Token = "0x400ECF1")]
	[FieldOffset(Offset = "0x6C")]
	private int m_IterationCounter;

	[Token(Token = "0x400ECF2")]
	[FieldOffset(Offset = "0x70")]
	private uint m_CircleDC;

	[Token(Token = "0x400ECF3")]
	[FieldOffset(Offset = "0x74")]
	private bool m_IsSingleCircle;

	[Token(Token = "0x400ECF4")]
	[FieldOffset(Offset = "0x75")]
	private bool m_IsSkip;

	[Token(Token = "0x400ECF5")]
	private const int FAKE_CIRCLE_CNT = 2;

	[Token(Token = "0x400ECF6")]
	private const int TURNTABLE_REWARD_CNT = 10;

	[Token(Token = "0x400ECF7")]
	private const float GET_REWARD_SHOW_SECOND = 1f;

	[Token(Token = "0x400ECF8")]
	private const float FAST_ROUND_CD_SECOND = 0.05f;

	[Token(Token = "0x400ECF9")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400ECFA")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600E537")]
	[Address(RVA = "0x2E873EC", Offset = "0x2E873EC", VA = "0x2E873EC")]
	public UIGachaLimitContent()
	{
	}

	[Token(Token = "0x600E538")]
	[Address(RVA = "0x2E87504", Offset = "0x2E87504", VA = "0x2E87504")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E539")]
	[Address(RVA = "0x2E875A8", Offset = "0x2E875A8", VA = "0x2E875A8", Slot = "62")]
	public override string GetTutorialWndTitleKey()
	{
		return null;
	}

	[Token(Token = "0x600E53A")]
	[Address(RVA = "0x2E8764C", Offset = "0x2E8764C", VA = "0x2E8764C", Slot = "59")]
	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E53B")]
	[Address(RVA = "0x2E876E0", Offset = "0x2E876E0", VA = "0x2E876E0", Slot = "58")]
	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E53C")]
	[Address(RVA = "0x2E87EC0", Offset = "0x2E87EC0", VA = "0x2E87EC0", Slot = "54")]
	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	[Token(Token = "0x600E53D")]
	[Address(RVA = "0x2E87F38", Offset = "0x2E87F38", VA = "0x2E87F38", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E53E")]
	[Address(RVA = "0x2E88BE0", Offset = "0x2E88BE0", VA = "0x2E88BE0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E53F")]
	[Address(RVA = "0x2E88C44", Offset = "0x2E88C44", VA = "0x2E88C44", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E540")]
	[Address(RVA = "0x2E88F14", Offset = "0x2E88F14", VA = "0x2E88F14", Slot = "42")]
	public override void OnSkipAnim()
	{
	}

	[Token(Token = "0x600E541")]
	[Address(RVA = "0x2E88930", Offset = "0x2E88930", VA = "0x2E88930")]
	private void InitExtraAwardList()
	{
	}

	[Token(Token = "0x600E542")]
	[Address(RVA = "0x2E89248", Offset = "0x2E89248", VA = "0x2E89248")]
	private void ShowExtraPreviewWnd(object[] data)
	{
	}

	[Token(Token = "0x600E543")]
	[Address(RVA = "0x2E8949C", Offset = "0x2E8949C", VA = "0x2E8949C")]
	private void ShowExchangeResultWnd(object[] data)
	{
	}

	[Token(Token = "0x600E544")]
	[Address(RVA = "0x2E898DC", Offset = "0x2E898DC", VA = "0x2E898DC")]
	public void RefreshExtraRewardList(uint chestID)
	{
	}

	[Token(Token = "0x600E545")]
	[Address(RVA = "0x2E89DA0", Offset = "0x2E89DA0", VA = "0x2E89DA0")]
	private void SetextraAwardActive(bool enable)
	{
	}

	[Token(Token = "0x600E546")]
	[Address(RVA = "0x2E89E38", Offset = "0x2E89E38", VA = "0x2E89E38")]
	private void ShowRareProbabilityTips(object[] param)
	{
	}

	[Token(Token = "0x600E547")]
	[Address(RVA = "0x2E8848C", Offset = "0x2E8848C", VA = "0x2E8848C")]
	private void AssembleTurntable()
	{
	}

	[Token(Token = "0x600E548")]
	[Address(RVA = "0x2E8A444", Offset = "0x2E8A444", VA = "0x2E8A444", Slot = "33")]
	protected override void InitGachaContentBuyBtn()
	{
	}

	[Token(Token = "0x600E549")]
	[Address(RVA = "0x2E8A570", Offset = "0x2E8A570", VA = "0x2E8A570")]
	private void RefreshAllBtnState(bool finishRemove)
	{
	}

	[Token(Token = "0x600E54A")]
	[Address(RVA = "0x2E8ACC0", Offset = "0x2E8ACC0", VA = "0x2E8ACC0", Slot = "57")]
	protected override void OnPreviewSceneShowTypeChange()
	{
	}

	[Token(Token = "0x600E54B")]
	[Address(RVA = "0x2E8AD5C", Offset = "0x2E8AD5C", VA = "0x2E8AD5C", Slot = "34")]
	protected override void OnRefreshUIView()
	{
	}

	[Token(Token = "0x600E54C")]
	[Address(RVA = "0x2E877CC", Offset = "0x2E877CC", VA = "0x2E877CC")]
	private void RefreshRewardPool(bool needResetState = true)
	{
	}

	[Token(Token = "0x600E54D")]
	[Address(RVA = "0x2E8B098", Offset = "0x2E8B098", VA = "0x2E8B098")]
	private void RefreshCountDownLabel()
	{
	}

	[Token(Token = "0x600E54E")]
	[Address(RVA = "0x2E8B2D4", Offset = "0x2E8B2D4", VA = "0x2E8B2D4", Slot = "39")]
	public override void OnShowContent()
	{
	}

	[Token(Token = "0x600E54F")]
	[Address(RVA = "0x2E8B400", Offset = "0x2E8B400", VA = "0x2E8B400", Slot = "41")]
	public override void OnPurchaseResult(bool isSuccess)
	{
	}

	[Token(Token = "0x600E550")]
	[Address(RVA = "0x2E8B8F0", Offset = "0x2E8B8F0", VA = "0x2E8B8F0")]
	private void OnRemoveClick()
	{
	}

	[Token(Token = "0x600E551")]
	[Address(RVA = "0x2E8BBF8", Offset = "0x2E8BBF8", VA = "0x2E8BBF8")]
	private void OnRareProbabilityClick()
	{
	}

	[Token(Token = "0x600E552")]
	[Address(RVA = "0x2E8B5D4", Offset = "0x2E8B5D4", VA = "0x2E8B5D4")]
	public void Circle(GachaResultInfo info)
	{
	}

	[Token(Token = "0x600E553")]
	[Address(RVA = "0x2E8C8D4", Offset = "0x2E8C8D4", VA = "0x2E8C8D4", Slot = "38")]
	public override void OnHideContent()
	{
	}

	[Token(Token = "0x600E554")]
	[Address(RVA = "0x2E8C674", Offset = "0x2E8C674", VA = "0x2E8C674")]
	private void DoCircle()
	{
	}

	[Token(Token = "0x600E555")]
	[Address(RVA = "0x2E8CBE8", Offset = "0x2E8CBE8", VA = "0x2E8CBE8")]
	private void SetOutstand(int idx, UIGachaLimitItemController.ViewStage stage)
	{
	}

	[Token(Token = "0x600E556")]
	[Address(RVA = "0x2E8CEF4", Offset = "0x2E8CEF4", VA = "0x2E8CEF4")]
	private void ShowResultView()
	{
	}

	[Token(Token = "0x600E557")]
	[Address(RVA = "0x2E8905C", Offset = "0x2E8905C", VA = "0x2E8905C")]
	private void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	[Token(Token = "0x600E558")]
	[Address(RVA = "0x2E8C990", Offset = "0x2E8C990", VA = "0x2E8C990")]
	private CircleStage GetCircleStage(int curIterationCounter)
	{
		return default(CircleStage);
	}

	[Token(Token = "0x600E559")]
	[Address(RVA = "0x2E8D040", Offset = "0x2E8D040", VA = "0x2E8D040")]
	private int RandomFindIdx(ExchangedAward award)
	{
		return default(int);
	}

	[Token(Token = "0x600E55A")]
	[Address(RVA = "0x2E8BE1C", Offset = "0x2E8BE1C", VA = "0x2E8BE1C")]
	private void Reset()
	{
	}

	[Token(Token = "0x600E55B")]
	[Address(RVA = "0x2E8B6E0", Offset = "0x2E8B6E0", VA = "0x2E8B6E0")]
	private void EnableInterfaceMask(bool v)
	{
	}

	[Token(Token = "0x600E55C")]
	[Address(RVA = "0x2E8C06C", Offset = "0x2E8C06C", VA = "0x2E8C06C")]
	private void GenRewardIndexList(GachaResultInfo info)
	{
	}

	[Token(Token = "0x600E55D")]
	[Address(RVA = "0x2E8C4A8", Offset = "0x2E8C4A8", VA = "0x2E8C4A8")]
	private void BuildFirstLapRateCurve()
	{
	}

	[Token(Token = "0x600E55E")]
	[Address(RVA = "0x2E8D430", Offset = "0x2E8D430", VA = "0x2E8D430")]
	public void SetItemPreviewState(BaseItemInfo info, int index = 0)
	{
	}

	[Token(Token = "0x600E55F")]
	[Address(RVA = "0x2E8D95C", Offset = "0x2E8D95C", VA = "0x2E8D95C", Slot = "61")]
	public override UIGachaPreviewController OpenPreviewPanel(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E560")]
	[Address(RVA = "0x2E8DA54", Offset = "0x2E8DA54", VA = "0x2E8DA54", Slot = "46")]
	public override void OnRewardPoolOpen()
	{
	}

	[Token(Token = "0x600E561")]
	[Address(RVA = "0x2E8DC1C", Offset = "0x2E8DC1C", VA = "0x2E8DC1C", Slot = "45")]
	public override void OnRewardPoolClose()
	{
	}

	[Token(Token = "0x600E562")]
	[Address(RVA = "0x2E8DF38", Offset = "0x2E8DF38", VA = "0x2E8DF38")]
	private void OnClosePreviewClick()
	{
	}

	[Token(Token = "0x600E563")]
	[Address(RVA = "0x2E8CD90", Offset = "0x2E8CD90", VA = "0x2E8CD90")]
	private float RateSample(int curIterationCounter)
	{
		return default(float);
	}

	[Token(Token = "0x600E564")]
	[Address(RVA = "0x2E8E044", Offset = "0x2E8E044", VA = "0x2E8E044")]
	private bool IsInFirstCircle(int curIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x600E565")]
	[Address(RVA = "0x2E8E170", Offset = "0x2E8E170", VA = "0x2E8E170")]
	private float RateCelling(float rate)
	{
		return default(float);
	}

	[Token(Token = "0x600E566")]
	[Address(RVA = "0x2E8E1E4", Offset = "0x2E8E1E4", VA = "0x2E8E1E4")]
	private static CommonRewardItemInfo _003CShowExchangeResultWnd_003Em__0(ExchangedAward item)
	{
		return null;
	}

	[Token(Token = "0x600E567")]
	[Address(RVA = "0x2E8E1EC", Offset = "0x2E8E1EC", VA = "0x2E8E1EC")]
	private static void _003CShowExchangeResultWnd_003Em__1()
	{
	}

	[Token(Token = "0x600E568")]
	[Address(RVA = "0x2E8E2AC", Offset = "0x2E8E2AC", VA = "0x2E8E2AC")]
	private void _003CShowResultView_003Em__2()
	{
	}

	[Token(Token = "0x600E569")]
	[Address(RVA = "0x2E8E2E4", Offset = "0x2E8E2E4", VA = "0x2E8E2E4")]
	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return default(uint);
	}

	[Token(Token = "0x600E56A")]
	[Address(RVA = "0x2E8E2EC", Offset = "0x2E8E2EC", VA = "0x2E8E2EC")]
	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	[Token(Token = "0x600E56B")]
	[Address(RVA = "0x2E8E30C", Offset = "0x2E8E30C", VA = "0x2E8E30C")]
	public UIWidget _003C_003EiFixBaseProxy_GetPreviewSceneBorder(uint P0)
	{
		return null;
	}

	[Token(Token = "0x600E56C")]
	[Address(RVA = "0x2E8E314", Offset = "0x2E8E314", VA = "0x2E8E314")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E56D")]
	[Address(RVA = "0x2E8E31C", Offset = "0x2E8E31C", VA = "0x2E8E31C")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E56E")]
	[Address(RVA = "0x2E8E324", Offset = "0x2E8E324", VA = "0x2E8E324")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E56F")]
	[Address(RVA = "0x2E8E32C", Offset = "0x2E8E32C", VA = "0x2E8E32C")]
	public void _003C_003EiFixBaseProxy_OnSkipAnim()
	{
	}

	[Token(Token = "0x600E570")]
	[Address(RVA = "0x2E8E334", Offset = "0x2E8E334", VA = "0x2E8E334")]
	public void _003C_003EiFixBaseProxy_OnPreviewSceneShowTypeChange()
	{
	}

	[Token(Token = "0x600E571")]
	[Address(RVA = "0x2E8E33C", Offset = "0x2E8E33C", VA = "0x2E8E33C")]
	public void _003C_003EiFixBaseProxy_OnShowContent()
	{
	}

	[Token(Token = "0x600E572")]
	[Address(RVA = "0x2E8E344", Offset = "0x2E8E344", VA = "0x2E8E344")]
	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0)
	{
	}

	[Token(Token = "0x600E573")]
	[Address(RVA = "0x2E8E34C", Offset = "0x2E8E34C", VA = "0x2E8E34C")]
	public void _003C_003EiFixBaseProxy_OnHideContent()
	{
	}

	[Token(Token = "0x600E574")]
	[Address(RVA = "0x2E8E354", Offset = "0x2E8E354", VA = "0x2E8E354")]
	public UIGachaPreviewController _003C_003EiFixBaseProxy_OpenPreviewPanel(Transform P0)
	{
		return null;
	}

	[Token(Token = "0x600E575")]
	[Address(RVA = "0x2E8E35C", Offset = "0x2E8E35C", VA = "0x2E8E35C")]
	public void _003C_003EiFixBaseProxy_OnRewardPoolOpen()
	{
	}

	[Token(Token = "0x600E576")]
	[Address(RVA = "0x2E8E364", Offset = "0x2E8E364", VA = "0x2E8E364")]
	public void _003C_003EiFixBaseProxy_OnRewardPoolClose()
	{
	}
}
