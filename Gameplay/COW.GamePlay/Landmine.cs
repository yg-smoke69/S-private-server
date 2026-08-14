using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x20005D3")]
internal class Landmine : AttackableEntity
{
	[Token(Token = "0x400440A")]
	[FieldOffset(Offset = "0x48")]
	private LevelLandmine PPNOFPOLHMF;

	[Token(Token = "0x600232B")]
	[Address(RVA = "0x17D4AE8", Offset = "0x17D4AE8", VA = "0x17D4AE8")]
	public Landmine()
	{
	}

	[Token(Token = "0x600232C")]
	[Address(RVA = "0x17D4AF0", Offset = "0x17D4AF0", VA = "0x17D4AF0", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x600232D")]
	[Address(RVA = "0x17D4B48", Offset = "0x17D4B48", VA = "0x17D4B48")]
	internal void DPLMGOJKKCM(LevelLandmine PEPGLDLKIHC)
	{
	}

	[Token(Token = "0x600232E")]
	[Address(RVA = "0x17D4BA8", Offset = "0x17D4BA8", VA = "0x17D4BA8", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x600232F")]
	[Address(RVA = "0x17D4E94", Offset = "0x17D4E94", VA = "0x17D4E94")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
