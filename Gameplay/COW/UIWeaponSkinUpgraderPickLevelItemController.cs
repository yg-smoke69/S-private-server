using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C14")]
public class UIWeaponSkinUpgraderPickLevelItemController : UIBaseController
{
	[Token(Token = "0x4010D4D")]
	[FieldOffset(Offset = "0x28")]
	private UIWeaponSkinUpgraderPickLevelItemView m_View;

	[Token(Token = "0x4010D4E")]
	[FieldOffset(Offset = "0x2C")]
	private SkinOwnAndOpenInfo m_OwnAndOpenInfo;

	[Token(Token = "0x6012557")]
	[Address(RVA = "0x1B73860", Offset = "0x1B73860", VA = "0x1B73860")]
	public UIWeaponSkinUpgraderPickLevelItemController()
	{
	}

	[Token(Token = "0x6012558")]
	[Address(RVA = "0x1B738E4", Offset = "0x1B738E4", VA = "0x1B738E4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012559")]
	[Address(RVA = "0x1B73988", Offset = "0x1B73988", VA = "0x1B73988", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601255A")]
	[Address(RVA = "0x1B73B78", Offset = "0x1B73B78", VA = "0x1B73B78", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x601255B")]
	[Address(RVA = "0x1B73CAC", Offset = "0x1B73CAC", VA = "0x1B73CAC")]
	public void SetData(uint skinId)
	{
	}

	[Token(Token = "0x601255C")]
	[Address(RVA = "0x1B74A7C", Offset = "0x1B74A7C", VA = "0x1B74A7C")]
	private void GoToWeaponDetailPage()
	{
	}

	[Token(Token = "0x601255D")]
	[Address(RVA = "0x1B74CC0", Offset = "0x1B74CC0", VA = "0x1B74CC0")]
	private void OnPickLv(object[] param)
	{
	}

	[Token(Token = "0x601255E")]
	[Address(RVA = "0x1B74E5C", Offset = "0x1B74E5C", VA = "0x1B74E5C")]
	public void OnChosen()
	{
	}

	[Token(Token = "0x601255F")]
	[Address(RVA = "0x1B74F0C", Offset = "0x1B74F0C", VA = "0x1B74F0C")]
	public void OnUnchosen()
	{
	}

	[Token(Token = "0x6012560")]
	[Address(RVA = "0x1B74FBC", Offset = "0x1B74FBC", VA = "0x1B74FBC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012561")]
	[Address(RVA = "0x1B74FC4", Offset = "0x1B74FC4", VA = "0x1B74FC4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
