using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200267D")]
public class UIGachaTurntableContent : UIGachaContentBase
{
	[Token(Token = "0x200267E")]
	private enum CircleStage
	{
		[Token(Token = "0x400EDAD")]
		NORMAL_RUNNING,
		[Token(Token = "0x400EDAE")]
		GET_REWARD,
		[Token(Token = "0x400EDAF")]
		END
	}

	[Token(Token = "0x200267F")]
	private class RewardIdx
	{
		[Token(Token = "0x400EDB0")]
		[FieldOffset(Offset = "0x8")]
		public int idx;

		[Token(Token = "0x400EDB1")]
		[FieldOffset(Offset = "0xC")]
		public int iterationIdx;

		[Token(Token = "0x600E71B")]
		[Address(RVA = "0x2E96D94", Offset = "0x2E96D94", VA = "0x2E96D94")]
		public RewardIdx()
		{
		}
	}

	[Token(Token = "0x2002680")]
	private class RateCurve
	{
		[Token(Token = "0x400EDB2")]
		[FieldOffset(Offset = "0x8")]
		public float a;

		[Token(Token = "0x400EDB3")]
		[FieldOffset(Offset = "0xC")]
		public int powers;

		[Token(Token = "0x400EDB4")]
		[FieldOffset(Offset = "0x10")]
		public float endY;

		[Token(Token = "0x600E71C")]
		[Address(RVA = "0x2E90A24", Offset = "0x2E90A24", VA = "0x2E90A24")]
		public RateCurve()
		{
		}
	}

	[Token(Token = "0x2002681")]
	private class PropsUI
	{
		[Token(Token = "0x400EDB5")]
		[FieldOffset(Offset = "0x8")]
		public UIEventListener eventListener;

		[Token(Token = "0x400EDB6")]
		[FieldOffset(Offset = "0xC")]
		public UISprite icon;

		[Token(Token = "0x400EDB7")]
		[FieldOffset(Offset = "0x10")]
		public UILabel count;

		[Token(Token = "0x600E71D")]
		[Address(RVA = "0x2E912A0", Offset = "0x2E912A0", VA = "0x2E912A0")]
		public PropsUI()
		{
		}

		[Token(Token = "0x600E71E")]
		[Address(RVA = "0x2E947B8", Offset = "0x2E947B8", VA = "0x2E947B8")]
		public void SetActive(bool value)
		{
		}
	}

	[Token(Token = "0x2002682")]
	private sealed class _003COnRefreshUIView_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EDB8")]
		[FieldOffset(Offset = "0x8")]
		internal CSSharedItemData itemData;

