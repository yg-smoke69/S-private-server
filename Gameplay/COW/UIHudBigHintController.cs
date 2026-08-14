using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026EF")]
internal class UIHudBigHintController : UIBaseController
{
	[Token(Token = "0x400F06B")]
	[FieldOffset(Offset = "0x28")]
	private UIHudBigHintView m_View;

	[Token(Token = "0x400F06C")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallID;

	[Token(Token = "0x600EC10")]
	[Address(RVA = "0x1DFF5DC", Offset = "0x1DFF5DC", VA = "0x1DFF5DC")]
	public UIHudBigHintController()
	{
	}

	[Token(Token = "0x600EC11")]
	[Address(RVA = "0x1DFF660", Offset = "0x1DFF660", VA = "0x1DFF660")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EC12")]
	[Address(RVA = "0x1DFF708", Offset = "0x1DFF708", VA = "0x1DFF708", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EC13")]
	[Address(RVA = "0x1DFF7C4", Offset = "0x1DFF7C4", VA = "0x1DFF7C4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600EC14")]
	[Address(RVA = "0x1DFF828", Offset = "0x1DFF828", VA = "0x1DFF828", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EC15")]
	[Address(RVA = "0x1DFF9A4", Offset = "0x1DFF9A4", VA = "0x1DFF9A4")]
	public void SetMessage(string message, float duration, int offset)
	{
	}

	[Token(Token = "0x600EC16")]
	[Address(RVA = "0x1DFFAF0", Offset = "0x1DFFAF0", VA = "0x1DFFAF0")]
	private void SetData(string message, float duration)
	{
	}

	[Token(Token = "0x600EC17")]
	[Address(RVA = "0x1DFFCB8", Offset = "0x1DFFCB8", VA = "0x1DFFCB8")]
	private void AutoHide()
	{
	}

	[Token(Token = "0x600EC18")]
	[Address(RVA = "0x1DFF894", Offset = "0x1DFF894", VA = "0x1DFF894")]
	private void CancelDelayCall()
	{
	}

	[Token(Token = "0x600EC19")]
	[Address(RVA = "0x1DFFDC8", Offset = "0x1DFFDC8", VA = "0x1DFFDC8", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600EC1A")]
	[Address(RVA = "0x1DFFE34", Offset = "0x1DFFE34", VA = "0x1DFFE34")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EC1B")]
	[Address(RVA = "0x1DFFE3C", Offset = "0x1DFFE3C", VA = "0x1DFFE3C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600EC1C")]
	[Address(RVA = "0x1DFFE44", Offset = "0x1DFFE44", VA = "0x1DFFE44")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600EC1D")]
	[Address(RVA = "0x1DFFE4C", Offset = "0x1DFFE4C", VA = "0x1DFFE4C")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
