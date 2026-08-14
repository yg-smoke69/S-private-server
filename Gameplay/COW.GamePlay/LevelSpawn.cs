using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x20006A1")]
public class LevelSpawn : BaseLevelObject
{
	[Token(Token = "0x40048E0")]
	[FieldOffset(Offset = "0x74")]
	public int SpawnObjectType;

	[Token(Token = "0x6002A90")]
	[Address(RVA = "0x20D1D50", Offset = "0x20D1D50", VA = "0x20D1D50")]
	public LevelSpawn()
	{
	}

	[Token(Token = "0x6002A91")]
	[Address(RVA = "0x20D1D58", Offset = "0x20D1D58", VA = "0x20D1D58", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6002A92")]
	[Address(RVA = "0x20D1EC4", Offset = "0x20D1EC4", VA = "0x20D1EC4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002A93")]
	[Address(RVA = "0x20D1F68", Offset = "0x20D1F68", VA = "0x20D1F68", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002A94")]
	[Address(RVA = "0x20D20EC", Offset = "0x20D20EC", VA = "0x20D20EC")]
	public void InitAttachModel(uint KFBALILGIIG, ushort IEPFELEIMFE)
	{
	}

	[Token(Token = "0x6002A95")]
	[Address(RVA = "0x20D24A8", Offset = "0x20D24A8", VA = "0x20D24A8")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x6002A96")]
	[Address(RVA = "0x20D24B0", Offset = "0x20D24B0", VA = "0x20D24B0")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
