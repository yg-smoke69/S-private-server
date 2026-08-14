using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005B8")]
internal class BoxingMachine : AttackableEntity
{
	[Token(Token = "0x4004395")]
	[FieldOffset(Offset = "0x48")]
	public GameObject VFX_ScoreContainer;

	[Token(Token = "0x4004396")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject VFX_HitContainer;

	[Token(Token = "0x60022B8")]
	[Address(RVA = "0x13B6A64", Offset = "0x13B6A64", VA = "0x13B6A64")]
	public BoxingMachine()
	{
	}

	[Token(Token = "0x60022B9")]
	[Address(RVA = "0x13B6A6C", Offset = "0x13B6A6C", VA = "0x13B6A6C", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60022BA")]
	[Address(RVA = "0x13B6AC4", Offset = "0x13B6AC4", VA = "0x13B6AC4", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x60022BB")]
	[Address(RVA = "0x13B6D80", Offset = "0x13B6D80", VA = "0x13B6D80")]
	private void EBPJNGPOFMG()
	{
	}

	[Token(Token = "0x60022BC")]
	[Address(RVA = "0x13B6E78", Offset = "0x13B6E78", VA = "0x13B6E78")]
	private void BGCNDECEKIG(ResourceID GJMJJFAOBEL, ResourceID DDDJHDHBFJB, Transform PHLFBBIAEFE)
	{
	}

	[Token(Token = "0x60022BD")]
	[Address(RVA = "0x13B7344", Offset = "0x13B7344", VA = "0x13B7344")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
