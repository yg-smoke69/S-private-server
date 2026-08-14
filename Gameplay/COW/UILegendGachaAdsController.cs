using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002688")]
public class UILegendGachaAdsController : UIBaseController
{
	[Token(Token = "0x400EDD0")]
	[FieldOffset(Offset = "0x28")]
	private uint m_GachaID;

	[Token(Token = "0x400EDD1")]
	[FieldOffset(Offset = "0x2C")]
	private UILegendGachaAdsView m_View;

	[Token(Token = "0x400EDD2")]
	[FieldOffset(Offset = "0x30")]
	private UICenterOnChild m_wrapCenter;

	[Token(Token = "0x400EDD3")]
	[FieldOffset(Offset = "0x34")]
	private List<UILobbyDotController> m_DotCtrls;

	[Token(Token = "0x400EDD4")]
	[FieldOffset(Offset = "0x38")]
	private List<UILobbyAdItemController> m_AdItems;

	[Token(Token = "0x400EDD5")]
	[FieldOffset(Offset = "0x3C")]
	private int m_LastSelectedIndex;

	[Token(Token = "0x400EDD6")]
	[FieldOffset(Offset = "0x40")]
	private List<UIModelLobbyAds.AdInfo> m_AdInfoList;

	[Token(Token = "0x400EDD7")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 m_ScrollViewOriginalLocalPosition;

	[Token(Token = "0x400EDD8")]
	[FieldOffset(Offset = "0x50")]
	private uint m_AutoScrollDelayCallID;

	[Token(Token = "0x600E744")]
	[Address(RVA = "0x2546D18", Offset = "0x2546D18", VA = "0x2546D18")]
	public UILegendGachaAdsController()
	{
	}

	[Token(Token = "0x600E745")]
	[Address(RVA = "0x2546E80", Offset = "0x2546E80", VA = "0x2546E80")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E746")]
	[Address(RVA = "0x2546F24", Offset = "0x2546F24", VA = "0x2546F24", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E747")]
	[Address(RVA = "0x25471A4", Offset = "0x25471A4", VA = "0x25471A4")]
	private void OnLegendGachaAdClick()
	{
	}

	[Token(Token = "0x600E748")]
	[Address(RVA = "0x25472DC", Offset = "0x25472DC", VA = "0x25472DC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E749")]
	[Address(RVA = "0x25473F0", Offset = "0x25473F0", VA = "0x25473F0")]
	public void RefreshUIData(uint gachaID, List<AdvertDesc> advertList)
	{
	}

	[Token(Token = "0x600E74A")]
	[Address(RVA = "0x2547F90", Offset = "0x2547F90", VA = "0x2547F90")]
	private void OnAutoScrollAdItem()
	{
	}

	[Token(Token = "0x600E74B")]
	[Address(RVA = "0x2548164", Offset = "0x2548164", VA = "0x2548164")]
	private void GetCenterItem(GameObject centerGo)
	{
	}

	[Token(Token = "0x600E74C")]
	[Address(RVA = "0x25482D4", Offset = "0x25482D4", VA = "0x25482D4")]
	public void SetPanelDepth(int depth)
	{
	}

	[Token(Token = "0x600E74D")]
	[Address(RVA = "0x25483C4", Offset = "0x25483C4", VA = "0x25483C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E74E")]
	[Address(RVA = "0x25483CC", Offset = "0x25483CC", VA = "0x25483CC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
