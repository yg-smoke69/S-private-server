using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002678")]
public class UIGachaTokenContent : UIGachaContentBase
{
	[Token(Token = "0x2002679")]
	private sealed class _003CRefreshenergyPointCount_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400ED83")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CcurrentTime_003E__0;

		[Token(Token = "0x400ED84")]
		[FieldOffset(Offset = "0xC")]
		internal uint pt;

		[Token(Token = "0x400ED85")]
		[FieldOffset(Offset = "0x10")]
		internal uint oldPt;

		[Token(Token = "0x400ED86")]
		[FieldOffset(Offset = "0x14")]
		internal int _003CshowPoint_003E__1;

		[Token(Token = "0x400ED87")]
		[FieldOffset(Offset = "0x18")]
		internal UIGachaTokenContent _0024this;

		[Token(Token = "0x400ED88")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x400ED89")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x400ED8A")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x1700118A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600E6CD")]
			[Address(RVA = "0x2E8E7AC", Offset = "0x2E8E7AC", VA = "0x2E8E7AC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700118B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600E6CE")]
			[Address(RVA = "0x2E8E7B4", Offset = "0x2E8E7B4", VA = "0x2E8E7B4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600E6CB")]
		[Address(RVA = "0x2E8E4B4", Offset = "0x2E8E4B4", VA = "0x2E8E4B4")]
		public _003CRefreshenergyPointCount_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600E6CC")]
		[Address(RVA = "0x2E8E4BC", Offset = "0x2E8E4BC", VA = "0x2E8E4BC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600E6CF")]
		[Address(RVA = "0x2E8E7BC", Offset = "0x2E8E7BC", VA = "0x2E8E7BC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600E6D0")]
		[Address(RVA = "0x2E8E7D0", Offset = "0x2E8E7D0", VA = "0x2E8E7D0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200267A")]
	private sealed class _003CIEDestroyAnimation_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400ED8B")]
		[FieldOffset(Offset = "0x8")]
		internal UIGachaTokenContent _0024this;

