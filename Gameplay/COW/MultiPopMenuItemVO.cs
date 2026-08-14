using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029D4")]
internal class MultiPopMenuItemVO
{
	[Token(Token = "0x4010135")]
	[FieldOffset(Offset = "0x8")]
	public Transform m_Transform;

	[Token(Token = "0x4010136")]
	[FieldOffset(Offset = "0xC")]
	public UIWidget m_Widget;

	[Token(Token = "0x4010137")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Offset;

	[Token(Token = "0x4010138")]
	[FieldOffset(Offset = "0x1C")]
	public object m_Data;

	[Token(Token = "0x6010D3B")]
	[Address(RVA = "0x2290090", Offset = "0x2290090", VA = "0x2290090")]
	public MultiPopMenuItemVO()
	{
	}
}
