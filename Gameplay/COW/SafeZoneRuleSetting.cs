using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Serializable]
[Token(Token = "0x2003297")]
public class SafeZoneRuleSetting : _Attribute
{
	[NonSerialized]
	[Token(Token = "0x4013436")]
	[FieldOffset(Offset = "0x8")]
	public float Value;

	[NonSerialized]
	[Token(Token = "0x4013437")]
	[FieldOffset(Offset = "0xC")]
	public bool Enabled;

	[Token(Token = "0x4013438")]
	[FieldOffset(Offset = "0x10")]
	public string TitleID;

	[Token(Token = "0x4013439")]
	[FieldOffset(Offset = "0x14")]
	public float MaxValue;

	[Token(Token = "0x401343A")]
	[FieldOffset(Offset = "0x18")]
	public float MinValue;

	[Token(Token = "0x401343B")]
	[FieldOffset(Offset = "0x1C")]
	public float DefaultValue;

	[Token(Token = "0x401343C")]
	[FieldOffset(Offset = "0x20")]
	public float MaxCircleSize;

	[Token(Token = "0x401343D")]
	[FieldOffset(Offset = "0x24")]
	public float MinCircleSize;

	[Token(Token = "0x6015545")]
	[Address(RVA = "0x241DF0C", Offset = "0x241DF0C", VA = "0x241DF0C")]
	public SafeZoneRuleSetting()
	{
	}

	[Token(Token = "0x6015546")]
	[Address(RVA = "0x241DF14", Offset = "0x241DF14", VA = "0x241DF14")]
	public SafeZoneRuleSetting Clone()
	{
		return null;
	}
}
