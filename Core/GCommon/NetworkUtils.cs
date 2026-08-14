using System.Net;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200407D")]
public static class NetworkUtils
{
	[Token(Token = "0x601A3B0")]
	[Address(RVA = "0x2979F1C", Offset = "0x2979F1C", VA = "0x2979F1C")]
	public static bool ParseUrlAddrAndPort(string url, out string outAddr, out int outPort)
	{
		return default(bool);
	}

	[Token(Token = "0x601A3B1")]
	[Address(RVA = "0x297A08C", Offset = "0x297A08C", VA = "0x297A08C")]
	public static byte[] HexStringToByte(string hexString)
	{
		return null;
	}

	[Token(Token = "0x601A3B2")]
	[Address(RVA = "0x297A320", Offset = "0x297A320", VA = "0x297A320")]
	public static IPAddress GetAddrByHostName(string serverAddr)
	{
		return null;
	}

	[Token(Token = "0x601A3B3")]
	[Address(RVA = "0x297AA58", Offset = "0x297AA58", VA = "0x297AA58")]
	public static bool IsValidUrl(string url)
	{
		return default(bool);
	}
}
