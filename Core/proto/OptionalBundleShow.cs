using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015B6")]
public class OptionalBundleShow
{
	[Token(Token = "0x400940E")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400940F")]
	[FieldOffset(Offset = "0xC")]
	public List<OptionalBundleShowData> bundles;

	[Token(Token = "0x6007C00")]
	[Address(RVA = "0x33DED5C", Offset = "0x33DED5C", VA = "0x33DED5C")]
	public OptionalBundleShow()
	{
	}
}
