using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015F5")]
public class CSGetBatchShowContentRes
{
	[Token(Token = "0x40094AA")]
	[FieldOffset(Offset = "0x8")]
	public List<BatchShowContentDesc> show_content;

	[Token(Token = "0x6007C3F")]
	[Address(RVA = "0x3181FF0", Offset = "0x3181FF0", VA = "0x3181FF0")]
	public CSGetBatchShowContentRes()
	{
	}
}
