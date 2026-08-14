using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A18")]
public class LevelExpDesc
{
	[Token(Token = "0x400A39D")]
	[FieldOffset(Offset = "0x8")]
	public uint level;

	[Token(Token = "0x400A39E")]
	[FieldOffset(Offset = "0xC")]
	public uint exp;

	[Token(Token = "0x6008070")]
	[Address(RVA = "0x30A446C", Offset = "0x30A446C", VA = "0x30A446C")]
	public LevelExpDesc()
	{
	}
}
