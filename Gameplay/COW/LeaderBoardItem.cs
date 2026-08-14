using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002928")]
internal class LeaderBoardItem
{
	[Token(Token = "0x400FD77")]
	[FieldOffset(Offset = "0x8")]
	private int rank;

	[Token(Token = "0x400FD78")]
	[FieldOffset(Offset = "0xC")]
	private int user_id;

	[Token(Token = "0x60105A1")]
	[Address(RVA = "0x1EF9660", Offset = "0x1EF9660", VA = "0x1EF9660")]
	public LeaderBoardItem()
	{
	}
}
