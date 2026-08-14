using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002646")]
public class UIGachaLegendaryTempBagFullTipWndContoller : UIPopupWindowController
{
	[Token(Token = "0x400EC6B")]
	[FieldOffset(Offset = "0x48")]
	private uint m_GachaID;

	[Token(Token = "0x400EC6C")]
	[FieldOffset(Offset = "0x4C")]
	private UIGachaLegendaryTempBagFullTipWndView m_View;

	[Token(Token = "0x600E453")]
	[Address(RVA = "0x2E68AC4", Offset = "0x2E68AC4", VA = "0x2E68AC4")]
	public UIGachaLegendaryTempBagFullTipWndContoller()
	{
	}

	[Token(Token = "0x600E454")]
	[Address(RVA = "0x2E68ACC", Offset = "0x2E68ACC", VA = "0x2E68ACC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E455")]
	[Address(RVA = "0x2E68B70", Offset = "0x2E68B70", VA = "0x2E68B70", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E456")]
	[Address(RVA = "0x2E68CCC", Offset = "0x2E68CCC", VA = "0x2E68CCC")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x600E457")]
	[Address(RVA = "0x2E68E74", Offset = "0x2E68E74", VA = "0x2E68E74")]
	public void SetGachaID(uint gachaID)
	{
	}

	[Token(Token = "0x600E458")]
	[Address(RVA = "0x2E68ED4", Offset = "0x2E68ED4", VA = "0x2E68ED4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
