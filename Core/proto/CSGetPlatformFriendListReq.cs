using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200169D")]
public class CSGetPlatformFriendListReq
{
	[Token(Token = "0x4009699")]
	[FieldOffset(Offset = "0x8")]
	public string token;

	[Token(Token = "0x400969A")]
	[FieldOffset(Offset = "0xC")]
	public uint platform_sdk_id;

	[Token(Token = "0x400969B")]
	[FieldOffset(Offset = "0x10")]
	public uint platform_type;

	[Token(Token = "0x400969C")]
	[FieldOffset(Offset = "0x14")]
	public bool need_presence;

	[Token(Token = "0x400969D")]
	[FieldOffset(Offset = "0x15")]
	public bool need_stats;

	[Token(Token = "0x400969E")]
	[FieldOffset(Offset = "0x16")]
	public bool need_ranking_stats;

	[Token(Token = "0x400969F")]
	[FieldOffset(Offset = "0x17")]
	public bool need_casual_stats;

	[Token(Token = "0x40096A0")]
	[FieldOffset(Offset = "0x18")]
	public bool need_cs_ranking_stats;

	[Token(Token = "0x6007CFA")]
	[Address(RVA = "0x3188764", Offset = "0x3188764", VA = "0x3188764")]
	public CSGetPlatformFriendListReq()
	{
	}

	[Token(Token = "0x6007CFB")]
	[Address(RVA = "0x3188804", Offset = "0x3188804", VA = "0x3188804", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6007CFC")]
	[Address(RVA = "0x31889D8", Offset = "0x31889D8", VA = "0x31889D8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
