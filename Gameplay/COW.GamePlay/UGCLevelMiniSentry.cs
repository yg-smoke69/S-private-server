using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x200072B")]
public class UGCLevelMiniSentry : BaseAutoGenIDLevelObject
{
	[Token(Token = "0x4004C5A")]
	private const float IOCOHPNPIOF = 100f;

	[Token(Token = "0x4004C5B")]
	[FieldOffset(Offset = "0x74")]
	public Transform Root;

	[Token(Token = "0x4004C5C")]
	[FieldOffset(Offset = "0x78")]
	public Transform RotY;

	[Token(Token = "0x4004C5D")]
	[FieldOffset(Offset = "0x7C")]
	public Transform Center;

	[Token(Token = "0x4004C5E")]
	[FieldOffset(Offset = "0x80")]
	public Transform FirePoint;

	[Token(Token = "0x4004C5F")]
	[FieldOffset(Offset = "0x84")]
	public GameObject TeammateEffects;

	[Token(Token = "0x4004C60")]
	[FieldOffset(Offset = "0x88")]
	public GameObject EnemyEffects;

	[Token(Token = "0x4004C61")]
	[FieldOffset(Offset = "0x8C")]
	public float AngleSpeed;

	[Token(Token = "0x4004C62")]
	[FieldOffset(Offset = "0x90")]
	public float AngleUp;

	[Token(Token = "0x4004C63")]
	[FieldOffset(Offset = "0x94")]
	public float AngleDown;

	[Token(Token = "0x4004C64")]
	[FieldOffset(Offset = "0x98")]
	public Vector3 FirePosLocalPosition;

	[Token(Token = "0x4004C65")]
	[FieldOffset(Offset = "0xA4")]
	public float FireAngle;

	[Token(Token = "0x4004C66")]
	[FieldOffset(Offset = "0xA8")]
	public Animator FireAnimator;

	[Token(Token = "0x4004C67")]
	[FieldOffset(Offset = "0xAC")]
	public Vector3 ExplodeEffectScale;

