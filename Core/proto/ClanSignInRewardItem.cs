using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200163D")]
public class ClanSignInRewardItem
{
	[Token(Token = "0x4009587")]
	[FieldOffset(Offset = "0x8")]
	public ClanSignInRewardsDesc desc;

	[Token(Token = "0x4009588")]
	[FieldOffset(Offset = "0xC")]
	public uint status;

	[Token(Token = "0x6007C87")]
	[Address(RVA = "0x309C140", Offset = "0x309C140", VA = "0x309C140")]
	public ClanSignInRewardItem()
	{
	}
}
