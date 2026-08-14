using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002798")]
internal class UIHudJetFlyDownController : UIHudButtonBaseController
{
	[Token(Token = "0x400F482")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudJetFlyDownView m_View;

	[Token(Token = "0x600F400")]
	[Address(RVA = "0x20B1D34", Offset = "0x20B1D34", VA = "0x20B1D34")]
	public UIHudJetFlyDownController()
	{
	}

	[Token(Token = "0x600F401")]
	[Address(RVA = "0x20B1D3C", Offset = "0x20B1D3C", VA = "0x20B1D3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F402")]
	[Address(RVA = "0x20B1DE4", Offset = "0x20B1DE4", VA = "0x20B1DE4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F403")]
	[Address(RVA = "0x20B1EC4", Offset = "0x20B1EC4", VA = "0x20B1EC4", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600F404")]
	[Address(RVA = "0x20B1F68", Offset = "0x20B1F68", VA = "0x20B1F68")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
