using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200284A")]
public class LeaderBoardSortingData
{
	[Token(Token = "0x400F891")]
	[FieldOffset(Offset = "0x8")]
	public EMatchResultPlayerInfoType InfoType;

	[Token(Token = "0x400F892")]
	[FieldOffset(Offset = "0xC")]
	public ELeaderBoardSortingOrder Order;

	[Token(Token = "0x400F893")]
	[FieldOffset(Offset = "0x10")]
	public int Value;

	[Token(Token = "0x600FBAB")]
	[Address(RVA = "0x1EF9668", Offset = "0x1EF9668", VA = "0x1EF9668")]
	public LeaderBoardSortingData()
	{
	}
}
