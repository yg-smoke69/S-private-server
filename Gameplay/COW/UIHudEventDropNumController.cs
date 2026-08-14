using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002748")]
public class UIHudEventDropNumController : UIBaseController
{
	[Token(Token = "0x400F25F")]
	[FieldOffset(Offset = "0x28")]
	private UIHudEventDropNumView m_View;

	[Token(Token = "0x600EFAA")]
	[Address(RVA = "0x1B99C40", Offset = "0x1B99C40", VA = "0x1B99C40")]
	public UIHudEventDropNumController()
	{
	}

	[Token(Token = "0x600EFAB")]
	[Address(RVA = "0x1B99CC4", Offset = "0x1B99CC4", VA = "0x1B99CC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EFAC")]
	[Address(RVA = "0x1B99D68", Offset = "0x1B99D68", VA = "0x1B99D68", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EFAD")]
	[Address(RVA = "0x1B99F6C", Offset = "0x1B99F6C", VA = "0x1B99F6C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EFAE")]
	[Address(RVA = "0x1B9A0A0", Offset = "0x1B9A0A0", VA = "0x1B9A0A0")]
	private void OnPickUpEventZombieDropItem(object[] data)
	{
	}

	[Token(Token = "0x600EFAF")]
	[Address(RVA = "0x1B9A294", Offset = "0x1B9A294", VA = "0x1B9A294")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EFB0")]
	[Address(RVA = "0x1B9A29C", Offset = "0x1B9A29C", VA = "0x1B9A29C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
