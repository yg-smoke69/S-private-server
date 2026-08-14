using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013D1")]
public class FriendAliasInfo
{
	[Token(Token = "0x4008B33")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008B34")]
	[FieldOffset(Offset = "0x10")]
	public string alias;

	[Token(Token = "0x6007AB4")]
	[Address(RVA = "0x30A1354", Offset = "0x30A1354", VA = "0x30A1354")]
	public FriendAliasInfo()
	{
	}
}
