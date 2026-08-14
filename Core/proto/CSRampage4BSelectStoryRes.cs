using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200197F")]
public class CSRampage4BSelectStoryRes
{
	[Token(Token = "0x4009FF8")]
	[FieldOffset(Offset = "0x8")]
	public uint story_result;

	[Token(Token = "0x4009FF9")]
	[FieldOffset(Offset = "0xC")]
	public uint buff;

	[Token(Token = "0x4009FFA")]
	[FieldOffset(Offset = "0x10")]
	public AwardDesc book_token;

	[Token(Token = "0x4009FFB")]
	[FieldOffset(Offset = "0x14")]
	public AwardDesc award;

	[Token(Token = "0x6007FD8")]
	[Address(RVA = "0x3098A94", Offset = "0x3098A94", VA = "0x3098A94")]
	public CSRampage4BSelectStoryRes()
	{
	}
}
