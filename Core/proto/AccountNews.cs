using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200138F")]
public class AccountNews
{
	[Token(Token = "0x40089F7")]
	[FieldOffset(Offset = "0x8")]
	public EAccount.NewsType type;

	[Token(Token = "0x40089F8")]
	[FieldOffset(Offset = "0xC")]
	public AccountNewsContent content;

	[Token(Token = "0x40089F9")]
	[FieldOffset(Offset = "0x10")]
	public long update_time;

	[Token(Token = "0x6007A8B")]
	[Address(RVA = "0x31799F0", Offset = "0x31799F0", VA = "0x31799F0")]
	public AccountNews()
	{
	}
}
