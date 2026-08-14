using System.IO;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004053")]
public sealed class FastBinaryWriter
{
	[Token(Token = "0x401B12E")]
	[FieldOffset(Offset = "0x0")]
	private static ulong Normal_Byte_Count;

	[Token(Token = "0x401B12F")]
	[FieldOffset(Offset = "0x8")]
	private static ulong Fast_Byte_Count;

	[Token(Token = "0x401B130")]
	[FieldOffset(Offset = "0x8")]
	private Stream _stream;

	[Token(Token = "0x401B131")]
	[FieldOffset(Offset = "0xC")]
	private byte[] _ioBuffer;

	[Token(Token = "0x401B132")]
	[FieldOffset(Offset = "0x10")]
	private int _ioIndex;

	[Token(Token = "0x601A2EC")]
	[Address(RVA = "0x32A9708", Offset = "0x32A9708", VA = "0x32A9708")]
	public FastBinaryWriter(Stream s)
	{
	}

	[Token(Token = "0x601A2ED")]
	[Address(RVA = "0x32A978C", Offset = "0x32A978C", VA = "0x32A978C")]
	public static void LogProtoWriteByteCount()
	{
	}

	[Token(Token = "0x601A2EE")]
	[Address(RVA = "0x32A99D4", Offset = "0x32A99D4", VA = "0x32A99D4")]
	private void DemandSpace(int required)
	{
	}

	[Token(Token = "0x601A2EF")]
	[Address(RVA = "0x32A9A30", Offset = "0x32A9A30", VA = "0x32A9A30")]
	public void Flush()
	{
	}

	[Token(Token = "0x601A2F0")]
	[Address(RVA = "0x32A9A98", Offset = "0x32A9A98", VA = "0x32A9A98")]
	internal ulong Zig(long value)
	{
		return default(ulong);
	}

	[Token(Token = "0x601A2F1")]
	[Address(RVA = "0x32A9AB0", Offset = "0x32A9AB0", VA = "0x32A9AB0")]
	public void Write(int value)
	{
	}

	[Token(Token = "0x601A2F2")]
	[Address(RVA = "0x32AAB8C", Offset = "0x32AAB8C", VA = "0x32AAB8C")]
	public void Write(uint value)
	{
	}

	[Token(Token = "0x601A2F3")]
	[Address(RVA = "0x32AACA8", Offset = "0x32AACA8", VA = "0x32AACA8")]
	public void Write(long value)
	{
	}

	[Token(Token = "0x601A2F4")]
	[Address(RVA = "0x32AADEC", Offset = "0x32AADEC", VA = "0x32AADEC")]
	public void Write(ulong value)
	{
	}

	[Token(Token = "0x601A2F5")]
	[Address(RVA = "0x32AAF24", Offset = "0x32AAF24", VA = "0x32AAF24")]
	public void Write(byte[] data)
	{
	}

	[Token(Token = "0x601A2F6")]
	[Address(RVA = "0x32AB068", Offset = "0x32AB068", VA = "0x32AB068")]
	public void Write(float value)
	{
	}

	[Token(Token = "0x601A2F7")]
	[Address(RVA = "0x32AB108", Offset = "0x32AB108", VA = "0x32AB108")]
	public void Write(short value)
	{
	}

	[Token(Token = "0x601A2F8")]
	[Address(RVA = "0x32AB238", Offset = "0x32AB238", VA = "0x32AB238")]
	public void Write(ushort value)
	{
	}

	[Token(Token = "0x601A2F9")]
	[Address(RVA = "0x32AB354", Offset = "0x32AB354", VA = "0x32AB354")]
	public void Write(bool value)
	{
	}

	[Token(Token = "0x601A2FA")]
	[Address(RVA = "0x32AB454", Offset = "0x32AB454", VA = "0x32AB454")]
	public void Write(byte value)
	{
	}

	[Token(Token = "0x601A2FB")]
	[Address(RVA = "0x32AB528", Offset = "0x32AB528", VA = "0x32AB528")]
	public void Write(sbyte value)
	{
	}

	[Token(Token = "0x601A2FC")]
	[Address(RVA = "0x32A9BDC", Offset = "0x32A9BDC", VA = "0x32A9BDC")]
	private void AppendVarint(ulong v)
	{
	}

	[Token(Token = "0x601A2FD")]
	[Address(RVA = "0x32A9BD8", Offset = "0x32A9BD8", VA = "0x32A9BD8")]
	public void WriteFix(int value)
	{
	}

	[Token(Token = "0x601A2FE")]
	[Address(RVA = "0x32AACA4", Offset = "0x32AACA4", VA = "0x32AACA4")]
	public void WriteFix(uint value)
	{
	}

	[Token(Token = "0x601A2FF")]
	[Address(RVA = "0x32AADD4", Offset = "0x32AADD4", VA = "0x32AADD4")]
	public void WriteFix(long value)
	{
	}

	[Token(Token = "0x601A300")]
	[Address(RVA = "0x32AAF0C", Offset = "0x32AAF0C", VA = "0x32AAF0C")]
	public void WriteFix(ulong value)
	{
	}

	[Token(Token = "0x601A301")]
	[Address(RVA = "0x32AB424", Offset = "0x32AB424", VA = "0x32AB424")]
	public void WriteFix(bool value)
	{
	}

	[Token(Token = "0x601A302")]
	[Address(RVA = "0x32AB004", Offset = "0x32AB004", VA = "0x32AB004")]
	public void WriteFix(byte[] data)
	{
	}

	[Token(Token = "0x601A303")]
	[Address(RVA = "0x32AB9FC", Offset = "0x32AB9FC", VA = "0x32AB9FC")]
	public void WriteFix(float value)
	{
	}

	[Token(Token = "0x601A304")]
	[Address(RVA = "0x32AB230", Offset = "0x32AB230", VA = "0x32AB230")]
	public void WriteFix(short value)
	{
	}

	[Token(Token = "0x601A305")]
	[Address(RVA = "0x32AB350", Offset = "0x32AB350", VA = "0x32AB350")]
	public void WriteFix(ushort value)
	{
	}

	[Token(Token = "0x601A306")]
	[Address(RVA = "0x32AB524", Offset = "0x32AB524", VA = "0x32AB524")]
	public void WriteFix(byte value)
	{
	}

	[Token(Token = "0x601A307")]
	[Address(RVA = "0x32AB5F8", Offset = "0x32AB5F8", VA = "0x32AB5F8")]
	public void WriteFix(sbyte value)
	{
	}

	[Token(Token = "0x601A308")]
	[Address(RVA = "0x32AB738", Offset = "0x32AB738", VA = "0x32AB738")]
	private void WriteFixU64(ulong value)
	{
	}

	[Token(Token = "0x601A309")]
	[Address(RVA = "0x32AB600", Offset = "0x32AB600", VA = "0x32AB600")]
	private void WriteFixU32(uint value)
	{
	}

	[Token(Token = "0x601A30A")]
	[Address(RVA = "0x32ABA9C", Offset = "0x32ABA9C", VA = "0x32ABA9C")]
	private void WriteFixU16(ushort value)
	{
	}

	[Token(Token = "0x601A30B")]
	[Address(RVA = "0x32AB99C", Offset = "0x32AB99C", VA = "0x32AB99C")]
	private void WriteFixU8(byte value)
	{
	}
}
