using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001528")]
public class wpSecondsAndDamage
{
	[Token(Token = "0x40091E8")]
	[FieldOffset(Offset = "0x8")]
	public uint seconds;

	[Token(Token = "0x40091E9")]
	[FieldOffset(Offset = "0xC")]
	public uint damage;

	[Token(Token = "0x6007B71")]
	[Address(RVA = "0x33E6D8C", Offset = "0x33E6D8C", VA = "0x33E6D8C")]
	public wpSecondsAndDamage()
	{
	}
}
