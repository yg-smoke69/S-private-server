using Il2CppDummyDll;

namespace WwiseGameSyncs.State;

[Token(Token = "0x20002C0")]
internal class State_Character_Location : StateBase
{
	[Token(Token = "0x40032E5")]
	[FieldOffset(Offset = "0x0")]
	public static State_Character_Location Indoor;

	[Token(Token = "0x40032E6")]
	[FieldOffset(Offset = "0x4")]
	public static State_Character_Location None;

	[Token(Token = "0x6000D55")]
	[Address(RVA = "0x336DE18", Offset = "0x336DE18", VA = "0x336DE18")]
	private State_Character_Location(uint _value)
	{
	}
}
