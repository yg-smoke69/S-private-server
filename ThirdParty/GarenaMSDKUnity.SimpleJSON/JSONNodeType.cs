using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON;

[Token(Token = "0x2000015")]
public enum JSONNodeType
{
	[Token(Token = "0x40000EB")]
	Array = 1,
	[Token(Token = "0x40000EC")]
	Object = 2,
	[Token(Token = "0x40000ED")]
	String = 3,
	[Token(Token = "0x40000EE")]
	Number = 4,
	[Token(Token = "0x40000EF")]
	NullValue = 5,
	[Token(Token = "0x40000F0")]
	Boolean = 6,
	[Token(Token = "0x40000F1")]
	None = 7,
	[Token(Token = "0x40000F2")]
	Custom = 255
}
