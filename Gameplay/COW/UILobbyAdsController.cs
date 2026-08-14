using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002918")]
internal class UILobbyAdsController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002919")]
	private enum BannerType
	{
		[Token(Token = "0x400FD1D")]
		None,
		[Token(Token = "0x400FD1E")]
		ActivityLocalization,
		[Token(Token = "0x400FD1F")]
		GMT,
		[Token(Token = "0x400FD20")]
		CDNSettingLocal
	}

	[Token(Token = "0x200291A")]
	public enum ExtraAdHintType
	{
		[Token(Token = "0x400FD22")]
		NONE,
		[Token(Token = "0x400FD23")]
		RESET_BY_ID,
		[Token(Token = "0x400FD24")]
		RESET_BY_TIME
	}

	[Token(Token = "0x200291B")]
	private class ExtraAdUI
	{
		[Token(Token = "0x400FD25")]
		[FieldOffset(Offset = "0x8")]
		public int idx;

		[Token(Token = "0x400FD26")]
		[FieldOffset(Offset = "0xC")]
		public UIButton Button;

		[Token(Token = "0x400FD27")]
		[FieldOffset(Offset = "0x10")]
		public UINetworkTextureExt NetworkTexture;

		[Token(Token = "0x400FD28")]
		[FieldOffset(Offset = "0x14")]
		public UISprite Bg;

		[Token(Token = "0x400FD29")]
		[FieldOffset(Offset = "0x18")]
		public Callback OnClick;

		[Token(Token = "0x400FD2A")]
		[FieldOffset(Offset = "0x1C")]
		public BoxCollider Collider;

		[Token(Token = "0x400FD2B")]
		[FieldOffset(Offset = "0x20")]
		public ExtraAdHintType hintType;

		[Token(Token = "0x400FD2C")]
		[FieldOffset(Offset = "0x24")]
		public uint cdnResID;

		[Token(Token = "0x400FD2D")]
		[FieldOffset(Offset = "0x28")]
		public GameObject hintTipGO;

		[Token(Token = "0x400FD2E")]
		[FieldOffset(Offset = "0x2C")]
		public UINavigationUtil.UINavigationFrom from;

		[Token(Token = "0x400FD2F")]
		[FieldOffset(Offset = "0x30")]
		public UISprite CountDown;

		[Token(Token = "0x400FD30")]
		[FieldOffset(Offset = "0x34")]
		public UISprite CountDownBG;

		[Token(Token = "0x400FD31")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Anim;

		[Token(Token = "0x400FD32")]
		[FieldOffset(Offset = "0x3C")]
		public UICountDownController CountDownCtrl;

		[Token(Token = "0x60104E8")]
		[Address(RVA = "0x2167360", Offset = "0x2167360", VA = "0x2167360")]
		public ExtraAdUI()
		{
		}
	}

	[Token(Token = "0x200291C")]
	private sealed class _003COnUIInit_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FD33")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x400FD34")]
		[FieldOffset(Offset = "0xC")]
		internal UILobbyAdsController _0024this;

		[Token(Token = "0x60104E9")]
		[Address(RVA = "0x2167368", Offset = "0x2167368", VA = "0x2167368")]
		public _003COnUIInit_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60104EA")]
		[Address(RVA = "0x216AE4C", Offset = "0x216AE4C", VA = "0x216AE4C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400FD0B")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyAdsView m_View;

	[Token(Token = "0x400FD0C")]
	[FieldOffset(Offset = "0x2C")]
	private UICenterOnChild m_wrapCenter;

	[Token(Token = "0x400FD0D")]
	[FieldOffset(Offset = "0x30")]
	private List<UILobbyDotController> m_DotCtrls;

	[Token(Token = "0x400FD0E")]
	[FieldOffset(Offset = "0x34")]
	private List<UILobbyAdItemController> m_AdItems;

	[Token(Token = "0x400FD0F")]
	[FieldOffset(Offset = "0x38")]
	private int m_LastSelectedIndex;

	[Token(Token = "0x400FD10")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIModelLobbyAds.AdInfo> m_AdInfoList;

	[Token(Token = "0x400FD11")]
	[FieldOffset(Offset = "0x40")]
	private UIModelLobbyAds m_ModelLobbyAd;

	[Token(Token = "0x400FD12")]
	[FieldOffset(Offset = "0x44")]
	private BoxCollider m_ContentCollider;

	[Token(Token = "0x400FD13")]
	[FieldOffset(Offset = "0x48")]
	private uint m_AutoScrollDelayCallID;

	[Token(Token = "0x400FD14")]
	private const int DEFAULT_DOT_WIDTH = 29;

	[Token(Token = "0x400FD15")]
	private const int DEFAULT_DOT_HEIGHT = 6;

	[Token(Token = "0x400FD16")]
	private const int DEFAULT_DOT_DISABLE_WIDTH = 29;

	[Token(Token = "0x400FD17")]
	private const int DEFAULT_DOT_DISABLE_HEIGHT = 8;

	[Token(Token = "0x400FD18")]
	private const int MAX_DISPLAY_DOT_CNT = 6;

	[Token(Token = "0x400FD19")]
	[FieldOffset(Offset = "0x4C")]
	private UIGrid m_CurrentGrid;

	[Token(Token = "0x400FD1A")]
	[FieldOffset(Offset = "0x50")]
	private List<AdvertDesc> _ExtraAds;

	[Token(Token = "0x400FD1B")]
	[FieldOffset(Offset = "0x54")]
	private ExtraAdUI[] _ExtraAdUIs;

	[Token(Token = "0x60104D4")]
	[Address(RVA = "0x2166528", Offset = "0x2166528", VA = "0x2166528")]
	public UILobbyAdsController()
	{
	}

	[Token(Token = "0x60104D5")]
	[Address(RVA = "0x2166684", Offset = "0x2166684", VA = "0x2166684")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60104D6")]
	[Address(RVA = "0x2166728", Offset = "0x2166728", VA = "0x2166728", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60104D7")]
	[Address(RVA = "0x2167FB4", Offset = "0x2167FB4", VA = "0x2167FB4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60104D8")]
	[Address(RVA = "0x21683CC", Offset = "0x21683CC", VA = "0x21683CC")]
	public void UpdateExtraAdHint()
	{
	}

	[Token(Token = "0x60104D9")]
	[Address(RVA = "0x21686A0", Offset = "0x21686A0", VA = "0x21686A0")]
	private void OnGetCDNAD(object[] data)
	{
	}

	[Token(Token = "0x60104DA")]
	[Address(RVA = "0x2168718", Offset = "0x2168718", VA = "0x2168718")]
	public void UpdateExtraAdsAnim()
	{
	}

	[Token(Token = "0x60104DB")]
	[Address(RVA = "0x2167370", Offset = "0x2167370", VA = "0x2167370")]
	private void UpdateExtraAds()
	{
	}

	[Token(Token = "0x60104DC")]
	[Address(RVA = "0x2169478", Offset = "0x2169478", VA = "0x2169478")]
	private void OnExtraAdsClick(int index)
	{
	}

	[Token(Token = "0x60104DD")]
	[Address(RVA = "0x2169858", Offset = "0x2169858", VA = "0x2169858")]
	private void SendBannerClickLog(BannerType bannerType, uint id)
	{
	}

	[Token(Token = "0x60104DE")]
	[Address(RVA = "0x2169A74", Offset = "0x2169A74", VA = "0x2169A74")]
	private void OnAdClickStateChange(object[] data)
	{
	}

	[Token(Token = "0x60104DF")]
	[Address(RVA = "0x2168B0C", Offset = "0x2168B0C", VA = "0x2168B0C")]
	private void RefreshUIData()
	{
	}

	[Token(Token = "0x60104E0")]
	[Address(RVA = "0x2169CFC", Offset = "0x2169CFC", VA = "0x2169CFC")]
	private void InitDot()
	{
	}

	[Token(Token = "0x60104E1")]
	[Address(RVA = "0x216A418", Offset = "0x216A418", VA = "0x216A418")]
	private void OnAutoScrollAdItem()
	{
	}

	[Token(Token = "0x60104E2")]
	[Address(RVA = "0x216A5EC", Offset = "0x216A5EC", VA = "0x216A5EC")]
	private void GetCenterItem(GameObject centerGo)
	{
	}

	[Token(Token = "0x60104E3")]
	[Address(RVA = "0x216A944", Offset = "0x216A944", VA = "0x216A944")]
	private void onAdsClicked()
	{
	}

	[Token(Token = "0x60104E4")]
	[Address(RVA = "0x216AC34", Offset = "0x216AC34", VA = "0x216AC34", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60104E5")]
	[Address(RVA = "0x216ADA8", Offset = "0x216ADA8", VA = "0x216ADA8", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60104E6")]
	[Address(RVA = "0x216AE3C", Offset = "0x216AE3C", VA = "0x216AE3C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60104E7")]
	[Address(RVA = "0x216AE44", Offset = "0x216AE44", VA = "0x216AE44")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
