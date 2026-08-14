using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001998")]
public enum SettingsTransferStatus
{
	[Token(Token = "0x400A02E")]
	NONE,
	[Token(Token = "0x400A02F")]
	NOTFOUNDBYACCOUNT,
	[Token(Token = "0x400A030")]
	NOTEXISTSAMEVERSION,
	[Token(Token = "0x400A031")]
	FOUNDSAMEVERSION
}
