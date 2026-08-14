using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001608")]
public class CSGetActivityRewardsReq
{
	[Token(Token = "0x40094DC")]
	[FieldOffset(Offset = "0x8")]
	public uint[] activity_ids;

	[Token(Token = "0x40094DD")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x6007C52")]
	[Address(RVA = "0x31812B4", Offset = "0x31812B4", VA = "0x31812B4")]
	public CSGetActivityRewardsReq()
	{
	}
}
