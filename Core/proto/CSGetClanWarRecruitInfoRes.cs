using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001668")]
public class CSGetClanWarRecruitInfoRes
{
	[Token(Token = "0x400961C")]
	[FieldOffset(Offset = "0x8")]
	public uint entry_rank;

	[Token(Token = "0x400961D")]
	[FieldOffset(Offset = "0xC")]
	public uint entry_cs_rank;

	[Token(Token = "0x6007CB2")]
	[Address(RVA = "0x318328C", Offset = "0x318328C", VA = "0x318328C")]
	public CSGetClanWarRecruitInfoRes()
	{
	}
}
