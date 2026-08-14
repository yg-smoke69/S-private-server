using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;
using message;

[Token(Token = "0x200099F")]
internal class PlayerForceTutorialBot : PlayerNetwork
{
	[Token(Token = "0x400595F")]
	private const int REVIVE_BASE_HP = 20;

	[Token(Token = "0x4005960")]
	[FieldOffset(Offset = "0x9C8")]
	public bool IsInvincible;

	[Token(Token = "0x600499C")]
	[Address(RVA = "0x1E1E610", Offset = "0x1E1E610", VA = "0x1E1E610")]
	public PlayerForceTutorialBot()
	{
	}

	[Token(Token = "0x600499D")]
	[Address(RVA = "0x1E1E618", Offset = "0x1E1E618", VA = "0x1E1E618", Slot = "103")]
	public override void InitProperties(object properties, bool needShowCloth = true)
	{
	}

	[Token(Token = "0x600499E")]
	[Address(RVA = "0x1E1EF5C", Offset = "0x1E1EF5C", VA = "0x1E1EF5C")]
	public void SetAvatar(uint id, string cloths = "")
	{
	}

	[Token(Token = "0x600499F")]
	[Address(RVA = "0x1E1F28C", Offset = "0x1E1F28C", VA = "0x1E1F28C")]
	public void ForceStartWalking(Vector3 dir)
	{
	}

	[Token(Token = "0x60049A0")]
	[Address(RVA = "0x1E1F57C", Offset = "0x1E1F57C", VA = "0x1E1F57C")]
	public void SetAimRotation(Vector3 pos)
	{
	}

	[Token(Token = "0x60049A1")]
	[Address(RVA = "0x1E1F74C", Offset = "0x1E1F74C", VA = "0x1E1F74C", Slot = "116")]
	public override void UpdateKinematics(float gameTime, float deltaTime)
	{
	}

	[Token(Token = "0x60049A2")]
	[Address(RVA = "0x1E1F754", Offset = "0x1E1F754", VA = "0x1E1F754", Slot = "108")]
	public override void Dead(int weaponID, IHAAMHPPLMG damager, bool isHeadShot = false, bool pendingRevive = false)
	{
	}

	[Token(Token = "0x60049A3")]
	[Address(RVA = "0x1E1F8AC", Offset = "0x1E1F8AC", VA = "0x1E1F8AC", Slot = "124")]
	public override int TakeDamage(int baseDamage, IHAAMHPPLMG damager, [Optional] ELMGJKHIIAA damageInfo, int weaponDataID = -1, [Optional] Vector3 firePos, [Optional] Vector3 hitPos, [Optional] List<float> checkParams, [Optional] MKFEKBKJCKE damagerWeaponDynamicInfo, uint damagerVehicleID = 0u)
	{
		return default(int);
	}

	[Token(Token = "0x60049A4")]
	[Address(RVA = "0x1E20A94", Offset = "0x1E20A94", VA = "0x1E20A94")]
	private new void SyncKnockDown(NKDBFGLPCCF msg)
	{
	}

	[Token(Token = "0x60049A5")]
	[Address(RVA = "0x1E20E50", Offset = "0x1E20E50", VA = "0x1E20E50")]
	public new void SyncRevive3P()
	{
	}
}
