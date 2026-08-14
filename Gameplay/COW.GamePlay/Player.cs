using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using TsiU;
using UMA;
using UnityEngine;
using UnityEngine.AI;
using WwiseGameSyncs;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000941")]
internal class Player : AttackableEntity, _Attribute, IConvertible, IComparable<int>, IFormattable
{
	[Token(Token = "0x2000942")]
	protected class EEKDOKOEAEO
	{
		[Token(Token = "0x40057DC")]
		[FieldOffset(Offset = "0x8")]
		private IHAAMHPPLMG BIFFAIEPIND;

		[Token(Token = "0x40057DD")]
		[FieldOffset(Offset = "0x20")]
		private float MHCAJOLGLMM;

		[Token(Token = "0x40057DE")]
		[FieldOffset(Offset = "0x24")]
		private bool BPBOMEMFBLN;

		[Token(Token = "0x60046F4")]
		[Address(RVA = "0x25D299C", Offset = "0x25D299C", VA = "0x25D299C")]
		public EEKDOKOEAEO(IHAAMHPPLMG IDNEFEOPGIF, float LEBOAIEJCPJ, bool FICNJIMKAEF = false)
		{
		}

		[Token(Token = "0x60046F5")]
		[Address(RVA = "0x25D2A9C", Offset = "0x25D2A9C", VA = "0x25D2A9C")]
		public void GDADMOPBGAB(float LEBOAIEJCPJ)
		{
		}

		[Token(Token = "0x60046F6")]
		[Address(RVA = "0x25D2BA8", Offset = "0x25D2BA8", VA = "0x25D2BA8")]
		public bool AALKKKLCHHJ()
		{
			return default(bool);
		}

		[Token(Token = "0x60046F7")]
		[Address(RVA = "0x25D2D44", Offset = "0x25D2D44", VA = "0x25D2D44")]
		public IHAAMHPPLMG MAPPHHIFNFL()
		{
			return default(IHAAMHPPLMG);
		}

		[Token(Token = "0x60046F8")]
		[Address(RVA = "0x25D2C34", Offset = "0x25D2C34", VA = "0x25D2C34")]
		public bool BMBHEEOENHB()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000943")]
	public enum DFKKGHCFGNM
	{
		[Token(Token = "0x40057E0")]
		Walking,
		[Token(Token = "0x40057E1")]
		Falling,
		[Token(Token = "0x40057E2")]
		Parachuting,
		[Token(Token = "0x40057E3")]
		OnBoard,
		[Token(Token = "0x40057E4")]
		SkyDiving,
		[Token(Token = "0x40057E5")]
		HitFly,
		[Token(Token = "0x40057E6")]
		Swimming,
		[Token(Token = "0x40057E7")]
		OnStrop,
		[Token(Token = "0x40057E8")]
		Football,
		[Token(Token = "0x40057E9")]
		JetFly,
		[Token(Token = "0x40057EA")]
		Gliding,
		[Token(Token = "0x40057EB")]
		OnGrapplingHook,
		[Token(Token = "0x40057EC")]
		Skateboarding,
		[Token(Token = "0x40057ED")]
		OnFerrisWheel,
		[Token(Token = "0x40057EE")]
		FlightRoam,
		[Token(Token = "0x40057EF")]
		FaithJumping,
		[Token(Token = "0x40057F0")]
		StarFalling
	}

	[Token(Token = "0x2000944")]
	public enum NILHJAFNEJL
	{
		[Token(Token = "0x40057F2")]
		None,
		[Token(Token = "0x40057F3")]
		FastRun
	}

	[Token(Token = "0x2000945")]
	public enum PPNGPELLBJO
	{
		[Token(Token = "0x40057F5")]
		None,
		[Token(Token = "0x40057F6")]
		Attack,
		[Token(Token = "0x40057F7")]
		Defense
	}

	[Token(Token = "0x2000946")]
	protected class BFPFGLLFEKJ
	{
		[Token(Token = "0x40057F8")]
		[FieldOffset(Offset = "0x8")]
		public EntityInfo IDNLKANJJJK;

		[Token(Token = "0x40057F9")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 PPPNEIDICKM;

		[Token(Token = "0x60046F9")]
		[Address(RVA = "0x25CF724", Offset = "0x25CF724", VA = "0x25CF724")]
		public BFPFGLLFEKJ()
		{
		}
	}

	[Token(Token = "0x2000947")]
	public enum GBJAEPHNFMD
	{
		[Token(Token = "0x40057FB")]
		NONE,
		[Token(Token = "0x40057FC")]
		TeammateRescure,
		[Token(Token = "0x40057FD")]
		SelfRescure,
		[Token(Token = "0x40057FE")]
		UseRescureZone
	}

	[Token(Token = "0x2000948")]
	public enum MOIJLENBKNL
	{
		[Token(Token = "0x4005800")]
		None,
		[Token(Token = "0x4005801")]
		Opened,
		[Token(Token = "0x4005802")]
		Closed,
		[Token(Token = "0x4005803")]
		Openning
	}

	[Token(Token = "0x2000949")]
	public class GPGBALKIDJK
	{
		[Token(Token = "0x4005804")]
		[FieldOffset(Offset = "0x8")]
		public float BDLDBPFPGHN;

		[Token(Token = "0x4005805")]
		[FieldOffset(Offset = "0xC")]
		protected float IPIPPGONMOJ;

		[Token(Token = "0x17000588")]
		public bool FEIPODFIEHJ
		{
			[Token(Token = "0x60046FE")]
			[Address(RVA = "0x25D7584", Offset = "0x25D7584", VA = "0x25D7584")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60046FA")]
		[Address(RVA = "0x25D7450", Offset = "0x25D7450", VA = "0x25D7450")]
		public GPGBALKIDJK()
		{
		}

		[Token(Token = "0x60046FB")]
		[Address(RVA = "0x25D7458", Offset = "0x25D7458", VA = "0x25D7458")]
		public void LILLELPNAGA()
		{
		}

		[Token(Token = "0x60046FC")]
		[Address(RVA = "0x25D74B8", Offset = "0x25D74B8", VA = "0x25D74B8")]
		public void ABMOPCJLELM()
		{
		}

		[Token(Token = "0x60046FD")]
		[Address(RVA = "0x25D7528", Offset = "0x25D7528", VA = "0x25D7528")]
		public void IENPMLHCMPG()
		{
		}

		[Token(Token = "0x60046FF")]
		[Address(RVA = "0x25D760C", Offset = "0x25D760C", VA = "0x25D760C")]
		public float AAIAIBHEEFO()
		{
			return default(float);
		}

		[Token(Token = "0x6004700")]
		[Address(RVA = "0x25D76CC", Offset = "0x25D76CC", VA = "0x25D76CC")]
		public float JPKNNMCGFPC()
		{
			return default(float);
		}

		[Token(Token = "0x6004701")]
		[Address(RVA = "0x25D77C0", Offset = "0x25D77C0", VA = "0x25D77C0")]
		public void HHJOBAKPMCO(float BLHEBBCODLC)
		{
		}
	}

	[Token(Token = "0x200094A")]
	public delegate bool HNJPDMBFFJH(float OPKNJGBDOBB, float OMAFEKBHOAA);

	[Token(Token = "0x200094B")]
	public enum NOAKLBNJKAM
	{
		[Token(Token = "0x4005807")]
		SkillNoiseDampingAndBleed
	}

	[Token(Token = "0x200094C")]
	public class AvatarTransformer : MonoBehaviour
	{
		[Token(Token = "0x4005808")]
		[FieldOffset(Offset = "0xC")]
		public GameObject root;

		[Token(Token = "0x4005809")]
		[FieldOffset(Offset = "0x10")]
		public bool playerRawIsFemale;

		[Token(Token = "0x400580A")]
		[FieldOffset(Offset = "0x14")]
		public AvatarEffect rawAvateaEffect;

		[Token(Token = "0x400580B")]
		[FieldOffset(Offset = "0x18")]
		public PlayerAudioComponent rawAudioComponent;

		[Token(Token = "0x400580C")]
		[FieldOffset(Offset = "0x1C")]
		public AvatarTransformData transformData;

		[Token(Token = "0x400580D")]
		[FieldOffset(Offset = "0x20")]
		private Renderer[] JCDKBHLNMBE;

		[Token(Token = "0x400580E")]
		[FieldOffset(Offset = "0x24")]
		private Animator[] NHDJEIIAKKO;

		[Token(Token = "0x400580F")]
		[FieldOffset(Offset = "0x28")]
		private SkinnedMeshRenderer[] PDEFMMHDHLO;

		[Token(Token = "0x4005810")]
		[FieldOffset(Offset = "0x2C")]
		public ResourceID modelResId;

		[Token(Token = "0x4005811")]
		[FieldOffset(Offset = "0x30")]
		public Player owner;

		[Token(Token = "0x4005812")]
		[FieldOffset(Offset = "0x34")]
		private BigHeadComponent LBDJPFMEJIK;

		[Token(Token = "0x6004706")]
		[Address(RVA = "0x25CEE30", Offset = "0x25CEE30", VA = "0x25CEE30")]
		public AvatarTransformer()
		{
		}

		[Token(Token = "0x6004707")]
		[Address(RVA = "0x25CEE38", Offset = "0x25CEE38", VA = "0x25CEE38")]
		public void SetVisible(bool IMGNBGJDAHG)
		{
		}

		[Token(Token = "0x6004708")]
		[Address(RVA = "0x25CF120", Offset = "0x25CF120", VA = "0x25CF120")]
		public void Clear()
		{
		}

		[Token(Token = "0x6004709")]
		[Address(RVA = "0x25CF224", Offset = "0x25CF224", VA = "0x25CF224")]
		public Vector3 GetLocalPosition()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Token(Token = "0x600470A")]
		[Address(RVA = "0x25CF2C8", Offset = "0x25CF2C8", VA = "0x25CF2C8")]
		public void ResetLocalPosition()
		{
		}

		[Token(Token = "0x600470B")]
		[Address(RVA = "0x25CF3E8", Offset = "0x25CF3E8", VA = "0x25CF3E8")]
		public void SetLocalPosition(Vector3 IMGNBGJDAHG)
		{
		}

		[Token(Token = "0x600470C")]
		[Address(RVA = "0x25CF4B4", Offset = "0x25CF4B4", VA = "0x25CF4B4")]
		public void UpdateBigHeadScale(float IMGNBGJDAHG)
		{
		}

		[Token(Token = "0x600470D")]
		[Address(RVA = "0x25CF600", Offset = "0x25CF600", VA = "0x25CF600")]
		public void SwitchEffect(UMAData.EffectType GJMJJFAOBEL)
		{
		}
	}

	[Token(Token = "0x200094D")]
	public class CBAGEACLABP : _Attribute
	{
		[Token(Token = "0x4005813")]
		[FieldOffset(Offset = "0x8")]
		private Transform _003CEPEGNDBBNMF_003Ek__BackingField;

		[Token(Token = "0x4005814")]
		[FieldOffset(Offset = "0xC")]
		private List<Transform> LAJJDLBFDMN;

		[Token(Token = "0x17000589")]
		public Transform GJGMOFLECDK
		{
			[Token(Token = "0x600470F")]
			[Address(RVA = "0x25D03E0", Offset = "0x25D03E0", VA = "0x25D03E0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004710")]
			[Address(RVA = "0x25D03E8", Offset = "0x25D03E8", VA = "0x25D03E8")]
			set
			{
			}
		}

		[Token(Token = "0x600470E")]
		[Address(RVA = "0x25D0354", Offset = "0x25D0354", VA = "0x25D0354")]
		public CBAGEACLABP()
		{
		}

		[Token(Token = "0x6004711")]
		[Address(RVA = "0x25D03F0", Offset = "0x25D03F0", VA = "0x25D03F0")]
		public void FNBAIAJNMME()
		{
		}

		[Token(Token = "0x6004712")]
		[Address(RVA = "0x25D058C", Offset = "0x25D058C", VA = "0x25D058C")]
		public void CEMJPLNCBMC(Transform FAONEINKBPJ)
		{
		}
	}

	[Token(Token = "0x200094E")]
	public class CKGPOJHAKOI
	{
		[Token(Token = "0x4005815")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, CBAGEACLABP> GAFPIBPIOJA;

		[Token(Token = "0x4005816")]
		[FieldOffset(Offset = "0xC")]
		private Transform FMPHAFEOFDP;

		[Token(Token = "0x4005817")]
		[FieldOffset(Offset = "0x10")]
		private CBAGEACLABP AAGHBFEKHPL;

		[Token(Token = "0x4005818")]
		[FieldOffset(Offset = "0x14")]
		private bool JMIOCLHCIFC;

		[Token(Token = "0x6004713")]
		[Address(RVA = "0x25D0AC0", Offset = "0x25D0AC0", VA = "0x25D0AC0")]
		public CKGPOJHAKOI()
		{
		}

		[Token(Token = "0x6004714")]
		[Address(RVA = "0x25D0B4C", Offset = "0x25D0B4C", VA = "0x25D0B4C")]
		public void DPLMGOJKKCM(Transform LHGLOHKNEPC)
		{
		}

		[Token(Token = "0x6004715")]
		[Address(RVA = "0x25D0C40", Offset = "0x25D0C40", VA = "0x25D0C40")]
		public CBAGEACLABP GMFALBCGPNG(string KANGHILGNLO)
		{
			return null;
		}

		[Token(Token = "0x6004716")]
		[Address(RVA = "0x25D0E78", Offset = "0x25D0E78", VA = "0x25D0E78")]
		public void EJCEHAJCONB(Transform PEEPIJHGLKN)
		{
		}

		[Token(Token = "0x6004717")]
		[Address(RVA = "0x25D1190", Offset = "0x25D1190", VA = "0x25D1190")]
		public void BOLCLHHGPJA()
		{
		}

		[Token(Token = "0x6004718")]
		[Address(RVA = "0x25D140C", Offset = "0x25D140C", VA = "0x25D140C")]
		public void JBABJMBKKPD(GameObject ECINOMEHBKA)
		{
		}
	}

	[Token(Token = "0x200094F")]
	public enum LGLMLIBMLAM
	{
		[Token(Token = "0x400581A")]
		DUST,
		[Token(Token = "0x400581B")]
		GRASS,
		[Token(Token = "0x400581C")]
		LENGTH
	}

	[Token(Token = "0x2000950")]
	public enum ODHBJJAOEBA
	{
		[Token(Token = "0x400581E")]
		Show,
		[Token(Token = "0x400581F")]
		Hide,
		[Token(Token = "0x4005820")]
		Fall
	}

	[Token(Token = "0x2000951")]
	public enum GHCOKFDGCNF
	{
		[Token(Token = "0x4005822")]
		DEFAULT,
		[Token(Token = "0x4005823")]
		CONCRETE,
		[Token(Token = "0x4005824")]
		WOOD,
		[Token(Token = "0x4005825")]
		METAL
	}

	[Token(Token = "0x2000952")]
	public class GPAMIDPFIDI
	{
		[Token(Token = "0x4005826")]
		[FieldOffset(Offset = "0x8")]
		public int IDNEFEOPGIF;

		[Token(Token = "0x4005827")]
		[FieldOffset(Offset = "0xC")]
		public GHCOKFDGCNF HMJKDKAKJDF;

		[Token(Token = "0x6004719")]
		[Address(RVA = "0x25D7428", Offset = "0x25D7428", VA = "0x25D7428")]
		public GPAMIDPFIDI(int IDNEFEOPGIF, GHCOKFDGCNF HMJKDKAKJDF)
		{
		}
	}

	[Token(Token = "0x2000953")]
	public class KHDMPGBLNCM
	{
		[Token(Token = "0x4005828")]
		[FieldOffset(Offset = "0x8")]
		private Player AFFLMOEAHKC;

		[Token(Token = "0x4005829")]
		[FieldOffset(Offset = "0xC")]
		private GHGCGGOLKIP _003CNPEONONOGEO_003Ek__BackingField;

		[Token(Token = "0x400582A")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 LLMPADJJPLB;

		[Token(Token = "0x400582B")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 NMLOGBJDLCK;

		[Token(Token = "0x400582C")]
		[FieldOffset(Offset = "0x28")]
		public float AFBEKADGJGD;

		[Token(Token = "0x400582D")]
		[FieldOffset(Offset = "0x2C")]
		public float LJJPEAFKHHJ;

		[Token(Token = "0x400582E")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 LMNBBBCKMGB;

		[Token(Token = "0x1700058A")]
		public GHGCGGOLKIP LLGMBFPFEKA
		{
			[Token(Token = "0x600471B")]
			[Address(RVA = "0x25D927C", Offset = "0x25D927C", VA = "0x25D927C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600471C")]
			[Address(RVA = "0x25D9284", Offset = "0x25D9284", VA = "0x25D9284")]
			private set
			{
			}
		}

		[Token(Token = "0x1700058B")]
		public DFKKGHCFGNM GHGCGGOLKIP
		{
			[Token(Token = "0x600471D")]
			[Address(RVA = "0x25D928C", Offset = "0x25D928C", VA = "0x25D928C")]
			get
			{
				return default(DFKKGHCFGNM);
			}
		}

		[Token(Token = "0x1700058C")]
		public FBCAHNCLMDC KIFHHPBIOHK
		{
			[Token(Token = "0x600471E")]
			[Address(RVA = "0x25D9308", Offset = "0x25D9308", VA = "0x25D9308")]
			get
			{
				return default(FBCAHNCLMDC);
			}
		}

		[Token(Token = "0x1700058D")]
		public bool JGJHDKKPNPA
		{
			[Token(Token = "0x600471F")]
			[Address(RVA = "0x25D9378", Offset = "0x25D9378", VA = "0x25D9378")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700058E")]
		public bool BJCMJCMJEHG
		{
			[Token(Token = "0x6004720")]
			[Address(RVA = "0x25D9424", Offset = "0x25D9424", VA = "0x25D9424")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700058F")]
		public bool MJGFLIMHEHA
		{
			[Token(Token = "0x6004721")]
			[Address(RVA = "0x25D94A8", Offset = "0x25D94A8", VA = "0x25D94A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000590")]
		public bool OCGFJFKOPBD
		{
			[Token(Token = "0x6004722")]
			[Address(RVA = "0x25D9558", Offset = "0x25D9558", VA = "0x25D9558")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000591")]
		public bool NCPJDOCMEEH
		{
			[Token(Token = "0x6004723")]
			[Address(RVA = "0x25D95DC", Offset = "0x25D95DC", VA = "0x25D95DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000592")]
		public bool LMOFIINBKHI
		{
			[Token(Token = "0x6004724")]
			[Address(RVA = "0x25D9660", Offset = "0x25D9660", VA = "0x25D9660")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000593")]
		public bool GEEFKINNFNM
		{
			[Token(Token = "0x6004725")]
			[Address(RVA = "0x25D9708", Offset = "0x25D9708", VA = "0x25D9708")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000594")]
		public bool KOGGOMGFANE
		{
			[Token(Token = "0x6004726")]
			[Address(RVA = "0x25D9838", Offset = "0x25D9838", VA = "0x25D9838")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000595")]
		public bool ONDKEAJMHPJ
		{
			[Token(Token = "0x6004727")]
			[Address(RVA = "0x25D98BC", Offset = "0x25D98BC", VA = "0x25D98BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000596")]
		public bool LECNAMLFAFM
		{
			[Token(Token = "0x6004728")]
			[Address(RVA = "0x25D9940", Offset = "0x25D9940", VA = "0x25D9940")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000597")]
		public bool IDDMOPOHKPJ
		{
			[Token(Token = "0x6004729")]
			[Address(RVA = "0x25D99C4", Offset = "0x25D99C4", VA = "0x25D99C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000598")]
		public bool DHJDBFFAHAM
		{
			[Token(Token = "0x600472A")]
			[Address(RVA = "0x25D9A48", Offset = "0x25D9A48", VA = "0x25D9A48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000599")]
		public bool GPPOKKMKOEM
		{
			[Token(Token = "0x600472B")]
			[Address(RVA = "0x25D9ACC", Offset = "0x25D9ACC", VA = "0x25D9ACC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700059A")]
		public bool PGIDLPHPOLJ
		{
			[Token(Token = "0x600472C")]
			[Address(RVA = "0x25D9B50", Offset = "0x25D9B50", VA = "0x25D9B50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700059B")]
		public bool AJMHFMMNDEP
		{
			[Token(Token = "0x600472D")]
			[Address(RVA = "0x25D9BE8", Offset = "0x25D9BE8", VA = "0x25D9BE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700059C")]
		public bool HLNEMKNFCPB
		{
			[Token(Token = "0x600472E")]
			[Address(RVA = "0x25D9C6C", Offset = "0x25D9C6C", VA = "0x25D9C6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600471A")]
		[Address(RVA = "0x25D918C", Offset = "0x25D918C", VA = "0x25D918C")]
		public KHDMPGBLNCM(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x600472F")]
		[Address(RVA = "0x25D9CDC", Offset = "0x25D9CDC", VA = "0x25D9CDC")]
		public void DFLCMLJPEHE(GHGCGGOLKIP JEHELPNHACP)
		{
		}
	}

	[Token(Token = "0x2000954")]
	public enum KDIHGOHFFFC
	{
		[Token(Token = "0x4005830")]
		BUFF_DOT = 1,
		[Token(Token = "0x4005831")]
		BUFF_SKIN
	}

	[Token(Token = "0x2000955")]
	public abstract class GHGCGGOLKIP
	{
		[Token(Token = "0x4005832")]
		[FieldOffset(Offset = "0x8")]
		protected FBCAHNCLMDC BDHNFGPDEBH;

		[Token(Token = "0x4005833")]
		[FieldOffset(Offset = "0xC")]
		private Player _003CBBHBMCKIJJO_003Ek__BackingField;

		[Token(Token = "0x1700059D")]
		protected Player JGHEGHHINPA
		{
			[Token(Token = "0x6004731")]
			[Address(RVA = "0x25CEC4C", Offset = "0x25CEC4C", VA = "0x25CEC4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004732")]
			[Address(RVA = "0x25D5FB0", Offset = "0x25D5FB0", VA = "0x25D5FB0")]
			private set
			{
			}
		}

		[Token(Token = "0x6004730")]
		[Address(RVA = "0x25CEAB0", Offset = "0x25CEAB0", VA = "0x25CEAB0")]
		public GHGCGGOLKIP(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x6004733")]
		public abstract DFKKGHCFGNM KMKLAHPKDGK();

		[Token(Token = "0x6004734")]
		[Address(RVA = "0x25D5FB8", Offset = "0x25D5FB8", VA = "0x25D5FB8")]
		public FBCAHNCLMDC DOBGCFLJMAA()
		{
			return default(FBCAHNCLMDC);
		}

		[Token(Token = "0x6004735")]
		[Address(RVA = "0x25D6010", Offset = "0x25D6010", VA = "0x25D6010")]
		public void DDOMLJNAFEC(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x6004736")]
		[Address(RVA = "0x25D642C", Offset = "0x25D642C", VA = "0x25D642C")]
		public void KOAIGFNENJP(FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x6004737")]
		[Address(RVA = "0x25D6578", Offset = "0x25D6578", VA = "0x25D6578")]
		public void EPLOCAGDCOI(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x6004738")]
		[Address(RVA = "0x25D60B8", Offset = "0x25D60B8", VA = "0x25D60B8")]
		protected void BIACCJKDBID(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x6004739")]
		[Address(RVA = "0x25D64E4", Offset = "0x25D64E4", VA = "0x25D64E4")]
		protected void FCFKPDLFOAE(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x600473A")]
		[Address(RVA = "0x25CEDD4", Offset = "0x25CEDD4", VA = "0x25CEDD4", Slot = "5")]
		protected virtual void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x600473B")]
		[Address(RVA = "0x25CED74", Offset = "0x25CED74", VA = "0x25CED74", Slot = "6")]
		protected virtual void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x600473C")]
		[Address(RVA = "0x25D292C", Offset = "0x25D292C", VA = "0x25D292C", Slot = "7")]
		protected virtual void LKGMANPKFKO(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x600473D")]
		[Address(RVA = "0x25D28B8", Offset = "0x25D28B8", VA = "0x25D28B8", Slot = "8")]
		protected virtual void GAIGFCBEHAK(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x600473E")]
		[Address(RVA = "0x25CED00", Offset = "0x25CED00", VA = "0x25CED00", Slot = "9")]
		protected virtual bool DMAKEHDPHJO(FBCAHNCLMDC JDDIEPOJPKL)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000956")]
	protected class KJCLFPMKCGB : GHGCGGOLKIP
	{
		[Token(Token = "0x600473F")]
		[Address(RVA = "0x25D9D3C", Offset = "0x25D9D3C", VA = "0x25D9D3C")]
		public KJCLFPMKCGB(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x6004740")]
		[Address(RVA = "0x25D9D5C", Offset = "0x25D9D5C", VA = "0x25D9D5C", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x6004741")]
		[Address(RVA = "0x25D9DB4", Offset = "0x25D9DB4", VA = "0x25D9DB4", Slot = "9")]
		protected override bool DMAKEHDPHJO(FBCAHNCLMDC JDDIEPOJPKL)
		{
			return default(bool);
		}

		[Token(Token = "0x6004742")]
		[Address(RVA = "0x25D9E44", Offset = "0x25D9E44", VA = "0x25D9E44", Slot = "7")]
		protected override void LKGMANPKFKO(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x6004743")]
		[Address(RVA = "0x25DB4D8", Offset = "0x25DB4D8", VA = "0x25DB4D8", Slot = "8")]
		protected override void GAIGFCBEHAK(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004744")]
		[Address(RVA = "0x25DCF80", Offset = "0x25DCF80", VA = "0x25DCF80")]
		private void FLPLMMKCEGM(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004745")]
		[Address(RVA = "0x25DD0A8", Offset = "0x25DD0A8", VA = "0x25DD0A8")]
		private static bool DMJNJBOJGGI(FBCAHNCLMDC PHEJDNJONIL)
		{
			return default(bool);
		}

		[Token(Token = "0x6004746")]
		[Address(RVA = "0x25DC088", Offset = "0x25DC088", VA = "0x25DC088")]
		private void GMFAAJPNDGK(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004747")]
		[Address(RVA = "0x25DBF2C", Offset = "0x25DBF2C", VA = "0x25DBF2C")]
		private void CLIKABGCAPG(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004748")]
		[Address(RVA = "0x25DD11C", Offset = "0x25DD11C", VA = "0x25DD11C", Slot = "10")]
		protected virtual void AMPELHJMNKN(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004749")]
		[Address(RVA = "0x25DB6C0", Offset = "0x25DB6C0", VA = "0x25DB6C0")]
		private void GAGJAENLJGE(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x600474A")]
		[Address(RVA = "0x25DB8A4", Offset = "0x25DB8A4", VA = "0x25DB8A4")]
		private void DALEGBEOBGC(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x600474B")]
		[Address(RVA = "0x25DBE58", Offset = "0x25DBE58", VA = "0x25DBE58")]
		private void CKNFKMKAMGG(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x600474C")]
		[Address(RVA = "0x25DCBC8", Offset = "0x25DCBC8", VA = "0x25DCBC8")]
		private void PJDCNADEGKO(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x600474D")]
		[Address(RVA = "0x25DCEA8", Offset = "0x25DCEA8", VA = "0x25DCEA8")]
		private void GGOFDAIMOBE(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x600474E")]
		[Address(RVA = "0x25DCFF0", Offset = "0x25DCFF0", VA = "0x25DCFF0")]
		private void KELMAAMGJGL(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x600474F")]
		[Address(RVA = "0x25DA224", Offset = "0x25DA224", VA = "0x25DA224")]
		private void HPGOPMECNGE(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x6004750")]
		[Address(RVA = "0x25D9FFC", Offset = "0x25D9FFC", VA = "0x25D9FFC")]
		private void JJEKHOHPDCJ(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x6004751")]
		[Address(RVA = "0x25DA560", Offset = "0x25DA560", VA = "0x25DA560")]
		private void HNFFHPGCDBA(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x6004752")]
		[Address(RVA = "0x25DA798", Offset = "0x25DA798", VA = "0x25DA798")]
		private void NMNIKAHKKKB(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x6004753")]
		[Address(RVA = "0x25DA834", Offset = "0x25DA834", VA = "0x25DA834")]
		private void GPJGHGNDBID(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x6004754")]
		[Address(RVA = "0x25DAFA4", Offset = "0x25DAFA4", VA = "0x25DAFA4")]
		private void FGPPDPAEONN(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004755")]
		[Address(RVA = "0x25DB0E4", Offset = "0x25DB0E4", VA = "0x25DB0E4")]
		private void JHJGPEEJKNM(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004756")]
		[Address(RVA = "0x25DB420", Offset = "0x25DB420", VA = "0x25DB420")]
		private void LLMANEGBDEO(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004757")]
		[Address(RVA = "0x25DB1BC", Offset = "0x25DB1BC", VA = "0x25DB1BC")]
		private void CNHNJDMFOPE(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x6004758")]
		[Address(RVA = "0x25DD9E8", Offset = "0x25DD9E8", VA = "0x25DD9E8")]
		public bool _003C_003EiFixBaseProxy_DMAKEHDPHJO(FBCAHNCLMDC P0)
		{
			return default(bool);
		}

		[Token(Token = "0x6004759")]
		[Address(RVA = "0x25DD9EC", Offset = "0x25DD9EC", VA = "0x25DD9EC")]
		public void _003C_003EiFixBaseProxy_LKGMANPKFKO(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}

		[Token(Token = "0x600475A")]
		[Address(RVA = "0x25DD9F0", Offset = "0x25DD9F0", VA = "0x25DD9F0")]
		public void _003C_003EiFixBaseProxy_GAIGFCBEHAK(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}
	}

	[Token(Token = "0x2000957")]
	protected class EJJNIOHJIFE : GHGCGGOLKIP
	{
		[Token(Token = "0x600475B")]
		[Address(RVA = "0x25D2DB8", Offset = "0x25D2DB8", VA = "0x25D2DB8")]
		public EJJNIOHJIFE(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x600475C")]
		[Address(RVA = "0x25D2DD8", Offset = "0x25D2DD8", VA = "0x25D2DD8", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x600475D")]
		[Address(RVA = "0x25D2E30", Offset = "0x25D2E30", VA = "0x25D2E30", Slot = "5")]
		protected override void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x600475E")]
		[Address(RVA = "0x25D2F1C", Offset = "0x25D2F1C", VA = "0x25D2F1C", Slot = "9")]
		protected override bool DMAKEHDPHJO(FBCAHNCLMDC JDDIEPOJPKL)
		{
			return default(bool);
		}

		[Token(Token = "0x600475F")]
		[Address(RVA = "0x25D2FAC", Offset = "0x25D2FAC", VA = "0x25D2FAC", Slot = "8")]
		protected override void GAIGFCBEHAK(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004760")]
		[Address(RVA = "0x25D3654", Offset = "0x25D3654", VA = "0x25D3654")]
		private void FINHBLMCKBA()
		{
		}

		[Token(Token = "0x6004761")]
		[Address(RVA = "0x25D376C", Offset = "0x25D376C", VA = "0x25D376C", Slot = "10")]
		protected virtual void AMPELHJMNKN(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004762")]
		[Address(RVA = "0x25D4188", Offset = "0x25D4188", VA = "0x25D4188", Slot = "11")]
		protected virtual void DONJDIFAFJO(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004763")]
		[Address(RVA = "0x25D4360", Offset = "0x25D4360", VA = "0x25D4360", Slot = "12")]
		protected virtual void ILHPFGFCDHG(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004764")]
		[Address(RVA = "0x25D3390", Offset = "0x25D3390", VA = "0x25D3390")]
		private void PFBIAJKEAHH(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004765")]
		[Address(RVA = "0x25D357C", Offset = "0x25D357C", VA = "0x25D357C")]
		private void CAGCNBLPLKG(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004766")]
		[Address(RVA = "0x25D310C", Offset = "0x25D310C", VA = "0x25D310C")]
		private void KMOIGCMDOLO(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004767")]
		[Address(RVA = "0x25D45B0", Offset = "0x25D45B0", VA = "0x25D45B0", Slot = "7")]
		protected override void LKGMANPKFKO(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x6004768")]
		[Address(RVA = "0x25D46C8", Offset = "0x25D46C8", VA = "0x25D46C8")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x6004769")]
		[Address(RVA = "0x25D46CC", Offset = "0x25D46CC", VA = "0x25D46CC")]
		public bool _003C_003EiFixBaseProxy_DMAKEHDPHJO(FBCAHNCLMDC P0)
		{
			return default(bool);
		}

		[Token(Token = "0x600476A")]
		[Address(RVA = "0x25D46D0", Offset = "0x25D46D0", VA = "0x25D46D0")]
		public void _003C_003EiFixBaseProxy_GAIGFCBEHAK(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}

		[Token(Token = "0x600476B")]
		[Address(RVA = "0x25D46D4", Offset = "0x25D46D4", VA = "0x25D46D4")]
		public void _003C_003EiFixBaseProxy_LKGMANPKFKO(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}
	}

	[Token(Token = "0x2000958")]
	private class OPKPFODAIEA : GHGCGGOLKIP
	{
		[Token(Token = "0x600476C")]
		[Address(RVA = "0x25E0120", Offset = "0x25E0120", VA = "0x25E0120")]
		public OPKPFODAIEA(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x600476D")]
		[Address(RVA = "0x25E0140", Offset = "0x25E0140", VA = "0x25E0140", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x600476E")]
		[Address(RVA = "0x25E0198", Offset = "0x25E0198", VA = "0x25E0198", Slot = "6")]
		protected override void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x600476F")]
		[Address(RVA = "0x25E03B4", Offset = "0x25E03B4", VA = "0x25E03B4", Slot = "5")]
		protected override void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x6004770")]
		[Address(RVA = "0x25E0598", Offset = "0x25E0598", VA = "0x25E0598")]
		public void _003C_003EiFixBaseProxy_LAFFLOMGJDH(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x6004771")]
		[Address(RVA = "0x25E059C", Offset = "0x25E059C", VA = "0x25E059C")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(DFKKGHCFGNM P0)
		{
		}
	}

	[Token(Token = "0x2000959")]
	private class BOHDPBAONLL : GHGCGGOLKIP
	{
		[Token(Token = "0x6004772")]
		[Address(RVA = "0x25CF734", Offset = "0x25CF734", VA = "0x25CF734")]
		public BOHDPBAONLL(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x6004773")]
		[Address(RVA = "0x25CF754", Offset = "0x25CF754", VA = "0x25CF754", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x6004774")]
		[Address(RVA = "0x25CF7AC", Offset = "0x25CF7AC", VA = "0x25CF7AC", Slot = "9")]
		protected override bool DMAKEHDPHJO(FBCAHNCLMDC JDDIEPOJPKL)
		{
			return default(bool);
		}

		[Token(Token = "0x6004775")]
		[Address(RVA = "0x25CF828", Offset = "0x25CF828", VA = "0x25CF828", Slot = "6")]
		protected override void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x6004776")]
		[Address(RVA = "0x25CFE1C", Offset = "0x25CFE1C", VA = "0x25CFE1C", Slot = "5")]
		protected override void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x6004777")]
		[Address(RVA = "0x25D0348", Offset = "0x25D0348", VA = "0x25D0348")]
		public bool _003C_003EiFixBaseProxy_DMAKEHDPHJO(FBCAHNCLMDC P0)
		{
			return default(bool);
		}

		[Token(Token = "0x6004778")]
		[Address(RVA = "0x25D034C", Offset = "0x25D034C", VA = "0x25D034C")]
		public void _003C_003EiFixBaseProxy_LAFFLOMGJDH(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x6004779")]
		[Address(RVA = "0x25D0350", Offset = "0x25D0350", VA = "0x25D0350")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(DFKKGHCFGNM P0)
		{
		}
	}

	[Token(Token = "0x200095A")]
	private class HMCFNKFMMAH : GHGCGGOLKIP
	{
		[Token(Token = "0x600477A")]
		[Address(RVA = "0x25D78BC", Offset = "0x25D78BC", VA = "0x25D78BC")]
		public HMCFNKFMMAH(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x600477B")]
		[Address(RVA = "0x25D78DC", Offset = "0x25D78DC", VA = "0x25D78DC", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x600477C")]
		[Address(RVA = "0x25D7934", Offset = "0x25D7934", VA = "0x25D7934", Slot = "9")]
		protected override bool DMAKEHDPHJO(FBCAHNCLMDC JDDIEPOJPKL)
		{
			return default(bool);
		}

		[Token(Token = "0x600477D")]
		[Address(RVA = "0x25D79B0", Offset = "0x25D79B0", VA = "0x25D79B0", Slot = "6")]
		protected override void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x600477E")]
		[Address(RVA = "0x25D7D18", Offset = "0x25D7D18", VA = "0x25D7D18", Slot = "5")]
		protected override void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x600477F")]
		[Address(RVA = "0x25D7FCC", Offset = "0x25D7FCC", VA = "0x25D7FCC")]
		public bool _003C_003EiFixBaseProxy_DMAKEHDPHJO(FBCAHNCLMDC P0)
		{
			return default(bool);
		}

		[Token(Token = "0x6004780")]
		[Address(RVA = "0x25D7FD0", Offset = "0x25D7FD0", VA = "0x25D7FD0")]
		public void _003C_003EiFixBaseProxy_LAFFLOMGJDH(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x6004781")]
		[Address(RVA = "0x25D7FD4", Offset = "0x25D7FD4", VA = "0x25D7FD4")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(DFKKGHCFGNM P0)
		{
		}
	}

	[Token(Token = "0x200095B")]
	private class MBCFAOPODHI : GHGCGGOLKIP
	{
		[Token(Token = "0x6004782")]
		[Address(RVA = "0x25DDA30", Offset = "0x25DDA30", VA = "0x25DDA30")]
		public MBCFAOPODHI(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x6004783")]
		[Address(RVA = "0x25DDA50", Offset = "0x25DDA50", VA = "0x25DDA50", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x6004784")]
		[Address(RVA = "0x25DDAA8", Offset = "0x25DDAA8", VA = "0x25DDAA8", Slot = "9")]
		protected override bool DMAKEHDPHJO(FBCAHNCLMDC JDDIEPOJPKL)
		{
			return default(bool);
		}

		[Token(Token = "0x6004785")]
		[Address(RVA = "0x25DDB24", Offset = "0x25DDB24", VA = "0x25DDB24", Slot = "6")]
		protected override void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x6004786")]
		[Address(RVA = "0x25DDCAC", Offset = "0x25DDCAC", VA = "0x25DDCAC", Slot = "5")]
		protected override void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x6004787")]
		[Address(RVA = "0x25DE218", Offset = "0x25DE218", VA = "0x25DE218", Slot = "8")]
		protected override void GAIGFCBEHAK(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004788")]
		[Address(RVA = "0x25DE2D0", Offset = "0x25DE2D0", VA = "0x25DE2D0")]
		private void HKAHMNACOOI(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x6004789")]
		[Address(RVA = "0x25DE8E8", Offset = "0x25DE8E8", VA = "0x25DE8E8")]
		private void HKPBABJKOOC(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x600478A")]
		[Address(RVA = "0x25DEF70", Offset = "0x25DEF70", VA = "0x25DEF70")]
		public bool _003C_003EiFixBaseProxy_DMAKEHDPHJO(FBCAHNCLMDC P0)
		{
			return default(bool);
		}

		[Token(Token = "0x600478B")]
		[Address(RVA = "0x25DEF74", Offset = "0x25DEF74", VA = "0x25DEF74")]
		public void _003C_003EiFixBaseProxy_LAFFLOMGJDH(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x600478C")]
		[Address(RVA = "0x25DEF78", Offset = "0x25DEF78", VA = "0x25DEF78")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x600478D")]
		[Address(RVA = "0x25DEF7C", Offset = "0x25DEF7C", VA = "0x25DEF7C")]
		public void _003C_003EiFixBaseProxy_GAIGFCBEHAK(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}
	}

	[Token(Token = "0x200095C")]
	private class GMNDPJPMBGE : GHGCGGOLKIP
	{
		[Token(Token = "0x600478E")]
		[Address(RVA = "0x25D6618", Offset = "0x25D6618", VA = "0x25D6618")]
		public GMNDPJPMBGE(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x600478F")]
		[Address(RVA = "0x25D6638", Offset = "0x25D6638", VA = "0x25D6638", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x6004790")]
		[Address(RVA = "0x25D6690", Offset = "0x25D6690", VA = "0x25D6690", Slot = "6")]
		protected override void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x6004791")]
		[Address(RVA = "0x25D6B4C", Offset = "0x25D6B4C", VA = "0x25D6B4C", Slot = "5")]
		protected override void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x6004792")]
		[Address(RVA = "0x25D7420", Offset = "0x25D7420", VA = "0x25D7420")]
		public void _003C_003EiFixBaseProxy_LAFFLOMGJDH(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x6004793")]
		[Address(RVA = "0x25D7424", Offset = "0x25D7424", VA = "0x25D7424")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(DFKKGHCFGNM P0)
		{
		}
	}

	[Token(Token = "0x200095D")]
	protected class KEEKAONHHFO : GHGCGGOLKIP
	{
		[Token(Token = "0x6004794")]
		[Address(RVA = "0x25D51EC", Offset = "0x25D51EC", VA = "0x25D51EC")]
		public KEEKAONHHFO(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x6004795")]
		[Address(RVA = "0x25D909C", Offset = "0x25D909C", VA = "0x25D909C", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x6004796")]
		[Address(RVA = "0x25D5450", Offset = "0x25D5450", VA = "0x25D5450", Slot = "6")]
		protected override void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x6004797")]
		[Address(RVA = "0x25D90F4", Offset = "0x25D90F4", VA = "0x25D90F4", Slot = "5")]
		protected override void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x6004798")]
		[Address(RVA = "0x25D9184", Offset = "0x25D9184", VA = "0x25D9184")]
		public void _003C_003EiFixBaseProxy_LAFFLOMGJDH(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x6004799")]
		[Address(RVA = "0x25D9188", Offset = "0x25D9188", VA = "0x25D9188")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(DFKKGHCFGNM P0)
		{
		}
	}

	[Token(Token = "0x200095E")]
	private class DIEDPKAGDEM : GHGCGGOLKIP
	{
		[Token(Token = "0x600479A")]
		[Address(RVA = "0x25D1680", Offset = "0x25D1680", VA = "0x25D1680")]
		public DIEDPKAGDEM(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x600479B")]
		[Address(RVA = "0x25D16A0", Offset = "0x25D16A0", VA = "0x25D16A0", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x600479C")]
		[Address(RVA = "0x25D16F8", Offset = "0x25D16F8", VA = "0x25D16F8", Slot = "9")]
		protected override bool DMAKEHDPHJO(FBCAHNCLMDC JDDIEPOJPKL)
		{
			return default(bool);
		}

		[Token(Token = "0x600479D")]
		[Address(RVA = "0x25D1774", Offset = "0x25D1774", VA = "0x25D1774", Slot = "6")]
		protected override void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x600479E")]
		[Address(RVA = "0x25D1B64", Offset = "0x25D1B64", VA = "0x25D1B64", Slot = "5")]
		protected override void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x600479F")]
		[Address(RVA = "0x25D1E7C", Offset = "0x25D1E7C", VA = "0x25D1E7C", Slot = "8")]
		protected override void GAIGFCBEHAK(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x60047A0")]
		[Address(RVA = "0x25D2468", Offset = "0x25D2468", VA = "0x25D2468", Slot = "7")]
		protected override void LKGMANPKFKO(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x60047A1")]
		[Address(RVA = "0x25D1F54", Offset = "0x25D1F54", VA = "0x25D1F54")]
		private void OHDJHPAGENJ(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x60047A2")]
		[Address(RVA = "0x25D20E0", Offset = "0x25D20E0", VA = "0x25D20E0")]
		private void AJLIFPLLCAH(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x60047A3")]
		[Address(RVA = "0x25D2198", Offset = "0x25D2198", VA = "0x25D2198")]
		private void DPOOLPJKHEI(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x60047A4")]
		[Address(RVA = "0x25D2500", Offset = "0x25D2500", VA = "0x25D2500")]
		private void JIJOBGKJLDF(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x60047A5")]
		[Address(RVA = "0x25D28A8", Offset = "0x25D28A8", VA = "0x25D28A8")]
		public bool _003C_003EiFixBaseProxy_DMAKEHDPHJO(FBCAHNCLMDC P0)
		{
			return default(bool);
		}

		[Token(Token = "0x60047A6")]
		[Address(RVA = "0x25D28AC", Offset = "0x25D28AC", VA = "0x25D28AC")]
		public void _003C_003EiFixBaseProxy_LAFFLOMGJDH(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x60047A7")]
		[Address(RVA = "0x25D28B0", Offset = "0x25D28B0", VA = "0x25D28B0")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x60047A8")]
		[Address(RVA = "0x25D28B4", Offset = "0x25D28B4", VA = "0x25D28B4")]
		public void _003C_003EiFixBaseProxy_GAIGFCBEHAK(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}

		[Token(Token = "0x60047A9")]
		[Address(RVA = "0x25D2928", Offset = "0x25D2928", VA = "0x25D2928")]
		public void _003C_003EiFixBaseProxy_LKGMANPKFKO(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}
	}

	[Token(Token = "0x200095F")]
	private class CGFJDEEGFLJ : GHGCGGOLKIP
	{
		[Token(Token = "0x60047AA")]
		[Address(RVA = "0x25D0888", Offset = "0x25D0888", VA = "0x25D0888")]
		public CGFJDEEGFLJ(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x60047AB")]
		[Address(RVA = "0x25D08A8", Offset = "0x25D08A8", VA = "0x25D08A8", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}
	}

	[Token(Token = "0x2000960")]
	private class NBAFOJNEIMI : GHGCGGOLKIP
	{
		[Token(Token = "0x60047AC")]
		[Address(RVA = "0x25DFE04", Offset = "0x25DFE04", VA = "0x25DFE04")]
		public NBAFOJNEIMI(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x60047AD")]
		[Address(RVA = "0x25DFE24", Offset = "0x25DFE24", VA = "0x25DFE24", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x60047AE")]
		[Address(RVA = "0x25DFE7C", Offset = "0x25DFE7C", VA = "0x25DFE7C", Slot = "6")]
		protected override void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x60047AF")]
		[Address(RVA = "0x25DFF80", Offset = "0x25DFF80", VA = "0x25DFF80", Slot = "5")]
		protected override void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x60047B0")]
		[Address(RVA = "0x25E0084", Offset = "0x25E0084", VA = "0x25E0084")]
		public void _003C_003EiFixBaseProxy_LAFFLOMGJDH(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x60047B1")]
		[Address(RVA = "0x25E0088", Offset = "0x25E0088", VA = "0x25E0088")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(DFKKGHCFGNM P0)
		{
		}
	}

	[Token(Token = "0x2000961")]
	private class JIGFHMMBNAP : GHGCGGOLKIP
	{
		[Token(Token = "0x60047B2")]
		[Address(RVA = "0x25D8794", Offset = "0x25D8794", VA = "0x25D8794")]
		public JIGFHMMBNAP(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x60047B3")]
		[Address(RVA = "0x25D87B4", Offset = "0x25D87B4", VA = "0x25D87B4", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x60047B4")]
		[Address(RVA = "0x25D880C", Offset = "0x25D880C", VA = "0x25D880C", Slot = "6")]
		protected override void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x60047B5")]
		[Address(RVA = "0x25D8910", Offset = "0x25D8910", VA = "0x25D8910", Slot = "5")]
		protected override void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x60047B6")]
		[Address(RVA = "0x25D8A14", Offset = "0x25D8A14", VA = "0x25D8A14", Slot = "9")]
		protected override bool DMAKEHDPHJO(FBCAHNCLMDC JDDIEPOJPKL)
		{
			return default(bool);
		}

		[Token(Token = "0x60047B7")]
		[Address(RVA = "0x25D8A90", Offset = "0x25D8A90", VA = "0x25D8A90", Slot = "8")]
		protected override void GAIGFCBEHAK(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x60047B8")]
		[Address(RVA = "0x25D8B34", Offset = "0x25D8B34", VA = "0x25D8B34", Slot = "10")]
		protected virtual void AMPELHJMNKN(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x60047B9")]
		[Address(RVA = "0x25D8D9C", Offset = "0x25D8D9C", VA = "0x25D8D9C")]
		public void _003C_003EiFixBaseProxy_LAFFLOMGJDH(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x60047BA")]
		[Address(RVA = "0x25D8DA0", Offset = "0x25D8DA0", VA = "0x25D8DA0")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x60047BB")]
		[Address(RVA = "0x25D8DA4", Offset = "0x25D8DA4", VA = "0x25D8DA4")]
		public bool _003C_003EiFixBaseProxy_DMAKEHDPHJO(FBCAHNCLMDC P0)
		{
			return default(bool);
		}

		[Token(Token = "0x60047BC")]
		[Address(RVA = "0x25D8DA8", Offset = "0x25D8DA8", VA = "0x25D8DA8")]
		public void _003C_003EiFixBaseProxy_GAIGFCBEHAK(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}
	}

	[Token(Token = "0x2000962")]
	private class ALPEOLLCIBM : GHGCGGOLKIP
	{
		[Token(Token = "0x60047BD")]
		[Address(RVA = "0x25CEA90", Offset = "0x25CEA90", VA = "0x25CEA90")]
		public ALPEOLLCIBM(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x60047BE")]
		[Address(RVA = "0x25CEAD0", Offset = "0x25CEAD0", VA = "0x25CEAD0", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x60047BF")]
		[Address(RVA = "0x25CEB28", Offset = "0x25CEB28", VA = "0x25CEB28", Slot = "9")]
		protected override bool DMAKEHDPHJO(FBCAHNCLMDC JDDIEPOJPKL)
		{
			return default(bool);
		}

		[Token(Token = "0x60047C0")]
		[Address(RVA = "0x25CEBA4", Offset = "0x25CEBA4", VA = "0x25CEBA4", Slot = "6")]
		protected override void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x60047C1")]
		[Address(RVA = "0x25CEC54", Offset = "0x25CEC54", VA = "0x25CEC54", Slot = "5")]
		protected override void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x60047C2")]
		[Address(RVA = "0x25CECFC", Offset = "0x25CECFC", VA = "0x25CECFC")]
		public bool _003C_003EiFixBaseProxy_DMAKEHDPHJO(FBCAHNCLMDC P0)
		{
			return default(bool);
		}

		[Token(Token = "0x60047C3")]
		[Address(RVA = "0x25CED70", Offset = "0x25CED70", VA = "0x25CED70")]
		public void _003C_003EiFixBaseProxy_LAFFLOMGJDH(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x60047C4")]
		[Address(RVA = "0x25CEDD0", Offset = "0x25CEDD0", VA = "0x25CEDD0")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(DFKKGHCFGNM P0)
		{
		}
	}

	[Token(Token = "0x2000963")]
	private class JMMEIFGOFEB : GHGCGGOLKIP
	{
		[Token(Token = "0x60047C5")]
		[Address(RVA = "0x25D8DAC", Offset = "0x25D8DAC", VA = "0x25D8DAC")]
		public JMMEIFGOFEB(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x60047C6")]
		[Address(RVA = "0x25D8DCC", Offset = "0x25D8DCC", VA = "0x25D8DCC", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x60047C7")]
		[Address(RVA = "0x25D8E24", Offset = "0x25D8E24", VA = "0x25D8E24", Slot = "9")]
		protected override bool DMAKEHDPHJO(FBCAHNCLMDC JDDIEPOJPKL)
		{
			return default(bool);
		}

		[Token(Token = "0x60047C8")]
		[Address(RVA = "0x25D8E88", Offset = "0x25D8E88", VA = "0x25D8E88", Slot = "6")]
		protected override void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x60047C9")]
		[Address(RVA = "0x25D9008", Offset = "0x25D9008", VA = "0x25D9008", Slot = "5")]
		protected override void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x60047CA")]
		[Address(RVA = "0x25D9090", Offset = "0x25D9090", VA = "0x25D9090")]
		public bool _003C_003EiFixBaseProxy_DMAKEHDPHJO(FBCAHNCLMDC P0)
		{
			return default(bool);
		}

		[Token(Token = "0x60047CB")]
		[Address(RVA = "0x25D9094", Offset = "0x25D9094", VA = "0x25D9094")]
		public void _003C_003EiFixBaseProxy_LAFFLOMGJDH(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x60047CC")]
		[Address(RVA = "0x25D9098", Offset = "0x25D9098", VA = "0x25D9098")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(DFKKGHCFGNM P0)
		{
		}
	}

	[Token(Token = "0x2000964")]
	private class FDJGOAIGCNF : GHGCGGOLKIP
	{
		[Token(Token = "0x60047CD")]
		[Address(RVA = "0x25D4CBC", Offset = "0x25D4CBC", VA = "0x25D4CBC")]
		public FDJGOAIGCNF(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x60047CE")]
		[Address(RVA = "0x25D4CDC", Offset = "0x25D4CDC", VA = "0x25D4CDC", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x60047CF")]
		[Address(RVA = "0x25D4D34", Offset = "0x25D4D34", VA = "0x25D4D34", Slot = "5")]
		protected override void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x60047D0")]
		[Address(RVA = "0x25D4E34", Offset = "0x25D4E34", VA = "0x25D4E34", Slot = "6")]
		protected override void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x60047D1")]
		[Address(RVA = "0x25D4F34", Offset = "0x25D4F34", VA = "0x25D4F34", Slot = "7")]
		protected override void LKGMANPKFKO(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x60047D2")]
		[Address(RVA = "0x25D4FA4", Offset = "0x25D4FA4", VA = "0x25D4FA4", Slot = "8")]
		protected override void GAIGFCBEHAK(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x60047D3")]
		[Address(RVA = "0x25D513C", Offset = "0x25D513C", VA = "0x25D513C", Slot = "9")]
		protected override bool DMAKEHDPHJO(FBCAHNCLMDC JDDIEPOJPKL)
		{
			return default(bool);
		}

		[Token(Token = "0x60047D4")]
		[Address(RVA = "0x25D505C", Offset = "0x25D505C", VA = "0x25D505C")]
		private void FMOMHFFHNGM(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x60047D5")]
		[Address(RVA = "0x25D50CC", Offset = "0x25D50CC", VA = "0x25D50CC")]
		private void CKPBABIJHPK(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x60047D6")]
		[Address(RVA = "0x25D51B8", Offset = "0x25D51B8", VA = "0x25D51B8")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x60047D7")]
		[Address(RVA = "0x25D51BC", Offset = "0x25D51BC", VA = "0x25D51BC")]
		public void _003C_003EiFixBaseProxy_LAFFLOMGJDH(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x60047D8")]
		[Address(RVA = "0x25D51C0", Offset = "0x25D51C0", VA = "0x25D51C0")]
		public void _003C_003EiFixBaseProxy_LKGMANPKFKO(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}

		[Token(Token = "0x60047D9")]
		[Address(RVA = "0x25D51C4", Offset = "0x25D51C4", VA = "0x25D51C4")]
		public void _003C_003EiFixBaseProxy_GAIGFCBEHAK(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}

		[Token(Token = "0x60047DA")]
		[Address(RVA = "0x25D51C8", Offset = "0x25D51C8", VA = "0x25D51C8")]
		public bool _003C_003EiFixBaseProxy_DMAKEHDPHJO(FBCAHNCLMDC P0)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000965")]
	private class PNJACMIHONN : GHGCGGOLKIP
	{
		[Token(Token = "0x60047DB")]
		[Address(RVA = "0x25E05A0", Offset = "0x25E05A0", VA = "0x25E05A0")]
		public PNJACMIHONN(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x60047DC")]
		[Address(RVA = "0x25E05C0", Offset = "0x25E05C0", VA = "0x25E05C0", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x60047DD")]
		[Address(RVA = "0x25E0618", Offset = "0x25E0618", VA = "0x25E0618", Slot = "6")]
		protected override void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x60047DE")]
		[Address(RVA = "0x25E09F4", Offset = "0x25E09F4", VA = "0x25E09F4", Slot = "5")]
		protected override void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x60047DF")]
		[Address(RVA = "0x25E0D50", Offset = "0x25E0D50", VA = "0x25E0D50", Slot = "8")]
		protected override void GAIGFCBEHAK(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x60047E0")]
		[Address(RVA = "0x25E10E8", Offset = "0x25E10E8", VA = "0x25E10E8", Slot = "7")]
		protected override void LKGMANPKFKO(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
		{
		}

		[Token(Token = "0x60047E1")]
		[Address(RVA = "0x25E13E0", Offset = "0x25E13E0", VA = "0x25E13E0", Slot = "9")]
		protected override bool DMAKEHDPHJO(FBCAHNCLMDC JDDIEPOJPKL)
		{
			return default(bool);
		}

		[Token(Token = "0x60047E2")]
		[Address(RVA = "0x25E1460", Offset = "0x25E1460", VA = "0x25E1460")]
		public void _003C_003EiFixBaseProxy_LAFFLOMGJDH(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x60047E3")]
		[Address(RVA = "0x25E1464", Offset = "0x25E1464", VA = "0x25E1464")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x60047E4")]
		[Address(RVA = "0x25E1468", Offset = "0x25E1468", VA = "0x25E1468")]
		public void _003C_003EiFixBaseProxy_GAIGFCBEHAK(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}

		[Token(Token = "0x60047E5")]
		[Address(RVA = "0x25E146C", Offset = "0x25E146C", VA = "0x25E146C")]
		public void _003C_003EiFixBaseProxy_LKGMANPKFKO(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}

		[Token(Token = "0x60047E6")]
		[Address(RVA = "0x25E1470", Offset = "0x25E1470", VA = "0x25E1470")]
		public bool _003C_003EiFixBaseProxy_DMAKEHDPHJO(FBCAHNCLMDC P0)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000966")]
	private class MIHDOIJMLBK : GHGCGGOLKIP
	{
		[Token(Token = "0x60047E7")]
		[Address(RVA = "0x25DF4E8", Offset = "0x25DF4E8", VA = "0x25DF4E8")]
		public MIHDOIJMLBK(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x60047E8")]
		[Address(RVA = "0x25DF508", Offset = "0x25DF508", VA = "0x25DF508", Slot = "4")]
		public override DFKKGHCFGNM KMKLAHPKDGK()
		{
			return default(DFKKGHCFGNM);
		}

		[Token(Token = "0x60047E9")]
		[Address(RVA = "0x25DF560", Offset = "0x25DF560", VA = "0x25DF560", Slot = "6")]
		protected override void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x60047EA")]
		[Address(RVA = "0x25DF9E8", Offset = "0x25DF9E8", VA = "0x25DF9E8", Slot = "5")]
		protected override void JMGKNDCPCOC(DFKKGHCFGNM JEHELPNHACP)
		{
		}

		[Token(Token = "0x60047EB")]
		[Address(RVA = "0x25DFDFC", Offset = "0x25DFDFC", VA = "0x25DFDFC")]
		public void _003C_003EiFixBaseProxy_LAFFLOMGJDH(DFKKGHCFGNM P0)
		{
		}

		[Token(Token = "0x60047EC")]
		[Address(RVA = "0x25DFE00", Offset = "0x25DFE00", VA = "0x25DFE00")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(DFKKGHCFGNM P0)
		{
		}
	}

	[Token(Token = "0x2000967")]
	protected class JHENAFAOPHA : EJJNIOHJIFE
	{
		[Token(Token = "0x60047ED")]
		[Address(RVA = "0x25D8320", Offset = "0x25D8320", VA = "0x25D8320")]
		public JHENAFAOPHA(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x60047EE")]
		[Address(RVA = "0x25D8340", Offset = "0x25D8340", VA = "0x25D8340", Slot = "12")]
		protected override void ILHPFGFCDHG(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x60047EF")]
		[Address(RVA = "0x25D858C", Offset = "0x25D858C", VA = "0x25D858C", Slot = "11")]
		protected override void DONJDIFAFJO(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x60047F0")]
		[Address(RVA = "0x25D8718", Offset = "0x25D8718", VA = "0x25D8718", Slot = "10")]
		protected override void AMPELHJMNKN(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x60047F1")]
		[Address(RVA = "0x25D8788", Offset = "0x25D8788", VA = "0x25D8788")]
		public void _003C_003EiFixBaseProxy_ILHPFGFCDHG(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}

		[Token(Token = "0x60047F2")]
		[Address(RVA = "0x25D878C", Offset = "0x25D878C", VA = "0x25D878C")]
		public void _003C_003EiFixBaseProxy_DONJDIFAFJO(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}

		[Token(Token = "0x60047F3")]
		[Address(RVA = "0x25D8790", Offset = "0x25D8790", VA = "0x25D8790")]
		public void _003C_003EiFixBaseProxy_AMPELHJMNKN(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}
	}

	[Token(Token = "0x2000968")]
	protected class FGFNPABLNPN : KEEKAONHHFO
	{
		[Token(Token = "0x60047F4")]
		[Address(RVA = "0x25D51CC", Offset = "0x25D51CC", VA = "0x25D51CC")]
		public FGFNPABLNPN(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x60047F5")]
		[Address(RVA = "0x25D520C", Offset = "0x25D520C", VA = "0x25D520C", Slot = "6")]
		protected override void LAFFLOMGJDH(DFKKGHCFGNM DLECPMBKMKM)
		{
		}

		[Token(Token = "0x60047F6")]
		[Address(RVA = "0x25D544C", Offset = "0x25D544C", VA = "0x25D544C")]
		public new void _003C_003EiFixBaseProxy_LAFFLOMGJDH(DFKKGHCFGNM P0)
		{
		}
	}

	[Token(Token = "0x2000969")]
	protected class NPHBKNFMDPD : KJCLFPMKCGB
	{
		[Token(Token = "0x60047F7")]
		[Address(RVA = "0x25E008C", Offset = "0x25E008C", VA = "0x25E008C")]
		public NPHBKNFMDPD(Player FIMNKGABILM)
		{
		}

		[Token(Token = "0x60047F8")]
		[Address(RVA = "0x25E00AC", Offset = "0x25E00AC", VA = "0x25E00AC", Slot = "10")]
		protected override void AMPELHJMNKN(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF)
		{
		}

		[Token(Token = "0x60047F9")]
		[Address(RVA = "0x25E011C", Offset = "0x25E011C", VA = "0x25E011C")]
		public void _003C_003EiFixBaseProxy_AMPELHJMNKN(DFKKGHCFGNM P0, FBCAHNCLMDC P1)
		{
		}
	}

	[Token(Token = "0x200096A")]
	public delegate void GGHHAHINCOB(Player KAEHJEGFKBL, NKNHDJPCHNO DKAMDDHEAJA, float GLEJKMBFEIG = 0f, float NILFPJJDANE = 0f);

	[Token(Token = "0x200096B")]
	public delegate void MHBKOOONOGC(Player KAEHJEGFKBL, DFKKGHCFGNM JFHIANHLOFM, DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC IHKBJIAFCMA, FBCAHNCLMDC JDDIEPOJPKL);

	[Token(Token = "0x200096C")]
	public delegate void AFICEILBKKH(Player KAEHJEGFKBL, Vector3 OLAFGGFHKFE, Quaternion HDDDEIJNMBL, float OMAFEKBHOAA);

	[Token(Token = "0x200096D")]
	private enum HCKOJDGLJCI
	{
		[Token(Token = "0x4005835")]
		Unhitted,
		[Token(Token = "0x4005836")]
		Hitted,
		[Token(Token = "0x4005837")]
		FadeIn,
		[Token(Token = "0x4005838")]
		FadeOut
	}

	[Token(Token = "0x200096E")]
	private sealed class GEOPFPEKFJK : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005839")]
		[FieldOffset(Offset = "0x8")]
		internal Player GADHAMJEKIM;

		[Token(Token = "0x400583A")]
		[FieldOffset(Offset = "0xC")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x400583B")]
		[FieldOffset(Offset = "0x10")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x400583C")]
		[FieldOffset(Offset = "0x14")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x1700059E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6004808")]
			[Address(RVA = "0x25D59B8", Offset = "0x25D59B8", VA = "0x25D59B8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700059F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004809")]
			[Address(RVA = "0x25D59C0", Offset = "0x25D59C0", VA = "0x25D59C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004806")]
		[Address(RVA = "0x25D5814", Offset = "0x25D5814", VA = "0x25D5814")]
		public GEOPFPEKFJK()
		{
		}

		[Token(Token = "0x6004807")]
		[Address(RVA = "0x25D581C", Offset = "0x25D581C", VA = "0x25D581C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600480A")]
		[Address(RVA = "0x25D59C8", Offset = "0x25D59C8", VA = "0x25D59C8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600480B")]
		[Address(RVA = "0x25D59DC", Offset = "0x25D59DC", VA = "0x25D59DC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200096F")]
	private sealed class BINFIJIGIPO
	{
		[Token(Token = "0x400583D")]
		[FieldOffset(Offset = "0x8")]
		internal uint IEPFELEIMFE;

		[Token(Token = "0x400583E")]
		[FieldOffset(Offset = "0xC")]
		internal Player GADHAMJEKIM;

		[Token(Token = "0x600480C")]
		[Address(RVA = "0x25CF72C", Offset = "0x25CF72C", VA = "0x25CF72C")]
		public BINFIJIGIPO()
		{
		}
	}

	[Token(Token = "0x2000970")]
	private sealed class HGNBIKFNBMM
	{
		[Token(Token = "0x400583F")]
		[FieldOffset(Offset = "0x8")]
		internal LevelTeleportDoor EJKDLCBJMOG;

		[Token(Token = "0x4005840")]
		[FieldOffset(Offset = "0xC")]
		internal BINFIJIGIPO CPIIAPJLCGM;

		[Token(Token = "0x600480D")]
		[Address(RVA = "0x25D7844", Offset = "0x25D7844", VA = "0x25D7844")]
		public HGNBIKFNBMM()
		{
		}

		[Token(Token = "0x600480E")]
		[Address(RVA = "0x25D784C", Offset = "0x25D784C", VA = "0x25D784C")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x2000971")]
	private sealed class CIKOGIJDBHK : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005841")]
		[FieldOffset(Offset = "0x8")]
		internal Player GADHAMJEKIM;

		[Token(Token = "0x4005842")]
		[FieldOffset(Offset = "0xC")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x4005843")]
		[FieldOffset(Offset = "0x10")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x4005844")]
		[FieldOffset(Offset = "0x14")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170005A0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6004811")]
			[Address(RVA = "0x25D0A14", Offset = "0x25D0A14", VA = "0x25D0A14", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004812")]
			[Address(RVA = "0x25D0A1C", Offset = "0x25D0A1C", VA = "0x25D0A1C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600480F")]
		[Address(RVA = "0x25D0900", Offset = "0x25D0900", VA = "0x25D0900")]
		public CIKOGIJDBHK()
		{
		}

		[Token(Token = "0x6004810")]
		[Address(RVA = "0x25D0908", Offset = "0x25D0908", VA = "0x25D0908", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004813")]
		[Address(RVA = "0x25D0A24", Offset = "0x25D0A24", VA = "0x25D0A24", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6004814")]
		[Address(RVA = "0x25D0A38", Offset = "0x25D0A38", VA = "0x25D0A38", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000972")]
	private sealed class EMCADEPBIAG : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005845")]
		[FieldOffset(Offset = "0x8")]
		internal Player GADHAMJEKIM;

		[Token(Token = "0x4005846")]
		[FieldOffset(Offset = "0xC")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x4005847")]
		[FieldOffset(Offset = "0x10")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x4005848")]
		[FieldOffset(Offset = "0x14")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x4005849")]
		[FieldOffset(Offset = "0x0")]
		private static Action<float> HMDOHFBHDOB;

		[Token(Token = "0x170005A2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6004817")]
			[Address(RVA = "0x25D4B70", Offset = "0x25D4B70", VA = "0x25D4B70", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004818")]
			[Address(RVA = "0x25D4B78", Offset = "0x25D4B78", VA = "0x25D4B78", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004815")]
		[Address(RVA = "0x25D46D8", Offset = "0x25D46D8", VA = "0x25D46D8")]
		public EMCADEPBIAG()
		{
		}

		[Token(Token = "0x6004816")]
		[Address(RVA = "0x25D46E0", Offset = "0x25D46E0", VA = "0x25D46E0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004819")]
		[Address(RVA = "0x25D4B80", Offset = "0x25D4B80", VA = "0x25D4B80", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600481A")]
		[Address(RVA = "0x25D4B94", Offset = "0x25D4B94", VA = "0x25D4B94", Slot = "6")]
		public void Reset()
		{
		}

		[Token(Token = "0x600481B")]
		[Address(RVA = "0x25D4C1C", Offset = "0x25D4C1C", VA = "0x25D4C1C")]
		private static void CHOPCLCOBKC(float NFPILHKMBHL)
		{
		}
	}

	[Token(Token = "0x2000973")]
	private sealed class LJIDGGEEJOK
	{
		[Token(Token = "0x400584A")]
		[FieldOffset(Offset = "0x8")]
		internal int JEDCNLDOCMB;

		[Token(Token = "0x400584B")]
		[FieldOffset(Offset = "0xC")]
		internal Player GADHAMJEKIM;

		[Token(Token = "0x600481C")]
		[Address(RVA = "0x25DD9F4", Offset = "0x25DD9F4", VA = "0x25DD9F4")]
		public LJIDGGEEJOK()
		{
		}

		[Token(Token = "0x600481D")]
		[Address(RVA = "0x25DD9FC", Offset = "0x25DD9FC", VA = "0x25DD9FC")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x4005590")]
	[FieldOffset(Offset = "0x48")]
	protected EEKDOKOEAEO PIGAJKODKBC;

	[Token(Token = "0x4005591")]
	[FieldOffset(Offset = "0x4C")]
	protected Dictionary<IHAAMHPPLMG, EEKDOKOEAEO> FBPNBBGKMLG;

	[Token(Token = "0x4005592")]
	[FieldOffset(Offset = "0x50")]
	protected GameObject AKAJGKMBPKC;

	[Token(Token = "0x4005593")]
	[FieldOffset(Offset = "0x54")]
	protected ResourceID IMLEGFGAJOO;

	[Token(Token = "0x4005594")]
	[FieldOffset(Offset = "0x58")]
	protected GameObject JILKEHHLFBK;

	[Token(Token = "0x4005595")]
	[FieldOffset(Offset = "0x5C")]
	protected ResourceID EPBLCLECCNB;

	[Token(Token = "0x4005596")]
	[FieldOffset(Offset = "0x60")]
	protected GameObject FBIIFPEGCJA;

	[Token(Token = "0x4005597")]
	[FieldOffset(Offset = "0x64")]
	private Dictionary<uint, int> ECEIBFFDDHB;

	[Token(Token = "0x4005598")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<uint, GameObject> DLKOOFLDPKJ;

	[Token(Token = "0x4005599")]
	[FieldOffset(Offset = "0x6C")]
	public bool isInZeppelin;

	[Token(Token = "0x400559A")]
	[FieldOffset(Offset = "0x70")]
	protected GameObject HLGGDPMJEHM;

	[Token(Token = "0x400559B")]
	[FieldOffset(Offset = "0x74")]
	private bool HCKCBDKPJCP;

	[Token(Token = "0x400559C")]
	[FieldOffset(Offset = "0x75")]
	private bool FMJKOEAAPPA;

	[Token(Token = "0x400559D")]
	[FieldOffset(Offset = "0x78")]
	private float MLLGIEIPEHA;

	[Token(Token = "0x400559E")]
	[FieldOffset(Offset = "0x7C")]
	private float CDKELFDHGOO;

	[Token(Token = "0x400559F")]
	[FieldOffset(Offset = "0x80")]
	protected bool NBGAEDGPOKI;

	[Token(Token = "0x40055A0")]
	[FieldOffset(Offset = "0x84")]
	protected GameObject LGIIDLGLPLD;

	[Token(Token = "0x40055A1")]
	[FieldOffset(Offset = "0x88")]
	private Dictionary<uint, ushort> JPOMMBKDIMP;

	[Token(Token = "0x40055A2")]
	[FieldOffset(Offset = "0x8C")]
	protected GameObject BHFKMEKICMJ;

	[Token(Token = "0x40055A3")]
	[FieldOffset(Offset = "0x90")]
	private EmoteLeaderCollider OJJCNCMFPKE;

	[Token(Token = "0x40055A4")]
	[FieldOffset(Offset = "0x94")]
	protected bool DPJJPHKPJMG;

	[Token(Token = "0x40055A5")]
	[FieldOffset(Offset = "0x95")]
	private bool DBPAMBCJLMH;

	[Token(Token = "0x40055A6")]
	[FieldOffset(Offset = "0x98")]
	protected uint EPCJCNCOIPM;

	[Token(Token = "0x40055A7")]
	[FieldOffset(Offset = "0x9C")]
	private bool IDHAHLLBEAO;

	[Token(Token = "0x40055A8")]
	[FieldOffset(Offset = "0xA0")]
	public Transform MainCameraTransform;

	[Token(Token = "0x40055A9")]
	[FieldOffset(Offset = "0xA4")]
	private NILHJAFNEJL HMMIKFIACJD;

	[Token(Token = "0x40055AA")]
	[FieldOffset(Offset = "0xA8")]
	private uint CJBNJOLJKAB;

	[Token(Token = "0x40055AB")]
	[FieldOffset(Offset = "0xB0")]
	protected ulong KMIBPHEHDNG;

	[Token(Token = "0x40055AC")]
	[FieldOffset(Offset = "0xB8")]
	protected IHAAMHPPLMG KFMGKCJMCAM;

	[Token(Token = "0x40055AD")]
	[FieldOffset(Offset = "0xD0")]
	protected ulong PLELBLDOAPF;

	[Token(Token = "0x40055AE")]
	[FieldOffset(Offset = "0xD8")]
	private int _003CNICENMJCIPK_003Ek__BackingField;

	[Token(Token = "0x40055AF")]
	[FieldOffset(Offset = "0xDC")]
	public uint TeamModeID;

	[Token(Token = "0x40055B0")]
	[FieldOffset(Offset = "0xE0")]
	public bool IsShowEquip;

	[Token(Token = "0x40055B1")]
	[FieldOffset(Offset = "0xE8")]
	private IHAAMHPPLMG _003CHMJPPFALOLK_003Ek__BackingField;

	[Token(Token = "0x40055B2")]
	[FieldOffset(Offset = "0x100")]
	private uint _003CHMENLODKOJA_003Ek__BackingField;

	[Token(Token = "0x40055B3")]
	[FieldOffset(Offset = "0x104")]
	private string _003CGDJEPAJNGKN_003Ek__BackingField;

	[Token(Token = "0x40055B4")]
	[FieldOffset(Offset = "0x108")]
	private string _003COLHGDLCEKFG_003Ek__BackingField;

	[Token(Token = "0x40055B5")]
	[FieldOffset(Offset = "0x10C")]
	private uint _003CPBPCPGHHADI_003Ek__BackingField;

	[Token(Token = "0x40055B6")]
	[FieldOffset(Offset = "0x110")]
	private uint _003CKIMHOMFJEAN_003Ek__BackingField;

	[Token(Token = "0x40055B7")]
	[FieldOffset(Offset = "0x114")]
	public bool PartyGameComboChanged;

	[Token(Token = "0x40055B8")]
	[FieldOffset(Offset = "0x118")]
	public uint PartyGameMusicShootingIndex;

	[Token(Token = "0x40055B9")]
	[FieldOffset(Offset = "0x11C")]
	public uint ServerGameMusicShootingIndex;

	[Token(Token = "0x40055BA")]
	[FieldOffset(Offset = "0x120")]
	protected object NCNCLJHGEOF;

	[Token(Token = "0x40055BB")]
	[FieldOffset(Offset = "0x124")]
	protected string OIAJCBLDHKP;

	[Token(Token = "0x40055BC")]
	[FieldOffset(Offset = "0x128")]
	public bool IsClientBot;

	[Token(Token = "0x40055BD")]
	[FieldOffset(Offset = "0x129")]
	private bool FHGIKLGCPJE;

	[Token(Token = "0x40055BE")]
	[FieldOffset(Offset = "0x130")]
	private ulong MGCDPGDFKBD;

	[Token(Token = "0x40055BF")]
	[FieldOffset(Offset = "0x138")]
	private List<AvatarSkillData> IFBNGCILJML;

	[Token(Token = "0x40055C0")]
	[FieldOffset(Offset = "0x13C")]
	protected bool IABKCAGKPAK;

	[Token(Token = "0x40055C1")]
	[FieldOffset(Offset = "0x13D")]
	private bool _003CLGLDBAFAKAO_003Ek__BackingField;

	[Token(Token = "0x40055C2")]
	[FieldOffset(Offset = "0x140")]
	protected TBlackBoard CJMCGPFMHAB;

	[Token(Token = "0x40055C3")]
	[FieldOffset(Offset = "0x144")]
	protected UserControlHandler LAHBMONIOOI;

	[Token(Token = "0x40055C4")]
	[FieldOffset(Offset = "0x148")]
	protected CharacterController HLMCNIKBHOB;

	[Token(Token = "0x40055C5")]
	[FieldOffset(Offset = "0x14C")]
	private bool DMMCDMPIDLD;

	[Token(Token = "0x40055C6")]
	[FieldOffset(Offset = "0x14D")]
	private bool GLMGFCFOCJE;

	[Token(Token = "0x40055C7")]
	[FieldOffset(Offset = "0x150")]
	private uint JMOOAILMPEE;

	[Token(Token = "0x40055C8")]
	[FieldOffset(Offset = "0x154")]
	private bool LMFGJEMJCJM;

	[Token(Token = "0x40055C9")]
	[FieldOffset(Offset = "0x155")]
	private bool EFICBKLKKKL;

	[Token(Token = "0x40055CA")]
	[FieldOffset(Offset = "0x158")]
	protected uint HPDKELNKDGG;

	[Token(Token = "0x40055CB")]
	[FieldOffset(Offset = "0x15C")]
	protected bool MIBGJAJIHFE;

	[Token(Token = "0x40055CC")]
	[FieldOffset(Offset = "0x160")]
	protected uint AEIJOOHLMME;

	[Token(Token = "0x40055CD")]
	[FieldOffset(Offset = "0x164")]
	public bool m_GetInVehicle;

	[Token(Token = "0x40055CE")]
	[FieldOffset(Offset = "0x165")]
	private bool _003CCCNDLIBNOFC_003Ek__BackingField;

	[Token(Token = "0x40055CF")]
	[FieldOffset(Offset = "0x166")]
	private bool _003CAPPMNFIOHBG_003Ek__BackingField;

	[Token(Token = "0x40055D0")]
	[FieldOffset(Offset = "0x167")]
	private bool _003CIIFBIIKDKCP_003Ek__BackingField;

	[Token(Token = "0x40055D1")]
	[FieldOffset(Offset = "0x168")]
	private bool _003CACCOOGCNEKI_003Ek__BackingField;

	[Token(Token = "0x40055D2")]
	[FieldOffset(Offset = "0x169")]
	private bool _003CIONDGFBFFJB_003Ek__BackingField;

	[Token(Token = "0x40055D3")]
	[FieldOffset(Offset = "0x16A")]
	private bool _003CNAECCHFPMDI_003Ek__BackingField;

	[Token(Token = "0x40055D4")]
	[FieldOffset(Offset = "0x16C")]
	protected LevelAmmoBox CKJEHEKAJOO;

	[Token(Token = "0x40055D5")]
	[FieldOffset(Offset = "0x170")]
	private uint _003CGBJDMPNADHL_003Ek__BackingField;

	[Token(Token = "0x40055D6")]
	[FieldOffset(Offset = "0x174")]
	public Vector3 TeamMapMark;

	[Token(Token = "0x40055D7")]
	[FieldOffset(Offset = "0x180")]
	public bool ShowMapMark;

	[Token(Token = "0x40055D8")]
	[FieldOffset(Offset = "0x184")]
	public uint CachedLastDriveVehicleObjID;

	[Token(Token = "0x40055D9")]
	[FieldOffset(Offset = "0x188")]
	public float InCount;

	[Token(Token = "0x40055DA")]
	[FieldOffset(Offset = "0x18C")]
	public float UnCount;

	[Token(Token = "0x40055DB")]
	[FieldOffset(Offset = "0x190")]
	public uint GetCount;

	[Token(Token = "0x40055DC")]
	[FieldOffset(Offset = "0x194")]
	public uint AimCount;

	[Token(Token = "0x40055DD")]
	[FieldOffset(Offset = "0x198")]
	private Quaternion JNODEFADBAF;

	[Token(Token = "0x40055DE")]
	[FieldOffset(Offset = "0x1A8")]
	public float Speed;

	[Token(Token = "0x40055DF")]
	[FieldOffset(Offset = "0x1AC")]
	private float PDNLLLONJBN;

	[Token(Token = "0x40055E0")]
	[FieldOffset(Offset = "0x1B0")]
	private Queue<float> PFJKJCJBDGO;

	[Token(Token = "0x40055E1")]
	[FieldOffset(Offset = "0x1B4")]
	public float ACount;

	[Token(Token = "0x40055E2")]
	[FieldOffset(Offset = "0x1B8")]
	private bool PGCJIBDBOJP;

	[Token(Token = "0x40055E3")]
	[FieldOffset(Offset = "0x1B9")]
	private bool KPGGOFKKNIA;

	[Token(Token = "0x40055E4")]
	[FieldOffset(Offset = "0x1BA")]
	private bool OMFDILIAFGM;

	[Token(Token = "0x40055E5")]
	[FieldOffset(Offset = "0x1BB")]
	private bool KFGOHPPJAJH;

	[Token(Token = "0x40055E6")]
	[FieldOffset(Offset = "0x1BC")]
	private float IGDKGBDOHOH;

	[Token(Token = "0x40055E7")]
	[FieldOffset(Offset = "0x1C0")]
	protected AvatarEffect AOOAPNCMNCH;

	[Token(Token = "0x40055E8")]
	[FieldOffset(Offset = "0x1C4")]
	protected GameObject OMJJGPDDDGG;

	[Token(Token = "0x40055E9")]
	[FieldOffset(Offset = "0x1C8")]
	protected PropAnimComponent OBCLHOEJBBP;

	[Token(Token = "0x40055EA")]
	[FieldOffset(Offset = "0x1CC")]
	protected GameObject MMOGANEKGEK;

	[Token(Token = "0x40055EB")]
	[FieldOffset(Offset = "0x1D0")]
	protected BattleFlagConfigData FCDOOAJKAML;

	[Token(Token = "0x40055EC")]
	[FieldOffset(Offset = "0x1D4")]
	private List<LevelRescureZone> DOEDPBEMIAA;

	[Token(Token = "0x40055ED")]
	[FieldOffset(Offset = "0x1D8")]
	private bool ALONPFNGEJA;

	[Token(Token = "0x40055EE")]
	[FieldOffset(Offset = "0x1DC")]
	protected IEnumerator DNKNEGKDJDO;

	[Token(Token = "0x40055EF")]
	[FieldOffset(Offset = "0x1E0")]
	protected IEnumerator BKFPKJLJAAA;

	[Token(Token = "0x40055F0")]
	[FieldOffset(Offset = "0x1E4")]
	private uint GBEMKMLPOEA;

	[Token(Token = "0x40055F1")]
	[FieldOffset(Offset = "0x1E8")]
	private uint BEPELMPKJDC;

	[Token(Token = "0x40055F2")]
	[FieldOffset(Offset = "0x1EC")]
	private uint FHPIKFBDLCP;

	[Token(Token = "0x40055F3")]
	[FieldOffset(Offset = "0x1F0")]
	public GPBDEDFKJNA ActiveUISightingWeapon;

	[Token(Token = "0x40055F4")]
	[FieldOffset(Offset = "0x1F4")]
	protected KCMNBMDPNAK EABOMEAANJM;

	[Token(Token = "0x40055F5")]
	[FieldOffset(Offset = "0x1F8")]
	public bool NextFireActionFromAuxButton;

	[Token(Token = "0x40055F6")]
	[FieldOffset(Offset = "0x1FC")]
	private Quaternion _003CKCFEHMAIINO_003Ek__BackingField;

	[Token(Token = "0x40055F7")]
	[FieldOffset(Offset = "0x20C")]
	private Quaternion _003CDJEKDGNFJJG_003Ek__BackingField;

	[Token(Token = "0x40055F8")]
	[FieldOffset(Offset = "0x21C")]
	public GINHBFJPFBP m_AimAssist;

	[Token(Token = "0x40055F9")]
	[FieldOffset(Offset = "0x220")]
	private bool _003CMJKMHJJJJGL_003Ek__BackingField;

	[Token(Token = "0x40055FA")]
	[FieldOffset(Offset = "0x224")]
	private float AEDMMIKNECI;

	[Token(Token = "0x40055FB")]
	[FieldOffset(Offset = "0x228")]
	private bool PCLBMKFOOEB;

	[Token(Token = "0x40055FC")]
	[FieldOffset(Offset = "0x229")]
	private bool GOGABLALMMG;

	[Token(Token = "0x40055FD")]
	[FieldOffset(Offset = "0x22A")]
	private bool PBBJJHIOFBF;

	[Token(Token = "0x40055FE")]
	[FieldOffset(Offset = "0x22B")]
	private bool _003COJPDNBCHIMO_003Ek__BackingField;

	[Token(Token = "0x40055FF")]
	[FieldOffset(Offset = "0x22C")]
	private EAimAssist GNBLLOPNPNG;

	[Token(Token = "0x4005600")]
	[FieldOffset(Offset = "0x230")]
	private FFNBBHKEDAE CPOKMKOBMGM;

	[Token(Token = "0x4005601")]
	[FieldOffset(Offset = "0x234")]
	protected CEPIKIJENLK FBNJKPALJEE;

	[Token(Token = "0x4005602")]
	[FieldOffset(Offset = "0x238")]
	private FollowCamera CHDOHNOEBML;

	[Token(Token = "0x4005603")]
	[FieldOffset(Offset = "0x23C")]
	protected ITransformNode GCMICMFEAKI;

	[Token(Token = "0x4005604")]
	[FieldOffset(Offset = "0x240")]
	protected ITransformNode OLCJOGDHJJJ;

	[Token(Token = "0x4005605")]
	[FieldOffset(Offset = "0x244")]
	protected ITransformNode OLJBCONDGLO;

	[Token(Token = "0x4005606")]
	[FieldOffset(Offset = "0x248")]
	protected ITransformNode HCLMADAFLPD;

	[Token(Token = "0x4005607")]
	[FieldOffset(Offset = "0x24C")]
	protected ITransformNode PFHDPLOAENC;

	[Token(Token = "0x4005608")]
	[FieldOffset(Offset = "0x250")]
	protected ITransformNode CENAIGAFGAG;

	[Token(Token = "0x4005609")]
	[FieldOffset(Offset = "0x254")]
	protected ITransformNode MPJBGDJJJMJ;

	[Token(Token = "0x400560A")]
	[FieldOffset(Offset = "0x258")]
	protected ITransformNode JPBJIMCDBHN;

	[Token(Token = "0x400560B")]
	[FieldOffset(Offset = "0x25C")]
	protected ITransformNode BMGCHFGEDDA;

	[Token(Token = "0x400560C")]
	[FieldOffset(Offset = "0x260")]
	protected ITransformNode AGHJLIMNPJA;

	[Token(Token = "0x400560D")]
	[FieldOffset(Offset = "0x264")]
	protected ITransformNode FDMBKCKMODA;

	[Token(Token = "0x400560E")]
	[FieldOffset(Offset = "0x268")]
	protected ITransformNode CKABHDJDMAP;

	[Token(Token = "0x400560F")]
	[FieldOffset(Offset = "0x26C")]
	protected ITransformNode KOCDBPLKMBI;

	[Token(Token = "0x4005610")]
	[FieldOffset(Offset = "0x270")]
	protected Transform EKEIMDDMFDG;

	[Token(Token = "0x4005611")]
	[FieldOffset(Offset = "0x274")]
	protected ITransformNode LIBEIIIAGIK;

	[Token(Token = "0x4005612")]
	[FieldOffset(Offset = "0x278")]
	protected ITransformNode HDEPJIBNIIK;

	[Token(Token = "0x4005613")]
	[FieldOffset(Offset = "0x27C")]
	protected ITransformNode NJDDAPKPILB;

	[Token(Token = "0x4005614")]
	[FieldOffset(Offset = "0x280")]
	protected ITransformNode JHIBMHEMJOL;

	[Token(Token = "0x4005615")]
	[FieldOffset(Offset = "0x284")]
	protected ITransformNode JBACCHNMGNJ;

	[Token(Token = "0x4005616")]
	[FieldOffset(Offset = "0x288")]
	protected ITransformNode FGECMMJKFNC;

	[Token(Token = "0x4005617")]
	[FieldOffset(Offset = "0x28C")]
	protected Collider HECFNHJKOMN;

	[Token(Token = "0x4005618")]
	[FieldOffset(Offset = "0x290")]
	protected NPCNMJAGIKI COLEAPKGFLK;

	[Token(Token = "0x4005619")]
	[FieldOffset(Offset = "0x294")]
	protected NewPlayerAnimationSystemComponent HFKJCLHCBGB;

	[Token(Token = "0x400561A")]
	[FieldOffset(Offset = "0x298")]
	protected PlayerAttributes JKPFFNEMJIF;

	[Token(Token = "0x400561B")]
	[FieldOffset(Offset = "0x29C")]
	protected AvatarManager FOGJNGDMJKJ;

	[Token(Token = "0x400561C")]
	[FieldOffset(Offset = "0x2A0")]
	protected AvatarDynamicEffectManager ICCHKILHLFH;

	[Token(Token = "0x400561D")]
	[FieldOffset(Offset = "0x2A4")]
	protected AvatarPropManager IOFIHCKMFJG;

	[Token(Token = "0x400561E")]
	[FieldOffset(Offset = "0x2A8")]
	protected PropertyData OOABFDMBHHM;

	[Token(Token = "0x400561F")]
	[FieldOffset(Offset = "0x2AC")]
	protected BigHeadComponent LBDJPFMEJIK;

	[Token(Token = "0x4005620")]
	[FieldOffset(Offset = "0x2B0")]
	protected BigHeadDataConfig DNHHAHENHLA;

	[Token(Token = "0x4005621")]
	[FieldOffset(Offset = "0x2B4")]
	protected float NIDPPKIOHNC;

	[Token(Token = "0x4005622")]
	[FieldOffset(Offset = "0x2B8")]
	protected bool BEMKJMCNFHL;

	[Token(Token = "0x4005623")]
	[FieldOffset(Offset = "0x2BC")]
	protected GameObject IBPFHDNFENM;

	[Token(Token = "0x4005624")]
	[FieldOffset(Offset = "0x2C0")]
	private bool _003CKDIONBJOKOM_003Ek__BackingField;

	[Token(Token = "0x4005625")]
	[FieldOffset(Offset = "0x2C1")]
	private bool _003CDLAPBLCDAHL_003Ek__BackingField;

	[Token(Token = "0x4005626")]
	[FieldOffset(Offset = "0x2C4")]
	protected NavMeshAgent KLDDNDJLFJB;

	[Token(Token = "0x4005627")]
	[FieldOffset(Offset = "0x2C8")]
	private NetworkPet _003CKKIEBALJHEO_003Ek__BackingField;

	[Token(Token = "0x4005628")]
	[FieldOffset(Offset = "0x2CC")]
	public bool PetForceHide;

	[Token(Token = "0x4005629")]
	[FieldOffset(Offset = "0x2CD")]
	private bool BFCJOEFIADO;

	[Token(Token = "0x400562A")]
	[FieldOffset(Offset = "0x2D0")]
	private float OPLPDHICHEI;

	[Token(Token = "0x400562B")]
	[FieldOffset(Offset = "0x2D4")]
	private Vector3 GIAOCFNMKLP;

	[Token(Token = "0x400562C")]
	[FieldOffset(Offset = "0x2E0")]
	private float FLJONGPCEHE;

	[Token(Token = "0x400562D")]
	private const float JBAEOKGLEFA = 0.5f;

	[Token(Token = "0x400562E")]
	[FieldOffset(Offset = "0x2E4")]
	private float MNDBDFDOLNL;

	[Token(Token = "0x400562F")]
	[FieldOffset(Offset = "0x2E8")]
	protected bool LJHKFOOOPBF;

	[Token(Token = "0x4005630")]
	protected const int IFCJNDPCMAL = 3;

	[Token(Token = "0x4005631")]
	[FieldOffset(Offset = "0x2EC")]
	public uint CallSetAimRotationCount;

	[Token(Token = "0x4005632")]
	[FieldOffset(Offset = "0x2F0")]
	public string TeamColorStr;

	[Token(Token = "0x4005633")]
	[FieldOffset(Offset = "0x2F4")]
	protected EMEHJLLMKNM JNGKBJICFLK;

	[Token(Token = "0x4005634")]
	[FieldOffset(Offset = "0x2F8")]
	protected TBTAction FODOLHEPEFD;

	[Token(Token = "0x4005635")]
	[FieldOffset(Offset = "0x2FC")]
	protected ILJPBIDGCDL KCOLAEGJAEP;

	[Token(Token = "0x4005636")]
	[FieldOffset(Offset = "0x300")]
	protected TBTAction OIBPDDEFIAG;

	[Token(Token = "0x4005637")]
	[FieldOffset(Offset = "0x304")]
	private bool _003CLPEIEILIKGC_003Ek__BackingField;

	[Token(Token = "0x4005638")]
	[FieldOffset(Offset = "0x308")]
	private EntityInfo ECOLJBKKDPP;

	[Token(Token = "0x4005639")]
	[FieldOffset(Offset = "0x318")]
	protected List<BFPFGLLFEKJ> DKNKEDPODIN;

	[Token(Token = "0x400563A")]
	[FieldOffset(Offset = "0x31C")]
	protected int OEIIPIHDPKP;

	[Token(Token = "0x400563B")]
	[FieldOffset(Offset = "0x320")]
	protected Vector3 NLPNKFGICKN;

	[Token(Token = "0x400563C")]
	[FieldOffset(Offset = "0x32C")]
	protected Vector3 ENJJHJECMFE;

	[Token(Token = "0x400563D")]
	[FieldOffset(Offset = "0x338")]
	protected bool OAHCAPCEACE;

	[Token(Token = "0x400563E")]
	[FieldOffset(Offset = "0x339")]
	protected bool CPOAHAKEDPO;

	[Token(Token = "0x400563F")]
	[FieldOffset(Offset = "0x33C")]
	private List<int> EFKFHDFLCOG;

	[Token(Token = "0x4005640")]
	[FieldOffset(Offset = "0x340")]
	private List<int> DFKLDJGEJDE;

	[Token(Token = "0x4005641")]
	[FieldOffset(Offset = "0x344")]
	private List<int> NNPAMCIOGNJ;

	[Token(Token = "0x4005642")]
	[FieldOffset(Offset = "0x348")]
	private Dictionary<uint, float> MGHBEOAIGPJ;

	[Token(Token = "0x4005643")]
	[FieldOffset(Offset = "0x34C")]
	private List<ClimbingTrigger> OPOHCIOFMOC;

	[Token(Token = "0x4005644")]
	[FieldOffset(Offset = "0x350")]
	private ClimbingTrigger FNJKEGLPPFP;

	[Token(Token = "0x4005645")]
	[FieldOffset(Offset = "0x354")]
	public LevelDoor CurProcessLevelDoor;

	[Token(Token = "0x4005646")]
	[FieldOffset(Offset = "0x358")]
	protected Vector3 HJHFAJACFLD;

	[Token(Token = "0x4005647")]
	[FieldOffset(Offset = "0x364")]
	protected Vehicle JGDCKBFOKNO;

	[Token(Token = "0x4005648")]
	[FieldOffset(Offset = "0x368")]
	protected LevelStrop KGJEAPMNDDB;

	[Token(Token = "0x4005649")]
	[FieldOffset(Offset = "0x36C")]
	protected FerrisWheelSeatGroup EOBIOOMCFHE;

	[Token(Token = "0x400564A")]
	[FieldOffset(Offset = "0x370")]
	protected float BCHJLPCBEKK;

	[Token(Token = "0x400564B")]
	[FieldOffset(Offset = "0x374")]
	protected LevelChair MMAENOBNBFH;

	[Token(Token = "0x400564C")]
	[FieldOffset(Offset = "0x378")]
	protected LevelCatapult DBEFOKEBPHG;

	[Token(Token = "0x400564D")]
	[FieldOffset(Offset = "0x37C")]
	protected LevelCannon HAFOKBEGIGK;

	[Token(Token = "0x400564E")]
	[FieldOffset(Offset = "0x380")]
	protected Quaternion CFKFFLJPAPL;

	[Token(Token = "0x400564F")]
	[FieldOffset(Offset = "0x390")]
	protected Quaternion JBNNBONFKKM;

	[Token(Token = "0x4005650")]
	[FieldOffset(Offset = "0x3A0")]
	protected LevelFerrisWheel OPFJPFCGKDC;

	[Token(Token = "0x4005651")]
	[FieldOffset(Offset = "0x3A4")]
	protected ITransformNode DHKPNBNNDBN;

	[Token(Token = "0x4005652")]
	[FieldOffset(Offset = "0x3A8")]
	protected ITransformNode HBFFGGLPDPL;

	[Token(Token = "0x4005653")]
	[FieldOffset(Offset = "0x3AC")]
	protected ITransformNode DJFFMJAKGGA;

	[Token(Token = "0x4005654")]
	[FieldOffset(Offset = "0x3B0")]
	protected ITransformNode CIDGDIKNJNM;

	[Token(Token = "0x4005655")]
	[FieldOffset(Offset = "0x3B4")]
	private float OCCKMDJJIGC;

	[Token(Token = "0x4005656")]
	[FieldOffset(Offset = "0x3B8")]
	private float PCJAEDCHCPK;

	[Token(Token = "0x4005657")]
	[FieldOffset(Offset = "0x3BC")]
	protected Vector3 IEDMBMHFEBN;

	[Token(Token = "0x4005658")]
	[FieldOffset(Offset = "0x3C8")]
	protected LevelGrapplingHook IAFEPPDJILB;

	[Token(Token = "0x4005659")]
	[FieldOffset(Offset = "0x3CC")]
	private PlayerLagHint LDKNCJNCPOC;

	[Token(Token = "0x400565A")]
	[FieldOffset(Offset = "0x3D0")]
	protected bool DFJLHMCEGOE;

	[Token(Token = "0x400565B")]
	[FieldOffset(Offset = "0x3D1")]
	private bool _003CLNMELDPHJND_003Ek__BackingField;

	[Token(Token = "0x400565C")]
	[FieldOffset(Offset = "0x3D2")]
	private bool _003CFEKDPENFNFC_003Ek__BackingField;

	[Token(Token = "0x400565D")]
	[FieldOffset(Offset = "0x3D4")]
	private uint LNKHKNJHKCM;

	[Token(Token = "0x400565E")]
	[FieldOffset(Offset = "0x3D8")]
	private bool _003CNEHPFAFDLMG_003Ek__BackingField;

	[Token(Token = "0x400565F")]
	[FieldOffset(Offset = "0x3D9")]
	private bool _003CBEKHBKEPPGP_003Ek__BackingField;

	[Token(Token = "0x4005660")]
	[FieldOffset(Offset = "0x3DA")]
	protected bool ODFGIJCAPAO;

	[Token(Token = "0x4005661")]
	[FieldOffset(Offset = "0x3DC")]
	protected Vector3 AAANOLNNEDP;

	[Token(Token = "0x4005662")]
	[FieldOffset(Offset = "0x3E8")]
	protected Vector3 BOPHBENCCDF;

	[Token(Token = "0x4005663")]
	[FieldOffset(Offset = "0x3F4")]
	protected bool PEHEHEMMFPI;

	[Token(Token = "0x4005664")]
	[FieldOffset(Offset = "0x3F5")]
	protected bool GCNDHHGDCEA;

	[Token(Token = "0x4005665")]
	[FieldOffset(Offset = "0x3F8")]
	protected Vector3 FAJDAHLIECL;

	[Token(Token = "0x4005666")]
	[FieldOffset(Offset = "0x404")]
	private bool _003CGDFPFHMONMF_003Ek__BackingField;

	[Token(Token = "0x4005667")]
	[FieldOffset(Offset = "0x405")]
	private bool _003CGNINDNFAMJF_003Ek__BackingField;

	[Token(Token = "0x4005668")]
	[FieldOffset(Offset = "0x406")]
	private bool _003CCCFMDCOMFAK_003Ek__BackingField;

	[Token(Token = "0x4005669")]
	[FieldOffset(Offset = "0x407")]
	private bool _003CLIANBOIJIDO_003Ek__BackingField;

	[Token(Token = "0x400566A")]
	[FieldOffset(Offset = "0x408")]
	private bool _003CNBNMJPGCKMM_003Ek__BackingField;

	[Token(Token = "0x400566B")]
	[FieldOffset(Offset = "0x409")]
	private bool PFBKKKHFOPK;

	[Token(Token = "0x400566C")]
	[FieldOffset(Offset = "0x40A")]
	private bool OMKCMEOOPKA;

	[Token(Token = "0x400566D")]
	[FieldOffset(Offset = "0x40B")]
	private bool EDPCMDPGDOH;

	[Token(Token = "0x400566E")]
	[FieldOffset(Offset = "0x40C")]
	private bool _003CPONPMCPHJCG_003Ek__BackingField;

	[Token(Token = "0x400566F")]
	[FieldOffset(Offset = "0x40D")]
	private bool CHCBNPEHMHH;

	[Token(Token = "0x4005670")]
	protected const uint KLEIOAKEPBK = 1u;

	[Token(Token = "0x4005671")]
	protected const uint ELIMKHFAEEJ = 2u;

	[Token(Token = "0x4005672")]
	protected const uint HDCGPMEBADA = 4u;

	[Token(Token = "0x4005673")]
	protected const uint IACELDMIMMP = 8u;

	[Token(Token = "0x4005674")]
	protected const uint LCOOIAMLDPH = 16u;

	[Token(Token = "0x4005675")]
	protected const uint DECLAGAPDFG = 32u;

	[Token(Token = "0x4005676")]
	protected const uint JKPIDABDNPA = 64u;

	[Token(Token = "0x4005677")]
	protected const uint PABPLOKMJJJ = 128u;

	[Token(Token = "0x4005678")]
	protected const uint MBBCLLGLKAN = 256u;

	[Token(Token = "0x4005679")]
	protected const uint MDFEFNKBAMF = 512u;

	[Token(Token = "0x400567A")]
	protected const uint AOPDCLHKLEA = 1024u;

	[Token(Token = "0x400567B")]
	protected const uint BBABEKBLAII = 2048u;

	[Token(Token = "0x400567C")]
	public const uint CHARENABLE_DEAD = 4096u;

	[Token(Token = "0x400567D")]
	[FieldOffset(Offset = "0x410")]
	protected BitArrayBoolean NAPHEFGOPOK;

	[Token(Token = "0x400567E")]
	protected const uint MKLPDBFENAC = 1u;

	[Token(Token = "0x400567F")]
	protected const uint LFJMNJIPINO = 2u;

	[Token(Token = "0x4005680")]
	protected const uint EGCCKHNBENN = 4u;

	[Token(Token = "0x4005681")]
	public const uint ISVISIBLE_ONBOARD = 8u;

	[Token(Token = "0x4005682")]
	public const uint ISVISIBLE_SKILL = 16u;

	[Token(Token = "0x4005683")]
	public const uint ISVISIBLE_ALIVE = 32u;

	[Token(Token = "0x4005684")]
	public const uint ISVISIBLE_INCUTSCENE = 64u;

	[Token(Token = "0x4005685")]
	public const uint ISVISIBLE_PRI = 128u;

	[Token(Token = "0x4005686")]
	public const uint ISVISIBLE_Transform = 256u;

	[Token(Token = "0x4005687")]
	public const uint ISVISIBLE_ZoneChange = 512u;

	[Token(Token = "0x4005688")]
	public const uint ISVISIBLE_Animation = 1024u;

	[Token(Token = "0x4005689")]
	public const uint ISVISIBLE_WereWolfDead = 2048u;

	[Token(Token = "0x400568A")]
	public const uint ISVISIBLE_SceneEdit = 4096u;

	[Token(Token = "0x400568B")]
	public const uint ISVISIBLE_PHOTOGRAPH = 8192u;

	[Token(Token = "0x400568C")]
	[FieldOffset(Offset = "0x414")]
	protected BitArrayBoolean FAGCPHGJGPI;

	[Token(Token = "0x400568D")]
	[FieldOffset(Offset = "0x418")]
	protected bool GOOIOCALNNN;

	[Token(Token = "0x400568E")]
	[FieldOffset(Offset = "0x41C")]
	protected Transform DEDJAOIJKFM;

	[Token(Token = "0x400568F")]
	[FieldOffset(Offset = "0x420")]
	protected List<JJHIMAEGAPA> DPNPDAMCHDD;

	[Token(Token = "0x4005690")]
	[FieldOffset(Offset = "0x424")]
	public bool IsSkillActive;

	[Token(Token = "0x4005691")]
	[FieldOffset(Offset = "0x428")]
	protected PGMEJCOFIGF BBJFCADNPDH;

	[Token(Token = "0x4005692")]
	[FieldOffset(Offset = "0x42C")]
	private bool BGJPEMHLKEF;

	[Token(Token = "0x4005693")]
	[FieldOffset(Offset = "0x430")]
	private Texture2D PMAICELBPPI;

	[Token(Token = "0x4005694")]
	[FieldOffset(Offset = "0x434")]
	private float NHCOJPPFDPB;

	[Token(Token = "0x4005695")]
	[FieldOffset(Offset = "0x438")]
	private float FPCAFLLFFDF;

	[Token(Token = "0x4005696")]
	[FieldOffset(Offset = "0x43C")]
	private float LGNMDAJBNCP;

	[Token(Token = "0x4005697")]
	private const float PMCMIKOFPCI = 0.02f;

	[Token(Token = "0x4005698")]
	private const float NDOEAKINCFF = 0.5f;

	[Token(Token = "0x4005699")]
	[FieldOffset(Offset = "0x440")]
	private MADMMIICBNN BOALKMLCEKO;

	[Token(Token = "0x400569A")]
	[FieldOffset(Offset = "0x444")]
	private GAGILKKDDMJ JJCIEFCHDII;

	[Token(Token = "0x400569B")]
	[FieldOffset(Offset = "0x448")]
	private MADMMIICBNN HMDJANMFEAF;

	[Token(Token = "0x400569C")]
	[FieldOffset(Offset = "0x44C")]
	private CapsuleHuman KHEEBPOHHMD;

	[Token(Token = "0x400569D")]
	[FieldOffset(Offset = "0x450")]
	private CapsuleCollider PLFOAPLCNJJ;

	[Token(Token = "0x400569E")]
	[FieldOffset(Offset = "0x454")]
	private readonly float DAJBPLPGKEO;

	[Token(Token = "0x400569F")]
	[FieldOffset(Offset = "0x458")]
	private readonly Vector3 HFJEKJLAAGG;

	[Token(Token = "0x40056A0")]
	[FieldOffset(Offset = "0x464")]
	private bool AKHCEAJPHBC;

	[Token(Token = "0x40056A1")]
	[FieldOffset(Offset = "0x468")]
	private GameObject JMIBMIHFPLI;

	[Token(Token = "0x40056A2")]
	[FieldOffset(Offset = "0x46C")]
	private List<CapsuleCollider> AIDDOCAPFKA;

	[Token(Token = "0x40056A3")]
	[FieldOffset(Offset = "0x470")]
	private AudioResource LDPJOPNGNKC;

	[Token(Token = "0x40056A4")]
	[FieldOffset(Offset = "0x474")]
	private AudioResource ELKHHIIMOCP;

	[Token(Token = "0x40056A5")]
	[FieldOffset(Offset = "0x478")]
	private AudioResource FJIAAIFGCGG;

	[Token(Token = "0x40056A6")]
	[FieldOffset(Offset = "0x47C")]
	private AudioResource BOPOAJDODMH;

	[Token(Token = "0x40056A7")]
	[FieldOffset(Offset = "0x480")]
	private AudioResource OHMIBKPBLJF;

	[Token(Token = "0x40056A8")]
	[FieldOffset(Offset = "0x484")]
	protected bool HGMCDMLCDNM;

	[Token(Token = "0x40056A9")]
	[FieldOffset(Offset = "0x488")]
	protected int FOMENKLPKOK;

	[Token(Token = "0x40056AA")]
	[FieldOffset(Offset = "0x48C")]
	private LevelTriggerFountain.CBOODHNHCFN JBEEHMKNFLK;

	[Token(Token = "0x40056AB")]
	[FieldOffset(Offset = "0x490")]
	private List<LevelTriggerHumanTire> DFHGFIABMPA;

	[Token(Token = "0x40056AC")]
	[FieldOffset(Offset = "0x494")]
	private PKLAGHHKOPO BMNPJLPCAHG;

	[Token(Token = "0x40056AD")]
	[FieldOffset(Offset = "0x498")]
	private GBJAEPHNFMD FOFFJBPHJEN;

	[Token(Token = "0x40056AE")]
	[FieldOffset(Offset = "0x49C")]
	private uint _003CAKJAMLCCNCP_003Ek__BackingField;

	[Token(Token = "0x40056AF")]
	[FieldOffset(Offset = "0x4A0")]
	private float CFBBENDFAJB;

	[Token(Token = "0x40056B0")]
	[FieldOffset(Offset = "0x4A4")]
	private float EJJCNCMMPJG;

	[Token(Token = "0x40056B1")]
	[FieldOffset(Offset = "0x4A8")]
	private bool OMIOGAMPNCO;

	[Token(Token = "0x40056B2")]
	[FieldOffset(Offset = "0x4AC")]
	private float BGIHFDHDBBL;

	[Token(Token = "0x40056B3")]
	[FieldOffset(Offset = "0x4B0")]
	private bool _003CCDOBMFNCJHD_003Ek__BackingField;

	[Token(Token = "0x40056B4")]
	[FieldOffset(Offset = "0x4B1")]
	private byte _003CKGEEJEELIKB_003Ek__BackingField;

	[Token(Token = "0x40056B5")]
	[FieldOffset(Offset = "0x4B2")]
	protected bool DLKHKAEKCJF;

	[Token(Token = "0x40056B6")]
	[FieldOffset(Offset = "0x4B4")]
	protected float KFMADIEPNPD;

	[Token(Token = "0x40056B7")]
	[FieldOffset(Offset = "0x4B8")]
	protected ResourceID NIKLELPPGHB;

	[Token(Token = "0x40056B8")]
	[FieldOffset(Offset = "0x4BC")]
	protected ResourceID PGKGMOIFFFI;

	[Token(Token = "0x40056B9")]
	[FieldOffset(Offset = "0x4C0")]
	protected ResourceID BHLLEKOLGGE;

	[Token(Token = "0x40056BA")]
	[FieldOffset(Offset = "0x4C4")]
	protected SkyboardData HLBFHIPPHMG;

	[Token(Token = "0x40056BB")]
	[FieldOffset(Offset = "0x4C8")]
	protected FlightData FHOPNAMDKCG;

	[Token(Token = "0x40056BC")]
	[FieldOffset(Offset = "0x4CC")]
	protected PlayerAudioComponent CAIANDEEDFA;

	[Token(Token = "0x40056BD")]
	[FieldOffset(Offset = "0x4D0")]
	protected GameObject MIGFGFBEIAI;

	[Token(Token = "0x40056BE")]
	[FieldOffset(Offset = "0x4D4")]
	protected Flight IBHNPLCMKMJ;

	[Token(Token = "0x40056BF")]
	[FieldOffset(Offset = "0x4D8")]
	protected Animator GOOCOCIJHMD;

	[Token(Token = "0x40056C0")]
	[FieldOffset(Offset = "0x4DC")]
	protected GameObject OGHCAIDNDIC;

	[Token(Token = "0x40056C1")]
	[FieldOffset(Offset = "0x4E0")]
	protected Parachute MMCDCKLFJMC;

	[Token(Token = "0x40056C2")]
	[FieldOffset(Offset = "0x4E4")]
	protected GameObject KIKLGCHBKNF;

	[Token(Token = "0x40056C3")]
	[FieldOffset(Offset = "0x4E8")]
	protected GameObject LHEABNEBLKJ;

	[Token(Token = "0x40056C4")]
	[FieldOffset(Offset = "0x4EC")]
	protected GameObject OOCMAEECDLO;

	[Token(Token = "0x40056C5")]
	[FieldOffset(Offset = "0x4F0")]
	protected GameObject JEBJINAPCMP;

	[Token(Token = "0x40056C6")]
	[FieldOffset(Offset = "0x4F4")]
	protected GameObject LPDDIILCOPB;

	[Token(Token = "0x40056C7")]
	[FieldOffset(Offset = "0x4F8")]
	protected GameObject AJOCBJKJFBG;

	[Token(Token = "0x40056C8")]
	[FieldOffset(Offset = "0x4FC")]
	protected GameObject JCBDAMEOFJD;

	[Token(Token = "0x40056C9")]
	[FieldOffset(Offset = "0x500")]
	protected GameObject PGLNGCLGFFM;

	[Token(Token = "0x40056CA")]
	[FieldOffset(Offset = "0x504")]
	protected StropRing KBPIGIGLOEI;

	[Token(Token = "0x40056CB")]
	[FieldOffset(Offset = "0x508")]
	protected GameObject IPMMKNDHJIG;

	[Token(Token = "0x40056CC")]
	[FieldOffset(Offset = "0x50C")]
	protected GameObject EEKDPNLGIGD;

	[Token(Token = "0x40056CD")]
	[FieldOffset(Offset = "0x510")]
	public GameObject m_CamouflageUniformGO;

	[Token(Token = "0x40056CE")]
	[FieldOffset(Offset = "0x514")]
	protected GameObject MBOGLBPFBMO;

	[Token(Token = "0x40056CF")]
	[FieldOffset(Offset = "0x518")]
	protected GameObject HPFEBMEAFLH;

	[Token(Token = "0x40056D0")]
	[FieldOffset(Offset = "0x51C")]
	protected GameObject EPECOOLMCCE;

	[Token(Token = "0x40056D1")]
	[FieldOffset(Offset = "0x520")]
	protected LevelHayrickOrigin PEHLMCLMJNB;

	[Token(Token = "0x40056D2")]
	[FieldOffset(Offset = "0x524")]
	protected LevelHayrickEnd LJMCJBLMBNI;

	[Token(Token = "0x40056D3")]
	[FieldOffset(Offset = "0x528")]
	protected Dictionary<ResourceID, List<GameObject>> FJHBPOGNLIP;

	[Token(Token = "0x40056D4")]
	[FieldOffset(Offset = "0x52C")]
	private GameObject FBPEKCNNNBH;

	[Token(Token = "0x40056D5")]
	[FieldOffset(Offset = "0x530")]
	protected GameObject GECMAEDCDNF;

	[Token(Token = "0x40056D6")]
	[FieldOffset(Offset = "0x534")]
	protected ResourceID AAMHKAKPBDG;

	[Token(Token = "0x40056D7")]
	[FieldOffset(Offset = "0x538")]
	protected GameObject LGOMNIOFGNN;

	[Token(Token = "0x40056D8")]
	[FieldOffset(Offset = "0x53C")]
	protected ResourceID IPGGFDIKDPD;

	[Token(Token = "0x40056D9")]
	[FieldOffset(Offset = "0x540")]
	protected ResourceID BNMNECHHHEB;

	[Token(Token = "0x40056DA")]
	[FieldOffset(Offset = "0x544")]
	private Dictionary<int, ResourceID> HBKNPLBMPOP;

	[Token(Token = "0x40056DB")]
	[FieldOffset(Offset = "0x548")]
	private GameObject NCCOBMFEMHN;

	[Token(Token = "0x40056DC")]
	[FieldOffset(Offset = "0x54C")]
	private bool FBEHNEEFMPO;

	[Token(Token = "0x40056DD")]
	[FieldOffset(Offset = "0x550")]
	private float BPNGKBJNPBM;

	[Token(Token = "0x40056DE")]
	[FieldOffset(Offset = "0x554")]
	private JNGKMJDINHC MCBOALKDHLJ;

	[Token(Token = "0x40056DF")]
	[FieldOffset(Offset = "0x558")]
	private MALGAHKKNNN HFKCFHINHNF;

	[Token(Token = "0x40056E0")]
	[FieldOffset(Offset = "0x55C")]
	private EntityInfo JNDGKAICLGP;

	[Token(Token = "0x40056E1")]
	[FieldOffset(Offset = "0x56C")]
	private bool JHOEDAABEKH;

	[Token(Token = "0x40056E2")]
	[FieldOffset(Offset = "0x570")]
	private Quaternion NGDLLEBMAAJ;

	[Token(Token = "0x40056E3")]
	private const float OOLEHDECAKK = 35f;

	[Token(Token = "0x40056E4")]
	private const float HLGMDFABCAJ = 135f;

	[Token(Token = "0x40056E5")]
	[FieldOffset(Offset = "0x580")]
	private float KJOFGFIOJAC;

	[Token(Token = "0x40056E6")]
	[FieldOffset(Offset = "0x584")]
	public float m_ControlDirectionResetTime;

	[Token(Token = "0x40056E7")]
	[FieldOffset(Offset = "0x588")]
	public float m_AuxAimResetTime;

	[Token(Token = "0x40056E8")]
	[FieldOffset(Offset = "0x58C")]
	public float m_MinAngleX;

	[Token(Token = "0x40056E9")]
	[FieldOffset(Offset = "0x590")]
	public float m_MaxAngleX;

	[Token(Token = "0x40056EA")]
	[FieldOffset(Offset = "0x594")]
	private float BNIBBPOJLHE;

	[Token(Token = "0x40056EB")]
	[FieldOffset(Offset = "0x598")]
	private MADMMIICBNN GEGFCFDGGGP;

	[Token(Token = "0x40056EC")]
	[FieldOffset(Offset = "0x59C")]
	private MADMMIICBNN IHGEFBPODCC;

	[Token(Token = "0x40056ED")]
	[FieldOffset(Offset = "0x5A0")]
	public bool LastAimingInfoFromWeaponAdjusted;

	[Token(Token = "0x40056EE")]
	[FieldOffset(Offset = "0x5A1")]
	private bool CCAIBFNCKCG;

	[Token(Token = "0x40056EF")]
	[FieldOffset(Offset = "0x5A2")]
	private bool FGFMOPILOIM;

	[Token(Token = "0x40056F0")]
	[FieldOffset(Offset = "0x5A4")]
	private OPILIBBOEAC _003CIMIKNCAFOCH_003Ek__BackingField;

	[Token(Token = "0x40056F1")]
	[FieldOffset(Offset = "0x5A8")]
	private uint HMNPPKCOJJB;

	[Token(Token = "0x40056F2")]
	[FieldOffset(Offset = "0x5AC")]
	public float LastPlayBulletTrackEffectTime;

	[Token(Token = "0x40056F3")]
	[FieldOffset(Offset = "0x5B0")]
	private GameObject OKIGDDNAKLO;

	[Token(Token = "0x40056F4")]
	[FieldOffset(Offset = "0x5B4")]
	private uint GMBJMMEHNOK;

	[Token(Token = "0x40056F5")]
	[FieldOffset(Offset = "0x5B8")]
	private GameObject AGDKBLNIILL;

	[Token(Token = "0x40056F6")]
	[FieldOffset(Offset = "0x5BC")]
	private GameObject PCAOEKALLDM;

	[Token(Token = "0x40056F7")]
	[FieldOffset(Offset = "0x5C0")]
	private GameObject JDHIDBEKPFN;

	[Token(Token = "0x40056F8")]
	[FieldOffset(Offset = "0x5C4")]
	private GameObject LIBHOJCBFJH;

	[Token(Token = "0x40056F9")]
	[FieldOffset(Offset = "0x5C8")]
	private GameObject BPJPIEFPMDE;

	[Token(Token = "0x40056FA")]
	[FieldOffset(Offset = "0x5CC")]
	private bool BDOLEIDDIDI;

	[Token(Token = "0x40056FB")]
	[FieldOffset(Offset = "0x5D0")]
	private GameObject PBOPOFJDGBN;

	[Token(Token = "0x40056FC")]
	[FieldOffset(Offset = "0x5D4")]
	private ResourceID GAABJILEOLP;

	[Token(Token = "0x40056FD")]
	[FieldOffset(Offset = "0x5D8")]
	private GameObject BBCPMLPEIFH;

	[Token(Token = "0x40056FE")]
	[FieldOffset(Offset = "0x5DC")]
	private ResourceID MBFDMHKLFMC;

	[Token(Token = "0x40056FF")]
	[FieldOffset(Offset = "0x5E0")]
	private ResourceID KJHHECHKBJB;

	[Token(Token = "0x4005700")]
	[FieldOffset(Offset = "0x5E4")]
	private GameObject GEHBAODHEAG;

	[Token(Token = "0x4005701")]
	[FieldOffset(Offset = "0x5E8")]
	public bool Is3PStopFire_WaitingChangeClipAnim;

	[Token(Token = "0x4005702")]
	[FieldOffset(Offset = "0x5EC")]
	protected AudioResource IHDNEGGNKPP;

	[Token(Token = "0x4005703")]
	[FieldOffset(Offset = "0x5F0")]
	private RuntimeAnimatorController DLHPJNALDBE;

	[Token(Token = "0x4005704")]
	[FieldOffset(Offset = "0x5F4")]
	protected GameObject NPBHHCMPLKD;

	[Token(Token = "0x4005705")]
	[FieldOffset(Offset = "0x5F8")]
	private float BAFFFHFPNOC;

	[Token(Token = "0x4005706")]
	[FieldOffset(Offset = "0x5FC")]
	private bool GKEOBAEDPFJ;

	[Token(Token = "0x4005707")]
	[FieldOffset(Offset = "0x5FD")]
	private bool CKCMCCFJHJL;

	[Token(Token = "0x4005708")]
	[FieldOffset(Offset = "0x600")]
	private float NNMHGOKCNJD;

	[Token(Token = "0x4005709")]
	[FieldOffset(Offset = "0x604")]
	private float HCLPKLFPMPP;

	[Token(Token = "0x400570A")]
	[FieldOffset(Offset = "0x608")]
	private float PDBGMCCBINL;

	[Token(Token = "0x400570B")]
	[FieldOffset(Offset = "0x60C")]
	private int OONNCMGHNNF;

	[Token(Token = "0x400570C")]
	[FieldOffset(Offset = "0x610")]
	private float GHJIFCGFKIK;

	[Token(Token = "0x400570D")]
	[FieldOffset(Offset = "0x614")]
	private float AAJPJLFGBGG;

	[Token(Token = "0x400570E")]
	[FieldOffset(Offset = "0x618")]
	private float AAKJAGGDPCK;

	[Token(Token = "0x400570F")]
	[FieldOffset(Offset = "0x61C")]
	private float EIOCLNPDFJH;

	[Token(Token = "0x4005710")]
	private const float KINDGEAMENC = 326f;

	[Token(Token = "0x4005711")]
	private const float KALEDIELNCI = 300f;

	[Token(Token = "0x4005712")]
	private const float PLIAMDPHPHE = 3f;

	[Token(Token = "0x4005713")]
	[FieldOffset(Offset = "0x620")]
	protected LevelItemPlant GLMFPMNIFCN;

	[Token(Token = "0x4005714")]
	[FieldOffset(Offset = "0x624")]
	private LinkedList<Vector2> FMPPBIOCMEL;

	[Token(Token = "0x4005715")]
	[FieldOffset(Offset = "0x628")]
	private bool _003CEJBPAOEEGJB_003Ek__BackingField;

	[Token(Token = "0x4005716")]
	[FieldOffset(Offset = "0x62C")]
	protected GameObject LLIKLJNGCDD;

	[Token(Token = "0x4005717")]
	[FieldOffset(Offset = "0x630")]
	protected ResourceID BDHGEBNCOHG;

	[Token(Token = "0x4005718")]
	[FieldOffset(Offset = "0x634")]
	private List<Vector3> KMPFOMBMCKD;

	[Token(Token = "0x4005719")]
	[FieldOffset(Offset = "0x638")]
	private float JDLCFLIPIFJ;

	[Token(Token = "0x400571A")]
	[FieldOffset(Offset = "0x63C")]
	private float IJAOMFAFPDK;

	[Token(Token = "0x400571B")]
	[FieldOffset(Offset = "0x640")]
	private bool EGIJMCIAPHA;

	[Token(Token = "0x400571C")]
	[FieldOffset(Offset = "0x644")]
	private ResourceID DPGJOJGKNCB;

	[Token(Token = "0x400571D")]
	[FieldOffset(Offset = "0x648")]
	private GameObject MDNGNAAPINN;

	[Token(Token = "0x400571E")]
	[FieldOffset(Offset = "0x64C")]
	private GameObject JDHEINBKCCO;

	[Token(Token = "0x400571F")]
	[FieldOffset(Offset = "0x650")]
	private ResourceID JHFAJJALKEI;

	[Token(Token = "0x4005720")]
	[FieldOffset(Offset = "0x654")]
	private GameObject JPHHDGJMCJG;

	[Token(Token = "0x4005721")]
	[FieldOffset(Offset = "0x658")]
	private bool AMHMPIHPJMJ;

	[Token(Token = "0x4005722")]
	[FieldOffset(Offset = "0x659")]
	private bool EIMKLIKDICP;

	[Token(Token = "0x4005723")]
	[FieldOffset(Offset = "0x65C")]
	private GameObject HALJPCILNOA;

	[Token(Token = "0x4005724")]
	[FieldOffset(Offset = "0x660")]
	private GameObject KINEPNMINDN;

	[Token(Token = "0x4005725")]
	[FieldOffset(Offset = "0x664")]
	private ResourceID LCGMGMAFIGI;

	[Token(Token = "0x4005726")]
	[FieldOffset(Offset = "0x668")]
	protected List<GameObject> GBDKCGEPGKD;

	[Token(Token = "0x4005727")]
	[FieldOffset(Offset = "0x66C")]
	private int BCHLPJMEMAN;

	[Token(Token = "0x4005728")]
	[FieldOffset(Offset = "0x670")]
	private ResourceID NABLMGKLAEB;

	[Token(Token = "0x4005729")]
	[FieldOffset(Offset = "0x674")]
	private bool PDDLACPFBGP;

	[Token(Token = "0x400572A")]
	[FieldOffset(Offset = "0x678")]
	private float CGGDNMFAOMB;

	[Token(Token = "0x400572B")]
	[FieldOffset(Offset = "0x67C")]
	protected GPGBALKIDJK HJEPPEFPGIB;

	[Token(Token = "0x400572C")]
	[FieldOffset(Offset = "0x680")]
	private bool CAMHBNPLLKL;

	[Token(Token = "0x400572D")]
	[FieldOffset(Offset = "0x684")]
	private float DAHOOELNILG;

	[Token(Token = "0x400572E")]
	[FieldOffset(Offset = "0x688")]
	private Vector2 LILENNDENJG;

	[Token(Token = "0x400572F")]
	[FieldOffset(Offset = "0x690")]
	private AudioResource FCDMMFCJCIF;

	[Token(Token = "0x4005730")]
	[FieldOffset(Offset = "0x694")]
	private bool IPALGNHIGGP;

	[Token(Token = "0x4005731")]
	[FieldOffset(Offset = "0x695")]
	private bool NIOKPGHHFLE;

	[Token(Token = "0x4005732")]
	[FieldOffset(Offset = "0x698")]
	private PCAirTrailView CCGGMOEJAMH;

	[Token(Token = "0x4005733")]
	[FieldOffset(Offset = "0x69C")]
	private LevelEmote NAJACJCDPPH;

	[Token(Token = "0x4005734")]
	[FieldOffset(Offset = "0x6A0")]
	private ResourceID IKKMCEGOFHN;

	[Token(Token = "0x4005735")]
	[FieldOffset(Offset = "0x6A4")]
	private GameObject JHHABGNEDGC;

	[Token(Token = "0x4005736")]
	[FieldOffset(Offset = "0x6A8")]
	private Dictionary<GameObject, Transform> GFIMHENBJHJ;

	[Token(Token = "0x4005737")]
	private const uint GEGPKGONNFK = 2u;

	[Token(Token = "0x4005738")]
	[FieldOffset(Offset = "0x6AC")]
	private GameObject JMLNCICDOAJ;

	[Token(Token = "0x4005739")]
	[FieldOffset(Offset = "0x6B0")]
	private float OFBPIDMAGJF;

	[Token(Token = "0x400573A")]
	[FieldOffset(Offset = "0x6B4")]
	private float DCBOLAEAPCP;

	[Token(Token = "0x400573B")]
	[FieldOffset(Offset = "0x6B8")]
	private bool ANKOBFEMGCG;

	[Token(Token = "0x400573C")]
	[FieldOffset(Offset = "0x6BC")]
	private List<int> IHBLOBAHOCL;

	[Token(Token = "0x400573D")]
	[FieldOffset(Offset = "0x6C0")]
	private GameObject MNIIFADNNEI;

	[Token(Token = "0x400573E")]
	[FieldOffset(Offset = "0x6C4")]
	private GameObject IGEHMJFLFLK;

	[Token(Token = "0x400573F")]
	[FieldOffset(Offset = "0x6C8")]
	private float NHDKAFCHKPN;

	[Token(Token = "0x4005740")]
	[FieldOffset(Offset = "0x6CC")]
	private float HOGELEIOFBN;

	[Token(Token = "0x4005741")]
	[FieldOffset(Offset = "0x6D0")]
	private float JKGANBCKJJF;

	[Token(Token = "0x4005742")]
	[FieldOffset(Offset = "0x6D4")]
	private float EIDHPEPGOFJ;

	[Token(Token = "0x4005743")]
	[FieldOffset(Offset = "0x6D8")]
	private bool AHCHKHNPNPN;

	[Token(Token = "0x4005744")]
	[FieldOffset(Offset = "0x6DC")]
	private List<float> OHFDNGOPJNM;

	[Token(Token = "0x4005745")]
	[FieldOffset(Offset = "0x6E0")]
	private GameObject AOKBGOECKJD;

	[Token(Token = "0x4005746")]
	[FieldOffset(Offset = "0x6E4")]
	private GameObject CNEBMPLCDFJ;

	[Token(Token = "0x4005747")]
	[FieldOffset(Offset = "0x6E8")]
	private ResourceID HGGJJGAFOEB;

	[Token(Token = "0x4005748")]
	[FieldOffset(Offset = "0x6EC")]
	protected bool HENICAOMCDF;

	[Token(Token = "0x4005749")]
	[FieldOffset(Offset = "0x6F0")]
	private AudioResource IGGLNPCAKBF;

	[Token(Token = "0x400574A")]
	[FieldOffset(Offset = "0x6F4")]
	public bool IsAtPartyGameSoloDanceBattleField;

	[Token(Token = "0x400574B")]
	[FieldOffset(Offset = "0x6F5")]
	public bool IsPartyGameSoloDancePreparing;

	[Token(Token = "0x400574C")]
	[FieldOffset(Offset = "0x6F6")]
	public bool IsPartyGameSoloDanceBattling;

	[Token(Token = "0x400574D")]
	[FieldOffset(Offset = "0x6F8")]
	public HNJPDMBFFJH ActSkillUpdateKinmaticsCall;

	[Token(Token = "0x400574E")]
	[FieldOffset(Offset = "0x6FC")]
	protected FDMPBIEMHAF NCLJLFMCMCO;

	[Token(Token = "0x400574F")]
	[FieldOffset(Offset = "0x700")]
	private bool _003CHKEECLPNLMK_003Ek__BackingField;

	[Token(Token = "0x4005750")]
	[FieldOffset(Offset = "0x701")]
	private bool _003CNCOILFBAHHH_003Ek__BackingField;

	[Token(Token = "0x4005751")]
	[FieldOffset(Offset = "0x702")]
	private bool _003CMFEHPDLGNAL_003Ek__BackingField;

	[Token(Token = "0x4005752")]
	[FieldOffset(Offset = "0x703")]
	private bool _003CPHFKOPMMCAE_003Ek__BackingField;

	[Token(Token = "0x4005753")]
	[FieldOffset(Offset = "0x704")]
	private bool _003COMDHJPALMCN_003Ek__BackingField;

	[Token(Token = "0x4005754")]
	[FieldOffset(Offset = "0x705")]
	public bool IsKnockedDownBleed;

	[Token(Token = "0x4005755")]
	[FieldOffset(Offset = "0x708")]
	private Transform IHEEHABIPJK;

	[Token(Token = "0x4005756")]
	[FieldOffset(Offset = "0x70C")]
	public GameObject m_TransformObject;

	[Token(Token = "0x4005757")]
	[FieldOffset(Offset = "0x710")]
	protected PFLCPEHBBLN HHMBLJDMHAJ;

	[Token(Token = "0x4005758")]
	[FieldOffset(Offset = "0x714")]
	protected bool ODMOIMMJICK;

	[Token(Token = "0x4005759")]
	[FieldOffset(Offset = "0x718")]
	protected GameObject NPHCEHACHBC;

	[Token(Token = "0x400575A")]
	[FieldOffset(Offset = "0x71C")]
	private Dictionary<uint, float> NHNCFOHEDAO;

	[Token(Token = "0x400575B")]
	[FieldOffset(Offset = "0x720")]
	protected CIIDIPDOOLC LKBDNHEBLML;

	[Token(Token = "0x400575C")]
	[FieldOffset(Offset = "0x724")]
	private AvatarTransformer LGKMIPFPCMM;

	[Token(Token = "0x400575D")]
	[FieldOffset(Offset = "0x728")]
	private bool OJHKLPIADDA;

	[Token(Token = "0x400575E")]
	[FieldOffset(Offset = "0x72C")]
	protected CKGPOJHAKOI EEGNIJLGCBI;

	[Token(Token = "0x400575F")]
	[FieldOffset(Offset = "0x730")]
	private float AILOFDKBIEI;

	[Token(Token = "0x4005760")]
	[FieldOffset(Offset = "0x734")]
	private float KPKJIPJJOEL;

	[Token(Token = "0x4005761")]
	[FieldOffset(Offset = "0x738")]
	private float GGEPKEONELC;

	[Token(Token = "0x4005762")]
	[FieldOffset(Offset = "0x73C")]
	private float OOAKFNMLCDA;

	[Token(Token = "0x4005763")]
	[FieldOffset(Offset = "0x740")]
	private Quaternion LDFINGBJFFO;

	[Token(Token = "0x4005764")]
	[FieldOffset(Offset = "0x750")]
	private Quaternion FHEBFMCEPKH;

	[Token(Token = "0x4005765")]
	[FieldOffset(Offset = "0x760")]
	private Quaternion KBJPPFLOHFG;

	[Token(Token = "0x4005766")]
	[FieldOffset(Offset = "0x770")]
	private Quaternion MLAJHCFEKLN;

	[Token(Token = "0x4005767")]
	[FieldOffset(Offset = "0x780")]
	private ClimbingTrigger FLJAGFADKJJ;

	[Token(Token = "0x4005768")]
	[FieldOffset(Offset = "0x784")]
	public float minAngleInCreep;

	[Token(Token = "0x4005769")]
	[FieldOffset(Offset = "0x788")]
	public float maxAngleInCreep;

	[Token(Token = "0x400576A")]
	[FieldOffset(Offset = "0x78C")]
	private MADMMIICBNN NFAHKACNAPB;

	[Token(Token = "0x400576B")]
	[FieldOffset(Offset = "0x790")]
	private bool? DADKBHNGOPJ;

	[Token(Token = "0x400576C")]
	[FieldOffset(Offset = "0x794")]
	private float CPBNDNOGCFM;

	[Token(Token = "0x400576D")]
	[FieldOffset(Offset = "0x798")]
	private float PGIFAOABEOM;

	[Token(Token = "0x400576E")]
	[FieldOffset(Offset = "0x79C")]
	protected GameObject AIBMDPHPJHK;

	[Token(Token = "0x400576F")]
	[FieldOffset(Offset = "0x7A0")]
	protected GameObject[] FKCLOFBCFEB;

	[Token(Token = "0x4005770")]
	[FieldOffset(Offset = "0x7A4")]
	protected LGLMLIBMLAM BMLEGOEAGKF;

	[Token(Token = "0x4005771")]
	[FieldOffset(Offset = "0x7A8")]
	public bool IsDoubleJumpTriggered;

	[Token(Token = "0x4005772")]
	[FieldOffset(Offset = "0x7AC")]
	protected GameObject KLFBNALOAIC;

	[Token(Token = "0x4005773")]
	[FieldOffset(Offset = "0x7B0")]
	protected GameObject IIGHDHHBBCL;

	[Token(Token = "0x4005774")]
	[FieldOffset(Offset = "0x7B4")]
	protected AMPGCIMNMBI FOEFIDJIHLP;

	[Token(Token = "0x4005775")]
	[FieldOffset(Offset = "0x7B8")]
	private bool _003CIFAPMMCMAGF_003Ek__BackingField;

	[Token(Token = "0x4005776")]
	[FieldOffset(Offset = "0x7BC")]
	private float NPELJHNMCLM;

	[Token(Token = "0x4005777")]
	[FieldOffset(Offset = "0x7C0")]
	protected Vector3 AGLPCFJDOEK;

	[Token(Token = "0x4005778")]
	[FieldOffset(Offset = "0x7CC")]
	protected MILCMIMPDMG ODGHKHFAPON;

	[Token(Token = "0x4005779")]
	[FieldOffset(Offset = "0x7F4")]
	protected CCGBDNBALMI JNBLBAACNIF;

	[Token(Token = "0x400577A")]
	[FieldOffset(Offset = "0x7F8")]
	private FoldWingConfigData COMEEIBGFFH;

	[Token(Token = "0x400577B")]
	[FieldOffset(Offset = "0x7FC")]
	public GameObject m_FoldWingIAmIn;

	[Token(Token = "0x400577C")]
	[FieldOffset(Offset = "0x800")]
	private bool PBPODOFEMGA;

	[Token(Token = "0x400577D")]
	[FieldOffset(Offset = "0x804")]
	private uint FLOPLHHJOOB;

	[Token(Token = "0x400577E")]
	[FieldOffset(Offset = "0x808")]
	protected float ONKBEPDPMIN;

	[Token(Token = "0x400577F")]
	[FieldOffset(Offset = "0x80C")]
	protected GameObject IMGBBFACIBP;

	[Token(Token = "0x4005780")]
	[FieldOffset(Offset = "0x810")]
	protected SphereCollider IMJJHDCEAPK;

	[Token(Token = "0x4005781")]
	[FieldOffset(Offset = "0x814")]
	protected Football DIMIKOEBCAM;

	[Token(Token = "0x4005782")]
	[FieldOffset(Offset = "0x818")]
	protected FootballHitTrigger JBHIAACEOOO;

	[Token(Token = "0x4005783")]
	[FieldOffset(Offset = "0x81C")]
	public Vector3 m_FootballHitVelocity;

	[Token(Token = "0x4005784")]
	[FieldOffset(Offset = "0x828")]
	protected float DKECBLGHKPH;

	[Token(Token = "0x4005785")]
	[FieldOffset(Offset = "0x82C")]
	protected bool FABPGCNFANC;

	[Token(Token = "0x4005786")]
	[FieldOffset(Offset = "0x0")]
	public static readonly float FOOTBALL_MOVE_EPSILON;

	[Token(Token = "0x4005787")]
	[FieldOffset(Offset = "0x830")]
	protected Vector3 PJDLFBIJJCJ;

	[Token(Token = "0x4005788")]
	[FieldOffset(Offset = "0x83C")]
	protected GameObject NCJOKPHEEGM;

	[Token(Token = "0x4005789")]
	[FieldOffset(Offset = "0x840")]
	protected AudioSource CGOLMJKNPLI;

	[Token(Token = "0x400578A")]
	[FieldOffset(Offset = "0x4")]
	public static readonly Dictionary<string, int> TagToBeneathFeet;

	[Token(Token = "0x400578B")]
	[FieldOffset(Offset = "0x844")]
	protected List<GPAMIDPFIDI> PJJGMNDOHOJ;

	[Token(Token = "0x400578C")]
	[FieldOffset(Offset = "0x848")]
	private float LFNHKGOLDKA;

	[Token(Token = "0x400578D")]
	[FieldOffset(Offset = "0x84C")]
	protected Vector3 ECPJLGNDCEH;

	[Token(Token = "0x400578E")]
	[FieldOffset(Offset = "0x858")]
	private ResourceID AHLFDJKCMKL;

	[Token(Token = "0x400578F")]
	[FieldOffset(Offset = "0x85C")]
	protected CKMBFCELDAO NPMKIFFMMHH;

	[Token(Token = "0x4005790")]
	[FieldOffset(Offset = "0x860")]
	protected GameObject JKKJGLIGPON;

	[Token(Token = "0x4005791")]
	[FieldOffset(Offset = "0x864")]
	private MADMMIICBNN OCPLOAGPGNK;

	[Token(Token = "0x4005792")]
	[FieldOffset(Offset = "0x868")]
	protected LevelMovePlatform MLKBNNJMCAF;

	[Token(Token = "0x4005793")]
	[FieldOffset(Offset = "0x86C")]
	protected Vector3 PPIGOHLCMKI;

	[Token(Token = "0x4005794")]
	[FieldOffset(Offset = "0x878")]
	protected Vector3 PLMCBCCFAHL;

	[Token(Token = "0x4005795")]
	[FieldOffset(Offset = "0x884")]
	protected KHDMPGBLNCM IBHJOIGFAEH;

	[Token(Token = "0x4005796")]
	[FieldOffset(Offset = "0x888")]
	private bool OHLEEFLGMDK;

	[Token(Token = "0x4005797")]
	[FieldOffset(Offset = "0x88C")]
	private float OIEABJBKFNH;

	[Token(Token = "0x4005798")]
	[FieldOffset(Offset = "0x890")]
	protected bool KDNKINMBDCI;

	[Token(Token = "0x4005799")]
	[FieldOffset(Offset = "0x891")]
	private byte JCJJHPLJIBA;

	[Token(Token = "0x400579A")]
	[FieldOffset(Offset = "0x894")]
	protected ALAHNGGPDIE FNAFKJFAEPA;

	[Token(Token = "0x400579B")]
	[FieldOffset(Offset = "0x898")]
	private uint CFOANMPFNPP;

	[Token(Token = "0x400579C")]
	[FieldOffset(Offset = "0x89C")]
	public float LastHitEffectTime;

	[Token(Token = "0x400579D")]
	[FieldOffset(Offset = "0x8A0")]
	public float LastHealHitEffectTiem;

	[Token(Token = "0x400579E")]
	[FieldOffset(Offset = "0x8A4")]
	protected int OHCDDMOIBDH;

	[Token(Token = "0x400579F")]
	[FieldOffset(Offset = "0x8A8")]
	private bool AHLDOCCIMLB;

	[Token(Token = "0x40057A0")]
	[FieldOffset(Offset = "0x8AC")]
	private List<uint> FEEMLCHLFJO;

	[Token(Token = "0x40057A1")]
	[FieldOffset(Offset = "0x8B0")]
	private byte _003CHCFMGMCOAMD_003Ek__BackingField;

	[Token(Token = "0x40057A2")]
	public const FBCAHNCLMDC SkateboardJumpPose = FBCAHNCLMDC.EPHYSXPOSE_LOWFALLING;

	[Token(Token = "0x40057A3")]
	public const FBCAHNCLMDC SkateboardSecondJumpPose = FBCAHNCLMDC.EPHYSXPOSE_SECONDFALLING;

	[Token(Token = "0x40057A4")]
	[FieldOffset(Offset = "0x8B4")]
	private GPGBALKIDJK JOKBBDGDCGH;

	[Token(Token = "0x40057A5")]
	[FieldOffset(Offset = "0x8B8")]
	private GPGBALKIDJK MDCCIFENIFF;

	[Token(Token = "0x40057A6")]
	[FieldOffset(Offset = "0x8BC")]
	private GPGBALKIDJK FGMECLFDOMN;

	[Token(Token = "0x40057A7")]
	[FieldOffset(Offset = "0x8C0")]
	private GPGBALKIDJK LOPINBEJDJI;

	[Token(Token = "0x40057A8")]
	[FieldOffset(Offset = "0x8C4")]
	private ResourceID FAFEJKKGLPF;

	[Token(Token = "0x40057A9")]
	[FieldOffset(Offset = "0x8C8")]
	private ResourceID KKLENDNJFKA;

	[Token(Token = "0x40057AA")]
	[FieldOffset(Offset = "0x8CC")]
	private GameObject CIAELMOEDKJ;

	[Token(Token = "0x40057AB")]
	[FieldOffset(Offset = "0x8D0")]
	private GameObject BFNJEMODDMA;

	[Token(Token = "0x40057AC")]
	[FieldOffset(Offset = "0x8D4")]
	private bool JFKFKBEHACK;

	[Token(Token = "0x40057AD")]
	[FieldOffset(Offset = "0x8D8")]
	private int MPNMENPICOK;

	[Token(Token = "0x40057AE")]
	[FieldOffset(Offset = "0x8DC")]
	protected float HEDHLKDDOAH;

	[Token(Token = "0x40057AF")]
	[FieldOffset(Offset = "0x8E0")]
	protected float IMNLLKCFMOE;

	[Token(Token = "0x40057B0")]
	[FieldOffset(Offset = "0x8E4")]
	protected GameObject LGDNHNHCLMI;

	[Token(Token = "0x40057B1")]
	[FieldOffset(Offset = "0x8E8")]
	protected LNPFNEMBDOB BPPLGKHPHAP;

	[Token(Token = "0x40057B2")]
	[FieldOffset(Offset = "0x8EC")]
	private float EEECGDMIEHM;

	[Token(Token = "0x40057B3")]
	[FieldOffset(Offset = "0x8F0")]
	private BCIGOPJHDPB _003CHECLGLBAEGC_003Ek__BackingField;

	[Token(Token = "0x40057B4")]
	[FieldOffset(Offset = "0x8")]
	private static readonly float LOPANOEFNIH;

	[Token(Token = "0x40057B5")]
	[FieldOffset(Offset = "0xC")]
	private static readonly float HEMFKLCOBPC;

	[Token(Token = "0x40057B6")]
	[FieldOffset(Offset = "0x8F4")]
	public float SkySurfingTotalDurationForLog;

	[Token(Token = "0x40057B7")]
	[FieldOffset(Offset = "0x8F8")]
	public float SkyDivingTotalDurationForLog;

	[Token(Token = "0x40057B8")]
	[FieldOffset(Offset = "0x8FC")]
	public uint SkySlidingPressBtnCountForLog;

	[Token(Token = "0x40057B9")]
	[FieldOffset(Offset = "0x900")]
	public int SkyDivingSwitchPosTimes;

	[Token(Token = "0x40057BA")]
	[FieldOffset(Offset = "0x904")]
	private float OHBFIAAOMJM;

	[Token(Token = "0x40057BB")]
	[FieldOffset(Offset = "0x908")]
	private float GBAFAOKFEBO;

	[Token(Token = "0x40057BC")]
	[FieldOffset(Offset = "0x90C")]
	public bool IsDieingOnParachute;

	[Token(Token = "0x40057BD")]
	[FieldOffset(Offset = "0x910")]
	protected Dictionary<int, GHGCGGOLKIP> HDOADBCLAKH;

	[Token(Token = "0x40057BE")]
	[FieldOffset(Offset = "0x914")]
	private bool MLPIFDOGEFA;

	[Token(Token = "0x40057BF")]
	[FieldOffset(Offset = "0x918")]
	private float APIPJEMABHG;

	[Token(Token = "0x40057C0")]
	[FieldOffset(Offset = "0x920")]
	private IHAAMHPPLMG HCOFNOCGHCH;

	[Token(Token = "0x40057C1")]
	[FieldOffset(Offset = "0x938")]
	private byte LIMGFHMEGLD;

	[Token(Token = "0x40057C2")]
	[FieldOffset(Offset = "0x93C")]
	private IKBGGPAEFDO BMMIMFAGFFG;

	[Token(Token = "0x40057C3")]
	[FieldOffset(Offset = "0x940")]
	private Vector3 NCJJNJINDEG;

	[Token(Token = "0x40057C4")]
	[FieldOffset(Offset = "0x94C")]
	private bool NDODIPNEHOI;

	[Token(Token = "0x40057C5")]
	[FieldOffset(Offset = "0x950")]
	public GGHHAHINCOB m_TeamParachuteCallBack;

	[Token(Token = "0x40057C6")]
	[FieldOffset(Offset = "0x954")]
	public MHBKOOONOGC m_OnPlayerPhysxStateSwtich;

	[Token(Token = "0x40057C7")]
	[FieldOffset(Offset = "0x958")]
	public AFICEILBKKH m_OnLeaderWantChangeTransfom;

	[Token(Token = "0x40057C8")]
	[FieldOffset(Offset = "0x95C")]
	private bool MCCBJIPJBCJ;

	[Token(Token = "0x40057C9")]
	[FieldOffset(Offset = "0x95D")]
	private bool OBFOMJPJMFD;

	[Token(Token = "0x40057CA")]
	[FieldOffset(Offset = "0x95E")]
	private bool HOLEEOILHJD;

	[Token(Token = "0x40057CB")]
	[FieldOffset(Offset = "0x960")]
	private ResourceID IFALCKJJBAO;

	[Token(Token = "0x40057CC")]
	[FieldOffset(Offset = "0x964")]
	protected JAEAODJEENM JGIOLIADMMM;

	[Token(Token = "0x40057CD")]
	[FieldOffset(Offset = "0x968")]
	protected Collider OJGBKKCKKHC;

	[Token(Token = "0x40057CE")]
	[FieldOffset(Offset = "0x96C")]
	private float EECCGJAJJFN;

	[Token(Token = "0x40057CF")]
	[FieldOffset(Offset = "0x970")]
	private float LDGIAGGPCHE;

	[Token(Token = "0x40057D0")]
	[FieldOffset(Offset = "0x974")]
	private int GGGFPPEFLJK;

	[Token(Token = "0x40057D1")]
	[FieldOffset(Offset = "0x978")]
	private MADMMIICBNN OAJEDLLNHBP;

	[Token(Token = "0x40057D2")]
	[FieldOffset(Offset = "0x97C")]
	private HCKOJDGLJCI AGAIPPNCMDE;

	[Token(Token = "0x40057D3")]
	[FieldOffset(Offset = "0x980")]
	private GameObject EOAPFCPNAOG;

	[Token(Token = "0x40057D4")]
	[FieldOffset(Offset = "0x984")]
	private bool GBHGDOIHFCK;

	[Token(Token = "0x40057D5")]
	[FieldOffset(Offset = "0x988")]
	protected Dictionary<byte, uint> ILPNHBIIODC;

	[Token(Token = "0x40057D6")]
	[FieldOffset(Offset = "0x98C")]
	protected List<EBDLMAHABAD> CMAFGEBBBKF;

	[Token(Token = "0x40057D7")]
	private const int NCABFOIPELJ = 20;

	[Token(Token = "0x40057D8")]
	[FieldOffset(Offset = "0x990")]
	protected uint KDBPLNFMOAF;

	[Token(Token = "0x40057D9")]
	[FieldOffset(Offset = "0x994")]
	protected uint FNDBGHADEAN;

	[Token(Token = "0x40057DA")]
	[FieldOffset(Offset = "0x10")]
	private static Comparison<uint> HMDOHFBHDOB;

	[Token(Token = "0x40057DB")]
	[FieldOffset(Offset = "0x14")]
	private static Comparison<EBDLMAHABAD> AOCDJNOINOH;

	[Token(Token = "0x17000465")]
	public bool GDABKBKEEPK
	{
		[Token(Token = "0x6004164")]
		[Address(RVA = "0xBD2514", Offset = "0xBD2514", VA = "0xBD2514")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004165")]
		[Address(RVA = "0xBD256C", Offset = "0xBD256C", VA = "0xBD256C")]
		set
		{
		}
	}

	[Token(Token = "0x17000466")]
	public bool AEHHCLKFOIF
	{
		[Token(Token = "0x6004167")]
		[Address(RVA = "0xBD2874", Offset = "0xBD2874", VA = "0xBD2874")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004166")]
		[Address(RVA = "0xBD25CC", Offset = "0xBD25CC", VA = "0xBD25CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000467")]
	public ulong MIJOCMKONAD
	{
		[Token(Token = "0x600417C")]
		[Address(RVA = "0xBD5F9C", Offset = "0xBD5F9C", VA = "0xBD5F9C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600417D")]
		[Address(RVA = "0xBD5FF4", Offset = "0xBD5FF4", VA = "0xBD5FF4")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000468")]
	public IHAAMHPPLMG IHAAMHPPLMG
	{
		[Token(Token = "0x600417F")]
		[Address(RVA = "0xBD2800", Offset = "0xBD2800", VA = "0xBD2800", Slot = "68")]
		get
		{
			return default(IHAAMHPPLMG);
		}
		[Token(Token = "0x6004180")]
		[Address(RVA = "0xBD61A4", Offset = "0xBD61A4", VA = "0xBD61A4")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000469")]
	public ulong DBBDCBDBDIG
	{
		[Token(Token = "0x6004181")]
		[Address(RVA = "0xBD6250", Offset = "0xBD6250", VA = "0xBD6250")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6004182")]
		[Address(RVA = "0xBD62A8", Offset = "0xBD62A8", VA = "0xBD62A8")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700046A")]
	public ulong CDPMKEGBFNC
	{
		[Token(Token = "0x6004183")]
		[Address(RVA = "0xBD6324", Offset = "0xBD6324", VA = "0xBD6324")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700046B")]
	public int CPDNBJNLAIM
	{
		[Token(Token = "0x6004184")]
		[Address(RVA = "0xBD6384", Offset = "0xBD6384", VA = "0xBD6384")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004185")]
		[Address(RVA = "0xBD638C", Offset = "0xBD638C", VA = "0xBD638C")]
		set
		{
		}
	}

	[Token(Token = "0x1700046C")]
	public IHAAMHPPLMG INJHIIEDLOE
	{
		[Token(Token = "0x6004187")]
		[Address(RVA = "0xBD63C8", Offset = "0xBD63C8", VA = "0xBD63C8")]
		get
		{
			return default(IHAAMHPPLMG);
		}
		[Token(Token = "0x6004186")]
		[Address(RVA = "0xBD6394", Offset = "0xBD6394", VA = "0xBD6394")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700046D")]
	public uint MGFPABPGMCA
	{
		[Token(Token = "0x6004188")]
		[Address(RVA = "0xBD63E0", Offset = "0xBD63E0", VA = "0xBD63E0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6004189")]
		[Address(RVA = "0xBD63E8", Offset = "0xBD63E8", VA = "0xBD63E8")]
		set
		{
		}
	}

	[Token(Token = "0x1700046E")]
	public string MFLBOPEBOKE
	{
		[Token(Token = "0x600418A")]
		[Address(RVA = "0xBD63F0", Offset = "0xBD63F0", VA = "0xBD63F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600418B")]
		[Address(RVA = "0xBD63F8", Offset = "0xBD63F8", VA = "0xBD63F8")]
		set
		{
		}
	}

	[Token(Token = "0x1700046F")]
	public string AIBGAEMOLAN
	{
		[Token(Token = "0x600418C")]
		[Address(RVA = "0xBD6400", Offset = "0xBD6400", VA = "0xBD6400")]
		get
		{
			return null;
		}
		[Token(Token = "0x600418D")]
		[Address(RVA = "0xBD6408", Offset = "0xBD6408", VA = "0xBD6408")]
		set
		{
		}
	}

	[Token(Token = "0x17000470")]
	public uint LGFOLJMCMFH
	{
		[Token(Token = "0x600418E")]
		[Address(RVA = "0xBD6410", Offset = "0xBD6410", VA = "0xBD6410")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600418F")]
		[Address(RVA = "0xBD6418", Offset = "0xBD6418", VA = "0xBD6418")]
		set
		{
		}
	}

	[Token(Token = "0x17000471")]
	public uint HACHAICBNDJ
	{
		[Token(Token = "0x6004190")]
		[Address(RVA = "0xBD6420", Offset = "0xBD6420", VA = "0xBD6420")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6004191")]
		[Address(RVA = "0xBD6428", Offset = "0xBD6428", VA = "0xBD6428")]
		set
		{
		}
	}

	[Token(Token = "0x17000472")]
	public object AKMGPJFCGKD
	{
		[Token(Token = "0x6004192")]
		[Address(RVA = "0xBD6430", Offset = "0xBD6430", VA = "0xBD6430")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004193")]
		[Address(RVA = "0xBD6488", Offset = "0xBD6488", VA = "0xBD6488")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000473")]
	public string GCJBNAHBGMD
	{
		[Token(Token = "0x6004194")]
		[Address(RVA = "0xBD64E8", Offset = "0xBD64E8", VA = "0xBD64E8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004195")]
		[Address(RVA = "0xBD6540", Offset = "0xBD6540", VA = "0xBD6540")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000474")]
	public bool JHKDNBCFKMN
	{
		[Token(Token = "0x6004196")]
		[Address(RVA = "0xBD60EC", Offset = "0xBD60EC", VA = "0xBD60EC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004197")]
		[Address(RVA = "0xBD65A0", Offset = "0xBD65A0", VA = "0xBD65A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000475")]
	public ulong PAJPAJAJKAF
	{
		[Token(Token = "0x6004198")]
		[Address(RVA = "0xBD6144", Offset = "0xBD6144", VA = "0xBD6144")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6004199")]
		[Address(RVA = "0xBD6600", Offset = "0xBD6600", VA = "0xBD6600")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000476")]
	public List<AvatarSkillData> IHJCPLDPBPO
	{
		[Token(Token = "0x600419A")]
		[Address(RVA = "0xBD6680", Offset = "0xBD6680", VA = "0xBD6680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000477")]
	public bool NJOEDDBEOFF
	{
		[Token(Token = "0x600419C")]
		[Address(RVA = "0xBD67F8", Offset = "0xBD67F8", VA = "0xBD67F8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600419D")]
		[Address(RVA = "0xBD6800", Offset = "0xBD6800", VA = "0xBD6800")]
		set
		{
		}
	}

	[Token(Token = "0x17000478")]
	public bool OCLKKGCBCFO
	{
		[Token(Token = "0x600419E")]
		[Address(RVA = "0xBD6808", Offset = "0xBD6808", VA = "0xBD6808")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000479")]
	public bool CGLPGGGGLEE
	{
		[Token(Token = "0x600419F")]
		[Address(RVA = "0xBD6A14", Offset = "0xBD6A14", VA = "0xBD6A14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700047A")]
	public bool LFHHIGKHEBJ
	{
		[Token(Token = "0x60041A0")]
		[Address(RVA = "0xBD6B20", Offset = "0xBD6B20", VA = "0xBD6B20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700047B")]
	public bool HBKOOOGIPBC
	{
		[Token(Token = "0x60041A1")]
		[Address(RVA = "0xBD6C2C", Offset = "0xBD6C2C", VA = "0xBD6C2C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041A2")]
		[Address(RVA = "0xBD6C84", Offset = "0xBD6C84", VA = "0xBD6C84")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700047C")]
	public CharacterController IJCLBOKGMCH
	{
		[Token(Token = "0x60041A3")]
		[Address(RVA = "0xBD6CE4", Offset = "0xBD6CE4", VA = "0xBD6CE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700047D")]
	public bool AMHNMEBKJKJ
	{
		[Token(Token = "0x60041A5")]
		[Address(RVA = "0xBD6D9C", Offset = "0xBD6D9C", VA = "0xBD6D9C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041A4")]
		[Address(RVA = "0xBD6D3C", Offset = "0xBD6D3C", VA = "0xBD6D3C")]
		set
		{
		}
	}

	[Token(Token = "0x1700047E")]
	public bool EFEDDDPHDMG
	{
		[Token(Token = "0x60041A7")]
		[Address(RVA = "0xBD6E54", Offset = "0xBD6E54", VA = "0xBD6E54")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041A6")]
		[Address(RVA = "0xBD6DF4", Offset = "0xBD6DF4", VA = "0xBD6DF4")]
		set
		{
		}
	}

	[Token(Token = "0x1700047F")]
	public uint AHILKHDAHGK
	{
		[Token(Token = "0x60041A9")]
		[Address(RVA = "0xBD6F0C", Offset = "0xBD6F0C", VA = "0xBD6F0C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60041A8")]
		[Address(RVA = "0xBD6EAC", Offset = "0xBD6EAC", VA = "0xBD6EAC")]
		set
		{
		}
	}

	[Token(Token = "0x17000480")]
	public bool JHCHNAGGJLO
	{
		[Token(Token = "0x60041AB")]
		[Address(RVA = "0xBD6FC4", Offset = "0xBD6FC4", VA = "0xBD6FC4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041AA")]
		[Address(RVA = "0xBD6F64", Offset = "0xBD6F64", VA = "0xBD6F64")]
		set
		{
		}
	}

	[Token(Token = "0x17000481")]
	public bool NBAPKPFJGEF
	{
		[Token(Token = "0x60041AD")]
		[Address(RVA = "0xBD707C", Offset = "0xBD707C", VA = "0xBD707C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041AC")]
		[Address(RVA = "0xBD701C", Offset = "0xBD701C", VA = "0xBD701C")]
		set
		{
		}
	}

	[Token(Token = "0x17000482")]
	public bool IJLNDEBJIAP
	{
		[Token(Token = "0x60041AF")]
		[Address(RVA = "0xBD7138", Offset = "0xBD7138", VA = "0xBD7138")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000483")]
	public bool ECGLMHGGJIA
	{
		[Token(Token = "0x60041B0")]
		[Address(RVA = "0xBD7190", Offset = "0xBD7190", VA = "0xBD7190")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041B1")]
		[Address(RVA = "0xBD7198", Offset = "0xBD7198", VA = "0xBD7198")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000484")]
	public bool FLEOHKNBGFK
	{
		[Token(Token = "0x60041B2")]
		[Address(RVA = "0xBD71A0", Offset = "0xBD71A0", VA = "0xBD71A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041B3")]
		[Address(RVA = "0xBD71A8", Offset = "0xBD71A8", VA = "0xBD71A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000485")]
	public bool HAFCKIHMJPA
	{
		[Token(Token = "0x60041B4")]
		[Address(RVA = "0xBD71B0", Offset = "0xBD71B0", VA = "0xBD71B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041B5")]
		[Address(RVA = "0xBD71B8", Offset = "0xBD71B8", VA = "0xBD71B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000486")]
	public bool JABEIFNBKAJ
	{
		[Token(Token = "0x60041B6")]
		[Address(RVA = "0xBD71C0", Offset = "0xBD71C0", VA = "0xBD71C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041B7")]
		[Address(RVA = "0xBD71C8", Offset = "0xBD71C8", VA = "0xBD71C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000487")]
	public bool GHHECPHJALL
	{
		[Token(Token = "0x60041B8")]
		[Address(RVA = "0xBD71D0", Offset = "0xBD71D0", VA = "0xBD71D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041B9")]
		[Address(RVA = "0xBD71D8", Offset = "0xBD71D8", VA = "0xBD71D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000488")]
	public bool HLLNDKGMJGE
	{
		[Token(Token = "0x60041BA")]
		[Address(RVA = "0xBD71E0", Offset = "0xBD71E0", VA = "0xBD71E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000489")]
	public bool BBOOLBGAJCN
	{
		[Token(Token = "0x60041BB")]
		[Address(RVA = "0xBD73DC", Offset = "0xBD73DC", VA = "0xBD73DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700048A")]
	public bool NLDFHMAACHI
	{
		[Token(Token = "0x60041BC")]
		[Address(RVA = "0xBD7504", Offset = "0xBD7504", VA = "0xBD7504")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041BD")]
		[Address(RVA = "0xBD750C", Offset = "0xBD750C", VA = "0xBD750C")]
		set
		{
		}
	}

	[Token(Token = "0x1700048B")]
	public uint MDDDNKCOMDF
	{
		[Token(Token = "0x60041BE")]
		[Address(RVA = "0xBD7514", Offset = "0xBD7514", VA = "0xBD7514")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60041BF")]
		[Address(RVA = "0xBD751C", Offset = "0xBD751C", VA = "0xBD751C")]
		set
		{
		}
	}

	[Token(Token = "0x1700048C")]
	public List<LevelRescureZone> LGJBAJPMDGP
	{
		[Token(Token = "0x60041C0")]
		[Address(RVA = "0xBD7524", Offset = "0xBD7524", VA = "0xBD7524")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700048D")]
	public bool HKPKGKHDDLN
	{
		[Token(Token = "0x60041C1")]
		[Address(RVA = "0xBD757C", Offset = "0xBD757C", VA = "0xBD757C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041C2")]
		[Address(RVA = "0xBD75D4", Offset = "0xBD75D4", VA = "0xBD75D4")]
		set
		{
		}
	}

	[Token(Token = "0x1700048E")]
	public AvatarEffect OCPIOLEODLO
	{
		[Token(Token = "0x60041C3")]
		[Address(RVA = "0xBD7634", Offset = "0xBD7634", VA = "0xBD7634")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700048F")]
	public uint PAHEGIIKLIH
	{
		[Token(Token = "0x60041C4")]
		[Address(RVA = "0xBD768C", Offset = "0xBD768C", VA = "0xBD768C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000490")]
	public uint CJCLANDKOJL
	{
		[Token(Token = "0x60041C5")]
		[Address(RVA = "0xBD76E4", Offset = "0xBD76E4", VA = "0xBD76E4")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000491")]
	protected Quaternion PNDINIPFHJL
	{
		[Token(Token = "0x60041CB")]
		[Address(RVA = "0xBD7990", Offset = "0xBD7990", VA = "0xBD7990")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}
		[Token(Token = "0x60041CC")]
		[Address(RVA = "0xBD79A0", Offset = "0xBD79A0", VA = "0xBD79A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000492")]
	protected Quaternion FAJPNPDBODN
	{
		[Token(Token = "0x60041CD")]
		[Address(RVA = "0xBD79B0", Offset = "0xBD79B0", VA = "0xBD79B0")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}
		[Token(Token = "0x60041CE")]
		[Address(RVA = "0xBD79C0", Offset = "0xBD79C0", VA = "0xBD79C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000493")]
	public bool JFCNHDKPKLJ
	{
		[Token(Token = "0x60041CF")]
		[Address(RVA = "0xBD79D0", Offset = "0xBD79D0", VA = "0xBD79D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041D0")]
		[Address(RVA = "0xBD79D8", Offset = "0xBD79D8", VA = "0xBD79D8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000494")]
	public bool PGMFLGILALM
	{
		[Token(Token = "0x60041D2")]
		[Address(RVA = "0xBD7EB0", Offset = "0xBD7EB0", VA = "0xBD7EB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041D1")]
		[Address(RVA = "0xBD79E0", Offset = "0xBD79E0", VA = "0xBD79E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000495")]
	public bool NKKHPIOIOCP
	{
		[Token(Token = "0x60041D3")]
		[Address(RVA = "0xBD7F08", Offset = "0xBD7F08", VA = "0xBD7F08")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041D4")]
		[Address(RVA = "0xBD7F60", Offset = "0xBD7F60", VA = "0xBD7F60")]
		set
		{
		}
	}

	[Token(Token = "0x17000496")]
	public bool HFEDEEMNIPJ
	{
		[Token(Token = "0x60041D5")]
		[Address(RVA = "0xBD7FC0", Offset = "0xBD7FC0", VA = "0xBD7FC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041D6")]
		[Address(RVA = "0xBD7FC8", Offset = "0xBD7FC8", VA = "0xBD7FC8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000497")]
	public EAimAssist KINGHFICKOE
	{
		[Token(Token = "0x60041D7")]
		[Address(RVA = "0xBD7FD0", Offset = "0xBD7FD0", VA = "0xBD7FD0")]
		get
		{
			return default(EAimAssist);
		}
	}

	[Token(Token = "0x17000498")]
	public bool JGJHDKKPNPA
	{
		[Token(Token = "0x60041DA")]
		[Address(RVA = "0xBD82A8", Offset = "0xBD82A8", VA = "0xBD82A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000499")]
	public bool AMDICHFGBFK
	{
		[Token(Token = "0x60041DC")]
		[Address(RVA = "0xBD8378", Offset = "0xBD8378", VA = "0xBD8378")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700049A")]
	public bool FCOMBCAICLO
	{
		[Token(Token = "0x60041DD")]
		[Address(RVA = "0xBD83E8", Offset = "0xBD83E8", VA = "0xBD83E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700049B")]
	public FollowCamera IJMODEIJCOD
	{
		[Token(Token = "0x60041DE")]
		[Address(RVA = "0xBD8458", Offset = "0xBD8458", VA = "0xBD8458")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700049C")]
	public virtual Collider NDIJPOAKKGG
	{
		[Token(Token = "0x60041E0")]
		[Address(RVA = "0xBD86C0", Offset = "0xBD86C0", VA = "0xBD86C0", Slot = "95")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700049D")]
	public NewPlayerAnimationSystemComponent ILFAKEOIACP
	{
		[Token(Token = "0x60041E1")]
		[Address(RVA = "0xBD8930", Offset = "0xBD8930", VA = "0xBD8930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700049E")]
	public AvatarManager LOHKIAIEKBM
	{
		[Token(Token = "0x60041E2")]
		[Address(RVA = "0xBD8988", Offset = "0xBD8988", VA = "0xBD8988")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700049F")]
	public PlayerAttributes KNHAHIOBOGM
	{
		[Token(Token = "0x60041E4")]
		[Address(RVA = "0xBD8A38", Offset = "0xBD8A38", VA = "0xBD8A38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A0")]
	public bool FCDEPAABNFL
	{
		[Token(Token = "0x60041E5")]
		[Address(RVA = "0xBD8D38", Offset = "0xBD8D38", VA = "0xBD8D38")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041E6")]
		[Address(RVA = "0xBD8D40", Offset = "0xBD8D40", VA = "0xBD8D40")]
		set
		{
		}
	}

	[Token(Token = "0x170004A1")]
	public bool IAPCAGNFMPO
	{
		[Token(Token = "0x60041E7")]
		[Address(RVA = "0xBD8D48", Offset = "0xBD8D48", VA = "0xBD8D48")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041E8")]
		[Address(RVA = "0xBD8D50", Offset = "0xBD8D50", VA = "0xBD8D50")]
		set
		{
		}
	}

	[Token(Token = "0x170004A2")]
	public Transform PHFLOHBNECC
	{
		[Token(Token = "0x60041E9")]
		[Address(RVA = "0xBD8D58", Offset = "0xBD8D58", VA = "0xBD8D58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A3")]
	public Transform ILGHEFOMOFC
	{
		[Token(Token = "0x60041EA")]
		[Address(RVA = "0xBD8E78", Offset = "0xBD8E78", VA = "0xBD8E78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A4")]
	public Transform PBHBNMIFEKJ
	{
		[Token(Token = "0x60041EB")]
		[Address(RVA = "0xBD8F98", Offset = "0xBD8F98", VA = "0xBD8F98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A5")]
	public Transform MHLFJLJMPMF
	{
		[Token(Token = "0x60041EC")]
		[Address(RVA = "0xBD944C", Offset = "0xBD944C", VA = "0xBD944C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A6")]
	public Transform FJGMHKIGNNH
	{
		[Token(Token = "0x60041ED")]
		[Address(RVA = "0xBD9324", Offset = "0xBD9324", VA = "0xBD9324")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A7")]
	public Transform BPFMFOEBAEM
	{
		[Token(Token = "0x60041EE")]
		[Address(RVA = "0xBD956C", Offset = "0xBD956C", VA = "0xBD956C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A8")]
	public Transform BOCCFAPCJCI
	{
		[Token(Token = "0x60041EF")]
		[Address(RVA = "0xBD968C", Offset = "0xBD968C", VA = "0xBD968C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A9")]
	public NavMeshAgent EHLFKJGHJBJ
	{
		[Token(Token = "0x60041F0")]
		[Address(RVA = "0xBD97AC", Offset = "0xBD97AC", VA = "0xBD97AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004AA")]
	public NetworkPet DHKMHJMDLAA
	{
		[Token(Token = "0x60041F1")]
		[Address(RVA = "0xBD9804", Offset = "0xBD9804", VA = "0xBD9804")]
		get
		{
			return null;
		}
		[Token(Token = "0x60041F2")]
		[Address(RVA = "0xBD980C", Offset = "0xBD980C", VA = "0xBD980C")]
		set
		{
		}
	}

	[Token(Token = "0x170004AB")]
	public bool GMNLFKLOFCC
	{
		[Token(Token = "0x60041F4")]
		[Address(RVA = "0xBD9BA4", Offset = "0xBD9BA4", VA = "0xBD9BA4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041F3")]
		[Address(RVA = "0xBD9814", Offset = "0xBD9814", VA = "0xBD9814")]
		set
		{
		}
	}

	[Token(Token = "0x170004AC")]
	public float LKGPEGADHNL
	{
		[Token(Token = "0x60041F6")]
		[Address(RVA = "0xBD9C60", Offset = "0xBD9C60", VA = "0xBD9C60")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60041F5")]
		[Address(RVA = "0xBD9BFC", Offset = "0xBD9BFC", VA = "0xBD9BFC")]
		set
		{
		}
	}

	[Token(Token = "0x170004AD")]
	public Vector3 BPCCLCIMGOA
	{
		[Token(Token = "0x60041F8")]
		[Address(RVA = "0xBD9D40", Offset = "0xBD9D40", VA = "0xBD9D40")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x60041F7")]
		[Address(RVA = "0xBD9CB8", Offset = "0xBD9CB8", VA = "0xBD9CB8")]
		set
		{
		}
	}

	[Token(Token = "0x170004AE")]
	public virtual bool AFDMGPFCBIO
	{
		[Token(Token = "0x60041F9")]
		[Address(RVA = "0xBD9DB0", Offset = "0xBD9DB0", VA = "0xBD9DB0", Slot = "96")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004AF")]
	public bool ALIGKMFIOBB
	{
		[Token(Token = "0x60041FA")]
		[Address(RVA = "0xBD9E34", Offset = "0xBD9E34", VA = "0xBD9E34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004B0")]
	public bool LGMPLILDPAJ
	{
		[Token(Token = "0x60041FB")]
		[Address(RVA = "0xBD9EB4", Offset = "0xBD9EB4", VA = "0xBD9EB4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004B1")]
	public bool DMABBAJADHK
	{
		[Token(Token = "0x60041FC")]
		[Address(RVA = "0xBD9FC4", Offset = "0xBD9FC4", VA = "0xBD9FC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004B2")]
	public bool AFENBOJOONG
	{
		[Token(Token = "0x60041FE")]
		[Address(RVA = "0xBD73D4", Offset = "0xBD73D4", VA = "0xBD73D4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041FF")]
		[Address(RVA = "0xBDA24C", Offset = "0xBDA24C", VA = "0xBDA24C")]
		set
		{
		}
	}

	[Token(Token = "0x170004B3")]
	public EntityInfo ACNHNCPFCFB
	{
		[Token(Token = "0x6004200")]
		[Address(RVA = "0xBD0020", Offset = "0xBD0020", VA = "0xBD0020")]
		get
		{
			return default(EntityInfo);
		}
	}

	[Token(Token = "0x170004B4")]
	public bool MDFFLKJAKHP
	{
		[Token(Token = "0x6004201")]
		[Address(RVA = "0xBDA254", Offset = "0xBDA254", VA = "0xBDA254")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004B5")]
	public bool OPMGNCPJPFL
	{
		[Token(Token = "0x6004202")]
		[Address(RVA = "0xBDA3CC", Offset = "0xBDA3CC", VA = "0xBDA3CC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004B6")]
	public bool ABCDIOFOCFE
	{
		[Token(Token = "0x6004203")]
		[Address(RVA = "0xBDA49C", Offset = "0xBDA49C", VA = "0xBDA49C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004B7")]
	public bool KILKIKOHANG
	{
		[Token(Token = "0x6004204")]
		[Address(RVA = "0xBDA56C", Offset = "0xBDA56C", VA = "0xBDA56C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004B8")]
	public bool NFOHALLLPIC
	{
		[Token(Token = "0x6004205")]
		[Address(RVA = "0xBDA63C", Offset = "0xBDA63C", VA = "0xBDA63C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004B9")]
	public bool PJKIDKGJGNA
	{
		[Token(Token = "0x6004206")]
		[Address(RVA = "0xBDA7D4", Offset = "0xBDA7D4", VA = "0xBDA7D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004BA")]
	public bool DHCCDAPIPAO
	{
		[Token(Token = "0x6004207")]
		[Address(RVA = "0xBDA844", Offset = "0xBDA844", VA = "0xBDA844")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004BB")]
	public bool LEANLMHPJKC
	{
		[Token(Token = "0x6004208")]
		[Address(RVA = "0xBDA8AC", Offset = "0xBDA8AC", VA = "0xBDA8AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004BC")]
	public bool FLCGKIKFHNP
	{
		[Token(Token = "0x6004209")]
		[Address(RVA = "0xBDA91C", Offset = "0xBDA91C", VA = "0xBDA91C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004BD")]
	public bool JNFIDMMDFMM
	{
		[Token(Token = "0x600420A")]
		[Address(RVA = "0xBDA98C", Offset = "0xBDA98C", VA = "0xBDA98C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004BE")]
	public bool EJIMJBIBMED
	{
		[Token(Token = "0x600420B")]
		[Address(RVA = "0xBDA9FC", Offset = "0xBDA9FC", VA = "0xBDA9FC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004BF")]
	public bool JOKIHGBEEHI
	{
		[Token(Token = "0x600420C")]
		[Address(RVA = "0xBDAA6C", Offset = "0xBDAA6C", VA = "0xBDAA6C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004C0")]
	public bool JPEIKDHIKIA
	{
		[Token(Token = "0x600420D")]
		[Address(RVA = "0xBDAADC", Offset = "0xBDAADC", VA = "0xBDAADC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004C1")]
	public bool DFCEANPIEIJ
	{
		[Token(Token = "0x600420E")]
		[Address(RVA = "0xBDAB4C", Offset = "0xBDAB4C", VA = "0xBDAB4C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004C2")]
	public LevelGrapplingHook JFLNOPHEHEF
	{
		[Token(Token = "0x6004210")]
		[Address(RVA = "0xBDAC1C", Offset = "0xBDAC1C", VA = "0xBDAC1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600420F")]
		[Address(RVA = "0xBDABBC", Offset = "0xBDABBC", VA = "0xBDABBC")]
		set
		{
		}
	}

	[Token(Token = "0x170004C3")]
	public bool EEJHIPELLEE
	{
		[Token(Token = "0x6004211")]
		[Address(RVA = "0xBDAC74", Offset = "0xBDAC74", VA = "0xBDAC74")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004C4")]
	public bool LPIJDKICPHJ
	{
		[Token(Token = "0x6004212")]
		[Address(RVA = "0xBDACF8", Offset = "0xBDACF8", VA = "0xBDACF8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004213")]
		[Address(RVA = "0xBDAD00", Offset = "0xBDAD00", VA = "0xBDAD00")]
		protected set
		{
		}
	}

	[Token(Token = "0x170004C5")]
	public bool IFACMDMJCHG
	{
		[Token(Token = "0x6004215")]
		[Address(RVA = "0xBDAD68", Offset = "0xBDAD68", VA = "0xBDAD68")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004216")]
		[Address(RVA = "0xBDAD70", Offset = "0xBDAD70", VA = "0xBDAD70")]
		set
		{
		}
	}

	[Token(Token = "0x170004C6")]
	public bool FECFKLIPDDG
	{
		[Token(Token = "0x6004217")]
		[Address(RVA = "0xBDAD78", Offset = "0xBDAD78", VA = "0xBDAD78")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004218")]
		[Address(RVA = "0xBDAD80", Offset = "0xBDAD80", VA = "0xBDAD80")]
		set
		{
		}
	}

	[Token(Token = "0x170004C7")]
	public bool IIJLJAEALEG
	{
		[Token(Token = "0x6004219")]
		[Address(RVA = "0xBDAD88", Offset = "0xBDAD88", VA = "0xBDAD88")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600421A")]
		[Address(RVA = "0xBDAD90", Offset = "0xBDAD90", VA = "0xBDAD90")]
		set
		{
		}
	}

	[Token(Token = "0x170004C8")]
	public bool KOMALEEFGJG
	{
		[Token(Token = "0x600421B")]
		[Address(RVA = "0xBDAD98", Offset = "0xBDAD98", VA = "0xBDAD98")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600421C")]
		[Address(RVA = "0xBD23D0", Offset = "0xBD23D0", VA = "0xBD23D0")]
		set
		{
		}
	}

	[Token(Token = "0x170004C9")]
	public bool HFJKBGABJKL
	{
		[Token(Token = "0x600421D")]
		[Address(RVA = "0xBDADA0", Offset = "0xBDADA0", VA = "0xBDADA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600421E")]
		[Address(RVA = "0xBDADA8", Offset = "0xBDADA8", VA = "0xBDADA8")]
		private set
		{
		}
	}

	[Token(Token = "0x170004CA")]
	public bool LDJKNCAALJE
	{
		[Token(Token = "0x600421F")]
		[Address(RVA = "0xBDADB0", Offset = "0xBDADB0", VA = "0xBDADB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004220")]
		[Address(RVA = "0xBDADB8", Offset = "0xBDADB8", VA = "0xBDADB8")]
		set
		{
		}
	}

	[Token(Token = "0x170004CB")]
	public bool KOPGHJJGEID
	{
		[Token(Token = "0x6004221")]
		[Address(RVA = "0xBDADC0", Offset = "0xBDADC0", VA = "0xBDADC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004CC")]
	public bool NNKENPMDLOL
	{
		[Token(Token = "0x6004222")]
		[Address(RVA = "0xBDAE38", Offset = "0xBDAE38", VA = "0xBDAE38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004CD")]
	public bool CAGDDOFJJFG
	{
		[Token(Token = "0x6004223")]
		[Address(RVA = "0xBDAEB0", Offset = "0xBDAEB0", VA = "0xBDAEB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004224")]
		[Address(RVA = "0xBDAEB8", Offset = "0xBDAEB8", VA = "0xBDAEB8")]
		set
		{
		}
	}

	[Token(Token = "0x170004CE")]
	public bool IBJHOHCFBNG
	{
		[Token(Token = "0x6004225")]
		[Address(RVA = "0xBDAEC0", Offset = "0xBDAEC0", VA = "0xBDAEC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004CF")]
	public bool NLFCPFENIHC
	{
		[Token(Token = "0x6004226")]
		[Address(RVA = "0xBDB04C", Offset = "0xBDB04C", VA = "0xBDB04C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004D0")]
	public bool ADFOBAFBAAG
	{
		[Token(Token = "0x6004227")]
		[Address(RVA = "0xBDB1D8", Offset = "0xBDB1D8", VA = "0xBDB1D8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004228")]
		[Address(RVA = "0xBDB1E0", Offset = "0xBDB1E0", VA = "0xBDB1E0")]
		set
		{
		}
	}

	[Token(Token = "0x170004D1")]
	public bool IKIAHICCKKP
	{
		[Token(Token = "0x600422C")]
		[Address(RVA = "0xBDB62C", Offset = "0xBDB62C", VA = "0xBDB62C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600422D")]
		[Address(RVA = "0xBDB684", Offset = "0xBDB684", VA = "0xBDB684")]
		set
		{
		}
	}

	[Token(Token = "0x170004D2")]
	public bool CGOOCAELGID
	{
		[Token(Token = "0x600422E")]
		[Address(RVA = "0xBDB6E4", Offset = "0xBDB6E4", VA = "0xBDB6E4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600422F")]
		[Address(RVA = "0xBDB73C", Offset = "0xBDB73C", VA = "0xBDB73C")]
		set
		{
		}
	}

	[Token(Token = "0x170004D3")]
	public LevelChair OEOKKLPIJKE
	{
		[Token(Token = "0x6004231")]
		[Address(RVA = "0xBDB9AC", Offset = "0xBDB9AC", VA = "0xBDB9AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004D4")]
	public int BFPJBCPMOBI
	{
		[Token(Token = "0x6004238")]
		[Address(RVA = "0xBDBE1C", Offset = "0xBDBE1C", VA = "0xBDBE1C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170004D5")]
	public bool CMHIOJAIEPA
	{
		[Token(Token = "0x6004239")]
		[Address(RVA = "0xBDBF58", Offset = "0xBDBF58", VA = "0xBDBF58")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004D6")]
	public Transform HCJBHFBLHOB
	{
		[Token(Token = "0x600423A")]
		[Address(RVA = "0xBD39C4", Offset = "0xBD39C4", VA = "0xBD39C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004D7")]
	public Transform POKAGBKPOKL
	{
		[Token(Token = "0x600423B")]
		[Address(RVA = "0xBDBFE0", Offset = "0xBDBFE0", VA = "0xBDBFE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004D8")]
	public Transform OFEFMJNNKCF
	{
		[Token(Token = "0x600423C")]
		[Address(RVA = "0xBDC140", Offset = "0xBDC140", VA = "0xBDC140")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004D9")]
	public Transform JJGNDPJJGCJ
	{
		[Token(Token = "0x600423D")]
		[Address(RVA = "0xBDC2A0", Offset = "0xBDC2A0", VA = "0xBDC2A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004DA")]
	public Transform AMPHBHIEIKN
	{
		[Token(Token = "0x600423E")]
		[Address(RVA = "0xBDC400", Offset = "0xBDC400", VA = "0xBDC400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004DB")]
	protected Transform LHAGAILJBPM
	{
		[Token(Token = "0x600423F")]
		[Address(RVA = "0xBDC560", Offset = "0xBDC560", VA = "0xBDC560")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004DC")]
	public bool CEBMLIKMBCE
	{
		[Token(Token = "0x6004240")]
		[Address(RVA = "0xBDC6C0", Offset = "0xBDC6C0", VA = "0xBDC6C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004DD")]
	public bool KPNHKCBLLJI
	{
		[Token(Token = "0x6004241")]
		[Address(RVA = "0xBDC748", Offset = "0xBDC748", VA = "0xBDC748")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004DE")]
	public bool OABGNKEHOMI
	{
		[Token(Token = "0x6004242")]
		[Address(RVA = "0xBDC7D0", Offset = "0xBDC7D0", VA = "0xBDC7D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004DF")]
	public bool KAMCALBHFBI
	{
		[Token(Token = "0x6004243")]
		[Address(RVA = "0xBDC96C", Offset = "0xBDC96C", VA = "0xBDC96C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004E0")]
	public bool CJGENGNALFO
	{
		[Token(Token = "0x6004244")]
		[Address(RVA = "0xBDC9F4", Offset = "0xBDC9F4", VA = "0xBDC9F4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004E1")]
	public bool EFPKMNJJFHE
	{
		[Token(Token = "0x6004245")]
		[Address(RVA = "0xBDCA84", Offset = "0xBDCA84", VA = "0xBDCA84")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004E2")]
	public bool LEOANJFLKND
	{
		[Token(Token = "0x6004246")]
		[Address(RVA = "0xBDCAFC", Offset = "0xBDCAFC", VA = "0xBDCAFC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004E3")]
	public bool HFMNNKEBNIP
	{
		[Token(Token = "0x6004247")]
		[Address(RVA = "0xBDCB74", Offset = "0xBDCB74", VA = "0xBDCB74")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004E4")]
	public bool MKMICDHFEAE
	{
		[Token(Token = "0x6004248")]
		[Address(RVA = "0xBDCBEC", Offset = "0xBDCBEC", VA = "0xBDCBEC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004249")]
		[Address(RVA = "0xBDCC44", Offset = "0xBDCC44", VA = "0xBDCC44")]
		set
		{
		}
	}

	[Token(Token = "0x170004E5")]
	public bool LFJKFLNNNBK
	{
		[Token(Token = "0x600424A")]
		[Address(RVA = "0xBDCCB0", Offset = "0xBDCCB0", VA = "0xBDCCB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004E6")]
	public bool AJMHFMMNDEP
	{
		[Token(Token = "0x600424B")]
		[Address(RVA = "0xBDCDA4", Offset = "0xBDCDA4", VA = "0xBDCDA4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004E7")]
	public bool HHJABOAFPHM
	{
		[Token(Token = "0x600424C")]
		[Address(RVA = "0xBDCE1C", Offset = "0xBDCE1C", VA = "0xBDCE1C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600424D")]
		[Address(RVA = "0xBDCE24", Offset = "0xBDCE24", VA = "0xBDCE24")]
		set
		{
		}
	}

	[Token(Token = "0x170004E8")]
	public bool CENMCEFKFBK
	{
		[Token(Token = "0x600424E")]
		[Address(RVA = "0xBDCE2C", Offset = "0xBDCE2C", VA = "0xBDCE2C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004E9")]
	public PGMEJCOFIGF EAKHEPNJMCP
	{
		[Token(Token = "0x600424F")]
		[Address(RVA = "0xBDCE84", Offset = "0xBDCE84", VA = "0xBDCE84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004EA")]
	public List<JJHIMAEGAPA> MCPGFPHMOGM
	{
		[Token(Token = "0x6004250")]
		[Address(RVA = "0xBDCEDC", Offset = "0xBDCEDC", VA = "0xBDCEDC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004EB")]
	public bool JKHBGMBINHI
	{
		[Token(Token = "0x6004251")]
		[Address(RVA = "0xBDCF34", Offset = "0xBDCF34", VA = "0xBDCF34")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004252")]
		[Address(RVA = "0xBDCF8C", Offset = "0xBDCF8C", VA = "0xBDCF8C")]
		set
		{
		}
	}

	[Token(Token = "0x170004EC")]
	public LevelTriggerHumanTire PGPNJNNOIDC
	{
		[Token(Token = "0x6004253")]
		[Address(RVA = "0xBDCFEC", Offset = "0xBDCFEC", VA = "0xBDCFEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004ED")]
	public PKLAGHHKOPO PKLAGHHKOPO
	{
		[Token(Token = "0x6004254")]
		[Address(RVA = "0xBDD0E4", Offset = "0xBDD0E4", VA = "0xBDD0E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004EE")]
	public GBJAEPHNFMD ABCBDLOPKEN
	{
		[Token(Token = "0x6004256")]
		[Address(RVA = "0xBDD7C4", Offset = "0xBDD7C4", VA = "0xBDD7C4")]
		get
		{
			return default(GBJAEPHNFMD);
		}
		[Token(Token = "0x6004257")]
		[Address(RVA = "0xBDD81C", Offset = "0xBDD81C", VA = "0xBDD81C")]
		set
		{
		}
	}

	[Token(Token = "0x170004EF")]
	public uint KFMJKFECHGI
	{
		[Token(Token = "0x600425E")]
		[Address(RVA = "0xBDDB14", Offset = "0xBDDB14", VA = "0xBDDB14")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600425D")]
		[Address(RVA = "0xBDDB0C", Offset = "0xBDDB0C", VA = "0xBDDB0C")]
		protected set
		{
		}
	}

	[Token(Token = "0x170004F0")]
	public float DELDBLPCJNN
	{
		[Token(Token = "0x600425F")]
		[Address(RVA = "0xBDDB1C", Offset = "0xBDDB1C", VA = "0xBDDB1C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004260")]
		[Address(RVA = "0xBDDB74", Offset = "0xBDDB74", VA = "0xBDDB74")]
		set
		{
		}
	}

	[Token(Token = "0x170004F1")]
	public float CDHLJIOPPID
	{
		[Token(Token = "0x6004261")]
		[Address(RVA = "0xBDDBE0", Offset = "0xBDDBE0", VA = "0xBDDBE0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004262")]
		[Address(RVA = "0xBDDC38", Offset = "0xBDDC38", VA = "0xBDDC38")]
		set
		{
		}
	}

	[Token(Token = "0x170004F2")]
	public bool NMJMPJNFGII
	{
		[Token(Token = "0x6004263")]
		[Address(RVA = "0xBDDCA8", Offset = "0xBDDCA8", VA = "0xBDDCA8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004264")]
		[Address(RVA = "0xBDDD00", Offset = "0xBDDD00", VA = "0xBDDD00")]
		set
		{
		}
	}

	[Token(Token = "0x170004F3")]
	public bool JPFMADNPNEB
	{
		[Token(Token = "0x600426C")]
		[Address(RVA = "0xBD9444", Offset = "0xBD9444", VA = "0xBD9444")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600426D")]
		[Address(RVA = "0xBDE23C", Offset = "0xBDE23C", VA = "0xBDE23C")]
		protected set
		{
		}
	}

	[Token(Token = "0x170004F4")]
	public byte IMEJKAHCAPH
	{
		[Token(Token = "0x600426E")]
		[Address(RVA = "0xBDF72C", Offset = "0xBDF72C", VA = "0xBDF72C")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x600426F")]
		[Address(RVA = "0xBDF734", Offset = "0xBDF734", VA = "0xBDF734")]
		set
		{
		}
	}

	[Token(Token = "0x170004F5")]
	public ResourceID CAEAPMIKCMO
	{
		[Token(Token = "0x600427F")]
		[Address(RVA = "0xBE2CF0", Offset = "0xBE2CF0", VA = "0xBE2CF0")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x6004280")]
		[Address(RVA = "0xBE2D48", Offset = "0xBE2D48", VA = "0xBE2D48")]
		set
		{
		}
	}

	[Token(Token = "0x170004F6")]
	public ResourceID ECBHFOMLHIC
	{
		[Token(Token = "0x6004281")]
		[Address(RVA = "0xBE2DA8", Offset = "0xBE2DA8", VA = "0xBE2DA8")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x6004282")]
		[Address(RVA = "0xBE2E00", Offset = "0xBE2E00", VA = "0xBE2E00")]
		set
		{
		}
	}

	[Token(Token = "0x170004F7")]
	public ResourceID MDLPMNCNFNP
	{
		[Token(Token = "0x6004283")]
		[Address(RVA = "0xBE2E60", Offset = "0xBE2E60", VA = "0xBE2E60")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x6004284")]
		[Address(RVA = "0xBE2EB8", Offset = "0xBE2EB8", VA = "0xBE2EB8")]
		set
		{
		}
	}

	[Token(Token = "0x170004F8")]
	public SkyboardData PLKBLACHKDO
	{
		[Token(Token = "0x6004286")]
		[Address(RVA = "0xBE323C", Offset = "0xBE323C", VA = "0xBE323C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004287")]
		[Address(RVA = "0xBE3294", Offset = "0xBE3294", VA = "0xBE3294")]
		set
		{
		}
	}

	[Token(Token = "0x170004F9")]
	public FlightData CKBPNFBNFLO
	{
		[Token(Token = "0x6004288")]
		[Address(RVA = "0xBE32F4", Offset = "0xBE32F4", VA = "0xBE32F4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004289")]
		[Address(RVA = "0xBE31DC", Offset = "0xBE31DC", VA = "0xBE31DC")]
		set
		{
		}
	}

	[Token(Token = "0x170004FA")]
	public PlayerAudioComponent MEEBGFCOPJO
	{
		[Token(Token = "0x600428A")]
		[Address(RVA = "0xBE334C", Offset = "0xBE334C", VA = "0xBE334C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004FB")]
	public Parachute COGOGHNCDHE
	{
		[Token(Token = "0x600428B")]
		[Address(RVA = "0xBE3468", Offset = "0xBE3468", VA = "0xBE3468")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004FC")]
	public Flight JEIMEBEHMIH
	{
		[Token(Token = "0x600428C")]
		[Address(RVA = "0xBE34C0", Offset = "0xBE34C0", VA = "0xBE34C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004FD")]
	public JNGKMJDINHC IMIAJFDPHIB
	{
		[Token(Token = "0x60042C7")]
		[Address(RVA = "0xC04804", Offset = "0xC04804", VA = "0xC04804")]
		get
		{
			return default(JNGKMJDINHC);
		}
		[Token(Token = "0x60042C8")]
		[Address(RVA = "0xC0485C", Offset = "0xC0485C", VA = "0xC0485C")]
		set
		{
		}
	}

	[Token(Token = "0x170004FE")]
	public MALGAHKKNNN OLLCDNPLHBN
	{
		[Token(Token = "0x60042C9")]
		[Address(RVA = "0xC048BC", Offset = "0xC048BC", VA = "0xC048BC")]
		get
		{
			return default(MALGAHKKNNN);
		}
		[Token(Token = "0x60042CA")]
		[Address(RVA = "0xC04914", Offset = "0xC04914", VA = "0xC04914")]
		set
		{
		}
	}

	[Token(Token = "0x170004FF")]
	public MADMMIICBNN GCMAMNFNEBG
	{
		[Token(Token = "0x600430E")]
		[Address(RVA = "0xC1D4E0", Offset = "0xC1D4E0", VA = "0xC1D4E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000500")]
	private MADMMIICBNN CJCNKCALFIK
	{
		[Token(Token = "0x600430F")]
		[Address(RVA = "0xC1D538", Offset = "0xC1D538", VA = "0xC1D538")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000501")]
	public OPILIBBOEAC AEMHIOJGMBP
	{
		[Token(Token = "0x6004310")]
		[Address(RVA = "0xC1D590", Offset = "0xC1D590", VA = "0xC1D590", Slot = "84")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004311")]
		[Address(RVA = "0xC1D598", Offset = "0xC1D598", VA = "0xC1D598")]
		private set
		{
		}
	}

	[Token(Token = "0x17000502")]
	public Vector3 GBHKDOGIBMM
	{
		[Token(Token = "0x6004316")]
		[Address(RVA = "0xC1DD54", Offset = "0xC1DD54", VA = "0xC1DD54")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000503")]
	public Vector3 GJPONEDMMKP
	{
		[Token(Token = "0x6004317")]
		[Address(RVA = "0xC1DFF4", Offset = "0xC1DFF4", VA = "0xC1DFF4")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000504")]
	public BaseLevelObject MCNKFJAECNC
	{
		[Token(Token = "0x6004399")]
		[Address(RVA = "0xC36A28", Offset = "0xC36A28", VA = "0xC36A28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000505")]
	public bool IPHMKAABNPJ
	{
		[Token(Token = "0x60043D7")]
		[Address(RVA = "0xC424CC", Offset = "0xC424CC", VA = "0xC424CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60043D8")]
		[Address(RVA = "0xC424D4", Offset = "0xC424D4", VA = "0xC424D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000506")]
	public bool DLIGANJECNO
	{
		[Token(Token = "0x6004403")]
		[Address(RVA = "0xC0A45C", Offset = "0xC0A45C", VA = "0xC0A45C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000507")]
	public bool PAPMKCKLHBF
	{
		[Token(Token = "0x6004404")]
		[Address(RVA = "0xC274EC", Offset = "0xC274EC", VA = "0xC274EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000508")]
	public bool CPLEOLCIFPK
	{
		[Token(Token = "0x6004405")]
		[Address(RVA = "0xC46570", Offset = "0xC46570", VA = "0xC46570")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000509")]
	public bool OKGECDMNNKJ
	{
		[Token(Token = "0x6004406")]
		[Address(RVA = "0xC4666C", Offset = "0xC4666C", VA = "0xC4666C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700050A")]
	public bool EAAGPMFOFHM
	{
		[Token(Token = "0x6004407")]
		[Address(RVA = "0xC46850", Offset = "0xC46850", VA = "0xC46850")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700050B")]
	public bool GEKIOMAKPOL
	{
		[Token(Token = "0x6004408")]
		[Address(RVA = "0xC19748", Offset = "0xC19748", VA = "0xC19748")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700050C")]
	public int EJBKGJDBCPE
	{
		[Token(Token = "0x6004448")]
		[Address(RVA = "0xC536BC", Offset = "0xC536BC", VA = "0xC536BC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700050D")]
	public Player LNLKCHLDGPF
	{
		[Token(Token = "0x600444C")]
		[Address(RVA = "0xC53778", Offset = "0xC53778", VA = "0xC53778", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700050E")]
	public bool FJCJOOOHHBE
	{
		[Token(Token = "0x6004466")]
		[Address(RVA = "0xC57ED8", Offset = "0xC57ED8", VA = "0xC57ED8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004467")]
		[Address(RVA = "0xC57F30", Offset = "0xC57F30", VA = "0xC57F30")]
		private set
		{
		}
	}

	[Token(Token = "0x1700050F")]
	public virtual BaseProfileInfo GFNIFLOJIAF
	{
		[Token(Token = "0x60044A8")]
		[Address(RVA = "0xC5BE14", Offset = "0xC5BE14", VA = "0xC5BE14", Slot = "215")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000510")]
	public float CFFHMNNJOBK
	{
		[Token(Token = "0x60044BB")]
		[Address(RVA = "0xC40614", Offset = "0xC40614", VA = "0xC40614")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60044BA")]
		[Address(RVA = "0xC405A8", Offset = "0xC405A8", VA = "0xC405A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000511")]
	public float HCCFDNJGDLM
	{
		[Token(Token = "0x60044BD")]
		[Address(RVA = "0xC40EB4", Offset = "0xC40EB4", VA = "0xC40EB4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60044BC")]
		[Address(RVA = "0xC40E44", Offset = "0xC40E44", VA = "0xC40E44")]
		set
		{
		}
	}

	[Token(Token = "0x17000512")]
	public bool AHNHGCFOLIN
	{
		[Token(Token = "0x60044C0")]
		[Address(RVA = "0xC5DC58", Offset = "0xC5DC58", VA = "0xC5DC58")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000513")]
	public float IGIDMIPOLNE
	{
		[Token(Token = "0x60044C1")]
		[Address(RVA = "0xC5DD28", Offset = "0xC5DD28", VA = "0xC5DD28")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000514")]
	public float HLKMFCIIBPI
	{
		[Token(Token = "0x60044C2")]
		[Address(RVA = "0xC5DE90", Offset = "0xC5DE90", VA = "0xC5DE90")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000515")]
	public float CFGLFCCMJKC
	{
		[Token(Token = "0x60044C3")]
		[Address(RVA = "0xC5DFF8", Offset = "0xC5DFF8", VA = "0xC5DFF8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000516")]
	public bool DDICBNOOEBN
	{
		[Token(Token = "0x60044EB")]
		[Address(RVA = "0xC1B090", Offset = "0xC1B090", VA = "0xC1B090")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60044EC")]
		[Address(RVA = "0xC63580", Offset = "0xC63580", VA = "0xC63580")]
		set
		{
		}
	}

	[Token(Token = "0x17000517")]
	public bool FLLFLDIDMNE
	{
		[Token(Token = "0x60044ED")]
		[Address(RVA = "0xC1BFE4", Offset = "0xC1BFE4", VA = "0xC1BFE4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60044EE")]
		[Address(RVA = "0xC63588", Offset = "0xC63588", VA = "0xC63588")]
		set
		{
		}
	}

	[Token(Token = "0x17000518")]
	public bool GICJKCOKDCH
	{
		[Token(Token = "0x60044EF")]
		[Address(RVA = "0xC63590", Offset = "0xC63590", VA = "0xC63590")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60044F0")]
		[Address(RVA = "0xC63598", Offset = "0xC63598", VA = "0xC63598")]
		set
		{
		}
	}

	[Token(Token = "0x17000519")]
	public bool MBEDBIKJBOM
	{
		[Token(Token = "0x60044F1")]
		[Address(RVA = "0xC635A0", Offset = "0xC635A0", VA = "0xC635A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60044F2")]
		[Address(RVA = "0xC635A8", Offset = "0xC635A8", VA = "0xC635A8")]
		set
		{
		}
	}

	[Token(Token = "0x1700051A")]
	public bool KNPACMOLBOE
	{
		[Token(Token = "0x60044F3")]
		[Address(RVA = "0xC635B0", Offset = "0xC635B0", VA = "0xC635B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60044F4")]
		[Address(RVA = "0xC635B8", Offset = "0xC635B8", VA = "0xC635B8")]
		set
		{
		}
	}

	[Token(Token = "0x1700051B")]
	public bool GKDOBOEENDB
	{
		[Token(Token = "0x60044FA")]
		[Address(RVA = "0xC63A64", Offset = "0xC63A64", VA = "0xC63A64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700051C")]
	public PFLCPEHBBLN OEOFBIMIAII
	{
		[Token(Token = "0x6004501")]
		[Address(RVA = "0xBDBB90", Offset = "0xBDBB90", VA = "0xBDBB90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700051D")]
	public bool IJBJJGDMABM
	{
		[Token(Token = "0x6004502")]
		[Address(RVA = "0xC64620", Offset = "0xC64620", VA = "0xC64620")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700051E")]
	public AvatarTransformData KJDCMLJDEMK
	{
		[Token(Token = "0x6004520")]
		[Address(RVA = "0xC66FDC", Offset = "0xC66FDC", VA = "0xC66FDC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700051F")]
	public bool FOCKKHFBHPD
	{
		[Token(Token = "0x6004529")]
		[Address(RVA = "0xC084B8", Offset = "0xC084B8", VA = "0xC084B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000520")]
	public bool IDDMOPOHKPJ
	{
		[Token(Token = "0x600452A")]
		[Address(RVA = "0xC083D8", Offset = "0xC083D8", VA = "0xC083D8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000521")]
	public ClimbingTrigger NODLLGGEIBF
	{
		[Token(Token = "0x600452B")]
		[Address(RVA = "0xC68A58", Offset = "0xC68A58", VA = "0xC68A58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000522")]
	public bool OCGFJFKOPBD
	{
		[Token(Token = "0x6004533")]
		[Address(RVA = "0xC06FDC", Offset = "0xC06FDC", VA = "0xC06FDC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000523")]
	public bool KPKHALMFEKF
	{
		[Token(Token = "0x6004534")]
		[Address(RVA = "0xC3667C", Offset = "0xC3667C", VA = "0xC3667C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000524")]
	public bool JFOHGJCANMP
	{
		[Token(Token = "0x6004541")]
		[Address(RVA = "0xC6B7D0", Offset = "0xC6B7D0", VA = "0xC6B7D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000525")]
	public bool JINIJFONCCB
	{
		[Token(Token = "0x6004542")]
		[Address(RVA = "0xC6B840", Offset = "0xC6B840", VA = "0xC6B840")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000526")]
	public bool FMENPGDGCML
	{
		[Token(Token = "0x6004547")]
		[Address(RVA = "0xC357C0", Offset = "0xC357C0", VA = "0xC357C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000527")]
	public bool CIAKKHCFGFC
	{
		[Token(Token = "0x6004548")]
		[Address(RVA = "0xC6BD8C", Offset = "0xC6BD8C", VA = "0xC6BD8C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000528")]
	public bool KFFEOMGCOBO
	{
		[Token(Token = "0x600454B")]
		[Address(RVA = "0xC6C390", Offset = "0xC6C390", VA = "0xC6C390")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000529")]
	public bool KMMKKLDMEGM
	{
		[Token(Token = "0x600454C")]
		[Address(RVA = "0xC6C418", Offset = "0xC6C418", VA = "0xC6C418")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700052A")]
	public bool CNHIMPHCIAI
	{
		[Token(Token = "0x600454D")]
		[Address(RVA = "0xC6C4CC", Offset = "0xC6C4CC", VA = "0xC6C4CC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700052B")]
	public bool EDOKAHPMFIM
	{
		[Token(Token = "0x600454F")]
		[Address(RVA = "0xC6C588", Offset = "0xC6C588", VA = "0xC6C588")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600454E")]
		[Address(RVA = "0xC6C580", Offset = "0xC6C580", VA = "0xC6C580")]
		set
		{
		}
	}

	[Token(Token = "0x1700052C")]
	public CCGBDNBALMI IJBNNNALNIK
	{
		[Token(Token = "0x6004555")]
		[Address(RVA = "0xC6CD48", Offset = "0xC6CD48", VA = "0xC6CD48")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004556")]
		[Address(RVA = "0xC6CDA0", Offset = "0xC6CDA0", VA = "0xC6CDA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700052D")]
	public bool PFNBJLDAGGD
	{
		[Token(Token = "0x6004557")]
		[Address(RVA = "0xC6CEDC", Offset = "0xC6CEDC", VA = "0xC6CEDC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700052E")]
	public FoldWingConfigData JDODMKEPPNG
	{
		[Token(Token = "0x6004558")]
		[Address(RVA = "0xC6CF44", Offset = "0xC6CF44", VA = "0xC6CF44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052F")]
	public bool PJGBEEDGBON
	{
		[Token(Token = "0x600455C")]
		[Address(RVA = "0xC6D1D8", Offset = "0xC6D1D8", VA = "0xC6D1D8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600455D")]
		[Address(RVA = "0xC6D230", Offset = "0xC6D230", VA = "0xC6D230")]
		set
		{
		}
	}

	[Token(Token = "0x17000530")]
	public Football CBFDFHABLIM
	{
		[Token(Token = "0x6004564")]
		[Address(RVA = "0xC6E138", Offset = "0xC6E138", VA = "0xC6E138")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000531")]
	public float CKEKAPOLDAM
	{
		[Token(Token = "0x6004565")]
		[Address(RVA = "0xC6E190", Offset = "0xC6E190", VA = "0xC6E190")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000532")]
	public bool BILJIPOILDD
	{
		[Token(Token = "0x6004566")]
		[Address(RVA = "0xBD5DC8", Offset = "0xBD5DC8", VA = "0xBD5DC8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000533")]
	public GHCOKFDGCNF JBPOAMOMIFA
	{
		[Token(Token = "0x600457E")]
		[Address(RVA = "0xC7212C", Offset = "0xC7212C", VA = "0xC7212C")]
		get
		{
			return default(GHCOKFDGCNF);
		}
		[Token(Token = "0x600457F")]
		[Address(RVA = "0xC7228C", Offset = "0xC7228C", VA = "0xC7228C")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000534")]
	public bool APLKOHCELBK
	{
		[Token(Token = "0x6004584")]
		[Address(RVA = "0xC19844", Offset = "0xC19844", VA = "0xC19844")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000535")]
	public bool GIPJOLAFCNB
	{
		[Token(Token = "0x6004585")]
		[Address(RVA = "0xC342B8", Offset = "0xC342B8", VA = "0xC342B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000536")]
	public bool JMIJEBJMLHG
	{
		[Token(Token = "0x6004586")]
		[Address(RVA = "0xC6C10C", Offset = "0xC6C10C", VA = "0xC6C10C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000537")]
	public bool MDCJIOPJFJP
	{
		[Token(Token = "0x6004587")]
		[Address(RVA = "0xC6C1C0", Offset = "0xC6C1C0", VA = "0xC6C1C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000538")]
	public CKMBFCELDAO EBOPGNPLBOE
	{
		[Token(Token = "0x6004588")]
		[Address(RVA = "0xC72988", Offset = "0xC72988", VA = "0xC72988")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000539")]
	public bool HGENIGEDNIO
	{
		[Token(Token = "0x600458E")]
		[Address(RVA = "0xC73180", Offset = "0xC73180", VA = "0xC73180")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700053A")]
	public MADMMIICBNN KJADDCANPJN
	{
		[Token(Token = "0x600458F")]
		[Address(RVA = "0xC7329C", Offset = "0xC7329C", VA = "0xC7329C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053B")]
	public uint OIFPNDKHLPE
	{
		[Token(Token = "0x6004591")]
		[Address(RVA = "0xC73E14", Offset = "0xC73E14", VA = "0xC73E14")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700053C")]
	public Vector3 IEBKAELKDFF
	{
		[Token(Token = "0x6004592")]
		[Address(RVA = "0xC73F14", Offset = "0xC73F14", VA = "0xC73F14")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700053D")]
	public bool AHLEEFJOIKP
	{
		[Token(Token = "0x6004597")]
		[Address(RVA = "0xC741EC", Offset = "0xC741EC", VA = "0xC741EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700053E")]
	public KHDMPGBLNCM DOPEOMJDEPC
	{
		[Token(Token = "0x600459E")]
		[Address(RVA = "0xBE952C", Offset = "0xBE952C", VA = "0xBE952C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053F")]
	protected float KOOGCLBBJHP
	{
		[Token(Token = "0x600459F")]
		[Address(RVA = "0xC74C04", Offset = "0xC74C04", VA = "0xC74C04")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000540")]
	protected float CMOIDFCEHBN
	{
		[Token(Token = "0x60045A0")]
		[Address(RVA = "0xC74D88", Offset = "0xC74D88", VA = "0xC74D88")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000541")]
	public int LJBCNMIFEFJ
	{
		[Token(Token = "0x60045BD")]
		[Address(RVA = "0xC21F80", Offset = "0xC21F80", VA = "0xC21F80")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60045BE")]
		[Address(RVA = "0xBEC1E4", Offset = "0xBEC1E4", VA = "0xBEC1E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000542")]
	public int JMFDKFEGFLK
	{
		[Token(Token = "0x60045BF")]
		[Address(RVA = "0xC220A8", Offset = "0xC220A8", VA = "0xC220A8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60045C0")]
		[Address(RVA = "0xC7A2E8", Offset = "0xC7A2E8", VA = "0xC7A2E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000543")]
	public int ALFKOKPECKN
	{
		[Token(Token = "0x60045C1")]
		[Address(RVA = "0xC7A410", Offset = "0xC7A410", VA = "0xC7A410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60045C2")]
		[Address(RVA = "0xC7A538", Offset = "0xC7A538", VA = "0xC7A538")]
		set
		{
		}
	}

	[Token(Token = "0x17000544")]
	public int EOEKAOHEMPP
	{
		[Token(Token = "0x60045C3")]
		[Address(RVA = "0xBE1AEC", Offset = "0xBE1AEC", VA = "0xBE1AEC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60045C4")]
		[Address(RVA = "0xC7A660", Offset = "0xC7A660", VA = "0xC7A660")]
		set
		{
		}
	}

	[Token(Token = "0x17000545")]
	public int OHOMAJNANED
	{
		[Token(Token = "0x60045C5")]
		[Address(RVA = "0xC7A788", Offset = "0xC7A788", VA = "0xC7A788")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000546")]
	public int FEPEFNDHJPG
	{
		[Token(Token = "0x60045C6")]
		[Address(RVA = "0xC7A8AC", Offset = "0xC7A8AC", VA = "0xC7A8AC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000547")]
	public float PKCBJJLHMEO
	{
		[Token(Token = "0x60045C7")]
		[Address(RVA = "0xC6ECD0", Offset = "0xC6ECD0", VA = "0xC6ECD0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000548")]
	public int NDOJPPCJKIC
	{
		[Token(Token = "0x60045C8")]
		[Address(RVA = "0xC79528", Offset = "0xC79528", VA = "0xC79528")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000549")]
	public int KOKDOPJMGPD
	{
		[Token(Token = "0x60045C9")]
		[Address(RVA = "0xC7A9D8", Offset = "0xC7A9D8", VA = "0xC7A9D8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60045CA")]
		[Address(RVA = "0xC7AB00", Offset = "0xC7AB00", VA = "0xC7AB00")]
		set
		{
		}
	}

	[Token(Token = "0x1700054A")]
	public int PLHJHKPJHDN
	{
		[Token(Token = "0x60045CB")]
		[Address(RVA = "0xC7AC28", Offset = "0xC7AC28", VA = "0xC7AC28")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700054B")]
	public int HIFLJPPPJAN
	{
		[Token(Token = "0x60045CC")]
		[Address(RVA = "0xC7AD50", Offset = "0xC7AD50", VA = "0xC7AD50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700054C")]
	public bool IAAEKPFDJHK
	{
		[Token(Token = "0x60045CD")]
		[Address(RVA = "0xC23BD0", Offset = "0xC23BD0", VA = "0xC23BD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700054D")]
	public int LOOIDLJGDHP
	{
		[Token(Token = "0x60045CE")]
		[Address(RVA = "0xC7AE78", Offset = "0xC7AE78", VA = "0xC7AE78")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700054E")]
	public int GBLBEFNFKGD
	{
		[Token(Token = "0x60045CF")]
		[Address(RVA = "0xC5ED10", Offset = "0xC5ED10", VA = "0xC5ED10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700054F")]
	public float BEJOJAEJKLO
	{
		[Token(Token = "0x60045D0")]
		[Address(RVA = "0xC7AFA0", Offset = "0xC7AFA0", VA = "0xC7AFA0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000550")]
	public int CBNPIFJAKFJ
	{
		[Token(Token = "0x60045D1")]
		[Address(RVA = "0xC7B0C4", Offset = "0xC7B0C4", VA = "0xC7B0C4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000551")]
	public INNIMLNIOIA IIJLDPOMKNL
	{
		[Token(Token = "0x60045D2")]
		[Address(RVA = "0xC7B1EC", Offset = "0xC7B1EC", VA = "0xC7B1EC")]
		get
		{
			return default(INNIMLNIOIA);
		}
	}

	[Token(Token = "0x17000552")]
	public int ELLCNHNCNCC
	{
		[Token(Token = "0x60045D3")]
		[Address(RVA = "0xC7B314", Offset = "0xC7B314", VA = "0xC7B314")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000553")]
	public int NHPIDPBPPII
	{
		[Token(Token = "0x60045D4")]
		[Address(RVA = "0xC7B43C", Offset = "0xC7B43C", VA = "0xC7B43C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000554")]
	public byte IDEPJJALDIK
	{
		[Token(Token = "0x60045D5")]
		[Address(RVA = "0xC7B564", Offset = "0xC7B564", VA = "0xC7B564")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17000555")]
	public int INFBGJBCLMC
	{
		[Token(Token = "0x60045D7")]
		[Address(RVA = "0xC0513C", Offset = "0xC0513C", VA = "0xC0513C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000556")]
	public int ANNJOPOOOFO
	{
		[Token(Token = "0x60045D8")]
		[Address(RVA = "0xC4492C", Offset = "0xC4492C", VA = "0xC4492C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000557")]
	public uint NFPPMIHIMJH
	{
		[Token(Token = "0x60045D9")]
		[Address(RVA = "0xC7B6E0", Offset = "0xC7B6E0", VA = "0xC7B6E0")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000558")]
	public int ELEIEHDKHJM
	{
		[Token(Token = "0x60045DA")]
		[Address(RVA = "0xC7B804", Offset = "0xC7B804", VA = "0xC7B804")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000559")]
	public int HKAJPDLHJPA
	{
		[Token(Token = "0x60045DB")]
		[Address(RVA = "0xC32D10", Offset = "0xC32D10", VA = "0xC32D10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700055A")]
	public int NDACFLCILDK
	{
		[Token(Token = "0x60045DC")]
		[Address(RVA = "0xC7B92C", Offset = "0xC7B92C", VA = "0xC7B92C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700055B")]
	public bool DPEBBONMIHE
	{
		[Token(Token = "0x60045DD")]
		[Address(RVA = "0xC7BA54", Offset = "0xC7BA54", VA = "0xC7BA54")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700055C")]
	public int HJPDAOFPHJA
	{
		[Token(Token = "0x60045DE")]
		[Address(RVA = "0xBDA6AC", Offset = "0xBDA6AC", VA = "0xBDA6AC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700055D")]
	public uint KJPNIKHFKDJ
	{
		[Token(Token = "0x60045DF")]
		[Address(RVA = "0xC7BB84", Offset = "0xC7BB84", VA = "0xC7BB84")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700055E")]
	public int INLNGPCBGFI
	{
		[Token(Token = "0x60045E0")]
		[Address(RVA = "0xC7BCAC", Offset = "0xC7BCAC", VA = "0xC7BCAC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700055F")]
	public uint DBNIDAFPMHG
	{
		[Token(Token = "0x60045E1")]
		[Address(RVA = "0xC7BDD4", Offset = "0xC7BDD4", VA = "0xC7BDD4")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000560")]
	public int KEEADNIPIKE
	{
		[Token(Token = "0x60045E2")]
		[Address(RVA = "0xC23010", Offset = "0xC23010", VA = "0xC23010")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000561")]
	public uint EGCHLGKIIFM
	{
		[Token(Token = "0x60045E3")]
		[Address(RVA = "0xC7BEF8", Offset = "0xC7BEF8", VA = "0xC7BEF8")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000562")]
	public bool GNIOKEILMBJ
	{
		[Token(Token = "0x60045E4")]
		[Address(RVA = "0xC7BF50", Offset = "0xC7BF50", VA = "0xC7BF50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000563")]
	public uint OBIJLEIGAJC
	{
		[Token(Token = "0x60045E5")]
		[Address(RVA = "0xC7C0DC", Offset = "0xC7C0DC", VA = "0xC7C0DC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000564")]
	public uint BDNBGOHCKJF
	{
		[Token(Token = "0x60045F1")]
		[Address(RVA = "0xC73CEC", Offset = "0xC73CEC", VA = "0xC73CEC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000565")]
	public float BCDOOOCHNOF
	{
		[Token(Token = "0x60045F2")]
		[Address(RVA = "0xC81DF0", Offset = "0xC81DF0", VA = "0xC81DF0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000566")]
	public bool MFHDIDBGKEP
	{
		[Token(Token = "0x60045FF")]
		[Address(RVA = "0xC842F8", Offset = "0xC842F8", VA = "0xC842F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000567")]
	public int GAPGDEHHDCN
	{
		[Token(Token = "0x600461D")]
		[Address(RVA = "0xC8B488", Offset = "0xC8B488", VA = "0xC8B488")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000568")]
	public uint HAGPMPDJHNC
	{
		[Token(Token = "0x600461E")]
		[Address(RVA = "0xC8B5B0", Offset = "0xC8B5B0", VA = "0xC8B5B0")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000569")]
	public uint JFLBPPBLEPB
	{
		[Token(Token = "0x600461F")]
		[Address(RVA = "0xC8B6D4", Offset = "0xC8B6D4", VA = "0xC8B6D4")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700056A")]
	public bool LPMCCPCLGBN
	{
		[Token(Token = "0x6004621")]
		[Address(RVA = "0xC8B8B4", Offset = "0xC8B8B4", VA = "0xC8B8B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700056B")]
	public bool HNFJGOBEMKM
	{
		[Token(Token = "0x6004622")]
		[Address(RVA = "0xC84ED0", Offset = "0xC84ED0", VA = "0xC84ED0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004623")]
		[Address(RVA = "0xC8B9E4", Offset = "0xC8B9E4", VA = "0xC8B9E4")]
		set
		{
		}
	}

	[Token(Token = "0x1700056C")]
	public float DKEFDABEPLJ
	{
		[Token(Token = "0x600463A")]
		[Address(RVA = "0xC8F3B0", Offset = "0xC8F3B0", VA = "0xC8F3B0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700056D")]
	public int MHJMENLPANO
	{
		[Token(Token = "0x600463B")]
		[Address(RVA = "0xC8F4D4", Offset = "0xC8F4D4", VA = "0xC8F4D4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700056E")]
	public int KJKENCDMEDC
	{
		[Token(Token = "0x600463C")]
		[Address(RVA = "0xC8F5F8", Offset = "0xC8F5F8", VA = "0xC8F5F8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700056F")]
	public bool AENDMLNBMHH
	{
		[Token(Token = "0x6004643")]
		[Address(RVA = "0xC90248", Offset = "0xC90248", VA = "0xC90248")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000570")]
	public byte DDPABHOMLJP
	{
		[Token(Token = "0x6004644")]
		[Address(RVA = "0xC902AC", Offset = "0xC902AC", VA = "0xC902AC")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6004645")]
		[Address(RVA = "0xC902B4", Offset = "0xC902B4", VA = "0xC902B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000571")]
	public byte NDCOECLCDLA
	{
		[Token(Token = "0x6004649")]
		[Address(RVA = "0xC906B4", Offset = "0xC906B4", VA = "0xC906B4")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17000572")]
	public bool IMEDADNKAKL
	{
		[Token(Token = "0x600464A")]
		[Address(RVA = "0xC907D8", Offset = "0xC907D8", VA = "0xC907D8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000573")]
	public bool PJHCDJKNLON
	{
		[Token(Token = "0x600464B")]
		[Address(RVA = "0xBD7E28", Offset = "0xBD7E28", VA = "0xBD7E28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000574")]
	public bool GPPOKKMKOEM
	{
		[Token(Token = "0x600464C")]
		[Address(RVA = "0xC90898", Offset = "0xC90898", VA = "0xC90898")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000575")]
	public bool PGIDLPHPOLJ
	{
		[Token(Token = "0x600464D")]
		[Address(RVA = "0xC90910", Offset = "0xC90910", VA = "0xC90910")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000576")]
	protected BCIGOPJHDPB BCIGOPJHDPB
	{
		[Token(Token = "0x600464F")]
		[Address(RVA = "0xC90AD4", Offset = "0xC90AD4", VA = "0xC90AD4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004650")]
		[Address(RVA = "0xC90ADC", Offset = "0xC90ADC", VA = "0xC90ADC")]
		set
		{
		}
	}

	[Token(Token = "0x17000577")]
	public bool ONDKEAJMHPJ
	{
		[Token(Token = "0x6004684")]
		[Address(RVA = "0xC966D0", Offset = "0xC966D0", VA = "0xC966D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000578")]
	public bool OGNJMIBKLCD
	{
		[Token(Token = "0x6004685")]
		[Address(RVA = "0xC9675C", Offset = "0xC9675C", VA = "0xC9675C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000579")]
	public bool JLCBAGLEDIH
	{
		[Token(Token = "0x6004686")]
		[Address(RVA = "0xC96874", Offset = "0xC96874", VA = "0xC96874")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700057A")]
	public bool LPBBNOGKAGG
	{
		[Token(Token = "0x6004693")]
		[Address(RVA = "0xBF2710", Offset = "0xBF2710", VA = "0xBF2710")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700057B")]
	public bool EHKKLLNOBGO
	{
		[Token(Token = "0x6004694")]
		[Address(RVA = "0xC3420C", Offset = "0xC3420C", VA = "0xC3420C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700057C")]
	private bool JGJDOGIGMHN
	{
		[Token(Token = "0x6004695")]
		[Address(RVA = "0xC77474", Offset = "0xC77474", VA = "0xC77474")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700057D")]
	public bool NCPJDOCMEEH
	{
		[Token(Token = "0x6004696")]
		[Address(RVA = "0xC77414", Offset = "0xC77414", VA = "0xC77414")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700057E")]
	private bool AGEKOLFACHF
	{
		[Token(Token = "0x6004697")]
		[Address(RVA = "0xC980AC", Offset = "0xC980AC", VA = "0xC980AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700057F")]
	public bool DHJDBFFAHAM
	{
		[Token(Token = "0x6004698")]
		[Address(RVA = "0xBE1F58", Offset = "0xBE1F58", VA = "0xBE1F58")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000580")]
	public IHAAMHPPLMG DLOMIEBOLKM
	{
		[Token(Token = "0x600469D")]
		[Address(RVA = "0xC984D0", Offset = "0xC984D0", VA = "0xC984D0")]
		get
		{
			return default(IHAAMHPPLMG);
		}
	}

	[Token(Token = "0x17000581")]
	public byte GPOFBNCDLCD
	{
		[Token(Token = "0x600469E")]
		[Address(RVA = "0xC98548", Offset = "0xC98548", VA = "0xC98548")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17000582")]
	public IKBGGPAEFDO IAILGALCJJK
	{
		[Token(Token = "0x600469F")]
		[Address(RVA = "0xC2EF68", Offset = "0xC2EF68", VA = "0xC2EF68")]
		get
		{
			return default(IKBGGPAEFDO);
		}
	}

	[Token(Token = "0x17000583")]
	public Transform CGGOHIKLEKD
	{
		[Token(Token = "0x60046A0")]
		[Address(RVA = "0xC985A0", Offset = "0xC985A0", VA = "0xC985A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000584")]
	public bool PKDPHMNGLLG
	{
		[Token(Token = "0x60046AA")]
		[Address(RVA = "0xC77CD0", Offset = "0xC77CD0", VA = "0xC77CD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000585")]
	public JAEAODJEENM EKEPLMOHPKL
	{
		[Token(Token = "0x60046B2")]
		[Address(RVA = "0xC5AB74", Offset = "0xC5AB74", VA = "0xC5AB74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000586")]
	public uint OCEKFOAIHNF
	{
		[Token(Token = "0x60046CE")]
		[Address(RVA = "0xC9DB78", Offset = "0xC9DB78", VA = "0xC9DB78")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60046CF")]
		[Address(RVA = "0xC9DBD0", Offset = "0xC9DBD0", VA = "0xC9DBD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000587")]
	public uint EOECGAAPENB
	{
		[Token(Token = "0x60046D0")]
		[Address(RVA = "0xC9DC30", Offset = "0xC9DC30", VA = "0xC9DC30")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60046D1")]
		[Address(RVA = "0xC9DC88", Offset = "0xC9DC88", VA = "0xC9DC88")]
		set
		{
		}
	}

	[Token(Token = "0x6004162")]
	[Address(RVA = "0xBD1660", Offset = "0xBD1660", VA = "0xBD1660")]
	public Player()
	{
	}

	[Token(Token = "0x6004163")]
	[Address(RVA = "0xBD23D8", Offset = "0xBD23D8", VA = "0xBD23D8")]
	public void SetIgnoreUserInputState(bool IMGNBGJDAHG)
	{
	}

	[Token(Token = "0x6004168")]
	[Address(RVA = "0xBD28CC", Offset = "0xBD28CC", VA = "0xBD28CC")]
	public void AddEPSurroundEffect(int EIKCFIDCCMM = 1, bool GJMAOIBIEBI = true)
	{
	}

	[Token(Token = "0x6004169")]
	[Address(RVA = "0xBD2D70", Offset = "0xBD2D70", VA = "0xBD2D70")]
	public void ForceMoveByClientHit(Vector3 LGCEBENCFFM)
	{
	}

	[Token(Token = "0x600416A")]
	[Address(RVA = "0xBD340C", Offset = "0xBD340C", VA = "0xBD340C")]
	public void SetAirShopBoughtData(uint KMGIELCFMND, ushort BJBICJALBNE)
	{
	}

	[Token(Token = "0x600416B")]
	[Address(RVA = "0xBD34F4", Offset = "0xBD34F4", VA = "0xBD34F4")]
	public ushort GetAirShopBoughtById(uint IDNEFEOPGIF)
	{
		return default(ushort);
	}

	[Token(Token = "0x600416C")]
	[Address(RVA = "0xBD35DC", Offset = "0xBD35DC", VA = "0xBD35DC")]
	public void ClearAirShopBounght()
	{
	}

	[Token(Token = "0x600416D")]
	[Address(RVA = "0xBD3690", Offset = "0xBD3690", VA = "0xBD3690")]
	public void UpdateAutoFLihtDamageEffect(bool ODOEHEHNJOG)
	{
	}

	[Token(Token = "0x600416E")]
	[Address(RVA = "0xBD2FDC", Offset = "0xBD2FDC", VA = "0xBD2FDC")]
	private Vector3 KEOMJALFPKD(Vector3 NLPMJMOOMIH, float IHDMOOHOJKO = 0f)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600416F")]
	[Address(RVA = "0xBD3C2C", Offset = "0xBD3C2C", VA = "0xBD3C2C")]
	public bool GetInPartyShoot()
	{
		return default(bool);
	}

	[Token(Token = "0x6004170")]
	[Address(RVA = "0xBD3C84", Offset = "0xBD3C84", VA = "0xBD3C84")]
	public void SetInPartyShoot(bool EBOJJLIHHCM)
	{
	}

	[Token(Token = "0x6004171")]
	[Address(RVA = "0xBD3CE4", Offset = "0xBD3CE4", VA = "0xBD3CE4")]
	public void SetPartyEffectShow(uint EIKCFIDCCMM = 0u)
	{
	}

	[Token(Token = "0x6004172")]
	[Address(RVA = "0xBD3DEC", Offset = "0xBD3DEC", VA = "0xBD3DEC")]
	public void InitMusicPartyEffect()
	{
	}

	[Token(Token = "0x6004173")]
	[Address(RVA = "0xBD3EE8", Offset = "0xBD3EE8", VA = "0xBD3EE8")]
	public void AddEPPlayerEffect()
	{
	}

	[Token(Token = "0x6004174")]
	[Address(RVA = "0xBD4370", Offset = "0xBD4370", VA = "0xBD4370")]
	protected void AFAAALFAJJJ()
	{
	}

	[Token(Token = "0x6004175")]
	[Address(RVA = "0xBD4790", Offset = "0xBD4790", VA = "0xBD4790")]
	public void SyncRevengeInfo(MDGAOJIACDM LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004176")]
	[Address(RVA = "0xBD4910", Offset = "0xBD4910", VA = "0xBD4910")]
	public void SyncRevengersInfo(HNOGPPOKMHC LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004177")]
	[Address(RVA = "0xBD4DF8", Offset = "0xBD4DF8", VA = "0xBD4DF8")]
	public void UpdateRevengeStatus(bool DPEBBLGPIMH = false)
	{
	}

	[Token(Token = "0x6004178")]
	[Address(RVA = "0xBD54BC", Offset = "0xBD54BC", VA = "0xBD54BC")]
	public void EnableCrossWindowEffect(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x6004179")]
	[Address(RVA = "0xBD58B0", Offset = "0xBD58B0", VA = "0xBD58B0", Slot = "48")]
	public override Vector3 GetAttackableCenterWS()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600417A")]
	[Address(RVA = "0xBD5E50", Offset = "0xBD5E50", VA = "0xBD5E50", Slot = "49")]
	public override float GetAttackableRadius()
	{
		return default(float);
	}

	[Token(Token = "0x600417B")]
	[Address(RVA = "0xBD5EC8", Offset = "0xBD5EC8", VA = "0xBD5EC8")]
	public uint GenerateLocalDamgeProjectileID()
	{
		return default(uint);
	}

	[Token(Token = "0x600417E")]
	[Address(RVA = "0xBD6070", Offset = "0xBD6070", VA = "0xBD6070")]
	public ulong GetShowUserID()
	{
		return default(ulong);
	}

	[Token(Token = "0x600419B")]
	[Address(RVA = "0xBD66D8", Offset = "0xBD66D8", VA = "0xBD66D8")]
	public void ReplaceSamoInfo(ulong HHMJNLLBELP, string KCKPGNOGDDI)
	{
	}

	[Token(Token = "0x60041AE")]
	[Address(RVA = "0xBD70D4", Offset = "0xBD70D4", VA = "0xBD70D4")]
	public uint GenUniqueID()
	{
		return default(uint);
	}

	[Token(Token = "0x60041C6")]
	[Address(RVA = "0xBD773C", Offset = "0xBD773C", VA = "0xBD773C")]
	public void SetBooyahEmotionID(uint IDNEFEOPGIF)
	{
	}

	[Token(Token = "0x60041C7")]
	[Address(RVA = "0xBD779C", Offset = "0xBD779C", VA = "0xBD779C")]
	public void RequireFollowCameraRotationUpdateTracing()
	{
	}

	[Token(Token = "0x60041C8")]
	[Address(RVA = "0xBD7808", Offset = "0xBD7808", VA = "0xBD7808")]
	public bool IsTracingFollowCameraRotationUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x60041C9")]
	[Address(RVA = "0xBD7860", Offset = "0xBD7860", VA = "0xBD7860")]
	public bool IsFollowCameraRotationUpdateTracingFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x60041CA")]
	[Address(RVA = "0xBD78B8", Offset = "0xBD78B8", VA = "0xBD78B8")]
	public void UpdateFollowCameraRotationUpdateTracing(bool OAHOFGAPLJK, bool FJNODLOFNAA)
	{
	}

	[Token(Token = "0x60041D8")]
	[Address(RVA = "0xBD8028", Offset = "0xBD8028", VA = "0xBD8028")]
	public void SetEAimAssitMode(EAimAssist NFPHLGPHGIK)
	{
	}

	[Token(Token = "0x60041D9")]
	[Address(RVA = "0xBD81DC", Offset = "0xBD81DC", VA = "0xBD81DC")]
	public FFNBBHKEDAE GetAimAssistOnSighting()
	{
		return null;
	}

	[Token(Token = "0x60041DB")]
	[Address(RVA = "0xBD8320", Offset = "0xBD8320", VA = "0xBD8320")]
	public CEPIKIJENLK GetResureStatus()
	{
		return null;
	}

	[Token(Token = "0x60041DF")]
	[Address(RVA = "0xBD85A0", Offset = "0xBD85A0", VA = "0xBD85A0", Slot = "94")]
	protected virtual Transform LPCNANNNHAH()
	{
		return null;
	}

	[Token(Token = "0x60041E3")]
	[Address(RVA = "0xBD89E0", Offset = "0xBD89E0", VA = "0xBD89E0")]
	public AvatarManager GetAvatarManager()
	{
		return null;
	}

	[Token(Token = "0x60041FD")]
	[Address(RVA = "0xBDA01C", Offset = "0xBDA01C", VA = "0xBDA01C")]
	public void SetAimRotation(Quaternion JGOGIAFGCFC)
	{
	}

	[Token(Token = "0x6004214")]
	[Address(RVA = "0xBDAD08", Offset = "0xBDAD08", VA = "0xBDAD08")]
	public void SetIsPendingRevive(bool EPIDFMHNHFG)
	{
	}

	[Token(Token = "0x6004229")]
	[Address(RVA = "0xBDB1E8", Offset = "0xBDB1E8", VA = "0xBDB1E8", Slot = "70")]
	public Vehicle VehicleIAmIn()
	{
		return null;
	}

	[Token(Token = "0x600422A")]
	[Address(RVA = "0xBDB240", Offset = "0xBDB240", VA = "0xBDB240")]
	public bool IsInVehicleCanFire()
	{
		return default(bool);
	}

	[Token(Token = "0x600422B")]
	[Address(RVA = "0xBDB3DC", Offset = "0xBDB3DC", VA = "0xBDB3DC", Slot = "71")]
	public bool IsPassengerInVehicleCanFire()
	{
		return default(bool);
	}

	[Token(Token = "0x6004230")]
	[Address(RVA = "0xBDB79C", Offset = "0xBDB79C", VA = "0xBDB79C")]
	public bool IsDriverInVehicleCanFire()
	{
		return default(bool);
	}

	[Token(Token = "0x6004232")]
	[Address(RVA = "0xBDA0E4", Offset = "0xBDA0E4", VA = "0xBDA0E4", Slot = "74")]
	public bool IsInCatapult()
	{
		return default(bool);
	}

	[Token(Token = "0x6004233")]
	[Address(RVA = "0xBDA198", Offset = "0xBDA198", VA = "0xBDA198")]
	public bool IsInCannon()
	{
		return default(bool);
	}

	[Token(Token = "0x6004234")]
	[Address(RVA = "0xBDBA04", Offset = "0xBDBA04", VA = "0xBDBA04")]
	public bool CanUseCannon()
	{
		return default(bool);
	}

	[Token(Token = "0x6004235")]
	[Address(RVA = "0xBDBA64", Offset = "0xBDBA64", VA = "0xBDBA64")]
	public bool IsUseSpaceShield()
	{
		return default(bool);
	}

	[Token(Token = "0x6004236")]
	[Address(RVA = "0xBDBD6C", Offset = "0xBDBD6C", VA = "0xBDBD6C")]
	public LevelCatapult GetCatapultIAmIn()
	{
		return null;
	}

	[Token(Token = "0x6004237")]
	[Address(RVA = "0xBDBDC4", Offset = "0xBDBDC4", VA = "0xBDBDC4")]
	public LevelCannon GetCannonIAmIn()
	{
		return null;
	}

	[Token(Token = "0x6004255")]
	[Address(RVA = "0xBDD13C", Offset = "0xBDD13C", VA = "0xBDD13C")]
	public bool CanHumanTireJump()
	{
		return default(bool);
	}

	[Token(Token = "0x6004258")]
	[Address(RVA = "0xBDD87C", Offset = "0xBDD87C", VA = "0xBDD87C", Slot = "56")]
	public override bool IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6004259")]
	[Address(RVA = "0xBDD8E0", Offset = "0xBDD8E0", VA = "0xBDD8E0", Slot = "57")]
	public override bool IsStreamerVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x600425A")]
	[Address(RVA = "0xBDD9D8", Offset = "0xBDD9D8", VA = "0xBDD9D8")]
	public bool IsPartialVisible(uint EBOJJLIHHCM)
	{
		return default(bool);
	}

	[Token(Token = "0x600425B")]
	[Address(RVA = "0xBDDA5C", Offset = "0xBDDA5C", VA = "0xBDDA5C", Slot = "97")]
	public virtual BaseProfileInfo PlayerBaseProfile()
	{
		return null;
	}

	[Token(Token = "0x600425C")]
	[Address(RVA = "0xBDDAB4", Offset = "0xBDDAB4", VA = "0xBDDAB4", Slot = "98")]
	public virtual bool IsWatching()
	{
		return default(bool);
	}

	[Token(Token = "0x6004265")]
	public static Player CreatePlayer<T>(Transform GOLANILPAJP, ulong HHMJNLLBELP, ulong OJHGCEHMNNI, IHAAMHPPLMG BIFFAIEPIND, bool JNLEJHIJFOP = false, [Optional] object JKBNDADENMG, bool DHENKAGPHFA = false) where T : Player
	{
		return null;
	}

	[Token(Token = "0x6004266")]
	[Address(RVA = "0xBDDD60", Offset = "0xBDDD60", VA = "0xBDDD60", Slot = "10")]
	public override void InitEntityInfo()
	{
	}

	[Token(Token = "0x6004267")]
	[Address(RVA = "0xBDDE04", Offset = "0xBDDE04", VA = "0xBDDE04")]
	public static Player_TrainingHumanTarget CreateHumanTargetPlayer(Transform GLFPMJGBGNI, IHAAMHPPLMG AAMCOABHOCD)
	{
		return null;
	}

	[Token(Token = "0x6004268")]
	[Address(RVA = "0xBDE244", Offset = "0xBDE244", VA = "0xBDE244")]
	public void CreateCapsuleHuman()
	{
	}

	[Token(Token = "0x6004269")]
	[Address(RVA = "0xBDE410", Offset = "0xBDE410", VA = "0xBDE410", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x600426A")]
	[Address(RVA = "0xBDF464", Offset = "0xBDF464", VA = "0xBDF464")]
	protected IEnumerator MMFMMGEIKII()
	{
		return null;
	}

	[Token(Token = "0x600426B")]
	[Address(RVA = "0xBDF530", Offset = "0xBDF530", VA = "0xBDF530", Slot = "99")]
	public virtual void InitWhenAvatarReady()
	{
	}

	[Token(Token = "0x6004270")]
	[Address(RVA = "0xBDF73C", Offset = "0xBDF73C", VA = "0xBDF73C")]
	public void EnableCharactorController(uint EBOJJLIHHCM, bool EDLIFKGBCMD)
	{
	}

	[Token(Token = "0x6004271")]
	[Address(RVA = "0xBDF9B8", Offset = "0xBDF9B8", VA = "0xBDF9B8")]
	public void EnableCharactorCollider(bool HPMMALDGFAB)
	{
	}

	[Token(Token = "0x6004272")]
	[Address(RVA = "0xBDFBD4", Offset = "0xBDFBD4", VA = "0xBDFBD4")]
	public void EnableCharactorAnimator(bool HPMMALDGFAB)
	{
	}

	[Token(Token = "0x6004273")]
	[Address(RVA = "0xBDFCE4", Offset = "0xBDFCE4", VA = "0xBDFCE4")]
	public void SetVisibleOnTrainingZoneChange(bool FICNJIMKAEF)
	{
	}

	[Token(Token = "0x6004274")]
	[Address(RVA = "0xBDF8D8", Offset = "0xBDF8D8", VA = "0xBDF8D8")]
	private void HNEBFIMBKJL(bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x6004275")]
	[Address(RVA = "0xBDFD70", Offset = "0xBDFD70", VA = "0xBDFD70", Slot = "100")]
	public virtual void SetVisible(uint EBOJJLIHHCM, bool EDLIFKGBCMD)
	{
	}

	[Token(Token = "0x6004276")]
	[Address(RVA = "0xBE1C10", Offset = "0xBE1C10", VA = "0xBE1C10")]
	public void RefreshVehicleAnim()
	{
	}

	[Token(Token = "0x6004277")]
	[Address(RVA = "0xBE1D8C", Offset = "0xBE1D8C", VA = "0xBE1D8C", Slot = "101")]
	protected virtual void ENOKKOIOGGN()
	{
	}

	[Token(Token = "0x6004278")]
	[Address(RVA = "0xBE1DE0", Offset = "0xBE1DE0", VA = "0xBE1DE0")]
	private bool POANGPHGLNN()
	{
		return default(bool);
	}

	[Token(Token = "0x6004279")]
	[Address(RVA = "0xBD69BC", Offset = "0xBD69BC", VA = "0xBD69BC")]
	public NPCNMJAGIKI GetInventoryManager()
	{
		return null;
	}

	[Token(Token = "0x600427A")]
	[Address(RVA = "0xBE1FB8", Offset = "0xBE1FB8", VA = "0xBE1FB8")]
	public GPBDEDFKJNA GetWeaponOnHand()
	{
		return null;
	}

	[Token(Token = "0x600427B")]
	[Address(RVA = "0xBD1300", Offset = "0xBD1300", VA = "0xBD1300")]
	public GPBDEDFKJNA GetActiveWeapon()
	{
		return null;
	}

	[Token(Token = "0x600427C")]
	[Address(RVA = "0xBE20B0", Offset = "0xBE20B0", VA = "0xBE20B0", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x600427D")]
	[Address(RVA = "0xBE21AC", Offset = "0xBE21AC", VA = "0xBE21AC")]
	protected void LLIPGNOGKPP()
	{
	}

	[Token(Token = "0x600427E")]
	[Address(RVA = "0xBE245C", Offset = "0xBE245C", VA = "0xBE245C")]
	private void DLPABGGJLJC(Transform MCNPCMHJKGK, Transform FFDHFKIMFDG)
	{
	}

	[Token(Token = "0x6004285")]
	[Address(RVA = "0xBE2F18", Offset = "0xBE2F18", VA = "0xBE2F18", Slot = "102")]
	public virtual bool HaveFlight()
	{
		return default(bool);
	}

	[Token(Token = "0x600428D")]
	[Address(RVA = "0xBE3518", Offset = "0xBE3518", VA = "0xBE3518")]
	protected Transform ADECBABGGBL()
	{
		return null;
	}

	[Token(Token = "0x600428E")]
	[Address(RVA = "0xBE36FC", Offset = "0xBE36FC", VA = "0xBE36FC", Slot = "103")]
	public virtual void InitProperties(object KGCOINAOBOH, bool HMLKNAHACCI = true)
	{
	}

	[Token(Token = "0x600428F")]
	[Address(RVA = "0xBE424C", Offset = "0xBE424C", VA = "0xBE424C")]
	protected void DOAMLHIHAOF(NILHJAFNEJL GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x6004290")]
	[Address(RVA = "0xBE4038", Offset = "0xBE4038", VA = "0xBE4038")]
	protected void HDMKLFBJANC()
	{
	}

	[Token(Token = "0x6004291")]
	[Address(RVA = "0xBE42AC", Offset = "0xBE42AC", VA = "0xBE42AC", Slot = "104")]
	protected virtual void DPLMGOJKKCM()
	{
	}

	[Token(Token = "0x6004292")]
	[Address(RVA = "0xBE66D0", Offset = "0xBE66D0", VA = "0xBE66D0", Slot = "105")]
	public virtual void UpdateShiledEffect()
	{
	}

	[Token(Token = "0x6004293")]
	[Address(RVA = "0xBE6C64", Offset = "0xBE6C64", VA = "0xBE6C64")]
	public void ShowShieldAttackedEffect(Player CNEIJLIGFEB)
	{
	}

	[Token(Token = "0x6004294")]
	[Address(RVA = "0xBE666C", Offset = "0xBE666C", VA = "0xBE666C")]
	private void CGIDCIBAEKE()
	{
	}

	[Token(Token = "0x6004295")]
	[Address(RVA = "0xBE6208", Offset = "0xBE6208", VA = "0xBE6208")]
	protected void BGIELJBHEIB()
	{
	}

	[Token(Token = "0x6004296")]
	[Address(RVA = "0xBD8B1C", Offset = "0xBD8B1C", VA = "0xBD8B1C")]
	protected void GAKOBGKCJKN()
	{
	}

	[Token(Token = "0x6004297")]
	[Address(RVA = "0xBE6DF0", Offset = "0xBE6DF0", VA = "0xBE6DF0")]
	public static bool IsLocalPlayer(ulong HHMJNLLBELP, IHAAMHPPLMG BIFFAIEPIND)
	{
		return default(bool);
	}

	[Token(Token = "0x6004298")]
	[Address(RVA = "0xBD3B24", Offset = "0xBD3B24", VA = "0xBD3B24")]
	public bool IsLocalPlayer()
	{
		return default(bool);
	}

	[Token(Token = "0x6004299")]
	[Address(RVA = "0xBE7010", Offset = "0xBE7010", VA = "0xBE7010", Slot = "106")]
	public virtual bool IsLocalTeammate()
	{
		return default(bool);
	}

	[Token(Token = "0x600429A")]
	[Address(RVA = "0xBE7264", Offset = "0xBE7264", VA = "0xBE7264")]
	public bool IsInLocalPlayerServiceGroup()
	{
		return default(bool);
	}

	[Token(Token = "0x600429B")]
	[Address(RVA = "0xBE73D8", Offset = "0xBE73D8", VA = "0xBE73D8")]
	public bool ShowWeaponSkin()
	{
		return default(bool);
	}

	[Token(Token = "0x600429C")]
	[Address(RVA = "0xBE74E8", Offset = "0xBE74E8", VA = "0xBE74E8")]
	public bool ShowSkin()
	{
		return default(bool);
	}

	[Token(Token = "0x600429D")]
	[Address(RVA = "0xBE7A0C", Offset = "0xBE7A0C", VA = "0xBE7A0C")]
	public static bool ShowSkinForQualityAndMemory()
	{
		return default(bool);
	}

	[Token(Token = "0x600429E")]
	[Address(RVA = "0xBE7BC4", Offset = "0xBE7BC4", VA = "0xBE7BC4")]
	public bool ShowFistWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x600429F")]
	[Address(RVA = "0xBE7D20", Offset = "0xBE7D20", VA = "0xBE7D20")]
	public bool ShowHandWeaponEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x60042A0")]
	[Address(RVA = "0xBE7EA8", Offset = "0xBE7EA8", VA = "0xBE7EA8")]
	public bool ShowHandWeaponFireEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x60042A1")]
	[Address(RVA = "0xBE8030", Offset = "0xBE8030", VA = "0xBE8030")]
	public bool ShowHandWeaponGunTraceEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x60042A2")]
	[Address(RVA = "0xBE8194", Offset = "0xBE8194", VA = "0xBE8194")]
	public bool ShowBackWeaponEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x60042A3")]
	[Address(RVA = "0xBE831C", Offset = "0xBE831C", VA = "0xBE831C")]
	public bool ShowClothEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x60042A4")]
	[Address(RVA = "0xBE84F4", Offset = "0xBE84F4", VA = "0xBE84F4")]
	public static bool UseHighQualityAvatar(ulong HHMJNLLBELP, IHAAMHPPLMG BIFFAIEPIND, ulong OJHGCEHMNNI)
	{
		return default(bool);
	}

	[Token(Token = "0x60042A5")]
	[Address(RVA = "0xBE8BDC", Offset = "0xBE8BDC", VA = "0xBE8BDC")]
	public bool UseHighQualityAvatar()
	{
		return default(bool);
	}

	[Token(Token = "0x60042A6")]
	[Address(RVA = "0xBE8CE8", Offset = "0xBE8CE8", VA = "0xBE8CE8")]
	public bool IsLocalObservered()
	{
		return default(bool);
	}

	[Token(Token = "0x60042A7")]
	[Address(RVA = "0xBE8E7C", Offset = "0xBE8E7C", VA = "0xBE8E7C")]
	public bool IsLocalTryingObservered()
	{
		return default(bool);
	}

	[Token(Token = "0x60042A8")]
	[Address(RVA = "0xBE9068", Offset = "0xBE9068", VA = "0xBE9068", Slot = "107")]
	public virtual void SetAI(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x60042A9")]
	[Address(RVA = "0xBE92BC", Offset = "0xBE92BC", VA = "0xBE92BC")]
	public bool IsUserControlChanged()
	{
		return default(bool);
	}

	[Token(Token = "0x60042AA")]
	[Address(RVA = "0xBE9340", Offset = "0xBE9340", VA = "0xBE9340", Slot = "67")]
	public GameObject GetGameObject()
	{
		return null;
	}

	[Token(Token = "0x60042AB")]
	[Address(RVA = "0xBE93A4", Offset = "0xBE93A4", VA = "0xBE93A4")]
	public Vector3 GetTargetDirection()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60042AC")]
	[Address(RVA = "0xBE9428", Offset = "0xBE9428", VA = "0xBE9428", Slot = "93")]
	public Vector3 GetVelocity()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60042AD")]
	[Address(RVA = "0xBE94AC", Offset = "0xBE94AC", VA = "0xBE94AC")]
	public DFKKGHCFGNM GetPhysXState()
	{
		return default(DFKKGHCFGNM);
	}

	[Token(Token = "0x60042AE")]
	[Address(RVA = "0xBE95F8", Offset = "0xBE95F8", VA = "0xBE95F8")]
	public FBCAHNCLMDC GetPhysXPose()
	{
		return default(FBCAHNCLMDC);
	}

	[Token(Token = "0x60042AF")]
	[Address(RVA = "0xBE9670", Offset = "0xBE9670", VA = "0xBE9670")]
	public bool IsCrouching()
	{
		return default(bool);
	}

	[Token(Token = "0x60042B0")]
	[Address(RVA = "0xBE96E8", Offset = "0xBE96E8", VA = "0xBE96E8")]
	private void MIEABLNHMCO()
	{
	}

	[Token(Token = "0x60042B1")]
	[Address(RVA = "0xBE9CB4", Offset = "0xBE9CB4", VA = "0xBE9CB4")]
	public void QuitRevive()
	{
	}

	[Token(Token = "0x60042B2")]
	[Address(RVA = "0xBE9E1C", Offset = "0xBE9E1C", VA = "0xBE9E1C", Slot = "108")]
	public virtual void Dead(int HEONOMOEOLN, IHAAMHPPLMG HLJDHPGGODB, bool KCHNLMEEHOP = false, bool EPIDFMHNHFG = false)
	{
	}

	[Token(Token = "0x60042B3")]
	[Address(RVA = "0xBEF144", Offset = "0xBEF144", VA = "0xBEF144", Slot = "109")]
	public virtual void UpdateController(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60042B4")]
	[Address(RVA = "0xBEF1F8", Offset = "0xBEF1F8", VA = "0xBEF1F8")]
	public void UpdateRightAxisAndDoRotation(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60042B5")]
	[Address(RVA = "0xBF0CBC", Offset = "0xBF0CBC", VA = "0xBF0CBC")]
	public void UpdateBrightness()
	{
	}

	[Token(Token = "0x60042B6")]
	[Address(RVA = "0xBF10F4", Offset = "0xBF10F4", VA = "0xBF10F4", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60042B7")]
	[Address(RVA = "0xBEF0F0", Offset = "0xBEF0F0", VA = "0xBEF0F0")]
	private void ELJKMOEOJKN()
	{
	}

	[Token(Token = "0x60042B8")]
	[Address(RVA = "0xBF1F78", Offset = "0xBF1F78", VA = "0xBF1F78")]
	protected void MPHMGBBCMDK()
	{
	}

	[Token(Token = "0x60042B9")]
	[Address(RVA = "0xBF1FCC", Offset = "0xBF1FCC", VA = "0xBF1FCC", Slot = "110")]
	public virtual void OnPlayerBeTouch()
	{
	}

	[Token(Token = "0x60042BA")]
	[Address(RVA = "0xBF22F8", Offset = "0xBF22F8", VA = "0xBF22F8")]
	public void CapsuleHumanTriggerEnter(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x60042BB")]
	[Address(RVA = "0xBF2580", Offset = "0xBF2580", VA = "0xBF2580")]
	public void CapsuleHumanTriggerExit(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x60042BC")]
	[Address(RVA = "0xBF2798", Offset = "0xBF2798", VA = "0xBF2798")]
	private bool EEOLAPHGEMP(Collider KODGAANKJBG)
	{
		return default(bool);
	}

	[Token(Token = "0x60042BD")]
	[Address(RVA = "0xBF289C", Offset = "0xBF289C", VA = "0xBF289C")]
	private bool NFPAOOBBJNB(ref EntityInfo GJMOEPKGCKO)
	{
		return default(bool);
	}

	[Token(Token = "0x60042BE")]
	[Address(RVA = "0xBF292C", Offset = "0xBF292C", VA = "0xBF292C", Slot = "111")]
	public virtual void OnTriggerEnter(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x60042BF")]
	[Address(RVA = "0xBFC05C", Offset = "0xBFC05C", VA = "0xBFC05C")]
	private void OnTriggerStay(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x60042C0")]
	[Address(RVA = "0xBFC4CC", Offset = "0xBFC4CC", VA = "0xBFC4CC")]
	public void ForceExitMusicShooingZone()
	{
	}

	[Token(Token = "0x60042C1")]
	[Address(RVA = "0xBFCADC", Offset = "0xBFCADC", VA = "0xBFCADC", Slot = "112")]
	public virtual void OnTriggerExit(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x60042C2")]
	[Address(RVA = "0xC038CC", Offset = "0xC038CC", VA = "0xC038CC")]
	public void UpdateTriggerBtns()
	{
	}

	[Token(Token = "0x60042C3")]
	[Address(RVA = "0xBFC194", Offset = "0xBFC194", VA = "0xBFC194")]
	private void KOMAGPGFMMM()
	{
	}

	[Token(Token = "0x60042C4")]
	[Address(RVA = "0xC045DC", Offset = "0xC045DC", VA = "0xC045DC")]
	public bool InSlider()
	{
		return default(bool);
	}

	[Token(Token = "0x60042C5")]
	[Address(RVA = "0xBF74A8", Offset = "0xBF74A8", VA = "0xBF74A8")]
	protected void EOLLAHNPEHI(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x60042C6")]
	[Address(RVA = "0xC02138", Offset = "0xC02138", VA = "0xC02138")]
	protected void HDIBBCNFHPF(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x60042CB")]
	[Address(RVA = "0xC046E4", Offset = "0xC046E4", VA = "0xC046E4")]
	private void ACODEINPIOJ()
	{
	}

	[Token(Token = "0x60042CC")]
	[Address(RVA = "0xC036BC", Offset = "0xC036BC", VA = "0xC036BC")]
	private void JMKFHLFIBOA()
	{
	}

	[Token(Token = "0x60042CD")]
	[Address(RVA = "0xBF8760", Offset = "0xBF8760", VA = "0xBF8760")]
	protected void JICIFKPNHFC(EntityInfo LKKPEFCCPPP, Vector3 LLOAGEMLBPF)
	{
	}

	[Token(Token = "0x60042CE")]
	[Address(RVA = "0xC06824", Offset = "0xC06824", VA = "0xC06824")]
	public bool CanUseAmmoBox()
	{
		return default(bool);
	}

	[Token(Token = "0x60042CF")]
	[Address(RVA = "0xC069E4", Offset = "0xC069E4", VA = "0xC069E4")]
	public bool CanJoinPartyGame()
	{
		return default(bool);
	}

	[Token(Token = "0x60042D0")]
	[Address(RVA = "0xC04E04", Offset = "0xC04E04", VA = "0xC04E04")]
	private void HFMCDFEIEOF()
	{
	}

	[Token(Token = "0x60042D1")]
	[Address(RVA = "0xC04C68", Offset = "0xC04C68", VA = "0xC04C68")]
	private void LIBMAPKFDLG()
	{
	}

	[Token(Token = "0x60042D2")]
	[Address(RVA = "0xC04FA0", Offset = "0xC04FA0", VA = "0xC04FA0")]
	private void KCBHFOJMFKH()
	{
	}

	[Token(Token = "0x60042D3")]
	[Address(RVA = "0xC05264", Offset = "0xC05264", VA = "0xC05264")]
	private void IJCGLIALPHN()
	{
	}

	[Token(Token = "0x60042D4")]
	[Address(RVA = "0xC05400", Offset = "0xC05400", VA = "0xC05400")]
	private void DFIICNPDJAJ()
	{
	}

	[Token(Token = "0x60042D5")]
	[Address(RVA = "0xC0559C", Offset = "0xC0559C", VA = "0xC0559C")]
	private void NKOFCOBAOHP()
	{
	}

	[Token(Token = "0x60042D6")]
	[Address(RVA = "0xC05738", Offset = "0xC05738", VA = "0xC05738")]
	private void IALMOEBOEDO()
	{
	}

	[Token(Token = "0x60042D7")]
	[Address(RVA = "0xC06CAC", Offset = "0xC06CAC", VA = "0xC06CAC")]
	public bool IsInHayric()
	{
		return default(bool);
	}

	[Token(Token = "0x60042D8")]
	[Address(RVA = "0xC058D4", Offset = "0xC058D4", VA = "0xC058D4")]
	private void EJMONKEHBFF()
	{
	}

	[Token(Token = "0x60042D9")]
	[Address(RVA = "0xC02EF8", Offset = "0xC02EF8", VA = "0xC02EF8")]
	private void DJKPCNMOHAM()
	{
	}

	[Token(Token = "0x60042DA")]
	[Address(RVA = "0xC05964", Offset = "0xC05964", VA = "0xC05964")]
	private void HOCHIBABHLB(OJCOOJEIJPD OPJKJHBKLGN)
	{
	}

	[Token(Token = "0x60042DB")]
	[Address(RVA = "0xC0640C", Offset = "0xC0640C", VA = "0xC0640C")]
	private void GHOEMLLEFCB()
	{
	}

	[Token(Token = "0x60042DC")]
	[Address(RVA = "0xC04AC8", Offset = "0xC04AC8", VA = "0xC04AC8")]
	private void NBLFJLDJGHC(EHudActionType PMGBACFJIHO)
	{
	}

	[Token(Token = "0x60042DD")]
	[Address(RVA = "0xC03440", Offset = "0xC03440", VA = "0xC03440")]
	protected void IGODEPBHPDG()
	{
	}

	[Token(Token = "0x60042DE")]
	[Address(RVA = "0xC07054", Offset = "0xC07054", VA = "0xC07054")]
	private void ACMIIEDBPGD()
	{
	}

	[Token(Token = "0x60042DF")]
	[Address(RVA = "0xC0858C", Offset = "0xC0858C", VA = "0xC0858C")]
	private void LAAMIIEHLBC()
	{
	}

	[Token(Token = "0x60042E0")]
	[Address(RVA = "0xC086EC", Offset = "0xC086EC", VA = "0xC086EC")]
	private void GBFHAIDNCNL(bool IOOECBJGKDC)
	{
	}

	[Token(Token = "0x60042E1")]
	[Address(RVA = "0xC04A60", Offset = "0xC04A60", VA = "0xC04A60")]
	private void MAHFFCLOGDP()
	{
	}

	[Token(Token = "0x60042E2")]
	[Address(RVA = "0xC02B6C", Offset = "0xC02B6C", VA = "0xC02B6C")]
	private void MAHFFCLOGDP(OFJHNKMJNGA CLJGFIOLMAK, uint IEPFELEIMFE)
	{
	}

	[Token(Token = "0x60042E3")]
	[Address(RVA = "0xC04A00", Offset = "0xC04A00", VA = "0xC04A00")]
	private void IGIOFJHFNGC()
	{
	}

	[Token(Token = "0x60042E4")]
	[Address(RVA = "0xC041A0", Offset = "0xC041A0", VA = "0xC041A0")]
	private void PGLGELCMJCH()
	{
	}

	[Token(Token = "0x60042E5")]
	[Address(RVA = "0xBF8628", Offset = "0xBF8628", VA = "0xBF8628")]
	public bool IsInTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x60042E6")]
	[Address(RVA = "0xC08EEC", Offset = "0xC08EEC", VA = "0xC08EEC")]
	public bool IsInTriggerIncludingPendingTrigger(EntityInfo GJMOEPKGCKO)
	{
		return default(bool);
	}

	[Token(Token = "0x60042E7")]
	[Address(RVA = "0xC09118", Offset = "0xC09118", VA = "0xC09118")]
	public void StopUsingItemOnHand()
	{
	}

	[Token(Token = "0x60042E8")]
	[Address(RVA = "0xBD7360", Offset = "0xBD7360", VA = "0xBD7360", Slot = "82")]
	public AAHMJHHPECM GetItemOnHand()
	{
		return null;
	}

	[Token(Token = "0x60042E9")]
	[Address(RVA = "0xC09198", Offset = "0xC09198", VA = "0xC09198")]
	public bool HasThrowingKnifeBROnHand()
	{
		return default(bool);
	}

	[Token(Token = "0x60042EA")]
	[Address(RVA = "0xC092D8", Offset = "0xC092D8", VA = "0xC092D8")]
	public int GetThrowingKnifeLegMountCount()
	{
		return default(int);
	}

	[Token(Token = "0x60042EB")]
	[Address(RVA = "0xC09440", Offset = "0xC09440", VA = "0xC09440", Slot = "83")]
	public AAHMJHHPECM GetRealItemOnHand()
	{
		return null;
	}

	[Token(Token = "0x60042EC")]
	[Address(RVA = "0xC094B8", Offset = "0xC094B8", VA = "0xC094B8")]
	public UserControlHandler GetUserControlHandler()
	{
		return null;
	}

	[Token(Token = "0x60042ED")]
	[Address(RVA = "0xC09510", Offset = "0xC09510", VA = "0xC09510", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60042EE")]
	[Address(RVA = "0xC09788", Offset = "0xC09788", VA = "0xC09788")]
	public bool IsGrounded()
	{
		return default(bool);
	}

	[Token(Token = "0x60042EF")]
	[Address(RVA = "0xC09800", Offset = "0xC09800", VA = "0xC09800", Slot = "113")]
	public virtual void UpdateAI(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60042F0")]
	[Address(RVA = "0xC09958", Offset = "0xC09958", VA = "0xC09958", Slot = "114")]
	public virtual void UpdateBehavior(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60042F1")]
	[Address(RVA = "0xC0A044", Offset = "0xC0A044", VA = "0xC0A044", Slot = "115")]
	protected virtual void LNMJFMKPKEO()
	{
	}

	[Token(Token = "0x60042F2")]
	[Address(RVA = "0xC0A6E8", Offset = "0xC0A6E8", VA = "0xC0A6E8")]
	private void BOKHKNADKOL()
	{
	}

	[Token(Token = "0x60042F3")]
	[Address(RVA = "0xC0A814", Offset = "0xC0A814", VA = "0xC0A814")]
	protected void LMICHEEPCGD()
	{
	}

	[Token(Token = "0x60042F4")]
	[Address(RVA = "0xC0AA7C", Offset = "0xC0AA7C", VA = "0xC0AA7C", Slot = "116")]
	public virtual void UpdateKinematics(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60042F5")]
	[Address(RVA = "0xC13FA8", Offset = "0xC13FA8", VA = "0xC13FA8")]
	public bool IsMoving()
	{
		return default(bool);
	}

	[Token(Token = "0x60042F6")]
	[Address(RVA = "0xC13F30", Offset = "0xC13F30", VA = "0xC13F30")]
	private void KHHKLDLHHFG(bool DCCDHMCDHJH)
	{
	}

	[Token(Token = "0x60042F7")]
	[Address(RVA = "0xC146A8", Offset = "0xC146A8", VA = "0xC146A8")]
	protected bool GKAPGHDOMJJ(Vector3 FAPNMKAAPFI)
	{
		return default(bool);
	}

	[Token(Token = "0x60042F8")]
	[Address(RVA = "0xC148D8", Offset = "0xC148D8", VA = "0xC148D8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60042F9")]
	[Address(RVA = "0xC157C4", Offset = "0xC157C4", VA = "0xC157C4")]
	protected bool KAFDBJLIHDF()
	{
		return default(bool);
	}

	[Token(Token = "0x60042FA")]
	[Address(RVA = "0xC158D4", Offset = "0xC158D4", VA = "0xC158D4")]
	protected void KNHEOJCMMOJ()
	{
	}

	[Token(Token = "0x60042FB")]
	[Address(RVA = "0xC15038", Offset = "0xC15038", VA = "0xC15038")]
	protected void BBNBBPHAGCO()
	{
	}

	[Token(Token = "0x60042FC")]
	[Address(RVA = "0xC16214", Offset = "0xC16214", VA = "0xC16214")]
	protected bool KBBJOOFNDJI(Transform BMLDFEHGDCE)
	{
		return default(bool);
	}

	[Token(Token = "0x60042FD")]
	[Address(RVA = "0xC167C0", Offset = "0xC167C0", VA = "0xC167C0")]
	protected void EPHLKDIEHDB(Transform BMLDFEHGDCE, float EBJNFHAODMP = 0f, float LFKIGLIEAOF = 0f, bool LOONMIGPEIE = false)
	{
	}

	[Token(Token = "0x60042FE")]
	[Address(RVA = "0xC16D20", Offset = "0xC16D20", VA = "0xC16D20", Slot = "117")]
	protected virtual bool ANHDPJADLOH()
	{
		return default(bool);
	}

	[Token(Token = "0x60042FF")]
	[Address(RVA = "0xC16D78", Offset = "0xC16D78", VA = "0xC16D78")]
	private void LKNAJCCBIBK(float OMAFEKBHOAA, out bool DCCFMIHLEKA, out float CGPEFIBAFAB)
	{
	}

	[Token(Token = "0x6004300")]
	[Address(RVA = "0xC17070", Offset = "0xC17070", VA = "0xC17070", Slot = "118")]
	public virtual void PostUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004301")]
	[Address(RVA = "0xC19F7C", Offset = "0xC19F7C", VA = "0xC19F7C")]
	protected void INDOOFOELNJ()
	{
	}

	[Token(Token = "0x6004302")]
	[Address(RVA = "0xBEF2A8", Offset = "0xBEF2A8", VA = "0xBEF2A8")]
	private void OJOHLBJEIJO(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004303")]
	[Address(RVA = "0xC1B640", Offset = "0xC1B640", VA = "0xC1B640")]
	private float FCMOKEPOAID(Vector3 KDLAFFALFIN, float EHHDNGCIBNF)
	{
		return default(float);
	}

	[Token(Token = "0x6004304")]
	[Address(RVA = "0xC1BA28", Offset = "0xC1BA28", VA = "0xC1BA28")]
	private float POKKAHADOBD(Vector3 KDLAFFALFIN, float EHHDNGCIBNF)
	{
		return default(float);
	}

	[Token(Token = "0x6004305")]
	[Address(RVA = "0xC1C26C", Offset = "0xC1C26C", VA = "0xC1C26C", Slot = "119")]
	public virtual void OnLandFinsish()
	{
	}

	[Token(Token = "0x6004306")]
	[Address(RVA = "0xC1CAB0", Offset = "0xC1CAB0", VA = "0xC1CAB0", Slot = "120")]
	public virtual void OnFaithFallingLandFinsish()
	{
	}

	[Token(Token = "0x6004307")]
	[Address(RVA = "0xC1CB38", Offset = "0xC1CB38", VA = "0xC1CB38")]
	public void SetHayrickOrigin(LevelHayrickOrigin DENIDDKOHJM)
	{
	}

	[Token(Token = "0x6004308")]
	[Address(RVA = "0xC1CB98", Offset = "0xC1CB98", VA = "0xC1CB98", Slot = "86")]
	public bool IsTargetFriend(OPILIBBOEAC FFDHFKIMFDG)
	{
		return default(bool);
	}

	[Token(Token = "0x6004309")]
	[Address(RVA = "0xC1CC10", Offset = "0xC1CC10", VA = "0xC1CC10", Slot = "121")]
	protected virtual bool PHPKGJIBCIK(OPILIBBOEAC FFDHFKIMFDG)
	{
		return default(bool);
	}

	[Token(Token = "0x600430A")]
	[Address(RVA = "0xC0844C", Offset = "0xC0844C", VA = "0xC0844C")]
	public Quaternion GetAimRotation()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x600430B")]
	[Address(RVA = "0xC1D304", Offset = "0xC1D304", VA = "0xC1D304")]
	public Quaternion GetAuxAimRotation()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x600430C")]
	[Address(RVA = "0xC1D380", Offset = "0xC1D380", VA = "0xC1D380")]
	public void ResetAuxAimRotation()
	{
	}

	[Token(Token = "0x600430D")]
	[Address(RVA = "0xC1D3E8", Offset = "0xC1D3E8", VA = "0xC1D3E8", Slot = "122")]
	public virtual void PauseAnimator()
	{
	}

	[Token(Token = "0x6004312")]
	[Address(RVA = "0xC1D5A0", Offset = "0xC1D5A0", VA = "0xC1D5A0", Slot = "85")]
	public bool HasHeuristicTarget()
	{
		return default(bool);
	}

	[Token(Token = "0x6004313")]
	[Address(RVA = "0xC1D798", Offset = "0xC1D798", VA = "0xC1D798", Slot = "87")]
	public bool HeuristicTargetIsFriend()
	{
		return default(bool);
	}

	[Token(Token = "0x6004314")]
	[Address(RVA = "0xC1D9A0", Offset = "0xC1D9A0", VA = "0xC1D9A0")]
	public OPILIBBOEAC GetHeuristicTarget()
	{
		return null;
	}

	[Token(Token = "0x6004315")]
	[Address(RVA = "0xC1DB00", Offset = "0xC1DB00", VA = "0xC1DB00")]
	public Vector3 GetWeaponTraceStartPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6004318")]
	[Address(RVA = "0xC1E120", Offset = "0xC1E120", VA = "0xC1E120", Slot = "123")]
	public virtual void UpdateAiming(float OPKNJGBDOBB, float OMAFEKBHOAA, bool PKPEMNPJDHA = false)
	{
	}

	[Token(Token = "0x6004319")]
	[Address(RVA = "0xC1FC54", Offset = "0xC1FC54", VA = "0xC1FC54")]
	public bool IsAmimingSelfGunShield(Collider HFBDJJDICLN)
	{
		return default(bool);
	}

	[Token(Token = "0x600431A")]
	[Address(RVA = "0xC1FF10", Offset = "0xC1FF10", VA = "0xC1FF10")]
	public bool IsAmimingSelfVehicleShield(Collider HFBDJJDICLN)
	{
		return default(bool);
	}

	[Token(Token = "0x600431B")]
	[Address(RVA = "0xC2019C", Offset = "0xC2019C", VA = "0xC2019C", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x600431C")]
	[Address(RVA = "0xC20398", Offset = "0xC20398", VA = "0xC20398", Slot = "124")]
	public virtual int TakeDamage(int KOCMLPLOILD, IHAAMHPPLMG HLJDHPGGODB, [Optional] ELMGJKHIIAA JIIJIFKKCCB, int BOEIBGAABDL = -1, [Optional] Vector3 NJMFBKNHMBP, [Optional] Vector3 DOBOBMFMKBJ, [Optional] List<float> NBKBEBFNDBE, [Optional] MKFEKBKJCKE OPINPCANMDE, uint GGIDKOBOJBB = 0u)
	{
		return default(int);
	}

	[Token(Token = "0x600431D")]
	[Address(RVA = "0xC2266C", Offset = "0xC2266C", VA = "0xC2266C", Slot = "55")]
	public override void TakeHealing(int EDEOPLNOGPP, IHAAMHPPLMG ONPMGNIIMJD, int BOEIBGAABDL, [Optional] Vector3 NJMFBKNHMBP, [Optional] Vector3 DOBOBMFMKBJ, [Optional] List<float> NBKBEBFNDBE)
	{
	}

	[Token(Token = "0x600431E")]
	[Address(RVA = "0xC231B4", Offset = "0xC231B4", VA = "0xC231B4")]
	public void ShowFireInfoInMap(byte GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x600431F")]
	[Address(RVA = "0xC221D0", Offset = "0xC221D0", VA = "0xC221D0")]
	public void PlaySpeedRoyalBGM(int BOEIBGAABDL)
	{
	}

	[Token(Token = "0x6004320")]
	[Address(RVA = "0xC23D00", Offset = "0xC23D00", VA = "0xC23D00", Slot = "125")]
	public virtual void PlayFireEffect(GPBDEDFKJNA LPGPKFMGCBG)
	{
	}

	[Token(Token = "0x6004321")]
	[Address(RVA = "0xC23D88", Offset = "0xC23D88", VA = "0xC23D88", Slot = "126")]
	public virtual void PlayCureAnimation(bool FJNDHBCJPEJ)
	{
	}

	[Token(Token = "0x6004322")]
	[Address(RVA = "0xC23E68", Offset = "0xC23E68", VA = "0xC23E68")]
	private void CGNEPMPHNLN(bool FJNDHBCJPEJ)
	{
	}

	[Token(Token = "0x6004323")]
	[Address(RVA = "0xC240DC", Offset = "0xC240DC", VA = "0xC240DC", Slot = "127")]
	public virtual void PlayMushRoomAnimation(bool FJNDHBCJPEJ)
	{
	}

	[Token(Token = "0x6004324")]
	[Address(RVA = "0xC24180", Offset = "0xC24180", VA = "0xC24180", Slot = "128")]
	public virtual void PlayRepairingAnimation(bool FJNDHBCJPEJ)
	{
	}

	[Token(Token = "0x6004325")]
	[Address(RVA = "0xC24224", Offset = "0xC24224", VA = "0xC24224", Slot = "129")]
	public virtual void PlayBombAnimation(bool FJNDHBCJPEJ, bool JDKCEEGNPLG = true)
	{
	}

	[Token(Token = "0x6004326")]
	[Address(RVA = "0xC24770", Offset = "0xC24770", VA = "0xC24770")]
	public void PlayADSTeleportAnimation()
	{
	}

	[Token(Token = "0x6004327")]
	[Address(RVA = "0xC24A1C", Offset = "0xC24A1C", VA = "0xC24A1C")]
	public void ShowADSPortalEffect(bool ODOEHEHNJOG, MOIJLENBKNL DEEGGKFDOKA)
	{
	}

	[Token(Token = "0x6004328")]
	[Address(RVA = "0xC24EF0", Offset = "0xC24EF0", VA = "0xC24EF0")]
	public void ShowADSBodyEffect(bool ODOEHEHNJOG)
	{
	}

	[Token(Token = "0x6004329")]
	[Address(RVA = "0xC24F4C", Offset = "0xC24F4C", VA = "0xC24F4C")]
	public void ShowADSWinBuffEffect(bool ODOEHEHNJOG)
	{
	}

	[Token(Token = "0x600432A")]
	[Address(RVA = "0xC24D60", Offset = "0xC24D60", VA = "0xC24D60")]
	private GameObject PLIKAJPOCCN(MOIJLENBKNL DEEGGKFDOKA)
	{
		return null;
	}

	[Token(Token = "0x600432B")]
	[Address(RVA = "0xC24FAC", Offset = "0xC24FAC", VA = "0xC24FAC")]
	public void PlayUsePacemakerAnimation(bool FJNDHBCJPEJ, uint CJDMCMOODAH = 0u)
	{
	}

	[Token(Token = "0x600432C")]
	[Address(RVA = "0xC25498", Offset = "0xC25498", VA = "0xC25498")]
	public void CreatePacemakerInAnim()
	{
	}

	[Token(Token = "0x600432D")]
	[Address(RVA = "0xC258B0", Offset = "0xC258B0", VA = "0xC258B0")]
	public void PlayUsePacemakerHeartBeatAudio()
	{
	}

	[Token(Token = "0x600432E")]
	[Address(RVA = "0xBED8DC", Offset = "0xBED8DC", VA = "0xBED8DC")]
	public void ClearPacemaker()
	{
	}

	[Token(Token = "0x600432F")]
	[Address(RVA = "0xC25A00", Offset = "0xC25A00", VA = "0xC25A00")]
	public void PlaySelfRescureGetUpEffect()
	{
	}

	[Token(Token = "0x6004330")]
	[Address(RVA = "0xC25F4C", Offset = "0xC25F4C", VA = "0xC25F4C")]
	public void PlayShootMusicTarget()
	{
	}

	[Token(Token = "0x6004331")]
	[Address(RVA = "0xBED798", Offset = "0xBED798", VA = "0xBED798")]
	public void ResetPlayerRescureReason()
	{
	}

	[Token(Token = "0x6004332")]
	[Address(RVA = "0xC25FA0", Offset = "0xC25FA0", VA = "0xC25FA0", Slot = "130")]
	public virtual void PlayPreparationAnimation(bool FJNDHBCJPEJ, EPreparationTimerType PMGBACFJIHO)
	{
	}

	[Token(Token = "0x6004333")]
	[Address(RVA = "0xC26120", Offset = "0xC26120", VA = "0xC26120", Slot = "131")]
	public virtual void StartFiring(GPBDEDFKJNA LPGPKFMGCBG)
	{
	}

	[Token(Token = "0x6004334")]
	[Address(RVA = "0xC263B8", Offset = "0xC263B8", VA = "0xC263B8", Slot = "132")]
	public virtual void StartWarmUp(GPBDEDFKJNA LPGPKFMGCBG)
	{
	}

	[Token(Token = "0x6004335")]
	[Address(RVA = "0xC26414", Offset = "0xC26414", VA = "0xC26414", Slot = "133")]
	public virtual void StopFire(GPBDEDFKJNA LPGPKFMGCBG)
	{
	}

	[Token(Token = "0x6004336")]
	[Address(RVA = "0xC2679C", Offset = "0xC2679C", VA = "0xC2679C")]
	public void OnReloadingNoBullet(GPBDEDFKJNA LPGPKFMGCBG)
	{
	}

	[Token(Token = "0x6004337")]
	[Address(RVA = "0xC267F8", Offset = "0xC267F8", VA = "0xC267F8", Slot = "134")]
	public virtual void StopCharge(GPBDEDFKJNA LPGPKFMGCBG)
	{
	}

	[Token(Token = "0x6004338")]
	[Address(RVA = "0xC26854", Offset = "0xC26854", VA = "0xC26854", Slot = "135")]
	public virtual bool GetSightingState()
	{
		return default(bool);
	}

	[Token(Token = "0x6004339")]
	[Address(RVA = "0xC26944", Offset = "0xC26944", VA = "0xC26944")]
	public PFMPPELJECF GetWeaponSightingAttachmentData()
	{
		return null;
	}

	[Token(Token = "0x600433A")]
	[Address(RVA = "0xC269BC", Offset = "0xC269BC", VA = "0xC269BC", Slot = "136")]
	public virtual bool IsSightingUIAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x600433B")]
	[Address(RVA = "0xC26AD4", Offset = "0xC26AD4", VA = "0xC26AD4")]
	public void OnAnimationVisibilityChanged(int POCENLDINHC)
	{
	}

	[Token(Token = "0x600433C")]
	[Address(RVA = "0xC26B58", Offset = "0xC26B58", VA = "0xC26B58")]
	public void OnAnimEvent(OHHHJLJHCKI HGMBMICDALC, object[] POCENLDINHC)
	{
	}

	[Token(Token = "0x600433D")]
	[Address(RVA = "0xC27714", Offset = "0xC27714", VA = "0xC27714")]
	private void DPGOIEBOIGF(bool CDPFEPBKMEI)
	{
	}

	[Token(Token = "0x600433E")]
	[Address(RVA = "0xC27BF4", Offset = "0xC27BF4", VA = "0xC27BF4")]
	private void KFGHAJEDHLG(bool PLGKHKHBADL)
	{
	}

	[Token(Token = "0x600433F")]
	[Address(RVA = "0xC27894", Offset = "0xC27894", VA = "0xC27894")]
	private void OPIIKCKHDNB(bool CCBOHNJELDL)
	{
	}

	[Token(Token = "0x6004340")]
	[Address(RVA = "0xC27DAC", Offset = "0xC27DAC", VA = "0xC27DAC", Slot = "90")]
	public void OnSightingUIStateChange(bool HNFJGOBEMKM, float HCIFNBGLHIF)
	{
	}

	[Token(Token = "0x6004341")]
	[Address(RVA = "0xC28BC4", Offset = "0xC28BC4", VA = "0xC28BC4", Slot = "137")]
	public virtual void SwapWeapon(int POFFNNMOOBM, bool GDKLMFLNNGM = false, [Optional] List<int> HACDOKBPCHJ)
	{
	}

	[Token(Token = "0x6004342")]
	[Address(RVA = "0xC28F94", Offset = "0xC28F94", VA = "0xC28F94")]
	private bool IGHCCPAFKBH(BMGBKEENCJH JPAGIDGHAAI, AAHMJHHPECM KJCJNKGIBOK)
	{
		return default(bool);
	}

	[Token(Token = "0x6004343")]
	[Address(RVA = "0xC29128", Offset = "0xC29128", VA = "0xC29128", Slot = "138")]
	public virtual void SwapWeapon(BMGBKEENCJH JPAGIDGHAAI, bool GDKLMFLNNGM = false)
	{
	}

	[Token(Token = "0x6004344")]
	[Address(RVA = "0xC295F4", Offset = "0xC295F4", VA = "0xC295F4", Slot = "139")]
	public virtual void ReloadWeapon()
	{
	}

	[Token(Token = "0x6004345")]
	[Address(RVA = "0xC29734", Offset = "0xC29734", VA = "0xC29734", Slot = "140")]
	public virtual void FullWeaponAmmo()
	{
	}

	[Token(Token = "0x6004346")]
	[Address(RVA = "0xC297AC", Offset = "0xC297AC", VA = "0xC297AC", Slot = "141")]
	public virtual void OnGrenadeStartFire()
	{
	}

	[Token(Token = "0x6004347")]
	[Address(RVA = "0xC29830", Offset = "0xC29830", VA = "0xC29830", Slot = "142")]
	public virtual void OnGrenadeEndFire()
	{
	}

	[Token(Token = "0x6004348")]
	[Address(RVA = "0xC298B4", Offset = "0xC298B4", VA = "0xC298B4", Slot = "143")]
	public virtual void OnThrowKnifeStartFire()
	{
	}

	[Token(Token = "0x6004349")]
	[Address(RVA = "0xC29938", Offset = "0xC29938", VA = "0xC29938", Slot = "144")]
	public virtual void OnThrowKnifeEndFire()
	{
	}

	[Token(Token = "0x600434A")]
	[Address(RVA = "0xC299BC", Offset = "0xC299BC", VA = "0xC299BC", Slot = "145")]
	public virtual void OnGrenadeQuitFire()
	{
	}

	[Token(Token = "0x600434B")]
	[Address(RVA = "0xC29A34", Offset = "0xC29A34", VA = "0xC29A34", Slot = "146")]
	public virtual void OnBeginPutDown()
	{
	}

	[Token(Token = "0x600434C")]
	[Address(RVA = "0xC29A88", Offset = "0xC29A88", VA = "0xC29A88", Slot = "147")]
	public virtual void OnWeaponLift(bool FNHIJNENHHM = false)
	{
	}

	[Token(Token = "0x600434D")]
	[Address(RVA = "0xC29B40", Offset = "0xC29B40", VA = "0xC29B40", Slot = "148")]
	public virtual void OnWeaponPutDown()
	{
	}

	[Token(Token = "0x600434E")]
	[Address(RVA = "0xC29BF4", Offset = "0xC29BF4", VA = "0xC29BF4", Slot = "149")]
	public virtual void OnWeaponReloadStarted(float LDBLIBDEDMH, bool GJFOOHPJCOG = false)
	{
	}

	[Token(Token = "0x600434F")]
	[Address(RVA = "0xC29CD4", Offset = "0xC29CD4", VA = "0xC29CD4", Slot = "150")]
	public virtual void OnWeaponReloadFinished(bool KIHNJGKPMPP)
	{
	}

	[Token(Token = "0x6004350")]
	[Address(RVA = "0xC29D30", Offset = "0xC29D30", VA = "0xC29D30")]
	public void OnWeaponReloadDone()
	{
	}

	[Token(Token = "0x6004351")]
	[Address(RVA = "0xC29DC4", Offset = "0xC29DC4", VA = "0xC29DC4", Slot = "151")]
	public virtual void OnSniperPullBoltStarted(float LDBLIBDEDMH)
	{
	}

	[Token(Token = "0x6004352")]
	[Address(RVA = "0xC29E64", Offset = "0xC29E64", VA = "0xC29E64", Slot = "152")]
	public virtual void OnSniperPullBoltFinished()
	{
	}

	[Token(Token = "0x6004353")]
	[Address(RVA = "0xC29EB8", Offset = "0xC29EB8", VA = "0xC29EB8")]
	public void OnSniperPullBoltDone()
	{
	}

	[Token(Token = "0x6004354")]
	[Address(RVA = "0xC29F2C", Offset = "0xC29F2C", VA = "0xC29F2C")]
	public void PlayChangeWeaponSoundInternal()
	{
	}

	[Token(Token = "0x6004355")]
	[Address(RVA = "0xC14F40", Offset = "0xC14F40", VA = "0xC14F40")]
	protected bool AIOEHOACJFL()
	{
		return default(bool);
	}

	[Token(Token = "0x6004356")]
	[Address(RVA = "0xC2A8CC", Offset = "0xC2A8CC", VA = "0xC2A8CC")]
	public void StartJumpOffAirTransporter()
	{
	}

	[Token(Token = "0x6004357")]
	[Address(RVA = "0xC2B198", Offset = "0xC2B198", VA = "0xC2B198")]
	protected void JMIMBCCIFOF()
	{
	}

	[Token(Token = "0x6004358")]
	[Address(RVA = "0xC2BB30", Offset = "0xC2BB30", VA = "0xC2BB30")]
	protected void KKANIBBAPAO()
	{
	}

	[Token(Token = "0x6004359")]
	[Address(RVA = "0xC2BC44", Offset = "0xC2BC44", VA = "0xC2BC44")]
	protected void AGMLANOELOO()
	{
	}

	[Token(Token = "0x600435A")]
	[Address(RVA = "0xC2CAA8", Offset = "0xC2CAA8", VA = "0xC2CAA8")]
	public void EquipFlight()
	{
	}

	[Token(Token = "0x600435B")]
	[Address(RVA = "0xBECF54", Offset = "0xBECF54", VA = "0xBECF54")]
	public void UnEquipFlight()
	{
	}

	[Token(Token = "0x600435C")]
	[Address(RVA = "0xC2D2E4", Offset = "0xC2D2E4", VA = "0xC2D2E4")]
	private void DNJEBLMCPOA()
	{
	}

	[Token(Token = "0x600435D")]
	[Address(RVA = "0xC2D4F0", Offset = "0xC2D4F0", VA = "0xC2D4F0", Slot = "153")]
	protected virtual void NHBCHNEHPDJ()
	{
	}

	[Token(Token = "0x600435E")]
	[Address(RVA = "0xC2D544", Offset = "0xC2D544", VA = "0xC2D544")]
	public bool IsDrivingFlight()
	{
		return default(bool);
	}

	[Token(Token = "0x600435F")]
	[Address(RVA = "0xC2D618", Offset = "0xC2D618", VA = "0xC2D618")]
	protected void AFJJLINKCLK()
	{
	}

	[Token(Token = "0x6004360")]
	[Address(RVA = "0xBECFB4", Offset = "0xBECFB4", VA = "0xBECFB4")]
	protected void AGDIMDNAEPM()
	{
	}

	[Token(Token = "0x6004361")]
	[Address(RVA = "0xC2DBB8", Offset = "0xC2DBB8", VA = "0xC2DBB8")]
	private void PFIFPCBGFNA()
	{
	}

	[Token(Token = "0x6004362")]
	[Address(RVA = "0xC2DE60", Offset = "0xC2DE60", VA = "0xC2DE60")]
	private void NAAOGCLEEKE()
	{
	}

	[Token(Token = "0x6004363")]
	[Address(RVA = "0xBECDF8", Offset = "0xBECDF8", VA = "0xBECDF8")]
	protected void NONLOIKKJFC()
	{
	}

	[Token(Token = "0x6004364")]
	[Address(RVA = "0xC2E6E4", Offset = "0xC2E6E4", VA = "0xC2E6E4")]
	public void StartSkyDiving()
	{
	}

	[Token(Token = "0x6004365")]
	[Address(RVA = "0xBD9888", Offset = "0xBD9888", VA = "0xBD9888")]
	private void MBDOEGHJNIJ()
	{
	}

	[Token(Token = "0x6004366")]
	[Address(RVA = "0xC2EFC0", Offset = "0xC2EFC0", VA = "0xC2EFC0")]
	private void CLNPBADKONF()
	{
	}

	[Token(Token = "0x6004367")]
	[Address(RVA = "0xC2C7CC", Offset = "0xC2C7CC", VA = "0xC2C7CC")]
	private bool AABGECALOGD()
	{
		return default(bool);
	}

	[Token(Token = "0x6004368")]
	[Address(RVA = "0xC2F750", Offset = "0xC2F750", VA = "0xC2F750")]
	private bool OFIHNCGMKJG()
	{
		return default(bool);
	}

	[Token(Token = "0x6004369")]
	[Address(RVA = "0xC2F3C4", Offset = "0xC2F3C4", VA = "0xC2F3C4")]
	private void HKAHMNACOOI()
	{
	}

	[Token(Token = "0x600436A")]
	[Address(RVA = "0xBDEEF4", Offset = "0xBDEEF4", VA = "0xBDEEF4")]
	private void IJDEGCAPANG()
	{
	}

	[Token(Token = "0x600436B")]
	[Address(RVA = "0xC2F96C", Offset = "0xC2F96C", VA = "0xC2F96C", Slot = "154")]
	public virtual float GetExtraSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x600436C")]
	[Address(RVA = "0xC2F9C4", Offset = "0xC2F9C4", VA = "0xC2F9C4")]
	private void BAJOHJCBLKF()
	{
	}

	[Token(Token = "0x600436D")]
	[Address(RVA = "0xBDF098", Offset = "0xBDF098", VA = "0xBDF098")]
	private void AMJEOPKAHGO()
	{
	}

	[Token(Token = "0x600436E")]
	[Address(RVA = "0xC2FD14", Offset = "0xC2FD14", VA = "0xC2FD14")]
	public void StopParachuting(bool LOJHBGCFEFL = true)
	{
	}

	[Token(Token = "0x600436F")]
	[Address(RVA = "0xC308EC", Offset = "0xC308EC", VA = "0xC308EC")]
	private void JPJJJMCKOJG()
	{
	}

	[Token(Token = "0x6004370")]
	[Address(RVA = "0xC30CB0", Offset = "0xC30CB0", VA = "0xC30CB0")]
	private void FCNPJEJBKLL()
	{
	}

	[Token(Token = "0x6004371")]
	[Address(RVA = "0xC2AF9C", Offset = "0xC2AF9C", VA = "0xC2AF9C")]
	private bool EFGMIIKLBEK()
	{
		return default(bool);
	}

	[Token(Token = "0x6004372")]
	[Address(RVA = "0xC30E58", Offset = "0xC30E58", VA = "0xC30E58")]
	private void ECDADPJAKPK()
	{
	}

	[Token(Token = "0x6004373")]
	[Address(RVA = "0xC31834", Offset = "0xC31834", VA = "0xC31834")]
	protected void EECDAGCKOBL(float OJGNBJELDEM)
	{
	}

	[Token(Token = "0x6004374")]
	[Address(RVA = "0xC31AB4", Offset = "0xC31AB4", VA = "0xC31AB4")]
	protected void PPINIOCDBBO(float OJGNBJELDEM)
	{
	}

	[Token(Token = "0x6004375")]
	[Address(RVA = "0xC31D34", Offset = "0xC31D34", VA = "0xC31D34")]
	public void StartParachuting()
	{
	}

	[Token(Token = "0x6004376")]
	[Address(RVA = "0xC314A8", Offset = "0xC314A8", VA = "0xC314A8")]
	private void IALNNBOKJHM()
	{
	}

	[Token(Token = "0x6004377")]
	[Address(RVA = "0xC3279C", Offset = "0xC3279C", VA = "0xC3279C")]
	public void PlayHypeFireEffect(int HPCPFHJBNIJ, int DCCLEJKNHKN = -1)
	{
	}

	[Token(Token = "0x6004378")]
	[Address(RVA = "0xC32E38", Offset = "0xC32E38", VA = "0xC32E38")]
	private void CLHNGLMIONN()
	{
	}

	[Token(Token = "0x6004379")]
	[Address(RVA = "0xC3327C", Offset = "0xC3327C", VA = "0xC3327C")]
	protected void OKJEFDPMEJH(int DCCLEJKNHKN, int BACIIIEPDLO)
	{
	}

	[Token(Token = "0x600437A")]
	[Address(RVA = "0xC337E0", Offset = "0xC337E0", VA = "0xC337E0", Slot = "155")]
	public virtual void BeforeSwitchAnimController(bool DLEBGIFAMJG = false)
	{
	}

	[Token(Token = "0x600437B")]
	[Address(RVA = "0xC33890", Offset = "0xC33890", VA = "0xC33890", Slot = "156")]
	public virtual void SwitchAnimController()
	{
	}

	[Token(Token = "0x600437C")]
	[Address(RVA = "0xC33B40", Offset = "0xC33B40", VA = "0xC33B40")]
	public void SetAsDriver()
	{
	}

	[Token(Token = "0x600437D")]
	[Address(RVA = "0xC33BC8", Offset = "0xC33BC8", VA = "0xC33BC8", Slot = "157")]
	public virtual void PlayChangeVehicleSeatAnimation(bool IPMICKKDKMJ)
	{
	}

	[Token(Token = "0x600437E")]
	[Address(RVA = "0xC33CB8", Offset = "0xC33CB8", VA = "0xC33CB8")]
	public void ShowBagPack()
	{
	}

	[Token(Token = "0x600437F")]
	[Address(RVA = "0xC33D6C", Offset = "0xC33D6C", VA = "0xC33D6C")]
	public void HideBagPack()
	{
	}

	[Token(Token = "0x6004380")]
	[Address(RVA = "0xC33E24", Offset = "0xC33E24", VA = "0xC33E24")]
	public void OnStartChangeWeapon(GPBDEDFKJNA LPLPBJGAPHK, float PFNGHMIADLB = 1f)
	{
	}

	[Token(Token = "0x6004381")]
	[Address(RVA = "0xC34340", Offset = "0xC34340", VA = "0xC34340", Slot = "158")]
	public virtual void ResizeSniperFireCollider(float LCMKCHOILIB, float BAJIOEGPDAN, float DCGFBHEMOGF = -1f, bool NCOONPPOKJO = false)
	{
	}

	[Token(Token = "0x6004382")]
	[Address(RVA = "0xC34794", Offset = "0xC34794", VA = "0xC34794", Slot = "159")]
	public virtual void ResizeCapsuleCollider(float LCMKCHOILIB, float BAJIOEGPDAN = -1f, float LDAODGKLLGC = 0f)
	{
	}

	[Token(Token = "0x6004383")]
	[Address(RVA = "0xBE117C", Offset = "0xBE117C", VA = "0xBE117C")]
	protected void DGFEGFFJLKL(bool HGMBMICDALC)
	{
	}

	[Token(Token = "0x6004384")]
	[Address(RVA = "0xBE59D4", Offset = "0xBE59D4", VA = "0xBE59D4")]
	public void OnFireModeChanged(bool IKPLNEOMFCJ)
	{
	}

	[Token(Token = "0x6004385")]
	[Address(RVA = "0xC34AC4", Offset = "0xC34AC4", VA = "0xC34AC4", Slot = "160")]
	public virtual Transform GetHeadTF()
	{
		return null;
	}

	[Token(Token = "0x6004386")]
	[Address(RVA = "0xC34C90", Offset = "0xC34C90", VA = "0xC34C90", Slot = "161")]
	public virtual Transform GetHipTF()
	{
		return null;
	}

	[Token(Token = "0x6004387")]
	[Address(RVA = "0xC34E5C", Offset = "0xC34E5C", VA = "0xC34E5C", Slot = "162")]
	protected virtual Vector3 MPDOJMMECAF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6004388")]
	[Address(RVA = "0xC3513C", Offset = "0xC3513C", VA = "0xC3513C", Slot = "163")]
	public virtual Transform GetLeftAnkleTF()
	{
		return null;
	}

	[Token(Token = "0x6004389")]
	[Address(RVA = "0xC3525C", Offset = "0xC3525C", VA = "0xC3525C", Slot = "164")]
	public virtual Transform GetRightAnkleTF()
	{
		return null;
	}

	[Token(Token = "0x600438A")]
	[Address(RVA = "0xC3537C", Offset = "0xC3537C", VA = "0xC3537C", Slot = "165")]
	public virtual Transform GetLeftToeTF()
	{
		return null;
	}

	[Token(Token = "0x600438B")]
	[Address(RVA = "0xC3549C", Offset = "0xC3549C", VA = "0xC3549C", Slot = "166")]
	public virtual Transform GetRightToeTF()
	{
		return null;
	}

	[Token(Token = "0x600438C")]
	[Address(RVA = "0xC355BC", Offset = "0xC355BC", VA = "0xC355BC", Slot = "167")]
	public virtual Vector3 GetCharacterControllerTopPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600438D")]
	[Address(RVA = "0xBF7C8C", Offset = "0xBF7C8C", VA = "0xBF7C8C")]
	public float GetCharacterHeight()
	{
		return default(float);
	}

	[Token(Token = "0x600438E")]
	[Address(RVA = "0xC3567C", Offset = "0xC3567C", VA = "0xC3567C")]
	public float GetCharacterCenterY()
	{
		return default(float);
	}

	[Token(Token = "0x600438F")]
	[Address(RVA = "0xC1F9C4", Offset = "0xC1F9C4", VA = "0xC1F9C4")]
	private OPILIBBOEAC GKHECDLGAJA()
	{
		return null;
	}

	[Token(Token = "0x6004390")]
	[Address(RVA = "0xC35708", Offset = "0xC35708", VA = "0xC35708")]
	public int GetWeaponZoomAmplifier()
	{
		return default(int);
	}

	[Token(Token = "0x6004391")]
	[Address(RVA = "0xC1A16C", Offset = "0xC1A16C", VA = "0xC1A16C")]
	private Vector3 FGMAPCMEDOA()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6004392")]
	[Address(RVA = "0xC35838", Offset = "0xC35838", VA = "0xC35838", Slot = "168")]
	public virtual bool RequestRescureTarget(IHAAMHPPLMG FFDHFKIMFDG)
	{
		return default(bool);
	}

	[Token(Token = "0x6004393")]
	[Address(RVA = "0xC35D18", Offset = "0xC35D18", VA = "0xC35D18", Slot = "169")]
	public virtual bool RequestStopResure()
	{
		return default(bool);
	}

	[Token(Token = "0x6004394")]
	[Address(RVA = "0xC35DA4", Offset = "0xC35DA4", VA = "0xC35DA4")]
	protected void GFBKBGOPNDF()
	{
	}

	[Token(Token = "0x6004395")]
	[Address(RVA = "0xC05B78", Offset = "0xC05B78", VA = "0xC05B78")]
	public void RequestUseTeleportDoor(uint IEPFELEIMFE)
	{
	}

	[Token(Token = "0x6004396")]
	[Address(RVA = "0xC363BC", Offset = "0xC363BC", VA = "0xC363BC")]
	private void FACFMIBCGEL(LevelTeleportDoor EJKDLCBJMOG, uint IEPFELEIMFE)
	{
	}

	[Token(Token = "0x6004397")]
	[Address(RVA = "0xC36094", Offset = "0xC36094", VA = "0xC36094")]
	public bool CheckCanUseTeleportDoor()
	{
		return default(bool);
	}

	[Token(Token = "0x6004398")]
	[Address(RVA = "0xC36710", Offset = "0xC36710", VA = "0xC36710")]
	public bool CheckCanUseFerrisWheel()
	{
		return default(bool);
	}

	[Token(Token = "0x600439A")]
	[Address(RVA = "0xC36A80", Offset = "0xC36A80", VA = "0xC36A80", Slot = "170")]
	public virtual void RequestPlayEmote4Plant(OFJHNKMJNGA CLJGFIOLMAK, uint IEPFELEIMFE)
	{
	}

	[Token(Token = "0x600439B")]
	[Address(RVA = "0xC36E40", Offset = "0xC36E40", VA = "0xC36E40", Slot = "171")]
	public virtual void RequestStoreInWareHouse(uint IEPFELEIMFE)
	{
	}

	[Token(Token = "0x600439C")]
	[Address(RVA = "0xC36E9C", Offset = "0xC36E9C", VA = "0xC36E9C", Slot = "172")]
	public virtual void RequestStopStoringInWarehouse()
	{
	}

	[Token(Token = "0x600439D")]
	[Address(RVA = "0xC36EF0", Offset = "0xC36EF0", VA = "0xC36EF0", Slot = "173")]
	public virtual void RequestOpenTreasury()
	{
	}

	[Token(Token = "0x600439E")]
	[Address(RVA = "0xC36F44", Offset = "0xC36F44", VA = "0xC36F44", Slot = "174")]
	public virtual void RequestOpenTimingTreasureBox()
	{
	}

	[Token(Token = "0x600439F")]
	[Address(RVA = "0xC36F98", Offset = "0xC36F98", VA = "0xC36F98", Slot = "175")]
	public virtual void RequestHayrickJump()
	{
	}

	[Token(Token = "0x60043A0")]
	[Address(RVA = "0xC36FEC", Offset = "0xC36FEC", VA = "0xC36FEC", Slot = "176")]
	public virtual void RequestStopEmote4Plant()
	{
	}

	[Token(Token = "0x60043A1")]
	[Address(RVA = "0xC37058", Offset = "0xC37058", VA = "0xC37058", Slot = "177")]
	public virtual void StopPlayEmotion()
	{
	}

	[Token(Token = "0x60043A2")]
	[Address(RVA = "0xC37154", Offset = "0xC37154", VA = "0xC37154", Slot = "178")]
	public virtual void RequestSyncStopEmotion(bool DOKIPIBOMOI = false)
	{
	}

	[Token(Token = "0x60043A3")]
	[Address(RVA = "0xC37294", Offset = "0xC37294", VA = "0xC37294", Slot = "179")]
	public virtual void StopEmote4Plant()
	{
	}

	[Token(Token = "0x60043A4")]
	[Address(RVA = "0xC37398", Offset = "0xC37398", VA = "0xC37398")]
	public void RequestEnterMusicShootZone(uint IDNEFEOPGIF)
	{
	}

	[Token(Token = "0x60043A5")]
	[Address(RVA = "0xC374BC", Offset = "0xC374BC", VA = "0xC374BC")]
	public void RequestEnterSoloDance()
	{
	}

	[Token(Token = "0x60043A6")]
	[Address(RVA = "0xC37930", Offset = "0xC37930", VA = "0xC37930")]
	public void RequestSoloDanceReady()
	{
	}

	[Token(Token = "0x60043A7")]
	[Address(RVA = "0xC37A38", Offset = "0xC37A38", VA = "0xC37A38")]
	public void RequestQuitSoloDance()
	{
	}

	[Token(Token = "0x60043A8")]
	[Address(RVA = "0xC37B40", Offset = "0xC37B40", VA = "0xC37B40")]
	public void RequestInviteSoloDanceOpponent(bool JPAMDNJCDHB)
	{
	}

	[Token(Token = "0x60043A9")]
	[Address(RVA = "0xBFC90C", Offset = "0xBFC90C", VA = "0xBFC90C")]
	public void RequestExitMusicShootZone(uint IDNEFEOPGIF, bool EBOJJLIHHCM = false)
	{
	}

	[Token(Token = "0x60043AA")]
	[Address(RVA = "0xC37CE0", Offset = "0xC37CE0", VA = "0xC37CE0", Slot = "180")]
	public virtual void RequestOpenRangeShop(uint IEPFELEIMFE)
	{
	}

	[Token(Token = "0x60043AB")]
	[Address(RVA = "0xC37FFC", Offset = "0xC37FFC", VA = "0xC37FFC", Slot = "181")]
	public virtual void RequestPray4EscortBoss(uint IEPFELEIMFE)
	{
	}

	[Token(Token = "0x60043AC")]
	[Address(RVA = "0xC3842C", Offset = "0xC3842C", VA = "0xC3842C", Slot = "182")]
	public virtual void RequestStopPraying4EscortBoss()
	{
	}

	[Token(Token = "0x60043AD")]
	[Address(RVA = "0xC38480", Offset = "0xC38480", VA = "0xC38480", Slot = "183")]
	public virtual void OnEscortBossStatusChanged()
	{
	}

	[Token(Token = "0x60043AE")]
	[Address(RVA = "0xC38694", Offset = "0xC38694", VA = "0xC38694", Slot = "184")]
	public virtual void RequestGetOnFerrisWheel()
	{
	}

	[Token(Token = "0x60043AF")]
	[Address(RVA = "0xC38BD0", Offset = "0xC38BD0", VA = "0xC38BD0", Slot = "185")]
	public virtual void RequestGetOffFerrisWheel()
	{
	}

	[Token(Token = "0x60043B0")]
	[Address(RVA = "0xC38F20", Offset = "0xC38F20", VA = "0xC38F20")]
	public void RequestEnterServerMiniGame(uint MAPEMGAINLD)
	{
	}

	[Token(Token = "0x60043B1")]
	[Address(RVA = "0xC39120", Offset = "0xC39120", VA = "0xC39120")]
	public void RequestGiveSnowball(uint EEAIIFLPEMM)
	{
	}

	[Token(Token = "0x60043B2")]
	[Address(RVA = "0xC39254", Offset = "0xC39254", VA = "0xC39254")]
	public bool CanWeaponCombine(GPBDEDFKJNA JDBHLIJFKOH)
	{
		return default(bool);
	}

	[Token(Token = "0x60043B3")]
	[Address(RVA = "0xC393CC", Offset = "0xC393CC", VA = "0xC393CC", Slot = "186")]
	public virtual void DoUpdateActionState(EAcationState FNECNAAOMEG, EPreparationTimerType JCLPFENICLD, float LEBOAIEJCPJ)
	{
	}

	[Token(Token = "0x60043B4")]
	[Address(RVA = "0xC39464", Offset = "0xC39464", VA = "0xC39464")]
	public void MountWeaponGameObject(GPBDEDFKJNA LPLPBJGAPHK, bool NJGHGBPCOCL)
	{
	}

	[Token(Token = "0x60043B5")]
	[Address(RVA = "0xC39A94", Offset = "0xC39A94", VA = "0xC39A94")]
	public void MountWeaponGameObject(GPBDEDFKJNA LPLPBJGAPHK)
	{
	}

	[Token(Token = "0x60043B6")]
	[Address(RVA = "0xC1BFEC", Offset = "0xC1BFEC", VA = "0xC1BFEC")]
	public bool IsFreeMove()
	{
		return default(bool);
	}

	[Token(Token = "0x60043B7")]
	[Address(RVA = "0xC3A12C", Offset = "0xC3A12C", VA = "0xC3A12C")]
	public bool IsFiring()
	{
		return default(bool);
	}

	[Token(Token = "0x60043B8")]
	[Address(RVA = "0xC3A1C8", Offset = "0xC3A1C8", VA = "0xC3A1C8")]
	public bool IsHoldingFireForSingleShot()
	{
		return default(bool);
	}

	[Token(Token = "0x60043B9")]
	[Address(RVA = "0xC3A264", Offset = "0xC3A264", VA = "0xC3A264")]
	public bool IsSniperPullingBolt()
	{
		return default(bool);
	}

	[Token(Token = "0x60043BA")]
	[Address(RVA = "0xC3A2F8", Offset = "0xC3A2F8", VA = "0xC3A2F8")]
	public GPBDEDFKJNA.ENBHOKKHLPG GetWeaponType()
	{
		return default(GPBDEDFKJNA.ENBHOKKHLPG);
	}

	[Token(Token = "0x60043BB")]
	[Address(RVA = "0xC3A3C0", Offset = "0xC3A3C0", VA = "0xC3A3C0")]
	public int GetWeaponSubType()
	{
		return default(int);
	}

	[Token(Token = "0x60043BC")]
	[Address(RVA = "0xC3A488", Offset = "0xC3A488", VA = "0xC3A488")]
	protected void FEJJMKNPOKH(bool GHLKDNNNICJ = true)
	{
	}

	[Token(Token = "0x60043BD")]
	[Address(RVA = "0xC3A614", Offset = "0xC3A614", VA = "0xC3A614")]
	private void KNOIEMFKNNH(bool EODCBFKKMIB)
	{
	}

	[Token(Token = "0x60043BE")]
	[Address(RVA = "0xC3A958", Offset = "0xC3A958", VA = "0xC3A958", Slot = "187")]
	public virtual void OnGetOnFerrisWheel(LevelFerrisWheel NLDLLCIMJGH, byte NCLKIGNAEMK, byte FNJFBBAGJGF)
	{
	}

	[Token(Token = "0x60043BF")]
	[Address(RVA = "0xC3ABB0", Offset = "0xC3ABB0", VA = "0xC3ABB0", Slot = "188")]
	public virtual void OnGetOffFerrisWheel(byte NCLKIGNAEMK, byte FNJFBBAGJGF)
	{
	}

	[Token(Token = "0x60043C0")]
	[Address(RVA = "0xC3ADC8", Offset = "0xC3ADC8", VA = "0xC3ADC8")]
	protected void MLPIEADEOIF()
	{
	}

	[Token(Token = "0x60043C1")]
	[Address(RVA = "0xC3AF4C", Offset = "0xC3AF4C", VA = "0xC3AF4C", Slot = "189")]
	public virtual void OnGetOnVehicle(Vehicle JOGHOHLEJFL)
	{
	}

	[Token(Token = "0x60043C2")]
	[Address(RVA = "0xC3C130", Offset = "0xC3C130", VA = "0xC3C130")]
	public Vector3 GetOffVehiclePosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60043C3")]
	[Address(RVA = "0xC3D660", Offset = "0xC3D660", VA = "0xC3D660")]
	public Vector3 GetOffChairPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60043C4")]
	[Address(RVA = "0xC3DEE4", Offset = "0xC3DEE4", VA = "0xC3DEE4")]
	public void OnLeaderPosChange(float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60043C5")]
	[Address(RVA = "0xC3DFEC", Offset = "0xC3DFEC", VA = "0xC3DFEC", Slot = "190")]
	public virtual void OnGetOffVehicle()
	{
	}

	[Token(Token = "0x60043C6")]
	[Address(RVA = "0xC3EDE8", Offset = "0xC3EDE8", VA = "0xC3EDE8")]
	public bool GetOnStropPrecheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60043C7")]
	[Address(RVA = "0xC3F0D0", Offset = "0xC3F0D0", VA = "0xC3F0D0", Slot = "191")]
	public virtual void OnGetOnStrop(LevelStrop GDMPEEPJPPG, float DDCDEMHFABG)
	{
	}

	[Token(Token = "0x60043C8")]
	[Address(RVA = "0xC4066C", Offset = "0xC4066C", VA = "0xC4066C", Slot = "192")]
	public virtual void OnGetOffStrop(float MHLMCIHJALP)
	{
	}

	[Token(Token = "0x60043C9")]
	[Address(RVA = "0xC41248", Offset = "0xC41248", VA = "0xC41248")]
	public void OnSceneEditLookMode()
	{
	}

	[Token(Token = "0x60043CA")]
	[Address(RVA = "0xC412E8", Offset = "0xC412E8", VA = "0xC412E8")]
	public void OnSceneEditUpdateTransform(bool LIEKNHHHKDC = false)
	{
	}

	[Token(Token = "0x60043CB")]
	[Address(RVA = "0xC41B10", Offset = "0xC41B10", VA = "0xC41B10")]
	public void OnSceneEditFreeMode()
	{
	}

	[Token(Token = "0x60043CC")]
	[Address(RVA = "0xC41C7C", Offset = "0xC41C7C", VA = "0xC41C7C")]
	public void OnSceneEditLockMode()
	{
	}

	[Token(Token = "0x60043CD")]
	[Address(RVA = "0xC41DE8", Offset = "0xC41DE8", VA = "0xC41DE8")]
	public void OnSceneEditPutDown()
	{
	}

	[Token(Token = "0x60043CE")]
	[Address(RVA = "0xC40F0C", Offset = "0xC40F0C", VA = "0xC40F0C")]
	private void AKCBKALIAIN()
	{
	}

	[Token(Token = "0x60043CF")]
	[Address(RVA = "0xC42044", Offset = "0xC42044", VA = "0xC42044", Slot = "78")]
	public bool HasGrapplingHook()
	{
		return default(bool);
	}

	[Token(Token = "0x60043D0")]
	[Address(RVA = "0xC4217C", Offset = "0xC4217C", VA = "0xC4217C", Slot = "80")]
	public bool HasVMEHook()
	{
		return default(bool);
	}

	[Token(Token = "0x60043D1")]
	[Address(RVA = "0xBECCA4", Offset = "0xBECCA4", VA = "0xBECCA4", Slot = "79")]
	public bool HasHook()
	{
		return default(bool);
	}

	[Token(Token = "0x60043D2")]
	[Address(RVA = "0xC422B4", Offset = "0xC422B4", VA = "0xC422B4", Slot = "75")]
	public bool IsOnGrapplingHook()
	{
		return default(bool);
	}

	[Token(Token = "0x60043D3")]
	[Address(RVA = "0xC03ED0", Offset = "0xC03ED0", VA = "0xC03ED0", Slot = "76")]
	public bool IsOnHook()
	{
		return default(bool);
	}

	[Token(Token = "0x60043D4")]
	[Address(RVA = "0xC42350", Offset = "0xC42350", VA = "0xC42350", Slot = "77")]
	public bool IsOnVMEHook()
	{
		return default(bool);
	}

	[Token(Token = "0x60043D5")]
	[Address(RVA = "0xC423EC", Offset = "0xC423EC", VA = "0xC423EC")]
	public void OnGrapplingHookSpawned(LevelGrapplingHook BJCKGAJPCIJ)
	{
	}

	[Token(Token = "0x60043D6")]
	[Address(RVA = "0xC42458", Offset = "0xC42458", VA = "0xC42458")]
	public void OnGrapplingHookHooked()
	{
	}

	[Token(Token = "0x60043D9")]
	[Address(RVA = "0xBECD80", Offset = "0xBECD80", VA = "0xBECD80")]
	public void OnGrapplingHookDestroyed()
	{
	}

	[Token(Token = "0x60043DA")]
	[Address(RVA = "0xC424DC", Offset = "0xC424DC", VA = "0xC424DC")]
	public void GetOffGrapplingHook()
	{
	}

	[Token(Token = "0x60043DB")]
	[Address(RVA = "0xC42560", Offset = "0xC42560", VA = "0xC42560")]
	public void OnGrapplingHookReEnter(Vector3 GFJJOEJMNON)
	{
	}

	[Token(Token = "0x60043DC")]
	[Address(RVA = "0xC42620", Offset = "0xC42620", VA = "0xC42620")]
	public void StartOnGrapplingHook()
	{
	}

	[Token(Token = "0x60043DD")]
	[Address(RVA = "0xC430A8", Offset = "0xC430A8", VA = "0xC430A8")]
	public void StopOnGrapplingHook()
	{
	}

	[Token(Token = "0x60043DE")]
	[Address(RVA = "0xC42C28", Offset = "0xC42C28", VA = "0xC42C28")]
	public void AddGrapplingHookGunEfeect(bool ILDNPPIHOMD)
	{
	}

	[Token(Token = "0x60043DF")]
	[Address(RVA = "0xC43554", Offset = "0xC43554", VA = "0xC43554")]
	public void OnStartFaithJuming()
	{
	}

	[Token(Token = "0x60043E0")]
	[Address(RVA = "0xC435D0", Offset = "0xC435D0", VA = "0xC435D0")]
	public void StartFaithJumping()
	{
	}

	[Token(Token = "0x60043E1")]
	[Address(RVA = "0xC43B84", Offset = "0xC43B84", VA = "0xC43B84")]
	public void OnFaithJumpingLand()
	{
	}

	[Token(Token = "0x60043E2")]
	[Address(RVA = "0xC4402C", Offset = "0xC4402C", VA = "0xC4402C")]
	public void StopFaithJumping()
	{
	}

	[Token(Token = "0x60043E3")]
	[Address(RVA = "0xBDE798", Offset = "0xBDE798", VA = "0xBDE798")]
	private void HKABNIGEFAM()
	{
	}

	[Token(Token = "0x60043E4")]
	[Address(RVA = "0xC445A8", Offset = "0xC445A8", VA = "0xC445A8")]
	public void AddWeaponImpactEffectToPool(ResourceID OBMONKFFGGI, GameObject ECINOMEHBKA)
	{
	}

	[Token(Token = "0x60043E5")]
	[Address(RVA = "0xC44808", Offset = "0xC44808", VA = "0xC44808", Slot = "92")]
	public void OnReusableObjectRecycled(ResourceID ODNIHGABFJA, GameObject ECINOMEHBKA)
	{
	}

	[Token(Token = "0x60043E6")]
	[Address(RVA = "0xBE1424", Offset = "0xBE1424", VA = "0xBE1424")]
	private void PMOMJMGILGF()
	{
	}

	[Token(Token = "0x60043E7")]
	[Address(RVA = "0xBE161C", Offset = "0xBE161C", VA = "0xBE161C")]
	private void KGLBHKBMKDO()
	{
	}

	[Token(Token = "0x60043E8")]
	[Address(RVA = "0xC44A54", Offset = "0xC44A54", VA = "0xC44A54")]
	public void StartJumpOffStrop(bool JLHGJLGFPNM)
	{
	}

	[Token(Token = "0x60043E9")]
	[Address(RVA = "0xC365FC", Offset = "0xC365FC", VA = "0xC365FC")]
	public bool IsFalling()
	{
		return default(bool);
	}

	[Token(Token = "0x60043EA")]
	[Address(RVA = "0xBEC3E0", Offset = "0xBEC3E0", VA = "0xBEC3E0", Slot = "72")]
	public bool IsOnStrop()
	{
		return default(bool);
	}

	[Token(Token = "0x60043EB")]
	[Address(RVA = "0xC44DDC", Offset = "0xC44DDC", VA = "0xC44DDC")]
	public bool IsStropState()
	{
		return default(bool);
	}

	[Token(Token = "0x60043EC")]
	[Address(RVA = "0xBF8554", Offset = "0xBF8554", VA = "0xBF8554", Slot = "73")]
	public bool IsOnChair()
	{
		return default(bool);
	}

	[Token(Token = "0x60043ED")]
	[Address(RVA = "0xC44E64", Offset = "0xC44E64", VA = "0xC44E64")]
	public FerrisWheelSeatGroup GetFerrisTriggerIAmIn()
	{
		return null;
	}

	[Token(Token = "0x60043EE")]
	[Address(RVA = "0xC44EBC", Offset = "0xC44EBC", VA = "0xC44EBC", Slot = "81")]
	public LevelStrop GetStropIAmOn()
	{
		return null;
	}

	[Token(Token = "0x60043EF")]
	[Address(RVA = "0xBEC30C", Offset = "0xBEC30C", VA = "0xBEC30C", Slot = "69")]
	public bool IsInVehicle()
	{
		return default(bool);
	}

	[Token(Token = "0x60043F0")]
	[Address(RVA = "0xBDC914", Offset = "0xBDC914", VA = "0xBDC914")]
	public Vehicle GetVehicleIAmIn()
	{
		return null;
	}

	[Token(Token = "0x60043F1")]
	[Address(RVA = "0xC44F14", Offset = "0xC44F14", VA = "0xC44F14")]
	public void ApplyVechileControl(COGIEJGPDDD AGGIFAEGEPA, Vector3 HAIAPHFNAIP)
	{
	}

	[Token(Token = "0x60043F2")]
	[Address(RVA = "0xC2A080", Offset = "0xC2A080", VA = "0xC2A080")]
	public GameObject PlayAshot(ResourceID IDNEFEOPGIF, bool ELOGCJLPBKI = true, float AIFHEJMAIFP = 1f, [Optional] ResourceID IBPEKMGNANK, bool JMFIHKELDED = false, EAudioEngineType DLBAILHGELB = EAudioEngineType.eUnity, bool PDPACCCGECN = false, bool DAKAECPEMAI = false, int AEMNIFDEIHM = -1, SwitchBase[] CIMBOBJEPKH)
	{
		return null;
	}

	[Token(Token = "0x60043F3")]
	[Address(RVA = "0xC4510C", Offset = "0xC4510C", VA = "0xC4510C")]
	public GameObject PlayAshotWithSwitches(ResourceID IDNEFEOPGIF, bool MIDFGODOKAL, SwitchBase[] CIMBOBJEPKH)
	{
		return null;
	}

	[Token(Token = "0x60043F4")]
	[Address(RVA = "0xC45584", Offset = "0xC45584", VA = "0xC45584")]
	public GameObject PlayAshotWithSwitches(ResourceID IDNEFEOPGIF, SwitchBase[] CIMBOBJEPKH)
	{
		return null;
	}

	[Token(Token = "0x60043F5")]
	[Address(RVA = "0xC45610", Offset = "0xC45610", VA = "0xC45610", Slot = "66")]
	public List<Vector3> GetBoundingBoxList()
	{
		return null;
	}

	[Token(Token = "0x60043F6")]
	[Address(RVA = "0xC458F4", Offset = "0xC458F4", VA = "0xC458F4", Slot = "23")]
	protected override void OnUpdateVisibleStateByStreamer(Vector3 MKGCDPNKMOB, Vector3 OANAHFHPBNB)
	{
	}

	[Token(Token = "0x60043F7")]
	[Address(RVA = "0xC45AAC", Offset = "0xC45AAC", VA = "0xC45AAC", Slot = "61")]
	public Vector3 GetCameraTrackableEntityPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60043F8")]
	[Address(RVA = "0xC45C4C", Offset = "0xC45C4C", VA = "0xC45C4C", Slot = "63")]
	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x60043F9")]
	[Address(RVA = "0xC45CCC", Offset = "0xC45CCC", VA = "0xC45CCC", Slot = "193")]
	public virtual Vector3 GetCameraTrackableEntityTopPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60043FA")]
	[Address(RVA = "0xC45E14", Offset = "0xC45E14", VA = "0xC45E14", Slot = "64")]
	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	[Token(Token = "0x60043FB")]
	[Address(RVA = "0xC45E78", Offset = "0xC45E78", VA = "0xC45E78", Slot = "65")]
	public bool IsCameraTrackableEntityAlive()
	{
		return default(bool);
	}

	[Token(Token = "0x60043FC")]
	[Address(RVA = "0xC46028", Offset = "0xC46028", VA = "0xC46028", Slot = "194")]
	public virtual bool IsOutOfControl()
	{
		return default(bool);
	}

	[Token(Token = "0x60043FD")]
	[Address(RVA = "0xC460BC", Offset = "0xC460BC", VA = "0xC460BC", Slot = "195")]
	public virtual bool IsLocalPlayerOutOfControlNeedUpdataAimRotaion()
	{
		return default(bool);
	}

	[Token(Token = "0x60043FE")]
	[Address(RVA = "0xC46114", Offset = "0xC46114", VA = "0xC46114", Slot = "196")]
	public virtual bool NeedTickWhenDead()
	{
		return default(bool);
	}

	[Token(Token = "0x60043FF")]
	[Address(RVA = "0xC46180", Offset = "0xC46180", VA = "0xC46180")]
	public void SetDriverSteeringAngle(float BLHEBBCODLC)
	{
	}

	[Token(Token = "0x6004400")]
	[Address(RVA = "0xC46220", Offset = "0xC46220", VA = "0xC46220")]
	public void SetHasDriverForAim(float BLHEBBCODLC)
	{
	}

	[Token(Token = "0x6004401")]
	[Address(RVA = "0xC462C0", Offset = "0xC462C0", VA = "0xC462C0")]
	private ResourceID KBGOGGEFADN()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6004402")]
	[Address(RVA = "0xC46480", Offset = "0xC46480", VA = "0xC46480")]
	public bool HasCustomAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6004409")]
	[Address(RVA = "0xC469C4", Offset = "0xC469C4", VA = "0xC469C4", Slot = "197")]
	public virtual bool RequestPlayCustomAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600440A")]
	[Address(RVA = "0xC4733C", Offset = "0xC4733C", VA = "0xC4733C")]
	public void SpawnBattleFlagOnHand()
	{
	}

	[Token(Token = "0x600440B")]
	[Address(RVA = "0xC474FC", Offset = "0xC474FC", VA = "0xC474FC")]
	protected void BJDEIKLANCD()
	{
	}

	[Token(Token = "0x600440C")]
	[Address(RVA = "0xC2735C", Offset = "0xC2735C", VA = "0xC2735C")]
	protected void DIKKBMEEEOL()
	{
	}

	[Token(Token = "0x600440D")]
	[Address(RVA = "0xC47968", Offset = "0xC47968", VA = "0xC47968")]
	protected Vector3 NCCKNPDMJHP()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600440E")]
	[Address(RVA = "0xC47BB4", Offset = "0xC47BB4", VA = "0xC47BB4")]
	public GameObject GetBattleFlagOnGround()
	{
		return null;
	}

	[Token(Token = "0x600440F")]
	[Address(RVA = "0xC47C24", Offset = "0xC47C24", VA = "0xC47C24")]
	public void ClearOnGroundBattleFlagRef()
	{
	}

	[Token(Token = "0x6004410")]
	[Address(RVA = "0xC47C80", Offset = "0xC47C80", VA = "0xC47C80")]
	public void ChangedBattleFlagToGround()
	{
	}

	[Token(Token = "0x6004411")]
	[Address(RVA = "0xC481AC", Offset = "0xC481AC", VA = "0xC481AC", Slot = "198")]
	public virtual bool RequestUseBattleFlag()
	{
		return default(bool);
	}

	[Token(Token = "0x6004412")]
	[Address(RVA = "0xC48284", Offset = "0xC48284", VA = "0xC48284")]
	protected void GAIMDDGHDKJ()
	{
	}

	[Token(Token = "0x6004413")]
	[Address(RVA = "0xC27938", Offset = "0xC27938", VA = "0xC27938")]
	private void GGCOCMBOHNA()
	{
	}

	[Token(Token = "0x6004414")]
	[Address(RVA = "0xC275E8", Offset = "0xC275E8", VA = "0xC275E8")]
	public void StopAnimEfects(bool CFDIGBCIEON = false)
	{
	}

	[Token(Token = "0x6004415")]
	[Address(RVA = "0xC483C0", Offset = "0xC483C0", VA = "0xC483C0")]
	public void ResetClothEffectEmoteShowMaskVisibility()
	{
	}

	[Token(Token = "0x6004416")]
	[Address(RVA = "0xC48834", Offset = "0xC48834", VA = "0xC48834")]
	public uint GetNowPlayeAvatarId()
	{
		return default(uint);
	}

	[Token(Token = "0x6004417")]
	[Address(RVA = "0xC46DF8", Offset = "0xC46DF8", VA = "0xC46DF8")]
	public void PlayCustomAnimation(sbyte OECMLDILLJN = 0)
	{
	}

	[Token(Token = "0x6004418")]
	[Address(RVA = "0xC48A2C", Offset = "0xC48A2C", VA = "0xC48A2C", Slot = "199")]
	public virtual bool RequestPlayEmotionAnimation(uint IMBFPICKFHM = 1u, float KPCJADGMEJG = 0f)
	{
		return default(bool);
	}

	[Token(Token = "0x6004419")]
	[Address(RVA = "0xC49788", Offset = "0xC49788", VA = "0xC49788", Slot = "200")]
	public virtual bool CanPlayEmotion()
	{
		return default(bool);
	}

	[Token(Token = "0x600441A")]
	[Address(RVA = "0xC49A84", Offset = "0xC49A84", VA = "0xC49A84")]
	public AnimationRuntimeHandle PlayAnimation(ResourceID MFNEABEJJCB, bool ILOIBNIHGPM = false)
	{
		return null;
	}

	[Token(Token = "0x600441B")]
	[Address(RVA = "0xC49C54", Offset = "0xC49C54", VA = "0xC49C54")]
	public void UpdateBuffBehaivor(CJKJKAEMMAO LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x600441C")]
	[Address(RVA = "0xC50554", Offset = "0xC50554", VA = "0xC50554")]
	public void CancelPreparation()
	{
	}

	[Token(Token = "0x600441D")]
	[Address(RVA = "0xC4EFF4", Offset = "0xC4EFF4", VA = "0xC4EFF4")]
	private void EMLPOJLFOBD(float LEBOAIEJCPJ)
	{
	}

	[Token(Token = "0x600441E")]
	[Address(RVA = "0xC4F6CC", Offset = "0xC4F6CC", VA = "0xC4F6CC")]
	private void MGOPCBNEDNO()
	{
	}

	[Token(Token = "0x600441F")]
	[Address(RVA = "0xBF1D90", Offset = "0xBF1D90", VA = "0xBF1D90")]
	protected void FPIEKKEHKFB(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004420")]
	[Address(RVA = "0xBF1B18", Offset = "0xBF1B18", VA = "0xBF1B18")]
	private void HBFBPCNKPIN()
	{
	}

	[Token(Token = "0x6004421")]
	[Address(RVA = "0xBEDD18", Offset = "0xBEDD18", VA = "0xBEDD18")]
	private void JJEDBOONCAG(bool ODOEHEHNJOG)
	{
	}

	[Token(Token = "0x6004422")]
	[Address(RVA = "0xBEE150", Offset = "0xBEE150", VA = "0xBEE150")]
	public void ShowBooyahGuyBuffEffect(bool ODOEHEHNJOG)
	{
	}

	[Token(Token = "0x6004423")]
	[Address(RVA = "0xC50914", Offset = "0xC50914", VA = "0xC50914")]
	private void NHEIOFOLEOE(UMAData AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6004424")]
	[Address(RVA = "0xBEE664", Offset = "0xBEE664", VA = "0xBEE664")]
	private void IEEMKHNHDKE(bool ODOEHEHNJOG, bool JDBPBKHLBFG = true, bool LBGNACHEJPP = true)
	{
	}

	[Token(Token = "0x6004425")]
	[Address(RVA = "0xC5099C", Offset = "0xC5099C", VA = "0xC5099C")]
	public void SwitchEffect(UMAData.EffectType INJCOCBCFNM)
	{
	}

	[Token(Token = "0x6004426")]
	[Address(RVA = "0xC4EB50", Offset = "0xC4EB50", VA = "0xC4EB50")]
	public void ShowSpeedUpEffect(bool ODOEHEHNJOG)
	{
	}

	[Token(Token = "0x6004427")]
	[Address(RVA = "0xC4E8F4", Offset = "0xC4E8F4", VA = "0xC4E8F4")]
	private void EOEPMCFDAEA(bool EDCBODJMHJI)
	{
	}

	[Token(Token = "0x6004428")]
	[Address(RVA = "0xBEEBB0", Offset = "0xBEEBB0", VA = "0xBEEBB0")]
	public void ShowEnergyStoneBuffEffect(bool ODOEHEHNJOG, ResourceID MHMPNKIIODD)
	{
	}

	[Token(Token = "0x6004429")]
	[Address(RVA = "0xC4FBEC", Offset = "0xC4FBEC", VA = "0xC4FBEC")]
	private void FBEKCOGLHGE(bool GIKMGIJCDOP, CBIKNJDAGLO JMEHJCCMLAL)
	{
	}

	[Token(Token = "0x600442A")]
	[Address(RVA = "0xC49014", Offset = "0xC49014", VA = "0xC49014")]
	public void PlayEmotionAnimation(uint IMBFPICKFHM, float KPCJADGMEJG = 0f, uint KLFDACDKGHH = 0u)
	{
	}

	[Token(Token = "0x600442B")]
	[Address(RVA = "0xC50B10", Offset = "0xC50B10", VA = "0xC50B10")]
	public void LeadEmote(uint MJKNGMDNEAJ)
	{
	}

	[Token(Token = "0x600442C")]
	[Address(RVA = "0xC50EA8", Offset = "0xC50EA8", VA = "0xC50EA8")]
	public void FollowEmote(IHAAMHPPLMG KCBGGCKHIGA)
	{
	}

	[Token(Token = "0x600442D")]
	[Address(RVA = "0xC51258", Offset = "0xC51258", VA = "0xC51258")]
	public uint GetPlayLeadEmoteTickCnt()
	{
		return default(uint);
	}

	[Token(Token = "0x600442E")]
	[Address(RVA = "0xC484BC", Offset = "0xC484BC", VA = "0xC484BC")]
	private void OOFPGOHIFKK()
	{
	}

	[Token(Token = "0x600442F")]
	[Address(RVA = "0xC487B4", Offset = "0xC487B4", VA = "0xC487B4")]
	private void FCFIFHBMAEN()
	{
	}

	[Token(Token = "0x6004430")]
	[Address(RVA = "0xBF7D04", Offset = "0xBF7D04", VA = "0xBF7D04")]
	private void NOJOCINAIBM(LevelDoor JEGOMJCNILO)
	{
	}

	[Token(Token = "0x6004431")]
	[Address(RVA = "0xC03F6C", Offset = "0xC03F6C", VA = "0xC03F6C")]
	private void PFCCNLMMAGC(LevelDoor JEGOMJCNILO)
	{
	}

	[Token(Token = "0x6004432")]
	[Address(RVA = "0xC02454", Offset = "0xC02454", VA = "0xC02454")]
	private void EOIHJPDAMHI(LevelDoor JEGOMJCNILO)
	{
	}

	[Token(Token = "0x6004433")]
	[Address(RVA = "0xC512B0", Offset = "0xC512B0", VA = "0xC512B0")]
	public void SetExternalWeapon(KCMNBMDPNAK JDBHLIJFKOH)
	{
	}

	[Token(Token = "0x6004434")]
	[Address(RVA = "0xC24064", Offset = "0xC24064", VA = "0xC24064")]
	public HMNOKCEINKD GetCombinedWeapon()
	{
		return null;
	}

	[Token(Token = "0x6004435")]
	[Address(RVA = "0xC5135C", Offset = "0xC5135C", VA = "0xC5135C")]
	public bool CanCombineWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x6004436")]
	[Address(RVA = "0xBE5AE8", Offset = "0xBE5AE8", VA = "0xBE5AE8")]
	protected void JOLIAOCIMHE(int EIKCFIDCCMM)
	{
	}

	[Token(Token = "0x6004437")]
	[Address(RVA = "0xBE132C", Offset = "0xBE132C", VA = "0xBE132C")]
	protected GameObject CAPBJIHPPFH()
	{
		return null;
	}

	[Token(Token = "0x6004438")]
	[Address(RVA = "0xC513D4", Offset = "0xC513D4", VA = "0xC513D4")]
	protected void LNDMGAFECMD(int BLEAICPKPGL)
	{
	}

	[Token(Token = "0x6004439")]
	[Address(RVA = "0xC51C3C", Offset = "0xC51C3C", VA = "0xC51C3C")]
	protected void HMKGIEKJCJH(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600443A")]
	[Address(RVA = "0xC52120", Offset = "0xC52120", VA = "0xC52120")]
	protected void PEEBIJOOMNJ(MNNBCGMPHJF.PNNDOLFEBEL KJINKEBEBNG, int EIKCFIDCCMM)
	{
	}

	[Token(Token = "0x600443B")]
	[Address(RVA = "0xC52410", Offset = "0xC52410", VA = "0xC52410")]
	protected void KIKMCKIBECF(int EIKCFIDCCMM)
	{
	}

	[Token(Token = "0x600443C")]
	[Address(RVA = "0xC528B0", Offset = "0xC528B0", VA = "0xC528B0", Slot = "201")]
	public virtual void PlayBigHeadHypeEffect()
	{
	}

	[Token(Token = "0x600443D")]
	[Address(RVA = "0xC52918", Offset = "0xC52918", VA = "0xC52918")]
	private void KFCMCNOJKLC()
	{
	}

	[Token(Token = "0x600443E")]
	[Address(RVA = "0xC52C6C", Offset = "0xC52C6C", VA = "0xC52C6C")]
	public void PlaySwimmingSurfSound(bool CHADOJMOHFJ)
	{
	}

	[Token(Token = "0x600443F")]
	[Address(RVA = "0xC52F5C", Offset = "0xC52F5C", VA = "0xC52F5C")]
	public void PlaySurfEffect(ResourceID FCMOICILFBP)
	{
	}

	[Token(Token = "0x6004440")]
	[Address(RVA = "0xC53190", Offset = "0xC53190", VA = "0xC53190")]
	public void DelayEquipBoard()
	{
	}

	[Token(Token = "0x6004441")]
	[Address(RVA = "0xC532D0", Offset = "0xC532D0", VA = "0xC532D0")]
	public void StopEquipBoardCoroutine()
	{
	}

	[Token(Token = "0x6004442")]
	[Address(RVA = "0xC53204", Offset = "0xC53204", VA = "0xC53204")]
	private IEnumerator BHKKPNLLLCE()
	{
		return null;
	}

	[Token(Token = "0x6004443")]
	[Address(RVA = "0xC53348", Offset = "0xC53348", VA = "0xC53348")]
	public void StartCheckBooyahEmote()
	{
	}

	[Token(Token = "0x6004444")]
	[Address(RVA = "0xBE99E0", Offset = "0xBE99E0", VA = "0xBE99E0")]
	public void StopCheckBooyahEmote(bool MALFDKAPNJI = true)
	{
	}

	[Token(Token = "0x6004445")]
	[Address(RVA = "0xC5343C", Offset = "0xC5343C", VA = "0xC5343C")]
	private IEnumerator AEIPFBNKHNE()
	{
		return null;
	}

	[Token(Token = "0x6004446")]
	[Address(RVA = "0xC53508", Offset = "0xC53508", VA = "0xC53508", Slot = "202")]
	protected virtual bool DNGFIJPMFNM()
	{
		return default(bool);
	}

	[Token(Token = "0x6004447")]
	[Address(RVA = "0xC53560", Offset = "0xC53560", VA = "0xC53560")]
	public void SetObservered(bool EBOJJLIHHCM)
	{
	}

	[Token(Token = "0x6004449")]
	[Address(RVA = "0xC53714", Offset = "0xC53714", VA = "0xC53714")]
	public void UsedRedEnvelope()
	{
	}

	[Token(Token = "0x600444A")]
	[Address(RVA = "0xBF8054", Offset = "0xBF8054", VA = "0xBF8054")]
	public void OnEnterDamageZone(LevelDamageZone BFBMOMCNAHC)
	{
	}

	[Token(Token = "0x600444B")]
	[Address(RVA = "0xC026D4", Offset = "0xC026D4", VA = "0xC026D4")]
	public void OnExitDamageZone(LevelDamageZone BFBMOMCNAHC)
	{
	}

	[Token(Token = "0x600444D")]
	[Address(RVA = "0xC537D0", Offset = "0xC537D0", VA = "0xC537D0")]
	public void SetVehicleVisible()
	{
	}

	[Token(Token = "0x600444E")]
	[Address(RVA = "0xC53844", Offset = "0xC53844", VA = "0xC53844")]
	public void DebugPlayerVisibilityInfo()
	{
	}

	[Token(Token = "0x600444F")]
	[Address(RVA = "0xC53B84", Offset = "0xC53B84", VA = "0xC53B84")]
	public void StartPendingRevive(FJNGPCLOJHC LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004450")]
	[Address(RVA = "0xC54308", Offset = "0xC54308", VA = "0xC54308")]
	public void StopPendingRevive(bool KNCEOGOLNFD)
	{
	}

	[Token(Token = "0x6004451")]
	[Address(RVA = "0xC54E98", Offset = "0xC54E98", VA = "0xC54E98")]
	public void ReviveInitState(Vector3 ACCOJJMKKPM, Quaternion JGOGIAFGCFC, uint DDFGMFGPDEK)
	{
	}

	[Token(Token = "0x6004452")]
	[Address(RVA = "0xC5542C", Offset = "0xC5542C", VA = "0xC5542C")]
	private void EKBFEIFLJMN()
	{
	}

	[Token(Token = "0x6004453")]
	[Address(RVA = "0xBED034", Offset = "0xBED034", VA = "0xBED034")]
	protected void CNAPGMNMAEJ()
	{
	}

	[Token(Token = "0x6004454")]
	[Address(RVA = "0xC554B4", Offset = "0xC554B4", VA = "0xC554B4")]
	protected void IEIJFBGINGO()
	{
	}

	[Token(Token = "0x6004455")]
	[Address(RVA = "0xC55668", Offset = "0xC55668", VA = "0xC55668", Slot = "203")]
	public virtual void ReviveInitMotionState(Vector3 ACCOJJMKKPM, Quaternion JGOGIAFGCFC, uint DDFGMFGPDEK)
	{
	}

	[Token(Token = "0x6004456")]
	[Address(RVA = "0xC55348", Offset = "0xC55348", VA = "0xC55348")]
	public void ReviveClearDamageZone()
	{
	}

	[Token(Token = "0x6004457")]
	[Address(RVA = "0xC55910", Offset = "0xC55910", VA = "0xC55910")]
	protected void BKNIENBDLJE()
	{
	}

	[Token(Token = "0x6004458")]
	[Address(RVA = "0xC55C2C", Offset = "0xC55C2C", VA = "0xC55C2C")]
	public void OnGetInCatapult(LevelCatapult BBOLNOPGKNE)
	{
	}

	[Token(Token = "0x6004459")]
	[Address(RVA = "0xBEC4B4", Offset = "0xBEC4B4", VA = "0xBEC4B4")]
	public void OnGetOutCatapult(LevelCatapult BBOLNOPGKNE)
	{
	}

	[Token(Token = "0x600445A")]
	[Address(RVA = "0xC5617C", Offset = "0xC5617C", VA = "0xC5617C")]
	public void OnGetInCannon(LevelCannon CBGDNCBALOD)
	{
	}

	[Token(Token = "0x600445B")]
	[Address(RVA = "0xBEC814", Offset = "0xBEC814", VA = "0xBEC814")]
	public void OnGetOutCannon(LevelCannon CBGDNCBALOD)
	{
	}

	[Token(Token = "0x600445C")]
	[Address(RVA = "0xC56780", Offset = "0xC56780", VA = "0xC56780")]
	public void OnStartSkyFalling(Vector3 HODJGPBPGDH, uint FDKNILEDMPG)
	{
	}

	[Token(Token = "0x600445D")]
	[Address(RVA = "0xC56AC4", Offset = "0xC56AC4", VA = "0xC56AC4")]
	public void OnStartPlatformJumping(Vector3 HODJGPBPGDH, uint FDKNILEDMPG)
	{
	}

	[Token(Token = "0x600445E")]
	[Address(RVA = "0xC56E08", Offset = "0xC56E08", VA = "0xC56E08")]
	public void OnCatapultLaunch()
	{
	}

	[Token(Token = "0x600445F")]
	[Address(RVA = "0xC5739C", Offset = "0xC5739C", VA = "0xC5739C")]
	public void OnStopCatapultFalling()
	{
	}

	[Token(Token = "0x6004460")]
	[Address(RVA = "0xBE1E78", Offset = "0xBE1E78", VA = "0xBE1E78")]
	public bool IsCatapultFalling()
	{
		return default(bool);
	}

	[Token(Token = "0x6004461")]
	[Address(RVA = "0xC57554", Offset = "0xC57554", VA = "0xC57554")]
	public void ShowCatapultFallingTailTraceLine()
	{
	}

	[Token(Token = "0x6004462")]
	[Address(RVA = "0xC57774", Offset = "0xC57774", VA = "0xC57774")]
	public void RemoveCatapultFallingTailTraceLine()
	{
	}

	[Token(Token = "0x6004463")]
	[Address(RVA = "0xC578D8", Offset = "0xC578D8", VA = "0xC578D8")]
	public void PlayChangeClothEffect()
	{
	}

	[Token(Token = "0x6004464")]
	[Address(RVA = "0xC57234", Offset = "0xC57234", VA = "0xC57234")]
	private void HAHHELIFCJA()
	{
	}

	[Token(Token = "0x6004465")]
	[Address(RVA = "0xC57D94", Offset = "0xC57D94", VA = "0xC57D94")]
	private void AFFFMLKFPFN()
	{
	}

	[Token(Token = "0x6004468")]
	[Address(RVA = "0xC57F90", Offset = "0xC57F90", VA = "0xC57F90")]
	public void OnGodStateCome(bool GHDIEEIHBCK, float OCKCJAFOINK)
	{
	}

	[Token(Token = "0x6004469")]
	[Address(RVA = "0xC19948", Offset = "0xC19948", VA = "0xC19948")]
	private void BFFIFDONEEL(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600446A")]
	[Address(RVA = "0xC4E6CC", Offset = "0xC4E6CC", VA = "0xC4E6CC")]
	private void DIBEAJNLBCO(bool JLPFGHIEHGJ = true)
	{
	}

	[Token(Token = "0x600446B")]
	[Address(RVA = "0xC58464", Offset = "0xC58464", VA = "0xC58464")]
	public GameObject PlayEffect(ResourceID OBMONKFFGGI, [Optional] Transform ACICLMFFFOA)
	{
		return null;
	}

	[Token(Token = "0x600446C")]
	[Address(RVA = "0xC58904", Offset = "0xC58904", VA = "0xC58904", Slot = "204")]
	public virtual void UpdatePendingReviveState(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600446D")]
	[Address(RVA = "0xC04974", Offset = "0xC04974", VA = "0xC04974")]
	protected void JKHFBGPMNPL(OFJHNKMJNGA CLJGFIOLMAK, uint IEPFELEIMFE)
	{
	}

	[Token(Token = "0x600446E")]
	[Address(RVA = "0xC02AE0", Offset = "0xC02AE0", VA = "0xC02AE0")]
	protected void GLOKINIKGFH(OFJHNKMJNGA CLJGFIOLMAK, uint IEPFELEIMFE)
	{
	}

	[Token(Token = "0x600446F")]
	[Address(RVA = "0xC589BC", Offset = "0xC589BC", VA = "0xC589BC")]
	protected void MDDKNBGIGGP(OFJHNKMJNGA CLJGFIOLMAK, uint IEPFELEIMFE, bool KEJJJHEBNLF)
	{
	}

	[Token(Token = "0x6004470")]
	[Address(RVA = "0xC58C48", Offset = "0xC58C48", VA = "0xC58C48")]
	private void MLHBFNBLAPI(LevelChair COFMFDFDICP)
	{
	}

	[Token(Token = "0x6004471")]
	[Address(RVA = "0xC58ED4", Offset = "0xC58ED4", VA = "0xC58ED4")]
	public void OnGetOnChair(LevelChair COFMFDFDICP)
	{
	}

	[Token(Token = "0x6004472")]
	[Address(RVA = "0xC58FC8", Offset = "0xC58FC8", VA = "0xC58FC8", Slot = "205")]
	public virtual void OnGetOffChair(LevelChair COFMFDFDICP)
	{
	}

	[Token(Token = "0x6004473")]
	[Address(RVA = "0xC59124", Offset = "0xC59124", VA = "0xC59124")]
	protected void EHKBIKJHIHI(GPGBALKIDJK PHEJDNJONIL)
	{
	}

	[Token(Token = "0x6004474")]
	[Address(RVA = "0xC59198", Offset = "0xC59198", VA = "0xC59198")]
	protected void EIIOFJOMING(GPGBALKIDJK PHEJDNJONIL)
	{
	}

	[Token(Token = "0x6004475")]
	[Address(RVA = "0xC5920C", Offset = "0xC5920C", VA = "0xC5920C")]
	protected bool CBOKAJBOGEK(GPGBALKIDJK PHEJDNJONIL)
	{
		return default(bool);
	}

	[Token(Token = "0x6004476")]
	[Address(RVA = "0xC59288", Offset = "0xC59288", VA = "0xC59288")]
	protected float LLCLNHIIDOG(GPGBALKIDJK PHEJDNJONIL)
	{
		return default(float);
	}

	[Token(Token = "0x6004477")]
	[Address(RVA = "0xC592FC", Offset = "0xC592FC", VA = "0xC592FC")]
	protected float FIHCOIOGNOB(GPGBALKIDJK PHEJDNJONIL)
	{
		return default(float);
	}

	[Token(Token = "0x6004478")]
	[Address(RVA = "0xBE5D18", Offset = "0xBE5D18", VA = "0xBE5D18")]
	protected void EDOHONPKCMP()
	{
	}

	[Token(Token = "0x6004479")]
	[Address(RVA = "0xC59378", Offset = "0xC59378", VA = "0xC59378")]
	protected void EHNENKLGGEJ()
	{
	}

	[Token(Token = "0x600447A")]
	[Address(RVA = "0xC593DC", Offset = "0xC593DC", VA = "0xC593DC")]
	public bool IsInNoHeadShotState()
	{
		return default(bool);
	}

	[Token(Token = "0x600447B")]
	[Address(RVA = "0xBE5E4C", Offset = "0xBE5E4C", VA = "0xBE5E4C")]
	private void BIGBIJAOIAG()
	{
	}

	[Token(Token = "0x600447C")]
	[Address(RVA = "0xC59440", Offset = "0xC59440", VA = "0xC59440")]
	public void RefreshCrouchScatterState()
	{
	}

	[Token(Token = "0x600447D")]
	[Address(RVA = "0xC595E0", Offset = "0xC595E0", VA = "0xC595E0")]
	public void StopCrouchScatterState()
	{
	}

	[Token(Token = "0x600447E")]
	[Address(RVA = "0xC1BE10", Offset = "0xC1BE10", VA = "0xC1BE10")]
	private bool DFAJGJIJAMC()
	{
		return default(bool);
	}

	[Token(Token = "0x600447F")]
	[Address(RVA = "0xC59644", Offset = "0xC59644", VA = "0xC59644")]
	private bool NIDOKHKLDAN()
	{
		return default(bool);
	}

	[Token(Token = "0x6004480")]
	[Address(RVA = "0xC1BE88", Offset = "0xC1BE88", VA = "0xC1BE88")]
	private void NOEKBCDOFAF(ref Vector3 KDLAFFALFIN, float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004481")]
	[Address(RVA = "0xC597FC", Offset = "0xC597FC", VA = "0xC597FC")]
	public void OnCronchToStandOrJump()
	{
	}

	[Token(Token = "0x6004482")]
	[Address(RVA = "0xC59888", Offset = "0xC59888", VA = "0xC59888")]
	public bool GetMeshBounds(ref Bounds LPJBDMAACKB)
	{
		return default(bool);
	}

	[Token(Token = "0x6004483")]
	[Address(RVA = "0xBE5F9C", Offset = "0xBE5F9C", VA = "0xBE5F9C")]
	private void GHLLGIJGBEB()
	{
	}

	[Token(Token = "0x6004484")]
	[Address(RVA = "0xBDF240", Offset = "0xBDF240", VA = "0xBDF240")]
	private void EMNLJIENEBB()
	{
	}

	[Token(Token = "0x6004485")]
	[Address(RVA = "0xC2B8BC", Offset = "0xC2B8BC", VA = "0xC2B8BC")]
	private void OFABAECCNCM()
	{
	}

	[Token(Token = "0x6004486")]
	[Address(RVA = "0xBDEC7C", Offset = "0xBDEC7C", VA = "0xBDEC7C")]
	private void DMCJJEBIJFH()
	{
	}

	[Token(Token = "0x6004487")]
	[Address(RVA = "0xC59998", Offset = "0xC59998", VA = "0xC59998")]
	private void GALOPPFGGBA()
	{
	}

	[Token(Token = "0x6004488")]
	[Address(RVA = "0xC599EC", Offset = "0xC599EC", VA = "0xC599EC")]
	private void CFMAIINHIBN()
	{
	}

	[Token(Token = "0x6004489")]
	[Address(RVA = "0xC59A40", Offset = "0xC59A40", VA = "0xC59A40")]
	public void Set1PEffect()
	{
	}

	[Token(Token = "0x600448A")]
	[Address(RVA = "0xC59B4C", Offset = "0xC59B4C", VA = "0xC59B4C")]
	public void Set3PEffect()
	{
	}

	[Token(Token = "0x600448B")]
	[Address(RVA = "0xC59C58", Offset = "0xC59C58", VA = "0xC59C58")]
	public bool HasEpicClothesActionEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600448C")]
	[Address(RVA = "0xC59D58", Offset = "0xC59D58", VA = "0xC59D58")]
	public void RequestPlayEpicClothesActionEffect()
	{
	}

	[Token(Token = "0x600448D")]
	[Address(RVA = "0xC59E6C", Offset = "0xC59E6C", VA = "0xC59E6C")]
	public void PlayEpicClothesActionEffect(sbyte OECMLDILLJN = 0)
	{
	}

	[Token(Token = "0x600448E")]
	[Address(RVA = "0xC59F94", Offset = "0xC59F94", VA = "0xC59F94")]
	public void BombModeRemoveBomb()
	{
	}

	[Token(Token = "0x600448F")]
	[Address(RVA = "0xBF8328", Offset = "0xBF8328", VA = "0xBF8328")]
	private void BAKBIOHIFPB(LevelEmote ONBDKOPIIHL)
	{
	}

	[Token(Token = "0x6004490")]
	[Address(RVA = "0xC02DCC", Offset = "0xC02DCC", VA = "0xC02DCC")]
	private void PIIAMNGLDJL(LevelEmote ONBDKOPIIHL)
	{
	}

	[Token(Token = "0x6004491")]
	[Address(RVA = "0xC27A10", Offset = "0xC27A10", VA = "0xC27A10")]
	private void NADCALNFPJA()
	{
	}

	[Token(Token = "0x6004492")]
	[Address(RVA = "0xC065A8", Offset = "0xC065A8", VA = "0xC065A8")]
	private void LFAGJGBPKDP(BaseLevelObject AIFDEOPLDJM)
	{
	}

	[Token(Token = "0x6004493")]
	[Address(RVA = "0xC035B0", Offset = "0xC035B0", VA = "0xC035B0")]
	private void PCLFDJNPPHE()
	{
	}

	[Token(Token = "0x6004494")]
	[Address(RVA = "0xC5A4F4", Offset = "0xC5A4F4", VA = "0xC5A4F4", Slot = "206")]
	public virtual void ForceUpdateAnimatorUMAChangeCallBack(UMAData AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6004495")]
	[Address(RVA = "0xC5A6CC", Offset = "0xC5A6CC", VA = "0xC5A6CC")]
	public void ForceUpdateAnimator()
	{
	}

	[Token(Token = "0x6004496")]
	[Address(RVA = "0xC5A7C8", Offset = "0xC5A7C8", VA = "0xC5A7C8", Slot = "207")]
	public virtual void CatchAnimComponentPlayAnimID(AnimationID MFNEABEJJCB)
	{
	}

	[Token(Token = "0x6004497")]
	[Address(RVA = "0xC5A8F0", Offset = "0xC5A8F0", VA = "0xC5A8F0", Slot = "208")]
	public virtual bool IsIgonreWeaponFireControl()
	{
		return default(bool);
	}

	[Token(Token = "0x6004498")]
	[Address(RVA = "0xC5A948", Offset = "0xC5A948", VA = "0xC5A948", Slot = "209")]
	public virtual Dictionary<int, int> GetGameControlMappingToSkillIndexMap()
	{
		return null;
	}

	[Token(Token = "0x6004499")]
	[Address(RVA = "0xC5A9A0", Offset = "0xC5A9A0", VA = "0xC5A9A0", Slot = "210")]
	public virtual Dictionary<KeyCode, int> GetKeyCodeToSkillIndexMap()
	{
		return null;
	}

	[Token(Token = "0x600449A")]
	[Address(RVA = "0xC5A9F8", Offset = "0xC5A9F8", VA = "0xC5A9F8", Slot = "211")]
	public virtual bool IsOverrdieFastRunControl()
	{
		return default(bool);
	}

	[Token(Token = "0x600449B")]
	[Address(RVA = "0xC5AA50", Offset = "0xC5AA50", VA = "0xC5AA50")]
	public void StopUseCurInventoryOnHand()
	{
	}

	[Token(Token = "0x600449C")]
	[Address(RVA = "0xC28478", Offset = "0xC28478", VA = "0xC28478")]
	public void SetAllPlayerThermalView(bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x600449D")]
	[Address(RVA = "0xC5ABCC", Offset = "0xC5ABCC", VA = "0xC5ABCC")]
	public void SetThermalView()
	{
	}

	[Token(Token = "0x600449E")]
	[Address(RVA = "0xC0354C", Offset = "0xC0354C", VA = "0xC0354C")]
	public bool JudgeInAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x600449F")]
	[Address(RVA = "0xC5AFAC", Offset = "0xC5AFAC", VA = "0xC5AFAC")]
	public bool JudgeInDefence()
	{
		return default(bool);
	}

	[Token(Token = "0x60044A0")]
	[Address(RVA = "0xC5B018", Offset = "0xC5B018", VA = "0xC5B018")]
	public void StartCrouching()
	{
	}

	[Token(Token = "0x60044A1")]
	[Address(RVA = "0xC5B844", Offset = "0xC5B844", VA = "0xC5B844")]
	public void StopCrouching()
	{
	}

	[Token(Token = "0x60044A2")]
	[Address(RVA = "0xBED1E8", Offset = "0xBED1E8", VA = "0xBED1E8")]
	private void LHIAJEPLEDI()
	{
	}

	[Token(Token = "0x60044A3")]
	[Address(RVA = "0xBDD3E8", Offset = "0xBDD3E8", VA = "0xBDD3E8")]
	public void ClearHumanTireIAmIn(bool DJIFNJPMLAH, [Optional] LevelTriggerHumanTire OMGKJGMEJJA)
	{
	}

	[Token(Token = "0x60044A4")]
	[Address(RVA = "0xC5BA90", Offset = "0xC5BA90", VA = "0xC5BA90", Slot = "212")]
	public virtual bool IsIgnorePlayerAudioComponent()
	{
		return default(bool);
	}

	[Token(Token = "0x60044A5")]
	[Address(RVA = "0xC5BAE8", Offset = "0xC5BAE8", VA = "0xC5BAE8", Slot = "213")]
	public virtual bool IsIgnoreHighFalling()
	{
		return default(bool);
	}

	[Token(Token = "0x60044A6")]
	[Address(RVA = "0xC5BB40", Offset = "0xC5BB40", VA = "0xC5BB40", Slot = "214")]
	public virtual bool IsNeedAimAssists()
	{
		return default(bool);
	}

	[Token(Token = "0x60044A7")]
	[Address(RVA = "0xC5BBC8", Offset = "0xC5BBC8", VA = "0xC5BBC8")]
	private bool LHFDAEJKOCH()
	{
		return default(bool);
	}

	[Token(Token = "0x60044A9")]
	[Address(RVA = "0xC5BE6C", Offset = "0xC5BE6C", VA = "0xC5BE6C")]
	public void SyncTeleportDoorUseInfo(AODEDBCGKCO LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x60044AA")]
	[Address(RVA = "0xC5BF10", Offset = "0xC5BF10", VA = "0xC5BF10")]
	public void SyncDriftBottleUseState(bool MCIEMBENCNG)
	{
	}

	[Token(Token = "0x60044AB")]
	[Address(RVA = "0xC5C218", Offset = "0xC5C218", VA = "0xC5C218")]
	public void SyncSupplyUseState()
	{
	}

	[Token(Token = "0x60044AC")]
	[Address(RVA = "0xC5C4FC", Offset = "0xC5C4FC", VA = "0xC5C4FC")]
	public void RecycleCurrentProp()
	{
	}

	[Token(Token = "0x60044AD")]
	[Address(RVA = "0xC5C568", Offset = "0xC5C568", VA = "0xC5C568")]
	public void ResetSimulationHP()
	{
	}

	[Token(Token = "0x60044AE")]
	[Address(RVA = "0xC5C64C", Offset = "0xC5C64C", VA = "0xC5C64C")]
	public List<JJHIMAEGAPA> GetDynamicSkills()
	{
		return null;
	}

	[Token(Token = "0x60044AF")]
	[Address(RVA = "0xC238A4", Offset = "0xC238A4", VA = "0xC238A4")]
	public JJHIMAEGAPA GetSkillByType(string GEPIPPKAIBK)
	{
		return null;
	}

	[Token(Token = "0x60044B0")]
	[Address(RVA = "0xC5C848", Offset = "0xC5C848", VA = "0xC5C848")]
	public void SyncVehicleHornAccordingToDistance(bool NCJHJOFDMNO, Transform CODBPDFODMD, Transform MCFBKACOPOP, ref GameObject KKABPDKFDBJ, ResourceID MFENCDOADDA)
	{
	}

	[Token(Token = "0x60044B1")]
	[Address(RVA = "0xC5D030", Offset = "0xC5D030", VA = "0xC5D030", Slot = "216")]
	public virtual void ChangeFog(bool IMGNBGJDAHG)
	{
	}

	[Token(Token = "0x60044B2")]
	[Address(RVA = "0xC5D08C", Offset = "0xC5D08C", VA = "0xC5D08C")]
	public void CheckAndTryGetoffAirTransporter()
	{
	}

	[Token(Token = "0x60044B3")]
	[Address(RVA = "0xC5D1B4", Offset = "0xC5D1B4", VA = "0xC5D1B4")]
	public void RequestUseRescureZone()
	{
	}

	[Token(Token = "0x60044B4")]
	[Address(RVA = "0xC5D794", Offset = "0xC5D794", VA = "0xC5D794")]
	private void MIAMCIKIGKI()
	{
	}

	[Token(Token = "0x60044B5")]
	[Address(RVA = "0xBEDBB4", Offset = "0xBEDBB4", VA = "0xBEDBB4")]
	public void ClearUseRescureZoneEffect()
	{
	}

	[Token(Token = "0x60044B6")]
	[Address(RVA = "0xC03204", Offset = "0xC03204", VA = "0xC03204")]
	public void CancelUseRescureZone()
	{
	}

	[Token(Token = "0x60044B7")]
	[Address(RVA = "0xC5D9FC", Offset = "0xC5D9FC", VA = "0xC5D9FC", Slot = "52")]
	public override bool CanAssitByWeapon(Player DEKAHNJALPI, GPBDEDFKJNA LPGPKFMGCBG)
	{
		return default(bool);
	}

	[Token(Token = "0x60044B8")]
	[Address(RVA = "0xC5DC04", Offset = "0xC5DC04", VA = "0xC5DC04", Slot = "217")]
	public virtual void OnPlayerTriggerCheckPoint()
	{
	}

	[Token(Token = "0x60044B9")]
	[Address(RVA = "0xC23138", Offset = "0xC23138", VA = "0xC23138")]
	public bool IsFullHP()
	{
		return default(bool);
	}

	[Token(Token = "0x60044BE")]
	[Address(RVA = "0xBF8408", Offset = "0xBF8408", VA = "0xBF8408")]
	protected void HCCALLOECFC(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x60044BF")]
	[Address(RVA = "0xC0332C", Offset = "0xC0332C", VA = "0xC0332C")]
	protected void DEKJHKINGBJ(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x60044C4")]
	[Address(RVA = "0xC5E15C", Offset = "0xC5E15C", VA = "0xC5E15C")]
	public void PlayVFXJumpInLowGravityArea()
	{
	}

	[Token(Token = "0x60044C5")]
	[Address(RVA = "0xC5E274", Offset = "0xC5E274", VA = "0xC5E274")]
	public void StopVFXInLowGravityArea()
	{
	}

	[Token(Token = "0x60044C6")]
	[Address(RVA = "0xC5E350", Offset = "0xC5E350", VA = "0xC5E350")]
	private void OBIMBAMKHLC(ResourceID JPFKGCMPLLM, Transform PHLFBBIAEFE, ref GameObject EDOANCAFENC)
	{
	}

	[Token(Token = "0x60044C7")]
	[Address(RVA = "0xC5E5E8", Offset = "0xC5E5E8", VA = "0xC5E5E8")]
	private void IGDKNGFGIKP(ResourceID JPFKGCMPLLM, ref GameObject EDOANCAFENC)
	{
	}

	[Token(Token = "0x60044C8")]
	[Address(RVA = "0xC5035C", Offset = "0xC5035C", VA = "0xC5035C")]
	private void AFHGMDENCGE(bool GIKMGIJCDOP, CBIKNJDAGLO JMEHJCCMLAL)
	{
	}

	[Token(Token = "0x60044C9")]
	[Address(RVA = "0xBF1844", Offset = "0xBF1844", VA = "0xBF1844")]
	private void EAFLDDIAHPG(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60044CA")]
	[Address(RVA = "0xC5E758", Offset = "0xC5E758", VA = "0xC5E758")]
	public void InfectionOnPlayerBeAttacked()
	{
	}

	[Token(Token = "0x60044CB")]
	[Address(RVA = "0xC5E874", Offset = "0xC5E874", VA = "0xC5E874")]
	public void PlayChangeToZombieVfx()
	{
	}

	[Token(Token = "0x60044CC")]
	[Address(RVA = "0xC5EE38", Offset = "0xC5EE38", VA = "0xC5EE38")]
	public void SetInfectionDefaultVfx()
	{
	}

	[Token(Token = "0x60044CD")]
	[Address(RVA = "0xC5F688", Offset = "0xC5F688", VA = "0xC5F688", Slot = "218")]
	public virtual bool IsCameraUseTargetBackOffset()
	{
		return default(bool);
	}

	[Token(Token = "0x60044CE")]
	[Address(RVA = "0xC5F6E0", Offset = "0xC5F6E0", VA = "0xC5F6E0", Slot = "219")]
	public virtual void OnEnterStarFalling()
	{
	}

	[Token(Token = "0x60044CF")]
	[Address(RVA = "0xC5F948", Offset = "0xC5F948", VA = "0xC5F948", Slot = "220")]
	public virtual void OnExitStarFalling()
	{
	}

	[Token(Token = "0x60044D0")]
	[Address(RVA = "0xC5FC40", Offset = "0xC5FC40", VA = "0xC5FC40")]
	public void BeginFollowFlight(Vector3 LMLOFKLDCCG, Vector3 NLMMBCFPEIB, float KBIDAGFCENL, float DCAEMBLLMDG)
	{
	}

	[Token(Token = "0x60044D1")]
	[Address(RVA = "0xC6005C", Offset = "0xC6005C", VA = "0xC6005C")]
	public void CancelFollowFlight()
	{
	}

	[Token(Token = "0x60044D2")]
	[Address(RVA = "0xC602D4", Offset = "0xC602D4", VA = "0xC602D4")]
	public void BeginGravityFlight(Vector3 DFLJCEGMKJP)
	{
	}

	[Token(Token = "0x60044D3")]
	[Address(RVA = "0xC60364", Offset = "0xC60364", VA = "0xC60364")]
	public void CancelGravityFlight()
	{
	}

	[Token(Token = "0x60044D4")]
	[Address(RVA = "0xC603C0", Offset = "0xC603C0", VA = "0xC603C0", Slot = "221")]
	public virtual void OnEnterFlightChangeCamera()
	{
	}

	[Token(Token = "0x60044D5")]
	[Address(RVA = "0xC60530", Offset = "0xC60530", VA = "0xC60530", Slot = "222")]
	public virtual void OnExitFlightChangeCamera()
	{
	}

	[Token(Token = "0x60044D6")]
	[Address(RVA = "0xC60644", Offset = "0xC60644", VA = "0xC60644", Slot = "223")]
	public virtual void FlightFollowToSkateBoard()
	{
	}

	[Token(Token = "0x60044D7")]
	[Address(RVA = "0xC60B74", Offset = "0xC60B74", VA = "0xC60B74", Slot = "224")]
	protected virtual void EKDCDADDHFM()
	{
	}

	[Token(Token = "0x60044D8")]
	[Address(RVA = "0xC610D4", Offset = "0xC610D4", VA = "0xC610D4")]
	private void GCGPGNLPDHE()
	{
	}

	[Token(Token = "0x60044D9")]
	[Address(RVA = "0xC61298", Offset = "0xC61298", VA = "0xC61298", Slot = "225")]
	public virtual void SwitchToFlight(bool OFEBJECKEBE)
	{
	}

	[Token(Token = "0x60044DA")]
	[Address(RVA = "0xC61310", Offset = "0xC61310", VA = "0xC61310", Slot = "226")]
	public virtual void SkateBoardToFlightFollow()
	{
	}

	[Token(Token = "0x60044DB")]
	[Address(RVA = "0xC61A50", Offset = "0xC61A50", VA = "0xC61A50", Slot = "227")]
	protected virtual void ADIINCGOMBB()
	{
	}

	[Token(Token = "0x60044DC")]
	[Address(RVA = "0xC61BFC", Offset = "0xC61BFC", VA = "0xC61BFC")]
	public void BeginFlightToDanceCenterTarget()
	{
	}

	[Token(Token = "0x60044DD")]
	[Address(RVA = "0xC61DC4", Offset = "0xC61DC4", VA = "0xC61DC4", Slot = "228")]
	public virtual void SpawnStarLightToXJ()
	{
	}

	[Token(Token = "0x60044DE")]
	[Address(RVA = "0xC620E4", Offset = "0xC620E4", VA = "0xC620E4", Slot = "229")]
	public virtual void OnPreTeleportCallDance()
	{
	}

	[Token(Token = "0x60044DF")]
	[Address(RVA = "0xC622FC", Offset = "0xC622FC", VA = "0xC622FC", Slot = "230")]
	public virtual void OnPostTeleportCallDance(int JEDCNLDOCMB)
	{
	}

	[Token(Token = "0x60044E0")]
	[Address(RVA = "0xC62938", Offset = "0xC62938", VA = "0xC62938")]
	public void DelCallDanceEffect()
	{
	}

	[Token(Token = "0x60044E1")]
	[Address(RVA = "0xC629B4", Offset = "0xC629B4", VA = "0xC629B4")]
	public void PlayCallDanceEmote(int JEDCNLDOCMB)
	{
	}

	[Token(Token = "0x60044E2")]
	[Address(RVA = "0xC62A5C", Offset = "0xC62A5C", VA = "0xC62A5C")]
	public void AddItemOffline(uint EECPJIFLNNM, uint BLEAICPKPGL, BMGBKEENCJH CKOOGPANEEC, bool PFPCDJCHMAD = true, bool JOMHFABHALL = true)
	{
	}

	[Token(Token = "0x60044E3")]
	[Address(RVA = "0xC62CD4", Offset = "0xC62CD4", VA = "0xC62CD4", Slot = "231")]
	public virtual bool IsNeedOfflineInitInventory()
	{
		return default(bool);
	}

	[Token(Token = "0x60044E4")]
	[Address(RVA = "0xC62D2C", Offset = "0xC62D2C", VA = "0xC62D2C", Slot = "232")]
	public virtual bool IsInitNeedEquipSound()
	{
		return default(bool);
	}

	[Token(Token = "0x60044E5")]
	[Address(RVA = "0xC62D84", Offset = "0xC62D84", VA = "0xC62D84")]
	public void TapTheBeat()
	{
	}

	[Token(Token = "0x60044E6")]
	[Address(RVA = "0xC62EA0", Offset = "0xC62EA0", VA = "0xC62EA0")]
	public void RequestPlayPartyDance(uint KMIPBIGPDPI, float JOMKIGFPPGD = 0f, bool NJEAJOGJPLE = false)
	{
	}

	[Token(Token = "0x60044E7")]
	[Address(RVA = "0xC630A4", Offset = "0xC630A4", VA = "0xC630A4")]
	private bool MIDFMLFGNJM()
	{
		return default(bool);
	}

	[Token(Token = "0x60044E8")]
	[Address(RVA = "0xC63490", Offset = "0xC63490", VA = "0xC63490")]
	public void StartPartyGameSoloDanceBattling()
	{
	}

	[Token(Token = "0x60044E9")]
	[Address(RVA = "0xC63508", Offset = "0xC63508", VA = "0xC63508")]
	public void EndPartyGameSoloDanceBattling()
	{
	}

	[Token(Token = "0x60044EA")]
	[Address(RVA = "0xC0A5D0", Offset = "0xC0A5D0", VA = "0xC0A5D0")]
	public bool IsPlayingMoveEmote()
	{
		return default(bool);
	}

	[Token(Token = "0x60044F5")]
	[Address(RVA = "0xC635C0", Offset = "0xC635C0", VA = "0xC635C0")]
	protected FDMPBIEMHAF OGLJABHCKKA(FDMPBIEMHAF ADHJBCCFHKM, [Optional] GameObject APOIADLOOAH)
	{
		return null;
	}

	[Token(Token = "0x60044F6")]
	[Address(RVA = "0xC6370C", Offset = "0xC6370C", VA = "0xC6370C")]
	protected void MLIOJODPGLK()
	{
	}

	[Token(Token = "0x60044F7")]
	[Address(RVA = "0xC6389C", Offset = "0xC6389C", VA = "0xC6389C", Slot = "233")]
	public virtual void OnActSkillFinished(KBJIDDDPPOO GEPIPPKAIBK)
	{
	}

	[Token(Token = "0x60044F8")]
	[Address(RVA = "0xC09F00", Offset = "0xC09F00", VA = "0xC09F00")]
	protected void NNFGLFGBGLJ(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60044F9")]
	[Address(RVA = "0xC638F8", Offset = "0xC638F8", VA = "0xC638F8", Slot = "234")]
	public virtual void CastSkillByIndex(int HHLONFLCJBL, bool IMGAECDPPCF = false)
	{
	}

	[Token(Token = "0x60044FB")]
	[Address(RVA = "0xC63B84", Offset = "0xC63B84", VA = "0xC63B84")]
	public bool CheckActSkillCanCast(int HHLONFLCJBL)
	{
		return default(bool);
	}

	[Token(Token = "0x60044FC")]
	[Address(RVA = "0xC6383C", Offset = "0xC6383C", VA = "0xC6383C")]
	public void ResetActSkillPlayerLockState()
	{
	}

	[Token(Token = "0x60044FD")]
	[Address(RVA = "0xC63CB0", Offset = "0xC63CB0", VA = "0xC63CB0")]
	public void ShowSkillVfxEffect(NOAKLBNJKAM DEEGGKFDOKA)
	{
	}

	[Token(Token = "0x60044FE")]
	[Address(RVA = "0xC6415C", Offset = "0xC6415C", VA = "0xC6415C")]
	public void ClearSkillVfxEffect(NOAKLBNJKAM DEEGGKFDOKA)
	{
	}

	[Token(Token = "0x60044FF")]
	[Address(RVA = "0xC644DC", Offset = "0xC644DC", VA = "0xC644DC")]
	public bool GetIsDampingNoiseBySkill(int CDAKGFIJNBE, int CDLMIMCKICB)
	{
		return default(bool);
	}

	[Token(Token = "0x6004500")]
	[Address(RVA = "0xBE1060", Offset = "0xBE1060", VA = "0xBE1060")]
	public bool IsTransformSkillTakingEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x6004503")]
	[Address(RVA = "0xC64678", Offset = "0xC64678", VA = "0xC64678")]
	public void SyncActiveSkillStatus(GPBEINJKAFN LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004504")]
	[Address(RVA = "0xC648D0", Offset = "0xC648D0", VA = "0xC648D0")]
	private ResourceID JAENHJGEDII()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6004505")]
	[Address(RVA = "0xC64AB8", Offset = "0xC64AB8", VA = "0xC64AB8")]
	public void PutOnTransformer()
	{
	}

	[Token(Token = "0x6004506")]
	[Address(RVA = "0xC65164", Offset = "0xC65164", VA = "0xC65164")]
	public void TakeOffTransformer()
	{
	}

	[Token(Token = "0x6004507")]
	[Address(RVA = "0xC64EE0", Offset = "0xC64EE0", VA = "0xC64EE0")]
	public void SetVisibiliyByTransformer(bool NJCMEBMNPJF)
	{
	}

	[Token(Token = "0x6004508")]
	[Address(RVA = "0xC65270", Offset = "0xC65270", VA = "0xC65270")]
	public void UpdateSkillHideInMap(bool FMLAEEMJLKI)
	{
	}

	[Token(Token = "0x6004509")]
	[Address(RVA = "0xC65310", Offset = "0xC65310", VA = "0xC65310")]
	public void UpdateDetectiveSkillEffect(bool ODOEHEHNJOG)
	{
	}

	[Token(Token = "0x600450A")]
	[Address(RVA = "0xC65644", Offset = "0xC65644", VA = "0xC65644")]
	public void OnSyncPetSkillMarkCuringEnemy(List<CMFKMGFNNIK> APBGBFPNFDB)
	{
	}

	[Token(Token = "0x600450B")]
	[Address(RVA = "0xC19C98", Offset = "0xC19C98", VA = "0xC19C98")]
	public void UpdatePetSkillMarkCuringEnemy(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600450C")]
	[Address(RVA = "0xBE5B64", Offset = "0xBE5B64", VA = "0xBE5B64")]
	private void DIHKICALMOP()
	{
	}

	[Token(Token = "0x600450D")]
	[Address(RVA = "0xC224E8", Offset = "0xC224E8", VA = "0xC224E8")]
	public void PlayAssistantShot(JIHBGIELHHG BEIOJKODJNK)
	{
	}

	[Token(Token = "0x600450E")]
	[Address(RVA = "0xC22560", Offset = "0xC22560", VA = "0xC22560")]
	public void ShowEventTriggerMark(HPDHMPCFMFH MNPBIOJNHME)
	{
	}

	[Token(Token = "0x600450F")]
	[Address(RVA = "0xC65D18", Offset = "0xC65D18", VA = "0xC65D18")]
	public void ClearEventTriggerMark(HPDHMPCFMFH MNPBIOJNHME)
	{
	}

	[Token(Token = "0x6004510")]
	[Address(RVA = "0xC65D90", Offset = "0xC65D90", VA = "0xC65D90")]
	public void ShowEventTriggerMark(HPDHMPCFMFH MNPBIOJNHME, Vector3 MLCIHBOHEHE)
	{
	}

	[Token(Token = "0x6004511")]
	[Address(RVA = "0xC65E34", Offset = "0xC65E34", VA = "0xC65E34")]
	public void ShowAssistantMarkItem(DLPJLPIHNCL JKMLNPBCKHM, uint BLNMJPPLIMH, string OADJHFCDPDM, uint BFFPKPKDJCD, Vector3 MLCIHBOHEHE)
	{
	}

	[Token(Token = "0x6004512")]
	[Address(RVA = "0xC65F08", Offset = "0xC65F08", VA = "0xC65F08")]
	public void ChangeRemoveSelfMarkEntityTime(float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004513")]
	[Address(RVA = "0xC65F80", Offset = "0xC65F80", VA = "0xC65F80")]
	public void ShowAssistantMarkForMapMark(Vector3 MLCIHBOHEHE, uint CGCGNJOCEJA)
	{
	}

	[Token(Token = "0x6004514")]
	[Address(RVA = "0xC66028", Offset = "0xC66028", VA = "0xC66028")]
	public void RequestMarkEntity(DLPJLPIHNCL JKMLNPBCKHM, uint BLNMJPPLIMH, uint BFFPKPKDJCD, Vector3 MLCIHBOHEHE)
	{
	}

	[Token(Token = "0x6004515")]
	[Address(RVA = "0xC660E4", Offset = "0xC660E4", VA = "0xC660E4")]
	public void TryRemoveAssistantMark(DLPJLPIHNCL JKMLNPBCKHM, uint BLNMJPPLIMH, uint BFFPKPKDJCD)
	{
	}

	[Token(Token = "0x6004516")]
	[Address(RVA = "0xC662F4", Offset = "0xC662F4", VA = "0xC662F4")]
	public void TryPosRemoveAssistantMark(DLPJLPIHNCL JKMLNPBCKHM, uint BLNMJPPLIMH, uint BFFPKPKDJCD)
	{
	}

	[Token(Token = "0x6004517")]
	[Address(RVA = "0xC66504", Offset = "0xC66504", VA = "0xC66504")]
	public bool CheckMarkItemInfo(DLPJLPIHNCL JKMLNPBCKHM, uint BLNMJPPLIMH, uint BFFPKPKDJCD)
	{
		return default(bool);
	}

	[Token(Token = "0x6004518")]
	[Address(RVA = "0xC665B0", Offset = "0xC665B0", VA = "0xC665B0")]
	public void ClearMarkItemCacheInfo()
	{
	}

	[Token(Token = "0x6004519")]
	[Address(RVA = "0xC6661C", Offset = "0xC6661C", VA = "0xC6661C")]
	public void RemoveAssistantMark(IHAAMHPPLMG IDNEFEOPGIF, DLPJLPIHNCL JKMLNPBCKHM, uint BLNMJPPLIMH, uint BFFPKPKDJCD)
	{
	}

	[Token(Token = "0x600451A")]
	[Address(RVA = "0xC66704", Offset = "0xC66704", VA = "0xC66704")]
	public void RequestAssistantShot(JIHBGIELHHG DIPOHFNABKH)
	{
	}

	[Token(Token = "0x600451B")]
	[Address(RVA = "0xC6677C", Offset = "0xC6677C", VA = "0xC6677C")]
	public void RequestAssistantShot(JIHBGIELHHG DIPOHFNABKH, HPDHMPCFMFH NBODIICEKLJ)
	{
	}

	[Token(Token = "0x600451C")]
	[Address(RVA = "0xC66814", Offset = "0xC66814", VA = "0xC66814")]
	public void RequestAssistantShot(JIHBGIELHHG DIPOHFNABKH, HPDHMPCFMFH NBODIICEKLJ, Vector3 CEGDIKIDIFF)
	{
	}

	[Token(Token = "0x600451D")]
	[Address(RVA = "0xC668C8", Offset = "0xC668C8", VA = "0xC668C8")]
	public void RaycastCheckForItemMark(ref BaseLevelObject DHGNNKKOMND, ref Vector3 MEKPPJBENPM, bool DPFMGIFJNKD = false)
	{
	}

	[Token(Token = "0x600451E")]
	[Address(RVA = "0xC66EE8", Offset = "0xC66EE8", VA = "0xC66EE8")]
	public bool CheckContainerSame(uint JAKHHJFDLKH)
	{
		return default(bool);
	}

	[Token(Token = "0x600451F")]
	[Address(RVA = "0xC66F68", Offset = "0xC66F68", VA = "0xC66F68")]
	public float GetMarkItemLastUseTime()
	{
		return default(float);
	}

	[Token(Token = "0x6004521")]
	[Address(RVA = "0xC670D8", Offset = "0xC670D8", VA = "0xC670D8")]
	public void TrySwitchToAvatarTransformer(uint ILHBGNHPAAI)
	{
	}

	[Token(Token = "0x6004522")]
	[Address(RVA = "0xC68368", Offset = "0xC68368", VA = "0xC68368")]
	public void QuitAvatarTransformer()
	{
	}

	[Token(Token = "0x6004523")]
	[Address(RVA = "0xC68780", Offset = "0xC68780", VA = "0xC68780")]
	private void MKIHBMBLAKH()
	{
	}

	[Token(Token = "0x6004524")]
	[Address(RVA = "0xC68800", Offset = "0xC68800", VA = "0xC68800")]
	private void JOFIHBPAJKP()
	{
	}

	[Token(Token = "0x6004525")]
	[Address(RVA = "0xC680B8", Offset = "0xC680B8", VA = "0xC680B8")]
	public bool canShowAvatarTransform(AvatarTransformData AJKBOONEOAB)
	{
		return default(bool);
	}

	[Token(Token = "0x6004526")]
	[Address(RVA = "0xC5A570", Offset = "0xC5A570", VA = "0xC5A570")]
	private void OKDHEBGCLPJ()
	{
	}

	[Token(Token = "0x6004527")]
	[Address(RVA = "0xC68954", Offset = "0xC68954", VA = "0xC68954")]
	private void PILAJPJNMPO()
	{
	}

	[Token(Token = "0x6004528")]
	[Address(RVA = "0xC689D4", Offset = "0xC689D4", VA = "0xC689D4", Slot = "21")]
	public override ITransformNode GetTransformNode(string HINJBPEDIAL)
	{
		return null;
	}

	[Token(Token = "0x600452C")]
	[Address(RVA = "0xC68AB0", Offset = "0xC68AB0", VA = "0xC68AB0")]
	public void RequestStartClimb()
	{
	}

	[Token(Token = "0x600452D")]
	[Address(RVA = "0xC1B098", Offset = "0xC1B098", VA = "0xC1B098")]
	public void UpdateClimbCamera(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600452E")]
	[Address(RVA = "0xC6942C", Offset = "0xC6942C", VA = "0xC6942C")]
	public void UpdateCrossOverJumpTimeAndFallTime(float FHHNIDDBDNG, float JMOJNEOBPND)
	{
	}

	[Token(Token = "0x600452F")]
	[Address(RVA = "0xC082A8", Offset = "0xC082A8", VA = "0xC082A8")]
	public bool CheckPhysPose_Climb()
	{
		return default(bool);
	}

	[Token(Token = "0x6004530")]
	[Address(RVA = "0xC6955C", Offset = "0xC6955C", VA = "0xC6955C")]
	public Vector2 GetCrossOverSpeed(float OPKNJGBDOBB)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6004531")]
	[Address(RVA = "0xC69908", Offset = "0xC69908", VA = "0xC69908")]
	private bool HOEGDFEPCOG(float OPKNJGBDOBB)
	{
		return default(bool);
	}

	[Token(Token = "0x6004532")]
	[Address(RVA = "0xC69A20", Offset = "0xC69A20", VA = "0xC69A20")]
	public void RequestEndClimb()
	{
	}

	[Token(Token = "0x6004535")]
	[Address(RVA = "0xC69D34", Offset = "0xC69D34", VA = "0xC69D34", Slot = "235")]
	public virtual bool RequestCreep()
	{
		return default(bool);
	}

	[Token(Token = "0x6004536")]
	[Address(RVA = "0xC6A18C", Offset = "0xC6A18C", VA = "0xC6A18C", Slot = "236")]
	public virtual bool RequestUnCreep(FBCAHNCLMDC ELJBADBICJN)
	{
		return default(bool);
	}

	[Token(Token = "0x6004537")]
	[Address(RVA = "0xC14124", Offset = "0xC14124", VA = "0xC14124")]
	protected void MLGFIGJKNGN()
	{
	}

	[Token(Token = "0x6004538")]
	[Address(RVA = "0xC1B2DC", Offset = "0xC1B2DC", VA = "0xC1B2DC")]
	protected float CMFMGFJNJAL()
	{
		return default(float);
	}

	[Token(Token = "0x6004539")]
	[Address(RVA = "0xC69284", Offset = "0xC69284", VA = "0xC69284")]
	public void RequestUnSightIfNeed()
	{
	}

	[Token(Token = "0x600453A")]
	[Address(RVA = "0xC6A578", Offset = "0xC6A578", VA = "0xC6A578")]
	public void RequestBackToSightingIfNeed()
	{
	}

	[Token(Token = "0x600453B")]
	[Address(RVA = "0xC6A510", Offset = "0xC6A510", VA = "0xC6A510")]
	private bool FABANIBMLGM()
	{
		return default(bool);
	}

	[Token(Token = "0x600453C")]
	[Address(RVA = "0xC6A6F4", Offset = "0xC6A6F4", VA = "0xC6A6F4")]
	public bool CheckCeiling(float OHOBOOGMABH = 1000f)
	{
		return default(bool);
	}

	[Token(Token = "0x600453D")]
	[Address(RVA = "0xC6AA30", Offset = "0xC6AA30", VA = "0xC6AA30")]
	public void EnableDashDustEffect(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x600453E")]
	[Address(RVA = "0xC6ACA0", Offset = "0xC6ACA0", VA = "0xC6ACA0")]
	protected void POEOHGIJMOJ()
	{
	}

	[Token(Token = "0x600453F")]
	[Address(RVA = "0xC6B518", Offset = "0xC6B518", VA = "0xC6B518")]
	public void ResetDashEffectType()
	{
	}

	[Token(Token = "0x6004540")]
	[Address(RVA = "0xC6B57C", Offset = "0xC6B57C", VA = "0xC6B57C")]
	public void SwitchDashEffectType(LGLMLIBMLAM OFNKBPDMCPK)
	{
	}

	[Token(Token = "0x6004543")]
	[Address(RVA = "0xC6B97C", Offset = "0xC6B97C", VA = "0xC6B97C")]
	public void ShowDoubleJumpEffect()
	{
	}

	[Token(Token = "0x6004544")]
	[Address(RVA = "0xC6BAFC", Offset = "0xC6BAFC", VA = "0xC6BAFC")]
	public void EndDoubleJumpEffect()
	{
	}

	[Token(Token = "0x6004545")]
	[Address(RVA = "0xC6BC08", Offset = "0xC6BC08", VA = "0xC6BC08")]
	public AMPGCIMNMBI GetDoubleJumpData()
	{
		return null;
	}

	[Token(Token = "0x6004546")]
	[Address(RVA = "0xC6BD34", Offset = "0xC6BD34", VA = "0xC6BD34", Slot = "237")]
	public virtual bool RequestStopDoubleJump()
	{
		return default(bool);
	}

	[Token(Token = "0x6004549")]
	[Address(RVA = "0xC6BE08", Offset = "0xC6BE08", VA = "0xC6BE08", Slot = "238")]
	public virtual bool RequestFastRun()
	{
		return default(bool);
	}

	[Token(Token = "0x600454A")]
	[Address(RVA = "0xC6C274", Offset = "0xC6C274", VA = "0xC6C274", Slot = "239")]
	public virtual bool RequestStopFastRun()
	{
		return default(bool);
	}

	[Token(Token = "0x6004550")]
	[Address(RVA = "0xC6C590", Offset = "0xC6C590", VA = "0xC6C590", Slot = "240")]
	public virtual void RequestChangeFlightRoamState(bool OFEBJECKEBE)
	{
	}

	[Token(Token = "0x6004551")]
	[Address(RVA = "0xC6C968", Offset = "0xC6C968", VA = "0xC6C968", Slot = "241")]
	public virtual void SetFlightRoam(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x6004552")]
	[Address(RVA = "0xC6CABC", Offset = "0xC6CABC", VA = "0xC6CABC", Slot = "242")]
	public virtual bool CanFlightRoam()
	{
		return default(bool);
	}

	[Token(Token = "0x6004553")]
	[Address(RVA = "0xC6CC1C", Offset = "0xC6CC1C", VA = "0xC6CC1C")]
	public void UpdateFlightRoamData(DPFDECGNHFK LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004554")]
	[Address(RVA = "0xC6C8F0", Offset = "0xC6C8F0", VA = "0xC6C8F0")]
	public MILCMIMPDMG GetFlightRoamData()
	{
		return default(MILCMIMPDMG);
	}

	[Token(Token = "0x6004559")]
	[Address(RVA = "0xC6CF9C", Offset = "0xC6CF9C", VA = "0xC6CF9C")]
	public bool IsShowingFoldWingModel()
	{
		return default(bool);
	}

	[Token(Token = "0x600455A")]
	[Address(RVA = "0xC6D070", Offset = "0xC6D070", VA = "0xC6D070")]
	public bool IsFoldWingGliding()
	{
		return default(bool);
	}

	[Token(Token = "0x600455B")]
	[Address(RVA = "0xC6D124", Offset = "0xC6D124", VA = "0xC6D124")]
	public bool IsFoldWingGlideFalling()
	{
		return default(bool);
	}

	[Token(Token = "0x600455E")]
	[Address(RVA = "0xC6D464", Offset = "0xC6D464", VA = "0xC6D464", Slot = "243")]
	public virtual bool RequestStopFoldWing()
	{
		return default(bool);
	}

	[Token(Token = "0x600455F")]
	[Address(RVA = "0xC6D4DC", Offset = "0xC6D4DC", VA = "0xC6D4DC")]
	public void ShowFoldWingModel()
	{
	}

	[Token(Token = "0x6004560")]
	[Address(RVA = "0xC6D65C", Offset = "0xC6D65C", VA = "0xC6D65C")]
	public void ShowFoldWingModel(CCGBDNBALMI CMNLNABNDOM)
	{
	}

	[Token(Token = "0x6004561")]
	[Address(RVA = "0xC6D72C", Offset = "0xC6D72C", VA = "0xC6D72C")]
	public void HideFoldWingModel()
	{
	}

	[Token(Token = "0x6004562")]
	[Address(RVA = "0xC6D85C", Offset = "0xC6D85C", VA = "0xC6D85C")]
	public void OnStopGliding()
	{
	}

	[Token(Token = "0x6004563")]
	[Address(RVA = "0xC6DB94", Offset = "0xC6DB94", VA = "0xC6DB94")]
	public void OnStartGliding()
	{
	}

	[Token(Token = "0x6004567")]
	[Address(RVA = "0xC6E1E8", Offset = "0xC6E1E8", VA = "0xC6E1E8")]
	public void ChangeFootballVerticalSpeed(float LBMGGMBKAEH)
	{
	}

	[Token(Token = "0x6004568")]
	[Address(RVA = "0xC6E260", Offset = "0xC6E260", VA = "0xC6E260")]
	private bool PAHAGEKBDOA()
	{
		return default(bool);
	}

	[Token(Token = "0x6004569")]
	[Address(RVA = "0xC10158", Offset = "0xC10158", VA = "0xC10158")]
	private void MLKEEFAMDIG(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600456A")]
	[Address(RVA = "0xC6E588", Offset = "0xC6E588", VA = "0xC6E588")]
	public bool IsFootballGrounded()
	{
		return default(bool);
	}

	[Token(Token = "0x600456B")]
	[Address(RVA = "0xC6E7B8", Offset = "0xC6E7B8", VA = "0xC6E7B8", Slot = "244")]
	protected virtual void JEAAMCGGCLM(Vector3 KHDDBHPLJKL)
	{
	}

	[Token(Token = "0x600456C")]
	[Address(RVA = "0xC6EA20", Offset = "0xC6EA20", VA = "0xC6EA20", Slot = "245")]
	protected virtual void MEGDHEJHOGA(Vector3 KHDDBHPLJKL)
	{
	}

	[Token(Token = "0x600456D")]
	[Address(RVA = "0xC6E3FC", Offset = "0xC6E3FC", VA = "0xC6E3FC")]
	protected void GPILCDHEFOA()
	{
	}

	[Token(Token = "0x600456E")]
	[Address(RVA = "0xC6EE10", Offset = "0xC6EE10", VA = "0xC6EE10", Slot = "246")]
	protected virtual void CHDOIKIIJNO(float HLADFEKELKI)
	{
	}

	[Token(Token = "0x600456F")]
	[Address(RVA = "0xBE9B9C", Offset = "0xBE9B9C", VA = "0xBE9B9C")]
	private void CCONEGLECKP()
	{
	}

	[Token(Token = "0x6004570")]
	[Address(RVA = "0xC6F2CC", Offset = "0xC6F2CC", VA = "0xC6F2CC", Slot = "247")]
	protected virtual ResourceID INCIGCBAPED()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6004571")]
	[Address(RVA = "0xC6F3E4", Offset = "0xC6F3E4", VA = "0xC6F3E4", Slot = "248")]
	protected virtual void BHFDLJAPPME()
	{
	}

	[Token(Token = "0x6004572")]
	[Address(RVA = "0xC6F438", Offset = "0xC6F438", VA = "0xC6F438", Slot = "249")]
	protected virtual void DGPFFIGIGIN(LevelTriggerFootball IEFAIIONNFC, bool MKLKBFHMNBD = false)
	{
	}

	[Token(Token = "0x6004573")]
	[Address(RVA = "0xC70E88", Offset = "0xC70E88", VA = "0xC70E88", Slot = "250")]
	protected virtual void KNEHCDIDKIO()
	{
	}

	[Token(Token = "0x6004574")]
	[Address(RVA = "0xC718C8", Offset = "0xC718C8", VA = "0xC718C8")]
	protected void HHNBPEGECMG()
	{
	}

	[Token(Token = "0x6004575")]
	[Address(RVA = "0xC7193C", Offset = "0xC7193C", VA = "0xC7193C")]
	public void StopFootball()
	{
	}

	[Token(Token = "0x6004576")]
	[Address(RVA = "0xBE1858", Offset = "0xBE1858", VA = "0xBE1858")]
	public void SetVisibleForFootball(bool EDLIFKGBCMD)
	{
	}

	[Token(Token = "0x6004577")]
	[Address(RVA = "0xC70E14", Offset = "0xC70E14", VA = "0xC70E14")]
	private void HANDJAJCCLN(Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x6004578")]
	[Address(RVA = "0xC719A8", Offset = "0xC719A8", VA = "0xC719A8")]
	public void OnFootballGoals()
	{
	}

	[Token(Token = "0x6004579")]
	[Address(RVA = "0xC71AEC", Offset = "0xC71AEC", VA = "0xC71AEC")]
	public void ResetPlayerWardrobeForFootball()
	{
	}

	[Token(Token = "0x600457A")]
	[Address(RVA = "0xC71C14", Offset = "0xC71C14", VA = "0xC71C14")]
	public void UpdatePlayerWardrobe(uint EIKCFIDCCMM)
	{
	}

	[Token(Token = "0x600457B")]
	[Address(RVA = "0xC71EA4", Offset = "0xC71EA4", VA = "0xC71EA4", Slot = "251")]
	public virtual float GetFootballAdjustAccForward()
	{
		return default(float);
	}

	[Token(Token = "0x600457C")]
	[Address(RVA = "0xC71F7C", Offset = "0xC71F7C", VA = "0xC71F7C", Slot = "252")]
	public virtual float GetFootballAdjustAccRight()
	{
		return default(float);
	}

	[Token(Token = "0x600457D")]
	[Address(RVA = "0xC72054", Offset = "0xC72054", VA = "0xC72054", Slot = "253")]
	public virtual float GetFootballFadeVelocityXZScale()
	{
		return default(float);
	}

	[Token(Token = "0x6004580")]
	[Address(RVA = "0xC722E8", Offset = "0xC722E8", VA = "0xC722E8")]
	public void AddBeneathFeet(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x6004581")]
	[Address(RVA = "0xC72610", Offset = "0xC72610", VA = "0xC72610")]
	public void RemoveBeneathFeet(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x6004582")]
	[Address(RVA = "0xC727B0", Offset = "0xC727B0", VA = "0xC727B0")]
	public void OnFootstepTriggerEnter(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x6004583")]
	[Address(RVA = "0xC7289C", Offset = "0xC7289C", VA = "0xC7289C")]
	public void OnFootstepTriggerExit(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x6004589")]
	[Address(RVA = "0xC729E0", Offset = "0xC729E0", VA = "0xC729E0", Slot = "254")]
	public virtual bool RequestStartJetFly()
	{
		return default(bool);
	}

	[Token(Token = "0x600458A")]
	[Address(RVA = "0xC72C4C", Offset = "0xC72C4C", VA = "0xC72C4C", Slot = "255")]
	public virtual bool RequestStopJetFly()
	{
		return default(bool);
	}

	[Token(Token = "0x600458B")]
	[Address(RVA = "0xC72CCC", Offset = "0xC72CCC", VA = "0xC72CCC")]
	public void ShowJetFlyEffect()
	{
	}

	[Token(Token = "0x600458C")]
	[Address(RVA = "0xC72DD8", Offset = "0xC72DD8", VA = "0xC72DD8")]
	public void EndJetFlyEffect()
	{
	}

	[Token(Token = "0x600458D")]
	[Address(RVA = "0xC72EE4", Offset = "0xC72EE4", VA = "0xC72EE4")]
	public void PlayJetFlyFlyingSound(ResourceID AHFEGJCBIHK)
	{
	}

	[Token(Token = "0x6004590")]
	[Address(RVA = "0xC732F4", Offset = "0xC732F4", VA = "0xC732F4", Slot = "256")]
	public virtual bool RequestUsingVEM()
	{
		return default(bool);
	}

	[Token(Token = "0x6004593")]
	[Address(RVA = "0xC73F8C", Offset = "0xC73F8C", VA = "0xC73F8C")]
	private bool GHPPBFNNOIC()
	{
		return default(bool);
	}

	[Token(Token = "0x6004594")]
	[Address(RVA = "0xBF7E18", Offset = "0xBF7E18", VA = "0xBF7E18")]
	private void KIODAKDIAAM(LevelMovePlatform IOMFFBOHMBP)
	{
	}

	[Token(Token = "0x6004595")]
	[Address(RVA = "0xC743D4", Offset = "0xC743D4", VA = "0xC743D4")]
	protected void OPBHCGIAAKP()
	{
	}

	[Token(Token = "0x6004596")]
	[Address(RVA = "0xC74590", Offset = "0xC74590", VA = "0xC74590")]
	protected void GENOMNOEMKE()
	{
	}

	[Token(Token = "0x6004598")]
	[Address(RVA = "0xC02580", Offset = "0xC02580", VA = "0xC02580")]
	private void GJANKLFBEOC(LevelMovePlatform IOMFFBOHMBP)
	{
	}

	[Token(Token = "0x6004599")]
	[Address(RVA = "0xC0B790", Offset = "0xC0B790", VA = "0xC0B790")]
	private void PNNOPCNHINI(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600459A")]
	[Address(RVA = "0xC0B9F8", Offset = "0xC0B9F8", VA = "0xC0B9F8")]
	private void OGBICHKMJAH(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600459B")]
	[Address(RVA = "0xC1C10C", Offset = "0xC1C10C", VA = "0xC1C10C")]
	private void NGNDAEMHKCI(Vector3 PHOIEBCMBCF)
	{
	}

	[Token(Token = "0x600459C")]
	[Address(RVA = "0xBED7F4", Offset = "0xBED7F4", VA = "0xBED7F4")]
	public void GetOffMovePlatForm()
	{
	}

	[Token(Token = "0x600459D")]
	[Address(RVA = "0xC7472C", Offset = "0xC7472C", VA = "0xC7472C")]
	public void CheckNeedExitMovePlatform()
	{
	}

	[Token(Token = "0x60045A1")]
	[Address(RVA = "0xC3C038", Offset = "0xC3C038", VA = "0xC3C038")]
	public void ForceStopWalking()
	{
	}

	[Token(Token = "0x60045A2")]
	[Address(RVA = "0xC74EDC", Offset = "0xC74EDC", VA = "0xC74EDC", Slot = "257")]
	protected virtual void OJFOCPGCHAE(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045A3")]
	[Address(RVA = "0xC76044", Offset = "0xC76044", VA = "0xC76044")]
	private bool KKEFBGADFHK(Vector3 BCIDJPHHJMJ, Vector3 KCMGNJMNFMG)
	{
		return default(bool);
	}

	[Token(Token = "0x60045A4")]
	[Address(RVA = "0xC76A34", Offset = "0xC76A34", VA = "0xC76A34")]
	private void MHCJIDFEELN(bool GJMKPCAMBCJ)
	{
	}

	[Token(Token = "0x60045A5")]
	[Address(RVA = "0xC0F260", Offset = "0xC0F260", VA = "0xC0F260")]
	private void LKGHLEJIAJJ(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045A6")]
	[Address(RVA = "0xC0BC54", Offset = "0xC0BC54", VA = "0xC0BC54")]
	private void GPCIIOBELJM(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045A7")]
	[Address(RVA = "0xC0C6BC", Offset = "0xC0C6BC", VA = "0xC0C6BC")]
	private void CLMALNBICBO(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045A8")]
	[Address(RVA = "0xC0D930", Offset = "0xC0D930", VA = "0xC0D930")]
	private void GKEMNJAKAIH(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045A9")]
	[Address(RVA = "0xC0FBF0", Offset = "0xC0FBF0", VA = "0xC0FBF0")]
	protected void BMNGLBIDCBA(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045AA")]
	[Address(RVA = "0xC13880", Offset = "0xC13880", VA = "0xC13880")]
	private void LKFDMMOGNEF(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045AB")]
	[Address(RVA = "0xC12F68", Offset = "0xC12F68", VA = "0xC12F68")]
	private void EBKMBJHNCBF(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045AC")]
	[Address(RVA = "0xC77D68", Offset = "0xC77D68", VA = "0xC77D68")]
	private void HNCOCCHGBOF(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045AD")]
	[Address(RVA = "0xC095B4", Offset = "0xC095B4", VA = "0xC095B4")]
	private void CHEKBDJKJCB(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045AE")]
	[Address(RVA = "0xC78158", Offset = "0xC78158", VA = "0xC78158")]
	public void BeginFreeStarFalling()
	{
	}

	[Token(Token = "0x60045AF")]
	[Address(RVA = "0xC7853C", Offset = "0xC7853C", VA = "0xC7853C", Slot = "258")]
	protected virtual void KJLLPBMDMAA(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045B0")]
	[Address(RVA = "0xC11C58", Offset = "0xC11C58", VA = "0xC11C58")]
	private void CCNONFDEOOL(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045B1")]
	[Address(RVA = "0xC78ACC", Offset = "0xC78ACC", VA = "0xC78ACC", Slot = "259")]
	protected virtual void MFNJELADALH(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045B2")]
	[Address(RVA = "0xC12280", Offset = "0xC12280", VA = "0xC12280")]
	private void NNKKBDALFMM(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045B3")]
	[Address(RVA = "0xC79248", Offset = "0xC79248", VA = "0xC79248")]
	public void SimOnFerrisWheel(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045B4")]
	[Address(RVA = "0xC792B8", Offset = "0xC792B8", VA = "0xC792B8")]
	public bool CanOpenParachuting(float OPKNJGBDOBB)
	{
		return default(bool);
	}

	[Token(Token = "0x60045B5")]
	[Address(RVA = "0xC7943C", Offset = "0xC7943C", VA = "0xC7943C")]
	public bool IsRevivingInRebornMode()
	{
		return default(bool);
	}

	[Token(Token = "0x60045B6")]
	[Address(RVA = "0xC79650", Offset = "0xC79650", VA = "0xC79650")]
	public void EnableSpeedLineEffect(bool EBOJJLIHHCM)
	{
	}

	[Token(Token = "0x60045B7")]
	[Address(RVA = "0xC0DC50", Offset = "0xC0DC50", VA = "0xC0DC50")]
	private void DFHDEDBLPHB(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045B8")]
	[Address(RVA = "0xBF77FC", Offset = "0xBF77FC", VA = "0xBF77FC")]
	private void DAAANIFHMHM(LevelTriggerFountain DNEICPFHEBL)
	{
	}

	[Token(Token = "0x60045B9")]
	[Address(RVA = "0xC77AA8", Offset = "0xC77AA8", VA = "0xC77AA8")]
	public void PostParachutingTransformChange(Transform CIDMLLIACLF, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60045BA")]
	[Address(RVA = "0xC777AC", Offset = "0xC777AC", VA = "0xC777AC")]
	private bool GCDOMHJEKNP(Vector3 DMAIMAGFNNG, Vector3 LINLCGGKPPL, float DJCFCEHNOCF, uint ONEDHFJBCMJ)
	{
		return default(bool);
	}

	[Token(Token = "0x60045BB")]
	[Address(RVA = "0xC7973C", Offset = "0xC7973C", VA = "0xC7973C")]
	protected void LLJNGDEELKF()
	{
	}

	[Token(Token = "0x60045BC")]
	[Address(RVA = "0xC7A290", Offset = "0xC7A290", VA = "0xC7A290", Slot = "260")]
	public virtual bool IsJumpCanMove()
	{
		return default(bool);
	}

	[Token(Token = "0x60045D6")]
	[Address(RVA = "0xC7B688", Offset = "0xC7B688", VA = "0xC7B688")]
	public ALAHNGGPDIE GetStartFireState()
	{
		return default(ALAHNGGPDIE);
	}

	[Token(Token = "0x60045E6")]
	[Address(RVA = "0xC7C200", Offset = "0xC7C200", VA = "0xC7C200", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60045E7")]
	[Address(RVA = "0xC7C258", Offset = "0xC7C258", VA = "0xC7C258", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60045E8")]
	[Address(RVA = "0xC80A08", Offset = "0xC80A08", VA = "0xC80A08")]
	private void NOOOKBFLHPC(sbyte EFFDBJAFKLG, sbyte HCHCCLLBLLC)
	{
	}

	[Token(Token = "0x60045E9")]
	[Address(RVA = "0xC80A78", Offset = "0xC80A78", VA = "0xC80A78")]
	private void AGEKLCDACIH(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045EA")]
	[Address(RVA = "0xC80C4C", Offset = "0xC80C4C", VA = "0xC80C4C")]
	private void KJKPKNPJPPE(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045EB")]
	[Address(RVA = "0xC80EE8", Offset = "0xC80EE8", VA = "0xC80EE8")]
	private void NPKFKAOBLGD(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045EC")]
	[Address(RVA = "0xC810F4", Offset = "0xC810F4", VA = "0xC810F4", Slot = "25")]
	protected override void OnPRIInitialized()
	{
	}

	[Token(Token = "0x60045ED")]
	[Address(RVA = "0xC81468", Offset = "0xC81468", VA = "0xC81468", Slot = "261")]
	protected virtual void HMGIMAFIEAP(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045EE")]
	[Address(RVA = "0xC818FC", Offset = "0xC818FC", VA = "0xC818FC", Slot = "262")]
	protected virtual void MCOGDGHKENF(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045EF")]
	[Address(RVA = "0xC81C98", Offset = "0xC81C98", VA = "0xC81C98", Slot = "263")]
	protected virtual void JCKCGKBCMMA(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045F0")]
	[Address(RVA = "0xC81D80", Offset = "0xC81D80", VA = "0xC81D80", Slot = "264")]
	protected virtual void NHCDBMMHFBA(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045F3")]
	[Address(RVA = "0xC81F30", Offset = "0xC81F30", VA = "0xC81F30")]
	protected void BAJBLICMGCA(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045F4")]
	[Address(RVA = "0xC821DC", Offset = "0xC821DC", VA = "0xC821DC", Slot = "265")]
	protected virtual void KLLCNEHDLFP(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045F5")]
	[Address(RVA = "0xC82538", Offset = "0xC82538", VA = "0xC82538")]
	protected void KNIPOHOEDBG(sbyte JGLJDJFHPBO, sbyte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045F6")]
	[Address(RVA = "0xC825E4", Offset = "0xC825E4", VA = "0xC825E4")]
	protected void GIIHLIKKKNM(sbyte JGLJDJFHPBO, sbyte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045F7")]
	[Address(RVA = "0xC82690", Offset = "0xC82690", VA = "0xC82690")]
	protected void AFHKNIFKGHK(sbyte JGLJDJFHPBO, sbyte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045F8")]
	[Address(RVA = "0xC8273C", Offset = "0xC8273C", VA = "0xC8273C", Slot = "266")]
	protected virtual void MNKMALKKPEA(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045F9")]
	[Address(RVA = "0xC82B00", Offset = "0xC82B00", VA = "0xC82B00", Slot = "267")]
	protected virtual void JFMCBOHJGIO(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045FA")]
	[Address(RVA = "0xC82DAC", Offset = "0xC82DAC", VA = "0xC82DAC", Slot = "268")]
	protected virtual void MCAOPJMILLF(ulong JGLJDJFHPBO, ulong DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045FB")]
	[Address(RVA = "0xC83D18", Offset = "0xC83D18", VA = "0xC83D18", Slot = "269")]
	protected virtual void PBMAPMDJCKA(ulong JGLJDJFHPBO, ulong DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045FC")]
	[Address(RVA = "0xC83ECC", Offset = "0xC83ECC", VA = "0xC83ECC")]
	protected void BBOIFMGOKCD(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60045FD")]
	[Address(RVA = "0xC84010", Offset = "0xC84010", VA = "0xC84010")]
	private void MLLCKJJJEKA(ulong AMNHOBCDNBI, ulong PDCEEIDIIIG)
	{
	}

	[Token(Token = "0x60045FE")]
	[Address(RVA = "0xC8423C", Offset = "0xC8423C", VA = "0xC8423C")]
	private void BLMCKPFHNAG(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004600")]
	[Address(RVA = "0xC84358", Offset = "0xC84358", VA = "0xC84358")]
	private void DNJCLDKLJIB(bool IIJMFDCBGAJ, bool NPLOJLCFCKO)
	{
	}

	[Token(Token = "0x6004601")]
	[Address(RVA = "0xC84548", Offset = "0xC84548", VA = "0xC84548")]
	private void HALBBCLENGA(bool IIJMFDCBGAJ, bool NPLOJLCFCKO)
	{
	}

	[Token(Token = "0x6004602")]
	[Address(RVA = "0xC84608", Offset = "0xC84608", VA = "0xC84608")]
	private void FPIONCICHLB(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004603")]
	[Address(RVA = "0xC85000", Offset = "0xC85000", VA = "0xC85000")]
	private void AGMLLEFALEF(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004604")]
	[Address(RVA = "0xC851CC", Offset = "0xC851CC", VA = "0xC851CC")]
	public void StopSighting()
	{
	}

	[Token(Token = "0x6004605")]
	[Address(RVA = "0xC81340", Offset = "0xC81340", VA = "0xC81340")]
	public int GetKillCount()
	{
		return default(int);
	}

	[Token(Token = "0x6004606")]
	[Address(RVA = "0xC5BCEC", Offset = "0xC5BCEC", VA = "0xC5BCEC")]
	public int GetDeathCount()
	{
		return default(int);
	}

	[Token(Token = "0x6004607")]
	[Address(RVA = "0xC85304", Offset = "0xC85304", VA = "0xC85304")]
	public int GetMaxKillStacks()
	{
		return default(int);
	}

	[Token(Token = "0x6004608")]
	[Address(RVA = "0xC8542C", Offset = "0xC8542C", VA = "0xC8542C")]
	public void OnKillCountChanged(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004609")]
	[Address(RVA = "0xC85758", Offset = "0xC85758", VA = "0xC85758")]
	public void OnPlayerDeadCountChanged(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600460A")]
	[Address(RVA = "0xC85B44", Offset = "0xC85B44", VA = "0xC85B44")]
	public void OnPlayerAssistCountChanged(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600460B")]
	[Address(RVA = "0xC85FE0", Offset = "0xC85FE0", VA = "0xC85FE0")]
	public void OnPlayerTotalDamageChanged(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600460C")]
	[Address(RVA = "0xC8630C", Offset = "0xC8630C", VA = "0xC8630C")]
	public void OnPlayerCurCoinChanged(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600460D")]
	[Address(RVA = "0xC866C0", Offset = "0xC866C0", VA = "0xC866C0")]
	public void OnPlayerEarnedCoinChanged(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600460E")]
	[Address(RVA = "0xC869E0", Offset = "0xC869E0", VA = "0xC869E0")]
	public void OnPlayerFactionIDChanged(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600460F")]
	[Address(RVA = "0xC86FD0", Offset = "0xC86FD0", VA = "0xC86FD0")]
	public void OnPlayerSyncMatchStartBuff(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004610")]
	[Address(RVA = "0xC87290", Offset = "0xC87290", VA = "0xC87290")]
	public void OnPlayerIdentityChanged(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004611")]
	[Address(RVA = "0xC87D84", Offset = "0xC87D84", VA = "0xC87D84")]
	public void OnPlayerODFactionChanged(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004612")]
	[Address(RVA = "0xC883AC", Offset = "0xC883AC", VA = "0xC883AC")]
	public void OnPlayerPVEKillCountChanged(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004613")]
	[Address(RVA = "0xC884F0", Offset = "0xC884F0", VA = "0xC884F0")]
	public void OnPlayerThrowKnifePhaseChanged(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004614")]
	[Address(RVA = "0xC8869C", Offset = "0xC8869C", VA = "0xC8869C")]
	public void OnPlayerMaxHypeChanged(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004615")]
	[Address(RVA = "0xC88864", Offset = "0xC88864", VA = "0xC88864")]
	public void OnPLayerMaxHypeLevelChanged(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004616")]
	[Address(RVA = "0xC88A2C", Offset = "0xC88A2C", VA = "0xC88A2C")]
	public void OnPlayerCurHypeChanged(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004617")]
	[Address(RVA = "0xC88E20", Offset = "0xC88E20", VA = "0xC88E20")]
	public void OnEscortTimeChanged(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004618")]
	[Address(RVA = "0xC8905C", Offset = "0xC8905C", VA = "0xC8905C")]
	public void OnPlayerHypeLevelChanged(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004619")]
	[Address(RVA = "0xC89F20", Offset = "0xC89F20", VA = "0xC89F20")]
	public void OnPlayerTrainingGameQueueInfoChange(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600461A")]
	[Address(RVA = "0xC8A114", Offset = "0xC8A114", VA = "0xC8A114")]
	public void OnPlayerTrainingZoneTypeIamInChanged(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600461B")]
	[Address(RVA = "0xC8A8A0", Offset = "0xC8A8A0", VA = "0xC8A8A0", Slot = "270")]
	protected virtual void PCNPOEKDIOC(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600461C")]
	[Address(RVA = "0xC8B244", Offset = "0xC8B244", VA = "0xC8B244")]
	private void ENAHOGHGLPI(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004620")]
	[Address(RVA = "0xC8B7FC", Offset = "0xC8B7FC", VA = "0xC8B7FC")]
	private void JKOFEGECJBC(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004624")]
	[Address(RVA = "0xC8BB48", Offset = "0xC8BB48", VA = "0xC8BB48")]
	private void FACPADKPPDK(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004625")]
	[Address(RVA = "0xC8BD58", Offset = "0xC8BD58", VA = "0xC8BD58")]
	private void KFJOIABFANO(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004626")]
	[Address(RVA = "0xC8BF7C", Offset = "0xC8BF7C", VA = "0xC8BF7C")]
	private void NFIJCGKDKAJ(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004627")]
	[Address(RVA = "0xC8C13C", Offset = "0xC8C13C", VA = "0xC8C13C")]
	private void GMBNIJILJGK(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004628")]
	[Address(RVA = "0xC8C420", Offset = "0xC8C420", VA = "0xC8C420")]
	private void CNFHAFINMMM(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004629")]
	[Address(RVA = "0xC8C490", Offset = "0xC8C490", VA = "0xC8C490")]
	private void PHCMMIFCEIE(ulong JGLJDJFHPBO, ulong DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600462A")]
	[Address(RVA = "0xC8C95C", Offset = "0xC8C95C", VA = "0xC8C95C")]
	private void PJACIOJONOI(ulong JGLJDJFHPBO, ulong DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600462B")]
	[Address(RVA = "0xC8D02C", Offset = "0xC8D02C", VA = "0xC8D02C")]
	private ResourceID PHPHECGOFKL()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600462C")]
	[Address(RVA = "0xC8D1BC", Offset = "0xC8D1BC", VA = "0xC8D1BC")]
	public bool ShowHandWeaponHitEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600462D")]
	[Address(RVA = "0xC8D344", Offset = "0xC8D344", VA = "0xC8D344")]
	public void PlayHurt(ResourceID AOOKEOAMFJO, int BOEIBGAABDL = -10000)
	{
	}

	[Token(Token = "0x600462E")]
	[Address(RVA = "0xC8D9E8", Offset = "0xC8D9E8", VA = "0xC8D9E8")]
	public void PlayHeal()
	{
	}

	[Token(Token = "0x600462F")]
	[Address(RVA = "0xC8DE38", Offset = "0xC8DE38", VA = "0xC8DE38")]
	public void OnPlayerInRoomChanged(bool JGLJDJFHPBO, bool DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004630")]
	[Address(RVA = "0xC8E0C0", Offset = "0xC8E0C0", VA = "0xC8E0C0")]
	public void OnPlayerTrainingTokenChanged(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004631")]
	[Address(RVA = "0xC8E568", Offset = "0xC8E568", VA = "0xC8E568")]
	public void OnPlayerMiniGameEffectChanged(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004632")]
	[Address(RVA = "0xC8E5FC", Offset = "0xC8E5FC", VA = "0xC8E5FC")]
	public void OnPlayerAmuseLevelChanged(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004633")]
	[Address(RVA = "0xC8E688", Offset = "0xC8E688", VA = "0xC8E688")]
	public List<uint> MysteryBoxQualityList()
	{
		return null;
	}

	[Token(Token = "0x6004634")]
	[Address(RVA = "0xC8E6E0", Offset = "0xC8E6E0", VA = "0xC8E6E0")]
	public void OnPlayerMysteryBoxQualityChanged(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004635")]
	[Address(RVA = "0xC8E928", Offset = "0xC8E928", VA = "0xC8E928")]
	public void OnPlayerPickedBountyContract(bool JGLJDJFHPBO, bool DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004636")]
	[Address(RVA = "0xC8EC44", Offset = "0xC8EC44", VA = "0xC8EC44")]
	public void OnPlayerPickedMissionBountyContract(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004637")]
	[Address(RVA = "0xC8EF60", Offset = "0xC8EF60", VA = "0xC8EF60")]
	public void OnPlayerAndrewSkillEffectCountChange(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004638")]
	[Address(RVA = "0xC8F19C", Offset = "0xC8F19C", VA = "0xC8F19C")]
	private void MINCNDGPJPI(bool JGLJDJFHPBO, bool DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004639")]
	[Address(RVA = "0xC8F340", Offset = "0xC8F340", VA = "0xC8F340", Slot = "271")]
	protected virtual void GOFCBCOIBAB(int JGLJDJFHPBO, int DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600463D")]
	[Address(RVA = "0xC8F71C", Offset = "0xC8F71C", VA = "0xC8F71C")]
	private void LDDPPFOPLCD(bool EFFDBJAFKLG, bool HCHCCLLBLLC)
	{
	}

	[Token(Token = "0x600463E")]
	[Address(RVA = "0xC8F874", Offset = "0xC8F874", VA = "0xC8F874")]
	private void IKCPMDELPFN(bool EFFDBJAFKLG, bool HCHCCLLBLLC)
	{
	}

	[Token(Token = "0x600463F")]
	[Address(RVA = "0xC8FB58", Offset = "0xC8FB58", VA = "0xC8FB58")]
	private void IOKDMDJLCDL(uint EFFDBJAFKLG, uint HCHCCLLBLLC)
	{
	}

	[Token(Token = "0x6004640")]
	[Address(RVA = "0xC8FC2C", Offset = "0xC8FC2C", VA = "0xC8FC2C")]
	private void DFAEGFGIMHG(float EFFDBJAFKLG, float HCHCCLLBLLC)
	{
	}

	[Token(Token = "0x6004641")]
	[Address(RVA = "0xC8FF24", Offset = "0xC8FF24", VA = "0xC8FF24")]
	private void LOLAMGPCJDE(float EFFDBJAFKLG, float HCHCCLLBLLC)
	{
	}

	[Token(Token = "0x6004642")]
	[Address(RVA = "0xC9009C", Offset = "0xC9009C", VA = "0xC9009C")]
	private void ILKLJMDNFIG(byte EFFDBJAFKLG, byte HCHCCLLBLLC)
	{
	}

	[Token(Token = "0x6004646")]
	[Address(RVA = "0xC902BC", Offset = "0xC902BC", VA = "0xC902BC")]
	private void HBACFEAJPEJ(byte EFFDBJAFKLG, byte HCHCCLLBLLC)
	{
	}

	[Token(Token = "0x6004647")]
	[Address(RVA = "0xC9048C", Offset = "0xC9048C", VA = "0xC9048C")]
	private void HHPJHDAJHLK(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004648")]
	[Address(RVA = "0xC905A4", Offset = "0xC905A4", VA = "0xC905A4")]
	private void NEFJJNGOMEE(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600464E")]
	[Address(RVA = "0xC90988", Offset = "0xC90988", VA = "0xC90988")]
	public Vector3 GetSyncStatePos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6004651")]
	[Address(RVA = "0xC90AE4", Offset = "0xC90AE4", VA = "0xC90AE4")]
	protected bool HGFMKLPHFKM()
	{
		return default(bool);
	}

	[Token(Token = "0x6004652")]
	[Address(RVA = "0xC90C4C", Offset = "0xC90C4C", VA = "0xC90C4C")]
	public void InitSkateboardCd(float ONOBDJGMALA, float OLBAMGCGOLF)
	{
	}

	[Token(Token = "0x6004653")]
	[Address(RVA = "0xC90D6C", Offset = "0xC90D6C", VA = "0xC90D6C")]
	private void MBPOFDIKJDM()
	{
	}

	[Token(Token = "0x6004654")]
	[Address(RVA = "0xC90DD0", Offset = "0xC90DD0", VA = "0xC90DD0")]
	public float GetSkateboardCdSecs()
	{
		return default(float);
	}

	[Token(Token = "0x6004655")]
	[Address(RVA = "0xC90E34", Offset = "0xC90E34", VA = "0xC90E34")]
	public float GetSkateboardRemainingCdSecs()
	{
		return default(float);
	}

	[Token(Token = "0x6004656")]
	[Address(RVA = "0xC90E98", Offset = "0xC90E98", VA = "0xC90E98")]
	private void LBAPINBOAIB()
	{
	}

	[Token(Token = "0x6004657")]
	[Address(RVA = "0xC90F0C", Offset = "0xC90F0C", VA = "0xC90F0C")]
	public void RequestStartSkateboarding()
	{
	}

	[Token(Token = "0x6004658")]
	[Address(RVA = "0xC912F4", Offset = "0xC912F4", VA = "0xC912F4")]
	private bool LHPADLLHFGG()
	{
		return default(bool);
	}

	[Token(Token = "0x6004659")]
	[Address(RVA = "0xC91FE8", Offset = "0xC91FE8", VA = "0xC91FE8")]
	public void RequestStopSkateboarding()
	{
	}

	[Token(Token = "0x600465A")]
	[Address(RVA = "0xC74068", Offset = "0xC74068", VA = "0xC74068")]
	public void RequestStopSkateboarding(PJGHNHFMADO OMNGGLFFMGM)
	{
	}

	[Token(Token = "0x600465B")]
	[Address(RVA = "0xC91F50", Offset = "0xC91F50", VA = "0xC91F50")]
	public void OnGetOnSkateboard(PJGHNHFMADO OMNGGLFFMGM)
	{
	}

	[Token(Token = "0x600465C")]
	[Address(RVA = "0xC9204C", Offset = "0xC9204C", VA = "0xC9204C")]
	public void OnGetOffSkateboard(PJGHNHFMADO OMNGGLFFMGM)
	{
	}

	[Token(Token = "0x600465D")]
	[Address(RVA = "0xC921E4", Offset = "0xC921E4", VA = "0xC921E4", Slot = "272")]
	protected virtual void GOPCHBGONHM()
	{
	}

	[Token(Token = "0x600465E")]
	[Address(RVA = "0xC93B68", Offset = "0xC93B68", VA = "0xC93B68", Slot = "273")]
	protected virtual void CHHIDDHMGHA()
	{
	}

	[Token(Token = "0x600465F")]
	[Address(RVA = "0xC927D4", Offset = "0xC927D4", VA = "0xC927D4")]
	private void IIECPBIFBCH()
	{
	}

	[Token(Token = "0x6004660")]
	[Address(RVA = "0xC93D68", Offset = "0xC93D68", VA = "0xC93D68")]
	private void MAGMHPMKLDI()
	{
	}

	[Token(Token = "0x6004661")]
	[Address(RVA = "0xC931A0", Offset = "0xC931A0", VA = "0xC931A0")]
	protected void GGOJFIHAKJN(bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x6004662")]
	[Address(RVA = "0xC93F5C", Offset = "0xC93F5C", VA = "0xC93F5C")]
	private static bool BDMEFGGMPFD(GameObject OMDFNKNJDII, bool ELOELMEPFCN)
	{
		return default(bool);
	}

	[Token(Token = "0x6004663")]
	[Address(RVA = "0xC92548", Offset = "0xC92548", VA = "0xC92548")]
	protected void BBOOCLIEHGE(bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x6004664")]
	[Address(RVA = "0xC926C4", Offset = "0xC926C4", VA = "0xC926C4")]
	protected void JJMCOAFPFAG(bool MPCICMINELN)
	{
	}

	[Token(Token = "0x6004665")]
	[Address(RVA = "0xC92E58", Offset = "0xC92E58", VA = "0xC92E58")]
	protected void LJKIKKFIBDJ()
	{
	}

	[Token(Token = "0x6004666")]
	[Address(RVA = "0xC92F78", Offset = "0xC92F78", VA = "0xC92F78")]
	public void SetupSkateboardCamera()
	{
	}

	[Token(Token = "0x6004667")]
	[Address(RVA = "0xC944B0", Offset = "0xC944B0", VA = "0xC944B0")]
	public bool CanSkateboardJump()
	{
		return default(bool);
	}

	[Token(Token = "0x6004668")]
	[Address(RVA = "0xC94724", Offset = "0xC94724", VA = "0xC94724")]
	public void RequestSkateboardJump()
	{
	}

	[Token(Token = "0x6004669")]
	[Address(RVA = "0xC94848", Offset = "0xC94848", VA = "0xC94848")]
	public void OnSkateboardJump()
	{
	}

	[Token(Token = "0x600466A")]
	[Address(RVA = "0xC94A08", Offset = "0xC94A08", VA = "0xC94A08")]
	private void PKGJPHCIIJG()
	{
	}

	[Token(Token = "0x600466B")]
	[Address(RVA = "0xC94C48", Offset = "0xC94C48", VA = "0xC94C48")]
	private void IBJNFAKLOCC()
	{
	}

	[Token(Token = "0x600466C")]
	[Address(RVA = "0xC94D7C", Offset = "0xC94D7C", VA = "0xC94D7C")]
	public float GetSkateboardJumpCdSecs()
	{
		return default(float);
	}

	[Token(Token = "0x600466D")]
	[Address(RVA = "0xC94DE0", Offset = "0xC94DE0", VA = "0xC94DE0")]
	public float GetSkateboardJumpRemainingCdSecs()
	{
		return default(float);
	}

	[Token(Token = "0x600466E")]
	[Address(RVA = "0xC94E44", Offset = "0xC94E44", VA = "0xC94E44")]
	public bool CanSkateboardDash()
	{
		return default(bool);
	}

	[Token(Token = "0x600466F")]
	[Address(RVA = "0xC94EBC", Offset = "0xC94EBC", VA = "0xC94EBC")]
	public void RequestSkateboardDash()
	{
	}

	[Token(Token = "0x6004670")]
	[Address(RVA = "0xC951DC", Offset = "0xC951DC", VA = "0xC951DC")]
	public void OnStateboardDash()
	{
	}

	[Token(Token = "0x6004671")]
	[Address(RVA = "0xC947D8", Offset = "0xC947D8", VA = "0xC947D8")]
	private void ICEOCBNBLBJ()
	{
	}

	[Token(Token = "0x6004672")]
	[Address(RVA = "0xC952F4", Offset = "0xC952F4", VA = "0xC952F4")]
	private void GFPBJBLDGDI()
	{
	}

	[Token(Token = "0x6004673")]
	[Address(RVA = "0xC950CC", Offset = "0xC950CC", VA = "0xC950CC")]
	private void DPNCHCEKIMG()
	{
	}

	[Token(Token = "0x6004674")]
	[Address(RVA = "0xC95420", Offset = "0xC95420", VA = "0xC95420")]
	public float GetSkateboardDashRemainingCdSecs()
	{
		return default(float);
	}

	[Token(Token = "0x6004675")]
	[Address(RVA = "0xC95484", Offset = "0xC95484", VA = "0xC95484")]
	public float GetSkateboardDashCdSecs()
	{
		return default(float);
	}

	[Token(Token = "0x6004676")]
	[Address(RVA = "0xC954E8", Offset = "0xC954E8", VA = "0xC954E8")]
	private bool EMMNMEHLOPL()
	{
		return default(bool);
	}

	[Token(Token = "0x6004677")]
	[Address(RVA = "0xC95560", Offset = "0xC95560", VA = "0xC95560", Slot = "274")]
	protected virtual void OCIILCDCKPB(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004678")]
	[Address(RVA = "0xC9564C", Offset = "0xC9564C", VA = "0xC9564C")]
	protected void MMPFLCIGMLM(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004679")]
	[Address(RVA = "0xC95F98", Offset = "0xC95F98", VA = "0xC95F98")]
	private bool CPFIDJJHDEC()
	{
		return default(bool);
	}

	[Token(Token = "0x600467A")]
	[Address(RVA = "0xC96250", Offset = "0xC96250", VA = "0xC96250", Slot = "275")]
	protected virtual void PMEIEBKGCEF()
	{
	}

	[Token(Token = "0x600467B")]
	[Address(RVA = "0xC96580", Offset = "0xC96580", VA = "0xC96580")]
	protected void PIDPMLOGKHM()
	{
	}

	[Token(Token = "0x600467C")]
	[Address(RVA = "0xC95ED8", Offset = "0xC95ED8", VA = "0xC95ED8")]
	protected void AGDJGCHAEON(out bool JLCFMAPHHAO, out bool AONJEGIKNJG)
	{
	}

	[Token(Token = "0x600467D")]
	[Address(RVA = "0xC9119C", Offset = "0xC9119C", VA = "0xC9119C")]
	private void DJKKMMBBPOF()
	{
	}

	[Token(Token = "0x600467E")]
	[Address(RVA = "0xC91248", Offset = "0xC91248", VA = "0xC91248")]
	private void PKADHAOMLCA()
	{
	}

	[Token(Token = "0x600467F")]
	[Address(RVA = "0xC91EA4", Offset = "0xC91EA4", VA = "0xC91EA4")]
	private void DKKIFIKCMNJ()
	{
	}

	[Token(Token = "0x6004680")]
	[Address(RVA = "0xC95020", Offset = "0xC95020", VA = "0xC95020")]
	private void GCNEAKFMKHG()
	{
	}

	[Token(Token = "0x6004681")]
	[Address(RVA = "0xC94678", Offset = "0xC94678", VA = "0xC94678")]
	private void CGIIFICIDDL()
	{
	}

	[Token(Token = "0x6004682")]
	[Address(RVA = "0xC92138", Offset = "0xC92138", VA = "0xC92138")]
	private void DEFKICNMKGP()
	{
	}

	[Token(Token = "0x6004683")]
	[Address(RVA = "0xC8E360", Offset = "0xC8E360", VA = "0xC8E360")]
	private void EBDFFHOBADE(string LODDOINFPPA)
	{
	}

	[Token(Token = "0x6004687")]
	[Address(RVA = "0xC9698C", Offset = "0xC9698C", VA = "0xC9698C", Slot = "276")]
	public virtual bool RequestSkySurfing()
	{
		return default(bool);
	}

	[Token(Token = "0x6004688")]
	[Address(RVA = "0xC96B20", Offset = "0xC96B20", VA = "0xC96B20", Slot = "277")]
	public virtual bool RequestSkyDiving()
	{
		return default(bool);
	}

	[Token(Token = "0x6004689")]
	[Address(RVA = "0xC96BD8", Offset = "0xC96BD8", VA = "0xC96BD8", Slot = "278")]
	protected virtual void CAJJAPOBLFB()
	{
	}

	[Token(Token = "0x600468A")]
	[Address(RVA = "0xBE6464", Offset = "0xBE6464", VA = "0xBE6464")]
	public void InitStatus(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC ELJBADBICJN)
	{
	}

	[Token(Token = "0x600468B")]
	[Address(RVA = "0xC97240", Offset = "0xC97240", VA = "0xC97240")]
	private bool NAKPCACOKEH(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL)
	{
		return default(bool);
	}

	[Token(Token = "0x600468C")]
	[Address(RVA = "0xC973E8", Offset = "0xC973E8", VA = "0xC973E8", Slot = "279")]
	public virtual void SwitchPhysXState(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC ELJBADBICJN = FBCAHNCLMDC.EPHYSXPOSE_STANDING)
	{
	}

	[Token(Token = "0x600468D")]
	[Address(RVA = "0xC97A1C", Offset = "0xC97A1C", VA = "0xC97A1C")]
	protected void EIPKOCCBJNG(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF, DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC ELJBADBICJN)
	{
	}

	[Token(Token = "0x600468E")]
	[Address(RVA = "0xBD7BD8", Offset = "0xBD7BD8", VA = "0xBD7BD8")]
	public void CheckAuxAimStatusChanged()
	{
	}

	[Token(Token = "0x600468F")]
	[Address(RVA = "0xBEBFE0", Offset = "0xBEBFE0", VA = "0xBEBFE0")]
	private void BKKJCLICECO(bool JIABGDLAICE)
	{
	}

	[Token(Token = "0x6004690")]
	[Address(RVA = "0xC97CB4", Offset = "0xC97CB4", VA = "0xC97CB4")]
	private void EDALKAMAGCD(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF, DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC ELJBADBICJN)
	{
	}

	[Token(Token = "0x6004691")]
	[Address(RVA = "0xC97FB8", Offset = "0xC97FB8", VA = "0xC97FB8", Slot = "280")]
	public virtual void SwitchPhysXPose(FBCAHNCLMDC JDDIEPOJPKL)
	{
	}

	[Token(Token = "0x6004692")]
	[Address(RVA = "0xC98054", Offset = "0xC98054", VA = "0xC98054", Slot = "281")]
	public virtual IPetsPawnAnimPlayer GetPetsPawnAnimPlayer()
	{
		return null;
	}

	[Token(Token = "0x6004699")]
	[Address(RVA = "0xC98124", Offset = "0xC98124", VA = "0xC98124", Slot = "282")]
	public virtual bool RequestStartSwimmingSurfing()
	{
		return default(bool);
	}

	[Token(Token = "0x600469A")]
	[Address(RVA = "0xC98198", Offset = "0xC98198", VA = "0xC98198", Slot = "283")]
	public virtual bool RequestStopSwimmingSurfing()
	{
		return default(bool);
	}

	[Token(Token = "0x600469B")]
	[Address(RVA = "0xC9820C", Offset = "0xC9820C", VA = "0xC9820C", Slot = "284")]
	public virtual bool RequestStartSwimming()
	{
		return default(bool);
	}

	[Token(Token = "0x600469C")]
	[Address(RVA = "0xC98360", Offset = "0xC98360", VA = "0xC98360", Slot = "285")]
	public virtual bool RequestStopSwimming()
	{
		return default(bool);
	}

	[Token(Token = "0x60046A1")]
	[Address(RVA = "0xC986AC", Offset = "0xC986AC", VA = "0xC986AC")]
	public void InitTeamParachuteInfo(object JKBNDADENMG)
	{
	}

	[Token(Token = "0x60046A2")]
	[Address(RVA = "0xC98878", Offset = "0xC98878", VA = "0xC98878")]
	public void SetTeamParachuteLeaderID(IHAAMHPPLMG KCBGGCKHIGA)
	{
	}

	[Token(Token = "0x60046A3")]
	[Address(RVA = "0xC98A60", Offset = "0xC98A60", VA = "0xC98A60")]
	private void DAEGBNAGKEF(IHAAMHPPLMG CHNELIGBABK)
	{
	}

	[Token(Token = "0x60046A4")]
	[Address(RVA = "0xC98E34", Offset = "0xC98E34", VA = "0xC98E34")]
	public void OnBecomeFree()
	{
	}

	[Token(Token = "0x60046A5")]
	[Address(RVA = "0xC99230", Offset = "0xC99230", VA = "0xC99230")]
	public void OnBecomeLeader()
	{
	}

	[Token(Token = "0x60046A6")]
	[Address(RVA = "0xC99574", Offset = "0xC99574", VA = "0xC99574")]
	public void OnBecomeFollower()
	{
	}

	[Token(Token = "0x60046A7")]
	[Address(RVA = "0xC774EC", Offset = "0xC774EC", VA = "0xC774EC")]
	private void LDICHAMJMPE(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60046A8")]
	[Address(RVA = "0xC99A24", Offset = "0xC99A24", VA = "0xC99A24")]
	private bool GAFDNABNDDD(Vector3 DMAIMAGFNNG, Vector3 OLAFGGFHKFE)
	{
		return default(bool);
	}

	[Token(Token = "0x60046A9")]
	[Address(RVA = "0xC99174", Offset = "0xC99174", VA = "0xC99174")]
	private void PKKHAKLHKIP()
	{
	}

	[Token(Token = "0x60046AB")]
	[Address(RVA = "0xC99DE8", Offset = "0xC99DE8", VA = "0xC99DE8")]
	public void ClientForceBecomeFreeMode()
	{
	}

	[Token(Token = "0x60046AC")]
	[Address(RVA = "0xC99F0C", Offset = "0xC99F0C", VA = "0xC99F0C")]
	public void NotifyServerParachuteFree()
	{
	}

	[Token(Token = "0x60046AD")]
	[Address(RVA = "0xC9A024", Offset = "0xC9A024", VA = "0xC9A024")]
	public void NotifyServerTransferLeader(IHAAMHPPLMG KCBGGCKHIGA)
	{
	}

	[Token(Token = "0x60046AE")]
	[Address(RVA = "0xC9A2C8", Offset = "0xC9A2C8", VA = "0xC9A2C8")]
	public void NotifyServerFollowLeader()
	{
	}

	[Token(Token = "0x60046AF")]
	[Address(RVA = "0xC9A4D4", Offset = "0xC9A4D4", VA = "0xC9A4D4")]
	public void OnServerTransferLeaderFail()
	{
	}

	[Token(Token = "0x60046B0")]
	[Address(RVA = "0xC9A6E8", Offset = "0xC9A6E8", VA = "0xC9A6E8")]
	public void OnServerFollowLeaderFail()
	{
	}

	[Token(Token = "0x60046B1")]
	[Address(RVA = "0xC2F7B0", Offset = "0xC2F7B0", VA = "0xC2F7B0")]
	public void ShowParachuteActionBtn()
	{
	}

	[Token(Token = "0x60046B3")]
	[Address(RVA = "0xC9A8FC", Offset = "0xC9A8FC", VA = "0xC9A8FC", Slot = "286")]
	public virtual void RequestTransform(ResourceID HCMAJGGMFPI, [Optional] GameObject OMDFNKNJDII)
	{
	}

	[Token(Token = "0x60046B4")]
	[Address(RVA = "0xC9A984", Offset = "0xC9A984", VA = "0xC9A984")]
	public void EnterTransform(ResourceID HCMAJGGMFPI, [Optional] GameObject OMDFNKNJDII)
	{
	}

	[Token(Token = "0x60046B5")]
	[Address(RVA = "0xC9AB2C", Offset = "0xC9AB2C", VA = "0xC9AB2C")]
	public void EnterTransform(GameObject JNLIMNHJEFC)
	{
	}

	[Token(Token = "0x60046B6")]
	[Address(RVA = "0xC9AF04", Offset = "0xC9AF04", VA = "0xC9AF04", Slot = "287")]
	protected virtual void PLDHDJBHLPC(JAEAODJEENM ELFLCIGJOBB)
	{
	}

	[Token(Token = "0x60046B7")]
	[Address(RVA = "0xC9B0CC", Offset = "0xC9B0CC", VA = "0xC9B0CC", Slot = "288")]
	protected virtual void HLFCFEDOOHH(JAEAODJEENM ELFLCIGJOBB)
	{
	}

	[Token(Token = "0x60046B8")]
	[Address(RVA = "0xC9B128", Offset = "0xC9B128", VA = "0xC9B128", Slot = "289")]
	public virtual void RequestExitTransform()
	{
	}

	[Token(Token = "0x60046B9")]
	[Address(RVA = "0xC9B188", Offset = "0xC9B188", VA = "0xC9B188")]
	public void ExitTransform()
	{
	}

	[Token(Token = "0x60046BA")]
	[Address(RVA = "0xC9B2D4", Offset = "0xC9B2D4", VA = "0xC9B2D4", Slot = "290")]
	protected virtual void MEJHGJPLADM()
	{
	}

	[Token(Token = "0x60046BB")]
	[Address(RVA = "0xC9AE7C", Offset = "0xC9AE7C", VA = "0xC9AE7C")]
	public void SetOrgModelVisible(bool FKHMOFHBOCC)
	{
	}

	[Token(Token = "0x60046BC")]
	[Address(RVA = "0xC9B328", Offset = "0xC9B328", VA = "0xC9B328")]
	public void UpdateTransparency(float OPKNJGBDOBB)
	{
	}

	[Token(Token = "0x60046BD")]
	[Address(RVA = "0xC9BE30", Offset = "0xC9BE30", VA = "0xC9BE30")]
	private Material AFKBONMNDGJ()
	{
		return null;
	}

	[Token(Token = "0x60046BE")]
	[Address(RVA = "0xC9BC70", Offset = "0xC9BC70", VA = "0xC9BC70")]
	private void JJDIIBBIGCF(bool PIJKEJBMOFH)
	{
	}

	[Token(Token = "0x60046BF")]
	[Address(RVA = "0xC9C358", Offset = "0xC9C358", VA = "0xC9C358")]
	private string HADEPOKHPNN(string HINJBPEDIAL)
	{
		return null;
	}

	[Token(Token = "0x60046C0")]
	[Address(RVA = "0xC9C4AC", Offset = "0xC9C4AC", VA = "0xC9C4AC")]
	private string AKJPCLIMOEG(string HINJBPEDIAL)
	{
		return null;
	}

	[Token(Token = "0x60046C1")]
	[Address(RVA = "0xC9C014", Offset = "0xC9C014", VA = "0xC9C014")]
	private void LPMMIPHIDOP(float HDKPAPDIIDN)
	{
	}

	[Token(Token = "0x60046C2")]
	[Address(RVA = "0xC9C168", Offset = "0xC9C168", VA = "0xC9C168")]
	private void CBECLIFOCHD()
	{
	}

	[Token(Token = "0x60046C3")]
	[Address(RVA = "0xC9C664", Offset = "0xC9C664", VA = "0xC9C664")]
	public void ClearTransprancy()
	{
	}

	[Token(Token = "0x60046C4")]
	[Address(RVA = "0xC9C758", Offset = "0xC9C758", VA = "0xC9C758")]
	public void SendFourSymbolSelectAttribute(byte IJMCPPFJGEP, uint MOJBFDMIMLM)
	{
	}

	[Token(Token = "0x60046C5")]
	[Address(RVA = "0xC9CB30", Offset = "0xC9CB30", VA = "0xC9CB30")]
	public void UpdateFourSymbolPendingAttributes(List<EBDLMAHABAD> EAMMBMICPCC)
	{
	}

	[Token(Token = "0x60046C6")]
	[Address(RVA = "0xC9D158", Offset = "0xC9D158", VA = "0xC9D158")]
	public void UpdateFourSymbolsSelectedAttributes(List<ILGLJBNFGKK> LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x60046C7")]
	[Address(RVA = "0xC9D34C", Offset = "0xC9D34C", VA = "0xC9D34C")]
	public List<EBDLMAHABAD> GetPlayerPendingSelectAttributes()
	{
		return null;
	}

	[Token(Token = "0x60046C8")]
	[Address(RVA = "0xC9D3A4", Offset = "0xC9D3A4", VA = "0xC9D3A4")]
	public Dictionary<byte, uint> GetPlayerSelectedAttributes()
	{
		return null;
	}

	[Token(Token = "0x60046C9")]
	[Address(RVA = "0xC9CA60", Offset = "0xC9CA60", VA = "0xC9CA60")]
	public bool HasPendingAttribute()
	{
		return default(bool);
	}

	[Token(Token = "0x60046CA")]
	[Address(RVA = "0xC1C74C", Offset = "0xC1C74C", VA = "0xC1C74C")]
	public void ShowLandingTutorialAtTutorialBR()
	{
	}

	[Token(Token = "0x60046CB")]
	[Address(RVA = "0xC9D3FC", Offset = "0xC9D3FC", VA = "0xC9D3FC")]
	private void GJDPNBDODHH(Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x60046CC")]
	[Address(RVA = "0xC9D548", Offset = "0xC9D548", VA = "0xC9D548")]
	public void TeleportBotAroundPlayerAtTutorialBR()
	{
	}

	[Token(Token = "0x60046CD")]
	[Address(RVA = "0xC9D99C", Offset = "0xC9D99C", VA = "0xC9D99C")]
	private void HPGDNELNMLC(Vector3 MOIAMOFEEOF)
	{
	}

	[Token(Token = "0x60046D2")]
	[Address(RVA = "0xC9DCE8", Offset = "0xC9DCE8", VA = "0xC9DCE8")]
	public void Test_ReSkyDiving()
	{
	}

	[Token(Token = "0x60046D3")]
	[Address(RVA = "0xC9DE08", Offset = "0xC9DE08", VA = "0xC9DE08")]
	public void Test_SwitchParachuteTexture(uint CJDMCMOODAH)
	{
	}

	[Token(Token = "0x60046D4")]
	[Address(RVA = "0xC9E038", Offset = "0xC9E038", VA = "0xC9E038")]
	public void Test_SwitchBackBag(uint KDEJLDPCPDA, uint CJIBGKIDCMM = 0u)
	{
	}

	[Token(Token = "0x60046D5")]
	[Address(RVA = "0xC9E118", Offset = "0xC9E118", VA = "0xC9E118")]
	public void Test_SwitchSkyboard(uint CJDMCMOODAH)
	{
	}

	[Token(Token = "0x60046D6")]
	[Address(RVA = "0xC9E23C", Offset = "0xC9E23C", VA = "0xC9E23C")]
	public void Test_SwitchLootBox(uint CJDMCMOODAH)
	{
	}

	[Token(Token = "0x60046D7")]
	[Address(RVA = "0xC9E2A8", Offset = "0xC9E2A8", VA = "0xC9E2A8")]
	public void Test_SwitchFlight(uint CJDMCMOODAH)
	{
	}

	[Token(Token = "0x60046D9")]
	[Address(RVA = "0xC9E9E8", Offset = "0xC9E9E8", VA = "0xC9E9E8")]
	private void MGCNEDLDNFK()
	{
	}

	[Token(Token = "0x60046DA")]
	[Address(RVA = "0xC9EAA4", Offset = "0xC9EAA4", VA = "0xC9EAA4")]
	private void CBEGJMNFFMI()
	{
	}

	[Token(Token = "0x60046DB")]
	[Address(RVA = "0xC9EBA0", Offset = "0xC9EBA0", VA = "0xC9EBA0")]
	private void IDMFKEBKCED()
	{
	}

	[Token(Token = "0x60046DC")]
	[Address(RVA = "0xC9EBA8", Offset = "0xC9EBA8", VA = "0xC9EBA8")]
	private void FBKOIIPHGMG()
	{
	}

	[Token(Token = "0x60046DD")]
	[Address(RVA = "0xC9EBB0", Offset = "0xC9EBB0", VA = "0xC9EBB0")]
	private bool EHAOLJAMIND(CSVBaseData NHJNFPKBBLI)
	{
		return default(bool);
	}

	[Token(Token = "0x60046DE")]
	[Address(RVA = "0xC9EC98", Offset = "0xC9EC98", VA = "0xC9EC98")]
	private void CFPLFPCGNCE()
	{
	}

	[Token(Token = "0x60046DF")]
	[Address(RVA = "0xC9ED60", Offset = "0xC9ED60", VA = "0xC9ED60")]
	private void LJIGIEJIAEN()
	{
	}

	[Token(Token = "0x60046E0")]
	[Address(RVA = "0xC9EEC8", Offset = "0xC9EEC8", VA = "0xC9EEC8")]
	private void MEJEDNCGNAO()
	{
	}

	[Token(Token = "0x60046E1")]
	[Address(RVA = "0xC9EED8", Offset = "0xC9EED8", VA = "0xC9EED8")]
	private void OFEBCJNCDEG()
	{
	}

	[Token(Token = "0x60046E2")]
	[Address(RVA = "0xC9EEE8", Offset = "0xC9EEE8", VA = "0xC9EEE8")]
	private static int BLHEPJKKMHF(uint NHJNFPKBBLI, uint LGALHNNDGNE)
	{
		return default(int);
	}

	[Token(Token = "0x60046E3")]
	[Address(RVA = "0xC9EF0C", Offset = "0xC9EF0C", VA = "0xC9EF0C")]
	private static int DJHPAIOCNPF(EBDLMAHABAD NHJNFPKBBLI, EBDLMAHABAD LGALHNNDGNE)
	{
		return default(int);
	}

	[Token(Token = "0x60046E4")]
	[Address(RVA = "0xC9EF54", Offset = "0xC9EF54", VA = "0xC9EF54")]
	public Vector3 _003C_003EiFixBaseProxy_GetAttackableCenterWS()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60046E5")]
	[Address(RVA = "0xC9EF68", Offset = "0xC9EF68", VA = "0xC9EF68")]
	public float _003C_003EiFixBaseProxy_GetAttackableRadius()
	{
		return default(float);
	}

	[Token(Token = "0x60046E6")]
	[Address(RVA = "0xC9EF70", Offset = "0xC9EF70", VA = "0xC9EF70")]
	public bool _003C_003EiFixBaseProxy_IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x60046E7")]
	[Address(RVA = "0xC9EF78", Offset = "0xC9EF78", VA = "0xC9EF78")]
	public bool _003C_003EiFixBaseProxy_IsStreamerVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x60046E8")]
	[Address(RVA = "0xC9EF80", Offset = "0xC9EF80", VA = "0xC9EF80")]
	public void _003C_003EiFixBaseProxy_InitEntityInfo()
	{
	}

	[Token(Token = "0x60046E9")]
	[Address(RVA = "0xC9EF88", Offset = "0xC9EF88", VA = "0xC9EF88")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x60046EA")]
	[Address(RVA = "0xC9EF90", Offset = "0xC9EF90", VA = "0xC9EF90")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x60046EB")]
	[Address(RVA = "0xC9EF98", Offset = "0xC9EF98", VA = "0xC9EF98")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x60046EC")]
	[Address(RVA = "0xC9EFA0", Offset = "0xC9EFA0", VA = "0xC9EFA0")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x60046ED")]
	[Address(RVA = "0xC9EFA8", Offset = "0xC9EFA8", VA = "0xC9EFA8")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}

	[Token(Token = "0x60046EE")]
	[Address(RVA = "0xC9EFCC", Offset = "0xC9EFCC", VA = "0xC9EFCC")]
	public void _003C_003EiFixBaseProxy_TakeHealing(int P0, IHAAMHPPLMG P1, int P2, Vector3 P3, Vector3 P4, List<float> P5)
	{
	}

	[Token(Token = "0x60046EF")]
	[Address(RVA = "0xC9F03C", Offset = "0xC9F03C", VA = "0xC9F03C")]
	public void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	[Token(Token = "0x60046F0")]
	[Address(RVA = "0xC9F070", Offset = "0xC9F070", VA = "0xC9F070")]
	public bool _003C_003EiFixBaseProxy_CanAssitByWeapon(Player P0, GPBDEDFKJNA P1)
	{
		return default(bool);
	}

	[Token(Token = "0x60046F1")]
	[Address(RVA = "0xC9F078", Offset = "0xC9F078", VA = "0xC9F078")]
	public ITransformNode _003C_003EiFixBaseProxy_GetTransformNode(string P0)
	{
		return null;
	}

	[Token(Token = "0x60046F2")]
	[Address(RVA = "0xC9F080", Offset = "0xC9F080", VA = "0xC9F080")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60046F3")]
	[Address(RVA = "0xC9F088", Offset = "0xC9F088", VA = "0xC9F088")]
	public void _003C_003EiFixBaseProxy_OnPRIInitialized()
	{
	}
}
