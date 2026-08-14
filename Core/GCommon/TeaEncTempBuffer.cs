using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004062")]
public class TeaEncTempBuffer
{
	[Token(Token = "0x401B17B")]
	[FieldOffset(Offset = "0x8")]
	public byte[] enc_src_buf;

	[Token(Token = "0x401B17C")]
	[FieldOffset(Offset = "0xC")]
	public byte[] enc_iv_plain;

	[Token(Token = "0x401B17D")]
	[FieldOffset(Offset = "0x10")]
	public byte[] enc_iv_crypt;

	[Token(Token = "0x401B17E")]
	[FieldOffset(Offset = "0x14")]
	public uint[] enc_k;

	[Token(Token = "0x601A357")]
	[Address(RVA = "0x323D5C0", Offset = "0x323D5C0", VA = "0x323D5C0")]
	public TeaEncTempBuffer()
	{
	}
}
