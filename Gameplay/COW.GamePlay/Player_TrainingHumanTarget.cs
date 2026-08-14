using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000977")]
internal class Player_TrainingHumanTarget : Player
{
	[Token(Token = "0x4005861")]
	[FieldOffset(Offset = "0x998")]
	private bool FDCJILJLAFE;

	[Token(Token = "0x4005862")]
	[FieldOffset(Offset = "0x99C")]
	private Camera CHDOHNOEBML;

	[Token(Token = "0x4005863")]
	[FieldOffset(Offset = "0x9A0")]
	private float HPFICPAOHGC;

	[Token(Token = "0x600481E")]
	[Address(RVA = "0x2115234", Offset = "0x2115234", VA = "0x2115234")]
	public Player_TrainingHumanTarget()
	{
	}

	[Token(Token = "0x600481F")]
	[Address(RVA = "0x21152C0", Offset = "0x21152C0", VA = "0x21152C0", Slot = "110")]
	public override void OnPlayerBeTouch()
	{
	}

	[Token(Token = "0x6004820")]
	[Address(RVA = "0x21153CC", Offset = "0x21153CC", VA = "0x21153CC", Slot = "104")]
	protected override void DPLMGOJKKCM()
	{
	}

	[Token(Token = "0x6004821")]
	[Address(RVA = "0x21154A4", Offset = "0x21154A4", VA = "0x21154A4", Slot = "124")]
	public override int TakeDamage(int KOCMLPLOILD, IHAAMHPPLMG HLJDHPGGODB, [Optional] ELMGJKHIIAA JIIJIFKKCCB, int BOEIBGAABDL = -1, [Optional] Vector3 NJMFBKNHMBP, [Optional] Vector3 DOBOBMFMKBJ, [Optional] List<float> NBKBEBFNDBE, [Optional] MKFEKBKJCKE OPINPCANMDE, uint GGIDKOBOJBB = 0u)
	{
		return default(int);
	}

	[Token(Token = "0x6004822")]
	[Address(RVA = "0x2115D5C", Offset = "0x2115D5C", VA = "0x2115D5C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6004823")]
	[Address(RVA = "0x2116114", Offset = "0x2116114", VA = "0x2116114")]
	private void DLGGPKBPMKN()
	{
	}

	[Token(Token = "0x6004824")]
	[Address(RVA = "0x2116318", Offset = "0x2116318", VA = "0x2116318", Slot = "51")]
	public override bool NeedAssit()
	{
		return default(bool);
	}

	[Token(Token = "0x6004825")]
	[Address(RVA = "0x2116370", Offset = "0x2116370", VA = "0x2116370", Slot = "52")]
	public override bool CanAssitByWeapon(Player DEKAHNJALPI, GPBDEDFKJNA LPGPKFMGCBG)
	{
		return default(bool);
	}

	[Token(Token = "0x6004826")]
	[Address(RVA = "0x21164A4", Offset = "0x21164A4", VA = "0x21164A4")]
	public void _003C_003EiFixBaseProxy_OnPlayerBeTouch()
	{
	}

	[Token(Token = "0x6004827")]
	[Address(RVA = "0x21164AC", Offset = "0x21164AC", VA = "0x21164AC")]
	public void _003C_003EiFixBaseProxy_DPLMGOJKKCM()
	{
	}

	[Token(Token = "0x6004828")]
	[Address(RVA = "0x21164B4", Offset = "0x21164B4", VA = "0x21164B4")]
	public int _003C_003EiFixBaseProxy_TakeDamage(int P0, IHAAMHPPLMG P1, ELMGJKHIIAA P2, int P3, Vector3 P4, Vector3 P5, List<float> P6, MKFEKBKJCKE P7, uint P8)
	{
		return default(int);
	}

	[Token(Token = "0x6004829")]
	[Address(RVA = "0x211653C", Offset = "0x211653C", VA = "0x211653C")]
	public bool _003C_003EiFixBaseProxy_NeedAssit()
	{
		return default(bool);
	}

	[Token(Token = "0x600482A")]
	[Address(RVA = "0x2116544", Offset = "0x2116544", VA = "0x2116544")]
	public new bool _003C_003EiFixBaseProxy_CanAssitByWeapon(Player P0, GPBDEDFKJNA P1)
	{
		return default(bool);
	}
}
