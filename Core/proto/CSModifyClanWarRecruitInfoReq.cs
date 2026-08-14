using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001667")]
public class CSModifyClanWarRecruitInfoReq
{
	[Token(Token = "0x4009619")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x400961A")]
	[FieldOffset(Offset = "0x10")]
	public uint entry_rank;

	[Token(Token = "0x400961B")]
	[FieldOffset(Offset = "0x14")]
	public uint entry_cs_rank;

	[Token(Token = "0x6007CB1")]
	[Address(RVA = "0x3097C90", Offset = "0x3097C90", VA = "0x3097C90")]
	public CSModifyClanWarRecruitInfoReq()
	{
	}
}
