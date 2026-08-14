using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B73")]
public class MonopolySettingDesc
{
	[Token(Token = "0x400ACA4")]
	[FieldOffset(Offset = "0x8")]
	public uint max_node;

	[Token(Token = "0x400ACA5")]
	[FieldOffset(Offset = "0xC")]
	public uint ticket_id;

	[Token(Token = "0x400ACA6")]
	[FieldOffset(Offset = "0x10")]
	public uint token_id;

	[Token(Token = "0x400ACA7")]
	[FieldOffset(Offset = "0x14")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400ACA8")]
	[FieldOffset(Offset = "0x18")]
	public uint forward_step;

	[Token(Token = "0x400ACA9")]
	[FieldOffset(Offset = "0x1C")]
	public uint backward_step;

	[Token(Token = "0x400ACAA")]
	[FieldOffset(Offset = "0x20")]
	public uint buff_multiple;

	[Token(Token = "0x400ACAB")]
	[FieldOffset(Offset = "0x24")]
	public uint buff_time;

	[Token(Token = "0x400ACAC")]
	[FieldOffset(Offset = "0x28")]
	public uint token_num;

	[Token(Token = "0x400ACAD")]
	[FieldOffset(Offset = "0x2C")]
	public uint start_token_num;

	[Token(Token = "0x400ACAE")]
	[FieldOffset(Offset = "0x30")]
	public uint phase1_num;

	[Token(Token = "0x400ACAF")]
	[FieldOffset(Offset = "0x34")]
	public uint phase2_num;

	[Token(Token = "0x400ACB0")]
	[FieldOffset(Offset = "0x38")]
	public uint phase3_num;

	[Token(Token = "0x60081CE")]
	[Address(RVA = "0x30A9038", Offset = "0x30A9038", VA = "0x30A9038")]
	public MonopolySettingDesc()
	{
	}
}
