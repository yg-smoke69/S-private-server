using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017A5")]
public class CupMatchStats
{
	[Token(Token = "0x4009AFF")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009B00")]
	[FieldOffset(Offset = "0x10")]
	public ulong opponent_id;

	[Token(Token = "0x4009B01")]
	[FieldOffset(Offset = "0x18")]
	public bool win;

	[Token(Token = "0x6007DFF")]
	[Address(RVA = "0x309DD20", Offset = "0x309DD20", VA = "0x309DD20")]
	public CupMatchStats()
	{
	}
}
