using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023A6")]
internal class UIHUDSingersBFireController : UIHudFireController
{
	[Token(Token = "0x400DE03")]
	[FieldOffset(Offset = "0x78")]
	private uint m_DelayCancleFire;

	[Token(Token = "0x600C881")]
	[Address(RVA = "0x22127D8", Offset = "0x22127D8", VA = "0x22127D8")]
	public UIHUDSingersBFireController()
	{
	}

	[Token(Token = "0x600C882")]
	[Address(RVA = "0x22127E0", Offset = "0x22127E0", VA = "0x22127E0")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C883")]
	[Address(RVA = "0x2212884", Offset = "0x2212884", VA = "0x2212884", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C884")]
	[Address(RVA = "0x2212970", Offset = "0x2212970", VA = "0x2212970")]
	private void TriggerFire(object[] param)
	{
	}

	[Token(Token = "0x600C885")]
	[Address(RVA = "0x2212AF4", Offset = "0x2212AF4", VA = "0x2212AF4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
