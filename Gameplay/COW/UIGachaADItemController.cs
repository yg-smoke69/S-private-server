using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200262C")]
public class UIGachaADItemController : UIBaseController
{
	[Token(Token = "0x400EBBF")]
	[FieldOffset(Offset = "0x28")]
	private UIGachaADItemView m_View;

	[Token(Token = "0x600E2B7")]
	[Address(RVA = "0x265A778", Offset = "0x265A778", VA = "0x265A778")]
	public UIGachaADItemController()
	{
	}

	[Token(Token = "0x600E2B8")]
	[Address(RVA = "0x265A7FC", Offset = "0x265A7FC", VA = "0x265A7FC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E2B9")]
	[Address(RVA = "0x265A8A0", Offset = "0x265A8A0", VA = "0x265A8A0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E2BA")]
	[Address(RVA = "0x265AA8C", Offset = "0x265AA8C", VA = "0x265AA8C")]
	private void OnItemSelect()
	{
	}

	[Token(Token = "0x600E2BB")]
	[Address(RVA = "0x265AB98", Offset = "0x265AB98", VA = "0x265AB98")]
	public void RefreshAdData(AdvertDesc info)
	{
	}

	[Token(Token = "0x600E2BC")]
	[Address(RVA = "0x265AE10", Offset = "0x265AE10", VA = "0x265AE10")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
