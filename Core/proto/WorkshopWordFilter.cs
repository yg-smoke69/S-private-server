using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014BF")]
public class WorkshopWordFilter
{
	[Token(Token = "0x4008FB5")]
	[FieldOffset(Offset = "0x8")]
	public EWorkshop.WordFilterType word_filter_type;

	[Token(Token = "0x4008FB6")]
	[FieldOffset(Offset = "0xC")]
	public string filter_content;

	[Token(Token = "0x4008FB7")]
	[FieldOffset(Offset = "0x10")]
	public string dirty_words;

	[Token(Token = "0x6007B20")]
	[Address(RVA = "0x33E6B88", Offset = "0x33E6B88", VA = "0x33E6B88")]
	public WorkshopWordFilter()
	{
	}
}
