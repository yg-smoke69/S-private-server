using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BC0")]
public class MocoMonthSettingDesc
{
	[Token(Token = "0x400AEA9")]
	[FieldOffset(Offset = "0x8")]
	public bool game_switch;

	[Token(Token = "0x400AEAA")]
	[FieldOffset(Offset = "0xC")]
	public uint free_times;

	[Token(Token = "0x400AEAB")]
	[FieldOffset(Offset = "0x10")]
	public uint process_start_time;

	[Token(Token = "0x400AEAC")]
	[FieldOffset(Offset = "0x14")]
	public uint awaken_store_control;

	[Token(Token = "0x400AEAD")]
	[FieldOffset(Offset = "0x18")]
	public uint token_id1;

	[Token(Token = "0x400AEAE")]
	[FieldOffset(Offset = "0x1C")]
	public uint token_id2;

	[Token(Token = "0x400AEAF")]
	[FieldOffset(Offset = "0x20")]
	public uint MaxProcessValue;

	[Token(Token = "0x600821B")]
	[Address(RVA = "0x30A8C58", Offset = "0x30A8C58", VA = "0x30A8C58")]
	public MocoMonthSettingDesc()
	{
	}
}
