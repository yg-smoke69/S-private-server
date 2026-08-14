using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200268A")]
public class UILengendGachaPreviewPopWndController : UIPopupWindowController
{
	[Token(Token = "0x400EDDE")]
	[FieldOffset(Offset = "0x48")]
	private UILengendGachaPreviewPopWndView m_View;

	[Token(Token = "0x400EDDF")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelGacha m_Model;

	[Token(Token = "0x400EDE0")]
	[FieldOffset(Offset = "0x50")]
	private uint m_GachaID;

	[Token(Token = "0x600E756")]
	[Address(RVA = "0x2549344", Offset = "0x2549344", VA = "0x2549344")]
	public UILengendGachaPreviewPopWndController()
	{
	}

	[Token(Token = "0x600E757")]
	[Address(RVA = "0x254934C", Offset = "0x254934C", VA = "0x254934C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E758")]
	[Address(RVA = "0x25493F0", Offset = "0x25493F0", VA = "0x25493F0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E759")]
	[Address(RVA = "0x2549650", Offset = "0x2549650", VA = "0x2549650", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E75A")]
	[Address(RVA = "0x2549768", Offset = "0x2549768", VA = "0x2549768", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600E75B")]
	[Address(RVA = "0x254989C", Offset = "0x254989C", VA = "0x254989C")]
	public void SetGachaID(uint gachaID)
	{
	}

	[Token(Token = "0x600E75C")]
	[Address(RVA = "0x2549908", Offset = "0x2549908", VA = "0x2549908")]
	private void ShowView()
	{
	}

	[Token(Token = "0x600E75D")]
	[Address(RVA = "0x254A06C", Offset = "0x254A06C", VA = "0x254A06C")]
	private void OnBtnProbabilityClick()
	{
	}

	[Token(Token = "0x600E75E")]
	[Address(RVA = "0x254A198", Offset = "0x254A198", VA = "0x254A198")]
	private void ShowRareProbabilityTips(object[] param)
	{
	}

	[Token(Token = "0x600E75F")]
	[Address(RVA = "0x254A640", Offset = "0x254A640", VA = "0x254A640")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E760")]
	[Address(RVA = "0x254A648", Offset = "0x254A648", VA = "0x254A648")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E761")]
	[Address(RVA = "0x254A650", Offset = "0x254A650", VA = "0x254A650")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
