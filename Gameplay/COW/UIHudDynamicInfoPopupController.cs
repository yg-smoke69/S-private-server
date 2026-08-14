using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002733")]
internal class UIHudDynamicInfoPopupController : UIBaseController
{
	[Token(Token = "0x400F1EB")]
	[FieldOffset(Offset = "0x28")]
	private UIHudDynamicInfoPopupView m_View;

	[Token(Token = "0x400F1EC")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallID;

	[Token(Token = "0x600EEAF")]
	[Address(RVA = "0x1CD8908", Offset = "0x1CD8908", VA = "0x1CD8908")]
	public UIHudDynamicInfoPopupController()
	{
	}

	[Token(Token = "0x600EEB0")]
	[Address(RVA = "0x1CD898C", Offset = "0x1CD898C", VA = "0x1CD898C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EEB1")]
	[Address(RVA = "0x1CD8A30", Offset = "0x1CD8A30", VA = "0x1CD8A30", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EEB2")]
	[Address(RVA = "0x1CD8AEC", Offset = "0x1CD8AEC", VA = "0x1CD8AEC", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600EEB3")]
	[Address(RVA = "0x1CD8B50", Offset = "0x1CD8B50", VA = "0x1CD8B50", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EEB4")]
	[Address(RVA = "0x1CD8CCC", Offset = "0x1CD8CCC", VA = "0x1CD8CCC")]
	public void SetMessage(string message, float duration)
	{
	}

	[Token(Token = "0x600EEB5")]
	[Address(RVA = "0x1CD8E94", Offset = "0x1CD8E94", VA = "0x1CD8E94")]
	private void AutoHide()
	{
	}

	[Token(Token = "0x600EEB6")]
	[Address(RVA = "0x1CD8BBC", Offset = "0x1CD8BBC", VA = "0x1CD8BBC")]
	private void CancelDelayCall()
	{
	}

	[Token(Token = "0x600EEB7")]
	[Address(RVA = "0x1CD8FA4", Offset = "0x1CD8FA4", VA = "0x1CD8FA4", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600EEB8")]
	[Address(RVA = "0x1CD9010", Offset = "0x1CD9010", VA = "0x1CD9010")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EEB9")]
	[Address(RVA = "0x1CD9018", Offset = "0x1CD9018", VA = "0x1CD9018")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600EEBA")]
	[Address(RVA = "0x1CD9020", Offset = "0x1CD9020", VA = "0x1CD9020")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600EEBB")]
	[Address(RVA = "0x1CD9028", Offset = "0x1CD9028", VA = "0x1CD9028")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
