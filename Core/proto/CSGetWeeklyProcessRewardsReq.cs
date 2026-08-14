using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001712")]
public class CSGetWeeklyProcessRewardsReq
{
	[Token(Token = "0x400986A")]
	[FieldOffset(Offset = "0x8")]
	public uint week_id;

	[Token(Token = "0x400986B")]
	[FieldOffset(Offset = "0xC")]
	public uint node_id;

	[Token(Token = "0x6007D6C")]
	[Address(RVA = "0x30966F0", Offset = "0x30966F0", VA = "0x30966F0")]
	public CSGetWeeklyProcessRewardsReq()
	{
	}
}
