using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006A0")]
internal class LevelSpaceShield : BaseLevelObject
{
	[Token(Token = "0x40048D2")]
	[FieldOffset(Offset = "0x74")]
	private PhyXShield PJGPHLPNNLF;

	[Token(Token = "0x40048D3")]
	[FieldOffset(Offset = "0x78")]
	private bool EGFFADLIBOC;

	[Token(Token = "0x40048D4")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject MeshColliderObj;

	[Token(Token = "0x40048D5")]
	[FieldOffset(Offset = "0x80")]
	public GameObject SphereColliderObj;

	[Token(Token = "0x40048D6")]
	[FieldOffset(Offset = "0x84")]
	public GameObject ColliderObject;

	[Token(Token = "0x40048D7")]
	[FieldOffset(Offset = "0x88")]
	public Animation ShieldEffectAnim;

	[Token(Token = "0x40048D8")]
	[FieldOffset(Offset = "0x8C")]
	public MeshRenderer LowQualityMeshRenderer;

	[Token(Token = "0x40048D9")]
	[FieldOffset(Offset = "0x90")]
	public MeshRenderer[] QualityMeshRenderer;

	[Token(Token = "0x40048DA")]
	public const string ANIMATION_CLIP_FRIEND_NAME = "VFX_Bounty_Shield_Start01";

	[Token(Token = "0x40048DB")]
	public const string ANIMATION_CLIP_ENEMY_NAME = "VFX_Bounty_Shield_Start02";

	[Token(Token = "0x40048DC")]
	[FieldOffset(Offset = "0x94")]
	private bool COEPIKEOBGP;

	[Token(Token = "0x40048DD")]
	[FieldOffset(Offset = "0x98")]
	private uint _003CABEFPHHANPE_003Ek__BackingField;

	[Token(Token = "0x40048DE")]
	[FieldOffset(Offset = "0x9C")]
	private uint _003CPLPPCGPDKGA_003Ek__BackingField;

	[Token(Token = "0x40048DF")]
	[FieldOffset(Offset = "0xA0")]
	private NBDKOJPKMNG _003CPHGODKCPLJB_003Ek__BackingField;

	[Token(Token = "0x1700033F")]
	public uint LMOOCPALJDD
	{
		[Token(Token = "0x6002A7A")]
		[Address(RVA = "0x20D04B4", Offset = "0x20D04B4", VA = "0x20D04B4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6002A7B")]
		[Address(RVA = "0x20D04BC", Offset = "0x20D04BC", VA = "0x20D04BC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000340")]
	public uint JMFDKFEGFLK
	{
		[Token(Token = "0x6002A7C")]
		[Address(RVA = "0x20D04C4", Offset = "0x20D04C4", VA = "0x20D04C4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6002A7D")]
		[Address(RVA = "0x20D04CC", Offset = "0x20D04CC", VA = "0x20D04CC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000341")]
	public NBDKOJPKMNG DOGKCEJMKID
	{
		[Token(Token = "0x6002A7E")]
		[Address(RVA = "0x20D04D4", Offset = "0x20D04D4", VA = "0x20D04D4")]
		get
		{
			return default(NBDKOJPKMNG);
		}
		[Token(Token = "0x6002A7F")]
		[Address(RVA = "0x20D04DC", Offset = "0x20D04DC", VA = "0x20D04DC")]
		private set
		{
		}
	}

	[Token(Token = "0x6002A79")]
	[Address(RVA = "0x20D04AC", Offset = "0x20D04AC", VA = "0x20D04AC")]
	public LevelSpaceShield()
	{
	}

	[Token(Token = "0x6002A80")]
	[Address(RVA = "0x20D04E4", Offset = "0x20D04E4", VA = "0x20D04E4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002A81")]
	[Address(RVA = "0x20D0588", Offset = "0x20D0588", VA = "0x20D0588", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002A82")]
	[Address(RVA = "0x20D05E0", Offset = "0x20D05E0", VA = "0x20D05E0")]
	public void Init(uint INNOJJAHLPC, uint HGHENLNEJIK)
	{
	}

	[Token(Token = "0x6002A83")]
	[Address(RVA = "0x20D0670", Offset = "0x20D0670", VA = "0x20D0670")]
	public void InitPhyx()
	{
	}

	[Token(Token = "0x6002A84")]
	[Address(RVA = "0x20D081C", Offset = "0x20D081C", VA = "0x20D081C", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002A85")]
	[Address(RVA = "0x20D09B4", Offset = "0x20D09B4", VA = "0x20D09B4", Slot = "40")]
	protected virtual void MNKMALKKPEA(int JGLJDJFHPBO, int DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002A86")]
	[Address(RVA = "0x20D0C64", Offset = "0x20D0C64", VA = "0x20D0C64")]
	public static LevelSpaceShield CreateSpaceShiled(uint IEPFELEIMFE, uint OLMNPOECBHH, uint INNOJJAHLPC, uint HGHENLNEJIK, Vector3 ACCOJJMKKPM, bool FNOABBFDFDD, bool HOGPMHLLOKA)
	{
		return null;
	}

	[Token(Token = "0x6002A87")]
	[Address(RVA = "0x20D1388", Offset = "0x20D1388", VA = "0x20D1388")]
	public void SetShieldHighQuality(bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x6002A88")]
	[Address(RVA = "0x20D0A90", Offset = "0x20D0A90", VA = "0x20D0A90")]
	public void SetDecalEffect(bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x6002A89")]
	[Address(RVA = "0x20D1474", Offset = "0x20D1474", VA = "0x20D1474", Slot = "29")]
	protected override void UnRegisterEntity()
	{
	}

	[Token(Token = "0x6002A8A")]
	[Address(RVA = "0x20D14E0", Offset = "0x20D14E0", VA = "0x20D14E0")]
	public void DestroyShield(uint OMNGGLFFMGM)
	{
	}

	[Token(Token = "0x6002A8B")]
	[Address(RVA = "0x20D17D0", Offset = "0x20D17D0", VA = "0x20D17D0")]
	private void MPGPCJCGBDE()
	{
	}

	[Token(Token = "0x6002A8C")]
	[Address(RVA = "0x20D1A60", Offset = "0x20D1A60", VA = "0x20D1A60")]
	private void FILGNCEOGNO()
	{
	}

	[Token(Token = "0x6002A8D")]
	[Address(RVA = "0x20D1D38", Offset = "0x20D1D38", VA = "0x20D1D38")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002A8E")]
	[Address(RVA = "0x20D1D40", Offset = "0x20D1D40", VA = "0x20D1D40")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002A8F")]
	[Address(RVA = "0x20D1D48", Offset = "0x20D1D48", VA = "0x20D1D48")]
	public void _003C_003EiFixBaseProxy_UnRegisterEntity()
	{
	}
}
