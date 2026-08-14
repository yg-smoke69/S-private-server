using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using WwiseGameSyncs;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000D0A")]
internal class Vehicle : AttackableEntity, _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable
{
	[Token(Token = "0x2000D0B")]
	protected class HHCBNAPCKHF : ShadowStateBase
	{
		[Token(Token = "0x40069F5")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 PGDEDHFOMCN;

		[Token(Token = "0x40069F6")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion BPLOAFBIHJL;

		[Token(Token = "0x40069F7")]
		[FieldOffset(Offset = "0x2C")]
		public Quaternion FBMPKHMBHAM;

		[Token(Token = "0x40069F8")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 JHJLNLCEGOG;

		[Token(Token = "0x40069F9")]
		[FieldOffset(Offset = "0x48")]
		public float DBFBJDIJFHH;

		[Token(Token = "0x40069FA")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 LMNBBBCKMGB;

		[Token(Token = "0x600643B")]
		[Address(RVA = "0x26E4220", Offset = "0x26E4220", VA = "0x26E4220")]
		public HHCBNAPCKHF()
		{
		}
	}

	[Token(Token = "0x2000D0C")]
	private enum LPMLHDAIIGO
	{
		[Token(Token = "0x40069FC")]
		EVehicleAuthState_None,
		[Token(Token = "0x40069FD")]
		EVehicleAuthState_Local,
		[Token(Token = "0x40069FE")]
		EVehicleAuthState_Network
	}

	[Serializable]
	[Token(Token = "0x2000D0D")]
	public class SmokeParam
	{
		[Token(Token = "0x40069FF")]
		[FieldOffset(Offset = "0x8")]
		public float HpRate;

		[Token(Token = "0x4006A00")]
		[FieldOffset(Offset = "0xC")]
		public string ResID;

		[Token(Token = "0x4006A01")]
		[FieldOffset(Offset = "0x10")]
		public Transform Transform;

		[Token(Token = "0x600643C")]
		[Address(RVA = "0x26E44F0", Offset = "0x26E44F0", VA = "0x26E44F0")]
		public SmokeParam()
		{
		}
	}

	[Token(Token = "0x2000D0E")]
	private class KCOCOJFGMMG
	{
		[Token(Token = "0x4006A02")]
		[FieldOffset(Offset = "0x8")]
		public PDMPKNHNMIC FGNAKNCNACG;

		[Token(Token = "0x4006A03")]
		[FieldOffset(Offset = "0xC")]
		public PDMPKNHNMIC BLACIFIIPCL;

		[Token(Token = "0x600643D")]
		[Address(RVA = "0x26E44E8", Offset = "0x26E44E8", VA = "0x26E44E8")]
		public KCOCOJFGMMG()
		{
		}
	}

	[Token(Token = "0x2000D0F")]
	private sealed class JGKMGHODHIA : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4006A04")]
		[FieldOffset(Offset = "0x8")]
		internal float BLHEBBCODLC;

		[Token(Token = "0x4006A05")]
		[FieldOffset(Offset = "0xC")]
		internal CommonParticleEffect GJMJJFAOBEL;

		[Token(Token = "0x4006A06")]
		[FieldOffset(Offset = "0x10")]
		internal Vehicle GADHAMJEKIM;

		[Token(Token = "0x4006A07")]
		[FieldOffset(Offset = "0x14")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x4006A08")]
		[FieldOffset(Offset = "0x18")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x4006A09")]
		[FieldOffset(Offset = "0x1C")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x17000875")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6006440")]
			[Address(RVA = "0x26E443C", Offset = "0x26E443C", VA = "0x26E443C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000876")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006441")]
			[Address(RVA = "0x26E4444", Offset = "0x26E4444", VA = "0x26E4444", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600643E")]
		[Address(RVA = "0x26E4228", Offset = "0x26E4228", VA = "0x26E4228")]
		public JGKMGHODHIA()
		{
		}

		[Token(Token = "0x600643F")]
		[Address(RVA = "0x26E4230", Offset = "0x26E4230", VA = "0x26E4230", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006442")]
		[Address(RVA = "0x26E444C", Offset = "0x26E444C", VA = "0x26E444C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6006443")]
		[Address(RVA = "0x26E4460", Offset = "0x26E4460", VA = "0x26E4460", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4006968")]
	private const float HMLMHICHIMK = 3.6f;

	[Token(Token = "0x4006969")]
	[FieldOffset(Offset = "0x0")]
	private static Vector3 MMEKECEHLDN;

	[Token(Token = "0x400696A")]
	[FieldOffset(Offset = "0xC")]
	private static float LLFJNDDCPIA;

	[Token(Token = "0x400696B")]
	[FieldOffset(Offset = "0x10")]
	private static float PJKAFKFCPGB;

	[Token(Token = "0x400696C")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<int, float> NCCPIIMFLEI;

	[Token(Token = "0x400696D")]
	public const uint ISVISIBLE_STREAMER = 4u;

	[Token(Token = "0x400696E")]
	public const uint ISVISIBLE_ONBOARD = 8u;

	[Token(Token = "0x400696F")]
	[FieldOffset(Offset = "0x4C")]
	protected BitArrayBoolean FAGCPHGJGPI;

	[Token(Token = "0x4006970")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<int, ResourceID> BPDBGECNEBM;

	[Token(Token = "0x4006971")]
	[FieldOffset(Offset = "0x54")]
	protected VehicleControllerInterface IGECMFCOLPJ;

	[Token(Token = "0x4006972")]
	[FieldOffset(Offset = "0x58")]
	private CarAudioComponent OCIKBKHPGKL;

	[Token(Token = "0x4006973")]
	[FieldOffset(Offset = "0x5C")]
	protected VehicleSkinInfoBase KEOGNJLCDAN;

	[Token(Token = "0x4006974")]
	[FieldOffset(Offset = "0x60")]
	protected VehicleSkinInfoBase JHGBHACNPAL;

	[Token(Token = "0x4006975")]
	[FieldOffset(Offset = "0x64")]
	public VehicleSkinPropertyData SkinPropData;

	[Token(Token = "0x4006976")]
	[FieldOffset(Offset = "0x68")]
	public string m_VehicleDefaultResourceName;

	[Token(Token = "0x4006977")]
	[FieldOffset(Offset = "0x6C")]
	public float m_CameraHeightScale;

	[Token(Token = "0x4006978")]
	[FieldOffset(Offset = "0x70")]
	public float m_CameraDistanceScale;

	[Token(Token = "0x4006979")]
	[FieldOffset(Offset = "0x74")]
	public float m_CameraMinPitch;

	[Token(Token = "0x400697A")]
	[FieldOffset(Offset = "0x78")]
	public float m_CameraMaxPitch;

	[Token(Token = "0x400697B")]
	[FieldOffset(Offset = "0x7C")]
	public float m_CameraHeightScale_PassengerFire;

	[Token(Token = "0x400697C")]
	[FieldOffset(Offset = "0x80")]
	public float m_CameraDistanceScale_PassengerFire;

	[Token(Token = "0x400697D")]
	[FieldOffset(Offset = "0x84")]
	public bool m_CanPassengerFire;

	[Token(Token = "0x400697E")]
	[FieldOffset(Offset = "0x85")]
	public bool m_CanPassengerSteering;

	[Token(Token = "0x400697F")]
	[FieldOffset(Offset = "0x86")]
	public bool m_UpdateAnimSteerAngle;

	[Token(Token = "0x4006980")]
	[FieldOffset(Offset = "0x87")]
	public bool m_UpdateAnimSteerAngleHD;

	[Token(Token = "0x4006981")]
	[FieldOffset(Offset = "0x88")]
	protected Player GNIICHFIDFG;

	[Token(Token = "0x4006982")]
	[FieldOffset(Offset = "0x8C")]
	public BoxCollider LevelTrigger;

	[Token(Token = "0x4006983")]
	[FieldOffset(Offset = "0x90")]
	public LevelVehicle LevelVehicle;

	[Token(Token = "0x4006984")]
	[FieldOffset(Offset = "0x94")]
	public Rigidbody VehicleRigidBody;

	[Token(Token = "0x4006985")]
	[FieldOffset(Offset = "0x98")]
	public GameObject[] HideAfterBroken;

	[Token(Token = "0x4006986")]
	[FieldOffset(Offset = "0x9C")]
	public bool EnableSetSeatVisible;

	[Token(Token = "0x4006987")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject DriverSeat;

	[Token(Token = "0x4006988")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject[] PassengerSeat;

	[Token(Token = "0x4006989")]
	[FieldOffset(Offset = "0xA8")]
	private ResourceID HBPLONPKPLF;

	[Token(Token = "0x400698A")]
	[FieldOffset(Offset = "0xAC")]
	public Transform[] GetOffPositions;

	[Token(Token = "0x400698B")]
	[FieldOffset(Offset = "0xB0")]
	public SmokeParam[] SmokeParams;

	[Token(Token = "0x400698C")]
	[FieldOffset(Offset = "0xB4")]
	public Transform ExplodePoint1;

	[Token(Token = "0x400698D")]
	[FieldOffset(Offset = "0xB8")]
	public Transform ExplodePoint2;

	[Token(Token = "0x400698E")]
	public const int DRIVER_SEAT_INDEX = 0;

	[Token(Token = "0x400698F")]
	[FieldOffset(Offset = "0xBC")]
	private Vector3 MPJGLKLLNFD;

	[Token(Token = "0x4006990")]
	[FieldOffset(Offset = "0xC8")]
	private Vector3 OMAKLJDJAFE;

	[Token(Token = "0x4006991")]
	[FieldOffset(Offset = "0xD4")]
	private Vector3 KDIIPAGJICJ;

	[Token(Token = "0x4006992")]
	[FieldOffset(Offset = "0xE0")]
	private WheelCollider[] BGCLDKHMCLN;

	[Token(Token = "0x4006993")]
	[FieldOffset(Offset = "0xE4")]
	protected IHAAMHPPLMG[] JPKOMGMOAFJ;

	[Token(Token = "0x4006994")]
	[FieldOffset(Offset = "0xE8")]
	public int[] AnimPoses;

	[Token(Token = "0x4006995")]
	[FieldOffset(Offset = "0xEC")]
	private KLODDDDBAFP IJDNIPLDHHN;

	[Token(Token = "0x4006996")]
	[FieldOffset(Offset = "0xF0")]
	private CDPEGEHFLFO FDNKIGGNMHD;

	[Token(Token = "0x4006997")]
	[FieldOffset(Offset = "0xF4")]
	private int GIMDMCCHFJI;

	[Token(Token = "0x4006998")]
	[FieldOffset(Offset = "0xF8")]
	private float BLBNLFCCJLB;

	[Token(Token = "0x4006999")]
	[FieldOffset(Offset = "0xFC")]
	private float DAOHPFDAGMM;

	[Token(Token = "0x400699A")]
	[FieldOffset(Offset = "0x100")]
	public float m_MaxExtent;

	[Token(Token = "0x400699B")]
	[FieldOffset(Offset = "0x104")]
	private Bounds _003CEDKIPHCJLGG_003Ek__BackingField;

	[Token(Token = "0x400699C")]
	[FieldOffset(Offset = "0x11C")]
	private LPMLHDAIIGO CPHMMMIFDPO;

	[Token(Token = "0x400699D")]
	[FieldOffset(Offset = "0x120")]
	protected uint KINJCKMOGIM;

	[Token(Token = "0x400699E")]
	[FieldOffset(Offset = "0x124")]
	protected HHCBNAPCKHF PLGAAJABBHA;

	[Token(Token = "0x400699F")]
	[FieldOffset(Offset = "0x128")]
	private bool AEBAGGBJJME;

	[Token(Token = "0x40069A0")]
	[FieldOffset(Offset = "0x129")]
	private bool MJBPEOLIJGC;

	[Token(Token = "0x40069A1")]
	[FieldOffset(Offset = "0x12C")]
	private Queue<Vector3> FHGEKDFLHCJ;

	[Token(Token = "0x40069A2")]
	[FieldOffset(Offset = "0x130")]
	private Vector3 PAFCJPKBBNO;

	[Token(Token = "0x40069A3")]
	[FieldOffset(Offset = "0x13C")]
	private Queue<Vector3> HCGCFNDABBM;

	[Token(Token = "0x40069A4")]
	[FieldOffset(Offset = "0x140")]
	private Vector3 LFFEIIMBHCH;

	[Token(Token = "0x40069A5")]
	[FieldOffset(Offset = "0x14C")]
	private Vector3 HPJCLNBPCPK;

	[Token(Token = "0x40069A6")]
	[FieldOffset(Offset = "0x158")]
	private HitDetectColliderHelper GIJHJNKGBBC;

	[Token(Token = "0x40069A7")]
	[FieldOffset(Offset = "0x15C")]
	protected bool DPLOJEPECHE;

	[Token(Token = "0x40069A8")]
	[FieldOffset(Offset = "0x15D")]
	protected bool OIJLMOJMNLJ;

	[Token(Token = "0x40069A9")]
	[FieldOffset(Offset = "0x160")]
	private CommonParticleEffect GLHIINOMLLJ;

	[Token(Token = "0x40069AA")]
	[FieldOffset(Offset = "0x164")]
	private GameObject BNEEJDCPDMO;

	[Token(Token = "0x40069AB")]
	[FieldOffset(Offset = "0x168")]
	private Dictionary<int, List<int>> DFKLDJGEJDE;

	[Token(Token = "0x40069AC")]
	[FieldOffset(Offset = "0x16C")]
	protected Dictionary<int, List<int>> NNPAMCIOGNJ;

	[Token(Token = "0x40069AD")]
	[FieldOffset(Offset = "0x170")]
	protected bool LMIKJPPDGGC;

	[Token(Token = "0x40069AE")]
	[FieldOffset(Offset = "0x171")]
	protected bool BBHONEKGDBO;

	[Token(Token = "0x40069AF")]
	[FieldOffset(Offset = "0x174")]
	private float LEIIOACGOEO;

	[Token(Token = "0x40069B0")]
	[FieldOffset(Offset = "0x178")]
	private float CEJEJAKKMIP;

	[Token(Token = "0x40069B1")]
	[FieldOffset(Offset = "0x17C")]
	public VehicleEffect[] m_Effecects;

	[Token(Token = "0x40069B2")]
	[FieldOffset(Offset = "0x180")]
	public VehicleConfig config;

	[Token(Token = "0x40069B3")]
	[FieldOffset(Offset = "0x184")]
	public VehicleUpgradeSetting[] VehicleUpgrades;

	[Token(Token = "0x40069B4")]
	[FieldOffset(Offset = "0x188")]
	public int BoostStartEffectIndex;

	[Token(Token = "0x40069B5")]
	[FieldOffset(Offset = "0x18C")]
	public int BoostLoopEffectIndex;

	[Token(Token = "0x40069B6")]
	[FieldOffset(Offset = "0x190")]
	public int BoostEndEffectIndex;

	[Token(Token = "0x40069B7")]
	[FieldOffset(Offset = "0x194")]
	public int JumpStartEffectIndex;

	[Token(Token = "0x40069B8")]
	[FieldOffset(Offset = "0x198")]
	public int JumpLoopEffectIndex;

	[Token(Token = "0x40069B9")]
	[FieldOffset(Offset = "0x19C")]
	public int JumpEndEffectIndex;

	[Token(Token = "0x40069BA")]
	[FieldOffset(Offset = "0x1A0")]
	public TssSdtFloat BoostDurationRate;

	[Token(Token = "0x40069BB")]
	[FieldOffset(Offset = "0x1A4")]
	public TssSdtFloat BoostCDRate;

	[Token(Token = "0x40069BC")]
	[FieldOffset(Offset = "0x1A8")]
	protected TssSdtFloat KMBNLMDMKPM;

	[Token(Token = "0x40069BD")]
	[FieldOffset(Offset = "0x1AC")]
	public TssSdtFloat JumpCDRate;

	[Token(Token = "0x40069BE")]
	[FieldOffset(Offset = "0x1B0")]
	protected TssSdtFloat EFFJHMFAGKL;

	[Token(Token = "0x40069BF")]
	[FieldOffset(Offset = "0x1B4")]
	protected TssSdtFloat LOLMIHEBKNK;

	[Token(Token = "0x40069C0")]
	[FieldOffset(Offset = "0x1B8")]
	protected TssSdtFloat BFIFFDEEDNO;

	[Token(Token = "0x40069C1")]
	[FieldOffset(Offset = "0x1BC")]
	protected TssSdtFloat GDNJCMLMNOP;

	[Token(Token = "0x40069C2")]
	[FieldOffset(Offset = "0x1C0")]
	public Transform[] MissilePositions;

	[Token(Token = "0x40069C3")]
	private const int EJKCGFKPBMA = 14;

	[Token(Token = "0x40069C4")]
	[FieldOffset(Offset = "0x1C4")]
	public Dictionary<int, LevelMissile> Missiles;

	[Token(Token = "0x40069C5")]
	[FieldOffset(Offset = "0x1C8")]
	protected ILEMHLDCNLK PGOGPNDDJHD;

	[Token(Token = "0x40069C6")]
	[FieldOffset(Offset = "0x1CC")]
	public Transform AimingCameraPos;

	[Token(Token = "0x40069C7")]
	[FieldOffset(Offset = "0x1D0")]
	public Transform HornPos;

	[Token(Token = "0x40069C8")]
	[FieldOffset(Offset = "0x1D4")]
	private GameObject GDHELOPOOKL;

	[Token(Token = "0x40069C9")]
	[FieldOffset(Offset = "0x1D8")]
	private bool JCEFNLCPIAP;

	[Token(Token = "0x40069CA")]
	[FieldOffset(Offset = "0x1D9")]
	private bool CHCLMEMGGJO;

	[Token(Token = "0x40069CB")]
	[FieldOffset(Offset = "0x1DA")]
	public bool IsDuringDrift;

	[Token(Token = "0x40069CC")]
	[FieldOffset(Offset = "0x1DC")]
	private Timer FCPNBIEIPBJ;

	[Token(Token = "0x40069CD")]
	[FieldOffset(Offset = "0x1E0")]
	private Timer JNLDEOFCCPE;

	[Token(Token = "0x40069CE")]
	[FieldOffset(Offset = "0x1E4")]
	private KCOCOJFGMMG AGDEKAGELND;

	[Token(Token = "0x40069CF")]
	private const float HLHKAIPFPPG = 1f;

	[Token(Token = "0x40069D0")]
	[FieldOffset(Offset = "0x1E8")]
	protected bool AHLIMKNJMIC;

	[Token(Token = "0x40069D1")]
	[FieldOffset(Offset = "0x1E9")]
	protected bool ADPOOJBBHNO;

	[Token(Token = "0x40069D2")]
	[FieldOffset(Offset = "0x1EC")]
	public Transform MachineGunRoot;

	[Token(Token = "0x40069D3")]
	[FieldOffset(Offset = "0x1F0")]
	public Transform MachineGunRotY;

	[Token(Token = "0x40069D4")]
	[FieldOffset(Offset = "0x1F4")]
	public Transform MachineGunRotX;

	[Token(Token = "0x40069D5")]
	[FieldOffset(Offset = "0x1F8")]
	public Transform MachineGunFirePoint;

	[Token(Token = "0x40069D6")]
	[FieldOffset(Offset = "0x1FC")]
	public string ImpactConcreteSound;

	[Token(Token = "0x40069D7")]
	[FieldOffset(Offset = "0x200")]
	public string ImpactBodySound;

	[Token(Token = "0x40069D8")]
	[FieldOffset(Offset = "0x204")]
	private bool _003COFCDFGCHNJE_003Ek__BackingField;

	[Token(Token = "0x40069D9")]
	[FieldOffset(Offset = "0x208")]
	private Rigidbody IGFELDFNEKA;

	[Token(Token = "0x40069DA")]
	[FieldOffset(Offset = "0x20C")]
	private float ABMGKFMEJMP;

	[Token(Token = "0x40069DB")]
	[FieldOffset(Offset = "0x210")]
	private float DJBMNLKLABK;

	[Token(Token = "0x40069DC")]
	[FieldOffset(Offset = "0x214")]
	private int JPHKMFCAHKK;

	[Token(Token = "0x40069DD")]
	[FieldOffset(Offset = "0x218")]
	private Vector3 GDFLMELOLIA;

	[Token(Token = "0x40069DE")]
	[FieldOffset(Offset = "0x224")]
	private Vector3 NOJALLOJMIK;

	[Token(Token = "0x40069DF")]
	private const uint JJIPFBLEOHI = 128u;

	[Token(Token = "0x40069E0")]
	private const uint PIJCGBDPOJK = 64u;

	[Token(Token = "0x40069E1")]
	private const uint NAGFAMEBECF = 32u;

	[Token(Token = "0x40069E2")]
	private const uint IFOBIFKLNCG = 31u;

	[Token(Token = "0x40069E3")]
	[FieldOffset(Offset = "0x230")]
	private GameObject ONIGKGJKGFM;

	[Token(Token = "0x40069E4")]
	[FieldOffset(Offset = "0x234")]
	private GameObject EOPMBFPDHAK;

	[Token(Token = "0x40069E5")]
	[FieldOffset(Offset = "0x238")]
	private List<CommonParticleEffect> OAOMKMKKOHJ;

	[Token(Token = "0x40069E6")]
	[FieldOffset(Offset = "0x23C")]
	public float StopBoostCollisionAngle;

	[Token(Token = "0x40069E7")]
	[FieldOffset(Offset = "0x240")]
	public float StopBoostCollisionYAngle;

	[Token(Token = "0x40069E8")]
	[FieldOffset(Offset = "0x244")]
	private List<float> PIGOIHAOJGH;

	[Token(Token = "0x40069E9")]
	[FieldOffset(Offset = "0x248")]
	public FGJEBMEEIGM Weapon;

	[Token(Token = "0x40069EA")]
	[FieldOffset(Offset = "0x24C")]
	public FGJEBMEEIGM SecondaryWeapon;

	[Token(Token = "0x40069EB")]
	[FieldOffset(Offset = "0x250")]
	protected GameObject NONMJIKFANN;

	[Token(Token = "0x40069EC")]
	[FieldOffset(Offset = "0x254")]
	protected Transform CGNABMEHKAN;

	[Token(Token = "0x40069ED")]
	private const float FHKAJHDEBPH = 4f;

	[Token(Token = "0x40069EE")]
	[FieldOffset(Offset = "0x258")]
	private DMPHBOJAAOO OLNALFIIEFN;

	[Token(Token = "0x40069EF")]
	[FieldOffset(Offset = "0x25C")]
	private uint CIJFFFOFJDP;

	[Token(Token = "0x40069F0")]
	[FieldOffset(Offset = "0x260")]
	private uint DMNCGGEFOBB;

	[Token(Token = "0x40069F1")]
	[FieldOffset(Offset = "0x264")]
	private ResourceID MJCLPOIHKNA;

	[Token(Token = "0x40069F2")]
	[FieldOffset(Offset = "0x268")]
	private bool GMBCDNBCFGK;

	[Token(Token = "0x40069F3")]
	[FieldOffset(Offset = "0x26C")]
	private uint ELJPGJOCEEN;

	[Token(Token = "0x40069F4")]
	[FieldOffset(Offset = "0x14")]
	private static Dictionary<string, int> MEOFHMAOFKA;

	[Token(Token = "0x17000861")]
	public VehicleControllerInterface HMMPFJGHDJJ
	{
		[Token(Token = "0x6006377")]
		[Address(RVA = "0xF8CF48", Offset = "0xF8CF48", VA = "0xF8CF48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000862")]
	public virtual CarAudioComponent LNLMNDKBELB
	{
		[Token(Token = "0x6006378")]
		[Address(RVA = "0xF8D004", Offset = "0xF8D004", VA = "0xF8D004", Slot = "72")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000863")]
	public uint NNGLFFLPKOH
	{
		[Token(Token = "0x6006379")]
		[Address(RVA = "0xF8D100", Offset = "0xF8D100", VA = "0xF8D100")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000864")]
	public Vector3 LDIFAEPHCEP
	{
		[Token(Token = "0x600637A")]
		[Address(RVA = "0xF8D2AC", Offset = "0xF8D2AC", VA = "0xF8D2AC")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000865")]
	public IHAAMHPPLMG NDNADFNNPLO
	{
		[Token(Token = "0x600637B")]
		[Address(RVA = "0xF8D31C", Offset = "0xF8D31C", VA = "0xF8D31C")]
		get
		{
			return default(IHAAMHPPLMG);
		}
		[Token(Token = "0x600637C")]
		[Address(RVA = "0xF8D3C0", Offset = "0xF8D3C0", VA = "0xF8D3C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000866")]
	public IHAAMHPPLMG[] CNBLOMLJJBI
	{
		[Token(Token = "0x600637D")]
		[Address(RVA = "0xF8DEC8", Offset = "0xF8DEC8", VA = "0xF8DEC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000867")]
	public float LFNEBCCDLDL
	{
		[Token(Token = "0x600637E")]
		[Address(RVA = "0xF8DF20", Offset = "0xF8DF20", VA = "0xF8DF20")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000868")]
	public Bounds LFGIIBPEHPD
	{
		[Token(Token = "0x600637F")]
		[Address(RVA = "0xF8DF78", Offset = "0xF8DF78", VA = "0xF8DF78")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Bounds);
		}
		[Token(Token = "0x6006380")]
		[Address(RVA = "0xF8DF90", Offset = "0xF8DF90", VA = "0xF8DF90")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000869")]
	public bool OIDOFMNJKLH
	{
		[Token(Token = "0x6006381")]
		[Address(RVA = "0xF8DFB4", Offset = "0xF8DFB4", VA = "0xF8DFB4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700086A")]
	public bool OPMGNCPJPFL
	{
		[Token(Token = "0x6006382")]
		[Address(RVA = "0xF8E00C", Offset = "0xF8E00C", VA = "0xF8E00C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700086B")]
	public virtual bool ABCDIOFOCFE
	{
		[Token(Token = "0x6006383")]
		[Address(RVA = "0xF8E0DC", Offset = "0xF8E0DC", VA = "0xF8E0DC", Slot = "73")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700086C")]
	public virtual bool DNJEEGLHMIG
	{
		[Token(Token = "0x6006384")]
		[Address(RVA = "0xF8E1AC", Offset = "0xF8E1AC", VA = "0xF8E1AC", Slot = "74")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700086D")]
	public bool ONNMIJMOIKN
	{
		[Token(Token = "0x6006385")]
		[Address(RVA = "0xF8E22C", Offset = "0xF8E22C", VA = "0xF8E22C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700086E")]
	public bool FLLFCNGPOLJ
	{
		[Token(Token = "0x6006386")]
		[Address(RVA = "0xF8E284", Offset = "0xF8E284", VA = "0xF8E284")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006387")]
		[Address(RVA = "0xF8E28C", Offset = "0xF8E28C", VA = "0xF8E28C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700086F")]
	public EControlMode COPAJOLGEFL
	{
		[Token(Token = "0x6006388")]
		[Address(RVA = "0xF8E294", Offset = "0xF8E294", VA = "0xF8E294")]
		get
		{
			return default(EControlMode);
		}
	}

	[Token(Token = "0x17000870")]
	public int LJBCNMIFEFJ
	{
		[Token(Token = "0x60063DF")]
		[Address(RVA = "0xF9C61C", Offset = "0xF9C61C", VA = "0xF9C61C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60063E0")]
		[Address(RVA = "0xF9F93C", Offset = "0xF9F93C", VA = "0xF9F93C")]
		set
		{
		}
	}

	[Token(Token = "0x17000871")]
	public int JMFDKFEGFLK
	{
		[Token(Token = "0x60063E1")]
		[Address(RVA = "0xF9C5A4", Offset = "0xF9C5A4", VA = "0xF9C5A4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60063E2")]
		[Address(RVA = "0xFA1E88", Offset = "0xFA1E88", VA = "0xFA1E88")]
		set
		{
		}
	}

	[Token(Token = "0x17000872")]
	public bool LFGMINIEFEL
	{
		[Token(Token = "0x6006404")]
		[Address(RVA = "0xF92520", Offset = "0xF92520", VA = "0xF92520")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000873")]
	public bool BLFIADFFLBO
	{
		[Token(Token = "0x6006405")]
		[Address(RVA = "0xF92D28", Offset = "0xF92D28", VA = "0xF92D28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000874")]
	public bool CDDLEAKCACO
	{
		[Token(Token = "0x6006406")]
		[Address(RVA = "0xFA8834", Offset = "0xFA8834", VA = "0xFA8834")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006376")]
	[Address(RVA = "0xF8CA18", Offset = "0xF8CA18", VA = "0xF8CA18")]
	public Vehicle()
	{
	}

	[Token(Token = "0x6006389")]
	[Address(RVA = "0xF8E35C", Offset = "0xF8E35C", VA = "0xF8E35C", Slot = "56")]
	public override bool IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x600638A")]
	[Address(RVA = "0xF8E3C0", Offset = "0xF8E3C0", VA = "0xF8E3C0", Slot = "59")]
	public override uint GetAttackableID()
	{
		return default(uint);
	}

	[Token(Token = "0x600638B")]
	[Address(RVA = "0xF8E4C0", Offset = "0xF8E4C0", VA = "0xF8E4C0", Slot = "60")]
	public override JADJBFDFEHA GetAttackableType()
	{
		return default(JADJBFDFEHA);
	}

	[Token(Token = "0x600638C")]
	[Address(RVA = "0xF8E518", Offset = "0xF8E518", VA = "0xF8E518", Slot = "75")]
	public virtual void SetEnterLevelTrigger(VehicleCollision AEHLDOHMBFO, Collider KODGAANKJBG, bool KEJJJHEBNLF)
	{
	}

	[Token(Token = "0x600638D")]
	[Address(RVA = "0xF90600", Offset = "0xF90600", VA = "0xF90600", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x600638E")]
	[Address(RVA = "0xF91228", Offset = "0xF91228", VA = "0xF91228", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x600638F")]
	[Address(RVA = "0xF91558", Offset = "0xF91558", VA = "0xF91558", Slot = "76")]
	public virtual void ApplyVechileControl(COGIEJGPDDD AGGIFAEGEPA, Vector3 GDFOEABIGBA)
	{
	}

	[Token(Token = "0x6006390")]
	[Address(RVA = "0xF92584", Offset = "0xF92584", VA = "0xF92584")]
	public static Vector3 ConvertAxisToGasBreak(Vector3 GDFOEABIGBA, out float CEBOGJJHHJI, out float OPNMKPJHDDE, bool PEPHKNGOOFF = true)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6006391")]
	[Address(RVA = "0xF92F30", Offset = "0xF92F30", VA = "0xF92F30")]
	private bool NELILBJLLBH()
	{
		return default(bool);
	}

	[Token(Token = "0x6006392")]
	[Address(RVA = "0xF93060", Offset = "0xF93060", VA = "0xF93060", Slot = "77")]
	protected virtual void FNGMCAAKBDG(bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x6006393")]
	[Address(RVA = "0xF93230", Offset = "0xF93230", VA = "0xF93230")]
	private bool BJMOPBODDIL()
	{
		return default(bool);
	}

	[Token(Token = "0x6006394")]
	[Address(RVA = "0xF932B0", Offset = "0xF932B0", VA = "0xF932B0", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6006395")]
	[Address(RVA = "0xF94E4C", Offset = "0xF94E4C", VA = "0xF94E4C", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6006396")]
	[Address(RVA = "0xF95AA0", Offset = "0xF95AA0", VA = "0xF95AA0")]
	public void CheckAndPlayBeHitVibrate()
	{
	}

	[Token(Token = "0x6006397")]
	[Address(RVA = "0xF95BB8", Offset = "0xF95BB8", VA = "0xF95BB8")]
	public void PlayCollisionVibrate()
	{
	}

	[Token(Token = "0x6006398")]
	[Address(RVA = "0xF95740", Offset = "0xF95740", VA = "0xF95740")]
	private void KNPMMPHPAOA()
	{
	}

	[Token(Token = "0x6006399")]
	[Address(RVA = "0xF95CD0", Offset = "0xF95CD0", VA = "0xF95CD0")]
	private void LCPPCHILLHN()
	{
	}

	[Token(Token = "0x600639A")]
	[Address(RVA = "0xF95DD4", Offset = "0xF95DD4", VA = "0xF95DD4", Slot = "19")]
	public override void OnPaused()
	{
	}

	[Token(Token = "0x600639B")]
	[Address(RVA = "0xF95F40", Offset = "0xF95F40", VA = "0xF95F40", Slot = "20")]
	public override void OnResumed()
	{
	}

	[Token(Token = "0x600639C")]
	[Address(RVA = "0xF960BC", Offset = "0xF960BC", VA = "0xF960BC", Slot = "78")]
	protected virtual void BIEJJKEBHAA()
	{
	}

	[Token(Token = "0x600639D")]
	[Address(RVA = "0xF96278", Offset = "0xF96278", VA = "0xF96278", Slot = "79")]
	public virtual void LockSpeed()
	{
	}

	[Token(Token = "0x600639E")]
	[Address(RVA = "0xF96408", Offset = "0xF96408", VA = "0xF96408", Slot = "80")]
	public virtual void UnLockSpeed()
	{
	}

	[Token(Token = "0x600639F")]
	[Address(RVA = "0xF96544", Offset = "0xF96544", VA = "0xF96544")]
	public void StartAutoDrive()
	{
	}

	[Token(Token = "0x60063A0")]
	[Address(RVA = "0xF92CC0", Offset = "0xF92CC0", VA = "0xF92CC0")]
	public void StopAutoDrive()
	{
	}

	[Token(Token = "0x60063A1")]
	[Address(RVA = "0xF965AC", Offset = "0xF965AC", VA = "0xF965AC")]
	public KLODDDDBAFP GetVehicleData()
	{
		return null;
	}

	[Token(Token = "0x60063A2")]
	[Address(RVA = "0xF96604", Offset = "0xF96604", VA = "0xF96604")]
	public CDPEGEHFLFO GetVehicleAudioData()
	{
		return null;
	}

	[Token(Token = "0x60063A3")]
	[Address(RVA = "0xF9665C", Offset = "0xF9665C", VA = "0xF9665C")]
	public void SetVehicleData(KLODDDDBAFP AJKBOONEOAB, VehicleConfigData KIGCLMKLBKF)
	{
	}

	[Token(Token = "0x60063A4")]
	[Address(RVA = "0xF967C0", Offset = "0xF967C0", VA = "0xF967C0")]
	private void MKBEBNDFJNP(VehicleConfigData KIGCLMKLBKF)
	{
	}

	[Token(Token = "0x60063A5")]
	[Address(RVA = "0xF96AF4", Offset = "0xF96AF4", VA = "0xF96AF4", Slot = "81")]
	protected virtual void MJCHMIADGLP(Dictionary<string, VehicleControllerInfo> CLAKKINOMEO)
	{
	}

	[Token(Token = "0x60063A6")]
	[Address(RVA = "0xF96D70", Offset = "0xF96D70", VA = "0xF96D70")]
	public void ChangeState(bool JEKHEMFKGMK, Player KAEHJEGFKBL, bool LGBFFOLBHHC = false, int LBKILHPDOKD = -1, uint JOHMBDGDHLP = 0u)
	{
	}

	[Token(Token = "0x60063A7")]
	[Address(RVA = "0xF99460", Offset = "0xF99460", VA = "0xF99460")]
	private void KLOOFPGOOEF()
	{
	}

	[Token(Token = "0x60063A8")]
	[Address(RVA = "0xF99278", Offset = "0xF99278", VA = "0xF99278")]
	public int GetPlayerSeat(IHAAMHPPLMG IFOLCOIDJIK)
	{
		return default(int);
	}

	[Token(Token = "0x60063A9")]
	[Address(RVA = "0xF901F0", Offset = "0xF901F0", VA = "0xF901F0")]
	protected bool LNBMCHLENAO()
	{
		return default(bool);
	}

	[Token(Token = "0x60063AA")]
	[Address(RVA = "0xF995B0", Offset = "0xF995B0", VA = "0xF995B0", Slot = "82")]
	protected virtual void NPNBDCPFJDM(float NKPFEBMAAKP)
	{
	}

	[Token(Token = "0x60063AB")]
	[Address(RVA = "0xF996E4", Offset = "0xF996E4", VA = "0xF996E4", Slot = "83")]
	protected virtual void COMNGBEGFJP(bool JGAKJHAPHOA)
	{
	}

	[Token(Token = "0x60063AC")]
	[Address(RVA = "0xF98DB4", Offset = "0xF98DB4", VA = "0xF98DB4")]
	public int GetEmptyPassengerSeat()
	{
		return default(int);
	}

	[Token(Token = "0x60063AD")]
	[Address(RVA = "0xF98F58", Offset = "0xF98F58", VA = "0xF98F58")]
	public bool IsSeatEmpty(int OFKIJKCMPHH)
	{
		return default(bool);
	}

	[Token(Token = "0x60063AE")]
	[Address(RVA = "0xF8D478", Offset = "0xF8D478", VA = "0xF8D478")]
	public bool SetSeat(int OFKIJKCMPHH, IHAAMHPPLMG FKPFJHMFGCJ)
	{
		return default(bool);
	}

	[Token(Token = "0x60063AF")]
	[Address(RVA = "0xF998EC", Offset = "0xF998EC", VA = "0xF998EC")]
	public void SyncStateWithServer(Vector3 ACCOJJMKKPM, Quaternion JGOGIAFGCFC, byte AMKOKEMABDM)
	{
	}

	[Token(Token = "0x60063B0")]
	[Address(RVA = "0xF99A10", Offset = "0xF99A10", VA = "0xF99A10")]
	public void InitState(Vector3 ACCOJJMKKPM, Quaternion JGOGIAFGCFC, bool MJMIHEENKEG, List<PDMPKNHNMIC> EBMMBMJNCLA)
	{
	}

	[Token(Token = "0x60063B1")]
	[Address(RVA = "0xF9AF48", Offset = "0xF9AF48", VA = "0xF9AF48")]
	public void PushSyncState(KCNKCFAMFGO HKAABMDNNAG, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x60063B2")]
	[Address(RVA = "0xF9B674", Offset = "0xF9B674", VA = "0xF9B674")]
	public void PushSyncSimplePosition(PGKDAKKEOCO CCNKEFBKJNK, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x60063B3")]
	[Address(RVA = "0xF9B4B0", Offset = "0xF9B4B0", VA = "0xF9B4B0")]
	private void PKGCIELHMLO(uint LPJONPCPBED, uint BLOANDINMIH)
	{
	}

	[Token(Token = "0x60063B4")]
	[Address(RVA = "0xF9B790", Offset = "0xF9B790", VA = "0xF9B790", Slot = "84")]
	protected virtual void JKCBPIGHJJA()
	{
	}

	[Token(Token = "0x60063B5")]
	[Address(RVA = "0xF9CCC4", Offset = "0xF9CCC4", VA = "0xF9CCC4")]
	public void SyncTransform(Vector3 ACCOJJMKKPM, Quaternion JGOGIAFGCFC)
	{
	}

	[Token(Token = "0x60063B6")]
	[Address(RVA = "0xF9C074", Offset = "0xF9C074", VA = "0xF9C074")]
	private void PDBFNJGMMDC(bool FICNJIMKAEF)
	{
	}

	[Token(Token = "0x60063B7")]
	[Address(RVA = "0xF9CDE0", Offset = "0xF9CDE0", VA = "0xF9CDE0")]
	public void SetupCamera(VehicleDriverCamera KFGFLKFGPBA)
	{
	}

	[Token(Token = "0x60063B8")]
	[Address(RVA = "0xF9CEF4", Offset = "0xF9CEF4", VA = "0xF9CEF4")]
	public void SetupCamera(VehiclePassengerCamera KFGFLKFGPBA)
	{
	}

	[Token(Token = "0x60063B9")]
	[Address(RVA = "0xF9D0B4", Offset = "0xF9D0B4", VA = "0xF9D0B4")]
	public byte GetCurrentPackedOp()
	{
		return default(byte);
	}

	[Token(Token = "0x60063BA")]
	[Address(RVA = "0xF9B3A4", Offset = "0xF9B3A4", VA = "0xF9B3A4")]
	public float GetSteeringFromPackedOp(byte FJNMLACBEPB)
	{
		return default(float);
	}

	[Token(Token = "0x60063BB")]
	[Address(RVA = "0xF90B4C", Offset = "0xF90B4C", VA = "0xF90B4C")]
	private void NFACKALEKEO(LPMLHDAIIGO DHIJHDLCFPH, uint OLDEOBHDPLC = 0u)
	{
	}

	[Token(Token = "0x60063BC")]
	[Address(RVA = "0xF90F88", Offset = "0xF90F88", VA = "0xF90F88")]
	private void HBLNGCJMOEI()
	{
	}

	[Token(Token = "0x60063BD")]
	[Address(RVA = "0xF9C1AC", Offset = "0xF9C1AC", VA = "0xF9C1AC")]
	private void AGAHELJKNIC(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x60063BE")]
	[Address(RVA = "0xF9BFA8", Offset = "0xF9BFA8", VA = "0xF9BFA8")]
	private void MMFBADLMOMJ(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x60063BF")]
	[Address(RVA = "0xF9D8EC", Offset = "0xF9D8EC", VA = "0xF9D8EC", Slot = "85")]
	public virtual void SetVisibility(uint EBOJJLIHHCM, bool GKCPPPINMPB)
	{
	}

	[Token(Token = "0x60063C0")]
	[Address(RVA = "0xF9E798", Offset = "0xF9E798", VA = "0xF9E798", Slot = "62")]
	public Vector3 GetCameraTrackableEntityPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60063C1")]
	[Address(RVA = "0xF9E828", Offset = "0xF9E828", VA = "0xF9E828", Slot = "64")]
	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x60063C2")]
	[Address(RVA = "0xF9E8FC", Offset = "0xF9E8FC", VA = "0xF9E8FC", Slot = "63")]
	public Vector3 GetCameraTrackableEntityTopPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60063C3")]
	[Address(RVA = "0xF9EB14", Offset = "0xF9EB14", VA = "0xF9EB14", Slot = "65")]
	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	[Token(Token = "0x60063C4")]
	[Address(RVA = "0xF9EB78", Offset = "0xF9EB78", VA = "0xF9EB78", Slot = "66")]
	public bool IsCameraTrackableEntityAlive()
	{
		return default(bool);
	}

	[Token(Token = "0x60063C5")]
	[Address(RVA = "0xF9EBE0", Offset = "0xF9EBE0", VA = "0xF9EBE0")]
	private CommonParticleEffect FLBGIABDFNL(ResourceID GJMJJFAOBEL, ResourceID DDDJHDHBFJB, Transform PHLFBBIAEFE)
	{
		return null;
	}

	[Token(Token = "0x60063C6")]
	[Address(RVA = "0xF9F204", Offset = "0xF9F204", VA = "0xF9F204", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x60063C7")]
	[Address(RVA = "0xF99F88", Offset = "0xF99F88", VA = "0xF99F88")]
	public void Dead(float FJOLJBDLEOF)
	{
	}

	[Token(Token = "0x60063C8")]
	[Address(RVA = "0xF9A61C", Offset = "0xF9A61C", VA = "0xF9A61C")]
	public void Explode(float FGICMPFOBEO)
	{
	}

	[Token(Token = "0x60063C9")]
	[Address(RVA = "0xF9FF94", Offset = "0xF9FF94", VA = "0xF9FF94", Slot = "23")]
	protected override void OnUpdateVisibleStateByStreamer(Vector3 MKGCDPNKMOB, Vector3 OANAHFHPBNB)
	{
	}

	[Token(Token = "0x60063CA")]
	[Address(RVA = "0xF9FB30", Offset = "0xF9FB30", VA = "0xF9FB30")]
	private void LAPMCEINJJM()
	{
	}

	[Token(Token = "0x60063CB")]
	[Address(RVA = "0xF9E4C0", Offset = "0xF9E4C0", VA = "0xF9E4C0")]
	private void IANFAOKDBAO()
	{
	}

	[Token(Token = "0x60063CC")]
	[Address(RVA = "0xFA054C", Offset = "0xFA054C", VA = "0xFA054C")]
	private void PABLEPLIAIE()
	{
	}

	[Token(Token = "0x60063CD")]
	[Address(RVA = "0xFA061C", Offset = "0xFA061C", VA = "0xFA061C")]
	private void NPNKCDICFGG()
	{
	}

	[Token(Token = "0x60063CE")]
	[Address(RVA = "0xFA01D0", Offset = "0xFA01D0", VA = "0xFA01D0")]
	private void GLIJACGAGBL(ResourceID KMIPBIGPDPI, ref GameObject BLNCAIJNJPF, ResourceID LMKMNAFNNJJ)
	{
	}

	[Token(Token = "0x60063CF")]
	[Address(RVA = "0xFA0400", Offset = "0xFA0400", VA = "0xFA0400")]
	private void MKBKBKHNPPE(ref GameObject BLNCAIJNJPF)
	{
	}

	[Token(Token = "0x60063D0")]
	[Address(RVA = "0xF9E524", Offset = "0xF9E524", VA = "0xF9E524")]
	private void BMIKLKEKFNN()
	{
	}

	[Token(Token = "0x60063D1")]
	[Address(RVA = "0xF9FC00", Offset = "0xF9FC00", VA = "0xF9FC00")]
	private IEnumerator JCPOHDCJACA(float BLHEBBCODLC, CommonParticleEffect GJMJJFAOBEL)
	{
		return null;
	}

	[Token(Token = "0x60063D2")]
	[Address(RVA = "0xF9C694", Offset = "0xF9C694", VA = "0xF9C694")]
	public void CheckAndStartSmoke(float MLFADFBDCGJ)
	{
	}

	[Token(Token = "0x60063D3")]
	[Address(RVA = "0xFA0680", Offset = "0xFA0680", VA = "0xFA0680")]
	private void EICJLGAMOKN()
	{
	}

	[Token(Token = "0x60063D4")]
	[Address(RVA = "0xFA08D4", Offset = "0xFA08D4", VA = "0xFA08D4")]
	private CommonParticleEffect NJFIMONDLHD(Vector3 MLCIHBOHEHE, ResourceID KMIPBIGPDPI)
	{
		return null;
	}

	[Token(Token = "0x60063D5")]
	[Address(RVA = "0xF9E2AC", Offset = "0xF9E2AC", VA = "0xF9E2AC")]
	private void CGJIPGPGDJE()
	{
	}

	[Token(Token = "0x60063D6")]
	[Address(RVA = "0xF92D8C", Offset = "0xF92D8C", VA = "0xF92D8C")]
	public void SendBrakeLightState(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x60063D7")]
	[Address(RVA = "0xFA0E08", Offset = "0xFA0E08", VA = "0xFA0E08")]
	public void SyncBrakeLight(bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x60063D8")]
	[Address(RVA = "0xF89E08", Offset = "0xF89E08", VA = "0xF89E08")]
	public void SendHornState(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x60063D9")]
	[Address(RVA = "0xFA0FA8", Offset = "0xFA0FA8", VA = "0xFA0FA8")]
	public void SyncHorn(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x60063DA")]
	[Address(RVA = "0xFA138C", Offset = "0xFA138C", VA = "0xFA138C")]
	public void SendGearVFXState()
	{
	}

	[Token(Token = "0x60063DB")]
	[Address(RVA = "0xFA1568", Offset = "0xFA1568", VA = "0xFA1568")]
	public void EnableGearVFX()
	{
	}

	[Token(Token = "0x60063DC")]
	[Address(RVA = "0xFA1B10", Offset = "0xFA1B10", VA = "0xFA1B10")]
	public void OnVehicleReset()
	{
	}

	[Token(Token = "0x60063DD")]
	[Address(RVA = "0xFA1C64", Offset = "0xFA1C64", VA = "0xFA1C64")]
	public void NotifyServerGotForceSyncInfo(uint HGIILPEDFDI, uint IAKABEJPKAE)
	{
	}

	[Token(Token = "0x60063DE")]
	[Address(RVA = "0xFA1E30", Offset = "0xFA1E30", VA = "0xFA1E30", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60063E3")]
	[Address(RVA = "0xFA1F0C", Offset = "0xFA1F0C", VA = "0xFA1F0C")]
	public bool IsLowSpeed()
	{
		return default(bool);
	}

	[Token(Token = "0x60063E4")]
	[Address(RVA = "0xFA2014", Offset = "0xFA2014", VA = "0xFA2014")]
	public bool IsMiddleSpeed()
	{
		return default(bool);
	}

	[Token(Token = "0x60063E5")]
	[Address(RVA = "0xFA2190", Offset = "0xFA2190", VA = "0xFA2190")]
	public bool IsHighSpeed()
	{
		return default(bool);
	}

	[Token(Token = "0x60063E6")]
	[Address(RVA = "0xFA2308", Offset = "0xFA2308", VA = "0xFA2308")]
	public bool IsDustMaxSpeed()
	{
		return default(bool);
	}

	[Token(Token = "0x60063E7")]
	[Address(RVA = "0xFA240C", Offset = "0xFA240C", VA = "0xFA240C")]
	public float GetResetLeftTime()
	{
		return default(float);
	}

	[Token(Token = "0x60063E8")]
	[Address(RVA = "0xF8D1A4", Offset = "0xF8D1A4", VA = "0xF8D1A4", Slot = "67")]
	public Vector3 GetVelocity()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60063E9")]
	[Address(RVA = "0xF9F9C0", Offset = "0xF9F9C0", VA = "0xF9F9C0")]
	public bool IsLocalPlayerOnBoard()
	{
		return default(bool);
	}

	[Token(Token = "0x60063EA")]
	[Address(RVA = "0xFA2464", Offset = "0xFA2464", VA = "0xFA2464")]
	public bool IsTeammateOnBoard()
	{
		return default(bool);
	}

	[Token(Token = "0x60063EB")]
	[Address(RVA = "0xF90400", Offset = "0xF90400", VA = "0xF90400")]
	public bool IsDriverLocalPlayer()
	{
		return default(bool);
	}

	[Token(Token = "0x60063EC")]
	[Address(RVA = "0xFA26A4", Offset = "0xFA26A4", VA = "0xFA26A4")]
	public bool HasTeammatesOnBoard(IHAAMHPPLMG KLDFIDFAMMJ, IHAAMHPPLMG EBMNOJGKOOJ)
	{
		return default(bool);
	}

	[Token(Token = "0x60063ED")]
	[Address(RVA = "0xFA2A6C", Offset = "0xFA2A6C", VA = "0xFA2A6C")]
	public bool HasNonTeammateOnBoard(IHAAMHPPLMG KLDFIDFAMMJ)
	{
		return default(bool);
	}

	[Token(Token = "0x60063EE")]
	[Address(RVA = "0xFA2E28", Offset = "0xFA2E28", VA = "0xFA2E28")]
	public void CollisionEnter(Collider JENOOGOLOKN, bool KFIHFEGMNGD, Vector3 ICCGANKNHDC)
	{
	}

	[Token(Token = "0x60063EF")]
	[Address(RVA = "0xFA6154", Offset = "0xFA6154", VA = "0xFA6154", Slot = "86")]
	protected virtual void OnCollisionEnter(Collision JENOOGOLOKN)
	{
	}

	[Token(Token = "0x60063F0")]
	[Address(RVA = "0xFA6BE8", Offset = "0xFA6BE8", VA = "0xFA6BE8")]
	private SwitchBase KKPIKKNBKNO(Collider JENOOGOLOKN)
	{
		return null;
	}

	[Token(Token = "0x60063F1")]
	[Address(RVA = "0xFA37E0", Offset = "0xFA37E0", VA = "0xFA37E0")]
	private void DFAMNLNNOFE(Collider JENOOGOLOKN, bool KFIHFEGMNGD, Vector3 ICCGANKNHDC)
	{
	}

	[Token(Token = "0x60063F2")]
	[Address(RVA = "0xFA4B20", Offset = "0xFA4B20", VA = "0xFA4B20")]
	private void MLNIKEMBJPK(Collider JENOOGOLOKN, bool KFIHFEGMNGD, Vector3 ICCGANKNHDC)
	{
	}

	[Token(Token = "0x60063F3")]
	[Address(RVA = "0xFA3014", Offset = "0xFA3014", VA = "0xFA3014")]
	private void PBIGCDJEBGP(Collider JENOOGOLOKN, bool KFIHFEGMNGD, Vector3 ICCGANKNHDC, float MOJPLNHCILN)
	{
	}

	[Token(Token = "0x60063F4")]
	[Address(RVA = "0xFA6598", Offset = "0xFA6598", VA = "0xFA6598")]
	private void IFGDADDHLIP(Collision JENOOGOLOKN)
	{
	}

	[Token(Token = "0x60063F5")]
	[Address(RVA = "0xFA79AC", Offset = "0xFA79AC", VA = "0xFA79AC")]
	public string[] GetVehicleDynamicAnimClipRes()
	{
		return null;
	}

	[Token(Token = "0x60063F6")]
	[Address(RVA = "0xFA7A1C", Offset = "0xFA7A1C", VA = "0xFA7A1C")]
	public int GetAnimPose(IHAAMHPPLMG FKPFJHMFGCJ)
	{
		return default(int);
	}

	[Token(Token = "0x60063F7")]
	[Address(RVA = "0xFA7100", Offset = "0xFA7100", VA = "0xFA7100")]
	private static int AMCKKFLNDMF(Vehicle FFJODNENOJL)
	{
		return default(int);
	}

	[Token(Token = "0x60063F8")]
	[Address(RVA = "0xFA731C", Offset = "0xFA731C", VA = "0xFA731C")]
	protected float DKCIMAIPJKM(float KOCMLPLOILD)
	{
		return default(float);
	}

	[Token(Token = "0x60063F9")]
	[Address(RVA = "0xFA74D0", Offset = "0xFA74D0", VA = "0xFA74D0")]
	private void CDDKPOHMGNB(int JLKLMFHFHFF, IHAAMHPPLMG HLJDHPGGODB, float IOOPPDAAMEP)
	{
	}

	[Token(Token = "0x60063FA")]
	[Address(RVA = "0xFA6F30", Offset = "0xFA6F30", VA = "0xFA6F30")]
	private bool EDCLBJAGAIJ(int LODDOINFPPA, float KDFABBOCHLC)
	{
		return default(bool);
	}

	[Token(Token = "0x60063FB")]
	[Address(RVA = "0xFA7C60", Offset = "0xFA7C60", VA = "0xFA7C60", Slot = "87")]
	public virtual void SyncChangeShape(byte PHEJDNJONIL)
	{
	}

	[Token(Token = "0x60063FC")]
	[Address(RVA = "0xFA7D10", Offset = "0xFA7D10", VA = "0xFA7D10", Slot = "88")]
	public virtual void SendChangeShape()
	{
	}

	[Token(Token = "0x60063FD")]
	[Address(RVA = "0xFA7D64", Offset = "0xFA7D64", VA = "0xFA7D64", Slot = "89")]
	public virtual void SyncParachuteState(byte GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x60063FE")]
	[Address(RVA = "0xFA7DC0", Offset = "0xFA7DC0", VA = "0xFA7DC0")]
	public bool IsLocalAuth()
	{
		return default(bool);
	}

	[Token(Token = "0x60063FF")]
	[Address(RVA = "0xFA7E24", Offset = "0xFA7E24", VA = "0xFA7E24")]
	public void SyncChangeAuth(bool OBCDPPCEIDP, uint OLDEOBHDPLC)
	{
	}

	[Token(Token = "0x6006400")]
	[Address(RVA = "0xFA7EC8", Offset = "0xFA7EC8", VA = "0xFA7EC8")]
	public void SyncChangeSeat(PDMPKNHNMIC CHKJECEDAKA, PDMPKNHNMIC JFNCAGPNJGF, float AKAJHMHFKMG)
	{
	}

	[Token(Token = "0x6006401")]
	[Address(RVA = "0xF94398", Offset = "0xF94398", VA = "0xF94398")]
	private void DNGOLPMHHJF()
	{
	}

	[Token(Token = "0x6006402")]
	[Address(RVA = "0xFA874C", Offset = "0xFA874C", VA = "0xFA874C")]
	public bool HasPendingChangeSeatRequest()
	{
		return default(bool);
	}

	[Token(Token = "0x6006403")]
	[Address(RVA = "0xF94880", Offset = "0xF94880", VA = "0xF94880")]
	private void HOKKFOHMIEN(PDMPKNHNMIC CHKJECEDAKA, PDMPKNHNMIC JFNCAGPNJGF)
	{
	}

	[Token(Token = "0x6006407")]
	[Address(RVA = "0xFA88A0", Offset = "0xFA88A0", VA = "0xFA88A0")]
	protected MKOHELJKKDL BFJLJCJNCID(PPPNNCOCOOI HGMBMICDALC)
	{
		return null;
	}

	[Token(Token = "0x6006408")]
	[Address(RVA = "0xFA87B0", Offset = "0xFA87B0", VA = "0xFA87B0")]
	protected bool KJMEFCIAACJ(PPPNNCOCOOI HGMBMICDALC)
	{
		return default(bool);
	}

	[Token(Token = "0x6006409")]
	[Address(RVA = "0xF9978C", Offset = "0xF9978C", VA = "0xF9978C")]
	public void StopUseItem(PPPNNCOCOOI HGMBMICDALC)
	{
	}

	[Token(Token = "0x600640A")]
	[Address(RVA = "0xF99848", Offset = "0xF99848", VA = "0xF99848")]
	protected void NKHBEIGCLDG(PPPNNCOCOOI HGMBMICDALC, bool GKKJKNFJGBN)
	{
	}

	[Token(Token = "0x600640B")]
	[Address(RVA = "0xFA8974", Offset = "0xFA8974", VA = "0xFA8974")]
	public bool CanJump()
	{
		return default(bool);
	}

	[Token(Token = "0x600640C")]
	[Address(RVA = "0xFA89E0", Offset = "0xFA89E0", VA = "0xFA89E0", Slot = "90")]
	public virtual bool IsGranded()
	{
		return default(bool);
	}

	[Token(Token = "0x600640D")]
	[Address(RVA = "0xFA8B08", Offset = "0xFA8B08", VA = "0xFA8B08")]
	public bool InWaterAndShouldBreak()
	{
		return default(bool);
	}

	[Token(Token = "0x600640E")]
	[Address(RVA = "0xFA8B88", Offset = "0xFA8B88", VA = "0xFA8B88")]
	public void AddWeapon(FGJEBMEEIGM LPLPBJGAPHK)
	{
	}

	[Token(Token = "0x600640F")]
	[Address(RVA = "0xFA8CB4", Offset = "0xFA8CB4", VA = "0xFA8CB4")]
	public void ActiveWeapon(FGJEBMEEIGM LPLPBJGAPHK)
	{
	}

	[Token(Token = "0x6006410")]
	[Address(RVA = "0xFA8DC0", Offset = "0xFA8DC0", VA = "0xFA8DC0", Slot = "91")]
	public virtual void InitStateWithPlayer(bool LAEJNDBBKGK, byte CMBHDPFEGFJ, Player BONOAOGGOGH, bool LGBFFOLBHHC = false, int LBKILHPDOKD = -1)
	{
	}

	[Token(Token = "0x6006411")]
	[Address(RVA = "0xFA8E68", Offset = "0xFA8E68", VA = "0xFA8E68", Slot = "92")]
	public virtual void StartOnBoard()
	{
	}

	[Token(Token = "0x6006412")]
	[Address(RVA = "0xFA8EBC", Offset = "0xFA8EBC", VA = "0xFA8EBC", Slot = "93")]
	public virtual void StartSkyDiving()
	{
	}

	[Token(Token = "0x6006413")]
	[Address(RVA = "0xFA8F10", Offset = "0xFA8F10", VA = "0xFA8F10", Slot = "94")]
	public virtual void StartParachute()
	{
	}

	[Token(Token = "0x6006414")]
	[Address(RVA = "0xFA8F64", Offset = "0xFA8F64", VA = "0xFA8F64", Slot = "95")]
	public virtual bool IsInParachuteJumpState()
	{
		return default(bool);
	}

	[Token(Token = "0x6006415")]
	[Address(RVA = "0xFA8FBC", Offset = "0xFA8FBC", VA = "0xFA8FBC", Slot = "96")]
	public virtual void OnBevActionCome()
	{
	}

	[Token(Token = "0x6006416")]
	[Address(RVA = "0xFA9010", Offset = "0xFA9010", VA = "0xFA9010", Slot = "97")]
	public virtual bool IsOnBoard()
	{
		return default(bool);
	}

	[Token(Token = "0x6006417")]
	[Address(RVA = "0xFA9068", Offset = "0xFA9068", VA = "0xFA9068", Slot = "98")]
	public virtual void StopParachutEffect()
	{
	}

	[Token(Token = "0x6006418")]
	[Address(RVA = "0xFA90BC", Offset = "0xFA90BC", VA = "0xFA90BC", Slot = "99")]
	public virtual void SyncAirDropState(byte IKDGBAFFHJB)
	{
	}

	[Token(Token = "0x6006419")]
	[Address(RVA = "0xFA9158", Offset = "0xFA9158", VA = "0xFA9158")]
	private void HANFFHLAFAP()
	{
	}

	[Token(Token = "0x600641A")]
	[Address(RVA = "0xFA940C", Offset = "0xFA940C", VA = "0xFA940C")]
	private void CFCDLBMEPIP()
	{
	}

	[Token(Token = "0x600641B")]
	[Address(RVA = "0xF9FD20", Offset = "0xF9FD20", VA = "0xF9FD20")]
	private void NGIGCKAKMEL()
	{
	}

	[Token(Token = "0x600641C")]
	[Address(RVA = "0xF9412C", Offset = "0xF9412C", VA = "0xF9412C")]
	private void BEHDFDDFCGJ(Vector3 PBNCJJAPDIJ)
	{
	}

	[Token(Token = "0x600641D")]
	[Address(RVA = "0xF9E628", Offset = "0xF9E628", VA = "0xF9E628")]
	protected void NJNJFJEPLKA(bool JOGHOHLEJFL)
	{
	}

	[Token(Token = "0x600641E")]
	[Address(RVA = "0xFA9570", Offset = "0xFA9570", VA = "0xFA9570", Slot = "68")]
	public void Mount(int HHLONFLCJBL, LevelMissile FGPDCJOPPJD)
	{
	}

	[Token(Token = "0x600641F")]
	[Address(RVA = "0xFA9B94", Offset = "0xFA9B94", VA = "0xFA9B94")]
	private void PMNFEMFLPEA(int HHLONFLCJBL, LevelMissile FGPDCJOPPJD)
	{
	}

	[Token(Token = "0x6006420")]
	[Address(RVA = "0xFA9E88", Offset = "0xFA9E88", VA = "0xFA9E88", Slot = "69")]
	public void UnMount(int HHLONFLCJBL, LevelMissile FGPDCJOPPJD)
	{
	}

	[Token(Token = "0x6006421")]
	[Address(RVA = "0xF9FD80", Offset = "0xF9FD80", VA = "0xF9FD80", Slot = "70")]
	public void ReleaseMounted()
	{
	}

	[Token(Token = "0x6006422")]
	[Address(RVA = "0xF98C84", Offset = "0xF98C84", VA = "0xF98C84")]
	public void OpenDriverFireHudInNeed()
	{
	}

	[Token(Token = "0x6006423")]
	[Address(RVA = "0xF99148", Offset = "0xF99148", VA = "0xF99148")]
	public void OpenPassengerSkillHudInNeed()
	{
	}

	[Token(Token = "0x6006424")]
	[Address(RVA = "0xF912A4", Offset = "0xF912A4", VA = "0xF912A4")]
	private void JMPIHFEBONJ(bool MMIAGJPKKLN = false)
	{
	}

	[Token(Token = "0x6006425")]
	[Address(RVA = "0xF98B68", Offset = "0xF98B68", VA = "0xF98B68")]
	private void MLCHKKIEEHF()
	{
	}

	[Token(Token = "0x6006426")]
	[Address(RVA = "0xFAA068", Offset = "0xFAA068", VA = "0xFAA068", Slot = "100")]
	public virtual void SyncVehicleSkin(uint NNLGCENNDBM, bool BBKJMMEJCBN = false)
	{
	}

	[Token(Token = "0x6006427")]
	[Address(RVA = "0xF9D76C", Offset = "0xF9D76C", VA = "0xF9D76C")]
	public void SwitchVehicleSkinBuff()
	{
	}

	[Token(Token = "0x6006428")]
	[Address(RVA = "0xF9D514", Offset = "0xF9D514", VA = "0xF9D514")]
	public static VehicleSkinInfoBase GetSkinInfoFromPool(ResourceID AHFEGJCBIHK)
	{
		return null;
	}

	[Token(Token = "0x6006429")]
	[Address(RVA = "0xFAA700", Offset = "0xFAA700", VA = "0xFAA700")]
	protected void GJGPHFCABEM(ResourceID OHHBPLBFNGD, bool EODMFNHFGKB)
	{
	}

	[Token(Token = "0x600642A")]
	[Address(RVA = "0xF9BD50", Offset = "0xF9BD50", VA = "0xF9BD50")]
	private void NODFPMGEMFE()
	{
	}

	[Token(Token = "0x600642B")]
	[Address(RVA = "0xFAAB80", Offset = "0xFAAB80", VA = "0xFAAB80")]
	private void NJLMPDGBBPF(uint LPFMNBCHJPE, bool FALMPPMFJFN, Object ECINOMEHBKA)
	{
	}

	[Token(Token = "0x600642C")]
	[Address(RVA = "0xF9140C", Offset = "0xF9140C", VA = "0xF9140C")]
	private void FMLLKFAKAIL(bool BNPFEMAICEL)
	{
	}

	[Token(Token = "0x600642D")]
	[Address(RVA = "0xFAAD58", Offset = "0xFAAD58", VA = "0xFAAD58", Slot = "101")]
	protected virtual void AJMKGJMHMOL([Optional] VehicleSkinInfoBase MEIAMJMMECB)
	{
	}

	[Token(Token = "0x600642E")]
	[Address(RVA = "0xFAB62C", Offset = "0xFAB62C", VA = "0xFAB62C", Slot = "102")]
	public virtual void ChangeProperty(string BFBMDJAICGD, float KKFLFMACNKA)
	{
	}

	[Token(Token = "0x6006430")]
	[Address(RVA = "0xFAC710", Offset = "0xFAC710", VA = "0xFAC710")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x6006431")]
	[Address(RVA = "0xFAC718", Offset = "0xFAC718", VA = "0xFAC718")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6006432")]
	[Address(RVA = "0xFAC720", Offset = "0xFAC720", VA = "0xFAC720")]
	public bool _003C_003EiFixBaseProxy_IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6006433")]
	[Address(RVA = "0xFAC728", Offset = "0xFAC728", VA = "0xFAC728")]
	public uint _003C_003EiFixBaseProxy_GetAttackableID()
	{
		return default(uint);
	}

	[Token(Token = "0x6006434")]
	[Address(RVA = "0xFAC730", Offset = "0xFAC730", VA = "0xFAC730")]
	public JADJBFDFEHA _003C_003EiFixBaseProxy_GetAttackableType()
	{
		return default(JADJBFDFEHA);
	}

	[Token(Token = "0x6006435")]
	[Address(RVA = "0xFAC738", Offset = "0xFAC738", VA = "0xFAC738")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x6006436")]
	[Address(RVA = "0xFAC740", Offset = "0xFAC740", VA = "0xFAC740")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6006437")]
	[Address(RVA = "0xFAC748", Offset = "0xFAC748", VA = "0xFAC748")]
	public void _003C_003EiFixBaseProxy_OnPaused()
	{
	}

	[Token(Token = "0x6006438")]
	[Address(RVA = "0xFAC750", Offset = "0xFAC750", VA = "0xFAC750")]
	public void _003C_003EiFixBaseProxy_OnResumed()
	{
	}

	[Token(Token = "0x6006439")]
	[Address(RVA = "0xFAC758", Offset = "0xFAC758", VA = "0xFAC758")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}

	[Token(Token = "0x600643A")]
	[Address(RVA = "0xFAC77C", Offset = "0xFAC77C", VA = "0xFAC77C")]
	public void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}
}
