using Il2CppDummyDll;
using UnityEngine;

namespace ReactUI;

[Token(Token = "0x2000CE2")]
public sealed class VariableNameAttribute : PropertyAttribute
{
	[Token(Token = "0x400685B")]
	[FieldOffset(Offset = "0xC")]
	private int m_typeMask;

	[Token(Token = "0x60061C2")]
	[Address(RVA = "0x316A928", Offset = "0x316A928", VA = "0x316A928")]
	public VariableNameAttribute()
	{
	}

	[Token(Token = "0x60061C3")]
	[Address(RVA = "0x316A948", Offset = "0x316A948", VA = "0x316A948")]
	public VariableNameAttribute(UIVariableType t1)
	{
	}

	[Token(Token = "0x60061C4")]
	[Address(RVA = "0x316A974", Offset = "0x316A974", VA = "0x316A974")]
	public VariableNameAttribute(UIVariableType t1, UIVariableType t2)
	{
	}

	[Token(Token = "0x60061C5")]
	[Address(RVA = "0x316A9AC", Offset = "0x316A9AC", VA = "0x316A9AC")]
	public VariableNameAttribute(UIVariableType t1, UIVariableType t2, UIVariableType t3)
	{
	}

	[Token(Token = "0x60061C6")]
	[Address(RVA = "0x316A9F0", Offset = "0x316A9F0", VA = "0x316A9F0")]
	public VariableNameAttribute(UIVariableType t1, UIVariableType t2, UIVariableType t3, UIVariableType t4)
	{
	}

	[Token(Token = "0x60061C7")]
	[Address(RVA = "0x316AA40", Offset = "0x316AA40", VA = "0x316AA40")]
	public VariableNameAttribute(UIVariableType t1, UIVariableType t2, UIVariableType t3, UIVariableType t4, UIVariableType t5)
	{
	}

	[Token(Token = "0x60061C8")]
	[Address(RVA = "0x316AA9C", Offset = "0x316AA9C", VA = "0x316AA9C")]
	public bool IsValid(UIVariableType type)
	{
		return default(bool);
	}
}
