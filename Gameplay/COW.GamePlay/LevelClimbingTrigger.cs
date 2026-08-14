using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x20005F2")]
public class LevelClimbingTrigger : BaseLevelObject
{
	[Token(Token = "0x40044D4")]
	[FieldOffset(Offset = "0x74")]
	public ClimbingTrigger Trigger;

	[Token(Token = "0x600244E")]
	[Address(RVA = "0x23842B0", Offset = "0x23842B0", VA = "0x23842B0")]
	public LevelClimbingTrigger()
	{
	}

	[Token(Token = "0x600244F")]
	[Address(RVA = "0x23842B8", Offset = "0x23842B8", VA = "0x23842B8", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002450")]
	[Address(RVA = "0x238435C", Offset = "0x238435C", VA = "0x238435C", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002451")]
	[Address(RVA = "0x23843CC", Offset = "0x23843CC", VA = "0x23843CC")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
