using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FAA")]
internal class UIHudArmsRaceWeaponInfoController : UIHudWeaponInfoController
{
	[Token(Token = "0x400C68A")]
	private const int NextWeaponsCount = 3;

	[Token(Token = "0x400C68B")]
	[FieldOffset(Offset = "0x78")]
	private bool m_IsInitedNextWeapons;

	[Token(Token = "0x400C68C")]
	[FieldOffset(Offset = "0x7C")]
	private int m_CurLevel;

	[Token(Token = "0x400C68D")]
	[FieldOffset(Offset = "0x80")]
	private List<UIHUDArmsRaceNextWeaponsController> m_NextWeaponControllers;

	[Token(Token = "0x6009DEE")]
	[Address(RVA = "0x17075E4", Offset = "0x17075E4", VA = "0x17075E4")]
	public UIHudArmsRaceWeaponInfoController()
	{
	}

	[Token(Token = "0x6009DEF")]
	[Address(RVA = "0x170769C", Offset = "0x170769C", VA = "0x170769C")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009DF0")]
	[Address(RVA = "0x1707740", Offset = "0x1707740", VA = "0x1707740", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009DF1")]
	[Address(RVA = "0x1707A68", Offset = "0x1707A68", VA = "0x1707A68", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009DF2")]
	[Address(RVA = "0x17078E4", Offset = "0x17078E4", VA = "0x17078E4")]
	private void InitNextWeapons()
	{
	}

	[Token(Token = "0x6009DF3")]
	[Address(RVA = "0x1707C04", Offset = "0x1707C04", VA = "0x1707C04")]
	private void OnGameArmsListCome(object[] param)
	{
	}

	[Token(Token = "0x6009DF4")]
	[Address(RVA = "0x1707F10", Offset = "0x1707F10", VA = "0x1707F10")]
	private void OnPlayerARMLevelUpdate(object[] param)
	{
	}

	[Token(Token = "0x6009DF5")]
	[Address(RVA = "0x1707C80", Offset = "0x1707C80", VA = "0x1707C80")]
	private void UpdateNextWeapons()
	{
	}

	[Token(Token = "0x6009DF6")]
	[Address(RVA = "0x1707FF0", Offset = "0x1707FF0", VA = "0x1707FF0", Slot = "33")]
	protected override bool IsCheckSilderWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x6009DF7")]
	[Address(RVA = "0x1708048", Offset = "0x1708048", VA = "0x1708048", Slot = "34")]
	protected override bool IsCheckHeaveyWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x6009DF8")]
	[Address(RVA = "0x17080A0", Offset = "0x17080A0", VA = "0x17080A0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009DF9")]
	[Address(RVA = "0x17080A8", Offset = "0x17080A8", VA = "0x17080A8")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6009DFA")]
	[Address(RVA = "0x17080B0", Offset = "0x17080B0", VA = "0x17080B0")]
	public bool _003C_003EiFixBaseProxy_IsCheckSilderWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x6009DFB")]
	[Address(RVA = "0x17080B8", Offset = "0x17080B8", VA = "0x17080B8")]
	public bool _003C_003EiFixBaseProxy_IsCheckHeaveyWeapon()
	{
		return default(bool);
	}
}
