using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x20006DC")]
internal class LevelVehicle : BaseLevelObject
{
	[Token(Token = "0x20006DD")]
	public enum AGBGMJCEDBL
	{
		[Token(Token = "0x4004B13")]
		GET_ON,
		[Token(Token = "0x4004B14")]
		GET_OFF,
		[Token(Token = "0x4004B15")]
		INIT_STATE,
		[Token(Token = "0x4004B16")]
		FORCE_SYNC_STATE,
		[Token(Token = "0x4004B17")]
		SYNC_STATE,
		[Token(Token = "0x4004B18")]
		DEAD,
		[Token(Token = "0x4004B19")]
		EXPLODE,
		[Token(Token = "0x4004B1A")]
		INV_SYNC,
		[Token(Token = "0x4004B1B")]
		INV_PICKUP,
		[Token(Token = "0x4004B1C")]
		INV_DROP,
		[Token(Token = "0x4004B1D")]
		INV_CHANGE,
		[Token(Token = "0x4004B1E")]
		CHANGE_AUTH,
		[Token(Token = "0x4004B1F")]
		CHANGE_SEAT,
		[Token(Token = "0x4004B20")]
		SYNC_POSITION
	}

	[Token(Token = "0x4004B0F")]
	[FieldOffset(Offset = "0x74")]
	public Vehicle m_Vehicle;

	[Token(Token = "0x4004B10")]
	[FieldOffset(Offset = "0x78")]
	public bool IsLocalPlayerEnteredTrigger;

	[Token(Token = "0x4004B11")]
	[FieldOffset(Offset = "0x7C")]
	private JIOIIELIHAO COLEAPKGFLK;

