using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023B1")]
public class UIStandardAdsController : UIBaseController
{
	[Token(Token = "0x20023B2")]
	public enum EDotPosType
	{
		[Token(Token = "0x400DE45")]
		OnCdn,
		[Token(Token = "0x400DE46")]
		BelowCdn
	}

	[Token(Token = "0x400DE36")]
	[FieldOffset(Offset = "0x28")]
	private UIStandardAdsView m_View;

	[Token(Token = "0x400DE37")]
	[FieldOffset(Offset = "0x2C")]
	private UICenterOnChild m_wrapCenter;

	[Token(Token = "0x400DE38")]
	[FieldOffset(Offset = "0x30")]
	private List<UILobbyDotController> m_DotCtrls;

	[Token(Token = "0x400DE39")]
	[FieldOffset(Offset = "0x34")]
	private List<UIStandardAdsItemController> m_AdItems;

	[Token(Token = "0x400DE3A")]
	[FieldOffset(Offset = "0x38")]
	private int m_LastSelectedIndex;

	[Token(Token = "0x400DE3B")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIModelLobbyAds.AdInfo> m_AdInfoList;

	[Token(Token = "0x400DE3C")]
	[FieldOffset(Offset = "0x40")]
	private uint m_AutoScrollDelayCallID;

	[Token(Token = "0x400DE3D")]
	[FieldOffset(Offset = "0x44")]
	private UIDragScrollView m_Drag;

	[Token(Token = "0x400DE3E")]
	[FieldOffset(Offset = "0x48")]
	private UINavigationUtil.UINavigationFrom m_NavType;

	[Token(Token = "0x400DE3F")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_NeedGopos;

	[Token(Token = "0x400DE40")]
	private const int DefaultDotWidth = 20;

	[Token(Token = "0x400DE41")]
	private const int DefaultDotHeight = 5;

	[Token(Token = "0x400DE42")]
	private const int DotsOnCdnPosY = -220;

	[Token(Token = "0x400DE43")]
	private const int DotsBelowCdnPosY = -265;

	[Token(Token = "0x600C8C6")]
	[Address(RVA = "0x205FEF4", Offset = "0x205FEF4", VA = "0x205FEF4")]
	public UIStandardAdsController()
	{
	}

	[Token(Token = "0x600C8C7")]
	[Address(RVA = "0x2060024", Offset = "0x2060024", VA = "0x2060024")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C8C8")]
	[Address(RVA = "0x20600C8", Offset = "0x20600C8", VA = "0x20600C8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C8C9")]
	[Address(RVA = "0x2060340", Offset = "0x2060340", VA = "0x2060340", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C8CA")]
	[Address(RVA = "0x2060454", Offset = "0x2060454", VA = "0x2060454")]
	public void SetGoposState(bool isEnable)
	{
	}

	[Token(Token = "0x600C8CB")]
	[Address(RVA = "0x20604B4", Offset = "0x20604B4", VA = "0x20604B4")]
	public void UpdatePanelDepth(int newDepth)
	{
	}

	[Token(Token = "0x600C8CC")]
	[Address(RVA = "0x20605A4", Offset = "0x20605A4", VA = "0x20605A4")]
	public void SetViewData(List<UIModelLobbyAds.AdInfo> adInfoList, UINavigationUtil.UINavigationFrom newNavType, int dotWidth = 20, int dotHeight = 5, EDotPosType dotPosType = EDotPosType.OnCdn)
	{
	}

	[Token(Token = "0x600C8CD")]
	[Address(RVA = "0x2061318", Offset = "0x2061318", VA = "0x2061318")]
	public void SetGridValue(int cellWidth, int cellHeight)
	{
	}

	[Token(Token = "0x600C8CE")]
	[Address(RVA = "0x2061434", Offset = "0x2061434", VA = "0x2061434")]
	private void OnAutoScrollAdItem()
	{
	}

	[Token(Token = "0x600C8CF")]
	[Address(RVA = "0x2061608", Offset = "0x2061608", VA = "0x2061608")]
	private void GetCenterItem(GameObject centerGo)
	{
	}

	[Token(Token = "0x600C8D0")]
	[Address(RVA = "0x2061898", Offset = "0x2061898", VA = "0x2061898")]
	private void onAdsClicked()
	{
	}

	[Token(Token = "0x600C8D1")]
	[Address(RVA = "0x2061B80", Offset = "0x2061B80", VA = "0x2061B80")]
	public void SetDotSprite(string enableName, string disableName)
	{
	}

	[Token(Token = "0x600C8D2")]
	[Address(RVA = "0x2061D40", Offset = "0x2061D40", VA = "0x2061D40")]
	public void SetDotSprite(UISprite enable, UISprite disable, Vector3 scale)
	{
	}

	[Token(Token = "0x600C8D3")]
	[Address(RVA = "0x2061F30", Offset = "0x2061F30", VA = "0x2061F30")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C8D4")]
	[Address(RVA = "0x2061F38", Offset = "0x2061F38", VA = "0x2061F38")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
