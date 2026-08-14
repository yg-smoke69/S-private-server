using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A6A")]
public class GameDropRate
{
	[Token(Token = "0x400A55E")]
	[FieldOffset(Offset = "0x8")]
	public uint drop_id;

	[Token(Token = "0x400A55F")]
	[FieldOffset(Offset = "0xC")]
	public uint drop_count;

	[Token(Token = "0x400A560")]
	[FieldOffset(Offset = "0x10")]
	public uint weight;

	[Token(Token = "0x60080C7")]
	[Address(RVA = "0x30A197C", Offset = "0x30A197C", VA = "0x30A197C")]
	public GameDropRate()
	{
	}
}
