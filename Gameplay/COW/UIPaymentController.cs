using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A1C")]
public class UIPaymentController : UINavigationController, _Attribute
{
	[Token(Token = "0x2002A1D")]
	public enum Tab
	{
		[Token(Token = "0x40102F4")]
		None,
		[Token(Token = "0x40102F5")]
		IAP,
		[Token(Token = "0x40102F6")]
		RebateCard,
		[Token(Token = "0x40102F7")]
		Bundle,
		[Token(Token = "0x40102F8")]
		FirstTime,
		[Token(Token = "0x40102F9")]
		Total,
		[Token(Token = "0x40102FA")]
		Activity,
		[Token(Token = "0x40102FB")]
		Shop,
		[Token(Token = "0x40102FC")]
		DiamondEvent,
		[Token(Token = "0x40102FD")]
		Subscription,
		[Token(Token = "0x40102FE")]
		GrowthFund,
		[Token(Token = "0x40102FF")]
		TopUpEvent,
		[Token(Token = "0x4010300")]
		MemberShip,
		[Token(Token = "0x4010301")]
		UpperLimit
	}

	[Token(Token = "0x2002A1E")]
	public enum EBundleType
	{
		[Token(Token = "0x4010303")]
		Default,
		[Token(Token = "0x4010304")]
		Bundle,
		[Token(Token = "0x4010305")]
		Newbie,
		[Token(Token = "0x4010306")]
		UpperLimit
	}

	[Token(Token = "0x2002A1F")]
	public class TabInfo
	{
		[Token(Token = "0x4010307")]
		[FieldOffset(Offset = "0x8")]
		public string NameLocKey;

		[Token(Token = "0x4010308")]
		[FieldOffset(Offset = "0xC")]
		public ETipsType TipsType;

		[Token(Token = "0x4010309")]
		[FieldOffset(Offset = "0x10")]
		public Func<bool> Visible;

		[Token(Token = "0x401030A")]
		[FieldOffset(Offset = "0x14")]
		public string NoteLocKey;

		[Token(Token = "0x401030B")]
		[FieldOffset(Offset = "0x18")]
		public bool LogClick;

		[Token(Token = "0x401030C")]
		[FieldOffset(Offset = "0x19")]
		public bool SubTab;

		[Token(Token = "0x60110AB")]
		[Address(RVA = "0x287E268", Offset = "0x287E268", VA = "0x287E268")]
		public TabInfo()
		{
		}
	}

	[Token(Token = "0x2002A20")]
	public class PaymentGotoParams
	{
		[Token(Token = "0x401030D")]
		[FieldOffset(Offset = "0x8")]
		public uint? SubscriptionHubStoreId;

		[Token(Token = "0x401030E")]
		[FieldOffset(Offset = "0x10")]
		public EBundleType m_BundleType;

		[Token(Token = "0x401030F")]
		[FieldOffset(Offset = "0x14")]
		public int SubTabIndex;

		[Token(Token = "0x60110AC")]
		[Address(RVA = "0x287BDEC", Offset = "0x287BDEC", VA = "0x287BDEC")]
		public PaymentGotoParams()
		{
		}
	}

	[Token(Token = "0x2002A21")]
	public class PaymentTabContentController : UIBaseController
	{
		[Token(Token = "0x60110AD")]
		[Address(RVA = "0x2867D80", Offset = "0x2867D80", VA = "0x2867D80")]
		public PaymentTabContentController()
		{
		}

		[Token(Token = "0x60110AE")]
		[Address(RVA = "0x286BE88", Offset = "0x286BE88", VA = "0x286BE88", Slot = "31")]
		public virtual void GotoByParams(PaymentGotoParams parameters)
		{
		}

		[Token(Token = "0x60110AF")]
		[Address(RVA = "0x2868648", Offset = "0x2868648", VA = "0x2868648", Slot = "32")]
		public virtual void RefreshContent()
		{
		}

		[Token(Token = "0x60110B0")]
		[Address(RVA = "0x287FAE4", Offset = "0x287FAE4", VA = "0x287FAE4", Slot = "33")]
		public virtual void OnPopUpWindowListChange(bool isCovered)
		{
		}
	}

	[Token(Token = "0x2002A22")]
	public class ImageIterator
	{
		[Token(Token = "0x2002A23")]
		public enum ImageType
		{
			[Token(Token = "0x4010316")]
			MainImage,
			[Token(Token = "0x4010317")]
			SubImage
		}

		[Token(Token = "0x4010310")]
		[FieldOffset(Offset = "0x0")]
		private static ImageIterator _I;

