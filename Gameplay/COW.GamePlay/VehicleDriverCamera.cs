using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000435")]
internal class VehicleDriverCamera : VehicleCameraBase
{
	[Token(Token = "0x2000436")]
	private enum MMOJIFPIFAP
	{
		[Token(Token = "0x4003BFB")]
		None,
		[Token(Token = "0x4003BFC")]
		PreMove,
		[Token(Token = "0x4003BFD")]
		Aiming,
		[Token(Token = "0x4003BFE")]
		PostMove
	}

	[Token(Token = "0x2000437")]
	private class LKLJODFHLLE
	{
		[Token(Token = "0x4003BFF")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 BFKFNCGPPLC;

		[Token(Token = "0x4003C00")]
		[FieldOffset(Offset = "0x14")]
		public Quaternion DBFHJHBDBFF;

		[Token(Token = "0x600150F")]
		[Address(RVA = "0x26EB2B0", Offset = "0x26EB2B0", VA = "0x26EB2B0")]
		public LKLJODFHLLE()
		{
		}
	}

	[Token(Token = "0x2000438")]
	private class BKOHPCEEKHE
	{
		[Token(Token = "0x4003C01")]
		[FieldOffset(Offset = "0x8")]
		private float[] AJKBOONEOAB;

		[Token(Token = "0x4003C02")]
		[FieldOffset(Offset = "0xC")]
		private int JLFLJKCNCKD;

		[Token(Token = "0x4003C03")]
		[FieldOffset(Offset = "0x10")]
		private int LIPEOGCNOPA;

		[Token(Token = "0x4003C04")]
		[FieldOffset(Offset = "0x14")]
		private int PFEDMBDKCLP;

		[Token(Token = "0x4003C05")]
		[FieldOffset(Offset = "0x18")]
		private float _003CAANLKNDCDAG_003Ek__BackingField;

