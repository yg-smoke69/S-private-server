using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x20005F6")]
public class LevelContainer : LevelContainerBase
{
	[Token(Token = "0x20005F7")]
	public enum DEGNBBAEMBB
	{
		[Token(Token = "0x40044FD")]
		NONE,
		[Token(Token = "0x40044FE")]
		Airdrop,
		[Token(Token = "0x40044FF")]
		Carepacage
	}

	[Token(Token = "0x20005F8")]
	public enum GIDNMDFLPKN
	{
		[Token(Token = "0x4004501")]
		Normal,
		[Token(Token = "0x4004502")]
		Shrink,
		[Token(Token = "0x4004503")]
		Disappear
	}

	[Token(Token = "0x20005F9")]
	private sealed class NOIPLFOCHJM
	{
		[Token(Token = "0x4004504")]
		[FieldOffset(Offset = "0x8")]
		internal MNGBAPBBJDC OIKHKCIIDAD;

		[Token(Token = "0x6002489")]
		[Address(RVA = "0x238D7D4", Offset = "0x238D7D4", VA = "0x238D7D4")]
		public NOIPLFOCHJM()
		{
		}

		[Token(Token = "0x600248A")]
		[Address(RVA = "0x238E270", Offset = "0x238E270", VA = "0x238E270")]
		internal bool CHOPCLCOBKC(MNGBAPBBJDC DLCOENFDFGH)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40044E9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 EDCKIOLINBO;

	[Token(Token = "0x40044EA")]
	[FieldOffset(Offset = "0xC")]
	private static readonly Vector3 OOOFOOIOKJE;

	[Token(Token = "0x40044EB")]
	[FieldOffset(Offset = "0x90")]
	protected Dictionary<IHAAMHPPLMG, HFCNOEBDHEP> ANKEOAFGDBD;

	[Token(Token = "0x40044EC")]
	[FieldOffset(Offset = "0x94")]
	private uint PFMEALCIILA;

	[Token(Token = "0x40044ED")]
	[FieldOffset(Offset = "0x98")]
	private bool OCFFEKPCMLE;

	[Token(Token = "0x40044EE")]
	[FieldOffset(Offset = "0x9C")]
	private ResourceID IIAPHAPHLIO;

