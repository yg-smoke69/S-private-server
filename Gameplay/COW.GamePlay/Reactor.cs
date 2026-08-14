using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000714")]
internal class Reactor : AttackableEntity
{
	[Token(Token = "0x4004C0F")]
	[FieldOffset(Offset = "0x48")]
	private GameObject LKIGJJNKHGF;

	[Token(Token = "0x4004C10")]
	[FieldOffset(Offset = "0x4C")]
	private uint MMNFABGNKAJ;

	[Token(Token = "0x4004C11")]
	[FieldOffset(Offset = "0x50")]
	private LevelReactor JLEJNIBALHD;

	[Token(Token = "0x4004C12")]
	[FieldOffset(Offset = "0x54")]
	private ParticleSystem m_Shine;

	[Token(Token = "0x6002CE1")]
	[Address(RVA = "0x19F1DA0", Offset = "0x19F1DA0", VA = "0x19F1DA0")]
	public Reactor()
	{
	}

	[Token(Token = "0x6002CE2")]
	[Address(RVA = "0x19F1DA8", Offset = "0x19F1DA8", VA = "0x19F1DA8", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002CE3")]
	[Address(RVA = "0x19F1E00", Offset = "0x19F1E00", VA = "0x19F1E00")]
	internal void DPLMGOJKKCM(LevelReactor ECINOMEHBKA)
	{
	}

	[Token(Token = "0x6002CE4")]
	[Address(RVA = "0x19F1E70", Offset = "0x19F1E70", VA = "0x19F1E70")]
	public void ChangeShineColor(float LGHNJEDOFFD)
	{
	}

	[Token(Token = "0x6002CE5")]
	[Address(RVA = "0x19F1FDC", Offset = "0x19F1FDC", VA = "0x19F1FDC", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x6002CE6")]
	[Address(RVA = "0x19F22D8", Offset = "0x19F22D8", VA = "0x19F22D8")]
	public void PlayExplodeEffect()
	{
	}

	[Token(Token = "0x6002CE7")]
	[Address(RVA = "0x19F2794", Offset = "0x19F2794", VA = "0x19F2794")]
	public void StopExplodeEfect()
	{
	}

	[Token(Token = "0x6002CE8")]
	[Address(RVA = "0x19F29FC", Offset = "0x19F29FC", VA = "0x19F29FC")]
	private void AHBAONFIDAK()
	{
	}

	[Token(Token = "0x6002CE9")]
	[Address(RVA = "0x19F2A00", Offset = "0x19F2A00", VA = "0x19F2A00")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
