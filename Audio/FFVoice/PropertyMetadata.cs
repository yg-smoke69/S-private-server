using System;
using System.Reflection;
using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B49")]
internal struct PropertyMetadata
{
	[Token(Token = "0x40193FD")]
	[FieldOffset(Offset = "0x0")]
	public MemberInfo Info;

	[Token(Token = "0x40193FE")]
	[FieldOffset(Offset = "0x4")]
	public bool IsField;

	[Token(Token = "0x40193FF")]
	[FieldOffset(Offset = "0x8")]
	public Type Type;
}
