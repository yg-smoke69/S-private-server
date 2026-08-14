using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A7E")]
public class UIPortraitCloseupController : UINavigationController
{
	[Token(Token = "0x4010503")]
	[FieldOffset(Offset = "0x68")]
	private UIPortraitCloseupView m_View;

	[Token(Token = "0x4010504")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_IsZoomIn;

	[Token(Token = "0x4010505")]
	[FieldOffset(Offset = "0x6D")]
	private bool m_IsMoving;

	[Token(Token = "0x4010506")]
	[FieldOffset(Offset = "0x70")]
	private AvatarCameraMoveComp m_AvatarMoveComp;

	[Token(Token = "0x4010507")]
	[FieldOffset(Offset = "0x74")]
	private GameObject m_GroundShadow;

	[Token(Token = "0x4010508")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 m_ProfilePageCamPos;

	[Token(Token = "0x4010509")]
	[FieldOffset(Offset = "0x84")]
	private float m_ProfilePageBGSize;

	[Token(Token = "0x401050A")]
	[FieldOffset(Offset = "0x88")]
	private float m_ZoomInBgSize;

	[Token(Token = "0x401050B")]
	[FieldOffset(Offset = "0x8C")]
	private float m_ZoomOutBgSize;

	[Token(Token = "0x401050C")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 m_ZoomInCamPos;

	[Token(Token = "0x401050D")]
	[FieldOffset(Offset = "0x9C")]
	private Vector3 m_ZoomOutCamPos;

	[Token(Token = "0x401050E")]
	private const string ZOOMINICON = "SG_UI_Icon_zoomin";

	[Token(Token = "0x401050F")]
	private const string ZOOMOUTICON = "SG_UI_Icon_zoomout";

	[Token(Token = "0x4010510")]
	private const float MOVE_DURATION = 0.8f;

	[Token(Token = "0x60114B8")]
	[Address(RVA = "0xEF69AC", Offset = "0xEF69AC", VA = "0xEF69AC")]
	public UIPortraitCloseupController()
	{
	}

	[Token(Token = "0x60114B9")]
	[Address(RVA = "0xEF6B00", Offset = "0xEF6B00", VA = "0xEF6B00")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60114BA")]
	[Address(RVA = "0xEF6BA4", Offset = "0xEF6BA4", VA = "0xEF6BA4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60114BB")]
	[Address(RVA = "0xEF6EA4", Offset = "0xEF6EA4", VA = "0xEF6EA4", Slot = "39")]
	public override List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x60114BC")]
	[Address(RVA = "0xEF6FA4", Offset = "0xEF6FA4", VA = "0xEF6FA4", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x60114BD")]
	[Address(RVA = "0xEF7A34", Offset = "0xEF7A34", VA = "0xEF7A34", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x60114BE")]
	[Address(RVA = "0xEF7CCC", Offset = "0xEF7CCC", VA = "0xEF7CCC")]
	public void SetNeedPlayEnterTeamAnim()
	{
	}

	[Token(Token = "0x60114BF")]
	[Address(RVA = "0xEF7DF0", Offset = "0xEF7DF0", VA = "0xEF7DF0")]
	private void OnExitBtnClick()
	{
	}

	[Token(Token = "0x60114C0")]
	[Address(RVA = "0xEF7EFC", Offset = "0xEF7EFC", VA = "0xEF7EFC")]
	private void OnTakePhotoBtnClick()
	{
	}

	[Token(Token = "0x60114C1")]
	[Address(RVA = "0xEF8058", Offset = "0xEF8058", VA = "0xEF8058")]
	private void OnZoomInOutBtnClick()
	{
	}

	[Token(Token = "0x60114C2")]
	[Address(RVA = "0xEF8414", Offset = "0xEF8414", VA = "0xEF8414")]
	private void SetMagnifierState(bool b)
	{
	}

	[Token(Token = "0x60114C3")]
	[Address(RVA = "0xEF8508", Offset = "0xEF8508", VA = "0xEF8508", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x60114C4")]
	[Address(RVA = "0xEF861C", Offset = "0xEF861C", VA = "0xEF861C", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x60114C5")]
	[Address(RVA = "0xEF7740", Offset = "0xEF7740", VA = "0xEF7740")]
	private GameObject GetBgObj()
	{
		return null;
	}

	[Token(Token = "0x60114C6")]
	[Address(RVA = "0xEF78D0", Offset = "0xEF78D0", VA = "0xEF78D0")]
	private GameObject GetCamObj()
	{
		return null;
	}

	[Token(Token = "0x60114C7")]
	[Address(RVA = "0xEF8730", Offset = "0xEF8730", VA = "0xEF8730")]
	private void _003COnZoomInOutBtnClick_003Em__0()
	{
	}

	[Token(Token = "0x60114C8")]
	[Address(RVA = "0xEF8744", Offset = "0xEF8744", VA = "0xEF8744")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60114C9")]
	[Address(RVA = "0xEF874C", Offset = "0xEF874C", VA = "0xEF874C")]
	public List<string> _003C_003EiFixBaseProxy_GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x60114CA")]
	[Address(RVA = "0xEF8754", Offset = "0xEF8754", VA = "0xEF8754")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x60114CB")]
	[Address(RVA = "0xEF875C", Offset = "0xEF875C", VA = "0xEF875C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x60114CC")]
	[Address(RVA = "0xEF8764", Offset = "0xEF8764", VA = "0xEF8764")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x60114CD")]
	[Address(RVA = "0xEF876C", Offset = "0xEF876C", VA = "0xEF876C")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
