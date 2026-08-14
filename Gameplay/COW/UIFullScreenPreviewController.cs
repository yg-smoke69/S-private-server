using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002629")]
internal class UIFullScreenPreviewController : UIPreviewPopUpWindowController
{
	[Token(Token = "0x200262A")]
	private sealed class _003CGetAdvertDescByType_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EBBB")]
		[FieldOffset(Offset = "0x8")]
		internal int type;

		[Token(Token = "0x600E2AF")]
		[Address(RVA = "0x265A438", Offset = "0x265A438", VA = "0x265A438")]
		public _003CGetAdvertDescByType_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E2B0")]
		[Address(RVA = "0x265A4C0", Offset = "0x265A4C0", VA = "0x265A4C0")]
		internal bool _003C_003Em__0(AdvertDesc ad)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400EBB3")]
	[FieldOffset(Offset = "0x5C")]
	private UIFullScreenPreviewView m_View;

	[Token(Token = "0x400EBB4")]
	[FieldOffset(Offset = "0x60")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x400EBB5")]
	[FieldOffset(Offset = "0x64")]
	private uint m_ItemID;

	[Token(Token = "0x400EBB6")]
	[FieldOffset(Offset = "0x68")]
	private UIModelCDNAd m_ModelCDNAd;

	[Token(Token = "0x400EBB7")]
	[FieldOffset(Offset = "0x6C")]
	private List<AdvertDesc> adList;

	[Token(Token = "0x400EBB8")]
	private const int DEFAULT = 1;

	[Token(Token = "0x400EBB9")]
	private const int PET = 2;

	[Token(Token = "0x400EBBA")]
	private const int WEAPON = 3;

	[Token(Token = "0x600E29D")]
	[Address(RVA = "0x2659788", Offset = "0x2659788", VA = "0x2659788")]
	public UIFullScreenPreviewController()
	{
	}

	[Token(Token = "0x600E29E")]
	[Address(RVA = "0x2659790", Offset = "0x2659790", VA = "0x2659790")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E29F")]
	[Address(RVA = "0x2659838", Offset = "0x2659838", VA = "0x2659838", Slot = "46")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600E2A0")]
	[Address(RVA = "0x2659890", Offset = "0x2659890", VA = "0x2659890", Slot = "47")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600E2A1")]
	[Address(RVA = "0x2659900", Offset = "0x2659900", VA = "0x2659900", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E2A2")]
	[Address(RVA = "0x2659B0C", Offset = "0x2659B0C", VA = "0x2659B0C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600E2A3")]
	[Address(RVA = "0x2659C00", Offset = "0x2659C00", VA = "0x2659C00", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600E2A4")]
	[Address(RVA = "0x2659D08", Offset = "0x2659D08", VA = "0x2659D08")]
	private void RefreshBG()
	{
	}

	[Token(Token = "0x600E2A5")]
	[Address(RVA = "0x265A0E8", Offset = "0x265A0E8", VA = "0x265A0E8")]
	public void SetPreviewInfo(uint itemID)
	{
	}

	[Token(Token = "0x600E2A6")]
	[Address(RVA = "0x265A1A8", Offset = "0x265A1A8", VA = "0x265A1A8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E2A7")]
	[Address(RVA = "0x2659F58", Offset = "0x2659F58", VA = "0x2659F58")]
	private string GetCDNBgURLByType(uint itemID)
	{
		return null;
	}

	[Token(Token = "0x600E2A8")]
	[Address(RVA = "0x265A2C0", Offset = "0x265A2C0", VA = "0x265A2C0")]
	private AdvertDesc GetAdvertDescByType(int type)
	{
		return null;
	}

	[Token(Token = "0x600E2A9")]
	[Address(RVA = "0x265A440", Offset = "0x265A440", VA = "0x265A440", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600E2AA")]
	[Address(RVA = "0x265A498", Offset = "0x265A498", VA = "0x265A498")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E2AB")]
	[Address(RVA = "0x265A4A0", Offset = "0x265A4A0", VA = "0x265A4A0")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600E2AC")]
	[Address(RVA = "0x265A4A8", Offset = "0x265A4A8", VA = "0x265A4A8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600E2AD")]
	[Address(RVA = "0x265A4B0", Offset = "0x265A4B0", VA = "0x265A4B0")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E2AE")]
	[Address(RVA = "0x265A4B8", Offset = "0x265A4B8", VA = "0x265A4B8")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}
}
