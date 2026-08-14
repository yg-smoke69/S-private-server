using Il2CppDummyDll;

[Token(Token = "0x2000A73")]
public class PlayerBountyWaitingSpawnRegion : PlayerSpawnRegion
{
	[Token(Token = "0x4005C3D")]
	[FieldOffset(Offset = "0x28")]
	public bool IsSwitchingRegion;

	[Token(Token = "0x4005C3E")]
	[FieldOffset(Offset = "0x2C")]
	public int RegionIndex;

	[Token(Token = "0x4005C3F")]
	[FieldOffset(Offset = "0x30")]
	public bool IsSingleGameUse;

	[Token(Token = "0x600509F")]
	[Address(RVA = "0x1E1DE04", Offset = "0x1E1DE04", VA = "0x1E1DE04")]
	public PlayerBountyWaitingSpawnRegion()
	{
	}

	[Token(Token = "0x60050A0")]
	[Address(RVA = "0x1E1DE60", Offset = "0x1E1DE60", VA = "0x1E1DE60")]
	private void Start()
	{
	}
}
