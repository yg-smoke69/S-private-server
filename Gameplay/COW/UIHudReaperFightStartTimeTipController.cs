using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022CE")]
public class UIHudReaperFightStartTimeTipController : UIBaseController
{
	[Token(Token = "0x400D97A")]
	[FieldOffset(Offset = "0x28")]
	private UIHudReaperFightStartTimeTipView m_View;

	[Token(Token = "0x400D97B")]
	[FieldOffset(Offset = "0x2C")]
	private int lastLeftTimeS;

	[Token(Token = "0x600BFC2")]
	[Address(RVA = "0x1FDAB68", Offset = "0x1FDAB68", VA = "0x1FDAB68")]
	public UIHudReaperFightStartTimeTipController()
	{
	}

	[Token(Token = "0x600BFC3")]
	[Address(RVA = "0x1FDABF4", Offset = "0x1FDABF4", VA = "0x1FDABF4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BFC4")]
	[Address(RVA = "0x1FDAC9C", Offset = "0x1FDAC9C", VA = "0x1FDAC9C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BFC5")]
	[Address(RVA = "0x1FDAD58", Offset = "0x1FDAD58", VA = "0x1FDAD58")]
	private void Update()
	{
	}

	[Token(Token = "0x600BFC6")]
	[Address(RVA = "0x1FDB28C", Offset = "0x1FDB28C", VA = "0x1FDB28C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
