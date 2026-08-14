using System;
using System.Reflection;
using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B78")]
internal struct PropertyMetadata
{
	[Token(Token = "0x4019564")]
	[FieldOffset(Offset = "0x0")]
	public MemberInfo Info;

	[Token(Token = "0x4019565")]
	[FieldOffset(Offset = "0x4")]
	public bool IsField;

	[Token(Token = "0x4019566")]
	[FieldOffset(Offset = "0x8")]
	public Type Type;
}
