using Il2CppDummyDll;

namespace WwiseGameSyncs.Switch;

[Token(Token = "0x20002B3")]
internal class Vehicle_Direction : SwitchBase
{
	[Token(Token = "0x40032BF")]
	[FieldOffset(Offset = "0x0")]
	public static Vehicle_Direction Negative;

	[Token(Token = "0x40032C0")]
	[FieldOffset(Offset = "0x4")]
	public static Vehicle_Direction Positive;

	[Token(Token = "0x6000D3B")]
	[Address(RVA = "0x336EA1C", Offset = "0x336EA1C", VA = "0x336EA1C")]
	private Vehicle_Direction(uint _value)
	{
	}
}
