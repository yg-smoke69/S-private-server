using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200130A")]
public class EPresence
{
	[Token(Token = "0x200130B")]
	public enum AccountPresence
	{
		[Token(Token = "0x40086DF")]
		AccountPresence_NONE,
		[Token(Token = "0x40086E0")]
		AccountPresence_ONLINE,
		[Token(Token = "0x40086E1")]
		AccountPresence_INGROUP,
		[Token(Token = "0x40086E2")]
		AccountPresence_INGAME,
		[Token(Token = "0x40086E3")]
		AccountPresence_INROOM,
		[Token(Token = "0x40086E4")]
		AccountPresence_INTRAINING
	}

	[Token(Token = "0x6007A49")]
	[Address(RVA = "0x309F8AC", Offset = "0x309F8AC", VA = "0x309F8AC")]
	public EPresence()
	{
	}
}
