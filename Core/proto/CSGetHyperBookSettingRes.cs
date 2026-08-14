using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001988")]
public class CSGetHyperBookSettingRes
{
	[Token(Token = "0x400A007")]
	[FieldOffset(Offset = "0x8")]
	public List<CollectionBookDesc> books;

	[Token(Token = "0x400A008")]
	[FieldOffset(Offset = "0xC")]
	public List<CollectionBookItemDesc> book_items;

	[Token(Token = "0x6007FE1")]
	[Address(RVA = "0x3186084", Offset = "0x3186084", VA = "0x3186084")]
	public CSGetHyperBookSettingRes()
	{
	}
}
