using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200173E")]
public class CSGetGiftRankRewardInfoRes
{
	[Token(Token = "0x40099AF")]
	[FieldOffset(Offset = "0x8")]
	public uint[] receiver_rewarded_list;

	[Token(Token = "0x40099B0")]
	[FieldOffset(Offset = "0xC")]
	public uint[] giver_rewarded_list;

	[Token(Token = "0x6007D98")]
	[Address(RVA = "0x3185A68", Offset = "0x3185A68", VA = "0x3185A68")]
	public CSGetGiftRankRewardInfoRes()
	{
	}
}
