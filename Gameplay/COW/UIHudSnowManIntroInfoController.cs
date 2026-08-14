using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002855")]
public class UIHudSnowManIntroInfoController : UIBaseController
{
	[Token(Token = "0x400F8D0")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSnowManIntorInfoView m_View;

	[Token(Token = "0x400F8D1")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallId;

	[Token(Token = "0x600FC40")]
	[Address(RVA = "0x1FDCDD8", Offset = "0x1FDCDD8", VA = "0x1FDCDD8")]
	public UIHudSnowManIntroInfoController()
	{
	}

	[Token(Token = "0x600FC41")]
	[Address(RVA = "0x1FDCE5C", Offset = "0x1FDCE5C", VA = "0x1FDCE5C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FC42")]
	[Address(RVA = "0x1FDCF00", Offset = "0x1FDCF00", VA = "0x1FDCF00", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FC43")]
	[Address(RVA = "0x1FDD09C", Offset = "0x1FDD09C", VA = "0x1FDD09C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FC44")]
	[Address(RVA = "0x1FDD1B8", Offset = "0x1FDD1B8", VA = "0x1FDD1B8")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600FC45")]
	[Address(RVA = "0x1FDD1C8", Offset = "0x1FDD1C8", VA = "0x1FDD1C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FC46")]
	[Address(RVA = "0x1FDD1D0", Offset = "0x1FDD1D0", VA = "0x1FDD1D0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
