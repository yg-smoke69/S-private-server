using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200152A")]
public class highKillInfo
{
	[Token(Token = "0x40091EC")]
	[FieldOffset(Offset = "0x8")]
	public uint kill;

	[Token(Token = "0x40091ED")]
	[FieldOffset(Offset = "0xC")]
	public uint damage;

	[Token(Token = "0x6007B73")]
	[Address(RVA = "0x33E6CC8", Offset = "0x33E6CC8", VA = "0x33E6CC8")]
	public highKillInfo()
	{
	}
}
