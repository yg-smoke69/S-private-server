using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027EC")]
public class UIHudPartyGameSoloDanceSettlementController : UIBaseController
{
	[Token(Token = "0x400F66E")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPartyGameSoloDanceSettlementView m_View;

	[Token(Token = "0x400F66F")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallAutoClose;

	[Token(Token = "0x600F7B2")]
	[Address(RVA = "0x1841D20", Offset = "0x1841D20", VA = "0x1841D20")]
	public UIHudPartyGameSoloDanceSettlementController()
	{
	}

	[Token(Token = "0x600F7B3")]
	[Address(RVA = "0x1841DA4", Offset = "0x1841DA4", VA = "0x1841DA4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F7B4")]
	[Address(RVA = "0x1841E48", Offset = "0x1841E48", VA = "0x1841E48", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F7B5")]
	[Address(RVA = "0x1842020", Offset = "0x1842020", VA = "0x1842020", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F7B6")]
	[Address(RVA = "0x18421A0", Offset = "0x18421A0", VA = "0x18421A0")]
	private void CancelDelayCall()
	{
	}

	[Token(Token = "0x600F7B7")]
	[Address(RVA = "0x18422B0", Offset = "0x18422B0", VA = "0x18422B0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600F7B8")]
	[Address(RVA = "0x184231C", Offset = "0x184231C", VA = "0x184231C")]
	public void ShowSettlement(object data)
	{
	}

	[Token(Token = "0x600F7B9")]
	[Address(RVA = "0x18427D4", Offset = "0x18427D4", VA = "0x18427D4")]
	private void OnClickBtnSettlementBack()
	{
	}

	[Token(Token = "0x600F7BA")]
	[Address(RVA = "0x1842934", Offset = "0x1842934", VA = "0x1842934")]
	private void OnClickBtnSettlementPlayAgain()
	{
	}

	[Token(Token = "0x600F7BB")]
	[Address(RVA = "0x1842A94", Offset = "0x1842A94", VA = "0x1842A94")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F7BC")]
	[Address(RVA = "0x1842A9C", Offset = "0x1842A9C", VA = "0x1842A9C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F7BD")]
	[Address(RVA = "0x1842AA4", Offset = "0x1842AA4", VA = "0x1842AA4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
