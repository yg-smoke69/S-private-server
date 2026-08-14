using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200270C")]
internal class UIHudCombineWeaponController : UIHudButtonBaseController
{
	[Token(Token = "0x400F100")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudCombineWeaponView m_View;

	[Token(Token = "0x400F101")]
	[FieldOffset(Offset = "0x30")]
	private bool m_CanCombine;

	[Token(Token = "0x600ED3E")]
	[Address(RVA = "0x135CCBC", Offset = "0x135CCBC", VA = "0x135CCBC")]
	public UIHudCombineWeaponController()
	{
	}

	[Token(Token = "0x600ED3F")]
	[Address(RVA = "0x135CCC4", Offset = "0x135CCC4", VA = "0x135CCC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ED40")]
	[Address(RVA = "0x135CD6C", Offset = "0x135CD6C", VA = "0x135CD6C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ED41")]
	[Address(RVA = "0x135D034", Offset = "0x135D034", VA = "0x135D034", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600ED42")]
	[Address(RVA = "0x135D238", Offset = "0x135D238", VA = "0x135D238")]
	private void OnCanCombineChanged(object[] param)
	{
	}

	[Token(Token = "0x600ED43")]
	[Address(RVA = "0x135D414", Offset = "0x135D414", VA = "0x135D414")]
	private void OnSightingStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600ED44")]
	[Address(RVA = "0x135D55C", Offset = "0x135D55C", VA = "0x135D55C")]
	private void OnCombineStatusChanged(object[] param)
	{
	}

	[Token(Token = "0x600ED45")]
	[Address(RVA = "0x135D6C0", Offset = "0x135D6C0", VA = "0x135D6C0", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600ED46")]
	[Address(RVA = "0x135D764", Offset = "0x135D764", VA = "0x135D764")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ED47")]
	[Address(RVA = "0x135D76C", Offset = "0x135D76C", VA = "0x135D76C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
