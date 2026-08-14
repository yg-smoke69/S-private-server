using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AD0")]
public class FriendsSearchSettingDesc
{
	[Token(Token = "0x400A8CC")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A8CD")]
	[FieldOffset(Offset = "0xC")]
	public uint friends_pool_num;

	[Token(Token = "0x600812D")]
	[Address(RVA = "0x30A1404", Offset = "0x30A1404", VA = "0x30A1404")]
	public FriendsSearchSettingDesc()
	{
	}
}
