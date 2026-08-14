using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016D0")]
public class CSGetAdvertRes
{
	[Token(Token = "0x400975D")]
	[FieldOffset(Offset = "0x8")]
	public List<AdvertDesc> advert_items;

	[Token(Token = "0x6007D2A")]
	[Address(RVA = "0x31813FC", Offset = "0x31813FC", VA = "0x31813FC")]
	public CSGetAdvertRes()
	{
	}
}
