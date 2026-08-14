using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B00")]
public class SamoAIThresholdDesc
{
	[Token(Token = "0x400A9DD")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A9DE")]
	[FieldOffset(Offset = "0xC")]
	public uint threshold;

	[Token(Token = "0x600815B")]
	[Address(RVA = "0x33E1E38", Offset = "0x33E1E38", VA = "0x33E1E38")]
	public SamoAIThresholdDesc()
	{
	}
}
