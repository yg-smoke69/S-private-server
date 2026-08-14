using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001C40")]
public class HTTP_NetworkDetection_GetSettings_Res
{
	[Token(Token = "0x400B411")]
	[FieldOffset(Offset = "0x8")]
	public string status;

	[Token(Token = "0x400B412")]
	[FieldOffset(Offset = "0xC")]
	public NetworkDetection_ModuleSetting[] settings;

	[Token(Token = "0x6008297")]
	[Address(RVA = "0x36148E8", Offset = "0x36148E8", VA = "0x36148E8")]
	public HTTP_NetworkDetection_GetSettings_Res()
	{
	}
}
