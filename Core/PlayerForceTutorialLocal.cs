using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009A0")]
internal class PlayerForceTutorialLocal : Player
{
	[Token(Token = "0x60049A6")]
	[Address(RVA = "0x1E20F30", Offset = "0x1E20F30", VA = "0x1E20F30")]
	public PlayerForceTutorialLocal()
	{
	}

	[Token(Token = "0x60049A7")]
	[Address(RVA = "0x1E20FB4", Offset = "0x1E20FB4", VA = "0x1E20FB4", Slot = "103")]
	public override void InitProperties(object properties, bool needShowCloth = true)
	{
	}

	[Token(Token = "0x60049A8")]
	[Address(RVA = "0x1E21250", Offset = "0x1E21250", VA = "0x1E21250")]
	public void InitAimRotation(Vector3 forward)
	{
	}

	[Token(Token = "0x60049A9")]
	[Address(RVA = "0x1E21334", Offset = "0x1E21334", VA = "0x1E21334", Slot = "124")]
	public override int TakeDamage(int baseDamage, IHAAMHPPLMG damager, [Optional] ELMGJKHIIAA damageInfo, int weaponDataID = -1, [Optional] Vector3 firePos, [Optional] Vector3 hitPos, [Optional] List<float> checkParams, [Optional] MKFEKBKJCKE damagerWeaponDynamicInfo, uint damagerVehicleID = 0u)
	{
		return default(int);
	}

	[Token(Token = "0x60049AA")]
	[Address(RVA = "0x1E21D58", Offset = "0x1E21D58", VA = "0x1E21D58")]
	public void DisableMoving()
	{
	}
}
