using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x2001E3F")]
public class UIHudTrainingMiniGameController : UIBaseController
{
	[Token(Token = "0x2001E40")]
	private sealed class AGCGFHINJIB : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400BF06")]
		[FieldOffset(Offset = "0x8")]
		internal CPAMLNADDFM JDKKCJCDEIF;

		[Token(Token = "0x400BF07")]
		[FieldOffset(Offset = "0xC")]
		internal uint DCLIIIKLBLP;

		[Token(Token = "0x400BF08")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudTrainingMiniGameController GADHAMJEKIM;

		[Token(Token = "0x400BF09")]
		[FieldOffset(Offset = "0x14")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x400BF0A")]
		[FieldOffset(Offset = "0x18")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x400BF0B")]
		[FieldOffset(Offset = "0x1C")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x17000F2F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600916A")]
			[Address(RVA = "0xF86B54", Offset = "0xF86B54", VA = "0xF86B54", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F30")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600916B")]
			[Address(RVA = "0xF86B5C", Offset = "0xF86B5C", VA = "0xF86B5C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009168")]
		[Address(RVA = "0xF83364", Offset = "0xF83364", VA = "0xF83364")]
		public AGCGFHINJIB()
		{
		}

		[Token(Token = "0x6009169")]
		[Address(RVA = "0xF86668", Offset = "0xF86668", VA = "0xF86668", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600916C")]
		[Address(RVA = "0xF86B64", Offset = "0xF86B64", VA = "0xF86B64", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600916D")]
		[Address(RVA = "0xF86B78", Offset = "0xF86B78", VA = "0xF86B78", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001E41")]
	private sealed class GKEDCFNDFGK : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400BF0C")]
		[FieldOffset(Offset = "0x8")]
		internal float GLBHNKFFJPD;

		[Token(Token = "0x400BF0D")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudTrainingMiniGameController GADHAMJEKIM;

		[Token(Token = "0x400BF0E")]
		[FieldOffset(Offset = "0x10")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x400BF0F")]
		[FieldOffset(Offset = "0x14")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x400BF10")]
		[FieldOffset(Offset = "0x18")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x17000F31")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009170")]
			[Address(RVA = "0xF870F8", Offset = "0xF870F8", VA = "0xF870F8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F32")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009171")]
			[Address(RVA = "0xF87100", Offset = "0xF87100", VA = "0xF87100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600916E")]
		[Address(RVA = "0xF83F80", Offset = "0xF83F80", VA = "0xF83F80")]
		public GKEDCFNDFGK()
		{
		}

		[Token(Token = "0x600916F")]
		[Address(RVA = "0xF86C00", Offset = "0xF86C00", VA = "0xF86C00", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009172")]
		[Address(RVA = "0xF87108", Offset = "0xF87108", VA = "0xF87108", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009173")]
		[Address(RVA = "0xF8711C", Offset = "0xF8711C", VA = "0xF8711C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400BEF3")]
	[FieldOffset(Offset = "0x28")]
	private UIHudTrainingMiniGameView NOJLDPLOCIH;

	[Token(Token = "0x400BEF4")]
	[FieldOffset(Offset = "0x2C")]
	private CBNIKECJHAN DCMBDLCHGJJ;

	[Token(Token = "0x400BEF5")]
	[FieldOffset(Offset = "0x30")]
	private JNGKMJDINHC GCFGNIFCNDC;

	[Token(Token = "0x400BEF6")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<int, CPAMLNADDFM> BNABLJLIGGI;

	[Token(Token = "0x400BEF7")]
	[FieldOffset(Offset = "0x38")]
	private StringBuilder OKLJNPPPMIJ;

	[Token(Token = "0x400BEF8")]
	[FieldOffset(Offset = "0x3C")]
	private string BBHINJFKJAK;

	[Token(Token = "0x400BEF9")]
	[FieldOffset(Offset = "0x40")]
	private uint MKGCDPNKMOB;

	[Token(Token = "0x400BEFA")]
	[FieldOffset(Offset = "0x44")]
	private uint NCNKFDHKDMD;

	[Token(Token = "0x400BEFB")]
	[FieldOffset(Offset = "0x48")]
	private float AFFLGFOBGHG;

	[Token(Token = "0x400BEFC")]
	[FieldOffset(Offset = "0x4C")]
	private uint BJEILPKAEFI;

	[Token(Token = "0x400BEFD")]
	[FieldOffset(Offset = "0x50")]
	private bool JGEKNDIOPFD;

	[Token(Token = "0x400BEFE")]
	[FieldOffset(Offset = "0x54")]
	private uint GHONIKMIHLI;

	[Token(Token = "0x400BEFF")]
	[FieldOffset(Offset = "0x58")]
	private List<UILabel> FNNIDKMBALP;

	[Token(Token = "0x400BF00")]
	[FieldOffset(Offset = "0x5C")]
	private List<UILabel> FLMPOMBFAPL;

	[Token(Token = "0x400BF01")]
	[FieldOffset(Offset = "0x0")]
	public static readonly uint LocalSimulationIceWallUniqueIDStart;

	[Token(Token = "0x400BF02")]
	[FieldOffset(Offset = "0x4")]
	public static readonly uint LocalSimulationGrenadeUniqueIDStart;

	[Token(Token = "0x400BF03")]
	[FieldOffset(Offset = "0x60")]
	private TrainingMiniGameMap FDGLPOGBBLM;

	[Token(Token = "0x400BF04")]
	[FieldOffset(Offset = "0x64")]
	public uint m_CurGameEntryId;

	[Token(Token = "0x400BF05")]
	[FieldOffset(Offset = "0x68")]
	private ulong KKHLPINACKP;

	[Token(Token = "0x600913C")]
	[Address(RVA = "0xF7FD78", Offset = "0xF7FD78", VA = "0xF7FD78")]
	public UIHudTrainingMiniGameController()
	{
	}

	[Token(Token = "0x600913D")]
	[Address(RVA = "0xF7FE38", Offset = "0xF7FE38", VA = "0xF7FE38")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600913E")]
	[Address(RVA = "0xF7FEDC", Offset = "0xF7FEDC", VA = "0xF7FEDC")]
	public static JNGKMJDINHC GetMiniGameByServerType(MALGAHKKNNN OJNCGNNGFPB)
	{
		return default(JNGKMJDINHC);
	}

	[Token(Token = "0x600913F")]
	[Address(RVA = "0xF7FF48", Offset = "0xF7FF48", VA = "0xF7FF48")]
	public CPAMLNADDFM GetCurTrainingMiniGame()
	{
		return null;
	}

	[Token(Token = "0x6009140")]
	[Address(RVA = "0xF80028", Offset = "0xF80028", VA = "0xF80028")]
	private CPAMLNADDFM HFCCAJKFKAD(JNGKMJDINHC OJNCGNNGFPB)
	{
		return null;
	}

	[Token(Token = "0x6009141")]
	[Address(RVA = "0xF80110", Offset = "0xF80110", VA = "0xF80110", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009142")]
	[Address(RVA = "0xF81338", Offset = "0xF81338", VA = "0xF81338", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009143")]
	[Address(RVA = "0xF818E0", Offset = "0xF818E0", VA = "0xF818E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6009144")]
	[Address(RVA = "0xF81A30", Offset = "0xF81A30", VA = "0xF81A30")]
	private void PMKGKBMHOHL()
	{
	}

	[Token(Token = "0x6009145")]
	[Address(RVA = "0xF8261C", Offset = "0xF8261C", VA = "0xF8261C")]
	private void LBKCLMHMFGM()
	{
	}

	[Token(Token = "0x6009146")]
	[Address(RVA = "0xF828F4", Offset = "0xF828F4", VA = "0xF828F4")]
	public void PreCountDown()
	{
	}

	[Token(Token = "0x6009147")]
	[Address(RVA = "0xF83298", Offset = "0xF83298", VA = "0xF83298")]
	private IEnumerator JGDBMDKKOAC()
	{
		return null;
	}

	[Token(Token = "0x6009148")]
	[Address(RVA = "0xF82DCC", Offset = "0xF82DCC", VA = "0xF82DCC")]
	private void FJKAEKLBJIM()
	{
	}

	[Token(Token = "0x6009149")]
	[Address(RVA = "0xF81D40", Offset = "0xF81D40", VA = "0xF81D40")]
	private void DGLIJFHKBDP()
	{
	}

	[Token(Token = "0x600914A")]
	[Address(RVA = "0xF83EB4", Offset = "0xF83EB4", VA = "0xF83EB4")]
	private IEnumerator EDKKKIEKCFP()
	{
		return null;
	}

	[Token(Token = "0x600914B")]
	[Address(RVA = "0xF83F88", Offset = "0xF83F88", VA = "0xF83F88")]
	private void FPIFKMPMIGH(bool KEEIHKKBKOF = true)
	{
	}

	[Token(Token = "0x600914C")]
	[Address(RVA = "0xF84314", Offset = "0xF84314", VA = "0xF84314")]
	private void JNLCDJEMENA()
	{
	}

	[Token(Token = "0x600914D")]
	[Address(RVA = "0xF84568", Offset = "0xF84568", VA = "0xF84568")]
	private void OAPCHBKJPDL()
	{
	}

	[Token(Token = "0x600914E")]
	[Address(RVA = "0xF847B8", Offset = "0xF847B8", VA = "0xF847B8")]
	private void NJDJOPJGJAI()
	{
	}

	[Token(Token = "0x600914F")]
	[Address(RVA = "0xF849F8", Offset = "0xF849F8", VA = "0xF849F8")]
	private void PHKBIMEPEAK()
	{
	}

	[Token(Token = "0x6009150")]
	[Address(RVA = "0xF83D94", Offset = "0xF83D94", VA = "0xF83D94")]
	private void HKLLNPLMJDP()
	{
	}

	[Token(Token = "0x6009151")]
	[Address(RVA = "0xF84C28", Offset = "0xF84C28", VA = "0xF84C28")]
	private void OGAFONFDPAD(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6009152")]
	[Address(RVA = "0xF84D8C", Offset = "0xF84D8C", VA = "0xF84D8C")]
	private void FGBNNJPNEEJ(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6009153")]
	[Address(RVA = "0xF84EFC", Offset = "0xF84EFC", VA = "0xF84EFC")]
	private void AFLMKMACMIF(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6009154")]
	[Address(RVA = "0xF850A8", Offset = "0xF850A8", VA = "0xF850A8")]
	private void AGKMMJBJHML(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6009155")]
	[Address(RVA = "0xF8518C", Offset = "0xF8518C", VA = "0xF8518C")]
	private void EIEBLJECHKJ(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6009156")]
	[Address(RVA = "0xF82C70", Offset = "0xF82C70", VA = "0xF82C70")]
	private void AEPLFPIPFLC()
	{
	}

	[Token(Token = "0x6009157")]
	[Address(RVA = "0xF8336C", Offset = "0xF8336C", VA = "0xF8336C")]
	private uint MJNCGJFFNJI()
	{
		return default(uint);
	}

	[Token(Token = "0x6009158")]
	[Address(RVA = "0xF838EC", Offset = "0xF838EC", VA = "0xF838EC")]
	private void NEECCDKBOFJ(uint DBGBPGFHKHE)
	{
	}

	[Token(Token = "0x6009159")]
	[Address(RVA = "0xF851F4", Offset = "0xF851F4", VA = "0xF851F4")]
	private bool PDHEEOILOEG(uint DBGBPGFHKHE)
	{
		return default(bool);
	}

	[Token(Token = "0x600915A")]
	[Address(RVA = "0xF85328", Offset = "0xF85328", VA = "0xF85328")]
	private void IPPBDKLNFGH(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600915B")]
	[Address(RVA = "0xF85764", Offset = "0xF85764", VA = "0xF85764")]
	private void GCKLPEFKGFG(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600915C")]
	[Address(RVA = "0xF859EC", Offset = "0xF859EC", VA = "0xF859EC")]
	private void MNELLGHIIFF(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600915D")]
	[Address(RVA = "0xF85B30", Offset = "0xF85B30", VA = "0xF85B30")]
	private void PCJLNOGNLKK(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600915E")]
	[Address(RVA = "0xF85C18", Offset = "0xF85C18", VA = "0xF85C18")]
	private void KGHFJMOPEFF(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600915F")]
	[Address(RVA = "0xF85F4C", Offset = "0xF85F4C", VA = "0xF85F4C")]
	public void SetServerMiniGameType(MALGAHKKNNN OJNCGNNGFPB)
	{
	}

	[Token(Token = "0x6009160")]
	[Address(RVA = "0xF86068", Offset = "0xF86068", VA = "0xF86068", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x6009161")]
	[Address(RVA = "0xF86200", Offset = "0xF86200", VA = "0xF86200", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x6009162")]
	[Address(RVA = "0xF86370", Offset = "0xF86370", VA = "0xF86370")]
	public void TestMark()
	{
	}

	[Token(Token = "0x6009164")]
	[Address(RVA = "0xF86648", Offset = "0xF86648", VA = "0xF86648")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009165")]
	[Address(RVA = "0xF86650", Offset = "0xF86650", VA = "0xF86650")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6009166")]
	[Address(RVA = "0xF86658", Offset = "0xF86658", VA = "0xF86658")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x6009167")]
	[Address(RVA = "0xF86660", Offset = "0xF86660", VA = "0xF86660")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
