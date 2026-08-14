using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000768")]
internal class NFJPHMKKEBF
{
	[Token(Token = "0x2000769")]
	protected enum LICPHHNNPPF
	{
		[Token(Token = "0x4004DEA")]
		NotStarted,
		[Token(Token = "0x4004DEB")]
		Running,
		[Token(Token = "0x4004DEC")]
		WaitingForEnd,
		[Token(Token = "0x4004DED")]
		EatingChickenDelayEnd,
		[Token(Token = "0x4004DEE")]
		MatchEnd
	}

	[Token(Token = "0x200076A")]
	protected class KOJOIDDNKEC
	{
		[Token(Token = "0x4004DEF")]
		[FieldOffset(Offset = "0x8")]
		public uint IKNBIKKDJGE;

		[Token(Token = "0x4004DF0")]
		[FieldOffset(Offset = "0xC")]
		public uint JJKDFONBOIP;

		[Token(Token = "0x6002FD6")]
		[Address(RVA = "0x154867C", Offset = "0x154867C", VA = "0x154867C")]
		public KOJOIDDNKEC()
		{
		}
	}

	[Token(Token = "0x200076B")]
	public enum OKPDGGLLCDE
	{
		[Token(Token = "0x4004DF2")]
		AirPlaneSkin,
		[Token(Token = "0x4004DF3")]
		TruckSkin,
		[Token(Token = "0x4004DF4")]
		AirdropSkin,
		[Token(Token = "0x4004DF5")]
		DynamicGenerate,
		[Token(Token = "0x4004DF6")]
		PickupModelChange,
		[Token(Token = "0x4004DF7")]
		HalloweenSweets,
		[Token(Token = "0x4004DF8")]
		CarePackageSkin,
		[Token(Token = "0x4004DF9")]
		CampFireSkin,
		[Token(Token = "0x4004DFA")]
		TreasureMapSkin,
		[Token(Token = "0x4004DFB")]
		DetectorIcon,
		[Token(Token = "0x4004DFC")]
		MapItemSkinType,
		[Token(Token = "0x4004DFD")]
		DrumSkin,
		[Token(Token = "0x4004DFE")]
		EventZombieSkin,
		[Token(Token = "0x4004DFF")]
		TimeDependentModel,
		[Token(Token = "0x4004E00")]
		TimeDependentActive,
		[Token(Token = "0x4004E01")]
		TimeDependentMusic,
		[Token(Token = "0x4004E02")]
		WaitingRoomWeapon,
		[Token(Token = "0x4004E03")]
		FountainSkin,
		[Token(Token = "0x4004E04")]
		UAVSkin,
		[Token(Token = "0x4004E05")]
		WaitingFireEffect,
		[Token(Token = "0x4004E06")]
		WaitingSurroundPlayerEffect,
		[Token(Token = "0x4004E07")]
		ZeppelinSkin,
		[Token(Token = "0x4004E08")]
		InGameShopSkin,
		[Token(Token = "0x4004E09")]
		Treasury,
		[Token(Token = "0x4004E0A")]
		Hayrick
	}

	[Token(Token = "0x200076C")]
	public class PIHNFDIMHKO
	{
		[Token(Token = "0x4004E0B")]
		[FieldOffset(Offset = "0x8")]
		public BaseProfileInfo APMFAKPGKMD;

		[Token(Token = "0x4004E0C")]
		[FieldOffset(Offset = "0xC")]
		public int PIAMIOFEBKF;

		[Token(Token = "0x4004E0D")]
		[FieldOffset(Offset = "0x10")]
		public bool GAKBHKNAHKG;

		[Token(Token = "0x4004E0E")]
		[FieldOffset(Offset = "0x14")]
		public int HPIEGIAICML;

		[Token(Token = "0x6002FD7")]
		[Address(RVA = "0x1548870", Offset = "0x1548870", VA = "0x1548870")]
		public PIHNFDIMHKO(BaseProfileInfo GNDAMCEFLLP, int BOEIBGAABDL, bool MLJDOPMFKBN, int NFNOAOOENJM)
		{
		}

		[Token(Token = "0x6002FD8")]
		[Address(RVA = "0x154890C", Offset = "0x154890C", VA = "0x154890C")]
		public PIHNFDIMHKO(PIHNFDIMHKO PAIGAJKOEHL)
		{
		}
	}

	[Token(Token = "0x200076D")]
	protected delegate void AKGCDMIKGDL(Player PJOIFFLCDPM, float OPKNJGBDOBB, float OMAFEKBHOAA);

	[Token(Token = "0x200076E")]
	protected enum DKNKNCONGAM
	{
		[Token(Token = "0x4004E10")]
		Controller,
		[Token(Token = "0x4004E11")]
		AI,
		[Token(Token = "0x4004E12")]
		Behavior,
		[Token(Token = "0x4004E13")]
		Kinematics,
		[Token(Token = "0x4004E14")]
		Post,
		[Token(Token = "0x4004E15")]
		PendingRevive,
		[Token(Token = "0x4004E16")]
		NB
	}

	[Token(Token = "0x200076F")]
	protected delegate void DHEGGMACCEI(NetworkAIPawn PJOIFFLCDPM, float OPKNJGBDOBB, float OMAFEKBHOAA);

	[Token(Token = "0x2000770")]
	protected enum IKLCKMNMLBM
	{
		[Token(Token = "0x4004E18")]
		Behavior,
		[Token(Token = "0x4004E19")]
		Kinematics,
		[Token(Token = "0x4004E1A")]
		Post,
		[Token(Token = "0x4004E1B")]
		NB
	}

	[Token(Token = "0x2000771")]
	private sealed class GOMBACKCDNP
	{
		[Token(Token = "0x4004E1C")]
		[FieldOffset(Offset = "0x8")]
		internal OGCHKCGKGKN LHCHNFGKLHD;

		[Token(Token = "0x4004E1D")]
		[FieldOffset(Offset = "0xC")]
		internal Player KAEHJEGFKBL;

		[Token(Token = "0x4004E1E")]
		[FieldOffset(Offset = "0x10")]
		internal NFJPHMKKEBF GADHAMJEKIM;

		[Token(Token = "0x6002FE1")]
		[Address(RVA = "0x1548464", Offset = "0x1548464", VA = "0x1548464")]
		public GOMBACKCDNP()
		{
		}

