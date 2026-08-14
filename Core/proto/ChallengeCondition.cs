using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A8B")]
public class ChallengeCondition
{
	[Token(Token = "0x400A627")]
	[FieldOffset(Offset = "0x8")]
	public uint condition;

	[Token(Token = "0x400A628")]
	[FieldOffset(Offset = "0xC")]
	public uint target_value;

	[Token(Token = "0x400A629")]
	[FieldOffset(Offset = "0x10")]
	public uint[] sub_condition;

	[Token(Token = "0x60080E8")]
	[Address(RVA = "0x309AC68", Offset = "0x309AC68", VA = "0x309AC68")]
	public ChallengeCondition()
	{
	}
}
