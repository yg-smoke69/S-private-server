using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200191F")]
public class JumpsuitHelpInfo
{
	[Token(Token = "0x4009ECF")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009ED0")]
	[FieldOffset(Offset = "0x10")]
	public string nick_name;

	[Token(Token = "0x4009ED1")]
	[FieldOffset(Offset = "0x14")]
	public bool token_claimed;

	[Token(Token = "0x4009ED2")]
	[FieldOffset(Offset = "0x18")]
	public long help_time;

	[Token(Token = "0x6007F78")]
	[Address(RVA = "0x30A41B0", Offset = "0x30A41B0", VA = "0x30A41B0")]
	public JumpsuitHelpInfo()
	{
	}
}
