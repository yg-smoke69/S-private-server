using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002707")]
internal class UIHUDCenterUpTitleController : UIBaseController
{
	[Token(Token = "0x400F0EC")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDCenterUpTitleView m_View;

	[Token(Token = "0x600ED18")]
	[Address(RVA = "0x1675A6C", Offset = "0x1675A6C", VA = "0x1675A6C")]
	public UIHUDCenterUpTitleController()
	{
	}

	[Token(Token = "0x600ED19")]
	[Address(RVA = "0x1675AF0", Offset = "0x1675AF0", VA = "0x1675AF0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ED1A")]
	[Address(RVA = "0x1675B98", Offset = "0x1675B98", VA = "0x1675B98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ED1B")]
	[Address(RVA = "0x1675CE8", Offset = "0x1675CE8", VA = "0x1675CE8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600ED1C")]
	[Address(RVA = "0x1675E1C", Offset = "0x1675E1C", VA = "0x1675E1C")]
	private void OnTitleInfoCome(object[] data)
	{
	}

	[Token(Token = "0x600ED1D")]
	[Address(RVA = "0x1676014", Offset = "0x1676014", VA = "0x1676014")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ED1E")]
	[Address(RVA = "0x167601C", Offset = "0x167601C", VA = "0x167601C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
