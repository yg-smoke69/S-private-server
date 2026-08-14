using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C13")]
public class UIWeaponSkinUpgraderGunPickItemController : UIBaseController
{
	[Token(Token = "0x4010D4B")]
	[FieldOffset(Offset = "0x28")]
	private UIWeaponSkinUpgraderGunPickItemView m_View;

	[Token(Token = "0x4010D4C")]
	[FieldOffset(Offset = "0x2C")]
	private SkinOwnAndOpenInfo m_SkinOwnAndOpenInfo;

	[Token(Token = "0x601254D")]
	[Address(RVA = "0x1B71C9C", Offset = "0x1B71C9C", VA = "0x1B71C9C")]
	public UIWeaponSkinUpgraderGunPickItemController()
	{
	}

	[Token(Token = "0x601254E")]
	[Address(RVA = "0x1B71D20", Offset = "0x1B71D20", VA = "0x1B71D20")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601254F")]
	[Address(RVA = "0x1B71DC4", Offset = "0x1B71DC4", VA = "0x1B71DC4", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012550")]
	[Address(RVA = "0x1B71E20", Offset = "0x1B71E20", VA = "0x1B71E20", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012551")]
	[Address(RVA = "0x1B70A10", Offset = "0x1B70A10", VA = "0x1B70A10")]
	public void SetData(SkinOwnAndOpenInfo skinOwnAndOpenInfo, bool showRedPoint = false)
	{
	}

	[Token(Token = "0x6012552")]
	[Address(RVA = "0x1B726F8", Offset = "0x1B726F8", VA = "0x1B726F8")]
	private void GoToPurchase()
	{
	}

	[Token(Token = "0x6012553")]
	[Address(RVA = "0x1B72904", Offset = "0x1B72904", VA = "0x1B72904")]
	private void GoToWeaponDetailPage()
	{
	}

	[Token(Token = "0x6012554")]
	[Address(RVA = "0x1B71FF0", Offset = "0x1B71FF0", VA = "0x1B71FF0")]
	private void SetQualityBG(uint Quality)
	{
	}

	[Token(Token = "0x6012555")]
	[Address(RVA = "0x1B72E80", Offset = "0x1B72E80", VA = "0x1B72E80")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012556")]
	[Address(RVA = "0x1B72E88", Offset = "0x1B72E88", VA = "0x1B72E88")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