	[Token(Token = "0x1700034D")]
	public JIOIIELIHAO NPCNMJAGIKI
	{
		[Token(Token = "0x6002BCB")]
		[Address(RVA = "0x2430300", Offset = "0x2430300", VA = "0x2430300")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700034E")]
	public bool BCEDHMPJEIP
	{
		[Token(Token = "0x6002BCC")]
		[Address(RVA = "0x24303E8", Offset = "0x24303E8", VA = "0x24303E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700034F")]
	public int LJBCNMIFEFJ
	{
		[Token(Token = "0x6002BD6")]
		[Address(RVA = "0x2432BF0", Offset = "0x2432BF0", VA = "0x2432BF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002BD7")]
		[Address(RVA = "0x2432D18", Offset = "0x2432D18", VA = "0x2432D18")]
		set
		{
		}
	}

	[Token(Token = "0x17000350")]
	public int JMFDKFEGFLK
	{
		[Token(Token = "0x6002BD8")]
		[Address(RVA = "0x2432E40", Offset = "0x2432E40", VA = "0x2432E40")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002BD9")]
		[Address(RVA = "0x2432F68", Offset = "0x2432F68", VA = "0x2432F68")]
		set
		{
		}
	}

	[Token(Token = "0x17000351")]
	public byte FAHNDLOIALL
	{
		[Token(Token = "0x6002BDA")]
		[Address(RVA = "0x2433090", Offset = "0x2433090", VA = "0x2433090")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6002BDB")]
		[Address(RVA = "0x24331B4", Offset = "0x24331B4", VA = "0x24331B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000352")]
	public byte FDFPBCEDIGD
	{
		[Token(Token = "0x6002BDC")]
		[Address(RVA = "0x24332DC", Offset = "0x24332DC", VA = "0x24332DC")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6002BDD")]
		[Address(RVA = "0x2433400", Offset = "0x2433400", VA = "0x2433400")]
		set
		{
		}
	}

	[Token(Token = "0x17000353")]
	public byte CECAMCCBFDM
	{
		[Token(Token = "0x6002BDE")]
		[Address(RVA = "0x2433528", Offset = "0x2433528", VA = "0x2433528")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6002BDF")]
		[Address(RVA = "0x243364C", Offset = "0x243364C", VA = "0x243364C")]
		set
		{
		}
	}

	[Token(Token = "0x17000354")]
	public uint GAPBDHBOCBE
	{
		[Token(Token = "0x6002BE0")]
		[Address(RVA = "0x2433774", Offset = "0x2433774", VA = "0x2433774")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6002BE1")]
		[Address(RVA = "0x2433898", Offset = "0x2433898", VA = "0x2433898")]
		set
		{
		}
	}

	[Token(Token = "0x6002BC9")]
	[Address(RVA = "0x24301D0", Offset = "0x24301D0", VA = "0x24301D0")]
	public LevelVehicle()
	{
	}

	[Token(Token = "0x6002BCA")]
	[Address(RVA = "0x24301D8", Offset = "0x24301D8", VA = "0x24301D8", Slot = "33")]
	public override void RegisterThis(OFJHNKMJNGA PMGBACFJIHO, uint IDNEFEOPGIF)
	{
	}

	[Token(Token = "0x6002BCD")]
	[Address(RVA = "0x243044C", Offset = "0x243044C", VA = "0x243044C")]
	public bool IsEquipped(PPPNNCOCOOI CKOOGPANEEC)
	{
		return default(bool);
	}

	[Token(Token = "0x6002BCE")]
	[Address(RVA = "0x24304CC", Offset = "0x24304CC", VA = "0x24304CC")]
	public bool UseEquipped(PPPNNCOCOOI CKOOGPANEEC)
	{
		return default(bool);
	}

	[Token(Token = "0x6002BCF")]
	[Address(RVA = "0x2430570", Offset = "0x2430570", VA = "0x2430570")]
	public void SetVehicleData(KLODDDDBAFP AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6002BD0")]
	[Address(RVA = "0x243070C", Offset = "0x243070C", VA = "0x243070C")]
	public void SetVisibility(uint EBOJJLIHHCM, bool JOGHOHLEJFL)
	{
	}

	[Token(Token = "0x6002BD1")]
	[Address(RVA = "0x24307B4", Offset = "0x24307B4", VA = "0x24307B4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002BD2")]
	[Address(RVA = "0x2430858", Offset = "0x2430858", VA = "0x2430858")]
	public byte GetTeamID()
	{
		return default(byte);
	}

	[Token(Token = "0x6002BD3")]
	[Address(RVA = "0x2430940", Offset = "0x2430940", VA = "0x2430940", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002BD4")]
	[Address(RVA = "0x2431628", Offset = "0x2431628", VA = "0x2431628", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002BD5")]
	[Address(RVA = "0x2432B98", Offset = "0x2432B98", VA = "0x2432B98", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002BE2")]
	[Address(RVA = "0x24339C0", Offset = "0x24339C0", VA = "0x24339C0", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002BE3")]
	[Address(RVA = "0x24343E0", Offset = "0x24343E0", VA = "0x24343E0", Slot = "40")]
	protected virtual void MNKMALKKPEA(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002BE4")]
	[Address(RVA = "0x2434A68", Offset = "0x2434A68", VA = "0x2434A68", Slot = "41")]
	protected virtual void MINFFBODCOL(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002BE5")]
	[Address(RVA = "0x2434610", Offset = "0x2434610", VA = "0x2434610")]
	public void PlayDamageEffectAndSound()
	{
	}

	[Token(Token = "0x6002BE6")]
	[Address(RVA = "0x2434BF8", Offset = "0x2434BF8", VA = "0x2434BF8")]
	private void DOBIFLAOKBH(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002BE7")]
	[Address(RVA = "0x2434C9C", Offset = "0x2434C9C", VA = "0x2434C9C")]
	private void BMBEHBCJEOH(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002BE8")]
	[Address(RVA = "0x2434D40", Offset = "0x2434D40", VA = "0x2434D40")]
	private void JNEMPAMPNNF(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002BE9")]
	[Address(RVA = "0x2434DE4", Offset = "0x2434DE4", VA = "0x2434DE4")]
	private void CCMIHNFJIMG(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002BEA")]
	[Address(RVA = "0x2434E8C", Offset = "0x2434E8C", VA = "0x2434E8C")]
	private void OLALOALHBNO(bool JGLJDJFHPBO, bool DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002BEB")]
	[Address(RVA = "0x2434F28", Offset = "0x2434F28", VA = "0x2434F28")]
	public void OnVehicleGearVFXReceived()
	{
	}

	[Token(Token = "0x6002BEC")]
	[Address(RVA = "0x2434FA0", Offset = "0x2434FA0", VA = "0x2434FA0")]
	private void EKJCGFNDGOE(bool JGLJDJFHPBO, bool DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002BED")]
	[Address(RVA = "0x243503C", Offset = "0x243503C", VA = "0x243503C")]
	private void CGFPADKDOII(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002BEE")]
	[Address(RVA = "0x2435420", Offset = "0x2435420", VA = "0x2435420")]
	public void HideAirDropEffect()
	{
	}

	[Token(Token = "0x6002BEF")]
	[Address(RVA = "0x24354A4", Offset = "0x24354A4", VA = "0x24354A4")]
	public void EnableShield()
	{
	}

	[Token(Token = "0x6002BF0")]
	[Address(RVA = "0x24357D8", Offset = "0x24357D8", VA = "0x24357D8")]
	public void _003C_003EiFixBaseProxy_RegisterThis(OFJHNKMJNGA P0, uint P1)
	{
	}

	[Token(Token = "0x6002BF1")]
	[Address(RVA = "0x24357E0", Offset = "0x24357E0", VA = "0x24357E0")]
	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	[Token(Token = "0x6002BF2")]
	[Address(RVA = "0x24357E8", Offset = "0x24357E8", VA = "0x24357E8")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	[Token(Token = "0x6002BF3")]
	[Address(RVA = "0x24357F0", Offset = "0x24357F0", VA = "0x24357F0")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002BF4")]
	[Address(RVA = "0x24357F8", Offset = "0x24357F8", VA = "0x24357F8")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}
}
