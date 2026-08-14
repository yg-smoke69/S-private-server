using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001709")]
public class WeeklyCompleteNum
{
	[Token(Token = "0x4009842")]
	[FieldOffset(Offset = "0x8")]
	public uint week_id;

	[Token(Token = "0x4009843")]
	[FieldOffset(Offset = "0xC")]
	public uint completed_num;

	[Token(Token = "0x6007D63")]
	[Address(RVA = "0x33E5568", Offset = "0x33E5568", VA = "0x33E5568")]
	public WeeklyCompleteNum()
	{
	}
}
