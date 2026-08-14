using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002966")]
public class UILuckyWheelRuleShowWndController : UIPopupWindowController
{
	[Token(Token = "0x400FF28")]
	[FieldOffset(Offset = "0x48")]
	private UILuckyWheelRuleShowWndView m_View;

	[Token(Token = "0x400FF29")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelLuckyWheel m_Model;

	[Token(Token = "0x6010972")]
	[Address(RVA = "0x18CE698", Offset = "0x18CE698", VA = "0x18CE698")]
	public UILuckyWheelRuleShowWndController()
	{
	}

	[Token(Token = "0x6010973")]
	[Address(RVA = "0x18CE6A0", Offset = "0x18CE6A0", VA = "0x18CE6A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010974")]
	[Address(RVA = "0x18CE748", Offset = "0x18CE748", VA = "0x18CE748", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010975")]
	[Address(RVA = "0x18CE87C", Offset = "0x18CE87C", VA = "0x18CE87C")]
	public void SetViewData()
	{
	}

	[Token(Token = "0x6010976")]
	[Address(RVA = "0x18CF478", Offset = "0x18CF478", VA = "0x18CF478")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