		[Token(Token = "0x400ED8C")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400ED8D")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400ED8E")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x1700118C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600E6D3")]
			[Address(RVA = "0x2E8E408", Offset = "0x2E8E408", VA = "0x2E8E408", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700118D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600E6D4")]
			[Address(RVA = "0x2E8E410", Offset = "0x2E8E410", VA = "0x2E8E410", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600E6D1")]
		[Address(RVA = "0x2E8E36C", Offset = "0x2E8E36C", VA = "0x2E8E36C")]
		public _003CIEDestroyAnimation_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600E6D2")]
		[Address(RVA = "0x2E8E374", Offset = "0x2E8E374", VA = "0x2E8E374", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600E6D5")]
		[Address(RVA = "0x2E8E418", Offset = "0x2E8E418", VA = "0x2E8E418", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600E6D6")]
		[Address(RVA = "0x2E8E42C", Offset = "0x2E8E42C", VA = "0x2E8E42C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400ED79")]
	[FieldOffset(Offset = "0x44")]
	private UIGachaTokenContentView m_View;

	[Token(Token = "0x400ED7A")]
	[FieldOffset(Offset = "0x48")]
	private List<UIGachaExtraListItemController> m_ExtraList;

	[Token(Token = "0x400ED7B")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIGachaADItemController> m_AdList;

	[Token(Token = "0x400ED7C")]
	[FieldOffset(Offset = "0x50")]
	private UITopButtonGroupController m_TopButtonGroupController;

	[Token(Token = "0x400ED7D")]
	[FieldOffset(Offset = "0x54")]
	private Color unShowColor;

	[Token(Token = "0x400ED7E")]
	[FieldOffset(Offset = "0x64")]
	private UISprite[] spriteStars;

	[Token(Token = "0x400ED7F")]
	[FieldOffset(Offset = "0x68")]
	private bool isOpenRewardPool;

	[Token(Token = "0x400ED80")]
	[FieldOffset(Offset = "0x6C")]
	private GameObject m_DrawAnimation;

	[Token(Token = "0x400ED81")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400ED82")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600E68E")]
	[Address(RVA = "0x2A2FE9C", Offset = "0x2A2FE9C", VA = "0x2A2FE9C")]
	public UIGachaTokenContent()
	{
	}

	[Token(Token = "0x600E68F")]
	[Address(RVA = "0x2A2FFB0", Offset = "0x2A2FFB0", VA = "0x2A2FFB0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E690")]
	[Address(RVA = "0x2A30054", Offset = "0x2A30054", VA = "0x2A30054", Slot = "62")]
	public override string GetTutorialWndTitleKey()
	{
		return null;
	}

	[Token(Token = "0x600E691")]
	[Address(RVA = "0x2A300F8", Offset = "0x2A300F8", VA = "0x2A300F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E692")]
	[Address(RVA = "0x2A30B20", Offset = "0x2A30B20", VA = "0x2A30B20", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E693")]
	[Address(RVA = "0x2A30B84", Offset = "0x2A30B84", VA = "0x2A30B84", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E694")]
	[Address(RVA = "0x2A31050", Offset = "0x2A31050", VA = "0x2A31050", Slot = "33")]
	protected override void InitGachaContentBuyBtn()
	{
	}

	[Token(Token = "0x600E695")]
	[Address(RVA = "0x2A3117C", Offset = "0x2A3117C", VA = "0x2A3117C", Slot = "60")]
	protected override void OnCloseRewardPanel()
	{
	}

	[Token(Token = "0x600E696")]
	[Address(RVA = "0x2A31E70", Offset = "0x2A31E70", VA = "0x2A31E70", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x600E697")]
	[Address(RVA = "0x2A31ED4", Offset = "0x2A31ED4", VA = "0x2A31ED4", Slot = "34")]
	protected override void OnRefreshUIView()
	{
	}

	[Token(Token = "0x600E698")]
	[Address(RVA = "0x2A32F94", Offset = "0x2A32F94", VA = "0x2A32F94", Slot = "38")]
	public override void OnHideContent()
	{
	}

	[Token(Token = "0x600E699")]
	[Address(RVA = "0x2A33154", Offset = "0x2A33154", VA = "0x2A33154", Slot = "54")]
	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	[Token(Token = "0x600E69A")]
	[Address(RVA = "0x2A331CC", Offset = "0x2A331CC", VA = "0x2A331CC", Slot = "42")]
	public override void OnSkipAnim()
	{
	}

	[Token(Token = "0x600E69B")]
	[Address(RVA = "0x2A33600", Offset = "0x2A33600", VA = "0x2A33600")]
	private void OnClickLotteryMachineEvt(object[] data)
	{
	}

	[Token(Token = "0x600E69C")]
	[Address(RVA = "0x2A338EC", Offset = "0x2A338EC", VA = "0x2A338EC", Slot = "41")]
	public override void OnPurchaseResult(bool isSuccess)
	{
	}

	[Token(Token = "0x600E69D")]
	[Address(RVA = "0x2A33B74", Offset = "0x2A33B74", VA = "0x2A33B74", Slot = "45")]
	public override void OnRewardPoolClose()
	{
	}

	[Token(Token = "0x600E69E")]
	[Address(RVA = "0x2A33DA0", Offset = "0x2A33DA0", VA = "0x2A33DA0")]
	public void SetUITokenSprite(UITopButtonGroupController uITopButtonGroupController)
	{
	}

	[Token(Token = "0x600E69F")]
	[Address(RVA = "0x2A30A88", Offset = "0x2A30A88", VA = "0x2A30A88")]
	private void SetextraAwardActive(bool enable)
	{
	}

	[Token(Token = "0x600E6A0")]
	[Address(RVA = "0x2A33E00", Offset = "0x2A33E00", VA = "0x2A33E00", Slot = "46")]
	public override void OnRewardPoolOpen()
	{
	}

	[Token(Token = "0x600E6A1")]
	[Address(RVA = "0x2A33684", Offset = "0x2A33684", VA = "0x2A33684")]
	public void OnClickLotteryMachine()
	{
	}

	[Token(Token = "0x600E6A2")]
	[Address(RVA = "0x2A33F58", Offset = "0x2A33F58", VA = "0x2A33F58")]
	private void ShowExchangeResultWnd(object[] data)
	{
	}

	[Token(Token = "0x600E6A3")]
	[Address(RVA = "0x2A34398", Offset = "0x2A34398", VA = "0x2A34398")]
	private void OnDrawResultShowed(object[] data)
	{
	}

	[Token(Token = "0x600E6A4")]
	[Address(RVA = "0x2A344B0", Offset = "0x2A344B0", VA = "0x2A344B0")]
	private void CheckLuckyPointReset()
	{
	}

	[Token(Token = "0x600E6A5")]
	[Address(RVA = "0x2A34738", Offset = "0x2A34738", VA = "0x2A34738")]
	private void OnWeaponCgUIShow(object[] data)
	{
	}

	[Token(Token = "0x600E6A6")]
	[Address(RVA = "0x2A347B0", Offset = "0x2A347B0", VA = "0x2A347B0")]
	private void OnWeaponCgUIHide(object[] data)
	{
	}

	[Token(Token = "0x600E6A7")]
	[Address(RVA = "0x2A3481C", Offset = "0x2A3481C", VA = "0x2A3481C")]
	private void OnEnergyPointClick()
	{
	}

	[Token(Token = "0x600E6A8")]
	[Address(RVA = "0x2A307D8", Offset = "0x2A307D8", VA = "0x2A307D8")]
	private void InitExtraAwardList()
	{
	}

	[Token(Token = "0x600E6A9")]
	[Address(RVA = "0x2A32AD0", Offset = "0x2A32AD0", VA = "0x2A32AD0")]
	public void RefreshExtraRewardList(uint chestID)
	{
	}

	[Token(Token = "0x600E6AA")]
	[Address(RVA = "0x2A311E8", Offset = "0x2A311E8", VA = "0x2A311E8")]
	private void RefreshEnergyPoint(bool needAnim = false)
	{
	}

	[Token(Token = "0x600E6AB")]
	[Address(RVA = "0x2A34C4C", Offset = "0x2A34C4C", VA = "0x2A34C4C")]
	private IEnumerator RefreshenergyPointCount(uint oldPt, uint pt)
	{
		return null;
	}

	[Token(Token = "0x600E6AC")]
	[Address(RVA = "0x2A34A78", Offset = "0x2A34A78", VA = "0x2A34A78")]
	public void RereshStarState(int level)
	{
	}

	[Token(Token = "0x600E6AD")]
	[Address(RVA = "0x2A34D64", Offset = "0x2A34D64", VA = "0x2A34D64")]
	private void ShowExtraPreviewWnd(object[] data)
	{
	}

	[Token(Token = "0x600E6AE")]
	[Address(RVA = "0x2A31F64", Offset = "0x2A31F64", VA = "0x2A31F64")]
	private void RefreshCountDownLabel()
	{
	}

	[Token(Token = "0x600E6AF")]
	[Address(RVA = "0x2A323AC", Offset = "0x2A323AC", VA = "0x2A323AC")]
	private void RefreshCDNContentMask()
	{
	}

	[Token(Token = "0x600E6B0")]
	[Address(RVA = "0x2A34FB8", Offset = "0x2A34FB8", VA = "0x2A34FB8", Slot = "37")]
	public override uint GetCurrentExchangeItemID()
	{
		return default(uint);
	}

	[Token(Token = "0x600E6B1")]
	[Address(RVA = "0x2A31784", Offset = "0x2A31784", VA = "0x2A31784")]
	public void RefreshTokenView()
	{
	}

	[Token(Token = "0x600E6B2")]
	[Address(RVA = "0x2A325F0", Offset = "0x2A325F0", VA = "0x2A325F0")]
	public void RefreshCDNView()
	{
	}

	[Token(Token = "0x600E6B3")]
	[Address(RVA = "0x2A33B0C", Offset = "0x2A33B0C", VA = "0x2A33B0C")]
	private void PlayResultAnim(GachaResultInfo info)
	{
	}

	[Token(Token = "0x600E6B4")]
	[Address(RVA = "0x2A35624", Offset = "0x2A35624", VA = "0x2A35624")]
	private void ProcessAnimEvt(object[] data)
	{
	}

	[Token(Token = "0x600E6B5")]
	[Address(RVA = "0x2A33344", Offset = "0x2A33344", VA = "0x2A33344")]
	public void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	[Token(Token = "0x600E6B6")]
	[Address(RVA = "0x2A35298", Offset = "0x2A35298", VA = "0x2A35298")]
	private void BeginPlayDrawAnim()
	{
	}

	[Token(Token = "0x600E6B7")]
	[Address(RVA = "0x2A35D20", Offset = "0x2A35D20", VA = "0x2A35D20")]
	private void PlayDropBoxAnim()
	{
	}

	[Token(Token = "0x600E6B8")]
	[Address(RVA = "0x2A3599C", Offset = "0x2A3599C", VA = "0x2A3599C")]
	private void EndPlayDrawAnim()
	{
	}

	[Token(Token = "0x600E6B9")]
	[Address(RVA = "0x2A35768", Offset = "0x2A35768", VA = "0x2A35768")]
	private void TryStopAnimation(string evt)
	{
	}

	[Token(Token = "0x600E6BA")]
	[Address(RVA = "0x2A30F30", Offset = "0x2A30F30", VA = "0x2A30F30")]
	public void ClearCache()
	{
	}

	[Token(Token = "0x600E6BB")]
	[Address(RVA = "0x2A36238", Offset = "0x2A36238", VA = "0x2A36238")]
	private IEnumerator IEDestroyAnimation()
	{
		return null;
	}

	[Token(Token = "0x600E6BC")]
	[Address(RVA = "0x2A36304", Offset = "0x2A36304", VA = "0x2A36304")]
	private static CommonRewardItemInfo _003CShowExchangeResultWnd_003Em__0(ExchangedAward item)
	{
		return null;
	}

	[Token(Token = "0x600E6BD")]
	[Address(RVA = "0x2A3630C", Offset = "0x2A3630C", VA = "0x2A3630C")]
	private static void _003CShowExchangeResultWnd_003Em__1()
	{
	}

	[Token(Token = "0x600E6BE")]
	[Address(RVA = "0x2A363CC", Offset = "0x2A363CC", VA = "0x2A363CC")]
	private void _003CRefreshCountDownLabel_003Em__2()
	{
	}

	[Token(Token = "0x600E6BF")]
	[Address(RVA = "0x2A36550", Offset = "0x2A36550", VA = "0x2A36550")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E6C0")]
	[Address(RVA = "0x2A36558", Offset = "0x2A36558", VA = "0x2A36558")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E6C1")]
	[Address(RVA = "0x2A36560", Offset = "0x2A36560", VA = "0x2A36560")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E6C2")]
	[Address(RVA = "0x2A36568", Offset = "0x2A36568", VA = "0x2A36568")]
	public void _003C_003EiFixBaseProxy_OnCloseRewardPanel()
	{
	}

	[Token(Token = "0x600E6C3")]
	[Address(RVA = "0x2A36570", Offset = "0x2A36570", VA = "0x2A36570")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	[Token(Token = "0x600E6C4")]
	[Address(RVA = "0x2A36578", Offset = "0x2A36578", VA = "0x2A36578")]
	public void _003C_003EiFixBaseProxy_OnHideContent()
	{
	}

	[Token(Token = "0x600E6C5")]
	[Address(RVA = "0x2A36580", Offset = "0x2A36580", VA = "0x2A36580")]
	public UIWidget _003C_003EiFixBaseProxy_GetPreviewSceneBorder(uint P0)
	{
		return null;
	}

	[Token(Token = "0x600E6C6")]
	[Address(RVA = "0x2A36588", Offset = "0x2A36588", VA = "0x2A36588")]
	public void _003C_003EiFixBaseProxy_OnSkipAnim()
	{
	}

	[Token(Token = "0x600E6C7")]
	[Address(RVA = "0x2A36590", Offset = "0x2A36590", VA = "0x2A36590")]
	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0)
	{
	}

	[Token(Token = "0x600E6C8")]
	[Address(RVA = "0x2A36598", Offset = "0x2A36598", VA = "0x2A36598")]
	public void _003C_003EiFixBaseProxy_OnRewardPoolClose()
	{
	}

	[Token(Token = "0x600E6C9")]
	[Address(RVA = "0x2A365A0", Offset = "0x2A365A0", VA = "0x2A365A0")]
	public void _003C_003EiFixBaseProxy_OnRewardPoolOpen()
	{
	}

	[Token(Token = "0x600E6CA")]
	[Address(RVA = "0x2A365A8", Offset = "0x2A365A8", VA = "0x2A365A8")]
	public uint _003C_003EiFixBaseProxy_GetCurrentExchangeItemID()
	{
		return default(uint);
	}
}
