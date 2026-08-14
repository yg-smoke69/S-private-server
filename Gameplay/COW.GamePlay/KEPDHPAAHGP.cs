using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.Gameplay.UGC;
using GCommon;
using Il2CppDummyDll;
using UMA.Simple;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000834")]
internal abstract class KEPDHPAAHGP : MatchGame, _Attribute
{
	[Token(Token = "0x2000835")]
	private sealed class NFBPAACJMOP : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005197")]
		[FieldOffset(Offset = "0x8")]
		internal GameModeSetting CLMGOKBLIBG;

		[Token(Token = "0x4005198")]
		[FieldOffset(Offset = "0xC")]
		internal List<int> PIOFMHCDOKG;

		[Token(Token = "0x4005199")]
		[FieldOffset(Offset = "0x10")]
		internal SlotOverlayCacheManager OMLCKACOFHE;

		[Token(Token = "0x400519A")]
		[FieldOffset(Offset = "0x14")]
		internal List<int>.Enumerator APEFBLFMFJC;

		[Token(Token = "0x400519B")]
		[FieldOffset(Offset = "0x24")]
		internal int INDLHNAMHHN;

		[Token(Token = "0x400519C")]
		[FieldOffset(Offset = "0x28")]
		internal KEPDHPAAHGP GADHAMJEKIM;

