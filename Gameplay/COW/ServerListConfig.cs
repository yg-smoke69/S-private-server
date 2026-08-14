using System;
using Il2CppDummyDll;

namespace COW;

[Serializable]
[Token(Token = "0x2002E05")]
internal class ServerListConfig
{
	[Token(Token = "0x4011A13")]
	[FieldOffset(Offset = "0x8")]
	public ServerConfig[] serverList;

	[Token(Token = "0x601347D")]
	[Address(RVA = "0x20DEA9C", Offset = "0x20DEA9C", VA = "0x20DEA9C")]
	public ServerListConfig()
	{
	}

	[Token(Token = "0x601347E")]
	[Address(RVA = "0x20DEAA4", Offset = "0x20DEAA4", VA = "0x20DEAA4")]
	public ServerConfig GetServerConfigByURL(string url)
	{
		return null;
	}
}
