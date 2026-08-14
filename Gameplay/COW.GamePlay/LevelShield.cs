using GCommon;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x2000694")]
internal class LevelShield : BaseLevelObject
{
	[Token(Token = "0x40048B0")]
	[FieldOffset(Offset = "0x74")]
	private Shield PJGPHLPNNLF;

	[Token(Token = "0x40048B1")]
	[FieldOffset(Offset = "0x78")]
	private Vehicle PAIEJAAJOMJ;

	[Token(Token = "0x40048B2")]
	[FieldOffset(Offset = "0x7C")]
	private uint _003CABEFPHHANPE_003Ek__BackingField;

	[Token(Token = "0x1700033E")]
	public uint LMOOCPALJDD
	{
		[Token(Token = "0x6002A31")]
		[Address(RVA = "0x20CD790", Offset = "0x20CD790", VA = "0x20CD790")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6002A32")]
		[Address(RVA = "0x20CD798", Offset = "0x20CD798", VA = "0x20CD798")]
		private set
		{
		}
	}

	[Token(Token = "0x6002A2E")]
	[Address(RVA = "0x20CD68C", Offset = "0x20CD68C", VA = "0x20CD68C")]
	public LevelShield()
	{
	}

	[Token(Token = "0x6002A2F")]
	[Address(RVA = "0x20CD694", Offset = "0x20CD694", VA = "0x20CD694", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002A30")]
	[Address(RVA = "0x20CD738", Offset = "0x20CD738", VA = "0x20CD738", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002A33")]
	[Address(RVA = "0x20CD7A0", Offset = "0x20CD7A0", VA = "0x20CD7A0")]
	public void BindWithVehicle(Vehicle NOLNFIAPLND)
	{
	}

	[Token(Token = "0x6002A34")]
	[Address(RVA = "0x20CDB68", Offset = "0x20CDB68", VA = "0x20CDB68", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002A35")]
	[Address(RVA = "0x20CDD88", Offset = "0x20CDD88", VA = "0x20CDD88", Slot = "40")]
	public virtual uint GetMaxHP()
	{
		return default(uint);
	}

	[Token(Token = "0x6002A36")]
	[Address(RVA = "0x20CDE60", Offset = "0x20CDE60", VA = "0x20CDE60", Slot = "41")]
	protected virtual void MNKMALKKPEA(int JGLJDJFHPBO, int DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002A37")]
	[Address(RVA = "0x20CE078", Offset = "0x20CE078", VA = "0x20CE078", Slot = "42")]
	public virtual ResourceID GetModelResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002A38")]
	[Address(RVA = "0x20CE128", Offset = "0x20CE128", VA = "0x20CE128")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002A39")]
	[Address(RVA = "0x20CE130", Offset = "0x20CE130", VA = "0x20CE130")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}
}
