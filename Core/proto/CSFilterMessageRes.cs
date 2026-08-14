using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200155C")]
public class CSFilterMessageRes
{
	[Token(Token = "0x40092DE")]
	[FieldOffset(Offset = "0x8")]
	public bool is_dirty;

	[Token(Token = "0x40092DF")]
	[FieldOffset(Offset = "0xC")]
	public List<string> dirty_words;

	[Token(Token = "0x40092E0")]
	[FieldOffset(Offset = "0x10")]
	public string filtered_text;

	[Token(Token = "0x6007BA4")]
	[Address(RVA = "0x31805DC", Offset = "0x31805DC", VA = "0x31805DC")]
	public CSFilterMessageRes()
	{
	}
}
