using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001635")]
public class CSModifyClanNameReq
{
	[Token(Token = "0x400956B")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x400956C")]
	[FieldOffset(Offset = "0x10")]
	public string clan_name;

	[Token(Token = "0x6007C7F")]
	[Address(RVA = "0x3097BF0", Offset = "0x3097BF0", VA = "0x3097BF0")]
	public CSModifyClanNameReq()
	{
	}
}
