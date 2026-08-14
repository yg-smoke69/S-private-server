using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006E7")]
public class LevelWheelRoll : BaseLevelObject
{
	[Token(Token = "0x20006E8")]
	private class HHCBNAPCKHF : ShadowStateBase
	{
		[Token(Token = "0x4004B50")]
		[FieldOffset(Offset = "0x10")]
		public float JCCLHMHKMJD;

		[Token(Token = "0x4004B51")]
		[FieldOffset(Offset = "0x14")]
		public float FDIAGFBGDLM;

		[Token(Token = "0x4004B52")]
		[FieldOffset(Offset = "0x18")]
		public float OCLICBDGBHD;

		[Token(Token = "0x4004B53")]
		[FieldOffset(Offset = "0x1C")]
		public float EBKKMCEAELO;

		[Token(Token = "0x6002C2F")]
		[Address(RVA = "0x243B038", Offset = "0x243B038", VA = "0x243B038")]
		public HHCBNAPCKHF()
		{
		}
	}

	[Token(Token = "0x4004B47")]
	[FieldOffset(Offset = "0x74")]
	public GameObject ZoneTrigger;

	[Token(Token = "0x4004B48")]
	[FieldOffset(Offset = "0x78")]
	public GameObject Platform;

	[Token(Token = "0x4004B49")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject Stick;

	[Token(Token = "0x4004B4A")]
	[FieldOffset(Offset = "0x80")]
	public Collider StickTrigger;

	[Token(Token = "0x4004B4B")]
	[FieldOffset(Offset = "0x84")]
	public GameObject ScoreZone;

	[Token(Token = "0x4004B4C")]
	[FieldOffset(Offset = "0x88")]
	public GameObject StickVFX;

	[Token(Token = "0x4004B4D")]
	[FieldOffset(Offset = "0x8C")]
	private bool PLBAMNHHEMG;

	[Token(Token = "0x4004B4E")]
	[FieldOffset(Offset = "0x90")]
	private HHCBNAPCKHF PLGAAJABBHA;

	[Token(Token = "0x4004B4F")]
	[FieldOffset(Offset = "0x94")]
	private uint KINJCKMOGIM;

	[Token(Token = "0x6002C25")]
	[Address(RVA = "0x243AFBC", Offset = "0x243AFBC", VA = "0x243AFBC")]
	public LevelWheelRoll()
	{
	}

	[Token(Token = "0x6002C26")]
	[Address(RVA = "0x243B040", Offset = "0x243B040", VA = "0x243B040", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002C27")]
	[Address(RVA = "0x243B0E4", Offset = "0x243B0E4", VA = "0x243B0E4", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002C28")]
	[Address(RVA = "0x243B230", Offset = "0x243B230", VA = "0x243B230", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002C29")]
	[Address(RVA = "0x243B5C8", Offset = "0x243B5C8", VA = "0x243B5C8", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002C2A")]
	[Address(RVA = "0x243B91C", Offset = "0x243B91C", VA = "0x243B91C")]
	public void Run()
	{
	}

	[Token(Token = "0x6002C2B")]
	[Address(RVA = "0x243B9E0", Offset = "0x243B9E0", VA = "0x243B9E0")]
	public void Stop()
	{
	}

	[Token(Token = "0x6002C2C")]
	[Address(RVA = "0x243BAA4", Offset = "0x243BAA4", VA = "0x243BAA4")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002C2D")]
	[Address(RVA = "0x243BAAC", Offset = "0x243BAAC", VA = "0x243BAAC")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6002C2E")]
	[Address(RVA = "0x243BAB4", Offset = "0x243BAB4", VA = "0x243BAB4")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
