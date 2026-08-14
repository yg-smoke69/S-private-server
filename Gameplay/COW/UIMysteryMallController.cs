using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021F7")]
internal class UIMysteryMallController : UINavigationController, _Attribute
{
	[Token(Token = "0x20021F8")]
	private sealed class _003COnNavigationShowed_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D4B6")]
		[FieldOffset(Offset = "0x8")]
		internal uint shopId;

		[Token(Token = "0x600B72B")]
		[Address(RVA = "0x1B23DCC", Offset = "0x1B23DCC", VA = "0x1B23DCC")]
		public _003COnNavigationShowed_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B72C")]
		[Address(RVA = "0x1B23DD4", Offset = "0x1B23DD4", VA = "0x1B23DD4")]
		internal bool _003C_003Em__0(StandardTopTabItemViewData value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20021F9")]
	private sealed class _003CRefreshView_003Ec__AnonStorey1
	{
		[Token(Token = "0x400D4B7")]
		[FieldOffset(Offset = "0x8")]
		internal MysteryShopExpressionDesc mallDesc;

		[Token(Token = "0x400D4B8")]
		[FieldOffset(Offset = "0xC")]
		internal UIMysteryMallController _0024this;

		[Token(Token = "0x600B72D")]
		[Address(RVA = "0x1B23E60", Offset = "0x1B23E60", VA = "0x1B23E60")]
		public _003CRefreshView_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600B72E")]
		[Address(RVA = "0x1B23E68", Offset = "0x1B23E68", VA = "0x1B23E68")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20021FA")]
	private sealed class _003COnBtnSwitchPoolClick_003Ec__AnonStorey2
	{
		[Token(Token = "0x400D4B9")]
		[FieldOffset(Offset = "0x8")]
		internal UISecondConfirmSmallContoller confirmWnd;

		[Token(Token = "0x400D4BA")]
		[FieldOffset(Offset = "0xC")]
		internal UIMysteryMallController _0024this;

		[Token(Token = "0x600B72F")]
		[Address(RVA = "0x1B23D38", Offset = "0x1B23D38", VA = "0x1B23D38")]
		public _003COnBtnSwitchPoolClick_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600B730")]
		[Address(RVA = "0x1B23D40", Offset = "0x1B23D40", VA = "0x1B23D40")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400D4A8")]
	[FieldOffset(Offset = "0x68")]
	private UIMysteryMallView m_View;

	[Token(Token = "0x400D4A9")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelMysteryMall m_ModelMall;

	[Token(Token = "0x400D4AA")]
	[FieldOffset(Offset = "0x70")]
	private UIMysteryMallItemController m_ItemSuperCtrl;

	[Token(Token = "0x400D4AB")]
	[FieldOffset(Offset = "0x74")]
	private UIStandardTopTabController m_TabCtrl;

	[Token(Token = "0x400D4AC")]
	[FieldOffset(Offset = "0x78")]
	private List<StandardTopTabItemViewData> m_TabDataList;

	[Token(Token = "0x400D4AD")]
	[FieldOffset(Offset = "0x7C")]
	private List<UIMysteryMallItemController> m_ItemNormalCtrlList;

	[Token(Token = "0x400D4AE")]
	[FieldOffset(Offset = "0x80")]
	private UICountDownController m_CountDownCtrl;

	[Token(Token = "0x400D4AF")]
	private const int MAX_NORMAL_ITEM_NUM = 13;

	[Token(Token = "0x400D4B0")]
	[FieldOffset(Offset = "0x84")]
	private uint m_CurPoolId;

	[Token(Token = "0x400D4B1")]
	[FieldOffset(Offset = "0x88")]
	private int m_LastSelectedIndex;

	[Token(Token = "0x400D4B2")]
	[FieldOffset(Offset = "0x8C")]
	private bool m_IsCancelLuckyDraw;

	[Token(Token = "0x400D4B3")]
	[FieldOffset(Offset = "0x0")]
	public static EThemeType CurTheme;

	[Token(Token = "0x400D4B4")]
	[FieldOffset(Offset = "0x90")]
	private UIMysteryMallThemeView[] m_MallThemeArray;

	[Token(Token = "0x400D4B5")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<UIMysteryMallThemeView> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600B713")]
	[Address(RVA = "0x1956418", Offset = "0x1956418", VA = "0x1956418")]
	public UIMysteryMallController()
	{
	}

	[Token(Token = "0x600B714")]
	[Address(RVA = "0x195650C", Offset = "0x195650C", VA = "0x195650C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B715")]
	[Address(RVA = "0x19565B4", Offset = "0x19565B4", VA = "0x19565B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B716")]
	[Address(RVA = "0x19576AC", Offset = "0x19576AC", VA = "0x19576AC", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600B717")]
	[Address(RVA = "0x1957BA4", Offset = "0x1957BA4", VA = "0x1957BA4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B718")]
	[Address(RVA = "0x1957CF8", Offset = "0x1957CF8", VA = "0x1957CF8")]
	private void OnTabSelected(int index)
	{
	}

	[Token(Token = "0x600B719")]
	[Address(RVA = "0x1956DA0", Offset = "0x1956DA0", VA = "0x1956DA0")]
	private void InitMysteryMallTab()
	{
	}

	[Token(Token = "0x600B71A")]
	[Address(RVA = "0x1958234", Offset = "0x1958234", VA = "0x1958234")]
	private void RefreshTabRedPoint()
	{
	}

	[Token(Token = "0x600B71B")]
	[Address(RVA = "0x1958410", Offset = "0x1958410", VA = "0x1958410")]
	private void RefreshView(bool needSort = false)
	{
	}

	[Token(Token = "0x600B71C")]
	[Address(RVA = "0x19595F0", Offset = "0x19595F0", VA = "0x19595F0")]
	private void RefreshNormalItemList(List<MysteryPoolStoreItem> poolItemList)
	{
	}

	[Token(Token = "0x600B71D")]
	[Address(RVA = "0x19593A0", Offset = "0x19593A0", VA = "0x19593A0")]
	private void RefreshBtnSwitchPool()
	{
	}

	[Token(Token = "0x600B71E")]
	[Address(RVA = "0x19597FC", Offset = "0x19597FC", VA = "0x19597FC")]
	private void OnBtnGemClick()
	{
	}

	[Token(Token = "0x600B71F")]
	[Address(RVA = "0x19598E4", Offset = "0x19598E4", VA = "0x19598E4")]
	private void OnBtnSwitchPoolClick()
	{
	}

	[Token(Token = "0x600B720")]
	[Address(RVA = "0x195A010", Offset = "0x195A010", VA = "0x195A010")]
	private void OnBtnPurchaseSuperClick()
	{
	}

	[Token(Token = "0x600B721")]
	[Address(RVA = "0x195A4F0", Offset = "0x195A4F0", VA = "0x195A4F0")]
	private void OnClickCloseButton()
	{
	}

	[Token(Token = "0x600B722")]
	[Address(RVA = "0x195A5FC", Offset = "0x195A5FC", VA = "0x195A5FC")]
	private void OnBtnRuleClick()
	{
	}

	[Token(Token = "0x600B723")]
	[Address(RVA = "0x195A8E0", Offset = "0x195A8E0", VA = "0x195A8E0")]
	private void OnBtnGoWebClick()
	{
	}

	[Token(Token = "0x600B724")]
	[Address(RVA = "0x195AB24", Offset = "0x195AB24", VA = "0x195AB24", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B725")]
	[Address(RVA = "0x195AC00", Offset = "0x195AC00", VA = "0x195AC00", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B727")]
	[Address(RVA = "0x195AF4C", Offset = "0x195AF4C", VA = "0x195AF4C")]
	private static int _003CInitMysteryMallTab_003Em__0(UIMysteryMallThemeView x, UIMysteryMallThemeView y)
	{
		return default(int);
	}

	[Token(Token = "0x600B728")]
	[Address(RVA = "0x195AF94", Offset = "0x195AF94", VA = "0x195AF94")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B729")]
	[Address(RVA = "0x195AF9C", Offset = "0x195AF9C", VA = "0x195AF9C")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600B72A")]
	[Address(RVA = "0x195AFA4", Offset = "0x195AFA4", VA = "0x195AFA4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
