using Il2CppDummyDll;

namespace WwiseGameSyncs.State;

[Token(Token = "0x20002C2")]
internal class Vehicle_State : StateBase
{
	[Token(Token = "0x40032EB")]
	[FieldOffset(Offset = "0x0")]
	public static Vehicle_State Default_Volume;

	[Token(Token = "0x40032EC")]
	[FieldOffset(Offset = "0x4")]
	public static Vehicle_State None;

	[Token(Token = "0x40032ED")]
	[FieldOffset(Offset = "0x8")]
	public static Vehicle_State Silence;

	[Token(Token = "0x6000D59")]
	[Address(RVA = "0x336DF48", Offset = "0x336DF48", VA = "0x336DF48")]
	private Vehicle_State(uint _value)
	{
	}
}
