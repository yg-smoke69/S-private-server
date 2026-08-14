using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Encryption;

[Token(Token = "0x2003BE4")]
internal class PkzipClassicCryptoBase
{
	[Token(Token = "0x4019872")]
	[FieldOffset(Offset = "0x8")]
	private uint[] keys;

	[Token(Token = "0x6017E2E")]
	[Address(RVA = "0x3519F18", Offset = "0x3519F18", VA = "0x3519F18")]
	public PkzipClassicCryptoBase()
	{
	}

	[Token(Token = "0x6017E2F")]
	[Address(RVA = "0x3519F20", Offset = "0x3519F20", VA = "0x3519F20")]
	protected byte TransformByte()
	{
		return default(byte);
	}

	[Token(Token = "0x6017E30")]
	[Address(RVA = "0x3519F78", Offset = "0x3519F78", VA = "0x3519F78")]
	protected void SetKeys(byte[] keyData)
	{
	}

	[Token(Token = "0x6017E31")]
	[Address(RVA = "0x351A33C", Offset = "0x351A33C", VA = "0x351A33C")]
	protected void UpdateKeys(byte ch)
	{
	}

	[Token(Token = "0x6017E32")]
	[Address(RVA = "0x351A5B0", Offset = "0x351A5B0", VA = "0x351A5B0")]
	protected void Reset()
	{
	}
}
