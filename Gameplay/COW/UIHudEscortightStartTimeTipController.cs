using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002742")]
public class UIHudEscortightStartTimeTipController : UIBaseController
{
	[Token(Token = "0x400F242")]
	[FieldOffset(Offset = "0x28")]
	private UIHudEscortFightStartTimeTipView m_View;

	[Token(Token = "0x400F243")]
	[FieldOffset(Offset = "0x2C")]
	private int lastLeftTimeS;

	[Token(Token = "0x600EF73")]
	[Address(RVA = "0x1B99674", Offset = "0x1B99674", VA = "0x1B99674")]
	public UIHudEscortightStartTimeTipController()
	{
	}

	[Token(Token = "0x600EF74")]
	[Address(RVA = "0x1B99700", Offset = "0x1B99700", VA = "0x1B99700")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EF75")]
	[Address(RVA = "0x1B997A8", Offset = "0x1B997A8", VA = "0x1B997A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EF76")]
	[Address(RVA = "0x1B99864", Offset = "0x1B99864", VA = "0x1B99864")]
	private void Update()
	{
	}

	[Token(Token = "0x600EF77")]
	[Address(RVA = "0x1B99C38", Offset = "0x1B99C38", VA = "0x1B99C38")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
