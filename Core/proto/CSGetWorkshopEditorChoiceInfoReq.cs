using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001902")]
public class CSGetWorkshopEditorChoiceInfoReq
{
	[Token(Token = "0x4009E8A")]
	[FieldOffset(Offset = "0x8")]
	public uint choice_id;

	[Token(Token = "0x4009E8B")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x6007F5B")]
	[Address(RVA = "0x3096B94", Offset = "0x3096B94", VA = "0x3096B94")]
	public CSGetWorkshopEditorChoiceInfoReq()
	{
	}
}
