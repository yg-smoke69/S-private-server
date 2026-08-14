using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.HUD;

[Token(Token = "0x20027CB")]
internal class UIHudNameController : UIBaseController, _Attribute
{
	[Token(Token = "0x20027CC")]
	private enum MPOLJMJBFCB
	{
		[Token(Token = "0x400F5CB")]
		NONE,
		[Token(Token = "0x400F5CC")]
		UP,
		[Token(Token = "0x400F5CD")]
		DOWN,
		[Token(Token = "0x400F5CE")]
		LEFT,
		[Token(Token = "0x400F5CF")]
		RIGHT
	}

	[Token(Token = "0x20027CD")]
	private sealed class PPDLBFJEHEH : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F5D0")]
		[FieldOffset(Offset = "0x8")]
		internal float AKAJHMHFKMG;

		[Token(Token = "0x400F5D1")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudNameController GADHAMJEKIM;

		[Token(Token = "0x400F5D2")]
		[FieldOffset(Offset = "0x10")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x400F5D3")]
		[FieldOffset(Offset = "0x14")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x400F5D4")]
		[FieldOffset(Offset = "0x18")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170011DE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600F683")]
			[Address(RVA = "0x18EB67C", Offset = "0x18EB67C", VA = "0x18EB67C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011DF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600F684")]
			[Address(RVA = "0x18EB684", Offset = "0x18EB684", VA = "0x18EB684", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600F681")]
		[Address(RVA = "0x18EB498", Offset = "0x18EB498", VA = "0x18EB498")]
		public PPDLBFJEHEH()
		{
		}

		[Token(Token = "0x600F682")]
		[Address(RVA = "0x18EB4A0", Offset = "0x18EB4A0", VA = "0x18EB4A0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600F685")]
		[Address(RVA = "0x18EB68C", Offset = "0x18EB68C", VA = "0x18EB68C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600F686")]
		[Address(RVA = "0x18EB6A0", Offset = "0x18EB6A0", VA = "0x18EB6A0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20027CE")]
	private sealed class IDDGIJIFPMM : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F5D5")]
		[FieldOffset(Offset = "0x8")]
		internal float PODKEPNOBON;

		[Token(Token = "0x400F5D6")]
		[FieldOffset(Offset = "0xC")]
		internal GameObject COIKPLNJBHM;

		[Token(Token = "0x400F5D7")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudNameController GADHAMJEKIM;

		[Token(Token = "0x400F5D8")]
		[FieldOffset(Offset = "0x14")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x400F5D9")]
		[FieldOffset(Offset = "0x18")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x400F5DA")]
		[FieldOffset(Offset = "0x1C")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170011E0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600F689")]
			[Address(RVA = "0x18EB13C", Offset = "0x18EB13C", VA = "0x18EB13C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011E1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600F68A")]
			[Address(RVA = "0x18EB144", Offset = "0x18EB144", VA = "0x18EB144", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600F687")]
		[Address(RVA = "0x18EAF40", Offset = "0x18EAF40", VA = "0x18EAF40")]
		public IDDGIJIFPMM()
		{
		}

		[Token(Token = "0x600F688")]
		[Address(RVA = "0x18EAF48", Offset = "0x18EAF48", VA = "0x18EAF48", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600F68B")]
		[Address(RVA = "0x18EB14C", Offset = "0x18EB14C", VA = "0x18EB14C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600F68C")]
		[Address(RVA = "0x18EB160", Offset = "0x18EB160", VA = "0x18EB160", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20027CF")]
	private sealed class LCCLFKEPNCB : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F5DB")]
		[FieldOffset(Offset = "0x8")]
		internal float AKAJHMHFKMG;

		[Token(Token = "0x400F5DC")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudNameController GADHAMJEKIM;

		[Token(Token = "0x400F5DD")]
		[FieldOffset(Offset = "0x10")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x400F5DE")]
		[FieldOffset(Offset = "0x14")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x400F5DF")]
		[FieldOffset(Offset = "0x18")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170011E2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600F68F")]
			[Address(RVA = "0x18EB3EC", Offset = "0x18EB3EC", VA = "0x18EB3EC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011E3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600F690")]
			[Address(RVA = "0x18EB3F4", Offset = "0x18EB3F4", VA = "0x18EB3F4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600F68D")]
		[Address(RVA = "0x18EB1E8", Offset = "0x18EB1E8", VA = "0x18EB1E8")]
		public LCCLFKEPNCB()
		{
		}

		[Token(Token = "0x600F68E")]
		[Address(RVA = "0x18EB1F0", Offset = "0x18EB1F0", VA = "0x18EB1F0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600F691")]
		[Address(RVA = "0x18EB3FC", Offset = "0x18EB3FC", VA = "0x18EB3FC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600F692")]
		[Address(RVA = "0x18EB410", Offset = "0x18EB410", VA = "0x18EB410", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F5AA")]
	[FieldOffset(Offset = "0x28")]
	private readonly Color EKHLPDCANMM;

	[Token(Token = "0x400F5AB")]
	[FieldOffset(Offset = "0x38")]
	private readonly Color KPIPAGOHJJI;

	[Token(Token = "0x400F5AC")]
	[FieldOffset(Offset = "0x48")]
	private readonly Color FEANKLJJIML;

	[Token(Token = "0x400F5AD")]
	[FieldOffset(Offset = "0x58")]
	private readonly float KHCADCGCPML;

	[Token(Token = "0x400F5AE")]
	[FieldOffset(Offset = "0x5C")]
	private readonly Vector3 AAEJGMJFGFJ;

	[Token(Token = "0x400F5AF")]
	private const float NHBLNPJNGIH = 20f;

	[Token(Token = "0x400F5B0")]
	[FieldOffset(Offset = "0x68")]
	private UIHudNameView NOJLDPLOCIH;

	[Token(Token = "0x400F5B1")]
	[FieldOffset(Offset = "0x70")]
	private IHAAMHPPLMG MJCIOGBICHJ;

	[Token(Token = "0x400F5B2")]
	[FieldOffset(Offset = "0x88")]
	private UIInGameScene EAOBGOHILPM;

	[Token(Token = "0x400F5B3")]
	[FieldOffset(Offset = "0x8C")]
	private Camera CHDOHNOEBML;

	[Token(Token = "0x400F5B4")]
	[FieldOffset(Offset = "0x90")]
	private FollowCamera EPOHLGPAJCG;

	[Token(Token = "0x400F5B5")]
	[FieldOffset(Offset = "0x94")]
	private Camera LJGIHOEPFGD;

	[Token(Token = "0x400F5B6")]
	[FieldOffset(Offset = "0x98")]
	private Queue EHGEDDBKPKF;

	[Token(Token = "0x400F5B7")]
	[FieldOffset(Offset = "0x9C")]
	private bool FLLDPFDFGJA;

	[Token(Token = "0x400F5B8")]
	[FieldOffset(Offset = "0xA0")]
	private Vector2 KEMINOHAPIF;

	[Token(Token = "0x400F5B9")]
	[FieldOffset(Offset = "0xA8")]
	private StringBuilder FPGGDNNFGDM;

	[Token(Token = "0x400F5BA")]
	[FieldOffset(Offset = "0xAC")]
	private int GFAFNAIDBKD;

	[Token(Token = "0x400F5BB")]
	[FieldOffset(Offset = "0xB0")]
	private int NHDHMLDIACM;

	[Token(Token = "0x400F5BC")]
	[FieldOffset(Offset = "0xB4")]
	private UIHudTriggerEventMarkController EJMJBLPJLAJ;

	[Token(Token = "0x400F5BD")]
	[FieldOffset(Offset = "0xB8")]
	private float HPFICPAOHGC;

	[Token(Token = "0x400F5BE")]
	[FieldOffset(Offset = "0xBC")]
	private bool BHIOEOGBAOK;

	[Token(Token = "0x400F5BF")]
	[FieldOffset(Offset = "0xBD")]
	private bool EKAEKHOPOAM;

	[Token(Token = "0x400F5C0")]
	[FieldOffset(Offset = "0xBE")]
	private bool KCEAINLFBJL;

	[Token(Token = "0x400F5C1")]
	[FieldOffset(Offset = "0xC0")]
	private string PFDNHJHAHCM;

	[Token(Token = "0x400F5C2")]
	[FieldOffset(Offset = "0xC4")]
	private string MGIGKHIOBBI;

	[Token(Token = "0x400F5C3")]
	[FieldOffset(Offset = "0xC8")]
	private bool NHPOEEDMDJD;

	[Token(Token = "0x400F5C4")]
	[FieldOffset(Offset = "0xC9")]
	private bool IMLDHCCMAMO;

	[Token(Token = "0x400F5C5")]
	[FieldOffset(Offset = "0xCC")]
	private uint NDCDCOFICAM;

	[Token(Token = "0x400F5C6")]
	[FieldOffset(Offset = "0xD0")]
	private FNCMBMMKLLI.IALJILGPBEL JPIJCGNDMKH;

	[Token(Token = "0x400F5C7")]
	private const float IJBHJDLIODC = 21f;

	[Token(Token = "0x400F5C8")]
	[FieldOffset(Offset = "0xD4")]
	private int GIIPFLFIJOI;

	[Token(Token = "0x400F5C9")]
	[FieldOffset(Offset = "0xD8")]
	private UIHudNameIdentityController IFHMHOLMCEN;

	[Token(Token = "0x600F648")]
	[Address(RVA = "0x122E468", Offset = "0x122E468", VA = "0x122E468")]
	public UIHudNameController()
	{
	}

	[Token(Token = "0x600F649")]
	[Address(RVA = "0x122E6A4", Offset = "0x122E6A4", VA = "0x122E6A4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F64A")]
	[Address(RVA = "0x122E708", Offset = "0x122E708", VA = "0x122E708", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F64B")]
	[Address(RVA = "0x122F9EC", Offset = "0x122F9EC", VA = "0x122F9EC", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F64C")]
	[Address(RVA = "0x1230234", Offset = "0x1230234", VA = "0x1230234")]
	private void EAJMGGJNNFN(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F64D")]
	[Address(RVA = "0x12302D8", Offset = "0x12302D8", VA = "0x12302D8")]
	private void LMOBAGHOPCM()
	{
	}

	[Token(Token = "0x600F64E")]
	[Address(RVA = "0x123067C", Offset = "0x123067C", VA = "0x123067C")]
	private void AKMEPMOKNCA()
	{
	}

	[Token(Token = "0x600F64F")]
	[Address(RVA = "0x12309E4", Offset = "0x12309E4", VA = "0x12309E4")]
	private void FGEGAAFNIIJ(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F650")]
	[Address(RVA = "0x12310E8", Offset = "0x12310E8", VA = "0x12310E8")]
	private void LJPODCMODAA()
	{
	}

	[Token(Token = "0x600F651")]
	[Address(RVA = "0x1231008", Offset = "0x1231008", VA = "0x1231008")]
	private void PJJKNPBENMK()
	{
	}

	[Token(Token = "0x600F652")]
	[Address(RVA = "0x122EB04", Offset = "0x122EB04", VA = "0x122EB04")]
	private void BCMDNJAHMHA()
	{
	}

	[Token(Token = "0x600F653")]
	[Address(RVA = "0x1230010", Offset = "0x1230010", VA = "0x1230010")]
	private void DLGGPKBPMKN()
	{
	}

	[Token(Token = "0x600F654")]
	[Address(RVA = "0x1231450", Offset = "0x1231450", VA = "0x1231450", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F655")]
	[Address(RVA = "0x1231B30", Offset = "0x1231B30", VA = "0x1231B30", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F656")]
	[Address(RVA = "0x1231B50", Offset = "0x1231B50", VA = "0x1231B50", Slot = "31")]
	public void BindPlayer(IHAAMHPPLMG FKPFJHMFGCJ)
	{
	}

	[Token(Token = "0x600F657")]
	[Address(RVA = "0x1234A2C", Offset = "0x1234A2C", VA = "0x1234A2C")]
	public void SetIsFriend(bool JMPJAJDILIJ)
	{
	}

	[Token(Token = "0x600F658")]
	[Address(RVA = "0x1234A40", Offset = "0x1234A40", VA = "0x1234A40")]
	public bool DebugIsWatingRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x600F659")]
	[Address(RVA = "0x1234AF8", Offset = "0x1234AF8", VA = "0x1234AF8", Slot = "32")]
	public void UnbindPlayer()
	{
	}

	[Token(Token = "0x600F65A")]
	[Address(RVA = "0x1232B24", Offset = "0x1232B24", VA = "0x1232B24")]
	private void PBLLGNHKMLG(bool HGMBMICDALC)
	{
	}

	[Token(Token = "0x600F65B")]
	[Address(RVA = "0x1234BD0", Offset = "0x1234BD0", VA = "0x1234BD0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600F65C")]
	[Address(RVA = "0x1234F84", Offset = "0x1234F84", VA = "0x1234F84")]
	private void IAHIHLNFAKC()
	{
	}

	[Token(Token = "0x600F65D")]
	[Address(RVA = "0x1233EAC", Offset = "0x1233EAC", VA = "0x1233EAC")]
	private void LBDDBGLBEOM(Player PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x600F65E")]
	[Address(RVA = "0x1233058", Offset = "0x1233058", VA = "0x1233058")]
	private void NCHMENNKJKP(Player PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x600F65F")]
	[Address(RVA = "0x1232B70", Offset = "0x1232B70", VA = "0x1232B70")]
	private bool BKMHONEHDHF(IHAAMHPPLMG FGFGBHLEONO)
	{
		return default(bool);
	}

	[Token(Token = "0x600F660")]
	[Address(RVA = "0x12333D8", Offset = "0x12333D8", VA = "0x12333D8")]
	private void PKBNGIKPFPD(Player PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x600F661")]
	[Address(RVA = "0x1235A00", Offset = "0x1235A00", VA = "0x1235A00")]
	private void AACJAILNPJB(int IENPBCLGFKM)
	{
	}

	[Token(Token = "0x600F662")]
	[Address(RVA = "0x1235484", Offset = "0x1235484", VA = "0x1235484")]
	private Vector3 EGGJHFKIALM(Player PJOIFFLCDPM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F663")]
	[Address(RVA = "0x1235C78", Offset = "0x1235C78", VA = "0x1235C78")]
	private void PHADFGMNBNO(GameObject ECINOMEHBKA, bool GIKMGIJCDOP)
	{
	}

	[Token(Token = "0x600F664")]
	[Address(RVA = "0x1235D8C", Offset = "0x1235D8C", VA = "0x1235D8C")]
	public void ShowEventTriggerIcon(InGameTriggerMaskData AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F665")]
	[Address(RVA = "0x1235F78", Offset = "0x1235F78", VA = "0x1235F78")]
	public void HideEventTriggerIcon(InGameTriggerMaskData AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F666")]
	[Address(RVA = "0x122F374", Offset = "0x122F374", VA = "0x122F374")]
	private void GCMDDIBHOIP(MPOLJMJBFCB COCOBLKAIMJ)
	{
	}

	[Token(Token = "0x600F667")]
	[Address(RVA = "0x123602C", Offset = "0x123602C", VA = "0x123602C")]
	private void FIHBIHHFLEI(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F668")]
	[Address(RVA = "0x1236978", Offset = "0x1236978", VA = "0x1236978")]
	private GameObject EEIJBAHJGMA(int JLKLMFHFHFF, DBNMCJLEFJI DMGBIOHCALL, AttackableEntity PJOIFFLCDPM)
	{
		return null;
	}

	[Token(Token = "0x600F669")]
	[Address(RVA = "0x1237270", Offset = "0x1237270", VA = "0x1237270")]
	private void EJHCMEKBBFG(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F66A")]
	[Address(RVA = "0x12374F0", Offset = "0x12374F0", VA = "0x12374F0")]
	private void FLFEPOPOIPE(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F66B")]
	[Address(RVA = "0x1234160", Offset = "0x1234160", VA = "0x1234160")]
	private void JLLBHMAOHAI(int POGMMPCAAMM)
	{
	}

	[Token(Token = "0x600F66C")]
	[Address(RVA = "0x123441C", Offset = "0x123441C", VA = "0x123441C")]
	private void CNNPFMOAHGB(int POGMMPCAAMM)
	{
	}

	[Token(Token = "0x600F66D")]
	[Address(RVA = "0x12341D8", Offset = "0x12341D8", VA = "0x12341D8")]
	private void KBHOIABLHKP(IHAAMHPPLMG EBNNIAFEOFA)
	{
	}

	[Token(Token = "0x600F66E")]
	[Address(RVA = "0x12371C4", Offset = "0x12371C4", VA = "0x12371C4")]
	private IEnumerator AKKFJCHOFOG(float AKAJHMHFKMG)
	{
		return null;
	}

	[Token(Token = "0x600F66F")]
	[Address(RVA = "0x1237100", Offset = "0x1237100", VA = "0x1237100")]
	private IEnumerator HOPMENONKLC(GameObject COIKPLNJBHM, float PODKEPNOBON)
	{
		return null;
	}

	[Token(Token = "0x600F670")]
	[Address(RVA = "0x1237770", Offset = "0x1237770", VA = "0x1237770")]
	private IEnumerator CJPMBFKEHIN(float AKAJHMHFKMG)
	{
		return null;
	}

	[Token(Token = "0x600F671")]
	[Address(RVA = "0x12319E0", Offset = "0x12319E0", VA = "0x12319E0")]
	private void LFIMEAIFLGA()
	{
	}

	[Token(Token = "0x600F672")]
	[Address(RVA = "0x123781C", Offset = "0x123781C", VA = "0x123781C")]
	private void LCMPNPFFGOM(GameObject ECINOMEHBKA)
	{
	}

	[Token(Token = "0x600F673")]
	[Address(RVA = "0x12378D4", Offset = "0x12378D4", VA = "0x12378D4")]
	private void JFHOOJOFFEL(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F674")]
	[Address(RVA = "0x1237A10", Offset = "0x1237A10", VA = "0x1237A10")]
	private void NJDPMLKDLGD(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600F675")]
	[Address(RVA = "0x1237E54", Offset = "0x1237E54", VA = "0x1237E54")]
	private void BLOCCNLCBCF(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600F676")]
	[Address(RVA = "0x1232CE8", Offset = "0x1232CE8", VA = "0x1232CE8")]
	private void CLLCOFDHOPH(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F677")]
	[Address(RVA = "0x1237FD0", Offset = "0x1237FD0", VA = "0x1237FD0")]
	private void NGCNMODAMAD(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F678")]
	[Address(RVA = "0x12380B8", Offset = "0x12380B8", VA = "0x12380B8")]
	private void LAEBKAECBDO(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F679")]
	[Address(RVA = "0x123870C", Offset = "0x123870C", VA = "0x123870C")]
	private void GFGEHMANCJB(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F67A")]
	[Address(RVA = "0x1234914", Offset = "0x1234914", VA = "0x1234914")]
	private void COFIEFLHLPI()
	{
	}

	[Token(Token = "0x600F67B")]
	[Address(RVA = "0x12349A0", Offset = "0x12349A0", VA = "0x12349A0")]
	private void KGMKGKECEFG()
	{
	}

	[Token(Token = "0x600F67C")]
	[Address(RVA = "0x123858C", Offset = "0x123858C", VA = "0x123858C")]
	private bool KGNJMKBLEAP(Player PJOIFFLCDPM)
	{
		return default(bool);
	}

	[Token(Token = "0x600F67D")]
	[Address(RVA = "0x1234784", Offset = "0x1234784", VA = "0x1234784")]
	private bool GGFNNIEANLK(Player PJOIFFLCDPM)
	{
		return default(bool);
	}

	[Token(Token = "0x600F67E")]
	[Address(RVA = "0x1238A7C", Offset = "0x1238A7C", VA = "0x1238A7C")]
	public void ShowTutorialCSGameGuide()
	{
	}

	[Token(Token = "0x600F67F")]
	[Address(RVA = "0x1238B64", Offset = "0x1238B64", VA = "0x1238B64")]
	private void BKHPEEJBIKM(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F680")]
	[Address(RVA = "0x1235728", Offset = "0x1235728", VA = "0x1235728")]
	private void AMNAMPHCMHN(Player PJOIFFLCDPM)
	{
	}
}
