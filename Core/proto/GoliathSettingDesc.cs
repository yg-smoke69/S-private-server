using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B51")]
public class GoliathSettingDesc
{
	[Token(Token = "0x400ABCB")]
	[FieldOffset(Offset = "0x8")]
	public uint auto_departure_time;

	[Token(Token = "0x400ABCC")]
	[FieldOffset(Offset = "0xC")]
	public uint web_event_open_time;

	[Token(Token = "0x400ABCD")]
	[FieldOffset(Offset = "0x10")]
	public uint web_event_end_time;

	[Token(Token = "0x400ABCE")]
	[FieldOffset(Offset = "0x14")]
	public string web_event_url;

	[Token(Token = "0x400ABCF")]
	[FieldOffset(Offset = "0x18")]
	public uint token_id;

	[Token(Token = "0x400ABD0")]
	[FieldOffset(Offset = "0x1C")]
	public uint duo_extra_reward;

	[Token(Token = "0x400ABD1")]
	[FieldOffset(Offset = "0x20")]
	public uint trio_extra_reward;

	[Token(Token = "0x400ABD2")]
	[FieldOffset(Offset = "0x24")]
	public uint squad_extra_reward;

	[Token(Token = "0x60081AC")]
	[Address(RVA = "0x30A2B4C", Offset = "0x30A2B4C", VA = "0x30A2B4C")]
	public GoliathSettingDesc()
	{
	}
}
