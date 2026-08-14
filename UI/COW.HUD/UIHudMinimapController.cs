using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.HUD;

[Token(Token = "0x20027B9")]
public class UIHudMinimapController : UIMapBaseController
{
	[Token(Token = "0x20027BA")]
	private interface CAHBDLOFEJF
	{
		[Token(Token = "0x600F5B9")]
		void EKMHBHMANFF(string OLGCAPMDBBJ);

		[Token(Token = "0x600F5BA")]
		void JEKDODLICGL();
	}

	[Token(Token = "0x20027BB")]
	private class EBECDECKCOD : _Attribute
	{
		[Token(Token = "0x400F554")]
		[FieldOffset(Offset = "0x8")]
		private UISprite FMKGNOCMPPF;

		[Token(Token = "0x400F555")]
		[FieldOffset(Offset = "0xC")]
		private string DKMINIINBNC;

		[Token(Token = "0x400F556")]
		[FieldOffset(Offset = "0x10")]
		private GameObject _003CBMDLFPDKAKG_003Ek__BackingField;

		[Token(Token = "0x170011DA")]
		public GameObject JHICBALKJHC
		{
			[Token(Token = "0x600F5BC")]
			[Address(RVA = "0x122655C", Offset = "0x122655C", VA = "0x122655C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F5BD")]
			[Address(RVA = "0x122E2DC", Offset = "0x122E2DC", VA = "0x122E2DC")]
			private set
			{
			}
		}

		[Token(Token = "0x600F5BB")]
		[Address(RVA = "0x121D6B8", Offset = "0x121D6B8", VA = "0x121D6B8")]
		public EBECDECKCOD(GameObject ECINOMEHBKA)
		{
		}

		[Token(Token = "0x600F5BE")]
		[Address(RVA = "0x121D868", Offset = "0x121D868", VA = "0x121D868", Slot = "4")]
		public void EKMHBHMANFF(string OLGCAPMDBBJ)
		{
		}

		[Token(Token = "0x600F5BF")]
		[Address(RVA = "0x122E2E4", Offset = "0x122E2E4", VA = "0x122E2E4", Slot = "5")]
		public void JEKDODLICGL()
		{
		}

		[Token(Token = "0x600F5C0")]
		[Address(RVA = "0x121D89C", Offset = "0x121D89C", VA = "0x121D89C")]
		public void IMBDKGNCOEC(bool IMGNBGJDAHG)
		{
		}

		[Token(Token = "0x600F5C1")]
		[Address(RVA = "0x1227180", Offset = "0x1227180", VA = "0x1227180")]
		public void NMMJBGBONHO(Color MGAOFBNFAKF)
		{
		}
	}

	[Token(Token = "0x20027BC")]
	private class LKJMDKOKMBO : EBECDECKCOD
	{
		[Token(Token = "0x400F557")]
		[FieldOffset(Offset = "0x14")]
		private GameObject PBADGMEHBFL;

		[Token(Token = "0x170011DB")]
		public GameObject ECINOMEHBKA
		{
			[Token(Token = "0x600F5C3")]
			[Address(RVA = "0x122D46C", Offset = "0x122D46C", VA = "0x122D46C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600F5C2")]
		[Address(RVA = "0x122D474", Offset = "0x122D474", VA = "0x122D474")]
		public LKJMDKOKMBO(GameObject ECINOMEHBKA)
		{
		}

		[Token(Token = "0x600F5C4")]
		[Address(RVA = "0x1226EE0", Offset = "0x1226EE0", VA = "0x1226EE0")]
		public void HDIOJBGGPAL(Vector3 NNBHGBDMDAB)
		{
		}

		[Token(Token = "0x600F5C5")]
		[Address(RVA = "0x122D490", Offset = "0x122D490", VA = "0x122D490")]
		public void OANHJLPJBLK(string OEAMHJMFBLL, Vector3 DPALDFGNBBF)
		{
		}

		[Token(Token = "0x600F5C6")]
		[Address(RVA = "0x1228FC4", Offset = "0x1228FC4", VA = "0x1228FC4")]
		public void OIACADNBDAH()
		{
		}
	}

	[Token(Token = "0x20027BD")]
	private enum PFHAEJBOLEM
	{
		[Token(Token = "0x400F559")]
		Waiting,
		[Token(Token = "0x400F55A")]
		Stable,
		[Token(Token = "0x400F55B")]
		Scaling,
		[Token(Token = "0x400F55C")]
		End
	}

