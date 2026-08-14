using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001C3F")]
public class NetworkDetection_ModuleSetting
{
	[Token(Token = "0x400B40F")]
	[FieldOffset(Offset = "0x8")]
	public string module_name;

	[Token(Token = "0x400B410")]
	[FieldOffset(Offset = "0xC")]
	public string[] ip_list;

	[Token(Token = "0x6008296")]
	[Address(RVA = "0x364D900", Offset = "0x364D900", VA = "0x364D900")]
	public NetworkDetection_ModuleSetting()
	{
	}
}
