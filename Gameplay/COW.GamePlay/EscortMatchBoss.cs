using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x20005BF")]
internal class EscortMatchBoss : AttackableEntity
{
	[Token(Token = "0x40043B7")]
	[FieldOffset(Offset = "0x48")]
	private LevelEscortMatchBoss JJNHCKANPGK;

	[Token(Token = "0x40043B8")]
	[FieldOffset(Offset = "0x4C")]
	private uint KNLJFIFOHCG;

	[Token(Token = "0x60022DB")]
	[Address(RVA = "0x191E0E8", Offset = "0x191E0E8", VA = "0x191E0E8")]
	public EscortMatchBoss()
	{
	}

	[Token(Token = "0x60022DC")]
	[Address(RVA = "0x191E0F0", Offset = "0x191E0F0", VA = "0x191E0F0", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60022DD")]
	[Address(RVA = "0x191E148", Offset = "0x191E148", VA = "0x191E148")]
	internal void DPLMGOJKKCM(LevelEscortMatchBoss AICJAPCHGCN)
	{
	}

	[Token(Token = "0x60022DE")]
	[Address(RVA = "0x191E1CC", Offset = "0x191E1CC", VA = "0x191E1CC", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x60022DF")]
	[Address(RVA = "0x191E63C", Offset = "0x191E63C", VA = "0x191E63C")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
