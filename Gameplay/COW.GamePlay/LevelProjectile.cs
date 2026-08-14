using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000680")]
internal class LevelProjectile : BaseLevelObject
{
	[Token(Token = "0x2000681")]
	public struct MAMGKOCOJLP
	{
		[Token(Token = "0x4004850")]
		[FieldOffset(Offset = "0x0")]
		public IHAAMHPPLMG OBJNLJGILDP;

		[Token(Token = "0x4004851")]
		[FieldOffset(Offset = "0x18")]
		public uint ELMGDKCNMAM;

		[Token(Token = "0x4004852")]
		[FieldOffset(Offset = "0x1C")]
		public TssSdtInt LJBIDFFHMKM;

		[Token(Token = "0x4004853")]
		[FieldOffset(Offset = "0x20")]
		public TssSdtFloat PJLBKLLLKLL;

		[Token(Token = "0x4004854")]
		[FieldOffset(Offset = "0x24")]
		public TssSdtFloat MGDKMDMHACH;

		[Token(Token = "0x4004855")]
		[FieldOffset(Offset = "0x28")]
		public TssSdtFloat KBFAAPLPKCJ;

		[Token(Token = "0x4004856")]
		[FieldOffset(Offset = "0x2C")]
		public TssSdtInt JPKDDFNMHJN;

		[Token(Token = "0x4004857")]
		[FieldOffset(Offset = "0x30")]
		public int HPIEGIAICML;

		[Token(Token = "0x4004858")]
		[FieldOffset(Offset = "0x34")]
		public PFMPPELJECF KDMFKDIKJEE;

