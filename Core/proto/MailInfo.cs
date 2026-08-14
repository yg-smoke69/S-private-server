using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001371")]
public class MailInfo
{
	[Token(Token = "0x400897B")]
	[FieldOffset(Offset = "0x8")]
	public ulong mail_id;

	[Token(Token = "0x400897C")]
	[FieldOffset(Offset = "0x10")]
	public uint type;

	[Token(Token = "0x400897D")]
	[FieldOffset(Offset = "0x14")]
	public string title;

	[Token(Token = "0x400897E")]
	[FieldOffset(Offset = "0x18")]
	public string content;

	[Token(Token = "0x400897F")]
	[FieldOffset(Offset = "0x1C")]
	public MailSenderInfo sender_info;

	[Token(Token = "0x4008980")]
	[FieldOffset(Offset = "0x20")]
	public MailAttachment attachment;

	[Token(Token = "0x4008981")]
	[FieldOffset(Offset = "0x28")]
	public long receive_time;

	[Token(Token = "0x4008982")]
	[FieldOffset(Offset = "0x30")]
	public EMail.Status status;

	[Token(Token = "0x4008983")]
	[FieldOffset(Offset = "0x34")]
	public EMail.Source source;

	[Token(Token = "0x4008984")]
	[FieldOffset(Offset = "0x38")]
	public EMail.ActionType action_type;

	[Token(Token = "0x6007A72")]
	[Address(RVA = "0x30A74C0", Offset = "0x30A74C0", VA = "0x30A74C0")]
	public MailInfo()
	{
	}
}
