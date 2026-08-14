using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001720")]
public class BlacklistInfoRes
{
	[Token(Token = "0x4009903")]
	[FieldOffset(Offset = "0x8")]
	public EAccount.BanReason ban_reason;

	[Token(Token = "0x4009904")]
	[FieldOffset(Offset = "0xC")]
	public uint expire_duration;

	[Token(Token = "0x4009905")]
	[FieldOffset(Offset = "0x10")]
	public uint ban_time;

	[Token(Token = "0x6007D7A")]
	[Address(RVA = "0x317C5F0", Offset = "0x317C5F0", VA = "0x317C5F0")]
	public BlacklistInfoRes()
	{
	}
}
