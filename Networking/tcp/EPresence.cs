using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D35")]
public class EPresence
{
	[Token(Token = "0x2001D36")]
	public enum Proto
	{
		[Token(Token = "0x400B85A")]
		Proto_NONE,
		[Token(Token = "0x400B85B")]
		Proto_PRESENCELIST
	}

	[Token(Token = "0x2001D37")]
	public enum ErrCode
	{
		[Token(Token = "0x400B85D")]
		ErrCode_SUSS
	}

	[Token(Token = "0x2001D38")]
	public enum PresenceListType
	{
		[Token(Token = "0x400B85F")]
		PresenceListType_NONE,
		[Token(Token = "0x400B860")]
		PresenceListType_FRIEND,
		[Token(Token = "0x400B861")]
		PresenceListType_CLAN
	}

	[Token(Token = "0x60087F3")]
	[Address(RVA = "0x33E9200", Offset = "0x33E9200", VA = "0x33E9200")]
	public EPresence()
	{
	}
}
