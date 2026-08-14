using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A05")]
public class MailDesc
{
	[Token(Token = "0x400A329")]
	[FieldOffset(Offset = "0x8")]
	public uint max_mail_num;

	[Token(Token = "0x400A32A")]
	[FieldOffset(Offset = "0xC")]
	public uint expire_days;

	[Token(Token = "0x400A32B")]
	[FieldOffset(Offset = "0x10")]
	public uint max_report_mail_num;

	[Token(Token = "0x400A32C")]
	[FieldOffset(Offset = "0x14")]
	public uint report_mail_expire_days;

	[Token(Token = "0x600805D")]
	[Address(RVA = "0x30A7418", Offset = "0x30A7418", VA = "0x30A7418")]
	public MailDesc()
	{
	}
}
