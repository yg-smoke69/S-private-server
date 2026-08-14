using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x2003F3D")]
public class DynamicGenerator : MonoBehaviour
{
	[Token(Token = "0x2003F3E")]
	public enum DDBKGEBAIHM
	{
		[Token(Token = "0x401AA78")]
		Type_Generic,
		[Token(Token = "0x401AA79")]
		Type_Grass,
		[Token(Token = "0x401AA7A")]
		Type_Tree,
		[Token(Token = "0x401AA7B")]
		Type_Stone,
		[Token(Token = "0x401AA7C")]
		Type_Billboard,
		[Token(Token = "0x401AA7D")]
		Type_StaticEnv,
		[Token(Token = "0x401AA7E")]
		Type_Pumpkin,
		[Token(Token = "0x401AA7F")]
		Type_Total
	}

	[Token(Token = "0x401AA74")]
	[FieldOffset(Offset = "0xC")]
	public DDBKGEBAIHM m_type;

	[Token(Token = "0x401AA75")]
	[FieldOffset(Offset = "0x10")]
	public bool m_streamCollider;

	[Token(Token = "0x401AA76")]
	[FieldOffset(Offset = "0x11")]
	public bool m_isExclude;

	[Token(Token = "0x6019C3B")]
	[Address(RVA = "0x25A85C8", Offset = "0x25A85C8", VA = "0x25A85C8")]
	public DynamicGenerator()
	{
	}
}
