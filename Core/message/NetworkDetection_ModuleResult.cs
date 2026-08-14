using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001C42")]
public class NetworkDetection_ModuleResult
{
	[Token(Token = "0x400B419")]
	[FieldOffset(Offset = "0x8")]
	public string module_name;

	[Token(Token = "0x400B41A")]
	[FieldOffset(Offset = "0xC")]
	public NetworkDetection_IPResult[] test_results;

	[Token(Token = "0x6008299")]
	[Address(RVA = "0x364D8F8", Offset = "0x364D8F8", VA = "0x364D8F8")]
	public NetworkDetection_ModuleResult()
	{
	}
}
