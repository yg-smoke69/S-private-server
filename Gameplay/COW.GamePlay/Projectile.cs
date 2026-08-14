using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000A52")]
internal class Projectile : AttackableEntity
{
	[Token(Token = "0x2000A53")]
	protected class HHCBNAPCKHF : ShadowStateBase
	{
		[Token(Token = "0x4005BAD")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 PGDEDHFOMCN;

		[Token(Token = "0x4005BAE")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion BPLOAFBIHJL;

		[Token(Token = "0x4005BAF")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 JHJLNLCEGOG;

		[Token(Token = "0x4005BB0")]
		[FieldOffset(Offset = "0x38")]
		public Quaternion FBMPKHMBHAM;

		[Token(Token = "0x4005BB1")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 LMNBBBCKMGB;

		[Token(Token = "0x600501D")]
		[Address(RVA = "0x21187F8", Offset = "0x21187F8", VA = "0x21187F8")]
		public HHCBNAPCKHF()
		{
		}
	}

	[Token(Token = "0x4005BA8")]
	[FieldOffset(Offset = "0x48")]
	protected uint KINJCKMOGIM;

	[Token(Token = "0x4005BA9")]
	[FieldOffset(Offset = "0x4C")]
	protected HHCBNAPCKHF PLGAAJABBHA;

	[Token(Token = "0x4005BAA")]
	[FieldOffset(Offset = "0x50")]
	private bool AEBAGGBJJME;

	[Token(Token = "0x4005BAB")]
	[FieldOffset(Offset = "0x54")]
	private Queue<Vector3> FHGEKDFLHCJ;

	[Token(Token = "0x4005BAC")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 PAFCJPKBBNO;

	[Token(Token = "0x6005014")]
	[Address(RVA = "0x21186FC", Offset = "0x21186FC", VA = "0x21186FC")]
	public Projectile()
	{
	}

	[Token(Token = "0x6005015")]
	[Address(RVA = "0x2118800", Offset = "0x2118800", VA = "0x2118800", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6005016")]
	[Address(RVA = "0x2118AAC", Offset = "0x2118AAC", VA = "0x2118AAC", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6005017")]
	[Address(RVA = "0x2118B04", Offset = "0x2118B04", VA = "0x2118B04", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6005018")]
	[Address(RVA = "0x2118D9C", Offset = "0x2118D9C", VA = "0x2118D9C", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6005019")]
	[Address(RVA = "0x2118E0C", Offset = "0x2118E0C", VA = "0x2118E0C")]
	public void PushSyncState(JNOJFPCMHMA HKAABMDNNAG, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x600501A")]
	[Address(RVA = "0x211927C", Offset = "0x211927C", VA = "0x211927C")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x600501B")]
	[Address(RVA = "0x2119284", Offset = "0x2119284", VA = "0x2119284")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x600501C")]
	[Address(RVA = "0x211928C", Offset = "0x211928C", VA = "0x211928C")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}
}
