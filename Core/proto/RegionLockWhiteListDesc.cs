using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A02")]
public class RegionLockWhiteListDesc
{
	[Token(Token = "0x400A322")]
	[FieldOffset(Offset = "0x8")]
	public string ip;

	[Token(Token = "0x400A323")]
	[FieldOffset(Offset = "0xC")]
	public string lock_region;

	[Token(Token = "0x600805A")]
	[Address(RVA = "0x33E14FC", Offset = "0x33E14FC", VA = "0x33E14FC")]
	public RegionLockWhiteListDesc()
	{
	}
}
