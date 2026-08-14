using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BD4")]
public class WorkshopExpSourceDesc
{
	[Token(Token = "0x400AF13")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AF14")]
	[FieldOffset(Offset = "0xC")]
	public uint score;

	[Token(Token = "0x400AF15")]
	[FieldOffset(Offset = "0x10")]
	public uint daily_limit;

	[Token(Token = "0x600822F")]
	[Address(RVA = "0x33E63CC", Offset = "0x33E63CC", VA = "0x33E63CC")]
	public WorkshopExpSourceDesc()
	{
	}
}
