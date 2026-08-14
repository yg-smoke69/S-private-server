using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Serializable]
[Token(Token = "0x2003290")]
public class ToggleRuleSetting : _Attribute
{
	[NonSerialized]
	[Token(Token = "0x401341B")]
	[FieldOffset(Offset = "0x8")]
	public bool Value;

	[NonSerialized]
	[Token(Token = "0x401341C")]
	[FieldOffset(Offset = "0x9")]
	public bool Enabled;

	[Token(Token = "0x401341D")]
	[FieldOffset(Offset = "0xC")]
	public string TitleID;

	[Token(Token = "0x401341E")]
	[FieldOffset(Offset = "0x10")]
	public bool HasTip;

	[Token(Token = "0x401341F")]
	[FieldOffset(Offset = "0x14")]
	public string TipID;

	[Token(Token = "0x4013420")]
	[FieldOffset(Offset = "0x18")]
	public bool DefaultValue;

	[Token(Token = "0x6015531")]
	[Address(RVA = "0x28ADD08", Offset = "0x28ADD08", VA = "0x28ADD08")]
	public ToggleRuleSetting()
	{
	}

	[Token(Token = "0x6015532")]
	[Address(RVA = "0x28ADD10", Offset = "0x28ADD10", VA = "0x28ADD10")]
	public ToggleRuleSetting Clone()
	{
		return null;
	}
}
