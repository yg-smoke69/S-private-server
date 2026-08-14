using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Encryption;

[Token(Token = "0x2003BE6")]
internal class PkzipClassicDecryptCryptoTransform : PkzipClassicCryptoBase, _Attribute, IConvertible
{
	[Token(Token = "0x17001903")]
	public bool CanReuseTransform
	{
		[Token(Token = "0x6017E3E")]
		[Address(RVA = "0x351A818", Offset = "0x351A818", VA = "0x351A818", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001904")]
	public int InputBlockSize
	{
		[Token(Token = "0x6017E3F")]
		[Address(RVA = "0x351A820", Offset = "0x351A820", VA = "0x351A820", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001905")]
	public int OutputBlockSize
	{
		[Token(Token = "0x6017E40")]
		[Address(RVA = "0x351A828", Offset = "0x351A828", VA = "0x351A828", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001906")]
	public bool CanTransformMultipleBlocks
	{
		[Token(Token = "0x6017E41")]
		[Address(RVA = "0x351A830", Offset = "0x351A830", VA = "0x351A830", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6017E3B")]
	[Address(RVA = "0x351A668", Offset = "0x351A668", VA = "0x351A668")]
	internal PkzipClassicDecryptCryptoTransform(byte[] keyBlock)
	{
	}

	[Token(Token = "0x6017E3C")]
	[Address(RVA = "0x351A690", Offset = "0x351A690", VA = "0x351A690", Slot = "9")]
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		return null;
	}

	[Token(Token = "0x6017E3D")]
	[Address(RVA = "0x351A730", Offset = "0x351A730", VA = "0x351A730", Slot = "8")]
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		return default(int);
	}

	[Token(Token = "0x6017E42")]
	[Address(RVA = "0x351A838", Offset = "0x351A838", VA = "0x351A838", Slot = "10")]
	public void Dispose()
	{
	}
}
