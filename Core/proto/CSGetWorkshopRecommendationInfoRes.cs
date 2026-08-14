using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018F2")]
public class CSGetWorkshopRecommendationInfoRes
{
	[Token(Token = "0x4009E42")]
	[FieldOffset(Offset = "0x8")]
	public List<WorkshopHotInfo> hot_infos;

	[Token(Token = "0x4009E43")]
	[FieldOffset(Offset = "0xC")]
	public List<WorkshopEditorChoiceDesc> editor_choice_descs;

	[Token(Token = "0x6007F4B")]
	[Address(RVA = "0x3096F98", Offset = "0x3096F98", VA = "0x3096F98")]
	public CSGetWorkshopRecommendationInfoRes()
	{
	}
}
