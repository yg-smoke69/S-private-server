using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001382")]
public class AvatarProfileWithID
{
	[Token(Token = "0x40089BB")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40089BC")]
	[FieldOffset(Offset = "0x10")]
	public AvatarProfile avatar_profile;

	[Token(Token = "0x6007A83")]
	[Address(RVA = "0x317B2B4", Offset = "0x317B2B4", VA = "0x317B2B4")]
	public AvatarProfileWithID()
	{
	}
}
