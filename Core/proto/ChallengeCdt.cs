using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200170C")]
public class ChallengeCdt
{
	[Token(Token = "0x4009857")]
	[FieldOffset(Offset = "0x8")]
	public EPChallenge_Condition_Type condition_type;

	[Token(Token = "0x4009858")]
	[FieldOffset(Offset = "0xC")]
	public uint current_value;

	[Token(Token = "0x4009859")]
	[FieldOffset(Offset = "0x10")]
	public uint target_value;

	[Token(Token = "0x400985A")]
	[FieldOffset(Offset = "0x14")]
	public uint[] sub_condition;

	[Token(Token = "0x6007D66")]
	[Address(RVA = "0x309AC60", Offset = "0x309AC60", VA = "0x309AC60")]
	public ChallengeCdt()
	{
	}
}
