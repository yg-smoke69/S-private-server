using Il2CppDummyDll;

namespace WwiseGameSyncs.Switch;

[Token(Token = "0x20002B2")]
internal class PlayerType : SwitchBase
{
	[Token(Token = "0x40032BC")]
	[FieldOffset(Offset = "0x0")]
	public static PlayerType First_Person;

	[Token(Token = "0x40032BD")]
	[FieldOffset(Offset = "0x4")]
	public static PlayerType Third_Person;

	[Token(Token = "0x40032BE")]
	[FieldOffset(Offset = "0x8")]
	public static PlayerType Third_Person_Far;

	[Token(Token = "0x6000D39")]
	[Address(RVA = "0x336E8CC", Offset = "0x336E8CC", VA = "0x336E8CC")]
	private PlayerType(uint _value)
	{
	}
}
