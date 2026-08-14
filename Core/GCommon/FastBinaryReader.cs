using System.IO;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004052")]
public sealed class FastBinaryReader
{
	[Token(Token = "0x401B129")]
	[FieldOffset(Offset = "0x8")]
	private Stream _stream;

	[Token(Token = "0x401B12A")]
	[FieldOffset(Offset = "0xC")]
	private byte[] _ioBuffer;

	[Token(Token = "0x401B12B")]
	[FieldOffset(Offset = "0x10")]
	private int _ioIndex;

	[Token(Token = "0x401B12C")]
	[FieldOffset(Offset = "0x14")]
	private int _available;

	[Token(Token = "0x401B12D")]
	private const long Int64Msb = long.MinValue;

	[Token(Token = "0x17001CB8")]
	public long Position
	{
		[Token(Token = "0x601A2CC")]
		[Address(RVA = "0x32A809C", Offset = "0x32A809C", VA = "0x32A809C")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001CB9")]
	public long Length
	{
		[Token(Token = "0x601A2CD")]
		[Address(RVA = "0x32A80E0", Offset = "0x32A80E0", VA = "0x32A80E0")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x601A2CA")]
	[Address(RVA = "0x32A8004", Offset = "0x32A8004", VA = "0x32A8004")]
	public FastBinaryReader(Stream s)
	{
	}

	[Token(Token = "0x601A2CB")]
	[Address(RVA = "0x32A808C", Offset = "0x32A808C", VA = "0x32A808C")]
	public void Reset()
	{
	}

	[Token(Token = "0x601A2CE")]
	[Address(RVA = "0x32A8114", Offset = "0x32A8114", VA = "0x32A8114")]
	public uint ReadUInt32()
	{
		return default(uint);
	}

	[Token(Token = "0x601A2CF")]
	[Address(RVA = "0x32A8224", Offset = "0x32A8224", VA = "0x32A8224")]
	public int ReadInt32()
	{
		return default(int);
	}

	[Token(Token = "0x601A2D0")]
	[Address(RVA = "0x32A830C", Offset = "0x32A830C", VA = "0x32A830C")]
	public ulong ReadUInt64()
	{
		return default(ulong);
	}

	[Token(Token = "0x601A2D1")]
	[Address(RVA = "0x32A83BC", Offset = "0x32A83BC", VA = "0x32A83BC")]
	public long ReadInt64()
	{
		return default(long);
	}

	[Token(Token = "0x601A2D2")]
	[Address(RVA = "0x32A848C", Offset = "0x32A848C", VA = "0x32A848C")]
	public short ReadInt16()
	{
		return default(short);
	}

	[Token(Token = "0x601A2D3")]
	[Address(RVA = "0x32A8564", Offset = "0x32A8564", VA = "0x32A8564")]
	public ushort ReadUInt16()
	{
		return default(ushort);
	}

	[Token(Token = "0x601A2D4")]
	[Address(RVA = "0x32A8618", Offset = "0x32A8618", VA = "0x32A8618")]
	public float ReadSingle()
	{
		return default(float);
	}

	[Token(Token = "0x601A2D5")]
	[Address(RVA = "0x32A87A8", Offset = "0x32A87A8", VA = "0x32A87A8")]
	public byte[] ReadBytes(int count)
	{
		return null;
	}

	[Token(Token = "0x601A2D6")]
	[Address(RVA = "0x32A8A24", Offset = "0x32A8A24", VA = "0x32A8A24")]
	public bool ReadBoolean()
	{
		return default(bool);
	}

	[Token(Token = "0x601A2D7")]
	[Address(RVA = "0x32A8A60", Offset = "0x32A8A60", VA = "0x32A8A60")]
	public byte ReadByte()
	{
		return default(byte);
	}

	[Token(Token = "0x601A2D8")]
	[Address(RVA = "0x32A8A68", Offset = "0x32A8A68", VA = "0x32A8A68")]
	public sbyte ReadSByte()
	{
		return default(sbyte);
	}

	[Token(Token = "0x601A2D9")]
	[Address(RVA = "0x32A8A90", Offset = "0x32A8A90", VA = "0x32A8A90")]
	public void Seek(int count)
	{
	}

	[Token(Token = "0x601A2DA")]
	[Address(RVA = "0x32A82E8", Offset = "0x32A82E8", VA = "0x32A82E8")]
	private long Zag(ulong ziggedValue)
	{
		return default(long);
	}

	[Token(Token = "0x601A2DB")]
	[Address(RVA = "0x32A81C4", Offset = "0x32A81C4", VA = "0x32A81C4")]
	private ulong ReadVariant()
	{
		return default(ulong);
	}

	[Token(Token = "0x601A2DC")]
	[Address(RVA = "0x32A90D8", Offset = "0x32A90D8", VA = "0x32A90D8")]
	internal void Ensure(int count)
	{
	}

	[Token(Token = "0x601A2DD")]
	[Address(RVA = "0x32A8C80", Offset = "0x32A8C80", VA = "0x32A8C80")]
	private int TryReadUInt64VariantWithoutMoving(out ulong value)
	{
		return default(int);
	}

	[Token(Token = "0x601A2DE")]
	[Address(RVA = "0x32A81C0", Offset = "0x32A81C0", VA = "0x32A81C0")]
	public uint ReadFixUInt32()
	{
		return default(uint);
	}

	[Token(Token = "0x601A2DF")]
	[Address(RVA = "0x32A82E4", Offset = "0x32A82E4", VA = "0x32A82E4")]
	public int ReadFixInt32()
	{
		return default(int);
	}

	[Token(Token = "0x601A2E0")]
	[Address(RVA = "0x32A83B8", Offset = "0x32A83B8", VA = "0x32A83B8")]
	public ulong ReadFixUInt64()
	{
		return default(ulong);
	}

	[Token(Token = "0x601A2E1")]
	[Address(RVA = "0x32A8488", Offset = "0x32A8488", VA = "0x32A8488")]
	public long ReadFixInt64()
	{
		return default(long);
	}

	[Token(Token = "0x601A2E2")]
	[Address(RVA = "0x32A8A3C", Offset = "0x32A8A3C", VA = "0x32A8A3C")]
	public bool ReadFixBoolean()
	{
		return default(bool);
	}

	[Token(Token = "0x601A2E3")]
	[Address(RVA = "0x32A870C", Offset = "0x32A870C", VA = "0x32A870C")]
	public float ReadFixSingle()
	{
		return default(float);
	}

	[Token(Token = "0x601A2E4")]
	[Address(RVA = "0x32A8550", Offset = "0x32A8550", VA = "0x32A8550")]
	public short ReadFixInt16()
	{
		return default(short);
	}

	[Token(Token = "0x601A2E5")]
	[Address(RVA = "0x32A8614", Offset = "0x32A8614", VA = "0x32A8614")]
	public ushort ReadFixUInt16()
	{
		return default(ushort);
	}

	[Token(Token = "0x601A2E6")]
	[Address(RVA = "0x32A8A64", Offset = "0x32A8A64", VA = "0x32A8A64")]
	public byte ReadFixByte()
	{
		return default(byte);
	}

	[Token(Token = "0x601A2E7")]
	[Address(RVA = "0x32A8A7C", Offset = "0x32A8A7C", VA = "0x32A8A7C")]
	public sbyte ReadFixSByte()
	{
		return default(sbyte);
	}

	[Token(Token = "0x601A2E8")]
	[Address(RVA = "0x32A934C", Offset = "0x32A934C", VA = "0x32A934C")]
	private ulong TryReadFixU64()
	{
		return default(ulong);
	}

	[Token(Token = "0x601A2E9")]
	[Address(RVA = "0x32A9204", Offset = "0x32A9204", VA = "0x32A9204")]
	private uint TryReadFixU32()
	{
		return default(uint);
	}

	[Token(Token = "0x601A2EA")]
	[Address(RVA = "0x32A9648", Offset = "0x32A9648", VA = "0x32A9648")]
	private ushort TryReadFixU16()
	{
		return default(ushort);
	}

	[Token(Token = "0x601A2EB")]
	[Address(RVA = "0x32A95CC", Offset = "0x32A95CC", VA = "0x32A95CC")]
	private byte TryReadFixU8()
	{
		return default(byte);
	}
}