	[Token(Token = "0x20027BE")]
	public enum JPKDINFPGOD
	{
		[Token(Token = "0x400F55E")]
		NorthUp,
		[Token(Token = "0x400F55F")]
		PlayerUp
	}

	[Token(Token = "0x20027BF")]
	private sealed class DMNPIHJBBJL
	{
		[Token(Token = "0x400F560")]
		[FieldOffset(Offset = "0x8")]
		internal Player IEAFOKKJJNC;

		[Token(Token = "0x400F561")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudMinimapController GADHAMJEKIM;

		[Token(Token = "0x600F5C7")]
		[Address(RVA = "0x121EFA4", Offset = "0x121EFA4", VA = "0x121EFA4")]
		public DMNPIHJBBJL()
		{
		}

		[Token(Token = "0x600F5C8")]
		[Address(RVA = "0x122E194", Offset = "0x122E194", VA = "0x122E194")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x20027C0")]
	private sealed class GJNOAIEIDHH<T>
	{
		[Token(Token = "0x400F562")]
		[FieldOffset(Offset = "0x0")]
		internal Dictionary<T, uint> LGPPCHLFFFG;

		[Token(Token = "0x400F563")]
		[FieldOffset(Offset = "0x0")]
		internal T FKPFJHMFGCJ;

		[Token(Token = "0x400F564")]
		[FieldOffset(Offset = "0x0")]
		internal Dictionary<T, LKJMDKOKMBO> LKHJCNHFMLM;

		[Token(Token = "0x400F565")]
		[FieldOffset(Offset = "0x0")]
		internal UIHudMinimapController GADHAMJEKIM;

		[Token(Token = "0x600F5C9")]
		public GJNOAIEIDHH()
		{
		}

		[Token(Token = "0x600F5CA")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x20027C1")]
	private sealed class CPDGNINHPOM : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F566")]
		[FieldOffset(Offset = "0x8")]
		internal float AKAJHMHFKMG;

		[Token(Token = "0x400F567")]
		[FieldOffset(Offset = "0x10")]
		internal IHAAMHPPLMG FKPFJHMFGCJ;

		[Token(Token = "0x400F568")]
		[FieldOffset(Offset = "0x28")]
		internal UIHudMinimapController GADHAMJEKIM;

		[Token(Token = "0x400F569")]
		[FieldOffset(Offset = "0x2C")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x400F56A")]
		[FieldOffset(Offset = "0x30")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x400F56B")]
		[FieldOffset(Offset = "0x34")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170011DC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600F5CD")]
			[Address(RVA = "0x122E0E8", Offset = "0x122E0E8", VA = "0x122E0E8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011DD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600F5CE")]
			[Address(RVA = "0x122E0F0", Offset = "0x122E0F0", VA = "0x122E0F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600F5CB")]
		[Address(RVA = "0x1229158", Offset = "0x1229158", VA = "0x1229158")]
		public CPDGNINHPOM()
		{
		}

		[Token(Token = "0x600F5CC")]
		[Address(RVA = "0x122DFC8", Offset = "0x122DFC8", VA = "0x122DFC8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600F5CF")]
		[Address(RVA = "0x122E0F8", Offset = "0x122E0F8", VA = "0x122E0F8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600F5D0")]
		[Address(RVA = "0x122E10C", Offset = "0x122E10C", VA = "0x122E10C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20027C2")]
	private sealed class OGAPMBBOOEP
	{
		[Token(Token = "0x400F56C")]
		[FieldOffset(Offset = "0x8")]
		internal IHAAMHPPLMG EBNNIAFEOFA;

		[Token(Token = "0x400F56D")]
		[FieldOffset(Offset = "0x20")]
		internal UIHudMinimapController GADHAMJEKIM;

		[Token(Token = "0x600F5D1")]
		[Address(RVA = "0x122A478", Offset = "0x122A478", VA = "0x122A478")]
		public OGAPMBBOOEP()
		{
		}

		[Token(Token = "0x600F5D2")]
		[Address(RVA = "0x122E318", Offset = "0x122E318", VA = "0x122E318")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x400F534")]
	private const string FAJIFFMLHAD = "Minimap_KillKing";

	[Token(Token = "0x400F535")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudMinimapView NOJLDPLOCIH;

	[Token(Token = "0x400F536")]
	[FieldOffset(Offset = "0x30")]
	private EBECDECKCOD BLGCIBMCIML;

	[Token(Token = "0x400F537")]
	[FieldOffset(Offset = "0x34")]
	private EBECDECKCOD MFAEEKALKCC;

	[Token(Token = "0x400F538")]
	[FieldOffset(Offset = "0x38")]
	private IHAAMHPPLMG HBDJBGHPOOP;

	[Token(Token = "0x400F539")]
	[FieldOffset(Offset = "0x50")]
	private Player AHJBMLIHBLE;

	[Token(Token = "0x400F53A")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 KKGGIFOCFLN;

	[Token(Token = "0x400F53B")]
	[FieldOffset(Offset = "0x60")]
	private float OGNOLDBKCFG;

	[Token(Token = "0x400F53C")]
	[FieldOffset(Offset = "0x0")]
	public static Vector2 ZoneFieldViewPos;

	[Token(Token = "0x400F53D")]
	[FieldOffset(Offset = "0x8")]
	public static Vector2 ZoneFieldViewSize;

	[Token(Token = "0x400F53E")]
	[FieldOffset(Offset = "0x64")]
	private Dictionary<IHAAMHPPLMG, LKJMDKOKMBO> KKEFEOGGPAB;

	[Token(Token = "0x400F53F")]
	[FieldOffset(Offset = "0x68")]
	private Queue<LKJMDKOKMBO> FBDJNEAFJLN;

	[Token(Token = "0x400F540")]
	[FieldOffset(Offset = "0x6C")]
	private Dictionary<uint, List<IHAAMHPPLMG>> BPNBBJEPKLC;

	[Token(Token = "0x400F541")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<LevelVehicle, SoundTipsView> CNJFINPLDHO;

	[Token(Token = "0x400F542")]
	[FieldOffset(Offset = "0x74")]
	private Queue<SoundTipsView> EKGLLEBBBJL;

	[Token(Token = "0x400F543")]
	[FieldOffset(Offset = "0x78")]
	private SoundTipsData NBGNEHKFPNG;

	[Token(Token = "0x400F544")]
	[FieldOffset(Offset = "0x7C")]
	private Dictionary<IHAAMHPPLMG, uint> PBIMICLKJDB;

	[Token(Token = "0x400F545")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<uint, uint> ICFKOLAHJJK;

	[Token(Token = "0x400F546")]
	[FieldOffset(Offset = "0x84")]
	private Dictionary<uint, LKJMDKOKMBO> GPKJDPAPACD;

	[Token(Token = "0x400F547")]
	[FieldOffset(Offset = "0x88")]
	private SafeZone NFFBCAEJPGM;

	[Token(Token = "0x400F548")]
	[FieldOffset(Offset = "0x8C")]
	private float PGFIJGCIPIM;

	[Token(Token = "0x400F549")]
	[FieldOffset(Offset = "0x90")]
	private float GNIFHBLIKCC;

	[Token(Token = "0x400F54A")]
	[FieldOffset(Offset = "0x94")]
	private float DOBPJCBJGHP;

	[Token(Token = "0x400F54B")]
	[FieldOffset(Offset = "0x98")]
	private float HAONJEFEJHF;

	[Token(Token = "0x400F54C")]
	[FieldOffset(Offset = "0x9C")]
	private float HMEIHOKPLPP;

	[Token(Token = "0x400F54D")]
	[FieldOffset(Offset = "0xA0")]
	private float GGJFKENLKFI;

	[Token(Token = "0x400F54E")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3 KLAKJDDDOFI;

	[Token(Token = "0x400F54F")]
	[FieldOffset(Offset = "0xB0")]
	private PFHAEJBOLEM LKAENMAJIDL;

	[Token(Token = "0x400F550")]
	[FieldOffset(Offset = "0xB4")]
	private bool HOLJJDGDPJB;

	[Token(Token = "0x400F551")]
	[FieldOffset(Offset = "0xB5")]
	private bool JJMFHNEOIDB;

	[Token(Token = "0x400F552")]
	[FieldOffset(Offset = "0x10")]
	public static JPKDINFPGOD MinimapMode;

	[Token(Token = "0x400F553")]
	[FieldOffset(Offset = "0xB6")]
	private bool EHCHBFELOGK;

	[Token(Token = "0x600F576")]
	[Address(RVA = "0x121CFE8", Offset = "0x121CFE8", VA = "0x121CFE8")]
	public UIHudMinimapController()
	{
	}

	[Token(Token = "0x600F577")]
	[Address(RVA = "0x121D2A8", Offset = "0x121D2A8", VA = "0x121D2A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F578")]
	[Address(RVA = "0x121D30C", Offset = "0x121D30C", VA = "0x121D30C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F579")]
	[Address(RVA = "0x121E7DC", Offset = "0x121E7DC", VA = "0x121E7DC")]
	private void DIMIHGCNACA(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F57A")]
	[Address(RVA = "0x121D8D0", Offset = "0x121D8D0", VA = "0x121D8D0")]
	private void ACLCKHMFAME()
	{
	}

	[Token(Token = "0x600F57B")]
	[Address(RVA = "0x121D9F0", Offset = "0x121D9F0", VA = "0x121D9F0")]
	private void PCNLCOCLOJO()
	{
	}

	[Token(Token = "0x600F57C")]
	[Address(RVA = "0x121FD28", Offset = "0x121FD28", VA = "0x121FD28", Slot = "31")]
	protected override void RegisterEvents()
	{
	}

	[Token(Token = "0x600F57D")]
	[Address(RVA = "0x1220998", Offset = "0x1220998", VA = "0x1220998", Slot = "32")]
	protected override void UnRegisterEvents()
	{
	}

	[Token(Token = "0x600F57E")]
	[Address(RVA = "0x1221514", Offset = "0x1221514", VA = "0x1221514", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F57F")]
	[Address(RVA = "0x121FD20", Offset = "0x121FD20", VA = "0x121FD20")]
	private bool JANLADKEFCH()
	{
		return default(bool);
	}

	[Token(Token = "0x600F580")]
	[Address(RVA = "0x121D788", Offset = "0x121D788", VA = "0x121D788")]
	private bool GJPEMHAGKAF()
	{
		return default(bool);
	}

	[Token(Token = "0x600F581")]
	[Address(RVA = "0x1221668", Offset = "0x1221668", VA = "0x1221668")]
	private void Update()
	{
	}

	[Token(Token = "0x600F582")]
	[Address(RVA = "0x1222294", Offset = "0x1222294", VA = "0x1222294")]
	private bool KICKBGIHNCP(float PDBFJFODFOP)
	{
		return default(bool);
	}

	[Token(Token = "0x600F583")]
	[Address(RVA = "0x12228FC", Offset = "0x12228FC", VA = "0x12228FC")]
	private bool MBAJNHNJJHH(float PDBFJFODFOP)
	{
		return default(bool);
	}

	[Token(Token = "0x600F584")]
	[Address(RVA = "0x1224950", Offset = "0x1224950", VA = "0x1224950")]
	private void FDPPHMOHCLO(float PDBFJFODFOP)
	{
	}

	[Token(Token = "0x600F585")]
	[Address(RVA = "0x1226984", Offset = "0x1226984", VA = "0x1226984")]
	private float KDPNCDHMNHG()
	{
		return default(float);
	}

	[Token(Token = "0x600F586")]
	[Address(RVA = "0x1226088", Offset = "0x1226088", VA = "0x1226088")]
	private void JOGIFGDGPJJ(float IOOPPDAAMEP)
	{
	}

	[Token(Token = "0x600F587")]
	[Address(RVA = "0x12251B4", Offset = "0x12251B4", VA = "0x12251B4")]
	private void GEIEHDFOFAJ()
	{
	}

	[Token(Token = "0x600F588")]
	[Address(RVA = "0x1221F10", Offset = "0x1221F10", VA = "0x1221F10")]
	private float GPCKCEMEBHH()
	{
		return default(float);
	}

	[Token(Token = "0x600F589")]
	[Address(RVA = "0x1226564", Offset = "0x1226564", VA = "0x1226564")]
	private float LHMOHJGMPDO(JPKDINFPGOD KKHJDNILHFN)
	{
		return default(float);
	}

	[Token(Token = "0x600F58A")]
	[Address(RVA = "0x1226F7C", Offset = "0x1226F7C", VA = "0x1226F7C")]
	private void MOANPBBCAGJ(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600F58B")]
	[Address(RVA = "0x1227008", Offset = "0x1227008", VA = "0x1227008")]
	public void RefreshPlayerArrow()
	{
	}

	[Token(Token = "0x600F58C")]
	[Address(RVA = "0x12271D8", Offset = "0x12271D8", VA = "0x12271D8")]
	private void CBKEHDPJNFE()
	{
	}

	[Token(Token = "0x600F58D")]
	[Address(RVA = "0x12276B0", Offset = "0x12276B0", VA = "0x12276B0")]
	private void FNMAAKEGAPI(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600F58E")]
	[Address(RVA = "0x12276E4", Offset = "0x12276E4", VA = "0x12276E4")]
	private void EDCBBKLMIOJ(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600F58F")]
	[Address(RVA = "0x121EFAC", Offset = "0x121EFAC", VA = "0x121EFAC")]
	private void EIFOOCACGFN(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600F590")]
	[Address(RVA = "0x1227D80", Offset = "0x1227D80", VA = "0x1227D80")]
	private void LOEOFNDFGAJ(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600F591")]
	[Address(RVA = "0x12281B4", Offset = "0x12281B4", VA = "0x12281B4")]
	private void OPCCABKFOJB(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600F592")]
	[Address(RVA = "0x1228734", Offset = "0x1228734", VA = "0x1228734")]
	public UIButton GetTutorialBtn()
	{
		return null;
	}

	[Token(Token = "0x600F593")]
	[Address(RVA = "0x122873C", Offset = "0x122873C", VA = "0x122873C")]
	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	[Token(Token = "0x600F594")]
	private void JBCGDEPDNOM<T>(Dictionary<T, uint> LGPPCHLFFFG, Dictionary<T, LKJMDKOKMBO> LKHJCNHFMLM, T FKPFJHMFGCJ, float NFPILHKMBHL = 1f)
	{
	}

	[Token(Token = "0x600F595")]
	[Address(RVA = "0x1227B80", Offset = "0x1227B80", VA = "0x1227B80")]
	private void OMKKHOHOGIJ(IHAAMHPPLMG FKPFJHMFGCJ)
	{
	}

	[Token(Token = "0x600F596")]
	[Address(RVA = "0x12287C0", Offset = "0x12287C0", VA = "0x12287C0")]
	private void LHCMDGEHPNG(uint IBFJIEGOCJA)
	{
	}

	[Token(Token = "0x600F597")]
	[Address(RVA = "0x122884C", Offset = "0x122884C", VA = "0x122884C", Slot = "33")]
	protected override void OnObservePlayer(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F598")]
	[Address(RVA = "0x122906C", Offset = "0x122906C", VA = "0x122906C")]
	private IEnumerator HILOBKEKJDK(IHAAMHPPLMG FKPFJHMFGCJ, float AKAJHMHFKMG)
	{
		return null;
	}

	[Token(Token = "0x600F599")]
	[Address(RVA = "0x1229160", Offset = "0x1229160", VA = "0x1229160")]
	private void NIECAPJHONE(IHAAMHPPLMG FKPFJHMFGCJ)
	{
	}

	[Token(Token = "0x600F59A")]
	private void PIIEAEMHFHC<T>(Dictionary<T, LKJMDKOKMBO> LGPPCHLFFFG, T FKPFJHMFGCJ)
	{
	}

	[Token(Token = "0x600F59B")]
	[Address(RVA = "0x1229200", Offset = "0x1229200", VA = "0x1229200")]
	public void OnSafeZoneChanged(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600F59C")]
	[Address(RVA = "0x1229324", Offset = "0x1229324", VA = "0x1229324")]
	private void DOOIAGOKEPD(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F59D")]
	[Address(RVA = "0x1229440", Offset = "0x1229440", VA = "0x1229440")]
	private void GFOCKLIODFG(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F59E")]
	[Address(RVA = "0x1229528", Offset = "0x1229528", VA = "0x1229528")]
	public void OnShowJKPTutorial(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600F59F")]
	[Address(RVA = "0x1229610", Offset = "0x1229610", VA = "0x1229610")]
	public void OnForecastEffectShow(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600F5A0")]
	[Address(RVA = "0x12298A4", Offset = "0x12298A4", VA = "0x12298A4")]
	public void OnTrainingZoneChange(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600F5A1")]
	[Address(RVA = "0x1229B1C", Offset = "0x1229B1C", VA = "0x1229B1C")]
	private void FGCIPLBLPGJ(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600F5A2")]
	[Address(RVA = "0x1229B20", Offset = "0x1229B20", VA = "0x1229B20")]
	private void KLGKGOBPHHD(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5A3")]
	[Address(RVA = "0x1229ECC", Offset = "0x1229ECC", VA = "0x1229ECC")]
	private void NDJBJCNLJBD(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5A4")]
	[Address(RVA = "0x1229F90", Offset = "0x1229F90", VA = "0x1229F90", Slot = "35")]
	protected override void OnPlayerHPChanged(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5A5")]
	[Address(RVA = "0x122A480", Offset = "0x122A480", VA = "0x122A480")]
	private void OKNIIMGLBGE(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5A6")]
	[Address(RVA = "0x122B284", Offset = "0x122B284", VA = "0x122B284")]
	private void ICIGMJBMGBD(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5A7")]
	[Address(RVA = "0x122AAA0", Offset = "0x122AAA0", VA = "0x122AAA0")]
	private void EHIFJJCHNNM(List<IHAAMHPPLMG> KAIDEHPHNNI, Vehicle NOLNFIAPLND, IHAAMHPPLMG CBFBOEHAFBO)
	{
	}

	[Token(Token = "0x600F5A8")]
	[Address(RVA = "0x122BA54", Offset = "0x122BA54", VA = "0x122BA54")]
	private void PDJOHNKHFGE(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5A9")]
	[Address(RVA = "0x122BEAC", Offset = "0x122BEAC", VA = "0x122BEAC")]
	private void GCJCMMEHJIF(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5AA")]
	[Address(RVA = "0x122C17C", Offset = "0x122C17C", VA = "0x122C17C")]
	private void MALKDBJNMML(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5AB")]
	[Address(RVA = "0x122CC80", Offset = "0x122CC80", VA = "0x122CC80")]
	private void KPKCNICMCHN(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5AC")]
	[Address(RVA = "0x122CF94", Offset = "0x122CF94", VA = "0x122CF94")]
	private void BJCCLJDCCNC(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600F5AD")]
	[Address(RVA = "0x1227718", Offset = "0x1227718", VA = "0x1227718")]
	private LKJMDKOKMBO OGNAAAAALPN(uint IDNEFEOPGIF, Vector3 ACCOJJMKKPM, Vector3 EBIJHALKJEM)
	{
		return null;
	}

	[Token(Token = "0x600F5AE")]
	[Address(RVA = "0x1227C28", Offset = "0x1227C28", VA = "0x1227C28")]
	private void BIBIAELKFML(LKJMDKOKMBO PBMBLMIFKNG, Vector3 ACCOJJMKKPM, Vector3 EBIJHALKJEM)
	{
	}

	[Token(Token = "0x600F5AF")]
	[Address(RVA = "0x122D550", Offset = "0x122D550", VA = "0x122D550")]
	private void PBMAPMDJCKA(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5B0")]
	[Address(RVA = "0x122D68C", Offset = "0x122D68C", VA = "0x122D68C")]
	private void CEEIPEKDFHI(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5B1")]
	[Address(RVA = "0x122D8F8", Offset = "0x122D8F8", VA = "0x122D8F8")]
	private void LMGKAPLLPHK(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5B2")]
	[Address(RVA = "0x122D8FC", Offset = "0x122D8FC", VA = "0x122D8FC")]
	private void JLBAGKFAGAP(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5B3")]
	[Address(RVA = "0x122D9C0", Offset = "0x122D9C0", VA = "0x122D9C0")]
	private void EKOBGAJCMLG(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5B4")]
	[Address(RVA = "0x122DA74", Offset = "0x122DA74", VA = "0x122DA74")]
	private void HMJEOGIEIMN(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5B5")]
	[Address(RVA = "0x122DB5C", Offset = "0x122DB5C", VA = "0x122DB5C")]
	private void LFLLOABKGAJ(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F5B6")]
	[Address(RVA = "0x122DC4C", Offset = "0x122DC4C", VA = "0x122DC4C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600F5B7")]
	[Address(RVA = "0x122DDA8", Offset = "0x122DDA8", VA = "0x122DDA8")]
	private void LateUpdate()
	{
	}
}
