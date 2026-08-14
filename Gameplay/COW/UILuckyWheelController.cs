using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200295C")]
public class UILuckyWheelController : UINavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x200295D")]
	private enum CircleStage
	{
		[Token(Token = "0x400FF04")]
		NORMAL_RUNNING,
		[Token(Token = "0x400FF05")]
		GET_REWARD,
		[Token(Token = "0x400FF06")]
		END
	}

	[Token(Token = "0x200295E")]
	private class RewardIdx
	{
		[Token(Token = "0x400FF07")]
		[FieldOffset(Offset = "0x8")]
		public int idx;

		[Token(Token = "0x400FF08")]
		[FieldOffset(Offset = "0xC")]
		public int iterationIdx;

		[Token(Token = "0x6010935")]
		[Address(RVA = "0x18C8CC8", Offset = "0x18C8CC8", VA = "0x18C8CC8")]
		public RewardIdx()
		{
		}
	}

	[Token(Token = "0x200295F")]
	private class RateCurve
	{
		[Token(Token = "0x400FF09")]
		[FieldOffset(Offset = "0x8")]
		public float a;

		[Token(Token = "0x400FF0A")]
		[FieldOffset(Offset = "0xC")]
		public int powers;

		[Token(Token = "0x400FF0B")]
		[FieldOffset(Offset = "0x10")]
		public float endY;

		[Token(Token = "0x6010936")]
		[Address(RVA = "0x18C8CB0", Offset = "0x18C8CB0", VA = "0x18C8CB0")]
		public RateCurve()
		{
		}
	}

	[Token(Token = "0x2002960")]
	private sealed class _003CIERefreshRewardPool_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FF0C")]
		[FieldOffset(Offset = "0x8")]
		internal List<CSLuckyWheelShopItemDesc> _003CcurrentRewardList_003E__0;

		[Token(Token = "0x400FF0D")]
		[FieldOffset(Offset = "0xC")]
		internal List<UILuckWheelRewardPoolItemController>.Enumerator _0024locvar0;

		[Token(Token = "0x400FF0E")]
		[FieldOffset(Offset = "0x1C")]
		internal int _003Ci_003E__1;

		[Token(Token = "0x400FF0F")]
		[FieldOffset(Offset = "0x20")]
		internal UILuckyWheelController _0024this;

		[Token(Token = "0x400FF10")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x400FF11")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0024disposing;

		[Token(Token = "0x400FF12")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x1700125B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6010939")]
			[Address(RVA = "0x18C8C04", Offset = "0x18C8C04", VA = "0x18C8C04", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700125C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601093A")]
			[Address(RVA = "0x18C8C0C", Offset = "0x18C8C0C", VA = "0x18C8C0C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6010937")]
		[Address(RVA = "0x18C888C", Offset = "0x18C888C", VA = "0x18C888C")]
		public _003CIERefreshRewardPool_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6010938")]
		[Address(RVA = "0x18C8894", Offset = "0x18C8894", VA = "0x18C8894", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601093B")]
		[Address(RVA = "0x18C8C14", Offset = "0x18C8C14", VA = "0x18C8C14", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601093C")]
		[Address(RVA = "0x18C8C28", Offset = "0x18C8C28", VA = "0x18C8C28", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400FEE8")]
	private const string WEBVIEWTUTORIALKEY = "WebViewTutorialKey";

	[Token(Token = "0x400FEE9")]
	public const uint CDNSUBTYPETITLE = 1u;

	[Token(Token = "0x400FEEA")]
	public const uint CDNSUBTYPEBG = 2u;

	[Token(Token = "0x400FEEB")]
	public const uint CDNSUBTYPESHARETITLE = 3u;

	[Token(Token = "0x400FEEC")]
	[FieldOffset(Offset = "0x68")]
	private UILuckyWheelView m_View;

	[Token(Token = "0x400FEED")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelLuckyWheel m_Model;

	[Token(Token = "0x400FEEE")]
	[FieldOffset(Offset = "0x70")]
	private UIModelCDNAd m_CDNModel;

	[Token(Token = "0x400FEEF")]
	[FieldOffset(Offset = "0x74")]
	private List<Transform> m_AwardContainerList;

	[Token(Token = "0x400FEF0")]
	[FieldOffset(Offset = "0x78")]
	private List<UILuckWheelRewardPoolItemController> m_RewardPoolItemControllerList;

	[Token(Token = "0x400FEF1")]
	[FieldOffset(Offset = "0x7C")]
	private List<UILuckyWheelItemController> m_WheelItemControllerList;

	[Token(Token = "0x400FEF2")]
	[FieldOffset(Offset = "0x80")]
	private List<GameObject> m_GlowObjList;

	[Token(Token = "0x400FEF3")]
	[FieldOffset(Offset = "0x84")]
	public bool NeedResetWheel;

	[Token(Token = "0x400FEF4")]
	[FieldOffset(Offset = "0x85")]
	private bool m_IsRefreshing;

	[Token(Token = "0x400FEF5")]
	[FieldOffset(Offset = "0x86")]
	private bool m_IsInPreview;

	[Token(Token = "0x400FEF6")]
	[FieldOffset(Offset = "0x88")]
	private uint m_DrawBtnDelayCall;

	[Token(Token = "0x400FEF7")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_RefreshBtnDelayCall;

	[Token(Token = "0x400FEF8")]
	[FieldOffset(Offset = "0x90")]
	private uint m_RefreshRewardPoolDiscountDelayCall;

	[Token(Token = "0x400FEF9")]
	[FieldOffset(Offset = "0x94")]
	private Coroutine m_RefreshCoroutine;

	[Token(Token = "0x400FEFA")]
	[FieldOffset(Offset = "0x98")]
	private RateCurve m_Curve;

	[Token(Token = "0x400FEFB")]
	[FieldOffset(Offset = "0x9C")]
	private List<RewardIdx> m_RewardIdxList;

	[Token(Token = "0x400FEFC")]
	[FieldOffset(Offset = "0xA0")]
	private int m_CurRewardIdx;

	[Token(Token = "0x400FEFD")]
	[FieldOffset(Offset = "0xA4")]
	private int m_IterationCounter;

	[Token(Token = "0x400FEFE")]
	[FieldOffset(Offset = "0xA8")]
	private uint m_CircleDC;

	[Token(Token = "0x400FEFF")]
	private const int FAKE_CIRCLE_CNT = 2;

	[Token(Token = "0x400FF00")]
	private const int TURNTABLE_REWARD_CNT = 8;

	[Token(Token = "0x400FF01")]
	private const float GET_REWARD_SHOW_SECOND = 1f;

	[Token(Token = "0x400FF02")]
	private const float FAST_ROUND_CD_SECOND = 0.05f;

	[Token(Token = "0x60108EA")]
	[Address(RVA = "0x2203D44", Offset = "0x2203D44", VA = "0x2203D44")]
	public UILuckyWheelController()
	{
	}

	[Token(Token = "0x60108EB")]
	[Address(RVA = "0x2203EF0", Offset = "0x2203EF0", VA = "0x2203EF0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60108EC")]
	[Address(RVA = "0x2203F98", Offset = "0x2203F98", VA = "0x2203F98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60108ED")]
	[Address(RVA = "0x2205670", Offset = "0x2205670", VA = "0x2205670", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x60108EE")]
	[Address(RVA = "0x22060AC", Offset = "0x22060AC", VA = "0x22060AC", Slot = "37")]
	protected override bool NeedWaitDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x60108EF")]
	[Address(RVA = "0x2206104", Offset = "0x2206104", VA = "0x2206104", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x60108F0")]
	[Address(RVA = "0x2206228", Offset = "0x2206228", VA = "0x2206228", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60108F1")]
	[Address(RVA = "0x2205C48", Offset = "0x2205C48", VA = "0x2205C48")]
	private void TryShowTutorial()
	{
	}

	[Token(Token = "0x60108F2")]
	[Address(RVA = "0x2206550", Offset = "0x2206550", VA = "0x2206550")]
	private void ProcessAnimEvt(object[] data)
	{
	}

	[Token(Token = "0x60108F3")]
	[Address(RVA = "0x2204F0C", Offset = "0x2204F0C", VA = "0x2204F0C")]
	private void SetCDNTitle()
	{
	}

	[Token(Token = "0x60108F4")]
	[Address(RVA = "0x2204CC8", Offset = "0x2204CC8", VA = "0x2204CC8")]
	private void SetBGCDN()
	{
	}

	[Token(Token = "0x60108F5")]
	[Address(RVA = "0x2205B70", Offset = "0x2205B70", VA = "0x2205B70")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x60108F6")]
	[Address(RVA = "0x220831C", Offset = "0x220831C", VA = "0x220831C")]
	private void RefreshRefreshBtnState()
	{
	}

	[Token(Token = "0x60108F7")]
	[Address(RVA = "0x2206F28", Offset = "0x2206F28", VA = "0x2206F28")]
	private void SetFinishedLuckyWheelView()
	{
	}

	[Token(Token = "0x60108F8")]
	[Address(RVA = "0x22080F0", Offset = "0x22080F0", VA = "0x22080F0")]
	private void RefreshPreviewRewardPoolItem()
	{
	}

	[Token(Token = "0x60108F9")]
	[Address(RVA = "0x22078BC", Offset = "0x22078BC", VA = "0x22078BC")]
	private void RefreshCurrentDiscount()
	{
	}

	[Token(Token = "0x60108FA")]
	[Address(RVA = "0x2208504", Offset = "0x2208504", VA = "0x2208504")]
	private void RefreshDiscountAfterDraw()
	{
	}

	[Token(Token = "0x60108FB")]
	[Address(RVA = "0x2208BD8", Offset = "0x2208BD8", VA = "0x2208BD8")]
	private void ShowRewardPoolDiscount()
	{
	}

	[Token(Token = "0x60108FC")]
	[Address(RVA = "0x2204368", Offset = "0x2204368", VA = "0x2204368")]
	private void InitView()
	{
	}

	[Token(Token = "0x60108FD")]
	[Address(RVA = "0x22057F0", Offset = "0x22057F0", VA = "0x22057F0")]
	private void ResetVfx()
	{
	}

	[Token(Token = "0x60108FE")]
	[Address(RVA = "0x22059D0", Offset = "0x22059D0", VA = "0x22059D0")]
	private void ResetRewardPoolItemVfx()
	{
	}

	[Token(Token = "0x60108FF")]
	[Address(RVA = "0x22044D8", Offset = "0x22044D8", VA = "0x22044D8")]
	private void AddEventDelegate()
	{
	}

	[Token(Token = "0x6010900")]
	[Address(RVA = "0x2208D84", Offset = "0x2208D84", VA = "0x2208D84")]
	private void SkipAnimation()
	{
	}

	[Token(Token = "0x6010901")]
	[Address(RVA = "0x22047DC", Offset = "0x22047DC", VA = "0x22047DC")]
	private void InitAwardContainer()
	{
	}

	[Token(Token = "0x6010902")]
	[Address(RVA = "0x2204AB0", Offset = "0x2204AB0", VA = "0x2204AB0")]
	private void InitItemControllers()
	{
	}

	[Token(Token = "0x6010903")]
	[Address(RVA = "0x22051AC", Offset = "0x22051AC", VA = "0x22051AC")]
	private void InitGlowObjects()
	{
	}

	[Token(Token = "0x6010904")]
	[Address(RVA = "0x22054AC", Offset = "0x22054AC", VA = "0x22054AC")]
	private void InitRewardPoolItemControllers()
	{
	}

	[Token(Token = "0x6010905")]
	[Address(RVA = "0x22091D0", Offset = "0x22091D0", VA = "0x22091D0")]
	private void OnHelpBtnClick(object[] param)
	{
	}

	[Token(Token = "0x6010906")]
	[Address(RVA = "0x22072F8", Offset = "0x22072F8", VA = "0x22072F8")]
	private void RefreshDrawBtnState()
	{
	}

	[Token(Token = "0x6010907")]
	[Address(RVA = "0x2208448", Offset = "0x2208448", VA = "0x2208448")]
	private void RefreshRightPanelVfx()
	{
	}

	[Token(Token = "0x6010908")]
	[Address(RVA = "0x22074CC", Offset = "0x22074CC", VA = "0x22074CC")]
	private void RefreshRewardPoolBtnState()
	{
	}

	[Token(Token = "0x6010909")]
	[Address(RVA = "0x2209390", Offset = "0x2209390", VA = "0x2209390")]
	private void RefreshViewAfterBuyItem()
	{
	}

	[Token(Token = "0x601090A")]
	[Address(RVA = "0x2206868", Offset = "0x2206868", VA = "0x2206868")]
	private void RefreshRewardPoolItem(bool needRefreshAnim = false)
	{
	}

	[Token(Token = "0x601090B")]
	[Address(RVA = "0x2206B0C", Offset = "0x2206B0C", VA = "0x2206B0C")]
	private void RefreshWheelItem()
	{
	}

	[Token(Token = "0x601090C")]
	[Address(RVA = "0x22093F0", Offset = "0x22093F0", VA = "0x22093F0")]
	private void OnDrawBtnClick()
	{
	}

	[Token(Token = "0x601090D")]
	[Address(RVA = "0x2209840", Offset = "0x2209840", VA = "0x2209840")]
	private void OnRewardPoolBtnClick()
	{
	}

	[Token(Token = "0x601090E")]
	[Address(RVA = "0x22095D0", Offset = "0x22095D0", VA = "0x22095D0")]
	private void OnRewardPoolPreviewCloseBtnClick()
	{
	}

	[Token(Token = "0x601090F")]
	[Address(RVA = "0x22099C8", Offset = "0x22099C8", VA = "0x22099C8")]
	private void OnPrperbilityClick()
	{
	}

	[Token(Token = "0x6010910")]
	[Address(RVA = "0x2209AD8", Offset = "0x2209AD8", VA = "0x2209AD8")]
	private void OnRefreshRewardPoolBtnClick()
	{
	}

	[Token(Token = "0x6010911")]
	[Address(RVA = "0x2209CC0", Offset = "0x2209CC0", VA = "0x2209CC0")]
	private void RequestRefreshRewardPool()
	{
	}

	[Token(Token = "0x6010912")]
	[Address(RVA = "0x2206D58", Offset = "0x2206D58", VA = "0x2206D58")]
	private void PlayResetWheelAnimation()
	{
	}

	[Token(Token = "0x6010913")]
	[Address(RVA = "0x21FB000", Offset = "0x21FB000", VA = "0x21FB000")]
	public void PlayDrawBntHintAnimaation()
	{
	}

	[Token(Token = "0x6010914")]
	[Address(RVA = "0x2209034", Offset = "0x2209034", VA = "0x2209034")]
	private void ShowResult()
	{
	}

	[Token(Token = "0x6010915")]
	[Address(RVA = "0x220A1A4", Offset = "0x220A1A4", VA = "0x220A1A4")]
	private void PlayShowDiscountVfx()
	{
	}

	[Token(Token = "0x6010916")]
	[Address(RVA = "0x220A01C", Offset = "0x220A01C", VA = "0x220A01C")]
	private void PlayDrawResultAnimation()
	{
	}

	[Token(Token = "0x6010917")]
	[Address(RVA = "0x220A4A8", Offset = "0x220A4A8", VA = "0x220A4A8")]
	private void PlayRefreshRewardPoolVfx()
	{
	}

	[Token(Token = "0x6010918")]
	[Address(RVA = "0x220A630", Offset = "0x220A630", VA = "0x220A630")]
	private void RefreshTime()
	{
	}

	[Token(Token = "0x6010919")]
	[Address(RVA = "0x220AA60", Offset = "0x220AA60", VA = "0x220AA60")]
	public void SetCurrentDiscountLabel(CSLuckyWheelDiscountDesc discount)
	{
	}

	[Token(Token = "0x601091A")]
	[Address(RVA = "0x220ADFC", Offset = "0x220ADFC", VA = "0x220ADFC")]
	private IEnumerator IERefreshRewardPool()
	{
		return null;
	}

	[Token(Token = "0x601091B")]
	[Address(RVA = "0x2205F0C", Offset = "0x2205F0C", VA = "0x2205F0C")]
	private void ResetAnimation()
	{
	}

	[Token(Token = "0x601091C")]
	[Address(RVA = "0x220AEC8", Offset = "0x220AEC8", VA = "0x220AEC8", Slot = "44")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x601091D")]
	[Address(RVA = "0x220AFC0", Offset = "0x220AFC0", VA = "0x220AFC0", Slot = "45")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x601091E")]
	[Address(RVA = "0x220B03C", Offset = "0x220B03C", VA = "0x220B03C", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601091F")]
	[Address(RVA = "0x220B78C", Offset = "0x220B78C", VA = "0x220B78C", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010920")]
	[Address(RVA = "0x220B634", Offset = "0x220B634", VA = "0x220B634")]
	public void Circle(uint id)
	{
	}

	[Token(Token = "0x6010921")]
	[Address(RVA = "0x2205738", Offset = "0x2205738", VA = "0x2205738")]
	private void EnableInterfaceMask(bool v)
	{
	}

	[Token(Token = "0x6010922")]
	[Address(RVA = "0x220C130", Offset = "0x220C130", VA = "0x220C130")]
	private void SetOutstand(int idx, UILuckyWheelItemController.ViewStage stage)
	{
	}

	[Token(Token = "0x6010923")]
	[Address(RVA = "0x2209E74", Offset = "0x2209E74", VA = "0x2209E74")]
	private void ResetGlowItem()
	{
	}

	[Token(Token = "0x6010924")]
	[Address(RVA = "0x220BD44", Offset = "0x220BD44", VA = "0x220BD44")]
	private void DoCircle()
	{
	}

	[Token(Token = "0x6010925")]
	[Address(RVA = "0x220C584", Offset = "0x220C584", VA = "0x220C584")]
	private float RateSample(int curIterationCounter)
	{
		return default(float);
	}

	[Token(Token = "0x6010926")]
	[Address(RVA = "0x220C814", Offset = "0x220C814", VA = "0x220C814")]
	private float RateCelling(float rate)
	{
		return default(float);
	}

	[Token(Token = "0x6010927")]
	[Address(RVA = "0x220C6E8", Offset = "0x220C6E8", VA = "0x220C6E8")]
	private bool IsInFirstCircle(int curIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x6010928")]
	[Address(RVA = "0x220C32C", Offset = "0x220C32C", VA = "0x220C32C")]
	private CircleStage GetCircleStage(int curIterationCounter)
	{
		return default(CircleStage);
	}

	[Token(Token = "0x6010929")]
	[Address(RVA = "0x220C888", Offset = "0x220C888", VA = "0x220C888")]
	private int RandomFindIdx(uint id)
	{
		return default(int);
	}

	[Token(Token = "0x601092A")]
	[Address(RVA = "0x2208DEC", Offset = "0x2208DEC", VA = "0x2208DEC")]
	private void Reset()
	{
	}

	[Token(Token = "0x601092B")]
	[Address(RVA = "0x220B8B4", Offset = "0x220B8B4", VA = "0x220B8B4")]
	private void GenRewardIndexList(uint id)
	{
	}

	[Token(Token = "0x601092C")]
	[Address(RVA = "0x220BBA0", Offset = "0x220BBA0", VA = "0x220BBA0")]
	private void BuildFirstLapRateCurve()
	{
	}

	[Token(Token = "0x601092D")]
	[Address(RVA = "0x220CBA8", Offset = "0x220CBA8", VA = "0x220CBA8")]
	private void _003CSetCDNTitle_003Em__0()
	{
	}

	[Token(Token = "0x601092E")]
	[Address(RVA = "0x220CBEC", Offset = "0x220CBEC", VA = "0x220CBEC")]
	private void _003COnDrawBtnClick_003Em__1()
	{
	}

	[Token(Token = "0x601092F")]
	[Address(RVA = "0x220CBF0", Offset = "0x220CBF0", VA = "0x220CBF0")]
	private void _003CRequestRefreshRewardPool_003Em__2()
	{
	}

	[Token(Token = "0x6010930")]
	[Address(RVA = "0x220CC3C", Offset = "0x220CC3C", VA = "0x220CC3C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010931")]
	[Address(RVA = "0x220CC44", Offset = "0x220CC44", VA = "0x220CC44")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6010932")]
	[Address(RVA = "0x220CC4C", Offset = "0x220CC4C", VA = "0x220CC4C")]
	public bool _003C_003EiFixBaseProxy_NeedWaitDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6010933")]
	[Address(RVA = "0x220CC54", Offset = "0x220CC54", VA = "0x220CC54")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x6010934")]
	[Address(RVA = "0x220CC5C", Offset = "0x220CC5C", VA = "0x220CC5C")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
