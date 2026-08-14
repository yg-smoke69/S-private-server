using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016B5")]
public class IntimacyRankAwardInfo
{
	[Token(Token = "0x40096CC")]
	[FieldOffset(Offset = "0x8")]
	public uint rank;

	[Token(Token = "0x40096CD")]
	[FieldOffset(Offset = "0xC")]
	public EFriend.IntimacyRankAwardStatus status;

	[Token(Token = "0x6007D16")]
	[Address(RVA = "0x30A3DB8", Offset = "0x30A3DB8", VA = "0x30A3DB8")]
	public IntimacyRankAwardInfo()
	{
	}
}
