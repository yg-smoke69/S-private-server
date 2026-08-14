using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004061")]
public class TeaDecTempBuffer
{
	[Token(Token = "0x401B176")]
	[FieldOffset(Offset = "0x8")]
	public byte[] dec_dest_buff;

	[Token(Token = "0x401B177")]
	[FieldOffset(Offset = "0xC")]
	public byte[] dec_zero_buff;

	[Token(Token = "0x401B178")]
	[FieldOffset(Offset = "0x10")]
	public byte[] dec_iv_pre;

	[Token(Token = "0x401B179")]
	[FieldOffset(Offset = "0x14")]
	public byte[] dec_iv_cur;

	[Token(Token = "0x401B17A")]
	[FieldOffset(Offset = "0x18")]
	public uint[] dec_k;

	[Token(Token = "0x601A356")]
	[Address(RVA = "0x323D500", Offset = "0x323D500", VA = "0x323D500")]
	public TeaDecTempBuffer()
	{
	}
}
