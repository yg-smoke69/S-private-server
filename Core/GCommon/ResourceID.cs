using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040E8")]
public struct ResourceID : _Attribute
{
	[Token(Token = "0x401B45C")]
	[FieldOffset(Offset = "0x0")]
	private readonly uint m_Value;

	[Token(Token = "0x401B45D")]
	[FieldOffset(Offset = "0x0")]
	public static readonly ResourceID INVALID;

	[Token(Token = "0x601A73E")]
	[Address(RVA = "0x93F964", Offset = "0x93F964", VA = "0x93F964")]
	private ResourceID(uint value)
	{
	}

	[Token(Token = "0x601A73F")]
	[Address(RVA = "0x3300C34", Offset = "0x3300C34", VA = "0x3300C34")]
	public static implicit operator uint(ResourceID id)
	{
		return default(uint);
	}

	[Token(Token = "0x601A740")]
	[Address(RVA = "0x3300C38", Offset = "0x3300C38", VA = "0x3300C38")]
	public static implicit operator ResourceID(uint value)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601A741")]
	[Address(RVA = "0x3300C3C", Offset = "0x3300C3C", VA = "0x3300C3C")]
	public static bool operator ==(ResourceID a, ResourceID b)
	{
		return default(bool);
	}

	[Token(Token = "0x601A742")]
	[Address(RVA = "0x3300C50", Offset = "0x3300C50", VA = "0x3300C50")]
	public static bool operator !=(ResourceID a, ResourceID b)
	{
		return default(bool);
	}

	[Token(Token = "0x601A743")]
	[Address(RVA = "0x93F96C", Offset = "0x93F96C", VA = "0x93F96C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x601A744")]
	[Address(RVA = "0x93F994", Offset = "0x93F994", VA = "0x93F994", Slot = "4")]
	public bool Equals(ResourceID other)
	{
		return default(bool);
	}

	[Token(Token = "0x601A745")]
	[Address(RVA = "0x93F9A8", Offset = "0x93F9A8", VA = "0x93F9A8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x601A746")]
	[Address(RVA = "0x93F9B0", Offset = "0x93F9B0", VA = "0x93F9B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
