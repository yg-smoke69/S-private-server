using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005E8")]
public class LevelCampFire : BaseLevelObject
{
	[Token(Token = "0x400447C")]
	[FieldOffset(Offset = "0x74")]
	public GameObject RangeSphere;

	[Token(Token = "0x400447D")]
	[FieldOffset(Offset = "0x78")]
	public GameObject BonFire;

	[Token(Token = "0x400447E")]
	[FieldOffset(Offset = "0x7C")]
	public Animator CampFireAnimator;

	[Token(Token = "0x400447F")]
	[FieldOffset(Offset = "0x80")]
	public GameObject FireEffect;

	[Token(Token = "0x4004480")]
	[FieldOffset(Offset = "0x84")]
	public GameObject BurnEffect;

	[Token(Token = "0x4004481")]
	[FieldOffset(Offset = "0x88")]
	public AudioSource CampFireAudioSource;

	[Token(Token = "0x4004482")]
	[FieldOffset(Offset = "0x8C")]
	private GameObject NJBBNCEJMLD;

	[Token(Token = "0x4004483")]
	[FieldOffset(Offset = "0x90")]
	private bool NHGHMJCLMNB;

	[Token(Token = "0x4004484")]
	[FieldOffset(Offset = "0x0")]
	private static readonly float CDIOPAIHLFA;

	[Token(Token = "0x4004485")]
	[FieldOffset(Offset = "0x98")]
	private IHAAMHPPLMG AFFLMOEAHKC;

	[Token(Token = "0x60023D2")]
	[Address(RVA = "0x2376910", Offset = "0x2376910", VA = "0x2376910")]
	public LevelCampFire()
	{
	}

	[Token(Token = "0x60023D3")]
	[Address(RVA = "0x23769BC", Offset = "0x23769BC", VA = "0x23769BC", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60023D4")]
	[Address(RVA = "0x2376A60", Offset = "0x2376A60", VA = "0x2376A60", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60023D5")]
	[Address(RVA = "0x2376B68", Offset = "0x2376B68", VA = "0x2376B68", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x60023D6")]
	[Address(RVA = "0x2377E14", Offset = "0x2377E14", VA = "0x2377E14")]
	public void FireBurnOut()
	{
	}

	[Token(Token = "0x60023D7")]
	[Address(RVA = "0x2378128", Offset = "0x2378128", VA = "0x2378128")]
	private void MANOBKNNLJG()
	{
	}

	[Token(Token = "0x60023D9")]
	[Address(RVA = "0x23784D4", Offset = "0x23784D4", VA = "0x23784D4")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x60023DA")]
	[Address(RVA = "0x23784DC", Offset = "0x23784DC", VA = "0x23784DC")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
