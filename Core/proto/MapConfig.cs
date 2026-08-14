using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001318")]
public class MapConfig
{
	[Token(Token = "0x4008724")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4008725")]
	[FieldOffset(Offset = "0xC")]
	public uint weight;

	[Token(Token = "0x4008726")]
	[FieldOffset(Offset = "0x10")]
	public uint priority;

	[Token(Token = "0x6007A4E")]
	[Address(RVA = "0x30A7980", Offset = "0x30A7980", VA = "0x30A7980")]
	public MapConfig()
	{
	}
}
