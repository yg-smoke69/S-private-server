using System.Collections.Generic;
using GCommon.Obfuscate;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000994")]
internal class PlayerAttributes : MonoBehaviour
{
	[Token(Token = "0x2000995")]
	public enum ALOFBFIPBIE
	{
		[Token(Token = "0x4005912")]
		Run,
		[Token(Token = "0x4005913")]
		Crouch,
		[Token(Token = "0x4005914")]
		Creep,
		[Token(Token = "0x4005915")]
		Dying,
		[Token(Token = "0x4005916")]
		Dash,
		[Token(Token = "0x4005917")]
		Swimming,
		[Token(Token = "0x4005918")]
		SwimmingSurf,
		[Token(Token = "0x4005919")]
		SwimmingDash,
		[Token(Token = "0x400591A")]
		JetFly,
		[Token(Token = "0x400591B")]
		JetFlyDash,
		[Token(Token = "0x400591C")]
		JetFlyV,
		[Token(Token = "0x400591D")]
		JetFlyVDash,
		[Token(Token = "0x400591E")]
		FlightRoamHorizontal,
		[Token(Token = "0x400591F")]
		FlightRoamVertical,
		[Token(Token = "0x4005920")]
		FlightRoamRush,
		[Token(Token = "0x4005921")]
		NB
	}

	[Token(Token = "0x2000996")]
	public enum MHEBOCMJHPI
	{
		[Token(Token = "0x4005923")]
		Moco,
		[Token(Token = "0x4005924")]
		DeliveryMarkEnemy,
		[Token(Token = "0x4005925")]
		MarkIceWallNearbyEnemy
	}

	[Token(Token = "0x2000997")]
	public enum FKPCPMHMIBD
	{
		[Token(Token = "0x4005927")]
		LimitedTimes,
		[Token(Token = "0x4005928")]
		CostHP,
		[Token(Token = "0x4005929")]
		Distance
	}

	[Token(Token = "0x2000998")]
	public enum MOBOKIKGNED
	{
		[Token(Token = "0x400592B")]
		Invalid = -1,
		[Token(Token = "0x400592C")]
		Dash,
		[Token(Token = "0x400592D")]
		ActSkill,
		[Token(Token = "0x400592E")]
		MonkeyKingSkill,
		[Token(Token = "0x400592F")]
		PRMode,
		[Token(Token = "0x4005930")]
		FrozenZone,
		[Token(Token = "0x4005931")]
		FSMode,
		[Token(Token = "0x4005932")]
		SpaceShieldSkill,
		[Token(Token = "0x4005933")]
		GameMode,
		[Token(Token = "0x4005934")]
		Inhaler,
		[Token(Token = "0x4005935")]
		HealingDance,
		[Token(Token = "0x4005936")]
		CustomRoom,
		[Token(Token = "0x4005937")]
		BuffDebris,
		[Token(Token = "0x4005938")]
		Hype,
		[Token(Token = "0x4005939")]
		DamageZone,
		[Token(Token = "0x400593A")]
		SpeedUpSkill,
		[Token(Token = "0x400593B")]
		PetShark,
		[Token(Token = "0x400593C")]
		EnergyStone,
		[Token(Token = "0x400593D")]
		AutoFlightBomb,
		[Token(Token = "0x400593E")]
		InfectionSlowDown,
		[Token(Token = "0x400593F")]
		UGCScale,
		[Token(Token = "0x4005940")]
		MoveEmote
	}

	[Token(Token = "0x2000999")]
	public enum FALFAOPADON
	{
		[Token(Token = "0x4005942")]
		None,
		[Token(Token = "0x4005943")]
		Damage,
		[Token(Token = "0x4005944")]
		JumpHeight,
		[Token(Token = "0x4005945")]
		DamageReduce,
		[Token(Token = "0x4005946")]
		CrouchSpeed,
		[Token(Token = "0x4005947")]
		Max
	}

	[Token(Token = "0x200099A")]
	public enum JMELIDNPEPN
	{
		[Token(Token = "0x4005949")]
		Default,
		[Token(Token = "0x400594A")]
		Damage_Hype,
		[Token(Token = "0x400594B")]
		Damage_GameMode,
		[Token(Token = "0x400594C")]
		Damage_BuffBehavior,
		[Token(Token = "0x400594D")]
		Damage_FSModeDamageBehavior,
		[Token(Token = "0x400594E")]
		Damage_EnergyStone,
		[Token(Token = "0x400594F")]
		Damage_UGCWeaponRate,
		[Token(Token = "0x4005950")]
		DamageReduce_GameMode,
		[Token(Token = "0x4005951")]
		DamageReduce_BuffBehavior,
		[Token(Token = "0x4005952")]
		DamageReduce_UGC,
		[Token(Token = "0x4005953")]
		JumpHeight_Hype,
		[Token(Token = "0x4005954")]
		JumpHeight_Custom,
		[Token(Token = "0x4005955")]
		JumpHeight_GameMode,
		[Token(Token = "0x4005956")]
		JumpHeight_FSModeBuff,
		[Token(Token = "0x4005957")]
		JumpHeight_Normal,
		[Token(Token = "0x4005958")]
		JumpHeight_UGC,
		[Token(Token = "0x4005959")]
		CrouchSpeed_PetSkill
	}

	[Token(Token = "0x40058CB")]
	[FieldOffset(Offset = "0xC")]
	private Player AFFLMOEAHKC;

