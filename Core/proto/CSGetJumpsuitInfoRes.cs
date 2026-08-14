using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001920")]
public class CSGetJumpsuitInfoRes
{
	[Token(Token = "0x4009ED3")]
	[FieldOffset(Offset = "0x8")]
	public float curr_amount;

	[Token(Token = "0x4009ED4")]
	[FieldOffset(Offset = "0xC")]
	public float curr_storage;

	[Token(Token = "0x4009ED5")]
	[FieldOffset(Offset = "0x10")]
	public long update_time;

	[Token(Token = "0x4009ED6")]
	[FieldOffset(Offset = "0x18")]
	public uint next_reset_time;

	[Token(Token = "0x4009ED7")]
	[FieldOffset(Offset = "0x1C")]
	public uint[] rewarded_stages;

	[Token(Token = "0x4009ED8")]
	[FieldOffset(Offset = "0x20")]
	public uint rewarded_box_num;

	[Token(Token = "0x4009ED9")]
	[FieldOffset(Offset = "0x24")]
	public List<JumpsuitHelpInfo> helper_list;

	[Token(Token = "0x4009EDA")]
	[FieldOffset(Offset = "0x28")]
	public ulong[] helped_list;

	[Token(Token = "0x6007F79")]
	[Address(RVA = "0x318654C", Offset = "0x318654C", VA = "0x318654C")]
	public CSGetJumpsuitInfoRes()
	{
	}
}
