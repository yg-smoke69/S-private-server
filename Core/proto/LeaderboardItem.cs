using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200155F")]
public class LeaderboardItem
{
	[Token(Token = "0x40092ED")]
	[FieldOffset(Offset = "0x8")]
	public ulong unique_id;

	[Token(Token = "0x40092EE")]
	[FieldOffset(Offset = "0x10")]
	public double score;

	[Token(Token = "0x40092EF")]
	[FieldOffset(Offset = "0x18")]
	public LeaderboardProfile profile;

	[Token(Token = "0x40092F0")]
	[FieldOffset(Offset = "0x1C")]
	public int pos;

	[Token(Token = "0x6007BA7")]
	[Address(RVA = "0x30A4454", Offset = "0x30A4454", VA = "0x30A4454")]
	public LeaderboardItem()
	{
	}
}
