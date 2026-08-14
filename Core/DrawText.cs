using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A6A")]
public class DrawText : MonoBehaviour
{
	[Token(Token = "0x4005C32")]
	[FieldOffset(Offset = "0xC")]
	public Transform m_Transform;

	[Token(Token = "0x4005C33")]
	[FieldOffset(Offset = "0x10")]
	public string m_Text;

	[Token(Token = "0x4005C34")]
	[FieldOffset(Offset = "0x14")]
	public bool m_ShowLabel;

	[Token(Token = "0x4005C35")]
	[FieldOffset(Offset = "0x18")]
	public Color m_Color;

	[Token(Token = "0x600508D")]
	[Address(RVA = "0x23246E4", Offset = "0x23246E4", VA = "0x23246E4")]
	public DrawText()
	{
	}

	[Token(Token = "0x600508E")]
	[Address(RVA = "0x2324780", Offset = "0x2324780", VA = "0x2324780")]
	private void Reset()
	{
	}
}
