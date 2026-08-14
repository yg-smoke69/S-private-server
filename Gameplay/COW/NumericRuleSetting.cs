using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Serializable]
[Token(Token = "0x200328F")]
public class NumericRuleSetting : _Attribute
{
	[NonSerialized]
	[Token(Token = "0x4013414")]
	[FieldOffset(Offset = "0x8")]
	public float Value;

	[NonSerialized]
	[Token(Token = "0x4013415")]
	[FieldOffset(Offset = "0xC")]
	public bool Enabled;

	[Token(Token = "0x4013416")]
	[FieldOffset(Offset = "0x10")]
	public string TitleID;

	[Token(Token = "0x4013417")]
	[FieldOffset(Offset = "0x14")]
	public float MaxValue;

	[Token(Token = "0x4013418")]
	[FieldOffset(Offset = "0x18")]
	public float MinValue;

	[Token(Token = "0x4013419")]
	[FieldOffset(Offset = "0x1C")]
	public float DefaultValue;

	[Token(Token = "0x401341A")]
	[FieldOffset(Offset = "0x20")]
	public float Step;

	[Token(Token = "0x601552F")]
	[Address(RVA = "0x28BB354", Offset = "0x28BB354", VA = "0x28BB354")]
	public NumericRuleSetting()
	{
	}

	[Token(Token = "0x6015530")]
	[Address(RVA = "0x28BB35C", Offset = "0x28BB35C", VA = "0x28BB35C")]
	public NumericRuleSetting Clone()
	{
		return null;
	}
}
