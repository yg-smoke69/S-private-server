using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B7A")]
internal struct ObjectMetadata
{
	[Token(Token = "0x401956A")]
	[FieldOffset(Offset = "0x0")]
	private Type element_type;

	[Token(Token = "0x401956B")]
	[FieldOffset(Offset = "0x4")]
	private bool is_dictionary;

	[Token(Token = "0x401956C")]
	[FieldOffset(Offset = "0x8")]
	private IDictionary<string, PropertyMetadata> properties;

	[Token(Token = "0x17001851")]
	public Type ElementType
	{
		[Token(Token = "0x6017B36")]
		[Address(RVA = "0x93C260", Offset = "0x93C260", VA = "0x93C260")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017B37")]
		[Address(RVA = "0x93C268", Offset = "0x93C268", VA = "0x93C268")]
		set
		{
		}
	}

	[Token(Token = "0x17001852")]
	public bool IsDictionary
	{
		[Token(Token = "0x6017B38")]
		[Address(RVA = "0x93C270", Offset = "0x93C270", VA = "0x93C270")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017B39")]
		[Address(RVA = "0x93C278", Offset = "0x93C278", VA = "0x93C278")]
		set
		{
		}
	}

	[Token(Token = "0x17001853")]
	public IDictionary<string, PropertyMetadata> Properties
	{
		[Token(Token = "0x6017B3A")]
		[Address(RVA = "0x93C280", Offset = "0x93C280", VA = "0x93C280")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017B3B")]
		[Address(RVA = "0x93C288", Offset = "0x93C288", VA = "0x93C288")]
		set
		{
		}
	}
}