		[Token(Token = "0x170001D7")]
		public float ANLOCGKJGHP
		{
			[Token(Token = "0x6001511")]
			[Address(RVA = "0x26EB3EC", Offset = "0x26EB3EC", VA = "0x26EB3EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6001512")]
			[Address(RVA = "0x26EB3F4", Offset = "0x26EB3F4", VA = "0x26EB3F4")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001D8")]
		public int HFPGENNDGME
		{
			[Token(Token = "0x6001513")]
			[Address(RVA = "0x26EB3FC", Offset = "0x26EB3FC", VA = "0x26EB3FC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6001510")]
		[Address(RVA = "0x26E7690", Offset = "0x26E7690", VA = "0x26E7690")]
		public BKOHPCEEKHE(int BMHOCKOEODD)
		{
		}

		[Token(Token = "0x6001514")]
		[Address(RVA = "0x26E770C", Offset = "0x26E770C", VA = "0x26E770C")]
		public float LPHJCCHJNNE(float BLHEBBCODLC)
		{
			return default(float);
		}

		[Token(Token = "0x6001515")]
		[Address(RVA = "0x26E7870", Offset = "0x26E7870", VA = "0x26E7870")]
		public float POMILHBLFAF()
		{
			return default(float);
		}
	}

	[Token(Token = "0x4003BD2")]
	[FieldOffset(Offset = "0x0")]
	public static VehicleDriverCamera Instance;

	[Token(Token = "0x4003BD3")]
	[FieldOffset(Offset = "0x6C")]
	public int Samples;

	[Token(Token = "0x4003BD4")]
	[FieldOffset(Offset = "0x70")]
	public float AccThreshold;

	[Token(Token = "0x4003BD5")]
	[FieldOffset(Offset = "0x74")]
	public float MaxAdditionalDist;

	[Token(Token = "0x4003BD6")]
	[FieldOffset(Offset = "0x78")]
	public float MinAdditionalDist;

	[Token(Token = "0x4003BD7")]
	[FieldOffset(Offset = "0x7C")]
	public float m_CurrentAdditionalDist;

	[Token(Token = "0x4003BD8")]
	[FieldOffset(Offset = "0x80")]
	public float AdditionalDistAccSpeed;

	[Token(Token = "0x4003BD9")]
	[FieldOffset(Offset = "0x84")]
	public float AdditionalDistDecSpeed;

	[Token(Token = "0x4003BDA")]
	[FieldOffset(Offset = "0x88")]
	public float AdditionalDistLerpSpeed;

	[Token(Token = "0x4003BDB")]
	[FieldOffset(Offset = "0x8C")]
	public bool DetailedCollisionChecks;

	[Token(Token = "0x4003BDC")]
	[FieldOffset(Offset = "0x8D")]
	public bool TransToWantedHeightOnce;

	[Token(Token = "0x4003BDD")]
	[FieldOffset(Offset = "0x90")]
	private Vehicle NOLNFIAPLND;

	[Token(Token = "0x4003BDE")]
	[FieldOffset(Offset = "0x94")]
	private Transform BKIIMNOJOKP;

	[Token(Token = "0x4003BDF")]
	[FieldOffset(Offset = "0x98")]
	private bool ALKNIFGNPJJ;

	[Token(Token = "0x4003BE0")]
	[FieldOffset(Offset = "0x9C")]
	private BKOHPCEEKHE OOKFNAAFANK;

	[Token(Token = "0x4003BE1")]
	[FieldOffset(Offset = "0xA0")]
	private BKOHPCEEKHE KJEDLMILPMC;

	[Token(Token = "0x4003BE2")]
	[FieldOffset(Offset = "0xA4")]
	private UserControlAxisData BBKEODKGKGD;

	[Token(Token = "0x4003BE3")]
	[FieldOffset(Offset = "0xA8")]
	private UserControlAxisData MAPEFGHDPCC;

	[Token(Token = "0x4003BE4")]
	[FieldOffset(Offset = "0xAC")]
	public float m_ControlEularsLerpSpeed;

	[Token(Token = "0x4003BE5")]
	[FieldOffset(Offset = "0xB0")]
	public float m_ControlDirLerpSpeed;

	[Token(Token = "0x4003BE6")]
	[FieldOffset(Offset = "0xB4")]
	public float m_ControlRotScaleX;

	[Token(Token = "0x4003BE7")]
	[FieldOffset(Offset = "0xB8")]
	public float m_ControlRotScaleY;

	[Token(Token = "0x4003BE8")]
	[FieldOffset(Offset = "0xBC")]
	public float m_AimSensitivity;

	[Token(Token = "0x4003BE9")]
	[FieldOffset(Offset = "0xC0")]
	private Quaternion KGCHOKDKEEK;

	[Token(Token = "0x4003BEA")]
	[FieldOffset(Offset = "0xD0")]
	private Quaternion FDPEPOOOIMC;

	[Token(Token = "0x4003BEB")]
	[FieldOffset(Offset = "0xE0")]
	private bool AEEALGHDJKC;

	[Token(Token = "0x4003BEC")]
	[FieldOffset(Offset = "0xE4")]
	private Vector3 JMDHIOHBAHF;

	[Token(Token = "0x4003BED")]
	[FieldOffset(Offset = "0xF0")]
	public float m_ControlDirectionResetTime;

	[Token(Token = "0x4003BEE")]
	[FieldOffset(Offset = "0xF4")]
	public float m_ControlDirectionLerp;

	[Token(Token = "0x4003BEF")]
	[FieldOffset(Offset = "0xF8")]
	public bool m_MultBaseRot;

	[Token(Token = "0x4003BF0")]
	[FieldOffset(Offset = "0xFC")]
	private float FIANLECMEIF;

	[Token(Token = "0x4003BF1")]
	[FieldOffset(Offset = "0x100")]
	private bool _003CNPOHIGPGJFI_003Ek__BackingField;

	[Token(Token = "0x4003BF2")]
	[FieldOffset(Offset = "0x104")]
	private UserControlAxisData DOKIDNKEJMD;

	[Token(Token = "0x4003BF3")]
	private const float CIPINKBEJLH = 40f;

	[Token(Token = "0x4003BF4")]
	private const float PEBMPHBJLEI = 60f;

	[Token(Token = "0x4003BF5")]
	[FieldOffset(Offset = "0x108")]
	private MMOJIFPIFAP IPAGNMHLMDA;

	[Token(Token = "0x4003BF6")]
	[FieldOffset(Offset = "0x10C")]
	private LKLJODFHLLE LJJBNKCNNGA;

	[Token(Token = "0x4003BF7")]
	[FieldOffset(Offset = "0x110")]
	private LKLJODFHLLE ADGANACFAJE;

	[Token(Token = "0x4003BF8")]
	[FieldOffset(Offset = "0x114")]
	public float AimPosLerpSpeed;

	[Token(Token = "0x4003BF9")]
	[FieldOffset(Offset = "0x118")]
	public float AimRotLerpSpeed;

	[Token(Token = "0x170001D5")]
	public bool FLDMPLPDGDO
	{
		[Token(Token = "0x60014F4")]
		[Address(RVA = "0x26E6A78", Offset = "0x26E6A78", VA = "0x26E6A78")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x26E6A80", Offset = "0x26E6A80", VA = "0x26E6A80")]
		protected set
		{
		}
	}

	[Token(Token = "0x170001D6")]
	public bool DIMGHKGHBEL
	{
		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x26E6A88", Offset = "0x26E6A88", VA = "0x26E6A88")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60014F3")]
	[Address(RVA = "0x26E6978", Offset = "0x26E6978", VA = "0x26E6978")]
	public VehicleDriverCamera()
	{
	}

	[Token(Token = "0x60014F7")]
	[Address(RVA = "0x26E6AEC", Offset = "0x26E6AEC", VA = "0x26E6AEC", Slot = "5")]
	protected override void PCGJKJBMAJM()
	{
	}

	[Token(Token = "0x60014F8")]
	[Address(RVA = "0x26E70DC", Offset = "0x26E70DC", VA = "0x26E70DC")]
	private UserControlAxisData HHMFFDAAAGB(int JOIMODOEEJH)
	{
		return null;
	}

	[Token(Token = "0x60014F9")]
	[Address(RVA = "0x26E723C", Offset = "0x26E723C", VA = "0x26E723C")]
	private bool PGMFLGILALM()
	{
		return default(bool);
	}

	[Token(Token = "0x60014FA")]
	[Address(RVA = "0x26E736C", Offset = "0x26E736C", VA = "0x26E736C")]
	private void FPFKMABNGGO()
	{
	}

	[Token(Token = "0x60014FB")]
	[Address(RVA = "0x26E790C", Offset = "0x26E790C", VA = "0x26E790C", Slot = "4")]
	protected override void IMEHMEOBENM()
	{
	}

	[Token(Token = "0x60014FC")]
	[Address(RVA = "0x26EA7E0", Offset = "0x26EA7E0", VA = "0x26EA7E0")]
	private void NEDPPICIOPO()
	{
	}

	[Token(Token = "0x60014FD")]
	[Address(RVA = "0x26E94DC", Offset = "0x26E94DC", VA = "0x26E94DC")]
	private void HDHMFEEDDBL(Vector3 ONGHEPIOMHN)
	{
	}

	[Token(Token = "0x60014FE")]
	[Address(RVA = "0x26E9344", Offset = "0x26E9344", VA = "0x26E9344")]
	private bool OMJEJCMICMA()
	{
		return default(bool);
	}

	[Token(Token = "0x60014FF")]
	[Address(RVA = "0x26E93A8", Offset = "0x26E93A8", VA = "0x26E93A8")]
	private bool JIGFGGECHJC()
	{
		return default(bool);
	}

	[Token(Token = "0x6001500")]
	[Address(RVA = "0x26EAAB4", Offset = "0x26EAAB4", VA = "0x26EAAB4")]
	public void StartAiming()
	{
	}

	[Token(Token = "0x6001501")]
	[Address(RVA = "0x26EB18C", Offset = "0x26EB18C", VA = "0x26EB18C")]
	public void StopAiming()
	{
	}

	[Token(Token = "0x6001502")]
	[Address(RVA = "0x26EA744", Offset = "0x26EA744", VA = "0x26EA744")]
	private void FMHJIAMENKK()
	{
	}

	[Token(Token = "0x6001503")]
	[Address(RVA = "0x26EA10C", Offset = "0x26EA10C", VA = "0x26EA10C")]
	private void GOBHGGNOAFH()
	{
	}

	[Token(Token = "0x6001504")]
	[Address(RVA = "0x26EB104", Offset = "0x26EB104", VA = "0x26EB104")]
	private void APGNABJMLJG()
	{
	}

	[Token(Token = "0x6001505")]
	[Address(RVA = "0x26EACD4", Offset = "0x26EACD4", VA = "0x26EACD4")]
	private void MEMEHLDGAJL(ref LKLJODFHLLE HLADFEKELKI, Transform OPJKJHBKLGN)
	{
	}

	[Token(Token = "0x6001506")]
	[Address(RVA = "0x26E9BEC", Offset = "0x26E9BEC", VA = "0x26E9BEC")]
	private void CHGJDIALHJI(ref Vector3 ACCOJJMKKPM, ref Quaternion JGOGIAFGCFC)
	{
	}

	[Token(Token = "0x6001507")]
	[Address(RVA = "0x26EAE90", Offset = "0x26EAE90", VA = "0x26EAE90")]
	private void MEMEHLDGAJL(ref LKLJODFHLLE HLADFEKELKI, Vector3 OPJKJHBKLGN)
	{
	}

	[Token(Token = "0x6001508")]
	[Address(RVA = "0x26E9AFC", Offset = "0x26E9AFC", VA = "0x26E9AFC")]
	private bool IANKOMDHFJJ(LKLJODFHLLE GMJOBAMEMDP, LKLJODFHLLE FDEJKGIAKNM, float NFPILHKMBHL)
	{
		return default(bool);
	}

	[Token(Token = "0x6001509")]
	[Address(RVA = "0x26E9E24", Offset = "0x26E9E24", VA = "0x26E9E24")]
	private bool IANKOMDHFJJ(LKLJODFHLLE GMJOBAMEMDP, Vector3 ACCOJJMKKPM, Quaternion JGOGIAFGCFC, float NFPILHKMBHL)
	{
		return default(bool);
	}

	[Token(Token = "0x600150A")]
	[Address(RVA = "0x26EA194", Offset = "0x26EA194", VA = "0x26EA194")]
	private void FGBDAOHEBDC(ref Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x600150B")]
	[Address(RVA = "0x26EB2B8", Offset = "0x26EB2B8", VA = "0x26EB2B8", Slot = "6")]
	public override void OnCameraChanged()
	{
	}

	[Token(Token = "0x600150C")]
	[Address(RVA = "0x26EB3DC", Offset = "0x26EB3DC", VA = "0x26EB3DC")]
	public new void _003C_003EiFixBaseProxy_PCGJKJBMAJM()
	{
	}

	[Token(Token = "0x600150D")]
	[Address(RVA = "0x26EB3E0", Offset = "0x26EB3E0", VA = "0x26EB3E0")]
	public void _003C_003EiFixBaseProxy_IMEHMEOBENM()
	{
	}

	[Token(Token = "0x600150E")]
	[Address(RVA = "0x26EB3E8", Offset = "0x26EB3E8", VA = "0x26EB3E8")]
	public new void _003C_003EiFixBaseProxy_OnCameraChanged()
	{
	}
}
