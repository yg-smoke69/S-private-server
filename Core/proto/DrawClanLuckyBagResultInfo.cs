using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200164C")]
public class DrawClanLuckyBagResultInfo
{
	[Token(Token = "0x40095DA")]
	[FieldOffset(Offset = "0x8")]
	public EDrawClanLuckyBagResultType.ResultType result_type;

	[Token(Token = "0x40095DB")]
	[FieldOffset(Offset = "0xC")]
	public ulong[] bag_ids;

	[Token(Token = "0x6007C96")]
	[Address(RVA = "0x309F228", Offset = "0x309F228", VA = "0x309F228")]
	public DrawClanLuckyBagResultInfo()
	{
	}
}