		[Token(Token = "0x4004859")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 CNOHJMHBLJN;

		[Token(Token = "0x400485A")]
		[FieldOffset(Offset = "0x44")]
		public float AFENOPAHNAL;

		[Token(Token = "0x400485B")]
		[FieldOffset(Offset = "0x48")]
		public int IOJFHHNHPNL;

		[Token(Token = "0x400485C")]
		[FieldOffset(Offset = "0x4C")]
		public uint PMOCOKPEHEJ;

		[Token(Token = "0x400485D")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 BOGOIAMJFDN;

		[Token(Token = "0x400485E")]
		[FieldOffset(Offset = "0x5C")]
		public float BBIMIGLHDDL;

		[Token(Token = "0x400485F")]
		[FieldOffset(Offset = "0x60")]
		public float GOIJGFDBMLB;

		[Token(Token = "0x4004860")]
		[FieldOffset(Offset = "0x64")]
		public float MGDELJJDHGK;

		[Token(Token = "0x4004861")]
		[FieldOffset(Offset = "0x68")]
		public float JHEDBAPBOKA;

		[Token(Token = "0x4004862")]
		[FieldOffset(Offset = "0x6C")]
		public float ICCJGHIGBCL;

		[Token(Token = "0x4004863")]
		[FieldOffset(Offset = "0x70")]
		public GPBDEDFKJNA.ENBHOKKHLPG BLNIBIIOMJH;
	}

	[Token(Token = "0x2000682")]
	public enum DIJOLMBEPED
	{
		[Token(Token = "0x4004865")]
		SYNC_STATE,
		[Token(Token = "0x4004866")]
		THROW,
		[Token(Token = "0x4004867")]
		EXPLODE
	}

	[Token(Token = "0x2000683")]
	private sealed class ILFBNIIBJMM
	{
		[Token(Token = "0x4004868")]
		[FieldOffset(Offset = "0x8")]
		internal ResourceID DKOKLIGAAAF;

		[Token(Token = "0x60029C8")]
		[Address(RVA = "0x20C0BCC", Offset = "0x20C0BCC", VA = "0x20C0BCC")]
		public ILFBNIIBJMM()
		{
		}
	}

	[Token(Token = "0x2000684")]
	private sealed class ELLKNBHPNKO
	{
		[Token(Token = "0x4004869")]
		[FieldOffset(Offset = "0x8")]
		internal Object NPDGACFHMPA;

		[Token(Token = "0x400486A")]
		[FieldOffset(Offset = "0xC")]
		internal ILFBNIIBJMM KKPNFILOEFP;

		[Token(Token = "0x60029C9")]
		[Address(RVA = "0x20C0FC8", Offset = "0x20C0FC8", VA = "0x20C0FC8")]
		public ELLKNBHPNKO()
		{
		}

		[Token(Token = "0x60029CA")]
		[Address(RVA = "0x20C6978", Offset = "0x20C6978", VA = "0x20C6978")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x2000685")]
	private sealed class JKGNPMKJHPA
	{
		[Token(Token = "0x400486B")]
		[FieldOffset(Offset = "0x8")]
		internal ResourceID OLOEBCMCLFK;

		[Token(Token = "0x400486C")]
		[FieldOffset(Offset = "0xC")]
		internal Object NPDGACFHMPA;

		[Token(Token = "0x400486D")]
		[FieldOffset(Offset = "0x10")]
		internal Player KAEHJEGFKBL;

		[Token(Token = "0x60029CB")]
		[Address(RVA = "0x20C29F4", Offset = "0x20C29F4", VA = "0x20C29F4")]
		public JKGNPMKJHPA()
		{
		}

		[Token(Token = "0x60029CC")]
		[Address(RVA = "0x20C6AA0", Offset = "0x20C6AA0", VA = "0x20C6AA0")]
		internal bool CHOPCLCOBKC()
		{
			return default(bool);
		}

		[Token(Token = "0x60029CD")]
		[Address(RVA = "0x20C6B70", Offset = "0x20C6B70", VA = "0x20C6B70")]
		internal bool HJGBDJENEAM()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4004835")]
	[FieldOffset(Offset = "0x74")]
	private LayerMask OBBNCKJCMAB;

	[Token(Token = "0x4004836")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 AIOGAJDGMBH;

	[Token(Token = "0x4004837")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 JFDGDFMNMIK;

	[Token(Token = "0x4004838")]
	[FieldOffset(Offset = "0x90")]
	private float FLCFKNGBLDJ;

	[Token(Token = "0x4004839")]
	[FieldOffset(Offset = "0x0")]
	private static readonly float DOCCFOLMPIC;

	[Token(Token = "0x400483A")]
	[FieldOffset(Offset = "0x94")]
	private bool MOHLHNAGECN;

	[Token(Token = "0x400483B")]
	[FieldOffset(Offset = "0x98")]
	private MADMMIICBNN JEEIBOEGGPD;

	[Token(Token = "0x400483C")]
	[FieldOffset(Offset = "0x9C")]
	private CLFBGACHJJP APAFCNEACMB;

	[Token(Token = "0x400483D")]
	[FieldOffset(Offset = "0xA0")]
	private bool MNDFMKPFOOB;

	[Token(Token = "0x400483E")]
	[FieldOffset(Offset = "0xA4")]
	private float KOEMNOKBGGE;

	[Token(Token = "0x400483F")]
	[FieldOffset(Offset = "0xA8")]
	protected LLDPJHPAOCB FBFBKKOBBPG;

	[Token(Token = "0x4004840")]
	[FieldOffset(Offset = "0xAC")]
	private Vector3 LFJMNHBGGEB;

	[Token(Token = "0x4004841")]
	[FieldOffset(Offset = "0xB8")]
	private uint GDNNOPINBCF;

	[Token(Token = "0x4004842")]
	[FieldOffset(Offset = "0xBC")]
	private bool IGPALKFGJDK;

	[Token(Token = "0x4004843")]
	[FieldOffset(Offset = "0xC0")]
	private float CKAHMDKFOEH;

	[Token(Token = "0x4004844")]
	[FieldOffset(Offset = "0xC4")]
	private float CLMPPNONBOH;

	[Token(Token = "0x4004845")]
	[FieldOffset(Offset = "0xC8")]
	private uint HHDIBABGDNN;

	[Token(Token = "0x4004846")]
	[FieldOffset(Offset = "0xCC")]
	public bool m_LocalExplode;

	[Token(Token = "0x4004847")]
	[FieldOffset(Offset = "0xCD")]
	private bool JHEICCKACFK;

	[Token(Token = "0x4004848")]
	[FieldOffset(Offset = "0xD0")]
	private uint EMMPEGANNDJ;

	[Token(Token = "0x4004849")]
	[FieldOffset(Offset = "0xD8")]
	private MAMGKOCOJLP HMKMIPGAKCH;

	[Token(Token = "0x400484A")]
	[FieldOffset(Offset = "0x150")]
	public Projectile m_projectile;

	[Token(Token = "0x400484B")]
	[FieldOffset(Offset = "0x154")]
	private uint PJLFFEPGNHC;

	[Token(Token = "0x400484C")]
	[FieldOffset(Offset = "0x158")]
	private GameObject EPKEHAOJGCK;

	[Token(Token = "0x400484D")]
	private const string GCDDKMFODAC = "bone_RightArm";

	[Token(Token = "0x400484E")]
	private const string DCAIABCAEMJ = "bone_LeftArm";

	[Token(Token = "0x400484F")]
	[FieldOffset(Offset = "0x15C")]
	private List<float> PIGOIHAOJGH;

	[Token(Token = "0x17000334")]
	public CLFBGACHJJP NLJHMEBFDLE
	{
		[Token(Token = "0x600299D")]
		[Address(RVA = "0x20BE4E0", Offset = "0x20BE4E0", VA = "0x20BE4E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600299C")]
		[Address(RVA = "0x20BE480", Offset = "0x20BE480", VA = "0x20BE480")]
		set
		{
		}
	}

	[Token(Token = "0x17000335")]
	public IHAAMHPPLMG JGHEGHHINPA
	{
		[Token(Token = "0x600299E")]
		[Address(RVA = "0x20BE538", Offset = "0x20BE538", VA = "0x20BE538")]
		get
		{
			return default(IHAAMHPPLMG);
		}
	}

	[Token(Token = "0x600299B")]
	[Address(RVA = "0x20BE360", Offset = "0x20BE360", VA = "0x20BE360")]
	public LevelProjectile()
	{
	}

	[Token(Token = "0x600299F")]
	[Address(RVA = "0x20BE5AC", Offset = "0x20BE5AC", VA = "0x20BE5AC", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60029A0")]
	[Address(RVA = "0x20BE650", Offset = "0x20BE650", VA = "0x20BE650", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x60029A1")]
	[Address(RVA = "0x20BE948", Offset = "0x20BE948", VA = "0x20BE948")]
	public void SetLocalData(uint BGHJCCBFFKL, Vector3 COCOBLKAIMJ, MAMGKOCOJLP PNLLBIBLNJO, float AKAJHMHFKMG = -1f, bool KOIEOPKGIBP = false)
	{
	}

	[Token(Token = "0x60029A2")]
	[Address(RVA = "0x20BF348", Offset = "0x20BF348", VA = "0x20BF348")]
	public void SetGrenadeDataScale(Player KAEHJEGFKBL)
	{
	}

	[Token(Token = "0x60029A3")]
	[Address(RVA = "0x20BF5A8", Offset = "0x20BF5A8", VA = "0x20BF5A8")]
	public void PlayThrowSound()
	{
	}

	[Token(Token = "0x60029A4")]
	[Address(RVA = "0x20BF52C", Offset = "0x20BF52C", VA = "0x20BF52C")]
	private bool GPIGENDDCFI(GPBDEDFKJNA.HAAOGJECGDE PMGBACFJIHO)
	{
		return default(bool);
	}

	[Token(Token = "0x60029A5")]
	[Address(RVA = "0x20BF73C", Offset = "0x20BF73C", VA = "0x20BF73C")]
	private uint NBFANIANAGC()
	{
		return default(uint);
	}

	[Token(Token = "0x60029A6")]
	[Address(RVA = "0x20BFA20", Offset = "0x20BFA20", VA = "0x20BFA20")]
	private bool BCILDKNMJBF(int MBKHHEHLHEF)
	{
		return default(bool);
	}

	[Token(Token = "0x60029A7")]
	[Address(RVA = "0x20BFC98", Offset = "0x20BFC98", VA = "0x20BFC98")]
	private bool KODFBBAHPMA()
	{
		return default(bool);
	}

	[Token(Token = "0x60029A8")]
	[Address(RVA = "0x20BEC94", Offset = "0x20BEC94", VA = "0x20BEC94")]
	private void HKJMPGMLMPF(uint KFBALILGIIG, Vector3 KEGEAOIJFBP)
	{
	}

	[Token(Token = "0x60029A9")]
	[Address(RVA = "0x20BFD18", Offset = "0x20BFD18", VA = "0x20BFD18")]
	public float GetExplodeRange()
	{
		return default(float);
	}

	[Token(Token = "0x60029AA")]
	[Address(RVA = "0x20BFD98", Offset = "0x20BFD98", VA = "0x20BFD98")]
	private void OLMCMENDEIH()
	{
	}

	[Token(Token = "0x60029AB")]
	[Address(RVA = "0x20BFEE0", Offset = "0x20BFEE0", VA = "0x20BFEE0")]
	private void ACLICFCNNBH()
	{
	}

	[Token(Token = "0x60029AC")]
	[Address(RVA = "0x20BFF78", Offset = "0x20BFF78", VA = "0x20BFF78")]
	private void JIFLCFHMKHD(uint KFBALILGIIG, Vector3 FAIKJBAFMMG, int OECMLDILLJN)
	{
	}

	[Token(Token = "0x60029AD")]
	[Address(RVA = "0x20C20F8", Offset = "0x20C20F8", VA = "0x20C20F8")]
	private void NFFKHLMALDB()
	{
	}

	[Token(Token = "0x60029AE")]
	[Address(RVA = "0x20C0BD4", Offset = "0x20C0BD4", VA = "0x20C0BD4")]
	private void KLDPFDHMAEN(Vector3 FAIKJBAFMMG)
	{
	}

	[Token(Token = "0x60029AF")]
	[Address(RVA = "0x20C0EF0", Offset = "0x20C0EF0", VA = "0x20C0EF0")]
	private ResourceID HKMCJJBMPLE()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60029B0")]
	[Address(RVA = "0x20C0FD0", Offset = "0x20C0FD0", VA = "0x20C0FD0")]
	private ResourceID MGHMFMEOBCE()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60029B1")]
	[Address(RVA = "0x20C1408", Offset = "0x20C1408", VA = "0x20C1408")]
	private int ILFCMAILBCE(Player KAEHJEGFKBL, CLFBGACHJJP.NMILPINJICG GNECEJIAFFI)
	{
		return default(int);
	}

	[Token(Token = "0x60029B2")]
	[Address(RVA = "0x20C1A9C", Offset = "0x20C1A9C", VA = "0x20C1A9C")]
	private void IAMCEANHNCB(float MGJPAOLGJEE)
	{
	}

	[Token(Token = "0x60029B3")]
	[Address(RVA = "0x20C1C9C", Offset = "0x20C1C9C", VA = "0x20C1C9C")]
	private void GINHFGEEGFG(Player KAEHJEGFKBL, float MGJPAOLGJEE)
	{
	}

	[Token(Token = "0x60029B4")]
	[Address(RVA = "0x20C29FC", Offset = "0x20C29FC", VA = "0x20C29FC", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x60029B5")]
	[Address(RVA = "0x20C3490", Offset = "0x20C3490", VA = "0x20C3490", Slot = "40")]
	protected virtual void LJLAODFDAAA(MADMMIICBNN JEEIBOEGGPD)
	{
	}

	[Token(Token = "0x60029B6")]
	[Address(RVA = "0x20C479C", Offset = "0x20C479C", VA = "0x20C479C")]
	protected bool CAGIGOEJJAG(MADMMIICBNN JEEIBOEGGPD)
	{
		return default(bool);
	}

	[Token(Token = "0x60029B7")]
	[Address(RVA = "0x20C4B0C", Offset = "0x20C4B0C", VA = "0x20C4B0C")]
	protected bool BJLGMCFGACO(MADMMIICBNN JEEIBOEGGPD)
	{
		return default(bool);
	}

	[Token(Token = "0x60029B8")]
	[Address(RVA = "0x20C4EDC", Offset = "0x20C4EDC", VA = "0x20C4EDC")]
	public void OnPlayHitEffect(MADMMIICBNN JEEIBOEGGPD)
	{
	}

	[Token(Token = "0x60029B9")]
	[Address(RVA = "0x20C52AC", Offset = "0x20C52AC", VA = "0x20C52AC")]
	private void LHBCHNEOLFJ(Vector3 ALIFAAJCFAI)
	{
	}

	[Token(Token = "0x60029BA")]
	[Address(RVA = "0x20C5498", Offset = "0x20C5498", VA = "0x20C5498", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60029BB")]
	[Address(RVA = "0x20C5F38", Offset = "0x20C5F38", VA = "0x20C5F38")]
	private bool JALEGCMOILC()
	{
		return default(bool);
	}

	[Token(Token = "0x60029BC")]
	[Address(RVA = "0x20C61CC", Offset = "0x20C61CC", VA = "0x20C61CC")]
	public int GetMaxDamage()
	{
		return default(int);
	}

	[Token(Token = "0x60029BD")]
	[Address(RVA = "0x20C62D0", Offset = "0x20C62D0", VA = "0x20C62D0")]
	private int NDINCJKIGJD()
	{
		return default(int);
	}

	[Token(Token = "0x60029BE")]
	[Address(RVA = "0x20C2288", Offset = "0x20C2288", VA = "0x20C2288")]
	private void AAOHHHJINON()
	{
	}

	[Token(Token = "0x60029BF")]
	[Address(RVA = "0x20C63D4", Offset = "0x20C63D4", VA = "0x20C63D4")]
	private void JFOPPDEHENK(MovableShootingTarget FFDHFKIMFDG)
	{
	}

	[Token(Token = "0x60029C0")]
	[Address(RVA = "0x20BF0DC", Offset = "0x20BF0DC", VA = "0x20BF0DC")]
	private void IPCOKCLODCC()
	{
	}

	[Token(Token = "0x60029C1")]
	[Address(RVA = "0x20C6854", Offset = "0x20C6854", VA = "0x20C6854")]
	private void KDFPOGJOBMC(uint LPFMNBCHJPE, bool FALMPPMFJFN, Object ECINOMEHBKA)
	{
	}

	[Token(Token = "0x60029C2")]
	[Address(RVA = "0x20BE838", Offset = "0x20BE838", VA = "0x20BE838")]
	private void JIFLOKPDEEC()
	{
	}

	[Token(Token = "0x60029C4")]
	[Address(RVA = "0x20C6944", Offset = "0x20C6944", VA = "0x20C6944")]
	private void MNKPHFNGHPF()
	{
	}

	[Token(Token = "0x60029C5")]
	[Address(RVA = "0x20C6960", Offset = "0x20C6960", VA = "0x20C6960")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x60029C6")]
	[Address(RVA = "0x20C6968", Offset = "0x20C6968", VA = "0x20C6968")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	[Token(Token = "0x60029C7")]
	[Address(RVA = "0x20C6970", Offset = "0x20C6970", VA = "0x20C6970")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