		[Token(Token = "0x6002FE2")]
		[Address(RVA = "0x154846C", Offset = "0x154846C", VA = "0x154846C")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x2000772")]
	private sealed class LGHDKGKEPIN
	{
		[Token(Token = "0x4004E1F")]
		[FieldOffset(Offset = "0x8")]
		internal FNCMBMMKLLI MEDCPPLFLNA;

		[Token(Token = "0x4004E20")]
		[FieldOffset(Offset = "0xC")]
		internal FOFJEMOKAOH MNCCLLOKJPJ;

		[Token(Token = "0x4004E21")]
		[FieldOffset(Offset = "0x10")]
		internal GOMBACKCDNP KKPNFILOEFP;

		[Token(Token = "0x6002FE3")]
		[Address(RVA = "0x1548684", Offset = "0x1548684", VA = "0x1548684")]
		public LGHDKGKEPIN()
		{
		}

		[Token(Token = "0x6002FE4")]
		[Address(RVA = "0x154868C", Offset = "0x154868C", VA = "0x154868C")]
		internal void CHOPCLCOBKC()
		{
		}

		[Token(Token = "0x6002FE5")]
		[Address(RVA = "0x15487C0", Offset = "0x15487C0", VA = "0x15487C0")]
		internal void HJGBDJENEAM()
		{
		}
	}

	[Token(Token = "0x2000773")]
	private sealed class DMBPLHEFCLE
	{
		[Token(Token = "0x4004E22")]
		[FieldOffset(Offset = "0x8")]
		internal Player KAEHJEGFKBL;

		[Token(Token = "0x4004E23")]
		[FieldOffset(Offset = "0xC")]
		internal NFJPHMKKEBF GADHAMJEKIM;

		[Token(Token = "0x6002FE6")]
		[Address(RVA = "0x1548130", Offset = "0x1548130", VA = "0x1548130")]
		public DMBPLHEFCLE()
		{
		}

		[Token(Token = "0x6002FE7")]
		[Address(RVA = "0x1548138", Offset = "0x1548138", VA = "0x1548138")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x2000774")]
	private sealed class BNIGAAIEDPI
	{
		[Token(Token = "0x4004E24")]
		[FieldOffset(Offset = "0x8")]
		internal Player KAEHJEGFKBL;

		[Token(Token = "0x4004E25")]
		[FieldOffset(Offset = "0xC")]
		internal NFJPHMKKEBF GADHAMJEKIM;

		[Token(Token = "0x6002FE8")]
		[Address(RVA = "0x1547BF4", Offset = "0x1547BF4", VA = "0x1547BF4")]
		public BNIGAAIEDPI()
		{
		}

		[Token(Token = "0x6002FE9")]
		[Address(RVA = "0x1547BFC", Offset = "0x1547BFC", VA = "0x1547BFC")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x2000775")]
	private sealed class KCIOGKEKDBB
	{
		[Token(Token = "0x4004E26")]
		[FieldOffset(Offset = "0x8")]
		internal Player KAEHJEGFKBL;

		[Token(Token = "0x4004E27")]
		[FieldOffset(Offset = "0xC")]
		internal NFJPHMKKEBF GADHAMJEKIM;

		[Token(Token = "0x6002FEA")]
		[Address(RVA = "0x1548640", Offset = "0x1548640", VA = "0x1548640")]
		public KCIOGKEKDBB()
		{
		}

		[Token(Token = "0x6002FEB")]
		[Address(RVA = "0x1548648", Offset = "0x1548648", VA = "0x1548648")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x2000776")]
	private sealed class BDIJKDFNNJC
	{
		[Token(Token = "0x4004E28")]
		[FieldOffset(Offset = "0x8")]
		internal FNCMBMMKLLI MEDCPPLFLNA;

		[Token(Token = "0x4004E29")]
		[FieldOffset(Offset = "0xC")]
		internal KCIOGKEKDBB LFCMDIDEEEL;

		[Token(Token = "0x6002FEC")]
		[Address(RVA = "0x1547AB8", Offset = "0x1547AB8", VA = "0x1547AB8")]
		public BDIJKDFNNJC()
		{
		}

		[Token(Token = "0x6002FED")]
		[Address(RVA = "0x1547AC0", Offset = "0x1547AC0", VA = "0x1547AC0")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x2000777")]
	private sealed class MFMHJLCELPD
	{
		[Token(Token = "0x4004E2A")]
		[FieldOffset(Offset = "0x8")]
		internal int LNCICJOAODE;

		[Token(Token = "0x4004E2B")]
		[FieldOffset(Offset = "0xC")]
		internal NFJPHMKKEBF GADHAMJEKIM;

		[Token(Token = "0x6002FEE")]
		[Address(RVA = "0x1548868", Offset = "0x1548868", VA = "0x1548868")]
		public MFMHJLCELPD()
		{
		}
	}

	[Token(Token = "0x2000778")]
	private sealed class GDPKABEAJBA
	{
		[Token(Token = "0x4004E2C")]
		[FieldOffset(Offset = "0x8")]
		internal int IDMLECOFHGD;

		[Token(Token = "0x4004E2D")]
		[FieldOffset(Offset = "0xC")]
		internal MFMHJLCELPD GJLKOCMILFD;

		[Token(Token = "0x6002FEF")]
		[Address(RVA = "0x154816C", Offset = "0x154816C", VA = "0x154816C")]
		public GDPKABEAJBA()
		{
		}

		[Token(Token = "0x6002FF0")]
		[Address(RVA = "0x1548174", Offset = "0x1548174", VA = "0x1548174")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x4004D69")]
	[FieldOffset(Offset = "0x8")]
	protected LICPHHNNPPF ILGECLEFCCO;

	[Token(Token = "0x4004D6A")]
	[FieldOffset(Offset = "0xC")]
	protected GameObject GLJMHCIIGOB;

	[Token(Token = "0x4004D6B")]
	[FieldOffset(Offset = "0x10")]
	protected Player FJPEHEGICBO;

	[Token(Token = "0x4004D6C")]
	[FieldOffset(Offset = "0x18")]
	protected IHAAMHPPLMG MOOHLKMMNMO;

	[Token(Token = "0x4004D6D")]
	[FieldOffset(Offset = "0x30")]
	protected uint GPAMBFNBCIB;

	[Token(Token = "0x4004D6E")]
	[FieldOffset(Offset = "0x34")]
	protected FNCMBMMKLLI BGGJJKKKFDC;

	[Token(Token = "0x4004D6F")]
	[FieldOffset(Offset = "0x38")]
	protected FOFJEMOKAOH BBHPPFPAHKE;

	[Token(Token = "0x4004D70")]
	[FieldOffset(Offset = "0x3C")]
	protected CJBECBAMMIG KMFLKCJECGB;

	[Token(Token = "0x4004D71")]
	[FieldOffset(Offset = "0x40")]
	protected HEFEPHLDKDG MCEJNJPNFEH;

	[Token(Token = "0x4004D72")]
	[FieldOffset(Offset = "0x44")]
	protected List<Player> JDFIGFJHKPD;

	[Token(Token = "0x4004D73")]
	[FieldOffset(Offset = "0x48")]
	protected Dictionary<IHAAMHPPLMG, Player> HOOCHDLKOOG;

	[Token(Token = "0x4004D74")]
	[FieldOffset(Offset = "0x4C")]
	protected Dictionary<IHAAMHPPLMG, Player> HJAKBBKDAPK;

	[Token(Token = "0x4004D75")]
	[FieldOffset(Offset = "0x50")]
	protected Dictionary<byte, Player> NIEBEGJADLC;

	[Token(Token = "0x4004D76")]
	[FieldOffset(Offset = "0x54")]
	protected Dictionary<IHAAMHPPLMG, Player> PHCLIMEPOEK;

	[Token(Token = "0x4004D77")]
	[FieldOffset(Offset = "0x58")]
	protected Dictionary<IHAAMHPPLMG, NetworkAIPawn> PJCIGCOCIHM;

	[Token(Token = "0x4004D78")]
	[FieldOffset(Offset = "0x5C")]
	protected Dictionary<IHAAMHPPLMG, FNCMBMMKLLI> KFJLFFOLGOM;

	[Token(Token = "0x4004D79")]
	[FieldOffset(Offset = "0x60")]
	protected Dictionary<byte, MatchTeam> NPLDHOBNMJF;

	[Token(Token = "0x4004D7A")]
	[FieldOffset(Offset = "0x64")]
	protected Dictionary<ulong, CJBECBAMMIG> LHEDMMHKPJI;

	[Token(Token = "0x4004D7B")]
	[FieldOffset(Offset = "0x68")]
	protected Dictionary<ushort, LevelVehicle> HMHEGALPPFP;

	[Token(Token = "0x4004D7C")]
	[FieldOffset(Offset = "0x6C")]
	protected Dictionary<ushort, LevelMovePlatform> CDPPNIGLLNL;

	[Token(Token = "0x4004D7D")]
	[FieldOffset(Offset = "0x70")]
	protected Dictionary<uint, NetworkPet> KHEFAPGJBOG;

	[Token(Token = "0x4004D7E")]
	[FieldOffset(Offset = "0x74")]
	protected Dictionary<uint, KOJOIDDNKEC> DAONDLCKKEC;

	[Token(Token = "0x4004D7F")]
	[FieldOffset(Offset = "0x78")]
	protected Dictionary<byte, KEMMCPJHGEN> NNNMKMEFIIJ;

	[Token(Token = "0x4004D80")]
	[FieldOffset(Offset = "0x7C")]
	protected Dictionary<uint, INOGCPKMJHK> NJJEHAHCKNJ;

	[Token(Token = "0x4004D81")]
	[FieldOffset(Offset = "0x80")]
	protected bool FFBOFFHLBLO;

	[Token(Token = "0x4004D82")]
	[FieldOffset(Offset = "0x81")]
	private bool JBKPLKBKLBD;

	[Token(Token = "0x4004D83")]
	[FieldOffset(Offset = "0x84")]
	private Transform _003CCAAGNMCKELH_003Ek__BackingField;

	[Token(Token = "0x4004D84")]
	[FieldOffset(Offset = "0x88")]
	private float GGEAEDHPFJL;

	[Token(Token = "0x4004D85")]
	private const float KNDMICMGPFB = 4f;

	[Token(Token = "0x4004D86")]
	[FieldOffset(Offset = "0x8C")]
	protected List<BaseLevelObject> NCDOOIOHPMJ;

	[Token(Token = "0x4004D87")]
	[FieldOffset(Offset = "0x90")]
	protected GameObject ODKEDJINIBB;

	[Token(Token = "0x4004D88")]
	[FieldOffset(Offset = "0x94")]
	protected List<OPILIBBOEAC> OKKANALNMMB;

	[Token(Token = "0x4004D89")]
	[FieldOffset(Offset = "0x98")]
	protected List<OPILIBBOEAC> IDKAIAHLDGI;

	[Token(Token = "0x4004D8A")]
	[FieldOffset(Offset = "0x9C")]
	protected SafeZone AOAPDOAICGF;

	[Token(Token = "0x4004D8B")]
	[FieldOffset(Offset = "0xA0")]
	protected LDAFPHICDJJ BAJIIMBHLEF;

	[Token(Token = "0x4004D8C")]
	[FieldOffset(Offset = "0xA4")]
	protected HDKCFINDDOE IFNKHPEKLFF;

	[Token(Token = "0x4004D8D")]
	[FieldOffset(Offset = "0xA8")]
	protected KBMPGFLDGOC IDPLODCKPEM;

	[Token(Token = "0x4004D8E")]
	[FieldOffset(Offset = "0xAC")]
	protected HJDAGOJJNFP PEDKMJOCKJJ;

	[Token(Token = "0x4004D8F")]
	[FieldOffset(Offset = "0xB0")]
	protected AirtransportParams IOMEBNMHCIK;

	[Token(Token = "0x4004D90")]
	[FieldOffset(Offset = "0xB4")]
	protected AirTransporter JIJBCPHADKH;

	[Token(Token = "0x4004D91")]
	[FieldOffset(Offset = "0xB8")]
	protected AirPlaceName OLHBMELIMFN;

	[Token(Token = "0x4004D92")]
	[FieldOffset(Offset = "0xBC")]
	protected GBILAIDDNBN LLDBBGAPJHD;

	[Token(Token = "0x4004D93")]
	[FieldOffset(Offset = "0xC0")]
	protected ADNFGKDMELO ENKPEKDLNPK;

	[Token(Token = "0x4004D94")]
	[FieldOffset(Offset = "0xC4")]
	protected uint HNNDIBGLEKH;

	[Token(Token = "0x4004D95")]
	[FieldOffset(Offset = "0xC8")]
	protected uint EILGBCJDONH;

	[Token(Token = "0x4004D96")]
	[FieldOffset(Offset = "0xCC")]
	protected LPGDKKAGPKJ FPDNCPJAMHL;

	[Token(Token = "0x4004D97")]
	[FieldOffset(Offset = "0xD0")]
	private Dictionary<uint, bool> BHNJIJJOEPA;

	[Token(Token = "0x4004D98")]
	[FieldOffset(Offset = "0xD4")]
	private Dictionary<uint, LevelContainer> PBNIIEDAHFN;

	[Token(Token = "0x4004D99")]
	[FieldOffset(Offset = "0xD8")]
	private uint OFHKCLLODJE;

	[Token(Token = "0x4004D9A")]
	[FieldOffset(Offset = "0xDC")]
	private Dictionary<byte, Dictionary<LevelContainer, bool>> NFOBPHBEALK;

	[Token(Token = "0x4004D9B")]
	[FieldOffset(Offset = "0xE0")]
	private byte EMCMJBIGLJJ;

	[Token(Token = "0x4004D9C")]
	[FieldOffset(Offset = "0xE4")]
	private uint KJGBPGFMCJJ;

	[Token(Token = "0x4004D9D")]
	[FieldOffset(Offset = "0xE8")]
	private uint NIHLOFKEDCL;

	[Token(Token = "0x4004D9E")]
	[FieldOffset(Offset = "0xEC")]
	private ResourceID COKOPGOOJIE;

	[Token(Token = "0x4004D9F")]
	[FieldOffset(Offset = "0xF0")]
	private bool PHGPCOBEPHC;

	[Token(Token = "0x4004DA0")]
	[FieldOffset(Offset = "0xF4")]
	private ResourceID KNKFIIAFJAO;

	[Token(Token = "0x4004DA1")]
	[FieldOffset(Offset = "0xF8")]
	private ResourceID JOCJBIOIAAJ;

	[Token(Token = "0x4004DA2")]
	[FieldOffset(Offset = "0xFC")]
	private ResourceID BFIAIKFJCLB;

	[Token(Token = "0x4004DA3")]
	[FieldOffset(Offset = "0x100")]
	private ResourceID CCPCJABPCHI;

	[Token(Token = "0x4004DA4")]
	[FieldOffset(Offset = "0x104")]
	private ResourceID HGPANDABIOK;

	[Token(Token = "0x4004DA5")]
	[FieldOffset(Offset = "0x108")]
	private ResourceID MJJPAOFIKLA;

	[Token(Token = "0x4004DA6")]
	[FieldOffset(Offset = "0x10C")]
	private ResourceID MJNOMAAMLMJ;

	[Token(Token = "0x4004DA7")]
	[FieldOffset(Offset = "0x110")]
	protected ResourceID BHCOODAKMIO;

	[Token(Token = "0x4004DA8")]
	[FieldOffset(Offset = "0x114")]
	protected ResourceID FANLFAIKFLO;

	[Token(Token = "0x4004DA9")]
	[FieldOffset(Offset = "0x118")]
	protected ResourceID IMCMBEKBHBA;

	[Token(Token = "0x4004DAA")]
	[FieldOffset(Offset = "0x11C")]
	protected ResourceID FBPEKCNNNBH;

	[Token(Token = "0x4004DAB")]
	[FieldOffset(Offset = "0x120")]
	protected ResourceID LPOGIDOKCMG;

	[Token(Token = "0x4004DAC")]
	[FieldOffset(Offset = "0x124")]
	protected ResourceID JHJKFOFDAHK;

	[Token(Token = "0x4004DAD")]
	[FieldOffset(Offset = "0x128")]
	protected ResourceID DPDKGANNCMJ;

	[Token(Token = "0x4004DAE")]
	[FieldOffset(Offset = "0x12C")]
	protected ResourceID PDCDDCODKGI;

	[Token(Token = "0x4004DAF")]
	[FieldOffset(Offset = "0x130")]
	protected ResourceID MCNGGPENJBF;

	[Token(Token = "0x4004DB0")]
	[FieldOffset(Offset = "0x134")]
	protected ResourceID LNGHABMOHIB;

	[Token(Token = "0x4004DB1")]
	[FieldOffset(Offset = "0x138")]
	protected ResourceID FGNNNBPHBLB;

	[Token(Token = "0x4004DB2")]
	[FieldOffset(Offset = "0x13C")]
	protected ResourceID DGPEPCFIEBD;

	[Token(Token = "0x4004DB3")]
	[FieldOffset(Offset = "0x140")]
	protected ResourceID PKKOBMADOPO;

	[Token(Token = "0x4004DB4")]
	[FieldOffset(Offset = "0x144")]
	protected ResourceID JEGICLBPHGA;

	[Token(Token = "0x4004DB5")]
	[FieldOffset(Offset = "0x148")]
	protected ResourceID FMPCJBCFNHC;

	[Token(Token = "0x4004DB6")]
	[FieldOffset(Offset = "0x14C")]
	protected Dictionary<uint, ResourceID> FBALMAIJIGP;

	[Token(Token = "0x4004DB7")]
	[FieldOffset(Offset = "0x150")]
	private Dictionary<int, ResourceID> ENLEIDLIICF;

	[Token(Token = "0x4004DB8")]
	[FieldOffset(Offset = "0x154")]
	private Dictionary<int, ResourceID> NFAIBOHKAOI;

	[Token(Token = "0x4004DB9")]
	[FieldOffset(Offset = "0x158")]
	private Dictionary<int, bool> GNHKLDANMKH;

	[Token(Token = "0x4004DBA")]
	[FieldOffset(Offset = "0x15C")]
	private Dictionary<int, string> FJLFPMMLOEP;

	[Token(Token = "0x4004DBB")]
	[FieldOffset(Offset = "0x160")]
	protected ResourceID IMKNOJMJDPE;

	[Token(Token = "0x4004DBC")]
	[FieldOffset(Offset = "0x164")]
	protected string DGGFOLHFOLI;

	[Token(Token = "0x4004DBD")]
	[FieldOffset(Offset = "0x168")]
	protected string PAJGKDGPCJI;

	[Token(Token = "0x4004DBE")]
	[FieldOffset(Offset = "0x16C")]
	protected string LNKAFCJFPDJ;

	[Token(Token = "0x4004DBF")]
	[FieldOffset(Offset = "0x170")]
	protected string KAEEHDDBHKN;

	[Token(Token = "0x4004DC0")]
	[FieldOffset(Offset = "0x174")]
	protected ResourceID CLHFIPHIDCB;

	[Token(Token = "0x4004DC1")]
	[FieldOffset(Offset = "0x178")]
	protected int AAFDKCFELDC;

	[Token(Token = "0x4004DC2")]
	[FieldOffset(Offset = "0x17C")]
	private HHDIPHFOBFO _003CPICLBKBDFPC_003Ek__BackingField;

	[Token(Token = "0x4004DC3")]
	[FieldOffset(Offset = "0x180")]
	private ushort _003CPBNMIEEJFLC_003Ek__BackingField;

	[Token(Token = "0x4004DC4")]
	[FieldOffset(Offset = "0x182")]
	protected bool LKBLDGIHHOH;

	[Token(Token = "0x4004DC5")]
	[FieldOffset(Offset = "0x183")]
	protected bool IPGOACBJMMD;

	[Token(Token = "0x4004DC6")]
	[FieldOffset(Offset = "0x0")]
	public static ulong FKINOFENLEB;

	[Token(Token = "0x4004DC7")]
	[FieldOffset(Offset = "0x8")]
	public static ulong HGJLDEIKLAB;

	[Token(Token = "0x4004DC8")]
	[FieldOffset(Offset = "0x10")]
	public static ulong HPEPCNDEDNB;

	[Token(Token = "0x4004DC9")]
	[FieldOffset(Offset = "0x18")]
	public static ulong CPPJIKMBEDL;

	[Token(Token = "0x4004DCA")]
	[FieldOffset(Offset = "0x188")]
	public double NBACGLGIHDC;

	[Token(Token = "0x4004DCB")]
	[FieldOffset(Offset = "0x190")]
	public Quaternion FCEKODBLKOK;

	[Token(Token = "0x4004DCC")]
	[FieldOffset(Offset = "0x1A0")]
	private uint LLNDDEAEPGH;

	[Token(Token = "0x4004DCD")]
	[FieldOffset(Offset = "0x1A4")]
	private bool FEDPNOLHALM;

	[Token(Token = "0x4004DCE")]
	[FieldOffset(Offset = "0x1A8")]
	private JEAGJCOAEAH AGNIMMIOPMH;

	[Token(Token = "0x4004DCF")]
	[FieldOffset(Offset = "0x1AC")]
	private string OKIDLCHHGDM;

	[Token(Token = "0x4004DD0")]
	[FieldOffset(Offset = "0x1B0")]
	public uint HFPGENNDGME;

	[Token(Token = "0x4004DD1")]
	[FieldOffset(Offset = "0x1B4")]
	public uint FCDLOIFDKAK;

	[Token(Token = "0x4004DD2")]
	[FieldOffset(Offset = "0x1B8")]
	public bool HLMGKCLKHID;

	[Token(Token = "0x4004DD3")]
	[FieldOffset(Offset = "0x1BC")]
	public Dictionary<uint, bool> JLFEFGGLKMH;

	[Token(Token = "0x4004DD4")]
	[FieldOffset(Offset = "0x1C0")]
	public PIHNFDIMHKO LMEPGAGBJOO;

	[Token(Token = "0x4004DD5")]
	[FieldOffset(Offset = "0x1C4")]
	public PIHNFDIMHKO FHNICLLIJJM;

	[Token(Token = "0x4004DD6")]
	[FieldOffset(Offset = "0x1C8")]
	private Transform OCKJNCOMFLA;

	[Token(Token = "0x4004DD7")]
	[FieldOffset(Offset = "0x1CC")]
	private List<IHAAMHPPLMG> IEAANLGPAJB;

	[Token(Token = "0x4004DD8")]
	[FieldOffset(Offset = "0x1D0")]
	protected AKGCDMIKGDL[] AKDPIGJOGLK;

	[Token(Token = "0x4004DD9")]
	[FieldOffset(Offset = "0x1D4")]
	protected DHEGGMACCEI[] ECICMFHHIAG;

	[Token(Token = "0x4004DDA")]
	private const uint IHEJCLFHLGF = 63u;

	[Token(Token = "0x4004DDB")]
	[FieldOffset(Offset = "0x1D8")]
	private uint LHENEBBGGMA;

	[Token(Token = "0x4004DDC")]
	[FieldOffset(Offset = "0x1DC")]
	private IMMKODAFPGI LOHBJAHALFP;

	[Token(Token = "0x4004DDD")]
	[FieldOffset(Offset = "0x1E0")]
	public IEMKOPMFIID FMDPCHEJLLH;

	[Token(Token = "0x4004DDE")]
	[FieldOffset(Offset = "0x20")]
	private static AKGCDMIKGDL HMDOHFBHDOB;

	[Token(Token = "0x4004DDF")]
	[FieldOffset(Offset = "0x24")]
	private static AKGCDMIKGDL AOCDJNOINOH;

	[Token(Token = "0x4004DE0")]
	[FieldOffset(Offset = "0x28")]
	private static AKGCDMIKGDL AAOFHFGKOBN;

	[Token(Token = "0x4004DE1")]
	[FieldOffset(Offset = "0x2C")]
	private static AKGCDMIKGDL KJNIBJNOINP;

	[Token(Token = "0x4004DE2")]
	[FieldOffset(Offset = "0x30")]
	private static AKGCDMIKGDL LMELNMABMHH;

	[Token(Token = "0x4004DE3")]
	[FieldOffset(Offset = "0x34")]
	private static AKGCDMIKGDL CBMPCCOKCBK;

	[Token(Token = "0x4004DE4")]
	[FieldOffset(Offset = "0x38")]
	private static DHEGGMACCEI ELAGCOFNAMO;

	[Token(Token = "0x4004DE5")]
	[FieldOffset(Offset = "0x3C")]
	private static DHEGGMACCEI FLBCAAMNJAP;

	[Token(Token = "0x4004DE6")]
	[FieldOffset(Offset = "0x40")]
	private static DHEGGMACCEI MMDDJGMHMCI;

	[Token(Token = "0x4004DE7")]
	[FieldOffset(Offset = "0x44")]
	private static Action HAIFJFNCJKC;

	[Token(Token = "0x4004DE8")]
	[FieldOffset(Offset = "0x48")]
	private static Action NGJCJHIKPPA;

	[Token(Token = "0x17000367")]
	public Transform FENDKOIHDII
	{
		[Token(Token = "0x6002EB8")]
		[Address(RVA = "0x116D444", Offset = "0x116D444", VA = "0x116D444")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002EB9")]
		[Address(RVA = "0x116D44C", Offset = "0x116D44C", VA = "0x116D44C")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000368")]
	public Dictionary<byte, KEMMCPJHGEN> BHGKFDDKJIM
	{
		[Token(Token = "0x6002EBA")]
		[Address(RVA = "0x116D454", Offset = "0x116D454", VA = "0x116D454")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000369")]
	public Dictionary<uint, INOGCPKMJHK> HPMDLPHPPNF
	{
		[Token(Token = "0x6002EBB")]
		[Address(RVA = "0x116D4AC", Offset = "0x116D4AC", VA = "0x116D4AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700036A")]
	public Dictionary<ushort, LevelMovePlatform> MMNBDMHGIAN
	{
		[Token(Token = "0x6002EBC")]
		[Address(RVA = "0x116D504", Offset = "0x116D504", VA = "0x116D504")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700036B")]
	public bool GKDGMOPPLPF
	{
		[Token(Token = "0x6002EBD")]
		[Address(RVA = "0x116D55C", Offset = "0x116D55C", VA = "0x116D55C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700036C")]
	public ResourceID KPGKPOOLKAM
	{
		[Token(Token = "0x6002EBE")]
		[Address(RVA = "0x116D5B4", Offset = "0x116D5B4", VA = "0x116D5B4")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x1700036D")]
	public ResourceID LLJDIFMBCBD
	{
		[Token(Token = "0x6002EBF")]
		[Address(RVA = "0x116D60C", Offset = "0x116D60C", VA = "0x116D60C")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x1700036E")]
	public ResourceID NPNKMMBEBAM
	{
		[Token(Token = "0x6002EC0")]
		[Address(RVA = "0x116D664", Offset = "0x116D664", VA = "0x116D664")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x1700036F")]
	public ResourceID HPEHPEKIKAM
	{
		[Token(Token = "0x6002EC1")]
		[Address(RVA = "0x116D6BC", Offset = "0x116D6BC", VA = "0x116D6BC")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x17000370")]
	public ResourceID CKGKHKBJGIE
	{
		[Token(Token = "0x6002EC2")]
		[Address(RVA = "0x116D714", Offset = "0x116D714", VA = "0x116D714")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x17000371")]
	public ResourceID DMFKJEGNEAA
	{
		[Token(Token = "0x6002EC3")]
		[Address(RVA = "0x116D76C", Offset = "0x116D76C", VA = "0x116D76C")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x17000372")]
	public ResourceID DIEBCHNNPCO
	{
		[Token(Token = "0x6002EC4")]
		[Address(RVA = "0x116D7C4", Offset = "0x116D7C4", VA = "0x116D7C4")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x17000373")]
	public ResourceID IDCOHHIBDGK
	{
		[Token(Token = "0x6002EC5")]
		[Address(RVA = "0x116D81C", Offset = "0x116D81C", VA = "0x116D81C")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x17000374")]
	public ResourceID JKBBDANHPBJ
	{
		[Token(Token = "0x6002EC6")]
		[Address(RVA = "0x116D874", Offset = "0x116D874", VA = "0x116D874")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x17000375")]
	public ResourceID BPJGIDGNJCK
	{
		[Token(Token = "0x6002EC7")]
		[Address(RVA = "0x116D8CC", Offset = "0x116D8CC", VA = "0x116D8CC")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x17000376")]
	public ResourceID FKJOPBCGHMO
	{
		[Token(Token = "0x6002EC8")]
		[Address(RVA = "0x116D924", Offset = "0x116D924", VA = "0x116D924")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x17000377")]
	public ResourceID BONGPAIMNBO
	{
		[Token(Token = "0x6002EC9")]
		[Address(RVA = "0x116D97C", Offset = "0x116D97C", VA = "0x116D97C")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x17000378")]
	public ResourceID CDICGALOBFF
	{
		[Token(Token = "0x6002ECA")]
		[Address(RVA = "0x116D9D4", Offset = "0x116D9D4", VA = "0x116D9D4")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x17000379")]
	public ResourceID IDIALOPDJIK
	{
		[Token(Token = "0x6002ECB")]
		[Address(RVA = "0x116DADC", Offset = "0x116DADC", VA = "0x116DADC")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x1700037A")]
	public ResourceID ECENDOCABCI
	{
		[Token(Token = "0x6002ECC")]
		[Address(RVA = "0x116DB34", Offset = "0x116DB34", VA = "0x116DB34")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x1700037B")]
	public ResourceID AHJFKAFDIEJ
	{
		[Token(Token = "0x6002ECD")]
		[Address(RVA = "0x116DB8C", Offset = "0x116DB8C", VA = "0x116DB8C")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x1700037C")]
	public ResourceID EAGNNPJOIJC
	{
		[Token(Token = "0x6002ECE")]
		[Address(RVA = "0x116DBE4", Offset = "0x116DBE4", VA = "0x116DBE4")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x1700037D")]
	public ResourceID ICGMAHPBDAO
	{
		[Token(Token = "0x6002ECF")]
		[Address(RVA = "0x116DC3C", Offset = "0x116DC3C", VA = "0x116DC3C")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x1700037E")]
	public ResourceID HELCFALECOC
	{
		[Token(Token = "0x6002ED0")]
		[Address(RVA = "0x116DC94", Offset = "0x116DC94", VA = "0x116DC94")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x6002ED1")]
		[Address(RVA = "0x116DCEC", Offset = "0x116DCEC", VA = "0x116DCEC")]
		set
		{
		}
	}

	[Token(Token = "0x1700037F")]
	public ResourceID LBNDJDNFNPJ
	{
		[Token(Token = "0x6002ED9")]
		[Address(RVA = "0x116E51C", Offset = "0x116E51C", VA = "0x116E51C")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x17000380")]
	public string JEAOCIEHLDJ
	{
		[Token(Token = "0x6002EDA")]
		[Address(RVA = "0x116E574", Offset = "0x116E574", VA = "0x116E574")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000381")]
	public string LLEMJCJICKA
	{
		[Token(Token = "0x6002EDB")]
		[Address(RVA = "0x116E5CC", Offset = "0x116E5CC", VA = "0x116E5CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000382")]
	public string GFBEIKLKMKK
	{
		[Token(Token = "0x6002EDC")]
		[Address(RVA = "0x116E624", Offset = "0x116E624", VA = "0x116E624")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000383")]
	public string IOPEHOGINCP
	{
		[Token(Token = "0x6002EDD")]
		[Address(RVA = "0x116E67C", Offset = "0x116E67C", VA = "0x116E67C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000384")]
	public ResourceID PLKHEIECMNC
	{
		[Token(Token = "0x6002EDE")]
		[Address(RVA = "0x116E6D4", Offset = "0x116E6D4", VA = "0x116E6D4")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x17000385")]
	public int OBLMGMMBMOL
	{
		[Token(Token = "0x6002EDF")]
		[Address(RVA = "0x116E72C", Offset = "0x116E72C", VA = "0x116E72C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000386")]
	public HHDIPHFOBFO KHEFHJNNLIL
	{
		[Token(Token = "0x6002EE0")]
		[Address(RVA = "0x116E784", Offset = "0x116E784", VA = "0x116E784")]
		get
		{
			return default(HHDIPHFOBFO);
		}
		[Token(Token = "0x6002EE1")]
		[Address(RVA = "0x116D43C", Offset = "0x116D43C", VA = "0x116D43C")]
		set
		{
		}
	}

	[Token(Token = "0x17000387")]
	public ushort GCPDMAACBBH
	{
		[Token(Token = "0x6002EE2")]
		[Address(RVA = "0x116E78C", Offset = "0x116E78C", VA = "0x116E78C")]
		get
		{
			return default(ushort);
		}
		[Token(Token = "0x6002EE3")]
		[Address(RVA = "0x116E798", Offset = "0x116E798", VA = "0x116E798")]
		set
		{
		}
	}

	[Token(Token = "0x17000388")]
	public bool NNIFIPFGBLM
	{
		[Token(Token = "0x6002EE4")]
		[Address(RVA = "0x116E7A4", Offset = "0x116E7A4", VA = "0x116E7A4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002EE5")]
		[Address(RVA = "0x116E7FC", Offset = "0x116E7FC", VA = "0x116E7FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000389")]
	public bool BPAPKNENMCI
	{
		[Token(Token = "0x6002EE6")]
		[Address(RVA = "0x116E85C", Offset = "0x116E85C", VA = "0x116E85C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002EE7")]
		[Address(RVA = "0x116E8B4", Offset = "0x116E8B4", VA = "0x116E8B4")]
		set
		{
		}
	}

	[Token(Token = "0x1700038A")]
	public JEAGJCOAEAH OHODLLBKANA
	{
		[Token(Token = "0x6002EE8")]
		[Address(RVA = "0x116E914", Offset = "0x116E914", VA = "0x116E914")]
		get
		{
			return default(JEAGJCOAEAH);
		}
	}

	[Token(Token = "0x1700038B")]
	public Transform FFDIHPNOCKD
	{
		[Token(Token = "0x6002F5F")]
		[Address(RVA = "0x118697C", Offset = "0x118697C", VA = "0x118697C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700038C")]
	public IMMKODAFPGI PMICCLAEIDI
	{
		[Token(Token = "0x6002FC7")]
		[Address(RVA = "0x119A5D4", Offset = "0x119A5D4", VA = "0x119A5D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002FC6")]
		[Address(RVA = "0x119A574", Offset = "0x119A574", VA = "0x119A574")]
		set
		{
		}
	}

	[Token(Token = "0x6002EB7")]
	[Address(RVA = "0x116C988", Offset = "0x116C988", VA = "0x116C988")]
	protected NFJPHMKKEBF()
	{
	}

	[Token(Token = "0x6002ED2")]
	[Address(RVA = "0x116DD4C", Offset = "0x116DD4C", VA = "0x116DD4C")]
	public ResourceID DEBKBOEJNKM(int EIKCFIDCCMM = 1)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002ED3")]
	[Address(RVA = "0x116DDD4", Offset = "0x116DDD4", VA = "0x116DDD4")]
	public ResourceID BACGLAIBFON()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002ED4")]
	[Address(RVA = "0x116DF2C", Offset = "0x116DF2C", VA = "0x116DF2C")]
	public ResourceID EEGEPOKKNKL(LevelTriggerFountain.CBOODHNHCFN PMGBACFJIHO)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002ED5")]
	[Address(RVA = "0x116E058", Offset = "0x116E058", VA = "0x116E058")]
	public ResourceID MANNBJIPBID(LevelBaseDrum.JPAKCIIEOML CJKPOPCFJLO)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002ED6")]
	[Address(RVA = "0x116E184", Offset = "0x116E184", VA = "0x116E184")]
	public ResourceID MAAKFGAMCPK(OGPGMJAHMMD PCLNHNFELMD)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002ED7")]
	[Address(RVA = "0x116E300", Offset = "0x116E300", VA = "0x116E300")]
	public bool CNKHGHIAIPN(PJBADHKCLNO DHIGIFJFEFM)
	{
		return default(bool);
	}

	[Token(Token = "0x6002ED8")]
	[Address(RVA = "0x116E3F0", Offset = "0x116E3F0", VA = "0x116E3F0")]
	public string PEIDLPLBMED(FMJEJDAMDLL DHIGIFJFEFM)
	{
		return null;
	}

	[Token(Token = "0x6002EE9")]
	public static T LBGFLLHDFNI<T>() where T : NFJPHMKKEBF, new()
	{
		return null;
	}

	[Token(Token = "0x6002EEA")]
	[Address(RVA = "0x116E96C", Offset = "0x116E96C", VA = "0x116E96C", Slot = "4")]
	public virtual void LILLELPNAGA()
	{
	}

	[Token(Token = "0x6002EEB")]
	[Address(RVA = "0x1170218", Offset = "0x1170218", VA = "0x1170218", Slot = "5")]
	public virtual void LLJKMFAFBLC()
	{
	}

	[Token(Token = "0x6002EEC")]
	[Address(RVA = "0x11705BC", Offset = "0x11705BC", VA = "0x11705BC")]
	public bool BCMGLHIGJLL()
	{
		return default(bool);
	}

	[Token(Token = "0x6002EED")]
	[Address(RVA = "0x117069C", Offset = "0x117069C", VA = "0x117069C")]
	public bool PANMKLKGDJD()
	{
		return default(bool);
	}

	[Token(Token = "0x6002EEE")]
	[Address(RVA = "0x117062C", Offset = "0x117062C", VA = "0x117062C")]
	public bool NLCJBNKCGFK()
	{
		return default(bool);
	}

	[Token(Token = "0x6002EEF")]
	[Address(RVA = "0x1170718", Offset = "0x1170718", VA = "0x1170718")]
	public bool DKMFGNPHFFE()
	{
		return default(bool);
	}

	[Token(Token = "0x6002EF0")]
	[Address(RVA = "0x1170784", Offset = "0x1170784", VA = "0x1170784")]
	public bool LALLBLHPGNP()
	{
		return default(bool);
	}

	[Token(Token = "0x6002EF1")]
	[Address(RVA = "0x116F520", Offset = "0x116F520", VA = "0x116F520")]
	protected void FGEKAPHFINE(LICPHHNNPPF JEHELPNHACP)
	{
	}

	[Token(Token = "0x6002EF2")]
	[Address(RVA = "0x11707F0", Offset = "0x11707F0", VA = "0x11707F0")]
	public Player FOANLCGNPGD()
	{
		return null;
	}

	[Token(Token = "0x6002EF3")]
	[Address(RVA = "0x1170848", Offset = "0x1170848", VA = "0x1170848")]
	public IHAAMHPPLMG OLDBJNEHANN()
	{
		return default(IHAAMHPPLMG);
	}

	[Token(Token = "0x6002EF4")]
	[Address(RVA = "0x11708BC", Offset = "0x11708BC", VA = "0x11708BC")]
	public uint EAFPPBGIOPP()
	{
		return default(uint);
	}

	[Token(Token = "0x6002EF5")]
	[Address(RVA = "0x1170914", Offset = "0x1170914", VA = "0x1170914")]
	public bool DPFDALEIMFH(IHAAMHPPLMG KAEHJEGFKBL)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EF6")]
	[Address(RVA = "0x1170E2C", Offset = "0x1170E2C", VA = "0x1170E2C")]
	public bool ECEFCPKMADP(IHAAMHPPLMG FGFGBHLEONO)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EF7")]
	[Address(RVA = "0x1170A88", Offset = "0x1170A88", VA = "0x1170A88")]
	public bool NBJDGEDLDLJ(IHAAMHPPLMG KAEHJEGFKBL)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EF8")]
	[Address(RVA = "0x1170C40", Offset = "0x1170C40", VA = "0x1170C40")]
	public bool HACLOBIFDAD(IHAAMHPPLMG KAEHJEGFKBL)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EF9")]
	[Address(RVA = "0x1170F84", Offset = "0x1170F84", VA = "0x1170F84")]
	public bool CAMLOBJDOEB(IHAAMHPPLMG KAEHJEGFKBL)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EFA")]
	[Address(RVA = "0x117124C", Offset = "0x117124C", VA = "0x117124C")]
	public bool MMNEJJDDJOJ(IHAAMHPPLMG KAEHJEGFKBL)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EFB")]
	[Address(RVA = "0x1171418", Offset = "0x1171418", VA = "0x1171418")]
	public void DONJMKJJOBP()
	{
	}

	[Token(Token = "0x6002EFC")]
	[Address(RVA = "0x1171474", Offset = "0x1171474", VA = "0x1171474")]
	public void PPLKIAINOGA(Player PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x6002EFD")]
	[Address(RVA = "0x1171590", Offset = "0x1171590", VA = "0x1171590")]
	public FNCMBMMKLLI DJEBKGGLGAC()
	{
		return null;
	}

	[Token(Token = "0x6002EFE")]
	[Address(RVA = "0x11715E8", Offset = "0x11715E8", VA = "0x11715E8")]
	public void PIHJBAOIAML()
	{
	}

	[Token(Token = "0x6002EFF")]
	[Address(RVA = "0x1171644", Offset = "0x1171644", VA = "0x1171644")]
	public FOFJEMOKAOH GOLDAGMANBH()
	{
		return null;
	}

	[Token(Token = "0x6002F00")]
	[Address(RVA = "0x117169C", Offset = "0x117169C", VA = "0x117169C")]
	public void MFHIFDMHFAC()
	{
	}

	[Token(Token = "0x6002F01")]
	[Address(RVA = "0x11716F8", Offset = "0x11716F8", VA = "0x11716F8")]
	public Dictionary<IHAAMHPPLMG, Player> CBDMGCCAGIN()
	{
		return null;
	}

	[Token(Token = "0x6002F02")]
	[Address(RVA = "0x1171750", Offset = "0x1171750", VA = "0x1171750")]
	public Player CKJLNHKNPED(byte OMFOJMGPOOB)
	{
		return null;
	}

	[Token(Token = "0x6002F03")]
	[Address(RVA = "0x11710B0", Offset = "0x11710B0", VA = "0x11710B0")]
	public Player KAGPBMINBIJ(IHAAMHPPLMG BIFFAIEPIND, bool NDHHLHFKJPJ = false)
	{
		return null;
	}

	[Token(Token = "0x6002F04")]
	[Address(RVA = "0x1171970", Offset = "0x1171970", VA = "0x1171970")]
	public Player GODMKIIHHKK(ulong HHMJNLLBELP)
	{
		return null;
	}

	[Token(Token = "0x6002F05")]
	[Address(RVA = "0x1171BA8", Offset = "0x1171BA8", VA = "0x1171BA8")]
	public Dictionary<byte, MatchTeam> LOLLFNEPGKG()
	{
		return null;
	}

	[Token(Token = "0x6002F06")]
	[Address(RVA = "0x1171C00", Offset = "0x1171C00", VA = "0x1171C00")]
	public MatchTeam LPLMCKCNHOB(IHAAMHPPLMG BIFFAIEPIND)
	{
		return null;
	}

	[Token(Token = "0x6002F07")]
	[Address(RVA = "0x1171D44", Offset = "0x1171D44", VA = "0x1171D44")]
	public MatchTeam FIKMDLGENBI(byte ADKBIHDAKOD)
	{
		return null;
	}

	[Token(Token = "0x6002F08")]
	[Address(RVA = "0x1171E38", Offset = "0x1171E38", VA = "0x1171E38")]
	public MatchTeam NJPHJHHFINB(uint AMMCBAKJEAD)
	{
		return null;
	}

	[Token(Token = "0x6002F09")]
	[Address(RVA = "0x1172064", Offset = "0x1172064", VA = "0x1172064")]
	public bool HMHKBBLHOCG(IHAAMHPPLMG BIFFAIEPIND)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F0A")]
	[Address(RVA = "0x117217C", Offset = "0x117217C", VA = "0x117217C")]
	public Dictionary<IHAAMHPPLMG, NetworkAIPawn> LNBKAJFPLFJ()
	{
		return null;
	}

	[Token(Token = "0x6002F0B")]
	[Address(RVA = "0x11721D4", Offset = "0x11721D4", VA = "0x11721D4")]
	public NetworkAIPawn INNONJJPKPA(IHAAMHPPLMG BIFFAIEPIND)
	{
		return null;
	}

	[Token(Token = "0x6002F0C")]
	[Address(RVA = "0x1172300", Offset = "0x1172300", VA = "0x1172300")]
	public bool DFKCHEPHFCG(IHAAMHPPLMG BIFFAIEPIND)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F0D")]
	[Address(RVA = "0x1172418", Offset = "0x1172418", VA = "0x1172418")]
	public List<OPILIBBOEAC> PBKHCDCOFKI()
	{
		return null;
	}

	[Token(Token = "0x6002F0E")]
	[Address(RVA = "0x1172470", Offset = "0x1172470", VA = "0x1172470")]
	public void FLAIEDPAOKI(OPILIBBOEAC HGMBMICDALC)
	{
	}

	[Token(Token = "0x6002F0F")]
	[Address(RVA = "0x1172650", Offset = "0x1172650", VA = "0x1172650")]
	public void KNAGHLEKACO(OPILIBBOEAC HGMBMICDALC)
	{
	}

	[Token(Token = "0x6002F10")]
	[Address(RVA = "0x11727BC", Offset = "0x11727BC", VA = "0x11727BC")]
	public List<OPILIBBOEAC> JONMGJGEDHC()
	{
		return null;
	}

	[Token(Token = "0x6002F11")]
	[Address(RVA = "0x1172814", Offset = "0x1172814", VA = "0x1172814")]
	public Dictionary<IHAAMHPPLMG, Player> CLBAOJPAAJM(IHAAMHPPLMG BIFFAIEPIND, bool BFFKNIKPCEK = true)
	{
		return null;
	}

	[Token(Token = "0x6002F12")]
	[Address(RVA = "0x1172A10", Offset = "0x1172A10", VA = "0x1172A10")]
	public Dictionary<IHAAMHPPLMG, Player> EGFHLOANGHL(IHAAMHPPLMG BIFFAIEPIND, bool BFFKNIKPCEK = true)
	{
		return null;
	}

	[Token(Token = "0x6002F13")]
	[Address(RVA = "0x1172C0C", Offset = "0x1172C0C", VA = "0x1172C0C")]
	public Dictionary<IHAAMHPPLMG, Player> FMONCKINMCD(IHAAMHPPLMG BIFFAIEPIND)
	{
		return null;
	}

	[Token(Token = "0x6002F14")]
	[Address(RVA = "0x1173130", Offset = "0x1173130", VA = "0x1173130")]
	public bool ILDGEDDOMEF(IHAAMHPPLMG BIFFAIEPIND, bool BFFKNIKPCEK, out float IENPBCLGFKM)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F15")]
	[Address(RVA = "0x1173640", Offset = "0x1173640", VA = "0x1173640")]
	public Dictionary<IHAAMHPPLMG, Player> BPBLJGGEJPG(Player KAEHJEGFKBL)
	{
		return null;
	}

	[Token(Token = "0x6002F16")]
	[Address(RVA = "0x11737B4", Offset = "0x11737B4", VA = "0x11737B4")]
	public List<IHAAMHPPLMG> MIBOPCBJEIH(IHAAMHPPLMG BIFFAIEPIND, bool BFFKNIKPCEK = true)
	{
		return null;
	}

	[Token(Token = "0x6002F17")]
	[Address(RVA = "0x1173B9C", Offset = "0x1173B9C", VA = "0x1173B9C")]
	public int CFKKAOHBKON()
	{
		return default(int);
	}

	[Token(Token = "0x6002F18")]
	[Address(RVA = "0x1173C5C", Offset = "0x1173C5C", VA = "0x1173C5C")]
	public int NDCIIFBHIEK()
	{
		return default(int);
	}

	[Token(Token = "0x6002F19")]
	[Address(RVA = "0x1173D1C", Offset = "0x1173D1C", VA = "0x1173D1C")]
	public int OLIIFILEICO()
	{
		return default(int);
	}

	[Token(Token = "0x6002F1A")]
	[Address(RVA = "0x1173F14", Offset = "0x1173F14", VA = "0x1173F14")]
	public void MMFFHFLMBHO(DKKNMJDABAC LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002F1B")]
	[Address(RVA = "0x1177668", Offset = "0x1177668", VA = "0x1177668")]
	private void CPGIAFPBABC(DNCAPGNMEFK AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6002F1C")]
	[Address(RVA = "0x1177A6C", Offset = "0x1177A6C", VA = "0x1177A6C")]
	public void APNPDFBPHJP(OAHAIGAGIAJ LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002F1D")]
	[Address(RVA = "0x1177FC0", Offset = "0x1177FC0", VA = "0x1177FC0")]
	public void MPGOIKHHBAO(MEDMDANEGBN LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002F1E")]
	[Address(RVA = "0x1178598", Offset = "0x1178598", VA = "0x1178598")]
	public AirTransporter NEELIMJGHIL(Player PJOIFFLCDPM)
	{
		return null;
	}

	[Token(Token = "0x6002F1F")]
	[Address(RVA = "0x1178F14", Offset = "0x1178F14", VA = "0x1178F14")]
	public void BGJMBLCPJDA(Vector3 EBIJHALKJEM)
	{
	}

	[Token(Token = "0x6002F20")]
	[Address(RVA = "0x1178C6C", Offset = "0x1178C6C", VA = "0x1178C6C")]
	public void HNBIKHLMLFP(GameObject ICDOAPANOPH)
	{
	}

	[Token(Token = "0x6002F21")]
	[Address(RVA = "0x117932C", Offset = "0x117932C", VA = "0x117932C")]
	public void FHEOFLBBMJC(Player PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x6002F22")]
	[Address(RVA = "0x1179454", Offset = "0x1179454", VA = "0x1179454")]
	public void HMLANLEOFHN(Player PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x6002F23")]
	[Address(RVA = "0x117957C", Offset = "0x117957C", VA = "0x117957C")]
	public AirTransporter EBNLJBELOGJ(Vehicle GJPPBDEFPHO)
	{
		return null;
	}

	[Token(Token = "0x6002F24")]
	[Address(RVA = "0x1179868", Offset = "0x1179868", VA = "0x1179868")]
	public void HIDDOCNKFHP(Vehicle GJPPBDEFPHO)
	{
	}

	[Token(Token = "0x6002F25")]
	[Address(RVA = "0x1179990", Offset = "0x1179990", VA = "0x1179990")]
	public void AHJKAIGPHBB()
	{
	}

	[Token(Token = "0x6002F26")]
	[Address(RVA = "0x1179BB4", Offset = "0x1179BB4", VA = "0x1179BB4")]
	public void IIKIIFPDGFL()
	{
	}

	[Token(Token = "0x6002F27")]
	[Address(RVA = "0x1179D78", Offset = "0x1179D78", VA = "0x1179D78")]
	public void BDJIGPFJEIJ(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002F28")]
	[Address(RVA = "0x1179EC8", Offset = "0x1179EC8", VA = "0x1179EC8", Slot = "6")]
	public virtual void PLMHKBHIHNI(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002F29")]
	[Address(RVA = "0x117AB80", Offset = "0x117AB80", VA = "0x117AB80", Slot = "7")]
	public virtual void LLKDEPINNNO(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002F2A")]
	[Address(RVA = "0x117B7E4", Offset = "0x117B7E4", VA = "0x117B7E4")]
	private bool ODMPBDPEGDH()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F2B")]
	[Address(RVA = "0x117B8F8", Offset = "0x117B8F8", VA = "0x117B8F8")]
	public void NGHHGGDOADJ()
	{
	}

	[Token(Token = "0x6002F2C")]
	[Address(RVA = "0x117BEEC", Offset = "0x117BEEC", VA = "0x117BEEC")]
	public void HDHKMBMPFMP(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002F2D")]
	[Address(RVA = "0x117BF5C", Offset = "0x117BF5C", VA = "0x117BF5C")]
	public void OFELDLIEBAK()
	{
	}

	[Token(Token = "0x6002F2E")]
	[Address(RVA = "0x117BFB0", Offset = "0x117BFB0", VA = "0x117BFB0")]
	private void NDKKJMBBFAD()
	{
	}

	[Token(Token = "0x6002F2F")]
	[Address(RVA = "0x117C178", Offset = "0x117C178", VA = "0x117C178")]
	private void GEEPJDNHBIN()
	{
	}

	[Token(Token = "0x6002F30")]
	[Address(RVA = "0x117C63C", Offset = "0x117C63C", VA = "0x117C63C")]
	public void EACPCMDDLKB()
	{
	}

	[Token(Token = "0x6002F31")]
	[Address(RVA = "0x117CB94", Offset = "0x117CB94", VA = "0x117CB94")]
	public void MNLBACBCCKB()
	{
	}

	[Token(Token = "0x6002F32")]
	[Address(RVA = "0x117CFFC", Offset = "0x117CFFC", VA = "0x117CFFC")]
	public void LFMCBKNIDFM()
	{
	}

	[Token(Token = "0x6002F33")]
	[Address(RVA = "0x117D134", Offset = "0x117D134", VA = "0x117D134")]
	public void DDDKBGJPFCM(JEAGJCOAEAH HACJEPEAOAB, int LIBIIBHCOMD, bool HAOPNKEIPBJ, ulong NBHJLLBBEHK, ulong BBAHABKOLIE, uint NOKDPLPAEOG)
	{
	}

	[Token(Token = "0x6002F34")]
	[Address(RVA = "0x117D34C", Offset = "0x117D34C", VA = "0x117D34C")]
	private void FPIDFMKCOKL(ulong NBHJLLBBEHK, ulong BBAHABKOLIE, uint NOKDPLPAEOG)
	{
	}

	[Token(Token = "0x6002F35")]
	[Address(RVA = "0x117D9B8", Offset = "0x117D9B8", VA = "0x117D9B8")]
	public bool ACPPCMJMMHL()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F36")]
	[Address(RVA = "0x117D86C", Offset = "0x117D86C", VA = "0x117D86C")]
	public void LKPEBOOMJCE()
	{
	}

	[Token(Token = "0x6002F37")]
	[Address(RVA = "0x117DA10", Offset = "0x117DA10", VA = "0x117DA10")]
	public void KAHAFNHFDAL()
	{
	}

	[Token(Token = "0x6002F38")]
	[Address(RVA = "0x117DA7C", Offset = "0x117DA7C", VA = "0x117DA7C")]
	private bool AEOELFMNFNL(IHAAMHPPLMG IDNEFEOPGIF, ulong EBOJJLIHHCM, bool AHGLALNNEAP)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F39")]
	[Address(RVA = "0x117DEE8", Offset = "0x117DEE8", VA = "0x117DEE8")]
	private bool NMJNEPHAEEF(IHAAMHPPLMG IDNEFEOPGIF)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F3A")]
	[Address(RVA = "0x117E16C", Offset = "0x117E16C", VA = "0x117E16C")]
	private void KOCNNBLGJCM(ulong HHMJNLLBELP, ulong NECLOOKIGCP, IHAAMHPPLMG BIFFAIEPIND, GKBDLJFGGMI DAAKKAOCBAA)
	{
	}

	[Token(Token = "0x6002F3B")]
	[Address(RVA = "0x117E490", Offset = "0x117E490", VA = "0x117E490")]
	public void INKCJIPPJDM(IHAAMHPPLMG EMGAGGMJIDG)
	{
	}

	[Token(Token = "0x6002F3C")]
	[Address(RVA = "0x117EB58", Offset = "0x117EB58", VA = "0x117EB58")]
	public void HEGPPDLEOGM(IHAAMHPPLMG BIFFAIEPIND)
	{
	}

	[Token(Token = "0x6002F3D")]
	[Address(RVA = "0x117EEE0", Offset = "0x117EEE0", VA = "0x117EEE0")]
	public bool LONDNBHBPDO(ulong HHMJNLLBELP, ulong NECLOOKIGCP, IHAAMHPPLMG BIFFAIEPIND, bool JNLEJHIJFOP = false, [Optional] object JKBNDADENMG, bool CPLFLFEIILI = false, bool GLPAPFGOGEO = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F3E")]
	[Address(RVA = "0x118096C", Offset = "0x118096C", VA = "0x118096C")]
	private void MONNBKJDMLO(Player PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x6002F3F")]
	[Address(RVA = "0x1181250", Offset = "0x1181250", VA = "0x1181250")]
	public bool MIEABLNHMCO(IHAAMHPPLMG BIFFAIEPIND, IHAAMHPPLMG HLJDHPGGODB, int HEONOMOEOLN, bool DIBOAOFANGC = false, bool EPIDFMHNHFG = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F40")]
	[Address(RVA = "0x11822B8", Offset = "0x11822B8", VA = "0x11822B8")]
	public void BEEDDKFOOCM(IHAAMHPPLMG BIFFAIEPIND)
	{
	}

	[Token(Token = "0x6002F41")]
	[Address(RVA = "0x1182BC0", Offset = "0x1182BC0", VA = "0x1182BC0")]
	public void NEOEDDJEBLH(IHAAMHPPLMG BIFFAIEPIND, Player KAEHJEGFKBL)
	{
	}

	[Token(Token = "0x6002F42")]
	[Address(RVA = "0x1182CE8", Offset = "0x1182CE8", VA = "0x1182CE8")]
	public void NBKJFILEKGJ(IHAAMHPPLMG BIFFAIEPIND)
	{
	}

	[Token(Token = "0x6002F43")]
	[Address(RVA = "0x1182E00", Offset = "0x1182E00", VA = "0x1182E00")]
	public void HCBPKAJLJKJ()
	{
	}

	[Token(Token = "0x6002F44")]
	[Address(RVA = "0x1182F40", Offset = "0x1182F40", VA = "0x1182F40")]
	public void PJMGGLPDGBC(bool CGMPJFGNHKA, bool JFDHABIIDFB, bool JJEFCCCDCGL)
	{
	}

	[Token(Token = "0x6002F45")]
	[Address(RVA = "0x1183878", Offset = "0x1183878", VA = "0x1183878")]
	public void JBLEMCPELHK(bool LMDPAJPNMCN)
	{
	}

	[Token(Token = "0x6002F46")]
	[Address(RVA = "0x118401C", Offset = "0x118401C", VA = "0x118401C")]
	public void NHIGAIFDIPM(Transform GJGMOFLECDK, float GIFHNFMMCME, bool MGJMFELLNFA = true)
	{
	}

	[Token(Token = "0x6002F47")]
	[Address(RVA = "0x118431C", Offset = "0x118431C", VA = "0x118431C")]
	public bool NBBLJLOONLH(IHAAMHPPLMG BIFFAIEPIND, EBNJADFGCFA KEJFOBBEAJO)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F48")]
	[Address(RVA = "0x11847DC", Offset = "0x11847DC", VA = "0x11847DC")]
	public bool JIOOOGJEAMG(IHAAMHPPLMG BIFFAIEPIND, IHAAMHPPLMG HLJDHPGGODB, int HEONOMOEOLN, bool DIBOAOFANGC = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F49")]
	[Address(RVA = "0x1184A04", Offset = "0x1184A04", VA = "0x1184A04")]
	public void KDHIKGDFIKF(IHAAMHPPLMG BIFFAIEPIND)
	{
	}

	[Token(Token = "0x6002F4A")]
	[Address(RVA = "0x1184BC8", Offset = "0x1184BC8", VA = "0x1184BC8")]
	public void GEJAANBJPMG(NetworkAIPawn PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x6002F4B")]
	[Address(RVA = "0x1184E5C", Offset = "0x1184E5C", VA = "0x1184E5C")]
	public bool EHHIOIPFOHI(IHAAMHPPLMG IFOLCOIDJIK)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F4C")]
	[Address(RVA = "0x1184F78", Offset = "0x1184F78", VA = "0x1184F78")]
	public void JJPGJBCHIEM(IHAAMHPPLMG IFOLCOIDJIK)
	{
	}

	[Token(Token = "0x6002F4D")]
	[Address(RVA = "0x1185090", Offset = "0x1185090", VA = "0x1185090")]
	public bool OCCNGJLAIPB(ulong HHMJNLLBELP, IHAAMHPPLMG BIFFAIEPIND, IHAAMHPPLMG MGEANOPAFEA, GBIFIIGGDGB MECMCGOMJGF, float FADEMGOJGHB = 3f)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F4E")]
	[Address(RVA = "0x117ECC4", Offset = "0x117ECC4", VA = "0x117ECC4")]
	public bool FHEJHOAMPBC(IHAAMHPPLMG BIFFAIEPIND)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F4F")]
	[Address(RVA = "0x118579C", Offset = "0x118579C", VA = "0x118579C")]
	public void GLLEJEPECLF()
	{
	}

	[Token(Token = "0x6002F50")]
	[Address(RVA = "0x11858AC", Offset = "0x11858AC", VA = "0x11858AC")]
	public bool LOMKCBMBLCP(ulong HHMJNLLBELP, IHAAMHPPLMG BIFFAIEPIND)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F51")]
	[Address(RVA = "0x1185954", Offset = "0x1185954", VA = "0x1185954")]
	public void FJAMLEMMHLF(List<AADOBBJPEMN> HNDFCNHDGBP)
	{
	}

	[Token(Token = "0x6002F52")]
	[Address(RVA = "0x1185AAC", Offset = "0x1185AAC", VA = "0x1185AAC")]
	public void OHLBLMHGNAL(HEFEPHLDKDG JJOEAOJMDCK)
	{
	}

	[Token(Token = "0x6002F53")]
	[Address(RVA = "0x1185B0C", Offset = "0x1185B0C", VA = "0x1185B0C")]
	public void BKHCEMEFCPP(List<KJNGJHNOAFI> KOLIMDCDHAB)
	{
	}

	[Token(Token = "0x6002F54")]
	[Address(RVA = "0x1185DB8", Offset = "0x1185DB8", VA = "0x1185DB8")]
	public void HEPFBKAAGEK(CIBBLFMOMLK ANBEGGDFLBM, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6002F55")]
	[Address(RVA = "0x1185FE8", Offset = "0x1185FE8", VA = "0x1185FE8")]
	public void HEPFBKAAGEK(BMMNIPHPNKI ANBEGGDFLBM, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6002F56")]
	[Address(RVA = "0x1186218", Offset = "0x1186218", VA = "0x1186218")]
	public void LAOMIEIABPH(JCHLJBCAMOG HDMDADEMHLL, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6002F57")]
	[Address(RVA = "0x1186448", Offset = "0x1186448", VA = "0x1186448")]
	public void CFFBHHDNEPB(KLGKMCNCIAJ ANBEGGDFLBM, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6002F58")]
	[Address(RVA = "0x116F58C", Offset = "0x116F58C", VA = "0x116F58C")]
	private void GEGIKAILJLG()
	{
	}

	[Token(Token = "0x6002F59")]
	[Address(RVA = "0x117A378", Offset = "0x117A378", VA = "0x117A378")]
	protected void ILNJIKLMJID(float OPKNJGBDOBB, float OMAFEKBHOAA, AKGCDMIKGDL ENONFNCOOMA)
	{
	}

	[Token(Token = "0x6002F5A")]
	[Address(RVA = "0x117A66C", Offset = "0x117A66C", VA = "0x117A66C")]
	protected void HPGNGNAFOKL(float OPKNJGBDOBB, float OMAFEKBHOAA, AKGCDMIKGDL ENONFNCOOMA)
	{
	}

	[Token(Token = "0x6002F5B")]
	[Address(RVA = "0x1186688", Offset = "0x1186688", VA = "0x1186688")]
	protected void ELDBNEAEJJK(float OPKNJGBDOBB, float OMAFEKBHOAA, AKGCDMIKGDL ENONFNCOOMA)
	{
	}

	[Token(Token = "0x6002F5C")]
	[Address(RVA = "0x116FDA0", Offset = "0x116FDA0", VA = "0x116FDA0")]
	private void BMHGINKEIOP()
	{
	}

	[Token(Token = "0x6002F5D")]
	[Address(RVA = "0x117A960", Offset = "0x117A960", VA = "0x117A960")]
	protected void JEHFKAMMGPB(float OPKNJGBDOBB, float OMAFEKBHOAA, DHEGGMACCEI ENONFNCOOMA)
	{
	}

	[Token(Token = "0x6002F5E")]
	[Address(RVA = "0x11808F4", Offset = "0x11808F4", VA = "0x11808F4")]
	private Transform NNEBCHNJIPB()
	{
		return null;
	}

	[Token(Token = "0x6002F60")]
	[Address(RVA = "0x1186A7C", Offset = "0x1186A7C", VA = "0x1186A7C")]
	public void OFPGPBODNHD(SafeZone LKBHBKCBHEE)
	{
	}

	[Token(Token = "0x6002F61")]
	[Address(RVA = "0x1186BAC", Offset = "0x1186BAC", VA = "0x1186BAC")]
	private void EKFJPKOEKPB()
	{
	}

	[Token(Token = "0x6002F62")]
	[Address(RVA = "0x1186DD0", Offset = "0x1186DD0", VA = "0x1186DD0")]
	public void CIDMADOHLKF(KGOHADAMBLI LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002F63")]
	[Address(RVA = "0x1187CBC", Offset = "0x1187CBC", VA = "0x1187CBC")]
	public void CIDMADOHLKF(EPCCGBHFKHM LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002F64")]
	[Address(RVA = "0x1187E18", Offset = "0x1187E18", VA = "0x1187E18")]
	public void DPCMENEFIGB(HMMEOGMGJKL LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002F65")]
	[Address(RVA = "0x1188028", Offset = "0x1188028", VA = "0x1188028")]
	public bool HFIGLBJNDOK()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F66")]
	[Address(RVA = "0x118814C", Offset = "0x118814C", VA = "0x118814C")]
	public bool GELFNMDAPPC()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F67")]
	[Address(RVA = "0x11881BC", Offset = "0x11881BC", VA = "0x11881BC")]
	public SafeZone IPIGDABFNCC()
	{
		return null;
	}

	[Token(Token = "0x6002F68")]
	[Address(RVA = "0x1188220", Offset = "0x1188220", VA = "0x1188220")]
	public SafeZone ABHFOHFHJPF()
	{
		return null;
	}

	[Token(Token = "0x6002F69")]
	[Address(RVA = "0x1188278", Offset = "0x1188278", VA = "0x1188278")]
	public void KKBIJIFHAPN(MCDIGEEGOLM LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002F6A")]
	[Address(RVA = "0x1188380", Offset = "0x1188380", VA = "0x1188380")]
	public LDAFPHICDJJ DPDNHBLFMFL()
	{
		return null;
	}

	[Token(Token = "0x6002F6B")]
	[Address(RVA = "0x11883D8", Offset = "0x11883D8", VA = "0x11883D8")]
	public LPGDKKAGPKJ POJCFPBNJJI()
	{
		return null;
	}

	[Token(Token = "0x6002F6C")]
	[Address(RVA = "0x1188430", Offset = "0x1188430", VA = "0x1188430")]
	public HJDAGOJJNFP IGNJJJPCDNP()
	{
		return null;
	}

	[Token(Token = "0x6002F6D")]
	[Address(RVA = "0x1188488", Offset = "0x1188488", VA = "0x1188488")]
	public HDKCFINDDOE LKNIODDGKMD()
	{
		return null;
	}

	[Token(Token = "0x6002F6E")]
	[Address(RVA = "0x11884E0", Offset = "0x11884E0", VA = "0x11884E0")]
	public KBMPGFLDGOC BHBJJKAOFKN()
	{
		return null;
	}

	[Token(Token = "0x6002F6F")]
	[Address(RVA = "0x1188538", Offset = "0x1188538", VA = "0x1188538")]
	public GBILAIDDNBN EGMILBLNBOA()
	{
		return null;
	}

	[Token(Token = "0x6002F70")]
	[Address(RVA = "0x1188590", Offset = "0x1188590", VA = "0x1188590")]
	public bool FNOLCKJALHG()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F71")]
	[Address(RVA = "0x1188664", Offset = "0x1188664", VA = "0x1188664")]
	public AirtransportParams IPKDIOPLAMB()
	{
		return null;
	}

	[Token(Token = "0x6002F72")]
	[Address(RVA = "0x11886BC", Offset = "0x11886BC", VA = "0x11886BC")]
	public void OCLKBNPBCAG(ushort OAEBFFBGCKE)
	{
	}

	[Token(Token = "0x6002F73")]
	[Address(RVA = "0x1188794", Offset = "0x1188794", VA = "0x1188794")]
	public void OCLKBNPBCAG(PGKJDKIJGJD AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6002F74")]
	[Address(RVA = "0x1188AE4", Offset = "0x1188AE4", VA = "0x1188AE4")]
	public AirTransporter KNMOKNICFCO()
	{
		return null;
	}

	[Token(Token = "0x6002F75")]
	[Address(RVA = "0x1188BC8", Offset = "0x1188BC8", VA = "0x1188BC8")]
	public void KDODOAHOEHI(uint HGIILPEDFDI, IHAAMHPPLMG BIFFAIEPIND, int AAEJAPCDKFG, int EMFANFHKAMM, byte LHDIBODNKFK)
	{
	}

	[Token(Token = "0x6002F76")]
	[Address(RVA = "0x11891C0", Offset = "0x11891C0", VA = "0x11891C0")]
	public void DJCMDEDAFGF(uint HGIILPEDFDI)
	{
	}

	[Token(Token = "0x6002F77")]
	[Address(RVA = "0x1189360", Offset = "0x1189360", VA = "0x1189360")]
	public void KMEJPIHIMNP(uint HGIILPEDFDI, int EMFANFHKAMM, Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x6002F78")]
	[Address(RVA = "0x11896D0", Offset = "0x11896D0", VA = "0x11896D0")]
	public void MPHJIMBDEOL()
	{
	}

	[Token(Token = "0x6002F79")]
	[Address(RVA = "0x11897D4", Offset = "0x11897D4", VA = "0x11897D4")]
	public void KMEJPIHIMNP(ushort IDNEFEOPGIF, LevelVehicle CPEMEECILEC)
	{
	}

	[Token(Token = "0x6002F7A")]
	[Address(RVA = "0x11898BC", Offset = "0x11898BC", VA = "0x11898BC")]
	public Dictionary<ushort, LevelVehicle> POGPNGLELEE()
	{
		return null;
	}

	[Token(Token = "0x6002F7B")]
	[Address(RVA = "0x1189914", Offset = "0x1189914", VA = "0x1189914")]
	public void NNCGJOOEBCP(ulong DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002F7C")]
	[Address(RVA = "0x1189C34", Offset = "0x1189C34", VA = "0x1189C34")]
	public void NOPPJBIINCO(uint LPJONPCPBED, List<LPJBAGLHCKN> PLEECPNDKLA)
	{
	}

	[Token(Token = "0x6002F7D")]
	[Address(RVA = "0x1189E3C", Offset = "0x1189E3C", VA = "0x1189E3C")]
	public void DKACGEMPEEL(ushort ICJPLDDFJIC, float OFBBIKDBHEL, float KDADAEPHMFI)
	{
	}

	[Token(Token = "0x6002F7E")]
	[Address(RVA = "0x118A0A4", Offset = "0x118A0A4", VA = "0x118A0A4")]
	public void PNBIIGOFJLI(ushort ICJPLDDFJIC, int BLEAICPKPGL, bool LBMGGMBKAEH)
	{
	}

	[Token(Token = "0x6002F7F")]
	[Address(RVA = "0x1189EF4", Offset = "0x1189EF4", VA = "0x1189EF4")]
	protected HNCJIDEAFBF LOMCHFIKAJB(ushort ICJPLDDFJIC)
	{
		return null;
	}

	[Token(Token = "0x6002F80")]
	[Address(RVA = "0x118A148", Offset = "0x118A148", VA = "0x118A148")]
	private bool HEDGHGLGLLB(IHAAMHPPLMG BIFFAIEPIND)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F81")]
	[Address(RVA = "0x118A3D8", Offset = "0x118A3D8", VA = "0x118A3D8")]
	private bool JAGFBEPEAGO(IHAAMHPPLMG BNEIFLDDNPN)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F82")]
	[Address(RVA = "0x1181C24", Offset = "0x1181C24", VA = "0x1181C24")]
	private void ABEOMHPHFGK(Player EPAHLENBDFO, bool EBOJJLIHHCM)
	{
	}

	[Token(Token = "0x6002F83")]
	[Address(RVA = "0x118A710", Offset = "0x118A710", VA = "0x118A710")]
	public void CDKIGEJMEGI(OGCHKCGKGKN LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002F84")]
	[Address(RVA = "0x118DBD4", Offset = "0x118DBD4", VA = "0x118DBD4")]
	private float ICOFIHCOALN(OGCHKCGKGKN LHCHNFGKLHD)
	{
		return default(float);
	}

	[Token(Token = "0x6002F85")]
	[Address(RVA = "0x118DF28", Offset = "0x118DF28", VA = "0x118DF28")]
	public void HCONBLBKMME(EGJGHKLNDGP LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002F86")]
	[Address(RVA = "0x118F7FC", Offset = "0x118F7FC", VA = "0x118F7FC")]
	private void MCJKEFKEMIB(Player KAEHJEGFKBL)
	{
	}

	[Token(Token = "0x6002F87")]
	[Address(RVA = "0x118F468", Offset = "0x118F468", VA = "0x118F468")]
	private void HLPIHDPJMBE(Player KAEHJEGFKBL, EGJGHKLNDGP LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002F88")]
	[Address(RVA = "0x118E210", Offset = "0x118E210", VA = "0x118E210")]
	private void PNALNHNPLAM(Player KAEHJEGFKBL, EGJGHKLNDGP LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002F89")]
	[Address(RVA = "0x118E6AC", Offset = "0x118E6AC", VA = "0x118E6AC")]
	private void OMNDAKGGLGM(Player KAEHJEGFKBL, EGJGHKLNDGP LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002F8A")]
	[Address(RVA = "0x118FC8C", Offset = "0x118FC8C", VA = "0x118FC8C")]
	public void BNCMIINLABI(ushort IDNEFEOPGIF, LevelMovePlatform ODDGCOJOBIC)
	{
	}

	[Token(Token = "0x6002F8B")]
	[Address(RVA = "0x1190040", Offset = "0x1190040", VA = "0x1190040")]
	public void CAOEFJOJACL(ulong DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002F8C")]
	[Address(RVA = "0x1190360", Offset = "0x1190360", VA = "0x1190360")]
	public void OIPDDDIKICF(BaseLevelObject NPFPMENEEHD)
	{
	}

	[Token(Token = "0x6002F8D")]
	[Address(RVA = "0x118FF74", Offset = "0x118FF74", VA = "0x118FF74")]
	public void PPCFPFPNFNK(BaseLevelObject NPFPMENEEHD)
	{
	}

	[Token(Token = "0x6002F8E")]
	[Address(RVA = "0x1190574", Offset = "0x1190574", VA = "0x1190574")]
	public void DBDNFPEKPII(LPNKIMBIJCB LOKDEBLJINJ, uint CCLAIMKALJG, uint KFBALILGIIG, uint JOHMBDGDHLP, uint BIFFAIEPIND, string HINJBPEDIAL, int EIKCFIDCCMM, List<uint> HMAOIGAAKJM, List<message.LADDOKDJCBG> NMJJDAPBIAG)
	{
	}

	[Token(Token = "0x6002F8F")]
	[Address(RVA = "0x1190BC0", Offset = "0x1190BC0", VA = "0x1190BC0")]
	public void FGFICBMFPBM(uint CCLAIMKALJG, uint BIFFAIEPIND)
	{
	}

	[Token(Token = "0x6002F90")]
	[Address(RVA = "0x1190DFC", Offset = "0x1190DFC", VA = "0x1190DFC")]
	public void LNKIJFHKCFM(GILAMPGPGMH LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002F91")]
	[Address(RVA = "0x1191058", Offset = "0x1191058", VA = "0x1191058")]
	public void GEICOLHIAJJ(bool INHCKIFLEAO)
	{
	}

	[Token(Token = "0x6002F92")]
	[Address(RVA = "0x119134C", Offset = "0x119134C", VA = "0x119134C")]
	public void CNKIPEIILAF(uint CCLAIMKALJG, uint JOHMBDGDHLP)
	{
	}

	[Token(Token = "0x6002F93")]
	[Address(RVA = "0x1191484", Offset = "0x1191484", VA = "0x1191484")]
	public void MEICHOABCOF(KELMCBLFFDC PKAHCEKFHIA)
	{
	}

	[Token(Token = "0x6002F94")]
	[Address(RVA = "0x11915D0", Offset = "0x11915D0", VA = "0x11915D0")]
	public uint EBAOONDAHFD(uint DEPJEGCACFI)
	{
		return default(uint);
	}

	[Token(Token = "0x6002F95")]
	[Address(RVA = "0x11916D8", Offset = "0x11916D8", VA = "0x11916D8")]
	public void HEJEOEOEAOG(FJNGPCLOJHC LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002F96")]
	[Address(RVA = "0x1191BB0", Offset = "0x1191BB0", VA = "0x1191BB0")]
	public void NDHMHNLANGJ(IHAAMHPPLMG BIFFAIEPIND)
	{
	}

	[Token(Token = "0x6002F97")]
	[Address(RVA = "0x1192D18", Offset = "0x1192D18", VA = "0x1192D18")]
	public void DODBBJHBBPN(IHAAMHPPLMG BIFFAIEPIND)
	{
	}

	[Token(Token = "0x6002F98")]
	[Address(RVA = "0x11932EC", Offset = "0x11932EC", VA = "0x11932EC")]
	public Dictionary<IHAAMHPPLMG, Player> IPPFMKEBBFK()
	{
		return null;
	}

	[Token(Token = "0x6002F99")]
	[Address(RVA = "0x1193344", Offset = "0x1193344", VA = "0x1193344")]
	public List<Player> ABFKMPADEHI()
	{
		return null;
	}

	[Token(Token = "0x6002F9A")]
	[Address(RVA = "0x1181FD4", Offset = "0x1181FD4", VA = "0x1181FD4")]
	private void PBMMBDBHOGI(Player KAEHJEGFKBL)
	{
	}

	[Token(Token = "0x6002F9B")]
	[Address(RVA = "0x118FB70", Offset = "0x118FB70", VA = "0x118FB70")]
	private void IADDPPCEKKL(Player KAEHJEGFKBL)
	{
	}

	[Token(Token = "0x6002F9C")]
	[Address(RVA = "0x1171844", Offset = "0x1171844", VA = "0x1171844")]
	public Player JPGGKFLCPMG(IHAAMHPPLMG BIFFAIEPIND)
	{
		return null;
	}

	[Token(Token = "0x6002F9D")]
	[Address(RVA = "0x11934E0", Offset = "0x11934E0", VA = "0x11934E0")]
	public void DLEEFMJPCHA(MJCMIMNHILD LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002F9E")]
	[Address(RVA = "0x1194E3C", Offset = "0x1194E3C", VA = "0x1194E3C")]
	public void JGDEPAJINMP(IHAAMHPPLMG HDIGMNBNOEI, IHAAMHPPLMG LIKDIANKPOI)
	{
	}

	[Token(Token = "0x6002F9F")]
	[Address(RVA = "0x1195490", Offset = "0x1195490", VA = "0x1195490")]
	public void BOBNKADLAKJ(FJNGPCLOJHC LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002FA0")]
	[Address(RVA = "0x1196658", Offset = "0x1196658", VA = "0x1196658")]
	public void LIAIEGOMHNH(Player HJCFNMMLPJH, bool DLFKDNPHAMP, bool LHMOGEDKINM)
	{
	}

	[Token(Token = "0x6002FA1")]
	[Address(RVA = "0x1196840", Offset = "0x1196840", VA = "0x1196840")]
	public void IDIMNNLEJOM(bool MKBGEMBLENG = false, [Optional] Vector3 JKEPOAIPKCO)
	{
	}

	[Token(Token = "0x6002FA2")]
	[Address(RVA = "0x11969A4", Offset = "0x11969A4", VA = "0x11969A4")]
	public void GBDNPJAMKCA(IHAAMHPPLMG BIFFAIEPIND)
	{
	}

	[Token(Token = "0x6002FA3")]
	[Address(RVA = "0x1196B44", Offset = "0x1196B44", VA = "0x1196B44")]
	public bool OFJEMNHALHE()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FA4")]
	[Address(RVA = "0x1196C1C", Offset = "0x1196C1C", VA = "0x1196C1C")]
	public int BKJOMPGOIJP()
	{
		return default(int);
	}

	[Token(Token = "0x6002FA5")]
	[Address(RVA = "0x1196C74", Offset = "0x1196C74", VA = "0x1196C74")]
	public int GCMLKFMGHOJ()
	{
		return default(int);
	}

	[Token(Token = "0x6002FA6")]
	[Address(RVA = "0x1196CCC", Offset = "0x1196CCC", VA = "0x1196CCC")]
	public int JEFJFJIHEHN()
	{
		return default(int);
	}

	[Token(Token = "0x6002FA7")]
	[Address(RVA = "0x1196D24", Offset = "0x1196D24", VA = "0x1196D24")]
	public void CIKHGHBKBIB(IHAAMHPPLMG IFOLCOIDJIK, float NFPILHKMBHL)
	{
	}

	[Token(Token = "0x6002FA8")]
	[Address(RVA = "0x11970F0", Offset = "0x11970F0", VA = "0x11970F0")]
	public void BFCAGMNNKPA()
	{
	}

	[Token(Token = "0x6002FA9")]
	[Address(RVA = "0x117B5E4", Offset = "0x117B5E4", VA = "0x117B5E4")]
	private void IKGJOBDMBNI()
	{
	}

	[Token(Token = "0x6002FAA")]
	[Address(RVA = "0x1197E10", Offset = "0x1197E10", VA = "0x1197E10")]
	private void CLBFJLOKMEN()
	{
	}

	[Token(Token = "0x6002FAB")]
	[Address(RVA = "0x11980BC", Offset = "0x11980BC", VA = "0x11980BC")]
	private void MMEIEGJDOIN()
	{
	}

	[Token(Token = "0x6002FAC")]
	[Address(RVA = "0x1198490", Offset = "0x1198490", VA = "0x1198490")]
	private bool OFAPAGCPOKO()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FAD")]
	[Address(RVA = "0x11973EC", Offset = "0x11973EC", VA = "0x11973EC")]
	private void JEHHJMPMIHL()
	{
	}

	[Token(Token = "0x6002FAE")]
	[Address(RVA = "0x11977B0", Offset = "0x11977B0", VA = "0x11977B0")]
	private void ABNKIEHIMME()
	{
	}

	[Token(Token = "0x6002FAF")]
	[Address(RVA = "0x11985B8", Offset = "0x11985B8", VA = "0x11985B8")]
	private void CKKIFELKMKF()
	{
	}

	[Token(Token = "0x6002FB0")]
	[Address(RVA = "0x1198898", Offset = "0x1198898", VA = "0x1198898")]
	private void NGCOJKKJIJA()
	{
	}

	[Token(Token = "0x6002FB1")]
	[Address(RVA = "0x1180D24", Offset = "0x1180D24", VA = "0x1180D24")]
	private void PMNJCHLFAPJ(Player KAEHJEGFKBL, object JKBNDADENMG)
	{
	}

	[Token(Token = "0x6002FB2")]
	[Address(RVA = "0x1198A88", Offset = "0x1198A88", VA = "0x1198A88")]
	public void NNLJCOLLCLB(byte LODDOINFPPA)
	{
	}

	[Token(Token = "0x6002FB3")]
	[Address(RVA = "0x11820F4", Offset = "0x11820F4", VA = "0x11820F4")]
	private void HHJAHDMOOLJ(Player PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x6002FB4")]
	[Address(RVA = "0x1198B90", Offset = "0x1198B90", VA = "0x1198B90")]
	public string GOEDAFMMNFN()
	{
		return null;
	}

	[Token(Token = "0x6002FB5")]
	[Address(RVA = "0x1197B80", Offset = "0x1197B80", VA = "0x1197B80")]
	private void INPGAAOKIGH()
	{
	}

	[Token(Token = "0x6002FB6")]
	[Address(RVA = "0x1197BDC", Offset = "0x1197BDC", VA = "0x1197BDC")]
	private void JAKJGONKIFN()
	{
	}

	[Token(Token = "0x6002FB7")]
	[Address(RVA = "0x1197CF8", Offset = "0x1197CF8", VA = "0x1197CF8")]
	private void PBPOHCICELL()
	{
	}

	[Token(Token = "0x6002FB8")]
	[Address(RVA = "0x1198BE8", Offset = "0x1198BE8", VA = "0x1198BE8")]
	public void FOINOKBFLBA(uint AOGJNMFCIPL, bool NJDLKHNLKNL)
	{
	}

	[Token(Token = "0x6002FB9")]
	[Address(RVA = "0x1198CD0", Offset = "0x1198CD0", VA = "0x1198CD0")]
	public bool IOJDKBJDKMK(uint AOGJNMFCIPL)
	{
		return default(bool);
	}

	[Token(Token = "0x6002FBA")]
	[Address(RVA = "0x1198DBC", Offset = "0x1198DBC", VA = "0x1198DBC")]
	public void FCLPPDAMHHP(uint AOGJNMFCIPL, LevelContainer GPAPBBFFIKB)
	{
	}

	[Token(Token = "0x6002FBB")]
	[Address(RVA = "0x1198EA4", Offset = "0x1198EA4", VA = "0x1198EA4")]
	public LevelContainer GLDFADKPNCF(uint AOGJNMFCIPL)
	{
		return null;
	}

	[Token(Token = "0x6002FBC")]
	[Address(RVA = "0x1198F88", Offset = "0x1198F88", VA = "0x1198F88")]
	public void FLBOHMAFKBN()
	{
	}

	[Token(Token = "0x6002FBD")]
	[Address(RVA = "0x11994C0", Offset = "0x11994C0", VA = "0x11994C0")]
	public void MEBBKPDGHMD(byte ADKBIHDAKOD, uint JAKHHJFDLKH, bool EBOJJLIHHCM)
	{
	}

	[Token(Token = "0x6002FBE")]
	[Address(RVA = "0x11997C4", Offset = "0x11997C4", VA = "0x11997C4")]
	public bool LLIPAMDDKMN(byte ADKBIHDAKOD, uint JAKHHJFDLKH)
	{
		return default(bool);
	}

	[Token(Token = "0x6002FBF")]
	[Address(RVA = "0x1199A6C", Offset = "0x1199A6C", VA = "0x1199A6C")]
	public void JEOOCIGDDAH(byte ADKBIHDAKOD, LevelContainer GPAPBBFFIKB)
	{
	}

	[Token(Token = "0x6002FC0")]
	[Address(RVA = "0x1199C20", Offset = "0x1199C20", VA = "0x1199C20")]
	public LevelContainer BEHJBINJLPH(byte ADKBIHDAKOD, uint JAKHHJFDLKH)
	{
		return null;
	}

	[Token(Token = "0x6002FC1")]
	[Address(RVA = "0x1199EC8", Offset = "0x1199EC8", VA = "0x1199EC8")]
	public void IBEGNMJJMII(NKDBFGLPCCF LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002FC2")]
	[Address(RVA = "0x118DD30", Offset = "0x118DD30", VA = "0x118DD30")]
	public void PJKIOKCHPDL(OGCHKCGKGKN LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6002FC3")]
	[Address(RVA = "0x119A0B0", Offset = "0x119A0B0", VA = "0x119A0B0")]
	public bool GEFGCCHMBGH()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FC4")]
	[Address(RVA = "0x119A124", Offset = "0x119A124", VA = "0x119A124")]
	public void HBOGFONENAG()
	{
	}

	[Token(Token = "0x6002FC5")]
	[Address(RVA = "0x119A184", Offset = "0x119A184", VA = "0x119A184")]
	public void NHLAHDOKDKJ(uint JAKHHJFDLKH)
	{
	}

	[Token(Token = "0x6002FC9")]
	[Address(RVA = "0x119A6C4", Offset = "0x119A6C4", VA = "0x119A6C4")]
	private static void ADEACGJKFFE(Player PJOIFFLCDPM, float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002FCA")]
	[Address(RVA = "0x119A708", Offset = "0x119A708", VA = "0x119A708")]
	private static void NPOEBAMCADD(Player PJOIFFLCDPM, float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002FCB")]
	[Address(RVA = "0x119A74C", Offset = "0x119A74C", VA = "0x119A74C")]
	private static void PBLEMBFMEBC(Player PJOIFFLCDPM, float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002FCC")]
	[Address(RVA = "0x119A790", Offset = "0x119A790", VA = "0x119A790")]
	private static void AJNGCBKLJAH(Player PJOIFFLCDPM, float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002FCD")]
	[Address(RVA = "0x119A7D4", Offset = "0x119A7D4", VA = "0x119A7D4")]
	private static void GLDPLIEBIDP(Player PJOIFFLCDPM, float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002FCE")]
	[Address(RVA = "0x119A818", Offset = "0x119A818", VA = "0x119A818")]
	private static void IJFOLPPIJBD(Player PJOIFFLCDPM, float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002FCF")]
	[Address(RVA = "0x119A85C", Offset = "0x119A85C", VA = "0x119A85C")]
	private static void IEADNMLAFAO(NetworkAIPawn PJOIFFLCDPM, float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002FD0")]
	[Address(RVA = "0x119A8A0", Offset = "0x119A8A0", VA = "0x119A8A0")]
	private static void GNECFBHDMNL(NetworkAIPawn PJOIFFLCDPM, float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002FD1")]
	[Address(RVA = "0x119A8E4", Offset = "0x119A8E4", VA = "0x119A8E4")]
	private static void HMBFIMNHJDK(NetworkAIPawn PJOIFFLCDPM, float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002FD2")]
	[Address(RVA = "0x119A928", Offset = "0x119A928", VA = "0x119A928")]
	private static void JEHHDKGIADG()
	{
	}

	[Token(Token = "0x6002FD3")]
	[Address(RVA = "0x119AA4C", Offset = "0x119AA4C", VA = "0x119AA4C")]
	private static void FCAFMNECIAJ()
	{
	}

	[Token(Token = "0x6002FD4")]
	[Address(RVA = "0x119AC0C", Offset = "0x119AC0C", VA = "0x119AC0C")]
	private void PDMFFINIOJE()
	{
	}

	[Token(Token = "0x6002FD5")]
	[Address(RVA = "0x119AC18", Offset = "0x119AC18", VA = "0x119AC18")]
	private void FKDHICKPOAB()
	{
	}
}
