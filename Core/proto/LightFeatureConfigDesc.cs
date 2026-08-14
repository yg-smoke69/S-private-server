using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B6B")]
public class LightFeatureConfigDesc
{
	[Token(Token = "0x400AC81")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400AC82")]
	[FieldOffset(Offset = "0xC")]
	public bool enable;

	[Token(Token = "0x60081C6")]
	[Address(RVA = "0x30A4594", Offset = "0x30A4594", VA = "0x30A4594")]
	public LightFeatureConfigDesc()
	{
	}
}
