using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200060D")]
public class LevelDoor : BaseLevelObject
{
	[Token(Token = "0x200060E")]
	public enum GKACJCLGANB
	{
		[Token(Token = "0x40045A8")]
		Door_X,
		[Token(Token = "0x40045A9")]
		Door_Y,
		[Token(Token = "0x40045AA")]
		Door_Z
	}

	[Token(Token = "0x400459A")]
	[FieldOffset(Offset = "0x74")]
	public GKACJCLGANB OpenAxis;

	[Token(Token = "0x400459B")]
	[FieldOffset(Offset = "0x78")]
	public Transform m_DoorObjectTF;

	[Token(Token = "0x400459C")]
	[FieldOffset(Offset = "0x7C")]
	public float ANGLE;

	[Token(Token = "0x400459D")]
	[FieldOffset(Offset = "0x80")]
	public float RotAngleSpeed;

	[Token(Token = "0x400459E")]
	[FieldOffset(Offset = "0x84")]
	public uint InitHealth;

	[Token(Token = "0x400459F")]
	[FieldOffset(Offset = "0x88")]
	public int CostCoin;

	[Token(Token = "0x40045A0")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 BFDNCOKJDGE;

	[Token(Token = "0x40045A1")]
	[FieldOffset(Offset = "0x98")]
	private bool LDMKONMOOJE;

	[Token(Token = "0x40045A2")]
	[FieldOffset(Offset = "0x9C")]
	private Quaternion IMCNIADHMBM;

	[Token(Token = "0x40045A3")]
	[FieldOffset(Offset = "0xAC")]
	private Quaternion GNIIFAJIBFO;

	[Token(Token = "0x40045A4")]
	[FieldOffset(Offset = "0xBC")]
	private Quaternion HICENHCBBLI;

	[Token(Token = "0x40045A5")]
	[FieldOffset(Offset = "0xCC")]
	private float APBFHBNCBAO;

	[Token(Token = "0x40045A6")]
	[FieldOffset(Offset = "0xD0")]
	private float FEADEJNPFDP;

	[Token(Token = "0x170002ED")]
	public bool APLGPNDGBOI
	{
		[Token(Token = "0x6002561")]
		[Address(RVA = "0x2715CB0", Offset = "0x2715CB0", VA = "0x2715CB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002562")]
		[Address(RVA = "0x2715DD4", Offset = "0x2715DD4", VA = "0x2715DD4")]
		set
		{
		}
	}

	[Token(Token = "0x170002EE")]
	public uint NIBCOPDOMMG
	{
		[Token(Token = "0x6002563")]
		[Address(RVA = "0x2716C7C", Offset = "0x2716C7C", VA = "0x2716C7C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6002564")]
		[Address(RVA = "0x2716DA0", Offset = "0x2716DA0", VA = "0x2716DA0")]
		set
		{
		}
	}

	[Token(Token = "0x6002554")]
	[Address(RVA = "0x27156EC", Offset = "0x27156EC", VA = "0x27156EC")]
	public LevelDoor()
	{
	}

	[Token(Token = "0x6002555")]
	[Address(RVA = "0x27157B0", Offset = "0x27157B0", VA = "0x27157B0", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6002556")]
	[Address(RVA = "0x2715994", Offset = "0x2715994", VA = "0x2715994", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002557")]
	[Address(RVA = "0x2715EFC", Offset = "0x2715EFC", VA = "0x2715EFC")]
	private void OLPEJLAKHIJ(bool JOGHOHLEJFL)
	{
	}

	[Token(Token = "0x6002558")]
	[Address(RVA = "0x2716940", Offset = "0x2716940", VA = "0x2716940", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002559")]
	[Address(RVA = "0x2716184", Offset = "0x2716184", VA = "0x2716184")]
	private void BPHDKABJFPK(float IPJKJPPFBIO)
	{
	}

	[Token(Token = "0x600255A")]
	[Address(RVA = "0x2716670", Offset = "0x2716670", VA = "0x2716670")]
	private void GJPOAIMPFFN()
	{
	}

	[Token(Token = "0x600255B")]
	[Address(RVA = "0x2716308", Offset = "0x2716308", VA = "0x2716308")]
	private void OMHBPHIEPKG()
	{
	}

	[Token(Token = "0x600255C")]
	[Address(RVA = "0x2716A3C", Offset = "0x2716A3C", VA = "0x2716A3C")]
	public bool IsMoving()
	{
		return default(bool);
	}

	[Token(Token = "0x600255D")]
	[Address(RVA = "0x2716A94", Offset = "0x2716A94", VA = "0x2716A94", Slot = "37")]
	public override void TakeDamage(int JLKLMFHFHFF)
	{
	}

	[Token(Token = "0x600255E")]
	[Address(RVA = "0x2716EC8", Offset = "0x2716EC8", VA = "0x2716EC8")]
	private void KAMKGHOICOE()
	{
	}

	[Token(Token = "0x600255F")]
	[Address(RVA = "0x2715C48", Offset = "0x2715C48", VA = "0x2715C48")]
	public bool IsAlive()
	{
		return default(bool);
	}

	[Token(Token = "0x6002560")]
	[Address(RVA = "0x2717380", Offset = "0x2717380", VA = "0x2717380", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002565")]
	[Address(RVA = "0x2717424", Offset = "0x2717424", VA = "0x2717424", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002566")]
	[Address(RVA = "0x27176A4", Offset = "0x27176A4", VA = "0x27176A4", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002567")]
	[Address(RVA = "0x27176FC", Offset = "0x27176FC", VA = "0x27176FC", Slot = "40")]
	protected virtual void OHNFIEMCCFF(bool JGLJDJFHPBO, bool DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002568")]
	[Address(RVA = "0x2717780", Offset = "0x2717780", VA = "0x2717780", Slot = "41")]
	protected virtual void DACNDAKPDKA(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002569")]
	[Address(RVA = "0x271780C", Offset = "0x271780C", VA = "0x271780C")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x600256A")]
	[Address(RVA = "0x2717814", Offset = "0x2717814", VA = "0x2717814")]
	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	[Token(Token = "0x600256B")]
	[Address(RVA = "0x271781C", Offset = "0x271781C", VA = "0x271781C")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x600256C")]
	[Address(RVA = "0x2717824", Offset = "0x2717824", VA = "0x2717824")]
	public void _003C_003EiFixBaseProxy_TakeDamage(int P0)
	{
	}

	[Token(Token = "0x600256D")]
	[Address(RVA = "0x271782C", Offset = "0x271782C", VA = "0x271782C")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x600256E")]
	[Address(RVA = "0x2717834", Offset = "0x2717834", VA = "0x2717834")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}
}
