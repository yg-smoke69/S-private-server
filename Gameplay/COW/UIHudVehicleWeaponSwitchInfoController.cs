using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028B4")]
internal class UIHudVehicleWeaponSwitchInfoController : UIBaseController
{
	[Token(Token = "0x400FA6E")]
	[FieldOffset(Offset = "0x28")]
	public UIHudVehicleWeaponSwitchInfoView m_View;

	[Token(Token = "0x400FA6F")]
	[FieldOffset(Offset = "0x2C")]
	private string EmptyWeaponSpriteIcon;

	[Token(Token = "0x400FA70")]
	[FieldOffset(Offset = "0x30")]
	private string EmptyAmmoSpriteIcon;

	[Token(Token = "0x400FA71")]
	[FieldOffset(Offset = "0x34")]
	private bool m_EmptyAmmo;

	[Token(Token = "0x400FA72")]
	[FieldOffset(Offset = "0x35")]
	private bool m_DisplayCleared;

	[Token(Token = "0x400FA73")]
	[FieldOffset(Offset = "0x38")]
	private GPBDEDFKJNA m_LastWeapon;

	[Token(Token = "0x400FA74")]
	[FieldOffset(Offset = "0x3C")]
	private FGJEBMEEIGM m_LastVehicleWeapon;

	[Token(Token = "0x400FA75")]
	[FieldOffset(Offset = "0x40")]
	private int m_LastAmmoCapacity;

	[Token(Token = "0x400FA76")]
	[FieldOffset(Offset = "0x44")]
	private int m_LastAmmoLeft;

	[Token(Token = "0x400FA77")]
	[FieldOffset(Offset = "0x48")]
	private int m_LastAmmoLeftInClip;

	[Token(Token = "0x600FFF8")]
	[Address(RVA = "0x1A736F8", Offset = "0x1A736F8", VA = "0x1A736F8")]
	public UIHudVehicleWeaponSwitchInfoController()
	{
	}

	[Token(Token = "0x600FFF9")]
	[Address(RVA = "0x1A73794", Offset = "0x1A73794", VA = "0x1A73794")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FFFA")]
	[Address(RVA = "0x1A73838", Offset = "0x1A73838", VA = "0x1A73838", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FFFB")]
	[Address(RVA = "0x1A73994", Offset = "0x1A73994", VA = "0x1A73994", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FFFC")]
	[Address(RVA = "0x1A73CE0", Offset = "0x1A73CE0", VA = "0x1A73CE0")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600FFFD")]
	[Address(RVA = "0x1A73ED8", Offset = "0x1A73ED8", VA = "0x1A73ED8")]
	private void Update()
	{
	}

	[Token(Token = "0x600FFFE")]
	[Address(RVA = "0x1A73A14", Offset = "0x1A73A14", VA = "0x1A73A14")]
	private void ClearWeaponDisplay()
	{
	}

	[Token(Token = "0x600FFFF")]
	[Address(RVA = "0x1A7439C", Offset = "0x1A7439C", VA = "0x1A7439C")]
	private void SetIcon(string s)
	{
	}

	[Token(Token = "0x6010000")]
	[Address(RVA = "0x1A7450C", Offset = "0x1A7450C", VA = "0x1A7450C")]
	private void SetIcon(ResourceID id)
	{
	}

	[Token(Token = "0x6010001")]
	[Address(RVA = "0x1A74654", Offset = "0x1A74654", VA = "0x1A74654")]
	private void SetWeaponIcon(GPBDEDFKJNA currentWeapon)
	{
	}

	[Token(Token = "0x6010002")]
	[Address(RVA = "0x1A746F0", Offset = "0x1A746F0", VA = "0x1A746F0")]
	private void SetWeaponIcon(FGJEBMEEIGM vWeapon)
	{
	}

	[Token(Token = "0x6010003")]
	[Address(RVA = "0x1A74778", Offset = "0x1A74778", VA = "0x1A74778")]
	private bool HasIcon(FGJEBMEEIGM vWeapon)
	{
		return default(bool);
	}

	[Token(Token = "0x6010004")]
	[Address(RVA = "0x1A740A8", Offset = "0x1A740A8", VA = "0x1A740A8")]
	private void UpdateWeaponIcon(FGJEBMEEIGM vehWeapon)
	{
	}

	[Token(Token = "0x6010005")]
	[Address(RVA = "0x1A74250", Offset = "0x1A74250", VA = "0x1A74250")]
	private void UpdateAmmoDisplay(FGJEBMEEIGM vehWeapon)
	{
	}

	[Token(Token = "0x6010006")]
	[Address(RVA = "0x1A748F8", Offset = "0x1A748F8", VA = "0x1A748F8")]
	private void UpdateAmmoDisplay(bool infinityAmmo)
	{
	}

	[Token(Token = "0x6010007")]
	[Address(RVA = "0x1A73DDC", Offset = "0x1A73DDC", VA = "0x1A73DDC")]
	private void UpdateAutoIcon(FGJEBMEEIGM vehWeapon)
	{
	}

	[Token(Token = "0x6010008")]
	[Address(RVA = "0x1A73BEC", Offset = "0x1A73BEC", VA = "0x1A73BEC")]
	private void ShowAutoIcon(bool b)
	{
	}

	[Token(Token = "0x6010009")]
	[Address(RVA = "0x1A74E00", Offset = "0x1A74E00", VA = "0x1A74E00")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x601000A")]
	[Address(RVA = "0x1A74EC4", Offset = "0x1A74EC4", VA = "0x1A74EC4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601000B")]
	[Address(RVA = "0x1A74ECC", Offset = "0x1A74ECC", VA = "0x1A74ECC")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
