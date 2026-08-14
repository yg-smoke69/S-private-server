using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C0D")]
public class ERampage4BTower
{
	[Token(Token = "0x2001C0E")]
	public enum TowerType
	{
		[Token(Token = "0x400B07A")]
		EMPTY_GRID,
		[Token(Token = "0x400B07B")]
		BORN_GRID,
		[Token(Token = "0x400B07C")]
		REWARD_GRID,
		[Token(Token = "0x400B07D")]
		RANDOM_EVENT,
		[Token(Token = "0x400B07E")]
		RANDOM_BUFF,
		[Token(Token = "0x400B07F")]
		BOOK_TOKEN,
		[Token(Token = "0x400B080")]
		NORMAL_ENEMY,
		[Token(Token = "0x400B081")]
		HARD_BOSS_1,
		[Token(Token = "0x400B082")]
		HARD_BOSS_2,
		[Token(Token = "0x400B083")]
		HARD_BOSS_3
	}

	[Token(Token = "0x6008268")]
	[Address(RVA = "0x309F8BC", Offset = "0x309F8BC", VA = "0x309F8BC")]
	public ERampage4BTower()
	{
	}
}
