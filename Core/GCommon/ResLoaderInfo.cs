using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040D3")]
public class ResLoaderInfo
{
	[Token(Token = "0x401B3B8")]
	[FieldOffset(Offset = "0x8")]
	public ResFileLoader Loader;

	[Token(Token = "0x401B3B9")]
	[FieldOffset(Offset = "0xC")]
	public bool IsUnZip;

	[Token(Token = "0x601A649")]
	[Address(RVA = "0x32E82AC", Offset = "0x32E82AC", VA = "0x32E82AC")]
	public ResLoaderInfo()
	{
	}
}
