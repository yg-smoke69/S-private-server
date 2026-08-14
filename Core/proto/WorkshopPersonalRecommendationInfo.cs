using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014BC")]
public class WorkshopPersonalRecommendationInfo
{
	[Token(Token = "0x4008FAC")]
	[FieldOffset(Offset = "0x8")]
	public string workshop_code;

	[Token(Token = "0x4008FAD")]
	[FieldOffset(Offset = "0xC")]
	public WorkshopBasicInfo workshop_basic_info;

	[Token(Token = "0x6007B1D")]
	[Address(RVA = "0x33E68F8", Offset = "0x33E68F8", VA = "0x33E68F8")]
	public WorkshopPersonalRecommendationInfo()
	{
	}
}
