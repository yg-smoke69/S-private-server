using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001610")]
public class CSGetBingoRewardsRes
{
	[Token(Token = "0x40094EB")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x40094EC")]
	[FieldOffset(Offset = "0xC")]
	public AwardData rewards;

	[Token(Token = "0x6007C5A")]
	[Address(RVA = "0x3182420", Offset = "0x3182420", VA = "0x3182420")]
	public CSGetBingoRewardsRes()
	{
	}
}
