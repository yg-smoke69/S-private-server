using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UMA;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000403")]
internal class AvatarManager : MonoBehaviour
{
	[Token(Token = "0x2000404")]
	public delegate void LIAOHMGEDGI();

	[Token(Token = "0x2000405")]
	public class FJIGOOPIJJD
	{
		[Token(Token = "0x4003AA6")]
		[FieldOffset(Offset = "0x8")]
		public uint NIDNCDNNGME;

		[Token(Token = "0x4003AA7")]
		[FieldOffset(Offset = "0xC")]
		public uint FJNBPPGHKEO;

		[Token(Token = "0x4003AA8")]
		[FieldOffset(Offset = "0x10")]
		public List<uint> COPDEIABDCP;

		[Token(Token = "0x4003AA9")]
		[FieldOffset(Offset = "0x14")]
		public List<uint> MCPGFPHMOGM;

		[Token(Token = "0x60013A3")]
		[Address(RVA = "0x15F9B78", Offset = "0x15F9B78", VA = "0x15F9B78")]
		public FJIGOOPIJJD()
		{
		}

		[SpecialName]
		[Token(Token = "0x60013A4")]
		[Address(RVA = "0x15F9B80", Offset = "0x15F9B80", VA = "0x15F9B80")]
		public static FJIGOOPIJJD CFFPIACECIG(PKPAMKEDCDC DBJHAGKNALD)
		{
			return null;
		}
	}

	[Token(Token = "0x2000406")]
	public enum DENCPDNONDO
	{
		[Token(Token = "0x4003AAB")]
		None = -1,
		[Token(Token = "0x4003AAC")]
		BackMount,
		[Token(Token = "0x4003AAD")]
		Eyes,
		[Token(Token = "0x4003AAE")]
		Head,
		[Token(Token = "0x4003AAF")]
		Feet,
		[Token(Token = "0x4003AB0")]
		Hands,
		[Token(Token = "0x4003AB1")]
		InnerMouth,
		[Token(Token = "0x4003AB2")]
		Legs,
		[Token(Token = "0x4003AB3")]
		Torso,
		[Token(Token = "0x4003AB4")]
		BackMountLeft,
		[Token(Token = "0x4003AB5")]
		BackMountRight,
		[Token(Token = "0x4003AB6")]
		BagPack,
		[Token(Token = "0x4003AB7")]
		Vest,
		[Token(Token = "0x4003AB8")]
		Helmet,
		[Token(Token = "0x4003AB9")]
		Legpack,
		[Token(Token = "0x4003ABA")]
		ParachuteBag,
		[Token(Token = "0x4003ABB")]
		BackMountBottom,
		[Token(Token = "0x4003ABC")]
		BackMountRightLeg,
		[Token(Token = "0x4003ABD")]
		Hair,
		[Token(Token = "0x4003ABE")]
		MAX
	}

	[Token(Token = "0x2000407")]
	private class KNLGCPICKLO
	{
		[Token(Token = "0x4003ABF")]
		[FieldOffset(Offset = "0x8")]
		public GameObject LNBPKIHNFHB;

		[Token(Token = "0x4003AC0")]
		[FieldOffset(Offset = "0xC")]
		public BitArrayBoolean FKHMOFHBOCC;

		[Token(Token = "0x4003AC1")]
		[FieldOffset(Offset = "0x10")]
		public uint AGJBGKNLLHG;

		[Token(Token = "0x4003AC2")]
		[FieldOffset(Offset = "0x14")]
		public uint LBLGIPCNPGP;

		[Token(Token = "0x4003AC3")]
		[FieldOffset(Offset = "0x18")]
		public Object LNADJGNMEOM;

		[Token(Token = "0x4003AC4")]
		[FieldOffset(Offset = "0x1C")]
		public Object CDGKCIJDAIH;

		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x15F9ED4", Offset = "0x15F9ED4", VA = "0x15F9ED4")]
		public KNLGCPICKLO()
		{
		}

		[Token(Token = "0x60013A6")]
		[Address(RVA = "0x15F9EDC", Offset = "0x15F9EDC", VA = "0x15F9EDC")]
		public void AICGLCLDADN()
		{
		}
	}

	[Token(Token = "0x2000408")]
	private sealed class JLKHICJDMHC : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4003AC5")]
		[FieldOffset(Offset = "0x8")]
		internal AvatarManager GADHAMJEKIM;