	[Token(Token = "0x40058CC")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, float> JDAIKEIDLDP;

	[Token(Token = "0x40058CD")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<int, List<uint>> IMAIFDLALDI;

	[Token(Token = "0x40058CE")]
	[FieldOffset(Offset = "0x18")]
	private float[] LHIEEKMIGHF;

	[Token(Token = "0x40058CF")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<int, float> GDJINOPDBFG;

	[Token(Token = "0x40058D0")]
	[FieldOffset(Offset = "0x20")]
	private float CCFHKGJMHPP;

	[Token(Token = "0x40058D1")]
	[FieldOffset(Offset = "0x24")]
	private float GGHFIKJHOBC;

	[Token(Token = "0x40058D2")]
	[FieldOffset(Offset = "0x28")]
	private float HCEBDFBDECL;

	[Token(Token = "0x40058D3")]
	[FieldOffset(Offset = "0x2C")]
	private float EBDDCIOAHNN;

	[Token(Token = "0x40058D4")]
	[FieldOffset(Offset = "0x30")]
	private float KNNENJLNMBG;

	[Token(Token = "0x40058D5")]
	[FieldOffset(Offset = "0x34")]
	private int LGEAIKPHPED;

	[Token(Token = "0x40058D6")]
	[FieldOffset(Offset = "0x38")]
	private int CHPNMIKDJNB;

	[Token(Token = "0x40058D7")]
	[FieldOffset(Offset = "0x3C")]
	private int MFNMHDFFIDO;

	[Token(Token = "0x40058D8")]
	[FieldOffset(Offset = "0x40")]
	private uint MLLMOMBNFCM;

	[Token(Token = "0x40058D9")]
	[FieldOffset(Offset = "0x44")]
	private uint DBHOCGNIFLB;

	[Token(Token = "0x40058DA")]
	[FieldOffset(Offset = "0x48")]
	private int AFCLMPPKGBG;

	[Token(Token = "0x40058DB")]
	[FieldOffset(Offset = "0x4C")]
	private float KDFIBLPJDIE;

	[Token(Token = "0x40058DC")]
	[FieldOffset(Offset = "0x50")]
	private float HDFKMKOPLIJ;

	[Token(Token = "0x40058DD")]
	[FieldOffset(Offset = "0x54")]
	private float JNKDBJOMMLM;

	[Token(Token = "0x40058DE")]
	[FieldOffset(Offset = "0x58")]
	private float BOMHIOELKDP;

	[Token(Token = "0x40058DF")]
	[FieldOffset(Offset = "0x5C")]
	private float GCFDLCFJCMM;

	[Token(Token = "0x40058E0")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<uint, float> BAKMLENGNJN;

	[Token(Token = "0x40058E1")]
	[FieldOffset(Offset = "0x64")]
	private float HGEEDADNIHK;

	[Token(Token = "0x40058E2")]
	[FieldOffset(Offset = "0x68")]
	private float IBNEMGNODCD;

	[Token(Token = "0x40058E3")]
	[FieldOffset(Offset = "0x6C")]
	private float _003CNMDNKOLGDNE_003Ek__BackingField;

	[Token(Token = "0x40058E4")]
	[FieldOffset(Offset = "0x70")]
	private float FMDNGKBFFGG;

	[Token(Token = "0x40058E5")]
	[FieldOffset(Offset = "0x74")]
	private float _003CPKMIOMOHAEM_003Ek__BackingField;

	[Token(Token = "0x40058E6")]
	[FieldOffset(Offset = "0x78")]
	private float _003CBNKPMKDEMNK_003Ek__BackingField;

	[Token(Token = "0x40058E7")]
	[FieldOffset(Offset = "0x7C")]
	private float MKELDMHMOEM;

	[Token(Token = "0x40058E8")]
	[FieldOffset(Offset = "0x80")]
	private bool _003CDPBOJJONDAP_003Ek__BackingField;

	[Token(Token = "0x40058E9")]
	[FieldOffset(Offset = "0x81")]
	private bool _003CJGNEEAELNAO_003Ek__BackingField;

	[Token(Token = "0x40058EA")]
	[FieldOffset(Offset = "0x84")]
	private float CFFFPJNCIDE;

	[Token(Token = "0x40058EB")]
	[FieldOffset(Offset = "0x88")]
	private float DKIGEJBMHMG;

	[Token(Token = "0x40058EC")]
	[FieldOffset(Offset = "0x8C")]
	private float GIHLNOJKENB;

	[Token(Token = "0x40058ED")]
	[FieldOffset(Offset = "0x90")]
	public IHAAMHPPLMG EffectOwner;

	[Token(Token = "0x40058EE")]
	[FieldOffset(Offset = "0xA8")]
	public bool ShowEnermyTargetOnMap;

	[Token(Token = "0x40058EF")]
	[FieldOffset(Offset = "0xA9")]
	public bool ShowEnermyTargetOnHud;

	[Token(Token = "0x40058F0")]
	[FieldOffset(Offset = "0xAC")]
	private Dictionary<int, BKJHKEAAEMG> MDAJNCNODLN;

	[Token(Token = "0x40058F1")]
	[FieldOffset(Offset = "0xB0")]
	private float DPFCEOKBPPP;

	[Token(Token = "0x40058F2")]
	[FieldOffset(Offset = "0xB4")]
	private float GJIAJAPMFNA;

	[Token(Token = "0x40058F3")]
	[FieldOffset(Offset = "0xB8")]
	private float HOLEAJMKMAF;

	[Token(Token = "0x40058F4")]
	[FieldOffset(Offset = "0xBC")]
	private float HJHGMGAMKBD;

	[Token(Token = "0x40058F5")]
	[FieldOffset(Offset = "0xC0")]
	private int JOMJAMEDBEJ;

	[Token(Token = "0x40058F6")]
	[FieldOffset(Offset = "0xC4")]
	private int NDKFOKCHPFP;

	[Token(Token = "0x40058F7")]
	[FieldOffset(Offset = "0xC8")]
	private float ODMOLMHDNGI;

	[Token(Token = "0x40058F8")]
	[FieldOffset(Offset = "0xCC")]
	private float KJCPIKMFNFL;

	[Token(Token = "0x40058F9")]
	[FieldOffset(Offset = "0xD0")]
	private float BCMOCFECJFE;

	[Token(Token = "0x40058FA")]
	[FieldOffset(Offset = "0xD4")]
	private float INGPBJOJOOH;

	[Token(Token = "0x40058FB")]
	[FieldOffset(Offset = "0xD8")]
	private float HAFFAIGGHPA;

	[Token(Token = "0x40058FC")]
	[FieldOffset(Offset = "0xDC")]
	private float MCHAOKCFIMM;

	[Token(Token = "0x40058FD")]
	[FieldOffset(Offset = "0xE0")]
	private float MCEMJCCBNPO;

	[Token(Token = "0x40058FE")]
	[FieldOffset(Offset = "0xE4")]
	private float _003CNPAOLMNJCJJ_003Ek__BackingField;

	[Token(Token = "0x40058FF")]
	[FieldOffset(Offset = "0xE8")]
	private float _003CBCPEAIHJCJC_003Ek__BackingField;

	[Token(Token = "0x4005900")]
	[FieldOffset(Offset = "0xEC")]
	private float _003CFDEDOIJIPEC_003Ek__BackingField;

	[Token(Token = "0x4005901")]
	[FieldOffset(Offset = "0xF0")]
	public float GrenadeThrowSpeedScale;

	[Token(Token = "0x4005902")]
	[FieldOffset(Offset = "0xF4")]
	private float ACKPGOCHNMM;

	[Token(Token = "0x4005903")]
	[FieldOffset(Offset = "0xF8")]
	public int DamageDecreaseRateInPreparation;

	[Token(Token = "0x4005904")]
	[FieldOffset(Offset = "0xFC")]
	private float CAAIOBMGPLG;

	[Token(Token = "0x4005905")]
	[FieldOffset(Offset = "0x100")]
	private float ACJKFCHHBDI;

	[Token(Token = "0x4005906")]
	[FieldOffset(Offset = "0x104")]
	private float PBBIOODHIIP;

	[Token(Token = "0x4005907")]
	[FieldOffset(Offset = "0x108")]
	private float LHBMEFKEJAA;

	[Token(Token = "0x4005908")]
	[FieldOffset(Offset = "0x10C")]
	private float HFMGCFKPJJP;

	[Token(Token = "0x4005909")]
	[FieldOffset(Offset = "0x110")]
	private float JJDEHJCHBMK;

	[Token(Token = "0x400590A")]
	[FieldOffset(Offset = "0x114")]
	public List<JKADOHMKGHI> DecreaseDamageList;

	[Token(Token = "0x400590B")]
	[FieldOffset(Offset = "0x118")]
	public Dictionary<uint, float> PetSharkSpeed;

	[Token(Token = "0x400590C")]
	[FieldOffset(Offset = "0x11C")]
	private float PEHAPLFHOON;

	[Token(Token = "0x400590D")]
	[FieldOffset(Offset = "0x120")]
	private float GOICCFLILAN;

	[Token(Token = "0x400590E")]
	[FieldOffset(Offset = "0x124")]
	private float KBMOPCNACAG;

	[Token(Token = "0x400590F")]
	[FieldOffset(Offset = "0x128")]
	private float DDONJJGEJOG;

	[Token(Token = "0x4005910")]
	[FieldOffset(Offset = "0x12C")]
	private Dictionary<IHAAMHPPLMG, float> DBNBMLHHEDF;

	[Token(Token = "0x170005B7")]
	public Player JGHEGHHINPA
	{
		[Token(Token = "0x60048F9")]
		[Address(RVA = "0x25EA03C", Offset = "0x25EA03C", VA = "0x25EA03C")]
		set
		{
		}
	}

	[Token(Token = "0x170005B8")]
	public float IOHFBFMJNJB
	{
		[Token(Token = "0x6004904")]
		[Address(RVA = "0x25EB91C", Offset = "0x25EB91C", VA = "0x25EB91C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004905")]
		[Address(RVA = "0x25EB974", Offset = "0x25EB974", VA = "0x25EB974")]
		set
		{
		}
	}

	[Token(Token = "0x170005B9")]
	public float NMBLCAACBJO
	{
		[Token(Token = "0x6004906")]
		[Address(RVA = "0x25EB9D8", Offset = "0x25EB9D8", VA = "0x25EB9D8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004907")]
		[Address(RVA = "0x25EBA40", Offset = "0x25EBA40", VA = "0x25EBA40")]
		set
		{
		}
	}

	[Token(Token = "0x170005BA")]
	public float KGOENPDDHEE
	{
		[Token(Token = "0x6004909")]
		[Address(RVA = "0x25EBB08", Offset = "0x25EBB08", VA = "0x25EBB08")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600490A")]
		[Address(RVA = "0x25EBB60", Offset = "0x25EBB60", VA = "0x25EBB60")]
		set
		{
		}
	}

	[Token(Token = "0x170005BB")]
	public float LCMGDFPHBBB
	{
		[Token(Token = "0x600490B")]
		[Address(RVA = "0x25EBBC4", Offset = "0x25EBBC4", VA = "0x25EBBC4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600490C")]
		[Address(RVA = "0x25EBC1C", Offset = "0x25EBC1C", VA = "0x25EBC1C")]
		set
		{
		}
	}

	[Token(Token = "0x170005BC")]
	public int ACICKHHOHKO
	{
		[Token(Token = "0x600490D")]
		[Address(RVA = "0x25EBC80", Offset = "0x25EBC80", VA = "0x25EBC80")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600490E")]
		[Address(RVA = "0x25EBCD8", Offset = "0x25EBCD8", VA = "0x25EBCD8")]
		set
		{
		}
	}

	[Token(Token = "0x170005BD")]
	public int ENBAIGIHNIA
	{
		[Token(Token = "0x600490F")]
		[Address(RVA = "0x25EBD38", Offset = "0x25EBD38", VA = "0x25EBD38")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004910")]
		[Address(RVA = "0x25EBD90", Offset = "0x25EBD90", VA = "0x25EBD90")]
		set
		{
		}
	}

	[Token(Token = "0x170005BE")]
	public int BDAJDAFECON
	{
		[Token(Token = "0x6004911")]
		[Address(RVA = "0x25EBDF0", Offset = "0x25EBDF0", VA = "0x25EBDF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004912")]
		[Address(RVA = "0x25EBE48", Offset = "0x25EBE48", VA = "0x25EBE48")]
		set
		{
		}
	}

	[Token(Token = "0x170005BF")]
	public uint IJFLFKNLLFF
	{
		[Token(Token = "0x6004913")]
		[Address(RVA = "0x25EBEA8", Offset = "0x25EBEA8", VA = "0x25EBEA8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6004914")]
		[Address(RVA = "0x25EBF00", Offset = "0x25EBF00", VA = "0x25EBF00")]
		set
		{
		}
	}

	[Token(Token = "0x170005C0")]
	public uint OAGIKPJLEKH
	{
		[Token(Token = "0x6004915")]
		[Address(RVA = "0x25EBF60", Offset = "0x25EBF60", VA = "0x25EBF60")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6004916")]
		[Address(RVA = "0x25EBFB8", Offset = "0x25EBFB8", VA = "0x25EBFB8")]
		set
		{
		}
	}

	[Token(Token = "0x170005C1")]
	public int CHPNNHOMBOC
	{
		[Token(Token = "0x6004917")]
		[Address(RVA = "0x25EC018", Offset = "0x25EC018", VA = "0x25EC018")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004918")]
		[Address(RVA = "0x25EC070", Offset = "0x25EC070", VA = "0x25EC070")]
		set
		{
		}
	}

	[Token(Token = "0x170005C2")]
	public float LDLHCJLLAOA
	{
		[Token(Token = "0x6004919")]
		[Address(RVA = "0x25EC0D0", Offset = "0x25EC0D0", VA = "0x25EC0D0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600491A")]
		[Address(RVA = "0x25EC128", Offset = "0x25EC128", VA = "0x25EC128")]
		set
		{
		}
	}

	[Token(Token = "0x170005C3")]
	public float BFALKOHMEAM
	{
		[Token(Token = "0x600491C")]
		[Address(RVA = "0x25EC1E4", Offset = "0x25EC1E4", VA = "0x25EC1E4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600491D")]
		[Address(RVA = "0x25EC23C", Offset = "0x25EC23C", VA = "0x25EC23C")]
		set
		{
		}
	}

	[Token(Token = "0x170005C4")]
	public float AILLJCECHNH
	{
		[Token(Token = "0x600491E")]
		[Address(RVA = "0x25EC2A0", Offset = "0x25EC2A0", VA = "0x25EC2A0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600491F")]
		[Address(RVA = "0x25EC2F8", Offset = "0x25EC2F8", VA = "0x25EC2F8")]
		set
		{
		}
	}

	[Token(Token = "0x170005C5")]
	public float MOGOKIANLIB
	{
		[Token(Token = "0x6004920")]
		[Address(RVA = "0x25EC35C", Offset = "0x25EC35C", VA = "0x25EC35C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004921")]
		[Address(RVA = "0x25EC3B4", Offset = "0x25EC3B4", VA = "0x25EC3B4")]
		set
		{
		}
	}

	[Token(Token = "0x170005C6")]
	public float DDHPOAPJMKM
	{
		[Token(Token = "0x6004922")]
		[Address(RVA = "0x25EC418", Offset = "0x25EC418", VA = "0x25EC418")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004923")]
		[Address(RVA = "0x25EC470", Offset = "0x25EC470", VA = "0x25EC470")]
		set
		{
		}
	}

	[Token(Token = "0x170005C7")]
	public float MEBLDPBCAHD
	{
		[Token(Token = "0x6004926")]
		[Address(RVA = "0x25EC6A0", Offset = "0x25EC6A0", VA = "0x25EC6A0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004927")]
		[Address(RVA = "0x25EC6F8", Offset = "0x25EC6F8", VA = "0x25EC6F8")]
		set
		{
		}
	}

	[Token(Token = "0x170005C8")]
	public float LOJNBNMOLMD
	{
		[Token(Token = "0x6004928")]
		[Address(RVA = "0x25EC75C", Offset = "0x25EC75C", VA = "0x25EC75C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004929")]
		[Address(RVA = "0x25EC7B4", Offset = "0x25EC7B4", VA = "0x25EC7B4")]
		set
		{
		}
	}

	[Token(Token = "0x170005C9")]
	public float COFDOPHFOBA
	{
		[Token(Token = "0x600492A")]
		[Address(RVA = "0x25EC818", Offset = "0x25EC818", VA = "0x25EC818")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600492B")]
		[Address(RVA = "0x25EC820", Offset = "0x25EC820", VA = "0x25EC820")]
		set
		{
		}
	}

	[Token(Token = "0x170005CA")]
	public float JHFDGFIFBJC
	{
		[Token(Token = "0x600492C")]
		[Address(RVA = "0x25EC828", Offset = "0x25EC828", VA = "0x25EC828")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600492D")]
		[Address(RVA = "0x25EC880", Offset = "0x25EC880", VA = "0x25EC880")]
		set
		{
		}
	}

	[Token(Token = "0x170005CB")]
	public float BCMDFJGNIMP
	{
		[Token(Token = "0x600492E")]
		[Address(RVA = "0x25EC8E4", Offset = "0x25EC8E4", VA = "0x25EC8E4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600492F")]
		[Address(RVA = "0x25EC8EC", Offset = "0x25EC8EC", VA = "0x25EC8EC")]
		set
		{
		}
	}

	[Token(Token = "0x170005CC")]
	public float LHOCINEFNPM
	{
		[Token(Token = "0x6004930")]
		[Address(RVA = "0x25EC8F4", Offset = "0x25EC8F4", VA = "0x25EC8F4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004931")]
		[Address(RVA = "0x25EC8FC", Offset = "0x25EC8FC", VA = "0x25EC8FC")]
		set
		{
		}
	}

	[Token(Token = "0x170005CD")]
	public float ENOGGDAMIGH
	{
		[Token(Token = "0x6004933")]
		[Address(RVA = "0x25EC95C", Offset = "0x25EC95C", VA = "0x25EC95C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004934")]
		[Address(RVA = "0x25EC9B4", Offset = "0x25EC9B4", VA = "0x25EC9B4")]
		set
		{
		}
	}

	[Token(Token = "0x170005CE")]
	public bool AINCJGAMCAJ
	{
		[Token(Token = "0x6004935")]
		[Address(RVA = "0x25ECA18", Offset = "0x25ECA18", VA = "0x25ECA18")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004936")]
		[Address(RVA = "0x25ECA20", Offset = "0x25ECA20", VA = "0x25ECA20")]
		set
		{
		}
	}

	[Token(Token = "0x170005CF")]
	public bool FMGEEBGPCAI
	{
		[Token(Token = "0x6004937")]
		[Address(RVA = "0x25ECA28", Offset = "0x25ECA28", VA = "0x25ECA28")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004938")]
		[Address(RVA = "0x25ECA30", Offset = "0x25ECA30", VA = "0x25ECA30")]
		set
		{
		}
	}

	[Token(Token = "0x170005D0")]
	public float FCOJMBCNDFK
	{
		[Token(Token = "0x600493B")]
		[Address(RVA = "0x25EB8C4", Offset = "0x25EB8C4", VA = "0x25EB8C4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600493C")]
		[Address(RVA = "0x25ECAE8", Offset = "0x25ECAE8", VA = "0x25ECAE8")]
		set
		{
		}
	}

	[Token(Token = "0x170005D1")]
	public float GIPGKEMEAPG
	{
		[Token(Token = "0x600493D")]
		[Address(RVA = "0x25ECB4C", Offset = "0x25ECB4C", VA = "0x25ECB4C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600493E")]
		[Address(RVA = "0x25ECBA4", Offset = "0x25ECBA4", VA = "0x25ECBA4")]
		set
		{
		}
	}

	[Token(Token = "0x170005D2")]
	public float GKFJPIPPHMB
	{
		[Token(Token = "0x600493F")]
		[Address(RVA = "0x25ECC08", Offset = "0x25ECC08", VA = "0x25ECC08")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004940")]
		[Address(RVA = "0x25ECC60", Offset = "0x25ECC60", VA = "0x25ECC60")]
		set
		{
		}
	}

	[Token(Token = "0x170005D3")]
	public float HGDNCCKKDMA
	{
		[Token(Token = "0x6004945")]
		[Address(RVA = "0x25ED130", Offset = "0x25ED130", VA = "0x25ED130")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004946")]
		[Address(RVA = "0x25ED188", Offset = "0x25ED188", VA = "0x25ED188")]
		set
		{
		}
	}

	[Token(Token = "0x170005D4")]
	public float HLLEGNKAMFL
	{
		[Token(Token = "0x6004947")]
		[Address(RVA = "0x25ED1EC", Offset = "0x25ED1EC", VA = "0x25ED1EC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004948")]
		[Address(RVA = "0x25ED244", Offset = "0x25ED244", VA = "0x25ED244")]
		set
		{
		}
	}

	[Token(Token = "0x170005D5")]
	public float GJGFCKPOIBO
	{
		[Token(Token = "0x6004949")]
		[Address(RVA = "0x25ED2A8", Offset = "0x25ED2A8", VA = "0x25ED2A8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600494A")]
		[Address(RVA = "0x25ED300", Offset = "0x25ED300", VA = "0x25ED300")]
		set
		{
		}
	}

	[Token(Token = "0x170005D6")]
	public float JPBGFIMJPHD
	{
		[Token(Token = "0x6004953")]
		[Address(RVA = "0x25ED6C4", Offset = "0x25ED6C4", VA = "0x25ED6C4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004954")]
		[Address(RVA = "0x25ED71C", Offset = "0x25ED71C", VA = "0x25ED71C")]
		set
		{
		}
	}

	[Token(Token = "0x170005D7")]
	public float IFIBMCPPOLO
	{
		[Token(Token = "0x6004955")]
		[Address(RVA = "0x25ED780", Offset = "0x25ED780", VA = "0x25ED780")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004956")]
		[Address(RVA = "0x25ED7D8", Offset = "0x25ED7D8", VA = "0x25ED7D8")]
		set
		{
		}
	}

	[Token(Token = "0x170005D8")]
	public float ALKJDCPPHBB
	{
		[Token(Token = "0x6004957")]
		[Address(RVA = "0x25ED83C", Offset = "0x25ED83C", VA = "0x25ED83C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004958")]
		[Address(RVA = "0x25ED894", Offset = "0x25ED894", VA = "0x25ED894")]
		set
		{
		}
	}

	[Token(Token = "0x170005D9")]
	public float GGKENGLPALJ
	{
		[Token(Token = "0x6004959")]
		[Address(RVA = "0x25D4130", Offset = "0x25D4130", VA = "0x25D4130")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600495A")]
		[Address(RVA = "0x25ED8F8", Offset = "0x25ED8F8", VA = "0x25ED8F8")]
		set
		{
		}
	}

	[Token(Token = "0x170005DA")]
	public float CFMPOCOMLKH
	{
		[Token(Token = "0x600495B")]
		[Address(RVA = "0x25ED95C", Offset = "0x25ED95C", VA = "0x25ED95C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600495C")]
		[Address(RVA = "0x25ED9B4", Offset = "0x25ED9B4", VA = "0x25ED9B4")]
		set
		{
		}
	}

	[Token(Token = "0x170005DB")]
	public float MAJEFOHIPHK
	{
		[Token(Token = "0x600495D")]
		[Address(RVA = "0x25EDA18", Offset = "0x25EDA18", VA = "0x25EDA18")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600495E")]
		[Address(RVA = "0x25EDA70", Offset = "0x25EDA70", VA = "0x25EDA70")]
		set
		{
		}
	}

	[Token(Token = "0x170005DC")]
	public float CPBBGAFNECJ
	{
		[Token(Token = "0x600495F")]
		[Address(RVA = "0x25EDAD4", Offset = "0x25EDAD4", VA = "0x25EDAD4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004960")]
		[Address(RVA = "0x25EDB2C", Offset = "0x25EDB2C", VA = "0x25EDB2C")]
		set
		{
		}
	}

	[Token(Token = "0x170005DD")]
	public float OANIADPEAOG
	{
		[Token(Token = "0x6004962")]
		[Address(RVA = "0x25EDB98", Offset = "0x25EDB98", VA = "0x25EDB98")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004961")]
		[Address(RVA = "0x25EDB90", Offset = "0x25EDB90", VA = "0x25EDB90")]
		set
		{
		}
	}

	[Token(Token = "0x170005DE")]
	public float GINAPIIAPLL
	{
		[Token(Token = "0x6004964")]
		[Address(RVA = "0x25EDBA8", Offset = "0x25EDBA8", VA = "0x25EDBA8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004963")]
		[Address(RVA = "0x25EDBA0", Offset = "0x25EDBA0", VA = "0x25EDBA0")]
		set
		{
		}
	}

	[Token(Token = "0x170005DF")]
	public float FALLPMGHJFM
	{
		[Token(Token = "0x6004966")]
		[Address(RVA = "0x25EDBB8", Offset = "0x25EDBB8", VA = "0x25EDBB8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004965")]
		[Address(RVA = "0x25EDBB0", Offset = "0x25EDBB0", VA = "0x25EDBB0")]
		set
		{
		}
	}

	[Token(Token = "0x170005E0")]
	public float ELLECDIABMJ
	{
		[Token(Token = "0x600496A")]
		[Address(RVA = "0x25EDE6C", Offset = "0x25EDE6C", VA = "0x25EDE6C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600496B")]
		[Address(RVA = "0x25EDEC4", Offset = "0x25EDEC4", VA = "0x25EDEC4")]
		set
		{
		}
	}

	[Token(Token = "0x170005E1")]
	public float CIBDACPBEBK
	{
		[Token(Token = "0x6004972")]
		[Address(RVA = "0x25EEDB0", Offset = "0x25EEDB0", VA = "0x25EEDB0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004973")]
		[Address(RVA = "0x25EEE08", Offset = "0x25EEE08", VA = "0x25EEE08")]
		set
		{
		}
	}

	[Token(Token = "0x170005E2")]
	public float MBNCHBDONOA
	{
		[Token(Token = "0x6004974")]
		[Address(RVA = "0x25EEE6C", Offset = "0x25EEE6C", VA = "0x25EEE6C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004975")]
		[Address(RVA = "0x25EEEC4", Offset = "0x25EEEC4", VA = "0x25EEEC4")]
		set
		{
		}
	}

	[Token(Token = "0x170005E3")]
	public float LNFGBLJGBAL
	{
		[Token(Token = "0x6004976")]
		[Address(RVA = "0x25EEF28", Offset = "0x25EEF28", VA = "0x25EEF28")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004977")]
		[Address(RVA = "0x25EEF80", Offset = "0x25EEF80", VA = "0x25EEF80")]
		set
		{
		}
	}

	[Token(Token = "0x170005E4")]
	public float KFNFJCLDFME
	{
		[Token(Token = "0x6004978")]
		[Address(RVA = "0x25EEFE4", Offset = "0x25EEFE4", VA = "0x25EEFE4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004979")]
		[Address(RVA = "0x25EF03C", Offset = "0x25EF03C", VA = "0x25EF03C")]
		set
		{
		}
	}

	[Token(Token = "0x170005E5")]
	public float FCFNODILCBD
	{
		[Token(Token = "0x600497A")]
		[Address(RVA = "0x25EF0A0", Offset = "0x25EF0A0", VA = "0x25EF0A0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600497B")]
		[Address(RVA = "0x25EF0F8", Offset = "0x25EF0F8", VA = "0x25EF0F8")]
		set
		{
		}
	}

	[Token(Token = "0x170005E6")]
	public float GNMGGKGAKFH
	{
		[Token(Token = "0x600497C")]
		[Address(RVA = "0x25EF15C", Offset = "0x25EF15C", VA = "0x25EF15C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600497D")]
		[Address(RVA = "0x25EF1B4", Offset = "0x25EF1B4", VA = "0x25EF1B4")]
		set
		{
		}
	}

	[Token(Token = "0x170005E7")]
	public float HKNOHIHJKFN
	{
		[Token(Token = "0x600497F")]
		[Address(RVA = "0x25EF4E4", Offset = "0x25EF4E4", VA = "0x25EF4E4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004980")]
		[Address(RVA = "0x25EF53C", Offset = "0x25EF53C", VA = "0x25EF53C")]
		set
		{
		}
	}

	[Token(Token = "0x170005E8")]
	public float IHFDBPKBEMH
	{
		[Token(Token = "0x6004981")]
		[Address(RVA = "0x25EF5A0", Offset = "0x25EF5A0", VA = "0x25EF5A0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004982")]
		[Address(RVA = "0x25EF5F8", Offset = "0x25EF5F8", VA = "0x25EF5F8")]
		set
		{
		}
	}

	[Token(Token = "0x170005E9")]
	public float MLKGGAIPGEN
	{
		[Token(Token = "0x6004983")]
		[Address(RVA = "0x25EF65C", Offset = "0x25EF65C", VA = "0x25EF65C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6004984")]
		[Address(RVA = "0x25EF6B4", Offset = "0x25EF6B4", VA = "0x25EF6B4")]
		set
		{
		}
	}

	[Token(Token = "0x170005EA")]
	public float DFOMAKICMBF
	{
		[Token(Token = "0x6004986")]
		[Address(RVA = "0x25EFA68", Offset = "0x25EFA68", VA = "0x25EFA68")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60048F8")]
	[Address(RVA = "0x25E9DB4", Offset = "0x25E9DB4", VA = "0x25E9DB4")]
	public PlayerAttributes()
	{
	}

	[Token(Token = "0x60048FA")]
	[Address(RVA = "0x25EA09C", Offset = "0x25EA09C", VA = "0x25EA09C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60048FB")]
	[Address(RVA = "0x25EA1A4", Offset = "0x25EA1A4", VA = "0x25EA1A4")]
	public void SetSpecialRunSpeedScale(MOBOKIKGNED PMGBACFJIHO, float CHADOJMOHFJ)
	{
	}

	[Token(Token = "0x60048FC")]
	[Address(RVA = "0x25EA28C", Offset = "0x25EA28C", VA = "0x25EA28C")]
	public void ResetSpecialRunSpeedScale(MOBOKIKGNED PMGBACFJIHO)
	{
	}

	[Token(Token = "0x60048FD")]
	[Address(RVA = "0x25EA390", Offset = "0x25EA390", VA = "0x25EA390")]
	public float GetSpecialRunSpeedScale(MOBOKIKGNED PMGBACFJIHO)
	{
		return default(float);
	}

	[Token(Token = "0x60048FE")]
	[Address(RVA = "0x25EA400", Offset = "0x25EA400", VA = "0x25EA400")]
	public float GetSpecialRunSpeedScale(MOBOKIKGNED PMGBACFJIHO, float KJOIOGILOBN)
	{
		return default(float);
	}

	[Token(Token = "0x60048FF")]
	[Address(RVA = "0x25EA524", Offset = "0x25EA524", VA = "0x25EA524")]
	public void SetWeaponRunSpeedScale(int PMGBACFJIHO, float CHADOJMOHFJ)
	{
	}

	[Token(Token = "0x6004900")]
	[Address(RVA = "0x25EA600", Offset = "0x25EA600", VA = "0x25EA600")]
	public float GetWeaponRunSpeedScale(int PMGBACFJIHO)
	{
		return default(float);
	}

	[Token(Token = "0x6004901")]
	[Address(RVA = "0x25EA6C4", Offset = "0x25EA6C4", VA = "0x25EA6C4")]
	private float MNCMFCAAJKK()
	{
		return default(float);
	}

	[Token(Token = "0x6004902")]
	[Address(RVA = "0x25EAC94", Offset = "0x25EAC94", VA = "0x25EAC94")]
	public float GetSpeedByType(ALOFBFIPBIE OPJKJHBKLGN)
	{
		return default(float);
	}

	[Token(Token = "0x6004903")]
	[Address(RVA = "0x25EAA60", Offset = "0x25EAA60", VA = "0x25EAA60")]
	private float PCFAIFBHFFO()
	{
		return default(float);
	}

	[Token(Token = "0x6004908")]
	[Address(RVA = "0x25EBAA4", Offset = "0x25EBAA4", VA = "0x25EBAA4")]
	public void SetDebugSpeedScale(float IOOPPDAAMEP)
	{
	}

	[Token(Token = "0x600491B")]
	[Address(RVA = "0x25EC18C", Offset = "0x25EC18C", VA = "0x25EC18C")]
	public float GetBiteArmorRate()
	{
		return default(float);
	}

	[Token(Token = "0x6004924")]
	[Address(RVA = "0x25EC4D4", Offset = "0x25EC4D4", VA = "0x25EC4D4")]
	public Dictionary<uint, float> GetFSModeWeaponTypeDamageRate()
	{
		return null;
	}

	[Token(Token = "0x6004925")]
	[Address(RVA = "0x25EC52C", Offset = "0x25EC52C", VA = "0x25EC52C")]
	public void UpFSModeWeaponTypeDamageRate(bool GJMAOIBIEBI, uint JOGHOHLEJFL, float LCENDNNCJNH)
	{
	}

	[Token(Token = "0x6004932")]
	[Address(RVA = "0x25EC904", Offset = "0x25EC904", VA = "0x25EC904")]
	public float GetDamageReductionRate()
	{
		return default(float);
	}

	[Token(Token = "0x6004939")]
	[Address(RVA = "0x25ECA38", Offset = "0x25ECA38", VA = "0x25ECA38")]
	public bool IsUnKillable()
	{
		return default(bool);
	}

	[Token(Token = "0x600493A")]
	[Address(RVA = "0x25ECA90", Offset = "0x25ECA90", VA = "0x25ECA90")]
	public float GetDamageRate()
	{
		return default(float);
	}

	[Token(Token = "0x6004941")]
	[Address(RVA = "0x25ECCC4", Offset = "0x25ECCC4", VA = "0x25ECCC4")]
	public float GetScatterRate()
	{
		return default(float);
	}

	[Token(Token = "0x6004942")]
	[Address(RVA = "0x25ECE28", Offset = "0x25ECE28", VA = "0x25ECE28")]
	public void AddReloadScale(int CDAKGFIJNBE, float IFBOIMOMEGD)
	{
	}

	[Token(Token = "0x6004943")]
	[Address(RVA = "0x25ECF98", Offset = "0x25ECF98", VA = "0x25ECF98")]
	public float GetReloadScale(int CDAKGFIJNBE)
	{
		return default(float);
	}

	[Token(Token = "0x6004944")]
	[Address(RVA = "0x25EB760", Offset = "0x25EB760", VA = "0x25EB760")]
	public BKJHKEAAEMG GetScaleMapByScaleType(FALFAOPADON PMGBACFJIHO)
	{
		return null;
	}

	[Token(Token = "0x600494B")]
	[Address(RVA = "0x25ED364", Offset = "0x25ED364", VA = "0x25ED364")]
	public void UpdateExtraLimitedTimeDamageRate(float LBMGGMBKAEH)
	{
	}

	[Token(Token = "0x600494C")]
	[Address(RVA = "0x25ED3D4", Offset = "0x25ED3D4", VA = "0x25ED3D4")]
	public float GetExtraLimitedTimesDamageRate()
	{
		return default(float);
	}

	[Token(Token = "0x600494D")]
	[Address(RVA = "0x25ED42C", Offset = "0x25ED42C", VA = "0x25ED42C")]
	public void UpdateExtraDamageLimitedTimes(int MIDELCNDAFJ)
	{
	}

	[Token(Token = "0x600494E")]
	[Address(RVA = "0x25ED498", Offset = "0x25ED498", VA = "0x25ED498")]
	public int GetDamageLimitedTimes()
	{
		return default(int);
	}

	[Token(Token = "0x600494F")]
	[Address(RVA = "0x25ED4F0", Offset = "0x25ED4F0", VA = "0x25ED4F0")]
	public void UpdateDamageEffectTimes(int MIDELCNDAFJ)
	{
	}

	[Token(Token = "0x6004950")]
	[Address(RVA = "0x25ED55C", Offset = "0x25ED55C", VA = "0x25ED55C")]
	public int GetDamageEffectTimes()
	{
		return default(int);
	}

	[Token(Token = "0x6004951")]
	[Address(RVA = "0x25ED5B4", Offset = "0x25ED5B4", VA = "0x25ED5B4")]
	public bool HasUnusedLimitedTimesDamage()
	{
		return default(bool);
	}

	[Token(Token = "0x6004952")]
	[Address(RVA = "0x25ED644", Offset = "0x25ED644", VA = "0x25ED644")]
	public bool IsLimitedTimesDamageValidWeapon(GPBDEDFKJNA.ENBHOKKHLPG CDAKGFIJNBE)
	{
		return default(bool);
	}

	[Token(Token = "0x6004967")]
	[Address(RVA = "0x25EDBC0", Offset = "0x25EDBC0", VA = "0x25EDBC0")]
	public float GetSkySurfingMaxHSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x6004968")]
	[Address(RVA = "0x25EDCA4", Offset = "0x25EDCA4", VA = "0x25EDCA4")]
	public float GetSkyDivingMaxHSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x6004969")]
	[Address(RVA = "0x25EDD88", Offset = "0x25EDD88", VA = "0x25EDD88")]
	public float GetParachutingMaxVSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x600496C")]
	[Address(RVA = "0x25EDF28", Offset = "0x25EDF28", VA = "0x25EDF28")]
	public bool GetCurrentMarkState(uint ALDPCPCNDMO)
	{
		return default(bool);
	}

	[Token(Token = "0x600496D")]
	[Address(RVA = "0x25EE1C8", Offset = "0x25EE1C8", VA = "0x25EE1C8")]
	public void AddMarkState(MHEBOCMJHPI AHNNHNBJBOB, uint IDNEFEOPGIF)
	{
	}

	[Token(Token = "0x600496E")]
	[Address(RVA = "0x25EE38C", Offset = "0x25EE38C", VA = "0x25EE38C")]
	public void RemvoeMarkState(MHEBOCMJHPI AHNNHNBJBOB, uint IDNEFEOPGIF)
	{
	}

	[Token(Token = "0x600496F")]
	[Address(RVA = "0x25EE4A4", Offset = "0x25EE4A4", VA = "0x25EE4A4")]
	public void ClearMarkState(MHEBOCMJHPI AHNNHNBJBOB)
	{
	}

	[Token(Token = "0x6004970")]
	[Address(RVA = "0x25EE5B8", Offset = "0x25EE5B8", VA = "0x25EE5B8")]
	public bool IsSkillDamageLimitedScaleEffecting(OOIPMACFIFL JFPKMOEGDIF)
	{
		return default(bool);
	}

	[Token(Token = "0x6004971")]
	[Address(RVA = "0x25EE654", Offset = "0x25EE654", VA = "0x25EE654")]
	public float GetSkillDamageScale(OOIPMACFIFL JFPKMOEGDIF, OPILIBBOEAC IDDMAHJHGBC)
	{
		return default(float);
	}

	[Token(Token = "0x600497E")]
	[Address(RVA = "0x25EF218", Offset = "0x25EF218", VA = "0x25EF218")]
	public void UpdatePetSharkSpeed(uint IDNEFEOPGIF, float IOOPPDAAMEP)
	{
	}

	[Token(Token = "0x6004985")]
	[Address(RVA = "0x25EF718", Offset = "0x25EF718", VA = "0x25EF718")]
	public bool SetDamageReductionRateByBehurtExpendEVBValue(IHAAMHPPLMG IDNEFEOPGIF, float ECMLPCAJDIH)
	{
		return default(bool);
	}

	[Token(Token = "0x6004987")]
	[Address(RVA = "0x25EFAC0", Offset = "0x25EFAC0", VA = "0x25EFAC0")]
	public bool GetDamageReductionRateByBeHurtExpendEPEnable()
	{
		return default(bool);
	}
}
