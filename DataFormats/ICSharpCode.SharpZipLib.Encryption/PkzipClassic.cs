using System.Security.Cryptography;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Encryption;

[Token(Token = "0x2003BE3")]
public abstract class PkzipClassic : SymmetricAlgorithm
{
	[Token(Token = "0x6017E2C")]
	[Address(RVA = "0x3519834", Offset = "0x3519834", VA = "0x3519834")]
	protected PkzipClassic()
	{
	}

	[Token(Token = "0x6017E2D")]
	[Address(RVA = "0x351983C", Offset = "0x351983C", VA = "0x351983C")]
	public static byte[] GenerateKeys(byte[] seed)
	{
		return null;
	}
}
