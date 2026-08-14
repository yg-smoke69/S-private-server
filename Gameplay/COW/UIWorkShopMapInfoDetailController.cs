using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C28")]
internal class UIWorkShopMapInfoDetailController : UIBaseController
{
	[Token(Token = "0x4010DA7")]
	[FieldOffset(Offset = "0x28")]
	private UIWorkShopMapInfoDetailView m_View;

	[Token(Token = "0x4010DA8")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIWorkshopMapItemController> m_WorkShopMapItems;

	[Token(Token = "0x4010DA9")]
	[FieldOffset(Offset = "0x30")]
	private int m_LastSelectedIndex;

	[Token(Token = "0x4010DAA")]
	[FieldOffset(Offset = "0x34")]
	private uint m_AutoScrollDelayCallID;

	[Token(Token = "0x4010DAB")]
	[FieldOffset(Offset = "0x38")]
	private UIWorkshopMapItemController m_GameMapItemCache;

	[Token(Token = "0x4010DAC")]
	[FieldOffset(Offset = "0x3C")]
	private UIWorkshopMapItemController m_CdnMapItemCache;

	[Token(Token = "0x4010DAD")]
	[FieldOffset(Offset = "0x40")]
	private int m_CurActiveItemCnt;

	[Token(Token = "0x4010DAE")]
	[FieldOffset(Offset = "0x44")]
	private int m_RealItemCnt;

	[Token(Token = "0x4010DAF")]
	[FieldOffset(Offset = "0x48")]
	private List<UISprite> m_LightDot;

	[Token(Token = "0x6012642")]
	[Address(RVA = "0x1A189E0", Offset = "0x1A189E0", VA = "0x1A189E0")]
	public UIWorkShopMapInfoDetailController()
	{
	}

	[Token(Token = "0x6012643")]
	[Address(RVA = "0x1A18AD4", Offset = "0x1A18AD4", VA = "0x1A18AD4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012644")]
	[Address(RVA = "0x1A18B7C", Offset = "0x1A18B7C", VA = "0x1A18B7C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012645")]
	[Address(RVA = "0x1A18E44", Offset = "0x1A18E44", VA = "0x1A18E44", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012646")]
	[Address(RVA = "0x1A18F58", Offset = "0x1A18F58", VA = "0x1A18F58")]
	public void InitData(uint mapID, string cdnUrl, byte[] bitMapData, byte[] iconMapData, int width, int height, [Optional] Action itemClickCallBack)
	{
	}

	[Token(Token = "0x6012647")]
	[Address(RVA = "0x1A1A028", Offset = "0x1A1A028", VA = "0x1A1A028")]
	private void Reset()
	{
	}

	[Token(Token = "0x6012648")]
	[Address(RVA = "0x1A1B3A4", Offset = "0x1A1B3A4", VA = "0x1A1B3A4")]
	private void OnAutoScrollAdItem()
	{
	}

	[Token(Token = "0x6012649")]
	[Address(RVA = "0x1A1B4DC", Offset = "0x1A1B4DC", VA = "0x1A1B4DC")]
	private void GetCenterItem(GameObject centerGo)
	{
	}

	[Token(Token = "0x601264A")]
	[Address(RVA = "0x1A1B658", Offset = "0x1A1B658", VA = "0x1A1B658")]
	private void RefreshDot()
	{
	}

	[Token(Token = "0x601264B")]
	[Address(RVA = "0x1A1B7F4", Offset = "0x1A1B7F4", VA = "0x1A1B7F4")]
	private void OnScrollViewDrag()
	{
	}

	[Token(Token = "0x601264C")]
	[Address(RVA = "0x1A1B904", Offset = "0x1A1B904", VA = "0x1A1B904")]
	private void OnContentCick()
	{
	}

	[Token(Token = "0x601264D")]
	[Address(RVA = "0x1A1BA70", Offset = "0x1A1BA70", VA = "0x1A1BA70")]
	public int GetScrollViewPanelDepth()
	{
		return default(int);
	}

	[Token(Token = "0x601264E")]
	[Address(RVA = "0x1A1BB1C", Offset = "0x1A1BB1C", VA = "0x1A1BB1C")]
	public void SetScrollViewDepth(int depth)
	{
	}

	[Token(Token = "0x601264F")]
	[Address(RVA = "0x1A1BC0C", Offset = "0x1A1BC0C", VA = "0x1A1BC0C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012650")]
	[Address(RVA = "0x1A1BC14", Offset = "0x1A1BC14", VA = "0x1A1BC14")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
