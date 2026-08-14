using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019B2")]
public class SkinTimelineDesc
{
	[Token(Token = "0x400A108")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A109")]
	[FieldOffset(Offset = "0xC")]
	public uint type;

	[Token(Token = "0x400A10A")]
	[FieldOffset(Offset = "0x10")]
	public string res_conf1;

	[Token(Token = "0x400A10B")]
	[FieldOffset(Offset = "0x14")]
	public string res_conf2;

	[Token(Token = "0x400A10C")]
	[FieldOffset(Offset = "0x18")]
	public string res_conf3;

	[Token(Token = "0x400A10D")]
	[FieldOffset(Offset = "0x20")]
	public long start_time;

	[Token(Token = "0x400A10E")]
	[FieldOffset(Offset = "0x28")]
	public long end_time;

	[Token(Token = "0x6008009")]
	[Address(RVA = "0x33E23AC", Offset = "0x33E23AC", VA = "0x33E23AC")]
	public SkinTimelineDesc()
	{
	}
}
