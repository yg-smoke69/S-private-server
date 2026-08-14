using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B4B")]
internal struct ObjectMetadata
{
	[Token(Token = "0x4019403")]
	[FieldOffset(Offset = "0x0")]
	private Type element_type;

	[Token(Token = "0x4019404")]
	[FieldOffset(Offset = "0x4")]
	private bool is_dictionary;

	[Token(Token = "0x4019405")]
	[FieldOffset(Offset = "0x8")]
	private IDictionary<string, PropertyMetadata> properties;

	[Token(Token = "0x170017FF")]
	public Type ElementType
	{
		[Token(Token = "0x6017948")]
		[Address(RVA = "0x93D100", Offset = "0x93D100", VA = "0x93D100")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017949")]
		[Address(RVA = "0x93D108", Offset = "0x93D108", VA = "0x93D108")]
		set
		{
		}
	}

	[Token(Token = "0x17001800")]
	public bool IsDictionary
	{
		[Token(Token = "0x601794A")]
		[Address(RVA = "0x93D110", Offset = "0x93D110", VA = "0x93D110")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601794B")]
		[Address(RVA = "0x93D118", Offset = "0x93D118", VA = "0x93D118")]
		set
		{
		}
	}

	[Token(Token = "0x17001801")]
	public IDictionary<string, PropertyMetadata> Properties
	{
		[Token(Token = "0x601794C")]
		[Address(RVA = "0x93D120", Offset = "0x93D120", VA = "0x93D120")]
		get
		{
			return null;
		}
		[Token(Token = "0x601794D")]
		[Address(RVA = "0x93D128", Offset = "0x93D128", VA = "0x93D128")]
		set
		{
		}
	}
}
