using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B13")]
public class ActivityConfigDesc
{
	[Token(Token = "0x400AA31")]
	[FieldOffset(Offset = "0x8")]
	public uint activity_id;

	[Token(Token = "0x400AA32")]
	[FieldOffset(Offset = "0xC")]
	public uint activity_type;

	[Token(Token = "0x400AA33")]
	[FieldOffset(Offset = "0x10")]
	public string start_time;

	[Token(Token = "0x400AA34")]
	[FieldOffset(Offset = "0x14")]
	public string end_time;

	[Token(Token = "0x400AA35")]
	[FieldOffset(Offset = "0x18")]
	public uint circle_type;

	[Token(Token = "0x400AA36")]
	[FieldOffset(Offset = "0x1C")]
	public uint[] match_modes;

	[Token(Token = "0x400AA37")]
	[FieldOffset(Offset = "0x20")]
	public uint process_num;

	[Token(Token = "0x400AA38")]
	[FieldOffset(Offset = "0x24")]
	public uint award_id;

	[Token(Token = "0x400AA39")]
	[FieldOffset(Offset = "0x28")]
	public uint award_num;

	[Token(Token = "0x400AA3A")]
	[FieldOffset(Offset = "0x2C")]
	public string cdn_url1;

	[Token(Token = "0x400AA3B")]
	[FieldOffset(Offset = "0x30")]
	public string cdn_url2;

	[Token(Token = "0x400AA3C")]
	[FieldOffset(Offset = "0x34")]
	public uint expire_time;

	[Token(Token = "0x600816E")]
	[Address(RVA = "0x317A030", Offset = "0x317A030", VA = "0x317A030")]
	public ActivityConfigDesc()
	{
	}
}
