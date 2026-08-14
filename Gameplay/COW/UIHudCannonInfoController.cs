using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002701")]
internal class UIHudCannonInfoController : UIBaseController
{
	[Token(Token = "0x400F0B3")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCannonInfoView m_View;

	[Token(Token = "0x400F0B4")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsInCannon;

	[Token(Token = "0x400F0B5")]
	[FieldOffset(Offset = "0x30")]
	private int m_CannonTotalShot;

	[Token(Token = "0x400F0B6")]
	[FieldOffset(Offset = "0x34")]
	private int m_CurrentCannonShot;

	[Token(Token = "0x600ECF0")]
	[Address(RVA = "0x2146210", Offset = "0x2146210", VA = "0x2146210")]
	public UIHudCannonInfoController()
	{
	}

	[Token(Token = "0x600ECF1")]
	[Address(RVA = "0x2146294", Offset = "0x2146294", VA = "0x2146294")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ECF2")]
	[Address(RVA = "0x2146338", Offset = "0x2146338", VA = "0x2146338", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ECF3")]
	[Address(RVA = "0x21464E4", Offset = "0x21464E4", VA = "0x21464E4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600ECF4")]
	[Address(RVA = "0x2146680", Offset = "0x2146680", VA = "0x2146680")]
	private void Update()
	{
	}

	[Token(Token = "0x600ECF5")]
	[Address(RVA = "0x2146B18", Offset = "0x2146B18", VA = "0x2146B18")]
	protected void OnPlayerInOrOutCannon(object[] data)
	{
	}

	[Token(Token = "0x600ECF6")]
	[Address(RVA = "0x2146960", Offset = "0x2146960", VA = "0x2146960")]
	private bool ShouldUpdateCannon(Player player)
	{
		return default(bool);
	}

	[Token(Token = "0x600ECF7")]
	[Address(RVA = "0x2146F48", Offset = "0x2146F48", VA = "0x2146F48")]
	private void SetVisibleState(object[] data)
	{
	}

	[Token(Token = "0x600ECF8")]
	[Address(RVA = "0x21471F8", Offset = "0x21471F8", VA = "0x21471F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ECF9")]
	[Address(RVA = "0x2147200", Offset = "0x2147200", VA = "0x2147200")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
