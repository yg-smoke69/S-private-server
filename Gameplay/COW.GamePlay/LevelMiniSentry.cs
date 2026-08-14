using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x200064F")]
internal class LevelMiniSentry : LevelObjectSpawnedAttackable
{
	[Token(Token = "0x40046F0")]
	private const float IOCOHPNPIOF = 100f;

	[Token(Token = "0x40046F1")]
	[FieldOffset(Offset = "0xA4")]
	public Transform Root;

	[Token(Token = "0x40046F2")]
	[FieldOffset(Offset = "0xA8")]
	public Transform RotY;

	[Token(Token = "0x40046F3")]
	[FieldOffset(Offset = "0xAC")]
	public Transform RotX;

	[Token(Token = "0x40046F4")]
	[FieldOffset(Offset = "0xB0")]
	public Transform Center;

	[Token(Token = "0x40046F5")]
	[FieldOffset(Offset = "0xB4")]
	public Transform FirePoint;

	[Token(Token = "0x40046F6")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject TeammateEffects;

	[Token(Token = "0x40046F7")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject EnemyEffects;

	[Token(Token = "0x40046F8")]
	[FieldOffset(Offset = "0xC0")]
	private TransformRotater GAPBAGILIKP;

	[Token(Token = "0x40046F9")]
	[FieldOffset(Offset = "0xC4")]
	private LAJLKFMPNPD BOPLAOANKBI;

	[Token(Token = "0x40046FA")]
	[FieldOffset(Offset = "0xC8")]
	private IHAAMHPPLMG FGNHJBFFKGI;

	[Token(Token = "0x40046FB")]
	[FieldOffset(Offset = "0xE0")]
	private Vector3 LFDFNDJJCCN;

	[Token(Token = "0x40046FC")]
	[FieldOffset(Offset = "0xEC")]
	private bool PNLJJIDMOMD;

	[Token(Token = "0x40046FD")]
	[FieldOffset(Offset = "0xF0")]
	private ParticleSystem LGDPBGEIBDJ;

	[Token(Token = "0x40046FE")]
	[FieldOffset(Offset = "0xF4")]
	protected bool ENCKCNBKOGF;

	[Token(Token = "0x1700030B")]
	private Vector3 JECKJADHFFN
	{
		[Token(Token = "0x6002758")]
		[Address(RVA = "0x24B90B4", Offset = "0x24B90B4", VA = "0x24B90B4")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700030C")]
	private Vector3 CNEICNJFGLM
	{
		[Token(Token = "0x6002759")]
		[Address(RVA = "0x24B9138", Offset = "0x24B9138", VA = "0x24B9138")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700030D")]
	public override int JLCCLJCEDIL
	{
		[Token(Token = "0x600275A")]
		[Address(RVA = "0x24B91BC", Offset = "0x24B91BC", VA = "0x24B91BC", Slot = "64")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002756")]
	[Address(RVA = "0x24B8F64", Offset = "0x24B8F64", VA = "0x24B8F64")]
	public LevelMiniSentry()
	{
	}

	[Token(Token = "0x6002757")]
	[Address(RVA = "0x24B9010", Offset = "0x24B9010", VA = "0x24B9010", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x600275B")]
	[Address(RVA = "0x24B922C", Offset = "0x24B922C", VA = "0x24B922C", Slot = "41")]
	protected override void DPLMGOJKKCM(CSVBaseData IHCGHDENPKF)
	{
	}

	[Token(Token = "0x600275C")]
	[Address(RVA = "0x24B9384", Offset = "0x24B9384", VA = "0x24B9384")]
	private void LLIPGNOGKPP(LAJLKFMPNPD AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600275D")]
	[Address(RVA = "0x24B9588", Offset = "0x24B9588", VA = "0x24B9588")]
	private void NNPPKEIPFHF(LAJLKFMPNPD AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600275E")]
	[Address(RVA = "0x24B9BDC", Offset = "0x24B9BDC", VA = "0x24B9BDC", Slot = "42")]
	public override void OnDead(MEBEMEIFFBA OMNGGLFFMGM)
	{
	}

	[Token(Token = "0x600275F")]
	[Address(RVA = "0x24B9F28", Offset = "0x24B9F28", VA = "0x24B9F28", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002760")]
	[Address(RVA = "0x24B984C", Offset = "0x24B984C", VA = "0x24B984C")]
	protected void HLPCOLLPANJ()
	{
	}

	[Token(Token = "0x6002761")]
	[Address(RVA = "0x24B9FFC", Offset = "0x24B9FFC", VA = "0x24B9FFC")]
	protected void NNEPBFMNLGC()
	{
	}

	[Token(Token = "0x6002762")]
	[Address(RVA = "0x24BA1A0", Offset = "0x24BA1A0", VA = "0x24BA1A0", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002763")]
	[Address(RVA = "0x24BA1F8", Offset = "0x24BA1F8", VA = "0x24BA1F8", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002764")]
	[Address(RVA = "0x24BA4B8", Offset = "0x24BA4B8", VA = "0x24BA4B8")]
	private void IBDOIKFADJK(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002765")]
	[Address(RVA = "0x24BA520", Offset = "0x24BA520", VA = "0x24BA520")]
	protected void GDLCAJOJOKI(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002766")]
	[Address(RVA = "0x24BA6F4", Offset = "0x24BA6F4", VA = "0x24BA6F4")]
	private void JFKIDBAKCIJ(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002767")]
	[Address(RVA = "0x24BA7D0", Offset = "0x24BA7D0", VA = "0x24BA7D0")]
	private void KMPPGCBOBFF(float NHJNFPKBBLI, float LGALHNNDGNE)
	{
	}

	[Token(Token = "0x6002768")]
	[Address(RVA = "0x24BAAA4", Offset = "0x24BAAA4", VA = "0x24BAAA4", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002769")]
	[Address(RVA = "0x24BADD0", Offset = "0x24BADD0", VA = "0x24BADD0")]
	private void NIBJAKNFNAF(Player KAEHJEGFKBL, bool OFNFHFAFGDE)
	{
	}

	[Token(Token = "0x600276A")]
	[Address(RVA = "0x24BB264", Offset = "0x24BB264", VA = "0x24BB264")]
	private Vector3 CFDOCHOLIAK(Player KAEHJEGFKBL, bool OFNFHFAFGDE)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600276B")]
	[Address(RVA = "0x24BC17C", Offset = "0x24BC17C", VA = "0x24BC17C")]
	private float PEDKIAIMHOK(float MKGCDPNKMOB, float OANAHFHPBNB)
	{
		return default(float);
	}

	[Token(Token = "0x600276C")]
	[Address(RVA = "0x24BB8A4", Offset = "0x24BB8A4", VA = "0x24BB8A4")]
	private void CPBCGAKODII(Vector3 BNDPJDJAFOM, Vector3 PFAPJJODMCM)
	{
	}

	[Token(Token = "0x600276D")]
	[Address(RVA = "0x24BBDA8", Offset = "0x24BBDA8", VA = "0x24BBDA8")]
	private void EFOOBIAPDCG()
	{
	}

	[Token(Token = "0x600276E")]
	[Address(RVA = "0x24BC220", Offset = "0x24BC220", VA = "0x24BC220", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600276F")]
	[Address(RVA = "0x24BC2A4", Offset = "0x24BC2A4", VA = "0x24BC2A4")]
	private void OJOHLBJEIJO(float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002770")]
	[Address(RVA = "0x24BA858", Offset = "0x24BA858", VA = "0x24BA858")]
	private void PJFDHCOALEG(float NHJNFPKBBLI, float LGALHNNDGNE)
	{
	}

	[Token(Token = "0x6002771")]
	[Address(RVA = "0x24BB1AC", Offset = "0x24BB1AC", VA = "0x24BB1AC")]
	private void JCFDFPAPHPD(Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x6002772")]
	[Address(RVA = "0x24BC6B0", Offset = "0x24BC6B0", VA = "0x24BC6B0")]
	private void IAMKIGIFEBK()
	{
	}

	[Token(Token = "0x6002773")]
	[Address(RVA = "0x24B978C", Offset = "0x24B978C", VA = "0x24B978C")]
	private void EPIBGDMIMND()
	{
	}

	[Token(Token = "0x6002774")]
	[Address(RVA = "0x24BC0BC", Offset = "0x24BC0BC", VA = "0x24BC0BC")]
	private void EEKOEPAMNFC()
	{
	}

	[Token(Token = "0x6002775")]
	[Address(RVA = "0x24B99F0", Offset = "0x24B99F0", VA = "0x24B99F0")]
	private void EHFKEGJCGFP()
	{
	}

	[Token(Token = "0x6002776")]
	[Address(RVA = "0x24BC8BC", Offset = "0x24BC8BC", VA = "0x24BC8BC")]
	public void _003C_003EiFixBaseProxy_DPLMGOJKKCM(CSVBaseData P0)
	{
	}

	[Token(Token = "0x6002777")]
	[Address(RVA = "0x24BC8C0", Offset = "0x24BC8C0", VA = "0x24BC8C0")]
	public void _003C_003EiFixBaseProxy_OnDead(MEBEMEIFFBA P0)
	{
	}

	[Token(Token = "0x6002778")]
	[Address(RVA = "0x24BC8C4", Offset = "0x24BC8C4", VA = "0x24BC8C4")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x6002779")]
	[Address(RVA = "0x24BC8C8", Offset = "0x24BC8C8", VA = "0x24BC8C8")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x600277A")]
	[Address(RVA = "0x24BC8D0", Offset = "0x24BC8D0", VA = "0x24BC8D0")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x600277B")]
	[Address(RVA = "0x24BC8D8", Offset = "0x24BC8D8", VA = "0x24BC8D8")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	[Token(Token = "0x600277C")]
	[Address(RVA = "0x24BC8E0", Offset = "0x24BC8E0", VA = "0x24BC8E0")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
