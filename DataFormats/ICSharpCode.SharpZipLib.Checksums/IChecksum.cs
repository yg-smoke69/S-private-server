using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Checksums;

[Token(Token = "0x2003BE0")]
public interface IChecksum
{
	[Token(Token = "0x170018FE")]
	long Value
	{
		[Token(Token = "0x6017E20")]
		get;
	}

	[Token(Token = "0x6017E21")]
	void Reset();

	[Token(Token = "0x6017E22")]
	void Update(int value);

	[Token(Token = "0x6017E23")]
	void Update(byte[] buffer);

	[Token(Token = "0x6017E24")]
	void Update(byte[] buffer, int offset, int count);
}
