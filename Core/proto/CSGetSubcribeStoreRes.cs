using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017CA")]
public class CSGetSubcribeStoreRes
{
	[Token(Token = "0x4009B6B")]
	[FieldOffset(Offset = "0x8")]
	public List<SubscribeStoreDesc> items;

	[Token(Token = "0x6007E24")]
	[Address(RVA = "0x3095808", Offset = "0x3095808", VA = "0x3095808")]
	public CSGetSubcribeStoreRes()
	{
	}
}
