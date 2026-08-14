using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001903")]
public class CSGetWorkshopEditorChoiceInfoRes
{
	[Token(Token = "0x4009E8C")]
	[FieldOffset(Offset = "0x8")]
	public List<WorkshopEditorChoiceInfo> workshop_editor_choice_infos;

	[Token(Token = "0x6007F5C")]
	[Address(RVA = "0x3096C34", Offset = "0x3096C34", VA = "0x3096C34")]
	public CSGetWorkshopEditorChoiceInfoRes()
	{
	}
}
