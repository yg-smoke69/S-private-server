using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015B5")]
public class BundleShow
{
	[Token(Token = "0x400940C")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400940D")]
	[FieldOffset(Offset = "0xC")]
	public List<BundleShowData> bundles;

	[Token(Token = "0x6007BFF")]
	[Address(RVA = "0x317D5F8", Offset = "0x317D5F8", VA = "0x317D5F8")]
	public BundleShow()
	{
	}
}
