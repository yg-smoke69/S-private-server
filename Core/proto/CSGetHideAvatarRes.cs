using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001677")]
public class CSGetHideAvatarRes
{
	[Token(Token = "0x400963F")]
	[FieldOffset(Offset = "0x8")]
	public uint[] avatar_id;

	[Token(Token = "0x4009640")]
	[FieldOffset(Offset = "0xC")]
	public uint[] ip_expired_avatar_id;

	[Token(Token = "0x6007CC1")]
	[Address(RVA = "0x3185CD8", Offset = "0x3185CD8", VA = "0x3185CD8")]
	public CSGetHideAvatarRes()
	{
	}
}
