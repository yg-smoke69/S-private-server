using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002845")]
internal class UIHudSightController : UIHudButtonBaseController
{
	[Token(Token = "0x400F871")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudSightView m_View;

	[Token(Token = "0x400F872")]
	[FieldOffset(Offset = "0x30")]
	private bool m_bSighting;

	[Token(Token = "0x400F873")]
	private const string AimShoot = "SG_UI_icon_aim";

	[Token(Token = "0x400F874")]
	private const string AimShootClose = "SG_UI_icon_aim_close";

	[Token(Token = "0x400F875")]
	private const string AimShoot_Shield = "SG_UI_icon_Shield";

	[Token(Token = "0x400F876")]
	private const string AimShootClose_Shield = "SG_UI_icon_Shield_close";

	[Token(Token = "0x400F877")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Color WHITE;

	[Token(Token = "0x400F878")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Color GRAY;

	[Token(Token = "0x400F879")]
	[FieldOffset(Offset = "0x34")]
	private uint weaponID;

	[Token(Token = "0x600FB74")]
	[Address(RVA = "0x16B9750", Offset = "0x16B9750", VA = "0x16B9750")]
	public UIHudSightController()
	{
	}

	[Token(Token = "0x600FB75")]
	[Address(RVA = "0x16B9758", Offset = "0x16B9758", VA = "0x16B9758")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FB76")]
	[Address(RVA = "0x16B97FC", Offset = "0x16B97FC", VA = "0x16B97FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FB77")]
	[Address(RVA = "0x16B9ABC", Offset = "0x16B9ABC", VA = "0x16B9ABC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600FB78")]
	[Address(RVA = "0x16B9CC0", Offset = "0x16B9CC0", VA = "0x16B9CC0", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FB79")]
	[Address(RVA = "0x16B9D64", Offset = "0x16B9D64", VA = "0x16B9D64")]
	private void Update()
	{
	}

	[Token(Token = "0x600FB7A")]
	[Address(RVA = "0x16BA4E0", Offset = "0x16BA4E0", VA = "0x16BA4E0")]
	private void ShowTutorialOpenGunSight(object[] data)
	{
	}

	[Token(Token = "0x600FB7B")]
	[Address(RVA = "0x16BA63C", Offset = "0x16BA63C", VA = "0x16BA63C")]
	private void ShowTutorialSightOpeningInForceTutorial(object[] param)
	{
	}

	[Token(Token = "0x600FB7C")]
	[Address(RVA = "0x16BA798", Offset = "0x16BA798", VA = "0x16BA798")]
	private void ShowTutorialSightClosingInForceTutorial(object[] param)
	{
	}

	[Token(Token = "0x600FB7E")]
	[Address(RVA = "0x16BA9A4", Offset = "0x16BA9A4", VA = "0x16BA9A4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FB7F")]
	[Address(RVA = "0x16BA9AC", Offset = "0x16BA9AC", VA = "0x16BA9AC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
