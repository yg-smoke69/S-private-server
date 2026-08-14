using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.HUD;

[Token(Token = "0x2002B3D")]
internal class UISPHudNameController : UIBaseController
{
	[Token(Token = "0x2002B3E")]
	private sealed class LMEMLKENDJI
	{
		[Token(Token = "0x4010970")]
		[FieldOffset(Offset = "0x8")]
		internal GameObject EIIFBOKNDBK;

		[Token(Token = "0x4010971")]
		[FieldOffset(Offset = "0xC")]
		internal FFCLHKFCKOI IABJAENJONF;

		[Token(Token = "0x4010972")]
		[FieldOffset(Offset = "0x10")]
		internal UISPHudNameController GADHAMJEKIM;

		[Token(Token = "0x6011CE8")]
		[Address(RVA = "0x1904ED4", Offset = "0x1904ED4", VA = "0x1904ED4")]
		public LMEMLKENDJI()
		{
		}

		[Token(Token = "0x6011CE9")]
		[Address(RVA = "0x1905DB8", Offset = "0x1905DB8", VA = "0x1905DB8")]
		internal void CHOPCLCOBKC()
		{
		}

		[Token(Token = "0x6011CEA")]
		[Address(RVA = "0x1905E08", Offset = "0x1905E08", VA = "0x1905E08")]
		internal void HJGBDJENEAM()
		{
		}

		[Token(Token = "0x6011CEB")]
		[Address(RVA = "0x1905FEC", Offset = "0x1905FEC", VA = "0x1905FEC")]
		internal bool CAKFNEAJIBN(FFCLHKFCKOI HGMBMICDALC)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4010951")]
	[FieldOffset(Offset = "0x0")]
	private static float ENLOFFOCFMA;

	[Token(Token = "0x4010952")]
	[FieldOffset(Offset = "0x4")]
	private static float EGHLOMACDHB;

	[Token(Token = "0x4010953")]
	[FieldOffset(Offset = "0x8")]
	private static float JMDBMJMEOHJ;

	[Token(Token = "0x4010954")]
	[FieldOffset(Offset = "0xC")]
	private static int AHAMKLGMGCE;

	[Token(Token = "0x4010955")]
	[FieldOffset(Offset = "0x10")]
	private static int KNAHJBPDILE;

