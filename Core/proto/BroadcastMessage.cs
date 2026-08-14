using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016C6")]
public class BroadcastMessage
{
	[Token(Token = "0x4009722")]
	[FieldOffset(Offset = "0x8")]
	public string nickname;

	[Token(Token = "0x4009723")]
	[FieldOffset(Offset = "0xC")]
	public EAnnouncement.NavigationType navigation_type;

	[Token(Token = "0x4009724")]
	[FieldOffset(Offset = "0x10")]
	public string source;

	[Token(Token = "0x4009725")]
	[FieldOffset(Offset = "0x14")]
	public uint item_id;

	[Token(Token = "0x4009726")]
	[FieldOffset(Offset = "0x18")]
	public long time_stamp;

	[Token(Token = "0x4009727")]
	[FieldOffset(Offset = "0x20")]
	public uint source_id;

	[Token(Token = "0x4009728")]
	[FieldOffset(Offset = "0x24")]
	public uint left_expire_time;

	[Token(Token = "0x6007D27")]
	[Address(RVA = "0x317D4A0", Offset = "0x317D4A0", VA = "0x317D4A0")]
	public BroadcastMessage()
	{
	}
}
