using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B01")]
public class UGCDebugModeThresholdDesc
{
	[Token(Token = "0x400A9DF")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A9E0")]
	[FieldOffset(Offset = "0xC")]
	public uint threshold;

	[Token(Token = "0x600815C")]
	[Address(RVA = "0x33E3DB8", Offset = "0x33E3DB8", VA = "0x33E3DB8")]
	public UGCDebugModeThresholdDesc()
	{
	}
}
