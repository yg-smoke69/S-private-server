using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000090")]
public class PropertyData
{
	[Token(Token = "0x400031B")]
	[FieldOffset(Offset = "0x8")]
	public ResourceID m_PropIDRight;

	[Token(Token = "0x400031C")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID m_PropIDLeft;

	[Token(Token = "0x400031D")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID m_PropIDRoot;

	[Token(Token = "0x400031E")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID m_PropIDHead;

	[Token(Token = "0x400031F")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 m_PropLeftScale;

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x196A758", Offset = "0x196A758", VA = "0x196A758")]
	public PropertyData()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x196A868", Offset = "0x196A868", VA = "0x196A868")]
	public PropertyData(ResourceID pLeft, ResourceID pRight, ResourceID pRoot, ResourceID pHead, [Optional] Vector3 pLeftScale)
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x196AA2C", Offset = "0x196AA2C", VA = "0x196AA2C")]
	public bool Valid()
	{
		return default(bool);
	}
}