		[Token(Token = "0x400519D")]
		[FieldOffset(Offset = "0x2C")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x400519E")]
		[FieldOffset(Offset = "0x30")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x400519F")]
		[FieldOffset(Offset = "0x34")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170003E0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003584")]
			[Address(RVA = "0xE43CD4", Offset = "0xE43CD4", VA = "0xE43CD4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003E1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003585")]
			[Address(RVA = "0xE43CDC", Offset = "0xE43CDC", VA = "0xE43CDC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003582")]
		[Address(RVA = "0xE42278", Offset = "0xE42278", VA = "0xE42278")]
		public NFBPAACJMOP()
		{
		}

		[Token(Token = "0x6003583")]
		[Address(RVA = "0xE439E4", Offset = "0xE439E4", VA = "0xE439E4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003586")]
		[Address(RVA = "0xE43CE4", Offset = "0xE43CE4", VA = "0xE43CE4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003587")]
		[Address(RVA = "0xE43D64", Offset = "0xE43D64", VA = "0xE43D64", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005186")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<uint, string> NLEIIMHALBI;

	[Token(Token = "0x4005187")]
	[FieldOffset(Offset = "0x88")]
	protected long KOMMANDCOCL;

	[Token(Token = "0x4005188")]
	[FieldOffset(Offset = "0x4")]
	private static readonly Vector3 BNJLLPPHLNN;

	[Token(Token = "0x4005189")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Vector3 HCOCGDGJNAH;

	[Token(Token = "0x400518A")]
	[FieldOffset(Offset = "0x90")]
	private GameObject BEBDOKFNDAL;

	[Token(Token = "0x400518B")]
	[FieldOffset(Offset = "0x94")]
	private ITransformNode GCHLGFOALGF;

	[Token(Token = "0x400518C")]
	[FieldOffset(Offset = "0x98")]
	private Transform FLGDCNEGFGN;

	[Token(Token = "0x400518D")]
	[FieldOffset(Offset = "0x9C")]
	private float DOJHFHGDMGM;

	[Token(Token = "0x400518E")]
	[FieldOffset(Offset = "0xA0")]
	public uint KANIHMFFFCP;

	[Token(Token = "0x400518F")]
	[FieldOffset(Offset = "0xA8")]
	public ulong BAKELLKIMKC;

	[Token(Token = "0x4005190")]
	[FieldOffset(Offset = "0xB0")]
	private ulong MECNCHHFKJD;

	[Token(Token = "0x4005191")]
	[FieldOffset(Offset = "0xB8")]
	public uint HFPGENNDGME;

	[Token(Token = "0x4005192")]
	[FieldOffset(Offset = "0xBC")]
	public uint NIFOAOIAAOB;

	[Token(Token = "0x4005193")]
	[FieldOffset(Offset = "0xC0")]
	public float PJPDPDBILAG;

	[Token(Token = "0x4005194")]
	[FieldOffset(Offset = "0xC4")]
	private UGCRunnerManager IGANCGPKHJK;

	[Token(Token = "0x4005195")]
	[FieldOffset(Offset = "0xC8")]
	private byte[] AJKBOONEOAB;

	[Token(Token = "0x4005196")]
	[FieldOffset(Offset = "0xCC")]
	private readonly Dictionary<uint, List<byte>> FIDCJIEEOPC;

	[Token(Token = "0x170003DF")]
	public UGCRunnerManager AGEPBNKNOPA
	{
		[Token(Token = "0x6003546")]
		[Address(RVA = "0xE39B24", Offset = "0xE39B24", VA = "0xE39B24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003541")]
	[Address(RVA = "0xE39820", Offset = "0xE39820", VA = "0xE39820")]
	protected KEPDHPAAHGP()
	{
	}

	[Token(Token = "0x6003542")]
	[Address(RVA = "0xE398F8", Offset = "0xE398F8", VA = "0xE398F8", Slot = "45")]
	public override bool IsOnlineGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6003543")]
	[Address(RVA = "0xE39950", Offset = "0xE39950", VA = "0xE39950", Slot = "23")]
	public override LoadingProcess[] GetLoadingProcesses()
	{
		return null;
	}

	[Token(Token = "0x6003544")]
	[Address(RVA = "0xE399C8", Offset = "0xE399C8", VA = "0xE399C8")]
	public BPHBIPKGCGK JBNFJDBIEJG()
	{
		return null;
	}

	[Token(Token = "0x6003545")]
	[Address(RVA = "0xE39AAC", Offset = "0xE39AAC", VA = "0xE39AAC")]
	public MatchGameClient MLBMMFJAGFA()
	{
		return null;
	}

	[Token(Token = "0x6003547")]
	[Address(RVA = "0xE39B7C", Offset = "0xE39B7C", VA = "0xE39B7C", Slot = "24")]
	public override void OnLoadingFailed(int APNIAMMIPMI)
	{
	}

	[Token(Token = "0x6003548")]
	[Address(RVA = "0xE3A02C", Offset = "0xE3A02C", VA = "0xE3A02C", Slot = "25")]
	public override void OnLoadingSceneFailed()
	{
	}

	[Token(Token = "0x6003549")]
	[Address(RVA = "0xE3A49C", Offset = "0xE3A49C", VA = "0xE3A49C")]
	private void NOPBFKCMECC()
	{
	}

	[Token(Token = "0x600354A")]
	[Address(RVA = "0xE3A980", Offset = "0xE3A980", VA = "0xE3A980", Slot = "8")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x600354B")]
	[Address(RVA = "0xE3AAEC", Offset = "0xE3AAEC", VA = "0xE3AAEC", Slot = "9")]
	protected override void OnSceneLoaded()
	{
	}

	[Token(Token = "0x600354C")]
	[Address(RVA = "0xE3BEB8", Offset = "0xE3BEB8", VA = "0xE3BEB8", Slot = "6")]
	public override bool NeedPreloadBeforeLoadScene()
	{
		return default(bool);
	}

	[Token(Token = "0x600354D")]
	[Address(RVA = "0xE3BF10", Offset = "0xE3BF10", VA = "0xE3BF10", Slot = "10")]
	protected override void OnPreloadLoaded()
	{
	}

	[Token(Token = "0x600354E")]
	[Address(RVA = "0xE3C05C", Offset = "0xE3C05C", VA = "0xE3C05C", Slot = "4")]
	public override uint GetPreloadCountPerFrame()
	{
		return default(uint);
	}

	[Token(Token = "0x600354F")]
	[Address(RVA = "0xE3C134", Offset = "0xE3C134", VA = "0xE3C134", Slot = "60")]
	public void OnPingSent(int LPALADOKGGK)
	{
	}

	[Token(Token = "0x6003550")]
	[Address(RVA = "0xE3C234", Offset = "0xE3C234", VA = "0xE3C234", Slot = "58")]
	public void OnConnected(bool AAIFFDPLMJP)
	{
	}

	[Token(Token = "0x6003551")]
	[Address(RVA = "0xE3C594", Offset = "0xE3C594", VA = "0xE3C594", Slot = "59")]
	public void OnDisconnected(DisconnectedReason OMNGGLFFMGM)
	{
	}

	[Token(Token = "0x6003552")]
	[Address(RVA = "0xE3CE60", Offset = "0xE3CE60", VA = "0xE3CE60")]
	private void PCIJJECCOEN(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6003553")]
	[Address(RVA = "0xE3FC34", Offset = "0xE3FC34", VA = "0xE3FC34")]
	private void JPAEDGPGMEA(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6003554")]
	[Address(RVA = "0xE3FCB0", Offset = "0xE3FCB0", VA = "0xE3FCB0")]
	private void EKOBGAJCMLG(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6003555")]
	[Address(RVA = "0xE3FD94", Offset = "0xE3FD94", VA = "0xE3FD94")]
	private void GKKLGMDHIEI(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6003556")]
	[Address(RVA = "0xE3FE10", Offset = "0xE3FE10", VA = "0xE3FE10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6003557")]
	[Address(RVA = "0xE40E3C", Offset = "0xE40E3C", VA = "0xE40E3C", Slot = "15")]
	protected override void OnFixedUpdate()
	{
	}

	[Token(Token = "0x6003558")]
	[Address(RVA = "0xE40F38", Offset = "0xE40F38", VA = "0xE40F38", Slot = "16")]
	protected override void OnNetworkFixedUpdate()
	{
	}

	[Token(Token = "0x6003559")]
	[Address(RVA = "0xE40FB0", Offset = "0xE40FB0", VA = "0xE40FB0", Slot = "12")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600355A")]
	[Address(RVA = "0xE41184", Offset = "0xE41184", VA = "0xE41184", Slot = "26")]
	public override int GetGameType()
	{
		return default(int);
	}

	[Token(Token = "0x600355B")]
	[Address(RVA = "0xE411DC", Offset = "0xE411DC", VA = "0xE411DC")]
	public void AJLHEAOCGOO(OOCHMIOHPNK KMIPBIGPDPI)
	{
	}

	[Token(Token = "0x600355C")]
	[Address(RVA = "0xE41560", Offset = "0xE41560", VA = "0xE41560")]
	public void KPDKKHAINBH(uint JDDKBHGGJKM)
	{
	}

	[Token(Token = "0x600355D")]
	[Address(RVA = "0xE415F0", Offset = "0xE415F0", VA = "0xE415F0")]
	public float OLAPLOIAMKM()
	{
		return default(float);
	}

	[Token(Token = "0x600355E")]
	[Address(RVA = "0xE416D8", Offset = "0xE416D8", VA = "0xE416D8")]
	public uint JMFEHLANENP()
	{
		return default(uint);
	}

	[Token(Token = "0x600355F")]
	[Address(RVA = "0xE4176C", Offset = "0xE4176C", VA = "0xE4176C")]
	protected ResourceID[] OCJCLDCHJPP()
	{
		return null;
	}

	[Token(Token = "0x6003560")]
	[Address(RVA = "0xE41918", Offset = "0xE41918", VA = "0xE41918", Slot = "21")]
	public override ResourceID[] GetAudioPreloadResourceID()
	{
		return null;
	}

	[Token(Token = "0x6003561")]
	[Address(RVA = "0xE41B7C", Offset = "0xE41B7C", VA = "0xE41B7C")]
	private void KAMAIOEKBEB(List<int> KMIPBIGPDPI, ref List<int> NLGILOONJCL)
	{
	}

	[Token(Token = "0x6003562")]
	[Address(RVA = "0xE41DA4", Offset = "0xE41DA4", VA = "0xE41DA4")]
	public List<int> EIAGLKMKODI()
	{
		return null;
	}

	[Token(Token = "0x6003563")]
	[Address(RVA = "0xE421AC", Offset = "0xE421AC", VA = "0xE421AC", Slot = "22")]
	public override IEnumerator PreloadUmas()
	{
		return null;
	}

	[Token(Token = "0x6003564")]
	[Address(RVA = "0xE42280", Offset = "0xE42280", VA = "0xE42280", Slot = "61")]
	protected virtual DBGNDLHOIEJ EMCEIOKJAKG()
	{
		return null;
	}

	[Token(Token = "0x6003565")]
	[Address(RVA = "0xE3B62C", Offset = "0xE3B62C", VA = "0xE3B62C")]
	protected void OPHGLJHDKKH()
	{
	}

	[Token(Token = "0x6003566")]
	[Address(RVA = "0xE422D8", Offset = "0xE422D8", VA = "0xE422D8", Slot = "35")]
	public override void PauseGame(bool JOGHOHLEJFL)
	{
	}

	[Token(Token = "0x6003567")]
	[Address(RVA = "0xE42758", Offset = "0xE42758", VA = "0xE42758", Slot = "36")]
	public override bool IsGamePaused()
	{
		return default(bool);
	}

	[Token(Token = "0x6003568")]
	[Address(RVA = "0xE427B0", Offset = "0xE427B0", VA = "0xE427B0", Slot = "62")]
	public virtual bool DIJBOFLPDGO()
	{
		return default(bool);
	}

	[Token(Token = "0x6003569")]
	[Address(RVA = "0xE42808", Offset = "0xE42808", VA = "0xE42808", Slot = "63")]
	public virtual bool BMCJEDLPHOI()
	{
		return default(bool);
	}

	[Token(Token = "0x600356A")]
	[Address(RVA = "0xE42860", Offset = "0xE42860", VA = "0xE42860")]
	public bool CFGHGJBANEE(ulong HHMJNLLBELP)
	{
		return default(bool);
	}

	[Token(Token = "0x600356B")]
	[Address(RVA = "0xE42A50", Offset = "0xE42A50", VA = "0xE42A50", Slot = "53")]
	public override Player CreatePlayer(Transform GOLANILPAJP, ulong HHMJNLLBELP, ulong OJHGCEHMNNI, IHAAMHPPLMG BIFFAIEPIND, bool JNLEJHIJFOP = false, [Optional] object JKBNDADENMG)
	{
		return null;
	}

	[Token(Token = "0x600356C")]
	[Address(RVA = "0xE42C40", Offset = "0xE42C40", VA = "0xE42C40", Slot = "64")]
	public virtual void BNNFHBGPFOF(LGIGCGIDOKP MPMFIDBNMMH)
	{
	}

	[Token(Token = "0x600356D")]
	[Address(RVA = "0xE42E74", Offset = "0xE42E74", VA = "0xE42E74")]
	public void NOLABDEHKJL(uint AMJAOAALHGB, uint HHLONFLCJBL, List<byte> GOMPGCOBDDD)
	{
	}

	[Token(Token = "0x600356F")]
	[Address(RVA = "0xE438EC", Offset = "0xE438EC", VA = "0xE438EC")]
	public new void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}

	[Token(Token = "0x6003570")]
	[Address(RVA = "0xE438F4", Offset = "0xE438F4", VA = "0xE438F4")]
	public new void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x6003571")]
	[Address(RVA = "0xE438FC", Offset = "0xE438FC", VA = "0xE438FC")]
	public void _003C_003EiFixBaseProxy_OnUpdate()
	{
	}

	[Token(Token = "0x6003572")]
	[Address(RVA = "0xE43904", Offset = "0xE43904", VA = "0xE43904")]
	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x6003573")]
	[Address(RVA = "0xE4390C", Offset = "0xE4390C", VA = "0xE4390C")]
	public void _003C_003EiFixBaseProxy_OnPreloadLoaded()
	{
	}

	[Token(Token = "0x6003574")]
	[Address(RVA = "0xE43914", Offset = "0xE43914", VA = "0xE43914")]
	public bool _003C_003EiFixBaseProxy_IsOnlineGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6003575")]
	[Address(RVA = "0xE4391C", Offset = "0xE4391C", VA = "0xE4391C")]
	public LoadingProcess[] _003C_003EiFixBaseProxy_GetLoadingProcesses()
	{
		return null;
	}

	[Token(Token = "0x6003576")]
	[Address(RVA = "0xE43924", Offset = "0xE43924", VA = "0xE43924")]
	public void _003C_003EiFixBaseProxy_OnLoadingFailed(int P0)
	{
	}

	[Token(Token = "0x6003577")]
	[Address(RVA = "0xE4392C", Offset = "0xE4392C", VA = "0xE4392C")]
	public void _003C_003EiFixBaseProxy_OnLoadingSceneFailed()
	{
	}

	[Token(Token = "0x6003578")]
	[Address(RVA = "0xE43934", Offset = "0xE43934", VA = "0xE43934")]
	public bool _003C_003EiFixBaseProxy_NeedPreloadBeforeLoadScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6003579")]
	[Address(RVA = "0xE4393C", Offset = "0xE4393C", VA = "0xE4393C")]
	public uint _003C_003EiFixBaseProxy_GetPreloadCountPerFrame()
	{
		return default(uint);
	}

	[Token(Token = "0x600357A")]
	[Address(RVA = "0xE43944", Offset = "0xE43944", VA = "0xE43944")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate()
	{
	}

	[Token(Token = "0x600357B")]
	[Address(RVA = "0xE4394C", Offset = "0xE4394C", VA = "0xE4394C")]
	public void _003C_003EiFixBaseProxy_OnNetworkFixedUpdate()
	{
	}

	[Token(Token = "0x600357C")]
	[Address(RVA = "0xE43954", Offset = "0xE43954", VA = "0xE43954")]
	public int _003C_003EiFixBaseProxy_GetGameType()
	{
		return default(int);
	}

	[Token(Token = "0x600357D")]
	[Address(RVA = "0xE4395C", Offset = "0xE4395C", VA = "0xE4395C")]
	public ResourceID[] _003C_003EiFixBaseProxy_GetAudioPreloadResourceID()
	{
		return null;
	}

	[Token(Token = "0x600357E")]
	[Address(RVA = "0xE43964", Offset = "0xE43964", VA = "0xE43964")]
	public IEnumerator _003C_003EiFixBaseProxy_PreloadUmas()
	{
		return null;
	}

	[Token(Token = "0x600357F")]
	[Address(RVA = "0xE4396C", Offset = "0xE4396C", VA = "0xE4396C")]
	public void _003C_003EiFixBaseProxy_PauseGame(bool P0)
	{
	}

	[Token(Token = "0x6003580")]
	[Address(RVA = "0xE43974", Offset = "0xE43974", VA = "0xE43974")]
	public bool _003C_003EiFixBaseProxy_IsGamePaused()
	{
		return default(bool);
	}

	[Token(Token = "0x6003581")]
	[Address(RVA = "0xE4397C", Offset = "0xE4397C", VA = "0xE4397C")]
	public Player _003C_003EiFixBaseProxy_CreatePlayer(Transform P0, ulong P1, ulong P2, IHAAMHPPLMG P3, bool P4, object P5)
	{
		return null;
	}
}
