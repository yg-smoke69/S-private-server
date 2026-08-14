using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002964")]
public class UILuckyWheelPurchaseController : UIPopupWindowController
{
	[Token(Token = "0x400FF21")]
	[FieldOffset(Offset = "0x48")]
	private UILuckyWheelPurchaseView m_View;

	[Token(Token = "0x400FF22")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelLuckyWheel m_Model;

	[Token(Token = "0x400FF23")]
	[FieldOffset(Offset = "0x50")]
	private uint m_ID;

	[Token(Token = "0x6010964")]
	[Address(RVA = "0x18CD2E4", Offset = "0x18CD2E4", VA = "0x18CD2E4")]
	public UILuckyWheelPurchaseController()
	{
	}

	[Token(Token = "0x6010965")]
	[Address(RVA = "0x18CD2EC", Offset = "0x18CD2EC", VA = "0x18CD2EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010966")]
	[Address(RVA = "0x18CD394", Offset = "0x18CD394", VA = "0x18CD394", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010967")]
	[Address(RVA = "0x18CD560", Offset = "0x18CD560", VA = "0x18CD560")]
	public void SetViewData(BaseItemInfo info, uint id, uint price)
	{
	}

	[Token(Token = "0x6010968")]
	[Address(RVA = "0x18CD81C", Offset = "0x18CD81C", VA = "0x18CD81C")]
	private void OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x6010969")]
	[Address(RVA = "0x18CD8A8", Offset = "0x18CD8A8", VA = "0x18CD8A8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