		[Token(Token = "0x4010311")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<int, int> PoolState;

		[Token(Token = "0x4010312")]
		[FieldOffset(Offset = "0xC")]
		public Dictionary<int, List<string>> IndexPool;

		[Token(Token = "0x4010313")]
		[FieldOffset(Offset = "0x4")]
		private static Converter<CSVBaseData, string> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x4010314")]
		[FieldOffset(Offset = "0x8")]
		private static Converter<CSVBaseData, string> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x1700127F")]
		public static ImageIterator I
		{
			[Token(Token = "0x60110B2")]
			[Address(RVA = "0x287F1E0", Offset = "0x287F1E0", VA = "0x287F1E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60110B1")]
		[Address(RVA = "0x287F120", Offset = "0x287F120", VA = "0x287F120")]
		private ImageIterator()
		{
		}

		[Token(Token = "0x60110B3")]
		[Address(RVA = "0x287F5AC", Offset = "0x287F5AC", VA = "0x287F5AC")]
		public string Next(ImageType type)
		{
			return null;
		}

		[Token(Token = "0x60110B4")]
		[Address(RVA = "0x287F93C", Offset = "0x287F93C", VA = "0x287F93C")]
		private static string _003Cget_I_003Em__0(CSVBaseData csvBaseData)
		{
			return null;
		}

		[Token(Token = "0x60110B5")]
		[Address(RVA = "0x287FA10", Offset = "0x287FA10", VA = "0x287FA10")]
		private static string _003Cget_I_003Em__1(CSVBaseData csvBaseData)
		{
			return null;
		}
	}

	[Token(Token = "0x2002A24")]
	private sealed class _003COnNavigationShowed_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010318")]
		[FieldOffset(Offset = "0x8")]
		internal uint groupId;

		[Token(Token = "0x60110B6")]
		[Address(RVA = "0x287CE6C", Offset = "0x287CE6C", VA = "0x287CE6C")]
		public _003COnNavigationShowed_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60110B7")]
		[Address(RVA = "0x287F0E8", Offset = "0x287F0E8", VA = "0x287F0E8")]
		internal bool _003C_003Em__0(ActivityGroupDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40102E7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int[] TAB_ORDER_SHOP_BUILD_SHOP_FIRST;

	[Token(Token = "0x40102E8")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int[] TAB_ORDER_SHOP_BUILD;

	[Token(Token = "0x40102E9")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<int, TabInfo> TAB_INFO;

	[Token(Token = "0x40102EA")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<int, PaymentTabContentController> m_Tabs;

	[Token(Token = "0x40102EB")]
	[FieldOffset(Offset = "0x6C")]
	private Tab m_CurrentTab;

	[Token(Token = "0x40102EC")]
	[FieldOffset(Offset = "0x70")]
	private int m_CurrentSubTab;

	[Token(Token = "0x40102ED")]
	[FieldOffset(Offset = "0x74")]
	private bool m_DebtMode;

	[Token(Token = "0x40102EE")]
	[FieldOffset(Offset = "0x78")]
	private UIPaymentView m_View;

	[Token(Token = "0x40102EF")]
	[FieldOffset(Offset = "0x7C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x40102F0")]
	[FieldOffset(Offset = "0x80")]
	private UIModelPayment m_ModelPayment;

	[Token(Token = "0x40102F1")]
	[FieldOffset(Offset = "0x84")]
	private readonly Dictionary<int, UIPaymentTabItemController> m_TabItems;

	[Token(Token = "0x40102F2")]
	[FieldOffset(Offset = "0xC")]
	private static Func<int, bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700127B")]
	private static int[] TabOrder
	{
		[Token(Token = "0x6011086")]
		[Address(RVA = "0x287947C", Offset = "0x287947C", VA = "0x287947C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700127C")]
	public static Tab DefaultTab
	{
		[Token(Token = "0x6011087")]
		[Address(RVA = "0x287964C", Offset = "0x287964C", VA = "0x287964C")]
		get
		{
			return default(Tab);
		}
	}

	[Token(Token = "0x1700127D")]
	public static Tab DefaultChargeTab
	{
		[Token(Token = "0x6011088")]
		[Address(RVA = "0x2879910", Offset = "0x2879910", VA = "0x2879910")]
		get
		{
			return default(Tab);
		}
	}

	[Token(Token = "0x1700127E")]
	public static bool CanHandleDebt
	{
		[Token(Token = "0x6011089")]
		[Address(RVA = "0x2879A9C", Offset = "0x2879A9C", VA = "0x2879A9C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6011085")]
	[Address(RVA = "0x2879388", Offset = "0x2879388", VA = "0x2879388")]
	public UIPaymentController()
	{
	}

	[Token(Token = "0x601108A")]
	[Address(RVA = "0x2879B70", Offset = "0x2879B70", VA = "0x2879B70")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601108B")]
	[Address(RVA = "0x2879C18", Offset = "0x2879C18", VA = "0x2879C18", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601108C")]
	[Address(RVA = "0x2879F18", Offset = "0x2879F18", VA = "0x2879F18")]
	private void RefreshAll(bool notGoToDefault = false)
	{
	}

	[Token(Token = "0x601108D")]
	[Address(RVA = "0x287B188", Offset = "0x287B188", VA = "0x287B188", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601108E")]
	[Address(RVA = "0x287B7B8", Offset = "0x287B7B8", VA = "0x287B7B8")]
	private void OnTabItemGotoTab(object[] parameters)
	{
	}

	[Token(Token = "0x601108F")]
	[Address(RVA = "0x287BF38", Offset = "0x287BF38", VA = "0x287BF38")]
	private void OnTabItemGotoTabInternal(object[] parameters)
	{
	}

	[Token(Token = "0x6011090")]
	[Address(RVA = "0x287C5C0", Offset = "0x287C5C0", VA = "0x287C5C0")]
	private void RefreshBG()
	{
	}

	[Token(Token = "0x6011091")]
	[Address(RVA = "0x287C6C4", Offset = "0x287C6C4", VA = "0x287C6C4", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6011092")]
	[Address(RVA = "0x287CE74", Offset = "0x287CE74", VA = "0x287CE74", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011093")]
	[Address(RVA = "0x287A698", Offset = "0x287A698", VA = "0x287A698")]
	private void Goto(Tab tab, [Optional] PaymentGotoParams paymentGotoParams)
	{
	}

	[Token(Token = "0x6011094")]
	[Address(RVA = "0x287CF30", Offset = "0x287CF30", VA = "0x287CF30")]
	private PaymentTabContentController Open(Tab tab)
	{
		return null;
	}

	[Token(Token = "0x6011095")]
	[Address(RVA = "0x287AFE0", Offset = "0x287AFE0", VA = "0x287AFE0")]
	private void RefreshCurrentTabContent()
	{
	}

	[Token(Token = "0x6011096")]
	[Address(RVA = "0x287D3A4", Offset = "0x287D3A4", VA = "0x287D3A4", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011097")]
	[Address(RVA = "0x287D45C", Offset = "0x287D45C", VA = "0x287D45C", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011098")]
	[Address(RVA = "0x287BDFC", Offset = "0x287BDFC", VA = "0x287BDFC")]
	public void RefreshTableAndScrollView(bool needScroll, float dragAmoung = 1f)
	{
	}

	[Token(Token = "0x6011099")]
	[Address(RVA = "0x287D57C", Offset = "0x287D57C", VA = "0x287D57C", Slot = "33")]
	protected override void OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x601109B")]
	[Address(RVA = "0x287E270", Offset = "0x287E270", VA = "0x287E270")]
	private static bool _003Cget_DefaultTab_003Em__0(int t)
	{
		return default(bool);
	}

	[Token(Token = "0x601109C")]
	[Address(RVA = "0x287E290", Offset = "0x287E290", VA = "0x287E290")]
	private static bool _003CTAB_INFO_003Em__1()
	{
		return default(bool);
	}

	[Token(Token = "0x601109D")]
	[Address(RVA = "0x287E298", Offset = "0x287E298", VA = "0x287E298")]
	private static bool _003CTAB_INFO_003Em__2()
	{
		return default(bool);
	}

	[Token(Token = "0x601109E")]
	[Address(RVA = "0x287E36C", Offset = "0x287E36C", VA = "0x287E36C")]
	private static bool _003CTAB_INFO_003Em__3()
	{
		return default(bool);
	}

	[Token(Token = "0x601109F")]
	[Address(RVA = "0x287E520", Offset = "0x287E520", VA = "0x287E520")]
	private static bool _003CTAB_INFO_003Em__4()
	{
		return default(bool);
	}

	[Token(Token = "0x60110A0")]
	[Address(RVA = "0x287E634", Offset = "0x287E634", VA = "0x287E634")]
	private static bool _003CTAB_INFO_003Em__5()
	{
		return default(bool);
	}

	[Token(Token = "0x60110A1")]
	[Address(RVA = "0x287E7A8", Offset = "0x287E7A8", VA = "0x287E7A8")]
	private static bool _003CTAB_INFO_003Em__6()
	{
		return default(bool);
	}

	[Token(Token = "0x60110A2")]
	[Address(RVA = "0x287E924", Offset = "0x287E924", VA = "0x287E924")]
	private static bool _003CTAB_INFO_003Em__7()
	{
		return default(bool);
	}

	[Token(Token = "0x60110A3")]
	[Address(RVA = "0x287EA68", Offset = "0x287EA68", VA = "0x287EA68")]
	private static bool _003CTAB_INFO_003Em__8()
	{
		return default(bool);
	}

	[Token(Token = "0x60110A4")]
	[Address(RVA = "0x287EC00", Offset = "0x287EC00", VA = "0x287EC00")]
	private static bool _003CTAB_INFO_003Em__9()
	{
		return default(bool);
	}

	[Token(Token = "0x60110A5")]
	[Address(RVA = "0x287EF88", Offset = "0x287EF88", VA = "0x287EF88")]
	private static bool _003CTAB_INFO_003Em__A()
	{
		return default(bool);
	}

	[Token(Token = "0x60110A6")]
	[Address(RVA = "0x287F0C0", Offset = "0x287F0C0", VA = "0x287F0C0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60110A7")]
	[Address(RVA = "0x287F0C8", Offset = "0x287F0C8", VA = "0x287F0C8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60110A8")]
	[Address(RVA = "0x287F0D0", Offset = "0x287F0D0", VA = "0x287F0D0")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x60110A9")]
	[Address(RVA = "0x287F0D8", Offset = "0x287F0D8", VA = "0x287F0D8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60110AA")]
	[Address(RVA = "0x287F0E0", Offset = "0x287F0E0", VA = "0x287F0E0")]
	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
