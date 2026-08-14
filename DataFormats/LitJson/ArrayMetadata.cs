using System;
using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B79")]
internal struct ArrayMetadata
{
	[Token(Token = "0x4019567")]
	[FieldOffset(Offset = "0x0")]
	private Type element_type;

	[Token(Token = "0x4019568")]
	[FieldOffset(Offset = "0x4")]
	private bool is_array;

	[Token(Token = "0x4019569")]
	[FieldOffset(Offset = "0x5")]
	private bool is_list;

	[Token(Token = "0x1700184E")]
	public Type ElementType
	{
		[Token(Token = "0x6017B30")]
		[Address(RVA = "0x93DDEC", Offset = "0x93DDEC", VA = "0x93DDEC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017B31")]
		[Address(RVA = "0x93DDF4", Offset = "0x93DDF4", VA = "0x93DDF4")]
		set
		{
		}
	}

	[Token(Token = "0x1700184F")]
	public bool IsArray
	{
		[Token(Token = "0x6017B32")]
		[Address(RVA = "0x93DDFC", Offset = "0x93DDFC", VA = "0x93DDFC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017B33")]
		[Address(RVA = "0x93DE04", Offset = "0x93DE04", VA = "0x93DE04")]
		set
		{
		}
	}

	[Token(Token = "0x17001850")]
	public bool IsList
	{
		[Token(Token = "0x6017B34")]
		[Address(RVA = "0x93DE0C", Offset = "0x93DE0C", VA = "0x93DE0C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017B35")]
		[Address(RVA = "0x93DE14", Offset = "0x93DE14", VA = "0x93DE14")]
		set
		{
		}
	}
}
