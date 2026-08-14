using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015EE")]
public class CSNewPlayerSigninReq
{
	[Token(Token = "0x4009499")]
	[FieldOffset(Offset = "0x8")]
	public uint reward_id;

	[Token(Token = "0x400949A")]
	[FieldOffset(Offset = "0xC")]
	public uint level;

	[Token(Token = "0x6007C38")]
	[Address(RVA = "0x3098134", Offset = "0x3098134", VA = "0x3098134")]
	public CSNewPlayerSigninReq()
	{
	}
}