	[Token(Token = "0x4010956")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudNameView NOJLDPLOCIH;

	[Token(Token = "0x4010957")]
	[FieldOffset(Offset = "0x2C")]
	private PlayerData JHFODFOIIIP;

	[Token(Token = "0x4010958")]
	[FieldOffset(Offset = "0x30")]
	private Player MJCIOGBICHJ;

	[Token(Token = "0x4010959")]
	[FieldOffset(Offset = "0x34")]
	private Camera PEAACFHPIFG;

	[Token(Token = "0x401095A")]
	[FieldOffset(Offset = "0x38")]
	private Transform GLGINDPIAEN;

	[Token(Token = "0x401095B")]
	[FieldOffset(Offset = "0x3C")]
	private FOFJEMOKAOH DEIMGFGFALM;

	[Token(Token = "0x401095C")]
	[FieldOffset(Offset = "0x40")]
	private bool IEELFCAOJPM;

	[Token(Token = "0x401095D")]
	[FieldOffset(Offset = "0x44")]
	private AAHMJHHPECM EFGKOKBAFLD;

	[Token(Token = "0x401095E")]
	[FieldOffset(Offset = "0x48")]
	private GPBDEDFKJNA OOPAOGFCGFJ;

	[Token(Token = "0x401095F")]
	[FieldOffset(Offset = "0x4C")]
	private int COPDIPHKECA;

	[Token(Token = "0x4010960")]
	[FieldOffset(Offset = "0x50")]
	private bool FNJABLEPAMJ;

	[Token(Token = "0x4010961")]
	[FieldOffset(Offset = "0x54")]
	private uint BFPAJMPOMCD;

	[Token(Token = "0x4010962")]
	private const int FAKIGKNMOLF = 5;

	[Token(Token = "0x4010963")]
	[FieldOffset(Offset = "0x14")]
	public static Color AmmoColorHigh;

	[Token(Token = "0x4010964")]
	[FieldOffset(Offset = "0x24")]
	public static Color AmmoColorMid;

	[Token(Token = "0x4010965")]
	[FieldOffset(Offset = "0x34")]
	public static Color AmmoColorLow;

	[Token(Token = "0x4010966")]
	[FieldOffset(Offset = "0x44")]
	public static Color AmmoColorGolden;

	[Token(Token = "0x4010967")]
	[FieldOffset(Offset = "0x58")]
	private readonly Color EKHLPDCANMM;

	[Token(Token = "0x4010968")]
	[FieldOffset(Offset = "0x68")]
	private readonly Color KPIPAGOHJJI;

	[Token(Token = "0x4010969")]
	[FieldOffset(Offset = "0x78")]
	private readonly Color HDNLEHKJGOP;

	[Token(Token = "0x401096A")]
	[FieldOffset(Offset = "0x88")]
	private uint OLDKPCFGODJ;

	[Token(Token = "0x401096B")]
	[FieldOffset(Offset = "0x8C")]
	private float FKEFGCPONLA;

	[Token(Token = "0x401096C")]
	[FieldOffset(Offset = "0x90")]
	private uint AHLIICMLPFN;

	[Token(Token = "0x401096D")]
	[FieldOffset(Offset = "0x94")]
	private uint NIEBAELGMKB;

	[Token(Token = "0x401096E")]
	[FieldOffset(Offset = "0x98")]
	private uint ABAHIGKMJOD;

	[Token(Token = "0x401096F")]
	[FieldOffset(Offset = "0x9C")]
	private List<FFCLHKFCKOI> HBNILBFKDED;

	[Token(Token = "0x6011CC2")]
	[Address(RVA = "0x18FE5E0", Offset = "0x18FE5E0", VA = "0x18FE5E0")]
	public UISPHudNameController()
	{
	}

	[Token(Token = "0x6011CC3")]
	[Address(RVA = "0x18FE710", Offset = "0x18FE710", VA = "0x18FE710")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011CC4")]
	[Address(RVA = "0x18FE778", Offset = "0x18FE778", VA = "0x18FE778", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011CC5")]
	[Address(RVA = "0x18FEDA4", Offset = "0x18FEDA4", VA = "0x18FEDA4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6011CC6")]
	[Address(RVA = "0x18FF3A8", Offset = "0x18FF3A8", VA = "0x18FF3A8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011CC7")]
	[Address(RVA = "0x18FFD78", Offset = "0x18FFD78", VA = "0x18FFD78")]
	private void DJLPCEHIAHL(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6011CC8")]
	[Address(RVA = "0x18FFE4C", Offset = "0x18FFE4C", VA = "0x18FFE4C")]
	private void DJGKLGPCKKC(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6011CC9")]
	[Address(RVA = "0x1900064", Offset = "0x1900064", VA = "0x1900064")]
	private void LPOHLAMLMLP(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6011CCA")]
	[Address(RVA = "0x19001EC", Offset = "0x19001EC", VA = "0x19001EC")]
	public void SetKokPlayerShow(bool ALPMKAGIOAF)
	{
	}

	[Token(Token = "0x6011CCB")]
	[Address(RVA = "0x19002BC", Offset = "0x19002BC", VA = "0x19002BC")]
	private void JFOPFNAIGJH(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6011CCC")]
	[Address(RVA = "0x1900444", Offset = "0x1900444", VA = "0x1900444")]
	private void MMFKDPBMDID(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6011CCD")]
	[Address(RVA = "0x19004C8", Offset = "0x19004C8", VA = "0x19004C8")]
	private void FOLNLHBFEBI(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6011CCE")]
	[Address(RVA = "0x19007E0", Offset = "0x19007E0", VA = "0x19007E0")]
	private void GDKMMDPJODD(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6011CCF")]
	[Address(RVA = "0x1900B40", Offset = "0x1900B40", VA = "0x1900B40")]
	public void BindPlayer(IHAAMHPPLMG FKPFJHMFGCJ)
	{
	}

	[Token(Token = "0x6011CD0")]
	[Address(RVA = "0x190230C", Offset = "0x190230C", VA = "0x190230C")]
	private void MMKCMGMEMHL(float KKMBAHJHMEG, float DGLEGBCGEKC)
	{
	}

	[Token(Token = "0x6011CD1")]
	[Address(RVA = "0x19017C0", Offset = "0x19017C0", VA = "0x19017C0")]
	private void KBAANPJOMHK(int LKEHLNKOLNF)
	{
	}

	[Token(Token = "0x6011CD2")]
	[Address(RVA = "0x1901CEC", Offset = "0x1901CEC", VA = "0x1901CEC")]
	private void PGGHCCNANHJ()
	{
	}

	[Token(Token = "0x6011CD3")]
	[Address(RVA = "0x19026B4", Offset = "0x19026B4", VA = "0x19026B4")]
	private void CIDLDAGLHNG()
	{
	}

	[Token(Token = "0x6011CD4")]
	[Address(RVA = "0x18FFC14", Offset = "0x18FFC14", VA = "0x18FFC14")]
	private void KCBDOAAEMNA(GameObject OMDFNKNJDII)
	{
	}

	[Token(Token = "0x6011CD5")]
	[Address(RVA = "0x1903E54", Offset = "0x1903E54", VA = "0x1903E54")]
	public void OnGotFlashed(float NCNKFDHKDMD)
	{
	}

	[Token(Token = "0x6011CD6")]
	[Address(RVA = "0x1904194", Offset = "0x1904194", VA = "0x1904194")]
	public void OnGotHit(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6011CD7")]
	[Address(RVA = "0x1903734", Offset = "0x1903734", VA = "0x1903734")]
	private void AKMEPMOKNCA()
	{
	}

	[Token(Token = "0x6011CD8")]
	[Address(RVA = "0x1903938", Offset = "0x1903938", VA = "0x1903938")]
	private void IMCOKLEMDPN()
	{
	}

	[Token(Token = "0x6011CD9")]
	[Address(RVA = "0x19039C4", Offset = "0x19039C4", VA = "0x19039C4")]
	private void EBJBPDAGBKA(float HJNEJKNOBGA, float OANAHFHPBNB)
	{
	}

	[Token(Token = "0x6011CDA")]
	[Address(RVA = "0x1902490", Offset = "0x1902490", VA = "0x1902490")]
	private Vector3 EGGJHFKIALM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6011CDB")]
	[Address(RVA = "0x1904EDC", Offset = "0x1904EDC", VA = "0x1904EDC")]
	private void LKLAKADJEIL()
	{
	}

	[Token(Token = "0x6011CDC")]
	[Address(RVA = "0x1903C8C", Offset = "0x1903C8C", VA = "0x1903C8C")]
	private void HIGLLNCFKGM()
	{
	}

	[Token(Token = "0x6011CDD")]
	[Address(RVA = "0x1904FFC", Offset = "0x1904FFC", VA = "0x1904FFC")]
	private void HCHBEPJDFOK(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6011CDE")]
	[Address(RVA = "0x190566C", Offset = "0x190566C", VA = "0x190566C")]
	private void FONHPBNABMN()
	{
	}

	[Token(Token = "0x6011CDF")]
	[Address(RVA = "0x1905810", Offset = "0x1905810", VA = "0x1905810")]
	private void PNNPOILJHKA()
	{
	}

	[Token(Token = "0x6011CE0")]
	[Address(RVA = "0x19054E0", Offset = "0x19054E0", VA = "0x19054E0")]
	private void OIGCHKEJCFM()
	{
	}

	[Token(Token = "0x6011CE1")]
	[Address(RVA = "0x190581C", Offset = "0x190581C", VA = "0x190581C")]
	private void OKKBNFFOHGG(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6011CE2")]
	[Address(RVA = "0x190597C", Offset = "0x190597C", VA = "0x190597C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6011CE3")]
	[Address(RVA = "0x19059C4", Offset = "0x19059C4", VA = "0x19059C4")]
	private void EBGIHEGOAIK(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6011CE5")]
	[Address(RVA = "0x1905CB4", Offset = "0x1905CB4", VA = "0x1905CB4")]
	private void MBCFHPGBODD()
	{
	}

	[Token(Token = "0x6011CE6")]
	[Address(RVA = "0x1905D10", Offset = "0x1905D10", VA = "0x1905D10")]
	private void NIEEFIGEDLN()
	{
	}

	[Token(Token = "0x6011CE7")]
	[Address(RVA = "0x1905D64", Offset = "0x1905D64", VA = "0x1905D64")]
	private void HNJBCJFLNMF()
	{
	}
}
