using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B08")]
internal class BountyOilDrum : AttackableEntity
{
	[Token(Token = "0x4005F5E")]
	[FieldOffset(Offset = "0x48")]
	public int MAXHP;

	[Token(Token = "0x4005F5F")]
	[FieldOffset(Offset = "0x4C")]
	private int m_CurHP;

	[Token(Token = "0x4005F60")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_ExplodeEffectNode;

	[Token(Token = "0x4005F61")]
	[FieldOffset(Offset = "0x54")]
	private uint m_DelayCallID;

	[Token(Token = "0x60054C9")]
	[Address(RVA = "0x2ED6288", Offset = "0x2ED6288", VA = "0x2ED6288")]
	public BountyOilDrum()
	{
	}

	[Token(Token = "0x60054CA")]
	[Address(RVA = "0x2ED6290", Offset = "0x2ED6290", VA = "0x2ED6290", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60054CB")]
	[Address(RVA = "0x2ED6298", Offset = "0x2ED6298", VA = "0x2ED6298", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA damageInfo, [Optional] MKFEKBKJCKE damagerWeaponDynamicInfo, [Optional] List<float> checkParams, uint damagerVehicleID = 0u)
	{
	}

	[Token(Token = "0x60054CC")]
	[Address(RVA = "0x2ED630C", Offset = "0x2ED630C", VA = "0x2ED630C")]
	private void Explode()
	{
	}

	[Token(Token = "0x60054CD")]
	[Address(RVA = "0x2ED65B0", Offset = "0x2ED65B0", VA = "0x2ED65B0")]
	public void PlayExplodeEffect()
	{
	}

	[Token(Token = "0x60054CE")]
	[Address(RVA = "0x2ED68FC", Offset = "0x2ED68FC", VA = "0x2ED68FC")]
	public void StopExplodeEfect()
	{
	}

	[Token(Token = "0x60054CF")]
	[Address(RVA = "0x2ED6AA8", Offset = "0x2ED6AA8", VA = "0x2ED6AA8", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x60054D0")]
	[Address(RVA = "0x2ED6AC8", Offset = "0x2ED6AC8", VA = "0x2ED6AC8")]
	private void _003CPlayExplodeEffect_003Em__0()
	{
	}
}
