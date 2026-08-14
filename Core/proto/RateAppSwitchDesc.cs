using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B7D")]
public class RateAppSwitchDesc
{
	[Token(Token = "0x400ACEB")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400ACEC")]
	[FieldOffset(Offset = "0xC")]
	public bool ios_open;

	[Token(Token = "0x400ACED")]
	[FieldOffset(Offset = "0xD")]
	public bool gp_open;

	[Token(Token = "0x400ACEE")]
	[FieldOffset(Offset = "0xE")]
	public bool huawei_open;

	[Token(Token = "0x400ACEF")]
	[FieldOffset(Offset = "0xF")]
	public bool xiaomi_open;

	[Token(Token = "0x400ACF0")]
	[FieldOffset(Offset = "0x10")]
	public uint game_mode1;

	[Token(Token = "0x400ACF1")]
	[FieldOffset(Offset = "0x14")]
	public uint rank1;

	[Token(Token = "0x400ACF2")]
	[FieldOffset(Offset = "0x18")]
	public uint game_mode2;

	[Token(Token = "0x400ACF3")]
	[FieldOffset(Offset = "0x1C")]
	public uint rank2;

	[Token(Token = "0x400ACF4")]
	[FieldOffset(Offset = "0x20")]
	public uint cd;

	[Token(Token = "0x60081D8")]
	[Address(RVA = "0x33E0EB0", Offset = "0x33E0EB0", VA = "0x33E0EB0")]
	public RateAppSwitchDesc()
	{
	}
}
