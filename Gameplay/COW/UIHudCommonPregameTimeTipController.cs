using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022AC")]
public class UIHudCommonPregameTimeTipController : UIBaseController
{
	[Token(Token = "0x400D8FD")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCommonPregameTimeTipView m_View;

	[Token(Token = "0x400D8FE")]
	[FieldOffset(Offset = "0x2C")]
	private int lastLeftTimeS;

	[Token(Token = "0x600BE9D")]
	[Address(RVA = "0x135F2AC", Offset = "0x135F2AC", VA = "0x135F2AC")]
	public UIHudCommonPregameTimeTipController()
	{
	}

	[Token(Token = "0x600BE9E")]
	[Address(RVA = "0x135F338", Offset = "0x135F338", VA = "0x135F338")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BE9F")]
	[Address(RVA = "0x135F3E0", Offset = "0x135F3E0", VA = "0x135F3E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BEA0")]
	[Address(RVA = "0x135F49C", Offset = "0x135F49C", VA = "0x135F49C")]
	private void Update()
	{
	}

	[Token(Token = "0x600BEA1")]
	[Address(RVA = "0x135F9C0", Offset = "0x135F9C0", VA = "0x135F9C0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
