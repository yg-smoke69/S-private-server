using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B97")]
public class FFWSTrainDesc
{
	[Token(Token = "0x400AD8C")]
	[FieldOffset(Offset = "0x8")]
	public uint token_id;

	[Token(Token = "0x400AD8D")]
	[FieldOffset(Offset = "0xC")]
	public uint token_num;

	[Token(Token = "0x400AD8E")]
	[FieldOffset(Offset = "0x10")]
	public uint experience;

	[Token(Token = "0x400AD8F")]
	[FieldOffset(Offset = "0x14")]
	public uint[] token_required;

	[Token(Token = "0x400AD90")]
	[FieldOffset(Offset = "0x18")]
	public uint train_limit;

	[Token(Token = "0x400AD91")]
	[FieldOffset(Offset = "0x1C")]
	public uint match_limit;

	[Token(Token = "0x400AD92")]
	[FieldOffset(Offset = "0x20")]
	public uint policy_parameter;

	[Token(Token = "0x400AD93")]
	[FieldOffset(Offset = "0x24")]
	public uint sword_parameter;

	[Token(Token = "0x60081F2")]
	[Address(RVA = "0x30A0964", Offset = "0x30A0964", VA = "0x30A0964")]
	public FFWSTrainDesc()
	{
	}
}
