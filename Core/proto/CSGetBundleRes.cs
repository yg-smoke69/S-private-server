using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015A0")]
public class CSGetBundleRes
{
	[Token(Token = "0x40093BE")]
	[FieldOffset(Offset = "0x8")]
	public List<BundleShow> bundle_show;

	[Token(Token = "0x6007BE8")]
	[Address(RVA = "0x3182BA8", Offset = "0x3182BA8", VA = "0x3182BA8")]
	public CSGetBundleRes()
	{
	}
}
