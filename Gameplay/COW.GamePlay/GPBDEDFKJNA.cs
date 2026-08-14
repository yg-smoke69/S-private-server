using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using WwiseGameSyncs;
using WwiseGameSyncs.Switch;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000563")]
internal class GPBDEDFKJNA : AAHMJHHPECM, _Attribute
{
	[Token(Token = "0x2000564")]
	public enum ENBHOKKHLPG
	{
		[Token(Token = "0x4004272")]
		Rifle = 0,
		[Token(Token = "0x4004273")]
		Sniper = 1,
		[Token(Token = "0x4004274")]
		HandGun = 2,
		[Token(Token = "0x4004275")]
		Knife = 3,
		[Token(Token = "0x4004276")]
		ShotGun = 4,
		[Token(Token = "0x4004277")]
		Grenade = 5,
		[Token(Token = "0x4004278")]
		SubMachineGun = 6,
		[Token(Token = "0x4004279")]
		GrenandeLauncher = 7,
		[Token(Token = "0x400427A")]
		CrossBow = 8,
		[Token(Token = "0x400427B")]
		BuildingGun = 9,
		[Token(Token = "0x400427C")]
		ExternalMachineGun = 10,
		[Token(Token = "0x400427D")]
		HealingGun = 11,
		[Token(Token = "0x400427E")]
		ChargeGun = 12,
		[Token(Token = "0x400427F")]
		HeavyWeapon = 13,
		[Token(Token = "0x4004280")]
		SpawnGun = 14,
		[Token(Token = "0x4004281")]
		GrapplingHookGun = 15,
		[Token(Token = "0x4004282")]
		HandCannon = 16,
		[Token(Token = "0x4004283")]
		PaintSprayer = 17,
		[Token(Token = "0x4004284")]
		ThrowingKnife = 18,
		[Token(Token = "0x4004285")]
		HandCannonIceWall = 19,
		[Token(Token = "0x4004286")]
		VerticalManeuveringEquipment = 20,
		[Token(Token = "0x4004287")]
		SprayWeapon = 21,
		[Token(Token = "0x4004288")]
		ThrowingKnifeBR = 22,
		[Token(Token = "0x4004289")]
		NB = 23,
		[Token(Token = "0x400428A")]
		FakeWeaponRedEnvelope = 24,
		[Token(Token = "0x400428B")]
		FakeWeaponPersonalUAV = 25,
		[Token(Token = "0x400428C")]
		ChargeShotGun = 26,
		[Token(Token = "0x400428D")]
		NB_ALL = 27,
		[Token(Token = "0x400428E")]
		ForAll = 255
	}

	[Token(Token = "0x2000565")]
	public enum HMKNCIHBOFC
	{
		[Token(Token = "0x4004290")]
		SubMachineGun_General,
		[Token(Token = "0x4004291")]
		SubMachineGun_Vss
	}

	[Token(Token = "0x2000566")]
	public enum HAAOGJECGDE
	{
		[Token(Token = "0x4004293")]
		Explosive = 0,
		[Token(Token = "0x4004294")]
		Flash = 1,
		[Token(Token = "0x4004295")]
		Smoke = 2,
		[Token(Token = "0x4004296")]
		Bow = 3,
		[Token(Token = "0x4004297")]
		GrapplingHook = 4,
		[Token(Token = "0x4004298")]
		WaterBall = 5,
		[Token(Token = "0x4004299")]
		Knife = 6,
		[Token(Token = "0x400429A")]
		LoadOut = 7,
		[Token(Token = "0x400429B")]
		VMEHook = 8,
		[Token(Token = "0x400429C")]
		BigToy = 9,
		[Token(Token = "0x400429D")]
		Frozen = 10,
		[Token(Token = "0x400429E")]
		Dummy = 11,
		[Token(Token = "0x400429F")]
		SnowBall = 12,
		[Token(Token = "0x40042A0")]
		FlameFlask = 13,
		[Token(Token = "0x40042A1")]
		SmokeFlask = 14,
		[Token(Token = "0x40042A2")]
		Bullet = 100,
		[Token(Token = "0x40042A3")]
		MAX = 101
	}

	[Token(Token = "0x2000567")]
	public enum IJBDLJMBMNN
	{
		[Token(Token = "0x40042A5")]
		TimeExplode,
		[Token(Token = "0x40042A6")]
		InstantExplode,
		[Token(Token = "0x40042A7")]
		NoExplode,
		[Token(Token = "0x40042A8")]
		Stick,
		[Token(Token = "0x40042A9")]
		ClientInstantExplode,
		[Token(Token = "0x40042AA")]
		TriggerExplode
	}

	[Token(Token = "0x2000568")]
	public enum HJFNLCPCILK
	{
		[Token(Token = "0x40042AC")]
		Throw,
		[Token(Token = "0x40042AD")]
		ManualTrigger
	}

	[Token(Token = "0x2000569")]
	public enum NBALLECGIMK
	{
		[Token(Token = "0x40042AF")]
		Grenade,
		[Token(Token = "0x40042B0")]
		MissileSecond,
		[Token(Token = "0x40042B1")]
		Missile
	}

	[Token(Token = "0x200056A")]
	public enum KEAMPGNLPLD
	{
		[Token(Token = "0x40042B3")]
		IceWall,
		[Token(Token = "0x40042B4")]
		BrickBlock,
		[Token(Token = "0x40042B5")]
		Craft
	}

	[Token(Token = "0x200056B")]
	public enum OMEHHDGDJKJ
	{
		[Token(Token = "0x40042B7")]
		Fist,
		[Token(Token = "0x40042B8")]
		Changuo,
		[Token(Token = "0x40042B9")]
		Machete,
		[Token(Token = "0x40042BA")]
		Katana,
		[Token(Token = "0x40042BB")]
		LightStick,
		[Token(Token = "0x40042BC")]
		Sickle,
		[Token(Token = "0x40042BD")]
		Hammer,
		[Token(Token = "0x40042BE")]
		ZombieFist,
		[Token(Token = "0x40042BF")]
		BalloonGenerator
	}

	[Token(Token = "0x200056C")]
	public enum LHBMOKPGGJN
	{
		[Token(Token = "0x40042C1")]
		DefaultRifle,
		[Token(Token = "0x40042C2")]
		MachineGun,
		[Token(Token = "0x40042C3")]
		ShieldGun,
		[Token(Token = "0x40042C4")]
		PrecisionRifle
	}

	[Token(Token = "0x200056D")]
	public enum GLDIHHOKIMA
	{
		[Token(Token = "0x40042C6")]
		DefaultMachineGun,
		[Token(Token = "0x40042C7")]
		Kord
	}

	[Token(Token = "0x200056E")]
	public enum BAHNHADPDEM
	{
		[Token(Token = "0x40042C9")]
		DefaultSniper,
		[Token(Token = "0x40042CA")]
		Kar98k
	}

	[Token(Token = "0x200056F")]
	public enum EMCPLHDHPHB
	{
		[Token(Token = "0x40042CC")]
		DefaultHandGun,
		[Token(Token = "0x40042CD")]
		M1873,
		[Token(Token = "0x40042CE")]
		Vector
	}

	[Token(Token = "0x2000570")]
	public enum HHMOMGDFCCJ
	{
		[Token(Token = "0x40042D0")]
		None = -1,
		[Token(Token = "0x40042D1")]
		Auto,
		[Token(Token = "0x40042D2")]
		Single,
		[Token(Token = "0x40042D3")]
		Three,
		[Token(Token = "0x40042D4")]
		Double
	}

	[Token(Token = "0x2000571")]
	public enum DHEPHFFMIFM
	{
		[Token(Token = "0x40042D6")]
		Invalid,
		[Token(Token = "0x40042D7")]
		MiniSentry,
		[Token(Token = "0x40042D8")]
		Dummy,
		[Token(Token = "0x40042D9")]
		MagneticField
	}

	[Token(Token = "0x2000572")]
	private enum ECICIGEBNHA
	{
		[Token(Token = "0x40042DB")]
		EFirstWeapon,
		[Token(Token = "0x40042DC")]
		ERightWeapon,
		[Token(Token = "0x40042DD")]
		EMaxWeapon
	}

	[Token(Token = "0x2000573")]
	private sealed class GDCIFIJOKAF
	{
		[Token(Token = "0x40042DE")]
		[FieldOffset(Offset = "0x8")]
		internal ResourceID BIBJANDPNFN;

		[Token(Token = "0x40042DF")]
		[FieldOffset(Offset = "0xC")]
		internal GPBDEDFKJNA GADHAMJEKIM;

		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x110ADF0", Offset = "0x110ADF0", VA = "0x110ADF0")]
		public GDCIFIJOKAF()
		{
		}
	}

	[Token(Token = "0x2000574")]
	private sealed class DAKFGNCOLML
	{
		[Token(Token = "0x40042E0")]
		[FieldOffset(Offset = "0x8")]
		internal float JOGHOHLEJFL;

		[Token(Token = "0x40042E1")]
		[FieldOffset(Offset = "0xC")]
		internal GDCIFIJOKAF AAHHNGKCADI;

		[Token(Token = "0x60020D7")]
		[Address(RVA = "0x110AC58", Offset = "0x110AC58", VA = "0x110AC58")]
		public DAKFGNCOLML()
		{
		}