		[Token(Token = "0x600E71F")]
		[Address(RVA = "0x2E948E4", Offset = "0x2E948E4", VA = "0x2E948E4")]
		public _003COnRefreshUIView_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E720")]
		[Address(RVA = "0x2E98DEC", Offset = "0x2E98DEC", VA = "0x2E98DEC")]
		internal void _003C_003Em__0(GameObject e)
		{
		}
	}

	[Token(Token = "0x400ED93")]
	[FieldOffset(Offset = "0x44")]
	private UIGachaTurntableContentView m_View;

	[Token(Token = "0x400ED94")]
	[FieldOffset(Offset = "0x48")]
	private UIModelGacha m_ModelGacha;

	[Token(Token = "0x400ED95")]
	[FieldOffset(Offset = "0x4C")]
	private List<RewardIdx> m_RewardIdxList;

	[Token(Token = "0x400ED96")]
	[FieldOffset(Offset = "0x50")]
	private List<GameObject> m_ItemPosList;

	[Token(Token = "0x400ED97")]
	[FieldOffset(Offset = "0x54")]
	private List<UIGachaTurntableItemController> m_ItemCtrlList;

	[Token(Token = "0x400ED98")]
	[FieldOffset(Offset = "0x58")]
	private List<UIGachaExtraListItemController> m_ExtraList;

	[Token(Token = "0x400ED99")]
	[FieldOffset(Offset = "0x5C")]
	private int m_CurRewardIdx;

	[Token(Token = "0x400ED9A")]
	[FieldOffset(Offset = "0x60")]
	private int m_IterationCounter;

	[Token(Token = "0x400ED9B")]
	[FieldOffset(Offset = "0x64")]
	private uint m_CircleDC;

	[Token(Token = "0x400ED9C")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsSingleCircle;

	[Token(Token = "0x400ED9D")]
	[FieldOffset(Offset = "0x69")]
	private bool m_IsSkip;

	[Token(Token = "0x400ED9E")]
	private const int FAKE_CIRCLE_CNT = 3;

	[Token(Token = "0x400ED9F")]
	private const int TURNTABLE_REWARD_CNT = 12;

	[Token(Token = "0x400EDA0")]
	private const float GET_REWARD_SHOW_SECOND = 1f;

	[Token(Token = "0x400EDA1")]
	private const float FAST_ROUND_CD_SECOND = 0.05f;

	[Token(Token = "0x400EDA2")]
	[FieldOffset(Offset = "0x6C")]
	private UICountDownController m_CountDownCtrl;

	[Token(Token = "0x400EDA3")]
	[FieldOffset(Offset = "0x70")]
	private RateCurve m_Curve;

	[Token(Token = "0x400EDA4")]
	[FieldOffset(Offset = "0x74")]
	private List<PropsUI> m_PropsUIs;

	[Token(Token = "0x400EDA5")]
	[FieldOffset(Offset = "0x78")]
	private float m_ItemAnimCheckTime;

	[Token(Token = "0x400EDA6")]
	[FieldOffset(Offset = "0x7C")]
	private int m_NextItemIndex;

	[Token(Token = "0x400EDA7")]
	[FieldOffset(Offset = "0x80")]
	private bool m_CanPlayItemAnim;

	[Token(Token = "0x400EDA8")]
	[FieldOffset(Offset = "0x84")]
	private int m_ItemAnimInterval;

	[Token(Token = "0x400EDA9")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<GachaShowItem> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400EDAA")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400EDAB")]
	[FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache2;

	[Token(Token = "0x1700118E")]
	public bool IsSkip
	{
		[Token(Token = "0x600E6E4")]
		[Address(RVA = "0x2E90AA0", Offset = "0x2E90AA0", VA = "0x2E90AA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600E6E3")]
		[Address(RVA = "0x2E90A40", Offset = "0x2E90A40", VA = "0x2E90A40")]
		set
		{
		}
	}

	[Token(Token = "0x600E6E2")]
	[Address(RVA = "0x2E908B4", Offset = "0x2E908B4", VA = "0x2E908B4")]
	public UIGachaTurntableContent()
	{
	}

	[Token(Token = "0x600E6E5")]
	[Address(RVA = "0x2E90AF8", Offset = "0x2E90AF8", VA = "0x2E90AF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E6E6")]
	[Address(RVA = "0x2E90B9C", Offset = "0x2E90B9C", VA = "0x2E90B9C", Slot = "62")]
	public override string GetTutorialWndTitleKey()
	{
		return null;
	}

	[Token(Token = "0x600E6E7")]
	[Address(RVA = "0x2E90C40", Offset = "0x2E90C40", VA = "0x2E90C40", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E6E8")]
	[Address(RVA = "0x2E91AA4", Offset = "0x2E91AA4", VA = "0x2E91AA4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E6E9")]
	[Address(RVA = "0x2E91B08", Offset = "0x2E91B08", VA = "0x2E91B08", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E6EA")]
	[Address(RVA = "0x2E91DB0", Offset = "0x2E91DB0", VA = "0x2E91DB0", Slot = "39")]
	public override void OnShowContent()
	{
	}

	[Token(Token = "0x600E6EB")]
	[Address(RVA = "0x2E91F30", Offset = "0x2E91F30", VA = "0x2E91F30")]
	private void Update()
	{
	}

	[Token(Token = "0x600E6EC")]
	[Address(RVA = "0x2E9229C", Offset = "0x2E9229C", VA = "0x2E9229C")]
	private void ResetItemAnim()
	{
	}

	[Token(Token = "0x600E6ED")]
	[Address(RVA = "0x2E925D0", Offset = "0x2E925D0", VA = "0x2E925D0", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600E6EE")]
	[Address(RVA = "0x2E92668", Offset = "0x2E92668", VA = "0x2E92668", Slot = "33")]
	protected override void InitGachaContentBuyBtn()
	{
	}

	[Token(Token = "0x600E6EF")]
	[Address(RVA = "0x2E92794", Offset = "0x2E92794", VA = "0x2E92794")]
	private void ProcessAnimEvt(object[] data)
	{
	}

	[Token(Token = "0x600E6F0")]
	[Address(RVA = "0x2E92A0C", Offset = "0x2E92A0C", VA = "0x2E92A0C", Slot = "34")]
	protected override void OnRefreshUIView()
	{
	}

	[Token(Token = "0x600E6F1")]
	[Address(RVA = "0x2E9412C", Offset = "0x2E9412C", VA = "0x2E9412C")]
	private void RefreshCountDownLabel()
	{
	}

	[Token(Token = "0x600E6F2")]
	[Address(RVA = "0x2E94E0C", Offset = "0x2E94E0C", VA = "0x2E94E0C")]
	private void ShowExchangeResultWnd(object[] data)
	{
	}

	[Token(Token = "0x600E6F3")]
	[Address(RVA = "0x2E95248", Offset = "0x2E95248", VA = "0x2E95248", Slot = "41")]
	public override void OnPurchaseResult(bool isSuccess)
	{
	}

	[Token(Token = "0x600E6F4")]
	[Address(RVA = "0x2E955C0", Offset = "0x2E955C0", VA = "0x2E955C0", Slot = "54")]
	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	[Token(Token = "0x600E6F5")]
	[Address(RVA = "0x2E95638", Offset = "0x2E95638", VA = "0x2E95638", Slot = "42")]
	public override void OnSkipAnim()
	{
	}

	[Token(Token = "0x600E6F6")]
	[Address(RVA = "0x2E954B4", Offset = "0x2E954B4", VA = "0x2E954B4")]
	public void Circle(GachaResultInfo info)
	{
	}

	[Token(Token = "0x600E6F7")]
	[Address(RVA = "0x2E912A8", Offset = "0x2E912A8", VA = "0x2E912A8")]
	private void AssembleTurntable()
	{
	}

	[Token(Token = "0x600E6F8")]
	[Address(RVA = "0x2E917F4", Offset = "0x2E917F4", VA = "0x2E917F4")]
	private void InitExtraAwardList()
	{
	}

	[Token(Token = "0x600E6F9")]
	[Address(RVA = "0x2E967A0", Offset = "0x2E967A0", VA = "0x2E967A0")]
	private void ShowExtraPreviewWnd(object[] data)
	{
	}

	[Token(Token = "0x600E6FA")]
	[Address(RVA = "0x2E948EC", Offset = "0x2E948EC", VA = "0x2E948EC")]
	private void RefreshExtraRewardList(uint chestID)
	{
	}

	[Token(Token = "0x600E6FB")]
	[Address(RVA = "0x2E95DA4", Offset = "0x2E95DA4", VA = "0x2E95DA4")]
	private void GenRewardIndexList(GachaResultInfo info)
	{
	}

	[Token(Token = "0x600E6FC")]
	[Address(RVA = "0x2E969F4", Offset = "0x2E969F4", VA = "0x2E969F4")]
	private int RandomFindIdx(ExchangedAward award)
	{
		return default(int);
	}

	[Token(Token = "0x600E6FD")]
	[Address(RVA = "0x2E9614C", Offset = "0x2E9614C", VA = "0x2E9614C")]
	private void BuildFirstLapRateCurve()
	{
	}

	[Token(Token = "0x600E6FE")]
	[Address(RVA = "0x2E96E4C", Offset = "0x2E96E4C", VA = "0x2E96E4C")]
	private float RateSample(int curIterationCounter)
	{
		return default(float);
	}

	[Token(Token = "0x600E6FF")]
	[Address(RVA = "0x2E970DC", Offset = "0x2E970DC", VA = "0x2E970DC")]
	private float RateCelling(float rate)
	{
		return default(float);
	}

	[Token(Token = "0x600E700")]
	[Address(RVA = "0x2E964D8", Offset = "0x2E964D8", VA = "0x2E964D8")]
	private void DoCircle()
	{
	}

	[Token(Token = "0x600E701")]
	[Address(RVA = "0x2E973A8", Offset = "0x2E973A8", VA = "0x2E973A8")]
	private void SetOutstand(int idx, UIGachaTurntableItemController.ViewStage stage)
	{
	}

	[Token(Token = "0x600E702")]
	[Address(RVA = "0x2E97150", Offset = "0x2E97150", VA = "0x2E97150")]
	private CircleStage GetCircleStage(int curIterationCounter)
	{
		return default(CircleStage);
	}

	[Token(Token = "0x600E703")]
	[Address(RVA = "0x2E95B58", Offset = "0x2E95B58", VA = "0x2E95B58")]
	private void Reset()
	{
	}

	[Token(Token = "0x600E704")]
	[Address(RVA = "0x2E976B8", Offset = "0x2E976B8", VA = "0x2E976B8")]
	private void ShowResultView()
	{
	}

	[Token(Token = "0x600E705")]
	[Address(RVA = "0x2E9579C", Offset = "0x2E9579C", VA = "0x2E9579C")]
	private void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	[Token(Token = "0x600E706")]
	[Address(RVA = "0x2E97804", Offset = "0x2E97804", VA = "0x2E97804")]
	private void OnHatchingDoorClick()
	{
	}

	[Token(Token = "0x600E707")]
	[Address(RVA = "0x2E97B4C", Offset = "0x2E97B4C", VA = "0x2E97B4C")]
	private void OnRareProbabilityClick()
	{
	}

	[Token(Token = "0x600E708")]
	[Address(RVA = "0x2E97C78", Offset = "0x2E97C78", VA = "0x2E97C78")]
	private void ShowRareProbabilityTips(object[] param)
	{
	}

	[Token(Token = "0x600E709")]
	[Address(RVA = "0x2E962C8", Offset = "0x2E962C8", VA = "0x2E962C8")]
	private void EnableInterfaceMask(bool v)
	{
	}

	[Token(Token = "0x600E70A")]
	[Address(RVA = "0x2E96FB0", Offset = "0x2E96FB0", VA = "0x2E96FB0")]
	private bool IsInFirstCircle(int curIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x600E70B")]
	[Address(RVA = "0x2E928F4", Offset = "0x2E928F4", VA = "0x2E928F4")]
	private void PlayTurntableShowSound()
	{
	}

	[Token(Token = "0x600E70C")]
	[Address(RVA = "0x2E9810C", Offset = "0x2E9810C", VA = "0x2E9810C")]
	private void DEBUG_ID(GachaResultInfo info)
	{
	}

	[Token(Token = "0x600E70D")]
	[Address(RVA = "0x2E98768", Offset = "0x2E98768", VA = "0x2E98768")]
	private void DEBUG_IDX()
	{
	}

	[Token(Token = "0x600E70E")]
	[Address(RVA = "0x2E98B78", Offset = "0x2E98B78", VA = "0x2E98B78")]
	private static bool _003COnRefreshUIView_003Em__0(GachaShowItem e)
	{
		return default(bool);
	}

	[Token(Token = "0x600E70F")]
	[Address(RVA = "0x2E98BA4", Offset = "0x2E98BA4", VA = "0x2E98BA4")]
	private void _003CRefreshCountDownLabel_003Em__1()
	{
	}

	[Token(Token = "0x600E710")]
	[Address(RVA = "0x2E98CA8", Offset = "0x2E98CA8", VA = "0x2E98CA8")]
	private static CommonRewardItemInfo _003CShowExchangeResultWnd_003Em__2(ExchangedAward item)
	{
		return null;
	}

	[Token(Token = "0x600E711")]
	[Address(RVA = "0x2E98CB0", Offset = "0x2E98CB0", VA = "0x2E98CB0")]
	private static void _003CShowExchangeResultWnd_003Em__3()
	{
	}

	[Token(Token = "0x600E712")]
	[Address(RVA = "0x2E98D70", Offset = "0x2E98D70", VA = "0x2E98D70")]
	private void _003CShowResultView_003Em__4()
	{
	}

	[Token(Token = "0x600E713")]
	[Address(RVA = "0x2E98DAC", Offset = "0x2E98DAC", VA = "0x2E98DAC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E714")]
	[Address(RVA = "0x2E98DB4", Offset = "0x2E98DB4", VA = "0x2E98DB4")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E715")]
	[Address(RVA = "0x2E98DBC", Offset = "0x2E98DBC", VA = "0x2E98DBC")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E716")]
	[Address(RVA = "0x2E98DC4", Offset = "0x2E98DC4", VA = "0x2E98DC4")]
	public void _003C_003EiFixBaseProxy_OnShowContent()
	{
	}

	[Token(Token = "0x600E717")]
	[Address(RVA = "0x2E98DCC", Offset = "0x2E98DCC", VA = "0x2E98DCC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600E718")]
	[Address(RVA = "0x2E98DD4", Offset = "0x2E98DD4", VA = "0x2E98DD4")]
	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0)
	{
	}

	[Token(Token = "0x600E719")]
	[Address(RVA = "0x2E98DDC", Offset = "0x2E98DDC", VA = "0x2E98DDC")]
	public UIWidget _003C_003EiFixBaseProxy_GetPreviewSceneBorder(uint P0)
	{
		return null;
	}

	[Token(Token = "0x600E71A")]
	[Address(RVA = "0x2E98DE4", Offset = "0x2E98DE4", VA = "0x2E98DE4")]
	public void _003C_003EiFixBaseProxy_OnSkipAnim()
	{
	}
}
