using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002822")]
public class UIHudRebornIntroInfoController : UIBaseController
{
	[Token(Token = "0x400F7B5")]
	[FieldOffset(Offset = "0x28")]
	private UIHudDGGIntroInfoView m_View;

	[Token(Token = "0x400F7B6")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallId;

	[Token(Token = "0x600FA15")]
	[Address(RVA = "0x13DAC2C", Offset = "0x13DAC2C", VA = "0x13DAC2C")]
	public UIHudRebornIntroInfoController()
	{
	}

	[Token(Token = "0x600FA16")]
	[Address(RVA = "0x13DACB0", Offset = "0x13DACB0", VA = "0x13DACB0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FA17")]
	[Address(RVA = "0x13DAD54", Offset = "0x13DAD54", VA = "0x13DAD54", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FA18")]
	[Address(RVA = "0x13DAEF0", Offset = "0x13DAEF0", VA = "0x13DAEF0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FA19")]
	[Address(RVA = "0x13DB00C", Offset = "0x13DB00C", VA = "0x13DB00C")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600FA1A")]
	[Address(RVA = "0x13DB0E4", Offset = "0x13DB0E4", VA = "0x13DB0E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FA1B")]
	[Address(RVA = "0x13DB0EC", Offset = "0x13DB0EC", VA = "0x13DB0EC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
