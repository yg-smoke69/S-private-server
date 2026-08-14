using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018FA")]
public class CSGetWorkshopPersonalRecommendationInfoRes
{
	[Token(Token = "0x4009E55")]
	[FieldOffset(Offset = "0x8")]
	public List<WorkshopPersonalRecommendationInfo> workshop_personal_recommendation_infos;

	[Token(Token = "0x6007F53")]
	[Address(RVA = "0x3096E6C", Offset = "0x3096E6C", VA = "0x3096E6C")]
	public CSGetWorkshopPersonalRecommendationInfoRes()
	{
	}
}
