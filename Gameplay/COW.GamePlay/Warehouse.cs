using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x2000733")]
internal class Warehouse : AttackableEntity
{
	[Token(Token = "0x4004CA4")]
	[FieldOffset(Offset = "0x48")]
	private LevelWareHouse FICCGKBFDHD;

	[Token(Token = "0x4004CA5")]
	[FieldOffset(Offset = "0x4C")]
	private uint ECIFAJLEAPM;

	[Token(Token = "0x4004CA6")]
	[FieldOffset(Offset = "0x50")]
	private uint AMMCBAKJEAD;

	[Token(Token = "0x6002D97")]
	[Address(RVA = "0x26F446C", Offset = "0x26F446C", VA = "0x26F446C")]
	public Warehouse()
	{
	}

	[Token(Token = "0x6002D98")]
	[Address(RVA = "0x26F4474", Offset = "0x26F4474", VA = "0x26F4474", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002D99")]
	[Address(RVA = "0x26F44CC", Offset = "0x26F44CC", VA = "0x26F44CC")]
	internal void DPLMGOJKKCM(LevelWareHouse CDGDDDAOFEG)
	{
	}

	[Token(Token = "0x6002D9A")]
	[Address(RVA = "0x26F45F0", Offset = "0x26F45F0", VA = "0x26F45F0")]
	public uint GetTeamIndex()
	{
		return default(uint);
	}

	[Token(Token = "0x6002D9B")]
	[Address(RVA = "0x26F4648", Offset = "0x26F4648", VA = "0x26F4648")]
	public bool IsMyTeam(int OOLNKDGDDCE)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D9C")]
	[Address(RVA = "0x26F4758", Offset = "0x26F4758", VA = "0x26F4758")]
	public int GetCurHP()
	{
		return default(int);
	}

	[Token(Token = "0x6002D9D")]
	[Address(RVA = "0x26F4858", Offset = "0x26F4858", VA = "0x26F4858", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x6002D9E")]
	[Address(RVA = "0x26F4B7C", Offset = "0x26F4B7C", VA = "0x26F4B7C")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
