using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000B33")]
internal class HLOONAALFOE : BBFLFMOCHPK
{
	[Token(Token = "0x2000B34")]
	public enum PMIAFNGJGHA
	{
		[Token(Token = "0x400606F")]
		CUTSCENE_1_Open,
		[Token(Token = "0x4006070")]
		CUTSCENE_1_C01_C02,
		[Token(Token = "0x4006071")]
		CUTSCENE_1_C03_C05,
		[Token(Token = "0x4006072")]
		CUTSCENE_1_C06,
		[Token(Token = "0x4006073")]
		CUTSCENE_1_C07_C010_QTE,
		[Token(Token = "0x4006074")]
		DEFEND_FIGHT_UAV,
		[Token(Token = "0x4006075")]
		CUTSCENE_2_C01_C03,
		[Token(Token = "0x4006076")]
		CUTSCENE_2_C04,
		[Token(Token = "0x4006077")]
		CUTSCENE_2_C05,
		[Token(Token = "0x4006078")]
		CUTSCENE_2_SP,
		[Token(Token = "0x4006079")]
		CUTSCENE_3_C01,
		[Token(Token = "0x400607A")]
		CUTSCENE_3_C02,
		[Token(Token = "0x400607B")]
		CUTSCENE_3_C03,
		[Token(Token = "0x400607C")]
		CUTSCENE_3_C04_LOOP_LOADSCENE,
		[Token(Token = "0x400607D")]
		CUTSCENE_3_C04_C06,
		[Token(Token = "0x400607E")]
		BOSS_FIGHT_PHASE,
		[Token(Token = "0x400607F")]
		CUTSCENE_3_C07_4_C02,
		[Token(Token = "0x4006080")]
		CUTSCENE_4_C04,
		[Token(Token = "0x4006081")]
		FREE_MOVE_PHASE
	}

	[Token(Token = "0x2000B35")]
	private sealed class EJDPMALOPIB
	{
		[Token(Token = "0x4006082")]
		[FieldOffset(Offset = "0x8")]
		internal Player JGAKJHAPHOA;

		[Token(Token = "0x6005619")]
		[Address(RVA = "0x112A2EC", Offset = "0x112A2EC", VA = "0x112A2EC")]
		public EJDPMALOPIB()
		{
		}

