using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002972")]
internal class UIMallBannerItemController : UIBaseController
{
	[Token(Token = "0x400FF61")]
	[FieldOffset(Offset = "0x28")]
	private UIMallBannerItemView m_View;

	[Token(Token = "0x60109E7")]
	[Address(RVA = "0x239655C", Offset = "0x239655C", VA = "0x239655C")]
	public UIMallBannerItemController()
	{
	}

	[Token(Token = "0x60109E8")]
	[Address(RVA = "0x23965E0", Offset = "0x23965E0", VA = "0x23965E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60109E9")]
	[Address(RVA = "0x2396684", Offset = "0x2396684", VA = "0x2396684", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60109EA")]
	[Address(RVA = "0x2396740", Offset = "0x2396740", VA = "0x2396740")]
	public void UpdateUIData(uint bannerId)
	{
	}

	[Token(Token = "0x60109EB")]
	[Address(RVA = "0x23969B0", Offset = "0x23969B0", VA = "0x23969B0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
