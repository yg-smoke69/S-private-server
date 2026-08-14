using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006B7")]
public class LevelTimingTreasureBox : BaseLevelObject
{
	[Token(Token = "0x20006B8")]
	public enum JNCMCDACLGC
	{
		[Token(Token = "0x4004A7E")]
		Add,
		[Token(Token = "0x4004A7F")]
		Destroy
	}

	[Token(Token = "0x4004A79")]
	[FieldOffset(Offset = "0x74")]
	public BoxCollider m_TriggerCollider;

	[Token(Token = "0x4004A7A")]
	[FieldOffset(Offset = "0x78")]
	private Transform ECAIILDGOJI;

	[Token(Token = "0x4004A7B")]
	[FieldOffset(Offset = "0x7C")]
	private float NFFPPEFGKNB;

	[Token(Token = "0x4004A7C")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 FDNIDIPEAPA;

	[Token(Token = "0x1700034A")]
	public bool APLGPNDGBOI
	{
		[Token(Token = "0x6002B27")]
		[Address(RVA = "0x2423C34", Offset = "0x2423C34", VA = "0x2423C34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002B22")]
	[Address(RVA = "0x242379C", Offset = "0x242379C", VA = "0x242379C")]
	public LevelTimingTreasureBox()
	{
	}

	[Token(Token = "0x6002B23")]
	[Address(RVA = "0x24237A4", Offset = "0x24237A4", VA = "0x24237A4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002B24")]
	[Address(RVA = "0x2423848", Offset = "0x2423848", VA = "0x2423848")]
	private void Start()
	{
	}

	[Token(Token = "0x6002B25")]
	[Address(RVA = "0x2423960", Offset = "0x2423960", VA = "0x2423960", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002B26")]
	[Address(RVA = "0x2423BDC", Offset = "0x2423BDC", VA = "0x2423BDC", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002B28")]
	[Address(RVA = "0x2423D58", Offset = "0x2423D58", VA = "0x2423D58", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002B29")]
	[Address(RVA = "0x2423E38", Offset = "0x2423E38", VA = "0x2423E38", Slot = "40")]
	protected virtual void OHNFIEMCCFF(bool JGLJDJFHPBO, bool DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002B2A")]
	[Address(RVA = "0x24240E4", Offset = "0x24240E4", VA = "0x24240E4")]
	private void AKOEDIJANFD(bool CKOHPBPLHCO)
	{
	}

	[Token(Token = "0x6002B2B")]
	[Address(RVA = "0x2424310", Offset = "0x2424310", VA = "0x2424310", Slot = "41")]
	protected virtual void HGPJDDNDLFE(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002B2C")]
	[Address(RVA = "0x24243A8", Offset = "0x24243A8", VA = "0x24243A8")]
	public bool CanOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6002B2D")]
	[Address(RVA = "0x242440C", Offset = "0x242440C", VA = "0x242440C")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002B2E")]
	[Address(RVA = "0x2424414", Offset = "0x2424414", VA = "0x2424414")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002B2F")]
	[Address(RVA = "0x242441C", Offset = "0x242441C", VA = "0x242441C")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
