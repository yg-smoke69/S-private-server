using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200139B")]
public class WarmGameInfo
{
	[Token(Token = "0x4008A26")]
	[FieldOffset(Offset = "0x8")]
	public uint type;

	[Token(Token = "0x4008A27")]
	[FieldOffset(Offset = "0xC")]
	public uint level;

	[Token(Token = "0x6007A96")]
	[Address(RVA = "0x33E5118", Offset = "0x33E5118", VA = "0x33E5118")]
	public WarmGameInfo()
	{
	}
}
