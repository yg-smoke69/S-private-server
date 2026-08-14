using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B62")]
public class DigitaluniverseBStoryBranchDesc
{
	[Token(Token = "0x400AC51")]
	[FieldOffset(Offset = "0x8")]
	public string branch_key;

	[Token(Token = "0x400AC52")]
	[FieldOffset(Offset = "0xC")]
	public uint branch_story_id;

	[Token(Token = "0x60081BD")]
	[Address(RVA = "0x309EE68", Offset = "0x309EE68", VA = "0x309EE68")]
	public DigitaluniverseBStoryBranchDesc()
	{
	}
}
