using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016E1")]
public class CSGetGachaSpecialExchangeDescRes
{
	[Token(Token = "0x400978D")]
	[FieldOffset(Offset = "0x8")]
	public List<ChestSpecialExchangeDesc> chest_special_exchange_descs;

	[Token(Token = "0x6007D3B")]
	[Address(RVA = "0x31858BC", Offset = "0x31858BC", VA = "0x31858BC")]
	public CSGetGachaSpecialExchangeDescRes()
	{
	}
}
