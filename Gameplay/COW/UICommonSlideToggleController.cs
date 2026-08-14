using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025A4")]
internal class UICommonSlideToggleController : UIBaseController
{
	[Token(Token = "0x400E8C9")]
	[FieldOffset(Offset = "0x28")]
	private UICommonSlideToggleView m_View;

	[Token(Token = "0x400E8CA")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_AnimPlaying;

	[Token(Token = "0x400E8CB")]
	[FieldOffset(Offset = "0x30")]
	private uint m_AnimDelayCall;

	[Token(Token = "0x600DC44")]
	[Address(RVA = "0x1EB9028", Offset = "0x1EB9028", VA = "0x1EB9028")]
	public UICommonSlideToggleController()
	{
	}

	[Token(Token = "0x600DC45")]
	[Address(RVA = "0x1EB90AC", Offset = "0x1EB90AC", VA = "0x1EB90AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DC46")]
	[Address(RVA = "0x1EB9154", Offset = "0x1EB9154", VA = "0x1EB9154", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DC47")]
	[Address(RVA = "0x1EB9210", Offset = "0x1EB9210", VA = "0x1EB9210", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DC48")]
	[Address(RVA = "0x1EB9318", Offset = "0x1EB9318", VA = "0x1EB9318")]
	public void BindBtns(UIButton btnLeft, UIButton btnRight, UILabel labelLeft, UILabel labelRight)
	{
	}

	[Token(Token = "0x600DC49")]
	[Address(RVA = "0x1EB96B0", Offset = "0x1EB96B0", VA = "0x1EB96B0")]
	private void OnToggleClick(bool left)
	{
	}

	[Token(Token = "0x600DC4A")]
	[Address(RVA = "0x1EB9A3C", Offset = "0x1EB9A3C", VA = "0x1EB9A3C")]
	private void Update()
	{
	}

	[Token(Token = "0x600DC4B")]
	[Address(RVA = "0x1EB9C00", Offset = "0x1EB9C00", VA = "0x1EB9C00")]
	private void _003CBindBtns_003Em__0()
	{
	}

	[Token(Token = "0x600DC4C")]
	[Address(RVA = "0x1EB9C08", Offset = "0x1EB9C08", VA = "0x1EB9C08")]
	private void _003CBindBtns_003Em__1()
	{
	}

	[Token(Token = "0x600DC4D")]
	[Address(RVA = "0x1EB9C10", Offset = "0x1EB9C10", VA = "0x1EB9C10")]
	private void _003COnToggleClick_003Em__2()
	{
	}

	[Token(Token = "0x600DC4E")]
	[Address(RVA = "0x1EB9C20", Offset = "0x1EB9C20", VA = "0x1EB9C20")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DC4F")]
	[Address(RVA = "0x1EB9C28", Offset = "0x1EB9C28", VA = "0x1EB9C28")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
