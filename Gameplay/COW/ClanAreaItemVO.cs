using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002529")]
internal class ClanAreaItemVO
{
	[Token(Token = "0x400E66B")]
	[FieldOffset(Offset = "0x8")]
	public Transform m_Transform;

	[Token(Token = "0x400E66C")]
	[FieldOffset(Offset = "0xC")]
	public UIWidget m_Widget;

	[Token(Token = "0x400E66D")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Offset;

	[Token(Token = "0x400E66E")]
	[FieldOffset(Offset = "0x1C")]
	public object m_Data;

	[Token(Token = "0x600D81E")]
	[Address(RVA = "0x1726ADC", Offset = "0x1726ADC", VA = "0x1726ADC")]
	public ClanAreaItemVO()
	{
	}
}
