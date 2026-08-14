using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B3B")]
public class BountySettingDesc
{
	[Token(Token = "0x400AB3B")]
	[FieldOffset(Offset = "0x8")]
	public uint model_id1;

	[Token(Token = "0x400AB3C")]
	[FieldOffset(Offset = "0xC")]
	public uint model_show_timestamp1;

	[Token(Token = "0x400AB3D")]
	[FieldOffset(Offset = "0x10")]
	public uint model_start_timestamp1;

	[Token(Token = "0x400AB3E")]
	[FieldOffset(Offset = "0x14")]
	public uint model_end_timestamp1;

	[Token(Token = "0x400AB3F")]
	[FieldOffset(Offset = "0x18")]
	public uint model_id2;

	[Token(Token = "0x400AB40")]
	[FieldOffset(Offset = "0x1C")]
	public uint model_show_timestamp2;

	[Token(Token = "0x400AB41")]
	[FieldOffset(Offset = "0x20")]
	public uint model_start_timestamp2;

	[Token(Token = "0x400AB42")]
	[FieldOffset(Offset = "0x24")]
	public uint model_end_timestamp2;

	[Token(Token = "0x400AB43")]
	[FieldOffset(Offset = "0x28")]
	public uint web_event_show_timestamp;

	[Token(Token = "0x400AB44")]
	[FieldOffset(Offset = "0x2C")]
	public uint web_event_start_timestamp;

	[Token(Token = "0x400AB45")]
	[FieldOffset(Offset = "0x30")]
	public uint web_event_end_timestamp;

	[Token(Token = "0x400AB46")]
	[FieldOffset(Offset = "0x34")]
	public string web_event_url;

	[Token(Token = "0x400AB47")]
	[FieldOffset(Offset = "0x38")]
	public uint purchase_show_timestamp;

	[Token(Token = "0x400AB48")]
	[FieldOffset(Offset = "0x3C")]
	public uint purchase_start_timestamp;

	[Token(Token = "0x400AB49")]
	[FieldOffset(Offset = "0x40")]
	public uint purchase_end_timestamp;

	[Token(Token = "0x400AB4A")]
	[FieldOffset(Offset = "0x44")]
	public uint calc_start_timestamp;

	[Token(Token = "0x400AB4B")]
	[FieldOffset(Offset = "0x48")]
	public uint token_id;

	[Token(Token = "0x400AB4C")]
	[FieldOffset(Offset = "0x4C")]
	public uint process_id;

	[Token(Token = "0x400AB4D")]
	[FieldOffset(Offset = "0x50")]
	public uint warm_up_start_timestamp;

	[Token(Token = "0x400AB4E")]
	[FieldOffset(Offset = "0x54")]
	public bool task_switch;

	[Token(Token = "0x400AB4F")]
	[FieldOffset(Offset = "0x55")]
	public bool store_switch;

	[Token(Token = "0x400AB50")]
	[FieldOffset(Offset = "0x58")]
	public uint master_id;

	[Token(Token = "0x400AB51")]
	[FieldOffset(Offset = "0x5C")]
	public uint nightmare_id;

	[Token(Token = "0x400AB52")]
	[FieldOffset(Offset = "0x60")]
	public string before_key;

	[Token(Token = "0x400AB53")]
	[FieldOffset(Offset = "0x64")]
	public uint shop_gopos;

	[Token(Token = "0x400AB54")]
	[FieldOffset(Offset = "0x68")]
	public uint subshop_gopos;

	[Token(Token = "0x400AB55")]
	[FieldOffset(Offset = "0x6C")]
	public uint bounty_show_end_timestamp;

	[Token(Token = "0x6008196")]
	[Address(RVA = "0x317D11C", Offset = "0x317D11C", VA = "0x317D11C")]
	public BountySettingDesc()
	{
	}
}
