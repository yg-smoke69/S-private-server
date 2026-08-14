using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DA5")]
public class AvatarLevelUpCard
{
	[Token(Token = "0x4011854")]
	[FieldOffset(Offset = "0x8")]
	public int cardId;

	[Token(Token = "0x4011855")]
	[FieldOffset(Offset = "0xC")]
	public int toLevel;

	[Token(Token = "0x4011856")]
	[FieldOffset(Offset = "0x10")]
	public uint goPos;

	[Token(Token = "0x60131D2")]
	[Address(RVA = "0x234D594", Offset = "0x234D594", VA = "0x234D594")]
	public AvatarLevelUpCard()
	{
	}
}
