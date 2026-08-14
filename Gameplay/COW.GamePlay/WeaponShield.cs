using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000739")]
internal class WeaponShield : AttackableEntity
{
	[Token(Token = "0x4004CAD")]
	[FieldOffset(Offset = "0x48")]
	private GPBDEDFKJNA FDCLCHKBBKO;

	[Token(Token = "0x4004CAE")]
	[FieldOffset(Offset = "0x4C")]
	public GMHJODEJKNH m_ShieldData;

	[Token(Token = "0x4004CAF")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_Collider;

	[Token(Token = "0x4004CB0")]
	[FieldOffset(Offset = "0x54")]
	private bool JDEOHCOHFAE;

	[Token(Token = "0x4004CB1")]
	[FieldOffset(Offset = "0x58")]
	private float AKGGDLNLEHB;

	[Token(Token = "0x4004CB2")]
	[FieldOffset(Offset = "0x5C")]
	private BKODMMFCJMM ILGECLEFCCO;

	[Token(Token = "0x4004CB3")]
	[FieldOffset(Offset = "0x60")]
	private float JEEBEIDLKPN;

	[Token(Token = "0x6002DA6")]
	[Address(RVA = "0x26F587C", Offset = "0x26F587C", VA = "0x26F587C")]
	public WeaponShield()
	{
	}

	[Token(Token = "0x6002DA7")]
	[Address(RVA = "0x26F588C", Offset = "0x26F588C", VA = "0x26F588C")]
	public bool IsResumeGenerate()
	{
		return default(bool);
	}

	[Token(Token = "0x6002DA8")]
	[Address(RVA = "0x26F58E4", Offset = "0x26F58E4", VA = "0x26F58E4")]
	public void BindWithOwner(GMHJODEJKNH DLMCLGMABHG, GPBDEDFKJNA BMNOLDHKGBJ)
	{
	}

	[Token(Token = "0x6002DA9")]
	[Address(RVA = "0x26F59A0", Offset = "0x26F59A0", VA = "0x26F59A0")]
	public void DisableCollider()
	{
	}

	[Token(Token = "0x6002DAA")]
	[Address(RVA = "0x26F5A1C", Offset = "0x26F5A1C", VA = "0x26F5A1C")]
	public void UpdateShield(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002DAB")]
	[Address(RVA = "0x26F5D60", Offset = "0x26F5D60", VA = "0x26F5D60", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint EMFANFHKAMM = 0u)
	{
	}

	[Token(Token = "0x6002DAC")]
	[Address(RVA = "0x26F612C", Offset = "0x26F612C", VA = "0x26F612C")]
	public void OnMsgTakeDamage(uint JLKLMFHFHFF)
	{
	}

	[Token(Token = "0x6002DAD")]
	[Address(RVA = "0x26F6278", Offset = "0x26F6278", VA = "0x26F6278")]
	private void HGOEKLMAEPF(float IMGNBGJDAHG)
	{
	}

	[Token(Token = "0x6002DAE")]
	[Address(RVA = "0x26F63C4", Offset = "0x26F63C4", VA = "0x26F63C4")]
	public void Hide()
	{
	}

	[Token(Token = "0x6002DAF")]
	[Address(RVA = "0x26F5BF0", Offset = "0x26F5BF0", VA = "0x26F5BF0")]
	public void Regenerate()
	{
	}

	[Token(Token = "0x6002DB0")]
	[Address(RVA = "0x26F60B8", Offset = "0x26F60B8", VA = "0x26F60B8")]
	public Player GetOwnerPlayer()
	{
		return null;
	}

	[Token(Token = "0x6002DB1")]
	[Address(RVA = "0x26F6654", Offset = "0x26F6654", VA = "0x26F6654", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002DB2")]
	[Address(RVA = "0x26F66AC", Offset = "0x26F66AC", VA = "0x26F66AC")]
	public float GetHP()
	{
		return default(float);
	}

	[Token(Token = "0x6002DB3")]
	[Address(RVA = "0x26F6704", Offset = "0x26F6704", VA = "0x26F6704")]
	public bool IsShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6002DB4")]
	[Address(RVA = "0x26F6768", Offset = "0x26F6768", VA = "0x26F6768")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
