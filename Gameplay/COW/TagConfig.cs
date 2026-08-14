using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002E8D")]
public class TagConfig
{
	[Token(Token = "0x4011C5F")]
	[FieldOffset(Offset = "0x8")]
	public Color color;

	[Token(Token = "0x4011C60")]
	[FieldOffset(Offset = "0x18")]
	public string text;

	[Token(Token = "0x60136C7")]
	[Address(RVA = "0x2893D5C", Offset = "0x2893D5C", VA = "0x2893D5C")]
	public TagConfig(Color color, string text)
	{
	}
}
