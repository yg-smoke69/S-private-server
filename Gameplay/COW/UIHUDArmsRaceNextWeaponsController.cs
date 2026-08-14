using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FA5")]
public class UIHUDArmsRaceNextWeaponsController : UIBaseController
{
	[Token(Token = "0x400C67D")]
	[FieldOffset(Offset = "0x28")]
	private UIHudArmsRaceNextWeaponView m_View;

	[Token(Token = "0x6009DC0")]
	[Address(RVA = "0x1670A64", Offset = "0x1670A64", VA = "0x1670A64")]
	public UIHUDArmsRaceNextWeaponsController()
	{
	}

	[Token(Token = "0x6009DC1")]
	[Address(RVA = "0x1670AE8", Offset = "0x1670AE8", VA = "0x1670AE8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009DC2")]
	[Address(RVA = "0x1670B8C", Offset = "0x1670B8C", VA = "0x1670B8C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009DC3")]
	[Address(RVA = "0x1670C48", Offset = "0x1670C48", VA = "0x1670C48")]
	public void SetData(uint weaponID, int ShowLevel, bool isShowNextArrow)
	{
	}

	[Token(Token = "0x6009DC4")]
	[Address(RVA = "0x1671064", Offset = "0x1671064", VA = "0x1671064")]
	public void HideInfo()
	{
	}

	[Token(Token = "0x6009DC5")]
	[Address(RVA = "0x16710F4", Offset = "0x16710F4", VA = "0x16710F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
