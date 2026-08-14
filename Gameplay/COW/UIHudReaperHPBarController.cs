using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022CF")]
public class UIHudReaperHPBarController : UIBaseController
{
	[Token(Token = "0x400D97C")]
	[FieldOffset(Offset = "0x28")]
	private UIHudReaperHPBarView m_View;

	[Token(Token = "0x600BFC7")]
	[Address(RVA = "0x1FDB44C", Offset = "0x1FDB44C", VA = "0x1FDB44C")]
	public UIHudReaperHPBarController()
	{
	}

	[Token(Token = "0x600BFC8")]
	[Address(RVA = "0x1FDB4D0", Offset = "0x1FDB4D0", VA = "0x1FDB4D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BFC9")]
	[Address(RVA = "0x1FDB578", Offset = "0x1FDB578", VA = "0x1FDB578", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BFCA")]
	[Address(RVA = "0x1FDB66C", Offset = "0x1FDB66C", VA = "0x1FDB66C")]
	public void UpdateHP(int oldV, int newV)
	{
	}

	[Token(Token = "0x600BFCB")]
	[Address(RVA = "0x1FDB7C0", Offset = "0x1FDB7C0", VA = "0x1FDB7C0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
