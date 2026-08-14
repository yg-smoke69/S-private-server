using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200288F")]
internal class UIHudTutorialGamePopupWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400F9B9")]
	[FieldOffset(Offset = "0x48")]
	private UIHudTutorialGamePopupWndView m_View;

	[Token(Token = "0x400F9BA")]
	[FieldOffset(Offset = "0x4C")]
	private LOCIDJPIMLO.HAJCBCOPDLI m_TutorialPopUpType;

	[Token(Token = "0x400F9BB")]
	[FieldOffset(Offset = "0x50")]
	private new UIPopupGlassBG m_Glass;

	[Token(Token = "0x400F9BC")]
	private const int COUNTDOWN = 15;

	[Token(Token = "0x400F9BD")]
	[FieldOffset(Offset = "0x54")]
	private bool m_IsGridInitiated;

	[Token(Token = "0x600FE8E")]
	[Address(RVA = "0x158EC10", Offset = "0x158EC10", VA = "0x158EC10")]
	public UIHudTutorialGamePopupWndController()
	{
	}

	[Token(Token = "0x600FE8F")]
	[Address(RVA = "0x158EC18", Offset = "0x158EC18", VA = "0x158EC18")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FE90")]
	[Address(RVA = "0x158ECC0", Offset = "0x158ECC0", VA = "0x158ECC0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FE91")]
	[Address(RVA = "0x158F20C", Offset = "0x158F20C", VA = "0x158F20C", Slot = "22")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600FE92")]
	[Address(RVA = "0x158F324", Offset = "0x158F324", VA = "0x158F324", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600FE93")]
	[Address(RVA = "0x158F4D8", Offset = "0x158F4D8", VA = "0x158F4D8", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600FE94")]
	[Address(RVA = "0x158F99C", Offset = "0x158F99C", VA = "0x158F99C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600FE95")]
	[Address(RVA = "0x158FA30", Offset = "0x158FA30", VA = "0x158FA30")]
	private void OnMaskClick()
	{
	}

	[Token(Token = "0x600FE96")]
	[Address(RVA = "0x158FAA8", Offset = "0x158FAA8", VA = "0x158FAA8")]
	private void OnContinueClick()
	{
	}

	[Token(Token = "0x600FE97")]
	[Address(RVA = "0x158FC18", Offset = "0x158FC18", VA = "0x158FC18")]
	private void OnLeaveClick()
	{
	}

	[Token(Token = "0x600FE98")]
	[Address(RVA = "0x158FC84", Offset = "0x158FC84", VA = "0x158FC84")]
	public void UpdateBGBlur()
	{
	}

	[Token(Token = "0x600FE99")]
	[Address(RVA = "0x158F5B0", Offset = "0x158F5B0", VA = "0x158F5B0")]
	private void SetGridData()
	{
	}

	[Token(Token = "0x600FE9A")]
	[Address(RVA = "0x158FCFC", Offset = "0x158FCFC", VA = "0x158FCFC")]
	public void ShowWelcomeContent()
	{
	}

	[Token(Token = "0x600FE9B")]
	[Address(RVA = "0x15900B4", Offset = "0x15900B4", VA = "0x15900B4")]
	public void ShowExitContent()
	{
	}

	[Token(Token = "0x600FE9C")]
	[Address(RVA = "0x159046C", Offset = "0x159046C", VA = "0x159046C")]
	public void ShowEndContent()
	{
	}

	[Token(Token = "0x600FE9D")]
	[Address(RVA = "0x15909F4", Offset = "0x15909F4", VA = "0x15909F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FE9E")]
	[Address(RVA = "0x15909FC", Offset = "0x15909FC", VA = "0x15909FC")]
	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	[Token(Token = "0x600FE9F")]
	[Address(RVA = "0x1590A04", Offset = "0x1590A04", VA = "0x1590A04")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