		[Token(Token = "0x4003AC6")]
		[FieldOffset(Offset = "0xC")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x4003AC7")]
		[FieldOffset(Offset = "0x10")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x4003AC8")]
		[FieldOffset(Offset = "0x14")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170001B9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60013A9")]
			[Address(RVA = "0x15F9E28", Offset = "0x15F9E28", VA = "0x15F9E28", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60013AA")]
			[Address(RVA = "0x15F9E30", Offset = "0x15F9E30", VA = "0x15F9E30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x15F9D8C", Offset = "0x15F9D8C", VA = "0x15F9D8C")]
		public JLKHICJDMHC()
		{
		}

		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x15F9D94", Offset = "0x15F9D94", VA = "0x15F9D94", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x15F9E38", Offset = "0x15F9E38", VA = "0x15F9E38", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x15F9E4C", Offset = "0x15F9E4C", VA = "0x15F9E4C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4003A51")]
	[FieldOffset(Offset = "0xC")]
	public SharedColorTable SkinColor;

	[Token(Token = "0x4003A52")]
	[FieldOffset(Offset = "0x10")]
	private OverlayColorData KIBDLAKHDCA;

	[Token(Token = "0x4003A53")]
	[FieldOffset(Offset = "0x14")]
	private OverlayColorData MPBBEPEGLCM;

	[Token(Token = "0x4003A54")]
	public const uint ISVISIBLE_PLAYER = 1u;

	[Token(Token = "0x4003A55")]
	public const uint ISVISIBLE_WEAPON = 2u;

	[Token(Token = "0x4003A56")]
	public const uint ISVISIBLE_CLOTHEFFECT = 4u;

	[Token(Token = "0x4003A57")]
	public const uint ISVISIBLE_EMOTE_SHOW_MASK = 8u;

	[Token(Token = "0x4003A58")]
	public const uint ISVISIBLE_ENEMY_HINT = 16u;

	[Token(Token = "0x4003A59")]
	[FieldOffset(Offset = "0x0")]
	public static int LOCAL_PLAYER_TEXTURE_SCALE;

	[Token(Token = "0x4003A5A")]
	[FieldOffset(Offset = "0x18")]
	private int DJOLEONHION;

	[Token(Token = "0x4003A5B")]
	[FieldOffset(Offset = "0x20")]
	private ulong KAIPKNFOKOP;

	[Token(Token = "0x4003A5C")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<uint, List<int>> NDDLAFGEGFF;

	[Token(Token = "0x4003A5D")]
	[FieldOffset(Offset = "0x2C")]
	private bool LGCLFCNIAJP;

	[Token(Token = "0x4003A5E")]
	[FieldOffset(Offset = "0x30")]
	public LIAOHMGEDGI OnCustomUMAUpdated;

	[Token(Token = "0x4003A5F")]
	[FieldOffset(Offset = "0x34")]
	private bool FBAMPPPNFJA;

	[Token(Token = "0x4003A60")]
	[FieldOffset(Offset = "0x38")]
	private List<int> JKPFALDJMJL;

	[Token(Token = "0x4003A61")]
	[FieldOffset(Offset = "0x3C")]
	private int BKFHFNBOLCC;

	[Token(Token = "0x4003A62")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<int, bool> MFDNONBCKBE;

	[Token(Token = "0x4003A63")]
	[FieldOffset(Offset = "0x44")]
	public FJIGOOPIJJD m_PAvatarData;

	[Token(Token = "0x4003A64")]
	private const string OBCHLDKAHGG = "Chest";

	[Token(Token = "0x4003A65")]
	private const string HBICEGGKOKL = "Vest";

	[Token(Token = "0x4003A66")]
	private const string CCOIKHJEAFC = "Hair";

	[Token(Token = "0x4003A67")]
	private const string LJNENLCEELK = "Helmet";

	[Token(Token = "0x4003A68")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<int, string> MJHBFJGAFDN;

	[Token(Token = "0x4003A69")]
	[FieldOffset(Offset = "0x4C")]
	private ITransformNode HHKAPLEDNKE;

	[Token(Token = "0x4003A6A")]
	[FieldOffset(Offset = "0x50")]
	private ITransformNode ENOJKEHACNF;

	[Token(Token = "0x4003A6B")]
	[FieldOffset(Offset = "0x54")]
	private ITransformNode DLHIFBPNPDE;

	[Token(Token = "0x4003A6C")]
	[FieldOffset(Offset = "0x58")]
	private ITransformNode HGMEBBJBOBD;

	[Token(Token = "0x4003A6D")]
	[FieldOffset(Offset = "0x5C")]
	private GameObject NPDIGGLHPNA;

	[Token(Token = "0x4003A6E")]
	[FieldOffset(Offset = "0x60")]
	private ITransformNode MDLEKCIMJAM;

	[Token(Token = "0x4003A6F")]
	[FieldOffset(Offset = "0x64")]
	private GameObject HOGGGAIHHOF;

	[Token(Token = "0x4003A70")]
	[FieldOffset(Offset = "0x68")]
	private GameObject CFOGNOKJDHD;

	[Token(Token = "0x4003A71")]
	[FieldOffset(Offset = "0x6C")]
	private ParticleSystem[] LAJBPPEDIJE;

	[Token(Token = "0x4003A72")]
	[FieldOffset(Offset = "0x70")]
	private GameObject FAAAPMGGBHP;

	[Token(Token = "0x4003A73")]
	[FieldOffset(Offset = "0x74")]
	private GameObject AMCHCPGIKIJ;

	[Token(Token = "0x4003A74")]
	[FieldOffset(Offset = "0x78")]
	private GameObject JJDEPGDLEIC;

	[Token(Token = "0x4003A75")]
	[FieldOffset(Offset = "0x7C")]
	private GameObject GNGKELDLKKJ;

	[Token(Token = "0x4003A76")]
	[FieldOffset(Offset = "0x80")]
	private GameObject APHDEPCPFPP;

	[Token(Token = "0x4003A77")]
	[FieldOffset(Offset = "0x4")]
	private static readonly Vector3 FBHNDPPDKOD;

	[Token(Token = "0x4003A78")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Vector3 GEEBOHKBKAG;

	[Token(Token = "0x4003A79")]
	[FieldOffset(Offset = "0x84")]
	private Dictionary<int, KNLGCPICKLO> MNKMDKDMKOL;

	[Token(Token = "0x4003A7A")]
	[FieldOffset(Offset = "0x88")]
	private Dictionary<uint, KNLGCPICKLO> KGFPFOCDMDI;

	[Token(Token = "0x4003A7B")]
	[FieldOffset(Offset = "0x8C")]
	internal IUmaAvatar EEAGBKBMBLD;

	[Token(Token = "0x4003A7C")]
	[FieldOffset(Offset = "0x90")]
	public IngameAvatarClothEffectComponent m_ClothEffectComponent;

	[Token(Token = "0x4003A7D")]
	[FieldOffset(Offset = "0x94")]
	public IngameAvatarMaterialAnimComponent m_MaterialAnimComponent;

	[Token(Token = "0x4003A7E")]
	[FieldOffset(Offset = "0x98")]
	private GameObject JLJENBFKIAN;

	[Token(Token = "0x4003A7F")]
	[FieldOffset(Offset = "0x9C")]
	private GameObject KDAJMHNPEFK;

	[Token(Token = "0x4003A80")]
	[FieldOffset(Offset = "0xA0")]
	private string ELJPOGKEMLB;

	[Token(Token = "0x4003A81")]
	[FieldOffset(Offset = "0xA4")]
	private string GPAOIHGAHEE;

	[Token(Token = "0x4003A82")]
	[FieldOffset(Offset = "0xA8")]
	private string MNJIMGDEEBB;

	[Token(Token = "0x4003A83")]
	[FieldOffset(Offset = "0xAC")]
	private string INJFNJCCIIN;

	[Token(Token = "0x4003A84")]
	[FieldOffset(Offset = "0xB0")]
	public AvatarSuitData m_AvatarSuit;

	[Token(Token = "0x4003A85")]
	[FieldOffset(Offset = "0xB4")]
	private ResourceID CMDKMNBOEAH;

	[Token(Token = "0x4003A86")]
	[FieldOffset(Offset = "0xB8")]
	private bool _003CNBODJGADMAB_003Ek__BackingField;

	[Token(Token = "0x4003A87")]
	[FieldOffset(Offset = "0xB9")]
	public bool init;

	[Token(Token = "0x4003A88")]
	[FieldOffset(Offset = "0xBC")]
	private Player _003CDKPCJMHMJFJ_003Ek__BackingField;

	[Token(Token = "0x4003A89")]
	[FieldOffset(Offset = "0xC0")]
	private EPPlayerInfo _003CEOJENFALKBB_003Ek__BackingField;

	[Token(Token = "0x4003A8A")]
	[FieldOffset(Offset = "0xC4")]
	private bool FGBIHFILDME;

	[Token(Token = "0x4003A8B")]
	[FieldOffset(Offset = "0xC5")]
	private bool LNANGLLEEEF;

	[Token(Token = "0x4003A8C")]
	[FieldOffset(Offset = "0xC8")]
	private string EELNHBHFKIA;

	[Token(Token = "0x4003A8D")]
	[FieldOffset(Offset = "0xCC")]
	private uint OMKCHJELKMC;

	[Token(Token = "0x4003A8E")]
	[FieldOffset(Offset = "0xD0")]
	private bool GJHAJBCKOLE;

	[Token(Token = "0x4003A8F")]
	[FieldOffset(Offset = "0xD1")]
	private bool FLAHJAIDEMJ;

	[Token(Token = "0x4003A90")]
	[FieldOffset(Offset = "0xD4")]
	private uint OCKIAALBIPN;

	[Token(Token = "0x4003A91")]
	[FieldOffset(Offset = "0xD8")]
	private bool LNDBKCDAEDF;

	[Token(Token = "0x4003A92")]
	[FieldOffset(Offset = "0xDC")]
	private UMAContextSimple NBACCFEDJCJ;

	[Token(Token = "0x4003A93")]
	[FieldOffset(Offset = "0xE0")]
	private float MIMLIHINMEP;

	[Token(Token = "0x4003A94")]
	[FieldOffset(Offset = "0xE4")]
	private bool HIEAMFCHMON;

	[Token(Token = "0x4003A95")]
	[FieldOffset(Offset = "0xE5")]
	private bool KCADLABCONA;

	[Token(Token = "0x4003A96")]
	[FieldOffset(Offset = "0xE6")]
	private bool JPPKMECFBLN;

	[Token(Token = "0x4003A97")]
	[FieldOffset(Offset = "0xE7")]
	private bool AEIEPOMCFND;

	[Token(Token = "0x4003A98")]
	[FieldOffset(Offset = "0x1C")]
	private static ResourceID[] LGNGFGFDIPO;

	[Token(Token = "0x4003A99")]
	[FieldOffset(Offset = "0xE8")]
	private List<uint> AJLMNDPNLDA;

	[Token(Token = "0x4003A9A")]
	[FieldOffset(Offset = "0xEC")]
	private bool CGOCOAEOCMN;

	[Token(Token = "0x4003A9B")]
	[FieldOffset(Offset = "0xED")]
	private bool CABKDMBCOBN;

	[Token(Token = "0x4003A9C")]
	[FieldOffset(Offset = "0xF0")]
	private List<EventClothEffectsData> HCEGEKMMJDJ;

	[Token(Token = "0x4003A9D")]
	[FieldOffset(Offset = "0xF4")]
	private List<string> MKIMLOFCBGO;

	[Token(Token = "0x4003A9E")]
	[FieldOffset(Offset = "0xF8")]
	private List<int> AOGLBHIPPJB;

	[Token(Token = "0x4003A9F")]
	private const int ADEPLMLJIPK = 100;

	[Token(Token = "0x4003AA0")]
	public const int GameModeEffectIndex1 = 101;

	[Token(Token = "0x4003AA1")]
	private const int HOCDJKLPDMB = 2;

	[Token(Token = "0x4003AA2")]
	[FieldOffset(Offset = "0xFC")]
	private uint CJNMMKINEBM;

	[Token(Token = "0x4003AA3")]
	[FieldOffset(Offset = "0x100")]
	private uint LDCCKHBBKIE;

	[Token(Token = "0x4003AA4")]
	[FieldOffset(Offset = "0x104")]
	private EpicClothesTextData CKLKLJJMNBJ;

	[Token(Token = "0x4003AA5")]
	[FieldOffset(Offset = "0x108")]
	private ResourceID BFPEFJIGDII;

	[Token(Token = "0x170001B0")]
	private int KHJDKEDLHHE
	{
		[Token(Token = "0x60012F3")]
		[Address(RVA = "0x11456D4", Offset = "0x11456D4", VA = "0x11456D4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170001B1")]
	public ulong OAGKEAFPEND
	{
		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x1145790", Offset = "0x1145790", VA = "0x1145790")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x170001B2")]
	public GameObject CLOAIIGBNIG
	{
		[Token(Token = "0x60012F9")]
		[Address(RVA = "0x114888C", Offset = "0x114888C", VA = "0x114888C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B3")]
	public bool LNKNDGHJHAE
	{
		[Token(Token = "0x60012FA")]
		[Address(RVA = "0x11488E4", Offset = "0x11488E4", VA = "0x11488E4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012FB")]
		[Address(RVA = "0x11488EC", Offset = "0x11488EC", VA = "0x11488EC")]
		set
		{
		}
	}

	[Token(Token = "0x170001B4")]
	public Player DFPPFJAPINP
	{
		[Token(Token = "0x60012FC")]
		[Address(RVA = "0x1145B54", Offset = "0x1145B54", VA = "0x1145B54")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012FD")]
		[Address(RVA = "0x11488F4", Offset = "0x11488F4", VA = "0x11488F4")]
		private set
		{
		}
	}

	[Token(Token = "0x170001B5")]
	public EPPlayerInfo JOFHHKLCMKC
	{
		[Token(Token = "0x60012FE")]
		[Address(RVA = "0x11488FC", Offset = "0x11488FC", VA = "0x11488FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012FF")]
		[Address(RVA = "0x1148904", Offset = "0x1148904", VA = "0x1148904")]
		private set
		{
		}
	}

	[Token(Token = "0x170001B6")]
	public bool ALLOFKGGNJB
	{
		[Token(Token = "0x6001315")]
		[Address(RVA = "0x114E190", Offset = "0x114E190", VA = "0x114E190")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001B7")]
	public uint NIDNCDNNGME
	{
		[Token(Token = "0x6001332")]
		[Address(RVA = "0x11562FC", Offset = "0x11562FC", VA = "0x11562FC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x170001B8")]
	public UMAData.EffectType DEEGGKFDOKA
	{
		[Token(Token = "0x6001373")]
		[Address(RVA = "0x11637B0", Offset = "0x11637B0", VA = "0x11637B0")]
		get
		{
			return default(UMAData.EffectType);
		}
	}

	[Token(Token = "0x60012F2")]
	[Address(RVA = "0x1144E04", Offset = "0x1144E04", VA = "0x1144E04")]
	public AvatarManager()
	{
	}

	[Token(Token = "0x60012F5")]
	[Address(RVA = "0x11457E8", Offset = "0x11457E8", VA = "0x11457E8")]
	public void EnterEffectTriggerClientInNeed()
	{
	}

	[Token(Token = "0x60012F6")]
	[Address(RVA = "0x1145F38", Offset = "0x1145F38", VA = "0x1145F38")]
	public void OnMapEnemyEffectStart(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x60012F7")]
	[Address(RVA = "0x1146610", Offset = "0x1146610", VA = "0x1146610")]
	public void OnMapEnemyEffectStop(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x1145B5C", Offset = "0x1145B5C", VA = "0x1145B5C")]
	public void OnEffectTriggerClientValueChanged(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6001300")]
	[Address(RVA = "0x114890C", Offset = "0x114890C", VA = "0x114890C")]
	private static ResourceID ILKPJGDMJFM(bool HHCCBKKFCLJ, bool FBEHHOHIPIM, bool JIKFNLENKEM)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6001301")]
	[Address(RVA = "0x1148CDC", Offset = "0x1148CDC", VA = "0x1148CDC")]
	public static AvatarManager CreateEpAvatar(bool FBEHHOHIPIM)
	{
		return null;
	}

	[Token(Token = "0x6001302")]
	[Address(RVA = "0x1149AEC", Offset = "0x1149AEC", VA = "0x1149AEC")]
	public void Init(Player FIMNKGABILM)
	{
	}

	[Token(Token = "0x6001303")]
	[Address(RVA = "0x114B7E0", Offset = "0x114B7E0", VA = "0x114B7E0")]
	public bool InitArtModel(bool NGCAOLIPLNP)
	{
		return default(bool);
	}

	[Token(Token = "0x6001304")]
	[Address(RVA = "0x1148F14", Offset = "0x1148F14", VA = "0x1148F14")]
	public void InitElitePassPlayer(bool NGCAOLIPLNP)
	{
	}

	[Token(Token = "0x6001305")]
	[Address(RVA = "0x114C568", Offset = "0x114C568", VA = "0x114C568")]
	public void BindEPPlayerAndUpdateAnimation(EPPlayerInfo FIMNKGABILM)
	{
	}

	[Token(Token = "0x6001306")]
	[Address(RVA = "0x114C5DC", Offset = "0x114C5DC", VA = "0x114C5DC")]
	public void BindEPPlayer(EPPlayerInfo FIMNKGABILM)
	{
	}

	[Token(Token = "0x6001307")]
	[Address(RVA = "0x114C86C", Offset = "0x114C86C", VA = "0x114C86C")]
	public void UpdateEPPlayerAnimation()
	{
	}

	[Token(Token = "0x6001308")]
	[Address(RVA = "0x114CD68", Offset = "0x114CD68", VA = "0x114CD68")]
	public void BindArenaNPCPLayer(EPPlayerInfo FIMNKGABILM, ResourceID APMLLCPBKAB)
	{
	}

	[Token(Token = "0x6001309")]
	[Address(RVA = "0x114CDF8", Offset = "0x114CDF8", VA = "0x114CDF8")]
	public void UpdateAreanaNPCPlayerAnimation(ResourceID APMLLCPBKAB)
	{
	}

	[Token(Token = "0x600130A")]
	[Address(RVA = "0x114CBC8", Offset = "0x114CBC8", VA = "0x114CBC8")]
	public void ChangeRace(string OGADKOELEAG)
	{
	}

	[Token(Token = "0x600130B")]
	[Address(RVA = "0x114D0F8", Offset = "0x114D0F8", VA = "0x114D0F8")]
	public void ClearPlayerSlots()
	{
	}

	[Token(Token = "0x600130C")]
	[Address(RVA = "0x114D218", Offset = "0x114D218", VA = "0x114D218")]
	public void ClearSetSlot()
	{
	}

	[Token(Token = "0x600130D")]
	[Address(RVA = "0x114D34C", Offset = "0x114D34C", VA = "0x114D34C")]
	public void UpdateAvatarForce()
	{
	}

	[Token(Token = "0x600130E")]
	[Address(RVA = "0x114D488", Offset = "0x114D488", VA = "0x114D488")]
	public void AddUMAFinishUpdateCallBack(UMAData.CharacterUpdatedDelgate IBJIDAEAKED)
	{
	}

	[Token(Token = "0x600130F")]
	[Address(RVA = "0x114D744", Offset = "0x114D744", VA = "0x114D744")]
	public void RemoveUMAFinishUpdateCallBack(UMAData.CharacterUpdatedDelgate IBJIDAEAKED)
	{
	}

	[Token(Token = "0x6001310")]
	[Address(RVA = "0x114DA00", Offset = "0x114DA00", VA = "0x114DA00")]
	public void SetLocalPosition(Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x6001311")]
	[Address(RVA = "0x114DADC", Offset = "0x114DADC", VA = "0x114DADC")]
	public void ResetLocalPosition()
	{
	}

	[Token(Token = "0x6001312")]
	[Address(RVA = "0x114DC54", Offset = "0x114DC54", VA = "0x114DC54")]
	public void SetSwimSurfDeadPostion()
	{
	}

	[Token(Token = "0x6001313")]
	[Address(RVA = "0x114DED0", Offset = "0x114DED0", VA = "0x114DED0")]
	public Vector3 GetLocalPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6001314")]
	[Address(RVA = "0x114DF74", Offset = "0x114DF74", VA = "0x114DF74")]
	public void SetAnimator(Animator DMKBBAIDGDA)
	{
	}

	[Token(Token = "0x6001316")]
	[Address(RVA = "0x114B1F0", Offset = "0x114B1F0", VA = "0x114B1F0")]
	private bool KBELPKJBLAG()
	{
		return default(bool);
	}

	[Token(Token = "0x6001317")]
	[Address(RVA = "0x114B164", Offset = "0x114B164", VA = "0x114B164")]
	private bool JPFMADNPNEB()
	{
		return default(bool);
	}

	[Token(Token = "0x6001318")]
	[Address(RVA = "0x114E2D0", Offset = "0x114E2D0", VA = "0x114E2D0")]
	private void BELKJHNEGAD(bool HHBLLIBLDCO = false)
	{
	}

	[Token(Token = "0x6001319")]
	[Address(RVA = "0x114F7E4", Offset = "0x114F7E4", VA = "0x114F7E4")]
	private void HNPNDBACGNL()
	{
	}

	[Token(Token = "0x600131A")]
	[Address(RVA = "0x114FF08", Offset = "0x114FF08", VA = "0x114FF08")]
	private bool OIFGJAPJMJH()
	{
		return default(bool);
	}

	[Token(Token = "0x600131B")]
	[Address(RVA = "0x1150020", Offset = "0x1150020", VA = "0x1150020")]
	private void OIDKGMCILLN()
	{
	}

	[Token(Token = "0x600131C")]
	[Address(RVA = "0x1150218", Offset = "0x1150218", VA = "0x1150218")]
	private void OBCOBGIFCCG()
	{
	}

	[Token(Token = "0x600131D")]
	[Address(RVA = "0x1150324", Offset = "0x1150324", VA = "0x1150324")]
	private void OBCOBGIFCCG(List<uint> IGMNKAJACKJ)
	{
	}

	[Token(Token = "0x600131E")]
	[Address(RVA = "0x11517B4", Offset = "0x11517B4", VA = "0x11517B4")]
	private void IKAMLNJCHPM(AvatarWardrobeData AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600131F")]
	[Address(RVA = "0x1151D68", Offset = "0x1151D68", VA = "0x1151D68")]
	private void FPPCDJHNMEH(UIModelAvatarBase.EWardrobeType PMGBACFJIHO, uint CJDMCMOODAH, int EIKCFIDCCMM = 0)
	{
	}

	[Token(Token = "0x6001320")]
	[Address(RVA = "0x1150E34", Offset = "0x1150E34", VA = "0x1150E34")]
	private void IKAMLNJCHPM(List<uint> IGMNKAJACKJ)
	{
	}

	[Token(Token = "0x6001321")]
	[Address(RVA = "0x11523E4", Offset = "0x11523E4", VA = "0x11523E4")]
	private void GGCLHNDIEBF(ResourceID HBOCMKFJKKA, UIModelAvatarBase.EWardrobeType PMGBACFJIHO, bool EBBKPGEELAH = false)
	{
	}

	[Token(Token = "0x6001322")]
	[Address(RVA = "0x1150AE8", Offset = "0x1150AE8", VA = "0x1150AE8")]
	private void KBMBCPDEMGL(ResourceID HBOCMKFJKKA, UIModelAvatarBase.EWardrobeType PMGBACFJIHO, bool EBBKPGEELAH = false)
	{
	}

	[Token(Token = "0x6001323")]
	[Address(RVA = "0x115252C", Offset = "0x115252C", VA = "0x115252C")]
	protected Transform EGOIFLNIJNI(UIModelAvatarBase.EWardrobeType IIHMIAEHDIG)
	{
		return null;
	}

	[Token(Token = "0x6001324")]
	[Address(RVA = "0x11525D4", Offset = "0x11525D4", VA = "0x11525D4")]
	private void HMHHGLGCCLP()
	{
	}

	[Token(Token = "0x6001325")]
	[Address(RVA = "0x1152E98", Offset = "0x1152E98", VA = "0x1152E98")]
	public void InitSingleGameAvatarData()
	{
	}

	[Token(Token = "0x6001326")]
	[Address(RVA = "0x1153334", Offset = "0x1153334", VA = "0x1153334")]
	public void SyncAvatarProperties([Optional] FJIGOOPIJJD CAHPGKODCHM, bool EFDPMACOJFC = true)
	{
	}

	[Token(Token = "0x6001327")]
	[Address(RVA = "0x11543BC", Offset = "0x11543BC", VA = "0x11543BC")]
	public void DebugChangeAvatarCloth(List<uint> COPDEIABDCP)
	{
	}

	[Token(Token = "0x6001328")]
	[Address(RVA = "0x1154614", Offset = "0x1154614", VA = "0x1154614")]
	public void ClearAllClothes()
	{
	}

	[Token(Token = "0x6001329")]
	[Address(RVA = "0x1154C68", Offset = "0x1154C68", VA = "0x1154C68")]
	public void ChangeAvatarCloth(List<uint> KDNILIFJHHK, bool KNEBHKEPCIB)
	{
	}

	[Token(Token = "0x600132A")]
	[Address(RVA = "0x1154AA8", Offset = "0x1154AA8", VA = "0x1154AA8")]
	public void ClearAllSlots()
	{
	}

	[Token(Token = "0x600132B")]
	[Address(RVA = "0x1155590", Offset = "0x1155590", VA = "0x1155590")]
	public void OnDebugTestRecipe(int LCDAEAANOBE, List<uint> OMCBOPLDPFP)
	{
	}

	[Token(Token = "0x600132C")]
	[Address(RVA = "0x1155B24", Offset = "0x1155B24", VA = "0x1155B24")]
	public void T_SyncAvatarProperties([Optional] List<uint> OIDLFHLENPB, bool PCJAHICBLGI = false)
	{
	}

	[Token(Token = "0x600132D")]
	[Address(RVA = "0x1155C28", Offset = "0x1155C28", VA = "0x1155C28")]
	public void T_UpdateAvatar([Optional] List<uint> OIDLFHLENPB, bool PCJAHICBLGI = false)
	{
	}

	[Token(Token = "0x600132E")]
	[Address(RVA = "0x1156368", Offset = "0x1156368", VA = "0x1156368")]
	private void CBNFBCCHPLI(UMAData AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600132F")]
	[Address(RVA = "0x1156A6C", Offset = "0x1156A6C", VA = "0x1156A6C")]
	public void SetClothEffectEmoteShowMaskVisibility(UIModelAvatarBase.EWardrobeType BIPNLODPPII, bool FCLJOMKMCBB)
	{
	}

	[Token(Token = "0x6001330")]
	[Address(RVA = "0x1156B14", Offset = "0x1156B14", VA = "0x1156B14")]
	public void ResetClothEffectEmoteShowMaskVisibility()
	{
	}

	[Token(Token = "0x6001331")]
	[Address(RVA = "0x1156C18", Offset = "0x1156C18", VA = "0x1156C18")]
	public Vector3 GetAvatarScale()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6001333")]
	[Address(RVA = "0x1150974", Offset = "0x1150974", VA = "0x1150974")]
	private bool PALKEECGDAH()
	{
		return default(bool);
	}

	[Token(Token = "0x6001334")]
	[Address(RVA = "0x115576C", Offset = "0x115576C", VA = "0x115576C")]
	public void DebugUpdateCloth(uint MJAMNGJHFJH, bool HHCCBKKFCLJ)
	{
	}

	[Token(Token = "0x6001335")]
	[Address(RVA = "0x114E7D4", Offset = "0x114E7D4", VA = "0x114E7D4")]
	public void UpdateCloth(uint MJAMNGJHFJH, bool NJLNAOOKBFC = false, bool CPBJIIIOCGI = false, [Optional] List<uint> GCHNKHHIBNI)
	{
	}

	[Token(Token = "0x6001336")]
	[Address(RVA = "0x1152650", Offset = "0x1152650", VA = "0x1152650")]
	public void UpdateFace(uint MLGDKLEHJJF, bool HHBLLIBLDCO = false)
	{
	}

	[Token(Token = "0x6001337")]
	[Address(RVA = "0x1156D7C", Offset = "0x1156D7C", VA = "0x1156D7C")]
	public void SetObservered(bool BBALBCEHDKE, bool PGDLKILFFJL)
	{
	}

	[Token(Token = "0x6001338")]
	[Address(RVA = "0x1153E0C", Offset = "0x1153E0C", VA = "0x1153E0C")]
	private void EKAFMNBHOCA(bool HHBLLIBLDCO = false)
	{
	}

	[Token(Token = "0x6001339")]
	[Address(RVA = "0x1157288", Offset = "0x1157288", VA = "0x1157288")]
	public void LoadDefaultAvatar()
	{
	}

	[Token(Token = "0x600133A")]
	[Address(RVA = "0x11572DC", Offset = "0x11572DC", VA = "0x11572DC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600133B")]
	[Address(RVA = "0x11575CC", Offset = "0x11575CC", VA = "0x11575CC")]
	public void CharacterCreatedCB(UMAData EIOFDOGMPHO)
	{
	}

	[Token(Token = "0x600133C")]
	[Address(RVA = "0x1157628", Offset = "0x1157628", VA = "0x1157628")]
	public void UpdateOffset(bool MDOMPAOAPEP, bool BAJJBNNNGIH)
	{
	}

	[Token(Token = "0x600133D")]
	[Address(RVA = "0x114B298", Offset = "0x114B298", VA = "0x114B298")]
	public void SetLayerRecursively(GameObject ECINOMEHBKA, int MBKHHEHLHEF)
	{
	}

	[Token(Token = "0x600133E")]
	[Address(RVA = "0x1157698", Offset = "0x1157698", VA = "0x1157698")]
	public void ChangeMeshLayer(int MBKHHEHLHEF)
	{
	}

	[Token(Token = "0x600133F")]
	[Address(RVA = "0x11577FC", Offset = "0x11577FC", VA = "0x11577FC")]
	public void SetVisible(bool JOGHOHLEJFL, bool NEEILPFMDDN = false)
	{
	}

	[Token(Token = "0x6001340")]
	[Address(RVA = "0x1158370", Offset = "0x1158370", VA = "0x1158370")]
	public void SetUMARendererActive(bool GIKMGIJCDOP)
	{
	}

	[Token(Token = "0x6001341")]
	[Address(RVA = "0x115858C", Offset = "0x115858C", VA = "0x115858C")]
	public void UpdateBigHeadAvatar(uint IKFLKGIAFOP, ResourceID FJOHBOFFMHD)
	{
	}

	[Token(Token = "0x6001342")]
	[Address(RVA = "0x1158D34", Offset = "0x1158D34", VA = "0x1158D34")]
	public void UpdateAvatarSlot(DENCPDNONDO COOGKCBBIBC, string PLAKNDLPAGG, bool CPBJIIIOCGI = false)
	{
	}

	[Token(Token = "0x6001343")]
	[Address(RVA = "0x115525C", Offset = "0x115525C", VA = "0x115525C")]
	public void UpdateAvatarSlot(string CJJCONMPDAO, string PLAKNDLPAGG, bool CPBJIIIOCGI = false)
	{
	}

	[Token(Token = "0x6001344")]
	[Address(RVA = "0x1158E40", Offset = "0x1158E40", VA = "0x1158E40")]
	public bool UpdateAvatarSlotGeneral(string CJJCONMPDAO, string PLAKNDLPAGG)
	{
		return default(bool);
	}

	[Token(Token = "0x6001345")]
	[Address(RVA = "0x1159500", Offset = "0x1159500", VA = "0x1159500")]
	private bool MNHIFAENBCG(string CJJCONMPDAO, string PLAKNDLPAGG)
	{
		return default(bool);
	}

	[Token(Token = "0x6001346")]
	[Address(RVA = "0x1159878", Offset = "0x1159878", VA = "0x1159878")]
	public void OnSyncAvatarEquip(AAHMJHHPECM CMNLNABNDOM)
	{
	}

	[Token(Token = "0x6001347")]
	[Address(RVA = "0x114EA68", Offset = "0x114EA68", VA = "0x114EA68")]
	private void KLBGHCADJFE(LGCOKIBHIJL CFKPHKPIOMH, uint CJIBGKIDCMM = 0u)
	{
	}

	[Token(Token = "0x6001348")]
	[Address(RVA = "0x1159A04", Offset = "0x1159A04", VA = "0x1159A04")]
	private void GDFBHIGMBGK()
	{
	}

	[Token(Token = "0x6001349")]
	[Address(RVA = "0x1154BE4", Offset = "0x1154BE4", VA = "0x1154BE4")]
	public void RemoveClothEffect(UIModelAvatarBase.EWardrobeType BIPNLODPPII)
	{
	}

	[Token(Token = "0x600134A")]
	[Address(RVA = "0x1159B24", Offset = "0x1159B24", VA = "0x1159B24")]
	public void OnSyncAvatarUnEquip(AAHMJHHPECM CMNLNABNDOM)
	{
	}

	[Token(Token = "0x600134B")]
	[Address(RVA = "0x1159DBC", Offset = "0x1159DBC", VA = "0x1159DBC")]
	public void OnSyncDropItem(AAHMJHHPECM CMNLNABNDOM)
	{
	}

	[Token(Token = "0x600134C")]
	[Address(RVA = "0x1159F9C", Offset = "0x1159F9C", VA = "0x1159F9C")]
	public void InitAvatarEquipments(List<AAHMJHHPECM> IHOFIOOBGBB)
	{
	}

	[Token(Token = "0x600134D")]
	[Address(RVA = "0x115A130", Offset = "0x115A130", VA = "0x115A130")]
	private bool OFFBLNBKNBI(NPCNMJAGIKI AHJOAPHFJLN, BMGBKEENCJH CKOOGPANEEC, bool INPCLNDJFOL, bool IIDGIAGBEHG = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600134E")]
	[Address(RVA = "0x115A474", Offset = "0x115A474", VA = "0x115A474")]
	public void RefreshBackMountWeaponForSwimming(bool INPCLNDJFOL, bool IIDGIAGBEHG = false)
	{
	}

	[Token(Token = "0x600134F")]
	[Address(RVA = "0x115BD90", Offset = "0x115BD90", VA = "0x115BD90")]
	public bool ShowSecondaryWeaponModel()
	{
		return default(bool);
	}

	[Token(Token = "0x6001350")]
	[Address(RVA = "0x11598F8", Offset = "0x11598F8", VA = "0x11598F8")]
	public void RefreshBackMountWeapon()
	{
	}

	[Token(Token = "0x6001351")]
	[Address(RVA = "0x115BFC0", Offset = "0x115BFC0", VA = "0x115BFC0")]
	public void RefreshBackMountWeaponForGettingOffSkateboard()
	{
	}

	[Token(Token = "0x6001352")]
	[Address(RVA = "0x115C0CC", Offset = "0x115C0CC", VA = "0x115C0CC")]
	private DENCPDNONDO PKFCLHBDHEB(uint LPFMNBCHJPE)
	{
		return default(DENCPDNONDO);
	}

	[Token(Token = "0x6001353")]
	[Address(RVA = "0x115C2BC", Offset = "0x115C2BC", VA = "0x115C2BC")]
	private void HCBJONGLJGH(uint LPFMNBCHJPE, bool BBFAHFFADIC, Object ECINOMEHBKA)
	{
	}

	[Token(Token = "0x6001354")]
	[Address(RVA = "0x115CFD0", Offset = "0x115CFD0", VA = "0x115CFD0")]
	public void RefreshWeaponModel()
	{
	}

	[Token(Token = "0x6001355")]
	[Address(RVA = "0x115C778", Offset = "0x115C778", VA = "0x115C778")]
	private void OIBDGMNJJHC(uint NOKEFDPIDGK, DENCPDNONDO CKOOGPANEEC = DENCPDNONDO.None)
	{
	}

	[Token(Token = "0x6001356")]
	[Address(RVA = "0x115D788", Offset = "0x115D788", VA = "0x115D788")]
	public void DebugRefreshBackWeaponModel()
	{
	}

	[Token(Token = "0x6001357")]
	[Address(RVA = "0x115D2D0", Offset = "0x115D2D0", VA = "0x115D2D0")]
	public Transform GetBackWeaponAttachPoint(DENCPDNONDO CKOOGPANEEC)
	{
		return null;
	}

	[Token(Token = "0x6001358")]
	[Address(RVA = "0x115A6A4", Offset = "0x115A6A4", VA = "0x115A6A4")]
	private void JJJFJMIDMAI(DENCPDNONDO IKMOPANGOGF, AAHMJHHPECM CMNLNABNDOM)
	{
	}

	[Token(Token = "0x6001359")]
	[Address(RVA = "0x115DA88", Offset = "0x115DA88", VA = "0x115DA88")]
	private ResourceID EEGGHBFHKPH(MANEMECPKIO CLIDKEHJBNO, AAHMJHHPECM CMNLNABNDOM)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600135A")]
	[Address(RVA = "0x115DC14", Offset = "0x115DC14", VA = "0x115DC14")]
	private ResourceID NDDBNLAAKIC(MANEMECPKIO CLIDKEHJBNO, AAHMJHHPECM CMNLNABNDOM)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600135B")]
	[Address(RVA = "0x115DDA0", Offset = "0x115DDA0", VA = "0x115DDA0")]
	private void AABKOOBJFND(AAHMJHHPECM CMNLNABNDOM, KNLGCPICKLO BOOIKMFADNA)
	{
	}

	[Token(Token = "0x600135C")]
	[Address(RVA = "0x115D560", Offset = "0x115D560", VA = "0x115D560")]
	private void AABKOOBJFND(AAHMJHHPECM CMNLNABNDOM, GameObject LNBPKIHNFHB)
	{
	}

	[Token(Token = "0x600135D")]
	[Address(RVA = "0x115DF9C", Offset = "0x115DF9C", VA = "0x115DF9C")]
	public void OnSyncSwapWeapon()
	{
	}

	[Token(Token = "0x600135E")]
	[Address(RVA = "0x115DFFC", Offset = "0x115DFFC", VA = "0x115DFFC")]
	public void EquipParachuteBag()
	{
	}

	[Token(Token = "0x600135F")]
	[Address(RVA = "0x115E104", Offset = "0x115E104", VA = "0x115E104")]
	public void UnequipParachuteBag()
	{
	}

	[Token(Token = "0x6001360")]
	[Address(RVA = "0x115E290", Offset = "0x115E290", VA = "0x115E290")]
	public void ClearWardrobe4SnowMan()
	{
	}

	[Token(Token = "0x6001361")]
	[Address(RVA = "0x115E538", Offset = "0x115E538", VA = "0x115E538")]
	public void ResetSnowManAvatar()
	{
	}

	[Token(Token = "0x6001362")]
	[Address(RVA = "0x115EE98", Offset = "0x115EE98", VA = "0x115EE98")]
	public void InitPartyComboEffet()
	{
	}

	[Token(Token = "0x6001363")]
	[Address(RVA = "0x115F93C", Offset = "0x115F93C", VA = "0x115F93C")]
	public void SetPartyEffectShow(uint EIKCFIDCCMM = 0u)
	{
	}

	[Token(Token = "0x6001364")]
	[Address(RVA = "0x115FC94", Offset = "0x115FC94", VA = "0x115FC94")]
	public void OnEnterSurf()
	{
	}

	[Token(Token = "0x6001365")]
	[Address(RVA = "0x1160548", Offset = "0x1160548", VA = "0x1160548")]
	public void OnExitSurf()
	{
	}

	[Token(Token = "0x6001366")]
	[Address(RVA = "0x11607A0", Offset = "0x11607A0", VA = "0x11607A0")]
	public void OnEnterWater()
	{
	}

	[Token(Token = "0x6001367")]
	[Address(RVA = "0x11602E0", Offset = "0x11602E0", VA = "0x11602E0")]
	public void OnExitWater()
	{
	}

	[Token(Token = "0x6001368")]
	[Address(RVA = "0x1160BB8", Offset = "0x1160BB8", VA = "0x1160BB8")]
	public void OnSurfMove(bool CHADOJMOHFJ)
	{
	}

	[Token(Token = "0x6001369")]
	[Address(RVA = "0x1160E98", Offset = "0x1160E98", VA = "0x1160E98")]
	public void OnWaterMove(bool CHADOJMOHFJ)
	{
	}

	[Token(Token = "0x600136A")]
	[Address(RVA = "0x1161CD8", Offset = "0x1161CD8", VA = "0x1161CD8")]
	public void PlayHitProtectionEffect()
	{
	}

	[Token(Token = "0x600136B")]
	[Address(RVA = "0x1159218", Offset = "0x1159218", VA = "0x1159218")]
	private static string BMDJDKLFJBH(string KPPDBEDAFNH, string LNGNLJCECCO)
	{
		return null;
	}

	[Token(Token = "0x600136C")]
	[Address(RVA = "0x11538C4", Offset = "0x11538C4", VA = "0x11538C4")]
	private void HBMJAIKEEPH()
	{
	}

	[Token(Token = "0x600136D")]
	[Address(RVA = "0x116250C", Offset = "0x116250C", VA = "0x116250C")]
	private bool OMOFPFDFIDC(IEnumerable<uint> IKICDPGEGBE)
	{
		return default(bool);
	}

	[Token(Token = "0x600136E")]
	[Address(RVA = "0x11628C8", Offset = "0x11628C8", VA = "0x11628C8")]
	private bool HKILDPBOHNM(uint IDNEFEOPGIF)
	{
		return default(bool);
	}

	[Token(Token = "0x600136F")]
	[Address(RVA = "0x1162140", Offset = "0x1162140", VA = "0x1162140")]
	private bool ICNNIFPFPBB(IEnumerable<uint> IKICDPGEGBE, uint IDNEFEOPGIF)
	{
		return default(bool);
	}

	[Token(Token = "0x6001370")]
	[Address(RVA = "0x11629E8", Offset = "0x11629E8", VA = "0x11629E8")]
	public ResourceID GetSuitAnimation()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6001371")]
	[Address(RVA = "0x1162AD8", Offset = "0x1162AD8", VA = "0x1162AD8")]
	public ResourceID GetAvatarSpecialAnimation()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6001372")]
	[Address(RVA = "0x1162B30", Offset = "0x1162B30", VA = "0x1162B30")]
	public void SwitchEffect(UMAData.EffectType DEEGGKFDOKA)
	{
	}

	[Token(Token = "0x6001374")]
	[Address(RVA = "0x1162DA4", Offset = "0x1162DA4", VA = "0x1162DA4")]
	private void BFCBOGFDAGM(UMAData.EffectType DEEGGKFDOKA)
	{
	}

	[Token(Token = "0x6001375")]
	[Address(RVA = "0x11639C0", Offset = "0x11639C0", VA = "0x11639C0")]
	public void SetAvatarColor(Color MGAOFBNFAKF)
	{
	}

	[Token(Token = "0x6001376")]
	[Address(RVA = "0x1163C18", Offset = "0x1163C18", VA = "0x1163C18")]
	public bool GetMeshBounds(ref Bounds LPJBDMAACKB)
	{
		return default(bool);
	}

	[Token(Token = "0x6001377")]
	[Address(RVA = "0x1163E38", Offset = "0x1163E38", VA = "0x1163E38")]
	public void SetThermalView(bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x6001378")]
	[Address(RVA = "0x1164208", Offset = "0x1164208", VA = "0x1164208")]
	public void SetThermalViewByModel(bool ELOELMEPFCN, GameObject GDOGIGDHJJO)
	{
	}

	[Token(Token = "0x6001379")]
	[Address(RVA = "0x1164468", Offset = "0x1164468", VA = "0x1164468")]
	public void DebugRefreshAllRenderTexture()
	{
	}

	[Token(Token = "0x600137A")]
	[Address(RVA = "0x1146AB0", Offset = "0x1146AB0", VA = "0x1146AB0")]
	private void MGJGIPLBKKC()
	{
	}

	[Token(Token = "0x600137B")]
	[Address(RVA = "0x1164754", Offset = "0x1164754", VA = "0x1164754")]
	private EventClothEffectsData BLNALPADBOM(int HHLONFLCJBL)
	{
		return null;
	}

	[Token(Token = "0x600137C")]
	[Address(RVA = "0x114679C", Offset = "0x114679C", VA = "0x114679C")]
	private ResourceID MFADKLCBAAG(int HHLONFLCJBL)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600137D")]
	[Address(RVA = "0x1164AE8", Offset = "0x1164AE8", VA = "0x1164AE8")]
	public bool CheckClothIsBackPack(int HHLONFLCJBL)
	{
		return default(bool);
	}

	[Token(Token = "0x600137E")]
	[Address(RVA = "0x1164C20", Offset = "0x1164C20", VA = "0x1164C20")]
	private bool NNBNEDMOIPF(int HHLONFLCJBL)
	{
		return default(bool);
	}

	[Token(Token = "0x600137F")]
	[Address(RVA = "0x1148220", Offset = "0x1148220", VA = "0x1148220")]
	public void StartTriggeredEffect(int HHLONFLCJBL)
	{
	}

	[Token(Token = "0x6001380")]
	[Address(RVA = "0x1165000", Offset = "0x1165000", VA = "0x1165000")]
	private ResourceID FNGJMEAONOG(int HHLONFLCJBL)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6001381")]
	[Address(RVA = "0x1164EBC", Offset = "0x1164EBC", VA = "0x1164EBC")]
	private void OFLEAOJJBHG(int HHLONFLCJBL, bool POOLNCIGGJP)
	{
	}

	[Token(Token = "0x6001382")]
	[Address(RVA = "0x1165254", Offset = "0x1165254", VA = "0x1165254")]
	private void DKONDDNJBLO(UIModelAvatarBase.EWardrobeType PMGBACFJIHO, ResourceID BLKEIMNDODG, int HHLONFLCJBL, bool POOLNCIGGJP)
	{
	}

	[Token(Token = "0x6001383")]
	[Address(RVA = "0x1165854", Offset = "0x1165854", VA = "0x1165854")]
	private bool IDACJEOCHDA(int PMGBACFJIHO, bool KECDEHFABPN)
	{
		return default(bool);
	}

	[Token(Token = "0x6001384")]
	[Address(RVA = "0x11567E8", Offset = "0x11567E8", VA = "0x11567E8")]
	private void IGDKAOOAAON()
	{
	}

	[Token(Token = "0x6001385")]
	[Address(RVA = "0x1165A28", Offset = "0x1165A28", VA = "0x1165A28")]
	private void KEFHKLMAFPG(int HHLONFLCJBL)
	{
	}

	[Token(Token = "0x6001386")]
	[Address(RVA = "0x1165118", Offset = "0x1165118", VA = "0x1165118")]
	private UIModelAvatarBase.EWardrobeType PGKKGMOIOHH(int HHLONFLCJBL)
	{
		return default(UIModelAvatarBase.EWardrobeType);
	}

	[Token(Token = "0x6001387")]
	[Address(RVA = "0x11468B4", Offset = "0x11468B4", VA = "0x11468B4")]
	public void StartTriggeredEffect(int HHLONFLCJBL, ResourceID FCMOICILFBP)
	{
	}

	[Token(Token = "0x6001388")]
	[Address(RVA = "0x1148564", Offset = "0x1148564", VA = "0x1148564")]
	public void StopTriggeredEffect(int HHLONFLCJBL)
	{
	}

	[Token(Token = "0x6001389")]
	[Address(RVA = "0x1165D80", Offset = "0x1165D80", VA = "0x1165D80")]
	public void StopTriggeredEffect(int HHLONFLCJBL, ResourceID FCMOICILFBP)
	{
	}

	[Token(Token = "0x600138A")]
	[Address(RVA = "0x1146028", Offset = "0x1146028", VA = "0x1146028")]
	private void IGCIEJHBCOP()
	{
	}

	[Token(Token = "0x600138B")]
	[Address(RVA = "0x11462B8", Offset = "0x11462B8", VA = "0x11462B8")]
	private void EFOEDJMILHB(bool GIKMGIJCDOP)
	{
	}

	[Token(Token = "0x600138C")]
	[Address(RVA = "0x1164DAC", Offset = "0x1164DAC", VA = "0x1164DAC")]
	private EffectsRegulatorData DFGBDCGPLBH(int HHLONFLCJBL)
	{
		return null;
	}

	[Token(Token = "0x600138D")]
	[Address(RVA = "0x11581DC", Offset = "0x11581DC", VA = "0x11581DC")]
	private bool LBNBBOEHIHI()
	{
		return default(bool);
	}

	[Token(Token = "0x600138E")]
	[Address(RVA = "0x11582A4", Offset = "0x11582A4", VA = "0x11582A4")]
	private IEnumerator EEINGKFILDE()
	{
		return null;
	}

	[Token(Token = "0x600138F")]
	[Address(RVA = "0x11563F4", Offset = "0x11563F4", VA = "0x11563F4")]
	private void FKLEHHMBAFD()
	{
	}

	[Token(Token = "0x6001390")]
	[Address(RVA = "0x1165E7C", Offset = "0x1165E7C", VA = "0x1165E7C")]
	private void MLHIACIPBLL(int HHLONFLCJBL, bool FICNJIMKAEF)
	{
	}

	[Token(Token = "0x6001391")]
	[Address(RVA = "0x1165BE8", Offset = "0x1165BE8", VA = "0x1165BE8")]
	private bool BFIFELGHALE(int HHLONFLCJBL)
	{
		return default(bool);
	}

	[Token(Token = "0x6001392")]
	[Address(RVA = "0x1153C38", Offset = "0x1153C38", VA = "0x1153C38")]
	private void OAOLLNKBALB()
	{
	}

	[Token(Token = "0x6001393")]
	[Address(RVA = "0x1165F38", Offset = "0x1165F38", VA = "0x1165F38")]
	private bool CNGKAIMBGMC()
	{
		return default(bool);
	}

	[Token(Token = "0x6001394")]
	[Address(RVA = "0x115E79C", Offset = "0x115E79C", VA = "0x115E79C")]
	public void UpdateEpicClothes(uint EIKCFIDCCMM, uint HHLONFLCJBL, bool ACGEBOCCMFK)
	{
	}

	[Token(Token = "0x6001395")]
	[Address(RVA = "0x11661AC", Offset = "0x11661AC", VA = "0x11661AC")]
	internal void KIPGMENOHOG(ClothesUpData AJKBOONEOAB, bool ACGEBOCCMFK)
	{
	}

	[Token(Token = "0x6001396")]
	[Address(RVA = "0x1166538", Offset = "0x1166538", VA = "0x1166538")]
	private bool NBOKFPAKDOC()
	{
		return default(bool);
	}

	[Token(Token = "0x6001397")]
	[Address(RVA = "0x1166754", Offset = "0x1166754", VA = "0x1166754")]
	private bool LIFKKJIEEEB()
	{
		return default(bool);
	}

	[Token(Token = "0x6001398")]
	[Address(RVA = "0x11668B8", Offset = "0x11668B8", VA = "0x11668B8")]
	private ResourceID FHPBCLIDFOA()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6001399")]
	[Address(RVA = "0x11669AC", Offset = "0x11669AC", VA = "0x11669AC")]
	public bool HasEpicClothesActionEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600139A")]
	[Address(RVA = "0x1166A9C", Offset = "0x1166A9C", VA = "0x1166A9C")]
	public void PlayEpicClothesActionEffect(sbyte OECMLDILLJN = 0)
	{
	}

	[Token(Token = "0x600139B")]
	[Address(RVA = "0x1166638", Offset = "0x1166638", VA = "0x1166638")]
	private void NIFOLJJBCGJ(ResourceID JPFKGCMPLLM)
	{
	}

	[Token(Token = "0x600139C")]
	[Address(RVA = "0x1166BD4", Offset = "0x1166BD4", VA = "0x1166BD4")]
	public void Test_EquipBagPack(uint LCBOHFBLJFA, uint CJIBGKIDCMM = 0u)
	{
	}

	[Token(Token = "0x600139D")]
	[Address(RVA = "0x1166CFC", Offset = "0x1166CFC", VA = "0x1166CFC")]
	public void Test_UnequipBagPack()
	{
	}
}
