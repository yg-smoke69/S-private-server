using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200068D")]
public class LevelRevivePoint : BaseLevelObject
{
	[Token(Token = "0x400488F")]
	[FieldOffset(Offset = "0x74")]
	public string ShowName;

	[Token(Token = "0x4004890")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_Collider;

	[Token(Token = "0x4004891")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject m_EffectGO;

	[Token(Token = "0x4004892")]
	[FieldOffset(Offset = "0x80")]
	public Collider m_ReviveInteractCollider;

	[Token(Token = "0x4004893")]
	[FieldOffset(Offset = "0x84")]
	public GameObject m_LaserGo;

	[Token(Token = "0x4004894")]
	[FieldOffset(Offset = "0x88")]
	public GameObject DestroyWhenAwake;

	[Token(Token = "0x4004895")]
	[FieldOffset(Offset = "0x8C")]
	public Color[] ActivatedStateColorArray;

	[Token(Token = "0x4004896")]
	[FieldOffset(Offset = "0x90")]
	public Color[] CapturedStateColorArray;

	[Token(Token = "0x4004897")]
	[FieldOffset(Offset = "0x94")]
	public Color[] CoolDownStateColorArray;

	[Token(Token = "0x4004898")]
	[FieldOffset(Offset = "0x98")]
	private byte GNGJCMKMDFD;

	[Token(Token = "0x4004899")]
	[FieldOffset(Offset = "0x9C")]
	private HMBBLFKNGGM ILGECLEFCCO;

	[Token(Token = "0x400489A")]
	[FieldOffset(Offset = "0xA0")]
	private Color[] NBMELFHOEIF;

	[Token(Token = "0x60029FD")]
	[Address(RVA = "0x20C97E0", Offset = "0x20C97E0", VA = "0x20C97E0")]
	public LevelRevivePoint()
	{
	}

	[Token(Token = "0x60029FE")]
	[Address(RVA = "0x20C9854", Offset = "0x20C9854", VA = "0x20C9854", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60029FF")]
	[Address(RVA = "0x20C9978", Offset = "0x20C9978", VA = "0x20C9978", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002A00")]
	[Address(RVA = "0x20C9A1C", Offset = "0x20C9A1C", VA = "0x20C9A1C", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002A01")]
	[Address(RVA = "0x20C9A74", Offset = "0x20C9A74", VA = "0x20C9A74", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002A02")]
	[Address(RVA = "0x20C9DD8", Offset = "0x20C9DD8", VA = "0x20C9DD8", Slot = "40")]
	protected virtual void DEINIPGNACC(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002A03")]
	[Address(RVA = "0x20CA094", Offset = "0x20CA094", VA = "0x20CA094", Slot = "41")]
	protected virtual void JLFBMKILCBE(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002A04")]
	[Address(RVA = "0x20CAB60", Offset = "0x20CAB60", VA = "0x20CAB60", Slot = "42")]
	protected virtual void HAJMDMKJPHK(int JGLJDJFHPBO, int DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002A05")]
	[Address(RVA = "0x20CB044", Offset = "0x20CB044", VA = "0x20CB044")]
	private bool JJEPEDHOIDP()
	{
		return default(bool);
	}

	[Token(Token = "0x6002A06")]
	[Address(RVA = "0x20CB4A4", Offset = "0x20CB4A4", VA = "0x20CB4A4")]
	private bool LPLFCPDFDEH()
	{
		return default(bool);
	}

	[Token(Token = "0x6002A07")]
	[Address(RVA = "0x20CB510", Offset = "0x20CB510", VA = "0x20CB510")]
	public void OnLocalPlayerEnter()
	{
	}

	[Token(Token = "0x6002A08")]
	[Address(RVA = "0x20CB8B4", Offset = "0x20CB8B4", VA = "0x20CB8B4")]
	public void OnLocalPlayerExit()
	{
	}

	[Token(Token = "0x6002A09")]
	[Address(RVA = "0x20CBAD0", Offset = "0x20CBAD0", VA = "0x20CBAD0", Slot = "23")]
	protected override void OnUpdateVisibleStateByStreamer(Vector3 MKGCDPNKMOB, Vector3 OANAHFHPBNB)
	{
	}

	[Token(Token = "0x6002A0A")]
	[Address(RVA = "0x20CA010", Offset = "0x20CA010", VA = "0x20CA010")]
	private void CEHHLMFFNEL()
	{
	}

	[Token(Token = "0x6002A0B")]
	[Address(RVA = "0x20CB0B0", Offset = "0x20CB0B0", VA = "0x20CB0B0")]
	private void CEHHLMFFNEL(Color[] NHJFJGEGMNF)
	{
	}

	[Token(Token = "0x6002A0C")]
	[Address(RVA = "0x20CBC88", Offset = "0x20CBC88", VA = "0x20CBC88")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x6002A0D")]
	[Address(RVA = "0x20CBC90", Offset = "0x20CBC90", VA = "0x20CBC90")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002A0E")]
	[Address(RVA = "0x20CBC98", Offset = "0x20CBC98", VA = "0x20CBC98")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002A0F")]
	[Address(RVA = "0x20CBCA0", Offset = "0x20CBCA0", VA = "0x20CBCA0")]
	public void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}
}
