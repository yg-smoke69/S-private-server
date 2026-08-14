using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026E7")]
internal class UIHudBannerTweenTipsController : UIBaseController
{
	[Token(Token = "0x400F049")]
	[FieldOffset(Offset = "0x28")]
	private UIHudBannerTweenTipsView m_View;

	[Token(Token = "0x400F04A")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallID;

	[Token(Token = "0x400F04B")]
	[FieldOffset(Offset = "0x30")]
	private BannerTweenTipPriority m_Priority;

	[Token(Token = "0x400F04C")]
	[FieldOffset(Offset = "0x34")]
	private UITutorialIndicatorCharacterController m_CharacterCtrl;

	[Token(Token = "0x600EBC4")]
	[Address(RVA = "0x171FCE0", Offset = "0x171FCE0", VA = "0x171FCE0")]
	public UIHudBannerTweenTipsController()
	{
	}

	[Token(Token = "0x600EBC5")]
	[Address(RVA = "0x171FD64", Offset = "0x171FD64", VA = "0x171FD64", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600EBC6")]
	[Address(RVA = "0x171FEE0", Offset = "0x171FEE0", VA = "0x171FEE0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EBC7")]
	[Address(RVA = "0x171FF84", Offset = "0x171FF84", VA = "0x171FF84", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EBC8")]
	[Address(RVA = "0x1720048", Offset = "0x1720048", VA = "0x1720048", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600EBC9")]
	[Address(RVA = "0x17200AC", Offset = "0x17200AC", VA = "0x17200AC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EBCA")]
	[Address(RVA = "0x1720118", Offset = "0x1720118", VA = "0x1720118")]
	public void SetData(string message, BannerTweenTipPriority priority, bool showCharacter, float duration, bool show, ResourceID iconRes)
	{
	}

	[Token(Token = "0x600EBCB")]
	[Address(RVA = "0x172038C", Offset = "0x172038C", VA = "0x172038C")]
	private void RefreshData(string message, BannerTweenTipPriority priority, bool showCharacter, ResourceID iconRes)
	{
	}

	[Token(Token = "0x600EBCC")]
	[Address(RVA = "0x172079C", Offset = "0x172079C", VA = "0x172079C")]
	private void AutoHide()
	{
	}

	[Token(Token = "0x600EBCD")]
	[Address(RVA = "0x171FDD0", Offset = "0x171FDD0", VA = "0x171FDD0")]
	private void CancelDelayCall()
	{
	}

	[Token(Token = "0x600EBCE")]
	[Address(RVA = "0x1720998", Offset = "0x1720998", VA = "0x1720998")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x600EBCF")]
	[Address(RVA = "0x17209A0", Offset = "0x17209A0", VA = "0x17209A0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EBD0")]
	[Address(RVA = "0x17209A8", Offset = "0x17209A8", VA = "0x17209A8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600EBD1")]
	[Address(RVA = "0x17209B0", Offset = "0x17209B0", VA = "0x17209B0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
