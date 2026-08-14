using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015A1")]
public class CSGetOptionalBundleRes
{
	[Token(Token = "0x40093BF")]
	[FieldOffset(Offset = "0x8")]
	public List<OptionalBundleShow> optional_bundle_show;

	[Token(Token = "0x6007BE9")]
	[Address(RVA = "0x3188328", Offset = "0x3188328", VA = "0x3188328")]
	public CSGetOptionalBundleRes()
	{
	}
}
