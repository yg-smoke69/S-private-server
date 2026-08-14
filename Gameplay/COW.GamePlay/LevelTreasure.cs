using Il2CppDummyDll;
using message;

namespace COW.GamePlay;

[Token(Token = "0x20006C2")]
public class LevelTreasure : BaseLevelObject
{
	[Token(Token = "0x4004AB2")]
	[FieldOffset(Offset = "0x74")]
	public PickupTreasureBox m_PickupTreasureBox;

	[Token(Token = "0x4004AB3")]
	[FieldOffset(Offset = "0x78")]
	public ulong m_OwnerID;

	[Token(Token = "0x4004AB4")]
	[FieldOffset(Offset = "0x80")]
	public bool m_IsDiggedOut;

	[Token(Token = "0x4004AB5")]
	[FieldOffset(Offset = "0x84")]
	public uint m_ContainerID;

	[Token(Token = "0x4004AB6")]
	[FieldOffset(Offset = "0x88")]
	public EGLJHKJKBKC m_TreasureType;

	[Token(Token = "0x6002B5F")]
	[Address(RVA = "0x24272C0", Offset = "0x24272C0", VA = "0x24272C0")]
	public LevelTreasure()
	{
	}

	[Token(Token = "0x6002B60")]
	[Address(RVA = "0x24272C8", Offset = "0x24272C8", VA = "0x24272C8", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002B61")]
	[Address(RVA = "0x242736C", Offset = "0x242736C", VA = "0x242736C", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002B62")]
	[Address(RVA = "0x24282F8", Offset = "0x24282F8", VA = "0x24282F8")]
	public void OnTreasureTrigger(bool LNADELIDMNN)
	{
	}

	[Token(Token = "0x6002B63")]
	[Address(RVA = "0x2428798", Offset = "0x2428798", VA = "0x2428798")]
	public void Delete()
	{
	}

	[Token(Token = "0x6002B64")]
	[Address(RVA = "0x2428024", Offset = "0x2428024", VA = "0x2428024")]
	private void PMDBBPIKIAH()
	{
	}

	[Token(Token = "0x6002B65")]
	[Address(RVA = "0x2428B5C", Offset = "0x2428B5C", VA = "0x2428B5C")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
