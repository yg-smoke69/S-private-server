using System;
using Il2CppDummyDll;

namespace COW;

[Serializable]
[Token(Token = "0x2002E06")]
internal class ServerConfig
{
	[Token(Token = "0x4011A14")]
	[FieldOffset(Offset = "0x8")]
	public string serverName;

	[Token(Token = "0x4011A15")]
	[FieldOffset(Offset = "0xC")]
	public string serverUrl;

	[Token(Token = "0x4011A16")]
	[FieldOffset(Offset = "0x10")]
	public bool garenaOverride;

	[Token(Token = "0x4011A17")]
	[FieldOffset(Offset = "0x11")]
	public bool garenaSandbox;

	[Token(Token = "0x4011A18")]
	[FieldOffset(Offset = "0x12")]
	public bool skipVersionCheck;

	[Token(Token = "0x601347F")]
	[Address(RVA = "0x20DEA94", Offset = "0x20DEA94", VA = "0x20DEA94")]
	public ServerConfig()
	{
	}
}
