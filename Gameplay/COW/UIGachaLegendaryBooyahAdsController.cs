using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200263F")]
public class UIGachaLegendaryBooyahAdsController : UIBaseController
{
	[Token(Token = "0x400EC14")]
	[FieldOffset(Offset = "0x28")]
	private uint m_GachaID;

	[Token(Token = "0x400EC15")]
	[FieldOffset(Offset = "0x2C")]
	private UIGachaLegendaryBooyahAdsView m_View;

	[Token(Token = "0x400EC16")]
	[FieldOffset(Offset = "0x30")]
	private UICenterOnChild m_wrapCenter;

	[Token(Token = "0x400EC17")]
	[FieldOffset(Offset = "0x34")]
	private List<UILobbyDotController> m_DotCtrls;

	[Token(Token = "0x400EC18")]
	[FieldOffset(Offset = "0x38")]
	private List<UILobbyAdItemController> m_AdItems;

	[Token(Token = "0x400EC19")]
	[FieldOffset(Offset = "0x3C")]
	private int m_LastSelectedIndex;

	[Token(Token = "0x400EC1A")]
	[FieldOffset(Offset = "0x40")]
	private List<UIModelLobbyAds.AdInfo> m_AdInfoList;

	[Token(Token = "0x400EC1B")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 m_ScrollViewOriginalLocalPosition;

	[Token(Token = "0x400EC1C")]
	[FieldOffset(Offset = "0x50")]
	private uint m_AutoScrollDelayCallID;

	[Token(Token = "0x600E3D6")]
	[Address(RVA = "0x2489910", Offset = "0x2489910", VA = "0x2489910")]
	public UIGachaLegendaryBooyahAdsController()
	{
	}

	[Token(Token = "0x600E3D7")]
	[Address(RVA = "0x2489A78", Offset = "0x2489A78", VA = "0x2489A78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E3D8")]
	[Address(RVA = "0x2489B1C", Offset = "0x2489B1C", VA = "0x2489B1C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E3D9")]
	[Address(RVA = "0x2489E84", Offset = "0x2489E84", VA = "0x2489E84")]
	private void ShowRewardPreviewWnd()
	{
	}

	[Token(Token = "0x600E3DA")]
	[Address(RVA = "0x2489FBC", Offset = "0x2489FBC", VA = "0x2489FBC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E3DB")]
	[Address(RVA = "0x248A0D0", Offset = "0x248A0D0", VA = "0x248A0D0")]
	public void RefreshUIData(uint gachaID)
	{
	}

	[Token(Token = "0x600E3DC")]
	[Address(RVA = "0x248AE40", Offset = "0x248AE40", VA = "0x248AE40")]
	private void OnAutoScrollAdItem()
	{
	}

	[Token(Token = "0x600E3DD")]
	[Address(RVA = "0x248B014", Offset = "0x248B014", VA = "0x248B014")]
	private void GetCenterItem(GameObject centerGo)
	{
	}

	[Token(Token = "0x600E3DE")]
	[Address(RVA = "0x248B184", Offset = "0x248B184", VA = "0x248B184")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E3DF")]
	[Address(RVA = "0x248B18C", Offset = "0x248B18C", VA = "0x248B18C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
