using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x20003C3")]
internal class Airdrop : AttackableEntity
{
	[Token(Token = "0x20003C4")]
	public enum IKILBBLDGCL
	{
		[Token(Token = "0x4003877")]
		AIRDROPNORMAL,
		[Token(Token = "0x4003878")]
		AIRDROPPACKAGE
	}

	[Token(Token = "0x20003C5")]
	private class HHCBNAPCKHF : ShadowStateBase
	{
		[Token(Token = "0x4003879")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 PGDEDHFOMCN;

		[Token(Token = "0x400387A")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion BPLOAFBIHJL;

		[Token(Token = "0x400387B")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 JHJLNLCEGOG;

		[Token(Token = "0x400387C")]
		[FieldOffset(Offset = "0x38")]
		public Quaternion FBMPKHMBHAM;

		[Token(Token = "0x400387D")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 LMNBBBCKMGB;

		[Token(Token = "0x60010C8")]
		[Address(RVA = "0x1139C48", Offset = "0x1139C48", VA = "0x1139C48")]
		public HHCBNAPCKHF()
		{
		}
	}

	[Token(Token = "0x400386A")]
	[FieldOffset(Offset = "0x48")]
	public Animator m_AirdropAnim;

	[Token(Token = "0x400386B")]
	[FieldOffset(Offset = "0x4C")]
	protected uint KINJCKMOGIM;

	[Token(Token = "0x400386C")]
	[FieldOffset(Offset = "0x50")]
	protected Vector3 LPJGJCMGKPI;

	[Token(Token = "0x400386D")]
	[FieldOffset(Offset = "0x5C")]
	protected Vector3 FGBDMMJEHBB;

	[Token(Token = "0x400386E")]
	[FieldOffset(Offset = "0x68")]
	private HHCBNAPCKHF PLGAAJABBHA;

	[Token(Token = "0x400386F")]
	[FieldOffset(Offset = "0x6C")]
	private bool AEBAGGBJJME;

	[Token(Token = "0x4003870")]
	[FieldOffset(Offset = "0x70")]
	private Queue<Vector3> FHGEKDFLHCJ;

	[Token(Token = "0x4003871")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 PAFCJPKBBNO;

	[Token(Token = "0x4003872")]
	[FieldOffset(Offset = "0x80")]
	private bool _003CCFKOAEGPEMG_003Ek__BackingField;

	[Token(Token = "0x4003873")]
	[FieldOffset(Offset = "0x81")]
	public bool IsLanding;

	[Token(Token = "0x4003874")]
	[FieldOffset(Offset = "0x84")]
	protected uint CCHLODMLGGC;

	[Token(Token = "0x4003875")]
	[FieldOffset(Offset = "0x88")]
	private bool KDJCFMAIBOA;

	[Token(Token = "0x17000194")]
	public bool DHHKDDPOGNH
	{
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0x1139C58", Offset = "0x1139C58", VA = "0x1139C58")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x1139C60", Offset = "0x1139C60", VA = "0x1139C60")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000195")]
	public uint OGFHJKCOCIK
	{
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x1139C68", Offset = "0x1139C68", VA = "0x1139C68")]
		set
		{
		}
	}

	[Token(Token = "0x60010BA")]
	[Address(RVA = "0x1139B0C", Offset = "0x1139B0C", VA = "0x1139B0C")]
	public Airdrop()
	{
	}

	[Token(Token = "0x60010BE")]
	[Address(RVA = "0x1139CC8", Offset = "0x1139CC8", VA = "0x1139CC8", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x1139F74", Offset = "0x1139F74", VA = "0x1139F74", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60010C0")]
	[Address(RVA = "0x1139FCC", Offset = "0x1139FCC", VA = "0x1139FCC", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60010C1")]
	[Address(RVA = "0x113A734", Offset = "0x113A734", VA = "0x113A734", Slot = "61")]
	public virtual void PushSyncState(IGGJJLFFJKB HKAABMDNNAG, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x60010C2")]
	[Address(RVA = "0x113ABC8", Offset = "0x113ABC8", VA = "0x113ABC8")]
	public void PlayAnimInWater()
	{
	}

	[Token(Token = "0x60010C3")]
	[Address(RVA = "0x113ACB4", Offset = "0x113ACB4", VA = "0x113ACB4", Slot = "62")]
	public virtual void SyncReEnter()
	{
	}

	[Token(Token = "0x60010C4")]
	[Address(RVA = "0x113AD08", Offset = "0x113AD08", VA = "0x113AD08", Slot = "63")]
	public virtual IKILBBLDGCL GetAiropDropType()
	{
		return default(IKILBBLDGCL);
	}

	[Token(Token = "0x60010C5")]
	[Address(RVA = "0x113A37C", Offset = "0x113A37C", VA = "0x113A37C")]
	private void DHAOFNAJCLK()
	{
	}

	[Token(Token = "0x60010C6")]
	[Address(RVA = "0x113AD60", Offset = "0x113AD60", VA = "0x113AD60")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x60010C7")]
	[Address(RVA = "0x113AD68", Offset = "0x113AD68", VA = "0x113AD68")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
