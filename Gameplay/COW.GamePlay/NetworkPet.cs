using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x200086C")]
internal class NetworkPet : COWReplicationEntity
{
	[Token(Token = "0x200086D")]
	public class HHCBNAPCKHF : ShadowStateBase
	{
		[Token(Token = "0x40052E2")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 JHJLNLCEGOG;

		[Token(Token = "0x40052E3")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 PGDEDHFOMCN;

		[Token(Token = "0x40052E4")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 PDBOFPMDKMM;

		[Token(Token = "0x40052E5")]
		[FieldOffset(Offset = "0x34")]
		public Quaternion BPLOAFBIHJL;

		[Token(Token = "0x40052E6")]
		[FieldOffset(Offset = "0x44")]
		public ODFIIFHKNNG CILLMPMIENL;

		[Token(Token = "0x40052E7")]
		[FieldOffset(Offset = "0x48")]
		public byte DFGKNGPEPCL;

		[Token(Token = "0x6003B25")]
		[Address(RVA = "0x17F1804", Offset = "0x17F1804", VA = "0x17F1804")]
		public HHCBNAPCKHF()
		{
		}
	}

	[Token(Token = "0x200086E")]
	private sealed class HAJCDLMKFGB
	{
		[Token(Token = "0x40052E8")]
		[FieldOffset(Offset = "0x8")]
		internal List<PetActionData> HLADFEKELKI;

		[Token(Token = "0x6003B26")]
		[Address(RVA = "0x17F328C", Offset = "0x17F328C", VA = "0x17F328C")]
		public HAJCDLMKFGB()
		{
		}

		[Token(Token = "0x6003B27")]
		[Address(RVA = "0x17F7680", Offset = "0x17F7680", VA = "0x17F7680")]
		internal void CHOPCLCOBKC(PetActionData FDJJDECLGEG)
		{
		}
	}

	[Token(Token = "0x40052B4")]
	[FieldOffset(Offset = "0x40")]
	protected HHCBNAPCKHF PLGAAJABBHA;

	[Token(Token = "0x40052B5")]
	[FieldOffset(Offset = "0x44")]
	protected uint KINJCKMOGIM;

	[Token(Token = "0x40052B6")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_Model;

	[Token(Token = "0x40052B7")]
	[FieldOffset(Offset = "0x4C")]
	public PetAnimComponent m_AnimComp;

	[Token(Token = "0x40052B8")]
	[FieldOffset(Offset = "0x50")]
	public Transform NamePos;

	[Token(Token = "0x40052B9")]
	[FieldOffset(Offset = "0x54")]
	public bool ParachuteBinding;

	[Token(Token = "0x40052BA")]
	[FieldOffset(Offset = "0x58")]
	public string ParachuteBindBoneName;

	[Token(Token = "0x40052BB")]
	[FieldOffset(Offset = "0x5C")]
	public Vector3 ParachuteTargetOffset;

	[Token(Token = "0x40052BC")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 ParachuteTargetAngle;

	[Token(Token = "0x40052BD")]
	[FieldOffset(Offset = "0x74")]
	public bool ParachuteSimulation;

	[Token(Token = "0x40052BE")]
	[FieldOffset(Offset = "0x78")]
	protected float HCFIHHOJJOB;

	[Token(Token = "0x40052BF")]
	[FieldOffset(Offset = "0x7C")]
	protected float FHLJGLEGGCM;

	[Token(Token = "0x40052C0")]
	[FieldOffset(Offset = "0x80")]
	protected float DEBOLNHKOBN;

	[Token(Token = "0x40052C1")]
	[FieldOffset(Offset = "0x84")]
	protected float DIEBIPPHGDM;

	[Token(Token = "0x40052C2")]
	[FieldOffset(Offset = "0x88")]
	private float LPIMIOOEJGF;

	[Token(Token = "0x40052C3")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 GKALLKIDKBC;

	[Token(Token = "0x40052C4")]
	[FieldOffset(Offset = "0x98")]
	private float JMLEHHOOPAC;

	[Token(Token = "0x40052C5")]
	[FieldOffset(Offset = "0x9C")]
	private float PODKKOEGFGA;

	[Token(Token = "0x40052C6")]
	[FieldOffset(Offset = "0xA0")]
	private float BMPDNKPMFAK;

	[Token(Token = "0x40052C7")]
	[FieldOffset(Offset = "0xA4")]
	private float MBPBFGCBANH;

	[Token(Token = "0x40052C8")]
	[FieldOffset(Offset = "0xA8")]
	private float JAPMMLNLGCK;

	[Token(Token = "0x40052C9")]
	[FieldOffset(Offset = "0xAC")]
	private float KAPGEJLBLHO;

	[Token(Token = "0x40052CA")]
	[FieldOffset(Offset = "0xB0")]
	public LPNKIMBIJCB Category;

	[Token(Token = "0x40052CB")]
	[FieldOffset(Offset = "0xB4")]
	public uint Id;

	[Token(Token = "0x40052CC")]
	[FieldOffset(Offset = "0xB8")]
	public Player Owner;

	[Token(Token = "0x40052CD")]
	[FieldOffset(Offset = "0xC0")]
	public IHAAMHPPLMG OwnerID;

	[Token(Token = "0x40052CE")]
	[FieldOffset(Offset = "0xD8")]
	public string Name;

	[Token(Token = "0x40052CF")]
	[FieldOffset(Offset = "0xDC")]
	public int DataID;

	[Token(Token = "0x40052D0")]
	[FieldOffset(Offset = "0xE0")]
	public int Level;

	[Token(Token = "0x40052D1")]
	[FieldOffset(Offset = "0xE4")]
	private bool CAMGOMPBDMD;

	[Token(Token = "0x40052D2")]
	[FieldOffset(Offset = "0xE5")]
	private bool GKKONJPCCIG;

	[Token(Token = "0x40052D3")]
	[FieldOffset(Offset = "0xE8")]
	private float HLHKHDMPEPO;

	[Token(Token = "0x40052D4")]
	[FieldOffset(Offset = "0xEC")]
	public ODFIIFHKNNG m_CurrentAction;

	[Token(Token = "0x40052D5")]
	[FieldOffset(Offset = "0xF0")]
	public byte m_CurrentActionParam;

	[Token(Token = "0x40052D6")]
	[FieldOffset(Offset = "0xF1")]
	public bool m_LowQuality;

	[Token(Token = "0x40052D7")]
	[FieldOffset(Offset = "0xF2")]
	public bool m_HidingForRole;

	[Token(Token = "0x40052D8")]
	[FieldOffset(Offset = "0xF3")]
	public bool m_SkipShowAnimForRole;

	[Token(Token = "0x40052D9")]
	[FieldOffset(Offset = "0xF4")]
	public int m_SyncTick;

	[Token(Token = "0x40052DA")]
	[FieldOffset(Offset = "0xF8")]
	public int m_UpdateTick;

	[Token(Token = "0x40052DB")]
	[FieldOffset(Offset = "0xFC")]
	public float m_LastUpdateVisibilityTime;

	[Token(Token = "0x40052DC")]
	[FieldOffset(Offset = "0x100")]
	protected Transform NMDBEPKFKOA;

	[Token(Token = "0x40052DD")]
	[FieldOffset(Offset = "0x104")]
	protected bool ENCKCNBKOGF;

	[Token(Token = "0x40052DE")]
	[FieldOffset(Offset = "0x108")]
	protected float GJKCPNGIIAJ;

	[Token(Token = "0x40052DF")]
	[FieldOffset(Offset = "0x10C")]
	private List<uint> _003CEIMOIGLHDAE_003Ek__BackingField;

	[Token(Token = "0x40052E0")]
	[FieldOffset(Offset = "0x110")]
	protected List<LADDOKDJCBG> DPNPDAMCHDD;

	[Token(Token = "0x40052E1")]
	[FieldOffset(Offset = "0x114")]
	private bool _003CHFOKBJMILBN_003Ek__BackingField;

	[Token(Token = "0x17000410")]
	public List<uint> MEIGOKBINLL
	{
		[Token(Token = "0x6003AE9")]
		[Address(RVA = "0x17F0F6C", Offset = "0x17F0F6C", VA = "0x17F0F6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003AEA")]
		[Address(RVA = "0x17F0F74", Offset = "0x17F0F74", VA = "0x17F0F74")]
		set
		{
		}
	}

	[Token(Token = "0x17000411")]
	private static bool BMCEMPMEPLG
	{
		[Token(Token = "0x6003AEB")]
		[Address(RVA = "0x17F0F7C", Offset = "0x17F0F7C", VA = "0x17F0F7C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000412")]
	public bool PILCDPFMNHG
	{
		[Token(Token = "0x6003B01")]
		[Address(RVA = "0x17F4050", Offset = "0x17F4050", VA = "0x17F4050")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000413")]
	public bool KLPACHKFNBD
	{
		[Token(Token = "0x6003B03")]
		[Address(RVA = "0x17F4340", Offset = "0x17F4340", VA = "0x17F4340")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003B04")]
		[Address(RVA = "0x17F24BC", Offset = "0x17F24BC", VA = "0x17F24BC")]
		protected set
		{
		}
	}

	[Token(Token = "0x6003AE8")]
	[Address(RVA = "0x17F0F0C", Offset = "0x17F0F0C", VA = "0x17F0F0C")]
	public NetworkPet()
	{
	}

	[Token(Token = "0x6003AEC")]
	[Address(RVA = "0x17F104C", Offset = "0x17F104C", VA = "0x17F104C", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6003AED")]
	[Address(RVA = "0x17F10A4", Offset = "0x17F10A4", VA = "0x17F10A4")]
	public void Init(LPNKIMBIJCB LOKDEBLJINJ, uint IDNEFEOPGIF, Player FIMNKGABILM, string HINJBPEDIAL, int KFBALILGIIG, int EIKCFIDCCMM, PetData AJKBOONEOAB, PetSkinData OLIAJGCFLJM, bool KILJNIKEFFJ)
	{
	}

	[Token(Token = "0x6003AEE")]
	[Address(RVA = "0x17F180C", Offset = "0x17F180C", VA = "0x17F180C")]
	protected void LGBDFGHKIBJ()
	{
	}

	[Token(Token = "0x6003AEF")]
	[Address(RVA = "0x17F2764", Offset = "0x17F2764", VA = "0x17F2764")]
	public List<LADDOKDJCBG> GetSkills()
	{
		return null;
	}

	[Token(Token = "0x6003AF0")]
	[Address(RVA = "0x17F27BC", Offset = "0x17F27BC", VA = "0x17F27BC")]
	public LADDOKDJCBG GetSkill(GFCEKNKJFOM PMGBACFJIHO)
	{
		return null;
	}

	[Token(Token = "0x6003AF1")]
	[Address(RVA = "0x17F2978", Offset = "0x17F2978", VA = "0x17F2978")]
	public void AddSkill(LADDOKDJCBG PHEJDNJONIL)
	{
	}

	[Token(Token = "0x6003AF2")]
	[Address(RVA = "0x17F2A84", Offset = "0x17F2A84", VA = "0x17F2A84")]
	private void PMBDANJKBCE()
	{
	}

	[Token(Token = "0x6003AF3")]
	[Address(RVA = "0x17F2558", Offset = "0x17F2558", VA = "0x17F2558")]
	protected void HLPCOLLPANJ()
	{
	}

	[Token(Token = "0x6003AF4")]
	[Address(RVA = "0x17F2C50", Offset = "0x17F2C50", VA = "0x17F2C50")]
	protected void NNEPBFMNLGC()
	{
	}

	[Token(Token = "0x6003AF5")]
	[Address(RVA = "0x17F1990", Offset = "0x17F1990", VA = "0x17F1990")]
	public List<PetActionData> GetAllActionData()
	{
		return null;
	}

	[Token(Token = "0x6003AF6")]
	[Address(RVA = "0x17F3124", Offset = "0x17F3124", VA = "0x17F3124")]
	public List<PetActionData> GetUnlockedActionData()
	{
		return null;
	}

	[Token(Token = "0x6003AF7")]
	[Address(RVA = "0x17F3294", Offset = "0x17F3294", VA = "0x17F3294")]
	public float GetCurrentPetSkillCD()
	{
		return default(float);
	}

	[Token(Token = "0x6003AF8")]
	[Address(RVA = "0x17F3500", Offset = "0x17F3500", VA = "0x17F3500")]
	public PetSkillLevelData GetCurrentPetSkill()
	{
		return null;
	}

	[Token(Token = "0x6003AF9")]
	[Address(RVA = "0x17F2E5C", Offset = "0x17F2E5C", VA = "0x17F2E5C")]
	private static void BNEFDMFCIJP(int CCLAIMKALJG, List<uint> HJKLCOGBAJI, Action<PetActionData> IBJIDAEAKED)
	{
	}

	[Token(Token = "0x6003AFA")]
	[Address(RVA = "0x17F36E4", Offset = "0x17F36E4", VA = "0x17F36E4")]
	public float GetNameHeight()
	{
		return default(float);
	}

	[Token(Token = "0x6003AFB")]
	[Address(RVA = "0x17F373C", Offset = "0x17F373C", VA = "0x17F373C")]
	public static bool IsMoving(ODFIIFHKNNG HGMBMICDALC)
	{
		return default(bool);
	}

	[Token(Token = "0x6003AFC")]
	[Address(RVA = "0x17F37A8", Offset = "0x17F37A8", VA = "0x17F37A8")]
	public bool IsPlayerPet()
	{
		return default(bool);
	}

	[Token(Token = "0x6003AFD")]
	[Address(RVA = "0x17F24C4", Offset = "0x17F24C4", VA = "0x17F24C4")]
	protected void OCEAEBICINJ()
	{
	}

	[Token(Token = "0x6003AFE")]
	[Address(RVA = "0x17F3BEC", Offset = "0x17F3BEC", VA = "0x17F3BEC")]
	protected void OANHJLPJBLK()
	{
	}

	[Token(Token = "0x6003AFF")]
	[Address(RVA = "0x17F3964", Offset = "0x17F3964", VA = "0x17F3964")]
	protected void IMBDKGNCOEC(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x6003B00")]
	[Address(RVA = "0x17F3C50", Offset = "0x17F3C50", VA = "0x17F3C50")]
	protected void GJHLDNPNNMJ()
	{
	}

	[Token(Token = "0x6003B02")]
	[Address(RVA = "0x17F4100", Offset = "0x17F4100", VA = "0x17F4100")]
	protected void BMKBPGHEIIF(bool ODOEHEHNJOG, bool PODKEPNOBON)
	{
	}

	[Token(Token = "0x6003B05")]
	[Address(RVA = "0x17F4348", Offset = "0x17F4348", VA = "0x17F4348")]
	public void RequestPlayAnim(uint IDNEFEOPGIF, bool NAAOIEPNAOI = false)
	{
	}

	[Token(Token = "0x6003B06")]
	[Address(RVA = "0x17F460C", Offset = "0x17F460C", VA = "0x17F460C")]
	public void RequestShowPet()
	{
	}

	[Token(Token = "0x6003B07")]
	[Address(RVA = "0x17F4674", Offset = "0x17F4674", VA = "0x17F4674")]
	public void RequestHidePet()
	{
	}

	[Token(Token = "0x6003B08")]
	[Address(RVA = "0x17F46DC", Offset = "0x17F46DC", VA = "0x17F46DC")]
	private void IBDOIKFADJK(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6003B09")]
	[Address(RVA = "0x17F1B68", Offset = "0x17F1B68", VA = "0x17F1B68")]
	private void HFNBMAKGHFP(bool DBOKAKKINPP = false)
	{
	}

	[Token(Token = "0x6003B0A")]
	[Address(RVA = "0x17F1AB0", Offset = "0x17F1AB0", VA = "0x17F1AB0")]
	private void HNPLCIGMIGI(bool HHDBPDCKAGO, bool CJEEDJMJPPE, bool MKLKBFHMNBD = false)
	{
	}

	[Token(Token = "0x6003B0B")]
	[Address(RVA = "0x17F4748", Offset = "0x17F4748", VA = "0x17F4748")]
	public void SyncState(uint ODKCAFDDNIA, EMNNEAFNALO HLADFEKELKI)
	{
	}

	[Token(Token = "0x6003B0C")]
	[Address(RVA = "0x17F49F4", Offset = "0x17F49F4", VA = "0x17F49F4")]
	private void AKNHNDPCGAM(uint ODKCAFDDNIA, EMNNEAFNALO HLADFEKELKI)
	{
	}

	[Token(Token = "0x6003B0D")]
	[Address(RVA = "0x17F5008", Offset = "0x17F5008", VA = "0x17F5008", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6003B0E")]
	[Address(RVA = "0x17F5E50", Offset = "0x17F5E50", VA = "0x17F5E50")]
	private void LNOOLABJFLN(bool DDKAJEIALJH, bool CFELGDMAGJH, float OPKNJGBDOBB)
	{
	}

	[Token(Token = "0x6003B0F")]
	[Address(RVA = "0x17F632C", Offset = "0x17F632C", VA = "0x17F632C")]
	private bool PEPEPEABCDL()
	{
		return default(bool);
	}

	[Token(Token = "0x6003B10")]
	[Address(RVA = "0x17F65E4", Offset = "0x17F65E4", VA = "0x17F65E4")]
	public void SimParachutting(float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6003B11")]
	[Address(RVA = "0x17F672C", Offset = "0x17F672C", VA = "0x17F672C", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6003B12")]
	[Address(RVA = "0x17F5A5C", Offset = "0x17F5A5C", VA = "0x17F5A5C")]
	protected void KMHFCKOHFAD(float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6003B13")]
	[Address(RVA = "0x17F6AA8", Offset = "0x17F6AA8", VA = "0x17F6AA8")]
	protected void MNFCCAGKKMG()
	{
	}

	[Token(Token = "0x6003B14")]
	[Address(RVA = "0x17F4828", Offset = "0x17F4828", VA = "0x17F4828")]
	protected void FAKHBHALKIE(ODFIIFHKNNG MPNMJMENKFD, uint ODKCAFDDNIA, EMNNEAFNALO HLADFEKELKI)
	{
	}

	[Token(Token = "0x6003B15")]
	[Address(RVA = "0x17F6E08", Offset = "0x17F6E08", VA = "0x17F6E08")]
	public void ForceShowHide()
	{
	}

	[Token(Token = "0x6003B16")]
	[Address(RVA = "0x17F6E6C", Offset = "0x17F6E6C", VA = "0x17F6E6C")]
	protected void APIJFFEMDJP(bool NKICGJCNFKM)
	{
	}

	[Token(Token = "0x6003B17")]
	[Address(RVA = "0x17F6064", Offset = "0x17F6064", VA = "0x17F6064")]
	protected bool OPCKHHIFGEH()
	{
		return default(bool);
	}

	[Token(Token = "0x6003B18")]
	[Address(RVA = "0x17F6534", Offset = "0x17F6534", VA = "0x17F6534")]
	protected void GLDCPDELDME(bool FICNJIMKAEF, bool NKICGJCNFKM)
	{
	}

	[Token(Token = "0x6003B19")]
	[Address(RVA = "0x17F6EE4", Offset = "0x17F6EE4", VA = "0x17F6EE4")]
	protected void OMCIKAPNPKD(bool NKICGJCNFKM)
	{
	}

	[Token(Token = "0x6003B1A")]
	[Address(RVA = "0x17F5F44", Offset = "0x17F5F44", VA = "0x17F5F44")]
	protected bool EIHICHKIJMO()
	{
		return default(bool);
	}

	[Token(Token = "0x6003B1B")]
	[Address(RVA = "0x17F6B98", Offset = "0x17F6B98", VA = "0x17F6B98")]
	protected void PPLFICAFDBO()
	{
	}

	[Token(Token = "0x6003B1C")]
	[Address(RVA = "0x17F3814", Offset = "0x17F3814", VA = "0x17F3814")]
	protected void OMELFKBLNLG()
	{
	}

	[Token(Token = "0x6003B1D")]
	[Address(RVA = "0x17F5304", Offset = "0x17F5304", VA = "0x17F5304")]
	protected void NCMHGFJPPIB(float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6003B1E")]
	[Address(RVA = "0x17F6F5C", Offset = "0x17F6F5C", VA = "0x17F6F5C")]
	private void LDCDODNBBMC()
	{
	}

	[Token(Token = "0x6003B1F")]
	[Address(RVA = "0x17F70F0", Offset = "0x17F70F0", VA = "0x17F70F0")]
	public void ChangeSkin(uint AKJDPFADPGH)
	{
	}

	[Token(Token = "0x6003B20")]
	[Address(RVA = "0x17F3E44", Offset = "0x17F3E44", VA = "0x17F3E44")]
	private void BGLKFBLBHJB()
	{
	}

	[Token(Token = "0x6003B21")]
	[Address(RVA = "0x17F72DC", Offset = "0x17F72DC", VA = "0x17F72DC")]
	public void DestorySelf()
	{
	}

	[Token(Token = "0x6003B22")]
	[Address(RVA = "0x17F73F0", Offset = "0x17F73F0", VA = "0x17F73F0")]
	protected void CKHNLJPFMHH()
	{
	}

	[Token(Token = "0x6003B23")]
	[Address(RVA = "0x17F7670", Offset = "0x17F7670", VA = "0x17F7670")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6003B24")]
	[Address(RVA = "0x17F7678", Offset = "0x17F7678", VA = "0x17F7678")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}
}
