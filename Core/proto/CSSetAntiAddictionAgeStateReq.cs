using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017C2")]
public class CSSetAntiAddictionAgeStateReq
{
	[Token(Token = "0x4009B55")]
	[FieldOffset(Offset = "0x8")]
	public EAntiAddiction.AgeState age_state;

	[Token(Token = "0x4009B56")]
	[FieldOffset(Offset = "0xC")]
	public string country_code;

	[Token(Token = "0x6007E1C")]
	[Address(RVA = "0x30999F8", Offset = "0x30999F8", VA = "0x30999F8")]
	public CSSetAntiAddictionAgeStateReq()
	{
	}
}
