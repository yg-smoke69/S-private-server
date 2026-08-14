using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028DC")]
public class UIImageShareCaptureWidgetController : UIBaseController
{
	[Token(Token = "0x400FB53")]
	[FieldOffset(Offset = "0x28")]
	private UIImageShareCaptureWidgetView m_View;

	[Token(Token = "0x60101F4")]
	[Address(RVA = "0xD46450", Offset = "0xD46450", VA = "0xD46450")]
	public UIImageShareCaptureWidgetController()
	{
	}

	[Token(Token = "0x60101F5")]
	[Address(RVA = "0xD464D4", Offset = "0xD464D4", VA = "0xD464D4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60101F6")]
	[Address(RVA = "0xD46578", Offset = "0xD46578", VA = "0xD46578", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60101F7")]
	[Address(RVA = "0xD46628", Offset = "0xD46628", VA = "0xD46628")]
	private void UpdatePlayerBasicInfo()
	{
	}

	[Token(Token = "0x60101F8")]
	[Address(RVA = "0xD46AF4", Offset = "0xD46AF4", VA = "0xD46AF4")]
	private void UpdateBanner(uint bannerId)
	{
	}

	[Token(Token = "0x60101F9")]
	[Address(RVA = "0xD46CA0", Offset = "0xD46CA0", VA = "0xD46CA0")]
	public void UpdateBanner(BannerData bannerdata, bool isBrief = false)
	{
	}

	[Token(Token = "0x60101FA")]
	[Address(RVA = "0xD46F2C", Offset = "0xD46F2C", VA = "0xD46F2C")]
	private void UpdatePlayerBasicInfo_P()
	{
	}

	[Token(Token = "0x60101FB")]
	[Address(RVA = "0xD473F8", Offset = "0xD473F8", VA = "0xD473F8")]
	private void UpdateBanner_P(uint bannerId)
	{
	}

	[Token(Token = "0x60101FC")]
	[Address(RVA = "0xD475A4", Offset = "0xD475A4", VA = "0xD475A4")]
	public void UpdateBanner_P(BannerData bannerdata, bool isBrief = false)
	{
	}

	[Token(Token = "0x60101FD")]
	[Address(RVA = "0xD47830", Offset = "0xD47830", VA = "0xD47830")]
	public void SetTarget(GameObject target, bool hasTopBar, bool hasLeftBar, bool isLandScape, float logoScale)
	{
	}

	[Token(Token = "0x60101FE")]
	[Address(RVA = "0xD4816C", Offset = "0xD4816C", VA = "0xD4816C")]
	public void UpdateSpecialLogo(string logoResource, bool isLandSpace, Vector3 adjustPosition, int adjustWidth = 0, int adjustHeight = 0)
	{
	}

	[Token(Token = "0x60101FF")]
	[Address(RVA = "0xD48418", Offset = "0xD48418", VA = "0xD48418")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
