using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B60")]
public class DigitaluniverseBSettingDesc
{
	[Token(Token = "0x400AC3E")]
	[FieldOffset(Offset = "0x8")]
	public bool ip_switch;

	[Token(Token = "0x400AC3F")]
	[FieldOffset(Offset = "0xC")]
	public uint token_id;

	[Token(Token = "0x400AC40")]
	[FieldOffset(Offset = "0x10")]
	public uint disable_opening_show;

	[Token(Token = "0x400AC41")]
	[FieldOffset(Offset = "0x18")]
	public long concert_start_time;

	[Token(Token = "0x400AC42")]
	[FieldOffset(Offset = "0x20")]
	public long concert_end_time;

	[Token(Token = "0x400AC43")]
	[FieldOffset(Offset = "0x28")]
	public long unlock_time;

	[Token(Token = "0x400AC44")]
	[FieldOffset(Offset = "0x30")]
	public string cloth_hold_percent_1st;

	[Token(Token = "0x400AC45")]
	[FieldOffset(Offset = "0x34")]
	public string cloth_hold_percent_2nd;

	[Token(Token = "0x400AC46")]
	[FieldOffset(Offset = "0x38")]
	public string cloth_hold_percent_3rd;

	[Token(Token = "0x400AC47")]
	[FieldOffset(Offset = "0x3C")]
	public string cloth_hold_percent_4th;

	[Token(Token = "0x60081BB")]
	[Address(RVA = "0x309EC2C", Offset = "0x309EC2C", VA = "0x309EC2C")]
	public DigitaluniverseBSettingDesc()
	{
	}
}
