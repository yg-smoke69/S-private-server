using System;
using Il2CppDummyDll;

namespace Unity.IL2CPP.CompilerServices;

[Token(Token = "0x2003D02")]
public class Il2CppSetOptionAttribute : Attribute
{
	[Token(Token = "0x4019E58")]
	[FieldOffset(Offset = "0x8")]
	private Option _003COption_003Ek__BackingField;

	[Token(Token = "0x4019E59")]
	[FieldOffset(Offset = "0xC")]
	private object _003CValue_003Ek__BackingField;

	[Token(Token = "0x170019C7")]
	public Option Option
	{
		[Token(Token = "0x60186DD")]
		[Address(RVA = "0x2A638B0", Offset = "0x2A638B0", VA = "0x2A638B0")]
		get
		{
			return default(Option);
		}
		[Token(Token = "0x60186DE")]
		[Address(RVA = "0x2A638A0", Offset = "0x2A638A0", VA = "0x2A638A0")]
		private set
		{
		}
	}

	[Token(Token = "0x170019C8")]
	public object Value
	{
		[Token(Token = "0x60186DF")]
		[Address(RVA = "0x2A638B8", Offset = "0x2A638B8", VA = "0x2A638B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60186E0")]
		[Address(RVA = "0x2A638A8", Offset = "0x2A638A8", VA = "0x2A638A8")]
		private set
		{
		}
	}

	[Token(Token = "0x60186DC")]
	[Address(RVA = "0x2A63878", Offset = "0x2A63878", VA = "0x2A63878")]
	public Il2CppSetOptionAttribute(Option option, object value)
	{
	}
}
