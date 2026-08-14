using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x20005CB")]
internal class IceWall : AttackableEntity
{
	[Token(Token = "0x40043D8")]
	[FieldOffset(Offset = "0x48")]
	private LevelIceWall JIEGJMIPACH;

	[Token(Token = "0x40043D9")]
	[FieldOffset(Offset = "0x4C")]
	private uint ECIFAJLEAPM;

	[Token(Token = "0x40043DA")]
	[FieldOffset(Offset = "0x50")]
	private int CJFLCJKEIME;

	[Token(Token = "0x170002DD")]
	public LevelIceWall PFBKKPOBHKK
	{
		[Token(Token = "0x6002307")]
		[Address(RVA = "0x198B12C", Offset = "0x198B12C", VA = "0x198B12C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002DE")]
	public int DCEJIKEGCJL
	{
		[Token(Token = "0x6002309")]
		[Address(RVA = "0x198B1DC", Offset = "0x198B1DC", VA = "0x198B1DC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002306")]
	[Address(RVA = "0x198B124", Offset = "0x198B124", VA = "0x198B124")]
	public IceWall()
	{
	}

	[Token(Token = "0x6002308")]
	[Address(RVA = "0x198B184", Offset = "0x198B184", VA = "0x198B184", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x600230A")]
	[Address(RVA = "0x198B2DC", Offset = "0x198B2DC", VA = "0x198B2DC")]
	internal void DPLMGOJKKCM(LevelIceWall KFMFPPHFIIE, bool BHFPOONGALP, int GLDOFPCMPLM)
	{
	}

	[Token(Token = "0x600230B")]
	[Address(RVA = "0x198B384", Offset = "0x198B384", VA = "0x198B384")]
	public void TakeDamageByVehicle(int JLKLMFHFHFF, IHAAMHPPLMG KAEHJEGFKBL, DBNMCJLEFJI JPLHIDNDING, int BOEIBGAABDL)
	{
	}

	[Token(Token = "0x600230C")]
	[Address(RVA = "0x198B59C", Offset = "0x198B59C", VA = "0x198B59C", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x600230D")]
	[Address(RVA = "0x198BA10", Offset = "0x198BA10", VA = "0x198BA10")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
