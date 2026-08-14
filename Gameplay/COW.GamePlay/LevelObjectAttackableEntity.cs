using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000418")]
internal class LevelObjectAttackableEntity : AttackableEntity
{
	[Token(Token = "0x4003AF6")]
	[FieldOffset(Offset = "0x48")]
	private BaseLevelObject NLAGANLNILL;

	[Token(Token = "0x6001426")]
	[Address(RVA = "0x24CE47C", Offset = "0x24CE47C", VA = "0x24CE47C")]
	public LevelObjectAttackableEntity()
	{
	}

	[Token(Token = "0x6001427")]
	[Address(RVA = "0x24CE484", Offset = "0x24CE484", VA = "0x24CE484")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001428")]
	[Address(RVA = "0x24CE534", Offset = "0x24CE534", VA = "0x24CE534", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6001429")]
	[Address(RVA = "0x24CE58C", Offset = "0x24CE58C", VA = "0x24CE58C", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x600142A")]
	[Address(RVA = "0x24CE64C", Offset = "0x24CE64C", VA = "0x24CE64C", Slot = "55")]
	public override void TakeHealing(int EDEOPLNOGPP, IHAAMHPPLMG ONPMGNIIMJD, int OIFJAJJFBLK, [Optional] Vector3 NJMFBKNHMBP, [Optional] Vector3 DOBOBMFMKBJ, [Optional] List<float> NBKBEBFNDBE)
	{
	}

	[Token(Token = "0x600142B")]
	[Address(RVA = "0x24CE7D4", Offset = "0x24CE7D4", VA = "0x24CE7D4")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}

	[Token(Token = "0x600142C")]
	[Address(RVA = "0x24CE7F8", Offset = "0x24CE7F8", VA = "0x24CE7F8")]
	public void _003C_003EiFixBaseProxy_TakeHealing(int P0, IHAAMHPPLMG P1, int P2, Vector3 P3, Vector3 P4, List<float> P5)
	{
	}
}
