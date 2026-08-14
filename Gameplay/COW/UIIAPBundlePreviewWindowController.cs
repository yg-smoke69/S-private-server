using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028D9")]
internal class UIIAPBundlePreviewWindowController : UIPopupWindowController
{
	[Token(Token = "0x20028DA")]
	private sealed class _003CTakeScreenshots_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FB49")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x400FB4A")]
		[FieldOffset(Offset = "0xC")]
		internal UIIAPBundlePreviewWindowController _0024this;

		[Token(Token = "0x60101E1")]
		[Address(RVA = "0xD410A0", Offset = "0xD410A0", VA = "0xD410A0")]
		public _003CTakeScreenshots_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60101E2")]
		[Address(RVA = "0xD41E30", Offset = "0xD41E30", VA = "0xD41E30")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x60101E3")]
		[Address(RVA = "0xD4200C", Offset = "0xD4200C", VA = "0xD4200C")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400FB41")]
	[FieldOffset(Offset = "0x48")]
	private UIIAPBundlePreviewWindowView m_View;

	[Token(Token = "0x400FB42")]
	[FieldOffset(Offset = "0x4C")]
	private int m_ScreenshotIndex;

	[Token(Token = "0x400FB43")]
	private const float DELAY_DETAIL = 0.1f;

	[Token(Token = "0x400FB44")]
	private const float DELAY_SCREENSHOT = 1f;

	[Token(Token = "0x400FB45")]
	[FieldOffset(Offset = "0x50")]
	private List<UIIAPBundlePreviewItemController> m_ItemControllers;

	[Token(Token = "0x400FB46")]
	[FieldOffset(Offset = "0x54")]
	private List<IAPBundleStoreData> m_IAPBundles;

	[Token(Token = "0x400FB47")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<CSVBaseData, IAPBundleStoreData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400FB48")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<IAPBundleStoreData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x60101CE")]
	[Address(RVA = "0xD408E8", Offset = "0xD408E8", VA = "0xD408E8")]
	public UIIAPBundlePreviewWindowController()
	{
	}

	[Token(Token = "0x60101CF")]
	[Address(RVA = "0xD409B0", Offset = "0xD409B0", VA = "0xD409B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60101D0")]
	[Address(RVA = "0xD40A58", Offset = "0xD40A58", VA = "0xD40A58", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60101D1")]
	[Address(RVA = "0xD40D64", Offset = "0xD40D64", VA = "0xD40D64", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60101D2")]
	[Address(RVA = "0xD40DD0", Offset = "0xD40DD0", VA = "0xD40DD0")]
	protected void CheckScreenshotOnVisibilityChanged()
	{
	}

	[Token(Token = "0x60101D3")]
	[Address(RVA = "0xD40EE0", Offset = "0xD40EE0", VA = "0xD40EE0")]
	private string ScreenshotFilePath(IAPBundleStoreData data)
	{
		return null;
	}

	[Token(Token = "0x60101D4")]
	[Address(RVA = "0xD40BC4", Offset = "0xD40BC4", VA = "0xD40BC4")]
	private void TakeScreenshots(int index = 0)
	{
	}

	[Token(Token = "0x60101D5")]
	[Address(RVA = "0xD410A8", Offset = "0xD410A8", VA = "0xD410A8", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x60101D6")]
	[Address(RVA = "0xD411C0", Offset = "0xD411C0", VA = "0xD411C0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60101D7")]
	[Address(RVA = "0xD41224", Offset = "0xD41224", VA = "0xD41224")]
	private void ClearItemControllers()
	{
	}

	[Token(Token = "0x60101D8")]
	[Address(RVA = "0xD413F4", Offset = "0xD413F4", VA = "0xD413F4")]
	private void UpdateItemControllers()
	{
	}

	[Token(Token = "0x60101D9")]
	[Address(RVA = "0xD41C04", Offset = "0xD41C04", VA = "0xD41C04")]
	private void OnItemClick(IAPBundleStoreData data)
	{
	}

	[Token(Token = "0x60101DA")]
	[Address(RVA = "0xD40B64", Offset = "0xD40B64", VA = "0xD40B64")]
	private void UpdateData()
	{
	}

	[Token(Token = "0x60101DB")]
	[Address(RVA = "0xD41D28", Offset = "0xD41D28", VA = "0xD41D28")]
	private static IAPBundleStoreData _003CUpdateItemControllers_003Em__0(CSVBaseData d)
	{
		return null;
	}

	[Token(Token = "0x60101DC")]
	[Address(RVA = "0xD41DBC", Offset = "0xD41DBC", VA = "0xD41DBC")]
	private static int _003CUpdateItemControllers_003Em__1(IAPBundleStoreData a, IAPBundleStoreData b)
	{
		return default(int);
	}

	[Token(Token = "0x60101DD")]
	[Address(RVA = "0xD41E10", Offset = "0xD41E10", VA = "0xD41E10")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60101DE")]
	[Address(RVA = "0xD41E18", Offset = "0xD41E18", VA = "0xD41E18")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60101DF")]
	[Address(RVA = "0xD41E20", Offset = "0xD41E20", VA = "0xD41E20")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	[Token(Token = "0x60101E0")]
	[Address(RVA = "0xD41E28", Offset = "0xD41E28", VA = "0xD41E28")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
