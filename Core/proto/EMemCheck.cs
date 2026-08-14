using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200149E")]
public class EMemCheck
{
	[Token(Token = "0x200149F")]
	public enum MemCheckType
	{
		[Token(Token = "0x4008F11")]
		MemCheckType_NONE,
		[Token(Token = "0x4008F12")]
		MemCheckType_GROUP,
		[Token(Token = "0x4008F13")]
		MemCheckType_MATCHMAKING
	}

	[Token(Token = "0x6007B0F")]
	[Address(RVA = "0x309F348", Offset = "0x309F348", VA = "0x309F348")]
	public EMemCheck()
	{
	}
}
