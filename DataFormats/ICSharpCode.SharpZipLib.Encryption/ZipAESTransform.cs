using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Encryption;

[Token(Token = "0x2003BE9")]
internal class ZipAESTransform : _Attribute, IConvertible
{
	[Token(Token = "0x401987C")]
	private const int PWD_VER_LENGTH = 2;

	[Token(Token = "0x401987D")]
	private const int KEY_ROUNDS = 1000;

	[Token(Token = "0x401987E")]
	private const int ENCRYPT_BLOCK = 16;

	[Token(Token = "0x401987F")]
	[FieldOffset(Offset = "0x8")]
	private int _blockSize;

	[Token(Token = "0x4019880")]
	[FieldOffset(Offset = "0xC")]
	private ICryptoTransform _encryptor;

	[Token(Token = "0x4019881")]
	[FieldOffset(Offset = "0x10")]
	private readonly byte[] _counterNonce;

	[Token(Token = "0x4019882")]
	[FieldOffset(Offset = "0x14")]
	private byte[] _encryptBuffer;

	[Token(Token = "0x4019883")]
	[FieldOffset(Offset = "0x18")]
	private int _encrPos;

	[Token(Token = "0x4019884")]
	[FieldOffset(Offset = "0x1C")]
	private byte[] _pwdVerifier;

	[Token(Token = "0x4019885")]
	[FieldOffset(Offset = "0x20")]
	private HMACSHA1 _hmacsha1;

	[Token(Token = "0x4019886")]
	[FieldOffset(Offset = "0x24")]
	private bool _finalised;

	[Token(Token = "0x4019887")]
	[FieldOffset(Offset = "0x25")]
	private bool _writeMode;

	[Token(Token = "0x1700190B")]
	public byte[] PwdVerifier
	{
		[Token(Token = "0x6017E53")]
		[Address(RVA = "0x351C034", Offset = "0x351C034", VA = "0x351C034")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700190C")]
	public int InputBlockSize
	{
		[Token(Token = "0x6017E56")]
		[Address(RVA = "0x351C0D8", Offset = "0x351C0D8", VA = "0x351C0D8", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700190D")]
	public int OutputBlockSize
	{
		[Token(Token = "0x6017E57")]
		[Address(RVA = "0x351C0E0", Offset = "0x351C0E0", VA = "0x351C0E0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700190E")]
	public bool CanTransformMultipleBlocks
	{
		[Token(Token = "0x6017E58")]
		[Address(RVA = "0x351C0E8", Offset = "0x351C0E8", VA = "0x351C0E8", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700190F")]
	public bool CanReuseTransform
	{
		[Token(Token = "0x6017E59")]
		[Address(RVA = "0x351C0F0", Offset = "0x351C0F0", VA = "0x351C0F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6017E51")]
	[Address(RVA = "0x351BAE8", Offset = "0x351BAE8", VA = "0x351BAE8")]
	public ZipAESTransform(string key, byte[] saltBytes, int blockSize, bool writeMode)
	{
	}

	[Token(Token = "0x6017E52")]
	[Address(RVA = "0x351B678", Offset = "0x351B678", VA = "0x351B678", Slot = "8")]
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		return default(int);
	}

	[Token(Token = "0x6017E54")]
	[Address(RVA = "0x351B978", Offset = "0x351B978", VA = "0x351B978")]
	public byte[] GetAuthCode()
	{
		return null;
	}

	[Token(Token = "0x6017E55")]
	[Address(RVA = "0x351C03C", Offset = "0x351C03C", VA = "0x351C03C", Slot = "9")]
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		return null;
	}

	[Token(Token = "0x6017E5A")]
	[Address(RVA = "0x351C0F8", Offset = "0x351C0F8", VA = "0x351C0F8", Slot = "10")]
	public void Dispose()
	{
	}
}
