using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Encryption;

[Token(Token = "0x2003BE5")]
internal class PkzipClassicEncryptCryptoTransform : PkzipClassicCryptoBase, _Attribute, IConvertible
{
	[Token(Token = "0x170018FF")]
	public bool CanReuseTransform
	{
		[Token(Token = "0x6017E36")]
		[Address(RVA = "0x351AA08", Offset = "0x351AA08", VA = "0x351AA08", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001900")]
	public int InputBlockSize
	{
		[Token(Token = "0x6017E37")]
		[Address(RVA = "0x351AA10", Offset = "0x351AA10", VA = "0x351AA10", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001901")]
	public int OutputBlockSize
	{
		[Token(Token = "0x6017E38")]
		[Address(RVA = "0x351AA18", Offset = "0x351AA18", VA = "0x351AA18", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001902")]
	public bool CanTransformMultipleBlocks
	{
		[Token(Token = "0x6017E39")]
		[Address(RVA = "0x351AA20", Offset = "0x351AA20", VA = "0x351AA20", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6017E33")]
	[Address(RVA = "0x351A83C", Offset = "0x351A83C", VA = "0x351A83C")]
	internal PkzipClassicEncryptCryptoTransform(byte[] keyBlock)
	{
	}

	[Token(Token = "0x6017E34")]
	[Address(RVA = "0x351A864", Offset = "0x351A864", VA = "0x351A864", Slot = "9")]
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		return null;
	}

	[Token(Token = "0x6017E35")]
	[Address(RVA = "0x351A904", Offset = "0x351A904", VA = "0x351A904", Slot = "8")]
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		return default(int);
	}

	[Token(Token = "0x6017E3A")]
	[Address(RVA = "0x351AA28", Offset = "0x351AA28", VA = "0x351AA28", Slot = "10")]
	public void Dispose()
	{
	}
}