	[Token(Token = "0x4004C68")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject AttackRangeEffect;

	[Token(Token = "0x4004C69")]
	[FieldOffset(Offset = "0xBC")]
	private TransformRotater GAPBAGILIKP;

	[Token(Token = "0x4004C6A")]
	[FieldOffset(Offset = "0xC0")]
	private KAPNFHPPLLE DJOBJCOEMCC;

	[Token(Token = "0x4004C6B")]
	[FieldOffset(Offset = "0xC8")]
	private IHAAMHPPLMG FGNHJBFFKGI;

	[Token(Token = "0x4004C6C")]
	[FieldOffset(Offset = "0xE0")]
	private Vector3 LFDFNDJJCCN;

	[Token(Token = "0x4004C6D")]
	[FieldOffset(Offset = "0xEC")]
	private bool PNLJJIDMOMD;

	[Token(Token = "0x4004C6E")]
	[FieldOffset(Offset = "0xF0")]
	private ParticleSystem LGDPBGEIBDJ;

	[Token(Token = "0x4004C6F")]
	[FieldOffset(Offset = "0xF4")]
	protected bool ENCKCNBKOGF;

	[Token(Token = "0x4004C70")]
	[FieldOffset(Offset = "0xF8")]
	private OIJCGOLPHCF FDELPPNIBDE;

	[Token(Token = "0x4004C71")]
	[FieldOffset(Offset = "0xFC")]
	private GameObject JMNOBLOABCD;

	[Token(Token = "0x17000359")]
	private Vector3 JECKJADHFFN
	{
		[Token(Token = "0x6002D46")]
		[Address(RVA = "0x138852C", Offset = "0x138852C", VA = "0x138852C")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700035A")]
	private Vector3 CNEICNJFGLM
	{
		[Token(Token = "0x6002D47")]
		[Address(RVA = "0x13885B0", Offset = "0x13885B0", VA = "0x13885B0")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x6002D44")]
	[Address(RVA = "0x138839C", Offset = "0x138839C", VA = "0x138839C")]
	public UGCLevelMiniSentry()
	{
	}

	[Token(Token = "0x6002D45")]
	[Address(RVA = "0x1388488", Offset = "0x1388488", VA = "0x1388488", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002D48")]
	[Address(RVA = "0x1388634", Offset = "0x1388634", VA = "0x1388634", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6002D49")]
	[Address(RVA = "0x1388760", Offset = "0x1388760", VA = "0x1388760")]
	public void Init(KAPNFHPPLLE KLKIKGHBPLL)
	{
	}

	[Token(Token = "0x6002D4A")]
	[Address(RVA = "0x13887E4", Offset = "0x13887E4", VA = "0x13887E4")]
	private void JAEEBAIJOEF()
	{
	}

	[Token(Token = "0x6002D4B")]
	[Address(RVA = "0x1388CBC", Offset = "0x1388CBC", VA = "0x1388CBC", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002D4C")]
	[Address(RVA = "0x1388D14", Offset = "0x1388D14", VA = "0x1388D14", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002D4D")]
	[Address(RVA = "0x13890B4", Offset = "0x13890B4", VA = "0x13890B4")]
	public bool IsSameTeam(IHAAMHPPLMG FKPFJHMFGCJ)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D4E")]
	[Address(RVA = "0x13892AC", Offset = "0x13892AC", VA = "0x13892AC")]
	public uint MaxHP()
	{
		return default(uint);
	}

	[Token(Token = "0x6002D4F")]
	[Address(RVA = "0x13889E0", Offset = "0x13889E0", VA = "0x13889E0")]
	private void NNPPKEIPFHF()
	{
	}

	[Token(Token = "0x6002D50")]
	[Address(RVA = "0x1389320", Offset = "0x1389320", VA = "0x1389320")]
	private void IBDOIKFADJK(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002D51")]
	[Address(RVA = "0x1389388", Offset = "0x1389388", VA = "0x1389388")]
	public void OnTargetChange(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002D52")]
	[Address(RVA = "0x138955C", Offset = "0x138955C", VA = "0x138955C")]
	public void OnRoatationChange(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002D53")]
	[Address(RVA = "0x13896C0", Offset = "0x13896C0", VA = "0x13896C0")]
	public void OnStatusChange(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002D54")]
	[Address(RVA = "0x1389638", Offset = "0x1389638", VA = "0x1389638")]
	private void KMPPGCBOBFF(float NHJNFPKBBLI, float LGALHNNDGNE)
	{
	}

	[Token(Token = "0x6002D55")]
	[Address(RVA = "0x1389CC8", Offset = "0x1389CC8", VA = "0x1389CC8")]
	private void DCJPHICJEJO()
	{
	}

	[Token(Token = "0x6002D56")]
	[Address(RVA = "0x1389D5C", Offset = "0x1389D5C", VA = "0x1389D5C", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002D57")]
	[Address(RVA = "0x138A248", Offset = "0x138A248", VA = "0x138A248")]
	private void NIBJAKNFNAF(Player KAEHJEGFKBL, bool OFNFHFAFGDE)
	{
	}

	[Token(Token = "0x6002D58")]
	[Address(RVA = "0x138A598", Offset = "0x138A598", VA = "0x138A598")]
	private Vector3 CFDOCHOLIAK(Player KAEHJEGFKBL, bool OFNFHFAFGDE)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002D59")]
	[Address(RVA = "0x138A394", Offset = "0x138A394", VA = "0x138A394")]
	private void OLEMDJKOEMH(NetworkAIPawn ACGKPBBEDFM, bool OFNFHFAFGDE)
	{
	}

	[Token(Token = "0x6002D5A")]
	[Address(RVA = "0x138B428", Offset = "0x138B428", VA = "0x138B428")]
	private Vector3 FJJFBOLEKPC(NetworkAIPawn ACGKPBBEDFM, bool OFNFHFAFGDE)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002D5B")]
	[Address(RVA = "0x138B384", Offset = "0x138B384", VA = "0x138B384")]
	private float PEDKIAIMHOK(float MKGCDPNKMOB, float OANAHFHPBNB)
	{
		return default(float);
	}

	[Token(Token = "0x6002D5C")]
	[Address(RVA = "0x138ABD8", Offset = "0x138ABD8", VA = "0x138ABD8")]
	private void CPBCGAKODII(Vector3 BNDPJDJAFOM, Vector3 PFAPJJODMCM)
	{
	}

	[Token(Token = "0x6002D5D")]
	[Address(RVA = "0x138B09C", Offset = "0x138B09C", VA = "0x138B09C")]
	private void EFOOBIAPDCG()
	{
	}

	[Token(Token = "0x6002D5E")]
	[Address(RVA = "0x138B7E0", Offset = "0x138B7E0", VA = "0x138B7E0", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002D5F")]
	[Address(RVA = "0x138B864", Offset = "0x138B864", VA = "0x138B864")]
	private void OJOHLBJEIJO(float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002D60")]
	[Address(RVA = "0x1389AE0", Offset = "0x1389AE0", VA = "0x1389AE0")]
	private void PJFDHCOALEG(float NHJNFPKBBLI, float LGALHNNDGNE)
	{
	}

	[Token(Token = "0x6002D61")]
	[Address(RVA = "0x138A4E0", Offset = "0x138A4E0", VA = "0x138A4E0")]
	private void JCFDFPAPHPD(Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x6002D62")]
	[Address(RVA = "0x138BC40", Offset = "0x138BC40", VA = "0x138BC40")]
	private void IAMKIGIFEBK()
	{
	}

	[Token(Token = "0x6002D63")]
	[Address(RVA = "0x1388BA8", Offset = "0x1388BA8", VA = "0x1388BA8")]
	private void EPIBGDMIMND()
	{
	}

	[Token(Token = "0x6002D64")]
	[Address(RVA = "0x138B2C4", Offset = "0x138B2C4", VA = "0x138B2C4")]
	private void EEKOEPAMNFC()
	{
	}

	[Token(Token = "0x6002D65")]
	[Address(RVA = "0x1389A20", Offset = "0x1389A20", VA = "0x1389A20")]
	private void LNCOIDFODKE()
	{
	}

	[Token(Token = "0x6002D66")]
	[Address(RVA = "0x138BC94", Offset = "0x138BC94", VA = "0x138BC94")]
	private void CLIPGBBEGNB(ResourceID DDDJHDHBFJB, ResourceID LMKMNAFNNJJ)
	{
	}

	[Token(Token = "0x6002D67")]
	[Address(RVA = "0x1388C68", Offset = "0x1388C68", VA = "0x1388C68")]
	private void EHFKEGJCGFP()
	{
	}

	[Token(Token = "0x6002D68")]
	[Address(RVA = "0x138BE3C", Offset = "0x138BE3C", VA = "0x138BE3C")]
	public void UpdateAttackRange(bool ODOEHEHNJOG, float DEDAENIPHKB)
	{
	}

	[Token(Token = "0x6002D69")]
	[Address(RVA = "0x138BFD0", Offset = "0x138BFD0", VA = "0x138BFD0")]
	private void PLIDJBLLIIE()
	{
	}

	[Token(Token = "0x6002D6A")]
	[Address(RVA = "0x138BFD4", Offset = "0x138BFD4", VA = "0x138BFD4")]
	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002D6B")]
	[Address(RVA = "0x138BFDC", Offset = "0x138BFDC", VA = "0x138BFDC")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x6002D6C")]
	[Address(RVA = "0x138BFE4", Offset = "0x138BFE4", VA = "0x138BFE4")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002D6D")]
	[Address(RVA = "0x138BFEC", Offset = "0x138BFEC", VA = "0x138BFEC")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002D6E")]
	[Address(RVA = "0x138BFF4", Offset = "0x138BFF4", VA = "0x138BFF4")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	[Token(Token = "0x6002D6F")]
	[Address(RVA = "0x138BFFC", Offset = "0x138BFFC", VA = "0x138BFFC")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
