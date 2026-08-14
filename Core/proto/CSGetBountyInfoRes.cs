using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200180E")]
public class CSGetBountyInfoRes
{
	[Token(Token = "0x4009BF6")]
	[FieldOffset(Offset = "0x8")]
	public ulong main_percent;

	[Token(Token = "0x4009BF7")]
	[FieldOffset(Offset = "0x10")]
	public ulong popularity;

	[Token(Token = "0x4009BF8")]
	[FieldOffset(Offset = "0x18")]
	public uint bounty_tokens;

	[Token(Token = "0x6007E68")]
	[Address(RVA = "0x31828CC", Offset = "0x31828CC", VA = "0x31828CC")]
	public CSGetBountyInfoRes()
	{
	}
}
