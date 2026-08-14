using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002669")]
public class UIGachaNormalContent : UIGachaContentBase
{
	[Token(Token = "0x200266A")]
	private sealed class _003CRefreshenergyPointCount_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400ED34")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CcurrentTime_003E__0;

		[Token(Token = "0x400ED35")]
		[FieldOffset(Offset = "0xC")]
		internal uint pt;

		[Token(Token = "0x400ED36")]
		[FieldOffset(Offset = "0x10")]
		internal uint oldPt;

		[Token(Token = "0x400ED37")]
		[FieldOffset(Offset = "0x14")]
		internal int _003CshowPoint_003E__1;

		[Token(Token = "0x400ED38")]
		[FieldOffset(Offset = "0x18")]
		internal UIGachaNormalContent _0024this;

		[Token(Token = "0x400ED39")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x400ED3A")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x400ED3B")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x17001183")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600E600")]
			[Address(RVA = "0x2A1F690", Offset = "0x2A1F690", VA = "0x2A1F690", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001184")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600E601")]
			[Address(RVA = "0x2A1F698", Offset = "0x2A1F698", VA = "0x2A1F698", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600E5FE")]
		[Address(RVA = "0x2A1DCFC", Offset = "0x2A1DCFC", VA = "0x2A1DCFC")]
		public _003CRefreshenergyPointCount_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600E5FF")]
		[Address(RVA = "0x2A1F3A0", Offset = "0x2A1F3A0", VA = "0x2A1F3A0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600E602")]
		[Address(RVA = "0x2A1F6A0", Offset = "0x2A1F6A0", VA = "0x2A1F6A0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600E603")]
		[Address(RVA = "0x2A1F6B4", Offset = "0x2A1F6B4", VA = "0x2A1F6B4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200266B")]
	private sealed class _003CIEDestroyAnimation_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400ED3C")]
		[FieldOffset(Offset = "0x8")]
		internal UIGachaNormalContent _0024this;

		[Token(Token = "0x400ED3D")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400ED3E")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400ED3F")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001185")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600E606")]
			[Address(RVA = "0x2A1F2F4", Offset = "0x2A1F2F4", VA = "0x2A1F2F4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001186")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600E607")]
			[Address(RVA = "0x2A1F2FC", Offset = "0x2A1F2FC", VA = "0x2A1F2FC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600E604")]
		[Address(RVA = "0x2A1EFC4", Offset = "0x2A1EFC4", VA = "0x2A1EFC4")]
		public _003CIEDestroyAnimation_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600E605")]
		[Address(RVA = "0x2A1F268", Offset = "0x2A1F268", VA = "0x2A1F268", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600E608")]
		[Address(RVA = "0x2A1F304", Offset = "0x2A1F304", VA = "0x2A1F304", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600E609")]
		[Address(RVA = "0x2A1F318", Offset = "0x2A1F318", VA = "0x2A1F318", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400ED2B")]
	[FieldOffset(Offset = "0x44")]
	private UIGachaNormalContentView m_View;

	[Token(Token = "0x400ED2C")]
	[FieldOffset(Offset = "0x48")]
	private List<UIGachaExtraListItemController> m_ExtraList;

	[Token(Token = "0x400ED2D")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIGachaADItemController> m_AdList;

	[Token(Token = "0x400ED2E")]
	[FieldOffset(Offset = "0x50")]
	private Color unShowColor;

	[Token(Token = "0x400ED2F")]
	[FieldOffset(Offset = "0x60")]
	private UISprite[] spriteStars;

	[Token(Token = "0x400ED30")]
	[FieldOffset(Offset = "0x64")]
	private bool isOpenRewardPool;

	[Token(Token = "0x400ED31")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_DrawAnimation;

	[Token(Token = "0x400ED32")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400ED33")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600E5C7")]
	[Address(RVA = "0x2A197EC", Offset = "0x2A197EC", VA = "0x2A197EC")]
	public UIGachaNormalContent()
	{
	}

	[Token(Token = "0x600E5C8")]
	[Address(RVA = "0x2A19900", Offset = "0x2A19900", VA = "0x2A19900")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E5C9")]
	[Address(RVA = "0x2A199A4", Offset = "0x2A199A4", VA = "0x2A199A4", Slot = "62")]
	public override string GetTutorialWndTitleKey()
	{
		return null;
	}

	[Token(Token = "0x600E5CA")]
	[Address(RVA = "0x2A19A48", Offset = "0x2A19A48", VA = "0x2A19A48", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E5CB")]
	[Address(RVA = "0x2A1A470", Offset = "0x2A1A470", VA = "0x2A1A470", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E5CC")]
	[Address(RVA = "0x2A1A4D4", Offset = "0x2A1A4D4", VA = "0x2A1A4D4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E5CD")]
	[Address(RVA = "0x2A1A9A0", Offset = "0x2A1A9A0", VA = "0x2A1A9A0", Slot = "33")]
	protected override void InitGachaContentBuyBtn()
	{
	}

	[Token(Token = "0x600E5CE")]
	[Address(RVA = "0x2A1AACC", Offset = "0x2A1AACC", VA = "0x2A1AACC", Slot = "60")]
	protected override void OnCloseRewardPanel()
	{
	}

	[Token(Token = "0x600E5CF")]
	[Address(RVA = "0x2A1B110", Offset = "0x2A1B110", VA = "0x2A1B110", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x600E5D0")]
	[Address(RVA = "0x2A1B174", Offset = "0x2A1B174", VA = "0x2A1B174", Slot = "34")]
	protected override void OnRefreshUIView()
	{
	}

	[Token(Token = "0x600E5D1")]
	[Address(RVA = "0x2A1C22C", Offset = "0x2A1C22C", VA = "0x2A1C22C", Slot = "54")]
	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	[Token(Token = "0x600E5D2")]
	[Address(RVA = "0x2A1C2A4", Offset = "0x2A1C2A4", VA = "0x2A1C2A4", Slot = "42")]
	public override void OnSkipAnim()
	{
	}

	[Token(Token = "0x600E5D3")]
	[Address(RVA = "0x2A1C6D8", Offset = "0x2A1C6D8", VA = "0x2A1C6D8", Slot = "41")]
	public override void OnPurchaseResult(bool isSuccess)
	{
	}

	[Token(Token = "0x600E5D4")]
	[Address(RVA = "0x2A1C960", Offset = "0x2A1C960", VA = "0x2A1C960", Slot = "45")]
	public override void OnRewardPoolClose()
	{
	}

	[Token(Token = "0x600E5D5")]
	[Address(RVA = "0x2A1A3D8", Offset = "0x2A1A3D8", VA = "0x2A1A3D8")]
	private void SetextraAwardActive(bool enable)
	{
	}

	[Token(Token = "0x600E5D6")]
	[Address(RVA = "0x2A1CB1C", Offset = "0x2A1CB1C", VA = "0x2A1CB1C", Slot = "46")]
	public override void OnRewardPoolOpen()
	{
	}

	[Token(Token = "0x600E5D7")]
	[Address(RVA = "0x2A1CC04", Offset = "0x2A1CC04", VA = "0x2A1CC04")]
	private void OnClickLotteryMachineEvt(object[] data)
	{
	}

	[Token(Token = "0x600E5D8")]
	[Address(RVA = "0x2A1CC88", Offset = "0x2A1CC88", VA = "0x2A1CC88")]
	public void OnClickLotteryMachine()
	{
	}

	[Token(Token = "0x600E5D9")]
	[Address(RVA = "0x2A1CEF0", Offset = "0x2A1CEF0", VA = "0x2A1CEF0")]
	private void ShowExchangeResultWnd(object[] data)
	{
	}

	[Token(Token = "0x600E5DA")]
	[Address(RVA = "0x2A1D330", Offset = "0x2A1D330", VA = "0x2A1D330")]
	private void OnDrawResultShowed(object[] data)
	{
	}

	[Token(Token = "0x600E5DB")]
	[Address(RVA = "0x2A1D448", Offset = "0x2A1D448", VA = "0x2A1D448")]
	private void CheckLuckyPointReset()
	{
	}

	[Token(Token = "0x600E5DC")]
	[Address(RVA = "0x2A1D6D0", Offset = "0x2A1D6D0", VA = "0x2A1D6D0")]
	private void OnWeaponCgUIShow(object[] data)
	{
	}

	[Token(Token = "0x600E5DD")]
	[Address(RVA = "0x2A1D748", Offset = "0x2A1D748", VA = "0x2A1D748")]
	private void OnWeaponCgUIHide(object[] data)
	{
	}

	[Token(Token = "0x600E5DE")]
	[Address(RVA = "0x2A1D7B4", Offset = "0x2A1D7B4", VA = "0x2A1D7B4")]
	private void OnEnergyPointClick()
	{
	}

	[Token(Token = "0x600E5DF")]
	[Address(RVA = "0x2A1A128", Offset = "0x2A1A128", VA = "0x2A1A128")]
	private void InitExtraAwardList()
	{
	}

	[Token(Token = "0x600E5E0")]
	[Address(RVA = "0x2A1BD68", Offset = "0x2A1BD68", VA = "0x2A1BD68")]
	public void RefreshExtraRewardList(uint chestID)
	{
	}

	[Token(Token = "0x600E5E1")]
	[Address(RVA = "0x2A1AB30", Offset = "0x2A1AB30", VA = "0x2A1AB30")]
	private void RefreshEnergyPoint(bool needAnim = false)
	{
	}

	[Token(Token = "0x600E5E2")]
	[Address(RVA = "0x2A1DBE4", Offset = "0x2A1DBE4", VA = "0x2A1DBE4")]
	private IEnumerator RefreshenergyPointCount(uint oldPt, uint pt)
	{
		return null;
	}

	[Token(Token = "0x600E5E3")]
	[Address(RVA = "0x2A1DA10", Offset = "0x2A1DA10", VA = "0x2A1DA10")]
	public void RereshStarState(int level)
	{
	}

	[Token(Token = "0x600E5E4")]
	[Address(RVA = "0x2A1DD04", Offset = "0x2A1DD04", VA = "0x2A1DD04")]
	private void ShowExtraPreviewWnd(object[] data)
	{
	}

	[Token(Token = "0x600E5E5")]
	[Address(RVA = "0x2A1B1FC", Offset = "0x2A1B1FC", VA = "0x2A1B1FC")]
	private void RefreshCountDownLabel()
	{
	}

	[Token(Token = "0x600E5E6")]
	[Address(RVA = "0x2A1B644", Offset = "0x2A1B644", VA = "0x2A1B644")]
	private void RefreshCDNContentMask()
	{
	}

	[Token(Token = "0x600E5E7")]
	[Address(RVA = "0x2A1B888", Offset = "0x2A1B888", VA = "0x2A1B888")]
	public void RefreshCDNView()
	{
	}

	[Token(Token = "0x600E5E8")]
	[Address(RVA = "0x2A1C8F8", Offset = "0x2A1C8F8", VA = "0x2A1C8F8")]
	private void PlayResultAnim(GachaResultInfo info)
	{
	}

	[Token(Token = "0x600E5E9")]
	[Address(RVA = "0x2A1E2E4", Offset = "0x2A1E2E4", VA = "0x2A1E2E4")]
	private void ProcessAnimEvt(object[] data)
	{
	}

	[Token(Token = "0x600E5EA")]
	[Address(RVA = "0x2A1C41C", Offset = "0x2A1C41C", VA = "0x2A1C41C")]
	public void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	[Token(Token = "0x600E5EB")]
	[Address(RVA = "0x2A1DF58", Offset = "0x2A1DF58", VA = "0x2A1DF58")]
	private void BeginPlayDrawAnim()
	{
	}

	[Token(Token = "0x600E5EC")]
	[Address(RVA = "0x2A1E9E0", Offset = "0x2A1E9E0", VA = "0x2A1E9E0")]
	private void PlayDropBoxAnim()
	{
	}

	[Token(Token = "0x600E5ED")]
	[Address(RVA = "0x2A1E65C", Offset = "0x2A1E65C", VA = "0x2A1E65C")]
	private void EndPlayDrawAnim()
	{
	}

	[Token(Token = "0x600E5EE")]
	[Address(RVA = "0x2A1E428", Offset = "0x2A1E428", VA = "0x2A1E428")]
	private void TryStopAnimation(string evt)
	{
	}

	[Token(Token = "0x600E5EF")]
	[Address(RVA = "0x2A1A880", Offset = "0x2A1A880", VA = "0x2A1A880")]
	public void ClearCache()
	{
	}

	[Token(Token = "0x600E5F0")]
	[Address(RVA = "0x2A1EEF8", Offset = "0x2A1EEF8", VA = "0x2A1EEF8")]
	private IEnumerator IEDestroyAnimation()
	{
		return null;
	}

	[Token(Token = "0x600E5F1")]
	[Address(RVA = "0x2A1EFCC", Offset = "0x2A1EFCC", VA = "0x2A1EFCC")]
	private static CommonRewardItemInfo _003CShowExchangeResultWnd_003Em__0(ExchangedAward item)
	{
		return null;
	}

	[Token(Token = "0x600E5F2")]
	[Address(RVA = "0x2A1EFD4", Offset = "0x2A1EFD4", VA = "0x2A1EFD4")]
	private static void _003CShowExchangeResultWnd_003Em__1()
	{
	}

	[Token(Token = "0x600E5F3")]
	[Address(RVA = "0x2A1F094", Offset = "0x2A1F094", VA = "0x2A1F094")]
	private void _003CRefreshCountDownLabel_003Em__2()
	{
	}

	[Token(Token = "0x600E5F4")]
	[Address(RVA = "0x2A1F218", Offset = "0x2A1F218", VA = "0x2A1F218")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E5F5")]
	[Address(RVA = "0x2A1F220", Offset = "0x2A1F220", VA = "0x2A1F220")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E5F6")]
	[Address(RVA = "0x2A1F228", Offset = "0x2A1F228", VA = "0x2A1F228")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E5F7")]
	[Address(RVA = "0x2A1F230", Offset = "0x2A1F230", VA = "0x2A1F230")]
	public void _003C_003EiFixBaseProxy_OnCloseRewardPanel()
	{
	}

	[Token(Token = "0x600E5F8")]
	[Address(RVA = "0x2A1F238", Offset = "0x2A1F238", VA = "0x2A1F238")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	[Token(Token = "0x600E5F9")]
	[Address(RVA = "0x2A1F240", Offset = "0x2A1F240", VA = "0x2A1F240")]
	public UIWidget _003C_003EiFixBaseProxy_GetPreviewSceneBorder(uint P0)
	{
		return null;
	}

	[Token(Token = "0x600E5FA")]
	[Address(RVA = "0x2A1F248", Offset = "0x2A1F248", VA = "0x2A1F248")]
	public void _003C_003EiFixBaseProxy_OnSkipAnim()
	{
	}

	[Token(Token = "0x600E5FB")]
	[Address(RVA = "0x2A1F250", Offset = "0x2A1F250", VA = "0x2A1F250")]
	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0)
	{
	}

	[Token(Token = "0x600E5FC")]
	[Address(RVA = "0x2A1F258", Offset = "0x2A1F258", VA = "0x2A1F258")]
	public void _003C_003EiFixBaseProxy_OnRewardPoolClose()
	{
	}

	[Token(Token = "0x600E5FD")]
	[Address(RVA = "0x2A1F260", Offset = "0x2A1F260", VA = "0x2A1F260")]
	public void _003C_003EiFixBaseProxy_OnRewardPoolOpen()
	{
	}
}
