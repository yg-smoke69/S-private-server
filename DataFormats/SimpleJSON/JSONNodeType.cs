using Il2CppDummyDll;

namespace SimpleJSON;

[Token(Token = "0x2003FE6")]
public enum JSONNodeType
{
	[Token(Token = "0x401AE83")]
	Array = 1,
	[Token(Token = "0x401AE84")]
	Object = 2,
	[Token(Token = "0x401AE85")]
	String = 3,
	[Token(Token = "0x401AE86")]
	Number = 4,
	[Token(Token = "0x401AE87")]
	NullValue = 5,
	[Token(Token = "0x401AE88")]
	Boolean = 6,
	[Token(Token = "0x401AE89")]
	None = 7,
	[Token(Token = "0x401AE8A")]
	Custom = 255
}
