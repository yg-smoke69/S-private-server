using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B3C")]
public class BountyPlayerRatingDesc
{
	[Token(Token = "0x400AB56")]
	[FieldOffset(Offset = "0x8")]
	public uint type_id;

	[Token(Token = "0x400AB57")]
	[FieldOffset(Offset = "0xC")]
	public string failed_title_key;

	[Token(Token = "0x400AB58")]
	[FieldOffset(Offset = "0x10")]
	public string failed_comment_key;

	[Token(Token = "0x400AB59")]
	[FieldOffset(Offset = "0x14")]
	public uint threshold_of_a;

	[Token(Token = "0x400AB5A")]
	[FieldOffset(Offset = "0x18")]
	public string a_title_key;

	[Token(Token = "0x400AB5B")]
	[FieldOffset(Offset = "0x1C")]
	public string a_comment_key;

	[Token(Token = "0x400AB5C")]
	[FieldOffset(Offset = "0x20")]
	public uint threshold_of_s;

	[Token(Token = "0x400AB5D")]
	[FieldOffset(Offset = "0x24")]
	public string s_title_key;

	[Token(Token = "0x400AB5E")]
	[FieldOffset(Offset = "0x28")]
	public string s_comment_key;

	[Token(Token = "0x400AB5F")]
	[FieldOffset(Offset = "0x2C")]
	public uint threshold_of_ss;

	[Token(Token = "0x400AB60")]
	[FieldOffset(Offset = "0x30")]
	public string ss_title_key;

	[Token(Token = "0x400AB61")]
	[FieldOffset(Offset = "0x34")]
	public string ss_comment_key;

	[Token(Token = "0x400AB62")]
	[FieldOffset(Offset = "0x38")]
	public uint threshold_of_sss;

	[Token(Token = "0x400AB63")]
	[FieldOffset(Offset = "0x3C")]
	public string sss_title_key;

	[Token(Token = "0x400AB64")]
	[FieldOffset(Offset = "0x40")]
	public string sss_comment_key;

	[Token(Token = "0x6008197")]
	[Address(RVA = "0x317D010", Offset = "0x317D010", VA = "0x317D010")]
	public BountyPlayerRatingDesc()
	{
	}
}