	[Token(Token = "0x40044EF")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject MLENEIEMGLJ;

	[Token(Token = "0x40044F0")]
	[FieldOffset(Offset = "0xA4")]
	private bool ENKKHKNOGBI;

	[Token(Token = "0x40044F1")]
	[FieldOffset(Offset = "0xA8")]
	private DEGNBBAEMBB LIOJIMHNKJN;

	[Token(Token = "0x40044F2")]
	[FieldOffset(Offset = "0xAC")]
	private ResourceID OHIAEJMAJLE;

	[Token(Token = "0x40044F3")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject FJBGALAHINC;

	[Token(Token = "0x40044F4")]
	[FieldOffset(Offset = "0xB4")]
	private bool LPEHJDCICHJ;

	[Token(Token = "0x40044F5")]
	[FieldOffset(Offset = "0xB8")]
	private uint HIBHGMMNEHN;

	[Token(Token = "0x40044F6")]
	[FieldOffset(Offset = "0xBC")]
	private List<uint> IFLACNBKOHO;

	[Token(Token = "0x40044F7")]
	[FieldOffset(Offset = "0xC0")]
	private uint FIKHKOAHBGP;

	[Token(Token = "0x40044F8")]
	[FieldOffset(Offset = "0xC4")]
	private uint AMMCIMBGONL;

	[Token(Token = "0x40044F9")]
	[FieldOffset(Offset = "0xC8")]
	private bool MCFKELLKAKC;

	[Token(Token = "0x40044FA")]
	[FieldOffset(Offset = "0xCC")]
	private LevelAirdrop MOOIMBHEPEK;

	[Token(Token = "0x40044FB")]
	[FieldOffset(Offset = "0xD0")]
	private List<uint> AIHOAMBIPNI;

	[Token(Token = "0x600245E")]
	[Address(RVA = "0x23843D4", Offset = "0x23843D4", VA = "0x23843D4")]
	public LevelContainer()
	{
	}

	[Token(Token = "0x600245F")]
	[Address(RVA = "0x23845F8", Offset = "0x23845F8", VA = "0x23845F8")]
	public DEGNBBAEMBB GetAirDropType()
	{
		return default(DEGNBBAEMBB);
	}

	[Token(Token = "0x6002460")]
	[Address(RVA = "0x2384650", Offset = "0x2384650", VA = "0x2384650", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002461")]
	[Address(RVA = "0x2384874", Offset = "0x2384874", VA = "0x2384874", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002462")]
	[Address(RVA = "0x2385698", Offset = "0x2385698", VA = "0x2385698")]
	private void HAAACAIBDNN(DPEAILNNCMF AGGIFAEGEPA, uint BBAFHKCBFFN, uint KFBALILGIIG, uint BLEAICPKPGL, byte FMEOKLHEKNH, ushort FFCMCEABIAL, bool BBIDGILJCMB, uint MKFJPKBDLMM, byte ADKBIHDAKOD)
	{
	}

	[Token(Token = "0x6002463")]
	[Address(RVA = "0x2387790", Offset = "0x2387790", VA = "0x2387790")]
	private void CNNBMEHLAMA()
	{
	}

	[Token(Token = "0x6002464")]
	[Address(RVA = "0x23878C4", Offset = "0x23878C4", VA = "0x23878C4")]
	public uint GetDeadBoxCount()
	{
		return default(uint);
	}

	[Token(Token = "0x6002465")]
	[Address(RVA = "0x238639C", Offset = "0x238639C", VA = "0x238639C")]
	private void PPBCGEMBIAO(PMGCGPJEGOO CFMPMCBJBOB)
	{
	}

	[Token(Token = "0x6002466")]
	[Address(RVA = "0x23888AC", Offset = "0x23888AC", VA = "0x23888AC", Slot = "41")]
	protected override void HIDBEMAHGMB()
	{
	}

	[Token(Token = "0x6002467")]
	[Address(RVA = "0x2387D40", Offset = "0x2387D40", VA = "0x2387D40")]
	private void MOHBIJMONDB()
	{
	}

	[Token(Token = "0x6002468")]
	[Address(RVA = "0x2387238", Offset = "0x2387238", VA = "0x2387238")]
	private void NGFEICDCCNB()
	{
	}

	[Token(Token = "0x6002469")]
	[Address(RVA = "0x23895E8", Offset = "0x23895E8", VA = "0x23895E8", Slot = "34")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600246A")]
	[Address(RVA = "0x2387984", Offset = "0x2387984", VA = "0x2387984")]
	public bool IsAirdrop(byte PMGBACFJIHO)
	{
		return default(bool);
	}

	[Token(Token = "0x600246B")]
	[Address(RVA = "0x23879F4", Offset = "0x23879F4", VA = "0x23879F4")]
	private bool LJABAALKHOE(byte PMGBACFJIHO)
	{
		return default(bool);
	}

	[Token(Token = "0x600246C")]
	[Address(RVA = "0x23874C0", Offset = "0x23874C0", VA = "0x23874C0")]
	public bool IsDeadBox()
	{
		return default(bool);
	}

	[Token(Token = "0x600246D")]
	[Address(RVA = "0x23871C8", Offset = "0x23871C8", VA = "0x23871C8")]
	private bool DMKBALCICDM(byte PMGBACFJIHO)
	{
		return default(bool);
	}

	[Token(Token = "0x600246E")]
	[Address(RVA = "0x2387450", Offset = "0x2387450", VA = "0x2387450")]
	private bool AKNCIILOGCD(byte PMGBACFJIHO)
	{
		return default(bool);
	}

	[Token(Token = "0x600246F")]
	[Address(RVA = "0x23896F4", Offset = "0x23896F4", VA = "0x23896F4")]
	private static bool FMCHELPGHGH(byte PMGBACFJIHO)
	{
		return default(bool);
	}

	[Token(Token = "0x6002470")]
	[Address(RVA = "0x23892D8", Offset = "0x23892D8", VA = "0x23892D8")]
	private bool DDCKEAIEOKP(uint LLONJJJJLFL)
	{
		return default(bool);
	}

	[Token(Token = "0x6002471")]
	[Address(RVA = "0x238940C", Offset = "0x238940C", VA = "0x238940C")]
	private bool IMECBPBHJLD(uint LLONJJJJLFL, uint EECPJIFLNNM)
	{
		return default(bool);
	}

	[Token(Token = "0x6002472")]
	[Address(RVA = "0x23855D0", Offset = "0x23855D0", VA = "0x23855D0")]
	private bool CBGJLMPHFIH(byte FMEOKLHEKNH)
	{
		return default(bool);
	}

	[Token(Token = "0x6002473")]
	[Address(RVA = "0x238975C", Offset = "0x238975C", VA = "0x238975C")]
	private HFCNOEBDHEP GJGDBGFMJFM(uint BECFAIOFONM)
	{
		return null;
	}

	[Token(Token = "0x6002474")]
	[Address(RVA = "0x238A614", Offset = "0x238A614", VA = "0x238A614")]
	public void AddAsDeadBox()
	{
	}

	[Token(Token = "0x6002475")]
	[Address(RVA = "0x238AA04", Offset = "0x238AA04", VA = "0x238AA04")]
	public void RemoveBountyEffectAndMark(ResourceID OBMONKFFGGI)
	{
	}

	[Token(Token = "0x6002476")]
	[Address(RVA = "0x238AE78", Offset = "0x238AE78", VA = "0x238AE78")]
	public void AddBountyEffectAndMark(ResourceID OBMONKFFGGI)
	{
	}

	[Token(Token = "0x6002477")]
	[Address(RVA = "0x238752C", Offset = "0x238752C", VA = "0x238752C")]
	public void AddKillerEffect()
	{
	}

	[Token(Token = "0x6002478")]
	[Address(RVA = "0x238B528", Offset = "0x238B528", VA = "0x238B528")]
	public MNGBAPBBJDC GetRandomPickUp()
	{
		return null;
	}

	[Token(Token = "0x6002479")]
	[Address(RVA = "0x238B628", Offset = "0x238B628", VA = "0x238B628", Slot = "42")]
	protected override void HAAACAIBDNN(MNGBAPBBJDC OIKHKCIIDAD, uint BIFFAIEPIND = uint.MaxValue, bool BBIDGILJCMB = false, bool PGJOFAKGBJG = false)
	{
	}

	[Token(Token = "0x600247A")]
	[Address(RVA = "0x238CF78", Offset = "0x238CF78", VA = "0x238CF78", Slot = "43")]
	protected override void NDFEDODBDHC(MNGBAPBBJDC OIKHKCIIDAD)
	{
	}

	[Token(Token = "0x600247B")]
	[Address(RVA = "0x238CC90", Offset = "0x238CC90", VA = "0x238CC90")]
	private void GBGLHBOJMBO()
	{
	}

	[Token(Token = "0x600247C")]
	[Address(RVA = "0x238D7DC", Offset = "0x238D7DC", VA = "0x238D7DC")]
	public void PostContainerCreated()
	{
	}

	[Token(Token = "0x600247D")]
	[Address(RVA = "0x238D84C", Offset = "0x238D84C", VA = "0x238D84C")]
	private void AGNDBPKELPL()
	{
	}

	[Token(Token = "0x600247E")]
	[Address(RVA = "0x2388FE0", Offset = "0x2388FE0", VA = "0x2388FE0")]
	private void PLLAMIMIAKG()
	{
	}

	[Token(Token = "0x600247F")]
	[Address(RVA = "0x238DAB0", Offset = "0x238DAB0", VA = "0x238DAB0")]
	public void OnTriggerEnter(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x6002480")]
	[Address(RVA = "0x238DD20", Offset = "0x238DD20", VA = "0x238DD20")]
	public void OnTriggerExit(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x6002482")]
	[Address(RVA = "0x238E068", Offset = "0x238E068", VA = "0x238E068")]
	private bool MNKPHFNGHPF(LevelTreasure OPJKJHBKLGN)
	{
		return default(bool);
	}

	[Token(Token = "0x6002483")]
	[Address(RVA = "0x238E0AC", Offset = "0x238E0AC", VA = "0x238E0AC")]
	public new void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	[Token(Token = "0x6002484")]
	[Address(RVA = "0x238E10C", Offset = "0x238E10C", VA = "0x238E10C")]
	public new void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	[Token(Token = "0x6002485")]
	[Address(RVA = "0x238E16C", Offset = "0x238E16C", VA = "0x238E16C")]
	public void _003C_003EiFixBaseProxy_HIDBEMAHGMB()
	{
	}

	[Token(Token = "0x6002486")]
	[Address(RVA = "0x238E170", Offset = "0x238E170", VA = "0x238E170")]
	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	[Token(Token = "0x6002487")]
	[Address(RVA = "0x238E178", Offset = "0x238E178", VA = "0x238E178")]
	public void _003C_003EiFixBaseProxy_HAAACAIBDNN(MNGBAPBBJDC P0, uint P1, bool P2, bool P3)
	{
	}

	[Token(Token = "0x6002488")]
	[Address(RVA = "0x238E210", Offset = "0x238E210", VA = "0x238E210")]
	public void _003C_003EiFixBaseProxy_NDFEDODBDHC(MNGBAPBBJDC P0)
	{
	}
}
