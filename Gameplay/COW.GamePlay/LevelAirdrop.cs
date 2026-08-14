using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005D4")]
internal class LevelAirdrop : BaseLevelObject
{
	[Token(Token = "0x20005D5")]
	public enum LFBPAOIEMHB
	{
		[Token(Token = "0x4004413")]
		SYNC_STATE,
		[Token(Token = "0x4004414")]
		INTO_WATER,
		[Token(Token = "0x4004415")]
		SYNC_REENTER,
		[Token(Token = "0x4004416")]
		SYNC_ZombieSurprise,
		[Token(Token = "0x4004417")]
		DESTROY
	}

	[Token(Token = "0x400440B")]
	[FieldOffset(Offset = "0x74")]
	public Airdrop m_Airdrop;

	[Token(Token = "0x400440C")]
	[FieldOffset(Offset = "0x78")]
	private bool KMOJDCGANCA;

	[Token(Token = "0x400440D")]
	[FieldOffset(Offset = "0x79")]
	private bool EPBEOAIBPPL;

	[Token(Token = "0x400440E")]
	[FieldOffset(Offset = "0x7C")]
	private ResourceID DOPFONNLKPK;

	[Token(Token = "0x400440F")]
	[FieldOffset(Offset = "0x80")]
	private GameObject IOFJIFHGKGO;

	[Token(Token = "0x4004410")]
	[FieldOffset(Offset = "0x84")]
	private bool NOLNFIPGJDO;

	[Token(Token = "0x4004411")]
	[FieldOffset(Offset = "0x88")]
	private uint _003CPHBPGDMJJLJ_003Ek__BackingField;

	[Token(Token = "0x170002E0")]
	public uint MEDANIICJLE
	{
		[Token(Token = "0x6002331")]
		[Address(RVA = "0x17D4F58", Offset = "0x17D4F58", VA = "0x17D4F58")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6002332")]
		[Address(RVA = "0x17D4F60", Offset = "0x17D4F60", VA = "0x17D4F60")]
		set
		{
		}
	}

	[Token(Token = "0x6002330")]
	[Address(RVA = "0x17D4EB8", Offset = "0x17D4EB8", VA = "0x17D4EB8")]
	public LevelAirdrop()
	{
	}

	[Token(Token = "0x6002333")]
	[Address(RVA = "0x17D4F68", Offset = "0x17D4F68", VA = "0x17D4F68", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002334")]
	[Address(RVA = "0x17D500C", Offset = "0x17D500C", VA = "0x17D500C")]
	public void SetShowOnMap(bool ODOEHEHNJOG)
	{
	}

	[Token(Token = "0x6002335")]
	[Address(RVA = "0x17D5074", Offset = "0x17D5074", VA = "0x17D5074", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002336")]
	[Address(RVA = "0x17D5498", Offset = "0x17D5498", VA = "0x17D5498", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002337")]
	[Address(RVA = "0x17D5198", Offset = "0x17D5198", VA = "0x17D5198")]
	private void MDNJDMEBMLE(bool ODOEHEHNJOG)
	{
	}

	[Token(Token = "0x6002338")]
	[Address(RVA = "0x17D5514", Offset = "0x17D5514", VA = "0x17D5514", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002339")]
	[Address(RVA = "0x17D59D0", Offset = "0x17D59D0", VA = "0x17D59D0")]
	public void ProcessAirDropBreathEffect(bool OBMBEMKCFFH, bool MGINMBAJDHN)
	{
	}

	[Token(Token = "0x600233A")]
	[Address(RVA = "0x17D6128", Offset = "0x17D6128", VA = "0x17D6128")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x600233B")]
	[Address(RVA = "0x17D6130", Offset = "0x17D6130", VA = "0x17D6130")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x600233C")]
	[Address(RVA = "0x17D6138", Offset = "0x17D6138", VA = "0x17D6138")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
