using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017CC")]
public class AccountSubscription
{
	[Token(Token = "0x4009B6D")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009B6E")]
	[FieldOffset(Offset = "0x10")]
	public uint store_id;

	[Token(Token = "0x4009B6F")]
	[FieldOffset(Offset = "0x14")]
	public bool can_claim_reward;

	[Token(Token = "0x6007E26")]
	[Address(RVA = "0x3179CE0", Offset = "0x3179CE0", VA = "0x3179CE0")]
	public AccountSubscription()
	{
	}
}
