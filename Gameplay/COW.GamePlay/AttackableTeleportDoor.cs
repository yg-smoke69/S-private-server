using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x20006B3")]
internal class AttackableTeleportDoor : AttackableEntity
{
	[Token(Token = "0x4004A6B")]
	[FieldOffset(Offset = "0x48")]
	private LevelTeleportDoor JLEJNIBALHD;

	[Token(Token = "0x6002B0A")]
	[Address(RVA = "0x1142A88", Offset = "0x1142A88", VA = "0x1142A88")]
	public AttackableTeleportDoor()
	{
	}

	[Token(Token = "0x6002B0B")]
	[Address(RVA = "0x1142A90", Offset = "0x1142A90", VA = "0x1142A90")]
	public void SetLevelObject(LevelTeleportDoor KIFMOAJDADA)
	{
	}

	[Token(Token = "0x6002B0C")]
	[Address(RVA = "0x1142AF0", Offset = "0x1142AF0", VA = "0x1142AF0", Slot = "59")]
	public override uint GetAttackableID()
	{
		return default(uint);
	}

	[Token(Token = "0x6002B0D")]
	[Address(RVA = "0x1142B68", Offset = "0x1142B68", VA = "0x1142B68")]
	public int GetCurHP()
	{
		return default(int);
	}

	[Token(Token = "0x6002B0E")]
	[Address(RVA = "0x1142C68", Offset = "0x1142C68", VA = "0x1142C68")]
	public void SetHP(int LBMGGMBKAEH)
	{
	}

	[Token(Token = "0x6002B0F")]
	[Address(RVA = "0x1142CEC", Offset = "0x1142CEC", VA = "0x1142CEC", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002B10")]
	[Address(RVA = "0x1142D44", Offset = "0x1142D44", VA = "0x1142D44", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint EMFANFHKAMM = 0u)
	{
	}

	[Token(Token = "0x6002B11")]
	[Address(RVA = "0x1143078", Offset = "0x1143078", VA = "0x1143078")]
	public uint _003C_003EiFixBaseProxy_GetAttackableID()
	{
		return default(uint);
	}

	[Token(Token = "0x6002B12")]
	[Address(RVA = "0x114307C", Offset = "0x114307C", VA = "0x114307C")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
