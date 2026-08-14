using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001683")]
public class CSClaimDispatchQuestRewardsReq
{
	[Token(Token = "0x4009659")]
	[FieldOffset(Offset = "0x8")]
	public uint quest_line;

	[Token(Token = "0x400965A")]
	[FieldOffset(Offset = "0xC")]
	public uint quest_id;

	[Token(Token = "0x6007CCD")]
	[Address(RVA = "0x317E5C8", Offset = "0x317E5C8", VA = "0x317E5C8")]
	public CSClaimDispatchQuestRewardsReq()
	{
	}
}
