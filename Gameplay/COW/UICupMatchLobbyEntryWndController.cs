using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002070")]
public class UICupMatchLobbyEntryWndController : UIPopupWindowController
{
	[Token(Token = "0x400CB6D")]
	[FieldOffset(Offset = "0x48")]
	private UICupMatchLobbyEntryWndView m_View;

	[Token(Token = "0x400CB6E")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelCupMatch m_Model;

	[Token(Token = "0x400CB6F")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsPreCupMatch;

	[Token(Token = "0x400CB70")]
	[FieldOffset(Offset = "0x54")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CB71")]
	private const int SHOWED = 1;

	[Token(Token = "0x400CB72")]
	private const string NO_CDN_RESOURCE = "0";

	[Token(Token = "0x600A665")]
	[Address(RVA = "0x2AA4E44", Offset = "0x2AA4E44", VA = "0x2AA4E44")]
	public UICupMatchLobbyEntryWndController()
	{
	}

	[Token(Token = "0x600A666")]
	[Address(RVA = "0x2AA4E4C", Offset = "0x2AA4E4C", VA = "0x2AA4E4C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A667")]
	[Address(RVA = "0x2AA4EF4", Offset = "0x2AA4EF4", VA = "0x2AA4EF4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A668")]
	[Address(RVA = "0x2AA5174", Offset = "0x2AA5174", VA = "0x2AA5174")]
	public void SetViewData(int cupMatchKey, bool isPreCupMatch, bool isSameYear)
	{
	}

	[Token(Token = "0x600A669")]
	[Address(RVA = "0x2AA5CDC", Offset = "0x2AA5CDC", VA = "0x2AA5CDC")]
	private void OnBtnCupMatchClick()
	{
	}

	[Token(Token = "0x600A66A")]
	[Address(RVA = "0x2AA5F48", Offset = "0x2AA5F48", VA = "0x2AA5F48")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x600A66B")]
	[Address(RVA = "0x2AA5ED4", Offset = "0x2AA5ED4", VA = "0x2AA5ED4")]
	private uint GetAnimationType()
	{
		return default(uint);
	}

	[Token(Token = "0x600A66C")]
	[Address(RVA = "0x2AA6068", Offset = "0x2AA6068", VA = "0x2AA6068")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
