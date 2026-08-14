using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200203D")]
internal class UIHudCSCoinController : UIBaseController
{
	[Token(Token = "0x400CA2A")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCSCoinView m_View;

	[Token(Token = "0x600A3B2")]
	[Address(RVA = "0x1EFEFB4", Offset = "0x1EFEFB4", VA = "0x1EFEFB4")]
	public UIHudCSCoinController()
	{
	}

	[Token(Token = "0x600A3B3")]
	[Address(RVA = "0x1EFF038", Offset = "0x1EFF038", VA = "0x1EFF038")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A3B4")]
	[Address(RVA = "0x1EFF0E0", Offset = "0x1EFF0E0", VA = "0x1EFF0E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A3B5")]
	[Address(RVA = "0x1EFF2DC", Offset = "0x1EFF2DC", VA = "0x1EFF2DC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600A3B6")]
	[Address(RVA = "0x1EFF478", Offset = "0x1EFF478", VA = "0x1EFF478")]
	private void OnCurCoinChanged(object[] data)
	{
	}

	[Token(Token = "0x600A3B7")]
	[Address(RVA = "0x1EFF5B8", Offset = "0x1EFF5B8", VA = "0x1EFF5B8")]
	private void OnSpectatorTargetChanged(object[] data)
	{
	}

	[Token(Token = "0x600A3B8")]
	[Address(RVA = "0x1EFF9C4", Offset = "0x1EFF9C4", VA = "0x1EFF9C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A3B9")]
	[Address(RVA = "0x1EFF9CC", Offset = "0x1EFF9CC", VA = "0x1EFF9CC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
