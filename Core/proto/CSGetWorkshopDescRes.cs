using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001906")]
public class CSGetWorkshopDescRes
{
	[Token(Token = "0x4009E90")]
	[FieldOffset(Offset = "0x8")]
	public List<WorkshopCustomModeTemplateRuleDesc> template_rule_desc;

	[Token(Token = "0x6007F5F")]
	[Address(RVA = "0x3096B08", Offset = "0x3096B08", VA = "0x3096B08")]
	public CSGetWorkshopDescRes()
	{
	}
}
