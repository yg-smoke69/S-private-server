using Il2CppDummyDll;

namespace WwiseGameSyncs.Switch;

[Token(Token = "0x20002AF")]
internal class Damage : SwitchBase
{
	[Token(Token = "0x40032AB")]
	[FieldOffset(Offset = "0x0")]
	public static Damage Above11;

	[Token(Token = "0x40032AC")]
	[FieldOffset(Offset = "0x4")]
	public static Damage Under11;

	[Token(Token = "0x6000D33")]
	[Address(RVA = "0x336E3DC", Offset = "0x336E3DC", VA = "0x336E3DC")]
	private Damage(uint _value)
	{
	}
}
