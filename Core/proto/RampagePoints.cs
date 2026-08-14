using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017EE")]
public class RampagePoints
{
	[Token(Token = "0x4009BB5")]
	[FieldOffset(Offset = "0x8")]
	public ELimitedEvent.RampageFaction faction;

	[Token(Token = "0x4009BB6")]
	[FieldOffset(Offset = "0x10")]
	public ulong points;

	[Token(Token = "0x6007E48")]
	[Address(RVA = "0x33E0558", Offset = "0x33E0558", VA = "0x33E0558")]
	public RampagePoints()
	{
	}
}
