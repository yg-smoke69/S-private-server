using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B85")]
public class MVPSettingDesc
{
	[Token(Token = "0x400AD0D")]
	[FieldOffset(Offset = "0x8")]
	public uint web_open;

	[Token(Token = "0x400AD0E")]
	[FieldOffset(Offset = "0xC")]
	public uint web_close;

	[Token(Token = "0x400AD0F")]
	[FieldOffset(Offset = "0x10")]
	public string web_jump;

	[Token(Token = "0x400AD10")]
	[FieldOffset(Offset = "0x14")]
	public uint chess_open;

	[Token(Token = "0x400AD11")]
	[FieldOffset(Offset = "0x18")]
	public uint chess_close;

	[Token(Token = "0x400AD12")]
	[FieldOffset(Offset = "0x1C")]
	public uint sign_in_open;

	[Token(Token = "0x400AD13")]
	[FieldOffset(Offset = "0x20")]
	public uint sign_in_close;

	[Token(Token = "0x400AD14")]
	[FieldOffset(Offset = "0x24")]
	public uint exchange_store_open;

	[Token(Token = "0x400AD15")]
	[FieldOffset(Offset = "0x28")]
	public uint exchange_store_close;

	[Token(Token = "0x400AD16")]
	[FieldOffset(Offset = "0x2C")]
	public uint gacha_jump;

	[Token(Token = "0x400AD17")]
	[FieldOffset(Offset = "0x30")]
	public uint gacha_jump_start;

	[Token(Token = "0x400AD18")]
	[FieldOffset(Offset = "0x34")]
	public uint gacha_jump_end;

	[Token(Token = "0x400AD19")]
	[FieldOffset(Offset = "0x38")]
	public uint exchange_token;

	[Token(Token = "0x400AD1A")]
	[FieldOffset(Offset = "0x3C")]
	public uint sugar_token;

	[Token(Token = "0x400AD1B")]
	[FieldOffset(Offset = "0x40")]
	public string background_cdn;

	[Token(Token = "0x60081E0")]
	[Address(RVA = "0x30A72B8", Offset = "0x30A72B8", VA = "0x30A72B8")]
	public MVPSettingDesc()
	{
	}
}
