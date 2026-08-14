using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B1B")]
public class GracePeriodDesc
{
	[Token(Token = "0x400AA69")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400AA6A")]
	[FieldOffset(Offset = "0xC")]
	public uint max_abuse;

	[Token(Token = "0x6008176")]
	[Address(RVA = "0x30A2CA4", Offset = "0x30A2CA4", VA = "0x30A2CA4")]
	public GracePeriodDesc()
	{
	}
}
