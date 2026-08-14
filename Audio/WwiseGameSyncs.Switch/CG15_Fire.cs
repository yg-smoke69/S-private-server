using Il2CppDummyDll;

namespace WwiseGameSyncs.Switch;

[Token(Token = "0x20002AE")]
internal class CG15_Fire : SwitchBase
{
	[Token(Token = "0x40032A9")]
	[FieldOffset(Offset = "0x0")]
	public static CG15_Fire Aiming;

	[Token(Token = "0x40032AA")]
	[FieldOffset(Offset = "0x4")]
	public static CG15_Fire Normal;

	[Token(Token = "0x6000D31")]
	[Address(RVA = "0x336E2AC", Offset = "0x336E2AC", VA = "0x336E2AC")]
	private CG15_Fire(uint _value)
	{
	}
}
