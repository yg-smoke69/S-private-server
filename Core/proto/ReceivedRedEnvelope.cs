using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013E7")]
public class ReceivedRedEnvelope
{
	[Token(Token = "0x4008B6F")]
	[FieldOffset(Offset = "0x8")]
	public uint boss_id;

	[Token(Token = "0x4008B70")]
	[FieldOffset(Offset = "0xC")]
	public string boss_name;

	[Token(Token = "0x4008B71")]
	[FieldOffset(Offset = "0x10")]
	public uint coins;

	[Token(Token = "0x4008B72")]
	[FieldOffset(Offset = "0x14")]
	public uint gems;

	[Token(Token = "0x4008B73")]
	[FieldOffset(Offset = "0x18")]
	public List<Item> items;

	[Token(Token = "0x4008B74")]
	[FieldOffset(Offset = "0x1C")]
	public bool is_lucky;

	[Token(Token = "0x6007AC8")]
	[Address(RVA = "0x33E0F60", Offset = "0x33E0F60", VA = "0x33E0F60")]
	public ReceivedRedEnvelope()
	{
	}
}