		[Token(Token = "0x60020D8")]
		[Address(RVA = "0x110AC60", Offset = "0x110AC60", VA = "0x110AC60")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x40041F9")]
	[FieldOffset(Offset = "0x30")]
	private float _003CGDNGOIMOALI_003Ek__BackingField;

	[Token(Token = "0x40041FA")]
	[FieldOffset(Offset = "0x34")]
	private float _003CPLMCHNCIOMJ_003Ek__BackingField;

	[Token(Token = "0x40041FB")]
	[FieldOffset(Offset = "0x38")]
	protected float IEPMIOGIMFA;

	[Token(Token = "0x40041FC")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int FGNAAAHCCBD;

	[Token(Token = "0x40041FD")]
	[FieldOffset(Offset = "0x3C")]
	private CHEJCCHHDMH _003CNOAOCMKGLAH_003Ek__BackingField;

	[Token(Token = "0x40041FE")]
	[FieldOffset(Offset = "0x40")]
	protected BIEJHPCGHAJ FOBPFEDOBJL;

	[Token(Token = "0x40041FF")]
	[FieldOffset(Offset = "0x44")]
	protected OOIPMACFIFL LAEMLAPIAFD;

	[Token(Token = "0x4004200")]
	[FieldOffset(Offset = "0x48")]
	protected HPMMGJBOEFE MDIFBGCDNDP;

	[Token(Token = "0x4004201")]
	[FieldOffset(Offset = "0x4C")]
	protected FKPFNILEOHE EFGDILOKKDP;

	[Token(Token = "0x4004202")]
	[FieldOffset(Offset = "0x148")]
	protected NCALMHIGJKG JMFLBODJBFB;

	[Token(Token = "0x4004203")]
	[FieldOffset(Offset = "0x18C")]
	protected OMFGKENGNON FJDOKPOPCHI;

	[Token(Token = "0x4004204")]
	[FieldOffset(Offset = "0x1D0")]
	protected FHNPPADMBGF BHMDAABMFBB;

	[Token(Token = "0x4004205")]
	[FieldOffset(Offset = "0x1F8")]
	protected uint GNMHOINIMCD;

	[Token(Token = "0x4004206")]
	[FieldOffset(Offset = "0x1FC")]
	protected FJOCAIIBNLO HGAIGENIHFO;

	[Token(Token = "0x4004207")]
	[FieldOffset(Offset = "0x200")]
	private Dictionary<int, EEDCJKMIFIC> FMMGFALCPAE;

	[Token(Token = "0x4004208")]
	[FieldOffset(Offset = "0x204")]
	protected LLDPJHPAOCB FBFBKKOBBPG;

	[Token(Token = "0x4004209")]
	[FieldOffset(Offset = "0x208")]
	public bool NOKAIPLGFHI;

	[Token(Token = "0x400420A")]
	[FieldOffset(Offset = "0x20C")]
	protected float KELPHOCIDKB;

	[Token(Token = "0x400420B")]
	[FieldOffset(Offset = "0x210")]
	protected float APBBHOMMEHE;

	[Token(Token = "0x400420C")]
	[FieldOffset(Offset = "0x214")]
	private int HIAGOBKLGPF;

	[Token(Token = "0x400420D")]
	[FieldOffset(Offset = "0x218")]
	private float HAHJIMMLDDB;

	[Token(Token = "0x400420E")]
	[FieldOffset(Offset = "0x21C")]
	protected int PHHKPGLANJM;

	[Token(Token = "0x400420F")]
	[FieldOffset(Offset = "0x220")]
	public ResourceID KCLJCBNNNEP;

	[Token(Token = "0x4004210")]
	[FieldOffset(Offset = "0x224")]
	private float _003CEOEMHHJCDPK_003Ek__BackingField;

	[Token(Token = "0x4004211")]
	[FieldOffset(Offset = "0x228")]
	private float BHJBPCLKNIL;

	[Token(Token = "0x4004212")]
	[FieldOffset(Offset = "0x22C")]
	public bool FEIFHLBBMIF;

	[Token(Token = "0x4004213")]
	[FieldOffset(Offset = "0x22D")]
	public bool CNCOJBBGBCA;

	[Token(Token = "0x4004214")]
	[FieldOffset(Offset = "0x230")]
	private ResourceID IKGEINEEKAE;

	[Token(Token = "0x4004215")]
	[FieldOffset(Offset = "0x234")]
	private ResourceID LABDGKIEGEF;

	[Token(Token = "0x4004216")]
	[FieldOffset(Offset = "0x238")]
	protected ResourceID JBPDKHMOBEE;

	[Token(Token = "0x4004217")]
	[FieldOffset(Offset = "0x23C")]
	protected bool NKGDCOLECJJ;

	[Token(Token = "0x4004218")]
	[FieldOffset(Offset = "0x240")]
	private float KPFFHEACHLM;

	[Token(Token = "0x4004219")]
	private const float GICCOFKEDPH = 0.1f;

	[Token(Token = "0x400421A")]
	[FieldOffset(Offset = "0x244")]
	protected PFMPPELJECF HEFOLMHAFCF;

	[Token(Token = "0x400421B")]
	public const uint OBOHBJLPFKE = 5519u;

	[Token(Token = "0x400421C")]
	[FieldOffset(Offset = "0x248")]
	protected int CEDMAMLDDOM;

	[Token(Token = "0x400421D")]
	[FieldOffset(Offset = "0x24C")]
	protected float FLPGGBENDGA;

	[Token(Token = "0x400421E")]
	[FieldOffset(Offset = "0x250")]
	protected int KPKMAPIIKOL;

	[Token(Token = "0x400421F")]
	[FieldOffset(Offset = "0x254")]
	private float CGMBLIDAPNH;

	[Token(Token = "0x4004220")]
	[FieldOffset(Offset = "0x258")]
	private CBIKNJDAGLO PGCILIEEGGI;

	[Token(Token = "0x4004221")]
	[FieldOffset(Offset = "0x25C")]
	protected int FCCEBKAPLOB;

	[Token(Token = "0x4004222")]
	[FieldOffset(Offset = "0x260")]
	private List<ResourceID> OLNOBOFDKHN;

	[Token(Token = "0x4004223")]
	[FieldOffset(Offset = "0x264")]
	protected GameObject AAPAEAKGKNM;

	[Token(Token = "0x4004224")]
	[FieldOffset(Offset = "0x268")]
	protected uint HNOINOEMEIH;

	[Token(Token = "0x4004225")]
	[FieldOffset(Offset = "0x26C")]
	protected bool FLACPHBJIAH;

	[Token(Token = "0x4004226")]
	[FieldOffset(Offset = "0x26D")]
	protected bool AJMJEFKPLFL;

	[Token(Token = "0x4004227")]
	[FieldOffset(Offset = "0x26E")]
	protected bool MNEDKFHCCOA;

	[Token(Token = "0x4004228")]
	[FieldOffset(Offset = "0x270")]
	private PlayerType EBPFOJCDMOB;

	[Token(Token = "0x4004229")]
	[FieldOffset(Offset = "0x274")]
	private bool _003CHDCPAJCEMFE_003Ek__BackingField;

	[Token(Token = "0x400422A")]
	[FieldOffset(Offset = "0x278")]
	private float _003CBMNNBJLJNMI_003Ek__BackingField;

	[Token(Token = "0x400422B")]
	[FieldOffset(Offset = "0x27C")]
	private float _003COFDFOKNHCMH_003Ek__BackingField;

	[Token(Token = "0x400422C")]
	[FieldOffset(Offset = "0x280")]
	private float _003CKPJIPEKHPEP_003Ek__BackingField;

	[Token(Token = "0x400422D")]
	[FieldOffset(Offset = "0x284")]
	private int _003CBNHDHAHOPCN_003Ek__BackingField;

	[Token(Token = "0x400422E")]
	[FieldOffset(Offset = "0x288")]
	private bool KCKCNEFGEGL;

	[Token(Token = "0x400422F")]
	[FieldOffset(Offset = "0x289")]
	protected bool LAEHFGPNIOC;

	[Token(Token = "0x4004230")]
	[FieldOffset(Offset = "0x28C")]
	private int _003CINAHJCBAIAD_003Ek__BackingField;

	[Token(Token = "0x4004231")]
	[FieldOffset(Offset = "0x290")]
	private Dictionary<uint, float> BOECJAEHOMG;

	[Token(Token = "0x4004232")]
	[FieldOffset(Offset = "0x294")]
	protected TssSdtSmallFloat JFPOKGAIJHA;

	[Token(Token = "0x4004233")]
	[FieldOffset(Offset = "0x298")]
	protected int HFLPIMNMLAN;

	[Token(Token = "0x4004234")]
	[FieldOffset(Offset = "0x29C")]
	protected uint CJIPKMJAALM;

	[Token(Token = "0x4004235")]
	[FieldOffset(Offset = "0x2A0")]
	protected uint LNEIGBIKHGJ;

	[Token(Token = "0x4004236")]
	[FieldOffset(Offset = "0x2A4")]
	protected uint HAEAIGKLENL;

	[Token(Token = "0x4004237")]
	[FieldOffset(Offset = "0x2A8")]
	protected float EEJLKDDDJJD;

	[Token(Token = "0x4004238")]
	[FieldOffset(Offset = "0x2AC")]
	protected uint BPCCOKBMKHP;

	[Token(Token = "0x4004239")]
	[FieldOffset(Offset = "0x2B0")]
	protected Transform FPHKANPGEJE;

	[Token(Token = "0x400423A")]
	[FieldOffset(Offset = "0x2B4")]
	protected GameObject LOOKBCDIAEA;

	[Token(Token = "0x400423B")]
	[FieldOffset(Offset = "0x2B8")]
	protected GameObject KJNGHHOPBOG;

	[Token(Token = "0x400423C")]
	[FieldOffset(Offset = "0x2BC")]
	protected TweenProperty[] ILAEFECMEND;

	[Token(Token = "0x400423D")]
	[FieldOffset(Offset = "0x2C0")]
	protected TweenProperty[] NOODMGNKAGK;

	[Token(Token = "0x400423E")]
	[FieldOffset(Offset = "0x2C4")]
	protected Transform CLPIAHJHFFB;

	[Token(Token = "0x400423F")]
	[FieldOffset(Offset = "0x2C8")]
	protected Transform LHCJGAINHIM;

	[Token(Token = "0x4004240")]
	[FieldOffset(Offset = "0x2CC")]
	protected Animator BACCCBKOBPE;

	[Token(Token = "0x4004241")]
	[FieldOffset(Offset = "0x2D0")]
	protected Animator GOENHIJCCLI;

	[Token(Token = "0x4004242")]
	[FieldOffset(Offset = "0x2D4")]
	protected RuntimeAnimatorController LENLPLLAJFJ;

	[Token(Token = "0x4004243")]
	[FieldOffset(Offset = "0x2D8")]
	protected WeaponAnimComponent LGMDNHIKIOK;

	[Token(Token = "0x4004244")]
	[FieldOffset(Offset = "0x2DC")]
	protected uint ABJILHPPBAC;

	[Token(Token = "0x4004245")]
	[FieldOffset(Offset = "0x2E0")]
	protected uint CBLNKJPHLDL;

	[Token(Token = "0x4004246")]
	[FieldOffset(Offset = "0x2E4")]
	protected uint CODECJJKBGG;

	[Token(Token = "0x4004247")]
	[FieldOffset(Offset = "0x2E8")]
	protected uint KBHCLGJFAAJ;

	[Token(Token = "0x4004248")]
	[FieldOffset(Offset = "0x2EC")]
	protected uint KJNJMDFGDLA;

	[Token(Token = "0x4004249")]
	[FieldOffset(Offset = "0x2F0")]
	protected uint EBBBPIIHLIJ;

	[Token(Token = "0x400424A")]
	[FieldOffset(Offset = "0x2F4")]
	protected uint DCGKDCGNBOA;

	[Token(Token = "0x400424B")]
	[FieldOffset(Offset = "0x2F8")]
	protected uint ILJACKBLJMB;

	[Token(Token = "0x400424C")]
	[FieldOffset(Offset = "0x2FC")]
	protected uint PFBOPJMOELJ;

	[Token(Token = "0x400424D")]
	[FieldOffset(Offset = "0x300")]
	protected uint AKOCKJIOCEM;

	[Token(Token = "0x400424E")]
	[FieldOffset(Offset = "0x304")]
	protected uint CMJJLNNAFEO;

	[Token(Token = "0x400424F")]
	[FieldOffset(Offset = "0x308")]
	protected uint BAFIGFOGMEA;

	[Token(Token = "0x4004250")]
	[FieldOffset(Offset = "0x30C")]
	protected uint MGHEHOOLNGN;

	[Token(Token = "0x4004251")]
	[FieldOffset(Offset = "0x310")]
	protected uint BIJNOKJEAAD;

	[Token(Token = "0x4004252")]
	[FieldOffset(Offset = "0x314")]
	protected BitArrayBoolean ALOGOHNIKGC;

	[Token(Token = "0x4004253")]
	[FieldOffset(Offset = "0x318")]
	protected ResourceID IHJELPCBKMA;

	[Token(Token = "0x4004254")]
	[FieldOffset(Offset = "0x31C")]
	protected GameObject LAJJJCJHDGL;

	[Token(Token = "0x4004255")]
	[FieldOffset(Offset = "0x320")]
	protected ParticleSystem LGDPBGEIBDJ;

	[Token(Token = "0x4004256")]
	[FieldOffset(Offset = "0x324")]
	private GameObject MGPLMPBDMLN;

	[Token(Token = "0x4004257")]
	[FieldOffset(Offset = "0x328")]
	private ParticleSystem BOBFAEAKLEK;

	[Token(Token = "0x4004258")]
	private const string GCDDKMFODAC = "bone_RightArm";

	[Token(Token = "0x4004259")]
	private const string DCAIABCAEMJ = "bone_LeftArm";

	[Token(Token = "0x400425A")]
	[FieldOffset(Offset = "0x32C")]
	private ResourceID FBMFEGPBKFN;

	[Token(Token = "0x400425B")]
	[FieldOffset(Offset = "0x330")]
	private GameObject HFMMJNGFGGO;

	[Token(Token = "0x400425C")]
	[FieldOffset(Offset = "0x334")]
	private ParticleSystem FPIKHCJEAHC;

	[Token(Token = "0x400425D")]
	[FieldOffset(Offset = "0x338")]
	protected uint[] BHBHOCEGOBB;

	[Token(Token = "0x400425E")]
	[FieldOffset(Offset = "0x33C")]
	private uint[] ECCADOHHFCE;

	[Token(Token = "0x400425F")]
	[FieldOffset(Offset = "0x340")]
	private Object[] CIMCCILIBPK;

	[Token(Token = "0x4004260")]
	[FieldOffset(Offset = "0x344")]
	private Object[] BPJNNMCMMGP;

	[Token(Token = "0x4004261")]
	[FieldOffset(Offset = "0x348")]
	public bool FCMADFPDPLF;

	[Token(Token = "0x4004262")]
	[FieldOffset(Offset = "0x349")]
	private bool ACCNHIIBHKM;

	[Token(Token = "0x4004263")]
	private const float LNBFIIAGCDC = 0.5f;

	[Token(Token = "0x4004264")]
	[FieldOffset(Offset = "0x34A")]
	private bool EMBPNIGDHJD;

	[Token(Token = "0x4004265")]
	[FieldOffset(Offset = "0x34C")]
	protected GameObject FIGDDGKJIJN;

	[Token(Token = "0x4004266")]
	[FieldOffset(Offset = "0x350")]
	protected GameObject PJLIMACFGJG;

	[Token(Token = "0x4004267")]
	[FieldOffset(Offset = "0x354")]
	protected GameObject COPNKJNKMBI;

	[Token(Token = "0x4004268")]
	[FieldOffset(Offset = "0x358")]
	protected bool PLHDPJKGLAO;

	[Token(Token = "0x4004269")]
	[FieldOffset(Offset = "0x359")]
	protected bool OKKJNPGJJOH;

	[Token(Token = "0x400426A")]
	[FieldOffset(Offset = "0x35A")]
	private bool GAFGBLFCKAF;

	[Token(Token = "0x400426B")]
	[FieldOffset(Offset = "0x35B")]
	private bool IOKEAMKJOMM;

	[Token(Token = "0x400426C")]
	[FieldOffset(Offset = "0x35C")]
	private float JKAAFGDOAHH;

	[Token(Token = "0x400426D")]
	[FieldOffset(Offset = "0x360")]
	private PFMPPELJECF NOCGIMNCJNG;

	[Token(Token = "0x400426E")]
	[FieldOffset(Offset = "0x364")]
	private PFMPPELJECF JBJNMOMCHJM;

	[Token(Token = "0x400426F")]
	[FieldOffset(Offset = "0x368")]
	private List<float> PIGOIHAOJGH;

	[Token(Token = "0x4004270")]
	[FieldOffset(Offset = "0x36C")]
	private float[] DPBGHMIEOON;

	[Token(Token = "0x1700028B")]
	public float IMKPOKLGEAH
	{
		[Token(Token = "0x6001F6E")]
		[Address(RVA = "0x10972B8", Offset = "0x10972B8", VA = "0x10972B8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001F6F")]
		[Address(RVA = "0x10972C0", Offset = "0x10972C0", VA = "0x10972C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700028C")]
	public float GLLKAIHFIAJ
	{
		[Token(Token = "0x6001F70")]
		[Address(RVA = "0x10972C8", Offset = "0x10972C8", VA = "0x10972C8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001F71")]
		[Address(RVA = "0x10972D0", Offset = "0x10972D0", VA = "0x10972D0")]
		set
		{
		}
	}

	[Token(Token = "0x1700028D")]
	public CHEJCCHHDMH DKNPGJAKMPB
	{
		[Token(Token = "0x6001F72")]
		[Address(RVA = "0x10972D8", Offset = "0x10972D8", VA = "0x10972D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F73")]
		[Address(RVA = "0x10972E0", Offset = "0x10972E0", VA = "0x10972E0")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700028E")]
	public uint IAENCEKHCHJ
	{
		[Token(Token = "0x6001F74")]
		[Address(RVA = "0x10972E8", Offset = "0x10972E8", VA = "0x10972E8")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700028F")]
	public float NJOPAJOCGCA
	{
		[Token(Token = "0x6001F76")]
		[Address(RVA = "0x1097348", Offset = "0x1097348", VA = "0x1097348")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001F75")]
		[Address(RVA = "0x1097340", Offset = "0x1097340", VA = "0x1097340")]
		private set
		{
		}
	}

	[Token(Token = "0x17000290")]
	public CBIKNJDAGLO MODHNHFICOO
	{
		[Token(Token = "0x6001F77")]
		[Address(RVA = "0x1097350", Offset = "0x1097350", VA = "0x1097350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000291")]
	public bool LLCIBIJKLAO
	{
		[Token(Token = "0x6001F78")]
		[Address(RVA = "0x10973A8", Offset = "0x10973A8", VA = "0x10973A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000292")]
	public Dictionary<int, EEDCJKMIFIC> AOBKOCLMGBJ
	{
		[Token(Token = "0x6001F7A")]
		[Address(RVA = "0x109750C", Offset = "0x109750C", VA = "0x109750C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000293")]
	public virtual float NKGDADJJLAC
	{
		[Token(Token = "0x6001F80")]
		[Address(RVA = "0x10977C0", Offset = "0x10977C0", VA = "0x10977C0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000294")]
	public float KKNCCPFCEFD
	{
		[Token(Token = "0x6001F83")]
		[Address(RVA = "0x10979E4", Offset = "0x10979E4", VA = "0x10979E4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000295")]
	public virtual bool OLNKGOGHBNB
	{
		[Token(Token = "0x6001F8E")]
		[Address(RVA = "0x1097F10", Offset = "0x1097F10", VA = "0x1097F10", Slot = "31")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001F8F")]
		[Address(RVA = "0x1097F18", Offset = "0x1097F18", VA = "0x1097F18", Slot = "32")]
		set
		{
		}
	}

	[Token(Token = "0x17000296")]
	public float PAPNGKBBGEC
	{
		[Token(Token = "0x6001F90")]
		[Address(RVA = "0x1097F20", Offset = "0x1097F20", VA = "0x1097F20")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001F91")]
		[Address(RVA = "0x1097F28", Offset = "0x1097F28", VA = "0x1097F28")]
		set
		{
		}
	}

	[Token(Token = "0x17000297")]
	public float GKJDAHJJOKG
	{
		[Token(Token = "0x6001F92")]
		[Address(RVA = "0x1097F30", Offset = "0x1097F30", VA = "0x1097F30")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001F93")]
		[Address(RVA = "0x1097F38", Offset = "0x1097F38", VA = "0x1097F38")]
		set
		{
		}
	}

	[Token(Token = "0x17000298")]
	public float IKFJMGLFKLB
	{
		[Token(Token = "0x6001F94")]
		[Address(RVA = "0x1097F40", Offset = "0x1097F40", VA = "0x1097F40")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001F95")]
		[Address(RVA = "0x1097F48", Offset = "0x1097F48", VA = "0x1097F48")]
		set
		{
		}
	}

	[Token(Token = "0x17000299")]
	public int MEOFEFPOBKN
	{
		[Token(Token = "0x6001F96")]
		[Address(RVA = "0x1097F50", Offset = "0x1097F50", VA = "0x1097F50")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001F97")]
		[Address(RVA = "0x1097F58", Offset = "0x1097F58", VA = "0x1097F58")]
		set
		{
		}
	}

	[Token(Token = "0x1700029A")]
	public bool CFICBIHIIEM
	{
		[Token(Token = "0x6001F98")]
		[Address(RVA = "0x1097884", Offset = "0x1097884", VA = "0x1097884")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001F99")]
		[Address(RVA = "0x1097F60", Offset = "0x1097F60", VA = "0x1097F60")]
		set
		{
		}
	}

	[Token(Token = "0x1700029B")]
	public bool BNOMHEOMOGD
	{
		[Token(Token = "0x6001F9A")]
		[Address(RVA = "0x10978DC", Offset = "0x10978DC", VA = "0x10978DC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001F9B")]
		[Address(RVA = "0x109807C", Offset = "0x109807C", VA = "0x109807C")]
		set
		{
		}
	}

	[Token(Token = "0x1700029C")]
	public float HCIJGAMEELO
	{
		[Token(Token = "0x6001FA0")]
		[Address(RVA = "0x1098318", Offset = "0x1098318", VA = "0x1098318")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700029D")]
	public int OKGOEIBGNIJ
	{
		[Token(Token = "0x6001FA1")]
		[Address(RVA = "0x1098370", Offset = "0x1098370", VA = "0x1098370")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700029E")]
	public int AGNIIOJBJKM
	{
		[Token(Token = "0x6001FA2")]
		[Address(RVA = "0x10983C8", Offset = "0x10983C8", VA = "0x10983C8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700029F")]
	public bool KLBPLKKBPOJ
	{
		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0x1098420", Offset = "0x1098420", VA = "0x1098420")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002A0")]
	public int GBBKMMHOHPK
	{
		[Token(Token = "0x6001FA4")]
		[Address(RVA = "0x1098478", Offset = "0x1098478", VA = "0x1098478")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001FA5")]
		[Address(RVA = "0x1098480", Offset = "0x1098480", VA = "0x1098480")]
		set
		{
		}
	}

	[Token(Token = "0x170002A1")]
	public virtual int KECCLKDLIIB
	{
		[Token(Token = "0x6001FA6")]
		[Address(RVA = "0x1098488", Offset = "0x1098488", VA = "0x1098488", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002A2")]
	public virtual int CBEKIDEFKFE
	{
		[Token(Token = "0x6001FA8")]
		[Address(RVA = "0x1098698", Offset = "0x1098698", VA = "0x1098698", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002A3")]
	public virtual bool FAMBENILEJF
	{
		[Token(Token = "0x6001FAB")]
		[Address(RVA = "0x10987D8", Offset = "0x10987D8", VA = "0x10987D8", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002A4")]
	public virtual bool AEGPIPGMHKA
	{
		[Token(Token = "0x6001FAC")]
		[Address(RVA = "0x1098830", Offset = "0x1098830", VA = "0x1098830", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002A5")]
	public float LGJHGKLFGJB
	{
		[Token(Token = "0x6001FB6")]
		[Address(RVA = "0x1098A1C", Offset = "0x1098A1C", VA = "0x1098A1C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002A6")]
	public float DNELOGOBMNF
	{
		[Token(Token = "0x6001FB8")]
		[Address(RVA = "0x1098FC4", Offset = "0x1098FC4", VA = "0x1098FC4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002A7")]
	public float MBGGGOPNJFB
	{
		[Token(Token = "0x6001FB9")]
		[Address(RVA = "0x109901C", Offset = "0x109901C", VA = "0x109901C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002A8")]
	public float DCDENPECJNE
	{
		[Token(Token = "0x6001FBA")]
		[Address(RVA = "0x1099074", Offset = "0x1099074", VA = "0x1099074")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002A9")]
	public float PEANLLEJEMP
	{
		[Token(Token = "0x6001FBB")]
		[Address(RVA = "0x10990CC", Offset = "0x10990CC", VA = "0x10990CC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002AA")]
	public float MEIHFCGIPMF
	{
		[Token(Token = "0x6001FBC")]
		[Address(RVA = "0x10992BC", Offset = "0x10992BC", VA = "0x10992BC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002AB")]
	public float PKMAHBOOLFO
	{
		[Token(Token = "0x6001FBD")]
		[Address(RVA = "0x1099380", Offset = "0x1099380", VA = "0x1099380")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002AC")]
	public virtual int LOAPCEBABLJ
	{
		[Token(Token = "0x6001FBE")]
		[Address(RVA = "0x1099570", Offset = "0x1099570", VA = "0x1099570", Slot = "46")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002AD")]
	public virtual ENBHOKKHLPG BLNIBIIOMJH
	{
		[Token(Token = "0x6001FBF")]
		[Address(RVA = "0x10996E0", Offset = "0x10996E0", VA = "0x10996E0", Slot = "47")]
		get
		{
			return default(ENBHOKKHLPG);
		}
	}

	[Token(Token = "0x170002AE")]
	public int IHNCAADOAAE
	{
		[Token(Token = "0x6001FC0")]
		[Address(RVA = "0x109984C", Offset = "0x109984C", VA = "0x109984C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002AF")]
	public int NGHKLAODJMD
	{
		[Token(Token = "0x6001FC1")]
		[Address(RVA = "0x10998E8", Offset = "0x10998E8", VA = "0x10998E8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002B0")]
	public int KMMEMPAHNMJ
	{
		[Token(Token = "0x6001FC4")]
		[Address(RVA = "0x1099A78", Offset = "0x1099A78", VA = "0x1099A78")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002B1")]
	public float JDDFDKOKKBP
	{
		[Token(Token = "0x6001FC5")]
		[Address(RVA = "0x1099B58", Offset = "0x1099B58", VA = "0x1099B58")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002B2")]
	public float KKKNAFFKHII
	{
		[Token(Token = "0x6001FC6")]
		[Address(RVA = "0x1099C5C", Offset = "0x1099C5C", VA = "0x1099C5C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002B3")]
	public float JEDNPECNGCG
	{
		[Token(Token = "0x6001FC7")]
		[Address(RVA = "0x1099CF0", Offset = "0x1099CF0", VA = "0x1099CF0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002B4")]
	public float AHFNKDJFBEA
	{
		[Token(Token = "0x6001FC8")]
		[Address(RVA = "0x1099D98", Offset = "0x1099D98", VA = "0x1099D98")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002B5")]
	public float NAMEJMCMAGF
	{
		[Token(Token = "0x6001FC9")]
		[Address(RVA = "0x1099E24", Offset = "0x1099E24", VA = "0x1099E24")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002B6")]
	public int CKNJFGFKONH
	{
		[Token(Token = "0x6001FCA")]
		[Address(RVA = "0x1099ECC", Offset = "0x1099ECC", VA = "0x1099ECC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002B7")]
	public float EFDFEEHCNMP
	{
		[Token(Token = "0x6001FCB")]
		[Address(RVA = "0x1099F54", Offset = "0x1099F54", VA = "0x1099F54")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002B8")]
	public float BJNHKLAKOJA
	{
		[Token(Token = "0x6001FCC")]
		[Address(RVA = "0x1099FD4", Offset = "0x1099FD4", VA = "0x1099FD4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002B9")]
	public float KKBCCLCJAGA
	{
		[Token(Token = "0x6001FCD")]
		[Address(RVA = "0x109A054", Offset = "0x109A054", VA = "0x109A054")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002BA")]
	public virtual float HEDPGAJMKPI
	{
		[Token(Token = "0x6001FCF")]
		[Address(RVA = "0x109A254", Offset = "0x109A254", VA = "0x109A254", Slot = "51")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002BB")]
	public virtual float LCCKNAFOGCO
	{
		[Token(Token = "0x6001FD0")]
		[Address(RVA = "0x109A2FC", Offset = "0x109A2FC", VA = "0x109A2FC", Slot = "52")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002BC")]
	public string JACCFBNIPAE
	{
		[Token(Token = "0x6001FD1")]
		[Address(RVA = "0x109A390", Offset = "0x109A390", VA = "0x109A390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BD")]
	public virtual bool FFEHMNKBCAF
	{
		[Token(Token = "0x6001FD2")]
		[Address(RVA = "0x109A414", Offset = "0x109A414", VA = "0x109A414", Slot = "53")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002BE")]
	public virtual bool AEMDKMIHDJK
	{
		[Token(Token = "0x6001FD3")]
		[Address(RVA = "0x109A598", Offset = "0x109A598", VA = "0x109A598", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002BF")]
	public virtual bool MGHGGCHIFNF
	{
		[Token(Token = "0x6001FD4")]
		[Address(RVA = "0x109A624", Offset = "0x109A624", VA = "0x109A624", Slot = "55")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002C0")]
	public virtual bool KBNBCBHOHBP
	{
		[Token(Token = "0x6001FD5")]
		[Address(RVA = "0x109A67C", Offset = "0x109A67C", VA = "0x109A67C", Slot = "56")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002C1")]
	public bool PGIOEMJGFDF
	{
		[Token(Token = "0x6001FD6")]
		[Address(RVA = "0x109A6EC", Offset = "0x109A6EC", VA = "0x109A6EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002C2")]
	public bool JABNGFGIHFF
	{
		[Token(Token = "0x6001FDB")]
		[Address(RVA = "0x109ABE8", Offset = "0x109ABE8", VA = "0x109ABE8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002C3")]
	public bool BICDHDAEKAK
	{
		[Token(Token = "0x6001FDE")]
		[Address(RVA = "0x109AD4C", Offset = "0x109AD4C", VA = "0x109AD4C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002C4")]
	public bool HCHAMBCGIEC
	{
		[Token(Token = "0x6001FDF")]
		[Address(RVA = "0x109AE2C", Offset = "0x109AE2C", VA = "0x109AE2C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002C5")]
	public int HCODPFNEDDE
	{
		[Token(Token = "0x6001FE0")]
		[Address(RVA = "0x10982C0", Offset = "0x10982C0", VA = "0x10982C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002C6")]
	public GameObject PEOEHGCJCNN
	{
		[Token(Token = "0x6002014")]
		[Address(RVA = "0x10A5954", Offset = "0x10A5954", VA = "0x10A5954")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C7")]
	public RuntimeAnimatorController DNECBJCFKDC
	{
		[Token(Token = "0x6002015")]
		[Address(RVA = "0x10A59AC", Offset = "0x10A59AC", VA = "0x10A59AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C8")]
	public virtual bool HNFJGOBEMKM
	{
		[Token(Token = "0x600208C")]
		[Address(RVA = "0x10B961C", Offset = "0x10B961C", VA = "0x10B961C", Slot = "150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600208D")]
		[Address(RVA = "0x10B9674", Offset = "0x10B9674", VA = "0x10B9674", Slot = "151")]
		set
		{
		}
	}

	[Token(Token = "0x170002C9")]
	public float FAOLHOCFHAK
	{
		[Token(Token = "0x600208F")]
		[Address(RVA = "0x10B9CD0", Offset = "0x10B9CD0", VA = "0x10B9CD0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002CA")]
	public bool GEGOCLDJILI
	{
		[Token(Token = "0x6002090")]
		[Address(RVA = "0x10B9D28", Offset = "0x10B9D28", VA = "0x10B9D28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002CB")]
	public PFMPPELJECF KOJCFODCFLN
	{
		[Token(Token = "0x60020A5")]
		[Address(RVA = "0x10BB990", Offset = "0x10BB990", VA = "0x10BB990")]
		get
		{
			return null;
		}
		[Token(Token = "0x60020A6")]
		[Address(RVA = "0x10BB2F0", Offset = "0x10BB2F0", VA = "0x10BB2F0")]
		set
		{
		}
	}

	[Token(Token = "0x6001F6D")]
	[Address(RVA = "0x1096E90", Offset = "0x1096E90", VA = "0x1096E90")]
	public GPBDEDFKJNA()
	{
	}

	[Token(Token = "0x6001F79")]
	[Address(RVA = "0x1097400", Offset = "0x1097400", VA = "0x1097400", Slot = "28")]
	public virtual void PKLCHEOCBIF(bool JOGHOHLEJFL)
	{
	}

	[Token(Token = "0x6001F7B")]
	[Address(RVA = "0x1097564", Offset = "0x1097564", VA = "0x1097564")]
	public OOIPMACFIFL FCGBLGADKEB()
	{
		return null;
	}

	[Token(Token = "0x6001F7C")]
	[Address(RVA = "0x10975BC", Offset = "0x10975BC", VA = "0x10975BC")]
	public ResourceID FCOLBLGOIEA()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6001F7D")]
	[Address(RVA = "0x109762C", Offset = "0x109762C", VA = "0x109762C")]
	public JJLGMMCALJD ADBBMDMEFNO()
	{
		return default(JJLGMMCALJD);
	}

	[Token(Token = "0x6001F7E")]
	[Address(RVA = "0x1097698", Offset = "0x1097698", VA = "0x1097698")]
	public bool PEBMIGCOPBB()
	{
		return default(bool);
	}

	[Token(Token = "0x6001F7F")]
	[Address(RVA = "0x1097750", Offset = "0x1097750", VA = "0x1097750")]
	public FKPFNILEOHE CJOFCDDJJEJ()
	{
		return default(FKPFNILEOHE);
	}

	[Token(Token = "0x6001F81")]
	[Address(RVA = "0x1097934", Offset = "0x1097934", VA = "0x1097934", Slot = "30")]
	protected virtual float GFACHJDEJBK()
	{
		return default(float);
	}

	[Token(Token = "0x6001F82")]
	[Address(RVA = "0x109798C", Offset = "0x109798C", VA = "0x109798C")]
	public float BDBEPOHOGGO()
	{
		return default(float);
	}

	[Token(Token = "0x6001F84")]
	[Address(RVA = "0x1097A48", Offset = "0x1097A48", VA = "0x1097A48")]
	public float BNGBKMOLMCP()
	{
		return default(float);
	}

	[Token(Token = "0x6001F85")]
	[Address(RVA = "0x1097AA0", Offset = "0x1097AA0", VA = "0x1097AA0")]
	public void HBFKCGECPJN(float LBMGGMBKAEH)
	{
	}

	[Token(Token = "0x6001F86")]
	[Address(RVA = "0x1097B10", Offset = "0x1097B10", VA = "0x1097B10")]
	public float IIADLDHAPAD()
	{
		return default(float);
	}

	[Token(Token = "0x6001F87")]
	[Address(RVA = "0x1097B68", Offset = "0x1097B68", VA = "0x1097B68")]
	public void OLANEHOECFH(float LBMGGMBKAEH)
	{
	}

	[Token(Token = "0x6001F88")]
	[Address(RVA = "0x1097BD8", Offset = "0x1097BD8", VA = "0x1097BD8")]
	public int NMGKCKFGBAH()
	{
		return default(int);
	}

	[Token(Token = "0x6001F89")]
	[Address(RVA = "0x1097C30", Offset = "0x1097C30", VA = "0x1097C30")]
	public void FNDJODCEFPM(int LBMGGMBKAEH, float EGHHKPCJNCH = 0f)
	{
	}

	[Token(Token = "0x6001F8A")]
	[Address(RVA = "0x1097CBC", Offset = "0x1097CBC", VA = "0x1097CBC")]
	public float IPGHNOBAMMD()
	{
		return default(float);
	}

	[Token(Token = "0x6001F8B")]
	[Address(RVA = "0x1097D2C", Offset = "0x1097D2C", VA = "0x1097D2C")]
	public int JPLCDFOPFEP(float LCMKCHOILIB)
	{
		return default(int);
	}

	[Token(Token = "0x6001F8C")]
	[Address(RVA = "0x1097E44", Offset = "0x1097E44", VA = "0x1097E44")]
	public int NMPLAAGMFOF()
	{
		return default(int);
	}

	[Token(Token = "0x6001F8D")]
	[Address(RVA = "0x1097E9C", Offset = "0x1097E9C", VA = "0x1097E9C")]
	public FHNPPADMBGF NKEKPIHDAEN()
	{
		return default(FHNPPADMBGF);
	}

	[Token(Token = "0x6001F9C")]
	[Address(RVA = "0x1098108", Offset = "0x1098108", VA = "0x1098108", Slot = "33")]
	protected virtual void PGFCIECDLIG()
	{
	}

	[Token(Token = "0x6001F9D")]
	[Address(RVA = "0x109815C", Offset = "0x109815C", VA = "0x109815C", Slot = "34")]
	public virtual void APBPBPBHMOP()
	{
	}

	[Token(Token = "0x6001F9E")]
	[Address(RVA = "0x10981B0", Offset = "0x10981B0", VA = "0x10981B0")]
	public int DKJKJBFAONH()
	{
		return default(int);
	}

	[Token(Token = "0x6001F9F")]
	[Address(RVA = "0x1098238", Offset = "0x1098238", VA = "0x1098238")]
	public bool AELMGPEAGHJ()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FA7")]
	[Address(RVA = "0x109861C", Offset = "0x109861C", VA = "0x109861C")]
	public uint EIDHEOFDEEM()
	{
		return default(uint);
	}

	[Token(Token = "0x6001FA9")]
	[Address(RVA = "0x109870C", Offset = "0x109870C", VA = "0x109870C", Slot = "37")]
	public virtual bool ENDJIHKOADN()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FAA")]
	[Address(RVA = "0x1098778", Offset = "0x1098778", VA = "0x1098778", Slot = "38")]
	public virtual void DOCDBLFANEG(int GBDCICHCNFC)
	{
	}

	[Token(Token = "0x6001FAD")]
	[Address(RVA = "0x109889C", Offset = "0x109889C", VA = "0x109889C")]
	public float HJIJLFAAANE(float NFPILHKMBHL)
	{
		return default(float);
	}

	[Token(Token = "0x6001FAE")]
	[Address(RVA = "0x1098ACC", Offset = "0x1098ACC", VA = "0x1098ACC")]
	public bool KMEBJDPCJDN()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FAF")]
	[Address(RVA = "0x1098B50", Offset = "0x1098B50", VA = "0x1098B50")]
	public float MDOGICPKBLN()
	{
		return default(float);
	}

	[Token(Token = "0x6001FB0")]
	[Address(RVA = "0x1098BD4", Offset = "0x1098BD4", VA = "0x1098BD4", Slot = "41")]
	public virtual float DGPMPMPIGDD(bool NFJEOGPNFLE)
	{
		return default(float);
	}

	[Token(Token = "0x6001FB1")]
	[Address(RVA = "0x1098C94", Offset = "0x1098C94", VA = "0x1098C94", Slot = "42")]
	public virtual float GOGJIEGNMEN(bool NFJEOGPNFLE, bool DDPIGPHFNOO)
	{
		return default(float);
	}

	[Token(Token = "0x6001FB2")]
	[Address(RVA = "0x1098D70", Offset = "0x1098D70", VA = "0x1098D70", Slot = "43")]
	public virtual float IDCLBLGKAAI(bool NFJEOGPNFLE, bool DDPIGPHFNOO)
	{
		return default(float);
	}

	[Token(Token = "0x6001FB3")]
	[Address(RVA = "0x1098E1C", Offset = "0x1098E1C", VA = "0x1098E1C", Slot = "44")]
	public virtual bool CPFLPNFBBFN()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FB4")]
	[Address(RVA = "0x1098E98", Offset = "0x1098E98", VA = "0x1098E98")]
	public bool LLJBFAAFCGF()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FB5")]
	[Address(RVA = "0x1098F08", Offset = "0x1098F08", VA = "0x1098F08", Slot = "45")]
	public virtual bool ABLAMBANKNM()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FB7")]
	[Address(RVA = "0x1098F60", Offset = "0x1098F60", VA = "0x1098F60")]
	public void JDJLMFGEPIM(float BCFJJHGGBNL)
	{
	}

	[Token(Token = "0x6001FC2")]
	[Address(RVA = "0x10999C8", Offset = "0x10999C8", VA = "0x10999C8", Slot = "48")]
	protected virtual bool CIENHDLGFFI()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FC3")]
	[Address(RVA = "0x1099A20", Offset = "0x1099A20", VA = "0x1099A20", Slot = "49")]
	protected virtual bool APEPALPEAHK()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FCE")]
	[Address(RVA = "0x109A0D4", Offset = "0x109A0D4", VA = "0x109A0D4", Slot = "50")]
	public virtual float DNGONFLICGC()
	{
		return default(float);
	}

	[Token(Token = "0x6001FD7")]
	[Address(RVA = "0x109A8D8", Offset = "0x109A8D8", VA = "0x109A8D8")]
	public bool LGEAKEGJOKD()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FD8")]
	[Address(RVA = "0x109A954", Offset = "0x109A954", VA = "0x109A954", Slot = "57")]
	public virtual bool NNHKFFFNMGF()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FD9")]
	[Address(RVA = "0x109A9EC", Offset = "0x109A9EC", VA = "0x109A9EC", Slot = "58")]
	public virtual bool PBAFLGKBKPF()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FDA")]
	[Address(RVA = "0x109AB4C", Offset = "0x109AB4C", VA = "0x109AB4C")]
	public bool DPHAKDLMPEC()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FDC")]
	[Address(RVA = "0x109AC64", Offset = "0x109AC64", VA = "0x109AC64")]
	public static bool GNAGIIEKCHC(ENBHOKKHLPG PMGBACFJIHO)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FDD")]
	[Address(RVA = "0x109ACD8", Offset = "0x109ACD8", VA = "0x109ACD8")]
	public static bool EIGPACHKPON(ENBHOKKHLPG PMGBACFJIHO)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FE1")]
	[Address(RVA = "0x109AEE8", Offset = "0x109AEE8", VA = "0x109AEE8", Slot = "6")]
	public override bool APJHPGBALDJ(Player FIMNKGABILM, uint LLONJJJJLFL, uint BLEAICPKPGL, LGCOKIBHIJL CFKPHKPIOMH, object[] JCJIJEGNBOK)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FE2")]
	[Address(RVA = "0x109B0E8", Offset = "0x109B0E8", VA = "0x109B0E8")]
	protected void JMONNPCEDJA()
	{
	}

	[Token(Token = "0x6001FE3")]
	[Address(RVA = "0x109B610", Offset = "0x109B610", VA = "0x109B610")]
	private void HCBJONGLJGH(uint LPFMNBCHJPE, bool BBFAHFFADIC, Object ECINOMEHBKA)
	{
	}

	[Token(Token = "0x6001FE4")]
	[Address(RVA = "0x109C0D4", Offset = "0x109C0D4", VA = "0x109C0D4")]
	private void OAHEICGGCAM(int HBKEFIALNGI)
	{
	}

	[Token(Token = "0x6001FE5")]
	[Address(RVA = "0x109C510", Offset = "0x109C510", VA = "0x109C510")]
	protected void EPCGKEIPCPB(GameObject NCKCFMMMAMA, GameObject CAGEPIDNLOB)
	{
	}

	[Token(Token = "0x6001FE6")]
	[Address(RVA = "0x109C7A8", Offset = "0x109C7A8", VA = "0x109C7A8", Slot = "59")]
	protected virtual void AAKGDEEOLLO()
	{
	}

	[Token(Token = "0x6001FE7")]
	[Address(RVA = "0x109BB08", Offset = "0x109BB08", VA = "0x109BB08")]
	protected void LBPIFEDNHNB()
	{
	}

	[Token(Token = "0x6001FE8")]
	[Address(RVA = "0x109D670", Offset = "0x109D670", VA = "0x109D670")]
	private bool HGANHIHIIMA()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FE9")]
	[Address(RVA = "0x109D714", Offset = "0x109D714", VA = "0x109D714", Slot = "60")]
	protected virtual void HKLDFHCLLID(GameObject MCOKPAHIBLN, bool HOMIGDEOPDN)
	{
	}

	[Token(Token = "0x6001FEA")]
	[Address(RVA = "0x109DC68", Offset = "0x109DC68", VA = "0x109DC68", Slot = "7")]
	public override bool BIDNGOEABGM()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FEB")]
	[Address(RVA = "0x109DD3C", Offset = "0x109DD3C", VA = "0x109DD3C")]
	protected bool GIJMDOCLKKM(ref GameObject ENOHHPLCIEI, bool GKPGHKNIHIE = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FEC")]
	[Address(RVA = "0x109EC44", Offset = "0x109EC44", VA = "0x109EC44")]
	protected ResourceID EEGGHBFHKPH(MANEMECPKIO CLIDKEHJBNO)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6001FED")]
	[Address(RVA = "0x109ECF8", Offset = "0x109ECF8", VA = "0x109ECF8")]
	protected ResourceID NDDBNLAAKIC(MANEMECPKIO CLIDKEHJBNO)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6001FEE")]
	[Address(RVA = "0x109EE10", Offset = "0x109EE10", VA = "0x109EE10", Slot = "8")]
	public override bool IALAILMPPHC()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FEF")]
	[Address(RVA = "0x109F464", Offset = "0x109F464", VA = "0x109F464", Slot = "61")]
	protected virtual RuntimeAnimatorController BCFAHEADPFF()
	{
		return null;
	}

	[Token(Token = "0x6001FF0")]
	[Address(RVA = "0x109FD04", Offset = "0x109FD04", VA = "0x109FD04")]
	public RuntimeAnimatorController DBKBNMMJNKM(ResourceID JPFKGCMPLLM)
	{
		return null;
	}

	[Token(Token = "0x6001FF1")]
	[Address(RVA = "0x10A024C", Offset = "0x10A024C", VA = "0x10A024C")]
	private RuntimeAnimatorController EPCFFKNFGNP(RuntimeAnimatorController AAIFFDPLMJP)
	{
		return null;
	}

	[Token(Token = "0x6001FF2")]
	[Address(RVA = "0x10A05A4", Offset = "0x10A05A4", VA = "0x10A05A4", Slot = "62")]
	protected virtual RuntimeAnimatorController MBLDHHAODIF()
	{
		return null;
	}

	[Token(Token = "0x6001FF3")]
	[Address(RVA = "0x10A0A34", Offset = "0x10A0A34", VA = "0x10A0A34", Slot = "63")]
	internal virtual bool DPLMGOJKKCM(OOIPMACFIFL JFPKMOEGDIF, GameObject MCOKPAHIBLN, GameObject ANLFMPFNDIB, [Optional] BIEJHPCGHAJ MKLONHDNBDM, [Optional] CHEJCCHHDMH ADKCBNCEFKI)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FF4")]
	[Address(RVA = "0x10A2478", Offset = "0x10A2478", VA = "0x10A2478", Slot = "64")]
	protected virtual RuntimeAnimatorController JMONCELHAEK()
	{
		return null;
	}

	[Token(Token = "0x6001FF5")]
	[Address(RVA = "0x10A259C", Offset = "0x10A259C", VA = "0x10A259C", Slot = "65")]
	protected virtual BIEJHPCGHAJ BAIHMFBFLAG()
	{
		return null;
	}

	[Token(Token = "0x6001FF6")]
	[Address(RVA = "0x10A2654", Offset = "0x10A2654", VA = "0x10A2654", Slot = "9")]
	public override void CADHBNPGJOD()
	{
	}

	[Token(Token = "0x6001FF7")]
	[Address(RVA = "0x10A28E4", Offset = "0x10A28E4", VA = "0x10A28E4", Slot = "66")]
	public virtual void PNDEBBLPLLM(bool JOGHOHLEJFL)
	{
	}

	[Token(Token = "0x6001FF8")]
	[Address(RVA = "0x10A29B0", Offset = "0x10A29B0", VA = "0x10A29B0", Slot = "67")]
	public virtual void AMFIDBKGFCF(CBIKNJDAGLO JMEHJCCMLAL, CJKJKAEMMAO LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6001FF9")]
	[Address(RVA = "0x10A34B0", Offset = "0x10A34B0", VA = "0x10A34B0", Slot = "68")]
	public virtual void EICIBJAGELA()
	{
	}

	[Token(Token = "0x6001FFA")]
	[Address(RVA = "0x10A3558", Offset = "0x10A3558", VA = "0x10A3558", Slot = "69")]
	public virtual RuntimeAnimatorController LGDGBJNGACK()
	{
		return null;
	}

	[Token(Token = "0x6001FFB")]
	[Address(RVA = "0x10A38B8", Offset = "0x10A38B8", VA = "0x10A38B8", Slot = "70")]
	public virtual void CMHJCIPNPDB(bool EMIPEFFPJAD)
	{
	}

	[Token(Token = "0x6001FFC")]
	[Address(RVA = "0x10A3AB0", Offset = "0x10A3AB0", VA = "0x10A3AB0", Slot = "71")]
	public virtual void IBNGBHFLAEI(bool CPEBBCJCBGE)
	{
	}

	[Token(Token = "0x6001FFD")]
	[Address(RVA = "0x10A3B90", Offset = "0x10A3B90", VA = "0x10A3B90", Slot = "72")]
	public virtual void BIFBCEODKKJ(bool CPEBBCJCBGE)
	{
	}

	[Token(Token = "0x6001FFE")]
	[Address(RVA = "0x10A3C40", Offset = "0x10A3C40", VA = "0x10A3C40", Slot = "73")]
	public virtual void ODLNPFJDCJI(bool CPEBBCJCBGE)
	{
	}

	[Token(Token = "0x6001FFF")]
	[Address(RVA = "0x10A3CF0", Offset = "0x10A3CF0", VA = "0x10A3CF0", Slot = "74")]
	public virtual void IEKPENMAJLA(bool CPEBBCJCBGE)
	{
	}

	[Token(Token = "0x6002000")]
	[Address(RVA = "0x10A3DA0", Offset = "0x10A3DA0", VA = "0x10A3DA0", Slot = "75")]
	public virtual void KNBLMKEDBKM(bool PBOKBMFGHGJ)
	{
	}

	[Token(Token = "0x6002001")]
	[Address(RVA = "0x10A3E34", Offset = "0x10A3E34", VA = "0x10A3E34", Slot = "76")]
	public virtual void JNJKKDFJNLA(bool CDPFEPBKMEI)
	{
	}

	[Token(Token = "0x6002002")]
	[Address(RVA = "0x10A3EC8", Offset = "0x10A3EC8", VA = "0x10A3EC8", Slot = "77")]
	public virtual void NEKFBDIFMNB(bool LHMPOAEDGNB)
	{
	}

	[Token(Token = "0x6002003")]
	[Address(RVA = "0x10A3F5C", Offset = "0x10A3F5C", VA = "0x10A3F5C", Slot = "78")]
	public virtual void CEPCFJOPFCJ(bool CBFLGKAKCCH)
	{
	}

	[Token(Token = "0x6002004")]
	[Address(RVA = "0x10A3FF0", Offset = "0x10A3FF0", VA = "0x10A3FF0", Slot = "79")]
	public virtual void OIDPMLPCHFP(bool JOGHOHLEJFL)
	{
	}

	[Token(Token = "0x6002005")]
	[Address(RVA = "0x10A417C", Offset = "0x10A417C", VA = "0x10A417C", Slot = "20")]
	public override void IMBDKGNCOEC(bool EDLIFKGBCMD)
	{
	}

	[Token(Token = "0x6002006")]
	[Address(RVA = "0x10A4210", Offset = "0x10A4210", VA = "0x10A4210", Slot = "80")]
	public virtual void BGGGJGJKAEB(int MBKHHEHLHEF)
	{
	}

	[Token(Token = "0x6002007")]
	[Address(RVA = "0x10A43F4", Offset = "0x10A43F4", VA = "0x10A43F4", Slot = "81")]
	public virtual void HCAILOACGNF(bool MJJIFADPOGD)
	{
	}

	[Token(Token = "0x6002008")]
	[Address(RVA = "0x10A44E4", Offset = "0x10A44E4", VA = "0x10A44E4", Slot = "82")]
	protected virtual void BHPAGDCHKBN()
	{
	}

	[Token(Token = "0x6002009")]
	[Address(RVA = "0x10A0E84", Offset = "0x10A0E84", VA = "0x10A0E84")]
	public void DBBCNLOHNNF(string FHHKFDFJAFE)
	{
	}

	[Token(Token = "0x600200A")]
	[Address(RVA = "0x10A4630", Offset = "0x10A4630", VA = "0x10A4630")]
	public bool MPPJFPPFAOH(LGCOKIBHIJL COGOOKNKDGF)
	{
		return default(bool);
	}

	[Token(Token = "0x600200B")]
	[Address(RVA = "0x10A4854", Offset = "0x10A4854", VA = "0x10A4854", Slot = "24")]
	public bool MPPJFPPFAOH(object GKBODFGOHBJ)
	{
		return default(bool);
	}

	[Token(Token = "0x600200C")]
	[Address(RVA = "0x10A4DB4", Offset = "0x10A4DB4", VA = "0x10A4DB4")]
	public bool JMGBBHALJEM(OJKINHMAFBC FHHKFDFJAFE)
	{
		return default(bool);
	}

	[Token(Token = "0x600200D")]
	[Address(RVA = "0x10A4EC0", Offset = "0x10A4EC0", VA = "0x10A4EC0", Slot = "22")]
	public void PNHPNFCEKCN(object GKBODFGOHBJ)
	{
	}

	[Token(Token = "0x600200E")]
	[Address(RVA = "0x10A5218", Offset = "0x10A5218", VA = "0x10A5218", Slot = "23")]
	public void LCFALMKPAJI(object GKBODFGOHBJ)
	{
	}

	[Token(Token = "0x600200F")]
	[Address(RVA = "0x10A53D4", Offset = "0x10A53D4", VA = "0x10A53D4", Slot = "26")]
	public object MAHPLBPDIMD(int FEJAKNHGOCL)
	{
		return null;
	}

	[Token(Token = "0x6002010")]
	[Address(RVA = "0x10A5544", Offset = "0x10A5544", VA = "0x10A5544")]
	public bool DNGGHBBAEMM(OJKINHMAFBC FHHKFDFJAFE)
	{
		return default(bool);
	}

	[Token(Token = "0x6002011")]
	[Address(RVA = "0x10A560C", Offset = "0x10A560C", VA = "0x10A560C")]
	public bool LMOGLPENLLL()
	{
		return default(bool);
	}

	[Token(Token = "0x6002012")]
	[Address(RVA = "0x10A5440", Offset = "0x10A5440", VA = "0x10A5440")]
	public EEDCJKMIFIC DCIPALFCMLL(OJKINHMAFBC FHHKFDFJAFE)
	{
		return null;
	}

	[Token(Token = "0x6002013")]
	[Address(RVA = "0x10A5710", Offset = "0x10A5710", VA = "0x10A5710", Slot = "27")]
	public object LJKDHGKFGJM(uint PAJOHEDOPMF)
	{
		return null;
	}

	[Token(Token = "0x6002016")]
	[Address(RVA = "0x10A5AA4", Offset = "0x10A5AA4", VA = "0x10A5AA4")]
	public void ALLIJDGBLDP()
	{
	}

	[Token(Token = "0x6002017")]
	[Address(RVA = "0x10A5B00", Offset = "0x10A5B00", VA = "0x10A5B00")]
	private void CCGACHGLKOJ()
	{
	}

	[Token(Token = "0x6002018")]
	[Address(RVA = "0x10A5BD8", Offset = "0x10A5BD8", VA = "0x10A5BD8", Slot = "13")]
	public override void NNMGEBDEFMJ()
	{
	}

	[Token(Token = "0x6002019")]
	[Address(RVA = "0x10A6500", Offset = "0x10A6500", VA = "0x10A6500", Slot = "83")]
	protected virtual void NDENCKFFPBJ()
	{
	}

	[Token(Token = "0x600201A")]
	[Address(RVA = "0x10A6490", Offset = "0x10A6490", VA = "0x10A6490")]
	public void AODENMOOPEF()
	{
	}

	[Token(Token = "0x600201B")]
	[Address(RVA = "0x10A659C", Offset = "0x10A659C", VA = "0x10A659C")]
	public void OILMJKDEPPM()
	{
	}

	[Token(Token = "0x600201C")]
	[Address(RVA = "0x10A6620", Offset = "0x10A6620", VA = "0x10A6620")]
	public void BKEOGOIKMPI()
	{
	}

	[Token(Token = "0x600201D")]
	[Address(RVA = "0x10A5FE0", Offset = "0x10A5FE0", VA = "0x10A5FE0")]
	public void PBNBGHGKCEN()
	{
	}

	[Token(Token = "0x600201E")]
	[Address(RVA = "0x10A66B0", Offset = "0x10A66B0", VA = "0x10A66B0", Slot = "12")]
	public override void AAEGJGFIEGF()
	{
	}

	[Token(Token = "0x600201F")]
	[Address(RVA = "0x10A6928", Offset = "0x10A6928", VA = "0x10A6928", Slot = "84")]
	public virtual void PDPNNHHMAOG(float MLPAAKNGDLA)
	{
	}

	[Token(Token = "0x6002020")]
	[Address(RVA = "0x10A6B70", Offset = "0x10A6B70", VA = "0x10A6B70", Slot = "85")]
	public virtual void LDPIPOENAHA(float MLPAAKNGDLA)
	{
	}

	[Token(Token = "0x6002021")]
	[Address(RVA = "0x10A6CBC", Offset = "0x10A6CBC", VA = "0x10A6CBC", Slot = "86")]
	public virtual void JBFIFNLKINN(float MLPAAKNGDLA, bool OCFMBNJCECD)
	{
	}

	[Token(Token = "0x6002022")]
	[Address(RVA = "0x10A6E1C", Offset = "0x10A6E1C", VA = "0x10A6E1C")]
	public void FNHNOGLKGFF()
	{
	}

	[Token(Token = "0x6002023")]
	[Address(RVA = "0x10A6F1C", Offset = "0x10A6F1C", VA = "0x10A6F1C")]
	public void MECCKBEGILG(bool HDAEJDDLFFM)
	{
	}

	[Token(Token = "0x6002024")]
	[Address(RVA = "0x10A7024", Offset = "0x10A7024", VA = "0x10A7024")]
	public bool JAINPCDDPNA()
	{
		return default(bool);
	}

	[Token(Token = "0x6002025")]
	[Address(RVA = "0x10A71AC", Offset = "0x10A71AC", VA = "0x10A71AC", Slot = "87")]
	public virtual bool FEDLDEJBOBE()
	{
		return default(bool);
	}

	[Token(Token = "0x6002026")]
	[Address(RVA = "0x10A7204", Offset = "0x10A7204", VA = "0x10A7204", Slot = "88")]
	public virtual void JMGGHFDOHAO(bool GJFOOHPJCOG = false)
	{
	}

	[Token(Token = "0x6002027")]
	[Address(RVA = "0x10A75BC", Offset = "0x10A75BC", VA = "0x10A75BC", Slot = "89")]
	public virtual void GFEAJJEPBFO(bool KIHNJGKPMPP)
	{
	}

	[Token(Token = "0x6002028")]
	[Address(RVA = "0x10A7B54", Offset = "0x10A7B54", VA = "0x10A7B54")]
	public bool FAGLKPNHEDN()
	{
		return default(bool);
	}

	[Token(Token = "0x6002029")]
	[Address(RVA = "0x10A7BDC", Offset = "0x10A7BDC", VA = "0x10A7BDC", Slot = "90")]
	public virtual void CHGJJHFMADG()
	{
	}

	[Token(Token = "0x600202A")]
	[Address(RVA = "0x10A7D80", Offset = "0x10A7D80", VA = "0x10A7D80", Slot = "91")]
	public virtual bool NFGEHDKPJEB()
	{
		return default(bool);
	}

	[Token(Token = "0x600202B")]
	[Address(RVA = "0x10A7EB0", Offset = "0x10A7EB0", VA = "0x10A7EB0", Slot = "92")]
	public virtual bool MHIIJFEGIEA()
	{
		return default(bool);
	}

	[Token(Token = "0x600202C")]
	[Address(RVA = "0x10A7FF8", Offset = "0x10A7FF8", VA = "0x10A7FF8")]
	public void OLJPGEHBBHJ()
	{
	}

	[Token(Token = "0x600202D")]
	[Address(RVA = "0x10A8208", Offset = "0x10A8208", VA = "0x10A8208")]
	public void LBGBAHJPCKH()
	{
	}

	[Token(Token = "0x600202E")]
	[Address(RVA = "0x10A83CC", Offset = "0x10A83CC", VA = "0x10A83CC")]
	public void FKBGCCGFDBO()
	{
	}

	[Token(Token = "0x600202F")]
	[Address(RVA = "0x10A8578", Offset = "0x10A8578", VA = "0x10A8578", Slot = "19")]
	public override void FHIPMICEPMI(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002030")]
	[Address(RVA = "0x10A8FB8", Offset = "0x10A8FB8", VA = "0x10A8FB8", Slot = "93")]
	public virtual void IJDEIPEPHPK()
	{
	}

	[Token(Token = "0x6002031")]
	[Address(RVA = "0x10A900C", Offset = "0x10A900C", VA = "0x10A900C", Slot = "94")]
	public virtual void NLOCOAHJCMG(bool CPNKBAIBKMM)
	{
	}

	[Token(Token = "0x6002032")]
	[Address(RVA = "0x10A9068", Offset = "0x10A9068", VA = "0x10A9068", Slot = "95")]
	public virtual bool PGJCCPIFNPM()
	{
		return default(bool);
	}

	[Token(Token = "0x6002033")]
	[Address(RVA = "0x10A90E4", Offset = "0x10A90E4", VA = "0x10A90E4", Slot = "96")]
	public virtual bool BAIJMHGEBHI()
	{
		return default(bool);
	}

	[Token(Token = "0x6002034")]
	[Address(RVA = "0x10A9158", Offset = "0x10A9158", VA = "0x10A9158", Slot = "97")]
	public virtual bool LMCLDKNEFCM()
	{
		return default(bool);
	}

	[Token(Token = "0x6002035")]
	[Address(RVA = "0x10A91F4", Offset = "0x10A91F4", VA = "0x10A91F4", Slot = "98")]
	public virtual bool GGOOPEGDNJK()
	{
		return default(bool);
	}

	[Token(Token = "0x6002036")]
	[Address(RVA = "0x10A9270", Offset = "0x10A9270", VA = "0x10A9270", Slot = "99")]
	public virtual bool FBNKBPDOGDA()
	{
		return default(bool);
	}

	[Token(Token = "0x6002037")]
	[Address(RVA = "0x10A92EC", Offset = "0x10A92EC", VA = "0x10A92EC", Slot = "100")]
	public virtual bool LOKIMNEODIP()
	{
		return default(bool);
	}

	[Token(Token = "0x6002038")]
	[Address(RVA = "0x10A9368", Offset = "0x10A9368", VA = "0x10A9368", Slot = "101")]
	public virtual bool JPDIOJCBAPJ(bool BMKGOHEFEHP = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002039")]
	[Address(RVA = "0x10A947C", Offset = "0x10A947C", VA = "0x10A947C", Slot = "102")]
	public virtual bool HBMIMFNAOFK()
	{
		return default(bool);
	}

	[Token(Token = "0x600203A")]
	[Address(RVA = "0x10A94F8", Offset = "0x10A94F8", VA = "0x10A94F8")]
	public bool OPHIEGGHNMG()
	{
		return default(bool);
	}

	[Token(Token = "0x600203B")]
	[Address(RVA = "0x1086828", Offset = "0x1086828", VA = "0x1086828")]
	public bool KGNJHPHBNCA()
	{
		return default(bool);
	}

	[Token(Token = "0x600203C")]
	[Address(RVA = "0x1086798", Offset = "0x1086798", VA = "0x1086798")]
	public bool CHDJNMGNMOC()
	{
		return default(bool);
	}

	[Token(Token = "0x600203D")]
	[Address(RVA = "0x10A9570", Offset = "0x10A9570", VA = "0x10A9570", Slot = "103")]
	public virtual bool FLOPJKBBMMO()
	{
		return default(bool);
	}

	[Token(Token = "0x600203E")]
	[Address(RVA = "0x10A95E4", Offset = "0x10A95E4", VA = "0x10A95E4", Slot = "104")]
	public virtual bool CNJOIHDOIBB()
	{
		return default(bool);
	}

	[Token(Token = "0x600203F")]
	[Address(RVA = "0x10A9698", Offset = "0x10A9698", VA = "0x10A9698", Slot = "16")]
	public override void MLEGPPOHFNA()
	{
	}

	[Token(Token = "0x6002040")]
	[Address(RVA = "0x10A9950", Offset = "0x10A9950", VA = "0x10A9950", Slot = "17")]
	public override void FBFHDCDNKPA()
	{
	}

	[Token(Token = "0x6002041")]
	[Address(RVA = "0x10A99C0", Offset = "0x10A99C0", VA = "0x10A99C0", Slot = "14")]
	public override void CEFKGANPJBD(float OPKNJGBDOBB)
	{
	}

	[Token(Token = "0x6002042")]
	[Address(RVA = "0x10A9B60", Offset = "0x10A9B60", VA = "0x10A9B60", Slot = "15")]
	public override void HKDAPAJCFAO(bool CKMODGKIJGG = false, bool EFOHNMLDEHN = true)
	{
	}

	[Token(Token = "0x6002043")]
	[Address(RVA = "0x10A9CA0", Offset = "0x10A9CA0", VA = "0x10A9CA0", Slot = "105")]
	public virtual void MKIDFMEHEOB()
	{
	}

	[Token(Token = "0x6002044")]
	[Address(RVA = "0x10A9CF4", Offset = "0x10A9CF4", VA = "0x10A9CF4", Slot = "106")]
	public virtual void LJINDJIDGEO()
	{
	}

	[Token(Token = "0x6002045")]
	[Address(RVA = "0x10A9D48", Offset = "0x10A9D48", VA = "0x10A9D48", Slot = "18")]
	public override void HKDMCIIODPA(bool EOLJJBMMHFA)
	{
	}

	[Token(Token = "0x6002046")]
	[Address(RVA = "0x10A9DF8", Offset = "0x10A9DF8", VA = "0x10A9DF8", Slot = "107")]
	public virtual void NFIMCJJLLNG()
	{
	}

	[Token(Token = "0x6002047")]
	[Address(RVA = "0x10A9EE4", Offset = "0x10A9EE4", VA = "0x10A9EE4", Slot = "108")]
	public virtual void JEEKOCJBDFO()
	{
	}

	[Token(Token = "0x6002048")]
	[Address(RVA = "0x10A9FEC", Offset = "0x10A9FEC", VA = "0x10A9FEC")]
	protected void AEGMMBJOCJM()
	{
	}

	[Token(Token = "0x6002049")]
	[Address(RVA = "0x10AA11C", Offset = "0x10AA11C", VA = "0x10AA11C", Slot = "109")]
	public virtual void MPGJOKFGLGK()
	{
	}

	[Token(Token = "0x600204A")]
	[Address(RVA = "0x10AAD14", Offset = "0x10AAD14", VA = "0x10AAD14", Slot = "110")]
	protected virtual void KBNHONDGOAL()
	{
	}

	[Token(Token = "0x600204B")]
	[Address(RVA = "0x10AAF74", Offset = "0x10AAF74", VA = "0x10AAF74", Slot = "111")]
	public virtual void ONFHCAOLJLG()
	{
	}

	[Token(Token = "0x600204C")]
	[Address(RVA = "0x10AB104", Offset = "0x10AB104", VA = "0x10AB104", Slot = "112")]
	public virtual void MICCHCHPFBE()
	{
	}

	[Token(Token = "0x600204D")]
	[Address(RVA = "0x10AB278", Offset = "0x10AB278", VA = "0x10AB278", Slot = "113")]
	protected virtual void EEKOEPAMNFC(bool BGJMHHINNCB = false)
	{
	}

	[Token(Token = "0x600204E")]
	[Address(RVA = "0x10AA6A0", Offset = "0x10AA6A0", VA = "0x10AA6A0")]
	private void CFDBGCELDBD()
	{
	}

	[Token(Token = "0x600204F")]
	[Address(RVA = "0x10ABB48", Offset = "0x10ABB48", VA = "0x10ABB48")]
	protected float HDFLOMEFDIH()
	{
		return default(float);
	}

	[Token(Token = "0x6002050")]
	[Address(RVA = "0x10ABBDC", Offset = "0x10ABBDC", VA = "0x10ABBDC")]
	public void FIGJHCGIBOH()
	{
	}

	[Token(Token = "0x6002051")]
	[Address(RVA = "0x10ABDC8", Offset = "0x10ABDC8", VA = "0x10ABDC8", Slot = "114")]
	public virtual void MEPPPIPMLOD(float IENPBCLGFKM = 0f)
	{
	}

	[Token(Token = "0x6002052")]
	[Address(RVA = "0x10AC4BC", Offset = "0x10AC4BC", VA = "0x10AC4BC", Slot = "115")]
	public virtual void HFMNKKIKDHM()
	{
	}

	[Token(Token = "0x6002053")]
	[Address(RVA = "0x10AC9D4", Offset = "0x10AC9D4", VA = "0x10AC9D4", Slot = "116")]
	protected virtual ResourceID IAOMCNKDHFK()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002054")]
	[Address(RVA = "0x10ACAAC", Offset = "0x10ACAAC", VA = "0x10ACAAC", Slot = "117")]
	protected virtual ResourceID LFHPNAEOHJB()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002055")]
	[Address(RVA = "0x10ACB5C", Offset = "0x10ACB5C", VA = "0x10ACB5C", Slot = "118")]
	protected virtual ResourceID FOKIFOJEEGA()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002056")]
	[Address(RVA = "0x10ACC0C", Offset = "0x10ACC0C", VA = "0x10ACC0C", Slot = "119")]
	protected virtual ResourceID IGKFJPGBNGN()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002057")]
	[Address(RVA = "0x10ACCBC", Offset = "0x10ACCBC", VA = "0x10ACCBC", Slot = "120")]
	public virtual ResourceID DPNGPNODAHG()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002058")]
	[Address(RVA = "0x10ACD6C", Offset = "0x10ACD6C", VA = "0x10ACD6C", Slot = "121")]
	public virtual ResourceID HAFEMDNNDBI()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002059")]
	[Address(RVA = "0x10ACE1C", Offset = "0x10ACE1C", VA = "0x10ACE1C", Slot = "122")]
	public virtual ResourceID JGAKHNOEGAL()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600205A")]
	[Address(RVA = "0x10ACECC", Offset = "0x10ACECC", VA = "0x10ACECC", Slot = "123")]
	public virtual ResourceID ADJBCECOMBN()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600205B")]
	[Address(RVA = "0x10ACF7C", Offset = "0x10ACF7C", VA = "0x10ACF7C", Slot = "124")]
	public virtual ResourceID HINFPMJLAEM()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600205C")]
	[Address(RVA = "0x10AD02C", Offset = "0x10AD02C", VA = "0x10AD02C", Slot = "125")]
	public virtual ResourceID IOPMFMLCJDK()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600205D")]
	[Address(RVA = "0x10AD0DC", Offset = "0x10AD0DC", VA = "0x10AD0DC", Slot = "126")]
	public virtual ResourceID MLONAIJEDIO()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600205E")]
	[Address(RVA = "0x10AD18C", Offset = "0x10AD18C", VA = "0x10AD18C", Slot = "127")]
	public virtual ResourceID HGEMLCNPNHA()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600205F")]
	[Address(RVA = "0x10AD23C", Offset = "0x10AD23C", VA = "0x10AD23C", Slot = "128")]
	public virtual ResourceID HHCOHOHFHNB()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002060")]
	[Address(RVA = "0x10AD2EC", Offset = "0x10AD2EC", VA = "0x10AD2EC", Slot = "129")]
	protected virtual ResourceID DPPFIDJAFNK()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002061")]
	[Address(RVA = "0x10AD39C", Offset = "0x10AD39C", VA = "0x10AD39C", Slot = "130")]
	protected virtual ResourceID OPNLBCCPLBC()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002062")]
	[Address(RVA = "0x10AD44C", Offset = "0x10AD44C", VA = "0x10AD44C", Slot = "131")]
	public virtual void MJNBLIEHADG()
	{
	}

	[Token(Token = "0x6002063")]
	[Address(RVA = "0x10AD580", Offset = "0x10AD580", VA = "0x10AD580", Slot = "132")]
	public virtual void LAFNPLEILPH(float LGHNJEDOFFD)
	{
	}

	[Token(Token = "0x6002064")]
	[Address(RVA = "0x10ADD9C", Offset = "0x10ADD9C", VA = "0x10ADD9C", Slot = "133")]
	public virtual void EALCJKIKJCC()
	{
	}

	[Token(Token = "0x6002065")]
	[Address(RVA = "0x10ADFDC", Offset = "0x10ADFDC", VA = "0x10ADFDC", Slot = "134")]
	public virtual void EPKIFHAOLHJ(float LGHNJEDOFFD)
	{
	}

	[Token(Token = "0x6002066")]
	[Address(RVA = "0x10AE038", Offset = "0x10AE038", VA = "0x10AE038", Slot = "135")]
	public virtual void LKAANJHMBPP()
	{
	}

	[Token(Token = "0x6002067")]
	[Address(RVA = "0x10AE08C", Offset = "0x10AE08C", VA = "0x10AE08C", Slot = "136")]
	public virtual Quaternion CAPCKFDHJFJ()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x6002068")]
	[Address(RVA = "0x10AE11C", Offset = "0x10AE11C", VA = "0x10AE11C", Slot = "137")]
	public virtual Vector3 OIKKMPKBNAG()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002069")]
	[Address(RVA = "0x10AE1B4", Offset = "0x10AE1B4", VA = "0x10AE1B4")]
	private bool GILMLNPODKD()
	{
		return default(bool);
	}

	[Token(Token = "0x600206A")]
	[Address(RVA = "0x10AE248", Offset = "0x10AE248", VA = "0x10AE248")]
	private ResourceID PCOLKAPEFKO()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600206B")]
	[Address(RVA = "0x10AE488", Offset = "0x10AE488", VA = "0x10AE488")]
	private void PEDEOMDPBLJ()
	{
	}

	[Token(Token = "0x600206C")]
	[Address(RVA = "0x10AF85C", Offset = "0x10AF85C", VA = "0x10AF85C")]
	private void INBCGPBPNDD()
	{
	}

	[Token(Token = "0x600206D")]
	[Address(RVA = "0x10AFEDC", Offset = "0x10AFEDC", VA = "0x10AFEDC", Slot = "138")]
	protected virtual void OHPJGLPDDLA()
	{
	}

	[Token(Token = "0x600206E")]
	[Address(RVA = "0x10B03E0", Offset = "0x10B03E0", VA = "0x10B03E0")]
	private void HGGLMFANIKE()
	{
	}

	[Token(Token = "0x600206F")]
	[Address(RVA = "0x10B08CC", Offset = "0x10B08CC", VA = "0x10B08CC")]
	private void OJPOBAFNLPJ()
	{
	}

	[Token(Token = "0x6002070")]
	[Address(RVA = "0x10B1094", Offset = "0x10B1094", VA = "0x10B1094", Slot = "139")]
	protected virtual void NDPGBMJNCLF()
	{
	}

	[Token(Token = "0x6002071")]
	[Address(RVA = "0x10B13B4", Offset = "0x10B13B4", VA = "0x10B13B4")]
	protected bool FKLIKIDKLCG()
	{
		return default(bool);
	}

	[Token(Token = "0x6002072")]
	[Address(RVA = "0x10B143C", Offset = "0x10B143C", VA = "0x10B143C", Slot = "140")]
	protected virtual void EFOOBIAPDCG()
	{
	}

	[Token(Token = "0x6002073")]
	[Address(RVA = "0x10B21D4", Offset = "0x10B21D4", VA = "0x10B21D4")]
	public void CPBCGAKODII(Vector3 BNDPJDJAFOM, Vector3 PFAPJJODMCM)
	{
	}

	[Token(Token = "0x6002074")]
	[Address(RVA = "0x10B30D4", Offset = "0x10B30D4", VA = "0x10B30D4")]
	public OAKMMHOLHCI MAEANBMJOJG(float FCHMLOCDHIM)
	{
		return default(OAKMMHOLHCI);
	}

	[Token(Token = "0x6002075")]
	[Address(RVA = "0x10B2A98", Offset = "0x10B2A98", VA = "0x10B2A98")]
	public void IDLPHMICGOC(GameObject NPGPGOFBFDN, Vector3 BNDPJDJAFOM, Vector3 PFAPJJODMCM)
	{
	}

	[Token(Token = "0x6002076")]
	[Address(RVA = "0x10B31B8", Offset = "0x10B31B8", VA = "0x10B31B8")]
	public void OHBKAFLOGGC(Vector3 BNDPJDJAFOM, Vector3 PFAPJJODMCM, Vector3 JPACGHDENMO)
	{
	}

	[Token(Token = "0x6002077")]
	[Address(RVA = "0x10B35B0", Offset = "0x10B35B0", VA = "0x10B35B0")]
	public void NKDBEEKCMNG(GameObject NPGPGOFBFDN, Vector3 BNDPJDJAFOM, Vector3 PFAPJJODMCM, Vector3 JPACGHDENMO)
	{
	}

	[Token(Token = "0x6002078")]
	[Address(RVA = "0x10B2704", Offset = "0x10B2704", VA = "0x10B2704")]
	private ResourceID DNDBGIDAJBK()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002079")]
	[Address(RVA = "0x10B3CD0", Offset = "0x10B3CD0", VA = "0x10B3CD0")]
	public uint OKBCNGNBLJE()
	{
		return default(uint);
	}

	[Token(Token = "0x600207A")]
	[Address(RVA = "0x10B3D34", Offset = "0x10B3D34", VA = "0x10B3D34", Slot = "141")]
	public virtual void EJONAOOEOJH()
	{
	}

	[Token(Token = "0x600207B")]
	[Address(RVA = "0x10B40A0", Offset = "0x10B40A0", VA = "0x10B40A0", Slot = "142")]
	public virtual bool JLCBJKOAMGL()
	{
		return default(bool);
	}

	[Token(Token = "0x600207C")]
	[Address(RVA = "0x10B427C", Offset = "0x10B427C", VA = "0x10B427C", Slot = "143")]
	public virtual bool MLBFCLCJLJD()
	{
		return default(bool);
	}

	[Token(Token = "0x600207D")]
	[Address(RVA = "0x10B42FC", Offset = "0x10B42FC", VA = "0x10B42FC", Slot = "144")]
	public virtual bool CKHEFMCMKNJ()
	{
		return default(bool);
	}

	[Token(Token = "0x600207E")]
	[Address(RVA = "0x10B437C", Offset = "0x10B437C", VA = "0x10B437C", Slot = "145")]
	public virtual bool DLFNLOMCGEC()
	{
		return default(bool);
	}

	[Token(Token = "0x600207F")]
	[Address(RVA = "0x10B440C", Offset = "0x10B440C", VA = "0x10B440C", Slot = "146")]
	public virtual bool GPCPAKEDODJ()
	{
		return default(bool);
	}

	[Token(Token = "0x6002080")]
	[Address(RVA = "0x10B4464", Offset = "0x10B4464", VA = "0x10B4464")]
	public BMELIBDDBNL JFKFCDLAGIB()
	{
		return default(BMELIBDDBNL);
	}

	[Token(Token = "0x6002081")]
	[Address(RVA = "0x10B44D8", Offset = "0x10B44D8", VA = "0x10B44D8")]
	public bool AGCEIHIIDAD()
	{
		return default(bool);
	}

	[Token(Token = "0x6002082")]
	[Address(RVA = "0x10B459C", Offset = "0x10B459C", VA = "0x10B459C")]
	public bool BOGLOKPKEBE()
	{
		return default(bool);
	}

	[Token(Token = "0x6002083")]
	[Address(RVA = "0x10B4660", Offset = "0x10B4660", VA = "0x10B4660")]
	public bool KDHHCMPLKHJ()
	{
		return default(bool);
	}

	[Token(Token = "0x6002084")]
	[Address(RVA = "0x10B4714", Offset = "0x10B4714", VA = "0x10B4714", Slot = "147")]
	public virtual bool JGMMNFNNIMP()
	{
		return default(bool);
	}

	[Token(Token = "0x6002085")]
	[Address(RVA = "0x10B4794", Offset = "0x10B4794", VA = "0x10B4794", Slot = "148")]
	public virtual void KDPOBABIMBM(MADMMIICBNN JEEIBOEGGPD, [Optional] MonoBehaviour ECINOMEHBKA, float PODKEPNOBON = 0f)
	{
	}

	[Token(Token = "0x6002086")]
	[Address(RVA = "0x10B6234", Offset = "0x10B6234", VA = "0x10B6234", Slot = "149")]
	public virtual Vector3 BNGFEPNCGGM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002087")]
	[Address(RVA = "0x10B63E8", Offset = "0x10B63E8", VA = "0x10B63E8")]
	public bool HBIDNDFPBEC()
	{
		return default(bool);
	}

	[Token(Token = "0x6002088")]
	[Address(RVA = "0x10B2018", Offset = "0x10B2018", VA = "0x10B2018")]
	public void NKIHNNONJPA(MADMMIICBNN JEEIBOEGGPD, MonoBehaviour ECINOMEHBKA, float PODKEPNOBON)
	{
	}

	[Token(Token = "0x6002089")]
	[Address(RVA = "0x10B64BC", Offset = "0x10B64BC", VA = "0x10B64BC")]
	public void KMKINCILGAN()
	{
	}

	[Token(Token = "0x600208A")]
	[Address(RVA = "0x10B4844", Offset = "0x10B4844", VA = "0x10B4844")]
	protected void BLAGCMCGEJG(MADMMIICBNN JEEIBOEGGPD)
	{
	}

	[Token(Token = "0x600208B")]
	[Address(RVA = "0x10B9504", Offset = "0x10B9504", VA = "0x10B9504")]
	private ResourceID HPANMEGGOOC(HitDetectColliderHelper BBNPJNJDELC)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600208E")]
	[Address(RVA = "0x10B9C64", Offset = "0x10B9C64", VA = "0x10B9C64", Slot = "152")]
	public virtual void DHMJGAOGPFC(bool ACLAKHPMAID)
	{
	}

	[Token(Token = "0x6002091")]
	[Address(RVA = "0x10B9DCC", Offset = "0x10B9DCC", VA = "0x10B9DCC")]
	private bool EIDOAAFGPHL()
	{
		return default(bool);
	}

	[Token(Token = "0x6002092")]
	[Address(RVA = "0x10BA0C8", Offset = "0x10BA0C8", VA = "0x10BA0C8")]
	public void NKIIEBJHPME(int IOAHAPDPDEA, float GODEIDGFHEN, float GGDFIICIAFE)
	{
	}

	[Token(Token = "0x6002093")]
	[Address(RVA = "0x10BA268", Offset = "0x10BA268", VA = "0x10BA268")]
	public void GIEAAAAONFL(float GGDFIICIAFE = 1f)
	{
	}

	[Token(Token = "0x6002094")]
	[Address(RVA = "0x10BA3C4", Offset = "0x10BA3C4", VA = "0x10BA3C4", Slot = "153")]
	public virtual bool DJBFDKOKDMM(ENBHOKKHLPG CDAKGFIJNBE)
	{
		return default(bool);
	}

	[Token(Token = "0x6002095")]
	[Address(RVA = "0x10BA498", Offset = "0x10BA498", VA = "0x10BA498")]
	public bool EAGLNADGJLH()
	{
		return default(bool);
	}

	[Token(Token = "0x6002096")]
	[Address(RVA = "0x10BA560", Offset = "0x10BA560", VA = "0x10BA560")]
	public int MBNJLGENCDI(float CNNKFNANFFL)
	{
		return default(int);
	}

	[Token(Token = "0x6002097")]
	[Address(RVA = "0x10BA8D0", Offset = "0x10BA8D0", VA = "0x10BA8D0", Slot = "154")]
	public virtual float FHBBBLKNINH(bool GBDCICHCNFC)
	{
		return default(float);
	}

	[Token(Token = "0x6002098")]
	[Address(RVA = "0x10BAF98", Offset = "0x10BAF98", VA = "0x10BAF98", Slot = "155")]
	protected virtual float FCNDNKJAEMI()
	{
		return default(float);
	}

	[Token(Token = "0x6002099")]
	[Address(RVA = "0x10BAC4C", Offset = "0x10BAC4C", VA = "0x10BAC4C")]
	public float AONIEMLPKHB()
	{
		return default(float);
	}

	[Token(Token = "0x600209A")]
	[Address(RVA = "0x10B6848", Offset = "0x10B6848", VA = "0x10B6848")]
	public float ALOKCKJCNJM(float CNNKFNANFFL)
	{
		return default(float);
	}

	[Token(Token = "0x600209B")]
	[Address(RVA = "0x10BAFF0", Offset = "0x10BAFF0", VA = "0x10BAFF0")]
	public bool FBEGNKJNIAC()
	{
		return default(bool);
	}

	[Token(Token = "0x600209C")]
	[Address(RVA = "0x10BB0D4", Offset = "0x10BB0D4", VA = "0x10BB0D4")]
	public float MLDACOFFLDN()
	{
		return default(float);
	}

	[Token(Token = "0x600209D")]
	[Address(RVA = "0x10A8CB4", Offset = "0x10A8CB4", VA = "0x10A8CB4")]
	protected void BAKMOBLCFPN(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600209E")]
	[Address(RVA = "0x10A1710", Offset = "0x10A1710", VA = "0x10A1710")]
	protected void EMAOKNCFCKE()
	{
	}

	[Token(Token = "0x600209F")]
	[Address(RVA = "0x10BB834", Offset = "0x10BB834", VA = "0x10BB834")]
	public bool DKDIOJHOKAC(OJKINHMAFBC MFLMBCPLJDA)
	{
		return default(bool);
	}

	[Token(Token = "0x60020A0")]
	[Address(RVA = "0x10BBA00", Offset = "0x10BBA00", VA = "0x10BBA00")]
	public float GOMJHDDLDGG()
	{
		return default(float);
	}

	[Token(Token = "0x60020A1")]
	[Address(RVA = "0x10BBC2C", Offset = "0x10BBC2C", VA = "0x10BBC2C", Slot = "156")]
	protected virtual void BCICCIIAJCP()
	{
	}

	[Token(Token = "0x60020A2")]
	[Address(RVA = "0x10BB8A4", Offset = "0x10BB8A4", VA = "0x10BB8A4")]
	private void KJFCGOPGBPN(PGHBICDAKIC PMMLMGKBEDF)
	{
	}

	[Token(Token = "0x60020A3")]
	[Address(RVA = "0x10BB350", Offset = "0x10BB350", VA = "0x10BB350")]
	private void OEKGKDEGPMC(PFMPPELJECF FBHKGBGFJPE)
	{
	}

	[Token(Token = "0x60020A4")]
	[Address(RVA = "0x10BBC80", Offset = "0x10BBC80", VA = "0x10BBC80", Slot = "157")]
	protected virtual void GHABKBMKMKC()
	{
	}

	[Token(Token = "0x60020A7")]
	[Address(RVA = "0x10BB12C", Offset = "0x10BB12C", VA = "0x10BB12C")]
	public void MEAAHLJFDCO(PFMPPELJECF BELEBGBAIBJ)
	{
	}

	[Token(Token = "0x60020A8")]
	[Address(RVA = "0x10BB18C", Offset = "0x10BB18C", VA = "0x10BB18C")]
	private PFMPPELJECF HBMOGLJHKPB()
	{
		return null;
	}

	[Token(Token = "0x60020A9")]
	[Address(RVA = "0x10BC20C", Offset = "0x10BC20C", VA = "0x10BC20C")]
	public float ACNJGLIOMBI()
	{
		return default(float);
	}

	[Token(Token = "0x60020AA")]
	[Address(RVA = "0x10B1EC0", Offset = "0x10B1EC0", VA = "0x10B1EC0")]
	public bool JFIKGOEBOIE()
	{
		return default(bool);
	}

	[Token(Token = "0x60020AB")]
	[Address(RVA = "0x10B96F4", Offset = "0x10B96F4", VA = "0x10B96F4")]
	public void KELMHNJBIBG()
	{
	}

	[Token(Token = "0x60020AC")]
	[Address(RVA = "0x10BC2B4", Offset = "0x10BC2B4", VA = "0x10BC2B4", Slot = "158")]
	public virtual void EGOLOEEOBEK()
	{
	}

	[Token(Token = "0x60020AD")]
	[Address(RVA = "0x10BC308", Offset = "0x10BC308", VA = "0x10BC308", Slot = "159")]
	public virtual bool KGELGKELDKL()
	{
		return default(bool);
	}

	[Token(Token = "0x60020AE")]
	[Address(RVA = "0x10BC3C0", Offset = "0x10BC3C0", VA = "0x10BC3C0", Slot = "160")]
	public virtual bool MMNOCLPJKFE()
	{
		return default(bool);
	}

	[Token(Token = "0x60020AF")]
	[Address(RVA = "0x10BC418", Offset = "0x10BC418", VA = "0x10BC418", Slot = "161")]
	public virtual void BMHNOHPPILD(bool CAAHGBFGBLC)
	{
	}

	[Token(Token = "0x60020B0")]
	[Address(RVA = "0x10BC558", Offset = "0x10BC558", VA = "0x10BC558", Slot = "162")]
	public virtual float PHNKNGCAOBL()
	{
		return default(float);
	}

	[Token(Token = "0x60020B1")]
	[Address(RVA = "0x10BC778", Offset = "0x10BC778", VA = "0x10BC778")]
	public bool DDPHEAFGOGH(MADMMIICBNN JEEIBOEGGPD)
	{
		return default(bool);
	}

	[Token(Token = "0x60020B2")]
	[Address(RVA = "0x10BCA44", Offset = "0x10BCA44", VA = "0x10BCA44")]
	private void CHOFHPMCLHF(OPILIBBOEAC CAGCICACKCF, float CHADOJMOHFJ, float IOOPPDAAMEP)
	{
	}

	[Token(Token = "0x60020B3")]
	[Address(RVA = "0x10B6A34", Offset = "0x10B6A34", VA = "0x10B6A34")]
	private List<float> LCLHHHKFCFP(OPILIBBOEAC CAGCICACKCF, Collider HFBDJJDICLN, bool LDGHPOPPPNL = false, [Optional] ELMGJKHIIAA JIIJIFKKCCB)
	{
		return null;
	}

	[Token(Token = "0x60020B4")]
	[Address(RVA = "0x10BCC10", Offset = "0x10BCC10", VA = "0x10BCC10", Slot = "21")]
	public override void LJMHPDANBLG(bool HEGHCPADJAC)
	{
	}

	[Token(Token = "0x60020B5")]
	[Address(RVA = "0x109D09C", Offset = "0x109D09C", VA = "0x109D09C")]
	private void FJIOOANNLKN()
	{
	}

	[Token(Token = "0x60020B6")]
	[Address(RVA = "0x10BCCA4", Offset = "0x10BCCA4", VA = "0x10BCCA4")]
	public void CNKMELBJBJB(uint EBOJJLIHHCM, bool JOGHOHLEJFL)
	{
	}

	[Token(Token = "0x60020B7")]
	[Address(RVA = "0x109D470", Offset = "0x109D470", VA = "0x109D470")]
	public void CDHNMAGAMFM()
	{
	}

	[Token(Token = "0x60020B8")]
	[Address(RVA = "0x10BCD44", Offset = "0x10BCD44", VA = "0x10BCD44", Slot = "163")]
	public virtual uint HNGNHFMPLLC()
	{
		return default(uint);
	}

	[Token(Token = "0x60020B9")]
	[Address(RVA = "0x10BCE1C", Offset = "0x10BCE1C", VA = "0x10BCE1C", Slot = "164")]
	public virtual bool JCMNJBONPLD()
	{
		return default(bool);
	}

	[Token(Token = "0x60020BA")]
	[Address(RVA = "0x10BCE74", Offset = "0x10BCE74", VA = "0x10BCE74", Slot = "165")]
	protected virtual int DPKDNEBKELD()
	{
		return default(int);
	}

	[Token(Token = "0x60020BB")]
	[Address(RVA = "0x10BCECC", Offset = "0x10BCECC", VA = "0x10BCECC")]
	protected float FEACNFPMKOA(DBNMCJLEFJI BCMGCJGCCIC)
	{
		return default(float);
	}

	[Token(Token = "0x60020BC")]
	[Address(RVA = "0x109EDAC", Offset = "0x109EDAC", VA = "0x109EDAC")]
	protected int DEDCIGDOINH(bool HOMIGDEOPDN)
	{
		return default(int);
	}

	[Token(Token = "0x60020BD")]
	[Address(RVA = "0x10BCF80", Offset = "0x10BCF80", VA = "0x10BCF80")]
	public void NDPKNHKELIE()
	{
	}

	[Token(Token = "0x60020BE")]
	[Address(RVA = "0x10BD308", Offset = "0x10BD308", VA = "0x10BD308")]
	public bool ONKHBPODLGM(Vector3 FAGGNKIIAIK, Vector3 NAMGLJFEGOO)
	{
		return default(bool);
	}

	[Token(Token = "0x60020BF")]
	[Address(RVA = "0x10BD4A8", Offset = "0x10BD4A8", VA = "0x10BD4A8")]
	public bool KDEPCADCNML()
	{
		return default(bool);
	}

	[Token(Token = "0x60020C0")]
	[Address(RVA = "0x10BD58C", Offset = "0x10BD58C", VA = "0x10BD58C")]
	public static SwitchBase DLNHHIPDJML(ENBHOKKHLPG PMGBACFJIHO)
	{
		return null;
	}

	[Token(Token = "0x60020C1")]
	[Address(RVA = "0x10BD8DC", Offset = "0x10BD8DC", VA = "0x10BD8DC", Slot = "166")]
	public virtual void EHPDOFJOJCA()
	{
	}

	[Token(Token = "0x60020C2")]
	[Address(RVA = "0x10BD930", Offset = "0x10BD930", VA = "0x10BD930", Slot = "167")]
	public virtual void IFAJILMBKDA()
	{
	}

	[Token(Token = "0x60020C3")]
	[Address(RVA = "0x10BD984", Offset = "0x10BD984", VA = "0x10BD984", Slot = "168")]
	public virtual void KGLOGHHIKFI()
	{
	}

	[Token(Token = "0x60020C4")]
	[Address(RVA = "0x10BD9D8", Offset = "0x10BD9D8", VA = "0x10BD9D8")]
	public void OGOAGHMOEMD()
	{
	}

	[Token(Token = "0x60020C5")]
	[Address(RVA = "0x109D3AC", Offset = "0x109D3AC", VA = "0x109D3AC")]
	protected void FEKIKGMNKGF(TweenProperty[] MKHJECHAKAO)
	{
	}

	[Token(Token = "0x60020C7")]
	[Address(RVA = "0x10BDF60", Offset = "0x10BDF60", VA = "0x10BDF60")]
	private void ICCOJFNCJIB()
	{
	}

	[Token(Token = "0x60020C8")]
	[Address(RVA = "0x10BE020", Offset = "0x10BE020", VA = "0x10BE020")]
	public bool _003C_003EiFixBaseProxy_APJHPGBALDJ(Player P0, uint P1, uint P2, LGCOKIBHIJL P3, object[] P4)
	{
		return default(bool);
	}

	[Token(Token = "0x60020C9")]
	[Address(RVA = "0x10BE04C", Offset = "0x10BE04C", VA = "0x10BE04C")]
	public void _003C_003EiFixBaseProxy_FHIPMICEPMI(float P0, float P1)
	{
	}

	[Token(Token = "0x60020CA")]
	[Address(RVA = "0x10BE054", Offset = "0x10BE054", VA = "0x10BE054")]
	public void _003C_003EiFixBaseProxy_HKDAPAJCFAO(bool P0, bool P1)
	{
	}

	[Token(Token = "0x60020CB")]
	[Address(RVA = "0x10BE05C", Offset = "0x10BE05C", VA = "0x10BE05C")]
	public void _003C_003EiFixBaseProxy_NNMGEBDEFMJ()
	{
	}

	[Token(Token = "0x60020CC")]
	[Address(RVA = "0x10BE064", Offset = "0x10BE064", VA = "0x10BE064")]
	public void _003C_003EiFixBaseProxy_AAEGJGFIEGF()
	{
	}

	[Token(Token = "0x60020CD")]
	[Address(RVA = "0x10BE06C", Offset = "0x10BE06C", VA = "0x10BE06C")]
	public void _003C_003EiFixBaseProxy_CEFKGANPJBD(float P0)
	{
	}

	[Token(Token = "0x60020CE")]
	[Address(RVA = "0x10BE074", Offset = "0x10BE074", VA = "0x10BE074")]
	public bool _003C_003EiFixBaseProxy_IALAILMPPHC()
	{
		return default(bool);
	}

	[Token(Token = "0x60020CF")]
	[Address(RVA = "0x10BE07C", Offset = "0x10BE07C", VA = "0x10BE07C")]
	public void _003C_003EiFixBaseProxy_CADHBNPGJOD()
	{
	}

	[Token(Token = "0x60020D0")]
	[Address(RVA = "0x10BE084", Offset = "0x10BE084", VA = "0x10BE084")]
	public bool _003C_003EiFixBaseProxy_BIDNGOEABGM()
	{
		return default(bool);
	}

	[Token(Token = "0x60020D1")]
	[Address(RVA = "0x10BE08C", Offset = "0x10BE08C", VA = "0x10BE08C")]
	public void _003C_003EiFixBaseProxy_IMBDKGNCOEC(bool P0)
	{
	}

	[Token(Token = "0x60020D2")]
	[Address(RVA = "0x10BE094", Offset = "0x10BE094", VA = "0x10BE094")]
	public void _003C_003EiFixBaseProxy_MLEGPPOHFNA()
	{
	}

	[Token(Token = "0x60020D3")]
	[Address(RVA = "0x10BE09C", Offset = "0x10BE09C", VA = "0x10BE09C")]
	public void _003C_003EiFixBaseProxy_FBFHDCDNKPA()
	{
	}

	[Token(Token = "0x60020D4")]
	[Address(RVA = "0x10BE0A4", Offset = "0x10BE0A4", VA = "0x10BE0A4")]
	public void _003C_003EiFixBaseProxy_HKDMCIIODPA(bool P0)
	{
	}

	[Token(Token = "0x60020D5")]
	[Address(RVA = "0x10BE0AC", Offset = "0x10BE0AC", VA = "0x10BE0AC")]
	public void _003C_003EiFixBaseProxy_LJMHPDANBLG(bool P0)
	{
	}
}
