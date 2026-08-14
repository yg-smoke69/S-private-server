using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002797")]
internal class UIHudJetFlyController : UIHudButtonBaseController
{
	[Token(Token = "0x400F481")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudJetFlyView m_View;

	[Token(Token = "0x600F3F6")]
	[Address(RVA = "0x20B0E8C", Offset = "0x20B0E8C", VA = "0x20B0E8C")]
	public UIHudJetFlyController()
	{
	}

	[Token(Token = "0x600F3F7")]
	[Address(RVA = "0x20B0E94", Offset = "0x20B0E94", VA = "0x20B0E94")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F3F8")]
	[Address(RVA = "0x20B0F3C", Offset = "0x20B0F3C", VA = "0x20B0F3C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F3F9")]
	[Address(RVA = "0x20B1188", Offset = "0x20B1188", VA = "0x20B1188", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F3FA")]
	[Address(RVA = "0x20B1324", Offset = "0x20B1324", VA = "0x20B1324", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600F3FB")]
	[Address(RVA = "0x20B13C8", Offset = "0x20B13C8", VA = "0x20B13C8")]
	private void Update()
	{
	}

	[Token(Token = "0x600F3FC")]
	[Address(RVA = "0x20B198C", Offset = "0x20B198C", VA = "0x20B198C")]
	private void OnEnergyChange(object[] data)
	{
	}

	[Token(Token = "0x600F3FD")]
	[Address(RVA = "0x20B1B34", Offset = "0x20B1B34", VA = "0x20B1B34")]
	private void OnShow(object[] data)
	{
	}

	[Token(Token = "0x600F3FE")]
	[Address(RVA = "0x20B1D24", Offset = "0x20B1D24", VA = "0x20B1D24")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F3FF")]
	[Address(RVA = "0x20B1D2C", Offset = "0x20B1D2C", VA = "0x20B1D2C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
