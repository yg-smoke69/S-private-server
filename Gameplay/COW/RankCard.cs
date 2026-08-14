using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20030CC")]
public class RankCard
{
	[Token(Token = "0x40128EB")]
	[FieldOffset(Offset = "0x8")]
	public int cardId;

	[Token(Token = "0x1700153A")]
	public ERankCardType CardType
	{
		[Token(Token = "0x601471A")]
		[Address(RVA = "0x196D4E0", Offset = "0x196D4E0", VA = "0x196D4E0")]
		get
		{
			return default(ERankCardType);
		}
	}

	[Token(Token = "0x6014719")]
	[Address(RVA = "0x196D4C0", Offset = "0x196D4C0", VA = "0x196D4C0")]
	public RankCard()
	{
	}

	[Token(Token = "0x601471B")]
	[Address(RVA = "0x196D5DC", Offset = "0x196D5DC", VA = "0x196D5DC")]
	public bool IsAvalible()
	{
		return default(bool);
	}
}