		[Token(Token = "0x600561A")]
		[Address(RVA = "0x112B600", Offset = "0x112B600", VA = "0x112B600")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x2000B36")]
	private sealed class DJPBBHFDJCB
	{
		[Token(Token = "0x4006083")]
		[FieldOffset(Offset = "0x8")]
		internal GameObject OBFOHOGCKLK;

		[Token(Token = "0x600561B")]
		[Address(RVA = "0x112B254", Offset = "0x112B254", VA = "0x112B254")]
		public DJPBBHFDJCB()
		{
		}

		[Token(Token = "0x600561C")]
		[Address(RVA = "0x112B530", Offset = "0x112B530", VA = "0x112B530")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x4006058")]
	[FieldOffset(Offset = "0x88")]
	private SwitchSceneManager IMLIMDIDFEC;

	[Token(Token = "0x4006059")]
	[FieldOffset(Offset = "0x8C")]
	private Transform LAMHPFMLAPE;

	[Token(Token = "0x400605A")]
	[FieldOffset(Offset = "0x90")]
	private BountyWaitingBoss AGPMIEPAGIJ;

	[Token(Token = "0x400605B")]
	[FieldOffset(Offset = "0x94")]
	private UAVManager IGGIANGDDMC;

	[Token(Token = "0x400605C")]
	[FieldOffset(Offset = "0x98")]
	private ResourceID[] GCMFPOCLIOL;

	[Token(Token = "0x400605D")]
	[FieldOffset(Offset = "0x9C")]
	private int COJNADEEKBL;

	[Token(Token = "0x400605E")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<int, DOENNBCOLCG> JEICPIBKDFO;

	[Token(Token = "0x400605F")]
	[FieldOffset(Offset = "0xA4")]
	private DOENNBCOLCG CPDJDNFHGMH;

	[Token(Token = "0x4006060")]
	[FieldOffset(Offset = "0xA8")]
	private bool IJBOFGHEIEJ;

	[Token(Token = "0x4006061")]
	[FieldOffset(Offset = "0xA9")]
	public bool GNPOKOKLFHI;

	[Token(Token = "0x4006062")]
	[FieldOffset(Offset = "0xAC")]
	private BountyWaitingCutsceneManager LPAKHOBOJDL;

	[Token(Token = "0x4006063")]
	[FieldOffset(Offset = "0xB0")]
	private Transform GNIIODOENFA;

	[Token(Token = "0x4006064")]
	[FieldOffset(Offset = "0xB4")]
	private BountySwitchSceneSubtitleController KNJHAJNCLAJ;

	[Token(Token = "0x4006065")]
	[FieldOffset(Offset = "0xB8")]
	private bool HJGLLNHEHIP;

	[Token(Token = "0x4006066")]
	[FieldOffset(Offset = "0xBC")]
	public List<uint> OAANJHMNLGN;

	[Token(Token = "0x4006067")]
	[FieldOffset(Offset = "0xC0")]
	private Dictionary<int, int> JGDDOOJBFDD;

	[Token(Token = "0x4006068")]
	[FieldOffset(Offset = "0xC4")]
	private PMIAFNGJGHA FLOCHFLAPNO;

	[Token(Token = "0x4006069")]
	[FieldOffset(Offset = "0xC8")]
	private float NAPCCECKIHC;

	[Token(Token = "0x400606A")]
	[FieldOffset(Offset = "0xCC")]
	private float HGOLPKCEBNJ;

	[Token(Token = "0x400606B")]
	[FieldOffset(Offset = "0xD0")]
	private bool EHOBOIHJGPN;

	[Token(Token = "0x400606C")]
	[FieldOffset(Offset = "0xD1")]
	private bool LFAAHBNEBDE;

	[Token(Token = "0x400606D")]
	[FieldOffset(Offset = "0x0")]
	private static Action HMDOHFBHDOB;

	[Token(Token = "0x170006EB")]
	public BountyWaitingBoss EGFHBFLKFKI
	{
		[Token(Token = "0x60055E3")]
		[Address(RVA = "0x1126570", Offset = "0x1126570", VA = "0x1126570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006EC")]
	public UAVManager AACLLNIEPEO
	{
		[Token(Token = "0x60055E4")]
		[Address(RVA = "0x11265C8", Offset = "0x11265C8", VA = "0x11265C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60055E2")]
	[Address(RVA = "0x11260D0", Offset = "0x11260D0", VA = "0x11260D0")]
	public HLOONAALFOE()
	{
	}

	[Token(Token = "0x60055E5")]
	[Address(RVA = "0x1126620", Offset = "0x1126620", VA = "0x1126620", Slot = "6")]
	public override bool NeedPreloadBeforeLoadScene()
	{
		return default(bool);
	}

	[Token(Token = "0x60055E6")]
	[Address(RVA = "0x1126678", Offset = "0x1126678", VA = "0x1126678", Slot = "53")]
	public override Player CreatePlayer(Transform GOLANILPAJP, ulong HHMJNLLBELP, ulong OJHGCEHMNNI, IHAAMHPPLMG BIFFAIEPIND, bool JNLEJHIJFOP = false, [Optional] object JKBNDADENMG)
	{
		return null;
	}

	[Token(Token = "0x60055E7")]
	[Address(RVA = "0x1126820", Offset = "0x1126820", VA = "0x1126820")]
	public void OINKCBLMBAP(BountySwitchSceneSubtitleController JCDPFNLBFCO)
	{
	}

	[Token(Token = "0x60055E8")]
	[Address(RVA = "0x1126880", Offset = "0x1126880", VA = "0x1126880")]
	public void POIBFBLFKKA(Transform JBKIMCBCCMF)
	{
	}

	[Token(Token = "0x60055E9")]
	[Address(RVA = "0x11268E0", Offset = "0x11268E0", VA = "0x11268E0")]
	public void FDDKDJHLMAD(SwitchSceneManager NCOOAGHMNMB)
	{
	}

	[Token(Token = "0x60055EA")]
	[Address(RVA = "0x1126BA0", Offset = "0x1126BA0", VA = "0x1126BA0")]
	public void ADOPAIHBNAP(PlayerBountyWaitingSpawnRegion CHPDPHLCMHG)
	{
	}

	[Token(Token = "0x60055EB")]
	[Address(RVA = "0x1126D4C", Offset = "0x1126D4C", VA = "0x1126D4C")]
	public void DOEFPPALNEM(UAVManager KLBEINJNIMA)
	{
	}

	[Token(Token = "0x60055EC")]
	[Address(RVA = "0x1126DF0", Offset = "0x1126DF0", VA = "0x1126DF0")]
	public void JNDMPPMLIMF(BountyWaitingBoss NEEMNIPKGCE)
	{
	}

	[Token(Token = "0x60055ED")]
	[Address(RVA = "0x11270D0", Offset = "0x11270D0", VA = "0x11270D0")]
	public void FHOELBPGLHH(Transform ELCNGAIGNDH)
	{
	}

	[Token(Token = "0x60055EE")]
	[Address(RVA = "0x1127130", Offset = "0x1127130", VA = "0x1127130")]
	public bool COELKKNKOCN()
	{
		return default(bool);
	}

	[Token(Token = "0x60055EF")]
	[Address(RVA = "0x1126A80", Offset = "0x1126A80", VA = "0x1126A80")]
	public bool JOIMECKMKIE()
	{
		return default(bool);
	}

	[Token(Token = "0x60055F0")]
	[Address(RVA = "0x1127208", Offset = "0x1127208", VA = "0x1127208", Slot = "9")]
	protected override void OnSceneLoaded()
	{
	}

	[Token(Token = "0x60055F1")]
	[Address(RVA = "0x1127274", Offset = "0x1127274", VA = "0x1127274")]
	private void GHPCMENKFJH()
	{
	}

	[Token(Token = "0x60055F2")]
	[Address(RVA = "0x112756C", Offset = "0x112756C", VA = "0x112756C")]
	private void EKMFFPJCGGE()
	{
	}

	[Token(Token = "0x60055F3")]
	[Address(RVA = "0x1127B54", Offset = "0x1127B54", VA = "0x1127B54")]
	private void LEBOKMDHONF()
	{
	}

	[Token(Token = "0x60055F4")]
	[Address(RVA = "0x1127EA8", Offset = "0x1127EA8", VA = "0x1127EA8")]
	private void IIMMMDJMBEK()
	{
	}

	[Token(Token = "0x60055F5")]
	[Address(RVA = "0x1128060", Offset = "0x1128060", VA = "0x1128060")]
	private void DEPJPFJCFJN()
	{
	}

	[Token(Token = "0x60055F6")]
	[Address(RVA = "0x1128284", Offset = "0x1128284", VA = "0x1128284")]
	private void IGPBJAFKHIE()
	{
	}

	[Token(Token = "0x60055F7")]
	[Address(RVA = "0x1128598", Offset = "0x1128598", VA = "0x1128598")]
	private void IGCPEEEMAMD()
	{
	}

	[Token(Token = "0x60055F8")]
	[Address(RVA = "0x112845C", Offset = "0x112845C", VA = "0x112845C")]
	private void MCBIBHMHEPN()
	{
	}

	[Token(Token = "0x60055F9")]
	[Address(RVA = "0x1128608", Offset = "0x1128608", VA = "0x1128608")]
	public void GINFBOJGNOG()
	{
	}

	[Token(Token = "0x60055FA")]
	[Address(RVA = "0x112772C", Offset = "0x112772C", VA = "0x112772C")]
	private void CDMDMJFODEJ()
	{
	}

	[Token(Token = "0x60055FB")]
	[Address(RVA = "0x1128898", Offset = "0x1128898", VA = "0x1128898")]
	public void BCHEDGJOFGP()
	{
	}

	[Token(Token = "0x60055FC")]
	[Address(RVA = "0x11276D4", Offset = "0x11276D4", VA = "0x11276D4")]
	private int FOJKAIBLPJF()
	{
		return default(int);
	}

	[Token(Token = "0x60055FD")]
	[Address(RVA = "0x11278CC", Offset = "0x11278CC", VA = "0x11278CC")]
	public void ELIIAFPACNG(bool MBGDFFNBAAI = false)
	{
	}

	[Token(Token = "0x60055FE")]
	[Address(RVA = "0x1128A50", Offset = "0x1128A50", VA = "0x1128A50", Slot = "59")]
	public override Dictionary<uint, uint> FKLMEHBFDOP()
	{
		return null;
	}

	[Token(Token = "0x60055FF")]
	[Address(RVA = "0x1128C54", Offset = "0x1128C54", VA = "0x1128C54")]
	private void EDAEOHBFHPF(bool OGAFCJBHMFK)
	{
	}

	[Token(Token = "0x6005600")]
	[Address(RVA = "0x1128D9C", Offset = "0x1128D9C", VA = "0x1128D9C")]
	private void FBNKLMEEJMC(bool OGAFCJBHMFK)
	{
	}

	[Token(Token = "0x6005601")]
	[Address(RVA = "0x1128EE4", Offset = "0x1128EE4", VA = "0x1128EE4")]
	private void BFPPLHCLFFC()
	{
	}

	[Token(Token = "0x6005602")]
	[Address(RVA = "0x1129004", Offset = "0x1129004", VA = "0x1129004")]
	public void IBCHIINOJJF(ResourceID DDDJHDHBFJB)
	{
	}

	[Token(Token = "0x6005603")]
	[Address(RVA = "0x1127BBC", Offset = "0x1127BBC", VA = "0x1127BBC")]
	private void ILFBBKNNECF()
	{
	}

	[Token(Token = "0x6005604")]
	[Address(RVA = "0x1129890", Offset = "0x1129890", VA = "0x1129890")]
	private void EEEIKIFLNCE()
	{
	}

	[Token(Token = "0x6005605")]
	[Address(RVA = "0x1129124", Offset = "0x1129124", VA = "0x1129124")]
	private void PIPENGEBHPB()
	{
	}

	[Token(Token = "0x6005606")]
	[Address(RVA = "0x1129EA8", Offset = "0x1129EA8", VA = "0x1129EA8")]
	private void MMEINJJMAAM()
	{
	}

	[Token(Token = "0x6005607")]
	[Address(RVA = "0x1129BF4", Offset = "0x1129BF4", VA = "0x1129BF4")]
	private void GKCOCEKBFEE()
	{
	}

	[Token(Token = "0x6005608")]
	[Address(RVA = "0x112926C", Offset = "0x112926C", VA = "0x112926C")]
	private void HMGCNOEIFEH()
	{
	}

	[Token(Token = "0x6005609")]
	[Address(RVA = "0x1129CF0", Offset = "0x1129CF0", VA = "0x1129CF0")]
	private void ALADLEDNLFH()
	{
	}

	[Token(Token = "0x600560A")]
	[Address(RVA = "0x11293EC", Offset = "0x11293EC", VA = "0x11293EC")]
	private void LECFCOLDOPM()
	{
	}

	[Token(Token = "0x600560B")]
	[Address(RVA = "0x112A2F4", Offset = "0x112A2F4", VA = "0x112A2F4")]
	private void HCEGIINDPEJ()
	{
	}

	[Token(Token = "0x600560C")]
	[Address(RVA = "0x11280F4", Offset = "0x11280F4", VA = "0x11280F4")]
	public void GDLEBPOMDNK(int HMLFBAFCBHB = 0, bool OPFGKAEKDAI = false)
	{
	}

	[Token(Token = "0x600560D")]
	[Address(RVA = "0x112A57C", Offset = "0x112A57C", VA = "0x112A57C")]
	public void MNKDAOKGDOB()
	{
	}

	[Token(Token = "0x600560E")]
	[Address(RVA = "0x112A5EC", Offset = "0x112A5EC", VA = "0x112A5EC", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600560F")]
	[Address(RVA = "0x112A824", Offset = "0x112A824", VA = "0x112A824")]
	public void IIJPFDKFDGK()
	{
	}

	[Token(Token = "0x6005610")]
	[Address(RVA = "0x112B25C", Offset = "0x112B25C", VA = "0x112B25C")]
	public void HLADIKELPML()
	{
	}

	[Token(Token = "0x6005611")]
	[Address(RVA = "0x112B2C0", Offset = "0x112B2C0", VA = "0x112B2C0")]
	public void MNPNHLPAAMO()
	{
	}

	[Token(Token = "0x6005612")]
	[Address(RVA = "0x112B3F8", Offset = "0x112B3F8", VA = "0x112B3F8")]
	private void FLEFIDDECJE()
	{
	}

	[Token(Token = "0x6005613")]
	[Address(RVA = "0x112B404", Offset = "0x112B404", VA = "0x112B404")]
	private static void KHNCNMAJFAF()
	{
	}

	[Token(Token = "0x6005614")]
	[Address(RVA = "0x112B4A8", Offset = "0x112B4A8", VA = "0x112B4A8")]
	public bool _003C_003EiFixBaseProxy_NeedPreloadBeforeLoadScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6005615")]
	[Address(RVA = "0x112B4B0", Offset = "0x112B4B0", VA = "0x112B4B0")]
	public Player _003C_003EiFixBaseProxy_CreatePlayer(Transform P0, ulong P1, ulong P2, IHAAMHPPLMG P3, bool P4, object P5)
	{
		return null;
	}

	[Token(Token = "0x6005616")]
	[Address(RVA = "0x112B518", Offset = "0x112B518", VA = "0x112B518")]
	public new void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}

	[Token(Token = "0x6005617")]
	[Address(RVA = "0x112B520", Offset = "0x112B520", VA = "0x112B520")]
	public Dictionary<uint, uint> _003C_003EiFixBaseProxy_FKLMEHBFDOP()
	{
		return null;
	}

	[Token(Token = "0x6005618")]
	[Address(RVA = "0x112B528", Offset = "0x112B528", VA = "0x112B528")]
	public new void _003C_003EiFixBaseProxy_OnUpdate()
	{
	}
}
