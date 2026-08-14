using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006FC")]
internal class OilDrums : AttackableEntity
{
	[Token(Token = "0x4004BC2")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_OildrumNode;

	[Token(Token = "0x4004BC3")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject m_BrokenNode;

	[Token(Token = "0x4004BC4")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_FlowingEffectNode;

	[Token(Token = "0x4004BC5")]
	[FieldOffset(Offset = "0x54")]
	private GameObject HGPGNIJPCEI;

	[Token(Token = "0x4004BC6")]
	[FieldOffset(Offset = "0x58")]
	private GameObject LKIGJJNKHGF;

	[Token(Token = "0x4004BC7")]
	[FieldOffset(Offset = "0x5C")]
	private uint MMNFABGNKAJ;

	[Token(Token = "0x4004BC8")]
	[FieldOffset(Offset = "0x60")]
	private LevelBaseDrum PMCCJDKOMDP;

	[Token(Token = "0x4004BC9")]
	[FieldOffset(Offset = "0x64")]
	private uint ECIFAJLEAPM;

	[Token(Token = "0x4004BCA")]
	[FieldOffset(Offset = "0x68")]
	private uint KNLJFIFOHCG;

	[Token(Token = "0x4004BCB")]
	[FieldOffset(Offset = "0x0")]
	private static Action HMDOHFBHDOB;

	[Token(Token = "0x6002CA4")]
	[Address(RVA = "0x1643FC0", Offset = "0x1643FC0", VA = "0x1643FC0")]
	public OilDrums()
	{
	}

	[Token(Token = "0x6002CA5")]
	[Address(RVA = "0x1643FC8", Offset = "0x1643FC8", VA = "0x1643FC8", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002CA6")]
	[Address(RVA = "0x1644020", Offset = "0x1644020", VA = "0x1644020")]
	internal void DPLMGOJKKCM(LevelBaseDrum KPDKCKNFPMO)
	{
	}

	[Token(Token = "0x6002CA7")]
	[Address(RVA = "0x16440C8", Offset = "0x16440C8", VA = "0x16440C8", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x6002CA8")]
	[Address(RVA = "0x1644680", Offset = "0x1644680", VA = "0x1644680")]
	public LevelBaseDrum.JPAKCIIEOML GetOilDrumType()
	{
		return default(LevelBaseDrum.JPAKCIIEOML);
	}

	[Token(Token = "0x6002CA9")]
	[Address(RVA = "0x1644788", Offset = "0x1644788", VA = "0x1644788")]
	public void SetOilDrumState(JOHANDONOGK GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x6002CAA")]
	[Address(RVA = "0x16449AC", Offset = "0x16449AC", VA = "0x16449AC")]
	private void EBPJNGPOFMG(bool ODOEHEHNJOG)
	{
	}

	[Token(Token = "0x6002CAB")]
	[Address(RVA = "0x1644E00", Offset = "0x1644E00", VA = "0x1644E00")]
	public void PlayExplodeEffect()
	{
	}

	[Token(Token = "0x6002CAC")]
	[Address(RVA = "0x1645374", Offset = "0x1645374", VA = "0x1645374")]
	public void StopExplodeEfect()
	{
	}

	[Token(Token = "0x6002CAD")]
	[Address(RVA = "0x164557C", Offset = "0x164557C", VA = "0x164557C")]
	private static void HEKOHGAKGMD()
	{
	}

	[Token(Token = "0x6002CAE")]
	[Address(RVA = "0x1645660", Offset = "0x1645660", VA = "0x1645660")]
	private void FNCAPFJKJJA()
	{
	}

	[Token(Token = "0x6002CAF")]
	[Address(RVA = "0x1645664", Offset = "0x1645664", VA = "0x1645664")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
